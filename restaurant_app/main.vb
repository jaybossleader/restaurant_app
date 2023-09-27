Public Class main
    Private Sub AddUserBtn_Click(sender As Object, e As EventArgs) Handles AddUserBtn.Click
        User.Show()


    End Sub

    Private Sub AddCatBtn_Click(sender As Object, e As EventArgs) Handles AddCatBtn.Click
        CatForm.Show()

    End Sub

    Private Sub AddItemBtn_Click(sender As Object, e As EventArgs) Handles AddItemBtn.Click
        ItemFrm.Show()

    End Sub

    Private Sub AddMenuBtn_Click(sender As Object, e As EventArgs) Handles AddMenuBtn.Click
        AddMenu.Show()

    End Sub

    Private Sub RepBtn_Click(sender As Object, e As EventArgs) Handles RepBtn.Click
        reports.Show()
    End Sub
End Class