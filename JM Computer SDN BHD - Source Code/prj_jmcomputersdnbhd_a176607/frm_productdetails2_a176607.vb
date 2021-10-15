Public Class frm_productdetails2_a176607
    Private Sub frm_productdetails2_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_category.Items.Add("(A) Desktop PC Case")
        cmb_category.Items.Add("(B) Desktop PC Power Supply")
        grd_products.DataSource = run_sql("SELECT * FROM TBL_PRODUCTS_A176607 ORDER BY FLD_PRODUCT_ID")
        grd_products.Columns(0).HeaderText = "Product_ID"
        grd_products.Columns(1).HeaderText = "Product_Name"
        grd_products.Columns(2).HeaderText = "Price ($)"
        grd_products.Columns(3).HeaderText = "Category"
        grd_products.Columns(4).HeaderText = "Brand"
        grd_products.Columns(5).HeaderText = "Series"
        grd_products.Columns(6).HeaderText = "Weight"
    End Sub
    Private Sub cmb_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_category.SelectedIndexChanged
        grd_products.DataSource = run_sql("SELECT * FROM TBL_PRODUCTS_A176607 WHERE FLD_CATEGORY = '" & cmb_category.Text & "' ORDER BY FLD_PRODUCT_ID")
    End Sub
    Private Sub grd_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellClick
        cmb_category.Text = grd_products(3, grd_products.CurrentRow.Index).Value
    End Sub
    Private Sub btn_insert_product_Click(sender As Object, e As EventArgs) Handles btn_insert_product.Click
        frm_insertproduct_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_edit_product_Click(sender As Object, e As EventArgs) Handles btn_edit_product.Click
        frm_updateproduct_a176607.Show()
        Me.Close()
    End Sub
    Private Sub pic_home_Click(sender As Object, e As EventArgs) Handles pic_home.Click
        frm_mainmenu_a176607.Show()
        Me.Close()
    End Sub
End Class