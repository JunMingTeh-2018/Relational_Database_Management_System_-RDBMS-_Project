<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customerdetails2_a176607
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_customerdetails2_a176607))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_customers = New System.Windows.Forms.DataGridView()
        Me.pic_back = New System.Windows.Forms.PictureBox()
        Me.lbl_tagline = New System.Windows.Forms.Label()
        Me.btn_insert_customer = New System.Windows.Forms.Button()
        Me.btn_edit_customer = New System.Windows.Forms.Button()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pic_logo.TabIndex = 9
        Me.pic_logo.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Modern No. 20", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(157, 28)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(689, 50)
        Me.lbl_title.TabIndex = 10
        Me.lbl_title.Text = "CUSTOMER DETAILS TABLE"
        '
        'grd_customers
        '
        Me.grd_customers.AllowUserToAddRows = False
        Me.grd_customers.AllowUserToDeleteRows = False
        Me.grd_customers.AllowUserToResizeColumns = False
        Me.grd_customers.AllowUserToResizeRows = False
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
        Me.grd_customers.Location = New System.Drawing.Point(92, 117)
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
        Me.grd_customers.Size = New System.Drawing.Size(810, 380)
        Me.grd_customers.TabIndex = 11
        '
        'pic_back
        '
        Me.pic_back.BackColor = System.Drawing.Color.Transparent
        Me.pic_back.BackgroundImage = CType(resources.GetObject("pic_back.BackgroundImage"), System.Drawing.Image)
        Me.pic_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_back.Location = New System.Drawing.Point(457, 497)
        Me.pic_back.Name = "pic_back"
        Me.pic_back.Size = New System.Drawing.Size(85, 81)
        Me.pic_back.TabIndex = 12
        Me.pic_back.TabStop = False
        '
        'lbl_tagline
        '
        Me.lbl_tagline.AutoSize = True
        Me.lbl_tagline.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tagline.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagline.Location = New System.Drawing.Point(299, 666)
        Me.lbl_tagline.Name = "lbl_tagline"
        Me.lbl_tagline.Size = New System.Drawing.Size(315, 28)
        Me.lbl_tagline.TabIndex = 13
        Me.lbl_tagline.Text = "Affordable Excellence of Tech"
        '
        'btn_insert_customer
        '
        Me.btn_insert_customer.BackColor = System.Drawing.Color.Transparent
        Me.btn_insert_customer.BackgroundImage = CType(resources.GetObject("btn_insert_customer.BackgroundImage"), System.Drawing.Image)
        Me.btn_insert_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_insert_customer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insert_customer.ForeColor = System.Drawing.Color.Transparent
        Me.btn_insert_customer.Location = New System.Drawing.Point(69, 525)
        Me.btn_insert_customer.Name = "btn_insert_customer"
        Me.btn_insert_customer.Size = New System.Drawing.Size(85, 81)
        Me.btn_insert_customer.TabIndex = 19
        Me.btn_insert_customer.UseVisualStyleBackColor = False
        '
        'btn_edit_customer
        '
        Me.btn_edit_customer.BackColor = System.Drawing.Color.Transparent
        Me.btn_edit_customer.BackgroundImage = CType(resources.GetObject("btn_edit_customer.BackgroundImage"), System.Drawing.Image)
        Me.btn_edit_customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_edit_customer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit_customer.ForeColor = System.Drawing.Color.Transparent
        Me.btn_edit_customer.Location = New System.Drawing.Point(841, 526)
        Me.btn_edit_customer.Name = "btn_edit_customer"
        Me.btn_edit_customer.Size = New System.Drawing.Size(85, 80)
        Me.btn_edit_customer.TabIndex = 18
        Me.btn_edit_customer.UseVisualStyleBackColor = False
        '
        'frm_customerdetails2_a176607
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.btn_insert_customer)
        Me.Controls.Add(Me.btn_edit_customer)
        Me.Controls.Add(Me.lbl_tagline)
        Me.Controls.Add(Me.pic_back)
        Me.Controls.Add(Me.grd_customers)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_customerdetails2_a176607"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Details Table"
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_customers As DataGridView
    Friend WithEvents pic_back As PictureBox
    Friend WithEvents lbl_tagline As Label
    Friend WithEvents btn_insert_customer As Button
    Friend WithEvents btn_edit_customer As Button
End Class
