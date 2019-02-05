Public Class frm_city_bus

    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


    Private Sub frm_city_bus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim day As String = DateAndTime.Now.DayOfWeek

        Access.AddParam("@day", "%" & day & "%")

        ' RUN QUERY
        Access.ExecQuery("SELECT Source, Destination,WorkingDays,time FROM BusData WHERE Type=1 AND WorkingDays LIKE @day")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgv_from_city_bus.DataSource = Access.DBDT
    End Sub
End Class