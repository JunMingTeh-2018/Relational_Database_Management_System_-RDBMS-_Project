Public Class frm_splashscreen_a176607
    Private Sub tmr_title_Tick(sender As Object, e As EventArgs) Handles tmr_title.Tick
        If lbl_title.ForeColor = Color.Yellow Then
            lbl_title.ForeColor = Color.SpringGreen
        Else
            If lbl_title.ForeColor = Color.SpringGreen Then
                lbl_title.ForeColor = Color.Yellow
            End If
        End If
    End Sub
    Private Sub pic_login_Click(sender As Object, e As EventArgs) Handles pic_login.Click
        frm_mainmenu_a176607.Show()
        Me.Hide()
    End Sub
End Class