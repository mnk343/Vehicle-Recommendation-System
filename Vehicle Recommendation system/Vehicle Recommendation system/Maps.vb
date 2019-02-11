Imports System.Text
Imports System.Math

Public Class Maps

    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Dim fare As Decimal

    Private Sub map_browser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub CalculateFare(dist As Decimal)

        fare = 50
        If dist > 2 Then
            If dist > 10 Then
                fare += 8 * 20
                fare += (dist - 10) * 15
            Else
                fare += (dist - 2) * 20
            End If

        End If
    End Sub


    Private Sub Maps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Hide()
        Panel4.Hide()

        Try
            Dim query As New StringBuilder
            Me.WindowState = FormWindowState.Maximized

            Dim src As String
            Dim des As String

            Dim iitg As String = "IIT Guwahati"
            Dim kam As String = "Kamakhya"
            Dim air As String = "Airport"
            Dim pb As String = "Pan Bazar"
            Dim rail As String = "Railway"
            Dim distance As Decimal

            src = cab_info.src_cb.Text
            des = cab_info.des_cb.Text

            If String.Compare(src, iitg) = 0 Or String.Compare(des, iitg) = 0 Then
                If String.Compare(src, kam) = 0 Or String.Compare(des, kam) = 0 Then
                    distance = 14.3
                End If
                If String.Compare(src, pb) = 0 Or String.Compare(des, pb) = 0 Then
                    distance = 19.4
                End If
                If String.Compare(src, rail) = 0 Or String.Compare(des, rail) = 0 Then
                    distance = 19.7
                End If

                If String.Compare(src, air) = 0 Or String.Compare(des, air) = 0 Then
                    distance = 23.6
                End If
            End If

            If String.Compare(src, kam) = 0 Or String.Compare(des, kam) = 0 Then

                If String.Compare(src, pb) = 0 Or String.Compare(des, pb) = 0 Then
                    distance = 9.1
                End If
                If String.Compare(src, rail) = 0 Or String.Compare(des, rail) = 0 Then
                    distance = 9.4
                End If

                If String.Compare(src, air) = 0 Or String.Compare(des, air) = 0 Then
                    distance = 17.8
                End If

            End If

            If String.Compare(src, kam) = 0 Or String.Compare(des, kam) = 0 Then

                If String.Compare(src, pb) = 0 Or String.Compare(des, pb) = 0 Then
                    distance = 9.1
                End If
                If String.Compare(src, rail) = 0 Or String.Compare(des, rail) = 0 Then
                    distance = 9.4
                End If

                If String.Compare(src, air) = 0 Or String.Compare(des, air) = 0 Then
                    distance = 17.8
                End If

            End If

            If String.Compare(src, pb) = 0 Or String.Compare(des, pb) = 0 Then


                If String.Compare(src, rail) = 0 Or String.Compare(des, rail) = 0 Then
                    distance = 1.2
                End If

                If String.Compare(src, air) = 0 Or String.Compare(des, air) = 0 Then
                    distance = 22.9
                End If

            End If

            If String.Compare(src, rail) = 0 Or String.Compare(des, rail) = 0 Then

                If String.Compare(src, air) = 0 Or String.Compare(des, air) = 0 Then
                    distance = 7.0
                End If

            End If

            showDist.Text = CStr(distance)
            CalculateFare(distance)
            money.Text = fare

            query.Append("https://bing.com/maps/default.aspx?rtp=adr.")

            If String.Compare(des, iitg) = 0 Then
                des = "IIT%20Guwahati"
            End If

            If String.Compare(des, pb) = 0 Then
                des = "Pan%20Bazzar"
            End If

            If String.Compare(des, rail) = 0 Then
                des = "Guwahati%20Railway%20Station"
            End If


            If String.Compare(src, iitg) = 0 Then
                src = "IIT%20Guwahati"
            End If

            If String.Compare(src, pb) = 0 Then
                src = "Pan%20Bazzar"
            End If

            If String.Compare(src, rail) = 0 Then
                src = "Guwahati%20Railway%20Station"
            End If

            query.Append(src)
            query.Append("~adr.")
            query.Append(des)

            map_browser.Navigate(query.ToString)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Dim hours As Integer = CInt(cab_info.hour_tb.Text)
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

                Dim totFare = CDec(money.Text)

                If NewBooking_dgv.Rows(row_index).Cells(3).Value = 0 Then

                ElseIf CInt(NewBooking_dgv.Rows(row_index).Cells(3).Value) >= 6 Then
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


        NewBooking_dgv.BorderStyle = BorderStyle.None
        NewBooking_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        NewBooking_dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        NewBooking_dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
        NewBooking_dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke

        NewBooking_dgv.EnableHeadersVisualStyles = False
        NewBooking_dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        NewBooking_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
        NewBooking_dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        NewBooking_dgv.RowTemplate.Height = 22
        NewBooking_dgv.DefaultCellStyle.Padding.Bottom.Equals(4)
        NewBooking_dgv.DefaultCellStyle.Padding.Bottom.Equals(4)
    End Sub

    Private Sub Booking_Click(sender As Object, e As EventArgs) Handles Booking.Click
        Label1.Hide()
        Panel3.Show()
        Panel4.Hide()

        NewBooking_FullData_dgv.Hide()

        

    End Sub

    Private Sub Sharebtn_Click(sender As Object, e As EventArgs) Handles Sharebtn.Click
        Panel4.Show()
        Panel3.Hide()

        Dim source As String
        Dim destination As String
        Dim numofpassengers As Integer
        Dim hours As Integer
        Dim minutes As Integer
        Dim day As String


        source = cab_info.src_cb.Text
        destination = cab_info.des_cb.Text
        numofpassengers = CInt(cab_info.no_pass.Text)
        hours = CInt(cab_info.hour_tb.Text)
        minutes = CInt(cab_info.min_tb.Text)
        day = cab_info.day_cb.Text

        Dim dat As String
        If day = "Today" Then

            dat = DateAndTime.Now.ToShortDateString


        ElseIf day = "Tomorrow" Then
            dat = DateAndTime.Now.AddDays(1).ToShortDateString

        Else

            dat = DateAndTime.Now.AddDays(2).ToShortDateString

        End If


        Access.ExecQuery("SELECT Booking.BookingID, Booking.CabId, Booking.Driver, Booking.Occupancy, CabData.Seater , CabData.Seater - Booking.Occupancy AS SeatsLeft, Booking.Source, Booking.Destination, Booking.Hour, Booking.Minute, Booking.Day,  CabData.VehicleName FROM CabData RIGHT JOIN Booking ON CabData.CabId = Booking.CabId" + " WHERE Source = '" + source + "' AND Destination = '" + destination + "' AND Hour >= " + CStr(hours) + " AND NOT ( Hour = " + CStr(hours) + " AND Minute <" + CStr(minutes) + " )" + "AND (CabData.Seater - Booking.Occupancy) >= " + CStr(numofpassengers) + " AND Format(Booking.Day, 'Short Date') = '" + dat + "' " + "ORDER BY (100*Booking.Hour + Booking.Minute) Asc" + ";")

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

                    Dim totFare = CDec(money.Text)

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



            Share_dgv.BorderStyle = BorderStyle.None
            Share_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
            Share_dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            Share_dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
            Share_dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke

            Share_dgv.EnableHeadersVisualStyles = False
            Share_dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            Share_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
            Share_dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Share_dgv.RowTemplate.Height = 22
            Share_dgv.DefaultCellStyle.Padding.Bottom.Equals(4)
            Share_dgv.DefaultCellStyle.Padding.Bottom.Equals(4)




            Share_dgv.Rows(0).DefaultCellStyle.BackColor = Color.Red
            Share_dgv.Rows(0).DefaultCellStyle.ForeColor = Color.White
            Share_dgv.ClearSelection()



        Next
    End Sub

   

    Private Sub NewBooking_dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles NewBooking_dgv.CellDoubleClick
        Dim row_index As Integer
        Dim query As New StringBuilder
        NewBooking_FullData_dgv.DataSource = Nothing
        NewBooking_dgv.DataSource = Nothing
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

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        cab_info.Show()
        Me.Close()

    End Sub
End Class

