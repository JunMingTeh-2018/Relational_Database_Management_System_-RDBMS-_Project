<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_splashscreen_a176607
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_splashscreen_a176607))
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.tmr_title = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_tagline = New System.Windows.Forms.Label()
        Me.pic_login = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_me = New System.Windows.Forms.Label()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_logo
        '
        Me.pic_logo.BackColor = System.Drawing.SystemColors.Control
        Me.pic_logo.BackgroundImage = CType(resources.GetObject("pic_logo.BackgroundImage"), System.Drawing.Image)
        Me.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_logo.Location = New System.Drawing.Point(411, 281)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(160, 98)
        Me.pic_logo.TabIndex = 2
        Me.pic_logo.TabStop = False
        Me.pic_logo.UseWaitCursor = True
        '
        'tmr_title
        '
        Me.tmr_title.Enabled = True
        Me.tmr_title.Interval = 500
        '
        'lbl_tagline
        '
        Me.lbl_tagline.AutoSize = True
        Me.lbl_tagline.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tagline.Font = New System.Drawing.Font("Permanent Marker", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagline.Location = New System.Drawing.Point(241, 637)
        Me.lbl_tagline.Name = "lbl_tagline"
        Me.lbl_tagline.Size = New System.Drawing.Size(477, 43)
        Me.lbl_tagline.TabIndex = 45
        Me.lbl_tagline.Text = "Affordable Excellence of Tech"
        '
        'pic_login
        '
        Me.pic_login.BackColor = System.Drawing.Color.Transparent
        Me.pic_login.BackgroundImage = CType(resources.GetObject("pic_login.BackgroundImage"), System.Drawing.Image)
        Me.pic_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_login.Location = New System.Drawing.Point(411, 502)
        Me.pic_login.Name = "pic_login"
        Me.pic_login.Size = New System.Drawing.Size(160, 63)
        Me.pic_login.TabIndex = 46
        Me.pic_login.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("American Captain", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_title.Location = New System.Drawing.Point(98, 118)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(749, 72)
        Me.lbl_title.TabIndex = 47
        Me.lbl_title.Text = "Welcome to JM Computer SDN BHD !"
        '
        'lbl_me
        '
        Me.lbl_me.AutoSize = True
        Me.lbl_me.BackColor = System.Drawing.Color.Transparent
        Me.lbl_me.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_me.Location = New System.Drawing.Point(285, 18)
        Me.lbl_me.Name = "lbl_me"
        Me.lbl_me.Size = New System.Drawing.Size(424, 42)
        Me.lbl_me.TabIndex = 48
        Me.lbl_me.Text = "TEH JUN MING (A176607)"
        '
        'frm_splashscreen_a176607
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.lbl_me)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_login)
        Me.Controls.Add(Me.lbl_tagline)
        Me.Controls.Add(Me.pic_logo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_splashscreen_a176607"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JM Computer SDN BHD"
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents tmr_title As Timer
    Friend WithEvents lbl_tagline As Label
    Friend WithEvents pic_login As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_me As Label
End Class
