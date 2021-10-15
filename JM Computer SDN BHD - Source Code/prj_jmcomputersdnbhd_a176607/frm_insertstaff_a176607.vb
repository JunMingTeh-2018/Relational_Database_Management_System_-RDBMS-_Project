Public Class frm_insertstaff_a176607
    Private Sub frm_insertstaff_a176607_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_staffs.DataSource = run_sql("SELECT * FROM TBL_STAFFS_A176607 ORDER BY FLD_STAFF_ID")
        grd_staffs.Columns(0).HeaderText = "Staff_ID"
        grd_staffs.Columns(1).HeaderText = "Name"
        grd_staffs.Columns(2).HeaderText = "Phone_Number"
        grd_staffs.Columns(3).HeaderText = "Email"
        clear_fields()
    End Sub
    Private Sub clear_fields()
        txt_staff_id.Text = generate_staff_id()
        txt_name.Text = ""
        txt_phone_number.Text = ""
        txt_email.Text = ""
        pic_staff.BackgroundImage = Image.FromFile(defaultphoto)
        txt_photo.Text = defaultphoto
    End Sub
    Private Function generate_staff_id() As String
        Dim last_staff_id As String = run_sql("SELECT MAX(FLD_STAFF_ID) AS LAST_STAFF_ID FROM TBL_STAFFS_A176607").Rows(0).Item("LAST_STAFF_ID")
        Dim new_staff_id As String = "S" & Mid(last_staff_id, 2) + 1
        Return new_staff_id
    End Function
    Private Sub btn_photo_Click(sender As Object, e As EventArgs) Handles btn_photo.Click
        Try
            Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
            OpenFileDialog.InitialDirectory = mydesktop
            OpenFileDialog.FileName = ""
            OpenFileDialog.Filter = "JPG files (*.jpg)|*.jpg"
            OpenFileDialog.ShowDialog()
            pic_staff.BackgroundImage = Image.FromFile(OpenFileDialog.FileName)
            txt_photo.Text = OpenFileDialog.FileName
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_clearphoto_Click(sender As Object, e As EventArgs) Handles btn_clearphoto.Click
        pic_staff.BackgroundImage = Image.FromFile(defaultphoto)
        txt_photo.Text = defaultphoto
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_name.Text Is "" Then
            Beep()
            button = MsgBoxStyle.YesNo
            result = MessageBox.Show("Are you sure you would like to add a new staff without the name ?", "Add Staff ?", button)
            btn_add_function()
        Else
            Beep()
            button = MsgBoxStyle.YesNo
            result = MessageBox.Show("Are you sure you would like to add a new staff ?", "Add Staff ?", button)
            btn_add_function()
        End If
    End Sub
    Private Sub btn_add_function()
        If result = MsgBoxResult.Yes Then
            Dim thissql As String = "INSERT INTO TBL_STAFFS_A176607 VALUES ('" & txt_staff_id.Text & "', '" & txt_name.Text & "', '" & txt_phone_number.Text & "', '" & txt_email.Text & "')"
            Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection2)
            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()
                My.Computer.FileSystem.CopyFile(txt_photo.Text, "pictures\staffs\" & txt_staff_id.Text & ".jpg")
                Beep()
                button = MsgBoxStyle.OkOnly
                result = MessageBox.Show("You have successfully added a new staff.", "Staff Added", button)
                grd_staffs.DataSource = run_sql("SELECT * FROM TBL_STAFFS_A176607 ORDER BY FLD_STAFF_ID")
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
            frm_staffdetails_a176607.Show()
            Me.Close()
        End If
    End Sub
    Private Sub pic_back_function()
        Beep()
        button = MsgBoxStyle.YesNo
        result = MessageBox.Show("Are you sure you would like to leave ? The staff that has not be added will not be saved !", "Are you leaving ?", button)
        If result = MsgBoxResult.Yes Then
            frm_staffdetails_a176607.Show()
            Me.Close()
        End If
    End Sub
End Class