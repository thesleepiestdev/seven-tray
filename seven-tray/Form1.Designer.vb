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
        Me.iconvolume = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.volumerclickmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BTNOpenVolumeMixer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTNPlaybackDevices = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNRecordingDevices = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNSounds = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTNVolumeControlOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.volumerclickmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'iconvolume
        '
        Me.iconvolume.ContextMenuStrip = Me.volumerclickmenu
        Me.iconvolume.Text = "The Audio Service is not running."
        Me.iconvolume.Visible = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'volumerclickmenu
        '
        Me.volumerclickmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTNOpenVolumeMixer, Me.ToolStripSeparator1, Me.BTNPlaybackDevices, Me.BTNRecordingDevices, Me.BTNSounds, Me.ToolStripSeparator2, Me.BTNVolumeControlOptions})
        Me.volumerclickmenu.Name = "volumerclickmenu"
        Me.volumerclickmenu.Size = New System.Drawing.Size(199, 126)
        '
        'BTNOpenVolumeMixer
        '
        Me.BTNOpenVolumeMixer.Name = "BTNOpenVolumeMixer"
        Me.BTNOpenVolumeMixer.Size = New System.Drawing.Size(198, 22)
        Me.BTNOpenVolumeMixer.Text = "Open Volume Mixer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        'BTNPlaybackDevices
        '
        Me.BTNPlaybackDevices.Name = "BTNPlaybackDevices"
        Me.BTNPlaybackDevices.Size = New System.Drawing.Size(198, 22)
        Me.BTNPlaybackDevices.Text = "Playback devices"
        '
        'BTNRecordingDevices
        '
        Me.BTNRecordingDevices.Name = "BTNRecordingDevices"
        Me.BTNRecordingDevices.Size = New System.Drawing.Size(198, 22)
        Me.BTNRecordingDevices.Text = "Recording devices"
        '
        'BTNSounds
        '
        Me.BTNSounds.Name = "BTNSounds"
        Me.BTNSounds.Size = New System.Drawing.Size(198, 22)
        Me.BTNSounds.Text = "Sounds"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(195, 6)
        '
        'BTNVolumeControlOptions
        '
        Me.BTNVolumeControlOptions.Name = "BTNVolumeControlOptions"
        Me.BTNVolumeControlOptions.Size = New System.Drawing.Size(198, 22)
        Me.BTNVolumeControlOptions.Text = "Volume control options"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(0, 0)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "seven-tray main"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.volumerclickmenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents iconvolume As System.Windows.Forms.NotifyIcon
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents volumerclickmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BTNOpenVolumeMixer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTNPlaybackDevices As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BTNRecordingDevices As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BTNSounds As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTNVolumeControlOptions As System.Windows.Forms.ToolStripMenuItem

End Class
