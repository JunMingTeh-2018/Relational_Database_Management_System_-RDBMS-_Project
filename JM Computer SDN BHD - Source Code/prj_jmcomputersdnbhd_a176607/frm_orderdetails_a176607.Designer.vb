<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderdetails_a176607
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderdetails_a176607))
        Me.grd_orders = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.pic_home = New System.Windows.Forms.PictureBox()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_tagline = New System.Windows.Forms.Label()
        Me.btn_make_order = New System.Windows.Forms.Button()
        Me.btn_view_orders = New System.Windows.Forms.Button()
        Me.btn_order_record = New System.Windows.Forms.Button()
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.grd_orders.Location = New System.Drawing.Point(92, 165)
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
        Me.grd_orders.Size = New System.Drawing.Size(809, 332)
        Me.grd_orders.TabIndex = 0
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(280, 28)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(419, 50)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "ORDER DETAILS"
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(92, 127)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(808, 27)
        Me.txt_search.TabIndex = 3
        Me.txt_search.Text = "Type here to serach Order Number"
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
        Me.pic_home.TabIndex = 6
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
        Me.pic_logo.TabIndex = 7
        Me.pic_logo.TabStop = False
        '
        'lbl_tagline
        '
        Me.lbl_tagline.AutoSize = True
        Me.lbl_tagline.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tagline.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagline.Location = New System.Drawing.Point(294, 666)
        Me.lbl_tagline.Name = "lbl_tagline"
        Me.lbl_tagline.Size = New System.Drawing.Size(315, 28)
        Me.lbl_tagline.TabIndex = 10
        Me.lbl_tagline.Text = "Affordable Excellence of Tech"
        '
        'btn_make_order
        '
        Me.btn_make_order.BackColor = System.Drawing.Color.Transparent
        Me.btn_make_order.BackgroundImage = CType(resources.GetObject("btn_make_order.BackgroundImage"), System.Drawing.Image)
        Me.btn_make_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_make_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_make_order.ForeColor = System.Drawing.Color.Transparent
        Me.btn_make_order.Location = New System.Drawing.Point(716, 525)
        Me.btn_make_order.Name = "btn_make_order"
        Me.btn_make_order.Size = New System.Drawing.Size(85, 81)
        Me.btn_make_order.TabIndex = 166
        Me.btn_make_order.UseVisualStyleBackColor = False
        '
        'btn_view_orders
        '
        Me.btn_view_orders.BackColor = System.Drawing.Color.Transparent
        Me.btn_view_orders.BackgroundImage = CType(resources.GetObject("btn_view_orders.BackgroundImage"), System.Drawing.Image)
        Me.btn_view_orders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_view_orders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_view_orders.ForeColor = System.Drawing.Color.Transparent
        Me.btn_view_orders.Location = New System.Drawing.Point(840, 525)
        Me.btn_view_orders.Name = "btn_view_orders"
        Me.btn_view_orders.Size = New System.Drawing.Size(85, 81)
        Me.btn_view_orders.TabIndex = 167
        Me.btn_view_orders.UseVisualStyleBackColor = False
        '
        'btn_order_record
        '
        Me.btn_order_record.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_order_record.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order_record.Location = New System.Drawing.Point(67, 546)
        Me.btn_order_record.Name = "btn_order_record"
        Me.btn_order_record.Size = New System.Drawing.Size(251, 28)
        Me.btn_order_record.TabIndex = 183
        Me.btn_order_record.Text = "ORDER RECORD"
        Me.btn_order_record.UseVisualStyleBackColor = True
        '
        'frm_orderdetails_a176607
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.btn_order_record)
        Me.Controls.Add(Me.btn_view_orders)
        Me.Controls.Add(Me.btn_make_order)
        Me.Controls.Add(Me.lbl_tagline)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.pic_home)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_orders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_orderdetails_a176607"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Details"
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_orders As DataGridView
    Friend WithEvents lbl_title As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents pic_home As PictureBox
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents lbl_tagline As Label
    Friend WithEvents btn_make_order As Button
    Friend WithEvents btn_view_orders As Button
    Friend WithEvents btn_order_record As Button
End Class
