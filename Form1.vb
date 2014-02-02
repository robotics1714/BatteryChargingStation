Imports Pololu.UsbWrapper
Imports Pololu.Usc

Public Class Form1
    Dim pololu As Usc
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connect to the Pololu Device
        Try
            pololu = ConnectToDevice()
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

        Throw New Exception("Could not find Pololu device. Restart the application and try again")
    End Function

    Private Sub TurnOn_Click(sender As Object, e As EventArgs) Handles TurnOn.Click
        'Turn on the relays
        pololu.setTarget(0, 1500 * 4)
        pololu.setTarget(2, 1500 * 4)
        pololu.setTarget(4, 1500 * 4)
        pololu.setTarget(6, 1500 * 4)
    End Sub

    Private Sub TurnOff_Click(sender As Object, e As EventArgs) Handles TurnOff.Click
        'Turn off the relays
        pololu.setTarget(0, 0)
        pololu.setTarget(2, 0)
        pololu.setTarget(4, 0)
        pololu.setTarget(6, 0)
    End Sub
End Class