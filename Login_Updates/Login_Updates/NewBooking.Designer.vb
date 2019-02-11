<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBooking
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
        Me._Vehicle_Recommendation_System_DatabaseDataSet1 = New WindowsApplication1._Vehicle_Recommendation_System_DatabaseDataSet()
        Me.load_btn = New System.Windows.Forms.Button()
        CType(Me._Vehicle_Recommendation_System_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'day_cb
        '
        Me.day_cb.FormattingEnabled = True
        Me.day_cb.Location = New System.Drawing.Point(136, 412)
        Me.day_cb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.day_cb.Name = "day_cb"
        Me.day_cb.Size = New System.Drawing.Size(121, 24)
        Me.day_cb.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 419)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 17)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 17)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "No of passenger"
        '
        'min_tb
        '
        Me.min_tb.Location = New System.Drawing.Point(878, 305)
        Me.min_tb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.min_tb.Name = "min_tb"
        Me.min_tb.Size = New System.Drawing.Size(100, 22)
        Me.min_tb.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(897, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Minutes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(700, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Hour"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(526, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Time"
        '
        'hour_tb
        '
        Me.hour_tb.Location = New System.Drawing.Point(678, 305)
        Me.hour_tb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.hour_tb.Name = "hour_tb"
        Me.hour_tb.Size = New System.Drawing.Size(100, 22)
        Me.hour_tb.TabIndex = 32
        '
        'no_pass
        '
        Me.no_pass.Location = New System.Drawing.Point(201, 306)
        Me.no_pass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.no_pass.Name = "no_pass"
        Me.no_pass.Size = New System.Drawing.Size(100, 22)
        Me.no_pass.TabIndex = 31
        '
        'des_cb
        '
        Me.des_cb.FormattingEnabled = True
        Me.des_cb.Location = New System.Drawing.Point(678, 125)
        Me.des_cb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.des_cb.Name = "des_cb"
        Me.des_cb.Size = New System.Drawing.Size(121, 24)
        Me.des_cb.TabIndex = 30
        '
        'src_cb
        '
        Me.src_cb.FormattingEnabled = True
        Me.src_cb.Location = New System.Drawing.Point(201, 122)
        Me.src_cb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.src_cb.Name = "src_cb"
        Me.src_cb.Size = New System.Drawing.Size(121, 24)
        Me.src_cb.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(522, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Destination"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Source"
        '
        '_Vehicle_Recommendation_System_DatabaseDataSet1
        '
        Me._Vehicle_Recommendation_System_DatabaseDataSet1.DataSetName = "_Vehicle_Recommendation_System_DatabaseDataSet"
        Me._Vehicle_Recommendation_System_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'load_btn
        '
        Me.load_btn.Location = New System.Drawing.Point(460, 370)
        Me.load_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.load_btn.Name = "load_btn"
        Me.load_btn.Size = New System.Drawing.Size(75, 23)
        Me.load_btn.TabIndex = 40
        Me.load_btn.Text = "Submit"
        Me.load_btn.UseVisualStyleBackColor = True
        '
        'NewBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 612)
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
        Me.Name = "NewBooking"
        Me.Text = "New Booking"
        CType(Me._Vehicle_Recommendation_System_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents _Vehicle_Recommendation_System_DatabaseDataSet1 As WindowsApplication1._Vehicle_Recommendation_System_DatabaseDataSet
    Friend WithEvents load_btn As System.Windows.Forms.Button
End Class
