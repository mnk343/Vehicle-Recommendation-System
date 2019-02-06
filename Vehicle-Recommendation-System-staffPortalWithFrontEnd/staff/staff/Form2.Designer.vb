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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'changePassword
        '
        Me.changePassword.BackColor = System.Drawing.Color.Black
        Me.changePassword.Font = New System.Drawing.Font("Museo Sans For Dell", 12.2!, System.Drawing.FontStyle.Bold)
        Me.changePassword.ForeColor = System.Drawing.Color.White
        Me.changePassword.Location = New System.Drawing.Point(289, 43)
        Me.changePassword.Margin = New System.Windows.Forms.Padding(4)
        Me.changePassword.Name = "changePassword"
        Me.changePassword.Size = New System.Drawing.Size(263, 86)
        Me.changePassword.TabIndex = 0
        Me.changePassword.Text = "Change Password"
        Me.changePassword.UseVisualStyleBackColor = False
        '
        'addMember
        '
        Me.addMember.BackColor = System.Drawing.Color.Black
        Me.addMember.Font = New System.Drawing.Font("Museo Sans For Dell", 12.2!, System.Drawing.FontStyle.Bold)
        Me.addMember.ForeColor = System.Drawing.Color.White
        Me.addMember.Location = New System.Drawing.Point(289, 184)
        Me.addMember.Margin = New System.Windows.Forms.Padding(4)
        Me.addMember.Name = "addMember"
        Me.addMember.Size = New System.Drawing.Size(263, 86)
        Me.addMember.TabIndex = 1
        Me.addMember.Text = "Add Member"
        Me.addMember.UseVisualStyleBackColor = False
        '
        'deleteMember
        '
        Me.deleteMember.BackColor = System.Drawing.Color.Black
        Me.deleteMember.Font = New System.Drawing.Font("Museo Sans For Dell", 12.2!, System.Drawing.FontStyle.Bold)
        Me.deleteMember.ForeColor = System.Drawing.Color.White
        Me.deleteMember.Location = New System.Drawing.Point(289, 336)
        Me.deleteMember.Margin = New System.Windows.Forms.Padding(4)
        Me.deleteMember.Name = "deleteMember"
        Me.deleteMember.Size = New System.Drawing.Size(263, 79)
        Me.deleteMember.TabIndex = 2
        Me.deleteMember.Text = "Delete Member"
        Me.deleteMember.UseVisualStyleBackColor = False
        '
        'prevPage
        '
        Me.prevPage.Font = New System.Drawing.Font("Museo Sans For Dell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevPage.Location = New System.Drawing.Point(13, 181)
        Me.prevPage.Margin = New System.Windows.Forms.Padding(4)
        Me.prevPage.Name = "prevPage"
        Me.prevPage.Size = New System.Drawing.Size(204, 86)
        Me.prevPage.TabIndex = 3
        Me.prevPage.Text = "Previous Page"
        Me.prevPage.UseVisualStyleBackColor = True
        '
        'signOut
        '
        Me.signOut.Font = New System.Drawing.Font("Museo Sans For Dell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signOut.Location = New System.Drawing.Point(15, 181)
        Me.signOut.Margin = New System.Windows.Forms.Padding(4)
        Me.signOut.Name = "signOut"
        Me.signOut.Size = New System.Drawing.Size(209, 86)
        Me.signOut.TabIndex = 5
        Me.signOut.Text = "Sign Out"
        Me.signOut.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.signOut)
        Me.Panel1.Location = New System.Drawing.Point(603, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 445)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.prevPage)
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(235, 445)
        Me.Panel2.TabIndex = 7
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 449)
        Me.Controls.Add(Me.deleteMember)
        Me.Controls.Add(Me.addMember)
        Me.Controls.Add(Me.changePassword)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents changePassword As System.Windows.Forms.Button
    Friend WithEvents addMember As System.Windows.Forms.Button
    Friend WithEvents deleteMember As System.Windows.Forms.Button
    Friend WithEvents prevPage As System.Windows.Forms.Button
    Friend WithEvents signOut As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
