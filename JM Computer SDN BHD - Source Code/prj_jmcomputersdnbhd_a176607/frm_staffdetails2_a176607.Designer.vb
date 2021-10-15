<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffdetails2_a176607
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_staffdetails2_a176607))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_staffs = New System.Windows.Forms.DataGridView()
        Me.pic_back = New System.Windows.Forms.PictureBox()
        Me.lbl_tagline = New System.Windows.Forms.Label()
        Me.btn_insert_staff = New System.Windows.Forms.Button()
        Me.btn_edit_staff = New System.Windows.Forms.Button()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_staffs, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_title.Location = New System.Drawing.Point(207, 29)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(582, 50)
        Me.lbl_title.TabIndex = 10
        Me.lbl_title.Text = "STAFF DETAILS TABLE"
        '
        'grd_staffs
        '
        Me.grd_staffs.AllowUserToAddRows = False
        Me.grd_staffs.AllowUserToDeleteRows = False
        Me.grd_staffs.AllowUserToResizeColumns = False
        Me.grd_staffs.AllowUserToResizeRows = False
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
        Me.grd_staffs.Location = New System.Drawing.Point(92, 117)
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
        Me.grd_staffs.Size = New System.Drawing.Size(810, 380)
        Me.grd_staffs.TabIndex = 11
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
        Me.pic_back.TabIndex = 13
        Me.pic_back.TabStop = False
        '
        'lbl_tagline
        '
        Me.lbl_tagline.AutoSize = True
        Me.lbl_tagline.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tagline.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagline.Location = New System.Drawing.Point(302, 666)
        Me.lbl_tagline.Name = "lbl_tagline"
        Me.lbl_tagline.Size = New System.Drawing.Size(315, 28)
        Me.lbl_tagline.TabIndex = 14
        Me.lbl_tagline.Text = "Affordable Excellence of Tech"
        '
        'btn_insert_staff
        '
        Me.btn_insert_staff.BackColor = System.Drawing.Color.Transparent
        Me.btn_insert_staff.BackgroundImage = CType(resources.GetObject("btn_insert_staff.BackgroundImage"), System.Drawing.Image)
        Me.btn_insert_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_insert_staff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insert_staff.ForeColor = System.Drawing.Color.Transparent
        Me.btn_insert_staff.Location = New System.Drawing.Point(68, 524)
        Me.btn_insert_staff.Name = "btn_insert_staff"
        Me.btn_insert_staff.Size = New System.Drawing.Size(85, 81)
        Me.btn_insert_staff.TabIndex = 21
        Me.btn_insert_staff.UseVisualStyleBackColor = False
        '
        'btn_edit_staff
        '
        Me.btn_edit_staff.BackColor = System.Drawing.Color.Transparent
        Me.btn_edit_staff.BackgroundImage = CType(resources.GetObject("btn_edit_staff.BackgroundImage"), System.Drawing.Image)
        Me.btn_edit_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_edit_staff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit_staff.ForeColor = System.Drawing.Color.Transparent
        Me.btn_edit_staff.Location = New System.Drawing.Point(840, 525)
        Me.btn_edit_staff.Name = "btn_edit_staff"
        Me.btn_edit_staff.Size = New System.Drawing.Size(85, 80)
        Me.btn_edit_staff.TabIndex = 20
        Me.btn_edit_staff.UseVisualStyleBackColor = False
        '
        'frm_staffdetails2_a176607
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 703)
        Me.Controls.Add(Me.btn_insert_staff)
        Me.Controls.Add(Me.btn_edit_staff)
        Me.Controls.Add(Me.lbl_tagline)
        Me.Controls.Add(Me.pic_back)
        Me.Controls.Add(Me.grd_staffs)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_staffdetails2_a176607"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Details Table"
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_staffs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_staffs As DataGridView
    Friend WithEvents pic_back As PictureBox
    Friend WithEvents lbl_tagline As Label
    Friend WithEvents btn_insert_staff As Button
    Friend WithEvents btn_edit_staff As Button
End Class
