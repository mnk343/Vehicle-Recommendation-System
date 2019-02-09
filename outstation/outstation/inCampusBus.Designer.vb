<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inCampusBus
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
        Me.t_lbl = New System.Windows.Forms.Label()
        Me.time_lbl = New System.Windows.Forms.Label()
        Me.bus_dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.d_cb = New System.Windows.Forms.Label()
        Me.s_cb = New System.Windows.Forms.ComboBox()
        Me.de_cb = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.bus_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        't_lbl
        '
        Me.t_lbl.AutoSize = True
        Me.t_lbl.Location = New System.Drawing.Point(493, 40)
        Me.t_lbl.Name = "t_lbl"
        Me.t_lbl.Size = New System.Drawing.Size(39, 17)
        Me.t_lbl.TabIndex = 0
        Me.t_lbl.Text = "Time"
        '
        'time_lbl
        '
        Me.time_lbl.AutoSize = True
        Me.time_lbl.Location = New System.Drawing.Point(562, 40)
        Me.time_lbl.Name = "time_lbl"
        Me.time_lbl.Size = New System.Drawing.Size(51, 17)
        Me.time_lbl.TabIndex = 1
        Me.time_lbl.Text = "Label1"
        '
        'bus_dgv
        '
        Me.bus_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bus_dgv.Location = New System.Drawing.Point(117, 375)
        Me.bus_dgv.Name = "bus_dgv"
        Me.bus_dgv.RowTemplate.Height = 24
        Me.bus_dgv.Size = New System.Drawing.Size(516, 150)
        Me.bus_dgv.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Source"
        '
        'd_cb
        '
        Me.d_cb.AutoSize = True
        Me.d_cb.Location = New System.Drawing.Point(405, 101)
        Me.d_cb.Name = "d_cb"
        Me.d_cb.Size = New System.Drawing.Size(79, 17)
        Me.d_cb.TabIndex = 4
        Me.d_cb.Text = "Destination"
        '
        's_cb
        '
        Me.s_cb.FormattingEnabled = True
        Me.s_cb.Location = New System.Drawing.Point(222, 105)
        Me.s_cb.Name = "s_cb"
        Me.s_cb.Size = New System.Drawing.Size(121, 24)
        Me.s_cb.TabIndex = 5
        '
        'de_cb
        '
        Me.de_cb.FormattingEnabled = True
        Me.de_cb.Location = New System.Drawing.Point(512, 98)
        Me.de_cb.Name = "de_cb"
        Me.de_cb.Size = New System.Drawing.Size(121, 24)
        Me.de_cb.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(496, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'inCampusBus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 652)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.de_cb)
        Me.Controls.Add(Me.s_cb)
        Me.Controls.Add(Me.d_cb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bus_dgv)
        Me.Controls.Add(Me.time_lbl)
        Me.Controls.Add(Me.t_lbl)
        Me.Name = "inCampusBus"
        Me.Text = "inCampusBus"
        CType(Me.bus_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents t_lbl As System.Windows.Forms.Label
    Friend WithEvents time_lbl As System.Windows.Forms.Label
    Friend WithEvents bus_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents d_cb As System.Windows.Forms.Label
    Friend WithEvents s_cb As System.Windows.Forms.ComboBox
    Friend WithEvents de_cb As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
