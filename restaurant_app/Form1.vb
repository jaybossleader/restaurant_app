Public Class login_form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        If usernameTB.Text.Equals("admin") And passwordTB.Text.Equals("admin") Then
            Me.Hide()
            main.Show()

        End If
    End Sub
End Class
