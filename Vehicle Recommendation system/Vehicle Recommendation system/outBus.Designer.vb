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
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.to_pnl.SuspendLayout()
        CType(Me.to_city_bus_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.from_pnl.SuspendLayout()
        CType(Me.dgv_from_city_bus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.left_fill_pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.from_city_lbl)
        Me.Panel3.Location = New System.Drawing.Point(2, 266)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(223, 92)
        Me.Panel3.TabIndex = 0
        '
        'from_city_lbl
        '
        Me.from_city_lbl.BackColor = System.Drawing.Color.White
        Me.from_city_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.from_city_lbl.ForeColor = System.Drawing.Color.Black
        Me.from_city_lbl.Location = New System.Drawing.Point(0, 27)
        Me.from_city_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.from_city_lbl.Name = "from_city_lbl"
        Me.from_city_lbl.Size = New System.Drawing.Size(226, 65)
        Me.from_city_lbl.TabIndex = 1
        Me.from_city_lbl.Text = "From City"
        Me.from_city_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.to_city_lbl)
        Me.Panel2.Location = New System.Drawing.Point(2, 106)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(227, 74)
        Me.Panel2.TabIndex = 0
        '
        'to_city_lbl
        '
        Me.to_city_lbl.BackColor = System.Drawing.Color.White
        Me.to_city_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_city_lbl.ForeColor = System.Drawing.Color.Black
        Me.to_city_lbl.Location = New System.Drawing.Point(-2, 0)
        Me.to_city_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.to_city_lbl.Name = "to_city_lbl"
        Me.to_city_lbl.Size = New System.Drawing.Size(230, 59)
        Me.to_city_lbl.TabIndex = 0
        Me.to_city_lbl.Text = "To City"
        Me.to_city_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'to_pnl
        '
        Me.to_pnl.BackColor = System.Drawing.Color.GreenYellow
        Me.to_pnl.Controls.Add(Me.to_city_bus_dgv)
        Me.to_pnl.Location = New System.Drawing.Point(235, 53)
        Me.to_pnl.Margin = New System.Windows.Forms.Padding(2)
        Me.to_pnl.Name = "to_pnl"
        Me.to_pnl.Size = New System.Drawing.Size(618, 386)
        Me.to_pnl.TabIndex = 9
        '
        'to_city_bus_dgv
        '
        Me.to_city_bus_dgv.AllowUserToAddRows = False
        Me.to_city_bus_dgv.AllowUserToDeleteRows = False
        Me.to_city_bus_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.to_city_bus_dgv.Location = New System.Drawing.Point(169, 122)
        Me.to_city_bus_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.to_city_bus_dgv.MultiSelect = False
        Me.to_city_bus_dgv.Name = "to_city_bus_dgv"
        Me.to_city_bus_dgv.ReadOnly = True
        Me.to_city_bus_dgv.RowTemplate.Height = 24
        Me.to_city_bus_dgv.Size = New System.Drawing.Size(324, 157)
        Me.to_city_bus_dgv.TabIndex = 5
        '
        'from_pnl
        '
        Me.from_pnl.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.from_pnl.Controls.Add(Me.dgv_from_city_bus)
        Me.from_pnl.Location = New System.Drawing.Point(233, 63)
        Me.from_pnl.Margin = New System.Windows.Forms.Padding(2)
        Me.from_pnl.Name = "from_pnl"
        Me.from_pnl.Size = New System.Drawing.Size(620, 384)
        Me.from_pnl.TabIndex = 7
        '
        'dgv_from_city_bus
        '
        Me.dgv_from_city_bus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_from_city_bus.Location = New System.Drawing.Point(171, 112)
        Me.dgv_from_city_bus.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_from_city_bus.Name = "dgv_from_city_bus"
        Me.dgv_from_city_bus.RowTemplate.Height = 24
        Me.dgv_from_city_bus.Size = New System.Drawing.Size(326, 159)
        Me.dgv_from_city_bus.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(436, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "TIME "
        '
        'time_lbl
        '
        Me.time_lbl.AutoSize = True
        Me.time_lbl.BackColor = System.Drawing.Color.Black
        Me.time_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_lbl.ForeColor = System.Drawing.Color.White
        Me.time_lbl.Location = New System.Drawing.Point(559, 9)
        Me.time_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.time_lbl.Name = "time_lbl"
        Me.time_lbl.Size = New System.Drawing.Size(71, 25)
        Me.time_lbl.TabIndex = 10
        Me.time_lbl.Text = "Label2"
        '
        'left_fill_pnl
        '
        Me.left_fill_pnl.BackColor = System.Drawing.Color.Black
        Me.left_fill_pnl.Controls.Add(Me.Panel3)
        Me.left_fill_pnl.Controls.Add(Me.Panel2)
        Me.left_fill_pnl.Location = New System.Drawing.Point(1, -1)
        Me.left_fill_pnl.Margin = New System.Windows.Forms.Padding(2)
        Me.left_fill_pnl.Name = "left_fill_pnl"
        Me.left_fill_pnl.Size = New System.Drawing.Size(227, 448)
        Me.left_fill_pnl.TabIndex = 8
        '
        'outBus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 450)
        Me.Controls.Add(Me.from_pnl)
        Me.Controls.Add(Me.to_pnl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.time_lbl)
        Me.Controls.Add(Me.left_fill_pnl)
        Me.Name = "outBus"
        Me.Text = "outBus"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.to_pnl.ResumeLayout(False)
        CType(Me.to_city_bus_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.from_pnl.ResumeLayout(False)
        CType(Me.dgv_from_city_bus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.left_fill_pnl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
