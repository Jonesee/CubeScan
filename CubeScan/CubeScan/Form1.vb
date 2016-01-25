
Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports System.Drawing.Imaging
Imports Microsoft.VisualBasic.FileIO
Imports System.Environment
Imports System.Drawing.Graphics
Imports System.IO.Ports

Public Class Form1

    Private WithEvents cam As New DSCamCapture
    Public Shared ImageName As String
    Public Shared FileFolderName As String
    Public SaveFileName As String
    Public PicNumber As Integer
    Public networkError As Boolean
    Public Shared FileUploadName As String
    Public FullFileName As String
    Public toggle As Boolean = False
    Public FirstSnapshot As Boolean
    Public ErrorMessage As String
    Public ErrorSub As String
    Public btnWebToggle As Boolean
    Public FileNameCheck As Boolean
    Public bitMapWidth As Integer
    Public bitmapHeight As Integer
    Public SaveClick As Boolean
    Public toggleConnect As Integer
    Dim redTotal As Integer
    Dim greenTotal As Integer
    Dim blueTotal As Integer
    Dim Rd, Gr, Bl As Integer
    Public redValue As Integer
    Public blueValue As Integer
    Public greenValue As Integer
    Public cubeletColor As Color
    Public bmapStartHeight As Integer
    Public bmapStartWidth As Integer
    Public bmapEndHeight As Integer
    Public bmapEndWidth As Integer
    Public screenshot As Bitmap
    Public bitmapcopy As Bitmap
    Public imagecount As Integer
    Public tempText As String
    Public myport As New SerialPort
    Public stringColorChr As String
    Public CubeString As String
    Public xCount As Integer
    Public FaceColor As String
    Public redString As String
    Public greenString As String
    Public whiteString As String
    Public blueString As String
    Public yellowString As String
    Public orangeString As String
    Public FullCubeString As String
    Public scan_done As Boolean
    Public connected As Boolean
    Public waitstate As Boolean
    Public SaveStringFileName As String
    Public cubeletCount As Integer
    Public startToggle As Integer


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ComboBox_Devices.Items.AddRange(cam.GetCaptureDevices)

        For Each sz As String In [Enum].GetNames(GetType(DSCamCapture.FrameSizes))
            ComboBox_FrameSize.Items.Add(sz.Replace("s", ""))
        Next

        If My.Settings.CamRes <> "" Then ComboBox_FrameSize.SelectedItem = My.Settings.CamRes

        ComboBox_ComPort.Items.Clear()

        For Each portname As String In SerialPort.GetPortNames 'Populate the combox box with computer's available com port names
            ComboBox_ComPort.Items.Add(portname)
        Next
        Form2.Label_Trackbar.Text = Form2.TrackBar1.Value
        lbl90.Text = "90" & Chr(176)
        lbl0.Text = "0" & Chr(176)
        lbl180.Text = "180" & Chr(176)

    End Sub

    Private Sub Button_ComPortConnect_Click(sender As System.Object, e As System.EventArgs) Handles Button_ComPortConnect.Click
        Try
            If myport.IsOpen Then myport.Close()
            With myport
                .PortName = ComboBox_ComPort.Text
                .BaudRate = 9600
                .Parity = Parity.None
                .DataBits = 8
                .StopBits = StopBits.One
                .Open()
                .WriteTimeout = 500
                .ReadTimeout = 500
            End With
            connected = True
            Label_Connect.Text = "Connected"
        Catch ex As Exception
            Label_Connect.Text = "Not Connected"
            MessageBox.Show("Com port is busy or unavailable. ", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            connected = False
        End Try
    End Sub

    Private Sub ComboBox_ComPort_DropDown(sender As System.Object, e As System.EventArgs) Handles ComboBox_ComPort.DropDown

        Button_ComPortConnect.Enabled = True

    End Sub

    Private Sub Button_Connect_Click(sender As System.Object, e As System.EventArgs) Handles Button_Connect.Click

        If ComboBox_FrameSize.Text = "" Then
            MessageBox.Show("Please select a frame size", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        ConnectToCamera()

    End Sub

    Public Sub ConnectToCamera()

        If Not cam.IsConnected Then

            Dim si As Integer = ComboBox_FrameSize.SelectedIndex
            Dim SelectedSize As DSCamCapture.FrameSizes = CType(si, DSCamCapture.FrameSizes)
            If cam.ConnectToDevice(ComboBox_Devices.SelectedIndex, 15, PictureBox1.ClientSize, SelectedSize, PictureBox1.Handle) Then
                cam.Start()
                Button_Connect.Text = "Disconnect"
            End If
        Else
            cam.Dispose()
            Button_Connect.Text = "Connect"
            toggle = False
        End If
        ComboBox_Devices.Enabled = Not cam.IsConnected
        ComboBox_FrameSize.Enabled = Not cam.IsConnected

    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click

        startToggle += 1
        If startToggle = 1 Then
            btnStart.Text = "Stop"
            If cam.IsConnected = False Then MessageBox.Show("Connect to camera before proceeding.", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            If connected = False And CheckBox_Test.Checked = False Then MessageBox.Show("Connect to com port before proceeding.", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            TextBox2.Clear()
            CubeString = ""
            Main()
        Else
            startToggle = 0
            btnStart.Text = "Start"
        End If
    End Sub

    Public Sub SaveBMP()

        SaveFileDialog1.FileName = "Cube Image"
        SaveFileDialog1.Filter = "bmp|*.bmp|All Files (*.*)|*.*"
        SaveFileDialog1.DefaultExt = ".bmp"
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

        SaveFileName = SaveFileDialog1.FileName
        My.Settings.SaveBMPFileName = SaveFileName
        If PictureBox2.Image Is Nothing Then Exit Sub
        PictureBox2.Image.Save(SaveFileName)

    End Sub

    Public Sub Main()

        TextBox1.Clear()
        SaveFileName = My.Settings.SaveBMPFileName
        If SaveFileName = "" Or My.Computer.FileSystem.FileExists(SaveFileName) = False Then
            Dim message As String = "  Please specify a filename and path before proceeding."
            Dim caption As String = "Color Scan"
            Dim result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SaveBMP()
        End If
        My.Settings.SaveBMPFileName = SaveFileName
        My.Settings.Save()

        '************************************  'Main routine starts here
        If CheckBox_Test.Checked = True Then
            ScanCube() 'take a snapshot of the video, break the bitmap down into 9 sub bitmaps and then determine the color of each cubelt
            Exit Sub
        End If


        CubeString = ""     'clear the CubeString variable

        Flip()              'send a command to flip the cube once
        wait()              'wait a few seconds for the action to take place
        ScanCube()          'scan yellow face
        pause()             'wait until the scanning process has completed

        If startToggle = 0 Then Exit Sub

        If cubelet4.BackColor <> Color.Yellow Then
            MessageBox.Show("The cube is not oriented correctly. Orient the cube so that the Blue face is pointing up and the Yellow face is pointing towards the push arm.", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            startToggle = 0 : btnStart.Text = "Start"
            Exit Sub
        End If

        CubeString = ""
        Flip()
        wait()
        Flip()              'scan white face
        wait()
        ScanCube()
        pause()

        If startToggle = 0 Then Exit Sub

        CubeString = ""
        Rotate_CW()
        wait()
        Flip()
        wait()
        Rotate_CCW()
        wait()              'scan red face
        Flip()
        wait()
        Flip()
        wait()
        Rotate_CW()
        wait()
        ScanCube()
        pause()

        If startToggle = 0 Then Exit Sub

        CubeString = ""
        Rotate_CCW()
        wait()
        Flip()
        wait()               'scan green face
        Rotate_CW()
        wait()
        ScanCube()
        pause()

        If startToggle = 0 Then Exit Sub

        CubeString = ""
        Rotate_CCW()
        wait()
        Flip()
        wait()               'scan orange face
        Rotate_CW()
        wait()
        ScanCube()
        pause()

        If startToggle = 0 Then Exit Sub

        CubeString = ""
        Rotate_CCW()
        wait()
        Flip()
        wait()               'scan blue face
        Rotate_CW()
        wait()
        ScanCube()
        pause()

        FullCubeString = yellowString & whiteString & redString & blueString & greenString & orangeString
        Try
            For sclr = 1 To 6
                Dim count As Integer
                Dim letter As Char
                If sclr = 1 Then letter = "r" : If sclr = 2 Then letter = "o" : If sclr = 3 Then letter = "y" : If sclr = 4 Then letter = "w" : If sclr = 5 Then letter = "g" : If sclr = 6 Then letter = "b"
                For Each c As Char In FullCubeString
                    If c = letter Then
                        count += 1
                    End If
                Next
                If count <> 9 Then Exit For : MessageBox.Show("Error while scanning colors, incorrect count.", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
            Next
        Catch ex As Exception
            MessageBox.Show("An error has occurred", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        End Try

        If FullCubeString.Count <> 54 Then
            MessageBox.Show("An error while scanning colors.", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Else
            stringTextbx.Text = FullCubeString
            Dim dr As DialogResult = MessageBox.Show("Proceed to solve cube?", "CubeScan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (Not System.Windows.Forms.DialogResult.Yes = dr) Then
                Exit Sub
            End If
        End If

        Rotate_CCW()
        wait()
        Flip()
        wait()
        Flip()
        wait()
        Flip()      'move to starting position
        wait()
        Rotate_CCCW()
        wait()
        Flip()
        wait()
        Rotate_CCW()
        wait()
        Flip()
        wait()

        If myport.IsOpen = False Then
            myport.Open()
        End If
        myport.WriteTimeout = 500
        myport.ReadTimeout = 500
        myport.WriteLine("Go#" & FullCubeString)

    End Sub

    Public Sub wait()

        waitstate = False
        TimerWait.Interval = 4000
        TimerWait.Enabled = True
        While waitstate = False
            Application.DoEvents()
        End While
    End Sub

    Private Sub TimerWait_Tick(sender As System.Object, e As System.EventArgs) Handles TimerWait.Tick
        TimerWait.Enabled = False
        waitstate = True
    End Sub

    Public Sub pause()
        While scan_done = False
            Application.DoEvents()
        End While
    End Sub
    Public Sub ScanCube()

        scan_done = False
        cam.SaveCurrentFrame(SaveFileName, Imaging.ImageFormat.Bmp)
        Label_Working.Text = "Working..."
        Timer2.Interval = 1000 'Send snapshot to hd, then scan cube
        Timer2.Enabled = True

    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        PictureBox2.LoadAsync(SaveFileName)
        Timer1.Interval = 1000
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        ScanAllCubelets()
    End Sub

    Public Sub ScanAllCubelets()

        Try
            screenshot = New Bitmap(PictureBox2.Width, PictureBox2.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            PictureBox2.DrawToBitmap(screenshot, New Rectangle(0, 0, screenshot.Width, screenshot.Height))
            bitmapcopy = New Bitmap(screenshot.Width, screenshot.Height, screenshot.PixelFormat)
            Using g As Graphics = Graphics.FromImage(bitmapcopy)
                g.DrawImage(screenshot, New Point(0, 0))
                g.Dispose()
            End Using

            '************

            bmapStartHeight = Form2.TrackBar1.Value                             ' |0||1||2|
            bmapEndHeight = 80 - Form2.TrackBar1.Value                          ' |3||4||5|
            bmapStartWidth = Form2.TrackBar1.Value                              ' |6||7||8|   cubelet numbering sequence
            bmapEndWidth = 80 - Form2.TrackBar1.Value
            ColorIntensity()
            cubelet0.BackColor = cubeletColor : Form2.c0.BackColor = cubeletColor
            tempText = (cubelet0.BackColor.ToString)
            ReplaceColorString()

            bmapStartHeight = Form2.TrackBar1.Value
            bmapEndHeight = 80 - Form2.TrackBar1.Value
            bmapStartWidth = 80 + Form2.TrackBar1.Value
            bmapEndWidth = 160 - Form2.TrackBar1.Value
            ColorIntensity()
            cubelet1.BackColor = cubeletColor : Form2.c1.BackColor = cubeletColor
            tempText = (cubelet1.BackColor.ToString)
            ReplaceColorString()

            bmapStartHeight = Form2.TrackBar1.Value
            bmapEndHeight = 80 - Form2.TrackBar1.Value
            bmapStartWidth = 160 + Form2.TrackBar1.Value
            bmapEndWidth = 240 - Form2.TrackBar1.Value
            ColorIntensity()
            cubelet2.BackColor = cubeletColor : Form2.c2.BackColor = cubeletColor
            tempText = (cubelet2.BackColor.ToString)
            ReplaceColorString()

            bmapStartHeight = 80 + Form2.TrackBar1.Value
            bmapEndHeight = 160 - Form2.TrackBar1.Value
            bmapStartWidth = Form2.TrackBar1.Value
            bmapEndWidth = 80 - Form2.TrackBar1.Value
            ColorIntensity()
            cubelet3.BackColor = cubeletColor : Form2.c3.BackColor = cubeletColor
            tempText = (cubelet3.BackColor.ToString)
            ReplaceColorString()

            bmapStartHeight = 80 + Form2.TrackBar1.Value
            bmapEndHeight = 160 - Form2.TrackBar1.Value
            bmapStartWidth = 80 + Form2.TrackBar1.Value                   'Face Center cubelet--cubelet #4
            bmapEndWidth = 160 - Form2.TrackBar1.Value
            ColorIntensity()
            cubelet4.BackColor = cubeletColor : Form2.c4.BackColor = cubeletColor
            tempText = (cubelet4.BackColor.ToString)
            FaceColor = tempText
            ReplaceColorString()
            Label_Working.Text = tempText & " Face"

            bmapStartHeight = 80 + Form2.TrackBar1.Value
            bmapEndHeight = 160 - Form2.TrackBar1.Value
            bmapStartWidth = 160 + Form2.TrackBar1.Value
            bmapEndWidth = 240 - Form2.TrackBar1.Value
            ColorIntensity()
            cubelet5.BackColor = cubeletColor : Form2.c5.BackColor = cubeletColor
            tempText = (cubelet5.BackColor.ToString)
            ReplaceColorString()

            bmapStartHeight = 160 + Form2.TrackBar1.Value
            bmapEndHeight = 240 - Form2.TrackBar1.Value
            bmapStartWidth = Form2.TrackBar1.Value
            bmapEndWidth = 80 - Form2.TrackBar1.Value
            ColorIntensity()
            cubelet6.BackColor = cubeletColor : Form2.c6.BackColor = cubeletColor
            tempText = (cubelet6.BackColor.ToString)
            ReplaceColorString()

            bmapStartHeight = 160 + Form2.TrackBar1.Value
            bmapEndHeight = 240 - Form2.TrackBar1.Value
            bmapStartWidth = 80 + Form2.TrackBar1.Value
            bmapEndWidth = 160 - Form2.TrackBar1.Value
            ColorIntensity()
            cubelet7.BackColor = cubeletColor : Form2.c7.BackColor = cubeletColor
            tempText = (cubelet7.BackColor.ToString)
            ReplaceColorString()

            bmapStartHeight = 160 + Form2.TrackBar1.Value
            bmapEndHeight = 240 - Form2.TrackBar1.Value
            bmapStartWidth = 160 + Form2.TrackBar1.Value
            bmapEndWidth = 240 - Form2.TrackBar1.Value
            ColorIntensity()
            cubelet8.BackColor = cubeletColor : Form2.c8.BackColor = cubeletColor
            tempText = (cubelet8.BackColor.ToString)
            ReplaceColorString()

            screenshot.Dispose()
            bitmapcopy.Dispose()
            GC.Collect()
            '*******************************************
            If FaceColor.Contains("Red") Then redString = CubeString
            If FaceColor.Contains("Green") Then greenString = CubeString
            If FaceColor.Contains("Blue") Then blueString = CubeString
            If FaceColor.Contains("White") Then whiteString = CubeString
            If FaceColor.Contains("Orange") Then orangeString = CubeString
            If FaceColor.Contains("Yellow") Then yellowString = CubeString
            '********************************************
            TextBox2.AppendText(FaceColor.Replace("Color", "").Replace("[", "").Replace("]", "") & " face= " & CubeString & vbCrLf)

            If CubeString.Count <> 9 Then
                MessageBox.Show("Unable to decipher colors correctly, adjust lighting or camera and try again.", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Stop) : CubeString = "" : Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("An unknown error occurred.", "CubeScan", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ReplaceColorString()

        stringColorChr = ""
        tempText = tempText.Replace("Color", "") : tempText = tempText.Replace("[", "") : tempText = tempText.Replace("]", "")

        If tempText.Contains("Red") Then stringColorChr = "r"
        If tempText.Contains("Green") Then stringColorChr = "g"
        If tempText.Contains("White") Then stringColorChr = "w"
        If tempText.Contains("Blue") Then stringColorChr = "b"
        If tempText.Contains("Yellow") Then stringColorChr = "y"
        If tempText.Contains("Orange") Then stringColorChr = "o"
        If tempText.Contains("Black") Then Exit Sub : MessageBox.Show("An error was encountered." & vbCrLf & "Check lighting and try again.", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Error)

        CubeString = CubeString & (stringColorChr)

        '*********************************

        'Loop six times and then concecate the different colored strings in the correct order and transmit them to the Arduino
        ' FullCubeString = yellowString & whiteString & redString & blueString & greenString & orangeString-- in this order

    End Sub

    Public Sub ColorIntensity() 'loop through the bitmap array, get the total rgb pixel values of the cubelet, then average the values

        redTotal = 0
        greenTotal = 0
        blueTotal = 0
        Try
            Dim PixelColor As Color

            For x = bmapStartWidth To bmapEndWidth

                For y = bmapStartHeight To bmapEndHeight
                    PixelColor = bitmapcopy.GetPixel(x, y)
                    Rd = PixelColor.R
                    Gr = PixelColor.G
                    Bl = PixelColor.B
                    redTotal = Rd + redTotal
                    greenTotal = Gr + greenTotal
                    blueTotal = Bl + blueTotal
                Next
            Next

            redValue = Math.Round(redTotal / 6400)
            greenValue = Math.Round(greenTotal / 6400)
            blueValue = Math.Round(blueTotal / 6400)

            TextBox1.AppendText("[Cubelet " & cubeletCount & "]" & vbCrLf & "Red Value=" & redValue & vbCrLf & "Green Value=" & greenValue & vbCrLf & "Blue Value=" & blueValue & vbCrLf & vbCrLf)
            cubeletCount += 1
            'If cubeletCount > 8 Then cubeletCount = 0 : TextBox1.AppendText("|0| |1| |2|" & vbCrLf & "|3| |4| |5|" & vbCrLf & "|6| |7| |8|")
            TextBox1.SelectionStart = 0 : TextBox1.ScrollToCaret()


        Catch ex As Exception
            MessageBox.Show("An error has occurred", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cubeletColor = Nothing
        DetermineColor()

    End Sub

    Public Sub DetermineColor() 'determine color by reading cubelet rgb pixel average values

        If redValue > (blueValue * 1.8) And greenValue > (blueValue * 1.3) And greenValue > (blueValue * 1.2) Then
            cubeletColor = Color.Orange
        End If

        If Math.Abs(greenValue - redValue) < 20 And Math.Abs(redValue - blueValue) < 20 And Math.Abs(greenValue - blueValue) < 20 Then
            cubeletColor = Color.White
        End If

        If blueValue > redValue * 2.4 And blueValue > greenValue * 1.6 And greenValue > (redValue) Then
            cubeletColor = Color.Blue

        End If
        If redValue >= blueValue * 1.3 And redValue >= greenValue * 1.4 And Math.Abs(greenValue - blueValue) <= 30 Then
            cubeletColor = Color.Red

        End If
        If greenValue > redValue * 1.7 And greenValue > blueValue * 1.1 Then
            cubeletColor = Color.Green

        End If
        If greenValue > blueValue * 1.3 And redValue > blueValue * 1.2 And Math.Abs(redValue - greenValue) <= 20 Then
            cubeletColor = Color.Yellow

        End If
        If cubeletColor <> Color.Orange And cubeletColor <> Color.White And cubeletColor <> Color.Blue And cubeletColor <> Color.Red And cubeletColor <> Color.Green And cubeletColor <> Color.Yellow Then
            cubeletColor = Color.Black
            Exit Sub : MessageBox.Show("A scanning error was encountered." & vbCrLf & "Check lighting and/or adjust scan size setting and try again.", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Error) : Main()
        End If

        blueTotal = 0 : redTotal = 0 : greenTotal = 0
        scan_done = True    'ends here

    End Sub

    Public Sub Send_Full_String() 'send the entire 54 character color string to the Arduino board for solving cube

        If myport.IsOpen = False Then
            myport.Open()
        End If
        myport.WriteTimeout = 500
        myport.ReadTimeout = 500
        myport.WriteLine("Go#" & FullCubeString)

    End Sub
    '********************************Mechanism Control Buttons*************************************
    Private Sub btnFlip_Click(sender As System.Object, e As System.EventArgs) Handles btnFlip.Click

        Flip()

    End Sub

    Public Sub Flip()

        Try
            If myport.IsOpen = False Then
                myport.Open()
            End If

            myport.WriteTimeout = 500
            myport.ReadTimeout = 500
            myport.WriteLine("P#")
        Catch ex As Exception
            MessageBox.Show("Serial port error.", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnP1_Click(sender As System.Object, e As System.EventArgs) Handles btnP1.Click

        Rotate_CCW()

    End Sub

    Public Sub Rotate_CCW()

        Try
            If myport.IsOpen = False Then
                myport.Open()
            End If

            myport.WriteTimeout = 500
            myport.ReadTimeout = 500
            myport.WriteLine("1#")
        Catch ex As Exception
            MessageBox.Show("Serial port error.", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnP2_Click(sender As System.Object, e As System.EventArgs) Handles btnP2.Click
        Rotate_CW()
    End Sub

    Public Sub Rotate_CW()

        Try
            If myport.IsOpen = False Then
                myport.Open()
            End If

            myport.WriteTimeout = 500
            myport.ReadTimeout = 500
            myport.WriteLine("2#")
        Catch ex As Exception
            MessageBox.Show("Serial port error.", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnP3_Click(sender As System.Object, e As System.EventArgs) Handles btnP3.Click

        Rotate_CCCW()

    End Sub

    Public Sub Rotate_CCCW()

        Try
            If myport.IsOpen = False Then
                myport.Open()
            End If

            myport.WriteTimeout = 500
            myport.ReadTimeout = 500
            myport.WriteLine("3#")
        Catch ex As Exception
            MessageBox.Show("Serial port error.", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnSendString_Click(sender As System.Object, e As System.EventArgs) Handles btnSendString.Click

        If stringTextbx.Text = "" Then MessageBox.Show("No string to send!", "CubeScan", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        FullCubeString = stringTextbx.Text
        Send_Full_String()

    End Sub
    '*********************************Menu Items****************************************

    Private Sub SaveAsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click

        SaveFileDialog2.FileName = "CubeString"
        SaveFileDialog2.DefaultExt = ".txt"
        SaveFileDialog2.Filter = "txt|*.txt|All Files (*.*)|*.*"
        SaveFileDialog2.ShowDialog()
        SaveStringFileName = SaveFileDialog2.FileName
        IO.File.WriteAllText(SaveFileDialog2.FileName, stringTextbx.Text)

    End Sub

    Private Sub CustomizeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomizeToolStripMenuItem.Click
        Form2.Visible = True
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        Form3.Visible = True
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Form4.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        My.Settings.Save()
        Try
            cam.Pause()
            cam.Dispose()
            If connected = True Then myport.Close()

            Application.Exit()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub SaveBitmap_Click(sender As System.Object, e As System.EventArgs) Handles SaveBitmap.Click
        SaveBMP()
    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        My.Settings.Save()
        Try
            cam.Pause()
            cam.Dispose()
            System.Threading.Thread.Sleep(100)
            If connected = True Then myport.Close()

        Catch ex As Exception

        End Try

    End Sub

End Class
