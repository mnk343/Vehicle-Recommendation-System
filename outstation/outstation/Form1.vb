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
End Class
