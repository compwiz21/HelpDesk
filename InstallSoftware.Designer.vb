<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InstallSoftware
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Background_Chocolatey = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.prerequisitecheckbox = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.zoomcheckbox = New System.Windows.Forms.CheckBox()
        Me.whatsappcheckbox = New System.Windows.Forms.CheckBox()
        Me.pdfcreatorcheckbox = New System.Windows.Forms.CheckBox()
        Me.bluebeamvucheckbox = New System.Windows.Forms.CheckBox()
        Me.ieshortcutscheckbox = New System.Windows.Forms.CheckBox()
        Me.unpinedgecheckbox = New System.Windows.Forms.CheckBox()
        Me.pinietaskbarcheckbox = New System.Windows.Forms.CheckBox()
        Me.skypeforbusinesscheckbox = New System.Windows.Forms.CheckBox()
        Me.teamviewercheckbox = New System.Windows.Forms.CheckBox()
        Me.Background_InstallSoftware = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel11.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Panel11.Controls.Add(Me.PictureBox5)
        Me.Panel11.Controls.Add(Me.Label1)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(758, 102)
        Me.Panel11.TabIndex = 1
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox5.Image = Global.HelpDesk.My.Resources.Resources.Step_2
        Me.PictureBox5.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(125, 74)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 50
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(220, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Installing Required Software"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 423)
        Me.Panel2.TabIndex = 40
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.HelpDesk.My.Resources.Resources.Zone_6_Helpdesk_logo
        Me.PictureBox2.Location = New System.Drawing.Point(12, 93)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(178, 131)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Background_Chocolatey
        '
        '
        'ProgressBar3
        '
        Me.ProgressBar3.ForeColor = System.Drawing.Color.Purple
        Me.ProgressBar3.Location = New System.Drawing.Point(222, 179)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(498, 23)
        Me.ProgressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar3.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(219, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "*Approximately 2 GB of data required..."
        '
        'prerequisitecheckbox
        '
        Me.prerequisitecheckbox.AutoSize = True
        Me.prerequisitecheckbox.Enabled = False
        Me.prerequisitecheckbox.Location = New System.Drawing.Point(222, 233)
        Me.prerequisitecheckbox.Name = "prerequisitecheckbox"
        Me.prerequisitecheckbox.Size = New System.Drawing.Size(94, 17)
        Me.prerequisitecheckbox.TabIndex = 51
        Me.prerequisitecheckbox.Text = "Pre-Requisites"
        Me.prerequisitecheckbox.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(222, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Installing Pre-Requisites"
        '
        'zoomcheckbox
        '
        Me.zoomcheckbox.AutoSize = True
        Me.zoomcheckbox.Enabled = False
        Me.zoomcheckbox.Location = New System.Drawing.Point(222, 257)
        Me.zoomcheckbox.Name = "zoomcheckbox"
        Me.zoomcheckbox.Size = New System.Drawing.Size(53, 17)
        Me.zoomcheckbox.TabIndex = 52
        Me.zoomcheckbox.Text = "Zoom"
        Me.zoomcheckbox.UseVisualStyleBackColor = True
        '
        'whatsappcheckbox
        '
        Me.whatsappcheckbox.AutoSize = True
        Me.whatsappcheckbox.Enabled = False
        Me.whatsappcheckbox.Location = New System.Drawing.Point(222, 280)
        Me.whatsappcheckbox.Name = "whatsappcheckbox"
        Me.whatsappcheckbox.Size = New System.Drawing.Size(81, 17)
        Me.whatsappcheckbox.TabIndex = 53
        Me.whatsappcheckbox.Text = "What's App"
        Me.whatsappcheckbox.UseVisualStyleBackColor = True
        '
        'pdfcreatorcheckbox
        '
        Me.pdfcreatorcheckbox.AutoSize = True
        Me.pdfcreatorcheckbox.Enabled = False
        Me.pdfcreatorcheckbox.Location = New System.Drawing.Point(222, 303)
        Me.pdfcreatorcheckbox.Name = "pdfcreatorcheckbox"
        Me.pdfcreatorcheckbox.Size = New System.Drawing.Size(84, 17)
        Me.pdfcreatorcheckbox.TabIndex = 54
        Me.pdfcreatorcheckbox.Text = "PDF Creator"
        Me.pdfcreatorcheckbox.UseVisualStyleBackColor = True
        '
        'bluebeamvucheckbox
        '
        Me.bluebeamvucheckbox.AutoSize = True
        Me.bluebeamvucheckbox.Enabled = False
        Me.bluebeamvucheckbox.Location = New System.Drawing.Point(222, 322)
        Me.bluebeamvucheckbox.Name = "bluebeamvucheckbox"
        Me.bluebeamvucheckbox.Size = New System.Drawing.Size(92, 17)
        Me.bluebeamvucheckbox.TabIndex = 55
        Me.bluebeamvucheckbox.Text = "BlueBeam VU"
        Me.bluebeamvucheckbox.UseVisualStyleBackColor = True
        '
        'ieshortcutscheckbox
        '
        Me.ieshortcutscheckbox.AutoSize = True
        Me.ieshortcutscheckbox.Enabled = False
        Me.ieshortcutscheckbox.Location = New System.Drawing.Point(222, 391)
        Me.ieshortcutscheckbox.Name = "ieshortcutscheckbox"
        Me.ieshortcutscheckbox.Size = New System.Drawing.Size(106, 17)
        Me.ieshortcutscheckbox.TabIndex = 57
        Me.ieshortcutscheckbox.Text = "Add IE Shortcuts"
        Me.ieshortcutscheckbox.UseVisualStyleBackColor = True
        '
        'unpinedgecheckbox
        '
        Me.unpinedgecheckbox.AutoSize = True
        Me.unpinedgecheckbox.Enabled = False
        Me.unpinedgecheckbox.Location = New System.Drawing.Point(222, 414)
        Me.unpinedgecheckbox.Name = "unpinedgecheckbox"
        Me.unpinedgecheckbox.Size = New System.Drawing.Size(150, 17)
        Me.unpinedgecheckbox.TabIndex = 58
        Me.unpinedgecheckbox.Text = "Unpin Edge From Taskbar"
        Me.unpinedgecheckbox.UseVisualStyleBackColor = True
        '
        'pinietaskbarcheckbox
        '
        Me.pinietaskbarcheckbox.AutoSize = True
        Me.pinietaskbarcheckbox.Enabled = False
        Me.pinietaskbarcheckbox.Location = New System.Drawing.Point(222, 437)
        Me.pinietaskbarcheckbox.Name = "pinietaskbarcheckbox"
        Me.pinietaskbarcheckbox.Size = New System.Drawing.Size(108, 17)
        Me.pinietaskbarcheckbox.TabIndex = 59
        Me.pinietaskbarcheckbox.Text = "Pin IE to Taskbar"
        Me.pinietaskbarcheckbox.UseVisualStyleBackColor = True
        '
        'skypeforbusinesscheckbox
        '
        Me.skypeforbusinesscheckbox.AutoSize = True
        Me.skypeforbusinesscheckbox.Enabled = False
        Me.skypeforbusinesscheckbox.Location = New System.Drawing.Point(222, 368)
        Me.skypeforbusinesscheckbox.Name = "skypeforbusinesscheckbox"
        Me.skypeforbusinesscheckbox.Size = New System.Drawing.Size(148, 17)
        Me.skypeforbusinesscheckbox.TabIndex = 60
        Me.skypeforbusinesscheckbox.Text = "Skype for Business Plugin"
        Me.skypeforbusinesscheckbox.UseVisualStyleBackColor = True
        '
        'teamviewercheckbox
        '
        Me.teamviewercheckbox.AutoSize = True
        Me.teamviewercheckbox.Enabled = False
        Me.teamviewercheckbox.Location = New System.Drawing.Point(222, 345)
        Me.teamviewercheckbox.Name = "teamviewercheckbox"
        Me.teamviewercheckbox.Size = New System.Drawing.Size(84, 17)
        Me.teamviewercheckbox.TabIndex = 61
        Me.teamviewercheckbox.Text = "Teamviewer"
        Me.teamviewercheckbox.UseVisualStyleBackColor = True
        '
        'Background_InstallSoftware
        '
        Me.Background_InstallSoftware.WorkerReportsProgress = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(318, 236)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(208, 10)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 62
        '
        'InstallSoftware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(758, 523)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.teamviewercheckbox)
        Me.Controls.Add(Me.skypeforbusinesscheckbox)
        Me.Controls.Add(Me.pinietaskbarcheckbox)
        Me.Controls.Add(Me.unpinedgecheckbox)
        Me.Controls.Add(Me.ieshortcutscheckbox)
        Me.Controls.Add(Me.bluebeamvucheckbox)
        Me.Controls.Add(Me.pdfcreatorcheckbox)
        Me.Controls.Add(Me.whatsappcheckbox)
        Me.Controls.Add(Me.zoomcheckbox)
        Me.Controls.Add(Me.prerequisitecheckbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProgressBar3)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InstallSoftware"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InstallSoftware"
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Background_Chocolatey As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents prerequisitecheckbox As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents zoomcheckbox As CheckBox
    Friend WithEvents whatsappcheckbox As CheckBox
    Friend WithEvents pdfcreatorcheckbox As CheckBox
    Friend WithEvents bluebeamvucheckbox As CheckBox
    Friend WithEvents ieshortcutscheckbox As CheckBox
    Friend WithEvents unpinedgecheckbox As CheckBox
    Friend WithEvents pinietaskbarcheckbox As CheckBox
    Friend WithEvents skypeforbusinesscheckbox As CheckBox
    Friend WithEvents teamviewercheckbox As CheckBox
    Friend WithEvents Background_InstallSoftware As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
