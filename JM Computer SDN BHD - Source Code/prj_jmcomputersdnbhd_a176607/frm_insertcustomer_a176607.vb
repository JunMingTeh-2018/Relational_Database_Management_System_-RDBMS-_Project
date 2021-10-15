Public Class frm_insertcustomer_a176607
    Private Sub frm_insertcustomer_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_customers.DataSource = run_sql("SELECT * FROM TBL_CUSTOMERS_A176607 ORDER BY FLD_CUSTOMER_ID")
        grd_customers.Columns(0).HeaderText = "Customer_ID"
        grd_customers.Columns(1).HeaderText = "Name"
        grd_customers.Columns(2).HeaderText = "Phone_Number"
        grd_customers.Columns(3).HeaderText = "Email"
        clear_fields()
    End Sub
    Private Sub clear_fields()
        txt_customer_id.Text = generate_customer_id()
        txt_name.Text = ""
        txt_phone_number.Text = ""
        txt_email.Text = ""
        pic_customer.BackgroundImage = Image.FromFile(defaultphoto)
        txt_photo.Text = defaultphoto
    End Sub
    Private Function generate_customer_id() As String
        Dim last_customer_id As String = run_sql("SELECT MAX(FLD_CUSTOMER_ID) AS LAST_CUSTOMER_ID FROM TBL_CUSTOMERS_A176607").Rows(0).Item("LAST_CUSTOMER_ID")
        Dim new_customer_id As String = "C" & Mid(last_customer_id, 2) + 1
        Return new_customer_id
    End Function
    Private Sub btn_photo_Click(sender As Object, e As EventArgs) Handles btn_photo.Click
        Try
            Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
            OpenFileDialog.InitialDirectory = mydesktop
            OpenFileDialog.FileName = ""
            OpenFileDialog.Filter = "JPG files (*.jpg)|*.jpg"
            OpenFileDialog.ShowDialog()
            pic_customer.BackgroundImage = Image.FromFile(OpenFileDialog.FileName)
            txt_photo.Text = OpenFileDialog.FileName
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_remove_photo_Click(sender As Object, e As EventArgs) Handles btn_remove_photo.Click
        pic_customer.BackgroundImage = Image.FromFile(defaultphoto)
        txt_photo.Text = defaultphoto
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_name.Text Is "" Then
            Beep()
            button = MsgBoxStyle.YesNo
            result = MessageBox.Show("Are you sure you would like to add a new customer without the name ?", "Add Customer ?", button)
            btn_add_function()
        Else
            Beep()
            button = MsgBoxStyle.YesNo
            result = MessageBox.Show("Are you sure you would like to add a new customer ?", "Add Customer ?", button)
            btn_add_function()
        End If
    End Sub
    Private Sub btn_add_function()
        If result = MsgBoxResult.Yes Then
            Dim thissql As String = "INSERT INTO TBL_CUSTOMERS_A176607 VALUES ('" & txt_customer_id.Text & "', '" & txt_name.Text & "', '" & txt_phone_number.Text & "', '" & txt_email.Text & "')"
            Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection2)
            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()
                My.Computer.FileSystem.CopyFile(txt_photo.Text, "pictures\customers\" & txt_customer_id.Text & ".jpg")
                Beep()
                button = MsgBoxStyle.OkOnly
                result = MessageBox.Show("You have successfully added a new customer.", "Customer Added", button)
                grd_customers.DataSource = run_sql("SELECT * FROM TBL_CUSTOMERS_A176607 ORDER BY FLD_CUSTOMER_ID")
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
        If txt_name.Text IsNot "" Then
            pic_back_function()
        ElseIf txt_phone_number.Text IsNot "" Then
            pic_back_function()
        ElseIf txt_email.Text IsNot "" Then
            pic_back_function()
        Else
            frm_customerdetails_a176607.Show()
            Me.Close()
        End If
    End Sub
    Private Sub pic_back_function()
        Beep()
        button = MsgBoxStyle.YesNo
        result = MessageBox.Show("Are you sure you would like to leave ? The customer that has not be added will not be saved !", "Are you leaving ?", button)
        If result = MsgBoxResult.Yes Then
            frm_customerdetails_a176607.Show()
            Me.Close()
        End If
    End Sub
End Class