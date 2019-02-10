<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_rickshaw
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
        Me.e_dgv = New System.Windows.Forms.DataGridView()
        Me.e_fullData_dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.e_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e_fullData_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'e_dgv
        '
        Me.e_dgv.AllowUserToAddRows = False
        Me.e_dgv.AllowUserToDeleteRows = False
        Me.e_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.e_dgv.Location = New System.Drawing.Point(46, 193)
        Me.e_dgv.Name = "e_dgv"
        Me.e_dgv.ReadOnly = True
        Me.e_dgv.RowTemplate.Height = 24
        Me.e_dgv.Size = New System.Drawing.Size(462, 236)
        Me.e_dgv.TabIndex = 0
        '
        'e_fullData_dgv
        '
        Me.e_fullData_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.e_fullData_dgv.Location = New System.Drawing.Point(12, 480)
        Me.e_fullData_dgv.Name = "e_fullData_dgv"
        Me.e_fullData_dgv.RowTemplate.Height = 24
        Me.e_fullData_dgv.Size = New System.Drawing.Size(10, 10)
        Me.e_fullData_dgv.TabIndex = 2
        Me.e_fullData_dgv.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 480)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(346, 142)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 23)
        Me.cmdFind.TabIndex = 4
        Me.cmdFind.Text = "Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(81, 143)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(208, 22)
        Me.txtFind.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'E_rickshaw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 502)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.e_fullData_dgv)
        Me.Controls.Add(Me.e_dgv)
        Me.Name = "E_rickshaw"
        Me.Text = "E_rickshaw"
        CType(Me.e_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e_fullData_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents e_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents e_fullData_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
