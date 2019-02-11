<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateBooking
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
        Me.cid_lbl = New System.Windows.Forms.Label()
        Me.bid_lbl = New System.Windows.Forms.Label()
        Me.book_dgv = New System.Windows.Forms.DataGridView()
        Me.back = New System.Windows.Forms.Button()
        CType(Me.book_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cid_lbl
        '
        Me.cid_lbl.AutoSize = True
        Me.cid_lbl.Location = New System.Drawing.Point(391, 254)
        Me.cid_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cid_lbl.Name = "cid_lbl"
        Me.cid_lbl.Size = New System.Drawing.Size(39, 13)
        Me.cid_lbl.TabIndex = 5
        Me.cid_lbl.Text = "Label1"
        Me.cid_lbl.Visible = False
        '
        'bid_lbl
        '
        Me.bid_lbl.AutoSize = True
        Me.bid_lbl.Location = New System.Drawing.Point(255, 265)
        Me.bid_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bid_lbl.Name = "bid_lbl"
        Me.bid_lbl.Size = New System.Drawing.Size(39, 13)
        Me.bid_lbl.TabIndex = 4
        Me.bid_lbl.Text = "Label1"
        Me.bid_lbl.Visible = False
        '
        'book_dgv
        '
        Me.book_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.book_dgv.Location = New System.Drawing.Point(53, 47)
        Me.book_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.book_dgv.Name = "book_dgv"
        Me.book_dgv.RowTemplate.Height = 24
        Me.book_dgv.Size = New System.Drawing.Size(410, 183)
        Me.book_dgv.TabIndex = 3
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.back.ForeColor = System.Drawing.Color.MediumBlue
        Me.back.Location = New System.Drawing.Point(42, 265)
        Me.back.Margin = New System.Windows.Forms.Padding(2)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(142, 38)
        Me.back.TabIndex = 26
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'updateBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 327)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.cid_lbl)
        Me.Controls.Add(Me.bid_lbl)
        Me.Controls.Add(Me.book_dgv)
        Me.Name = "updateBooking"
        Me.Text = "updateBooking"
        CType(Me.book_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cid_lbl As System.Windows.Forms.Label
    Friend WithEvents bid_lbl As System.Windows.Forms.Label
    Friend WithEvents book_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents back As System.Windows.Forms.Button
End Class
