<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class outstation1
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
        Me.info = New System.Windows.Forms.Label()
        Me.clear = New System.Windows.Forms.Button()
        Me.submit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passengers = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.gang_btn = New System.Windows.Forms.Button()
        Me.tawang_btn = New System.Windows.Forms.Button()
        Me.shilong_btn = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Location = New System.Drawing.Point(300, 273)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(327, 24)
        Me.info.TabIndex = 29
        Me.info.Text = "Please Select A City to see results"
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(521, 141)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 23)
        Me.clear.TabIndex = 28
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(400, 141)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 23)
        Me.submit.TabIndex = 27
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(397, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Please Enter Number of Pasengers (optional)"
        '
        'passengers
        '
        Me.passengers.Location = New System.Drawing.Point(400, 101)
        Me.passengers.Margin = New System.Windows.Forms.Padding(2)
        Me.passengers.Name = "passengers"
        Me.passengers.Size = New System.Drawing.Size(275, 20)
        Me.passengers.TabIndex = 25
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(66, 213)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(771, 155)
        Me.dgvData.TabIndex = 24
        '
        'gang_btn
        '
        Me.gang_btn.Location = New System.Drawing.Point(63, 139)
        Me.gang_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.gang_btn.Name = "gang_btn"
        Me.gang_btn.Size = New System.Drawing.Size(91, 27)
        Me.gang_btn.TabIndex = 23
        Me.gang_btn.Text = "Gangtok"
        Me.gang_btn.UseVisualStyleBackColor = True
        '
        'tawang_btn
        '
        Me.tawang_btn.Location = New System.Drawing.Point(63, 97)
        Me.tawang_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.tawang_btn.Name = "tawang_btn"
        Me.tawang_btn.Size = New System.Drawing.Size(91, 27)
        Me.tawang_btn.TabIndex = 22
        Me.tawang_btn.Text = "Tawang"
        Me.tawang_btn.UseVisualStyleBackColor = True
        '
        'shilong_btn
        '
        Me.shilong_btn.Location = New System.Drawing.Point(66, 55)
        Me.shilong_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.shilong_btn.Name = "shilong_btn"
        Me.shilong_btn.Size = New System.Drawing.Size(88, 26)
        Me.shilong_btn.TabIndex = 21
        Me.shilong_btn.Text = "Shilong"
        Me.shilong_btn.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(733, 138)
        Me.back.Margin = New System.Windows.Forms.Padding(2)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(104, 26)
        Me.back.TabIndex = 30
        Me.back.Text = "Home Page"
        Me.back.UseVisualStyleBackColor = True
        '
        'outstation1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 412)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passengers)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.gang_btn)
        Me.Controls.Add(Me.tawang_btn)
        Me.Controls.Add(Me.shilong_btn)
        Me.Name = "outstation1"
        Me.Text = "outstation1"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents passengers As System.Windows.Forms.TextBox
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents gang_btn As System.Windows.Forms.Button
    Friend WithEvents tawang_btn As System.Windows.Forms.Button
    Friend WithEvents shilong_btn As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
End Class
