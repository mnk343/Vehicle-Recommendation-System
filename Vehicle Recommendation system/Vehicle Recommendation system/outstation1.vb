Public Class outstation1

    Dim check As Integer
    Dim NoPassengers As Integer
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


    Private Sub outstation1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        dgvData.BackgroundColor = Color.White

        dgvData.EnableHeadersVisualStyles = False
        dgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
        dgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvData.RowTemplate.Height = 22
        dgvData.DefaultCellStyle.Padding.Bottom.Equals(4)
        dgvData.DefaultCellStyle.Padding.Bottom.Equals(4)
        'dgvData.AutoSizeColumnsMode







    End Sub

    Private Sub shilong_btn_Click(sender As Object, e As EventArgs) Handles shilong_btn.Click

        dgvData.Visible = True
        info.Visible = False

        check = 1

        ' RUN QUERY
        Access.ExecQuery("SELECT CabId, UserName, Contact, ShillongTrips , VehicleName, Seater FROM CabData WHERE Shillong = TRUE AND Status = TRUE AND Seater >= " + CStr(NoPassengers) + " ORDER BY ShillongTrips DESC;")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT
    End Sub

    Private Sub tawang_btn_Click(sender As Object, e As EventArgs) Handles tawang_btn.Click

        dgvData.Visible = True
        info.Visible = False

        check = 2

        ' RUN QUERY

        Access.ExecQuery("SELECT CabId, UserName, Contact, TawangTrips, VehicleName,Seater FROM CabData WHERE Tawang = TRUE AND Status = TRUE AND Seater >= " + CStr(NoPassengers) + " ORDER BY TawangTrips DESC;")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT
    End Sub

    Private Sub gang_btn_Click(sender As Object, e As EventArgs) Handles gang_btn.Click

        dgvData.Visible = True
        info.Visible = False

        check = 3

        ' RUN QUERY
        Access.ExecQuery("SELECT CabId, UserName, Contact, GangtokTrips, VehicleName,Seater FROM CabData WHERE Gangtok = TRUE AND Status = TRUE AND Seater >= " + CStr(NoPassengers) + " ORDER BY GangtokTrips DESC;")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT
    End Sub


    Private Sub SearchMember(Name As String)
        ' ADD PARAMETERS & RUN QUERY
        Access.AddParam("@user", "%" & Name & "%")
        Access.ExecQuery("SELECT CabId, UserName, Contact " & _
                         "FROM CabData " & _
                         "WHERE UserName LIKE @user AND Status = TRUE")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRIDVIEW
        dgvData.DataSource = Access.DBDT
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click

        passengers.Text = ""
        NoPassengers = 0
        submit_Click(sender, e)
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click

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

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
        Form1.Show()

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


End Class
