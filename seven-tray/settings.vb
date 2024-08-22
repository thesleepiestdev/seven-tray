Public Class settings
    Private Sub SaveSettings()
        If CHKNet.Checked = True Then
            My.Settings.NetEnabled = True
            If RADEth.Checked = True Then
                My.Settings.NetType = 0
            Else
                My.Settings.NetType = 1
            End If
        Else
            My.Settings.NetEnabled = False
        End If
        If CHKActionCenter.Checked = True Then
            My.Settings.ActionCenterEnabled = 1
        Else
            My.Settings.ActionCenterEnabled = 0
        End If
    End Sub

    Private Sub CHKNet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKNet.CheckedChanged, CHKActionCenter.CheckedChanged
        If CHKNet.Checked = True Then
            GroupBox2.Show()
        Else
            GroupBox2.Hide()
        End If
    End Sub

    Private Sub settings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Settings.NetEnabled = True Then
            CHKNet.Checked = True
        End If
        If My.Settings.NetType = 1 Then
            RADWifi.Checked = True
        End If
        If My.Settings.ActionCenterEnabled = True Then
            CHKActionCenter.Checked = True
        End If
    End Sub

    Private Sub BTNQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNQuit.Click
        SaveSettings()
        Form1.Close()
    End Sub
    Private Sub BTNCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub BTNDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNDone.Click
        SaveSettings()
    End Sub

    Private Sub GitHubURL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GitHubURL.LinkClicked
        Process.Start("https://github.com/thesleepiestdev/seven-tray")
    End Sub
End Class