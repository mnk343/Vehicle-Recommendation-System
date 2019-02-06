Public Class Form1

    Dim check As Integer
    Dim NoPassengers As Integer

    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvData.Visible = False
        info.visible = True

        check = 1
        NoPassengers = 0

        ' RUN QUERY
        Access.ExecQuery("SELECT CabId, UserName, Contact FROM CabData WHERE Status = TRUE;")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT
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

    Private Sub shilong_btn_MouseClick(sender As Object, e As MouseEventArgs) Handles shilong_btn.MouseClick
        shilong_btn.BackColor = Color.SkyBlue

    End Sub


    Private Sub shilong_btn_MouseHover(sender As Object, e As EventArgs) Handles shilong_btn.MouseHover
        shilong_btn.BackColor = Color.LightGray

    End Sub

    Private Sub shilong_btn_MouseLeave(sender As Object, e As EventArgs) Handles shilong_btn.MouseLeave
        shilong_btn.BackColor = Color.White
    End Sub



    Private Sub tawang_btn_MouseClick(sender As Object, e As MouseEventArgs) Handles tawang_btn.MouseClick
        tawang_btn.BackColor = Color.SkyBlue

    End Sub


    Private Sub tawang_btn_MouseHover(sender As Object, e As EventArgs) Handles tawang_btn.MouseHover
        tawang_btn.BackColor = Color.LightGray

    End Sub

    Private Sub tawang_btn_MouseLeave(sender As Object, e As EventArgs) Handles tawang_btn.MouseLeave
        tawang_btn.BackColor = Color.White
    End Sub



    Private Sub gang_btn_MouseClick(sender As Object, e As MouseEventArgs) Handles gang_btn.MouseClick
        gang_btn.BackColor = Color.SkyBlue

    End Sub


    Private Sub gang_btn_MouseHover(sender As Object, e As EventArgs) Handles gang_btn.MouseHover
        gang_btn.BackColor = Color.LightGray

    End Sub

    Private Sub gang_btn_MouseLeave(sender As Object, e As EventArgs) Handles gang_btn.MouseLeave
        gang_btn.BackColor = Color.White
    End Sub


    Private Sub submit_MouseClick(sender As Object, e As MouseEventArgs) Handles submit.MouseClick
        submit.BackColor = Color.SkyBlue

    End Sub


    Private Sub submit_MouseHover(sender As Object, e As EventArgs) Handles submit.MouseHover
        submit.BackColor = Color.LightGray

    End Sub

    Private Sub submit_MouseLeave(sender As Object, e As EventArgs) Handles submit.MouseLeave
        submit.BackColor = Color.Black
    End Sub


    Private Sub clear_MouseClick(sender As Object, e As MouseEventArgs) Handles clear.MouseClick
        clear.BackColor = Color.SkyBlue

    End Sub


    Private Sub clear_MouseHover(sender As Object, e As EventArgs) Handles clear.MouseHover
        clear.BackColor = Color.LightGray

    End Sub

    Private Sub clear_MouseLeave(sender As Object, e As EventArgs) Handles clear.MouseLeave
        clear.BackColor = Color.Black
    End Sub

    

   
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
