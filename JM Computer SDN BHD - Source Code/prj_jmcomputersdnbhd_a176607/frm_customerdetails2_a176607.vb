Public Class frm_customerdetails2_a176607
    Private Sub frm_customerdetails2_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_customers.DataSource = run_sql("SELECT * FROM TBL_CUSTOMERS_A176607 ORDER BY FLD_CUSTOMER_ID")
        grd_customers.Columns(0).HeaderText = "Customer_ID"
        grd_customers.Columns(1).HeaderText = "Name"
        grd_customers.Columns(2).HeaderText = "Phone_Number"
        grd_customers.Columns(3).HeaderText = "Email"
    End Sub
    Private Sub btn_insert_customer_Click(sender As Object, e As EventArgs) Handles btn_insert_customer.Click
        frm_insertcustomer_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_edit_customer_Click(sender As Object, e As EventArgs) Handles btn_edit_customer.Click
        frm_updatecustomer_a176607.Show()
        Me.Close()
    End Sub
    Private Sub pic_back_Click(sender As Object, e As EventArgs) Handles pic_back.Click
        frm_customerdetails_a176607.Show()
        Me.Close()
    End Sub
End Class