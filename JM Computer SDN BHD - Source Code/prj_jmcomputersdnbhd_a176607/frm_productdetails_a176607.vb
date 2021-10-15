Public Class frm_productdetails_a176607
    Private Sub frm_customerdetails_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_product_id.DataSource = run_sql("SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A176607 ORDER BY FLD_PRODUCT_ID")
        lst_product_id.DisplayMember = "FLD_PRODUCT_ID"
        refresh_text(lst_product_id.Text)
        cmb_category.Items.Add("(A) Desktop PC Case")
        cmb_category.Items.Add("(B) Desktop PC Power Supply")
    End Sub
    Private Sub refresh_text(product_id As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A176607 WHERE FLD_PRODUCT_ID = '" & product_id & "' ORDER BY FLD_PRODUCT_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        txt_product_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_product_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        cmb_category.Text = mydatatable.Rows(0).Item("FLD_CATEGORY")
        txt_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txt_series.Text = mydatatable.Rows(0).Item("FLD_SERIES")
        txt_weight.Text = mydatatable.Rows(0).Item("FLD_WEIGHT")
        pic_product.BackgroundImage = Image.FromFile("pictures/products/" & txt_product_id.Text & ".jpg")
    End Sub
    Private Sub lst_product_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_product_id.MouseClick
        refresh_text(lst_product_id.Text)
    End Sub
    Private Sub cmb_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_category.SelectedIndexChanged
        lst_product_id.DataSource = run_sql("SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A176607 WHERE FLD_CATEGORY = '" & cmb_category.Text & "' ORDER BY FLD_PRODUCT_ID")
        lst_product_id.DisplayMember = "FLD_PRODUCT_ID"
    End Sub
    Private Sub lbl_product_table_Click(sender As Object, e As EventArgs) Handles lbl_product_table.Click
        frm_productdetails2_a176607.Show()
        Me.Close()
    End Sub
    Private Sub pic_home_Click(sender As Object, e As EventArgs) Handles pic_home.Click
        frm_mainmenu_a176607.Show()
        Me.Close()
    End Sub
End Class