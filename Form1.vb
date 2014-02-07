﻿Imports Pololu.UsbWrapper
Imports Pololu.Usc
Imports System.IO

Public Class Form1
    Dim controller As Usc 'Represents the Pololu controller
    Dim inputs() As Pololu.Usc.ServoStatus 'Represents each port on the Pololu controller
    'Variables that will hold the inputs from the chargers
    Dim values(6) As Double
    Dim amps(6) As Double
    'The sum of these to should be 1 because they are opposite
    Dim percentCharge(6) As Double
    Dim percentEmpty(6) As Double
    'Holds whether the charger are on or off
    Dim chargerOn(6) As Boolean
    'Keeps track of how long it was since a charger was turned on
    Dim onTimer(6) As Integer
    'Counts how many times the program read inputs before each UI update
    Dim timesInputsReceived As Integer

    Private Const CONVERSION_VAL As Integer = 202
    Private Const CHARGE_TIME As Integer = 270
    Private Const FILE_PATH As String = "log.txt"
    Private Const CHARGER_ON As Integer = 0
    Private Const CHARGER_OFF As Integer = 1500 * 4

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connect to the Pololu Device
        Try
            controller = ConnectToDevice()
        Catch exception As Exception
            MsgBox(exception.Message)
            Close()
        End Try

        'Create the log file we will be writing to if it is not already there
        If File.Exists(FILE_PATH) = False Then
            File.Create(FILE_PATH)
        End If

        'Turn all of the chargers off and sets all of the elements in the onTimer array to 0
        For i As Integer = 0 To 5
            chargerOn(i) = False
            amps(i) = 0
            onTimer(i) = 0
        Next

        timesInputsReceived = 0
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

    'Grab values from the pololu device periodically
    Private Sub inputTimer_Tick(sender As Object, e As EventArgs) Handles inputTimer.Tick
        'Calculate the voltage from the inputs
        controller.getVariables(inputs)
        For i As Integer = 0 To 5
            'We divide the input by 201 to convert it to the actual voltage
            'The value can theoretically never be less than 2.5
            If (CDbl(inputs(i).position.ToString)) < 550 Then
                values(i) += 550
            Else
                values(i) += CDbl(inputs(i).position.ToString)
            End If
        Next
        timesInputsReceived += 1
    End Sub

    'Update the charger progress bars
    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        'Divide the values by the number of times the inputs were received to get the average
        For i As Integer = 0 To 5
            values(i) /= timesInputsReceived
        Next

        'Calculate the current in amps and how charged the battery is in percent
        For i As Integer = 0 To 6
            'Change the range of the values from 0 to 2.55
            Dim temp As Double = values(i) - 550
            'Get the ratio of the temporary value to 2.55
            Dim ratio As Double = temp / 475
            'The ratio is the same as the percent of the battery that is uncharged
            percentEmpty(i) = ratio
            'Subtract the ratio by 11 to get the percent done because if the ratio is 1
            'that means the battery is fully uncharged.
            percentCharge(i) = 1 - ratio
            'Multiply that by 7.5 (the amount of current it's drawing at 5.06 volts) 
            'and round it to 1 decimal place
            amps(i) = Math.Round(ratio * 15, 1)
        Next

        'If the batteries are 100% charged, set charged on to false otherwise set it to true
        For i As Integer = 0 To 5
            'Check to see if the current charger is on so the program doesn't turn on a charger
            'that should be off
            Dim time As Integer = My.Computer.Clock.TickCount
            If (percentCharge(i) < 1 And chargerOn(i) = True) Or (time - onTimer(i) < 5000) Then
                chargerOn(i) = True
            Else
                chargerOn(i) = False
            End If
        Next

        'Turn the chargers on or off
        If chargerOn(0) = True Then 'Charger 1
            controller.setTarget(6, CHARGER_ON)
            OnOffLbl1.Text = "On"
        Else
            controller.setTarget(6, CHARGER_OFF)
            OnOffLbl1.Text = "Off"
            BatteryLbl1.Text = "0"
        End If
        If chargerOn(1) = True Then 'Charger 2
            controller.setTarget(7, CHARGER_ON)
            OnOffLbl2.Text = "On"
        Else
            controller.setTarget(7, CHARGER_OFF)
            OnOffLbl2.Text = "Off"
            BatteryLbl2.Text = "0"
        End If
        If chargerOn(2) = True Then 'Charger 3
            controller.setTarget(8, CHARGER_ON)
            OnOffLbl3.Text = "On"
        Else
            controller.setTarget(8, CHARGER_OFF)
            OnOffLbl3.Text = "Off"
            BatteryLbl3.Text = "0"
        End If
        If chargerOn(3) = True Then 'Charger 4
            controller.setTarget(9, CHARGER_ON)
            OnOffLbl4.Text = "On"
        Else
            controller.setTarget(9, CHARGER_OFF)
            OnOffLbl4.Text = "Off"
            BatteryLbl4.Text = "0"
        End If
        If chargerOn(4) = True Then 'Charger 5
            controller.setTarget(10, CHARGER_ON)
            OnOffLbl5.Text = "On"
        Else
            controller.setTarget(10, CHARGER_OFF)
            OnOffLbl5.Text = "Off"
            BatteryLbl5.Text = "0"
        End If
        If chargerOn(5) = True Then 'Charger 6
            controller.setTarget(11, CHARGER_ON)
            OnOffLbl6.Text = "On"
        Else
            controller.setTarget(11, CHARGER_OFF)
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
        CurrentLbl1.Text = CStr(amps(0)) + "A"
        CurrentLbl2.Text = CStr(amps(1)) + "A"
        CurrentLbl3.Text = CStr(amps(2)) + "A"
        CurrentLbl4.Text = CStr(amps(3)) + "A"
        CurrentLbl5.Text = CStr(amps(4)) + "A"
        CurrentLbl6.Text = CStr(amps(5)) + "A"

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

        'Reset the values array and the timeInputReceived variable for the next loop
        For i As Integer = 0 To 5
            values(i) = 0
        Next
        timesInputsReceived = 0
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
            onTimer(0) = My.Computer.Clock.TickCount
            chargerOn(0) = True
        End If
    End Sub

    Private Sub OnBtn2_Click(sender As Object, e As EventArgs) Handles OnBtn2.Click
        Dim input As String = GetBatteryNum()

        'Change the battery number if the user did not hit cancel and turn on the charger
        If input.Length <> 0 Then
            BatteryLbl2.Text = input
            onTimer(1) = My.Computer.Clock.TickCount
            chargerOn(1) = True
        End If
    End Sub

    Private Sub OnBtn3_Click(sender As Object, e As EventArgs) Handles OnBtn3.Click
        Dim input As String = GetBatteryNum()

        'Change the battery number if the user did not hit cancel and turn on the charger
        If input.Length <> 0 Then
            BatteryLbl3.Text = input
            onTimer(2) = My.Computer.Clock.TickCount
            chargerOn(2) = True
        End If
    End Sub

    Private Sub OnBtn4_Click(sender As Object, e As EventArgs) Handles OnBtn4.Click
        Dim input As String = GetBatteryNum()

        'Change the battery number if the user did not hit cancel and turn on the charger
        If input.Length <> 0 Then
            BatteryLbl4.Text = input
            onTimer(3) = My.Computer.Clock.TickCount
            chargerOn(3) = True
        End If
    End Sub

    Private Sub OnBtn5_Click(sender As Object, e As EventArgs) Handles OnBtn5.Click
        Dim input As String = GetBatteryNum()

        'Change the battery number if the user did not hit cancel and turn on the charger
        If input.Length <> 0 Then
            BatteryLbl5.Text = input
            onTimer(4) = My.Computer.Clock.TickCount
            chargerOn(4) = True
        End If
    End Sub

    Private Sub OnBtn6_Click(sender As Object, e As EventArgs) Handles OnBtn6.Click
        Dim input As String = GetBatteryNum()

        'Change the battery number if the user did not hit cancel and turn on the charger
        If input.Length <> 0 Then
            BatteryLbl6.Text = input
            onTimer(5) = My.Computer.Clock.TickCount
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

    Private Sub fileWriteTimer_Tick(sender As Object, e As EventArgs) Handles fileWriteTimer.Tick
        'Put the battery data in the a string
        Dim data As String = ""

        'If atleast 1 charger is on, write the time
        For i As Integer = 0 To 5
            If chargerOn(i) = True Then
                data += Date.Now().ToString("ddMMMyyyy") + " " + DateTime.Now.ToLongTimeString() + vbCrLf
                Exit For
            End If
        Next

        'Get data from charger 1
        If chargerOn(0) = True Then
            data += "Charger 1 "
            data += "Battery " + BatteryLbl1.Text + " "
            data += CStr(amps(0)) + "A "
            data += CStr(CInt(percentCharge(0) * 100)) + "% percent charged" + vbCrLf
        End If
        'Get data from charger 2
        If chargerOn(1) = True Then
            data += "Charger 2 "
            data += "Battery " + BatteryLbl2.Text + " "
            data += CStr(amps(1)) + "A "
            data += CStr(CInt(percentCharge(1) * 100)) + "% percent charged" + vbCrLf
        End If
        'Get data from charger 3
        If chargerOn(2) = True Then
            data += "Charger 3 "
            data += "Battery " + BatteryLbl3.Text + " "
            data += CStr(amps(2)) + "A "
            data += CStr(CInt(percentCharge(2) * 100)) + "% percent charged" + vbCrLf
        End If
        'Get data from charger 4
        If chargerOn(3) = True Then
            data += "Charger 4 "
            data += "Battery " + BatteryLbl4.Text + " "
            data += CStr(amps(3)) + "A "
            data += CStr(CInt(percentCharge(3) * 100)) + "% percent charged" + vbCrLf
        End If
        'Get data from charger 5
        If chargerOn(4) = True Then
            data += "Charger 5 "
            data += "Battery " + BatteryLbl5.Text + " "
            data += CStr(amps(4)) + "A "
            data += CStr(CInt(percentCharge(4) * 100)) + "% percent charged" + vbCrLf
        End If
        'Get data from charger 6
        If chargerOn(5) = True Then
            data += "Charger 6 "
            data += "Battery " + BatteryLbl6.Text + " "
            data += CStr(amps(5)) + "A "
            data += CStr(CInt(percentCharge(5) * 100)) + "% percent charged" + vbCrLf
        End If

        'Write the data to a file
        My.Computer.FileSystem.WriteAllText(FILE_PATH, data, True)
    End Sub
End Class