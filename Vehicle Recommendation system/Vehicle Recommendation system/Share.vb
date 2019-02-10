﻿Public Class Share

    Dim source As String
    Dim destination As String
    Dim numofpassengers As Integer
    Dim hours As Integer
    Dim minutes As Integer
    Dim day As String

    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


    Private Sub Share_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        source = cab_info.src_cb.Text
        destination = cab_info.des_cb.Text
        numofpassengers = CInt(cab_info.no_pass.Text)
        hours = CInt(cab_info.hour_tb.Text)
        minutes = CInt(cab_info.min_tb.Text)
        day = cab_info.day_cb.Text
        'Dim darray() As String

        Dim dat As String
        If day = "Today" Then

            dat = DateAndTime.Now.ToShortDateString


        ElseIf day = "Tomorrow" Then
            dat = DateAndTime.Now.AddDays(1).ToShortDateString

        Else

            dat = DateAndTime.Now.AddDays(2).ToShortDateString

        End If
        'source = "IIT Guwahati"
        'destination = "Airport"
        'hours = 10
        'minutes = 45
        'dat = "10-02-2019"


        'numofpassengers = 1
        'darray = dat.Split("-")
        'date_lbl.Text = darray(2)


        'Access.ExecQuery(";")
        Access.ExecQuery("SELECT Booking.BookingID, Booking.CabId, Booking.Driver, Booking.Occupancy, CabData.Seater, CabData.Seater - Booking.Occupancy AS SeatsLeft, Booking.Source, Booking.Destination, Booking.Hour, Booking.Minute, Booking.Day,  CabData.VehicleName FROM CabData RIGHT JOIN Booking ON CabData.CabId = Booking.CabId" + " WHERE Source = '" + source + "' AND Destination = '" + destination + "' AND Hour >= " + CStr(hours) + " AND NOT ( Hour = " + CStr(hours) + " AND Minute <" + CStr(minutes) + " )" + "AND (CabData.Seater - Booking.Occupancy) >= " + CStr(numofpassengers) + " AND Format(Booking.Day, 'Short Date') = '" + dat + "' " + "ORDER BY (100*Booking.Hour + Booking.Minute) Asc" + ";")
        '"AND Booking.Da = " + CStr(CInt(darray(0))) + " AND Booking.Mon = " + CStr(CInt(darray(1))) + " AND Booking.Yea = " + CStr(CInt(darray(2))) 

        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        Share_dgv.DataSource = Access.DBDT

        Share_dgv.Rows(0).DefaultCellStyle.BackColor = Color.Red
        Share_dgv.Rows(0).DefaultCellStyle.ForeColor = Color.White
        Share_dgv.ClearSelection()
    End Sub
End Class

