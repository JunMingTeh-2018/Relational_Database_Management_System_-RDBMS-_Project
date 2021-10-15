<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertcustomer_a176607
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertcustomer_a176607))
        Me.btn_remove_photo = New System.Windows.Forms.Button()
        Me.lbl_photo = New System.Windows.Forms.Label()
        Me.txt_photo = New System.Windows.Forms.TextBox()
        Me.btn_photo = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.lbl_phone_number = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_customer_id = New System.Windows.Forms.Label()
        Me.pic_customer = New System.Windows.Forms.PictureBox()
        Me.txt_customer_id = New System.Windows.Forms.TextBox()
        Me.lbl_tagline = New System.Windows.Forms.Label()
        Me.grd_customers = New System.Windows.Forms.DataGridView()
        Me.pic_back = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_phone_number = New System.Windows.Forms.TextBox()
        CType(Me.pic_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_remove_photo
        '
        Me.btn_remove_photo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_remove_photo.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove_photo.Location = New System.Drawing.Point(692, 429)
        Me.btn_remove_photo.Name = "btn_remove_photo"
        Me.btn_remove_photo.Size = New System.Drawing.Size(203, 28)
        Me.btn_remove_photo.TabIndex = 90
        Me.btn_remove_photo.Text = "Romove Photo"
        Me.btn_remove_photo.UseVisualStyleBackColor = True
        '
        'lbl_photo
        '
        Me.lbl_photo.AutoSize = True
        Me.lbl_photo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_photo.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_photo.Location = New System.Drawing.Point(743, 120)
        Me.lbl_photo.Name = "lbl_photo"
        Me.lbl_photo.Size = New System.Drawing.Size(75, 25)
        Me.lbl_photo.TabIndex = 89
        Me.lbl_photo.Text = "Photo"
        '
        'txt_photo
        '
        Me.txt_photo.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_photo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_photo.Location = New System.Drawing.Point(692, 366)
        Me.txt_photo.Name = "txt_photo"
        Me.txt_photo.ReadOnly = True
        Me.txt_photo.Size = New System.Drawing.Size(203, 27)
        Me.txt_photo.TabIndex = 88
        '
        'btn_photo
        '
        Me.btn_photo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_photo.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_photo.Location = New System.Drawing.Point(692, 398)
        Me.btn_photo.Name = "btn_photo"
        Me.btn_photo.Size = New System.Drawing.Size(203, 28)
        Me.btn_photo.TabIndex = 87
        Me.btn_photo.Text = "Select Photo"
        Me.btn_photo.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(100, 464)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(795, 28)
        Me.btn_add.TabIndex = 86
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'lbl_phone_number
        '
        Me.lbl_phone_number.AutoSize = True
        Me.lbl_phone_number.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phone_number.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone_number.Location = New System.Drawing.Point(389, 402)
        Me.lbl_phone_number.Name = "lbl_phone_number"
        Me.lbl_phone_number.Size = New System.Drawing.Size(126, 20)
        Me.lbl_phone_number.TabIndex = 85
        Me.lbl_phone_number.Text = "Phone Number"
        '
        'txt_email
        '
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(566, 430)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(118, 27)
        Me.txt_email.TabIndex = 82
        '
        'lbl_customer_id
        '
        Me.lbl_customer_id.AutoSize = True
        Me.lbl_customer_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customer_id.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_id.Location = New System.Drawing.Point(96, 402)
        Me.lbl_customer_id.Name = "lbl_customer_id"
        Me.lbl_customer_id.Size = New System.Drawing.Size(108, 20)
        Me.lbl_customer_id.TabIndex = 79
        Me.lbl_customer_id.Text = "Customer ID"
        '
        'pic_customer
        '
        Me.pic_customer.BackColor = System.Drawing.Color.Transparent
        Me.pic_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_customer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_customer.Location = New System.Drawing.Point(692, 148)
        Me.pic_customer.Name = "pic_customer"
        Me.pic_customer.Size = New System.Drawing.Size(203, 212)
        Me.pic_customer.TabIndex = 76
        Me.pic_customer.TabStop = False
        '
        'txt_customer_id
        '
        Me.txt_customer_id.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_customer_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customer_id.Location = New System.Drawing.Point(252, 399)
        Me.txt_customer_id.Name = "txt_customer_id"
        Me.txt_customer_id.ReadOnly = True
        Me.txt_customer_id.Size = New System.Drawing.Size(131, 27)
        Me.txt_customer_id.TabIndex = 73
        Me.txt_customer_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_tagline
        '
        Me.lbl_tagline.AutoSize = True
        Me.lbl_tagline.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tagline.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagline.Location = New System.Drawing.Point(287, 666)
        Me.lbl_tagline.Name = "lbl_tagline"
        Me.lbl_tagline.Size = New System.Drawing.Size(315, 28)
        Me.lbl_tagline.TabIndex = 71
        Me.lbl_tagline.Text = "Affordable Excellence of Tech"
        '
        'grd_customers
        '
        Me.grd_customers.AllowUserToAddRows = False
        Me.grd_customers.AllowUserToDeleteRows = False
        Me.grd_customers.AllowUserToResizeColumns = False
        Me.grd_customers.AllowUserToResizeRows = False
        Me.grd_customers.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grd_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_customers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_customers.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_customers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_customers.DefaultCellStyle = DataGridViewCellStyle2
        Me.grd_customers.Location = New System.Drawing.Point(100, 124)
        Me.grd_customers.Name = "grd_customers"
        Me.grd_customers.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_customers.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grd_customers.RowHeadersWidth = 51
        Me.grd_customers.RowTemplate.Height = 24
        Me.grd_customers.Size = New System.Drawing.Size(584, 269)
        Me.grd_customers.TabIndex = 70
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
        Me.pic_back.TabIndex = 69
        Me.pic_back.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(211, 25)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(528, 50)
        Me.lbl_title.TabIndex = 68
        Me.lbl_title.Text = "ADD NEW CUSTOMER"
        '
        'pic_logo
        '
        Me.pic_logo.BackColor = System.Drawing.Color.Transparent
        Me.pic_logo.BackgroundImage = CType(resources.GetObject("pic_logo.BackgroundImage"), System.Drawing.Image)
        Me.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_logo.Location = New System.Drawing.Point(12, 12)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(90, 81)
        Me.pic_logo.TabIndex = 67
        Me.pic_logo.TabStop = False
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(389, 433)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(57, 20)
        Me.lbl_email.TabIndex = 83
        Me.lbl_email.Text = "Email"
        '
        'txt_name
        '
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(252, 430)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(131, 27)
        Me.txt_name.TabIndex = 75
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(96, 433)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(53, 20)
        Me.lbl_name.TabIndex = 80
        Me.lbl_name.Text = "Name"
        '
        'txt_phone_number
        '
        Me.txt_phone_number.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_phone_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone_number.Location = New System.Drawing.Point(566, 399)
        Me.txt_phone_number.Name = "txt_phone_number"
        Me.txt_phone_number.Size = New System.Drawing.Size(118, 27)
        Me.txt_phone_number.TabIndex = 84
        Me.txt_phone_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_insertcustomer_a176607
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.btn_remove_photo)
        Me.Controls.Add(Me.lbl_photo)
        Me.Controls.Add(Me.txt_photo)
        Me.Controls.Add(Me.btn_photo)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.lbl_phone_number)
        Me.Controls.Add(Me.txt_phone_number)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_customer_id)
        Me.Controls.Add(Me.pic_customer)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_customer_id)
        Me.Controls.Add(Me.lbl_tagline)
        Me.Controls.Add(Me.grd_customers)
        Me.Controls.Add(Me.pic_back)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_insertcustomer_a176607"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Customer"
        CType(Me.pic_customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_remove_photo As Button
    Friend WithEvents lbl_photo As Label
    Friend WithEvents txt_photo As TextBox
    Friend WithEvents btn_photo As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents lbl_phone_number As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_customer_id As Label
    Friend WithEvents pic_customer As PictureBox
    Friend WithEvents txt_customer_id As TextBox
    Friend WithEvents lbl_tagline As Label
    Friend WithEvents grd_customers As DataGridView
    Friend WithEvents pic_back As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_phone_number As TextBox
End Class
