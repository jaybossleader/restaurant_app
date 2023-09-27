Public Class AddMenu
    Private dtTableGrd As DataTable
    Private Sub AddMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestaurantDataSet.View_1' table. You can move, or remove it, as needed.
        Me.View_1TableAdapter.Fill(Me.RestaurantDataSet.View_1)
        'TODO: This line of code loads data into the 'RestaurantDataSet.items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.RestaurantDataSet.items)
        'TODO: This line of code loads data into the 'RestaurantDataSet.menu_share' table. You can move, or remove it, as needed.
        Me.Menu_shareTableAdapter.Fill(Me.RestaurantDataSet.menu_share)
        'TODO: This line of code loads data into the 'RestaurantDataSet.menu' table. You can move, or remove it, as needed.
        Me.MenuTableAdapter.Fill(Me.RestaurantDataSet.menu)


    End Sub

    Private Sub AddMenuBtn_Click(sender As Object, e As EventArgs) Handles AddMenuBtn.Click
        Me.MenuTableAdapter.Update(Me.RestaurantDataSet.menu)
    End Sub

    Private Sub AddItemsToMenuBtn_Click(sender As Object, e As EventArgs) Handles AddItemsToMenuBtn.Click
        DataGridView1.Visible = False
        AddMenuBtn.Visible = False
        AddItemsToMenuBtn.Visible = False
        DataGridView2.Visible = True
        AddBtn.Visible = True
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Me.Menu_shareTableAdapter.Update(Me.RestaurantDataSet.menu_share)
    End Sub

    Private Sub ShowMenuBtn_Click(sender As Object, e As EventArgs) Handles ShowMenuBtn.Click
        DataGridView3.Visible = True
        filterComboBox.Visible = True
        DataGridView1.Visible = False
        AddMenuBtn.Visible = False
        AddItemsToMenuBtn.Visible = False
        DataGridView2.Visible = False
        AddBtn.Visible = False
        filterComboBox.Text.Equals("null")
        Dim f = "menu_name= '{0}'"
        f = "null"
        View1BindingSource.Filter = f
    End Sub

    Private Sub filterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterComboBox.SelectedIndexChanged
        Dim f = "menu_name= '{0}'"
        f = String.Format(f, filterComboBox.Text)

        View1BindingSource.Filter = f
    End Sub


End Class