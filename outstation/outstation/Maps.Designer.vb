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
        Me.map_browser = New System.Windows.Forms.WebBrowser()
        Me.Distance_lbl = New System.Windows.Forms.Label()
        Me.Share = New System.Windows.Forms.Button()
        Me.Booking = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'map_browser
        '
        Me.map_browser.AllowNavigation = False
        Me.map_browser.AllowWebBrowserDrop = False
        Me.map_browser.Location = New System.Drawing.Point(0, 0)
        Me.map_browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.map_browser.Name = "map_browser"
        Me.map_browser.Size = New System.Drawing.Size(1040, 581)
        Me.map_browser.TabIndex = 0
        '
        'Distance_lbl
        '
        Me.Distance_lbl.AutoSize = True
        Me.Distance_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Distance_lbl.Location = New System.Drawing.Point(1066, 66)
        Me.Distance_lbl.Name = "Distance_lbl"
        Me.Distance_lbl.Size = New System.Drawing.Size(59, 20)
        Me.Distance_lbl.TabIndex = 1
        Me.Distance_lbl.Text = "Label1"
        '
        'Share
        '
        Me.Share.Location = New System.Drawing.Point(1082, 215)
        Me.Share.Name = "Share"
        Me.Share.Size = New System.Drawing.Size(126, 69)
        Me.Share.TabIndex = 2
        Me.Share.Text = "Share "
        Me.Share.UseVisualStyleBackColor = True
        '
        'Booking
        '
        Me.Booking.Location = New System.Drawing.Point(1086, 362)
        Me.Booking.Name = "Booking"
        Me.Booking.Size = New System.Drawing.Size(121, 69)
        Me.Booking.TabIndex = 3
        Me.Booking.Text = "New Booking "
        Me.Booking.UseVisualStyleBackColor = True
        '
        'Maps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 581)
        Me.Controls.Add(Me.Booking)
        Me.Controls.Add(Me.Share)
        Me.Controls.Add(Me.Distance_lbl)
        Me.Controls.Add(Me.map_browser)
        Me.Name = "Maps"
        Me.Text = "Maps"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents map_browser As System.Windows.Forms.WebBrowser
    Friend WithEvents Distance_lbl As System.Windows.Forms.Label
    Friend WithEvents Share As System.Windows.Forms.Button
    Friend WithEvents Booking As System.Windows.Forms.Button
End Class
