Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UpdateVolumeIcon()
        volumerclickmenu.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        UpdateVolumeIcon()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = Keys.VolumeUp Or keyData = Keys.VolumeDown Or keyData = Keys.VolumeMute Then
            UpdateVolumeIcon()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub BTNOpenVolumeMixer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNOpenVolumeMixer.Click
        Process.Start("sndvol")
    End Sub
    Private Sub UpdateVolumeIcon()
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo(Application.StartupPath & "\adjust_get_current_system_volume_vista_plus.exe")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oStartInfo.CreateNoWindow = True
        oProcess.StartInfo = oStartInfo
        Try
            oProcess.Start()
        Catch ex As Exception
        End Try


        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using

        Dim volume As Integer
        If Integer.TryParse(sOutput, volume) Then
            Select Case volume
                Case 0
                    iconvolume.Icon = My.Resources.vol_0
                Case 1 To 32
                    iconvolume.Icon = My.Resources.vol_1_32
                Case 33 To 65
                    iconvolume.Icon = My.Resources.vol_33_65
                Case 66 To 100
                    iconvolume.Icon = My.Resources.vol_66_100
            End Select
            iconvolume.Text = "Speakers: " & volume & "%"
        End If
    End Sub

    Private Sub iconvolume_Click(ByVal sender As Object, ByVal e As MouseEventArgs) Handles iconvolume.Click
        If e.Button = MouseButtons.Left Then
            Process.Start("sndvol", "-f 26214900")
        End If
    End Sub

    Private Sub iconvolume_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles iconvolume.MouseMove
        UpdateVolumeIcon()
    End Sub

    Private Sub BTNPlaybackDevices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNPlaybackDevices.Click
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("cmd.exe", "/c mmsys.cpl,0")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oStartInfo.CreateNoWindow = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
    End Sub

    Private Sub BTNRecordingDevices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNRecordingDevices.Click
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("cmd.exe", "/c mmsys.cpl,1")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oStartInfo.CreateNoWindow = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
    End Sub

    Private Sub BTNSounds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSounds.Click
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("cmd.exe", "/c mmsys.cpl,2")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oStartInfo.CreateNoWindow = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
    End Sub

    Private Sub BTNVolumeControlOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNVolumeControlOptions.Click
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("cmd.exe", "/c %systemroot%\system32\msdt.exe -id AudioPlaybackDiagnostic")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oStartInfo.CreateNoWindow = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()
    End Sub
End Class
