<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reports))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.View1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestaurantDataSet = New restaurant_app.restaurantDataSet()
        Me.View_1TableAdapter = New restaurant_app.restaurantDataSetTableAdapters.View_1TableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FunCB = New System.Windows.Forms.ComboBox()
        Me.NumCB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuCB = New System.Windows.Forms.ComboBox()
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatCB = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryTableAdapter = New restaurant_app.restaurantDataSetTableAdapters.categoryTableAdapter()
        Me.MenuTableAdapter = New restaurant_app.restaurantDataSetTableAdapters.menuTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenunameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatnbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilterBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.MenuidDataGridViewTextBoxColumn, Me.ItemidDataGridViewTextBoxColumn, Me.ItemDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.Expr3DataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.Expr1DataGridViewTextBoxColumn, Me.MenunameDataGridViewTextBoxColumn, Me.Expr2DataGridViewTextBoxColumn, Me.CatnbDataGridViewTextBoxColumn, Me.Expr4DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.View1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 132)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1035, 424)
        Me.DataGridView1.TabIndex = 0
        '
        'View1BindingSource
        '
        Me.View1BindingSource.DataMember = "View_1"
        Me.View1BindingSource.DataSource = Me.RestaurantDataSet
        '
        'RestaurantDataSet
        '
        Me.RestaurantDataSet.DataSetName = "restaurantDataSet"
        Me.RestaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_1TableAdapter
        '
        Me.View_1TableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MenuCB)
        Me.GroupBox1.Controls.Add(Me.CatCB)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1035, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filters"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FilterBtn)
        Me.GroupBox2.Controls.Add(Me.FunCB)
        Me.GroupBox2.Controls.Add(Me.NumCB)
        Me.GroupBox2.Location = New System.Drawing.Point(382, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 72)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Price"
        '
        'FunCB
        '
        Me.FunCB.FormattingEnabled = True
        Me.FunCB.Items.AddRange(New Object() {"=", ">", "<"})
        Me.FunCB.Location = New System.Drawing.Point(73, 43)
        Me.FunCB.Name = "FunCB"
        Me.FunCB.Size = New System.Drawing.Size(121, 24)
        Me.FunCB.TabIndex = 4
        '
        'NumCB
        '
        Me.NumCB.Location = New System.Drawing.Point(202, 45)
        Me.NumCB.Name = "NumCB"
        Me.NumCB.Size = New System.Drawing.Size(100, 22)
        Me.NumCB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Category"
        '
        'MenuCB
        '
        Me.MenuCB.DataSource = Me.MenuBindingSource
        Me.MenuCB.DisplayMember = "menu_name"
        Me.MenuCB.FormattingEnabled = True
        Me.MenuCB.Location = New System.Drawing.Point(142, 59)
        Me.MenuCB.Name = "MenuCB"
        Me.MenuCB.Size = New System.Drawing.Size(121, 24)
        Me.MenuCB.TabIndex = 1
        Me.MenuCB.ValueMember = "menu_name"
        '
        'MenuBindingSource
        '
        Me.MenuBindingSource.DataMember = "menu"
        Me.MenuBindingSource.DataSource = Me.RestaurantDataSet
        '
        'CatCB
        '
        Me.CatCB.DataSource = Me.CategoryBindingSource
        Me.CatCB.DisplayMember = "category"
        Me.CatCB.FormattingEnabled = True
        Me.CatCB.Location = New System.Drawing.Point(6, 59)
        Me.CatCB.Name = "CatCB"
        Me.CatCB.Size = New System.Drawing.Size(121, 24)
        Me.CatCB.TabIndex = 0
        Me.CatCB.ValueMember = "category"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "category"
        Me.CategoryBindingSource.DataSource = Me.RestaurantDataSet
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'MenuTableAdapter
        '
        Me.MenuTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'MenuidDataGridViewTextBoxColumn
        '
        Me.MenuidDataGridViewTextBoxColumn.DataPropertyName = "menu_id"
        Me.MenuidDataGridViewTextBoxColumn.HeaderText = "menu_id"
        Me.MenuidDataGridViewTextBoxColumn.Name = "MenuidDataGridViewTextBoxColumn"
        Me.MenuidDataGridViewTextBoxColumn.Visible = False
        '
        'ItemidDataGridViewTextBoxColumn
        '
        Me.ItemidDataGridViewTextBoxColumn.DataPropertyName = "item_id"
        Me.ItemidDataGridViewTextBoxColumn.HeaderText = "item_id"
        Me.ItemidDataGridViewTextBoxColumn.Name = "ItemidDataGridViewTextBoxColumn"
        Me.ItemidDataGridViewTextBoxColumn.Visible = False
        '
        'ItemDataGridViewTextBoxColumn
        '
        Me.ItemDataGridViewTextBoxColumn.DataPropertyName = "item"
        Me.ItemDataGridViewTextBoxColumn.HeaderText = "item"
        Me.ItemDataGridViewTextBoxColumn.Name = "ItemDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Menu Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'Expr3DataGridViewTextBoxColumn
        '
        Me.Expr3DataGridViewTextBoxColumn.DataPropertyName = "Expr3"
        Me.Expr3DataGridViewTextBoxColumn.HeaderText = "Original Price"
        Me.Expr3DataGridViewTextBoxColumn.Name = "Expr3DataGridViewTextBoxColumn"
        Me.Expr3DataGridViewTextBoxColumn.Visible = False
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'Expr1DataGridViewTextBoxColumn
        '
        Me.Expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn.HeaderText = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn.Name = "Expr1DataGridViewTextBoxColumn"
        Me.Expr1DataGridViewTextBoxColumn.Visible = False
        '
        'MenunameDataGridViewTextBoxColumn
        '
        Me.MenunameDataGridViewTextBoxColumn.DataPropertyName = "menu_name"
        Me.MenunameDataGridViewTextBoxColumn.HeaderText = "Menu"
        Me.MenunameDataGridViewTextBoxColumn.Name = "MenunameDataGridViewTextBoxColumn"
        Me.MenunameDataGridViewTextBoxColumn.Visible = False
        '
        'Expr2DataGridViewTextBoxColumn
        '
        Me.Expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2"
        Me.Expr2DataGridViewTextBoxColumn.HeaderText = "Expr2"
        Me.Expr2DataGridViewTextBoxColumn.Name = "Expr2DataGridViewTextBoxColumn"
        Me.Expr2DataGridViewTextBoxColumn.Visible = False
        '
        'CatnbDataGridViewTextBoxColumn
        '
        Me.CatnbDataGridViewTextBoxColumn.DataPropertyName = "cat_nb"
        Me.CatnbDataGridViewTextBoxColumn.HeaderText = "cat_nb"
        Me.CatnbDataGridViewTextBoxColumn.Name = "CatnbDataGridViewTextBoxColumn"
        Me.CatnbDataGridViewTextBoxColumn.Visible = False
        '
        'Expr4DataGridViewTextBoxColumn
        '
        Me.Expr4DataGridViewTextBoxColumn.DataPropertyName = "Expr4"
        Me.Expr4DataGridViewTextBoxColumn.HeaderText = "Expr4"
        Me.Expr4DataGridViewTextBoxColumn.Name = "Expr4DataGridViewTextBoxColumn"
        Me.Expr4DataGridViewTextBoxColumn.Visible = False
        '
        'FilterBtn
        '
        Me.FilterBtn.BackColor = System.Drawing.Color.Gold
        Me.FilterBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FilterBtn.Location = New System.Drawing.Point(355, 38)
        Me.FilterBtn.Name = "FilterBtn"
        Me.FilterBtn.Size = New System.Drawing.Size(75, 28)
        Me.FilterBtn.TabIndex = 5
        Me.FilterBtn.Text = "Filter"
        Me.FilterBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(930, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1131, 622)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reports"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RestaurantDataSet As restaurantDataSet
    Friend WithEvents View1BindingSource As BindingSource
    Friend WithEvents View_1TableAdapter As restaurantDataSetTableAdapters.View_1TableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FunCB As ComboBox
    Friend WithEvents NumCB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuCB As ComboBox
    Friend WithEvents CatCB As ComboBox
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents CategoryTableAdapter As restaurantDataSetTableAdapters.categoryTableAdapter
    Friend WithEvents MenuBindingSource As BindingSource
    Friend WithEvents MenuTableAdapter As restaurantDataSetTableAdapters.menuTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenunameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CatnbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FilterBtn As Button
    Friend WithEvents Button1 As Button
End Class
