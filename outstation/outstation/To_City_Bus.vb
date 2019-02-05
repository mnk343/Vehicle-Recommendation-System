Public Class To_City_Bus

    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


    Private Sub To_City_Bus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clk_lbl.Text = DateAndTime.Now.ToShortTimeString
        Dim day As String = DateAndTime.Now.DayOfWeek
        Dim hour As Integer = DateAndTime.Now.Hour
        Dim minute As Integer = DateAndTime.Now.Minute




        Access.AddParam("@day", "%" & day & "%")

        'hour = 20
        'minute = 33
        ' RUN QUERY
        Access.ExecQuery("SELECT Source, Destination,WorkingDays,time FROM BusData WHERE Type=0 AND WorkingDays LIKE @day AND Hour >= " + CStr(hour) + " AND NOT ( Hour = " + CStr(hour) + " AND Minute <" + CStr(minute) + ") ")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        to_city_bus_dgv.DataSource = Access.DBDT

        to_city_bus_dgv.Rows(0).DefaultCellStyle.BackColor = Color.Red
        to_city_bus_dgv.Rows(0).DefaultCellStyle.ForeColor = Color.White
        to_city_bus_dgv.ClearSelection()





    End Sub
End Class