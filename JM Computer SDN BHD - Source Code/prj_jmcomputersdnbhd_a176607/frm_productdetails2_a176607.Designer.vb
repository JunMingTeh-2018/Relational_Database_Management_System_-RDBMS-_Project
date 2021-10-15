<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productdetails2_a176607
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productdetails2_a176607))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_tagline = New System.Windows.Forms.Label()
        Me.cmb_category = New System.Windows.Forms.ComboBox()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.btn_insert_product = New System.Windows.Forms.Button()
        Me.btn_edit_product = New System.Windows.Forms.Button()
        Me.pic_home = New System.Windows.Forms.PictureBox()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_logo
        '
        Me.pic_logo.BackColor = System.Drawing.Color.Transparent
        Me.pic_logo.BackgroundImage = CType(resources.GetObject("pic_logo.BackgroundImage"), System.Drawing.Image)
        Me.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_logo.Location = New System.Drawing.Point(12, 12)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(90, 81)
        Me.pic_logo.TabIndex = 16
        Me.pic_logo.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(159, 29)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(655, 50)
        Me.lbl_title.TabIndex = 17
        Me.lbl_title.Text = "PRODUCT DETAILS TABLE"
        '
        'lbl_tagline
        '
        Me.lbl_tagline.AutoSize = True
        Me.lbl_tagline.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tagline.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagline.Location = New System.Drawing.Point(304, 665)
        Me.lbl_tagline.Name = "lbl_tagline"
        Me.lbl_tagline.Size = New System.Drawing.Size(315, 28)
        Me.lbl_tagline.TabIndex = 19
        Me.lbl_tagline.Text = "Affordable Excellence of Tech"
        '
        'cmb_category
        '
        Me.cmb_category.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_category.FormattingEnabled = True
        Me.cmb_category.Location = New System.Drawing.Point(92, 117)
        Me.cmb_category.Name = "cmb_category"
        Me.cmb_category.Size = New System.Drawing.Size(810, 28)
        Me.cmb_category.TabIndex = 20
        Me.cmb_category.Text = "Click here to choose category"
        '
        'grd_products
        '
        Me.grd_products.AllowUserToAddRows = False
        Me.grd_products.AllowUserToDeleteRows = False
        Me.grd_products.AllowUserToResizeColumns = False
        Me.grd_products.AllowUserToResizeRows = False
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grd_products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_products.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_products.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_products.DefaultCellStyle = DataGridViewCellStyle2
        Me.grd_products.Location = New System.Drawing.Point(92, 165)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_products.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grd_products.RowHeadersWidth = 51
        Me.grd_products.RowTemplate.Height = 24
        Me.grd_products.Size = New System.Drawing.Size(810, 334)
        Me.grd_products.TabIndex = 21
        '
        'btn_insert_product
        '
        Me.btn_insert_product.BackColor = System.Drawing.Color.Transparent
        Me.btn_insert_product.BackgroundImage = CType(resources.GetObject("btn_insert_product.BackgroundImage"), System.Drawing.Image)
        Me.btn_insert_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_insert_product.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insert_product.ForeColor = System.Drawing.Color.Transparent
        Me.btn_insert_product.Location = New System.Drawing.Point(69, 523)
        Me.btn_insert_product.Name = "btn_insert_product"
        Me.btn_insert_product.Size = New System.Drawing.Size(85, 81)
        Me.btn_insert_product.TabIndex = 23
        Me.btn_insert_product.UseVisualStyleBackColor = False
        '
        'btn_edit_product
        '
        Me.btn_edit_product.BackColor = System.Drawing.Color.Transparent
        Me.btn_edit_product.BackgroundImage = CType(resources.GetObject("btn_edit_product.BackgroundImage"), System.Drawing.Image)
        Me.btn_edit_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_edit_product.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit_product.ForeColor = System.Drawing.Color.Transparent
        Me.btn_edit_product.Location = New System.Drawing.Point(841, 524)
        Me.btn_edit_product.Name = "btn_edit_product"
        Me.btn_edit_product.Size = New System.Drawing.Size(85, 80)
        Me.btn_edit_product.TabIndex = 22
        Me.btn_edit_product.UseVisualStyleBackColor = False
        '
        'pic_home
        '
        Me.pic_home.BackColor = System.Drawing.Color.Transparent
        Me.pic_home.BackgroundImage = CType(resources.GetObject("pic_home.BackgroundImage"), System.Drawing.Image)
        Me.pic_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_home.Location = New System.Drawing.Point(463, 502)
        Me.pic_home.Name = "pic_home"
        Me.pic_home.Size = New System.Drawing.Size(73, 72)
        Me.pic_home.TabIndex = 24
        Me.pic_home.TabStop = False
        '
        'frm_productdetails2_a176607
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.pic_home)
        Me.Controls.Add(Me.btn_insert_product)
        Me.Controls.Add(Me.btn_edit_product)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.cmb_category)
        Me.Controls.Add(Me.lbl_tagline)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_productdetails2_a176607"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Details Table"
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_tagline As Label
    Friend WithEvents cmb_category As ComboBox
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents btn_insert_product As Button
    Friend WithEvents btn_edit_product As Button
    Friend WithEvents pic_home As PictureBox
End Class
