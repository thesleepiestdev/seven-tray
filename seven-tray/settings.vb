Public Class settings

    Private Sub CHKNet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKNet.CheckedChanged
        If CHKNet.Checked = True Then
            GroupBox2.Show()
        Else
            GroupBox2.Hide()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
    End Sub

    Private Sub BTNQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNQuit.Click
        Form1.Close()
    End Sub

    Private Sub settings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Settings.NetEnabled = True Then
            CHKNet.Checked = True
        End If
        If My.Settings.NetType = 1 Then
            RADWifi.Checked = True
        End If
    End Sub
End Class