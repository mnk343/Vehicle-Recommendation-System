<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingCab
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
        Me.NewBooking_dgv = New System.Windows.Forms.DataGridView()
        Me.NewBooking_FullData_dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.NewBooking_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewBooking_FullData_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewBooking_dgv
        '
        Me.NewBooking_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NewBooking_dgv.Location = New System.Drawing.Point(102, 60)
        Me.NewBooking_dgv.Name = "NewBooking_dgv"
        Me.NewBooking_dgv.RowTemplate.Height = 24
        Me.NewBooking_dgv.Size = New System.Drawing.Size(469, 229)
        Me.NewBooking_dgv.TabIndex = 0
        '
        'NewBooking_FullData_dgv
        '
        Me.NewBooking_FullData_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NewBooking_FullData_dgv.Location = New System.Drawing.Point(742, 61)
        Me.NewBooking_FullData_dgv.Name = "NewBooking_FullData_dgv"
        Me.NewBooking_FullData_dgv.RowTemplate.Height = 24
        Me.NewBooking_FullData_dgv.Size = New System.Drawing.Size(360, 227)
        Me.NewBooking_FullData_dgv.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(475, 326)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'BookingCab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 375)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NewBooking_FullData_dgv)
        Me.Controls.Add(Me.NewBooking_dgv)
        Me.Name = "BookingCab"
        Me.Text = "BookingCab"
        CType(Me.NewBooking_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewBooking_FullData_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewBooking_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents NewBooking_FullData_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
