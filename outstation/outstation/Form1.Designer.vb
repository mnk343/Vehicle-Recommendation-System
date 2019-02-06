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
        Me.CabDataTableAdapter = New outstation.Vehicle_Recommendation_System_DatabaseDataSetTableAdapters.CabDataTableAdapter()
        Me.passengers = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.submit = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.info = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CabDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vehicle_Recommendation_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'shilong_btn
        '
        Me.shilong_btn.Location = New System.Drawing.Point(70, 24)
        Me.shilong_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.shilong_btn.Name = "shilong_btn"
        Me.shilong_btn.Size = New System.Drawing.Size(88, 26)
        Me.shilong_btn.TabIndex = 0
        Me.shilong_btn.Text = "Shilong"
        Me.shilong_btn.UseVisualStyleBackColor = True
        '
        'tawang_btn
        '
        Me.tawang_btn.Location = New System.Drawing.Point(67, 66)
        Me.tawang_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tawang_btn.Name = "tawang_btn"
        Me.tawang_btn.Size = New System.Drawing.Size(91, 27)
        Me.tawang_btn.TabIndex = 1
        Me.tawang_btn.Text = "Tawang"
        Me.tawang_btn.UseVisualStyleBackColor = True
        '
        'gang_btn
        '
        Me.gang_btn.Location = New System.Drawing.Point(67, 108)
        Me.gang_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gang_btn.Name = "gang_btn"
        Me.gang_btn.Size = New System.Drawing.Size(91, 27)
        Me.gang_btn.TabIndex = 2
        Me.gang_btn.Text = "Gangtok"
        Me.gang_btn.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(70, 182)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(771, 155)
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
        'CabDataTableAdapter
        '
        Me.CabDataTableAdapter.ClearBeforeFill = True
        '
        'passengers
        '
        Me.passengers.Location = New System.Drawing.Point(404, 70)
        Me.passengers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.passengers.Name = "passengers"
        Me.passengers.Size = New System.Drawing.Size(275, 20)
        Me.passengers.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Please Enter Number of Pasengers (optional)"
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(404, 110)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 23)
        Me.submit.TabIndex = 9
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(525, 110)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 23)
        Me.clear.TabIndex = 10
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Location = New System.Drawing.Point(304, 242)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(327, 24)
        Me.info.TabIndex = 11
        Me.info.Text = "Please Select A City to see results"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 387)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passengers)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.gang_btn)
        Me.Controls.Add(Me.tawang_btn)
        Me.Controls.Add(Me.shilong_btn)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents passengers As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents info As System.Windows.Forms.Label

End Class
