<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffdetails_a176607
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_staffdetails_a176607))
        Me.lst_staff_id = New System.Windows.Forms.ListBox()
        Me.txt_staff_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_phone_number = New System.Windows.Forms.TextBox()
        Me.pic_staff = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.pic_home = New System.Windows.Forms.PictureBox()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_staff_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_phone_number = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_lst = New System.Windows.Forms.Label()
        Me.lbl_photo = New System.Windows.Forms.Label()
        Me.lbl_tagline = New System.Windows.Forms.Label()
        Me.lbl_staff_table = New System.Windows.Forms.Label()
        CType(Me.pic_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_staff_id
        '
        Me.lst_staff_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lst_staff_id.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_staff_id.FormattingEnabled = True
        Me.lst_staff_id.ItemHeight = 22
        Me.lst_staff_id.Location = New System.Drawing.Point(105, 170)
        Me.lst_staff_id.Name = "lst_staff_id"
        Me.lst_staff_id.Size = New System.Drawing.Size(103, 312)
        Me.lst_staff_id.TabIndex = 0
        '
        'txt_staff_id
        '
        Me.txt_staff_id.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_staff_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staff_id.Location = New System.Drawing.Point(387, 196)
        Me.txt_staff_id.Name = "txt_staff_id"
        Me.txt_staff_id.ReadOnly = True
        Me.txt_staff_id.Size = New System.Drawing.Size(255, 27)
        Me.txt_staff_id.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(387, 272)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(255, 27)
        Me.txt_name.TabIndex = 2
        '
        'txt_phone_number
        '
        Me.txt_phone_number.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_phone_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone_number.Location = New System.Drawing.Point(387, 348)
        Me.txt_phone_number.Name = "txt_phone_number"
        Me.txt_phone_number.ReadOnly = True
        Me.txt_phone_number.Size = New System.Drawing.Size(255, 27)
        Me.txt_phone_number.TabIndex = 3
        '
        'pic_staff
        '
        Me.pic_staff.BackColor = System.Drawing.Color.Transparent
        Me.pic_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_staff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_staff.Location = New System.Drawing.Point(660, 177)
        Me.pic_staff.Name = "pic_staff"
        Me.pic_staff.Size = New System.Drawing.Size(228, 296)
        Me.pic_staff.TabIndex = 4
        Me.pic_staff.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(286, 28)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(402, 50)
        Me.lbl_title.TabIndex = 6
        Me.lbl_title.Text = "STAFF DETAILS"
        '
        'txt_email
        '
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(387, 424)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.ReadOnly = True
        Me.txt_email.Size = New System.Drawing.Size(255, 27)
        Me.txt_email.TabIndex = 7
        '
        'pic_home
        '
        Me.pic_home.BackColor = System.Drawing.Color.Transparent
        Me.pic_home.BackgroundImage = CType(resources.GetObject("pic_home.BackgroundImage"), System.Drawing.Image)
        Me.pic_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_home.Location = New System.Drawing.Point(464, 501)
        Me.pic_home.Name = "pic_home"
        Me.pic_home.Size = New System.Drawing.Size(73, 72)
        Me.pic_home.TabIndex = 8
        Me.pic_home.TabStop = False
        '
        'pic_logo
        '
        Me.pic_logo.BackColor = System.Drawing.Color.Transparent
        Me.pic_logo.BackgroundImage = CType(resources.GetObject("pic_logo.BackgroundImage"), System.Drawing.Image)
        Me.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_logo.Location = New System.Drawing.Point(12, 12)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(90, 81)
        Me.pic_logo.TabIndex = 9
        Me.pic_logo.TabStop = False
        '
        'lbl_staff_id
        '
        Me.lbl_staff_id.AutoSize = True
        Me.lbl_staff_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff_id.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_id.Location = New System.Drawing.Point(215, 199)
        Me.lbl_staff_id.Name = "lbl_staff_id"
        Me.lbl_staff_id.Size = New System.Drawing.Size(75, 20)
        Me.lbl_staff_id.TabIndex = 10
        Me.lbl_staff_id.Text = "Staff ID"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(215, 275)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(53, 20)
        Me.lbl_name.TabIndex = 11
        Me.lbl_name.Text = "Name"
        '
        'lbl_phone_number
        '
        Me.lbl_phone_number.AutoSize = True
        Me.lbl_phone_number.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phone_number.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone_number.Location = New System.Drawing.Point(215, 351)
        Me.lbl_phone_number.Name = "lbl_phone_number"
        Me.lbl_phone_number.Size = New System.Drawing.Size(126, 20)
        Me.lbl_phone_number.TabIndex = 12
        Me.lbl_phone_number.Text = "Phone Number"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(215, 427)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(57, 20)
        Me.lbl_email.TabIndex = 13
        Me.lbl_email.Text = "Email"
        '
        'lbl_lst
        '
        Me.lbl_lst.AutoSize = True
        Me.lbl_lst.BackColor = System.Drawing.Color.Transparent
        Me.lbl_lst.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lst.Location = New System.Drawing.Point(101, 134)
        Me.lbl_lst.Name = "lbl_lst"
        Me.lbl_lst.Size = New System.Drawing.Size(84, 25)
        Me.lbl_lst.TabIndex = 14
        Me.lbl_lst.Text = "Choose"
        '
        'lbl_photo
        '
        Me.lbl_photo.AutoSize = True
        Me.lbl_photo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_photo.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_photo.Location = New System.Drawing.Point(728, 138)
        Me.lbl_photo.Name = "lbl_photo"
        Me.lbl_photo.Size = New System.Drawing.Size(75, 25)
        Me.lbl_photo.TabIndex = 15
        Me.lbl_photo.Text = "Photo"
        '
        'lbl_tagline
        '
        Me.lbl_tagline.AutoSize = True
        Me.lbl_tagline.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tagline.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagline.Location = New System.Drawing.Point(302, 666)
        Me.lbl_tagline.Name = "lbl_tagline"
        Me.lbl_tagline.Size = New System.Drawing.Size(315, 28)
        Me.lbl_tagline.TabIndex = 16
        Me.lbl_tagline.Text = "Affordable Excellence of Tech"
        '
        'lbl_staff_table
        '
        Me.lbl_staff_table.AutoSize = True
        Me.lbl_staff_table.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff_table.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_staff_table.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_staff_table.Location = New System.Drawing.Point(696, 547)
        Me.lbl_staff_table.Name = "lbl_staff_table"
        Me.lbl_staff_table.Size = New System.Drawing.Size(199, 34)
        Me.lbl_staff_table.TabIndex = 17
        Me.lbl_staff_table.Text = "Want to view as TABLE form ?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click here"
        Me.lbl_staff_table.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_staffdetails_a176607
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.lbl_staff_table)
        Me.Controls.Add(Me.lbl_tagline)
        Me.Controls.Add(Me.lbl_photo)
        Me.Controls.Add(Me.lbl_lst)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_phone_number)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_staff_id)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.pic_home)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_staff)
        Me.Controls.Add(Me.txt_phone_number)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_staff_id)
        Me.Controls.Add(Me.lst_staff_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_staffdetails_a176607"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Details"
        CType(Me.pic_staff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst_staff_id As ListBox
    Friend WithEvents txt_staff_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_phone_number As TextBox
    Friend WithEvents pic_staff As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents pic_home As PictureBox
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents lbl_staff_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_phone_number As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_lst As Label
    Friend WithEvents lbl_photo As Label
    Friend WithEvents lbl_tagline As Label
    Friend WithEvents lbl_staff_table As Label
End Class
