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
        Me.SuspendLayout()
        '
        'vehicle
        '
        Me.vehicle.FormattingEnabled = True
        Me.vehicle.Location = New System.Drawing.Point(49, 12)
        Me.vehicle.Name = "vehicle"
        Me.vehicle.Size = New System.Drawing.Size(121, 21)
        Me.vehicle.TabIndex = 0
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userName.Location = New System.Drawing.Point(12, 55)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(119, 25)
        Me.userName.TabIndex = 1
        Me.userName.Text = "User Name"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(12, 105)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(106, 25)
        Me.password.TabIndex = 2
        Me.password.Text = "Password"
        '
        'confirmPassword
        '
        Me.confirmPassword.AutoSize = True
        Me.confirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPassword.Location = New System.Drawing.Point(12, 157)
        Me.confirmPassword.Name = "confirmPassword"
        Me.confirmPassword.Size = New System.Drawing.Size(186, 25)
        Me.confirmPassword.TabIndex = 3
        Me.confirmPassword.Text = "Confirm Password"
        '
        'contactNo
        '
        Me.contactNo.AutoSize = True
        Me.contactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNo.Location = New System.Drawing.Point(12, 216)
        Me.contactNo.Name = "contactNo"
        Me.contactNo.Size = New System.Drawing.Size(167, 25)
        Me.contactNo.TabIndex = 4
        Me.contactNo.Text = "Contact Number"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 466)
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
End Class
