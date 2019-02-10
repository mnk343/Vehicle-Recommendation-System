Public Class Share

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
        Access.ExecQuery("SELECT Booking.BookingID, Booking.CabId, Booking.Driver, Booking.Occupancy, CabData.Seater , CabData.Seater - Booking.Occupancy AS SeatsLeft, Booking.Source, Booking.Destination, Booking.Hour, Booking.Minute, Booking.Day,  CabData.VehicleName FROM CabData RIGHT JOIN Booking ON CabData.CabId = Booking.CabId" + " WHERE Source = '" + source + "' AND Destination = '" + destination + "' AND Hour >= " + CStr(hours) + " AND NOT ( Hour = " + CStr(hours) + " AND Minute <" + CStr(minutes) + " )" + "AND (CabData.Seater - Booking.Occupancy) >= " + CStr(numofpassengers) + " AND Format(Booking.Day, 'Short Date') = '" + dat + "' " + "ORDER BY (100*Booking.Hour + Booking.Minute) Asc" + ";")
        '"AND Booking.Da = " + CStr(CInt(darray(0))) + " AND Booking.Mon = " + CStr(CInt(darray(1))) + " AND Booking.Yea = " + CStr(CInt(darray(2))) 

        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        Share_dgv.DataSource = Access.DBDT

        

        Dim newCol As New DataGridViewTextBoxColumn

        newCol.HeaderText = "Approx Fare after Sharing : "
        newCol.Name = "Approx Fare after Sharing : "
        newCol.Visible = True
        newCol.Width = 80

        Share_dgv.Columns.Add(newCol)

        For row_index As Integer = 0 To Share_dgv.RowCount - 1


            If (row_index <= Share_dgv.RowCount And row_index >= 0) Then

                If (CInt(Share_dgv.Rows(row_index).Cells(4).Value) = 0) Then


                Else

                    Dim factor As Integer = 1

                    Dim totFare = CDec(Maps.money.Text)

                    If CInt(Share_dgv.Rows(row_index).Cells(4).Value) >= 6 Then
                        factor = 1.5
                    ElseIf CInt(Share_dgv.Rows(row_index).Cells(4).Value) >= 8 Then
                        factor = 2.5
                    Else
                        factor = 1

                    End If

                    totFare *= factor
                    MessageBox.Show((Share_dgv.Rows(row_index).Cells(4).Value))
                    totFare /= CInt((Share_dgv.Rows(row_index).Cells(4).Value))
                    totFare *= CInt(cab_info.no_pass.Text)


                    If CInt(Share_dgv.Rows(row_index).Cells(4).Value) >= 6 Then
                        factor = 1.25
                    ElseIf CInt(Share_dgv.Rows(row_index).Cells(4).Value) >= 8 Then
                        factor = 1.5
                    Else
                        factor = 1
                    End If

                    If (totFare < 200) Then
                        totFare = 200
                    End If

                    Share_dgv.Rows(row_index).Cells(12).Value = totFare
                End If
            End If

            Share_dgv.Rows(0).DefaultCellStyle.BackColor = Color.Red
            Share_dgv.Rows(0).DefaultCellStyle.ForeColor = Color.White
            Share_dgv.ClearSelection()



        Next


    End Sub

    Private Sub Share_dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Share_dgv.CellContentClick

    End Sub
End Class

