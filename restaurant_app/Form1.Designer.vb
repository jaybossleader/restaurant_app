<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_form))
        Me.usernameTB = New System.Windows.Forms.TextBox()
        Me.passwordTB = New System.Windows.Forms.TextBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'usernameTB
        '
        Me.usernameTB.Location = New System.Drawing.Point(50, 193)
        Me.usernameTB.Name = "usernameTB"
        Me.usernameTB.Size = New System.Drawing.Size(100, 20)
        Me.usernameTB.TabIndex = 0
        '
        'passwordTB
        '
        Me.passwordTB.Location = New System.Drawing.Point(238, 193)
        Me.passwordTB.Name = "passwordTB"
        Me.passwordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTB.Size = New System.Drawing.Size(100, 20)
        Me.passwordTB.TabIndex = 1
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.Gold
        Me.login_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.login_btn.Location = New System.Drawing.Point(157, 276)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(75, 35)
        Me.login_btn.TabIndex = 2
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'login_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(401, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.passwordTB)
        Me.Controls.Add(Me.usernameTB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usernameTB As TextBox
    Friend WithEvents passwordTB As TextBox
    Friend WithEvents login_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
