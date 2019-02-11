<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class outBus
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.from_city_lbl = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.to_city_lbl = New System.Windows.Forms.Label()
        Me.to_pnl = New System.Windows.Forms.Panel()
        Me.to_city_bus_dgv = New System.Windows.Forms.DataGridView()
        Me.from_pnl = New System.Windows.Forms.Panel()
        Me.dgv_from_city_bus = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.time_lbl = New System.Windows.Forms.Label()
        Me.left_fill_pnl = New System.Windows.Forms.Panel()
        Me.back = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.to_pnl.SuspendLayout()
        CType(Me.to_city_bus_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.from_pnl.SuspendLayout()
        CType(Me.dgv_from_city_bus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.left_fill_pnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.back)
        Me.Panel3.Location = New System.Drawing.Point(2, 266)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(223, 92)
        Me.Panel3.TabIndex = 0
        '
        'from_city_lbl
        '
        Me.from_city_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.from_city_lbl.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.from_city_lbl.ForeColor = System.Drawing.Color.White
        Me.from_city_lbl.Location = New System.Drawing.Point(2, 174)
        Me.from_city_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.from_city_lbl.Name = "from_city_lbl"
        Me.from_city_lbl.Size = New System.Drawing.Size(226, 65)
        Me.from_city_lbl.TabIndex = 1
        Me.from_city_lbl.Text = "From City"
        Me.from_city_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(2, 106)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(227, 74)
        Me.Panel2.TabIndex = 0
        '
        'to_city_lbl
        '
        Me.to_city_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.to_city_lbl.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_city_lbl.ForeColor = System.Drawing.Color.White
        Me.to_city_lbl.Location = New System.Drawing.Point(-3, 74)
        Me.to_city_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.to_city_lbl.Name = "to_city_lbl"
        Me.to_city_lbl.Size = New System.Drawing.Size(230, 59)
        Me.to_city_lbl.TabIndex = 0
        Me.to_city_lbl.Text = "To City"
        Me.to_city_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'to_pnl
        '
        Me.to_pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.to_pnl.Controls.Add(Me.to_city_bus_dgv)
        Me.to_pnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.to_pnl.Location = New System.Drawing.Point(223, 81)
        Me.to_pnl.Margin = New System.Windows.Forms.Padding(2)
        Me.to_pnl.Name = "to_pnl"
        Me.to_pnl.Size = New System.Drawing.Size(782, 400)
        Me.to_pnl.TabIndex = 9
        '
        'to_city_bus_dgv
        '
        Me.to_city_bus_dgv.AllowUserToAddRows = False
        Me.to_city_bus_dgv.AllowUserToDeleteRows = False
        Me.to_city_bus_dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.to_city_bus_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.to_city_bus_dgv.Location = New System.Drawing.Point(145, 140)
        Me.to_city_bus_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.to_city_bus_dgv.MultiSelect = False
        Me.to_city_bus_dgv.Name = "to_city_bus_dgv"
        Me.to_city_bus_dgv.ReadOnly = True
        Me.to_city_bus_dgv.RowTemplate.Height = 24
        Me.to_city_bus_dgv.Size = New System.Drawing.Size(592, 157)
        Me.to_city_bus_dgv.TabIndex = 5
        '
        'from_pnl
        '
        Me.from_pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.from_pnl.Controls.Add(Me.dgv_from_city_bus)
        Me.from_pnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.from_pnl.Location = New System.Drawing.Point(1005, 81)
        Me.from_pnl.Margin = New System.Windows.Forms.Padding(2)
        Me.from_pnl.Name = "from_pnl"
        Me.from_pnl.Size = New System.Drawing.Size(832, 400)
        Me.from_pnl.TabIndex = 7
        '
        'dgv_from_city_bus
        '
        Me.dgv_from_city_bus.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.dgv_from_city_bus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_from_city_bus.Location = New System.Drawing.Point(138, 140)
        Me.dgv_from_city_bus.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_from_city_bus.Name = "dgv_from_city_bus"
        Me.dgv_from_city_bus.RowTemplate.Height = 24
        Me.dgv_from_city_bus.Size = New System.Drawing.Size(589, 159)
        Me.dgv_from_city_bus.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(193, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "TIME "
        '
        'time_lbl
        '
        Me.time_lbl.AutoSize = True
        Me.time_lbl.BackColor = System.Drawing.Color.Transparent
        Me.time_lbl.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_lbl.ForeColor = System.Drawing.Color.Black
        Me.time_lbl.Location = New System.Drawing.Point(362, 23)
        Me.time_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.time_lbl.Name = "time_lbl"
        Me.time_lbl.Size = New System.Drawing.Size(79, 24)
        Me.time_lbl.TabIndex = 10
        Me.time_lbl.Text = "Label2"
        '
        'left_fill_pnl
        '
        Me.left_fill_pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.left_fill_pnl.Controls.Add(Me.to_city_lbl)
        Me.left_fill_pnl.Controls.Add(Me.Panel3)
        Me.left_fill_pnl.Controls.Add(Me.from_city_lbl)
        Me.left_fill_pnl.Controls.Add(Me.Panel2)
        Me.left_fill_pnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.left_fill_pnl.Location = New System.Drawing.Point(0, 0)
        Me.left_fill_pnl.Margin = New System.Windows.Forms.Padding(2)
        Me.left_fill_pnl.Name = "left_fill_pnl"
        Me.left_fill_pnl.Size = New System.Drawing.Size(223, 481)
        Me.left_fill_pnl.TabIndex = 8
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.back.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.White
        Me.back.Location = New System.Drawing.Point(0, 18)
        Me.back.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(226, 65)
        Me.back.TabIndex = 2
        Me.back.Text = "Home Page"
        Me.back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.time_lbl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(223, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 81)
        Me.Panel1.TabIndex = 12
        '
        'outBus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 481)
        Me.Controls.Add(Me.from_pnl)
        Me.Controls.Add(Me.to_pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.left_fill_pnl)
        Me.Name = "outBus"
        Me.Text = "outBus"
        Me.Panel3.ResumeLayout(False)
        Me.to_pnl.ResumeLayout(False)
        CType(Me.to_city_bus_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.from_pnl.ResumeLayout(False)
        CType(Me.dgv_from_city_bus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.left_fill_pnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents from_city_lbl As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents to_city_lbl As System.Windows.Forms.Label
    Friend WithEvents to_pnl As System.Windows.Forms.Panel
    Friend WithEvents to_city_bus_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents from_pnl As System.Windows.Forms.Panel
    Friend WithEvents dgv_from_city_bus As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents time_lbl As System.Windows.Forms.Label
    Friend WithEvents left_fill_pnl As System.Windows.Forms.Panel
    Friend WithEvents back As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
