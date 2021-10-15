Public Class frm_updateproduct_a176607
    Private Sub frm_updateproduct_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_category.Items.Add("(A) Desktop PC Case")
        cmb_category.Items.Add("(B) Desktop PC Power Supply")
        refresh_grid()
    End Sub
    Private Sub refresh_grid()
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
        Try
            current_row = grd_products.CurrentRow.Index
            current_code = grd_products(0, current_row).Value
            txt_product_id.Text = current_code
            txt_product_name.Text = grd_products(1, current_row).Value
            txt_price.Text = grd_products(2, current_row).Value
            cmb_category.Text = grd_products(3, current_row).Value
            txt_brand.Text = grd_products(4, current_row).Value
            txt_series.Text = grd_products(5, current_row).Value
            txt_weight.Text = grd_products(6, current_row).Value
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txt_product_id.Text IsNot "" Then
            Try
                If txt_product_name.Text <> grd_products(1, current_row).Value Then
                    btn_update_function()
                ElseIf txt_price.Text <> grd_products(2, current_row).Value Then
                    btn_update_function()
                ElseIf txt_brand.Text <> grd_products(4, current_row).Value Then
                    btn_update_function()
                ElseIf txt_series.Text <> grd_products(5, current_row).Value Then
                    btn_update_function()
                ElseIf txt_weight.Text <> grd_products(6, current_row).Value Then
                    btn_update_function()
                Else
                    Beep()
                    button = MsgBoxStyle.OkOnly
                    result = MessageBox.Show("Please at least edit a product's detail to update the product's detail", "Update Product Details Failed", button)
                End If
            Catch ex As Exception
            End Try
        Else
            Beep()
            button = MsgBoxStyle.OkOnly
            result = MessageBox.Show("Please select a product to be updated.", "Update Product Details Failed", button)
        End If
    End Sub
    Private Sub btn_update_function()
        Beep()
        button = MsgBoxStyle.YesNo
        result = MessageBox.Show("Are you sure you would like to update the product '" & current_code & "''s details ?", "Update Product Details ?", button)
        If result = MsgBoxResult.Yes Then
            Dim thissql As String = "UPDATE TBL_PRODUCTS_A176607 SET FLD_PRODUCT_NAME = '" & txt_product_name.Text & "', FLD_PRICE = '" & txt_price.Text & "', FLD_CATEGORY = '" & cmb_category.Text & "', FLD_BRAND = '" & txt_brand.Text & "', FLD_SERIES = '" & txt_series.Text & "', FLD_WEIGHT = '" & txt_weight.Text & "' WHERE FLD_PRODUCT_ID = '" & current_code & "'"
            Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection2)
            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()
                Beep()
                button = MsgBoxStyle.OkOnly
                Dim result = MessageBox.Show("You have successfully updated the product '" & current_code & "' details.", "Product Details Updated", button)
                refresh_grid()
                clear_fields()
            Catch ex As Exception
                Beep()
                button = MsgBoxStyle.OkOnly
                result = MessageBox.Show("There is an error found, as shown below :" & vbCrLf & vbCrLf & ex.Message, "Error Detected !", button)
                mywriter.Connection.Close()
            End Try
        End If
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If txt_product_id.Text IsNot "" Then
            Beep()
            button = MsgBoxStyle.YesNo
            Dim result = MessageBox.Show("Are you sure you would like to delete the product '" & current_code & "' ?", "Delete Product ?", button)
            If result = MsgBoxResult.Yes Then
                run_sql_command("DELETE FROM TBL_PRODUCTS_A176607 WHERE FLD_PRODUCT_ID = '" & current_code & "'")
                My.Computer.FileSystem.DeleteFile("pictures\products\" & current_code & ".jpg")
                Beep()
                button = MsgBoxStyle.OkOnly
                result = MessageBox.Show("You have successfully deleted the product '" & current_code & "'.", "Product Deleted", button)
                refresh_grid()
                clear_fields()
            End If
        Else
            Beep()
            button = MsgBoxStyle.OkOnly
            result = MessageBox.Show("Please select a product to be deleted.", "Delete Product Failed", button)
        End If
    End Sub
    Private Sub clear_fields()
        cmb_category.Text = "Click here to choose category"
        txt_product_id.Text = ""
        txt_product_name.Text = ""
        txt_price.Text = ""
        txt_brand.Text = ""
        txt_series.Text = ""
        txt_weight.Text = ""
    End Sub
    Private Sub pic_back_Click(sender As Object, e As EventArgs) Handles pic_back.Click
        If txt_product_id.Text IsNot "" Then
            Try
                If txt_product_name.Text <> grd_products(1, current_row).Value Then
                    pic_back_function()
                ElseIf txt_price.Text <> grd_products(2, current_row).Value Then
                    pic_back_function()
                ElseIf txt_brand.Text <> grd_products(4, current_row).Value Then
                    pic_back_function()
                ElseIf txt_series.Text <> grd_products(5, current_row).Value Then
                    pic_back_function()
                ElseIf txt_weight.Text <> grd_products(6, current_row).Value Then
                    pic_back_function()
                Else
                    frm_productdetails2_a176607.Show()
                    Me.Close()
                End If
            Catch ex As Exception
                frm_productdetails2_a176607.Show()
                Me.Close()
            End Try
        Else
            frm_productdetails2_a176607.Show()
            Me.Close()
        End If
    End Sub
    Private Sub pic_back_function()
        Beep()
        button = MsgBoxStyle.YesNo
        result = MessageBox.Show("Are you sure you would like to leave ? The edition of product's details that have not be updated will not be saved !", "Are you leaving ?", button)
        If result = MsgBoxResult.Yes Then
            frm_productdetails2_a176607.Show()
            Me.Close()
        End If
    End Sub
End Class