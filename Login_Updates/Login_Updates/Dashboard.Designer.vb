<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.profile = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chduty = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'profile
        '
        Me.profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.profile.ForeColor = System.Drawing.Color.MediumBlue
        Me.profile.Location = New System.Drawing.Point(274, 236)
        Me.profile.Name = "profile"
        Me.profile.Size = New System.Drawing.Size(428, 47)
        Me.profile.TabIndex = 3
        Me.profile.Text = "UPDATE PROFILE"
        Me.profile.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.Button1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button1.Location = New System.Drawing.Point(274, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(428, 47)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "UPDATE BOOKING"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(170, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(639, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'chduty
        '
        Me.chduty.AutoSize = True
        Me.chduty.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.chduty.ForeColor = System.Drawing.Color.MediumBlue
        Me.chduty.Location = New System.Drawing.Point(403, 439)
        Me.chduty.Name = "chduty"
        Me.chduty.Size = New System.Drawing.Size(145, 40)
        Me.chduty.TabIndex = 21
        Me.chduty.Text = "On Duty"
        Me.chduty.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.Label1.Location = New System.Drawing.Point(295, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 36)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Hi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.Label2.Location = New System.Drawing.Point(338, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 36)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "User"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1077, 579)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chduty)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.profile)
        Me.DoubleBuffered = True
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents profile As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chduty As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
