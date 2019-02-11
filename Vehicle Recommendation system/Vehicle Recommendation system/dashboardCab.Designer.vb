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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'newbook
        '
        Me.newbook.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.newbook.ForeColor = System.Drawing.Color.MediumBlue
        Me.newbook.Location = New System.Drawing.Point(198, 243)
        Me.newbook.Margin = New System.Windows.Forms.Padding(2)
        Me.newbook.Name = "newbook"
        Me.newbook.Size = New System.Drawing.Size(321, 38)
        Me.newbook.TabIndex = 31
        Me.newbook.Text = "NEW BOOKING"
        Me.newbook.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.Label2.Location = New System.Drawing.Point(246, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 29)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.Label1.Location = New System.Drawing.Point(209, 111)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 29)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Hi"
        '
        'chduty
        '
        Me.chduty.AutoSize = True
        Me.chduty.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.chduty.ForeColor = System.Drawing.Color.MediumBlue
        Me.chduty.Location = New System.Drawing.Point(294, 375)
        Me.chduty.Margin = New System.Windows.Forms.Padding(2)
        Me.chduty.Name = "chduty"
        Me.chduty.Size = New System.Drawing.Size(117, 33)
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
        Me.update_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.update_btn.ForeColor = System.Drawing.Color.MediumBlue
        Me.update_btn.Location = New System.Drawing.Point(198, 309)
        Me.update_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(321, 38)
        Me.update_btn.TabIndex = 26
        Me.update_btn.Text = "UPDATE BOOKING"
        Me.update_btn.UseVisualStyleBackColor = True
        '
        'profile
        '
        Me.profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.profile.ForeColor = System.Drawing.Color.MediumBlue
        Me.profile.Location = New System.Drawing.Point(198, 181)
        Me.profile.Margin = New System.Windows.Forms.Padding(2)
        Me.profile.Name = "profile"
        Me.profile.Size = New System.Drawing.Size(321, 38)
        Me.profile.TabIndex = 25
        Me.profile.Text = "UPDATE PROFILE"
        Me.profile.UseVisualStyleBackColor = True
        '
        'dashboardCab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 440)
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
End Class
