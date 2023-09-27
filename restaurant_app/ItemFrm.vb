Public Class ItemFrm
    Private Sub ItemFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestaurantDataSet.category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.RestaurantDataSet.category)
        'TODO: This line of code loads data into the 'RestaurantDataSet.items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.RestaurantDataSet.items)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddItemBtn.Click
        Me.ItemsTableAdapter.Update(Me.RestaurantDataSet.items)
    End Sub
End Class