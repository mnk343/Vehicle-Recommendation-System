<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboardStaff
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
        Me.deleteMember = New System.Windows.Forms.Button()
        Me.addMember = New System.Windows.Forms.Button()
        Me.changePassword = New System.Windows.Forms.Button()
        Me.prevPage = New System.Windows.Forms.Button()
        Me.signOut = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.update = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'deleteMember
        '
        Me.deleteMember.BackColor = System.Drawing.Color.Black
        Me.deleteMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.2!, System.Drawing.FontStyle.Bold)
        Me.deleteMember.ForeColor = System.Drawing.Color.White
        Me.deleteMember.Location = New System.Drawing.Point(217, 249)
        Me.deleteMember.Name = "deleteMember"
        Me.deleteMember.Size = New System.Drawing.Size(197, 64)
        Me.deleteMember.TabIndex = 10
        Me.deleteMember.Text = "Delete Member"
        Me.deleteMember.UseVisualStyleBackColor = False
        '
        'addMember
        '
        Me.addMember.BackColor = System.Drawing.Color.Black
        Me.addMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.2!, System.Drawing.FontStyle.Bold)
        Me.addMember.ForeColor = System.Drawing.Color.White
        Me.addMember.Location = New System.Drawing.Point(217, 148)
        Me.addMember.Name = "addMember"
        Me.addMember.Size = New System.Drawing.Size(197, 70)
        Me.addMember.TabIndex = 9
        Me.addMember.Text = "Add Member"
        Me.addMember.UseVisualStyleBackColor = False
        '
        'changePassword
        '
        Me.changePassword.BackColor = System.Drawing.Color.Black
        Me.changePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.2!, System.Drawing.FontStyle.Bold)
        Me.changePassword.ForeColor = System.Drawing.Color.White
        Me.changePassword.Location = New System.Drawing.Point(217, 33)
        Me.changePassword.Name = "changePassword"
        Me.changePassword.Size = New System.Drawing.Size(197, 70)
        Me.changePassword.TabIndex = 8
        Me.changePassword.Text = "Change Password"
        Me.changePassword.UseVisualStyleBackColor = False
        '
        'prevPage
        '
        Me.prevPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevPage.Location = New System.Drawing.Point(3, 182)
        Me.prevPage.Name = "prevPage"
        Me.prevPage.Size = New System.Drawing.Size(153, 70)
        Me.prevPage.TabIndex = 3
        Me.prevPage.Text = "Previous Page"
        Me.prevPage.UseVisualStyleBackColor = True
        '
        'signOut
        '
        Me.signOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signOut.Location = New System.Drawing.Point(23, 182)
        Me.signOut.Name = "signOut"
        Me.signOut.Size = New System.Drawing.Size(157, 70)
        Me.signOut.TabIndex = 5
        Me.signOut.Text = "Sign Out"
        Me.signOut.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.signOut)
        Me.Panel1.Location = New System.Drawing.Point(441, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 462)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.prevPage)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(176, 462)
        Me.Panel2.TabIndex = 12
        '
        'update
        '
        Me.update.BackColor = System.Drawing.Color.Black
        Me.update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.2!, System.Drawing.FontStyle.Bold)
        Me.update.ForeColor = System.Drawing.Color.White
        Me.update.Location = New System.Drawing.Point(217, 347)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(197, 64)
        Me.update.TabIndex = 13
        Me.update.Text = "Update Member"
        Me.update.UseVisualStyleBackColor = False
        '
        'dashboardStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 459)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.deleteMember)
        Me.Controls.Add(Me.addMember)
        Me.Controls.Add(Me.changePassword)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "dashboardStaff"
        Me.Text = "dashboardStaff"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents deleteMember As System.Windows.Forms.Button
    Friend WithEvents addMember As System.Windows.Forms.Button
    Friend WithEvents changePassword As System.Windows.Forms.Button
    Friend WithEvents prevPage As System.Windows.Forms.Button
    Friend WithEvents signOut As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents update As System.Windows.Forms.Button
End Class
