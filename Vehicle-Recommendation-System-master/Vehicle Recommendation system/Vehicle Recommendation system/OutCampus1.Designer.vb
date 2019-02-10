<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutCampus1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OutCampus1))
        Me.bus = New System.Windows.Forms.Button()
        Me.cab = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bus
        '
        Me.bus.BackColor = System.Drawing.Color.Black
        Me.bus.BackgroundImage = CType(resources.GetObject("bus.BackgroundImage"), System.Drawing.Image)
        Me.bus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bus.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.bus.Location = New System.Drawing.Point(283, 84)
        Me.bus.Name = "bus"
        Me.bus.Size = New System.Drawing.Size(216, 208)
        Me.bus.TabIndex = 3
        Me.bus.Text = "Bus"
        Me.bus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bus.UseVisualStyleBackColor = False
        '
        'cab
        '
        Me.cab.BackColor = System.Drawing.Color.Black
        Me.cab.BackgroundImage = CType(resources.GetObject("cab.BackgroundImage"), System.Drawing.Image)
        Me.cab.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cab.ForeColor = System.Drawing.Color.Yellow
        Me.cab.Location = New System.Drawing.Point(28, 84)
        Me.cab.Name = "cab"
        Me.cab.Size = New System.Drawing.Size(231, 208)
        Me.cab.TabIndex = 2
        Me.cab.Text = "Cab"
        Me.cab.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cab.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Black
        Me.back.BackgroundImage = CType(resources.GetObject("back.BackgroundImage"), System.Drawing.Image)
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.IndianRed
        Me.back.Location = New System.Drawing.Point(519, 84)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(199, 208)
        Me.back.TabIndex = 4
        Me.back.Text = "Home Page"
        Me.back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.back.UseVisualStyleBackColor = False
        '
        'OutCampus1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(730, 368)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.bus)
        Me.Controls.Add(Me.cab)
        Me.Name = "OutCampus1"
        Me.Text = "OutCampus1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bus As System.Windows.Forms.Button
    Friend WithEvents cab As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
End Class
