Public Class To_City_Bus

    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


    Private Sub To_City_Bus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clk_lbl.Text = DateAndTime.Now.DayOfWeek
        Dim day As String = DateAndTime.Now.DayOfWeek

        Access.AddParam("@day", "%" & day & "%")

        ' RUN QUERY
        Access.ExecQuery("SELECT Source, Destination,WorkingDays,time FROM BusData WHERE Type=0 AND WorkingDays LIKE @day")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        to_city_bus_dgv.DataSource = Access.DBDT
    End Sub
End Class