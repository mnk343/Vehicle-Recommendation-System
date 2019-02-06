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
        Me.SuspendLayout()
        '
        'map_browser
        '
        Me.map_browser.AllowNavigation = False
        Me.map_browser.AllowWebBrowserDrop = False
        Me.map_browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.map_browser.Location = New System.Drawing.Point(0, 0)
        Me.map_browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.map_browser.Name = "map_browser"
        Me.map_browser.Size = New System.Drawing.Size(1311, 581)
        Me.map_browser.TabIndex = 0
        '
        'Maps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 581)
        Me.Controls.Add(Me.map_browser)
        Me.Name = "Maps"
        Me.Text = "Maps"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents map_browser As System.Windows.Forms.WebBrowser
End Class
