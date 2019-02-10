<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cab_info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cab_info))
        Me.load_btn = New System.Windows.Forms.Button()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'load_btn
        '
        Me.load_btn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.load_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.load_btn.Location = New System.Drawing.Point(353, 367)
        Me.load_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.load_btn.Name = "load_btn"
        Me.load_btn.Size = New System.Drawing.Size(92, 35)
        Me.load_btn.TabIndex = 27
        Me.load_btn.Text = "Load"
        Me.load_btn.UseVisualStyleBackColor = False
        '
        'day_cb
        '
        Me.day_cb.FormattingEnabled = True
        Me.day_cb.Location = New System.Drawing.Point(235, 178)
        Me.day_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.day_cb.Name = "day_cb"
        Me.day_cb.Size = New System.Drawing.Size(92, 21)
        Me.day_cb.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 173)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 24)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 123)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 24)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "No of passenger"
        '
        'min_tb
        '
        Me.min_tb.Location = New System.Drawing.Point(707, 129)
        Me.min_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.min_tb.Name = "min_tb"
        Me.min_tb.Size = New System.Drawing.Size(76, 20)
        Me.min_tb.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(713, 114)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Minutes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(626, 114)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Hour"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(466, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Time"
        '
        'hour_tb
        '
        Me.hour_tb.Location = New System.Drawing.Point(610, 129)
        Me.hour_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.hour_tb.Name = "hour_tb"
        Me.hour_tb.Size = New System.Drawing.Size(76, 20)
        Me.hour_tb.TabIndex = 19
        '
        'no_pass
        '
        Me.no_pass.Location = New System.Drawing.Point(235, 128)
        Me.no_pass.Margin = New System.Windows.Forms.Padding(2)
        Me.no_pass.Name = "no_pass"
        Me.no_pass.Size = New System.Drawing.Size(92, 20)
        Me.no_pass.TabIndex = 18
        '
        'des_cb
        '
        Me.des_cb.FormattingEnabled = True
        Me.des_cb.Location = New System.Drawing.Point(607, 81)
        Me.des_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.des_cb.Name = "des_cb"
        Me.des_cb.Size = New System.Drawing.Size(92, 21)
        Me.des_cb.TabIndex = 17
        '
        'src_cb
        '
        Me.src_cb.FormattingEnabled = True
        Me.src_cb.Location = New System.Drawing.Point(235, 78)
        Me.src_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.src_cb.Name = "src_cb"
        Me.src_cb.Size = New System.Drawing.Size(92, 21)
        Me.src_cb.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(466, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Destination"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Source"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.load_btn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.min_tb)
        Me.Panel1.Controls.Add(Me.day_cb)
        Me.Panel1.Controls.Add(Me.hour_tb)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.src_cb)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.des_cb)
        Me.Panel1.Controls.Add(Me.no_pass)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 461)
        Me.Panel1.TabIndex = 28
        '
        'cab_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(812, 468)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "cab_info"
        Me.Text = "cab_info"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents load_btn As System.Windows.Forms.Button
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
