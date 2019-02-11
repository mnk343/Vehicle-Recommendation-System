<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class toCampus
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
        Me.doubleClick = New System.Windows.Forms.Label()
        Me.e_fullData_dgv = New System.Windows.Forms.DataGridView()
        Me.erickshaw = New System.Windows.Forms.Button()
        Me.lblSugg = New System.Windows.Forms.Label()
        Me.bus = New System.Windows.Forms.Button()
        Me.lblInfoBus = New System.Windows.Forms.Label()
        Me.btnSubmitBus = New System.Windows.Forms.Button()
        Me.s_cb = New System.Windows.Forms.ComboBox()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.bus_dgv = New System.Windows.Forms.DataGridView()
        Me.t_lbl = New System.Windows.Forms.Label()
        Me.e_dgv = New System.Windows.Forms.DataGridView()
        Me.de_cb = New System.Windows.Forms.ComboBox()
        Me.d_cb = New System.Windows.Forms.Label()
        Me.time_lbl = New System.Windows.Forms.Label()
        Me.panelERickshaw = New System.Windows.Forms.Panel()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.panelBus = New System.Windows.Forms.Panel()
        Me.panel1 = New System.Windows.Forms.Panel()
        CType(Me.e_fullData_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bus_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelERickshaw.SuspendLayout()
        Me.panelBus.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'doubleClick
        '
        Me.doubleClick.AutoSize = True
        Me.doubleClick.Location = New System.Drawing.Point(62, 320)
        Me.doubleClick.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.doubleClick.Name = "doubleClick"
        Me.doubleClick.Size = New System.Drawing.Size(190, 13)
        Me.doubleClick.TabIndex = 13
        Me.doubleClick.Text = "* Double click on Cell to Get Directions"
        '
        'e_fullData_dgv
        '
        Me.e_fullData_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.e_fullData_dgv.Location = New System.Drawing.Point(61, 392)
        Me.e_fullData_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.e_fullData_dgv.Name = "e_fullData_dgv"
        Me.e_fullData_dgv.RowTemplate.Height = 24
        Me.e_fullData_dgv.Size = New System.Drawing.Size(8, 10)
        Me.e_fullData_dgv.TabIndex = 8
        Me.e_fullData_dgv.Visible = False
        '
        'erickshaw
        '
        Me.erickshaw.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erickshaw.Location = New System.Drawing.Point(35, 190)
        Me.erickshaw.Name = "erickshaw"
        Me.erickshaw.Size = New System.Drawing.Size(147, 44)
        Me.erickshaw.TabIndex = 1
        Me.erickshaw.Text = "E - Rickshaw"
        Me.erickshaw.UseVisualStyleBackColor = True
        '
        'lblSugg
        '
        Me.lblSugg.AutoSize = True
        Me.lblSugg.Location = New System.Drawing.Point(75, 25)
        Me.lblSugg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSugg.Name = "lblSugg"
        Me.lblSugg.Size = New System.Drawing.Size(42, 13)
        Me.lblSugg.TabIndex = 12
        Me.lblSugg.Text = "lblSugg"
        '
        'bus
        '
        Me.bus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bus.Location = New System.Drawing.Point(35, 103)
        Me.bus.Name = "bus"
        Me.bus.Size = New System.Drawing.Size(147, 44)
        Me.bus.TabIndex = 0
        Me.bus.Text = "Bus"
        Me.bus.UseVisualStyleBackColor = True
        '
        'lblInfoBus
        '
        Me.lblInfoBus.AutoSize = True
        Me.lblInfoBus.Location = New System.Drawing.Point(158, 314)
        Me.lblInfoBus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfoBus.Name = "lblInfoBus"
        Me.lblInfoBus.Size = New System.Drawing.Size(126, 13)
        Me.lblInfoBus.TabIndex = 16
        Me.lblInfoBus.Text = "No Bus Aviable right now"
        '
        'btnSubmitBus
        '
        Me.btnSubmitBus.Location = New System.Drawing.Point(226, 129)
        Me.btnSubmitBus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmitBus.Name = "btnSubmitBus"
        Me.btnSubmitBus.Size = New System.Drawing.Size(56, 19)
        Me.btnSubmitBus.TabIndex = 15
        Me.btnSubmitBus.Text = "Sumbit"
        Me.btnSubmitBus.UseVisualStyleBackColor = True
        '
        's_cb
        '
        Me.s_cb.FormattingEnabled = True
        Me.s_cb.Location = New System.Drawing.Point(127, 75)
        Me.s_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.s_cb.Name = "s_cb"
        Me.s_cb.Size = New System.Drawing.Size(92, 21)
        Me.s_cb.TabIndex = 13
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(61, 75)
        Me.lblSource.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(41, 13)
        Me.lblSource.TabIndex = 11
        Me.lblSource.Text = "Source"
        '
        'bus_dgv
        '
        Me.bus_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bus_dgv.Location = New System.Drawing.Point(34, 251)
        Me.bus_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.bus_dgv.Name = "bus_dgv"
        Me.bus_dgv.RowTemplate.Height = 24
        Me.bus_dgv.Size = New System.Drawing.Size(387, 122)
        Me.bus_dgv.TabIndex = 10
        '
        't_lbl
        '
        Me.t_lbl.AutoSize = True
        Me.t_lbl.Location = New System.Drawing.Point(331, 22)
        Me.t_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.t_lbl.Name = "t_lbl"
        Me.t_lbl.Size = New System.Drawing.Size(30, 13)
        Me.t_lbl.TabIndex = 8
        Me.t_lbl.Text = "Time"
        '
        'e_dgv
        '
        Me.e_dgv.AllowUserToAddRows = False
        Me.e_dgv.AllowUserToDeleteRows = False
        Me.e_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.e_dgv.Location = New System.Drawing.Point(61, 103)
        Me.e_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.e_dgv.Name = "e_dgv"
        Me.e_dgv.ReadOnly = True
        Me.e_dgv.RowTemplate.Height = 24
        Me.e_dgv.Size = New System.Drawing.Size(346, 192)
        Me.e_dgv.TabIndex = 7
        '
        'de_cb
        '
        Me.de_cb.FormattingEnabled = True
        Me.de_cb.Location = New System.Drawing.Point(345, 70)
        Me.de_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.de_cb.Name = "de_cb"
        Me.de_cb.Size = New System.Drawing.Size(92, 21)
        Me.de_cb.TabIndex = 14
        '
        'd_cb
        '
        Me.d_cb.AutoSize = True
        Me.d_cb.Location = New System.Drawing.Point(265, 72)
        Me.d_cb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.d_cb.Name = "d_cb"
        Me.d_cb.Size = New System.Drawing.Size(60, 13)
        Me.d_cb.TabIndex = 12
        Me.d_cb.Text = "Destination"
        '
        'time_lbl
        '
        Me.time_lbl.AutoSize = True
        Me.time_lbl.Location = New System.Drawing.Point(383, 22)
        Me.time_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.time_lbl.Name = "time_lbl"
        Me.time_lbl.Size = New System.Drawing.Size(39, 13)
        Me.time_lbl.TabIndex = 9
        Me.time_lbl.Text = "Label1"
        '
        'panelERickshaw
        '
        Me.panelERickshaw.Controls.Add(Me.doubleClick)
        Me.panelERickshaw.Controls.Add(Me.lblSugg)
        Me.panelERickshaw.Controls.Add(Me.lblTemp)
        Me.panelERickshaw.Controls.Add(Me.e_fullData_dgv)
        Me.panelERickshaw.Controls.Add(Me.e_dgv)
        Me.panelERickshaw.Location = New System.Drawing.Point(790, 436)
        Me.panelERickshaw.Name = "panelERickshaw"
        Me.panelERickshaw.Size = New System.Drawing.Size(24, 31)
        Me.panelERickshaw.TabIndex = 5
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(99, 388)
        Me.lblTemp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(44, 13)
        Me.lblTemp.TabIndex = 9
        Me.lblTemp.Text = "lblTemp"
        Me.lblTemp.Visible = False
        '
        'panelBus
        '
        Me.panelBus.Controls.Add(Me.lblInfoBus)
        Me.panelBus.Controls.Add(Me.btnSubmitBus)
        Me.panelBus.Controls.Add(Me.de_cb)
        Me.panelBus.Controls.Add(Me.s_cb)
        Me.panelBus.Controls.Add(Me.d_cb)
        Me.panelBus.Controls.Add(Me.lblSource)
        Me.panelBus.Controls.Add(Me.bus_dgv)
        Me.panelBus.Controls.Add(Me.time_lbl)
        Me.panelBus.Controls.Add(Me.t_lbl)
        Me.panelBus.Location = New System.Drawing.Point(229, 6)
        Me.panelBus.Name = "panelBus"
        Me.panelBus.Size = New System.Drawing.Size(516, 461)
        Me.panelBus.TabIndex = 4
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panel1.Controls.Add(Me.erickshaw)
        Me.panel1.Controls.Add(Me.bus)
        Me.panel1.Location = New System.Drawing.Point(0, 1)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(223, 439)
        Me.panel1.TabIndex = 3
        '
        'toCampus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 558)
        Me.Controls.Add(Me.panelERickshaw)
        Me.Controls.Add(Me.panelBus)
        Me.Controls.Add(Me.panel1)
        Me.Name = "toCampus"
        Me.Text = "toCampus"
        CType(Me.e_fullData_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bus_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelERickshaw.ResumeLayout(False)
        Me.panelERickshaw.PerformLayout()
        Me.panelBus.ResumeLayout(False)
        Me.panelBus.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents doubleClick As System.Windows.Forms.Label
    Friend WithEvents e_fullData_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents erickshaw As System.Windows.Forms.Button
    Friend WithEvents lblSugg As System.Windows.Forms.Label
    Friend WithEvents bus As System.Windows.Forms.Button
    Friend WithEvents lblInfoBus As System.Windows.Forms.Label
    Friend WithEvents btnSubmitBus As System.Windows.Forms.Button
    Friend WithEvents s_cb As System.Windows.Forms.ComboBox
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents bus_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents t_lbl As System.Windows.Forms.Label
    Friend WithEvents e_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents de_cb As System.Windows.Forms.ComboBox
    Friend WithEvents d_cb As System.Windows.Forms.Label
    Friend WithEvents time_lbl As System.Windows.Forms.Label
    Friend WithEvents panelERickshaw As System.Windows.Forms.Panel
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents panelBus As System.Windows.Forms.Panel
    Friend WithEvents panel1 As System.Windows.Forms.Panel
End Class
