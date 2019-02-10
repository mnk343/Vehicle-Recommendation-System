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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.CabDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vehicle_Recommendation_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.info.Location = New System.Drawing.Point(313, 260)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(327, 24)
        Me.info.TabIndex = 20
        Me.info.Text = "Please Select A City to see results"
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.Black
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.Color.White
        Me.clear.Location = New System.Drawing.Point(473, 228)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(96, 29)
        Me.clear.TabIndex = 19
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = False
        '
        'submit
        '
        Me.submit.BackColor = System.Drawing.Color.Black
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.ForeColor = System.Drawing.Color.White
        Me.submit.Location = New System.Drawing.Point(362, 228)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(85, 29)
        Me.submit.TabIndex = 18
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(269, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Please Enter Number of Pasengers (optional)"
        '
        'passengers
        '
        Me.passengers.Location = New System.Drawing.Point(317, 193)
        Me.passengers.Margin = New System.Windows.Forms.Padding(2)
        Me.passengers.Name = "passengers"
        Me.passengers.Size = New System.Drawing.Size(275, 20)
        Me.passengers.TabIndex = 16
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(73, 296)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(771, 155)
        Me.dgvData.TabIndex = 15
        '
        'gang_btn
        '
        Me.gang_btn.BackColor = System.Drawing.Color.White
        Me.gang_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gang_btn.ForeColor = System.Drawing.Color.Black
        Me.gang_btn.Location = New System.Drawing.Point(95, 8)
        Me.gang_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.gang_btn.Name = "gang_btn"
        Me.gang_btn.Size = New System.Drawing.Size(91, 38)
        Me.gang_btn.TabIndex = 14
        Me.gang_btn.Text = "Gangtok"
        Me.gang_btn.UseVisualStyleBackColor = False
        '
        'tawang_btn
        '
        Me.tawang_btn.BackColor = System.Drawing.Color.White
        Me.tawang_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tawang_btn.ForeColor = System.Drawing.Color.Black
        Me.tawang_btn.Location = New System.Drawing.Point(90, 8)
        Me.tawang_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.tawang_btn.Name = "tawang_btn"
        Me.tawang_btn.Size = New System.Drawing.Size(112, 38)
        Me.tawang_btn.TabIndex = 13
        Me.tawang_btn.Text = "Tawang"
        Me.tawang_btn.UseVisualStyleBackColor = False
        '
        'shilong_btn
        '
        Me.shilong_btn.BackColor = System.Drawing.Color.White
        Me.shilong_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.shilong_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shilong_btn.ForeColor = System.Drawing.Color.Black
        Me.shilong_btn.Location = New System.Drawing.Point(72, 8)
        Me.shilong_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.shilong_btn.Name = "shilong_btn"
        Me.shilong_btn.Size = New System.Drawing.Size(108, 38)
        Me.shilong_btn.TabIndex = 12
        Me.shilong_btn.Text = "Shilong"
        Me.shilong_btn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.shilong_btn)
        Me.Panel1.Location = New System.Drawing.Point(1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 141)
        Me.Panel1.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.tawang_btn)
        Me.Panel2.Location = New System.Drawing.Point(289, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(314, 141)
        Me.Panel2.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.gang_btn)
        Me.Panel3.Location = New System.Drawing.Point(601, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(287, 141)
        Me.Panel3.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 462)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passengers)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CabDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vehicle_Recommendation_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel

End Class
