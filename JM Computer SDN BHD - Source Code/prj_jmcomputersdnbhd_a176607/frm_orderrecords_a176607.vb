Public Class frm_orderrecords_a176607
    Private Sub frm_orderrecords_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_orderrecords.DataSource = run_sql("SELECT * FROM TBL_ORDERRECORDS_A176607 ORDER BY FLD_CUSTOMER_ID")
        grd_orderrecords.Columns(0).HeaderText = "Customer ID"
        grd_orderrecords.Columns(1).HeaderText = "Order Number"
        grd_orderrecords.Columns(2).HeaderText = "Staff ID"
        grd_orderrecords.Columns(3).HeaderText = "Order Date"
    End Sub
    Private Sub btn_order_details_Click(sender As Object, e As EventArgs) Handles btn_order_details.Click
        frm_orderdetails_a176607.Show()
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