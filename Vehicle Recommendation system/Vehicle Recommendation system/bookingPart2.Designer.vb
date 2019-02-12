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
        Me.SuspendLayout()
        '
        'day_cb
        '
        Me.day_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.day_cb.FormattingEnabled = True
        Me.day_cb.Location = New System.Drawing.Point(121, 280)
        Me.day_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.day_cb.Name = "day_cb"
        Me.day_cb.Size = New System.Drawing.Size(92, 21)
        Me.day_cb.TabIndex = 67
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 285)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 193)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "No of passenger"
        '
        'min_tb
        '
        Me.min_tb.Location = New System.Drawing.Point(677, 193)
        Me.min_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.min_tb.Name = "min_tb"
        Me.min_tb.Size = New System.Drawing.Size(76, 20)
        Me.min_tb.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(692, 167)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Minutes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(544, 167)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Hour"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(413, 196)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Time"
        '
        'hour_tb
        '
        Me.hour_tb.Location = New System.Drawing.Point(527, 193)
        Me.hour_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.hour_tb.Name = "hour_tb"
        Me.hour_tb.Size = New System.Drawing.Size(76, 20)
        Me.hour_tb.TabIndex = 60
        '
        'no_pass
        '
        Me.no_pass.Location = New System.Drawing.Point(170, 194)
        Me.no_pass.Margin = New System.Windows.Forms.Padding(2)
        Me.no_pass.Name = "no_pass"
        Me.no_pass.Size = New System.Drawing.Size(76, 20)
        Me.no_pass.TabIndex = 59
        '
        'des_cb
        '
        Me.des_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.des_cb.FormattingEnabled = True
        Me.des_cb.Location = New System.Drawing.Point(527, 47)
        Me.des_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.des_cb.Name = "des_cb"
        Me.des_cb.Size = New System.Drawing.Size(92, 21)
        Me.des_cb.TabIndex = 58
        '
        'src_cb
        '
        Me.src_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.src_cb.FormattingEnabled = True
        Me.src_cb.Location = New System.Drawing.Point(170, 44)
        Me.src_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.src_cb.Name = "src_cb"
        Me.src_cb.Size = New System.Drawing.Size(92, 21)
        Me.src_cb.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(411, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Destination"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Source"
        '
        'load_btn
        '
        Me.load_btn.Location = New System.Drawing.Point(527, 307)
        Me.load_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.load_btn.Name = "load_btn"
        Me.load_btn.Size = New System.Drawing.Size(56, 19)
        Me.load_btn.TabIndex = 68
        Me.load_btn.Text = "Update"
        Me.load_btn.UseVisualStyleBackColor = True
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(638, 311)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(57, 23)
        Me.back_btn.TabIndex = 69
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Location = New System.Drawing.Point(418, 310)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(76, 32)
        Me.delete_btn.TabIndex = 70
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'bookingPart2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 378)
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
End Class
