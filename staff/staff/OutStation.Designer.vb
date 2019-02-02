<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutStation
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Vehicle_Recommendation_System_DatabaseDataSet = New staff.Vehicle_Recommendation_System_DatabaseDataSet()
        Me.VehicleRecommendationSystemDatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarHireDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarHireDataTableAdapter = New staff.Vehicle_Recommendation_System_DatabaseDataSetTableAdapters.CarHireDataTableAdapter()
        Me.CarHireDataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OwnerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vehicle_Recommendation_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleRecommendationSystemDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarHireDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarHireDataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.OwnerNameDataGridViewTextBoxColumn, Me.MobileDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CarHireDataBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(263, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(490, 257)
        Me.DataGridView1.TabIndex = 4
        '
        'Vehicle_Recommendation_System_DatabaseDataSet
        '
        Me.Vehicle_Recommendation_System_DatabaseDataSet.DataSetName = "Vehicle_Recommendation_System_DatabaseDataSet"
        Me.Vehicle_Recommendation_System_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehicleRecommendationSystemDatabaseDataSetBindingSource
        '
        Me.VehicleRecommendationSystemDatabaseDataSetBindingSource.DataSource = Me.Vehicle_Recommendation_System_DatabaseDataSet
        Me.VehicleRecommendationSystemDatabaseDataSetBindingSource.Position = 0
        '
        'CarHireDataBindingSource
        '
        Me.CarHireDataBindingSource.DataMember = "CarHireData"
        Me.CarHireDataBindingSource.DataSource = Me.VehicleRecommendationSystemDatabaseDataSetBindingSource
        '
        'CarHireDataTableAdapter
        '
        Me.CarHireDataTableAdapter.ClearBeforeFill = True
        '
        'CarHireDataBindingSource1
        '
        Me.CarHireDataBindingSource1.DataMember = "CarHireData"
        Me.CarHireDataBindingSource1.DataSource = Me.VehicleRecommendationSystemDatabaseDataSetBindingSource
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'OwnerNameDataGridViewTextBoxColumn
        '
        Me.OwnerNameDataGridViewTextBoxColumn.DataPropertyName = "Owner Name"
        Me.OwnerNameDataGridViewTextBoxColumn.HeaderText = "Owner Name"
        Me.OwnerNameDataGridViewTextBoxColumn.Name = "OwnerNameDataGridViewTextBoxColumn"
        '
        'MobileDataGridViewTextBoxColumn
        '
        Me.MobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile"
        Me.MobileDataGridViewTextBoxColumn.HeaderText = "Mobile"
        Me.MobileDataGridViewTextBoxColumn.Name = "MobileDataGridViewTextBoxColumn"
        '
        'OutStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 563)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "OutStation"
        Me.Text = "OutStation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vehicle_Recommendation_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleRecommendationSystemDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarHireDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarHireDataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VehicleRecommendationSystemDatabaseDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vehicle_Recommendation_System_DatabaseDataSet As staff.Vehicle_Recommendation_System_DatabaseDataSet
    Friend WithEvents CarHireDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CarHireDataTableAdapter As staff.Vehicle_Recommendation_System_DatabaseDataSetTableAdapters.CarHireDataTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OwnerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarHireDataBindingSource1 As System.Windows.Forms.BindingSource
End Class
