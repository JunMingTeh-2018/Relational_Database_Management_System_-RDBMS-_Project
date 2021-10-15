<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder_a176607
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_a176607))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_product_id = New System.Windows.Forms.Label()
        Me.cmb_customer_id = New System.Windows.Forms.ComboBox()
        Me.cmb_staff_id = New System.Windows.Forms.ComboBox()
        Me.txt_product_subtotal_price = New System.Windows.Forms.TextBox()
        Me.lbl_subtotal_price = New System.Windows.Forms.Label()
        Me.nud_quantity = New System.Windows.Forms.NumericUpDown()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_product_quantity = New System.Windows.Forms.Label()
        Me.txt_product_price = New System.Windows.Forms.TextBox()
        Me.txt_product_name = New System.Windows.Forms.TextBox()
        Me.lbl_total_price = New System.Windows.Forms.Label()
        Me.txt_total_price = New System.Windows.Forms.TextBox()
        Me.btn_confirm_order = New System.Windows.Forms.Button()
        Me.btn_remove_product = New System.Windows.Forms.Button()
        Me.btn_add_product = New System.Windows.Forms.Button()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_product_price = New System.Windows.Forms.Label()
        Me.lbl_product_name = New System.Windows.Forms.Label()
        Me.lbl_order_date = New System.Windows.Forms.Label()
        Me.txt_order_date = New System.Windows.Forms.TextBox()
        Me.lbl_order_number = New System.Windows.Forms.Label()
        Me.txt_order_number = New System.Windows.Forms.TextBox()
        Me.lbl_customer_name = New System.Windows.Forms.Label()
        Me.lbl_staff_name = New System.Windows.Forms.Label()
        Me.lbl_customer_id = New System.Windows.Forms.Label()
        Me.lbl_staff_id = New System.Windows.Forms.Label()
        Me.txt_customer_name = New System.Windows.Forms.TextBox()
        Me.txt_staff_name = New System.Windows.Forms.TextBox()
        Me.lbl_tagline = New System.Windows.Forms.Label()
        Me.pic_home = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_orders = New System.Windows.Forms.DataGridView()
        Me.cmb_product_id = New System.Windows.Forms.ComboBox()
        Me.lbl_photo = New System.Windows.Forms.Label()
        Me.lbl_category = New System.Windows.Forms.Label()
        Me.txt_category = New System.Windows.Forms.TextBox()
        Me.btn_view_orders = New System.Windows.Forms.Button()
        Me.btn_order_record = New System.Windows.Forms.Button()
        Me.btn_order_details = New System.Windows.Forms.Button()
        CType(Me.nud_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_product_id
        '
        Me.lbl_product_id.AutoSize = True
        Me.lbl_product_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_product_id.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_id.Location = New System.Drawing.Point(310, 198)
        Me.lbl_product_id.Name = "lbl_product_id"
        Me.lbl_product_id.Size = New System.Drawing.Size(98, 20)
        Me.lbl_product_id.TabIndex = 172
        Me.lbl_product_id.Text = "Product ID"
        '
        'cmb_customer_id
        '
        Me.cmb_customer_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_customer_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_customer_id.FormattingEnabled = True
        Me.cmb_customer_id.Location = New System.Drawing.Point(251, 120)
        Me.cmb_customer_id.Name = "cmb_customer_id"
        Me.cmb_customer_id.Size = New System.Drawing.Size(121, 28)
        Me.cmb_customer_id.TabIndex = 171
        '
        'cmb_staff_id
        '
        Me.cmb_staff_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_staff_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_staff_id.FormattingEnabled = True
        Me.cmb_staff_id.Location = New System.Drawing.Point(499, 120)
        Me.cmb_staff_id.Name = "cmb_staff_id"
        Me.cmb_staff_id.Size = New System.Drawing.Size(114, 28)
        Me.cmb_staff_id.TabIndex = 170
        '
        'txt_product_subtotal_price
        '
        Me.txt_product_subtotal_price.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_product_subtotal_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_subtotal_price.Location = New System.Drawing.Point(786, 260)
        Me.txt_product_subtotal_price.Name = "txt_product_subtotal_price"
        Me.txt_product_subtotal_price.ReadOnly = True
        Me.txt_product_subtotal_price.Size = New System.Drawing.Size(109, 27)
        Me.txt_product_subtotal_price.TabIndex = 169
        Me.txt_product_subtotal_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_subtotal_price
        '
        Me.lbl_subtotal_price.AutoSize = True
        Me.lbl_subtotal_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subtotal_price.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal_price.Location = New System.Drawing.Point(588, 263)
        Me.lbl_subtotal_price.Name = "lbl_subtotal_price"
        Me.lbl_subtotal_price.Size = New System.Drawing.Size(153, 20)
        Me.lbl_subtotal_price.TabIndex = 168
        Me.lbl_subtotal_price.Text = "Subtotal Price ($)"
        '
        'nud_quantity
        '
        Me.nud_quantity.Location = New System.Drawing.Point(755, 231)
        Me.nud_quantity.Name = "nud_quantity"
        Me.nud_quantity.Size = New System.Drawing.Size(140, 22)
        Me.nud_quantity.TabIndex = 167
        Me.nud_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nud_quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'pic_logo
        '
        Me.pic_logo.BackColor = System.Drawing.Color.Transparent
        Me.pic_logo.BackgroundImage = CType(resources.GetObject("pic_logo.BackgroundImage"), System.Drawing.Image)
        Me.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_logo.Location = New System.Drawing.Point(12, 12)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(90, 81)
        Me.pic_logo.TabIndex = 165
        Me.pic_logo.TabStop = False
        '
        'lbl_product_quantity
        '
        Me.lbl_product_quantity.AutoSize = True
        Me.lbl_product_quantity.BackColor = System.Drawing.Color.Transparent
        Me.lbl_product_quantity.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_quantity.Location = New System.Drawing.Point(588, 230)
        Me.lbl_product_quantity.Name = "lbl_product_quantity"
        Me.lbl_product_quantity.Size = New System.Drawing.Size(77, 20)
        Me.lbl_product_quantity.TabIndex = 164
        Me.lbl_product_quantity.Text = "Quantity"
        '
        'txt_product_price
        '
        Me.txt_product_price.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_product_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_price.Location = New System.Drawing.Point(430, 260)
        Me.txt_product_price.Name = "txt_product_price"
        Me.txt_product_price.ReadOnly = True
        Me.txt_product_price.Size = New System.Drawing.Size(140, 27)
        Me.txt_product_price.TabIndex = 163
        Me.txt_product_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_product_name
        '
        Me.txt_product_name.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_product_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_name.Location = New System.Drawing.Point(755, 195)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.ReadOnly = True
        Me.txt_product_name.Size = New System.Drawing.Size(141, 27)
        Me.txt_product_name.TabIndex = 162
        Me.txt_product_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_total_price
        '
        Me.lbl_total_price.AutoSize = True
        Me.lbl_total_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total_price.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_price.Location = New System.Drawing.Point(612, 470)
        Me.lbl_total_price.Name = "lbl_total_price"
        Me.lbl_total_price.Size = New System.Drawing.Size(129, 20)
        Me.lbl_total_price.TabIndex = 161
        Me.lbl_total_price.Text = "Total Price ($)"
        '
        'txt_total_price
        '
        Me.txt_total_price.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_total_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_price.Location = New System.Drawing.Point(786, 466)
        Me.txt_total_price.Name = "txt_total_price"
        Me.txt_total_price.ReadOnly = True
        Me.txt_total_price.Size = New System.Drawing.Size(110, 28)
        Me.txt_total_price.TabIndex = 160
        Me.txt_total_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_confirm_order
        '
        Me.btn_confirm_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirm_order.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm_order.Location = New System.Drawing.Point(397, 466)
        Me.btn_confirm_order.Name = "btn_confirm_order"
        Me.btn_confirm_order.Size = New System.Drawing.Size(209, 28)
        Me.btn_confirm_order.TabIndex = 159
        Me.btn_confirm_order.Text = "CONFIRM ORDER"
        Me.btn_confirm_order.UseVisualStyleBackColor = True
        '
        'btn_remove_product
        '
        Me.btn_remove_product.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_remove_product.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove_product.Location = New System.Drawing.Point(100, 466)
        Me.btn_remove_product.Name = "btn_remove_product"
        Me.btn_remove_product.Size = New System.Drawing.Size(291, 28)
        Me.btn_remove_product.TabIndex = 158
        Me.btn_remove_product.Text = "REMOVE PRODUCT"
        Me.btn_remove_product.UseVisualStyleBackColor = True
        '
        'btn_add_product
        '
        Me.btn_add_product.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_product.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_product.Location = New System.Drawing.Point(307, 293)
        Me.btn_add_product.Name = "btn_add_product"
        Me.btn_add_product.Size = New System.Drawing.Size(589, 28)
        Me.btn_add_product.TabIndex = 157
        Me.btn_add_product.Text = "ADD PRODUCT"
        Me.btn_add_product.UseVisualStyleBackColor = True
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_product.Location = New System.Drawing.Point(100, 226)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(201, 234)
        Me.pic_product.TabIndex = 156
        Me.pic_product.TabStop = False
        '
        'lbl_product_price
        '
        Me.lbl_product_price.AutoSize = True
        Me.lbl_product_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_product_price.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_price.Location = New System.Drawing.Point(310, 263)
        Me.lbl_product_price.Name = "lbl_product_price"
        Me.lbl_product_price.Size = New System.Drawing.Size(82, 20)
        Me.lbl_product_price.TabIndex = 155
        Me.lbl_product_price.Text = "Price ($)"
        '
        'lbl_product_name
        '
        Me.lbl_product_name.AutoSize = True
        Me.lbl_product_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_product_name.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_product_name.Location = New System.Drawing.Point(588, 198)
        Me.lbl_product_name.Name = "lbl_product_name"
        Me.lbl_product_name.Size = New System.Drawing.Size(121, 20)
        Me.lbl_product_name.TabIndex = 154
        Me.lbl_product_name.Text = "Product Name"
        '
        'lbl_order_date
        '
        Me.lbl_order_date.AutoSize = True
        Me.lbl_order_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order_date.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_date.Location = New System.Drawing.Point(619, 158)
        Me.lbl_order_date.Name = "lbl_order_date"
        Me.lbl_order_date.Size = New System.Drawing.Size(96, 20)
        Me.lbl_order_date.TabIndex = 153
        Me.lbl_order_date.Text = "Order Date"
        '
        'txt_order_date
        '
        Me.txt_order_date.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_order_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_order_date.Location = New System.Drawing.Point(763, 154)
        Me.txt_order_date.Name = "txt_order_date"
        Me.txt_order_date.ReadOnly = True
        Me.txt_order_date.Size = New System.Drawing.Size(133, 27)
        Me.txt_order_date.TabIndex = 152
        Me.txt_order_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_order_number
        '
        Me.lbl_order_number.AutoSize = True
        Me.lbl_order_number.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order_number.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_number.Location = New System.Drawing.Point(619, 124)
        Me.lbl_order_number.Name = "lbl_order_number"
        Me.lbl_order_number.Size = New System.Drawing.Size(122, 20)
        Me.lbl_order_number.TabIndex = 151
        Me.lbl_order_number.Text = "Order Numebr"
        '
        'txt_order_number
        '
        Me.txt_order_number.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_order_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_order_number.Location = New System.Drawing.Point(786, 121)
        Me.txt_order_number.Name = "txt_order_number"
        Me.txt_order_number.ReadOnly = True
        Me.txt_order_number.Size = New System.Drawing.Size(110, 27)
        Me.txt_order_number.TabIndex = 150
        Me.txt_order_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_customer_name
        '
        Me.lbl_customer_name.AutoSize = True
        Me.lbl_customer_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customer_name.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_name.Location = New System.Drawing.Point(96, 157)
        Me.lbl_customer_name.Name = "lbl_customer_name"
        Me.lbl_customer_name.Size = New System.Drawing.Size(53, 20)
        Me.lbl_customer_name.TabIndex = 149
        Me.lbl_customer_name.Text = "Name"
        '
        'lbl_staff_name
        '
        Me.lbl_staff_name.AutoSize = True
        Me.lbl_staff_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff_name.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_name.Location = New System.Drawing.Point(378, 157)
        Me.lbl_staff_name.Name = "lbl_staff_name"
        Me.lbl_staff_name.Size = New System.Drawing.Size(53, 20)
        Me.lbl_staff_name.TabIndex = 148
        Me.lbl_staff_name.Text = "Name"
        '
        'lbl_customer_id
        '
        Me.lbl_customer_id.AutoSize = True
        Me.lbl_customer_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customer_id.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_id.Location = New System.Drawing.Point(96, 123)
        Me.lbl_customer_id.Name = "lbl_customer_id"
        Me.lbl_customer_id.Size = New System.Drawing.Size(108, 20)
        Me.lbl_customer_id.TabIndex = 147
        Me.lbl_customer_id.Text = "Customer ID"
        '
        'lbl_staff_id
        '
        Me.lbl_staff_id.AutoSize = True
        Me.lbl_staff_id.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff_id.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_id.Location = New System.Drawing.Point(378, 123)
        Me.lbl_staff_id.Name = "lbl_staff_id"
        Me.lbl_staff_id.Size = New System.Drawing.Size(75, 20)
        Me.lbl_staff_id.TabIndex = 146
        Me.lbl_staff_id.Text = "Staff ID"
        '
        'txt_customer_name
        '
        Me.txt_customer_name.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_customer_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customer_name.Location = New System.Drawing.Point(228, 154)
        Me.txt_customer_name.Name = "txt_customer_name"
        Me.txt_customer_name.ReadOnly = True
        Me.txt_customer_name.Size = New System.Drawing.Size(144, 27)
        Me.txt_customer_name.TabIndex = 145
        Me.txt_customer_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_staff_name
        '
        Me.txt_staff_name.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_staff_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staff_name.Location = New System.Drawing.Point(476, 154)
        Me.txt_staff_name.Name = "txt_staff_name"
        Me.txt_staff_name.ReadOnly = True
        Me.txt_staff_name.Size = New System.Drawing.Size(137, 27)
        Me.txt_staff_name.TabIndex = 144
        Me.txt_staff_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_tagline
        '
        Me.lbl_tagline.AutoSize = True
        Me.lbl_tagline.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tagline.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagline.Location = New System.Drawing.Point(291, 666)
        Me.lbl_tagline.Name = "lbl_tagline"
        Me.lbl_tagline.Size = New System.Drawing.Size(315, 28)
        Me.lbl_tagline.TabIndex = 143
        Me.lbl_tagline.Text = "Affordable Excellence of Tech"
        '
        'pic_home
        '
        Me.pic_home.BackColor = System.Drawing.Color.Transparent
        Me.pic_home.BackgroundImage = CType(resources.GetObject("pic_home.BackgroundImage"), System.Drawing.Image)
        Me.pic_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_home.Location = New System.Drawing.Point(464, 500)
        Me.pic_home.Name = "pic_home"
        Me.pic_home.Size = New System.Drawing.Size(73, 72)
        Me.pic_home.TabIndex = 142
        Me.pic_home.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(310, 28)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(350, 50)
        Me.lbl_title.TabIndex = 141
        Me.lbl_title.Text = "MAKE ORDER"
        '
        'grd_orders
        '
        Me.grd_orders.AllowUserToAddRows = False
        Me.grd_orders.AllowUserToDeleteRows = False
        Me.grd_orders.AllowUserToResizeColumns = False
        Me.grd_orders.AllowUserToResizeRows = False
        Me.grd_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_orders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_orders.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_orders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grd_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_orders.DefaultCellStyle = DataGridViewCellStyle8
        Me.grd_orders.Location = New System.Drawing.Point(307, 327)
        Me.grd_orders.Name = "grd_orders"
        Me.grd_orders.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_orders.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grd_orders.RowHeadersWidth = 51
        Me.grd_orders.RowTemplate.Height = 24
        Me.grd_orders.Size = New System.Drawing.Size(589, 133)
        Me.grd_orders.TabIndex = 140
        '
        'cmb_product_id
        '
        Me.cmb_product_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_product_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_product_id.FormattingEnabled = True
        Me.cmb_product_id.Location = New System.Drawing.Point(454, 193)
        Me.cmb_product_id.Name = "cmb_product_id"
        Me.cmb_product_id.Size = New System.Drawing.Size(116, 28)
        Me.cmb_product_id.TabIndex = 175
        '
        'lbl_photo
        '
        Me.lbl_photo.AutoSize = True
        Me.lbl_photo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_photo.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_photo.Location = New System.Drawing.Point(151, 198)
        Me.lbl_photo.Name = "lbl_photo"
        Me.lbl_photo.Size = New System.Drawing.Size(75, 25)
        Me.lbl_photo.TabIndex = 176
        Me.lbl_photo.Text = "Photo"
        '
        'lbl_category
        '
        Me.lbl_category.AutoSize = True
        Me.lbl_category.BackColor = System.Drawing.Color.Transparent
        Me.lbl_category.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_category.Location = New System.Drawing.Point(310, 230)
        Me.lbl_category.Name = "lbl_category"
        Me.lbl_category.Size = New System.Drawing.Size(76, 20)
        Me.lbl_category.TabIndex = 178
        Me.lbl_category.Text = "Category"
        '
        'txt_category
        '
        Me.txt_category.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_category.Location = New System.Drawing.Point(430, 227)
        Me.txt_category.Name = "txt_category"
        Me.txt_category.ReadOnly = True
        Me.txt_category.Size = New System.Drawing.Size(140, 27)
        Me.txt_category.TabIndex = 179
        '
        'btn_view_orders
        '
        Me.btn_view_orders.BackColor = System.Drawing.Color.Transparent
        Me.btn_view_orders.BackgroundImage = CType(resources.GetObject("btn_view_orders.BackgroundImage"), System.Drawing.Image)
        Me.btn_view_orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_view_orders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_view_orders.ForeColor = System.Drawing.Color.Transparent
        Me.btn_view_orders.Location = New System.Drawing.Point(839, 526)
        Me.btn_view_orders.Name = "btn_view_orders"
        Me.btn_view_orders.Size = New System.Drawing.Size(85, 81)
        Me.btn_view_orders.TabIndex = 180
        Me.btn_view_orders.UseVisualStyleBackColor = False
        '
        'btn_order_record
        '
        Me.btn_order_record.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_order_record.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order_record.Location = New System.Drawing.Point(68, 569)
        Me.btn_order_record.Name = "btn_order_record"
        Me.btn_order_record.Size = New System.Drawing.Size(251, 28)
        Me.btn_order_record.TabIndex = 182
        Me.btn_order_record.Text = "ORDER RECORD"
        Me.btn_order_record.UseVisualStyleBackColor = True
        '
        'btn_order_details
        '
        Me.btn_order_details.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_order_details.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order_details.Location = New System.Drawing.Point(68, 533)
        Me.btn_order_details.Name = "btn_order_details"
        Me.btn_order_details.Size = New System.Drawing.Size(251, 28)
        Me.btn_order_details.TabIndex = 181
        Me.btn_order_details.Text = "ORDER DETAILS"
        Me.btn_order_details.UseVisualStyleBackColor = True
        '
        'frm_makeorder_a176607
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.btn_order_record)
        Me.Controls.Add(Me.btn_order_details)
        Me.Controls.Add(Me.btn_view_orders)
        Me.Controls.Add(Me.txt_category)
        Me.Controls.Add(Me.lbl_category)
        Me.Controls.Add(Me.lbl_photo)
        Me.Controls.Add(Me.cmb_product_id)
        Me.Controls.Add(Me.lbl_product_id)
        Me.Controls.Add(Me.cmb_customer_id)
        Me.Controls.Add(Me.cmb_staff_id)
        Me.Controls.Add(Me.txt_product_subtotal_price)
        Me.Controls.Add(Me.lbl_subtotal_price)
        Me.Controls.Add(Me.nud_quantity)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.lbl_product_quantity)
        Me.Controls.Add(Me.txt_product_price)
        Me.Controls.Add(Me.txt_product_name)
        Me.Controls.Add(Me.lbl_total_price)
        Me.Controls.Add(Me.txt_total_price)
        Me.Controls.Add(Me.btn_confirm_order)
        Me.Controls.Add(Me.btn_remove_product)
        Me.Controls.Add(Me.btn_add_product)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lbl_product_price)
        Me.Controls.Add(Me.lbl_product_name)
        Me.Controls.Add(Me.lbl_order_date)
        Me.Controls.Add(Me.txt_order_date)
        Me.Controls.Add(Me.lbl_order_number)
        Me.Controls.Add(Me.txt_order_number)
        Me.Controls.Add(Me.lbl_customer_name)
        Me.Controls.Add(Me.lbl_staff_name)
        Me.Controls.Add(Me.lbl_customer_id)
        Me.Controls.Add(Me.lbl_staff_id)
        Me.Controls.Add(Me.txt_customer_name)
        Me.Controls.Add(Me.txt_staff_name)
        Me.Controls.Add(Me.lbl_tagline)
        Me.Controls.Add(Me.pic_home)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_orders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_makeorder_a176607"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make Order"
        CType(Me.nud_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_product_id As Label
    Friend WithEvents cmb_customer_id As ComboBox
    Friend WithEvents cmb_staff_id As ComboBox
    Friend WithEvents txt_product_subtotal_price As TextBox
    Friend WithEvents lbl_subtotal_price As Label
    Friend WithEvents nud_quantity As NumericUpDown
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents lbl_product_quantity As Label
    Friend WithEvents txt_product_price As TextBox
    Friend WithEvents txt_product_name As TextBox
    Friend WithEvents lbl_total_price As Label
    Friend WithEvents txt_total_price As TextBox
    Friend WithEvents btn_confirm_order As Button
    Friend WithEvents btn_remove_product As Button
    Friend WithEvents btn_add_product As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_product_price As Label
    Friend WithEvents lbl_product_name As Label
    Friend WithEvents lbl_order_date As Label
    Friend WithEvents txt_order_date As TextBox
    Friend WithEvents lbl_order_number As Label
    Friend WithEvents txt_order_number As TextBox
    Friend WithEvents lbl_customer_name As Label
    Friend WithEvents lbl_staff_name As Label
    Friend WithEvents lbl_customer_id As Label
    Friend WithEvents lbl_staff_id As Label
    Friend WithEvents txt_customer_name As TextBox
    Friend WithEvents txt_staff_name As TextBox
    Friend WithEvents lbl_tagline As Label
    Friend WithEvents pic_home As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_orders As DataGridView
    Friend WithEvents cmb_product_id As ComboBox
    Friend WithEvents lbl_photo As Label
    Friend WithEvents lbl_category As Label
    Friend WithEvents txt_category As TextBox
    Friend WithEvents btn_view_orders As Button
    Friend WithEvents btn_order_record As Button
    Friend WithEvents btn_order_details As Button
End Class
