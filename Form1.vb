Imports Pololu.UsbWrapper
Imports Pololu.Usc

Public Class Form1
    Dim controller As Usc 'Represents the Pololu controller
    Dim inputs() As Pololu.Usc.ServoStatus 'Represents each port on the Pololu controller

    Private Const CONVERSION_VAL As Integer = 201
    Private Const CHARGE_TIME As Integer = 270

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connect to the Pololu Device
        Try
            controller = ConnectToDevice()
        Catch exception As Exception
            MsgBox(exception.Message)
            Close()
        End Try
    End Sub

    Function ConnectToDevice() As Usc
        'Get a list of all the devices connected to the computer (Should only be 1)
        Dim devices As List(Of DeviceListItem) = Usc.getConnectedDevices()

        For Each dli As DeviceListItem In devices
            Dim device As Usc = New Usc(dli) 'Connect to the device
            Return device 'Return the device
        Next

        'If this function gets p
        Throw New Exception("Could not find Pololu device. Restart the application and try again")
    End Function

    'Update the charger progress bars
    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        'Variables that will hold the inputs from the chargers
        Dim values(6) As Double
        'The sum of these to should be 1 because they are opposite
        Dim percentCharge(6) As Double
        Dim percentEmpty(6) As Double

        'Calculate the voltage from the inputs
        controller.getVariables(inputs)
        For i As Integer = 0 To 5
            'We divide the input by 201 to convert it to the actual voltage
            'The value can theoretically never be less than 2.5
            If (CDbl(inputs(i).position.ToString) / CONVERSION_VAL) < 2.55 Then
                values(i) = 2.55
            Else
                values(i) = CDbl(inputs(i).position.ToString) / 201
            End If
        Next

        'Calculate the current in amps and how charged the battery is in percent
        For i As Integer = 0 To 6
            'Change the range of the values from 0 to 2.55
            Dim temp As Double = values(i) - 2.55
            'Get the ratio of the temporary value to 2.55
            Dim ratio As Double = temp / 2.55
            'The ratio is the same as the percent of the battery that is uncharged
            percentEmpty(i) = ratio
            'Subtract the ratio by 11 to get the percent done because if the ratio is 1
            'that means the battery is fully uncharged.
            percentCharge(i) = 1 - ratio
            'Multiply that by 7.5 (the amount of current it's drawing at 5.1 volts) 
            'and round it to 1 decimal place
            values(i) = Math.Round(ratio * 7.5, 1)
        Next

        'Set the values in the charger progress bars
        Charger1.Value = CInt(percentCharge(0) * 100)
        Charger2.Value = CInt(percentCharge(1) * 100)
        Charger3.Value = CInt(percentCharge(2) * 100)
        Charger4.Value = CInt(percentCharge(3) * 100)
        Charger5.Value = CInt(percentCharge(4) * 100)
        Charger6.Value = CInt(percentCharge(5) * 100)

        'Display the current being drawn
        CurrentLbl1.Text = CStr(values(0)) + "A"
        CurrentLbl2.Text = CStr(values(1)) + "A"
        CurrentLbl3.Text = CStr(values(2)) + "A"
        CurrentLbl4.Text = CStr(values(3)) + "A"
        CurrentLbl5.Text = CStr(values(4)) + "A"
        CurrentLbl6.Text = CStr(values(5)) + "A"

        'Display how charged the battery is in percent
        PercentLbl1.Text = CStr(CInt(percentCharge(0) * 100)) + "% Complete"
        PercentLbl2.Text = CStr(CInt(percentCharge(1) * 100)) + "% Complete"
        PercentLbl3.Text = CStr(CInt(percentCharge(2) * 100)) + "% Complete"
        PercentLbl4.Text = CStr(CInt(percentCharge(3) * 100)) + "% Complete"
        PercentLbl5.Text = CStr(CInt(percentCharge(4) * 100)) + "% Complete"
        PercentLbl6.Text = CStr(CInt(percentCharge(5) * 100)) + "% Complete"

        'Calculate the remaining time. We do this by multiplying the percent charge by the time
        'it takes to charge and empty battery
        ETALbl1.Text = CStr(CInt(percentEmpty(0) * CHARGE_TIME)) + " Minutes"
        ETALbl2.Text = CStr(CInt(percentEmpty(1) * CHARGE_TIME)) + " Minutes"
        ETALbl3.Text = CStr(CInt(percentEmpty(2) * CHARGE_TIME)) + " Minutes"
        ETALbl4.Text = CStr(CInt(percentEmpty(3) * CHARGE_TIME)) + " Minutes"
        ETALbl5.Text = CStr(CInt(percentEmpty(4) * CHARGE_TIME)) + " Minutes"
        ETALbl6.Text = CStr(CInt(percentEmpty(5) * CHARGE_TIME)) + " Minutes"

    End Sub

    'When the on buttons are pressed, ask for the battery number
    Private Sub OnBtn1_Click(sender As Object, e As EventArgs) Handles OnBtn1.Click
        'Keep asking for the battery number until we get valid input
        Dim batteryNum As Integer = 0
        Dim validInput As Boolean = False
        While validInput = False
            Try
                'Get the battery number from the user
                Dim temp As String = InputBox("What battery is this?", "Which Battery?", "0")
                'If the user hit cancel, exit the program
                If temp.Length = 0 Then
                    Return
                End If

                'Convert the string from the input box to a int
                batteryNum = CInt(temp)

                'If the input was valid, exit the loop
                validInput = True
            Catch ex As Exception
                'If the input was invalid, tell the user so
                MsgBox("Invalid Input")
            End Try
        End While

        'Change the battery number to the input
        BatteryLbl1.Text = CStr(batteryNum)
    End Sub
End Class