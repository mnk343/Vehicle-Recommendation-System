<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_Rickshawdashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_Rickshawdashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.profile = New System.Windows.Forms.Button()
        Me.chduty = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.Label1.Location = New System.Drawing.Point(289, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 36)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Hi"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(113, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(639, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.Label2.Location = New System.Drawing.Point(380, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 36)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "User"
        '
        'profile
        '
        Me.profile.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.profile.ForeColor = System.Drawing.Color.MediumBlue
        Me.profile.Location = New System.Drawing.Point(208, 228)
        Me.profile.Name = "profile"
        Me.profile.Size = New System.Drawing.Size(428, 47)
        Me.profile.TabIndex = 26
        Me.profile.Text = "UPDATE PROFILE"
        Me.profile.UseVisualStyleBackColor = True
        '
        'chduty
        '
        Me.chduty.AutoSize = True
        Me.chduty.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.chduty.ForeColor = System.Drawing.Color.MediumBlue
        Me.chduty.Location = New System.Drawing.Point(326, 344)
        Me.chduty.Name = "chduty"
        Me.chduty.Size = New System.Drawing.Size(145, 40)
        Me.chduty.TabIndex = 27
        Me.chduty.Text = "On Duty"
        Me.chduty.UseVisualStyleBackColor = True
        '
        'E_Rickshawdashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 463)
        Me.Controls.Add(Me.chduty)
        Me.Controls.Add(Me.profile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "E_Rickshawdashboard"
        Me.Text = "E_Rickshawdashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents profile As System.Windows.Forms.Button
    Friend WithEvents chduty As System.Windows.Forms.CheckBox
End Class
