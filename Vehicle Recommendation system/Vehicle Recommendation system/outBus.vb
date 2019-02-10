Public Class outBus

    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


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


    Private Sub outBus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time_lbl.Text = DateTime.Now.ToShortTimeString
    End Sub

    Private Sub left_fill_pnl_Paint(sender As Object, e As PaintEventArgs) Handles left_fill_pnl.Paint

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




        to_city_bus_dgv.BorderStyle = BorderStyle.None
        to_city_bus_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        to_city_bus_dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        to_city_bus_dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
        to_city_bus_dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
        to_city_bus_dgv.BackgroundColor = Color.White

        to_city_bus_dgv.EnableHeadersVisualStyles = False
        to_city_bus_dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        to_city_bus_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
        to_city_bus_dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        to_city_bus_dgv.RowTemplate.Height = 22
        to_city_bus_dgv.DefaultCellStyle.Padding.Bottom.Equals(4)
        to_city_bus_dgv.DefaultCellStyle.Padding.Bottom.Equals(4)

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





        dgv_from_city_bus.BorderStyle = BorderStyle.None
        dgv_from_city_bus.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        dgv_from_city_bus.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv_from_city_bus.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
        dgv_from_city_bus.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
        dgv_from_city_bus.BackgroundColor = Color.White

        dgv_from_city_bus.EnableHeadersVisualStyles = False
        dgv_from_city_bus.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv_from_city_bus.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
        dgv_from_city_bus.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv_from_city_bus.RowTemplate.Height = 22
        dgv_from_city_bus.DefaultCellStyle.Padding.Bottom.Equals(4)
        dgv_from_city_bus.DefaultCellStyle.Padding.Bottom.Equals(4)








        dgv_from_city_bus.Rows(0).DefaultCellStyle.BackColor = Color.Red
        dgv_from_city_bus.Rows(0).DefaultCellStyle.ForeColor = Color.White
        dgv_from_city_bus.ClearSelection()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class