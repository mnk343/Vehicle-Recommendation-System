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
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.e_fullData_dgv = New System.Windows.Forms.DataGridView()
        Me.e_dgv = New System.Windows.Forms.DataGridView()
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
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(223, 439)
        Me.panel1.TabIndex = 0
        '
        'erickshaw
        '
        Me.erickshaw.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erickshaw.Location = New System.Drawing.Point(35, 190)
        Me.erickshaw.Name = "erickshaw"
        Me.erickshaw.Size = New System.Drawing.Size(147, 44)
        Me.erickshaw.TabIndex = 1
        Me.erickshaw.Text = "E - Rickshaw"
        Me.erickshaw.UseVisualStyleBackColor = True
        '
        'bus
        '
        Me.bus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bus.Location = New System.Drawing.Point(35, 103)
        Me.bus.Name = "bus"
        Me.bus.Size = New System.Drawing.Size(147, 44)
        Me.bus.TabIndex = 0
        Me.bus.Text = "Bus"
        Me.bus.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.de_cb)
        Me.Panel2.Controls.Add(Me.s_cb)
        Me.Panel2.Controls.Add(Me.d_cb)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.bus_dgv)
        Me.Panel2.Controls.Add(Me.time_lbl)
        Me.Panel2.Controls.Add(Me.t_lbl)
        Me.Panel2.Location = New System.Drawing.Point(230, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(454, 433)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(333, 173)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 19)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'de_cb
        '
        Me.de_cb.FormattingEnabled = True
        Me.de_cb.Location = New System.Drawing.Point(345, 70)
        Me.de_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.de_cb.Name = "de_cb"
        Me.de_cb.Size = New System.Drawing.Size(92, 21)
        Me.de_cb.TabIndex = 14
        '
        's_cb
        '
        Me.s_cb.FormattingEnabled = True
        Me.s_cb.Location = New System.Drawing.Point(127, 75)
        Me.s_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.s_cb.Name = "s_cb"
        Me.s_cb.Size = New System.Drawing.Size(92, 21)
        Me.s_cb.TabIndex = 13
        '
        'd_cb
        '
        Me.d_cb.AutoSize = True
        Me.d_cb.Location = New System.Drawing.Point(265, 72)
        Me.d_cb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.d_cb.Name = "d_cb"
        Me.d_cb.Size = New System.Drawing.Size(60, 13)
        Me.d_cb.TabIndex = 12
        Me.d_cb.Text = "Destination"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Source"
        '
        'bus_dgv
        '
        Me.bus_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bus_dgv.Location = New System.Drawing.Point(49, 295)
        Me.bus_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.bus_dgv.Name = "bus_dgv"
        Me.bus_dgv.RowTemplate.Height = 24
        Me.bus_dgv.Size = New System.Drawing.Size(387, 122)
        Me.bus_dgv.TabIndex = 10
        '
        'time_lbl
        '
        Me.time_lbl.AutoSize = True
        Me.time_lbl.Location = New System.Drawing.Point(383, 22)
        Me.time_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.time_lbl.Name = "time_lbl"
        Me.time_lbl.Size = New System.Drawing.Size(39, 13)
        Me.time_lbl.TabIndex = 9
        Me.time_lbl.Text = "Label1"
        '
        't_lbl
        '
        Me.t_lbl.AutoSize = True
        Me.t_lbl.Location = New System.Drawing.Point(331, 22)
        Me.t_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.t_lbl.Name = "t_lbl"
        Me.t_lbl.Size = New System.Drawing.Size(30, 13)
        Me.t_lbl.TabIndex = 8
        Me.t_lbl.Text = "Time"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtFind)
        Me.Panel3.Controls.Add(Me.cmdFind)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.e_fullData_dgv)
        Me.Panel3.Controls.Add(Me.e_dgv)
        Me.Panel3.Location = New System.Drawing.Point(247, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(449, 439)
        Me.Panel3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Label2"
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(88, 62)
        Me.txtFind.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(157, 20)
        Me.txtFind.TabIndex = 11
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(287, 61)
        Me.cmdFind.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(56, 19)
        Me.cmdFind.TabIndex = 10
        Me.cmdFind.Text = "Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 336)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'e_fullData_dgv
        '
        Me.e_fullData_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.e_fullData_dgv.Location = New System.Drawing.Point(61, 361)
        Me.e_fullData_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.e_fullData_dgv.Name = "e_fullData_dgv"
        Me.e_fullData_dgv.RowTemplate.Height = 24
        Me.e_fullData_dgv.Size = New System.Drawing.Size(8, 10)
        Me.e_fullData_dgv.TabIndex = 8
        Me.e_fullData_dgv.Visible = False
        '
        'e_dgv
        '
        Me.e_dgv.AllowUserToAddRows = False
        Me.e_dgv.AllowUserToDeleteRows = False
        Me.e_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.e_dgv.Location = New System.Drawing.Point(61, 103)
        Me.e_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.e_dgv.Name = "e_dgv"
        Me.e_dgv.ReadOnly = True
        Me.e_dgv.RowTemplate.Height = 24
        Me.e_dgv.Size = New System.Drawing.Size(346, 192)
        Me.e_dgv.TabIndex = 7
        '
        'toCampus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 443)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel1)
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
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents e_fullData_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents e_dgv As System.Windows.Forms.DataGridView
End Class
