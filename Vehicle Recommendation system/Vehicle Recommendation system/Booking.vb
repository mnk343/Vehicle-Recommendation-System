Imports System.Text
Imports System.Math

Public Class Booking

    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub NewBooking_dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles NewBooking_dgv.CellContentClick
        Dim row_index As Integer
        Dim query As New StringBuilder

        row_index = e.RowIndex

        row_index = e.RowIndex
        If row_index >= 0 Then
            Dim row As DataGridViewRow = NewBooking_FullData_dgv.Rows([row_index])

            Dim lat As String = row.Cells(1).Value.ToString
            Dim longi As String = row.Cells(0).Value.ToString
            'lbl.Text = row.Cells(2).Value.ToString

            ' query.Append("https://bing.com/maps/default.aspx?rtp=adr.")
            query.Append("https://bing.com/maps/default.aspx?sp=point.")
            query.Append(lat)
            query.Append("_")
            query.Append(longi)
            query.Append("_")
            query.Append(row.Cells(2).Value.ToString)
            query.Append("&lvl=15")
            Label1.Text = query.ToString()
            Label1.Hide()
            CabMap.Show()
        End If

    End Sub

    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim hours As Integer = CInt(cab_info.hour_tb.Text)
        'Dim hours As Integer = 15
        Dim dat As String
        Dim Day As String


        Day = cab_info.day_cb.Text


        If Day = "Today" Then

            dat = DateAndTime.Now.ToShortDateString


        ElseIf Day = "Tomorrow" Then
            dat = DateAndTime.Now.AddDays(1).ToShortDateString

        Else

            dat = DateAndTime.Now.AddDays(2).ToShortDateString

        End If
        'dat = "10-02-2019"
        Access.ExecQuery("SELECT CabData.CabId, CabData.UserName, CabData.Contact, CabData.Seater, CabData.VehicleName FROM CabData WHERE CabData.City = TRUE AND CabData.CabId NOT IN ( SELECT Booking.CabId FROM Booking WHERE " + CStr(hours) + " BETWEEN Booking.Hour - 1 AND Booking.Hour + 1 AND Format(Booking.Day, 'Short Date') = '" + dat + "') ;")




        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        NewBooking_dgv.DataSource = Access.DBDT


        Access.ExecQuery("SELECT CabData.Longitude, CabData.Latitude, CabData.UserName FROM CabData WHERE CabData.City = TRUE AND CabData.CabId NOT IN ( SELECT Booking.CabId FROM Booking WHERE " + CStr(hours) + " BETWEEN Booking.Hour - 1 AND Booking.Hour + 1 AND Format(Booking.Day, 'Short Date') = '" + dat + "') ;")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        NewBooking_FullData_dgv.DataSource = Access.DBDT
        NewBooking_FullData_dgv.Hide()

    End Sub
End Class