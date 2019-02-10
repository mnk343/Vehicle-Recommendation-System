<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class emergencyService
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsub = New System.Windows.Forms.RichTextBox()
        Me.Send = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.choose = New System.Windows.Forms.ComboBox()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 87)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Subject"
        '
        'txtsub
        '
        Me.txtsub.Location = New System.Drawing.Point(186, 84)
        Me.txtsub.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsub.Name = "txtsub"
        Me.txtsub.Size = New System.Drawing.Size(310, 25)
        Me.txtsub.TabIndex = 20
        Me.txtsub.Text = "Emergency"
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(287, 297)
        Me.Send.Margin = New System.Windows.Forms.Padding(2)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(103, 48)
        Me.Send.TabIndex = 19
        Me.Send.Text = "Send"
        Me.Send.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 170)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Choose"
        '
        'choose
        '
        Me.choose.AllowDrop = True
        Me.choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.choose.FormattingEnabled = True
        Me.choose.Items.AddRange(New Object() {"Hospital", "Fire Station", "Police"})
        Me.choose.Location = New System.Drawing.Point(186, 32)
        Me.choose.Margin = New System.Windows.Forms.Padding(2)
        Me.choose.Name = "choose"
        Me.choose.Size = New System.Drawing.Size(310, 21)
        Me.choose.TabIndex = 14
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(186, 145)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(310, 130)
        Me.txtaddress.TabIndex = 11
        Me.txtaddress.Text = "I need urgent help!!"
        '
        'emergencyService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 464)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsub)
        Me.Controls.Add(Me.Send)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.choose)
        Me.Controls.Add(Me.txtaddress)
        Me.Name = "emergencyService"
        Me.Text = "emergencyService"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsub As System.Windows.Forms.RichTextBox
    Friend WithEvents Send As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents choose As System.Windows.Forms.ComboBox
    Friend WithEvents txtaddress As System.Windows.Forms.RichTextBox
End Class
