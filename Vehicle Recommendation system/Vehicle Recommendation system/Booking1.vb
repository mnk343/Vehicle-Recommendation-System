Imports System.Text
Imports System.Math

Public Class Booking1

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Access As New DBControl

    Private Sub Booking1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
11:
        Dim hours As Integer = CInt(cab_info.hour_tb.Text)
        'Dim hours As Integer = 15
        Dim dat As String
        Dim Day As String
        Dim numofpassengers
        numofpassengers = CInt(cab_info.no_pass.Text)

        Day = cab_info.day_cb.Text


        If Day = "Today" Then

            dat = DateAndTime.Now.ToShortDateString


        ElseIf Day = "Tomorrow" Then
            dat = DateAndTime.Now.AddDays(1).ToShortDateString

        Else

            dat = DateAndTime.Now.AddDays(2).ToShortDateString

        End If
        'dat = "10-02-2019"
        Access.ExecQuery("SELECT CabData.CabId, CabData.UserName, CabData.Contact, CabData.Seater, CabData.VehicleName FROM CabData WHERE CabData.City = TRUE AND CabData.Seater >= " + CStr(numofpassengers) + "   AND CabData.CabId NOT IN ( SELECT Booking.CabId FROM Booking WHERE " + CStr(hours) + " BETWEEN Booking.Hour - 1 AND Booking.Hour + 1 AND Format(Booking.Day, 'Short Date') = '" + dat + "') ;")

        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        NewBooking_dgv.DataSource = Access.DBDT


        Access.ExecQuery("SELECT CabData.Longitude, CabData.Latitude, CabData.UserName FROM CabData WHERE CabData.City = TRUE  AND CabData.Seater >= " + CStr(numofpassengers) + "   AND CabData.CabId NOT IN ( SELECT Booking.CabId FROM Booking WHERE " + CStr(hours) + " BETWEEN Booking.Hour - 1 AND Booking.Hour + 1 AND Format(Booking.Day, 'Short Date') = '" + dat + "') ;")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        NewBooking_FullData_dgv.DataSource = Access.DBDT
        NewBooking_FullData_dgv.Hide()



        Dim newCol As New DataGridViewTextBoxColumn

        newCol.HeaderText = "Approx Fare : "
        newCol.Name = "Approx Fare : "
        newCol.Visible = True
        newCol.Width = 80

        NewBooking_dgv.Columns.Add(newCol)

        For row_index As Integer = 0 To NewBooking_dgv.RowCount - 1

            
            If (row_index < NewBooking_dgv.RowCount) Then
                Dim factor As Integer = 1

                Dim totFare = CDec(Maps.money.Text)

                If CInt(NewBooking_dgv.Rows(row_index).Cells(3).Value) >= 6 Then
                    factor = 1.5
                ElseIf CInt(NewBooking_dgv.Rows(row_index).Cells(3).Value) >= 8 Then
                    factor = 2.5
                Else
                    factor = 1

                End If

                totFare *= factor
                NewBooking_dgv.Rows(row_index).Cells(5).Value = totFare
            End If

        Next

    End Sub

    Private Sub NewBooking_dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles NewBooking_dgv.CellDoubleClick
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

    Private Sub NewBooking_dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles NewBooking_dgv.CellContentClick

    End Sub
End Class