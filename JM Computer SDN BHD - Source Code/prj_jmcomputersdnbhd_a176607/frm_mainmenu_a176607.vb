Public Class frm_mainmenu_a176607
    Private Sub frm_mainmenu_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_date.Text = Date.Now
    End Sub
    Private Sub tmr_main_menu_Tick(sender As Object, e As EventArgs) Handles tmr_main_menu.Tick
        If lbl_title.ForeColor = Color.Black Then
            lbl_title.ForeColor = Color.ForestGreen
        Else
            If lbl_title.ForeColor = Color.ForestGreen Then
                lbl_title.ForeColor = Color.Black
            End If
        End If
    End Sub
    Private Sub btn_product_list_Click(sender As Object, e As EventArgs) Handles btn_product_list.Click
        frm_productdetails2_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_insert_product_Click(sender As Object, e As EventArgs) Handles btn_insert_product.Click
        frm_insertproduct_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_edit_product_Click(sender As Object, e As EventArgs) Handles btn_edit_product.Click
        frm_updateproduct_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_product_catalog_Click(sender As Object, e As EventArgs) Handles btn_product_catalog.Click
        frm_productdetails_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_staff_list_Click(sender As Object, e As EventArgs) Handles btn_staff_list.Click
        frm_staffdetails_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_insert_staff_Click(sender As Object, e As EventArgs) Handles btn_insert_staff.Click
        frm_insertstaff_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_edit_staff_Click(sender As Object, e As EventArgs) Handles btn_edit_staff.Click
        frm_updatestaff_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_customer_list_Click(sender As Object, e As EventArgs) Handles btn_customer_list.Click
        frm_customerdetails_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_insert_customer_Click(sender As Object, e As EventArgs) Handles btn_insert_customer.Click
        frm_insertcustomer_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_edit_customer_Click(sender As Object, e As EventArgs) Handles btn_edit_customer.Click
        frm_updatecustomer_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_order_details_Click_1(sender As Object, e As EventArgs) Handles btn_order_details.Click
        frm_orderdetails_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_order_record_Click_1(sender As Object, e As EventArgs) Handles btn_order_record.Click
        frm_orderrecords_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_make_order_Click_1(sender As Object, e As EventArgs) Handles btn_make_order.Click
        frm_makeorder_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_view_orders_Click(sender As Object, e As EventArgs) Handles btn_view_orders.Click
        frm_vieworders_a176607.Show()
        Me.Close()
    End Sub
    Private Sub pic_exit_Click(sender As Object, e As EventArgs) Handles pic_exit.Click
        Beep()
        button = MsgBoxStyle.YesNo
        result = MessageBox.Show("Are you sure you would like to EXIT ?", "Are you leaving ?", button)
        If result = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class