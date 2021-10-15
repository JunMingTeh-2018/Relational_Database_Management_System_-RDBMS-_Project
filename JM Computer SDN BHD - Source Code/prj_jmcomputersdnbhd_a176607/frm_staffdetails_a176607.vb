Public Class frm_staffdetails_a176607
    Private Sub frm_staffdetails_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_staff_id.DataSource = run_sql("SELECT FLD_STAFF_ID FROM TBL_STAFFS_A176607 ORDER BY FLD_STAFF_ID")
        lst_staff_id.DisplayMember = "FLD_STAFF_ID"
        refresh_text()
    End Sub
    Private Sub refresh_text()
        Dim mydatatable = run_sql("SELECT * FROM TBL_STAFFS_A176607")
        txt_staff_id.Text = mydatatable.Rows(lst_staff_id.SelectedIndex).Item("FLD_STAFF_ID")
        txt_name.Text = mydatatable.Rows(lst_staff_id.SelectedIndex).Item("FLD_NAME")
        txt_phone_number.Text = mydatatable.Rows(lst_staff_id.SelectedIndex).Item("FLD_PHONE_NUMBER")
        txt_email.Text = mydatatable.Rows(lst_staff_id.SelectedIndex).Item("FLD_EMAIL")
        pic_staff.BackgroundImage = Image.FromFile("pictures/staffs/" & txt_staff_id.Text & ".jpg")
    End Sub
    Private Sub lst_staff_id_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_staff_id.MouseClick
        refresh_text()
    End Sub
    Private Sub lbl_staff_table_Click(sender As Object, e As EventArgs) Handles lbl_staff_table.Click
        frm_staffdetails2_a176607.Show()
        Me.Close()
    End Sub
    Private Sub pic_home_Click(sender As Object, e As EventArgs) Handles pic_home.Click
        frm_mainmenu_a176607.Show()
        Me.Close()
    End Sub
End Class