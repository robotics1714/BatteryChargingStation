<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Charger1 = New System.Windows.Forms.ProgressBar()
        Me.Charger2 = New System.Windows.Forms.ProgressBar()
        Me.Charger3 = New System.Windows.Forms.ProgressBar()
        Me.Charger4 = New System.Windows.Forms.ProgressBar()
        Me.Charger5 = New System.Windows.Forms.ProgressBar()
        Me.Charger6 = New System.Windows.Forms.ProgressBar()
        Me.TurnOn = New System.Windows.Forms.Button()
        Me.TurnOff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Charger1
        '
        Me.Charger1.Location = New System.Drawing.Point(12, 12)
        Me.Charger1.Name = "Charger1"
        Me.Charger1.Size = New System.Drawing.Size(164, 23)
        Me.Charger1.TabIndex = 0
        '
        'Charger2
        '
        Me.Charger2.Location = New System.Drawing.Point(13, 42)
        Me.Charger2.Name = "Charger2"
        Me.Charger2.Size = New System.Drawing.Size(163, 23)
        Me.Charger2.TabIndex = 1
        '
        'Charger3
        '
        Me.Charger3.Location = New System.Drawing.Point(13, 72)
        Me.Charger3.Name = "Charger3"
        Me.Charger3.Size = New System.Drawing.Size(163, 23)
        Me.Charger3.TabIndex = 2
        '
        'Charger4
        '
        Me.Charger4.Location = New System.Drawing.Point(13, 102)
        Me.Charger4.Name = "Charger4"
        Me.Charger4.Size = New System.Drawing.Size(163, 23)
        Me.Charger4.TabIndex = 3
        '
        'Charger5
        '
        Me.Charger5.Location = New System.Drawing.Point(13, 132)
        Me.Charger5.Name = "Charger5"
        Me.Charger5.Size = New System.Drawing.Size(163, 23)
        Me.Charger5.TabIndex = 4
        '
        'Charger6
        '
        Me.Charger6.Location = New System.Drawing.Point(13, 162)
        Me.Charger6.Name = "Charger6"
        Me.Charger6.Size = New System.Drawing.Size(163, 23)
        Me.Charger6.TabIndex = 5
        '
        'TurnOn
        '
        Me.TurnOn.Location = New System.Drawing.Point(260, 11)
        Me.TurnOn.Name = "TurnOn"
        Me.TurnOn.Size = New System.Drawing.Size(75, 23)
        Me.TurnOn.TabIndex = 6
        Me.TurnOn.Text = "Turn On"
        Me.TurnOn.UseVisualStyleBackColor = True
        '
        'TurnOff
        '
        Me.TurnOff.Location = New System.Drawing.Point(369, 11)
        Me.TurnOff.Name = "TurnOff"
        Me.TurnOff.Size = New System.Drawing.Size(75, 23)
        Me.TurnOff.TabIndex = 7
        Me.TurnOff.Text = "Turn Off"
        Me.TurnOff.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 324)
        Me.Controls.Add(Me.TurnOff)
        Me.Controls.Add(Me.TurnOn)
        Me.Controls.Add(Me.Charger6)
        Me.Controls.Add(Me.Charger5)
        Me.Controls.Add(Me.Charger4)
        Me.Controls.Add(Me.Charger3)
        Me.Controls.Add(Me.Charger2)
        Me.Controls.Add(Me.Charger1)
        Me.Name = "Form1"
        Me.Text = "Battery Charging Station Controls"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Charger1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger3 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger4 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger5 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger6 As System.Windows.Forms.ProgressBar
    Friend WithEvents TurnOn As System.Windows.Forms.Button
    Friend WithEvents TurnOff As System.Windows.Forms.Button

End Class
