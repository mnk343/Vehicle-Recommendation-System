<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_city_bus
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
        Me.dgv_from_city_bus = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_from_city_bus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_from_city_bus
        '
        Me.dgv_from_city_bus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_from_city_bus.Location = New System.Drawing.Point(97, 151)
        Me.dgv_from_city_bus.Name = "dgv_from_city_bus"
        Me.dgv_from_city_bus.RowTemplate.Height = 24
        Me.dgv_from_city_bus.Size = New System.Drawing.Size(828, 296)
        Me.dgv_from_city_bus.TabIndex = 0
        '
        'frm_city_bus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 512)
        Me.Controls.Add(Me.dgv_from_city_bus)
        Me.Name = "frm_city_bus"
        Me.Text = "frm_city_bus"
        CType(Me.dgv_from_city_bus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_from_city_bus As System.Windows.Forms.DataGridView
End Class
