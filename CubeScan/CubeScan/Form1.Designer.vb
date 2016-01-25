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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveBitmap = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label_Working = New System.Windows.Forms.Label()
        Me.cubelet8 = New System.Windows.Forms.Label()
        Me.cubelet7 = New System.Windows.Forms.Label()
        Me.cubelet6 = New System.Windows.Forms.Label()
        Me.cubelet5 = New System.Windows.Forms.Label()
        Me.cubelet4 = New System.Windows.Forms.Label()
        Me.cubelet3 = New System.Windows.Forms.Label()
        Me.cubelet2 = New System.Windows.Forms.Label()
        Me.cubelet1 = New System.Windows.Forms.Label()
        Me.cubelet0 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox_ComPort = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_ComPortConnect = New System.Windows.Forms.Button()
        Me.btnFlip = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBox_Test = New System.Windows.Forms.CheckBox()
        Me.ComboBox_FrameSize = New System.Windows.Forms.ComboBox()
        Me.btnP1 = New System.Windows.Forms.Button()
        Me.btnP2 = New System.Windows.Forms.Button()
        Me.btnP3 = New System.Windows.Forms.Button()
        Me.stringTextbx = New System.Windows.Forms.TextBox()
        Me.btnSendString = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TimerWait = New System.Windows.Forms.Timer(Me.components)
        Me.Label_Connect = New System.Windows.Forms.Label()
        Me.lbl180 = New System.Windows.Forms.Label()
        Me.lbl90 = New System.Windows.Forms.Label()
        Me.lbl0 = New System.Windows.Forms.Label()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.ComboBox_Devices = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(350, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CubeScan"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(824, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.SaveBitmap, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Image = CType(resources.GetObject("SaveAsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &Cube String"
        Me.SaveAsToolStripMenuItem.ToolTipText = "Save current cube string to a text file."
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'SaveBitmap
        '
        Me.SaveBitmap.Image = CType(resources.GetObject("SaveBitmap.Image"), System.Drawing.Image)
        Me.SaveBitmap.Name = "SaveBitmap"
        Me.SaveBitmap.Size = New System.Drawing.Size(163, 22)
        Me.SaveBitmap.Text = "Save &Bitmap"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(160, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ToolsToolStripMenuItem.Text = "&Settings"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Image = CType(resources.GetObject("CustomizeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Scan Size"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Image = CType(resources.GetObject("ContentsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(30, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 240)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Camera:"
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(443, 354)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(75, 23)
        Me.Button_Connect.TabIndex = 8
        Me.Button_Connect.Text = "Connect"
        Me.ToolTip1.SetToolTip(Me.Button_Connect, "Connect to camera.")
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(572, 354)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label_Working
        '
        Me.Label_Working.Location = New System.Drawing.Point(729, 160)
        Me.Label_Working.Name = "Label_Working"
        Me.Label_Working.Size = New System.Drawing.Size(73, 13)
        Me.Label_Working.TabIndex = 27
        Me.Label_Working.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cubelet8
        '
        Me.cubelet8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cubelet8.Location = New System.Drawing.Point(777, 129)
        Me.cubelet8.Name = "cubelet8"
        Me.cubelet8.Size = New System.Drawing.Size(25, 25)
        Me.cubelet8.TabIndex = 26
        Me.cubelet8.Text = "8"
        Me.cubelet8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cubelet7
        '
        Me.cubelet7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cubelet7.Location = New System.Drawing.Point(753, 129)
        Me.cubelet7.Name = "cubelet7"
        Me.cubelet7.Size = New System.Drawing.Size(25, 25)
        Me.cubelet7.TabIndex = 25
        Me.cubelet7.Text = "7"
        Me.cubelet7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cubelet6
        '
        Me.cubelet6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cubelet6.Location = New System.Drawing.Point(729, 129)
        Me.cubelet6.Name = "cubelet6"
        Me.cubelet6.Size = New System.Drawing.Size(25, 25)
        Me.cubelet6.TabIndex = 24
        Me.cubelet6.Text = "6"
        Me.cubelet6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cubelet5
        '
        Me.cubelet5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cubelet5.Location = New System.Drawing.Point(777, 105)
        Me.cubelet5.Name = "cubelet5"
        Me.cubelet5.Size = New System.Drawing.Size(25, 25)
        Me.cubelet5.TabIndex = 23
        Me.cubelet5.Text = "5"
        Me.cubelet5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cubelet4
        '
        Me.cubelet4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cubelet4.Location = New System.Drawing.Point(753, 105)
        Me.cubelet4.Name = "cubelet4"
        Me.cubelet4.Size = New System.Drawing.Size(25, 25)
        Me.cubelet4.TabIndex = 22
        Me.cubelet4.Text = "4"
        Me.cubelet4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cubelet3
        '
        Me.cubelet3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cubelet3.Location = New System.Drawing.Point(729, 105)
        Me.cubelet3.Name = "cubelet3"
        Me.cubelet3.Size = New System.Drawing.Size(25, 25)
        Me.cubelet3.TabIndex = 21
        Me.cubelet3.Text = "3"
        Me.cubelet3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cubelet2
        '
        Me.cubelet2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cubelet2.Location = New System.Drawing.Point(777, 81)
        Me.cubelet2.Name = "cubelet2"
        Me.cubelet2.Size = New System.Drawing.Size(25, 25)
        Me.cubelet2.TabIndex = 20
        Me.cubelet2.Text = "2"
        Me.cubelet2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cubelet1
        '
        Me.cubelet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cubelet1.Location = New System.Drawing.Point(753, 81)
        Me.cubelet1.Name = "cubelet1"
        Me.cubelet1.Size = New System.Drawing.Size(25, 25)
        Me.cubelet1.TabIndex = 19
        Me.cubelet1.Text = "1"
        Me.cubelet1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cubelet0
        '
        Me.cubelet0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cubelet0.Location = New System.Drawing.Point(729, 81)
        Me.cubelet0.Name = "cubelet0"
        Me.cubelet0.Size = New System.Drawing.Size(25, 25)
        Me.cubelet0.TabIndex = 18
        Me.cubelet0.Text = "0"
        Me.cubelet0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(358, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Frame Size:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(285, 80)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(163, 116)
        Me.TextBox1.TabIndex = 29
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(285, 204)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(163, 116)
        Me.TextBox2.TabIndex = 30
        '
        'SaveFileDialog1
        '
        '
        'Timer1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(463, 80)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(240, 240)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'Timer2
        '
        '
        'ComboBox_ComPort
        '
        Me.ComboBox_ComPort.FormattingEnabled = True
        Me.ComboBox_ComPort.Location = New System.Drawing.Point(30, 355)
        Me.ComboBox_ComPort.Name = "ComboBox_ComPort"
        Me.ComboBox_ComPort.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox_ComPort.TabIndex = 32
        Me.ComboBox_ComPort.Text = "Select Port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Com Port:"
        '
        'Button_ComPortConnect
        '
        Me.Button_ComPortConnect.Enabled = False
        Me.Button_ComPortConnect.Location = New System.Drawing.Point(121, 354)
        Me.Button_ComPortConnect.Name = "Button_ComPortConnect"
        Me.Button_ComPortConnect.Size = New System.Drawing.Size(75, 23)
        Me.Button_ComPortConnect.TabIndex = 34
        Me.Button_ComPortConnect.Text = "Connect"
        Me.ToolTip1.SetToolTip(Me.Button_ComPortConnect, "Connect to cube solver.")
        Me.Button_ComPortConnect.UseVisualStyleBackColor = True
        '
        'btnFlip
        '
        Me.btnFlip.Location = New System.Drawing.Point(747, 295)
        Me.btnFlip.Name = "btnFlip"
        Me.btnFlip.Size = New System.Drawing.Size(42, 23)
        Me.btnFlip.TabIndex = 35
        Me.btnFlip.Text = "Flip"
        Me.btnFlip.UseVisualStyleBackColor = True
        '
        'CheckBox_Test
        '
        Me.CheckBox_Test.AutoSize = True
        Me.CheckBox_Test.Location = New System.Drawing.Point(664, 358)
        Me.CheckBox_Test.Name = "CheckBox_Test"
        Me.CheckBox_Test.Size = New System.Drawing.Size(79, 17)
        Me.CheckBox_Test.TabIndex = 44
        Me.CheckBox_Test.Text = "Test Colors"
        Me.ToolTip1.SetToolTip(Me.CheckBox_Test, "Check this box to test color recognition without running the automated cube solvi" & _
        "ng process.")
        Me.CheckBox_Test.UseVisualStyleBackColor = True
        '
        'ComboBox_FrameSize
        '
        Me.ComboBox_FrameSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CubeScan.My.MySettings.Default, "CamRes", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox_FrameSize.FormattingEnabled = True
        Me.ComboBox_FrameSize.Location = New System.Drawing.Point(358, 355)
        Me.ComboBox_FrameSize.Name = "ComboBox_FrameSize"
        Me.ComboBox_FrameSize.Size = New System.Drawing.Size(78, 21)
        Me.ComboBox_FrameSize.TabIndex = 7
        Me.ComboBox_FrameSize.Text = Global.CubeScan.My.MySettings.Default.CamRes
        Me.ToolTip1.SetToolTip(Me.ComboBox_FrameSize, "Use 320 x 240 resolution for best results")
        '
        'btnP1
        '
        Me.btnP1.Location = New System.Drawing.Point(747, 208)
        Me.btnP1.Name = "btnP1"
        Me.btnP1.Size = New System.Drawing.Size(41, 23)
        Me.btnP1.TabIndex = 41
        Me.btnP1.Text = "P 1"
        Me.btnP1.UseVisualStyleBackColor = True
        '
        'btnP2
        '
        Me.btnP2.Location = New System.Drawing.Point(747, 237)
        Me.btnP2.Name = "btnP2"
        Me.btnP2.Size = New System.Drawing.Size(41, 23)
        Me.btnP2.TabIndex = 42
        Me.btnP2.Text = "P 2"
        Me.btnP2.UseVisualStyleBackColor = True
        '
        'btnP3
        '
        Me.btnP3.Location = New System.Drawing.Point(747, 266)
        Me.btnP3.Name = "btnP3"
        Me.btnP3.Size = New System.Drawing.Size(41, 23)
        Me.btnP3.TabIndex = 43
        Me.btnP3.Text = "P 3"
        Me.btnP3.UseVisualStyleBackColor = True
        '
        'stringTextbx
        '
        Me.stringTextbx.Location = New System.Drawing.Point(572, 390)
        Me.stringTextbx.Name = "stringTextbx"
        Me.stringTextbx.Size = New System.Drawing.Size(166, 20)
        Me.stringTextbx.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.stringTextbx, "Manually enter a color string in this field if desired.")
        '
        'btnSendString
        '
        Me.btnSendString.Location = New System.Drawing.Point(753, 390)
        Me.btnSendString.Name = "btnSendString"
        Me.btnSendString.Size = New System.Drawing.Size(37, 23)
        Me.btnSendString.TabIndex = 46
        Me.btnSendString.Text = "Go"
        Me.ToolTip1.SetToolTip(Me.btnSendString, "Click to solve cube using  a manually entered string.")
        Me.btnSendString.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(573, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Send String:  ( y,w,r,g,o,b )"
        '
        'TimerWait
        '
        '
        'Label_Connect
        '
        Me.Label_Connect.Location = New System.Drawing.Point(113, 383)
        Me.Label_Connect.Name = "Label_Connect"
        Me.Label_Connect.Size = New System.Drawing.Size(88, 17)
        Me.Label_Connect.TabIndex = 48
        Me.Label_Connect.Text = "Not Connected"
        Me.Label_Connect.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl180
        '
        Me.lbl180.AutoSize = True
        Me.lbl180.Location = New System.Drawing.Point(792, 242)
        Me.lbl180.Name = "lbl180"
        Me.lbl180.Size = New System.Drawing.Size(25, 13)
        Me.lbl180.TabIndex = 49
        Me.lbl180.Text = "180"
        '
        'lbl90
        '
        Me.lbl90.AutoSize = True
        Me.lbl90.Location = New System.Drawing.Point(794, 214)
        Me.lbl90.Name = "lbl90"
        Me.lbl90.Size = New System.Drawing.Size(19, 13)
        Me.lbl90.TabIndex = 50
        Me.lbl90.Text = "90"
        '
        'lbl0
        '
        Me.lbl0.AutoSize = True
        Me.lbl0.Location = New System.Drawing.Point(796, 271)
        Me.lbl0.Name = "lbl0"
        Me.lbl0.Size = New System.Drawing.Size(13, 13)
        Me.lbl0.TabIndex = 51
        Me.lbl0.Text = "0"
        '
        'ComboBox_Devices
        '
        Me.ComboBox_Devices.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CubeScan.My.MySettings.Default, "CaptureDeviceName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox_Devices.FormattingEnabled = True
        Me.ComboBox_Devices.Location = New System.Drawing.Point(228, 355)
        Me.ComboBox_Devices.Name = "ComboBox_Devices"
        Me.ComboBox_Devices.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Devices.TabIndex = 5
        Me.ComboBox_Devices.Text = Global.CubeScan.My.MySettings.Default.CaptureDeviceName
        Me.ToolTip1.SetToolTip(Me.ComboBox_Devices, "Select a camera from the list.")
        '
        'Form1
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 440)
        Me.Controls.Add(Me.lbl0)
        Me.Controls.Add(Me.lbl90)
        Me.Controls.Add(Me.lbl180)
        Me.Controls.Add(Me.Label_Connect)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSendString)
        Me.Controls.Add(Me.stringTextbx)
        Me.Controls.Add(Me.CheckBox_Test)
        Me.Controls.Add(Me.btnP3)
        Me.Controls.Add(Me.btnP2)
        Me.Controls.Add(Me.btnP1)
        Me.Controls.Add(Me.btnFlip)
        Me.Controls.Add(Me.Button_ComPortConnect)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox_ComPort)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_Working)
        Me.Controls.Add(Me.cubelet8)
        Me.Controls.Add(Me.cubelet7)
        Me.Controls.Add(Me.cubelet6)
        Me.Controls.Add(Me.cubelet5)
        Me.Controls.Add(Me.cubelet4)
        Me.Controls.Add(Me.cubelet3)
        Me.Controls.Add(Me.cubelet2)
        Me.Controls.Add(Me.cubelet1)
        Me.Controls.Add(Me.cubelet0)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Button_Connect)
        Me.Controls.Add(Me.ComboBox_FrameSize)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox_Devices)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CubeScan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox_Devices As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_FrameSize As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Connect As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Label_Working As System.Windows.Forms.Label
    Friend WithEvents cubelet8 As System.Windows.Forms.Label
    Friend WithEvents cubelet7 As System.Windows.Forms.Label
    Friend WithEvents cubelet6 As System.Windows.Forms.Label
    Friend WithEvents cubelet5 As System.Windows.Forms.Label
    Friend WithEvents cubelet4 As System.Windows.Forms.Label
    Friend WithEvents cubelet3 As System.Windows.Forms.Label
    Friend WithEvents cubelet2 As System.Windows.Forms.Label
    Friend WithEvents cubelet1 As System.Windows.Forms.Label
    Friend WithEvents cubelet0 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ComboBox_ComPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button_ComPortConnect As System.Windows.Forms.Button
    Friend WithEvents btnFlip As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnP1 As System.Windows.Forms.Button
    Friend WithEvents btnP2 As System.Windows.Forms.Button
    Friend WithEvents btnP3 As System.Windows.Forms.Button
    Friend WithEvents CheckBox_Test As System.Windows.Forms.CheckBox
    Friend WithEvents stringTextbx As System.Windows.Forms.TextBox
    Friend WithEvents btnSendString As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TimerWait As System.Windows.Forms.Timer
    Friend WithEvents Label_Connect As System.Windows.Forms.Label
    Friend WithEvents lbl180 As System.Windows.Forms.Label
    Friend WithEvents lbl90 As System.Windows.Forms.Label
    Friend WithEvents lbl0 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveBitmap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
