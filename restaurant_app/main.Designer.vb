<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.AddUserBtn = New System.Windows.Forms.Button()
        Me.AddCatBtn = New System.Windows.Forms.Button()
        Me.AddItemBtn = New System.Windows.Forms.Button()
        Me.AddMenuBtn = New System.Windows.Forms.Button()
        Me.RepBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddUserBtn
        '
        Me.AddUserBtn.Location = New System.Drawing.Point(55, 59)
        Me.AddUserBtn.Name = "AddUserBtn"
        Me.AddUserBtn.Size = New System.Drawing.Size(177, 23)
        Me.AddUserBtn.TabIndex = 0
        Me.AddUserBtn.Text = "Add User"
        Me.AddUserBtn.UseVisualStyleBackColor = True
        '
        'AddCatBtn
        '
        Me.AddCatBtn.Location = New System.Drawing.Point(55, 115)
        Me.AddCatBtn.Name = "AddCatBtn"
        Me.AddCatBtn.Size = New System.Drawing.Size(177, 23)
        Me.AddCatBtn.TabIndex = 1
        Me.AddCatBtn.Text = "Add Category"
        Me.AddCatBtn.UseVisualStyleBackColor = True
        '
        'AddItemBtn
        '
        Me.AddItemBtn.Location = New System.Drawing.Point(55, 175)
        Me.AddItemBtn.Name = "AddItemBtn"
        Me.AddItemBtn.Size = New System.Drawing.Size(177, 23)
        Me.AddItemBtn.TabIndex = 2
        Me.AddItemBtn.Text = "Add Item"
        Me.AddItemBtn.UseVisualStyleBackColor = True
        '
        'AddMenuBtn
        '
        Me.AddMenuBtn.Location = New System.Drawing.Point(55, 234)
        Me.AddMenuBtn.Name = "AddMenuBtn"
        Me.AddMenuBtn.Size = New System.Drawing.Size(177, 23)
        Me.AddMenuBtn.TabIndex = 3
        Me.AddMenuBtn.Text = "Menu"
        Me.AddMenuBtn.UseVisualStyleBackColor = True
        '
        'RepBtn
        '
        Me.RepBtn.Location = New System.Drawing.Point(55, 288)
        Me.RepBtn.Name = "RepBtn"
        Me.RepBtn.Size = New System.Drawing.Size(177, 23)
        Me.RepBtn.TabIndex = 4
        Me.RepBtn.Text = "Report"
        Me.RepBtn.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(285, 450)
        Me.Controls.Add(Me.RepBtn)
        Me.Controls.Add(Me.AddMenuBtn)
        Me.Controls.Add(Me.AddItemBtn)
        Me.Controls.Add(Me.AddCatBtn)
        Me.Controls.Add(Me.AddUserBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddUserBtn As Button
    Friend WithEvents AddCatBtn As Button
    Friend WithEvents AddItemBtn As Button
    Friend WithEvents AddMenuBtn As Button
    Friend WithEvents RepBtn As Button
End Class
