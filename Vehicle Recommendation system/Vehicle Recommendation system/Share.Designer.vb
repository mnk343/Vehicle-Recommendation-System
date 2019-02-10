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
        Me.date_lbl = New System.Windows.Forms.Label()
        Me.Share_dgv = New System.Windows.Forms.DataGridView()
        CType(Me.Share_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'date_lbl
        '
        Me.date_lbl.AutoSize = True
        Me.date_lbl.Location = New System.Drawing.Point(385, 95)
        Me.date_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.date_lbl.Name = "date_lbl"
        Me.date_lbl.Size = New System.Drawing.Size(39, 13)
        Me.date_lbl.TabIndex = 3
        Me.date_lbl.Text = "Label1"
        '
        'Share_dgv
        '
        Me.Share_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Share_dgv.Location = New System.Drawing.Point(75, 67)
        Me.Share_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.Share_dgv.Name = "Share_dgv"
        Me.Share_dgv.RowTemplate.Height = 24
        Me.Share_dgv.Size = New System.Drawing.Size(296, 145)
        Me.Share_dgv.TabIndex = 2
        '
        'Share
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 305)
        Me.Controls.Add(Me.date_lbl)
        Me.Controls.Add(Me.Share_dgv)
        Me.Name = "Share"
        Me.Text = "Share"
        CType(Me.Share_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents date_lbl As System.Windows.Forms.Label
    Friend WithEvents Share_dgv As System.Windows.Forms.DataGridView
End Class
