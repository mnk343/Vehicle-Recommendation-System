<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cab_info
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.src_cb = New System.Windows.Forms.ComboBox()
        Me.des_cb = New System.Windows.Forms.ComboBox()
        Me.no_pass = New System.Windows.Forms.TextBox()
        Me.hour_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.min_tb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.day_cb = New System.Windows.Forms.ComboBox()
        Me.load_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Source"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(591, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destination"
        '
        'src_cb
        '
        Me.src_cb.FormattingEnabled = True
        Me.src_cb.Location = New System.Drawing.Point(270, 73)
        Me.src_cb.Name = "src_cb"
        Me.src_cb.Size = New System.Drawing.Size(121, 24)
        Me.src_cb.TabIndex = 2
        '
        'des_cb
        '
        Me.des_cb.FormattingEnabled = True
        Me.des_cb.Location = New System.Drawing.Point(746, 75)
        Me.des_cb.Name = "des_cb"
        Me.des_cb.Size = New System.Drawing.Size(121, 24)
        Me.des_cb.TabIndex = 3
        '
        'no_pass
        '
        Me.no_pass.Location = New System.Drawing.Point(270, 256)
        Me.no_pass.Name = "no_pass"
        Me.no_pass.Size = New System.Drawing.Size(100, 22)
        Me.no_pass.TabIndex = 4
        '
        'hour_tb
        '
        Me.hour_tb.Location = New System.Drawing.Point(746, 255)
        Me.hour_tb.Name = "hour_tb"
        Me.hour_tb.Size = New System.Drawing.Size(100, 22)
        Me.hour_tb.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(594, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(768, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Hour"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(965, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Minutes"
        '
        'min_tb
        '
        Me.min_tb.Location = New System.Drawing.Point(946, 255)
        Me.min_tb.Name = "min_tb"
        Me.min_tb.Size = New System.Drawing.Size(100, 22)
        Me.min_tb.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(103, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "No of passenger"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(106, 369)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Day"
        '
        'day_cb
        '
        Me.day_cb.FormattingEnabled = True
        Me.day_cb.Location = New System.Drawing.Point(204, 362)
        Me.day_cb.Name = "day_cb"
        Me.day_cb.Size = New System.Drawing.Size(121, 24)
        Me.day_cb.TabIndex = 12
        '
        'load_btn
        '
        Me.load_btn.Location = New System.Drawing.Point(746, 378)
        Me.load_btn.Name = "load_btn"
        Me.load_btn.Size = New System.Drawing.Size(75, 23)
        Me.load_btn.TabIndex = 13
        Me.load_btn.Text = "Load"
        Me.load_btn.UseVisualStyleBackColor = True
        '
        'Cab_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 530)
        Me.Controls.Add(Me.load_btn)
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
        Me.Name = "Cab_info"
        Me.Text = "Cab_info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents src_cb As System.Windows.Forms.ComboBox
    Friend WithEvents des_cb As System.Windows.Forms.ComboBox
    Friend WithEvents no_pass As System.Windows.Forms.TextBox
    Friend WithEvents hour_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents min_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents day_cb As System.Windows.Forms.ComboBox
    Friend WithEvents load_btn As System.Windows.Forms.Button
End Class
