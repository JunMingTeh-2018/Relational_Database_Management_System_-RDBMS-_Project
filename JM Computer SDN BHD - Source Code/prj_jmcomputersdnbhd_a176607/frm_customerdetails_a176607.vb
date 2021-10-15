Public Class frm_customerdetails_a176607
    Private Sub frm_customerdetails_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_customer_id.DataSource = run_sql("SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMERS_A176607 ORDER BY FLD_CUSTOMER_ID")
        lst_customer_id.DisplayMember = "FLD_CUSTOMER_ID"
        refresh_text()
    End Sub
    Private Sub refresh_text()
        Dim mydatatable = run_sql("SELECT * FROM TBL_CUSTOMERS_A176607")
        txt_customer_id.Text = mydatatable.Rows(lst_customer_id.SelectedIndex).Item("FLD_CUSTOMER_ID")
        txt_name.Text = mydatatable.Rows(lst_customer_id.SelectedIndex).Item("FLD_NAME")
        txt_phone_number.Text = mydatatable.Rows(lst_customer_id.SelectedIndex).Item("FLD_PHONE_NUMBER")
        txt_email.Text = mydatatable.Rows(lst_customer_id.SelectedIndex).Item("FLD_EMAIL")
        pic_customer.BackgroundImage = Image.FromFile("pictures/customers/" & txt_customer_id.Text & ".jpg")
    End Sub
    Private Sub lst_customer_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_customer_id.MouseClick
        refresh_text()
    End Sub
    Private Sub lbl_customer_table_Click(sender As Object, e As EventArgs) Handles lbl_customer_table.Click
        frm_customerdetails2_a176607.Show()
        Me.Close()
    End Sub
    Private Sub pic_home_Click(sender As Object, e As EventArgs) Handles pic_home.Click
        frm_mainmenu_a176607.Show()
        Me.Close()
    End Sub
End Class