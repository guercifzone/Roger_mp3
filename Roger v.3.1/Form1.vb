Public Class Form1
    Dim currentTrack As Integer
    Dim repeatMode As String = "none"
    Dim gen As System.Random = New System.Random()
    Dim random As Boolean = False
    Dim tempInt As Integer

#Region " movin form"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
#End Region


    Private Sub Txt_Load_TextChanged(sender As Object, e As EventArgs) Handles Txt_Load.TextChanged
        ListBox_Track.Items.Clear()
        If Not Txt_Load.Text = "" Then
            For Each file As String In My.Computer.FileSystem.GetFiles(Txt_Load.Text, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.mp3")
                ListBox_Track.Items.Add(file)
            Next
        End If
    End Sub
    Private Sub ListBox_Track_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Track.SelectedIndexChanged
        WMP.URL = ListBox_Track.SelectedItem.ToString
        currentTrack = ListBox_Track.SelectedIndex
    End Sub
    Private Sub NotifyIcon_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon.DoubleClick
        Me.Visible = True
    End Sub
    Private Sub WMP_MediaChange(sender As Object, e As AxWMPLib._WMPOCXEvents_MediaChangeEvent) Handles WMP.MediaChange
        TrackNameToolStripMenuItem.Text = ListBox_Track.Items(currentTrack)
    End Sub
    Private Sub WMP_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles WMP.PlayStateChange
        Static Dim play As Boolean = True

        Select Case WMP.playState
            Case 10
                If play Then
                    WMP.Ctlcontrols.play()

                End If
            Case 8
                If random Then
                    play = False
                    tempInt = gen.Next(0, ListBox_Track.Items.Count + 1)
                    WMP.URL = ListBox_Track.Items(tempInt)
                    currentTrack = tempInt
                    play = True
                Else
                    play = False
                    If repeatMode = "track" Then
                        WMP.URL = ListBox_Track.Items(currentTrack)
                        play = True
                        Exit Sub
                    End If
                    If currentTrack = (ListBox_Track.Items.Count - 1) Then
                        If repeatMode = "all" Then
                            WMP.URL = ListBox_Track.Items(0)
                            currentTrack = 0
                        End If
                    Else
                        WMP.URL = ListBox_Track.Items(currentTrack + 1)
                        currentTrack += 1

                    End If
                End If
                play = True

        End Select
    End Sub

#Region "buton option"

    Private Sub Btn_hide_MouseHover(sender As Object, e As EventArgs) Handles Btn_hide.MouseHover
        '309; 23
        Btn_hide.Size = New System.Drawing.Point(315, 25)
        Btn_hide.ForeColor = Color.CadetBlue
        Btn_hide.BackColor = Color.Black
    End Sub

    Private Sub Btn_hide_MouseLeave(sender As Object, e As EventArgs) Handles Btn_hide.MouseLeave
        Btn_hide.Size = New System.Drawing.Point(309, 23)
        Btn_hide.ForeColor = Color.Black
        Btn_hide.BackColor = Color.White
    End Sub
    Private Sub Btn_hide_Click(sender As Object, e As EventArgs) Handles Btn_hide.Click
        Me.Hide()
    End Sub
    Private Sub Btn_load_Click(sender As Object, e As EventArgs) Handles Btn_load.Click
        Dim open As New FolderBrowserDialog
        If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Txt_Load.Text = open.SelectedPath.ToString
        End If
    End Sub
    Private Sub Btn_load_MouseHover(sender As Object, e As EventArgs) Handles Btn_load.MouseHover
        '85; 23
        Btn_load.Size = New System.Drawing.Point(90, 25)
        Btn_load.ForeColor = Color.CadetBlue
        Btn_load.BackColor = Color.Black
    End Sub

    Private Sub Btn_load_MouseLeave(sender As Object, e As EventArgs) Handles Btn_load.MouseLeave
        Btn_load.Size = New System.Drawing.Point(85, 23)
        Btn_load.ForeColor = Color.Black
        Btn_load.BackColor = Color.White
    End Sub
#End Region

#Region "tools menuscript"
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SelectTrackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectTrackToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        If currentTrack = (ListBox_Track.Items.Count - 1) Then
            WMP.URL = ListBox_Track.Items(0)
            currentTrack = 0
        Else

            WMP.URL = ListBox_Track.Items(currentTrack + 1)
            currentTrack += 1

        End If
    End Sub

    Private Sub PreviousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviousToolStripMenuItem.Click
        If currentTrack = 0 Then
            WMP.URL = ListBox_Track.Items(ListBox_Track.Items.Count - 1)
            currentTrack = ListBox_Track.Items.Count - 1
        Else

            WMP.URL = ListBox_Track.Items(currentTrack - 1)
            currentTrack -= 1

        End If
    End Sub

    Private Sub PlayPauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayPauseToolStripMenuItem.Click
        If WMP.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            WMP.Ctlcontrols.pause()
        ElseIf WMP.playState = WMPLib.WMPPlayState.wmppsPaused Then
            WMP.Ctlcontrols.play()

        End If
    End Sub

    Private Sub RepeatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepeatToolStripMenuItem.Click
        repeatMode = "track"
        RepeatNoneToolStripMenuItem.Text = "Repeat [Track]"
    End Sub

    Private Sub RepeatALLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepeatALLToolStripMenuItem.Click
        repeatMode = "ALL"
        RepeatNoneToolStripMenuItem.Text = "Repeat [ALL]"
    End Sub

    Private Sub NoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoneToolStripMenuItem.Click
        repeatMode = "None"
        RepeatNoneToolStripMenuItem.Text = "Repeat [None]"
    End Sub

    Private Sub RandomOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RandomOffToolStripMenuItem.Click
        If random = True Then
            random = False
            RandomOffToolStripMenuItem.Text = "Random {Off}"
        Else
            random = True
            RandomOffToolStripMenuItem.Text = "Random {On}"
        End If
    End Sub

#End Region






    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim url As String = "https://www.youtube.com/channel/UCZr2VGmXdJ-yGLUZztCVFGw"
        Process.Start(url)
    End Sub
End Class
