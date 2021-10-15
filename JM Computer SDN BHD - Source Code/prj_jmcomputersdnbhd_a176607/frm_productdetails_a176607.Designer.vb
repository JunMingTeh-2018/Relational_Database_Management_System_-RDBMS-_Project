<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_productdetails_a176607
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productdetails_a176607))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_category = New System.Windows.Forms.ComboBox()
        Me.pic_home = New System.Windows.Forms.PictureBox()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_photo = New System.Windows.Forms.Label()
        Me.lbl_lst = New System.Windows.Forms.Label()
        Me.lbl_brand = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_product_name = New System.Windows.Forms.Label()
        Me.lbl_product_id = New System.Windows.Forms.Label()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_product_name = New System.Windows.Forms.TextBox()
        Me.txt_product_id = New System.Windows.Forms.TextBox()
        Me.lst_product_id = New System.Windows.Forms.ListBox()
        Me.lbl_weight = New System.Windows.Forms.Label()
        Me.txt_weight = New System.Windows.Forms.TextBox()
        Me.lbl_series = New System.Windows.Forms.Label()
        Me.txt_series = New System.Windows.Forms.TextBox()
        Me.lbl_tagline = New System.Windows.Forms.Label()
        Me.lbl_product_table = New System.Windows.Forms.Label()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(247, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRODUCT DETAILS"
        '
        'cmb_category
        '
        Me.cmb_category.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_category.FormattingEnabled = True
        Me.cmb_category.Location = New System.Drawing.Point(218, 167)
        Me.cmb_category.Name = "cmb_category"
        Me.cmb_category.Size = New System.Drawing.Size(423, 28)
        Me.cmb_category.TabIndex = 12
        Me.cmb_category.Text = "Click here to choose category"
        '
        'pic_home
        '
        Me.pic_home.BackColor = System.Drawing.Color.Transparent
        Me.pic_home.BackgroundImage = CType(resources.GetObject("pic_home.BackgroundImage"), System.Drawing.Image)
        Me.pic_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_home.Location = New System.Drawing.Point(464, 502)
        Me.pic_home.Name = "pic_home"
        Me.pic_home.Size = New System.Drawing.Size(73, 72)
        Me.pic_home.TabIndex = 14
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
        Me.pic_logo.TabIndex = 15
        Me.pic_logo.TabStop = False
        '
        'lbl_photo
        '
        Me.lbl_photo.AutoSize = True
        Me.lbl_photo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_photo.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_photo.Location = New System.Drawing.Point(726, 135)
        Me.lbl_photo.Name = "lbl_photo"
        Me.lbl_photo.Size = New System.Drawing.Size(75, 25)
        Me.lbl_photo.TabIndex = 39
        Me.lbl_photo.Text = "Photo"
        '
        'lbl_lst
        '
        Me.lbl_lst.AutoSize = True
        Me.lbl_lst.BackColor = System.Drawing.Color.Transparent
        Me.lbl_lst.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lst.Location = New System.Drawing.Point(99, 131)
        Me.lbl_lst.Name = "lbl_lst"
        Me.lbl_lst.Size = New System.Drawing.Size(84, 25)
        Me.lbl_lst.TabIndex = 38
        Me.lbl_lst.Text = "Choose"
        '
        'lbl_brand
        '
        Me.lbl_brand.AutoSize = True
        Me.lbl_brand.BackColor = System.Drawing.Color.Transparent
        Me.lbl_brand.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brand.Location = New System.Drawing.Point(214, 349)
        Me.lbl_brand.Name = "lbl_brand"
        Me.lbl_brand.Size = New System.Drawing.Size(58, 20)
        Me.lbl_brand.TabIndex = 37
        Me.lbl_brand.Text = "Brand"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_price.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(214, 303)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(82, 20)
        Me.lbl_price.TabIndex = 36
        Me.lbl_price.Text = "Price ($)"
        '
        'lbl_product_name
        '
        Me.lbl_product_name.AutoSize = True
        Me.lbl_product_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_product_name.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_name.Location = New System.Drawing.Point(214, 257)
        Me.lbl_product_name.Name = "lbl_product_name"
        Me.lbl_product_name.Size = New System.Drawing.Size(121, 20)
        Me.lbl_product_name.TabIndex = 35
        Me.lbl_product_name.Text = "Product Name"
        '
        'lbl_product_id
        '
        Me.lbl_product_id.AutoSize = True
        Me.lbl_product_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_product_id.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_id.Location = New System.Drawing.Point(214, 211)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(98, 20)
        Me.lbl_product_id.TabIndex = 34
        Me.lbl_product_id.Text = "Product ID"
        '
        'txt_brand
        '
        Me.txt_brand.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(386, 346)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.ReadOnly = True
        Me.txt_brand.Size = New System.Drawing.Size(255, 27)
        Me.txt_brand.TabIndex = 33
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_product.Location = New System.Drawing.Point(659, 174)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(228, 296)
        Me.pic_product.TabIndex = 32
        Me.pic_product.TabStop = False
        '
        'txt_price
        '
        Me.txt_price.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(386, 300)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(255, 27)
        Me.txt_price.TabIndex = 31
        '
        'txt_product_name
        '
        Me.txt_product_name.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_product_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_name.Location = New System.Drawing.Point(386, 254)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.ReadOnly = True
        Me.txt_product_name.Size = New System.Drawing.Size(255, 27)
        Me.txt_product_name.TabIndex = 30
        '
        'txt_product_id
        '
        Me.txt_product_id.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_product_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_id.Location = New System.Drawing.Point(386, 208)
        Me.txt_product_id.Name = "txt_product_id"
        Me.txt_product_id.ReadOnly = True
        Me.txt_product_id.Size = New System.Drawing.Size(255, 27)
        Me.txt_product_id.TabIndex = 29
        '
        'lst_product_id
        '
        Me.lst_product_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lst_product_id.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_product_id.FormattingEnabled = True
        Me.lst_product_id.ItemHeight = 22
        Me.lst_product_id.Location = New System.Drawing.Point(104, 167)
        Me.lst_product_id.Name = "lst_product_id"
        Me.lst_product_id.Size = New System.Drawing.Size(103, 312)
        Me.lst_product_id.TabIndex = 28
        '
        'lbl_weight
        '
        Me.lbl_weight.AutoSize = True
        Me.lbl_weight.BackColor = System.Drawing.Color.Transparent
        Me.lbl_weight.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_weight.Location = New System.Drawing.Point(214, 442)
        Me.lbl_weight.Name = "lbl_weight"
        Me.lbl_weight.Size = New System.Drawing.Size(64, 20)
        Me.lbl_weight.TabIndex = 41
        Me.lbl_weight.Text = "Weight"
        '
        'txt_weight
        '
        Me.txt_weight.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_weight.Location = New System.Drawing.Point(386, 439)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.ReadOnly = True
        Me.txt_weight.Size = New System.Drawing.Size(255, 27)
        Me.txt_weight.TabIndex = 40
        '
        'lbl_series
        '
        Me.lbl_series.AutoSize = True
        Me.lbl_series.BackColor = System.Drawing.Color.Transparent
        Me.lbl_series.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_series.Location = New System.Drawing.Point(214, 395)
        Me.lbl_series.Name = "lbl_series"
        Me.lbl_series.Size = New System.Drawing.Size(56, 20)
        Me.lbl_series.TabIndex = 43
        Me.lbl_series.Text = "Series"
        '
        'txt_series
        '
        Me.txt_series.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_series.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_series.Location = New System.Drawing.Point(386, 392)
        Me.txt_series.Name = "txt_series"
        Me.txt_series.ReadOnly = True
        Me.txt_series.Size = New System.Drawing.Size(255, 27)
        Me.txt_series.TabIndex = 42
        '
        'lbl_tagline
        '
        Me.lbl_tagline.AutoSize = True
        Me.lbl_tagline.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tagline.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagline.Location = New System.Drawing.Point(304, 666)
        Me.lbl_tagline.Name = "lbl_tagline"
        Me.lbl_tagline.Size = New System.Drawing.Size(315, 28)
        Me.lbl_tagline.TabIndex = 44
        Me.lbl_tagline.Text = "Affordable Excellence of Tech"
        '
        'lbl_product_table
        '
        Me.lbl_product_table.AutoSize = True
        Me.lbl_product_table.BackColor = System.Drawing.Color.Transparent
        Me.lbl_product_table.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_product_table.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_product_table.Location = New System.Drawing.Point(694, 545)
        Me.lbl_product_table.Name = "lbl_product_table"
        Me.lbl_product_table.Size = New System.Drawing.Size(199, 34)
        Me.lbl_product_table.TabIndex = 45
        Me.lbl_product_table.Text = "Want to view as TABLE form ?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click here"
        Me.lbl_product_table.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_productdetails_a176607
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.lbl_product_table)
        Me.Controls.Add(Me.lbl_tagline)
        Me.Controls.Add(Me.lbl_series)
        Me.Controls.Add(Me.txt_series)
        Me.Controls.Add(Me.lbl_weight)
        Me.Controls.Add(Me.txt_weight)
        Me.Controls.Add(Me.lbl_photo)
        Me.Controls.Add(Me.lbl_lst)
        Me.Controls.Add(Me.lbl_brand)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_product_name)
        Me.Controls.Add(Me.lbl_product_id)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_product_name)
        Me.Controls.Add(Me.txt_product_id)
        Me.Controls.Add(Me.lst_product_id)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.pic_home)
        Me.Controls.Add(Me.cmb_category)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_productdetails_a176607"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Details"
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_category As ComboBox
    Friend WithEvents pic_home As PictureBox
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents lbl_photo As Label
    Friend WithEvents lbl_lst As Label
    Friend WithEvents lbl_brand As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_product_name As Label
    Friend WithEvents lbl_product_id As Label
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_product_name As TextBox
    Friend WithEvents txt_product_id As TextBox
    Friend WithEvents lst_product_id As ListBox
    Friend WithEvents lbl_weight As Label
    Friend WithEvents txt_weight As TextBox
    Friend WithEvents lbl_series As Label
    Friend WithEvents txt_series As TextBox
    Friend WithEvents lbl_tagline As Label
    Friend WithEvents lbl_product_table As Label
End Class
