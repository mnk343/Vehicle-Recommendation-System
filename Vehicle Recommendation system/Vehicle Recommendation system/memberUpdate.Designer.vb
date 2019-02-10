<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class memberUpdate
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
        Me.submit1 = New System.Windows.Forms.Button()
        Me.name = New System.Windows.Forms.Label()
        Me.showPassword = New System.Windows.Forms.CheckBox()
        Me.password = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.usrName = New System.Windows.Forms.TextBox()
        Me.vehicle = New System.Windows.Forms.ComboBox()
        Me.contactNo = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.submit = New System.Windows.Forms.Button()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.confirmPassword = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.info = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'submit1
        '
        Me.submit1.Location = New System.Drawing.Point(815, 52)
        Me.submit1.Name = "submit1"
        Me.submit1.Size = New System.Drawing.Size(75, 23)
        Me.submit1.TabIndex = 29
        Me.submit1.Text = "Submit"
        Me.submit1.UseVisualStyleBackColor = True
        '
        'name
        '
        Me.name.AutoSize = True
        Me.name.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name.Location = New System.Drawing.Point(22, 54)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(290, 26)
        Me.name.TabIndex = 27
        Me.name.Text = "Kindly Enter User Name : "
        '
        'showPassword
        '
        Me.showPassword.AutoSize = True
        Me.showPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showPassword.ForeColor = System.Drawing.Color.White
        Me.showPassword.Location = New System.Drawing.Point(600, 5)
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
        Me.password.Location = New System.Drawing.Point(41, 25)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(116, 26)
        Me.password.TabIndex = 2
        Me.password.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(378, 32)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(349, 20)
        Me.txtPassword.TabIndex = 6
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
        'usrName
        '
        Me.usrName.Location = New System.Drawing.Point(405, 54)
        Me.usrName.Name = "usrName"
        Me.usrName.Size = New System.Drawing.Size(349, 20)
        Me.usrName.TabIndex = 28
        '
        'vehicle
        '
        Me.vehicle.FormattingEnabled = True
        Me.vehicle.Location = New System.Drawing.Point(405, 16)
        Me.vehicle.Name = "vehicle"
        Me.vehicle.Size = New System.Drawing.Size(349, 21)
        Me.vehicle.TabIndex = 23
        '
        'contactNo
        '
        Me.contactNo.AutoSize = True
        Me.contactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNo.ForeColor = System.Drawing.Color.White
        Me.contactNo.Location = New System.Drawing.Point(41, 77)
        Me.contactNo.Name = "contactNo"
        Me.contactNo.Size = New System.Drawing.Size(185, 26)
        Me.contactNo.TabIndex = 4
        Me.contactNo.Text = "Contact Number"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.AcceptsReturn = True
        Me.txtConfirmPassword.Location = New System.Drawing.Point(378, 57)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(349, 20)
        Me.txtConfirmPassword.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.submit)
        Me.Panel1.Location = New System.Drawing.Point(27, 369)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 110)
        Me.Panel1.TabIndex = 25
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
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(378, 84)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(349, 20)
        Me.txtContactNo.TabIndex = 8
        '
        'confirmPassword
        '
        Me.confirmPassword.AutoSize = True
        Me.confirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPassword.ForeColor = System.Drawing.Color.White
        Me.confirmPassword.Location = New System.Drawing.Point(41, 51)
        Me.confirmPassword.Name = "confirmPassword"
        Me.confirmPassword.Size = New System.Drawing.Size(207, 26)
        Me.confirmPassword.TabIndex = 3
        Me.confirmPassword.Text = "Confirm Password"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.showPassword)
        Me.Panel2.Controls.Add(Me.password)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Controls.Add(Me.txtContactNo)
        Me.Panel2.Controls.Add(Me.confirmPassword)
        Me.Panel2.Controls.Add(Me.contactNo)
        Me.Panel2.Controls.Add(Me.txtConfirmPassword)
        Me.Panel2.Location = New System.Drawing.Point(27, 101)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(742, 268)
        Me.Panel2.TabIndex = 26
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Location = New System.Drawing.Point(22, 16)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(334, 26)
        Me.info.TabIndex = 24
        Me.info.Text = "Please Select a vehicle type : "
        '
        'memberUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 435)
        Me.Controls.Add(Me.submit1)
        Me.Controls.Add(Me.name)
        Me.Controls.Add(Me.usrName)
        Me.Controls.Add(Me.vehicle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.info)
        ' Me.name = "memberUpdate"
        Me.Text = "memberUpdate"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents submit1 As System.Windows.Forms.Button
    Friend WithEvents name As System.Windows.Forms.Label
    Friend WithEvents showPassword As System.Windows.Forms.CheckBox
    Friend WithEvents password As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents usrName As System.Windows.Forms.TextBox
    Friend WithEvents vehicle As System.Windows.Forms.ComboBox
    Friend WithEvents contactNo As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents confirmPassword As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents info As System.Windows.Forms.Label
End Class
