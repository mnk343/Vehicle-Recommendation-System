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
        Me.confirmPassword = New System.Windows.Forms.Label()
        Me.contactNo = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.info = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.showPassword = New System.Windows.Forms.CheckBox()
        Me.password = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'vehicle
        '
        Me.vehicle.FormattingEnabled = True
        Me.vehicle.Location = New System.Drawing.Point(505, 48)
        Me.vehicle.Margin = New System.Windows.Forms.Padding(4)
        Me.vehicle.Name = "vehicle"
        Me.vehicle.Size = New System.Drawing.Size(464, 24)
        Me.vehicle.TabIndex = 0
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.Font = New System.Drawing.Font("Museo Sans For Dell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userName.ForeColor = System.Drawing.Color.White
        Me.userName.Location = New System.Drawing.Point(55, 36)
        Me.userName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(161, 33)
        Me.userName.TabIndex = 1
        Me.userName.Text = "User Name"
        '
        'confirmPassword
        '
        Me.confirmPassword.AutoSize = True
        Me.confirmPassword.Font = New System.Drawing.Font("Museo Sans For Dell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPassword.ForeColor = System.Drawing.Color.White
        Me.confirmPassword.Location = New System.Drawing.Point(55, 191)
        Me.confirmPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.confirmPassword.Name = "confirmPassword"
        Me.confirmPassword.Size = New System.Drawing.Size(258, 33)
        Me.confirmPassword.TabIndex = 3
        Me.confirmPassword.Text = "Confirm Password"
        '
        'contactNo
        '
        Me.contactNo.AutoSize = True
        Me.contactNo.Font = New System.Drawing.Font("Museo Sans For Dell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNo.ForeColor = System.Drawing.Color.White
        Me.contactNo.Location = New System.Drawing.Point(55, 274)
        Me.contactNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.contactNo.Name = "contactNo"
        Me.contactNo.Size = New System.Drawing.Size(237, 33)
        Me.contactNo.TabIndex = 4
        Me.contactNo.Text = "Contact Number"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(504, 45)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(464, 22)
        Me.txtName.TabIndex = 5
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.AcceptsReturn = True
        Me.txtConfirmPassword.Location = New System.Drawing.Point(504, 200)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(464, 22)
        Me.txtConfirmPassword.TabIndex = 7
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(504, 285)
        Me.txtContactNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(464, 22)
        Me.txtContactNo.TabIndex = 8
        '
        'submit
        '
        Me.submit.BackColor = System.Drawing.Color.Black
        Me.submit.Font = New System.Drawing.Font("Museo Sans For Dell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.ForeColor = System.Drawing.Color.White
        Me.submit.Location = New System.Drawing.Point(189, 52)
        Me.submit.Margin = New System.Windows.Forms.Padding(4)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(196, 58)
        Me.submit.TabIndex = 9
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = False
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Museo Sans For Dell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Location = New System.Drawing.Point(56, 41)
        Me.info.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(400, 33)
        Me.info.TabIndex = 10
        Me.info.Text = "Please Select a vehicle type : "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Museo Sans For Dell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(606, 52)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 58)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.submit)
        Me.Panel1.Location = New System.Drawing.Point(1, 442)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(989, 135)
        Me.Panel1.TabIndex = 13
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(504, 121)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(464, 22)
        Me.txtPassword.TabIndex = 6
        '
        'showPassword
        '
        Me.showPassword.AutoSize = True
        Me.showPassword.Font = New System.Drawing.Font("Museo Sans For Dell", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showPassword.ForeColor = System.Drawing.Color.White
        Me.showPassword.Location = New System.Drawing.Point(812, 230)
        Me.showPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(156, 24)
        Me.showPassword.TabIndex = 11
        Me.showPassword.Text = "Show Password"
        Me.showPassword.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Museo Sans For Dell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.White
        Me.password.Location = New System.Drawing.Point(55, 112)
        Me.password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(142, 33)
        Me.password.TabIndex = 2
        Me.password.Text = "Password"
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
        Me.Panel2.Location = New System.Drawing.Point(1, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(989, 330)
        Me.Panel2.TabIndex = 14
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 574)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.vehicle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vehicle As System.Windows.Forms.ComboBox
    Friend WithEvents userName As System.Windows.Forms.Label
    Friend WithEvents confirmPassword As System.Windows.Forms.Label
    Friend WithEvents contactNo As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents showPassword As System.Windows.Forms.CheckBox
    Friend WithEvents password As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
