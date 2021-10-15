Public Class frm_makeorder_a176607
    Dim mydatatable
    Dim row_index As Integer = 0
    Dim total_price As Integer = 0
    Private Sub frm_makeorder_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_customer_id.DataSource = run_sql("SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMERS_A176607 ORDER BY FLD_CUSTOMER_ID")
        cmb_customer_id.DisplayMember = "FLD_CUSTOMER_ID"
        cmb_staff_id.DataSource = run_sql("SELECT FLD_STAFF_ID FROM TBL_STAFFS_A176607 ORDER BY FLD_STAFF_ID")
        cmb_staff_id.DisplayMember = "FLD_STAFF_ID"
        cmb_product_id.DataSource = run_sql("SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A176607 ORDER BY FLD_PRODUCT_ID")
        cmb_product_id.DisplayMember = "FLD_PRODUCT_ID"
        refresh_all()
        grd_orders.ColumnCount = 4
        grd_orders.Columns(0).HeaderText = "Product Name"
        grd_orders.Columns(1).HeaderText = "Price ($)"
        grd_orders.Columns(2).HeaderText = "Quantity"
        grd_orders.Columns(3).HeaderText = "Subtotal ($)"
    End Sub
    Private Sub refresh_all()
        txt_order_number.Text = generate_order_number()
        txt_order_date.Text = Date.Today
        cmb_product_id.Text = "PA101"
        grd_orders.RowCount = 0
        grd_orders.Rows.Clear()
    End Sub
    Private Function generate_order_number() As String
        Dim last_order_number As String
        Dim new_order_number As String
        mydatatable = run_sql("SELECT FLD_ORDER_NUMBER FROM TBL_ORDER_A176607")
        If mydatatable.Rows.Count = 0 Then
            new_order_number = "O101"
        Else
            last_order_number = run_sql("SELECT MAX(FLD_ORDER_NUMBER) AS LAST_ORDER_NUMBER FROM TBL_ORDER_A176607").Rows(0).Item("LAST_ORDER_NUMBER")
            new_order_number = "O" & Mid(last_order_number, 2) + 1
        End If
        Return new_order_number
    End Function
    Private Sub refresh_subtotal_price()
        If nud_quantity.Value = 1 Then
            txt_product_subtotal_price.Text = txt_product_price.Text
        ElseIf nud_quantity.Value > 1 Then
            txt_product_subtotal_price.Text = mydatatable.Rows(cmb_product_id.SelectedIndex).Item("FLD_PRICE") * nud_quantity.Value
        ElseIf nud_quantity.Value = 0 Then
            txt_product_subtotal_price.Text = "0"
        End If
    End Sub
    Private Sub cmb_customer_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_customer_id.SelectedIndexChanged
        mydatatable = run_sql("SELECT FLD_NAME FROM TBL_CUSTOMERS_A176607 ORDER BY FLD_CUSTOMER_ID")
        txt_customer_name.Text = mydatatable.Rows(cmb_customer_id.SelectedIndex).Item(0)
    End Sub
    Private Sub cmb_staff_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_staff_id.SelectedIndexChanged
        mydatatable = run_sql("SELECT FLD_NAME FROM TBL_STAFFS_A176607 ORDER BY FLD_STAFF_ID")
        txt_staff_name.Text = mydatatable.Rows(cmb_staff_id.SelectedIndex).Item(0)
    End Sub
    Private Sub cmb_product_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_product_id.SelectedIndexChanged
        mydatatable = run_sql("SELECT * FROM TBL_PRODUCTS_A176607 ORDER BY FLD_PRODUCT_ID")
        txt_product_name.Text = mydatatable.Rows(cmb_product_id.SelectedIndex).Item("FLD_PRODUCT_NAME")
        txt_category.Text = mydatatable.Rows(cmb_product_id.SelectedIndex).Item("FLD_CATEGORY")
        txt_product_price.Text = mydatatable.Rows(cmb_product_id.SelectedIndex).Item("FLD_PRICE")
        Dim product_id = mydatatable.Rows(cmb_product_id.SelectedIndex).Item("FLD_PRODUCT_ID")
        pic_product.BackgroundImage = Image.FromFile("pictures/products/" & product_id & ".jpg")
        nud_quantity.Value = 1
        refresh_subtotal_price()
    End Sub
    Private Sub nud_quantity_ValueChanged(sender As Object, e As EventArgs) Handles nud_quantity.ValueChanged
        refresh_subtotal_price()
    End Sub
    Private Sub btn_add_product_Click(sender As Object, e As EventArgs) Handles btn_add_product.Click
        Dim count_repeat_product As Integer = 0
        Dim temp_row_index As Integer
        For i As Integer = 0 To grd_orders.Rows.Count - 1
            If txt_product_name.Text = grd_orders(0, i).Value Then
                count_repeat_product += 1
                temp_row_index = i
            End If
        Next
        If count_repeat_product > 0 Then
            grd_orders(2, temp_row_index).Value = grd_orders(2, temp_row_index).Value + nud_quantity.Value
            Dim temp_new_subtotal As Integer = grd_orders(1, temp_row_index).Value * nud_quantity.Value
            grd_orders(3, temp_row_index).Value = grd_orders(3, temp_row_index).Value + temp_new_subtotal
            total_price += temp_new_subtotal
        Else
            grd_orders.RowCount += 1
            grd_orders(0, row_index).Value = txt_product_name.Text
            grd_orders(1, row_index).Value = txt_product_price.Text
            grd_orders(2, row_index).Value = nud_quantity.Value
            grd_orders(3, row_index).Value = txt_product_price.Text * nud_quantity.Value
            total_price += grd_orders(3, row_index).Value
            row_index += 1
        End If
        txt_total_price.Text = total_price
        nud_quantity.Value = 1
    End Sub
    Private Sub btn_remove_product_Click(sender As Object, e As EventArgs) Handles btn_remove_product.Click
        If grd_orders.Rows.Count > 0 Then
            Beep()
            button = MsgBoxStyle.YesNo
            result = MessageBox.Show("Are you sure you would like to remove the product '" & grd_orders(0, grd_orders.CurrentRow.Index).Value & "' ?", "Remove Product ?", button)
            If result = MsgBoxResult.Yes Then
                total_price -= grd_orders(3, grd_orders.CurrentRow.Index).Value
                txt_total_price.Text = total_price.ToString
                grd_orders.Rows.RemoveAt(grd_orders.CurrentRow.Index)
                row_index -= 1
            End If
        Else
            Beep()
            button = MsgBoxStyle.OkOnly
            result = MessageBox.Show("There is no product to be removed.", "Remove Product Failed", button)
        End If
    End Sub
    Private Sub btn_confirm_order_Click(sender As Object, e As EventArgs) Handles btn_confirm_order.Click
        If grd_orders.Rows.Count > 0 Then
            Beep()
            button = MsgBoxStyle.YesNo
            result = MessageBox.Show("Are you sure you would like to confirm the order '" & txt_order_number.Text & "' ? There will be no any changes after confirming the order !", "Confirm Order ?", button)
            If result = MsgBoxResult.Yes Then
                Dim mytransaction As OleDb.OleDbTransaction
                myconnection2.Open()
                mytransaction = myconnection2.BeginTransaction
                Dim order_number As String = txt_order_number.Text
                Try
                    mydatatable = run_sql("SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMERS_A176607 ORDER BY FLD_CUSTOMER_ID")
                    Dim customer_id As String = mydatatable.Rows(cmb_customer_id.SelectedIndex).Item(0)
                    mydatatable = run_sql("SELECT FLD_STAFF_ID FROM TBL_STAFFS_A176607 ORDER BY FLD_STAFF_ID")
                    Dim staff_id As String = mydatatable.Rows(cmb_staff_id.SelectedIndex).Item(0)
                    Dim order_record_sql As String = "INSERT INTO TBL_ORDERRECORDS_A176607 VALUES ('" & customer_id & "', '" & order_number & "', '" & staff_id & "', '" & txt_order_date.Text & "')"
                    Dim order_record_writter As New OleDb.OleDbCommand(order_record_sql, myconnection2, mytransaction)
                    order_record_writter.ExecuteNonQuery()
                    For i As Integer = 0 To grd_orders.Rows.Count - 1
                        Dim order_datatable = run_sql("SELECT * FROM TBL_PRODUCTS_A176607 WHERE FLD_PRODUCT_NAME = '" & grd_orders(0, i).Value & "'")
                        Dim product_id As String = order_datatable.Rows(0).Item("FLD_PRODUCT_ID")
                        Dim order_sql As String = "INSERT INTO TBL_ORDER_A176607 VALUES ('" & order_number & "', '" & product_id & "', " & grd_orders(2, i).Value & ")"
                        Dim order_writter As New OleDb.OleDbCommand(order_sql, myconnection2, mytransaction)
                        order_writter.ExecuteNonQuery()
                    Next
                    mytransaction.Commit()
                    myconnection2.Close()
                    Beep()
                    button = MsgBoxStyle.OkOnly
                    result = MessageBox.Show("You have successfully confirmed the order '" & txt_order_number.Text & "'.", "Order Confirmed", button)
                    refresh_all()
                Catch ex As Exception
                    Beep()
                    button = MsgBoxStyle.OkOnly
                    result = MessageBox.Show("There is an error found, as shown below :" & vbCrLf & vbCrLf & ex.Message, "Error Detected !", button)
                    mytransaction.Rollback()
                    myconnection2.Close()
                    refresh_all()
                End Try
                row_index = 0
            End If
        Else
            Beep()
            button = MsgBoxStyle.OkOnly
            result = MessageBox.Show("There is no order to be confirmed.", "Confirm Order Failed", button)
        End If
    End Sub
    Private Sub btn_order_details_Click(sender As Object, e As EventArgs) Handles btn_order_details.Click
        If grd_orders.Rows.Count > 0 Then
            Beep()
            button = MsgBoxStyle.YesNo
            result = MessageBox.Show("Are you sure you would like to leave ? The products have not order will not be saved !", "Discard Order ?", button)
            If result = MsgBoxResult.Yes Then
                frm_orderdetails_a176607.Show()
                Me.Close()
            End If
        Else
            frm_orderdetails_a176607.Show()
            Me.Close()
        End If
    End Sub
    Private Sub btn_order_record_Click(sender As Object, e As EventArgs) Handles btn_order_record.Click
        If grd_orders.Rows.Count > 0 Then
            Beep()
            button = MsgBoxStyle.YesNo
            result = MessageBox.Show("Are you sure you would like to leave ? The products have not order will not be saved !", "Discard Order ?", button)
            If result = MsgBoxResult.Yes Then
                frm_orderrecords_a176607.Show()
                Me.Close()
            End If
        Else
            frm_orderrecords_a176607.Show()
            Me.Close()
        End If
    End Sub
    Private Sub btn_view_orders_Click(sender As Object, e As EventArgs) Handles btn_view_orders.Click
        If grd_orders.Rows.Count > 0 Then
            Beep()
            button = MsgBoxStyle.YesNo
            result = MessageBox.Show("Are you sure you would like to leave ? The products have not order will not be saved !", "Discard Order ?", button)
            If result = MsgBoxResult.Yes Then
                frm_vieworders_a176607.Show()
                Me.Close()
            End If
        Else
            frm_vieworders_a176607.Show()
            Me.Close()
        End If
    End Sub
    Private Sub pic_home_Click(sender As Object, e As EventArgs) Handles pic_home.Click
        If grd_orders.Rows.Count > 0 Then
            Beep()
            button = MsgBoxStyle.YesNo
            result = MessageBox.Show("Are you sure you would like to leave ? The products have not order will not be saved !", "Discard Order ?", button)
            If result = MsgBoxResult.Yes Then
                frm_mainmenu_a176607.Show()
                Me.Close()
            End If
        Else
            frm_mainmenu_a176607.Show()
            Me.Close()
        End If
    End Sub
End Class