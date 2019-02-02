<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.changePassword = New System.Windows.Forms.Button()
        Me.addMember = New System.Windows.Forms.Button()
        Me.deleteMember = New System.Windows.Forms.Button()
        Me.prevPage = New System.Windows.Forms.Button()
        Me.signOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'changePassword
        '
        Me.changePassword.Location = New System.Drawing.Point(200, 47)
        Me.changePassword.Name = "changePassword"
        Me.changePassword.Size = New System.Drawing.Size(232, 70)
        Me.changePassword.TabIndex = 0
        Me.changePassword.Text = "Change Password"
        Me.changePassword.UseVisualStyleBackColor = True
        '
        'addMember
        '
        Me.addMember.Location = New System.Drawing.Point(200, 133)
        Me.addMember.Name = "addMember"
        Me.addMember.Size = New System.Drawing.Size(232, 61)
        Me.addMember.TabIndex = 1
        Me.addMember.Text = "Add Member"
        Me.addMember.UseVisualStyleBackColor = True
        '
        'deleteMember
        '
        Me.deleteMember.Location = New System.Drawing.Point(200, 212)
        Me.deleteMember.Name = "deleteMember"
        Me.deleteMember.Size = New System.Drawing.Size(232, 54)
        Me.deleteMember.TabIndex = 2
        Me.deleteMember.Text = "Delete Member"
        Me.deleteMember.UseVisualStyleBackColor = True
        '
        'prevPage
        '
        Me.prevPage.Location = New System.Drawing.Point(48, 299)
        Me.prevPage.Name = "prevPage"
        Me.prevPage.Size = New System.Drawing.Size(153, 54)
        Me.prevPage.TabIndex = 3
        Me.prevPage.Text = "Previous Page"
        Me.prevPage.UseVisualStyleBackColor = True
        '
        'signOut
        '
        Me.signOut.Location = New System.Drawing.Point(414, 299)
        Me.signOut.Name = "signOut"
        Me.signOut.Size = New System.Drawing.Size(157, 54)
        Me.signOut.TabIndex = 5
        Me.signOut.Text = "Sign Out"
        Me.signOut.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 365)
        Me.Controls.Add(Me.signOut)
        Me.Controls.Add(Me.prevPage)
        Me.Controls.Add(Me.deleteMember)
        Me.Controls.Add(Me.addMember)
        Me.Controls.Add(Me.changePassword)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents changePassword As System.Windows.Forms.Button
    Friend WithEvents addMember As System.Windows.Forms.Button
    Friend WithEvents deleteMember As System.Windows.Forms.Button
    Friend WithEvents prevPage As System.Windows.Forms.Button
    Friend WithEvents signOut As System.Windows.Forms.Button
End Class
