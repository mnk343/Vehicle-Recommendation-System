<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.txtfrom = New System.Windows.Forms.RichTextBox()
        Me.txtto = New System.Windows.Forms.RichTextBox()
        Me.choose = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Send = New System.Windows.Forms.Button()
        Me.txtsub = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(188, 298)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(412, 159)
        Me.txtaddress.TabIndex = 0
        Me.txtaddress.Text = ""
        '
        'txtfrom
        '
        Me.txtfrom.Location = New System.Drawing.Point(188, 52)
        Me.txtfrom.Name = "txtfrom"
        Me.txtfrom.Size = New System.Drawing.Size(412, 30)
        Me.txtfrom.TabIndex = 1
        Me.txtfrom.Text = ""
        '
        'txtto
        '
        Me.txtto.Location = New System.Drawing.Point(188, 172)
        Me.txtto.Name = "txtto"
        Me.txtto.ReadOnly = True
        Me.txtto.Size = New System.Drawing.Size(412, 30)
        Me.txtto.TabIndex = 2
        Me.txtto.Text = ""
        '
        'choose
        '
        Me.choose.AllowDrop = True
        Me.choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.choose.FormattingEnabled = True
        Me.choose.Items.AddRange(New Object() {"Hospital", "Fire Station", "Police"})
        Me.choose.Location = New System.Drawing.Point(188, 112)
        Me.choose.Name = "choose"
        Me.choose.Size = New System.Drawing.Size(412, 24)
        Me.choose.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Choose"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Address"
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(323, 485)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(137, 59)
        Me.Send.TabIndex = 8
        Me.Send.Text = "Send"
        Me.Send.UseVisualStyleBackColor = True
        '
        'txtsub
        '
        Me.txtsub.Location = New System.Drawing.Point(188, 233)
        Me.txtsub.Name = "txtsub"
        Me.txtsub.Size = New System.Drawing.Size(412, 30)
        Me.txtsub.TabIndex = 9
        Me.txtsub.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Subject"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 568)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsub)
        Me.Controls.Add(Me.Send)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.choose)
        Me.Controls.Add(Me.txtto)
        Me.Controls.Add(Me.txtfrom)
        Me.Controls.Add(Me.txtaddress)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents txtfrom As System.Windows.Forms.RichTextBox
    Friend WithEvents txtto As System.Windows.Forms.RichTextBox
    Friend WithEvents choose As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Send As System.Windows.Forms.Button
    Friend WithEvents txtsub As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
