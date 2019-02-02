<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class outCampus
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.outstn_btn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.from_city_btn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.to_city_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(60, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(885, 428)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.outstn_btn)
        Me.Panel4.Location = New System.Drawing.Point(321, 262)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(232, 100)
        Me.Panel4.TabIndex = 2
        '
        'outstn_btn
        '
        Me.outstn_btn.Location = New System.Drawing.Point(0, 0)
        Me.outstn_btn.Name = "outstn_btn"
        Me.outstn_btn.Size = New System.Drawing.Size(232, 100)
        Me.outstn_btn.TabIndex = 0
        Me.outstn_btn.Text = "Outstation"
        Me.outstn_btn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.from_city_btn)
        Me.Panel3.Location = New System.Drawing.Point(649, 106)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(198, 90)
        Me.Panel3.TabIndex = 1
        '
        'from_city_btn
        '
        Me.from_city_btn.Location = New System.Drawing.Point(3, 0)
        Me.from_city_btn.Name = "from_city_btn"
        Me.from_city_btn.Size = New System.Drawing.Size(194, 90)
        Me.from_city_btn.TabIndex = 0
        Me.from_city_btn.Text = "From City"
        Me.from_city_btn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.Controls.Add(Me.to_city_btn)
        Me.Panel2.Location = New System.Drawing.Point(15, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 0
        '
        'to_city_btn
        '
        Me.to_city_btn.Location = New System.Drawing.Point(0, 0)
        Me.to_city_btn.Name = "to_city_btn"
        Me.to_city_btn.Size = New System.Drawing.Size(200, 100)
        Me.to_city_btn.TabIndex = 0
        Me.to_city_btn.Text = "To City"
        Me.to_city_btn.UseVisualStyleBackColor = True
        '
        'outCampus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1039, 524)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "outCampus"
        Me.Text = "Out Campus"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents outstn_btn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents to_city_btn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents from_city_btn As System.Windows.Forms.Button
End Class
