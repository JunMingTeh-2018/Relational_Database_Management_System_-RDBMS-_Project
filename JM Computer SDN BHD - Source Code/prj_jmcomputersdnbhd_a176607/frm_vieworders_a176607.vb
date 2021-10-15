Public Class frm_vieworders_a176607
    Private Sub frm_vieworders_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_order_number.DataSource = run_sql("SELECT FLD_ORDER_NUMBER FROM TBL_ORDERRECORDS_A176607 ORDER BY FLD_ORDER_NUMBER")
        cmb_order_number.DisplayMember = "FLD_ORDER_NUMBER"
        refresh_all()
    End Sub
    Private Sub refresh_all()
        Dim mydatatable = run_sql("SELECT * FROM TBL_ORDERRECORDS_A176607 ORDER BY FLD_ORDER_NUMBER")
        Dim customer_datatable = run_sql("SELECT * FROM TBL_CUSTOMERS_A176607 WHERE FLD_CUSTOMER_ID = '" & mydatatable.Rows(cmb_order_number.SelectedIndex).Item("FLD_CUSTOMER_ID") & "'")
        txt_customer_name.Text = customer_datatable.Rows(0).Item("FLD_NAME")
        txt_order_date.Text = mydatatable.Rows(cmb_order_number.SelectedIndex).Item("FLD_ORDER_DATE")
        Dim staff_datatable = run_sql("SELECT * FROM TBL_STAFFS_A176607 WHERE FLD_STAFF_ID = '" & mydatatable.Rows(cmb_order_number.SelectedIndex).Item("FLD_STAFF_ID") & "'")
        txt_staff_name.Text = staff_datatable.Rows(0).Item("FLD_NAME")
        Dim product_datatable = run_sql("SELECT FLD_PRODUCT_NAME, FLD_PRICE, FLD_PRODUCT_QUANTITY, FLD_PRICE * FLD_PRODUCT_QUANTITY FROM TBL_PRODUCTS_A176607, TBL_ORDER_A176607 WHERE FLD_ORDER_NUMBER = '" & cmb_order_number.Text & "' AND TBL_PRODUCTS_A176607.FLD_PRODUCT_ID = TBL_ORDER_A176607.FLD_PRODUCT_ID")
        grd_orders.DataSource = product_datatable
        grd_orders.Columns(0).HeaderText = "Product Name"
        grd_orders.Columns(1).HeaderText = "Price ($)"
        grd_orders.Columns(2).HeaderText = "Quantity"
        grd_orders.Columns(3).HeaderText = "Subtotal ($)"
        Dim total_price As Integer = 0
        For i As Integer = 0 To grd_orders.Rows.Count - 1
            total_price += grd_orders(3, i).Value
        Next
        txt_total_price.Text = total_price
    End Sub
    Private Sub cmb_order_number_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_order_number.SelectedIndexChanged
        refresh_all()
    End Sub
    Private Sub btn_order_details_Click(sender As Object, e As EventArgs) Handles btn_order_details.Click
        frm_orderdetails_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_order_record_Click(sender As Object, e As EventArgs) Handles btn_order_record.Click
        frm_orderrecords_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_make_order_Click(sender As Object, e As EventArgs) Handles btn_make_order.Click
        frm_makeorder_a176607.Show()
        Me.Close()
    End Sub
    Private Sub pic_home_Click(sender As Object, e As EventArgs) Handles pic_home.Click
        frm_mainmenu_a176607.Show()
        Me.Close()
    End Sub
End Class