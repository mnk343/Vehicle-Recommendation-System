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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.password = New System.Windows.Forms.Label()
        Me.confirmPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.showPassword = New System.Windows.Forms.CheckBox()
        Me.changePassword = New System.Windows.Forms.Button()
        Me.prevPage = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Museo Sans For Dell", 14.2!, System.Drawing.FontStyle.Bold)
        Me.password.Location = New System.Drawing.Point(270, 263)
        Me.password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(121, 28)
        Me.password.TabIndex = 0
        Me.password.Text = "Password"
        '
        'confirmPassword
        '
        Me.confirmPassword.AutoSize = True
        Me.confirmPassword.Font = New System.Drawing.Font("Museo Sans For Dell", 14.2!, System.Drawing.FontStyle.Bold)
        Me.confirmPassword.Location = New System.Drawing.Point(270, 333)
        Me.confirmPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.confirmPassword.Name = "confirmPassword"
        Me.confirmPassword.Size = New System.Drawing.Size(220, 28)
        Me.confirmPassword.TabIndex = 1
        Me.confirmPassword.Text = "Confirm Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(586, 269)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(274, 22)
        Me.txtPassword.TabIndex = 2
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(586, 333)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(274, 22)
        Me.txtConfirmPassword.TabIndex = 3
        '
        'showPassword
        '
        Me.showPassword.AutoSize = True
        Me.showPassword.Font = New System.Drawing.Font("Museo Sans For Dell", 10.0!, System.Drawing.FontStyle.Bold)
        Me.showPassword.Location = New System.Drawing.Point(704, 370)
        Me.showPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(156, 24)
        Me.showPassword.TabIndex = 4
        Me.showPassword.Text = "Show Password"
        Me.showPassword.UseVisualStyleBackColor = True
        '
        'changePassword
        '
        Me.changePassword.BackColor = System.Drawing.Color.Black
        Me.changePassword.Font = New System.Drawing.Font("Museo Sans For Dell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changePassword.ForeColor = System.Drawing.Color.White
        Me.changePassword.Location = New System.Drawing.Point(433, 431)
        Me.changePassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.changePassword.Name = "changePassword"
        Me.changePassword.Size = New System.Drawing.Size(256, 70)
        Me.changePassword.TabIndex = 5
        Me.changePassword.Text = "Change Password"
        Me.changePassword.UseVisualStyleBackColor = False
        '
        'prevPage
        '
        Me.prevPage.BackColor = System.Drawing.Color.White
        Me.prevPage.Font = New System.Drawing.Font("Museo Sans For Dell", 16.2!, System.Drawing.FontStyle.Bold)
        Me.prevPage.ForeColor = System.Drawing.Color.Black
        Me.prevPage.Location = New System.Drawing.Point(1, 216)
        Me.prevPage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.prevPage.Name = "prevPage"
        Me.prevPage.Size = New System.Drawing.Size(241, 75)
        Me.prevPage.TabIndex = 6
        Me.prevPage.Text = "Previous Page"
        Me.prevPage.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 216)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(1, 289)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(241, 228)
        Me.Panel2.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(433, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 514)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.prevPage)
        Me.Controls.Add(Me.changePassword)
        Me.Controls.Add(Me.showPassword)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.confirmPassword)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
