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
        Me.login = New System.Windows.Forms.Button()
        Me.outstation = New System.Windows.Forms.Button()
        Me.outCampus = New System.Windows.Forms.Button()
        Me.inCampus = New System.Windows.Forms.Button()
        Me.emergency = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'login
        '
        Me.login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.Location = New System.Drawing.Point(205, 42)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(139, 42)
        Me.login.TabIndex = 0
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = True
        '
        'outstation
        '
        Me.outstation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outstation.Location = New System.Drawing.Point(56, 131)
        Me.outstation.Name = "outstation"
        Me.outstation.Size = New System.Drawing.Size(139, 42)
        Me.outstation.TabIndex = 1
        Me.outstation.Text = "Outstation"
        Me.outstation.UseVisualStyleBackColor = True
        '
        'outCampus
        '
        Me.outCampus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outCampus.Location = New System.Drawing.Point(400, 131)
        Me.outCampus.Name = "outCampus"
        Me.outCampus.Size = New System.Drawing.Size(139, 42)
        Me.outCampus.TabIndex = 2
        Me.outCampus.Text = "Out Campus"
        Me.outCampus.UseVisualStyleBackColor = True
        '
        'inCampus
        '
        Me.inCampus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inCampus.Location = New System.Drawing.Point(56, 248)
        Me.inCampus.Name = "inCampus"
        Me.inCampus.Size = New System.Drawing.Size(139, 42)
        Me.inCampus.TabIndex = 3
        Me.inCampus.Text = "In Campus"
        Me.inCampus.UseVisualStyleBackColor = True
        '
        'emergency
        '
        Me.emergency.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emergency.Location = New System.Drawing.Point(400, 248)
        Me.emergency.Name = "emergency"
        Me.emergency.Size = New System.Drawing.Size(139, 42)
        Me.emergency.TabIndex = 4
        Me.emergency.Text = "Emergency"
        Me.emergency.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 373)
        Me.Controls.Add(Me.emergency)
        Me.Controls.Add(Me.inCampus)
        Me.Controls.Add(Me.outCampus)
        Me.Controls.Add(Me.outstation)
        Me.Controls.Add(Me.login)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents login As System.Windows.Forms.Button
    Friend WithEvents outstation As System.Windows.Forms.Button
    Friend WithEvents outCampus As System.Windows.Forms.Button
    Friend WithEvents inCampus As System.Windows.Forms.Button
    Friend WithEvents emergency As System.Windows.Forms.Button

End Class
