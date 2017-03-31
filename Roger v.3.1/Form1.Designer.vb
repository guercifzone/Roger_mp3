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
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TrackNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectTrackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayPauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatNoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RandomOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox_Track = New System.Windows.Forms.ListBox()
        Me.Btn_hide = New System.Windows.Forms.Button()
        Me.Btn_load = New System.Windows.Forms.Button()
        Me.WMP = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Txt_Load = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ContextMenuStrip.SuspendLayout()
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.ContextMenuStrip
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "NotifyIcon"
        Me.NotifyIcon.Visible = True
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrackNameToolStripMenuItem, Me.ToolStripSeparator1, Me.SelectTrackToolStripMenuItem, Me.PlayPauseToolStripMenuItem, Me.NextToolStripMenuItem, Me.PreviousToolStripMenuItem, Me.RepeatNoneToolStripMenuItem, Me.RandomOffToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(151, 192)
        '
        'TrackNameToolStripMenuItem
        '
        Me.TrackNameToolStripMenuItem.Name = "TrackNameToolStripMenuItem"
        Me.TrackNameToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TrackNameToolStripMenuItem.Text = "&Track Name"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        'SelectTrackToolStripMenuItem
        '
        Me.SelectTrackToolStripMenuItem.Name = "SelectTrackToolStripMenuItem"
        Me.SelectTrackToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SelectTrackToolStripMenuItem.Text = "&Select Track"
        '
        'PlayPauseToolStripMenuItem
        '
        Me.PlayPauseToolStripMenuItem.Name = "PlayPauseToolStripMenuItem"
        Me.PlayPauseToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PlayPauseToolStripMenuItem.Text = "&Play/Pause"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NextToolStripMenuItem.Text = "&Next"
        '
        'PreviousToolStripMenuItem
        '
        Me.PreviousToolStripMenuItem.Name = "PreviousToolStripMenuItem"
        Me.PreviousToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PreviousToolStripMenuItem.Text = "&Previous"
        '
        'RepeatNoneToolStripMenuItem
        '
        Me.RepeatNoneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RepeatToolStripMenuItem, Me.RepeatALLToolStripMenuItem, Me.NoneToolStripMenuItem})
        Me.RepeatNoneToolStripMenuItem.Name = "RepeatNoneToolStripMenuItem"
        Me.RepeatNoneToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.RepeatNoneToolStripMenuItem.Text = "&Repeat [None]"
        '
        'RepeatToolStripMenuItem
        '
        Me.RepeatToolStripMenuItem.Name = "RepeatToolStripMenuItem"
        Me.RepeatToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.RepeatToolStripMenuItem.Text = "&Repeat Track"
        '
        'RepeatALLToolStripMenuItem
        '
        Me.RepeatALLToolStripMenuItem.Name = "RepeatALLToolStripMenuItem"
        Me.RepeatALLToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.RepeatALLToolStripMenuItem.Text = "&Repeat ALL"
        '
        'NoneToolStripMenuItem
        '
        Me.NoneToolStripMenuItem.Name = "NoneToolStripMenuItem"
        Me.NoneToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.NoneToolStripMenuItem.Text = "&None"
        '
        'RandomOffToolStripMenuItem
        '
        Me.RandomOffToolStripMenuItem.Name = "RandomOffToolStripMenuItem"
        Me.RandomOffToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.RandomOffToolStripMenuItem.Text = "&Random [Off]"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(147, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ListBox_Track
        '
        Me.ListBox_Track.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ListBox_Track.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListBox_Track.FormattingEnabled = True
        Me.ListBox_Track.Location = New System.Drawing.Point(13, 13)
        Me.ListBox_Track.Name = "ListBox_Track"
        Me.ListBox_Track.Size = New System.Drawing.Size(309, 186)
        Me.ListBox_Track.TabIndex = 1
        '
        'Btn_hide
        '
        Me.Btn_hide.BackColor = System.Drawing.Color.White
        Me.Btn_hide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_hide.Location = New System.Drawing.Point(13, 285)
        Me.Btn_hide.Name = "Btn_hide"
        Me.Btn_hide.Size = New System.Drawing.Size(309, 23)
        Me.Btn_hide.TabIndex = 2
        Me.Btn_hide.Text = "&Hide Me"
        Me.Btn_hide.UseVisualStyleBackColor = False
        '
        'Btn_load
        '
        Me.Btn_load.BackColor = System.Drawing.Color.White
        Me.Btn_load.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_load.Location = New System.Drawing.Point(237, 256)
        Me.Btn_load.Name = "Btn_load"
        Me.Btn_load.Size = New System.Drawing.Size(85, 23)
        Me.Btn_load.TabIndex = 3
        Me.Btn_load.Text = "&Load Folder"
        Me.Btn_load.UseVisualStyleBackColor = False
        '
        'WMP
        '
        Me.WMP.Enabled = True
        Me.WMP.Location = New System.Drawing.Point(13, 205)
        Me.WMP.Name = "WMP"
        Me.WMP.OcxState = CType(resources.GetObject("WMP.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMP.Size = New System.Drawing.Size(309, 45)
        Me.WMP.TabIndex = 4
        '
        'Txt_Load
        '
        Me.Txt_Load.Location = New System.Drawing.Point(13, 258)
        Me.Txt_Load.Name = "Txt_Load"
        Me.Txt_Load.ReadOnly = True
        Me.Txt_Load.Size = New System.Drawing.Size(218, 20)
        Me.Txt_Load.TabIndex = 5
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 311)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(124, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "&My Youtube Channel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(334, 332)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Txt_Load)
        Me.Controls.Add(Me.WMP)
        Me.Controls.Add(Me.Btn_load)
        Me.Controls.Add(Me.Btn_hide)
        Me.Controls.Add(Me.ListBox_Track)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Roger v.3.1"
        Me.ContextMenuStrip.ResumeLayout(False)
        CType(Me.WMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TrackNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectTrackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayPauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatNoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RandomOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatALLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox_Track As System.Windows.Forms.ListBox
    Friend WithEvents Btn_hide As System.Windows.Forms.Button
    Friend WithEvents Btn_load As System.Windows.Forms.Button
    Friend WithEvents WMP As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Txt_Load As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
