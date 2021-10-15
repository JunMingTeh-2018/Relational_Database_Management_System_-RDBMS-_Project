Public Class frm_staffdetails2_a176607
    Private Sub frm_staffdetails2_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_staffs.DataSource = run_sql("SELECT * FROM TBL_STAFFS_A176607 ORDER BY FLD_STAFF_ID")
        grd_staffs.Columns(0).HeaderText = "Staff_ID"
        grd_staffs.Columns(1).HeaderText = "Name"
        grd_staffs.Columns(2).HeaderText = "Phone_Number"
        grd_staffs.Columns(3).HeaderText = "Email"
    End Sub
    Private Sub btn_insert_staff_Click(sender As Object, e As EventArgs) Handles btn_insert_staff.Click
        frm_insertstaff_a176607.Show()
        Me.Close()
    End Sub
    Private Sub btn_edit_staff_Click(sender As Object, e As EventArgs) Handles btn_edit_staff.Click
        frm_updatestaff_a176607.Show()
        Me.Close()
    End Sub
    Private Sub pic_back_Click(sender As Object, e As EventArgs) Handles pic_back.Click
        frm_staffdetails_a176607.Show()
        Me.Close()
    End Sub
End Class