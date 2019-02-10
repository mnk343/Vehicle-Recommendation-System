<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class memberUpdate
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
        Me.info = New System.Windows.Forms.Label()
        Me.vehicleName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtVehicleName = New System.Windows.Forms.TextBox()
        Me.seater = New System.Windows.Forms.Label()
        Me.txtSeater = New System.Windows.Forms.TextBox()
        Me.tawangTrips = New System.Windows.Forms.Label()
        Me.txtTawangTrips = New System.Windows.Forms.TextBox()
        Me.gangtokTrips = New System.Windows.Forms.Label()
        Me.txtGangtokTrips = New System.Windows.Forms.TextBox()
        Me.shillongTrips = New System.Windows.Forms.Label()
        Me.txtShillongTrips = New System.Windows.Forms.TextBox()
        Me.cityTrips = New System.Windows.Forms.Label()
        Me.txtCityTrips = New System.Windows.Forms.TextBox()
        Me.gangtok = New System.Windows.Forms.CheckBox()
        Me.tawang = New System.Windows.Forms.CheckBox()
        Me.shillong = New System.Windows.Forms.CheckBox()
        Me.City = New System.Windows.Forms.CheckBox()
        Me.showPassword = New System.Windows.Forms.CheckBox()
        Me.password = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.contactNo = New System.Windows.Forms.Label()
        Me.update = New System.Windows.Forms.Button()
        Me.vehicle = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.submit1 = New System.Windows.Forms.Button()
        Me.usrName = New System.Windows.Forms.TextBox()
        Me.name = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Location = New System.Drawing.Point(66, 21)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(334, 26)
        Me.info.TabIndex = 31
        Me.info.Text = "Please Select a vehicle type : "
        '
        'vehicleName
        '
        Me.vehicleName.AutoSize = True
        Me.vehicleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicleName.ForeColor = System.Drawing.Color.White
        Me.vehicleName.Location = New System.Drawing.Point(333, 204)
        Me.vehicleName.Name = "vehicleName"
        Me.vehicleName.Size = New System.Drawing.Size(105, 16)
        Me.vehicleName.TabIndex = 26
        Me.vehicleName.Text = "Vehicle Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.vehicleName)
        Me.Panel2.Controls.Add(Me.txtVehicleName)
        Me.Panel2.Controls.Add(Me.seater)
        Me.Panel2.Controls.Add(Me.txtSeater)
        Me.Panel2.Controls.Add(Me.tawangTrips)
        Me.Panel2.Controls.Add(Me.txtTawangTrips)
        Me.Panel2.Controls.Add(Me.gangtokTrips)
        Me.Panel2.Controls.Add(Me.txtGangtokTrips)
        Me.Panel2.Controls.Add(Me.shillongTrips)
        Me.Panel2.Controls.Add(Me.txtShillongTrips)
        Me.Panel2.Controls.Add(Me.cityTrips)
        Me.Panel2.Controls.Add(Me.txtCityTrips)
        Me.Panel2.Controls.Add(Me.gangtok)
        Me.Panel2.Controls.Add(Me.tawang)
        Me.Panel2.Controls.Add(Me.shillong)
        Me.Panel2.Controls.Add(Me.City)
        Me.Panel2.Controls.Add(Me.showPassword)
        Me.Panel2.Controls.Add(Me.password)
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Controls.Add(Me.txtContactNo)
        Me.Panel2.Controls.Add(Me.contactNo)
        Me.Panel2.Location = New System.Drawing.Point(71, 106)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(742, 268)
        Me.Panel2.TabIndex = 33
        '
        'txtVehicleName
        '
        Me.txtVehicleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehicleName.Location = New System.Drawing.Point(454, 204)
        Me.txtVehicleName.Name = "txtVehicleName"
        Me.txtVehicleName.Size = New System.Drawing.Size(106, 22)
        Me.txtVehicleName.TabIndex = 27
        '
        'seater
        '
        Me.seater.AutoSize = True
        Me.seater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seater.ForeColor = System.Drawing.Color.White
        Me.seater.Location = New System.Drawing.Point(43, 198)
        Me.seater.Name = "seater"
        Me.seater.Size = New System.Drawing.Size(54, 16)
        Me.seater.TabIndex = 24
        Me.seater.Text = "Seater"
        '
        'txtSeater
        '
        Me.txtSeater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeater.Location = New System.Drawing.Point(123, 198)
        Me.txtSeater.Name = "txtSeater"
        Me.txtSeater.Size = New System.Drawing.Size(47, 22)
        Me.txtSeater.TabIndex = 25
        '
        'tawangTrips
        '
        Me.tawangTrips.AutoSize = True
        Me.tawangTrips.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tawangTrips.ForeColor = System.Drawing.Color.White
        Me.tawangTrips.Location = New System.Drawing.Point(541, 150)
        Me.tawangTrips.Name = "tawangTrips"
        Me.tawangTrips.Size = New System.Drawing.Size(103, 16)
        Me.tawangTrips.TabIndex = 22
        Me.tawangTrips.Text = "Tawang Trips"
        '
        'txtTawangTrips
        '
        Me.txtTawangTrips.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTawangTrips.Location = New System.Drawing.Point(665, 147)
        Me.txtTawangTrips.Name = "txtTawangTrips"
        Me.txtTawangTrips.Size = New System.Drawing.Size(47, 22)
        Me.txtTawangTrips.TabIndex = 23
        '
        'gangtokTrips
        '
        Me.gangtokTrips.AutoSize = True
        Me.gangtokTrips.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gangtokTrips.ForeColor = System.Drawing.Color.White
        Me.gangtokTrips.Location = New System.Drawing.Point(350, 147)
        Me.gangtokTrips.Name = "gangtokTrips"
        Me.gangtokTrips.Size = New System.Drawing.Size(106, 16)
        Me.gangtokTrips.TabIndex = 20
        Me.gangtokTrips.Text = "Gangtok Trips"
        '
        'txtGangtokTrips
        '
        Me.txtGangtokTrips.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGangtokTrips.Location = New System.Drawing.Point(479, 144)
        Me.txtGangtokTrips.Name = "txtGangtokTrips"
        Me.txtGangtokTrips.Size = New System.Drawing.Size(47, 22)
        Me.txtGangtokTrips.TabIndex = 21
        '
        'shillongTrips
        '
        Me.shillongTrips.AutoSize = True
        Me.shillongTrips.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shillongTrips.ForeColor = System.Drawing.Color.White
        Me.shillongTrips.Location = New System.Drawing.Point(160, 144)
        Me.shillongTrips.Name = "shillongTrips"
        Me.shillongTrips.Size = New System.Drawing.Size(104, 16)
        Me.shillongTrips.TabIndex = 18
        Me.shillongTrips.Text = "Shillong Trips"
        '
        'txtShillongTrips
        '
        Me.txtShillongTrips.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShillongTrips.Location = New System.Drawing.Point(271, 141)
        Me.txtShillongTrips.Name = "txtShillongTrips"
        Me.txtShillongTrips.Size = New System.Drawing.Size(47, 22)
        Me.txtShillongTrips.TabIndex = 19
        '
        'cityTrips
        '
        Me.cityTrips.AutoSize = True
        Me.cityTrips.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityTrips.ForeColor = System.Drawing.Color.White
        Me.cityTrips.Location = New System.Drawing.Point(13, 144)
        Me.cityTrips.Name = "cityTrips"
        Me.cityTrips.Size = New System.Drawing.Size(74, 16)
        Me.cityTrips.TabIndex = 16
        Me.cityTrips.Text = "City Trips"
        '
        'txtCityTrips
        '
        Me.txtCityTrips.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCityTrips.Location = New System.Drawing.Point(93, 144)
        Me.txtCityTrips.Name = "txtCityTrips"
        Me.txtCityTrips.Size = New System.Drawing.Size(47, 22)
        Me.txtCityTrips.TabIndex = 17
        '
        'gangtok
        '
        Me.gangtok.AutoSize = True
        Me.gangtok.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gangtok.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gangtok.Location = New System.Drawing.Point(353, 94)
        Me.gangtok.Name = "gangtok"
        Me.gangtok.Size = New System.Drawing.Size(119, 29)
        Me.gangtok.TabIndex = 15
        Me.gangtok.Text = "Gangtok"
        Me.gangtok.UseVisualStyleBackColor = True
        '
        'tawang
        '
        Me.tawang.AutoSize = True
        Me.tawang.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tawang.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tawang.Location = New System.Drawing.Point(488, 94)
        Me.tawang.Name = "tawang"
        Me.tawang.Size = New System.Drawing.Size(113, 29)
        Me.tawang.TabIndex = 14
        Me.tawang.Text = "Tawang"
        Me.tawang.UseVisualStyleBackColor = True
        '
        'shillong
        '
        Me.shillong.AutoSize = True
        Me.shillong.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shillong.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.shillong.Location = New System.Drawing.Point(202, 94)
        Me.shillong.Name = "shillong"
        Me.shillong.Size = New System.Drawing.Size(116, 29)
        Me.shillong.TabIndex = 13
        Me.shillong.Text = "Shillong"
        Me.shillong.UseVisualStyleBackColor = True
        '
        'City
        '
        Me.City.AutoSize = True
        Me.City.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.City.Location = New System.Drawing.Point(93, 94)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(72, 29)
        Me.City.TabIndex = 12
        Me.City.Text = "City"
        Me.City.UseVisualStyleBackColor = True
        '
        'showPassword
        '
        Me.showPassword.AutoSize = True
        Me.showPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showPassword.ForeColor = System.Drawing.Color.White
        Me.showPassword.Location = New System.Drawing.Point(600, 5)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(139, 21)
        Me.showPassword.TabIndex = 11
        Me.showPassword.Text = "Show Password"
        Me.showPassword.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.White
        Me.password.Location = New System.Drawing.Point(41, 25)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(116, 26)
        Me.password.TabIndex = 2
        Me.password.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(378, 32)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(349, 20)
        Me.txtPassword.TabIndex = 6
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(378, 58)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(349, 20)
        Me.txtContactNo.TabIndex = 8
        '
        'contactNo
        '
        Me.contactNo.AutoSize = True
        Me.contactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNo.ForeColor = System.Drawing.Color.White
        Me.contactNo.Location = New System.Drawing.Point(41, 51)
        Me.contactNo.Name = "contactNo"
        Me.contactNo.Size = New System.Drawing.Size(185, 26)
        Me.contactNo.TabIndex = 4
        Me.contactNo.Text = "Contact Number"
        '
        'update
        '
        Me.update.BackColor = System.Drawing.Color.Black
        Me.update.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.ForeColor = System.Drawing.Color.White
        Me.update.Location = New System.Drawing.Point(142, 42)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(147, 47)
        Me.update.TabIndex = 9
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = False
        '
        'vehicle
        '
        Me.vehicle.FormattingEnabled = True
        Me.vehicle.Location = New System.Drawing.Point(449, 21)
        Me.vehicle.Name = "vehicle"
        Me.vehicle.Size = New System.Drawing.Size(349, 21)
        Me.vehicle.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.update)
        Me.Panel1.Location = New System.Drawing.Point(71, 374)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 110)
        Me.Panel1.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(454, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 47)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'submit1
        '
        Me.submit1.Location = New System.Drawing.Point(859, 57)
        Me.submit1.Name = "submit1"
        Me.submit1.Size = New System.Drawing.Size(75, 23)
        Me.submit1.TabIndex = 36
        Me.submit1.Text = "Submit"
        Me.submit1.UseVisualStyleBackColor = True
        '
        'usrName
        '
        Me.usrName.Location = New System.Drawing.Point(449, 59)
        Me.usrName.Name = "usrName"
        Me.usrName.Size = New System.Drawing.Size(349, 20)
        Me.usrName.TabIndex = 35
        '
        'name
        '
        Me.name.AutoSize = True
        Me.name.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name.Location = New System.Drawing.Point(66, 59)
        Me.name.Name = "name"
        Me.name.Size = New System.Drawing.Size(290, 26)
        Me.name.TabIndex = 34
        Me.name.Text = "Kindly Enter User Name : "
        '
        'memberUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 517)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.vehicle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.submit1)
        Me.Controls.Add(Me.usrName)
        Me.Controls.Add(Me.name)
        ' Me.Name = "memberUpdate"
        Me.Text = "memberUpdate"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents vehicleName As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtVehicleName As System.Windows.Forms.TextBox
    Friend WithEvents seater As System.Windows.Forms.Label
    Friend WithEvents txtSeater As System.Windows.Forms.TextBox
    Friend WithEvents tawangTrips As System.Windows.Forms.Label
    Friend WithEvents txtTawangTrips As System.Windows.Forms.TextBox
    Friend WithEvents gangtokTrips As System.Windows.Forms.Label
    Friend WithEvents txtGangtokTrips As System.Windows.Forms.TextBox
    Friend WithEvents shillongTrips As System.Windows.Forms.Label
    Friend WithEvents txtShillongTrips As System.Windows.Forms.TextBox
    Friend WithEvents cityTrips As System.Windows.Forms.Label
    Friend WithEvents txtCityTrips As System.Windows.Forms.TextBox
    Friend WithEvents gangtok As System.Windows.Forms.CheckBox
    Friend WithEvents tawang As System.Windows.Forms.CheckBox
    Friend WithEvents shillong As System.Windows.Forms.CheckBox
    Friend WithEvents City As System.Windows.Forms.CheckBox
    Friend WithEvents showPassword As System.Windows.Forms.CheckBox
    Friend WithEvents password As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents contactNo As System.Windows.Forms.Label
    Friend WithEvents update As System.Windows.Forms.Button
    Friend WithEvents vehicle As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents submit1 As System.Windows.Forms.Button
    Friend WithEvents usrName As System.Windows.Forms.TextBox
    Friend WithEvents name As System.Windows.Forms.Label
End Class
