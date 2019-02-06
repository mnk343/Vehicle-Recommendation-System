Public Class bus
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


    Private Sub OutCampus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time_lbl.Text = DateTime.Now.ToShortTimeString
    End Sub

    Private Sub from_city_lbl_Click(sender As Object, e As EventArgs) Handles from_city_lbl.Click
        to_pnl.Hide()

        to_city_lbl.BackColor = Color.White
        from_city_lbl.BackColor = Color.Blue

        to_city_lbl.ForeColor = Color.Black
        from_city_lbl.ForeColor = Color.White



    End Sub


    Private Sub to_city_lbl_Click(sender As Object, e As EventArgs) Handles to_city_lbl.Click




        to_pnl.Show()
        to_city_lbl.BackColor = Color.Blue
        from_city_lbl.BackColor = Color.White

        to_city_lbl.ForeColor = Color.White
        from_city_lbl.ForeColor = Color.Black


    End Sub




    Private Sub to_pnl_Paint(sender As Object, e As PaintEventArgs) Handles to_pnl.Paint

        Dim day As String = DateAndTime.Now.DayOfWeek
        Dim hour As Integer = DateAndTime.Now.Hour
        Dim minute As Integer = DateAndTime.Now.Minute




        Access.AddParam("@day", "%" & day & "%")

        'hour = 20
        'minute = 33
        ' RUN QUERY
        Access.ExecQuery("SELECT TOP 5 Source, Destination,time FROM BusData WHERE Type=0 AND WorkingDays LIKE @day AND Hour >= " + CStr(hour) + " AND NOT ( Hour = " + CStr(hour) + " AND Minute <" + CStr(minute) + ");")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        to_city_bus_dgv.DataSource = Access.DBDT

        to_city_bus_dgv.Rows(0).DefaultCellStyle.BackColor = Color.Red
        to_city_bus_dgv.Rows(0).DefaultCellStyle.ForeColor = Color.White
        to_city_bus_dgv.ClearSelection()


    End Sub

    Private Sub from_pnl_Paint(sender As Object, e As PaintEventArgs) Handles from_pnl.Paint


        Dim day As String = DateAndTime.Now.DayOfWeek
        Dim hour As Integer = DateAndTime.Now.Hour
        Dim minute As Integer = DateAndTime.Now.Minute
        Access.AddParam("@day", "%" & day & "%")



        ' RUN QUERY
        Access.ExecQuery("SELECT TOP 5 Source, Destination,time FROM BusData WHERE Type=1 AND WorkingDays LIKE @day AND Hour >= " + CStr(hour) + " AND NOT ( Hour = " + CStr(hour) + " AND Minute <" + CStr(minute) + ") ")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgv_from_city_bus.DataSource = Access.DBDT

        dgv_from_city_bus.Rows(0).DefaultCellStyle.BackColor = Color.Red
        dgv_from_city_bus.Rows(0).DefaultCellStyle.ForeColor = Color.White
        dgv_from_city_bus.ClearSelection()
    End Sub
End Class