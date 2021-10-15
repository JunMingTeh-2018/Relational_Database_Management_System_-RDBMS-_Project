<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customerdetails_a176607
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_customerdetails_a176607))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_home = New System.Windows.Forms.PictureBox()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_photo = New System.Windows.Forms.Label()
        Me.lbl_lst = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_phone_number = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_customer_id = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.pic_customer = New System.Windows.Forms.PictureBox()
        Me.txt_phone_number = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_customer_id = New System.Windows.Forms.TextBox()
        Me.lst_customer_id = New System.Windows.Forms.ListBox()
        Me.lbl_tagline = New System.Windows.Forms.Label()
        Me.lbl_customer_table = New System.Windows.Forms.Label()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(241, 26)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(509, 50)
        Me.lbl_title.TabIndex = 6
        Me.lbl_title.Text = "CUSTOMER DETAILS"
        '
        'pic_home
        '
        Me.pic_home.BackColor = System.Drawing.Color.Transparent
        Me.pic_home.BackgroundImage = CType(resources.GetObject("pic_home.BackgroundImage"), System.Drawing.Image)
        Me.pic_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_home.Location = New System.Drawing.Point(462, 502)
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
        'lbl_photo
        '
        Me.lbl_photo.AutoSize = True
        Me.lbl_photo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_photo.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_photo.Location = New System.Drawing.Point(722, 139)
        Me.lbl_photo.Name = "lbl_photo"
        Me.lbl_photo.Size = New System.Drawing.Size(75, 25)
        Me.lbl_photo.TabIndex = 27
        Me.lbl_photo.Text = "Photo"
        '
        'lbl_lst
        '
        Me.lbl_lst.AutoSize = True
        Me.lbl_lst.BackColor = System.Drawing.Color.Transparent
        Me.lbl_lst.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lst.Location = New System.Drawing.Point(99, 135)
        Me.lbl_lst.Name = "lbl_lst"
        Me.lbl_lst.Size = New System.Drawing.Size(84, 25)
        Me.lbl_lst.TabIndex = 26
        Me.lbl_lst.Text = "Choose"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(214, 428)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(57, 20)
        Me.lbl_email.TabIndex = 25
        Me.lbl_email.Text = "Email"
        '
        'lbl_phone_number
        '
        Me.lbl_phone_number.AutoSize = True
        Me.lbl_phone_number.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phone_number.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone_number.Location = New System.Drawing.Point(214, 352)
        Me.lbl_phone_number.Name = "lbl_phone_number"
        Me.lbl_phone_number.Size = New System.Drawing.Size(126, 20)
        Me.lbl_phone_number.TabIndex = 24
        Me.lbl_phone_number.Text = "Phone Number"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(214, 276)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(53, 20)
        Me.lbl_name.TabIndex = 23
        Me.lbl_name.Text = "Name"
        '
        'lbl_customer_id
        '
        Me.lbl_customer_id.AutoSize = True
        Me.lbl_customer_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customer_id.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_id.Location = New System.Drawing.Point(214, 200)
        Me.lbl_customer_id.Name = "lbl_customer_id"
        Me.lbl_customer_id.Size = New System.Drawing.Size(108, 20)
        Me.lbl_customer_id.TabIndex = 22
        Me.lbl_customer_id.Text = "Customer ID"
        '
        'txt_email
        '
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(386, 425)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.ReadOnly = True
        Me.txt_email.Size = New System.Drawing.Size(255, 27)
        Me.txt_email.TabIndex = 21
        '
        'pic_customer
        '
        Me.pic_customer.BackColor = System.Drawing.Color.Transparent
        Me.pic_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_customer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_customer.Location = New System.Drawing.Point(659, 178)
        Me.pic_customer.Name = "pic_customer"
        Me.pic_customer.Size = New System.Drawing.Size(228, 296)
        Me.pic_customer.TabIndex = 20
        Me.pic_customer.TabStop = False
        '
        'txt_phone_number
        '
        Me.txt_phone_number.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_phone_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone_number.Location = New System.Drawing.Point(386, 349)
        Me.txt_phone_number.Name = "txt_phone_number"
        Me.txt_phone_number.ReadOnly = True
        Me.txt_phone_number.Size = New System.Drawing.Size(255, 27)
        Me.txt_phone_number.TabIndex = 19
        '
        'txt_name
        '
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(386, 273)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(255, 27)
        Me.txt_name.TabIndex = 18
        '
        'txt_customer_id
        '
        Me.txt_customer_id.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_customer_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customer_id.Location = New System.Drawing.Point(386, 197)
        Me.txt_customer_id.Name = "txt_customer_id"
        Me.txt_customer_id.ReadOnly = True
        Me.txt_customer_id.Size = New System.Drawing.Size(255, 27)
        Me.txt_customer_id.TabIndex = 17
        '
        'lst_customer_id
        '
        Me.lst_customer_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lst_customer_id.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_customer_id.FormattingEnabled = True
        Me.lst_customer_id.ItemHeight = 22
        Me.lst_customer_id.Location = New System.Drawing.Point(104, 171)
        Me.lst_customer_id.Name = "lst_customer_id"
        Me.lst_customer_id.Size = New System.Drawing.Size(103, 312)
        Me.lst_customer_id.TabIndex = 16
        '
        'lbl_tagline
        '
        Me.lbl_tagline.AutoSize = True
        Me.lbl_tagline.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tagline.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagline.Location = New System.Drawing.Point(298, 666)
        Me.lbl_tagline.Name = "lbl_tagline"
        Me.lbl_tagline.Size = New System.Drawing.Size(315, 28)
        Me.lbl_tagline.TabIndex = 28
        Me.lbl_tagline.Text = "Affordable Excellence of Tech"
        '
        'lbl_customer_table
        '
        Me.lbl_customer_table.AutoSize = True
        Me.lbl_customer_table.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customer_table.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_customer_table.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_customer_table.Location = New System.Drawing.Point(698, 548)
        Me.lbl_customer_table.Name = "lbl_customer_table"
        Me.lbl_customer_table.Size = New System.Drawing.Size(199, 34)
        Me.lbl_customer_table.TabIndex = 29
        Me.lbl_customer_table.Text = "Want to view as TABLE form ?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click here"
        Me.lbl_customer_table.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_customerdetails_a176607
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.lbl_customer_table)
        Me.Controls.Add(Me.lbl_tagline)
        Me.Controls.Add(Me.lbl_photo)
        Me.Controls.Add(Me.lbl_lst)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_phone_number)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_customer_id)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.pic_customer)
        Me.Controls.Add(Me.txt_phone_number)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_customer_id)
        Me.Controls.Add(Me.lst_customer_id)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.pic_home)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_customerdetails_a176607"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Details"
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_home As PictureBox
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents lbl_photo As Label
    Friend WithEvents lbl_lst As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_phone_number As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_customer_id As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents pic_customer As PictureBox
    Friend WithEvents txt_phone_number As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_customer_id As TextBox
    Friend WithEvents lst_customer_id As ListBox
    Friend WithEvents lbl_tagline As Label
    Friend WithEvents lbl_customer_table As Label
End Class
