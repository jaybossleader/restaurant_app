<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMenu))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenunameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestaurantDataSet = New restaurant_app.restaurantDataSet()
        Me.MenuTableAdapter = New restaurant_app.restaurantDataSetTableAdapters.menuTableAdapter()
        Me.AddMenuBtn = New System.Windows.Forms.Button()
        Me.AddItemsToMenuBtn = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MenuBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenushareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Menu_shareTableAdapter = New restaurant_app.restaurantDataSetTableAdapters.menu_shareTableAdapter()
        Me.ItemsTableAdapter = New restaurant_app.restaurantDataSetTableAdapters.itemsTableAdapter()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ShowMenuBtn = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.View1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_1TableAdapter = New restaurant_app.restaurantDataSetTableAdapters.View_1TableAdapter()
        Me.filterComboBox = New System.Windows.Forms.ComboBox()
        Me.MenuBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenunameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatnbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenushareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.MenunameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MenuBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(253, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(256, 312)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'MenunameDataGridViewTextBoxColumn
        '
        Me.MenunameDataGridViewTextBoxColumn.DataPropertyName = "menu_name"
        Me.MenunameDataGridViewTextBoxColumn.HeaderText = "menu_name"
        Me.MenunameDataGridViewTextBoxColumn.Name = "MenunameDataGridViewTextBoxColumn"
        '
        'MenuBindingSource
        '
        Me.MenuBindingSource.DataMember = "menu"
        Me.MenuBindingSource.DataSource = Me.RestaurantDataSet
        '
        'RestaurantDataSet
        '
        Me.RestaurantDataSet.DataSetName = "restaurantDataSet"
        Me.RestaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuTableAdapter
        '
        Me.MenuTableAdapter.ClearBeforeFill = True
        '
        'AddMenuBtn
        '
        Me.AddMenuBtn.BackColor = System.Drawing.Color.Gold
        Me.AddMenuBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddMenuBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AddMenuBtn.Location = New System.Drawing.Point(300, 358)
        Me.AddMenuBtn.Name = "AddMenuBtn"
        Me.AddMenuBtn.Size = New System.Drawing.Size(155, 34)
        Me.AddMenuBtn.TabIndex = 1
        Me.AddMenuBtn.Text = "Add Menu"
        Me.AddMenuBtn.UseVisualStyleBackColor = False
        '
        'AddItemsToMenuBtn
        '
        Me.AddItemsToMenuBtn.BackColor = System.Drawing.Color.Gold
        Me.AddItemsToMenuBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddItemsToMenuBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AddItemsToMenuBtn.Location = New System.Drawing.Point(300, 398)
        Me.AddItemsToMenuBtn.Name = "AddItemsToMenuBtn"
        Me.AddItemsToMenuBtn.Size = New System.Drawing.Size(155, 34)
        Me.AddItemsToMenuBtn.TabIndex = 2
        Me.AddItemsToMenuBtn.Text = "Add Items to Menu"
        Me.AddItemsToMenuBtn.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.MenuidDataGridViewTextBoxColumn, Me.ItemidDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.MenushareBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 40)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(752, 312)
        Me.DataGridView2.TabIndex = 3
        Me.DataGridView2.Visible = False
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn1.Visible = False
        '
        'MenuidDataGridViewTextBoxColumn
        '
        Me.MenuidDataGridViewTextBoxColumn.DataPropertyName = "menu_id"
        Me.MenuidDataGridViewTextBoxColumn.DataSource = Me.MenuBindingSource1
        Me.MenuidDataGridViewTextBoxColumn.DisplayMember = "menu_name"
        Me.MenuidDataGridViewTextBoxColumn.HeaderText = "Menu"
        Me.MenuidDataGridViewTextBoxColumn.Name = "MenuidDataGridViewTextBoxColumn"
        Me.MenuidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MenuidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MenuidDataGridViewTextBoxColumn.ValueMember = "id"
        '
        'MenuBindingSource1
        '
        Me.MenuBindingSource1.DataMember = "menu"
        Me.MenuBindingSource1.DataSource = Me.RestaurantDataSet
        '
        'ItemidDataGridViewTextBoxColumn
        '
        Me.ItemidDataGridViewTextBoxColumn.DataPropertyName = "item_id"
        Me.ItemidDataGridViewTextBoxColumn.DataSource = Me.ItemsBindingSource
        Me.ItemidDataGridViewTextBoxColumn.DisplayMember = "item"
        Me.ItemidDataGridViewTextBoxColumn.HeaderText = "Item"
        Me.ItemidDataGridViewTextBoxColumn.Name = "ItemidDataGridViewTextBoxColumn"
        Me.ItemidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ItemidDataGridViewTextBoxColumn.ValueMember = "id"
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "items"
        Me.ItemsBindingSource.DataSource = Me.RestaurantDataSet
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'MenushareBindingSource
        '
        Me.MenushareBindingSource.DataMember = "menu_share"
        Me.MenushareBindingSource.DataSource = Me.RestaurantDataSet
        '
        'Menu_shareTableAdapter
        '
        Me.Menu_shareTableAdapter.ClearBeforeFill = True
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.Gold
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AddBtn.Location = New System.Drawing.Point(300, 398)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(155, 34)
        Me.AddBtn.TabIndex = 4
        Me.AddBtn.Text = "Add Items to Menu"
        Me.AddBtn.UseVisualStyleBackColor = False
        Me.AddBtn.Visible = False
        '
        'ShowMenuBtn
        '
        Me.ShowMenuBtn.BackColor = System.Drawing.Color.Gold
        Me.ShowMenuBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowMenuBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ShowMenuBtn.Location = New System.Drawing.Point(609, 398)
        Me.ShowMenuBtn.Name = "ShowMenuBtn"
        Me.ShowMenuBtn.Size = New System.Drawing.Size(155, 34)
        Me.ShowMenuBtn.TabIndex = 5
        Me.ShowMenuBtn.Text = "Show Menus"
        Me.ShowMenuBtn.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn2, Me.ItemDataGridViewTextBoxColumn, Me.Expr3DataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn1, Me.CategoryDataGridViewTextBoxColumn, Me.MenuidDataGridViewTextBoxColumn1, Me.ItemidDataGridViewTextBoxColumn1, Me.Expr1DataGridViewTextBoxColumn, Me.MenunameDataGridViewTextBoxColumn1, Me.Expr2DataGridViewTextBoxColumn, Me.CatnbDataGridViewTextBoxColumn, Me.Expr4DataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.View1BindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(12, 40)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(752, 312)
        Me.DataGridView3.TabIndex = 6
        Me.DataGridView3.Visible = False
        '
        'View1BindingSource
        '
        Me.View1BindingSource.DataMember = "View_1"
        Me.View1BindingSource.DataSource = Me.RestaurantDataSet
        '
        'View_1TableAdapter
        '
        Me.View_1TableAdapter.ClearBeforeFill = True
        '
        'filterComboBox
        '
        Me.filterComboBox.DataSource = Me.MenuBindingSource2
        Me.filterComboBox.DisplayMember = "menu_name"
        Me.filterComboBox.FormattingEnabled = True
        Me.filterComboBox.Location = New System.Drawing.Point(24, 12)
        Me.filterComboBox.Name = "filterComboBox"
        Me.filterComboBox.Size = New System.Drawing.Size(121, 21)
        Me.filterComboBox.TabIndex = 7
        Me.filterComboBox.ValueMember = "menu_name"
        Me.filterComboBox.Visible = False
        '
        'MenuBindingSource2
        '
        Me.MenuBindingSource2.DataMember = "menu"
        Me.MenuBindingSource2.DataSource = Me.RestaurantDataSet
        '
        'IdDataGridViewTextBoxColumn2
        '
        Me.IdDataGridViewTextBoxColumn2.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn2.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn2.Name = "IdDataGridViewTextBoxColumn2"
        Me.IdDataGridViewTextBoxColumn2.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn2.Visible = False
        '
        'ItemDataGridViewTextBoxColumn
        '
        Me.ItemDataGridViewTextBoxColumn.DataPropertyName = "item"
        Me.ItemDataGridViewTextBoxColumn.HeaderText = "item"
        Me.ItemDataGridViewTextBoxColumn.Name = "ItemDataGridViewTextBoxColumn"
        Me.ItemDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr3DataGridViewTextBoxColumn
        '
        Me.Expr3DataGridViewTextBoxColumn.DataPropertyName = "Expr3"
        Me.Expr3DataGridViewTextBoxColumn.HeaderText = "Original Price"
        Me.Expr3DataGridViewTextBoxColumn.Name = "Expr3DataGridViewTextBoxColumn"
        Me.Expr3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn1
        '
        Me.PriceDataGridViewTextBoxColumn1.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn1.HeaderText = "Menu Price"
        Me.PriceDataGridViewTextBoxColumn1.Name = "PriceDataGridViewTextBoxColumn1"
        Me.PriceDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MenuidDataGridViewTextBoxColumn1
        '
        Me.MenuidDataGridViewTextBoxColumn1.DataPropertyName = "menu_id"
        Me.MenuidDataGridViewTextBoxColumn1.HeaderText = "menu_id"
        Me.MenuidDataGridViewTextBoxColumn1.Name = "MenuidDataGridViewTextBoxColumn1"
        Me.MenuidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MenuidDataGridViewTextBoxColumn1.Visible = False
        '
        'ItemidDataGridViewTextBoxColumn1
        '
        Me.ItemidDataGridViewTextBoxColumn1.DataPropertyName = "item_id"
        Me.ItemidDataGridViewTextBoxColumn1.HeaderText = "item_id"
        Me.ItemidDataGridViewTextBoxColumn1.Name = "ItemidDataGridViewTextBoxColumn1"
        Me.ItemidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ItemidDataGridViewTextBoxColumn1.Visible = False
        '
        'Expr1DataGridViewTextBoxColumn
        '
        Me.Expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn.HeaderText = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn.Name = "Expr1DataGridViewTextBoxColumn"
        Me.Expr1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Expr1DataGridViewTextBoxColumn.Visible = False
        '
        'MenunameDataGridViewTextBoxColumn1
        '
        Me.MenunameDataGridViewTextBoxColumn1.DataPropertyName = "menu_name"
        Me.MenunameDataGridViewTextBoxColumn1.HeaderText = "menu_name"
        Me.MenunameDataGridViewTextBoxColumn1.Name = "MenunameDataGridViewTextBoxColumn1"
        Me.MenunameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MenunameDataGridViewTextBoxColumn1.Visible = False
        '
        'Expr2DataGridViewTextBoxColumn
        '
        Me.Expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2"
        Me.Expr2DataGridViewTextBoxColumn.HeaderText = "Expr2"
        Me.Expr2DataGridViewTextBoxColumn.Name = "Expr2DataGridViewTextBoxColumn"
        Me.Expr2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Expr2DataGridViewTextBoxColumn.Visible = False
        '
        'CatnbDataGridViewTextBoxColumn
        '
        Me.CatnbDataGridViewTextBoxColumn.DataPropertyName = "cat_nb"
        Me.CatnbDataGridViewTextBoxColumn.HeaderText = "cat_nb"
        Me.CatnbDataGridViewTextBoxColumn.Name = "CatnbDataGridViewTextBoxColumn"
        Me.CatnbDataGridViewTextBoxColumn.ReadOnly = True
        Me.CatnbDataGridViewTextBoxColumn.Visible = False
        '
        'Expr4DataGridViewTextBoxColumn
        '
        Me.Expr4DataGridViewTextBoxColumn.DataPropertyName = "Expr4"
        Me.Expr4DataGridViewTextBoxColumn.HeaderText = "Expr4"
        Me.Expr4DataGridViewTextBoxColumn.Name = "Expr4DataGridViewTextBoxColumn"
        Me.Expr4DataGridViewTextBoxColumn.ReadOnly = True
        Me.Expr4DataGridViewTextBoxColumn.Visible = False
        '
        'AddMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(776, 473)
        Me.Controls.Add(Me.filterComboBox)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.ShowMenuBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.AddItemsToMenuBtn)
        Me.Controls.Add(Me.AddMenuBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddMenu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenushareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RestaurantDataSet As restaurantDataSet
    Friend WithEvents MenuBindingSource As BindingSource
    Friend WithEvents MenuTableAdapter As restaurantDataSetTableAdapters.menuTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenunameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddMenuBtn As Button
    Friend WithEvents AddItemsToMenuBtn As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents MenushareBindingSource As BindingSource
    Friend WithEvents Menu_shareTableAdapter As restaurantDataSetTableAdapters.menu_shareTableAdapter
    Friend WithEvents MenuBindingSource1 As BindingSource
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As restaurantDataSetTableAdapters.itemsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MenuidDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents ItemidDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddBtn As Button
    Friend WithEvents ShowMenuBtn As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents View1BindingSource As BindingSource
    Friend WithEvents View_1TableAdapter As restaurantDataSetTableAdapters.View_1TableAdapter
    Friend WithEvents filterComboBox As ComboBox
    Friend WithEvents MenuBindingSource2 As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ItemDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenunameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Expr2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CatnbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
