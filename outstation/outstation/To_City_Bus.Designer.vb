<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class To_City_Bus
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
        Me.time_lbl = New System.Windows.Forms.Label()
        Me.clk_lbl = New System.Windows.Forms.Label()
        Me.to_city_bus_dgv = New System.Windows.Forms.DataGridView()
        CType(Me.to_city_bus_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'time_lbl
        '
        Me.time_lbl.AutoSize = True
        Me.time_lbl.Location = New System.Drawing.Point(801, 34)
        Me.time_lbl.Name = "time_lbl"
        Me.time_lbl.Size = New System.Drawing.Size(39, 17)
        Me.time_lbl.TabIndex = 0
        Me.time_lbl.Text = "Time"
        '
        'clk_lbl
        '
        Me.clk_lbl.AutoSize = True
        Me.clk_lbl.Location = New System.Drawing.Point(873, 34)
        Me.clk_lbl.Name = "clk_lbl"
        Me.clk_lbl.Size = New System.Drawing.Size(51, 17)
        Me.clk_lbl.TabIndex = 1
        Me.clk_lbl.Text = "Label2"
        '
        'to_city_bus_dgv
        '
        Me.to_city_bus_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.to_city_bus_dgv.Location = New System.Drawing.Point(171, 184)
        Me.to_city_bus_dgv.Name = "to_city_bus_dgv"
        Me.to_city_bus_dgv.RowTemplate.Height = 24
        Me.to_city_bus_dgv.Size = New System.Drawing.Size(695, 267)
        Me.to_city_bus_dgv.TabIndex = 2
        '
        'To_City_Bus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 494)
        Me.Controls.Add(Me.to_city_bus_dgv)
        Me.Controls.Add(Me.clk_lbl)
        Me.Controls.Add(Me.time_lbl)
        Me.Name = "To_City_Bus"
        Me.Text = "To_City_Bus"
        CType(Me.to_city_bus_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents time_lbl As System.Windows.Forms.Label
    Friend WithEvents clk_lbl As System.Windows.Forms.Label
    Friend WithEvents to_city_bus_dgv As System.Windows.Forms.DataGridView
End Class
