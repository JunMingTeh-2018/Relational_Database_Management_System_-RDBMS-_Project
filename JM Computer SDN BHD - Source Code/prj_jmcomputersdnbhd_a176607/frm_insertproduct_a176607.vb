Public Class frm_insertproduct_a176607
    Private Sub frm_insertproduct_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_products.DataSource = run_sql("SELECT * FROM TBL_PRODUCTS_A176607 ORDER BY FLD_PRODUCT_ID")
        grd_products.Columns(0).HeaderText = "Product_ID"
        grd_products.Columns(1).HeaderText = "Product_Name"
        grd_products.Columns(2).HeaderText = "Price ($)"
        grd_products.Columns(3).HeaderText = "Category"
        grd_products.Columns(4).HeaderText = "Brand"
        grd_products.Columns(5).HeaderText = "Series"
        grd_products.Columns(6).HeaderText = "Weight"
        cmb_category.Items.Add("(A) Desktop PC Case")
        cmb_category.Items.Add("(B) Desktop PC Power Supply")
        clear_fields()
    End Sub
    Private Sub clear_fields()
        cmb_category.Text = "Click here to choose the product category that you want to add"
        txt_product_id.Text = ""
        txt_product_name.Text = ""
        txt_price.Text = "0"
        txt_brand.Text = ""
        txt_series.Text = ""
        txt_weight.Text = ""
        pic_product.BackgroundImage = Image.FromFile(defaultphoto)
        txt_photo.Text = defaultphoto
    End Sub
    Private Sub cmb_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_category.SelectedIndexChanged
        txt_product_id.Text = generate_product_id()
    End Sub
    Private Function generate_product_id() As String
        Dim last_product_id As String
        Dim new_product_id As String
        If cmb_category.SelectedItem Is "(A) Desktop PC Case" Then
            last_product_id = run_sql("SELECT MAX(FLD_PRODUCT_ID) AS LAST_PRODUCT_ID FROM TBL_PRODUCTS_A176607 WHERE FLD_PRODUCT_ID LIKE 'PA%'").Rows(0).Item("LAST_PRODUCT_ID")
            new_product_id = "PA" & Mid(last_product_id, 3) + 1
        Else
            last_product_id = run_sql("SELECT MAX(FLD_PRODUCT_ID) AS LAST_PRODUCT_ID FROM TBL_PRODUCTS_A176607 WHERE FLD_PRODUCT_ID LIKE 'PB%'").Rows(0).Item("LAST_PRODUCT_ID")
            new_product_id = "PB" & Mid(last_product_id, 3) + 1
        End If
        Return new_product_id
    End Function
    Private Sub btn_photo_Click(sender As Object, e As EventArgs) Handles btn_photo.Click
        Try
            Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
            OpenFileDialog.InitialDirectory = mydesktop
            OpenFileDialog.FileName = ""
            OpenFileDialog.Filter = "JPG files (*.jpg)|*.jpg"
            OpenFileDialog.ShowDialog()
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog.FileName)
            txt_photo.Text = OpenFileDialog.FileName
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_clearphoto_Click(sender As Object, e As EventArgs) Handles btn_clearphoto.Click
        pic_product.BackgroundImage = Image.FromFile(defaultphoto)
        txt_photo.Text = defaultphoto
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_product_id.Text IsNot "" Then
            If txt_product_name.Text Is "" Then
                Beep()
                button = MsgBoxStyle.YesNo
                result = MessageBox.Show("Are you sure you would like to add a new product without the product name ?", "Add Product ?", button)
                btn_add_function()
            ElseIf txt_price.Text = "0" Then
                Beep()
                button = MsgBoxStyle.YesNo
                result = MessageBox.Show("Are you sure you would like to add a new product with its price is $0 ?", "Add Product ?", button)
                btn_add_function()
            Else
                Beep()
                button = MsgBoxStyle.YesNo
                result = MessageBox.Show("Are you sure you would like to add a new product ?", "Add Product ?", button)
                btn_add_function()
            End If
        Else
            Beep()
            button = MsgBoxStyle.OkOnly
            result = MessageBox.Show("Please choose a product category before adding a new product.", "Add Product Failed", button)
        End If
    End Sub
    Private Sub btn_add_function()
        If result = MsgBoxResult.Yes Then
            Dim thissql As String = "INSERT INTO TBL_PRODUCTS_A176607 VALUES ('" & txt_product_id.Text & "', '" & txt_product_name.Text & "', " & txt_price.Text & ", '" & cmb_category.Text & "', '" & txt_brand.Text & "', '" & txt_series.Text & "', '" & txt_weight.Text & "')"
            Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection2)
            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()
                My.Computer.FileSystem.CopyFile(txt_photo.Text, "pictures\products\" & txt_product_id.Text & ".jpg")
                Beep()
                button = MsgBoxStyle.OkOnly
                result = MessageBox.Show("You have successfully added a new product.", "Product Added", button)
                grd_products.DataSource = run_sql("SELECT * FROM TBL_PRODUCTS_A176607 ORDER BY FLD_PRODUCT_ID")
                clear_fields()
            Catch ex As Exception
                Beep()
                button = MsgBoxStyle.OkOnly
                result = MessageBox.Show("There is an error found, as shown below :" & vbCrLf & vbCrLf & ex.Message, "Error Detected !", button)
                mywriter.Connection.Close()
            End Try
        End If
    End Sub
    Private Sub pic_back_Click(sender As Object, e As EventArgs) Handles pic_back.Click
        If txt_product_id.Text IsNot "" Then
            pic_back_function()
        ElseIf txt_product_name.Text IsNot "" Then
            pic_back_function()
        ElseIf txt_price.Text <> "0" Then
            pic_back_function()
        ElseIf txt_brand.Text IsNot "" Then
            pic_back_function()
        ElseIf txt_series.Text IsNot "" Then
            pic_back_function()
        ElseIf txt_weight.Text IsNot "" Then
            pic_back_function()
        Else
            frm_productdetails2_a176607.Show()
            Me.Close()
        End If
    End Sub
    Private Sub pic_back_function()
        Beep()
        button = MsgBoxStyle.YesNo
        result = MessageBox.Show("Are you sure you would like to leave ? The product that has not be added will not be saved !", "Are you leaving ?", button)
        If result = MsgBoxResult.Yes Then
            frm_productdetails2_a176607.Show()
            Me.Close()
        End If
    End Sub
End Class