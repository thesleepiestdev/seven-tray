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
        Me.CHKNet = New System.Windows.Forms.CheckBox()
        Me.CHKVol = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RADWifi = New System.Windows.Forms.RadioButton()
        Me.RADEth = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BTNQuit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CHKNet)
        Me.GroupBox1.Controls.Add(Me.CHKVol)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 70)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "enabled icons"
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
        Me.GroupBox2.Location = New System.Drawing.Point(13, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 100)
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
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(277, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(196, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BTNQuit
        '
        Me.BTNQuit.Location = New System.Drawing.Point(13, 226)
        Me.BTNQuit.Name = "BTNQuit"
        Me.BTNQuit.Size = New System.Drawing.Size(75, 23)
        Me.BTNQuit.TabIndex = 3
        Me.BTNQuit.Text = "quit app"
        Me.BTNQuit.UseVisualStyleBackColor = True
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 261)
        Me.Controls.Add(Me.BTNQuit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(370, 290)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(370, 290)
        Me.Name = "settings"
        Me.Text = "seven-tray settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CHKVol As System.Windows.Forms.CheckBox
    Friend WithEvents CHKNet As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RADWifi As System.Windows.Forms.RadioButton
    Friend WithEvents RADEth As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BTNQuit As System.Windows.Forms.Button
End Class
