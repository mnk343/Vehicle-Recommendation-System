<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.login = New System.Windows.Forms.Button()
        Me.inCampus = New System.Windows.Forms.Button()
        Me.emergency = New System.Windows.Forms.Button()
        Me.outstation = New System.Windows.Forms.Button()
        Me.outCampus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.White
        Me.login.Dock = System.Windows.Forms.DockStyle.Top
        Me.login.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.Color.DodgerBlue
        Me.login.Location = New System.Drawing.Point(0, 0)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(596, 64)
        Me.login.TabIndex = 0
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = False
        '
        'inCampus
        '
        Me.inCampus.BackgroundImage = CType(resources.GetObject("inCampus.BackgroundImage"), System.Drawing.Image)
        Me.inCampus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inCampus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inCampus.ForeColor = System.Drawing.Color.DarkGreen
        Me.inCampus.Location = New System.Drawing.Point(0, 277)
        Me.inCampus.Name = "inCampus"
        Me.inCampus.Size = New System.Drawing.Size(316, 222)
        Me.inCampus.TabIndex = 3
        Me.inCampus.Text = "In Campus"
        Me.inCampus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.inCampus.UseVisualStyleBackColor = True
        '
        'emergency
        '
        Me.emergency.BackColor = System.Drawing.Color.Transparent
        Me.emergency.BackgroundImage = CType(resources.GetObject("emergency.BackgroundImage"), System.Drawing.Image)
        Me.emergency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.emergency.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emergency.ForeColor = System.Drawing.Color.Red
        Me.emergency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.emergency.Location = New System.Drawing.Point(312, 277)
        Me.emergency.Name = "emergency"
        Me.emergency.Size = New System.Drawing.Size(291, 222)
        Me.emergency.TabIndex = 4
        Me.emergency.Text = "Emergency"
        Me.emergency.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.emergency.UseVisualStyleBackColor = False
        '
        'outstation
        '
        Me.outstation.BackColor = System.Drawing.Color.Transparent
        Me.outstation.BackgroundImage = CType(resources.GetObject("outstation.BackgroundImage"), System.Drawing.Image)
        Me.outstation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.outstation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outstation.Location = New System.Drawing.Point(-13, 66)
        Me.outstation.Name = "outstation"
        Me.outstation.Size = New System.Drawing.Size(329, 211)
        Me.outstation.TabIndex = 1
        Me.outstation.UseVisualStyleBackColor = False
        '
        'outCampus
        '
        Me.outCampus.BackgroundImage = CType(resources.GetObject("outCampus.BackgroundImage"), System.Drawing.Image)
        Me.outCampus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.outCampus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outCampus.ForeColor = System.Drawing.Color.SkyBlue
        Me.outCampus.Location = New System.Drawing.Point(312, 68)
        Me.outCampus.Name = "outCampus"
        Me.outCampus.Size = New System.Drawing.Size(284, 209)
        Me.outCampus.TabIndex = 2
        Me.outCampus.Text = "Out Campus"
        Me.outCampus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.outCampus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 496)
        Me.Controls.Add(Me.inCampus)
        Me.Controls.Add(Me.emergency)
        Me.Controls.Add(Me.outCampus)
        Me.Controls.Add(Me.outstation)
        Me.Controls.Add(Me.login)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents login As System.Windows.Forms.Button
    Friend WithEvents inCampus As System.Windows.Forms.Button
    Friend WithEvents emergency As System.Windows.Forms.Button
    Friend WithEvents outstation As System.Windows.Forms.Button
    Friend WithEvents outCampus As System.Windows.Forms.Button

End Class
