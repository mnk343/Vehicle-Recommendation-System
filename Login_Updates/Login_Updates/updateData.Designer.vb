<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateData
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updateData))
        Me.usertxt = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.butupd = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList5 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList6 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.butclear = New System.Windows.Forms.Button()
        Me.chgangtok = New System.Windows.Forms.CheckBox()
        Me.chtawang = New System.Windows.Forms.CheckBox()
        Me.chshillong = New System.Windows.Forms.CheckBox()
        Me.chcity = New System.Windows.Forms.CheckBox()
        Me.chshow = New System.Windows.Forms.CheckBox()
        Me.butback = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usertxt
        '
        Me.usertxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!)
        Me.usertxt.Location = New System.Drawing.Point(549, 182)
        Me.usertxt.Multiline = True
        Me.usertxt.Name = "usertxt"
        Me.usertxt.ReadOnly = True
        Me.usertxt.Size = New System.Drawing.Size(341, 29)
        Me.usertxt.TabIndex = 1
        '
        'txtcontact
        '
        Me.txtcontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!)
        Me.txtcontact.Location = New System.Drawing.Point(549, 254)
        Me.txtcontact.Multiline = True
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(341, 29)
        Me.txtcontact.TabIndex = 2
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.8!)
        Me.txtpass.Location = New System.Drawing.Point(549, 331)
        Me.txtpass.Multiline = True
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(341, 29)
        Me.txtpass.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.8!)
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(203, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username"
        Me.Label2.UseMnemonic = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.8!)
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(203, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Contact Number"
        Me.Label3.UseMnemonic = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.8!)
        Me.Label5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label5.Location = New System.Drawing.Point(203, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Current Password"
        Me.Label5.UseMnemonic = False
        '
        'butupd
        '
        Me.butupd.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.butupd.ForeColor = System.Drawing.Color.MediumBlue
        Me.butupd.Location = New System.Drawing.Point(432, 562)
        Me.butupd.Name = "butupd"
        Me.butupd.Size = New System.Drawing.Size(263, 48)
        Me.butupd.TabIndex = 10
        Me.butupd.Text = "UPDATE"
        Me.butupd.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.Button2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button2.Location = New System.Drawing.Point(937, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(204, 32)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "NEW PASSWORD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.8!)
        Me.Label4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label4.Location = New System.Drawing.Point(203, 411)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 29)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Places"
        Me.Label4.UseMnemonic = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList3
        '
        Me.ImageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList3.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList4
        '
        Me.ImageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList4.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList4.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList5
        '
        Me.ImageList5.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList5.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList5.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList6
        '
        Me.ImageList6.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList6.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList6.TransparentColor = System.Drawing.Color.Transparent
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(251, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(639, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'butclear
        '
        Me.butclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.butclear.ForeColor = System.Drawing.Color.MediumBlue
        Me.butclear.Location = New System.Drawing.Point(61, 562)
        Me.butclear.Name = "butclear"
        Me.butclear.Size = New System.Drawing.Size(263, 48)
        Me.butclear.TabIndex = 20
        Me.butclear.Text = "CLEAR"
        Me.butclear.UseVisualStyleBackColor = True
        '
        'chgangtok
        '
        Me.chgangtok.AutoSize = True
        Me.chgangtok.Location = New System.Drawing.Point(886, 421)
        Me.chgangtok.Name = "chgangtok"
        Me.chgangtok.Size = New System.Drawing.Size(84, 21)
        Me.chgangtok.TabIndex = 15
        Me.chgangtok.Text = "Gangtok"
        Me.chgangtok.UseVisualStyleBackColor = True
        '
        'chtawang
        '
        Me.chtawang.AutoSize = True
        Me.chtawang.Location = New System.Drawing.Point(760, 421)
        Me.chtawang.Name = "chtawang"
        Me.chtawang.Size = New System.Drawing.Size(80, 21)
        Me.chtawang.TabIndex = 16
        Me.chtawang.Text = "Tawang"
        Me.chtawang.UseVisualStyleBackColor = True
        '
        'chshillong
        '
        Me.chshillong.AutoSize = True
        Me.chshillong.Location = New System.Drawing.Point(645, 421)
        Me.chshillong.Name = "chshillong"
        Me.chshillong.Size = New System.Drawing.Size(80, 21)
        Me.chshillong.TabIndex = 14
        Me.chshillong.Text = "Shillong"
        Me.chshillong.UseVisualStyleBackColor = True
        '
        'chcity
        '
        Me.chcity.AutoSize = True
        Me.chcity.Location = New System.Drawing.Point(549, 419)
        Me.chcity.Name = "chcity"
        Me.chcity.Size = New System.Drawing.Size(53, 21)
        Me.chcity.TabIndex = 17
        Me.chcity.Text = "City"
        Me.chcity.UseVisualStyleBackColor = True
        '
        'chshow
        '
        Me.chshow.AutoSize = True
        Me.chshow.Location = New System.Drawing.Point(906, 338)
        Me.chshow.Name = "chshow"
        Me.chshow.Size = New System.Drawing.Size(64, 21)
        Me.chshow.TabIndex = 21
        Me.chshow.Text = "Show"
        Me.chshow.UseVisualStyleBackColor = True
        '
        'butback
        '
        Me.butback.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.butback.ForeColor = System.Drawing.Color.MediumBlue
        Me.butback.Location = New System.Drawing.Point(824, 562)
        Me.butback.Name = "butback"
        Me.butback.Size = New System.Drawing.Size(263, 48)
        Me.butback.TabIndex = 22
        Me.butback.Text = "BACK"
        Me.butback.UseVisualStyleBackColor = True
        '
        'updateData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 622)
        Me.Controls.Add(Me.butback)
        Me.Controls.Add(Me.chshow)
        Me.Controls.Add(Me.butclear)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chcity)
        Me.Controls.Add(Me.chtawang)
        Me.Controls.Add(Me.chgangtok)
        Me.Controls.Add(Me.chshillong)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.butupd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.usertxt)
        Me.Name = "updateData"
        Me.Text = "Update Data"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents usertxt As System.Windows.Forms.TextBox
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents butupd As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList4 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList5 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList6 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents butclear As System.Windows.Forms.Button
    Friend WithEvents chgangtok As System.Windows.Forms.CheckBox
    Friend WithEvents chtawang As System.Windows.Forms.CheckBox
    Friend WithEvents chshillong As System.Windows.Forms.CheckBox
    Friend WithEvents chcity As System.Windows.Forms.CheckBox
    Friend WithEvents chshow As System.Windows.Forms.CheckBox
    Friend WithEvents butback As System.Windows.Forms.Button
End Class
