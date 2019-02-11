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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.emergency_btn = New System.Windows.Forms.Button()
        Me.incampus_btn = New System.Windows.Forms.Button()
        Me.outcampus_btn = New System.Windows.Forms.Button()
        Me.outstation_btn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bus = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.outstation_panel = New System.Windows.Forms.Panel()
        Me.info = New System.Windows.Forms.Label()
        Me.clear = New System.Windows.Forms.Button()
        Me.submit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.passengers = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.gang_btn = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.tawang_btn = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.shilong_btn = New System.Windows.Forms.Button()
        Me.emergency_panel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtsub = New System.Windows.Forms.RichTextBox()
        Me.Send = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.choose = New System.Windows.Forms.ComboBox()
        Me.txtaddress = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.erickshaw = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.panelERickshaw = New System.Windows.Forms.Panel()
        Me.doubleClick = New System.Windows.Forms.Label()
        Me.lblSugg = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.e_fullData_dgv = New System.Windows.Forms.DataGridView()
        Me.e_dgv = New System.Windows.Forms.DataGridView()
        Me.panelBus = New System.Windows.Forms.Panel()
        Me.lblInfoBus = New System.Windows.Forms.Label()
        Me.btnSubmitBus = New System.Windows.Forms.Button()
        Me.de_cb = New System.Windows.Forms.ComboBox()
        Me.s_cb = New System.Windows.Forms.ComboBox()
        Me.d_cb = New System.Windows.Forms.Label()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.bus_dgv = New System.Windows.Forms.DataGridView()
        Me.time_lbl = New System.Windows.Forms.Label()
        Me.t_lbl = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.outcampus_panel = New System.Windows.Forms.Panel()
        Me.incampus_panel = New System.Windows.Forms.Panel()
        Me.CabDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.outstation_panel.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.emergency_panel.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.panelERickshaw.SuspendLayout()
        CType(Me.e_fullData_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.e_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBus.SuspendLayout()
        CType(Me.bus_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.outcampus_panel.SuspendLayout()
        Me.incampus_panel.SuspendLayout()
        CType(Me.CabDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.emergency_btn)
        Me.Panel1.Controls.Add(Me.incampus_btn)
        Me.Panel1.Controls.Add(Me.outcampus_btn)
        Me.Panel1.Controls.Add(Me.outstation_btn)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 745)
        Me.Panel1.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 622)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(259, 123)
        Me.Panel4.TabIndex = 8
        '
        'emergency_btn
        '
        Me.emergency_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.emergency_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.emergency_btn.FlatAppearance.BorderSize = 0
        Me.emergency_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.emergency_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emergency_btn.ForeColor = System.Drawing.Color.LightGray
        Me.emergency_btn.Location = New System.Drawing.Point(0, 217)
        Me.emergency_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.emergency_btn.Name = "emergency_btn"
        Me.emergency_btn.Size = New System.Drawing.Size(259, 44)
        Me.emergency_btn.TabIndex = 11
        Me.emergency_btn.Text = "Emergency"
        Me.emergency_btn.UseVisualStyleBackColor = False
        '
        'incampus_btn
        '
        Me.incampus_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.incampus_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.incampus_btn.FlatAppearance.BorderSize = 0
        Me.incampus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.incampus_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incampus_btn.ForeColor = System.Drawing.Color.LightGray
        Me.incampus_btn.Location = New System.Drawing.Point(0, 173)
        Me.incampus_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.incampus_btn.Name = "incampus_btn"
        Me.incampus_btn.Size = New System.Drawing.Size(259, 44)
        Me.incampus_btn.TabIndex = 10
        Me.incampus_btn.Text = "Incampus"
        Me.incampus_btn.UseVisualStyleBackColor = False
        '
        'outcampus_btn
        '
        Me.outcampus_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.outcampus_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.outcampus_btn.FlatAppearance.BorderSize = 0
        Me.outcampus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.outcampus_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outcampus_btn.ForeColor = System.Drawing.Color.LightGray
        Me.outcampus_btn.Location = New System.Drawing.Point(0, 129)
        Me.outcampus_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.outcampus_btn.Name = "outcampus_btn"
        Me.outcampus_btn.Size = New System.Drawing.Size(259, 44)
        Me.outcampus_btn.TabIndex = 9
        Me.outcampus_btn.Text = "Outcampus"
        Me.outcampus_btn.UseVisualStyleBackColor = False
        '
        'outstation_btn
        '
        Me.outstation_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.outstation_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.outstation_btn.FlatAppearance.BorderSize = 0
        Me.outstation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.outstation_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outstation_btn.ForeColor = System.Drawing.Color.LightGray
        Me.outstation_btn.Location = New System.Drawing.Point(0, 85)
        Me.outstation_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.outstation_btn.Name = "outstation_btn"
        Me.outstation_btn.Size = New System.Drawing.Size(259, 44)
        Me.outstation_btn.TabIndex = 8
        Me.outstation_btn.Text = "Outstation"
        Me.outstation_btn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(259, 85)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(93, 15)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(71, 59)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.login_btn)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(259, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1477, 85)
        Me.Panel3.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(51, 26)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 38)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(105, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 38)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Dashboard"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.login_btn.ForeColor = System.Drawing.Color.White
        Me.login_btn.Location = New System.Drawing.Point(869, 23)
        Me.login_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(115, 44)
        Me.login_btn.TabIndex = 8
        Me.login_btn.Text = "Log In"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(807, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 44)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'bus
        '
        Me.bus.BackColor = System.Drawing.Color.White
        Me.bus.BackgroundImage = CType(resources.GetObject("bus.BackgroundImage"), System.Drawing.Image)
        Me.bus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bus.Location = New System.Drawing.Point(40, 36)
        Me.bus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bus.Name = "bus"
        Me.bus.Size = New System.Drawing.Size(155, 114)
        Me.bus.TabIndex = 0
        Me.bus.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.bus)
        Me.Panel6.Location = New System.Drawing.Point(281, 4)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(223, 150)
        Me.Panel6.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 1)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bus"
        '
        'outstation_panel
        '
        Me.outstation_panel.Controls.Add(Me.info)
        Me.outstation_panel.Controls.Add(Me.clear)
        Me.outstation_panel.Controls.Add(Me.submit)
        Me.outstation_panel.Controls.Add(Me.Label6)
        Me.outstation_panel.Controls.Add(Me.passengers)
        Me.outstation_panel.Controls.Add(Me.dgvData)
        Me.outstation_panel.Controls.Add(Me.Panel5)
        Me.outstation_panel.Controls.Add(Me.Panel8)
        Me.outstation_panel.Controls.Add(Me.Panel11)
        Me.outstation_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.outstation_panel.Location = New System.Drawing.Point(2558, 85)
        Me.outstation_panel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.outstation_panel.Name = "outstation_panel"
        Me.outstation_panel.Size = New System.Drawing.Size(1299, 660)
        Me.outstation_panel.TabIndex = 4
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.Location = New System.Drawing.Point(473, 555)
        Me.info.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(413, 29)
        Me.info.TabIndex = 39
        Me.info.Text = "Please Select A City to see results"
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.Black
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.Color.White
        Me.clear.Location = New System.Drawing.Point(679, 437)
        Me.clear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(128, 36)
        Me.clear.TabIndex = 38
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = False
        '
        'submit
        '
        Me.submit.BackColor = System.Drawing.Color.Black
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.ForeColor = System.Drawing.Color.White
        Me.submit.Location = New System.Drawing.Point(545, 437)
        Me.submit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(113, 36)
        Me.submit.TabIndex = 37
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(415, 348)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(447, 25)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Please Enter Number of Pasengers (optional)"
        '
        'passengers
        '
        Me.passengers.Location = New System.Drawing.Point(479, 394)
        Me.passengers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.passengers.Name = "passengers"
        Me.passengers.Size = New System.Drawing.Size(365, 22)
        Me.passengers.TabIndex = 35
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(153, 492)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(1028, 191)
        Me.dgvData.TabIndex = 34
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.gang_btn)
        Me.Panel5.Location = New System.Drawing.Point(857, 160)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(383, 174)
        Me.Panel5.TabIndex = 42
        '
        'gang_btn
        '
        Me.gang_btn.BackColor = System.Drawing.Color.White
        Me.gang_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gang_btn.ForeColor = System.Drawing.Color.Black
        Me.gang_btn.Location = New System.Drawing.Point(127, 10)
        Me.gang_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gang_btn.Name = "gang_btn"
        Me.gang_btn.Size = New System.Drawing.Size(121, 47)
        Me.gang_btn.TabIndex = 14
        Me.gang_btn.Text = "Gangtok"
        Me.gang_btn.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Panel8.Controls.Add(Me.tawang_btn)
        Me.Panel8.Location = New System.Drawing.Point(441, 160)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(419, 174)
        Me.Panel8.TabIndex = 41
        '
        'tawang_btn
        '
        Me.tawang_btn.BackColor = System.Drawing.Color.White
        Me.tawang_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tawang_btn.ForeColor = System.Drawing.Color.Black
        Me.tawang_btn.Location = New System.Drawing.Point(120, 10)
        Me.tawang_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tawang_btn.Name = "tawang_btn"
        Me.tawang_btn.Size = New System.Drawing.Size(149, 47)
        Me.tawang_btn.TabIndex = 13
        Me.tawang_btn.Text = "Tawang"
        Me.tawang_btn.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Black
        Me.Panel11.BackgroundImage = CType(resources.GetObject("Panel11.BackgroundImage"), System.Drawing.Image)
        Me.Panel11.Controls.Add(Me.shilong_btn)
        Me.Panel11.Location = New System.Drawing.Point(57, 160)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(389, 174)
        Me.Panel11.TabIndex = 40
        '
        'shilong_btn
        '
        Me.shilong_btn.BackColor = System.Drawing.Color.White
        Me.shilong_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.shilong_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shilong_btn.ForeColor = System.Drawing.Color.Black
        Me.shilong_btn.Location = New System.Drawing.Point(96, 10)
        Me.shilong_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.shilong_btn.Name = "shilong_btn"
        Me.shilong_btn.Size = New System.Drawing.Size(144, 47)
        Me.shilong_btn.TabIndex = 12
        Me.shilong_btn.Text = "Shilong"
        Me.shilong_btn.UseVisualStyleBackColor = False
        '
        'emergency_panel
        '
        Me.emergency_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.emergency_panel.Controls.Add(Me.Label8)
        Me.emergency_panel.Controls.Add(Me.txtsub)
        Me.emergency_panel.Controls.Add(Me.Send)
        Me.emergency_panel.Controls.Add(Me.Label9)
        Me.emergency_panel.Controls.Add(Me.Label10)
        Me.emergency_panel.Controls.Add(Me.choose)
        Me.emergency_panel.Controls.Add(Me.txtaddress)
        Me.emergency_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.emergency_panel.Location = New System.Drawing.Point(1662, 85)
        Me.emergency_panel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.emergency_panel.Name = "emergency_panel"
        Me.emergency_panel.Size = New System.Drawing.Size(896, 660)
        Me.emergency_panel.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(168, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Subject"
        '
        'txtsub
        '
        Me.txtsub.Location = New System.Drawing.Point(271, 222)
        Me.txtsub.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtsub.Name = "txtsub"
        Me.txtsub.Size = New System.Drawing.Size(412, 30)
        Me.txtsub.TabIndex = 27
        Me.txtsub.Text = "Emergency"
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(549, 564)
        Me.Send.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(137, 59)
        Me.Send.TabIndex = 26
        Me.Send.Text = "Send"
        Me.Send.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(168, 327)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(168, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Choose"
        '
        'choose
        '
        Me.choose.AllowDrop = True
        Me.choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.choose.FormattingEnabled = True
        Me.choose.Items.AddRange(New Object() {"Hospital", "Fire Station", "Police"})
        Me.choose.Location = New System.Drawing.Point(271, 158)
        Me.choose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.choose.Name = "choose"
        Me.choose.Size = New System.Drawing.Size(412, 24)
        Me.choose.TabIndex = 23
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(271, 297)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(412, 159)
        Me.txtaddress.TabIndex = 22
        Me.txtaddress.Text = "I need urgent help!!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "E-Rickshaw"
        '
        'erickshaw
        '
        Me.erickshaw.BackColor = System.Drawing.Color.White
        Me.erickshaw.BackgroundImage = CType(resources.GetObject("erickshaw.BackgroundImage"), System.Drawing.Image)
        Me.erickshaw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.erickshaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.erickshaw.Location = New System.Drawing.Point(40, 36)
        Me.erickshaw.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.erickshaw.Name = "erickshaw"
        Me.erickshaw.Size = New System.Drawing.Size(151, 114)
        Me.erickshaw.TabIndex = 1
        Me.erickshaw.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.erickshaw)
        Me.Panel7.Location = New System.Drawing.Point(613, 4)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(216, 150)
        Me.Panel7.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Controls.Add(Me.Button3)
        Me.Panel9.Location = New System.Drawing.Point(441, 283)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(459, 174)
        Me.Panel9.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 33)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cab"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(253, 37)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 111)
        Me.Button3.TabIndex = 1
        Me.Button3.UseVisualStyleBackColor = False
        '
        'panelERickshaw
        '
        Me.panelERickshaw.Controls.Add(Me.doubleClick)
        Me.panelERickshaw.Controls.Add(Me.lblSugg)
        Me.panelERickshaw.Controls.Add(Me.lblTemp)
        Me.panelERickshaw.Controls.Add(Me.e_fullData_dgv)
        Me.panelERickshaw.Controls.Add(Me.e_dgv)
        Me.panelERickshaw.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelERickshaw.Location = New System.Drawing.Point(0, -236)
        Me.panelERickshaw.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelERickshaw.Name = "panelERickshaw"
        Me.panelERickshaw.Size = New System.Drawing.Size(1403, 394)
        Me.panelERickshaw.TabIndex = 0
        '
        'doubleClick
        '
        Me.doubleClick.AutoSize = True
        Me.doubleClick.Location = New System.Drawing.Point(544, 405)
        Me.doubleClick.Name = "doubleClick"
        Me.doubleClick.Size = New System.Drawing.Size(250, 17)
        Me.doubleClick.TabIndex = 18
        Me.doubleClick.Text = "* Double click on Cell to Get Directions"
        '
        'lblSugg
        '
        Me.lblSugg.AutoSize = True
        Me.lblSugg.Location = New System.Drawing.Point(264, 46)
        Me.lblSugg.Name = "lblSugg"
        Me.lblSugg.Size = New System.Drawing.Size(55, 17)
        Me.lblSugg.TabIndex = 17
        Me.lblSugg.Text = "lblSugg"
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(593, 489)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(58, 17)
        Me.lblTemp.TabIndex = 16
        Me.lblTemp.Text = "lblTemp"
        Me.lblTemp.Visible = False
        '
        'e_fullData_dgv
        '
        Me.e_fullData_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.e_fullData_dgv.Location = New System.Drawing.Point(543, 494)
        Me.e_fullData_dgv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.e_fullData_dgv.Name = "e_fullData_dgv"
        Me.e_fullData_dgv.RowTemplate.Height = 24
        Me.e_fullData_dgv.Size = New System.Drawing.Size(11, 12)
        Me.e_fullData_dgv.TabIndex = 15
        Me.e_fullData_dgv.Visible = False
        '
        'e_dgv
        '
        Me.e_dgv.AllowUserToAddRows = False
        Me.e_dgv.AllowUserToDeleteRows = False
        Me.e_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.e_dgv.Location = New System.Drawing.Point(254, 132)
        Me.e_dgv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.e_dgv.Name = "e_dgv"
        Me.e_dgv.ReadOnly = True
        Me.e_dgv.RowTemplate.Height = 24
        Me.e_dgv.Size = New System.Drawing.Size(461, 236)
        Me.e_dgv.TabIndex = 14
        '
        'panelBus
        '
        Me.panelBus.Controls.Add(Me.lblInfoBus)
        Me.panelBus.Controls.Add(Me.btnSubmitBus)
        Me.panelBus.Controls.Add(Me.de_cb)
        Me.panelBus.Controls.Add(Me.s_cb)
        Me.panelBus.Controls.Add(Me.d_cb)
        Me.panelBus.Controls.Add(Me.lblSource)
        Me.panelBus.Controls.Add(Me.bus_dgv)
        Me.panelBus.Controls.Add(Me.time_lbl)
        Me.panelBus.Controls.Add(Me.t_lbl)
        Me.panelBus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBus.Location = New System.Drawing.Point(0, 158)
        Me.panelBus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelBus.Name = "panelBus"
        Me.panelBus.Size = New System.Drawing.Size(1403, 502)
        Me.panelBus.TabIndex = 2
        '
        'lblInfoBus
        '
        Me.lblInfoBus.AutoSize = True
        Me.lblInfoBus.Location = New System.Drawing.Point(308, 401)
        Me.lblInfoBus.Name = "lblInfoBus"
        Me.lblInfoBus.Size = New System.Drawing.Size(165, 17)
        Me.lblInfoBus.TabIndex = 25
        Me.lblInfoBus.Text = "No Bus Aviable right now"
        '
        'btnSubmitBus
        '
        Me.btnSubmitBus.Location = New System.Drawing.Point(399, 174)
        Me.btnSubmitBus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmitBus.Name = "btnSubmitBus"
        Me.btnSubmitBus.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmitBus.TabIndex = 24
        Me.btnSubmitBus.Text = "Sumbit"
        Me.btnSubmitBus.UseVisualStyleBackColor = True
        '
        'de_cb
        '
        Me.de_cb.FormattingEnabled = True
        Me.de_cb.Location = New System.Drawing.Point(557, 101)
        Me.de_cb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.de_cb.Name = "de_cb"
        Me.de_cb.Size = New System.Drawing.Size(121, 24)
        Me.de_cb.TabIndex = 23
        '
        's_cb
        '
        Me.s_cb.FormattingEnabled = True
        Me.s_cb.Location = New System.Drawing.Point(267, 107)
        Me.s_cb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.s_cb.Name = "s_cb"
        Me.s_cb.Size = New System.Drawing.Size(121, 24)
        Me.s_cb.TabIndex = 22
        '
        'd_cb
        '
        Me.d_cb.AutoSize = True
        Me.d_cb.Location = New System.Drawing.Point(451, 103)
        Me.d_cb.Name = "d_cb"
        Me.d_cb.Size = New System.Drawing.Size(79, 17)
        Me.d_cb.TabIndex = 21
        Me.d_cb.Text = "Destination"
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(179, 107)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(53, 17)
        Me.lblSource.TabIndex = 20
        Me.lblSource.Text = "Source"
        '
        'bus_dgv
        '
        Me.bus_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bus_dgv.Location = New System.Drawing.Point(143, 324)
        Me.bus_dgv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bus_dgv.Name = "bus_dgv"
        Me.bus_dgv.RowTemplate.Height = 24
        Me.bus_dgv.Size = New System.Drawing.Size(516, 150)
        Me.bus_dgv.TabIndex = 19
        '
        'time_lbl
        '
        Me.time_lbl.AutoSize = True
        Me.time_lbl.Location = New System.Drawing.Point(608, 42)
        Me.time_lbl.Name = "time_lbl"
        Me.time_lbl.Size = New System.Drawing.Size(51, 17)
        Me.time_lbl.TabIndex = 18
        Me.time_lbl.Text = "Label1"
        '
        't_lbl
        '
        Me.t_lbl.AutoSize = True
        Me.t_lbl.Location = New System.Drawing.Point(539, 42)
        Me.t_lbl.Name = "t_lbl"
        Me.t_lbl.Size = New System.Drawing.Size(39, 17)
        Me.t_lbl.TabIndex = 17
        Me.t_lbl.Text = "Time"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(27, 33)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(155, 114)
        Me.Button4.TabIndex = 0
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Label5)
        Me.Panel10.Controls.Add(Me.Button4)
        Me.Panel10.Location = New System.Drawing.Point(77, 46)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(379, 174)
        Me.Panel10.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(271, 70)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 33)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Bus"
        '
        'outcampus_panel
        '
        Me.outcampus_panel.Controls.Add(Me.Panel9)
        Me.outcampus_panel.Controls.Add(Me.Panel10)
        Me.outcampus_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.outcampus_panel.Location = New System.Drawing.Point(3857, 85)
        Me.outcampus_panel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.outcampus_panel.Name = "outcampus_panel"
        Me.outcampus_panel.Size = New System.Drawing.Size(1349, 660)
        Me.outcampus_panel.TabIndex = 2
        '
        'incampus_panel
        '
        Me.incampus_panel.Controls.Add(Me.panelERickshaw)
        Me.incampus_panel.Controls.Add(Me.panelBus)
        Me.incampus_panel.Controls.Add(Me.Panel7)
        Me.incampus_panel.Controls.Add(Me.Panel6)
        Me.incampus_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.incampus_panel.Location = New System.Drawing.Point(259, 85)
        Me.incampus_panel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.incampus_panel.Name = "incampus_panel"
        Me.incampus_panel.Size = New System.Drawing.Size(1403, 660)
        Me.incampus_panel.TabIndex = 9
        '
        'CabDataBindingSource
        '
        Me.CabDataBindingSource.DataMember = "CabData"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1736, 745)
        Me.Controls.Add(Me.outcampus_panel)
        Me.Controls.Add(Me.outstation_panel)
        Me.Controls.Add(Me.emergency_panel)
        Me.Controls.Add(Me.incampus_panel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.outstation_panel.ResumeLayout(False)
        Me.outstation_panel.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.emergency_panel.ResumeLayout(False)
        Me.emergency_panel.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.panelERickshaw.ResumeLayout(False)
        Me.panelERickshaw.PerformLayout()
        CType(Me.e_fullData_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.e_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBus.ResumeLayout(False)
        Me.panelBus.PerformLayout()
        CType(Me.bus_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.outcampus_panel.ResumeLayout(False)
        Me.incampus_panel.ResumeLayout(False)
        CType(Me.CabDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents emergency_btn As System.Windows.Forms.Button
    Friend WithEvents incampus_btn As System.Windows.Forms.Button
    Friend WithEvents outcampus_btn As System.Windows.Forms.Button
    Friend WithEvents outstation_btn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents login_btn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bus As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents outstation_panel As System.Windows.Forms.Panel
    Friend WithEvents emergency_panel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents erickshaw As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents panelERickshaw As System.Windows.Forms.Panel
    Friend WithEvents panelBus As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents outcampus_panel As System.Windows.Forms.Panel
    Friend WithEvents incampus_panel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtsub As System.Windows.Forms.RichTextBox
    Friend WithEvents Send As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents choose As System.Windows.Forms.ComboBox
    Friend WithEvents txtaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents passengers As System.Windows.Forms.TextBox
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents gang_btn As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents tawang_btn As System.Windows.Forms.Button
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents shilong_btn As System.Windows.Forms.Button
    Friend WithEvents CabDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents doubleClick As System.Windows.Forms.Label
    Friend WithEvents lblSugg As System.Windows.Forms.Label
    Friend WithEvents lblTemp As System.Windows.Forms.Label
    Friend WithEvents e_fullData_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents e_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents lblInfoBus As System.Windows.Forms.Label
    Friend WithEvents btnSubmitBus As System.Windows.Forms.Button
    Friend WithEvents de_cb As System.Windows.Forms.ComboBox
    Friend WithEvents s_cb As System.Windows.Forms.ComboBox
    Friend WithEvents d_cb As System.Windows.Forms.Label
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents bus_dgv As System.Windows.Forms.DataGridView
    Friend WithEvents time_lbl As System.Windows.Forms.Label
    Friend WithEvents t_lbl As System.Windows.Forms.Label

End Class
