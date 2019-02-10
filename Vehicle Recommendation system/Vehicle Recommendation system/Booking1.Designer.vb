<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewBooking_FullData_dgv = New System.Windows.Forms.DataGridView()
        Me.NewBooking_dgv = New System.Windows.Forms.DataGridView()
        CType(Me.NewBooking_FullData_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewBooking_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(221, 332)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'NewBooking_FullData_dgv
        '
        Me.NewBooking_FullData_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NewBooking_FullData_dgv.Location = New System.Drawing.Point(507, 119)
        Me.NewBooking_FullData_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.NewBooking_FullData_dgv.Name = "NewBooking_FullData_dgv"
        Me.NewBooking_FullData_dgv.RowTemplate.Height = 24
        Me.NewBooking_FullData_dgv.Size = New System.Drawing.Size(270, 184)
        Me.NewBooking_FullData_dgv.TabIndex = 7
        '
        'NewBooking_dgv
        '
        Me.NewBooking_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NewBooking_dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.NewBooking_dgv.Location = New System.Drawing.Point(11, 119)
        Me.NewBooking_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.NewBooking_dgv.Name = "NewBooking_dgv"
        Me.NewBooking_dgv.RowTemplate.Height = 24
        Me.NewBooking_dgv.Size = New System.Drawing.Size(492, 186)
        Me.NewBooking_dgv.TabIndex = 6
        '
        'Booking1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 500)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NewBooking_FullData_dgv)
        Me.Controls.Add(Me.NewBooking_dgv)
        Me.Name = "Booking1"
        Me.Text = "Booking1"
        CType(Me.NewBooking_FullData_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewBooking_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NewBooking_FullData_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents NewBooking_dgv As System.Windows.Forms.DataGridView
End Class
