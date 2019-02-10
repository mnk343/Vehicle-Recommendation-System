<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class city
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
        Me.left_fill_pnl = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.from_city_lbl = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.to_city_lbl = New System.Windows.Forms.Label()
        Me.frm_header = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.to_header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.to_pnl = New System.Windows.Forms.Panel()
        Me.to_bus = New System.Windows.Forms.Button()
        Me.to_cab = New System.Windows.Forms.Button()
        Me.from_pnl = New System.Windows.Forms.Panel()
        Me.from_cab = New System.Windows.Forms.Button()
        Me.from_bus = New System.Windows.Forms.Button()
        Me.left_fill_pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.frm_header.SuspendLayout()
        Me.to_header.SuspendLayout()
        Me.to_pnl.SuspendLayout()
        Me.from_pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'left_fill_pnl
        '
        Me.left_fill_pnl.BackColor = System.Drawing.Color.Transparent
        Me.left_fill_pnl.Controls.Add(Me.Panel3)
        Me.left_fill_pnl.Controls.Add(Me.Panel2)
        Me.left_fill_pnl.Location = New System.Drawing.Point(0, 1)
        Me.left_fill_pnl.Name = "left_fill_pnl"
        Me.left_fill_pnl.Size = New System.Drawing.Size(303, 552)
        Me.left_fill_pnl.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.from_city_lbl)
        Me.Panel3.Location = New System.Drawing.Point(3, 328)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(297, 113)
        Me.Panel3.TabIndex = 0
        '
        'from_city_lbl
        '
        Me.from_city_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.from_city_lbl.Location = New System.Drawing.Point(0, 0)
        Me.from_city_lbl.Name = "from_city_lbl"
        Me.from_city_lbl.Size = New System.Drawing.Size(301, 113)
        Me.from_city_lbl.TabIndex = 1
        Me.from_city_lbl.Text = "From City"
        Me.from_city_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.to_city_lbl)
        Me.Panel2.Location = New System.Drawing.Point(3, 130)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(303, 91)
        Me.Panel2.TabIndex = 0
        '
        'to_city_lbl
        '
        Me.to_city_lbl.BackColor = System.Drawing.Color.Blue
        Me.to_city_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_city_lbl.ForeColor = System.Drawing.Color.White
        Me.to_city_lbl.Location = New System.Drawing.Point(-3, 0)
        Me.to_city_lbl.Name = "to_city_lbl"
        Me.to_city_lbl.Size = New System.Drawing.Size(306, 91)
        Me.to_city_lbl.TabIndex = 0
        Me.to_city_lbl.Text = "To City"
        Me.to_city_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_header
        '
        Me.frm_header.Controls.Add(Me.Label2)
        Me.frm_header.Location = New System.Drawing.Point(309, 1)
        Me.frm_header.Name = "frm_header"
        Me.frm_header.Size = New System.Drawing.Size(827, 74)
        Me.frm_header.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(346, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "From City"
        '
        'to_header
        '
        Me.to_header.Controls.Add(Me.Label1)
        Me.to_header.Location = New System.Drawing.Point(306, 4)
        Me.to_header.Name = "to_header"
        Me.to_header.Size = New System.Drawing.Size(827, 74)
        Me.to_header.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(359, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To City"
        '
        'to_pnl
        '
        Me.to_pnl.Controls.Add(Me.to_bus)
        Me.to_pnl.Controls.Add(Me.to_cab)
        Me.to_pnl.Location = New System.Drawing.Point(309, 78)
        Me.to_pnl.Name = "to_pnl"
        Me.to_pnl.Size = New System.Drawing.Size(826, 475)
        Me.to_pnl.TabIndex = 2
        '
        'to_bus
        '
        Me.to_bus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_bus.Location = New System.Drawing.Point(161, 220)
        Me.to_bus.Name = "to_bus"
        Me.to_bus.Size = New System.Drawing.Size(195, 87)
        Me.to_bus.TabIndex = 2
        Me.to_bus.Text = "Bus"
        Me.to_bus.UseVisualStyleBackColor = True
        '
        'to_cab
        '
        Me.to_cab.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_cab.Location = New System.Drawing.Point(480, 220)
        Me.to_cab.Name = "to_cab"
        Me.to_cab.Size = New System.Drawing.Size(182, 87)
        Me.to_cab.TabIndex = 1
        Me.to_cab.Text = "Cab"
        Me.to_cab.UseVisualStyleBackColor = True
        '
        'from_pnl
        '
        Me.from_pnl.Controls.Add(Me.from_cab)
        Me.from_pnl.Controls.Add(Me.from_bus)
        Me.from_pnl.Location = New System.Drawing.Point(310, 81)
        Me.from_pnl.Name = "from_pnl"
        Me.from_pnl.Size = New System.Drawing.Size(826, 472)
        Me.from_pnl.TabIndex = 0
        '
        'from_cab
        '
        Me.from_cab.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.from_cab.Location = New System.Drawing.Point(485, 223)
        Me.from_cab.Name = "from_cab"
        Me.from_cab.Size = New System.Drawing.Size(195, 87)
        Me.from_cab.TabIndex = 1
        Me.from_cab.Text = "Cab"
        Me.from_cab.UseVisualStyleBackColor = True
        '
        'from_bus
        '
        Me.from_bus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.from_bus.Location = New System.Drawing.Point(166, 223)
        Me.from_bus.Name = "from_bus"
        Me.from_bus.Size = New System.Drawing.Size(195, 87)
        Me.from_bus.TabIndex = 0
        Me.from_bus.Text = "Bus"
        Me.from_bus.UseVisualStyleBackColor = True
        '
        'city
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 555)
        Me.Controls.Add(Me.to_header)
        Me.Controls.Add(Me.to_pnl)
        Me.Controls.Add(Me.from_pnl)
        Me.Controls.Add(Me.frm_header)
        Me.Controls.Add(Me.left_fill_pnl)
        Me.Name = "city"
        Me.Text = "City"
        Me.left_fill_pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.frm_header.ResumeLayout(False)
        Me.frm_header.PerformLayout()
        Me.to_header.ResumeLayout(False)
        Me.to_header.PerformLayout()
        Me.to_pnl.ResumeLayout(False)
        Me.from_pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents left_fill_pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents frm_header As System.Windows.Forms.Panel
    Friend WithEvents to_pnl As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents from_pnl As System.Windows.Forms.Panel
    Friend WithEvents to_header As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents from_city_lbl As System.Windows.Forms.Label
    Friend WithEvents to_city_lbl As System.Windows.Forms.Label
    Friend WithEvents to_bus As System.Windows.Forms.Button
    Friend WithEvents to_cab As System.Windows.Forms.Button
    Friend WithEvents from_cab As System.Windows.Forms.Button
    Friend WithEvents from_bus As System.Windows.Forms.Button
End Class
