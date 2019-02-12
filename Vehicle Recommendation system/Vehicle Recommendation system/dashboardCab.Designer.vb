<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboardCab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboardCab))
        Me.newbook = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chduty = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.profile = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'newbook
        '
        Me.newbook.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.newbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newbook.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newbook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.newbook.Location = New System.Drawing.Point(198, 243)
        Me.newbook.Margin = New System.Windows.Forms.Padding(2)
        Me.newbook.Name = "newbook"
        Me.newbook.Size = New System.Drawing.Size(321, 38)
        Me.newbook.TabIndex = 31
        Me.newbook.Text = "NEW BOOKING"
        Me.newbook.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(347, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 27)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(289, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 27)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Hi"
        '
        'chduty
        '
        Me.chduty.AutoSize = True
        Me.chduty.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chduty.ForeColor = System.Drawing.Color.White
        Me.chduty.Location = New System.Drawing.Point(294, 375)
        Me.chduty.Margin = New System.Windows.Forms.Padding(2)
        Me.chduty.Name = "chduty"
        Me.chduty.Size = New System.Drawing.Size(121, 31)
        Me.chduty.TabIndex = 28
        Me.chduty.Text = "On Duty"
        Me.chduty.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(120, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(479, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'update_btn
        '
        Me.update_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update_btn.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.update_btn.Location = New System.Drawing.Point(198, 309)
        Me.update_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(321, 38)
        Me.update_btn.TabIndex = 26
        Me.update_btn.Text = "UPDATE BOOKING"
        Me.update_btn.UseVisualStyleBackColor = False
        '
        'profile
        '
        Me.profile.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.profile.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.profile.Location = New System.Drawing.Point(198, 181)
        Me.profile.Margin = New System.Windows.Forms.Padding(2)
        Me.profile.Name = "profile"
        Me.profile.Size = New System.Drawing.Size(321, 38)
        Me.profile.TabIndex = 25
        Me.profile.Text = "UPDATE PROFILE"
        Me.profile.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.back.Location = New System.Drawing.Point(558, 224)
        Me.back.Margin = New System.Windows.Forms.Padding(2)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(174, 38)
        Me.back.TabIndex = 32
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = False
        '
        'dashboardCab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(743, 440)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.newbook)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chduty)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.update_btn)
        Me.Controls.Add(Me.profile)
        Me.Name = "dashboardCab"
        Me.Text = "dashboardCab"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents newbook As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chduty As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents update_btn As System.Windows.Forms.Button
    Friend WithEvents profile As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
End Class
