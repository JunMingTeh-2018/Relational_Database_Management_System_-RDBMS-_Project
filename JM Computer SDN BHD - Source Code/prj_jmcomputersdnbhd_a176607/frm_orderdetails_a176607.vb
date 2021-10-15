Public Class frm_orderdetails_a176607
    Private Sub frm_orderdetails_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_orders.DataSource = run_sql("SELECT * FROM TBL_ORDER_A176607 ORDER BY FLD_ORDER_NUMBER")
        grd_orders.Columns(0).HeaderText = "Order Number"
        grd_orders.Columns(1).HeaderText = "Product ID"
        grd_orders.Columns(2).HeaderText = "Product Quantity"
    End Sub
    Private Sub txt_search_Click(sender As Object, e As EventArgs) Handles txt_search.Click
        txt_search.Clear()
    End Sub
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        grd_orders.DataSource = run_sql("SELECT * FROM TBL_ORDER_A176607 WHERE FLD_ORDER_NUMBER LIKE '%" & txt_search.Text & "%'")
    End Sub
    Private Sub btn_order_record_Click(sender As Object, e As EventArgs) Handles btn_order_record.Click
        frm_orderrecords_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_make_order_Click(sender As Object, e As EventArgs) Handles btn_make_order.Click
        frm_makeorder_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_view_orders_Click(sender As Object, e As EventArgs) Handles btn_view_orders.Click
        frm_vieworders_a176607.Show()
        Me.Close()
    End Sub
    Private Sub pic_home_Click(sender As Object, e As EventArgs) Handles pic_home.Click
        frm_mainmenu_a176607.Show()
        Me.Close()
    End Sub
End Class