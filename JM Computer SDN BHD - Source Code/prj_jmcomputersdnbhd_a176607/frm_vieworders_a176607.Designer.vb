<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_vieworders_a176607
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_vieworders_a176607))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_tagline = New System.Windows.Forms.Label()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.pic_home = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_orders = New System.Windows.Forms.DataGridView()
        Me.lbl_order_date = New System.Windows.Forms.Label()
        Me.txt_order_date = New System.Windows.Forms.TextBox()
        Me.lbl_order_number = New System.Windows.Forms.Label()
        Me.lbl_customer_name = New System.Windows.Forms.Label()
        Me.lbl_staff_name = New System.Windows.Forms.Label()
        Me.txt_customer_name = New System.Windows.Forms.TextBox()
        Me.txt_staff_name = New System.Windows.Forms.TextBox()
        Me.lbl_total_price = New System.Windows.Forms.Label()
        Me.txt_total_price = New System.Windows.Forms.TextBox()
        Me.cmb_order_number = New System.Windows.Forms.ComboBox()
        Me.btn_make_order = New System.Windows.Forms.Button()
        Me.btn_order_record = New System.Windows.Forms.Button()
        Me.btn_order_details = New System.Windows.Forms.Button()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_tagline
        '
        Me.lbl_tagline.AutoSize = True
        Me.lbl_tagline.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tagline.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagline.Location = New System.Drawing.Point(286, 666)
        Me.lbl_tagline.Name = "lbl_tagline"
        Me.lbl_tagline.Size = New System.Drawing.Size(315, 28)
        Me.lbl_tagline.TabIndex = 16
        Me.lbl_tagline.Text = "Affordable Excellence of Tech"
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
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(373, 29)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(224, 50)
        Me.lbl_title.TabIndex = 12
        Me.lbl_title.Text = "INVOICE"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_orders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grd_orders.DefaultCellStyle = DataGridViewCellStyle2
        Me.grd_orders.Location = New System.Drawing.Point(92, 175)
        Me.grd_orders.Name = "grd_orders"
        Me.grd_orders.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_orders.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grd_orders.RowHeadersWidth = 51
        Me.grd_orders.RowTemplate.Height = 24
        Me.grd_orders.Size = New System.Drawing.Size(809, 269)
        Me.grd_orders.TabIndex = 11
        '
        'lbl_order_date
        '
        Me.lbl_order_date.AutoSize = True
        Me.lbl_order_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order_date.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_date.Location = New System.Drawing.Point(620, 131)
        Me.lbl_order_date.Name = "lbl_order_date"
        Me.lbl_order_date.Size = New System.Drawing.Size(96, 20)
        Me.lbl_order_date.TabIndex = 181
        Me.lbl_order_date.Text = "Order Date"
        '
        'txt_order_date
        '
        Me.txt_order_date.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_order_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_order_date.Location = New System.Drawing.Point(764, 127)
        Me.txt_order_date.Name = "txt_order_date"
        Me.txt_order_date.ReadOnly = True
        Me.txt_order_date.Size = New System.Drawing.Size(133, 27)
        Me.txt_order_date.TabIndex = 180
        Me.txt_order_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_order_number
        '
        Me.lbl_order_number.AutoSize = True
        Me.lbl_order_number.BackColor = System.Drawing.Color.Transparent
        Me.lbl_order_number.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_number.Location = New System.Drawing.Point(362, 131)
        Me.lbl_order_number.Name = "lbl_order_number"
        Me.lbl_order_number.Size = New System.Drawing.Size(122, 20)
        Me.lbl_order_number.TabIndex = 179
        Me.lbl_order_number.Text = "Order Number"
        '
        'lbl_customer_name
        '
        Me.lbl_customer_name.AutoSize = True
        Me.lbl_customer_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customer_name.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customer_name.Location = New System.Drawing.Point(97, 130)
        Me.lbl_customer_name.Name = "lbl_customer_name"
        Me.lbl_customer_name.Size = New System.Drawing.Size(81, 20)
        Me.lbl_customer_name.TabIndex = 177
        Me.lbl_customer_name.Text = "Customer"
        '
        'lbl_staff_name
        '
        Me.lbl_staff_name.AutoSize = True
        Me.lbl_staff_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staff_name.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staff_name.Location = New System.Drawing.Point(96, 464)
        Me.lbl_staff_name.Name = "lbl_staff_name"
        Me.lbl_staff_name.Size = New System.Drawing.Size(48, 20)
        Me.lbl_staff_name.TabIndex = 176
        Me.lbl_staff_name.Text = "Staff"
        '
        'txt_customer_name
        '
        Me.txt_customer_name.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_customer_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customer_name.Location = New System.Drawing.Point(209, 127)
        Me.txt_customer_name.Name = "txt_customer_name"
        Me.txt_customer_name.ReadOnly = True
        Me.txt_customer_name.Size = New System.Drawing.Size(147, 27)
        Me.txt_customer_name.TabIndex = 173
        '
        'txt_staff_name
        '
        Me.txt_staff_name.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_staff_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staff_name.Location = New System.Drawing.Point(209, 461)
        Me.txt_staff_name.Name = "txt_staff_name"
        Me.txt_staff_name.ReadOnly = True
        Me.txt_staff_name.Size = New System.Drawing.Size(147, 27)
        Me.txt_staff_name.TabIndex = 172
        '
        'lbl_total_price
        '
        Me.lbl_total_price.AutoSize = True
        Me.lbl_total_price.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total_price.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_price.Location = New System.Drawing.Point(587, 465)
        Me.lbl_total_price.Name = "lbl_total_price"
        Me.lbl_total_price.Size = New System.Drawing.Size(129, 20)
        Me.lbl_total_price.TabIndex = 183
        Me.lbl_total_price.Text = "Total Price ($)"
        '
        'txt_total_price
        '
        Me.txt_total_price.Cursor = System.Windows.Forms.Cursors.No
        Me.txt_total_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_price.Location = New System.Drawing.Point(764, 460)
        Me.txt_total_price.Name = "txt_total_price"
        Me.txt_total_price.ReadOnly = True
        Me.txt_total_price.Size = New System.Drawing.Size(133, 28)
        Me.txt_total_price.TabIndex = 182
        Me.txt_total_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_order_number
        '
        Me.cmb_order_number.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_order_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_order_number.FormattingEnabled = True
        Me.cmb_order_number.Location = New System.Drawing.Point(523, 127)
        Me.cmb_order_number.Name = "cmb_order_number"
        Me.cmb_order_number.Size = New System.Drawing.Size(84, 28)
        Me.cmb_order_number.TabIndex = 184
        '
        'btn_make_order
        '
        Me.btn_make_order.BackColor = System.Drawing.Color.Transparent
        Me.btn_make_order.BackgroundImage = CType(resources.GetObject("btn_make_order.BackgroundImage"), System.Drawing.Image)
        Me.btn_make_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_make_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_make_order.ForeColor = System.Drawing.Color.Transparent
        Me.btn_make_order.Location = New System.Drawing.Point(839, 527)
        Me.btn_make_order.Name = "btn_make_order"
        Me.btn_make_order.Size = New System.Drawing.Size(85, 81)
        Me.btn_make_order.TabIndex = 185
        Me.btn_make_order.UseVisualStyleBackColor = False
        '
        'btn_order_record
        '
        Me.btn_order_record.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_order_record.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order_record.Location = New System.Drawing.Point(68, 563)
        Me.btn_order_record.Name = "btn_order_record"
        Me.btn_order_record.Size = New System.Drawing.Size(251, 28)
        Me.btn_order_record.TabIndex = 187
        Me.btn_order_record.Text = "ORDER RECORD"
        Me.btn_order_record.UseVisualStyleBackColor = True
        '
        'btn_order_details
        '
        Me.btn_order_details.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_order_details.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order_details.Location = New System.Drawing.Point(68, 527)
        Me.btn_order_details.Name = "btn_order_details"
        Me.btn_order_details.Size = New System.Drawing.Size(251, 28)
        Me.btn_order_details.TabIndex = 186
        Me.btn_order_details.Text = "ORDER DETAILS"
        Me.btn_order_details.UseVisualStyleBackColor = True
        '
        'frm_vieworders_a176607
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.btn_order_record)
        Me.Controls.Add(Me.btn_order_details)
        Me.Controls.Add(Me.btn_make_order)
        Me.Controls.Add(Me.cmb_order_number)
        Me.Controls.Add(Me.lbl_total_price)
        Me.Controls.Add(Me.txt_total_price)
        Me.Controls.Add(Me.lbl_order_date)
        Me.Controls.Add(Me.txt_order_date)
        Me.Controls.Add(Me.lbl_order_number)
        Me.Controls.Add(Me.lbl_customer_name)
        Me.Controls.Add(Me.lbl_staff_name)
        Me.Controls.Add(Me.txt_customer_name)
        Me.Controls.Add(Me.txt_staff_name)
        Me.Controls.Add(Me.lbl_tagline)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.pic_home)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_orders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_vieworders_a176607"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Orders"
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_tagline As Label
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents pic_home As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_orders As DataGridView
    Friend WithEvents lbl_order_date As Label
    Friend WithEvents txt_order_date As TextBox
    Friend WithEvents lbl_order_number As Label
    Friend WithEvents lbl_customer_name As Label
    Friend WithEvents lbl_staff_name As Label
    Friend WithEvents txt_customer_name As TextBox
    Friend WithEvents txt_staff_name As TextBox
    Friend WithEvents lbl_total_price As Label
    Friend WithEvents txt_total_price As TextBox
    Friend WithEvents cmb_order_number As ComboBox
    Friend WithEvents btn_make_order As Button
    Friend WithEvents btn_order_record As Button
    Friend WithEvents btn_order_details As Button
End Class
