Public Class frm_updatestaff_a176607
    Private Sub frm_updatestaff_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
    End Sub
    Private Sub refresh_grid()
        grd_staffs.DataSource = run_sql("SELECT * FROM TBL_STAFFS_A176607 ORDER BY FLD_STAFF_ID")
        grd_staffs.Columns(0).HeaderText = "Staff_ID"
        grd_staffs.Columns(1).HeaderText = "Name"
        grd_staffs.Columns(2).HeaderText = "Phone_Number"
        grd_staffs.Columns(3).HeaderText = "Email"
    End Sub
    Private Sub grd_staffs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staffs.CellClick
        Try
            current_row = grd_staffs.CurrentRow.Index
            current_code = grd_staffs(0, current_row).Value
            txt_staff_id.Text = current_code
            txt_name.Text = grd_staffs(1, current_row).Value
            txt_phone_number.Text = grd_staffs(2, current_row).Value
            txt_email.Text = grd_staffs(3, current_row).Value
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txt_staff_id.Text IsNot "" Then
            If txt_name.Text <> grd_staffs(1, current_row).Value Then
                btn_update_function()
            ElseIf txt_phone_number.Text <> grd_staffs(2, current_row).Value Then
                btn_update_function()
            ElseIf txt_email.Text <> grd_staffs(3, current_row).Value Then
                btn_update_function()
            Else
                Beep()
                button = MsgBoxStyle.OkOnly
                result = MessageBox.Show("Please at least edit a staff's detail to update the staff's detail", "Update Staff Details Failed", button)
            End If
        Else
            Beep()
            button = MsgBoxStyle.OkOnly
            result = MessageBox.Show("Please select a staff to be updated.", "Update Staff Details Failed", button)
        End If
    End Sub
    Private Sub btn_update_function()
        Beep()
        button = MsgBoxStyle.YesNo
        result = MessageBox.Show("Are you sure you would like to update the staff '" & current_code & "''s details ?", "Update Staff Details ?", button)
        If result = MsgBoxResult.Yes Then
            Dim thissql As String = "UPDATE TBL_STAFFS_A176607 SET FLD_NAME = '" & txt_name.Text & "', FLD_PHONE_NUMBER = '" & txt_phone_number.Text & "', FLD_EMAIL = '" & txt_email.Text & "' WHERE FLD_STAFF_ID = '" & current_code & "'"
            Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection2)
            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()
                Beep()
                button = MsgBoxStyle.OkOnly
                result = MessageBox.Show("You have successfully updated the staff '" & current_code & "' details.", "Staff Details Updated", button)
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
        If txt_staff_id.Text IsNot "" Then
            Beep()
            button = MsgBoxStyle.YesNo
            result = MessageBox.Show("Are you sure you would like to delete the staff '" & current_code & "' ?", "Delete Staff ?", button)
            If result = MsgBoxResult.Yes Then
                run_sql_command("DELETE FROM TBL_STAFFS_A176607 WHERE FLD_STAFF_ID = '" & current_code & "'")
                My.Computer.FileSystem.DeleteFile("pictures\staffs\" & current_code & ".jpg")
                Beep()
                button = MsgBoxStyle.OkOnly
                result = MessageBox.Show("You have successfully deleted the staff '" & current_code & "'.", "Staff Deleted", button)
                refresh_grid()
                clear_fields()
            End If
        Else
            Beep()
            button = MsgBoxStyle.OkOnly
            result = MessageBox.Show("Please select a staff to be deleted.", "Delete Staff Failed", button)
        End If
    End Sub
    Private Sub clear_fields()
        txt_staff_id.Text = ""
        txt_name.Text = ""
        txt_phone_number.Text = ""
        txt_email.Text = ""
    End Sub
    Private Sub pic_back_Click(sender As Object, e As EventArgs) Handles pic_back.Click
        If txt_staff_id.Text IsNot "" Then
            If txt_name.Text <> grd_staffs(1, current_row).Value Then
                pic_back_function()
            ElseIf txt_phone_number.Text <> grd_staffs(2, current_row).Value Then
                pic_back_function()
            ElseIf txt_email.Text <> grd_staffs(3, current_row).Value Then
                pic_back_function()
            Else
                frm_staffdetails_a176607.Show()
                Me.Close()
            End If
        Else
            frm_staffdetails_a176607.Show()
            Me.Close()
        End If
    End Sub
    Private Sub pic_back_function()
        Beep()
        button = MsgBoxStyle.YesNo
        result = MessageBox.Show("Are you sure you would like to leave ? The edition of customer's details that have not be updated will not be saved !", "Are you leaving ?", button)
        If result = MsgBoxResult.Yes Then
            frm_staffdetails_a176607.Show()
            Me.Close()
        End If
    End Sub
End Class