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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.showDist = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Booking
        '
        Me.Booking.Location = New System.Drawing.Point(740, 317)
        Me.Booking.Margin = New System.Windows.Forms.Padding(2)
        Me.Booking.Name = "Booking"
        Me.Booking.Size = New System.Drawing.Size(91, 56)
        Me.Booking.TabIndex = 6
        Me.Booking.Text = "New Booking "
        Me.Booking.UseVisualStyleBackColor = True
        '
        'Sharebtn
        '
        Me.Sharebtn.Location = New System.Drawing.Point(738, 198)
        Me.Sharebtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Sharebtn.Name = "Sharebtn"
        Me.Sharebtn.Size = New System.Drawing.Size(94, 56)
        Me.Sharebtn.TabIndex = 5
        Me.Sharebtn.Text = "Share "
        Me.Sharebtn.UseVisualStyleBackColor = True
        '
        'Distance_lbl
        '
        Me.Distance_lbl.AutoSize = True
        Me.Distance_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Distance_lbl.Location = New System.Drawing.Point(677, 68)
        Me.Distance_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Distance_lbl.Name = "Distance_lbl"
        Me.Distance_lbl.Size = New System.Drawing.Size(202, 17)
        Me.Distance_lbl.TabIndex = 4
        Me.Distance_lbl.Text = "Total Distance to be covered : "
        '
        'map_browser
        '
        Me.map_browser.AllowNavigation = False
        Me.map_browser.AllowWebBrowserDrop = False
        Me.map_browser.Location = New System.Drawing.Point(8, -1)
        Me.map_browser.Margin = New System.Windows.Forms.Padding(2)
        Me.map_browser.MinimumSize = New System.Drawing.Size(15, 16)
        Me.map_browser.Name = "map_browser"
        Me.map_browser.Size = New System.Drawing.Size(646, 472)
        Me.map_browser.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'showDist
        '
        Me.showDist.AutoSize = True
        Me.showDist.Location = New System.Drawing.Point(740, 104)
        Me.showDist.Name = "showDist"
        Me.showDist.Size = New System.Drawing.Size(39, 13)
        Me.showDist.TabIndex = 9
        Me.showDist.Text = "Label2"
        '
        'Maps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 462)
        Me.Controls.Add(Me.showDist)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.map_browser)
        Me.Controls.Add(Me.Booking)
        Me.Controls.Add(Me.Sharebtn)
        Me.Controls.Add(Me.Distance_lbl)
        Me.Name = "Maps"
        Me.Text = "Maps"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Booking As System.Windows.Forms.Button
    Friend WithEvents Sharebtn As System.Windows.Forms.Button
    Friend WithEvents Distance_lbl As System.Windows.Forms.Label
    Friend WithEvents map_browser As System.Windows.Forms.WebBrowser
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents showDist As System.Windows.Forms.Label
End Class
