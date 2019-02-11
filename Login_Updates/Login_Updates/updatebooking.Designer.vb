<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updatebooking
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
        Me.book_dgv = New System.Windows.Forms.DataGridView()
        Me.bid_lbl = New System.Windows.Forms.Label()
        Me.cid_lbl = New System.Windows.Forms.Label()
        CType(Me.book_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'book_dgv
        '
        Me.book_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.book_dgv.Location = New System.Drawing.Point(145, 85)
        Me.book_dgv.Name = "book_dgv"
        Me.book_dgv.RowTemplate.Height = 24
        Me.book_dgv.Size = New System.Drawing.Size(546, 225)
        Me.book_dgv.TabIndex = 0
        '
        'bid_lbl
        '
        Me.bid_lbl.AutoSize = True
        Me.bid_lbl.Location = New System.Drawing.Point(415, 353)
        Me.bid_lbl.Name = "bid_lbl"
        Me.bid_lbl.Size = New System.Drawing.Size(51, 17)
        Me.bid_lbl.TabIndex = 1
        Me.bid_lbl.Text = "Label1"
        Me.bid_lbl.Visible = False
        '
        'cid_lbl
        '
        Me.cid_lbl.AutoSize = True
        Me.cid_lbl.Location = New System.Drawing.Point(596, 340)
        Me.cid_lbl.Name = "cid_lbl"
        Me.cid_lbl.Size = New System.Drawing.Size(51, 17)
        Me.cid_lbl.TabIndex = 2
        Me.cid_lbl.Text = "Label1"
        Me.cid_lbl.Visible = False
        '
        'updatebooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 471)
        Me.Controls.Add(Me.cid_lbl)
        Me.Controls.Add(Me.bid_lbl)
        Me.Controls.Add(Me.book_dgv)
        Me.Name = "updatebooking"
        Me.Text = "updatebooking"
        CType(Me.book_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents book_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents bid_lbl As System.Windows.Forms.Label
    Friend WithEvents cid_lbl As System.Windows.Forms.Label
End Class
