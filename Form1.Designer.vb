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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Charger1 = New System.Windows.Forms.ProgressBar()
        Me.Charger2 = New System.Windows.Forms.ProgressBar()
        Me.Charger3 = New System.Windows.Forms.ProgressBar()
        Me.Charger4 = New System.Windows.Forms.ProgressBar()
        Me.Charger5 = New System.Windows.Forms.ProgressBar()
        Me.Charger6 = New System.Windows.Forms.ProgressBar()
        Me.TurnOn = New System.Windows.Forms.Button()
        Me.TurnOff = New System.Windows.Forms.Button()
        Me.WaitTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CurrentLbl1 = New System.Windows.Forms.Label()
        Me.CurrentLbl2 = New System.Windows.Forms.Label()
        Me.CurrentLbl3 = New System.Windows.Forms.Label()
        Me.CurrentLbl4 = New System.Windows.Forms.Label()
        Me.CurrentLbl5 = New System.Windows.Forms.Label()
        Me.CurrentLbl6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Charger1
        '
        Me.Charger1.Location = New System.Drawing.Point(13, 29)
        Me.Charger1.Name = "Charger1"
        Me.Charger1.Size = New System.Drawing.Size(164, 23)
        Me.Charger1.TabIndex = 0
        Me.Charger1.Value = 100
        '
        'Charger2
        '
        Me.Charger2.Location = New System.Drawing.Point(12, 75)
        Me.Charger2.Name = "Charger2"
        Me.Charger2.Size = New System.Drawing.Size(163, 23)
        Me.Charger2.TabIndex = 1
        Me.Charger2.Value = 100
        '
        'Charger3
        '
        Me.Charger3.Location = New System.Drawing.Point(12, 121)
        Me.Charger3.Name = "Charger3"
        Me.Charger3.Size = New System.Drawing.Size(163, 23)
        Me.Charger3.TabIndex = 2
        Me.Charger3.Value = 100
        '
        'Charger4
        '
        Me.Charger4.Location = New System.Drawing.Point(12, 167)
        Me.Charger4.Name = "Charger4"
        Me.Charger4.Size = New System.Drawing.Size(163, 23)
        Me.Charger4.TabIndex = 3
        Me.Charger4.Value = 100
        '
        'Charger5
        '
        Me.Charger5.Location = New System.Drawing.Point(13, 213)
        Me.Charger5.Name = "Charger5"
        Me.Charger5.Size = New System.Drawing.Size(163, 23)
        Me.Charger5.TabIndex = 4
        Me.Charger5.Value = 100
        '
        'Charger6
        '
        Me.Charger6.Location = New System.Drawing.Point(12, 259)
        Me.Charger6.Name = "Charger6"
        Me.Charger6.Size = New System.Drawing.Size(163, 23)
        Me.Charger6.TabIndex = 5
        Me.Charger6.Value = 100
        '
        'TurnOn
        '
        Me.TurnOn.Location = New System.Drawing.Point(321, 121)
        Me.TurnOn.Name = "TurnOn"
        Me.TurnOn.Size = New System.Drawing.Size(75, 23)
        Me.TurnOn.TabIndex = 6
        Me.TurnOn.Text = "Turn On"
        Me.TurnOn.UseVisualStyleBackColor = True
        '
        'TurnOff
        '
        Me.TurnOff.Location = New System.Drawing.Point(321, 145)
        Me.TurnOff.Name = "TurnOff"
        Me.TurnOff.Size = New System.Drawing.Size(75, 23)
        Me.TurnOff.TabIndex = 7
        Me.TurnOff.Text = "Turn Off"
        Me.TurnOff.UseVisualStyleBackColor = True
        '
        'WaitTimer
        '
        Me.WaitTimer.Enabled = True
        Me.WaitTimer.Interval = 250
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Charger 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Charger 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Charger 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Charger 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Charger 5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Charger 6"
        '
        'CurrentLbl1
        '
        Me.CurrentLbl1.AutoSize = True
        Me.CurrentLbl1.Location = New System.Drawing.Point(198, 39)
        Me.CurrentLbl1.Name = "CurrentLbl1"
        Me.CurrentLbl1.Size = New System.Drawing.Size(23, 13)
        Me.CurrentLbl1.TabIndex = 14
        Me.CurrentLbl1.Text = "0 A"
        '
        'CurrentLbl2
        '
        Me.CurrentLbl2.AutoSize = True
        Me.CurrentLbl2.Location = New System.Drawing.Point(198, 85)
        Me.CurrentLbl2.Name = "CurrentLbl2"
        Me.CurrentLbl2.Size = New System.Drawing.Size(23, 13)
        Me.CurrentLbl2.TabIndex = 15
        Me.CurrentLbl2.Text = "0 A"
        '
        'CurrentLbl3
        '
        Me.CurrentLbl3.AutoSize = True
        Me.CurrentLbl3.Location = New System.Drawing.Point(198, 131)
        Me.CurrentLbl3.Name = "CurrentLbl3"
        Me.CurrentLbl3.Size = New System.Drawing.Size(23, 13)
        Me.CurrentLbl3.TabIndex = 16
        Me.CurrentLbl3.Text = "0 A"
        '
        'CurrentLbl4
        '
        Me.CurrentLbl4.AutoSize = True
        Me.CurrentLbl4.Location = New System.Drawing.Point(198, 177)
        Me.CurrentLbl4.Name = "CurrentLbl4"
        Me.CurrentLbl4.Size = New System.Drawing.Size(23, 13)
        Me.CurrentLbl4.TabIndex = 17
        Me.CurrentLbl4.Text = "0 A"
        '
        'CurrentLbl5
        '
        Me.CurrentLbl5.AutoSize = True
        Me.CurrentLbl5.Location = New System.Drawing.Point(198, 223)
        Me.CurrentLbl5.Name = "CurrentLbl5"
        Me.CurrentLbl5.Size = New System.Drawing.Size(23, 13)
        Me.CurrentLbl5.TabIndex = 18
        Me.CurrentLbl5.Text = "0 A"
        '
        'CurrentLbl6
        '
        Me.CurrentLbl6.AutoSize = True
        Me.CurrentLbl6.Location = New System.Drawing.Point(198, 269)
        Me.CurrentLbl6.Name = "CurrentLbl6"
        Me.CurrentLbl6.Size = New System.Drawing.Size(23, 13)
        Me.CurrentLbl6.TabIndex = 19
        Me.CurrentLbl6.Text = "0 A"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 324)
        Me.Controls.Add(Me.CurrentLbl6)
        Me.Controls.Add(Me.CurrentLbl5)
        Me.Controls.Add(Me.CurrentLbl4)
        Me.Controls.Add(Me.CurrentLbl3)
        Me.Controls.Add(Me.CurrentLbl2)
        Me.Controls.Add(Me.CurrentLbl1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TurnOff)
        Me.Controls.Add(Me.TurnOn)
        Me.Controls.Add(Me.Charger6)
        Me.Controls.Add(Me.Charger5)
        Me.Controls.Add(Me.Charger4)
        Me.Controls.Add(Me.Charger3)
        Me.Controls.Add(Me.Charger2)
        Me.Controls.Add(Me.Charger1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "FRC Team 1714 Battery Charging Station"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Charger1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger3 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger4 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger5 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger6 As System.Windows.Forms.ProgressBar
    Friend WithEvents TurnOn As System.Windows.Forms.Button
    Friend WithEvents TurnOff As System.Windows.Forms.Button
    Friend WithEvents WaitTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CurrentLbl1 As System.Windows.Forms.Label
    Friend WithEvents CurrentLbl2 As System.Windows.Forms.Label
    Friend WithEvents CurrentLbl3 As System.Windows.Forms.Label
    Friend WithEvents CurrentLbl4 As System.Windows.Forms.Label
    Friend WithEvents CurrentLbl5 As System.Windows.Forms.Label
    Friend WithEvents CurrentLbl6 As System.Windows.Forms.Label

End Class
