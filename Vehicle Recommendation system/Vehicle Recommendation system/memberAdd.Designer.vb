<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class memberAdd
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.userName = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.confirmPassword = New System.Windows.Forms.Label()
        Me.contactNo = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.info = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.showPassword = New System.Windows.Forms.CheckBox()
        Me.password = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'vehicle
        '
        Me.vehicle.FormattingEnabled = True
        Me.vehicle.Location = New System.Drawing.Point(397, 15)
        Me.vehicle.Name = "vehicle"
        Me.vehicle.Size = New System.Drawing.Size(349, 21)
        Me.vehicle.TabIndex = 15
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(378, 37)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(349, 20)
        Me.txtName.TabIndex = 5
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userName.ForeColor = System.Drawing.Color.White
        Me.userName.Location = New System.Drawing.Point(41, 29)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(132, 26)
        Me.userName.TabIndex = 1
        Me.userName.Text = "User Name"
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(378, 232)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(349, 20)
        Me.txtContactNo.TabIndex = 8
        '
        'confirmPassword
        '
        Me.confirmPassword.AutoSize = True
        Me.confirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPassword.ForeColor = System.Drawing.Color.White
        Me.confirmPassword.Location = New System.Drawing.Point(41, 155)
        Me.confirmPassword.Name = "confirmPassword"
        Me.confirmPassword.Size = New System.Drawing.Size(207, 26)
        Me.confirmPassword.TabIndex = 3
        Me.confirmPassword.Text = "Confirm Password"
        '
        'contactNo
        '
        Me.contactNo.AutoSize = True
        Me.contactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNo.ForeColor = System.Drawing.Color.White
        Me.contactNo.Location = New System.Drawing.Point(41, 223)
        Me.contactNo.Name = "contactNo"
        Me.contactNo.Size = New System.Drawing.Size(185, 26)
        Me.contactNo.TabIndex = 4
        Me.contactNo.Text = "Contact Number"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.AcceptsReturn = True
        Me.txtConfirmPassword.Location = New System.Drawing.Point(378, 162)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(349, 20)
        Me.txtConfirmPassword.TabIndex = 7
        '
        'submit
        '
        Me.submit.BackColor = System.Drawing.Color.Black
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.ForeColor = System.Drawing.Color.White
        Me.submit.Location = New System.Drawing.Point(142, 42)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(147, 47)
        Me.submit.TabIndex = 9
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = False
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Location = New System.Drawing.Point(14, 15)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(334, 26)
        Me.info.TabIndex = 16
        Me.info.Text = "Please Select a vehicle type : "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(454, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 47)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.submit)
        Me.Panel1.Location = New System.Drawing.Point(19, 329)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 110)
        Me.Panel1.TabIndex = 17
        '
        'showPassword
        '
        Me.showPassword.AutoSize = True
        Me.showPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showPassword.ForeColor = System.Drawing.Color.White
        Me.showPassword.Location = New System.Drawing.Point(609, 187)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(139, 21)
        Me.showPassword.TabIndex = 11
        Me.showPassword.Text = "Show Password"
        Me.showPassword.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.White
        Me.password.Location = New System.Drawing.Point(41, 91)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(116, 26)
        Me.password.TabIndex = 2
        Me.password.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(378, 98)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(349, 20)
        Me.txtPassword.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.showPassword)
        Me.Panel2.Controls.Add(Me.userName)
        Me.Panel2.Controls.Add(Me.password)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Controls.Add(Me.txtContactNo)
        Me.Panel2.Controls.Add(Me.confirmPassword)
        Me.Panel2.Controls.Add(Me.contactNo)
        Me.Panel2.Controls.Add(Me.txtConfirmPassword)
        Me.Panel2.Location = New System.Drawing.Point(19, 61)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(742, 268)
        Me.Panel2.TabIndex = 18
        '
        'memberAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 473)
        Me.Controls.Add(Me.vehicle)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "memberAdd"
        Me.Text = "memberAdd"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vehicle As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents userName As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents confirmPassword As System.Windows.Forms.Label
    Friend WithEvents contactNo As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents showPassword As System.Windows.Forms.CheckBox
    Friend WithEvents password As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
