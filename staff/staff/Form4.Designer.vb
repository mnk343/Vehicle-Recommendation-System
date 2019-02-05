<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.vehicle = New System.Windows.Forms.ComboBox()
        Me.userName = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.confirmPassword = New System.Windows.Forms.Label()
        Me.contactNo = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.info = New System.Windows.Forms.Label()
        Me.showPassword = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'vehicle
        '
        Me.vehicle.FormattingEnabled = True
        Me.vehicle.Location = New System.Drawing.Point(357, 21)
        Me.vehicle.Name = "vehicle"
        Me.vehicle.Size = New System.Drawing.Size(121, 21)
        Me.vehicle.TabIndex = 0
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userName.Location = New System.Drawing.Point(45, 69)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(119, 25)
        Me.userName.TabIndex = 1
        Me.userName.Text = "User Name"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(45, 119)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(106, 25)
        Me.password.TabIndex = 2
        Me.password.Text = "Password"
        '
        'confirmPassword
        '
        Me.confirmPassword.AutoSize = True
        Me.confirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPassword.Location = New System.Drawing.Point(45, 171)
        Me.confirmPassword.Name = "confirmPassword"
        Me.confirmPassword.Size = New System.Drawing.Size(186, 25)
        Me.confirmPassword.TabIndex = 3
        Me.confirmPassword.Text = "Confirm Password"
        '
        'contactNo
        '
        Me.contactNo.AutoSize = True
        Me.contactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNo.Location = New System.Drawing.Point(45, 230)
        Me.contactNo.Name = "contactNo"
        Me.contactNo.Size = New System.Drawing.Size(167, 25)
        Me.contactNo.TabIndex = 4
        Me.contactNo.Text = "Contact Number"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(268, 74)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(349, 20)
        Me.txtName.TabIndex = 5
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(268, 124)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(349, 20)
        Me.txtPassword.TabIndex = 6
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.AcceptsReturn = True
        Me.txtConfirmPassword.Location = New System.Drawing.Point(268, 171)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(349, 20)
        Me.txtConfirmPassword.TabIndex = 7
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(268, 235)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(349, 20)
        Me.txtContactNo.TabIndex = 8
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(437, 289)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(147, 47)
        Me.submit.TabIndex = 9
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Location = New System.Drawing.Point(50, 17)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(301, 25)
        Me.info.TabIndex = 10
        Me.info.Text = "Please Select a vehicle type : "
        '
        'showPassword
        '
        Me.showPassword.AutoSize = True
        Me.showPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showPassword.Location = New System.Drawing.Point(17, 289)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(184, 29)
        Me.showPassword.TabIndex = 11
        Me.showPassword.Text = "Show Password"
        Me.showPassword.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(437, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 47)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 466)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.showPassword)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.contactNo)
        Me.Controls.Add(Me.confirmPassword)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.vehicle)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vehicle As System.Windows.Forms.ComboBox
    Friend WithEvents userName As System.Windows.Forms.Label
    Friend WithEvents password As System.Windows.Forms.Label
    Friend WithEvents confirmPassword As System.Windows.Forms.Label
    Friend WithEvents contactNo As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents showPassword As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
