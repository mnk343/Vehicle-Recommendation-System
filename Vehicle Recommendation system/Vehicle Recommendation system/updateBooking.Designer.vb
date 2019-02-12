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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dc_lbl = New System.Windows.Forms.Label()
        CType(Me.book_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cid_lbl
        '
        Me.cid_lbl.AutoSize = True
        Me.cid_lbl.Location = New System.Drawing.Point(100, 380)
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
        Me.bid_lbl.Location = New System.Drawing.Point(23, 380)
        Me.bid_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bid_lbl.Name = "bid_lbl"
        Me.bid_lbl.Size = New System.Drawing.Size(39, 13)
        Me.bid_lbl.TabIndex = 4
        Me.bid_lbl.Text = "Label1"
        Me.bid_lbl.Visible = False
        '
        'book_dgv
        '
        Me.book_dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.book_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.book_dgv.Location = New System.Drawing.Point(39, 71)
        Me.book_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.book_dgv.Name = "book_dgv"
        Me.book_dgv.RowTemplate.Height = 24
        Me.book_dgv.Size = New System.Drawing.Size(410, 183)
        Me.book_dgv.TabIndex = 3
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.back.Location = New System.Drawing.Point(183, 326)
        Me.back.Margin = New System.Windows.Forms.Padding(2)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(142, 38)
        Me.back.TabIndex = 26
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dc_lbl)
        Me.Panel1.Controls.Add(Me.book_dgv)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 303)
        Me.Panel1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "No Bookings till now"
        '
        'dc_lbl
        '
        Me.dc_lbl.AutoSize = True
        Me.dc_lbl.Location = New System.Drawing.Point(39, 36)
        Me.dc_lbl.Name = "dc_lbl"
        Me.dc_lbl.Size = New System.Drawing.Size(297, 13)
        Me.dc_lbl.TabIndex = 4
        Me.dc_lbl.Text = "*Double Click on the cell to update the coresponding booking"
        '
        'updateBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(531, 413)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.cid_lbl)
        Me.Controls.Add(Me.bid_lbl)
        Me.Name = "updateBooking"
        Me.Text = "updateBooking"
        CType(Me.book_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cid_lbl As System.Windows.Forms.Label
    Friend WithEvents bid_lbl As System.Windows.Forms.Label
    Friend WithEvents book_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dc_lbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
