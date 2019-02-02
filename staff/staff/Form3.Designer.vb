<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.password = New System.Windows.Forms.Label()
        Me.confirmPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.showPassword = New System.Windows.Forms.CheckBox()
        Me.changePassword = New System.Windows.Forms.Button()
        Me.prevPage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(53, 115)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(106, 25)
        Me.password.TabIndex = 0
        Me.password.Text = "Password"
        '
        'confirmPassword
        '
        Me.confirmPassword.AutoSize = True
        Me.confirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPassword.Location = New System.Drawing.Point(53, 191)
        Me.confirmPassword.Name = "confirmPassword"
        Me.confirmPassword.Size = New System.Drawing.Size(186, 25)
        Me.confirmPassword.TabIndex = 1
        Me.confirmPassword.Text = "Confirm Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(283, 115)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(255, 20)
        Me.txtPassword.TabIndex = 2
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(283, 196)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(255, 20)
        Me.txtConfirmPassword.TabIndex = 3
        '
        'showPassword
        '
        Me.showPassword.AutoSize = True
        Me.showPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showPassword.Location = New System.Drawing.Point(71, 241)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(184, 29)
        Me.showPassword.TabIndex = 4
        Me.showPassword.Text = "Show Password"
        Me.showPassword.UseVisualStyleBackColor = True
        '
        'changePassword
        '
        Me.changePassword.Location = New System.Drawing.Point(388, 321)
        Me.changePassword.Name = "changePassword"
        Me.changePassword.Size = New System.Drawing.Size(192, 57)
        Me.changePassword.TabIndex = 5
        Me.changePassword.Text = "Change My Password"
        Me.changePassword.UseVisualStyleBackColor = True
        '
        'prevPage
        '
        Me.prevPage.Location = New System.Drawing.Point(124, 321)
        Me.prevPage.Name = "prevPage"
        Me.prevPage.Size = New System.Drawing.Size(211, 57)
        Me.prevPage.TabIndex = 6
        Me.prevPage.Text = "Previous Page"
        Me.prevPage.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 418)
        Me.Controls.Add(Me.prevPage)
        Me.Controls.Add(Me.changePassword)
        Me.Controls.Add(Me.showPassword)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.confirmPassword)
        Me.Controls.Add(Me.password)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents password As System.Windows.Forms.Label
    Friend WithEvents confirmPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents showPassword As System.Windows.Forms.CheckBox
    Friend WithEvents changePassword As System.Windows.Forms.Button
    Friend WithEvents prevPage As System.Windows.Forms.Button
End Class
