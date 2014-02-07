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
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
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
        Me.PercentLbl1 = New System.Windows.Forms.Label()
        Me.PercentLbl2 = New System.Windows.Forms.Label()
        Me.PercentLbl3 = New System.Windows.Forms.Label()
        Me.PercentLbl4 = New System.Windows.Forms.Label()
        Me.PercentLbl5 = New System.Windows.Forms.Label()
        Me.PercentLbl6 = New System.Windows.Forms.Label()
        Me.ETA = New System.Windows.Forms.Label()
        Me.ETALbl1 = New System.Windows.Forms.Label()
        Me.ETALbl2 = New System.Windows.Forms.Label()
        Me.ETALbl3 = New System.Windows.Forms.Label()
        Me.ETALbl4 = New System.Windows.Forms.Label()
        Me.ETALbl5 = New System.Windows.Forms.Label()
        Me.ETALbl6 = New System.Windows.Forms.Label()
        Me.Battery = New System.Windows.Forms.Label()
        Me.BatteryLbl1 = New System.Windows.Forms.Label()
        Me.BatteryLbl2 = New System.Windows.Forms.Label()
        Me.BatteryLbl3 = New System.Windows.Forms.Label()
        Me.BatteryLbl4 = New System.Windows.Forms.Label()
        Me.BatteryLbl5 = New System.Windows.Forms.Label()
        Me.BatteryLbl6 = New System.Windows.Forms.Label()
        Me.OnBtn1 = New System.Windows.Forms.Button()
        Me.OffBtn1 = New System.Windows.Forms.Button()
        Me.OnBtn2 = New System.Windows.Forms.Button()
        Me.OffBtn2 = New System.Windows.Forms.Button()
        Me.OnBtn3 = New System.Windows.Forms.Button()
        Me.OffBtn3 = New System.Windows.Forms.Button()
        Me.OnBtn4 = New System.Windows.Forms.Button()
        Me.OffBtn4 = New System.Windows.Forms.Button()
        Me.OnBtn5 = New System.Windows.Forms.Button()
        Me.OffBtn5 = New System.Windows.Forms.Button()
        Me.OnBtn6 = New System.Windows.Forms.Button()
        Me.OffBtn6 = New System.Windows.Forms.Button()
        Me.OnOffLbl1 = New System.Windows.Forms.Label()
        Me.OnOffLbl2 = New System.Windows.Forms.Label()
        Me.OnOffLbl3 = New System.Windows.Forms.Label()
        Me.OnOffLbl4 = New System.Windows.Forms.Label()
        Me.OnOffLbl5 = New System.Windows.Forms.Label()
        Me.OnOffLbl6 = New System.Windows.Forms.Label()
        Me.fileWriteTimer = New System.Windows.Forms.Timer(Me.components)
        Me.inputTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Charger1
        '
        Me.Charger1.Location = New System.Drawing.Point(13, 29)
        Me.Charger1.Name = "Charger1"
        Me.Charger1.Size = New System.Drawing.Size(164, 23)
        Me.Charger1.TabIndex = 0
        '
        'Charger2
        '
        Me.Charger2.Location = New System.Drawing.Point(12, 75)
        Me.Charger2.Name = "Charger2"
        Me.Charger2.Size = New System.Drawing.Size(163, 23)
        Me.Charger2.TabIndex = 1
        '
        'Charger3
        '
        Me.Charger3.Location = New System.Drawing.Point(12, 121)
        Me.Charger3.Name = "Charger3"
        Me.Charger3.Size = New System.Drawing.Size(163, 23)
        Me.Charger3.TabIndex = 2
        '
        'Charger4
        '
        Me.Charger4.Location = New System.Drawing.Point(12, 167)
        Me.Charger4.Name = "Charger4"
        Me.Charger4.Size = New System.Drawing.Size(163, 23)
        Me.Charger4.TabIndex = 3
        '
        'Charger5
        '
        Me.Charger5.Location = New System.Drawing.Point(13, 213)
        Me.Charger5.Name = "Charger5"
        Me.Charger5.Size = New System.Drawing.Size(163, 23)
        Me.Charger5.TabIndex = 4
        '
        'Charger6
        '
        Me.Charger6.Location = New System.Drawing.Point(12, 259)
        Me.Charger6.Name = "Charger6"
        Me.Charger6.Size = New System.Drawing.Size(163, 23)
        Me.Charger6.TabIndex = 5
        '
        'UpdateTimer
        '
        Me.UpdateTimer.Enabled = True
        Me.UpdateTimer.Interval = 1500
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
        Me.CurrentLbl1.ForeColor = System.Drawing.Color.Purple
        Me.CurrentLbl1.Location = New System.Drawing.Point(228, 39)
        Me.CurrentLbl1.Name = "CurrentLbl1"
        Me.CurrentLbl1.Size = New System.Drawing.Size(23, 13)
        Me.CurrentLbl1.TabIndex = 14
        Me.CurrentLbl1.Text = "0 A"
        '
        'CurrentLbl2
        '
        Me.CurrentLbl2.AutoSize = True
        Me.CurrentLbl2.ForeColor = System.Drawing.Color.Purple
        Me.CurrentLbl2.Location = New System.Drawing.Point(228, 85)
        Me.CurrentLbl2.Name = "CurrentLbl2"
        Me.CurrentLbl2.Size = New System.Drawing.Size(23, 13)
        Me.CurrentLbl2.TabIndex = 15
        Me.CurrentLbl2.Text = "0 A"
        '
        'CurrentLbl3
        '
        Me.CurrentLbl3.AutoSize = True
        Me.CurrentLbl3.ForeColor = System.Drawing.Color.Purple
        Me.CurrentLbl3.Location = New System.Drawing.Point(228, 131)
        Me.CurrentLbl3.Name = "CurrentLbl3"
        Me.CurrentLbl3.Size = New System.Drawing.Size(23, 13)
        Me.CurrentLbl3.TabIndex = 16
        Me.CurrentLbl3.Text = "0 A"
        '
        'CurrentLbl4
        '
        Me.CurrentLbl4.AutoSize = True
        Me.CurrentLbl4.ForeColor = System.Drawing.Color.Purple
        Me.CurrentLbl4.Location = New System.Drawing.Point(228, 177)
        Me.CurrentLbl4.Name = "CurrentLbl4"
        Me.CurrentLbl4.Size = New System.Drawing.Size(23, 13)
        Me.CurrentLbl4.TabIndex = 17
        Me.CurrentLbl4.Text = "0 A"
        '
        'CurrentLbl5
        '
        Me.CurrentLbl5.AutoSize = True
        Me.CurrentLbl5.ForeColor = System.Drawing.Color.Purple
        Me.CurrentLbl5.Location = New System.Drawing.Point(228, 223)
        Me.CurrentLbl5.Name = "CurrentLbl5"
        Me.CurrentLbl5.Size = New System.Drawing.Size(23, 13)
        Me.CurrentLbl5.TabIndex = 18
        Me.CurrentLbl5.Text = "0 A"
        '
        'CurrentLbl6
        '
        Me.CurrentLbl6.AutoSize = True
        Me.CurrentLbl6.ForeColor = System.Drawing.Color.Purple
        Me.CurrentLbl6.Location = New System.Drawing.Point(228, 269)
        Me.CurrentLbl6.Name = "CurrentLbl6"
        Me.CurrentLbl6.Size = New System.Drawing.Size(23, 13)
        Me.CurrentLbl6.TabIndex = 19
        Me.CurrentLbl6.Text = "0 A"
        '
        'PercentLbl1
        '
        Me.PercentLbl1.AutoSize = True
        Me.PercentLbl1.Location = New System.Drawing.Point(198, 26)
        Me.PercentLbl1.Name = "PercentLbl1"
        Me.PercentLbl1.Size = New System.Drawing.Size(21, 13)
        Me.PercentLbl1.TabIndex = 20
        Me.PercentLbl1.Text = "0%"
        '
        'PercentLbl2
        '
        Me.PercentLbl2.AutoSize = True
        Me.PercentLbl2.Location = New System.Drawing.Point(198, 72)
        Me.PercentLbl2.Name = "PercentLbl2"
        Me.PercentLbl2.Size = New System.Drawing.Size(21, 13)
        Me.PercentLbl2.TabIndex = 21
        Me.PercentLbl2.Text = "0%"
        '
        'PercentLbl3
        '
        Me.PercentLbl3.AutoSize = True
        Me.PercentLbl3.Location = New System.Drawing.Point(198, 118)
        Me.PercentLbl3.Name = "PercentLbl3"
        Me.PercentLbl3.Size = New System.Drawing.Size(21, 13)
        Me.PercentLbl3.TabIndex = 22
        Me.PercentLbl3.Text = "0%"
        '
        'PercentLbl4
        '
        Me.PercentLbl4.AutoSize = True
        Me.PercentLbl4.Location = New System.Drawing.Point(198, 164)
        Me.PercentLbl4.Name = "PercentLbl4"
        Me.PercentLbl4.Size = New System.Drawing.Size(21, 13)
        Me.PercentLbl4.TabIndex = 23
        Me.PercentLbl4.Text = "0%"
        '
        'PercentLbl5
        '
        Me.PercentLbl5.AutoSize = True
        Me.PercentLbl5.Location = New System.Drawing.Point(198, 210)
        Me.PercentLbl5.Name = "PercentLbl5"
        Me.PercentLbl5.Size = New System.Drawing.Size(21, 13)
        Me.PercentLbl5.TabIndex = 24
        Me.PercentLbl5.Text = "0%"
        '
        'PercentLbl6
        '
        Me.PercentLbl6.AutoSize = True
        Me.PercentLbl6.Location = New System.Drawing.Point(198, 256)
        Me.PercentLbl6.Name = "PercentLbl6"
        Me.PercentLbl6.Size = New System.Drawing.Size(21, 13)
        Me.PercentLbl6.TabIndex = 25
        Me.PercentLbl6.Text = "0%"
        '
        'ETA
        '
        Me.ETA.AutoSize = True
        Me.ETA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ETA.Location = New System.Drawing.Point(335, 9)
        Me.ETA.Name = "ETA"
        Me.ETA.Size = New System.Drawing.Size(31, 13)
        Me.ETA.TabIndex = 26
        Me.ETA.Text = "ETA"
        '
        'ETALbl1
        '
        Me.ETALbl1.AutoSize = True
        Me.ETALbl1.Location = New System.Drawing.Point(335, 39)
        Me.ETALbl1.Name = "ETALbl1"
        Me.ETALbl1.Size = New System.Drawing.Size(64, 13)
        Me.ETALbl1.TabIndex = 27
        Me.ETALbl1.Text = "270 minutes"
        '
        'ETALbl2
        '
        Me.ETALbl2.AutoSize = True
        Me.ETALbl2.Location = New System.Drawing.Point(335, 85)
        Me.ETALbl2.Name = "ETALbl2"
        Me.ETALbl2.Size = New System.Drawing.Size(64, 13)
        Me.ETALbl2.TabIndex = 28
        Me.ETALbl2.Text = "270 minutes"
        '
        'ETALbl3
        '
        Me.ETALbl3.AutoSize = True
        Me.ETALbl3.Location = New System.Drawing.Point(335, 131)
        Me.ETALbl3.Name = "ETALbl3"
        Me.ETALbl3.Size = New System.Drawing.Size(64, 13)
        Me.ETALbl3.TabIndex = 29
        Me.ETALbl3.Text = "270 minutes"
        '
        'ETALbl4
        '
        Me.ETALbl4.AutoSize = True
        Me.ETALbl4.Location = New System.Drawing.Point(335, 177)
        Me.ETALbl4.Name = "ETALbl4"
        Me.ETALbl4.Size = New System.Drawing.Size(64, 13)
        Me.ETALbl4.TabIndex = 30
        Me.ETALbl4.Text = "270 minutes"
        '
        'ETALbl5
        '
        Me.ETALbl5.AutoSize = True
        Me.ETALbl5.Location = New System.Drawing.Point(335, 223)
        Me.ETALbl5.Name = "ETALbl5"
        Me.ETALbl5.Size = New System.Drawing.Size(64, 13)
        Me.ETALbl5.TabIndex = 31
        Me.ETALbl5.Text = "270 minutes"
        '
        'ETALbl6
        '
        Me.ETALbl6.AutoSize = True
        Me.ETALbl6.Location = New System.Drawing.Point(335, 269)
        Me.ETALbl6.Name = "ETALbl6"
        Me.ETALbl6.Size = New System.Drawing.Size(64, 13)
        Me.ETALbl6.TabIndex = 32
        Me.ETALbl6.Text = "270 minutes"
        '
        'Battery
        '
        Me.Battery.AutoSize = True
        Me.Battery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Battery.Location = New System.Drawing.Point(494, 9)
        Me.Battery.Name = "Battery"
        Me.Battery.Size = New System.Drawing.Size(47, 13)
        Me.Battery.TabIndex = 33
        Me.Battery.Text = "Battery"
        '
        'BatteryLbl1
        '
        Me.BatteryLbl1.AutoSize = True
        Me.BatteryLbl1.Location = New System.Drawing.Point(510, 39)
        Me.BatteryLbl1.Name = "BatteryLbl1"
        Me.BatteryLbl1.Size = New System.Drawing.Size(13, 13)
        Me.BatteryLbl1.TabIndex = 34
        Me.BatteryLbl1.Text = "0"
        '
        'BatteryLbl2
        '
        Me.BatteryLbl2.AutoSize = True
        Me.BatteryLbl2.Location = New System.Drawing.Point(510, 85)
        Me.BatteryLbl2.Name = "BatteryLbl2"
        Me.BatteryLbl2.Size = New System.Drawing.Size(13, 13)
        Me.BatteryLbl2.TabIndex = 35
        Me.BatteryLbl2.Text = "0"
        '
        'BatteryLbl3
        '
        Me.BatteryLbl3.AutoSize = True
        Me.BatteryLbl3.Location = New System.Drawing.Point(510, 131)
        Me.BatteryLbl3.Name = "BatteryLbl3"
        Me.BatteryLbl3.Size = New System.Drawing.Size(13, 13)
        Me.BatteryLbl3.TabIndex = 36
        Me.BatteryLbl3.Text = "0"
        '
        'BatteryLbl4
        '
        Me.BatteryLbl4.AutoSize = True
        Me.BatteryLbl4.Location = New System.Drawing.Point(510, 177)
        Me.BatteryLbl4.Name = "BatteryLbl4"
        Me.BatteryLbl4.Size = New System.Drawing.Size(13, 13)
        Me.BatteryLbl4.TabIndex = 37
        Me.BatteryLbl4.Text = "0"
        '
        'BatteryLbl5
        '
        Me.BatteryLbl5.AutoSize = True
        Me.BatteryLbl5.Location = New System.Drawing.Point(510, 223)
        Me.BatteryLbl5.Name = "BatteryLbl5"
        Me.BatteryLbl5.Size = New System.Drawing.Size(13, 13)
        Me.BatteryLbl5.TabIndex = 38
        Me.BatteryLbl5.Text = "0"
        '
        'BatteryLbl6
        '
        Me.BatteryLbl6.AutoSize = True
        Me.BatteryLbl6.Location = New System.Drawing.Point(510, 269)
        Me.BatteryLbl6.Name = "BatteryLbl6"
        Me.BatteryLbl6.Size = New System.Drawing.Size(13, 13)
        Me.BatteryLbl6.TabIndex = 39
        Me.BatteryLbl6.Text = "0"
        '
        'OnBtn1
        '
        Me.OnBtn1.Location = New System.Drawing.Point(592, 34)
        Me.OnBtn1.Name = "OnBtn1"
        Me.OnBtn1.Size = New System.Drawing.Size(75, 23)
        Me.OnBtn1.TabIndex = 40
        Me.OnBtn1.Text = "Turn On"
        Me.OnBtn1.UseVisualStyleBackColor = True
        '
        'OffBtn1
        '
        Me.OffBtn1.Location = New System.Drawing.Point(689, 34)
        Me.OffBtn1.Name = "OffBtn1"
        Me.OffBtn1.Size = New System.Drawing.Size(75, 23)
        Me.OffBtn1.TabIndex = 41
        Me.OffBtn1.Text = "Turn Off"
        Me.OffBtn1.UseVisualStyleBackColor = True
        '
        'OnBtn2
        '
        Me.OnBtn2.Location = New System.Drawing.Point(592, 80)
        Me.OnBtn2.Name = "OnBtn2"
        Me.OnBtn2.Size = New System.Drawing.Size(75, 23)
        Me.OnBtn2.TabIndex = 42
        Me.OnBtn2.Text = "Turn On"
        Me.OnBtn2.UseVisualStyleBackColor = True
        '
        'OffBtn2
        '
        Me.OffBtn2.Location = New System.Drawing.Point(689, 80)
        Me.OffBtn2.Name = "OffBtn2"
        Me.OffBtn2.Size = New System.Drawing.Size(75, 23)
        Me.OffBtn2.TabIndex = 43
        Me.OffBtn2.Text = "Turn Off"
        Me.OffBtn2.UseVisualStyleBackColor = True
        '
        'OnBtn3
        '
        Me.OnBtn3.Location = New System.Drawing.Point(592, 126)
        Me.OnBtn3.Name = "OnBtn3"
        Me.OnBtn3.Size = New System.Drawing.Size(75, 23)
        Me.OnBtn3.TabIndex = 44
        Me.OnBtn3.Text = "Turn On"
        Me.OnBtn3.UseVisualStyleBackColor = True
        '
        'OffBtn3
        '
        Me.OffBtn3.Location = New System.Drawing.Point(689, 126)
        Me.OffBtn3.Name = "OffBtn3"
        Me.OffBtn3.Size = New System.Drawing.Size(75, 23)
        Me.OffBtn3.TabIndex = 45
        Me.OffBtn3.Text = "Turn Off"
        Me.OffBtn3.UseVisualStyleBackColor = True
        '
        'OnBtn4
        '
        Me.OnBtn4.Location = New System.Drawing.Point(592, 171)
        Me.OnBtn4.Name = "OnBtn4"
        Me.OnBtn4.Size = New System.Drawing.Size(75, 23)
        Me.OnBtn4.TabIndex = 46
        Me.OnBtn4.Text = "Turn On"
        Me.OnBtn4.UseVisualStyleBackColor = True
        '
        'OffBtn4
        '
        Me.OffBtn4.Location = New System.Drawing.Point(689, 171)
        Me.OffBtn4.Name = "OffBtn4"
        Me.OffBtn4.Size = New System.Drawing.Size(75, 23)
        Me.OffBtn4.TabIndex = 47
        Me.OffBtn4.Text = "Turn Off"
        Me.OffBtn4.UseVisualStyleBackColor = True
        '
        'OnBtn5
        '
        Me.OnBtn5.Location = New System.Drawing.Point(592, 218)
        Me.OnBtn5.Name = "OnBtn5"
        Me.OnBtn5.Size = New System.Drawing.Size(75, 23)
        Me.OnBtn5.TabIndex = 48
        Me.OnBtn5.Text = "Turn On"
        Me.OnBtn5.UseVisualStyleBackColor = True
        '
        'OffBtn5
        '
        Me.OffBtn5.Location = New System.Drawing.Point(689, 218)
        Me.OffBtn5.Name = "OffBtn5"
        Me.OffBtn5.Size = New System.Drawing.Size(75, 23)
        Me.OffBtn5.TabIndex = 49
        Me.OffBtn5.Text = "Turn Off"
        Me.OffBtn5.UseVisualStyleBackColor = True
        '
        'OnBtn6
        '
        Me.OnBtn6.Location = New System.Drawing.Point(592, 264)
        Me.OnBtn6.Name = "OnBtn6"
        Me.OnBtn6.Size = New System.Drawing.Size(75, 23)
        Me.OnBtn6.TabIndex = 50
        Me.OnBtn6.Text = "Turn On"
        Me.OnBtn6.UseVisualStyleBackColor = True
        '
        'OffBtn6
        '
        Me.OffBtn6.Location = New System.Drawing.Point(689, 264)
        Me.OffBtn6.Name = "OffBtn6"
        Me.OffBtn6.Size = New System.Drawing.Size(75, 23)
        Me.OffBtn6.TabIndex = 51
        Me.OffBtn6.Text = "Turn Off"
        Me.OffBtn6.UseVisualStyleBackColor = True
        '
        'OnOffLbl1
        '
        Me.OnOffLbl1.AutoSize = True
        Me.OnOffLbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnOffLbl1.Location = New System.Drawing.Point(198, 39)
        Me.OnOffLbl1.Name = "OnOffLbl1"
        Me.OnOffLbl1.Size = New System.Drawing.Size(24, 13)
        Me.OnOffLbl1.TabIndex = 52
        Me.OnOffLbl1.Text = "Off"
        '
        'OnOffLbl2
        '
        Me.OnOffLbl2.AutoSize = True
        Me.OnOffLbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnOffLbl2.Location = New System.Drawing.Point(198, 85)
        Me.OnOffLbl2.Name = "OnOffLbl2"
        Me.OnOffLbl2.Size = New System.Drawing.Size(24, 13)
        Me.OnOffLbl2.TabIndex = 53
        Me.OnOffLbl2.Text = "Off"
        '
        'OnOffLbl3
        '
        Me.OnOffLbl3.AutoSize = True
        Me.OnOffLbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnOffLbl3.Location = New System.Drawing.Point(198, 131)
        Me.OnOffLbl3.Name = "OnOffLbl3"
        Me.OnOffLbl3.Size = New System.Drawing.Size(24, 13)
        Me.OnOffLbl3.TabIndex = 54
        Me.OnOffLbl3.Text = "Off"
        '
        'OnOffLbl4
        '
        Me.OnOffLbl4.AutoSize = True
        Me.OnOffLbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnOffLbl4.Location = New System.Drawing.Point(198, 177)
        Me.OnOffLbl4.Name = "OnOffLbl4"
        Me.OnOffLbl4.Size = New System.Drawing.Size(24, 13)
        Me.OnOffLbl4.TabIndex = 55
        Me.OnOffLbl4.Text = "Off"
        '
        'OnOffLbl5
        '
        Me.OnOffLbl5.AutoSize = True
        Me.OnOffLbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnOffLbl5.Location = New System.Drawing.Point(198, 223)
        Me.OnOffLbl5.Name = "OnOffLbl5"
        Me.OnOffLbl5.Size = New System.Drawing.Size(24, 13)
        Me.OnOffLbl5.TabIndex = 56
        Me.OnOffLbl5.Text = "Off"
        '
        'OnOffLbl6
        '
        Me.OnOffLbl6.AutoSize = True
        Me.OnOffLbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnOffLbl6.Location = New System.Drawing.Point(198, 269)
        Me.OnOffLbl6.Name = "OnOffLbl6"
        Me.OnOffLbl6.Size = New System.Drawing.Size(24, 13)
        Me.OnOffLbl6.TabIndex = 57
        Me.OnOffLbl6.Text = "Off"
        '
        'fileWriteTimer
        '
        Me.fileWriteTimer.Enabled = True
        Me.fileWriteTimer.Interval = 60000
        '
        'inputTimer
        '
        Me.inputTimer.Enabled = True
        Me.inputTimer.Interval = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 324)
        Me.Controls.Add(Me.OnOffLbl6)
        Me.Controls.Add(Me.OnOffLbl5)
        Me.Controls.Add(Me.OnOffLbl4)
        Me.Controls.Add(Me.OnOffLbl3)
        Me.Controls.Add(Me.OnOffLbl2)
        Me.Controls.Add(Me.OnOffLbl1)
        Me.Controls.Add(Me.OffBtn6)
        Me.Controls.Add(Me.OnBtn6)
        Me.Controls.Add(Me.OffBtn5)
        Me.Controls.Add(Me.OnBtn5)
        Me.Controls.Add(Me.OffBtn4)
        Me.Controls.Add(Me.OnBtn4)
        Me.Controls.Add(Me.OffBtn3)
        Me.Controls.Add(Me.OnBtn3)
        Me.Controls.Add(Me.OffBtn2)
        Me.Controls.Add(Me.OnBtn2)
        Me.Controls.Add(Me.OffBtn1)
        Me.Controls.Add(Me.OnBtn1)
        Me.Controls.Add(Me.BatteryLbl6)
        Me.Controls.Add(Me.BatteryLbl5)
        Me.Controls.Add(Me.BatteryLbl4)
        Me.Controls.Add(Me.BatteryLbl3)
        Me.Controls.Add(Me.BatteryLbl2)
        Me.Controls.Add(Me.BatteryLbl1)
        Me.Controls.Add(Me.Battery)
        Me.Controls.Add(Me.ETALbl6)
        Me.Controls.Add(Me.ETALbl5)
        Me.Controls.Add(Me.ETALbl4)
        Me.Controls.Add(Me.ETALbl3)
        Me.Controls.Add(Me.ETALbl2)
        Me.Controls.Add(Me.ETALbl1)
        Me.Controls.Add(Me.ETA)
        Me.Controls.Add(Me.PercentLbl6)
        Me.Controls.Add(Me.PercentLbl5)
        Me.Controls.Add(Me.PercentLbl4)
        Me.Controls.Add(Me.PercentLbl3)
        Me.Controls.Add(Me.PercentLbl2)
        Me.Controls.Add(Me.PercentLbl1)
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
        Me.Controls.Add(Me.Charger6)
        Me.Controls.Add(Me.Charger5)
        Me.Controls.Add(Me.Charger4)
        Me.Controls.Add(Me.Charger3)
        Me.Controls.Add(Me.Charger2)
        Me.Controls.Add(Me.Charger1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Team 1714's Battery Charging Station Controls"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Charger1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger3 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger4 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger5 As System.Windows.Forms.ProgressBar
    Friend WithEvents Charger6 As System.Windows.Forms.ProgressBar
    Friend WithEvents UpdateTimer As System.Windows.Forms.Timer
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
    Friend WithEvents PercentLbl1 As System.Windows.Forms.Label
    Friend WithEvents PercentLbl2 As System.Windows.Forms.Label
    Friend WithEvents PercentLbl3 As System.Windows.Forms.Label
    Friend WithEvents PercentLbl4 As System.Windows.Forms.Label
    Friend WithEvents PercentLbl5 As System.Windows.Forms.Label
    Friend WithEvents PercentLbl6 As System.Windows.Forms.Label
    Friend WithEvents ETA As System.Windows.Forms.Label
    Friend WithEvents ETALbl1 As System.Windows.Forms.Label
    Friend WithEvents ETALbl2 As System.Windows.Forms.Label
    Friend WithEvents ETALbl3 As System.Windows.Forms.Label
    Friend WithEvents ETALbl4 As System.Windows.Forms.Label
    Friend WithEvents ETALbl5 As System.Windows.Forms.Label
    Friend WithEvents ETALbl6 As System.Windows.Forms.Label
    Friend WithEvents Battery As System.Windows.Forms.Label
    Friend WithEvents BatteryLbl1 As System.Windows.Forms.Label
    Friend WithEvents BatteryLbl2 As System.Windows.Forms.Label
    Friend WithEvents BatteryLbl3 As System.Windows.Forms.Label
    Friend WithEvents BatteryLbl4 As System.Windows.Forms.Label
    Friend WithEvents BatteryLbl5 As System.Windows.Forms.Label
    Friend WithEvents BatteryLbl6 As System.Windows.Forms.Label
    Friend WithEvents OnBtn1 As System.Windows.Forms.Button
    Friend WithEvents OffBtn1 As System.Windows.Forms.Button
    Friend WithEvents OnBtn2 As System.Windows.Forms.Button
    Friend WithEvents OffBtn2 As System.Windows.Forms.Button
    Friend WithEvents OnBtn3 As System.Windows.Forms.Button
    Friend WithEvents OffBtn3 As System.Windows.Forms.Button
    Friend WithEvents OnBtn4 As System.Windows.Forms.Button
    Friend WithEvents OffBtn4 As System.Windows.Forms.Button
    Friend WithEvents OnBtn5 As System.Windows.Forms.Button
    Friend WithEvents OffBtn5 As System.Windows.Forms.Button
    Friend WithEvents OnBtn6 As System.Windows.Forms.Button
    Friend WithEvents OffBtn6 As System.Windows.Forms.Button
    Friend WithEvents OnOffLbl1 As System.Windows.Forms.Label
    Friend WithEvents OnOffLbl2 As System.Windows.Forms.Label
    Friend WithEvents OnOffLbl3 As System.Windows.Forms.Label
    Friend WithEvents OnOffLbl4 As System.Windows.Forms.Label
    Friend WithEvents OnOffLbl5 As System.Windows.Forms.Label
    Friend WithEvents OnOffLbl6 As System.Windows.Forms.Label
    Friend WithEvents fileWriteTimer As System.Windows.Forms.Timer
    Friend WithEvents inputTimer As System.Windows.Forms.Timer

End Class
