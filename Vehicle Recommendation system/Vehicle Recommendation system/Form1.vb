Imports System.Net.Mail
Imports System.Text
Imports System.Math
Imports System.Data.OleDb
Imports System.Data


Public Class Form1
    Private Access As New DBControl
    Dim bs As Integer
    Dim ch As Integer
    Dim driver As String = "Temp"
    Dim check As Integer
    Dim NoPassengers As Integer
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


    Private Sub outstation_Click(sender As Object, e As EventArgs)
        Me.Hide()
        outstation1.Show()
    End Sub

    Private Sub outCampus_Click(sender As Object, e As EventArgs)
        Me.Hide()
        OutCampus1.Show()
    End Sub


    Private Sub login_Click(sender As Object, e As EventArgs)
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ch = 0
        bs = 0
        panelERickshaw.Hide()
        panelBus.Hide()
        incampus_panel.Hide()
        outstation_panel.Hide()
        outcampus_panel.Hide()
        emergency_panel.Hide()

        'MessageBox.Show(DateTime.Now.ToString("MM/dd/yyyy"))
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\mayan\Desktop\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"
        Dim conn = New OleDbConnection(dbsource)
        Dim querry As String

        querry = " DELETE * FROM [Booking] WHERE [Day] < #" + DateTime.Now.ToString("MM/dd/yyyy") + "# ; "
        conn = New OleDbConnection(dbsource)
        Dim cmd As New OleDbCommand(querry, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()




    End Sub

    Private Sub inCampus_Click(sender As Object, e As EventArgs)

        Me.Hide()
        toCampus.Show()

    End Sub

    Private Sub emergency_Click(sender As Object, e As EventArgs)
        emergencyService.Show()
        Me.Hide()

    End Sub


    Private Sub emergency_btn_Click(sender As Object, e As EventArgs) Handles emergency_btn.Click

        incampus_panel.Hide()
        outstation_panel.Hide()
        outcampus_panel.Hide()
        emergency_panel.Show()


    End Sub

    Private Sub incampus_btn_Click(sender As Object, e As EventArgs) Handles incampus_btn.Click

        Panel12.Hide()

        incampus_panel.Show()
        outstation_panel.Hide()
        outcampus_panel.Hide()
        emergency_panel.Hide()

        panelERickshaw.Hide()


    End Sub

    Private Sub outcampus_btn_Click(sender As Object, e As EventArgs) Handles outcampus_btn.Click

        incampus_panel.Hide()
        outstation_panel.Hide()
        outcampus_panel.Show()
        emergency_panel.Hide()

    End Sub

    Private Sub outstation_btn_Click(sender As Object, e As EventArgs) Handles outstation_btn.Click
        lblError.Hide()

        incampus_panel.Hide()
        outstation_panel.Show()
        outcampus_panel.Hide()
        emergency_panel.Hide()


        dgvData.Visible = False
        info.Visible = True

        check = 1
        NoPassengers = 0

        ' RUN QUERY
        Access.ExecQuery("SELECT CabId, UserName, Contact FROM CabData WHERE Status = TRUE;")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT

        dgvData.BorderStyle = BorderStyle.None
        dgvData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgvData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvData.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
        dgvData.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
       
        dgvData.EnableHeadersVisualStyles = False
        dgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
        dgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvData.RowTemplate.Height = 22
        dgvData.DefaultCellStyle.Padding.Bottom.Equals(4)
        dgvData.DefaultCellStyle.Padding.Bottom.Equals(4)
        'dgvData.AutoSizeColumnsMode





    End Sub

    Private Sub emergency_panel_Paint(sender As Object, e As PaintEventArgs) Handles emergency_panel.Paint

    End Sub

    Private Sub Send_Click(sender As Object, e As EventArgs) Handles Send.Click

        Dim textTo As String = ""

        If txtsub.Text.Length = 0 Then
            MessageBox.Show("Write a proper Subject,Else a common Subject will be sent")
            txtsub.Text &= "Need Help"
        End If

        If choose.Text = "Hospital" Then
            textTo = "annanyapr@gmail.com"

        ElseIf choose.Text = "Fire Station" Then
            textTo = "avira170101014@iitg.ac.in"

        ElseIf choose.Text = "Police" Then
            textTo = "arany170101011@iitg.ac.in"

        End If
        Try
            Dim Smtp_Server As New SmtpClient
            Dim email As New MailMessage
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("softwarelab25@gmail.com", "Software123")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            email = New MailMessage
            email.From = New MailAddress("softwarelab25@gmail.com")
            email.To.Add(textTo)
            email.Subject = txtsub.Text
            email.IsBodyHtml = True
            email.Body = txtaddress.Text
            Smtp_Server.Send(email)
            MessageBox.Show("Message has been sent", "Success")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click

        lblError.Hide()

        dgvData.Visible = True
        info.Visible = False

        If passengers.Text = "" Then
            NoPassengers = 0
        Else
            NoPassengers = CInt(passengers.Text)
        End If

        If check = 1 Then
            shilong_btn_Click(sender, e)

        ElseIf check = 2 Then
            tawang_btn_Click(sender, e)

        ElseIf check = 3 Then
            gang_btn_Click(sender, e)
        End If
    End Sub

    Private Sub shilong_btn_Click(sender As Object, e As EventArgs) Handles shilong_btn.Click
        dgvData.Visible = True
        info.Visible = False
        lblError.Hide()

        check = 1

        If (passengers.Text.Length > 0) Then
            NoPassengers = CInt(passengers.Text)
        End If

        ' RUN QUERY
        Access.ExecQuery("SELECT CabId, UserName, Contact, ShillongTrips , VehicleName, Seater FROM CabData WHERE Shillong = TRUE AND Status = TRUE AND Seater >= " + CStr(NoPassengers) + " ORDER BY ShillongTrips DESC;")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT

        If dgvData.RowCount = 0 Then
            dgvData.Hide()
            lblError.Show()
            '
        End If
    End Sub

    Private Sub tawang_btn_Click(sender As Object, e As EventArgs) Handles tawang_btn.Click
        dgvData.Visible = True
        info.Visible = False
        lblError.Hide()

        check = 2

        If (passengers.Text.Length > 0) Then
            NoPassengers = CInt(passengers.Text)
        End If


        ' RUN QUERY

        Access.ExecQuery("SELECT CabId, UserName, Contact, TawangTrips, VehicleName,Seater FROM CabData WHERE Tawang = TRUE AND Status = TRUE AND Seater >= " + CStr(NoPassengers) + " ORDER BY TawangTrips DESC;")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT


        If dgvData.RowCount = 0 Then
            dgvData.Hide()
            lblError.Show()
        End If
    End Sub

    Private Sub gang_btn_Click(sender As Object, e As EventArgs) Handles gang_btn.Click
        dgvData.Visible = True
        info.Visible = False
        lblError.Hide()

        check = 3
        If (passengers.Text.Length > 0) Then
            NoPassengers = CInt(passengers.Text)
        End If


        ' RUN QUERY
        Access.ExecQuery("SELECT CabId, UserName, Contact, GangtokTrips, VehicleName,Seater FROM CabData WHERE Gangtok = TRUE AND Status = TRUE AND Seater >= " + CStr(NoPassengers) + " ORDER BY GangtokTrips DESC;")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT

        
        If dgvData.RowCount = 0 Then
            dgvData.Hide()
            lblError.Show()
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        passengers.Text = ""
        NoPassengers = 0
        submit_Click(sender, e)
    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        Me.Hide()
        outBus.Show()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Me.Hide()
        cab_info.Show()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub erickshaw_Click(sender As Object, e As EventArgs) Handles erickshaw.Click

        Access.ExecQuery("SELECT UserName,Contact FROM [E-RickshawData] WHERE Status=TRUE")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        
            panelERickshaw.Show()
            panelBus.Hide()
            ' FILL DATAGRID
        e_dgv.DataSource = Nothing
        e_fullData_dgv.DataSource = Nothing
        e_dgv.Columns.Clear()
        e_dgv.Rows.Clear()
        e_fullData_dgv.Rows.Clear()
        e_fullData_dgv.Columns.Clear()


        e_dgv.DataSource = Access.DBDT


            Access.ExecQuery("SELECT Latitude,Longitude,UserName FROM [E-RickshawData] WHERE Status=TRUE")
            If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

            ' FILL DATAGRID
            e_fullData_dgv.DataSource = Access.DBDT

            Dim min As Double = 1000000
            Dim lat1 As Double = 26.192824   ' Of User
            Dim lon1 As Double = 91.695249   ' Of User 
            Dim R As Double = 6371

            Dim driver As String = "Temp"
            Dim row_of_driver As Integer = 0


            Dim newCol As New DataGridViewTextBoxColumn

            newCol.HeaderText = "Distance"
            newCol.Name = "Distance"
            newCol.Visible = True
            newCol.Width = 80

            e_dgv.Columns.Add(newCol)

            For row_index As Integer = 0 To e_fullData_dgv.RowCount - 1


                Dim lat2 As Double = e_fullData_dgv.Rows(row_index).Cells(0).Value
                Dim lon2 As Double = e_fullData_dgv.Rows(row_index).Cells(1).Value

                Dim dlat As Double = (lat2 - lat1) * (Math.PI / 180)
                Dim dLon As Double = (lon2 - lon1) * (Math.PI / 180)
                Dim a As Double = Math.Sin(dlat / 2) * Math.Sin(dlat / 2) +
                                    Math.Cos((lat2) * (Math.PI / 180)) * Math.Cos((lat2) * (Math.PI / 180)) *
                                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2)

                Dim d As Double = R * 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a))
                d *= 1000
                d = Math.Round(d, 3)
                Dim distance As String = CStr(d)
                distance += " m"

                If (row_index <= e_dgv.RowCount - 1) Then
                    e_dgv.Rows(row_index).Cells(2).Value = distance
                End If

                If d < min Then
                    min = d
                    driver = e_dgv.Rows(row_index).Cells(0).Value

                    row_of_driver = row_index
                End If


            Next
            If row_of_driver >= 0 And row_of_driver < e_dgv.RowCount Then
                Dim sug As String = "Closest Driver from you is " + driver + " at distance " + e_dgv.Rows(row_of_driver).Cells(2).Value + " meters"
                lblSugg.Text = sug


                e_dgv.BorderStyle = BorderStyle.None
                e_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
                e_dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
                e_dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
                e_dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke


                e_dgv.EnableHeadersVisualStyles = False
                e_dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
                e_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
                e_dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                e_dgv.RowTemplate.Height = 22
                e_dgv.DefaultCellStyle.Padding.Bottom.Equals(4)
                e_dgv.DefaultCellStyle.Padding.Bottom.Equals(4)




                e_dgv.Rows(row_of_driver).DefaultCellStyle.BackColor = Color.Red
                e_dgv.Rows(row_of_driver).DefaultCellStyle.ForeColor = Color.White
            End If



    End Sub

    Private Sub e_dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles e_dgv.CellDoubleClick
        Dim row_index As Integer
        Dim query As New StringBuilder
        row_index = e.RowIndex
        If row_index >= 0 Then
            Dim row As DataGridViewRow = e_fullData_dgv.Rows([row_index])

            Dim lat As String = row.Cells(0).Value.ToString
            Dim longi As String = row.Cells(1).Value.ToString

            'rtp=pos.42.2_-122.3~pos.55.2_-127.0
            query.Append("https://bing.com/maps/default.aspx?rtp=pos.26.192824_91.695249~pos.")
            'query.Append("https://bing.com/maps/default.aspx?sp=point.")
            query.Append(lat)
            query.Append("_")
            query.Append(longi)
            'query.Append("_")
            'query.Append(row.Cells(2).Value.ToString)
            query.Append("&lvl=15")
            lblTemp.Text = query.ToString
            query.Append("&sp=point.")
            query.Append(lat)
            query.Append("_")
            query.Append(longi)
            query.Append("_")
            query.Append(row.Cells(2).Value.ToString)
            rickshaw_map.Show()

        End If
    End Sub

    
    Private Sub w1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bus_Click(sender As Object, e As EventArgs) Handles bus.Click

        time_lbl.Text = DateTime.Now.ToShortTimeString
        If bs > 0 Then

        Else
            bs += 1

            s_cb.Items.Add("E Type")
            s_cb.Items.Add("Admin")
            s_cb.Items.Add("Kameng")
            s_cb.Items.Add("Core 4")
            s_cb.Items.Add("Core 1")
            s_cb.Items.Add("Dhansari")

            de_cb.Items.Add("Admin")
            de_cb.Items.Add("Hospital")
            de_cb.Items.Add("Core 1")
            de_cb.Items.Add("KV")
        End If

        panelBus.Show()
        panelERickshaw.Hide()
        lblInfoBus.Hide()
    End Sub

    Private Sub btnSubmitBus_Click(sender As Object, e As EventArgs) Handles btnSubmitBus.Click
        Panel12.Show()

        bus_dgv.Show()

        lblInfoBus.Hide()
        Dim day As String = DateAndTime.Now.DayOfWeek
        Dim hour As Integer = DateAndTime.Now.Hour
        Dim minute As Integer = DateAndTime.Now.Minute

        Dim src As String = s_cb.Text
        Dim des As String = de_cb.Text

        If String.Compare(src, des) = 0 Then
            MessageBox.Show("source and destination must be diffrent")
        ElseIf String.Compare(src, "") = 0 Then
            MessageBox.Show("Select Source")

        ElseIf String.Compare("", des) = 0 Then
            MessageBox.Show("Select Destination")
        Else
            Access.AddParam("@src", "%" & src & "%")
            Access.AddParam("@des", "%" & des & "%")
            Access.ExecQuery("SELECT Source, Destination,Time FROM InCampusBusData WHERE Source LIKE @src AND Destination LIKE @des AND Hour >= " + CStr(hour) + " AND NOT ( Hour = " + CStr(hour) + " AND Minute <" + CStr(minute) + ");")
            If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

            ' FILL DATAGRID
            bus_dgv.DataSource = Access.DBDT



            bus_dgv.BorderStyle = BorderStyle.None
            bus_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
            bus_dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            bus_dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
            bus_dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke

            bus_dgv.EnableHeadersVisualStyles = False
            bus_dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            bus_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
            bus_dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            bus_dgv.RowTemplate.Height = 22
            bus_dgv.DefaultCellStyle.Padding.Bottom.Equals(4)
            bus_dgv.DefaultCellStyle.Padding.Bottom.Equals(4)

            If bus_dgv.RowCount = 1 Then
                bus_dgv.Hide()
                lblInfoBus.Show()
            End If


            bus_dgv.Rows(0).DefaultCellStyle.BackColor = Color.Red
            bus_dgv.Rows(0).DefaultCellStyle.ForeColor = Color.White
            bus_dgv.ClearSelection()

        End If

    End Sub

    Private Sub panelERickshaw_Paint(sender As Object, e As PaintEventArgs) Handles panelERickshaw.Paint

    End Sub

    Private Sub outstation_panel_Paint(sender As Object, e As PaintEventArgs) Handles outstation_panel.Paint

    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Me.Hide()
        loginForm.Show()

    End Sub

    Private Sub passengers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles passengers.KeyPress


        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label5_Click(sender, e)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label4_Click(sender,e)
    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub

    Private Sub bus_dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bus_dgv.CellContentClick

    End Sub
End Class