Imports Pololu.UsbWrapper
Imports Pololu.Usc

Public Class Form1
    Dim controller As Usc 'Represents the Pololu controller
    Dim inputs() As Pololu.Usc.ServoStatus 'Represents each port on the Pololu controller

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

    Private Sub TurnOn_Click(sender As Object, e As EventArgs) Handles TurnOn.Click
        'Turn on the relays. You have to multiple the value by 4 for some reason
        controller.setTarget(6, 1500 * 4)
        controller.setTarget(7, 1500 * 4)
        controller.setTarget(8, 1500 * 4)
        controller.setTarget(23, 1500 * 4)
    End Sub

    Private Sub TurnOff_Click(sender As Object, e As EventArgs) Handles TurnOff.Click
        'Turn off the relays
        controller.setTarget(6, 0)
        controller.setTarget(7, 0)
        controller.setTarget(8, 0)
        controller.setTarget(23, 0)
    End Sub
    'Update the charger progress bars
    Private Sub WaitTimer_Tick(sender As Object, e As EventArgs) Handles WaitTimer.Tick
        'Variables that will hold the inputs from the chargers
        Dim values(6) As Double
        Dim percentCharge(6) As Double

        'Calculate the voltage from the inputs
        controller.getVariables(inputs)
        For i As Integer = 0 To 5
            'We divide the input by 201 to convert it to the actual voltage
            'The value can theoretically never be less than 2.5
            If (CDbl(inputs(i).position.ToString) / 201) < 2.55 Then
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
            'Subtract the ratio by 100 to get the percent done because if the ratio is 100
            'that means the battery is fully uncharged.
            percentCharge(i) = 1 - ratio
            'Multiply that by 7.5 (the ammount of current it's drawing at 5.1 volts)
            values(i) = ratio * 7.5
        Next

        'Set the values in the charger progress bars
        Charger1.Value = CInt(percentCharge(0)) * 100
        Charger2.Value = CInt(percentCharge(1)) * 100
        Charger3.Value = CInt(percentCharge(2)) * 100
        Charger4.Value = CInt(percentCharge(3)) * 100
        Charger5.Value = CInt(percentCharge(4)) * 100
        Charger6.Value = CInt(percentCharge(5)) * 100

        'Calculate the amount of current that is being drawn (right now it's not current it's volts)
        CurrentLbl1.Text = CStr(values(0)) + "A"
        CurrentLbl2.Text = CStr(values(1)) + "A"
        CurrentLbl3.Text = CStr(values(2)) + "A"
        CurrentLbl4.Text = CStr(values(3)) + "A"
        CurrentLbl5.Text = CStr(values(4)) + "A"
        CurrentLbl6.Text = CStr(values(5)) + "A"
    End Sub
End Class