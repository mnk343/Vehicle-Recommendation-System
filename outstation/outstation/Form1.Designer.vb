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
        Me.CabDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vehicle_Recommendation_System_DatabaseDataSet = New outstation.Vehicle_Recommendation_System_DatabaseDataSet()
        Me.CabDataTableAdapter = New outstation.Vehicle_Recommendation_System_DatabaseDataSetTableAdapters.CabDataTableAdapter()
        Me.info = New System.Windows.Forms.Label()
        Me.clear = New System.Windows.Forms.Button()
        Me.submit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passengers = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.gang_btn = New System.Windows.Forms.Button()
        Me.tawang_btn = New System.Windows.Forms.Button()
        Me.shilong_btn = New System.Windows.Forms.Button()
        CType(Me.CabDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vehicle_Recommendation_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Location = New System.Drawing.Point(309, 255)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(327, 24)
        Me.info.TabIndex = 20
        Me.info.Text = "Please Select A City to see results"
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(530, 123)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 23)
        Me.clear.TabIndex = 19
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(409, 123)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 23)
        Me.submit.TabIndex = 18
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(406, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Please Enter Number of Pasengers (optional)"
        '
        'passengers
        '
        Me.passengers.Location = New System.Drawing.Point(409, 83)
        Me.passengers.Margin = New System.Windows.Forms.Padding(2)
        Me.passengers.Name = "passengers"
        Me.passengers.Size = New System.Drawing.Size(275, 20)
        Me.passengers.TabIndex = 16
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(75, 195)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(771, 155)
        Me.dgvData.TabIndex = 15
        '
        'gang_btn
        '
        Me.gang_btn.Location = New System.Drawing.Point(72, 121)
        Me.gang_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.gang_btn.Name = "gang_btn"
        Me.gang_btn.Size = New System.Drawing.Size(91, 27)
        Me.gang_btn.TabIndex = 14
        Me.gang_btn.Text = "Gangtok"
        Me.gang_btn.UseVisualStyleBackColor = True
        '
        'tawang_btn
        '
        Me.tawang_btn.Location = New System.Drawing.Point(72, 79)
        Me.tawang_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.tawang_btn.Name = "tawang_btn"
        Me.tawang_btn.Size = New System.Drawing.Size(91, 27)
        Me.tawang_btn.TabIndex = 13
        Me.tawang_btn.Text = "Tawang"
        Me.tawang_btn.UseVisualStyleBackColor = True
        '
        'shilong_btn
        '
        Me.shilong_btn.Location = New System.Drawing.Point(75, 37)
        Me.shilong_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.shilong_btn.Name = "shilong_btn"
        Me.shilong_btn.Size = New System.Drawing.Size(88, 26)
        Me.shilong_btn.TabIndex = 12
        Me.shilong_btn.Text = "Shilong"
        Me.shilong_btn.UseVisualStyleBackColor = True
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
        CType(Me.CabDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vehicle_Recommendation_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Vehicle_Recommendation_System_DatabaseDataSet As outstation.Vehicle_Recommendation_System_DatabaseDataSet
    Friend WithEvents CabDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CabDataTableAdapter As outstation.Vehicle_Recommendation_System_DatabaseDataSetTableAdapters.CabDataTableAdapter
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents passengers As System.Windows.Forms.TextBox
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents gang_btn As System.Windows.Forms.Button
    Friend WithEvents tawang_btn As System.Windows.Forms.Button
    Friend WithEvents shilong_btn As System.Windows.Forms.Button

End Class
