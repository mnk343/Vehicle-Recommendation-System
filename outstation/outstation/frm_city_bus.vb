Public Class frm_city_bus

    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


    Private Sub frm_city_bus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time_lbl.Text = DateAndTime.Now.ToShortTimeString

        Dim day As String = DateAndTime.Now.DayOfWeek
        Dim hour As Integer = DateAndTime.Now.Hour
        Dim minute As Integer = DateAndTime.Now.Minute
        Access.AddParam("@day", "%" & day & "%")



        ' RUN QUERY
        Access.ExecQuery("SELECT Source, Destination,WorkingDays,time FROM BusData WHERE Type=1 AND WorkingDays LIKE @day AND Hour >= " + CStr(hour) + " AND NOT ( Hour = " + CStr(hour) + " AND Minute <" + CStr(minute) + ") ")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgv_from_city_bus.DataSource = Access.DBDT

        dgv_from_city_bus.Rows(0).DefaultCellStyle.BackColor = Color.Red
        dgv_from_city_bus.Rows(0).DefaultCellStyle.ForeColor = Color.White
        dgv_from_city_bus.ClearSelection()


    End Sub
End Class