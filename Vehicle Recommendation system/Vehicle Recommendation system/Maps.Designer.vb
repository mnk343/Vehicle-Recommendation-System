<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maps
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
        Me.Booking = New System.Windows.Forms.Button()
        Me.Sharebtn = New System.Windows.Forms.Button()
        Me.Distance_lbl = New System.Windows.Forms.Label()
        Me.map_browser = New System.Windows.Forms.WebBrowser()
        Me.showDist = New System.Windows.Forms.Label()
        Me.money = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.back = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.nb_noDatalbl = New System.Windows.Forms.Label()
        Me.hidLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewBooking_FullData_dgv = New System.Windows.Forms.DataGridView()
        Me.NewBooking_dgv = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.sc_noDatalbl = New System.Windows.Forms.Label()
        Me.date_lbl = New System.Windows.Forms.Label()
        Me.Share_dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.NewBooking_FullData_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewBooking_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Share_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Booking
        '
        Me.Booking.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Booking.Location = New System.Drawing.Point(236, 12)
        Me.Booking.Margin = New System.Windows.Forms.Padding(2)
        Me.Booking.Name = "Booking"
        Me.Booking.Size = New System.Drawing.Size(136, 77)
        Me.Booking.TabIndex = 6
        Me.Booking.Text = "New Booking "
        Me.Booking.UseVisualStyleBackColor = True
        '
        'Sharebtn
        '
        Me.Sharebtn.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sharebtn.Location = New System.Drawing.Point(23, 13)
        Me.Sharebtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Sharebtn.Name = "Sharebtn"
        Me.Sharebtn.Size = New System.Drawing.Size(161, 75)
        Me.Sharebtn.TabIndex = 5
        Me.Sharebtn.Text = "Share "
        Me.Sharebtn.UseVisualStyleBackColor = True
        '
        'Distance_lbl
        '
        Me.Distance_lbl.AutoSize = True
        Me.Distance_lbl.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Distance_lbl.ForeColor = System.Drawing.Color.White
        Me.Distance_lbl.Location = New System.Drawing.Point(27, 8)
        Me.Distance_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Distance_lbl.Name = "Distance_lbl"
        Me.Distance_lbl.Size = New System.Drawing.Size(382, 30)
        Me.Distance_lbl.TabIndex = 4
        Me.Distance_lbl.Text = "Total Distance to be covered : "
        '
        'map_browser
        '
        Me.map_browser.AllowNavigation = False
        Me.map_browser.AllowWebBrowserDrop = False
        Me.map_browser.Dock = System.Windows.Forms.DockStyle.Top
        Me.map_browser.Location = New System.Drawing.Point(0, 0)
        Me.map_browser.Margin = New System.Windows.Forms.Padding(2)
        Me.map_browser.MinimumSize = New System.Drawing.Size(15, 16)
        Me.map_browser.Name = "map_browser"
        Me.map_browser.Size = New System.Drawing.Size(1370, 404)
        Me.map_browser.TabIndex = 7
        '
        'showDist
        '
        Me.showDist.AutoSize = True
        Me.showDist.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showDist.ForeColor = System.Drawing.Color.White
        Me.showDist.Location = New System.Drawing.Point(151, 43)
        Me.showDist.Name = "showDist"
        Me.showDist.Size = New System.Drawing.Size(79, 24)
        Me.showDist.TabIndex = 9
        Me.showDist.Text = "Label2"
        '
        'money
        '
        Me.money.AutoSize = True
        Me.money.Location = New System.Drawing.Point(349, 51)
        Me.money.Name = "money"
        Me.money.Size = New System.Drawing.Size(38, 13)
        Me.money.TabIndex = 10
        Me.money.Text = "money"
        Me.money.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.showDist)
        Me.Panel1.Controls.Add(Me.Distance_lbl)
        Me.Panel1.Controls.Add(Me.money)
        Me.Panel1.Location = New System.Drawing.Point(12, 424)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 72)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.back)
        Me.Panel2.Controls.Add(Me.Sharebtn)
        Me.Panel2.Controls.Add(Me.Booking)
        Me.Panel2.Location = New System.Drawing.Point(12, 503)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(421, 184)
        Me.Panel2.TabIndex = 12
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(165, 114)
        Me.back.Margin = New System.Windows.Forms.Padding(2)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(136, 54)
        Me.back.TabIndex = 14
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel3.Controls.Add(Me.nb_noDatalbl)
        Me.Panel3.Controls.Add(Me.hidLabel)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.NewBooking_FullData_dgv)
        Me.Panel3.Controls.Add(Me.NewBooking_dgv)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(-424, 404)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(890, 283)
        Me.Panel3.TabIndex = 13
        '
        'nb_noDatalbl
        '
        Me.nb_noDatalbl.AutoSize = True
        Me.nb_noDatalbl.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nb_noDatalbl.ForeColor = System.Drawing.Color.White
        Me.nb_noDatalbl.Location = New System.Drawing.Point(511, 132)
        Me.nb_noDatalbl.Name = "nb_noDatalbl"
        Me.nb_noDatalbl.Size = New System.Drawing.Size(189, 22)
        Me.nb_noDatalbl.TabIndex = 13
        Me.nb_noDatalbl.Text = "No bookings till now"
        '
        'hidLabel
        '
        Me.hidLabel.AutoSize = True
        Me.hidLabel.Location = New System.Drawing.Point(650, 239)
        Me.hidLabel.Name = "hidLabel"
        Me.hidLabel.Size = New System.Drawing.Size(39, 13)
        Me.hidLabel.TabIndex = 12
        Me.hidLabel.Text = "Label2"
        Me.hidLabel.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 254)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        '
        'NewBooking_FullData_dgv
        '
        Me.NewBooking_FullData_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NewBooking_FullData_dgv.Location = New System.Drawing.Point(32, 262)
        Me.NewBooking_FullData_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.NewBooking_FullData_dgv.Name = "NewBooking_FullData_dgv"
        Me.NewBooking_FullData_dgv.RowTemplate.Height = 24
        Me.NewBooking_FullData_dgv.Size = New System.Drawing.Size(10, 10)
        Me.NewBooking_FullData_dgv.TabIndex = 10
        '
        'NewBooking_dgv
        '
        Me.NewBooking_dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.NewBooking_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NewBooking_dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.NewBooking_dgv.Location = New System.Drawing.Point(44, 73)
        Me.NewBooking_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.NewBooking_dgv.Name = "NewBooking_dgv"
        Me.NewBooking_dgv.ReadOnly = True
        Me.NewBooking_dgv.RowTemplate.Height = 24
        Me.NewBooking_dgv.Size = New System.Drawing.Size(784, 154)
        Me.NewBooking_dgv.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel4.Controls.Add(Me.sc_noDatalbl)
        Me.Panel4.Controls.Add(Me.date_lbl)
        Me.Panel4.Controls.Add(Me.Share_dgv)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(466, 404)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(904, 283)
        Me.Panel4.TabIndex = 12
        '
        'sc_noDatalbl
        '
        Me.sc_noDatalbl.AutoSize = True
        Me.sc_noDatalbl.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sc_noDatalbl.ForeColor = System.Drawing.Color.White
        Me.sc_noDatalbl.Location = New System.Drawing.Point(282, 132)
        Me.sc_noDatalbl.Name = "sc_noDatalbl"
        Me.sc_noDatalbl.Size = New System.Drawing.Size(211, 22)
        Me.sc_noDatalbl.TabIndex = 6
        Me.sc_noDatalbl.Text = "No Share cabs till Now"
        '
        'date_lbl
        '
        Me.date_lbl.AutoSize = True
        Me.date_lbl.Location = New System.Drawing.Point(1211, 99)
        Me.date_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.date_lbl.Name = "date_lbl"
        Me.date_lbl.Size = New System.Drawing.Size(39, 13)
        Me.date_lbl.TabIndex = 5
        Me.date_lbl.Text = "Label1"
        '
        'Share_dgv
        '
        Me.Share_dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Share_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Share_dgv.Location = New System.Drawing.Point(174, 81)
        Me.Share_dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.Share_dgv.Name = "Share_dgv"
        Me.Share_dgv.ReadOnly = True
        Me.Share_dgv.RowTemplate.Height = 24
        Me.Share_dgv.Size = New System.Drawing.Size(559, 145)
        Me.Share_dgv.TabIndex = 4
        '
        'Maps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 687)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.map_browser)
        Me.Name = "Maps"
        Me.Text = "Maps"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NewBooking_FullData_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewBooking_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Share_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Booking As System.Windows.Forms.Button
    Friend WithEvents Sharebtn As System.Windows.Forms.Button
    Friend WithEvents Distance_lbl As System.Windows.Forms.Label
    Friend WithEvents map_browser As System.Windows.Forms.WebBrowser
    Friend WithEvents showDist As System.Windows.Forms.Label
    Friend WithEvents money As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NewBooking_FullData_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents NewBooking_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents date_lbl As System.Windows.Forms.Label
    Friend WithEvents Share_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents hidLabel As System.Windows.Forms.Label
    Friend WithEvents nb_noDatalbl As System.Windows.Forms.Label
    Friend WithEvents sc_noDatalbl As System.Windows.Forms.Label
End Class
