Public Class CatForm
    Private Sub CatForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestaurantDataSet.category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.RestaurantDataSet.category)

    End Sub

    Private Sub AddCatBtn_Click(sender As Object, e As EventArgs) Handles AddCatBtn.Click
        Me.CategoryTableAdapter.Update(Me.RestaurantDataSet.category)
    End Sub
End Class