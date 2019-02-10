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
        Me.bus = New System.Windows.Forms.Button()
        Me.cab = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bus
        '
        Me.bus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bus.Location = New System.Drawing.Point(294, 150)
        Me.bus.Name = "bus"
        Me.bus.Size = New System.Drawing.Size(140, 47)
        Me.bus.TabIndex = 3
        Me.bus.Text = "Bus"
        Me.bus.UseVisualStyleBackColor = True
        '
        'cab
        '
        Me.cab.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cab.Location = New System.Drawing.Point(76, 150)
        Me.cab.Name = "cab"
        Me.cab.Size = New System.Drawing.Size(140, 47)
        Me.cab.TabIndex = 2
        Me.cab.Text = "Cab"
        Me.cab.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(530, 150)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(140, 47)
        Me.back.TabIndex = 4
        Me.back.Text = "Home Page"
        Me.back.UseVisualStyleBackColor = True
        '
        'OutCampus1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
