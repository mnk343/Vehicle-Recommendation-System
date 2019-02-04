<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.shilong_btn = New System.Windows.Forms.Button()
        Me.tawang_btn = New System.Windows.Forms.Button()
        Me.gang_btn = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.CabDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vehicle_Recommendation_System_DatabaseDataSet = New outstation.Vehicle_Recommendation_System_DatabaseDataSet()
        Me.find_text_box = New System.Windows.Forms.TextBox()
        Me.find_outstation_btn = New System.Windows.Forms.Button()
        Me.CabDataTableAdapter = New outstation.Vehicle_Recommendation_System_DatabaseDataSetTableAdapters.CabDataTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CabDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vehicle_Recommendation_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'shilong_btn
        '
        Me.shilong_btn.Location = New System.Drawing.Point(94, 105)
        Me.shilong_btn.Name = "shilong_btn"
        Me.shilong_btn.Size = New System.Drawing.Size(117, 32)
        Me.shilong_btn.TabIndex = 0
        Me.shilong_btn.Text = "Shilong"
        Me.shilong_btn.UseVisualStyleBackColor = True
        '
        'tawang_btn
        '
        Me.tawang_btn.Location = New System.Drawing.Point(294, 104)
        Me.tawang_btn.Name = "tawang_btn"
        Me.tawang_btn.Size = New System.Drawing.Size(112, 33)
        Me.tawang_btn.TabIndex = 1
        Me.tawang_btn.Text = "Tawang"
        Me.tawang_btn.UseVisualStyleBackColor = True
        '
        'gang_btn
        '
        Me.gang_btn.Location = New System.Drawing.Point(497, 104)
        Me.gang_btn.Name = "gang_btn"
        Me.gang_btn.Size = New System.Drawing.Size(121, 33)
        Me.gang_btn.TabIndex = 2
        Me.gang_btn.Text = "gangtok"
        Me.gang_btn.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(94, 224)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(506, 191)
        Me.dgvData.TabIndex = 3
        '
        'CabDataBindingSource
        '
        Me.CabDataBindingSource.DataMember = "CabData"
        Me.CabDataBindingSource.DataSource = Me.Vehicle_Recommendation_System_DatabaseDataSet
        '
        'Vehicle_Recommendation_System_DatabaseDataSet
        '
        Me.Vehicle_Recommendation_System_DatabaseDataSet.DataSetName = "Vehicle_Recommendation_System_DatabaseDataSet"
        Me.Vehicle_Recommendation_System_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'find_text_box
        '
        Me.find_text_box.Location = New System.Drawing.Point(94, 171)
        Me.find_text_box.Name = "find_text_box"
        Me.find_text_box.Size = New System.Drawing.Size(165, 22)
        Me.find_text_box.TabIndex = 4
        '
        'find_outstation_btn
        '
        Me.find_outstation_btn.Location = New System.Drawing.Point(294, 161)
        Me.find_outstation_btn.Name = "find_outstation_btn"
        Me.find_outstation_btn.Size = New System.Drawing.Size(75, 32)
        Me.find_outstation_btn.TabIndex = 5
        Me.find_outstation_btn.Text = "Find"
        Me.find_outstation_btn.UseVisualStyleBackColor = True
        '
        'CabDataTableAdapter
        '
        Me.CabDataTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(675, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Passenger"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(458, 176)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 22)
        Me.TextBox1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 476)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.find_outstation_btn)
        Me.Controls.Add(Me.find_text_box)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.gang_btn)
        Me.Controls.Add(Me.tawang_btn)
        Me.Controls.Add(Me.shilong_btn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CabDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vehicle_Recommendation_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents shilong_btn As System.Windows.Forms.Button
    Friend WithEvents tawang_btn As System.Windows.Forms.Button
    Friend WithEvents gang_btn As System.Windows.Forms.Button
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents Vehicle_Recommendation_System_DatabaseDataSet As outstation.Vehicle_Recommendation_System_DatabaseDataSet
    Friend WithEvents CabDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CabDataTableAdapter As outstation.Vehicle_Recommendation_System_DatabaseDataSetTableAdapters.CabDataTableAdapter
    Friend WithEvents find_text_box As System.Windows.Forms.TextBox
    Friend WithEvents find_outstation_btn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
