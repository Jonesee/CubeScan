Public Class Form2
    Public cSize As Integer
    Public tbv As Integer
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label_Trackbar.Text = TrackBar1.Value
        tbv = TrackBar1.Value
        ResizeGrid()

    End Sub

    Private Sub Button_Done_Click(sender As System.Object, e As System.EventArgs) Handles Button_Done.Click
        Me.Visible = False
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        Label_Trackbar.Text = TrackBar1.Value
        tbv = TrackBar1.Value
        ResizeGrid()
    End Sub

    Public Sub ResizeGrid()
        cSize = 18 - TrackBar1.Value
        c0.Height = cSize : c0.Width = cSize : c1.Height = cSize : c1.Width = cSize : c2.Height = cSize : c2.Width = cSize : c3.Height = cSize : c3.Width = cSize : c4.Height = cSize : c4.Width = cSize
        c5.Height = cSize : c5.Width = cSize : c6.Height = cSize : c6.Width = cSize : c7.Height = cSize : c7.Width = cSize : c8.Height = cSize : c8.Width = cSize

        Panel1.Location = New Point(287 + tbv / 2, 54 + tbv / 2)
    End Sub
  
End Class