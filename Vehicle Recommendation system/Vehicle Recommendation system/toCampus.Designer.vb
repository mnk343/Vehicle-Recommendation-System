<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class toCampus
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.erickshaw = New System.Windows.Forms.Button()
        Me.bus = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.de_cb = New System.Windows.Forms.ComboBox()
        Me.s_cb = New System.Windows.Forms.ComboBox()
        Me.d_cb = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bus_dgv = New System.Windows.Forms.DataGridView()
        Me.time_lbl = New System.Windows.Forms.Label()
        Me.t_lbl = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.e_fullData_dgv = New System.Windows.Forms.DataGridView()
        Me.e_dgv = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.bus_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.e_fullData_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panel1.Controls.Add(Me.erickshaw)
        Me.panel1.Controls.Add(Me.bus)
        Me.panel1.Location = New System.Drawing.Point(1, 1)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(297, 540)
        Me.panel1.TabIndex = 0
        '
        'erickshaw
        '
        Me.erickshaw.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erickshaw.Location = New System.Drawing.Point(47, 234)
        Me.erickshaw.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.erickshaw.Name = "erickshaw"
        Me.erickshaw.Size = New System.Drawing.Size(196, 54)
        Me.erickshaw.TabIndex = 1
        Me.erickshaw.Text = "E - Rickshaw"
        Me.erickshaw.UseVisualStyleBackColor = True
        '
        'bus
        '
        Me.bus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bus.Location = New System.Drawing.Point(47, 127)
        Me.bus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bus.Name = "bus"
        Me.bus.Size = New System.Drawing.Size(196, 54)
        Me.bus.TabIndex = 0
        Me.bus.Text = "Bus"
        Me.bus.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.de_cb)
        Me.Panel2.Controls.Add(Me.s_cb)
        Me.Panel2.Controls.Add(Me.d_cb)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.bus_dgv)
        Me.Panel2.Controls.Add(Me.time_lbl)
        Me.Panel2.Controls.Add(Me.t_lbl)
        Me.Panel2.Location = New System.Drawing.Point(306, 8)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(605, 533)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(301, 159)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Sumbit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'de_cb
        '
        Me.de_cb.FormattingEnabled = True
        Me.de_cb.Location = New System.Drawing.Point(460, 86)
        Me.de_cb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.de_cb.Name = "de_cb"
        Me.de_cb.Size = New System.Drawing.Size(121, 24)
        Me.de_cb.TabIndex = 14
        '
        's_cb
        '
        Me.s_cb.FormattingEnabled = True
        Me.s_cb.Location = New System.Drawing.Point(169, 92)
        Me.s_cb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.s_cb.Name = "s_cb"
        Me.s_cb.Size = New System.Drawing.Size(121, 24)
        Me.s_cb.TabIndex = 13
        '
        'd_cb
        '
        Me.d_cb.AutoSize = True
        Me.d_cb.Location = New System.Drawing.Point(353, 89)
        Me.d_cb.Name = "d_cb"
        Me.d_cb.Size = New System.Drawing.Size(79, 17)
        Me.d_cb.TabIndex = 12
        Me.d_cb.Text = "Destination"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Source"
        '
        'bus_dgv
        '
        Me.bus_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bus_dgv.Location = New System.Drawing.Point(46, 309)
        Me.bus_dgv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bus_dgv.Name = "bus_dgv"
        Me.bus_dgv.RowTemplate.Height = 24
        Me.bus_dgv.Size = New System.Drawing.Size(516, 150)
        Me.bus_dgv.TabIndex = 10
        '
        'time_lbl
        '
        Me.time_lbl.AutoSize = True
        Me.time_lbl.Location = New System.Drawing.Point(511, 27)
        Me.time_lbl.Name = "time_lbl"
        Me.time_lbl.Size = New System.Drawing.Size(51, 17)
        Me.time_lbl.TabIndex = 9
        Me.time_lbl.Text = "Label1"
        '
        't_lbl
        '
        Me.t_lbl.AutoSize = True
        Me.t_lbl.Location = New System.Drawing.Point(441, 27)
        Me.t_lbl.Name = "t_lbl"
        Me.t_lbl.Size = New System.Drawing.Size(39, 17)
        Me.t_lbl.TabIndex = 8
        Me.t_lbl.Text = "Time"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.e_fullData_dgv)
        Me.Panel3.Controls.Add(Me.e_dgv)
        Me.Panel3.Location = New System.Drawing.Point(323, 1)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(599, 540)
        Me.Panel3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'e_fullData_dgv
        '
        Me.e_fullData_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.e_fullData_dgv.Location = New System.Drawing.Point(81, 482)
        Me.e_fullData_dgv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.e_fullData_dgv.Name = "e_fullData_dgv"
        Me.e_fullData_dgv.RowTemplate.Height = 24
        Me.e_fullData_dgv.Size = New System.Drawing.Size(11, 12)
        Me.e_fullData_dgv.TabIndex = 8
        Me.e_fullData_dgv.Visible = False
        '
        'e_dgv
        '
        Me.e_dgv.AllowUserToAddRows = False
        Me.e_dgv.AllowUserToDeleteRows = False
        Me.e_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.e_dgv.Location = New System.Drawing.Point(81, 127)
        Me.e_dgv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.e_dgv.Name = "e_dgv"
        Me.e_dgv.ReadOnly = True
        Me.e_dgv.RowTemplate.Height = 24
        Me.e_dgv.Size = New System.Drawing.Size(461, 236)
        Me.e_dgv.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "* Double click on Cell to Get Directions"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "No Bus Aviable right now"
        '
        'toCampus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 545)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "toCampus"
        Me.Text = "toCampus"
        Me.panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.bus_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.e_fullData_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents erickshaw As System.Windows.Forms.Button
    Friend WithEvents bus As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents de_cb As System.Windows.Forms.ComboBox
    Friend WithEvents s_cb As System.Windows.Forms.ComboBox
    Friend WithEvents d_cb As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bus_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents time_lbl As System.Windows.Forms.Label
    Friend WithEvents t_lbl As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents e_fullData_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents e_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
