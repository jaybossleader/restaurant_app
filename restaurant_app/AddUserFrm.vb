Public Class User
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestaurantDataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.RestaurantDataSet.user)

    End Sub

    Private Sub AddUserBtn_Click(sender As Object, e As EventArgs) Handles AddUserBtn.Click
        Me.UserTableAdapter.Update(Me.RestaurantDataSet.user)
    End Sub
End Class