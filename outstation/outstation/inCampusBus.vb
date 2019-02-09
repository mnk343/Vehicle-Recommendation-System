Public Class inCampusBus
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


    Private Sub inCampusBus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time_lbl.Text = DateTime.Now.ToShortTimeString
        

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

        



            End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim day As String = DateAndTime.Now.DayOfWeek
        Dim hour As Integer = DateAndTime.Now.Hour
        Dim minute As Integer = DateAndTime.Now.Minute

        Dim src As String = s_cb.Text
        Dim des As String = de_cb.Text

        'hour = 20
        'minute = 33
        ' RUN QUERY
        Access.AddParam("@src", "%" & src & "%")
        Access.AddParam("@des", "%" & des & "%")
        Access.ExecQuery("SELECT Source, Destination,Time FROM InCampusBusData WHERE Source LIKE @src AND Destination LIKE @des AND Hour >= " + CStr(hour) + " AND NOT ( Hour = " + CStr(hour) + " AND Minute <" + CStr(minute) + ");")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        bus_dgv.DataSource = Access.DBDT

        bus_dgv.Rows(0).DefaultCellStyle.BackColor = Color.Red
        bus_dgv.Rows(0).DefaultCellStyle.ForeColor = Color.White
        bus_dgv.ClearSelection()



    End Sub
End Class