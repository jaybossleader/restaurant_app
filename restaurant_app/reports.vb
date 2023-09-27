Imports Microsoft.Office.Interop
Public Class reports
    Private Sub reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestaurantDataSet.menu' table. You can move, or remove it, as needed.
        Me.MenuTableAdapter.Fill(Me.RestaurantDataSet.menu)
        'TODO: This line of code loads data into the 'RestaurantDataSet.category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.RestaurantDataSet.category)
        'TODO: This line of code loads data into the 'RestaurantDataSet.View_1' table. You can move, or remove it, as needed.
        Me.View_1TableAdapter.Fill(Me.RestaurantDataSet.View_1)


    End Sub

    Private Sub FilterBtn_Click(sender As Object, e As EventArgs)








    End Sub

    Private Sub CatCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CatCB.SelectedIndexChanged
        Dim f1 = "category= '{0}'"
        f1 = String.Format(f1, CatCB.Text)

        View1BindingSource.Filter = f1
    End Sub

    Private Sub MenuCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MenuCB.SelectedIndexChanged
        Dim f = "menu_name= '{0}'"
        f = String.Format(f, MenuCB.Text)

        View1BindingSource.Filter = f
    End Sub

    Private Sub NumCB_TextChanged(sender As Object, e As EventArgs) Handles NumCB.TextChanged


    End Sub

    Private Sub FilterBtn_Click_1(sender As Object, e As EventArgs) Handles FilterBtn.Click
        If FunCB.Text.Equals(">") Then
            Dim f = "price > '{0}'"
            f = String.Format(f, NumCB.Text)

            View1BindingSource.Filter = f
            Dim rowsTotal, colsTotal As Short
            Dim I, j, iC As Short
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim xlApp As New Excel.Application
            Try
                Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
                Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
                xlApp.Visible = True

                rowsTotal = DataGridView1.RowCount
                colsTotal = DataGridView1.Columns.Count - 1
                With excelWorksheet
                    .Cells.Select()
                    .Cells.Delete()
                    For iC = 0 To colsTotal
                        .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                    Next
                    For I = 0 To rowsTotal - 1
                        For j = 0 To colsTotal
                            .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                        Next j
                    Next I
                    .Rows("1:1").Font.FontStyle = "Bold"
                    .Rows("1:1").Font.Size = 12

                    .Cells.Columns.AutoFit()
                    .Cells.Select()
                    .Cells.EntireColumn.AutoFit()
                    .Cells(1, 1).Select()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                'RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                xlApp = Nothing
            End Try
        End If
        If FunCB.Text.Equals("<") Then
            Dim f = "price < '{0}'"
            f = String.Format(f, NumCB.Text)

            View1BindingSource.Filter = f
            Dim rowsTotal, colsTotal As Short
            Dim I, j, iC As Short
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim xlApp As New Excel.Application
            Try
                Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
                Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
                xlApp.Visible = True

                rowsTotal = DataGridView1.RowCount
                colsTotal = DataGridView1.Columns.Count - 1
                With excelWorksheet
                    .Cells.Select()
                    .Cells.Delete()
                    For iC = 0 To colsTotal
                        .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                    Next
                    For I = 0 To rowsTotal - 1
                        For j = 0 To colsTotal
                            .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                        Next j
                    Next I
                    .Rows("1:1").Font.FontStyle = "Bold"
                    .Rows("1:1").Font.Size = 12

                    .Cells.Columns.AutoFit()
                    .Cells.Select()
                    .Cells.EntireColumn.AutoFit()
                    .Cells(1, 1).Select()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                'RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                xlApp = Nothing
            End Try
        End If
        If FunCB.Text.Equals("=") Then
            Dim f = "price = '{0}'"
            f = String.Format(f, NumCB.Text)

            View1BindingSource.Filter = f
            Dim rowsTotal, colsTotal As Short
            Dim I, j, iC As Short
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim xlApp As New Excel.Application
            Try
                Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
                Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
                xlApp.Visible = True

                rowsTotal = DataGridView1.RowCount
                colsTotal = DataGridView1.Columns.Count - 1
                With excelWorksheet
                    .Cells.Select()
                    .Cells.Delete()
                    For iC = 0 To colsTotal
                        .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                    Next
                    For I = 0 To rowsTotal - 1
                        For j = 0 To colsTotal
                            .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                        Next j
                    Next I
                    .Rows("1:1").Font.FontStyle = "Bold"
                    .Rows("1:1").Font.Size = 12

                    .Cells.Columns.AutoFit()
                    .Cells.Select()
                    .Cells.EntireColumn.AutoFit()
                    .Cells(1, 1).Select()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                'RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                xlApp = Nothing
            End Try
        End If

    End Sub


End Class