<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertstaff_a176607
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertstaff_a176607))
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btn_clearphoto = New System.Windows.Forms.Button()
        Me.lbl_photo = New System.Windows.Forms.Label()
        Me.txt_photo = New System.Windows.Forms.TextBox()
        Me.btn_photo = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lbl_phone_number = New System.Windows.Forms.Label()
        Me.txt_phone_number = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_staff_id = New System.Windows.Forms.Label()
        Me.pic_staff = New System.Windows.Forms.PictureBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_staff_id = New System.Windows.Forms.TextBox()
        Me.lbl_tagline = New System.Windows.Forms.Label()
        Me.grd_staffs = New System.Windows.Forms.DataGridView()
        Me.pic_back = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        CType(Me.pic_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_staffs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'btn_clearphoto
        '
        Me.btn_clearphoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clearphoto.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clearphoto.Location = New System.Drawing.Point(690, 429)
        Me.btn_clearphoto.Name = "btn_clearphoto"
        Me.btn_clearphoto.Size = New System.Drawing.Size(203, 28)
        Me.btn_clearphoto.TabIndex = 109
        Me.btn_clearphoto.Text = "Clear Photo"
        Me.btn_clearphoto.UseVisualStyleBackColor = True
        '
        'lbl_photo
        '
        Me.lbl_photo.AutoSize = True
        Me.lbl_photo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_photo.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_photo.Location = New System.Drawing.Point(743, 120)
        Me.lbl_photo.Name = "lbl_photo"
        Me.lbl_photo.Size = New System.Drawing.Size(75, 25)
        Me.lbl_photo.TabIndex = 108
        Me.lbl_photo.Text = "Photo"
        '
        'txt_photo
        '
        Me.txt_photo.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_photo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_photo.Location = New System.Drawing.Point(690, 366)
        Me.txt_photo.Name = "txt_photo"
        Me.txt_photo.ReadOnly = True
        Me.txt_photo.Size = New System.Drawing.Size(203, 27)
        Me.txt_photo.TabIndex = 107
        '
        'btn_photo
        '
        Me.btn_photo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_photo.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_photo.Location = New System.Drawing.Point(690, 398)
        Me.btn_photo.Name = "btn_photo"
        Me.btn_photo.Size = New System.Drawing.Size(203, 28)
        Me.btn_photo.TabIndex = 106
        Me.btn_photo.Text = "Select Photo"
        Me.btn_photo.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(100, 464)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(793, 28)
        Me.btn_add.TabIndex = 105
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'lbl_phone_number
        '
        Me.lbl_phone_number.AutoSize = True
        Me.lbl_phone_number.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phone_number.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone_number.Location = New System.Drawing.Point(372, 402)
        Me.lbl_phone_number.Name = "lbl_phone_number"
        Me.lbl_phone_number.Size = New System.Drawing.Size(126, 20)
        Me.lbl_phone_number.TabIndex = 104
        Me.lbl_phone_number.Text = "Phone Number"
        '
        'txt_phone_number
        '
        Me.txt_phone_number.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_phone_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone_number.Location = New System.Drawing.Point(548, 399)
        Me.txt_phone_number.Name = "txt_phone_number"
        Me.txt_phone_number.Size = New System.Drawing.Size(136, 27)
        Me.txt_phone_number.TabIndex = 103
        Me.txt_phone_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(372, 433)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(57, 20)
        Me.lbl_email.TabIndex = 102
        Me.lbl_email.Text = "Email"
        '
        'txt_email
        '
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(548, 430)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(136, 27)
        Me.txt_email.TabIndex = 101
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(96, 433)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(53, 20)
        Me.lbl_name.TabIndex = 100
        Me.lbl_name.Text = "Name"
        '
        'lbl_staff_id
        '
        Me.lbl_staff_id.AutoSize = True
        Me.lbl_staff_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff_id.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_id.Location = New System.Drawing.Point(96, 402)
        Me.lbl_staff_id.Name = "lbl_staff_id"
        Me.lbl_staff_id.Size = New System.Drawing.Size(75, 20)
        Me.lbl_staff_id.TabIndex = 99
        Me.lbl_staff_id.Text = "Staff ID"
        '
        'pic_staff
        '
        Me.pic_staff.BackColor = System.Drawing.Color.Transparent
        Me.pic_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_staff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_staff.Location = New System.Drawing.Point(692, 148)
        Me.pic_staff.Name = "pic_staff"
        Me.pic_staff.Size = New System.Drawing.Size(203, 212)
        Me.pic_staff.TabIndex = 98
        Me.pic_staff.TabStop = False
        '
        'txt_name
        '
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(217, 430)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(149, 27)
        Me.txt_name.TabIndex = 97
        '
        'txt_staff_id
        '
        Me.txt_staff_id.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_staff_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staff_id.Location = New System.Drawing.Point(217, 399)
        Me.txt_staff_id.Name = "txt_staff_id"
        Me.txt_staff_id.ReadOnly = True
        Me.txt_staff_id.Size = New System.Drawing.Size(149, 27)
        Me.txt_staff_id.TabIndex = 96
        Me.txt_staff_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_tagline
        '
        Me.lbl_tagline.AutoSize = True
        Me.lbl_tagline.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tagline.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagline.Location = New System.Drawing.Point(276, 666)
        Me.lbl_tagline.Name = "lbl_tagline"
        Me.lbl_tagline.Size = New System.Drawing.Size(315, 28)
        Me.lbl_tagline.TabIndex = 95
        Me.lbl_tagline.Text = "Affordable Excellence of Tech"
        '
        'grd_staffs
        '
        Me.grd_staffs.AllowUserToAddRows = False
        Me.grd_staffs.AllowUserToDeleteRows = False
        Me.grd_staffs.AllowUserToResizeColumns = False
        Me.grd_staffs.AllowUserToResizeRows = False
        Me.grd_staffs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grd_staffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_staffs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_staffs.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_staffs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_staffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_staffs.DefaultCellStyle = DataGridViewCellStyle2
        Me.grd_staffs.Location = New System.Drawing.Point(100, 124)
        Me.grd_staffs.Name = "grd_staffs"
        Me.grd_staffs.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_staffs.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grd_staffs.RowHeadersWidth = 51
        Me.grd_staffs.RowTemplate.Height = 24
        Me.grd_staffs.Size = New System.Drawing.Size(584, 269)
        Me.grd_staffs.TabIndex = 94
        '
        'pic_back
        '
        Me.pic_back.BackColor = System.Drawing.Color.Transparent
        Me.pic_back.BackgroundImage = CType(resources.GetObject("pic_back.BackgroundImage"), System.Drawing.Image)
        Me.pic_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_back.Location = New System.Drawing.Point(458, 497)
        Me.pic_back.Name = "pic_back"
        Me.pic_back.Size = New System.Drawing.Size(85, 81)
        Me.pic_back.TabIndex = 93
        Me.pic_back.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(265, 25)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(421, 50)
        Me.lbl_title.TabIndex = 92
        Me.lbl_title.Text = "ADD NEW STAFF"
        '
        'pic_logo
        '
        Me.pic_logo.BackColor = System.Drawing.Color.Transparent
        Me.pic_logo.BackgroundImage = CType(resources.GetObject("pic_logo.BackgroundImage"), System.Drawing.Image)
        Me.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_logo.Location = New System.Drawing.Point(12, 12)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(90, 81)
        Me.pic_logo.TabIndex = 91
        Me.pic_logo.TabStop = False
        '
        'frm_insertstaff_a176607
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.btn_clearphoto)
        Me.Controls.Add(Me.lbl_photo)
        Me.Controls.Add(Me.txt_photo)
        Me.Controls.Add(Me.btn_photo)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.lbl_phone_number)
        Me.Controls.Add(Me.txt_phone_number)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_staff_id)
        Me.Controls.Add(Me.pic_staff)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_staff_id)
        Me.Controls.Add(Me.lbl_tagline)
        Me.Controls.Add(Me.grd_staffs)
        Me.Controls.Add(Me.pic_back)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_insertstaff_a176607"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Staff"
        CType(Me.pic_staff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_staffs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents btn_clearphoto As Button
    Friend WithEvents lbl_photo As Label
    Friend WithEvents txt_photo As TextBox
    Friend WithEvents btn_photo As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents lbl_phone_number As Label
    Friend WithEvents txt_phone_number As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_staff_id As Label
    Friend WithEvents pic_staff As PictureBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_staff_id As TextBox
    Friend WithEvents lbl_tagline As Label
    Friend WithEvents grd_staffs As DataGridView
    Friend WithEvents pic_back As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_logo As PictureBox
End Class
