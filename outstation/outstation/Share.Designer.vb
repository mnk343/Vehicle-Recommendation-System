<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Share
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
        Me.Share_dgv = New System.Windows.Forms.DataGridView()
        Me.date_lbl = New System.Windows.Forms.Label()
        CType(Me.Share_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Share_dgv
        '
        Me.Share_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Share_dgv.Location = New System.Drawing.Point(72, 54)
        Me.Share_dgv.Name = "Share_dgv"
        Me.Share_dgv.RowTemplate.Height = 24
        Me.Share_dgv.Size = New System.Drawing.Size(394, 178)
        Me.Share_dgv.TabIndex = 0
        '
        'date_lbl
        '
        Me.date_lbl.AutoSize = True
        Me.date_lbl.Location = New System.Drawing.Point(485, 89)
        Me.date_lbl.Name = "date_lbl"
        Me.date_lbl.Size = New System.Drawing.Size(51, 17)
        Me.date_lbl.TabIndex = 1
        Me.date_lbl.Text = "Label1"
        '
        'Share
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 324)
        Me.Controls.Add(Me.date_lbl)
        Me.Controls.Add(Me.Share_dgv)
        Me.Name = "Share"
        Me.Text = "Share"
        CType(Me.Share_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Share_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents date_lbl As System.Windows.Forms.Label
End Class
