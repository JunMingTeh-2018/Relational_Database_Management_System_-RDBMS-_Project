Module mod_globals_a176607
    Public myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_JMCOMPUTERSDNBHD_A176607.accdb;Persist Security Info=False;"
    Public myconnection2 As New OleDb.OleDbConnection(myconnection)
    Public defaultphoto As String = Application.StartupPath & "\pictures\Default Photo.jpg"
    Public current_code, message, title As String
    Public current_row As Integer
    Public button As MessageBoxButtons
    Public result
    Public Function run_sql(mysql As String) As DataTable
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        Try
            myreader.Fill(mydatatable)
        Catch ex As Exception
            Beep()
            button = MsgBoxStyle.OkOnly
            result = MessageBox.Show("There is an error found, as shown below :" & vbCrLf & vbCrLf & ex.Message, "Error Detected !", button)
        End Try
        Return mydatatable
    End Function
    Public Sub run_sql_command(thissql As String)
        Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
        Catch ex As Exception
            Beep()
            button = MsgBoxStyle.OkOnly
            result = MessageBox.Show("There is an error found, as shown below :" & vbCrLf & vbCrLf & ex.Message, "Error Detected !", button)
            mywriter.Connection.Close()
        End Try
    End Sub
End Module
