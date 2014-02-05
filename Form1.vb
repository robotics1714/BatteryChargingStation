Imports Pololu.UsbWrapper
Imports Pololu.Usc

Public Class Form1
    Dim controller As Usc 'Represents the Pololu controller
    Dim inputs() As Pololu.Usc.ServoStatus 'Represents each port on the Pololu controller
    Dim chargerOn(6) As Boolean 'Holds whether the charger are on or off

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

        'Turn all of the chargers of
        For i As Integer = 0 To 5
            chargerOn(i) = False
        Next
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

        'If the batteries are 100% charged, set charged on to false otherwise set it to true
        For i As Integer = 0 To 5
            'Check to see if the current charger is on so the program doesn't turn on a charger
            'that should be off
            If percentCharge(i) < 1 And chargerOn(i) = True Then
                chargerOn(i) = True
            Else
                chargerOn(i) = False
            End If
        Next

        'Turn the chargers on or off
        If chargerOn(0) = True Then 'Charger 1
            controller.setTarget(6, 1500 * 4)
            OnOffLbl1.Text = "On"
        Else
            controller.setTarget(6, 0)
            OnOffLbl1.Text = "Off"
            BatteryLbl1.Text = "0"
        End If
        If chargerOn(1) = True Then 'Charger 2
            controller.setTarget(7, 1500 * 4)
            OnOffLbl2.Text = "On"
        Else
            controller.setTarget(7, 0)
            OnOffLbl2.Text = "Off"
            BatteryLbl2.Text = "0"
        End If
        If chargerOn(2) = True Then 'Charger 3
            controller.setTarget(8, 1500 * 4)
            OnOffLbl3.Text = "On"
        Else
            controller.setTarget(8, 0)
            OnOffLbl3.Text = "Off"
            BatteryLbl3.Text = "0"
        End If
        If chargerOn(3) = True Then 'Charger 4
            controller.setTarget(9, 1500 * 4)
            OnOffLbl4.Text = "On"
        Else
            controller.setTarget(9, 0)
            OnOffLbl4.Text = "Off"
            BatteryLbl4.Text = "0"
        End If
        If chargerOn(4) = True Then 'Charger 5
            controller.setTarget(10, 1500 * 4)
            OnOffLbl5.Text = "On"
        Else
            controller.setTarget(10, 0)
            OnOffLbl5.Text = "Off"
            BatteryLbl5.Text = "0"
        End If
        If chargerOn(5) = True Then 'Charger 6
            controller.setTarget(11, 1500 * 4)
            OnOffLbl6.Text = "On"
        Else
            controller.setTarget(11, 0)
            OnOffLbl6.Text = "Off"
            BatteryLbl6.Text = "0"
        End If

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

    Private Function GetBatteryNum() As String
        'Ask for a number and don't return anything unless the value is a number or the user hit cancel
        Dim input As String = "invalid" 'Set the input to an invalid value 

        'Go through the loop until something is returned from the function
        While True
            'Get the battery number from the user
            input = InputBox("What battery is this?", "Which Battery?", "0")
            'If the user hit cancel or if the input is valid, return input
            If input.Length = 0 Or IsNumeric(input) Then
                Return input
            Else
                'If the input was not valid, say so
                MsgBox("Invalid Input")
            End If

        End While

        Return "0"
    End Function

    'When the on buttons are pressed, ask for the battery number
    Private Sub OnBtn1_Click(sender As Object, e As EventArgs) Handles OnBtn1.Click
        Dim input As String = GetBatteryNum()

        'Change the battery number if the user did not hit cancel and turn on the charger
        If input.Length <> 0 Then
            BatteryLbl1.Text = input
            chargerOn(0) = True
        End If
    End Sub

    Private Sub OnBtn2_Click(sender As Object, e As EventArgs) Handles OnBtn2.Click
        Dim input As String = GetBatteryNum()

        'Change the battery number if the user did not hit cancel and turn on the charger
        If input.Length <> 0 Then
            BatteryLbl2.Text = input
            chargerOn(1) = True
        End If
    End Sub

    Private Sub OnBtn3_Click(sender As Object, e As EventArgs) Handles OnBtn3.Click
        Dim input As String = GetBatteryNum()

        'Change the battery number if the user did not hit cancel and turn on the charger
        If input.Length <> 0 Then
            BatteryLbl3.Text = input
            chargerOn(2) = True
        End If
    End Sub

    Private Sub OnBtn4_Click(sender As Object, e As EventArgs) Handles OnBtn4.Click
        Dim input As String = GetBatteryNum()

        'Change the battery number if the user did not hit cancel and turn on the charger
        If input.Length <> 0 Then
            BatteryLbl4.Text = input
            chargerOn(3) = True
        End If
    End Sub

    Private Sub OnBtn5_Click(sender As Object, e As EventArgs) Handles OnBtn5.Click
        Dim input As String = GetBatteryNum()

        'Change the battery number if the user did not hit cancel and turn on the charger
        If input.Length <> 0 Then
            BatteryLbl5.Text = input
            chargerOn(4) = True
        End If
    End Sub

    Private Sub OnBtn6_Click(sender As Object, e As EventArgs) Handles OnBtn6.Click
        Dim input As String = GetBatteryNum()

        'Change the battery number if the user did not hit cancel and turn on the charger
        If input.Length <> 0 Then
            BatteryLbl6.Text = input
            chargerOn(5) = True
        End If
    End Sub

    Private Sub OffBtn1_Click(sender As Object, e As EventArgs) Handles OffBtn1.Click
        'Turn off the charger
        BatteryLbl1.Text = "0"
        chargerOn(0) = False
    End Sub

    Private Sub OffBtn2_Click(sender As Object, e As EventArgs) Handles OffBtn2.Click
        'Turn off the charger
        BatteryLbl2.Text = "0"
        chargerOn(1) = False
    End Sub

    Private Sub OffBtn3_Click(sender As Object, e As EventArgs) Handles OffBtn3.Click
        'Turn off the charger
        BatteryLbl3.Text = "0"
        chargerOn(2) = False
    End Sub

    Private Sub OffBtn4_Click(sender As Object, e As EventArgs) Handles OffBtn4.Click
        'Turn off the charger
        BatteryLbl4.Text = "0"
        chargerOn(3) = False
    End Sub

    Private Sub OffBtn5_Click(sender As Object, e As EventArgs) Handles OffBtn5.Click
        'Turn off the charger
        BatteryLbl5.Text = "0"
        chargerOn(4) = False
    End Sub

    Private Sub OffBtn6_Click(sender As Object, e As EventArgs) Handles OffBtn6.Click
        'Turn off the charger
        BatteryLbl6.Text = "0"
        chargerOn(5) = False
    End Sub
End Class