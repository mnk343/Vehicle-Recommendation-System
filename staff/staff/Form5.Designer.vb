<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.delete = New System.Windows.Forms.Button()
        Me.name = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(167, 141)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(224, 31)
        Me.txtName.TabIndex = 0
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(306, 264)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(173, 61)
        Me.delete.TabIndex = 1
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'name
        '
        Me.name.AutoSize = True
        Me.name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name.Location = New System.Drawing.Point(142, 80)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(289, 25)
        Me.name.TabIndex = 2
        Me.name.Text = "Enter the username to delete"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 61)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 364)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.name)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.txtName)
        'Me.Name = "Form5"
        Me.Text = "Delete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents name As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
