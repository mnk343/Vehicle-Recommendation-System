<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookingPart2
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
        Me.day_cb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.min_tb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hour_tb = New System.Windows.Forms.TextBox()
        Me.no_pass = New System.Windows.Forms.TextBox()
        Me.des_cb = New System.Windows.Forms.ComboBox()
        Me.src_cb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.load_btn = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'day_cb
        '
        Me.day_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.day_cb.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.day_cb.ForeColor = System.Drawing.Color.White
        Me.day_cb.FormattingEnabled = True
        Me.day_cb.Location = New System.Drawing.Point(314, 101)
        Me.day_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.day_cb.Name = "day_cb"
        Me.day_cb.Size = New System.Drawing.Size(92, 24)
        Me.day_cb.TabIndex = 67
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(216, 104)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 16)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(20, 194)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 17)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "No of passenger"
        '
        'min_tb
        '
        Me.min_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.min_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.min_tb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min_tb.ForeColor = System.Drawing.Color.White
        Me.min_tb.Location = New System.Drawing.Point(646, 191)
        Me.min_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.min_tb.Name = "min_tb"
        Me.min_tb.Size = New System.Drawing.Size(76, 16)
        Me.min_tb.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(586, 191)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Minutes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(431, 193)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Hour"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(571, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Time"
        '
        'hour_tb
        '
        Me.hour_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.hour_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hour_tb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hour_tb.ForeColor = System.Drawing.Color.White
        Me.hour_tb.Location = New System.Drawing.Point(483, 193)
        Me.hour_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.hour_tb.Name = "hour_tb"
        Me.hour_tb.Size = New System.Drawing.Size(76, 16)
        Me.hour_tb.TabIndex = 60
        '
        'no_pass
        '
        Me.no_pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.no_pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.no_pass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_pass.ForeColor = System.Drawing.Color.White
        Me.no_pass.Location = New System.Drawing.Point(140, 192)
        Me.no_pass.Margin = New System.Windows.Forms.Padding(2)
        Me.no_pass.MaxLength = 6
        Me.no_pass.Name = "no_pass"
        Me.no_pass.Size = New System.Drawing.Size(76, 16)
        Me.no_pass.TabIndex = 59
        '
        'des_cb
        '
        Me.des_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.des_cb.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.des_cb.ForeColor = System.Drawing.Color.White
        Me.des_cb.FormattingEnabled = True
        Me.des_cb.Location = New System.Drawing.Point(527, 36)
        Me.des_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.des_cb.Name = "des_cb"
        Me.des_cb.Size = New System.Drawing.Size(92, 24)
        Me.des_cb.TabIndex = 58
        '
        'src_cb
        '
        Me.src_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.src_cb.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.src_cb.ForeColor = System.Drawing.Color.White
        Me.src_cb.FormattingEnabled = True
        Me.src_cb.Location = New System.Drawing.Point(170, 44)
        Me.src_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.src_cb.Name = "src_cb"
        Me.src_cb.Size = New System.Drawing.Size(92, 24)
        Me.src_cb.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(413, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Destination"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Source"
        '
        'load_btn
        '
        Me.load_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.load_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.load_btn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.load_btn.ForeColor = System.Drawing.Color.White
        Me.load_btn.Location = New System.Drawing.Point(527, 307)
        Me.load_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.load_btn.Name = "load_btn"
        Me.load_btn.Size = New System.Drawing.Size(76, 35)
        Me.load_btn.TabIndex = 68
        Me.load_btn.Text = "Update"
        Me.load_btn.UseVisualStyleBackColor = False
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back_btn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.ForeColor = System.Drawing.Color.White
        Me.back_btn.Location = New System.Drawing.Point(638, 311)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(57, 23)
        Me.back_btn.TabIndex = 69
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = False
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_btn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.ForeColor = System.Drawing.Color.White
        Me.delete_btn.Location = New System.Drawing.Point(418, 310)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(76, 32)
        Me.delete_btn.TabIndex = 70
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(140, 213)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(87, 1)
        Me.Panel1.TabIndex = 71
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(481, 213)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(92, 1)
        Me.Panel2.TabIndex = 72
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(646, 213)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(88, 1)
        Me.Panel3.TabIndex = 73
        '
        'bookingPart2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(788, 378)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.day_cb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.min_tb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.hour_tb)
        Me.Controls.Add(Me.no_pass)
        Me.Controls.Add(Me.des_cb)
        Me.Controls.Add(Me.src_cb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.load_btn)
        Me.Name = "bookingPart2"
        Me.Text = "bookingPart2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents day_cb As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents min_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents hour_tb As System.Windows.Forms.TextBox
    Friend WithEvents no_pass As System.Windows.Forms.TextBox
    Friend WithEvents des_cb As System.Windows.Forms.ComboBox
    Friend WithEvents src_cb As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents load_btn As System.Windows.Forms.Button
    Friend WithEvents back_btn As System.Windows.Forms.Button
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
