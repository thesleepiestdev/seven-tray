<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CHKActionCenter = New System.Windows.Forms.CheckBox()
        Me.CHKNet = New System.Windows.Forms.CheckBox()
        Me.CHKVol = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RADWifi = New System.Windows.Forms.RadioButton()
        Me.RADEth = New System.Windows.Forms.RadioButton()
        Me.BTNDone = New System.Windows.Forms.Button()
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.BTNQuit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GitHubURL = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CHKActionCenter)
        Me.GroupBox1.Controls.Add(Me.CHKNet)
        Me.GroupBox1.Controls.Add(Me.CHKVol)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 95)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "enabled icons"
        '
        'CHKActionCenter
        '
        Me.CHKActionCenter.AutoSize = True
        Me.CHKActionCenter.Location = New System.Drawing.Point(7, 67)
        Me.CHKActionCenter.Name = "CHKActionCenter"
        Me.CHKActionCenter.Size = New System.Drawing.Size(90, 17)
        Me.CHKActionCenter.TabIndex = 1
        Me.CHKActionCenter.Text = "Action Center"
        Me.CHKActionCenter.UseVisualStyleBackColor = True
        '
        'CHKNet
        '
        Me.CHKNet.AutoSize = True
        Me.CHKNet.Location = New System.Drawing.Point(7, 44)
        Me.CHKNet.Name = "CHKNet"
        Me.CHKNet.Size = New System.Drawing.Size(66, 17)
        Me.CHKNet.TabIndex = 1
        Me.CHKNet.Text = "Network"
        Me.CHKNet.UseVisualStyleBackColor = True
        '
        'CHKVol
        '
        Me.CHKVol.AutoSize = True
        Me.CHKVol.Checked = True
        Me.CHKVol.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKVol.Enabled = False
        Me.CHKVol.Location = New System.Drawing.Point(7, 20)
        Me.CHKVol.Name = "CHKVol"
        Me.CHKVol.Size = New System.Drawing.Size(61, 17)
        Me.CHKVol.TabIndex = 0
        Me.CHKVol.Text = "Volume"
        Me.CHKVol.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RADWifi)
        Me.GroupBox2.Controls.Add(Me.RADEth)
        Me.GroupBox2.Location = New System.Drawing.Point(156, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(124, 95)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "network type"
        Me.GroupBox2.Visible = False
        '
        'RADWifi
        '
        Me.RADWifi.AutoSize = True
        Me.RADWifi.Location = New System.Drawing.Point(8, 43)
        Me.RADWifi.Name = "RADWifi"
        Me.RADWifi.Size = New System.Drawing.Size(49, 17)
        Me.RADWifi.TabIndex = 0
        Me.RADWifi.Text = "Wi-Fi"
        Me.RADWifi.UseVisualStyleBackColor = True
        '
        'RADEth
        '
        Me.RADEth.AutoSize = True
        Me.RADEth.Checked = True
        Me.RADEth.Location = New System.Drawing.Point(7, 20)
        Me.RADEth.Name = "RADEth"
        Me.RADEth.Size = New System.Drawing.Size(65, 17)
        Me.RADEth.TabIndex = 0
        Me.RADEth.TabStop = True
        Me.RADEth.Text = "Ethernet"
        Me.RADEth.UseVisualStyleBackColor = True
        '
        'BTNDone
        '
        Me.BTNDone.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BTNDone.Location = New System.Drawing.Point(107, 10)
        Me.BTNDone.Name = "BTNDone"
        Me.BTNDone.Size = New System.Drawing.Size(90, 23)
        Me.BTNDone.TabIndex = 2
        Me.BTNDone.Text = "done"
        Me.BTNDone.UseVisualStyleBackColor = True
        '
        'BTNCancel
        '
        Me.BTNCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNCancel.Location = New System.Drawing.Point(11, 10)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(90, 23)
        Me.BTNCancel.TabIndex = 2
        Me.BTNCancel.Text = "cancel"
        Me.BTNCancel.UseVisualStyleBackColor = True
        '
        'BTNQuit
        '
        Me.BTNQuit.Location = New System.Drawing.Point(203, 10)
        Me.BTNQuit.Name = "BTNQuit"
        Me.BTNQuit.Size = New System.Drawing.Size(90, 23)
        Me.BTNQuit.TabIndex = 3
        Me.BTNQuit.Text = "save and quit"
        Me.BTNQuit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(8, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "v3 - 2024-08-22 "
        '
        'GitHubURL
        '
        Me.GitHubURL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GitHubURL.AutoSize = True
        Me.GitHubURL.Location = New System.Drawing.Point(100, 144)
        Me.GitHubURL.Name = "GitHubURL"
        Me.GitHubURL.Size = New System.Drawing.Size(192, 13)
        Me.GitHubURL.TabIndex = 5
        Me.GitHubURL.TabStop = True
        Me.GitHubURL.Text = "github.com/thesleepiestdev/seven-tray"
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 166)
        Me.Controls.Add(Me.GitHubURL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNQuit)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNDone)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settings"
        Me.Text = "seven-tray settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CHKVol As System.Windows.Forms.CheckBox
    Friend WithEvents CHKNet As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RADWifi As System.Windows.Forms.RadioButton
    Friend WithEvents RADEth As System.Windows.Forms.RadioButton
    Friend WithEvents BTNDone As System.Windows.Forms.Button
    Friend WithEvents BTNCancel As System.Windows.Forms.Button
    Friend WithEvents BTNQuit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CHKActionCenter As System.Windows.Forms.CheckBox
    Friend WithEvents GitHubURL As System.Windows.Forms.LinkLabel
End Class
