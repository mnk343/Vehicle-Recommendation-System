Imports System.Data.OleDb

Public Class bookingPart2
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub bookingPart2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        src_cb.Items.Add("IIT Guwahati")
        src_cb.Items.Add("Kamakhya")
        src_cb.Items.Add("Airport")
        src_cb.Items.Add("Railway")
        src_cb.Items.Add("Pan Bazar")

        des_cb.Items.Add("IIT Guwahati")
        des_cb.Items.Add("Kamakhya")
        des_cb.Items.Add("Airport")
        des_cb.Items.Add("Railway")
        des_cb.Items.Add("Pan Bazar")

        day_cb.Items.Add("Today")
        day_cb.Items.Add("Tomorrow")
        day_cb.Items.Add("Day after Tomorrow")

        Dim bookid = updateBooking.bid_lbl.Text
        Dim querry As String = "Select * From [Booking] Where [BookingID]= " + bookid + ";"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\mayan\Desktop\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"
        Dim conn As New OleDbConnection(dbsource)
        Dim cmd As New OleDbCommand(querry, conn)
        conn.Open()
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        While reader.Read()
            src_cb.Text = CStr(reader(4))
            des_cb.Text = CStr(reader(5))
            no_pass.Text = CStr(reader(3))
            hour_tb.Text = CStr(reader(6))
            min_tb.Text = CStr(reader(7))
            Dim dat As String = CStr(reader(8))
            If dat = DateAndTime.Now.ToShortDateString Then
                day_cb.Text = "Today"


            ElseIf dat = DateAndTime.Now.AddDays(1).ToShortDateString Then
                day_cb.Text = "Tomorrow"



            ElseIf dat = DateAndTime.Now.AddDays(2).ToShortDateString Then
                day_cb.Text = "Day after Tomorrow"
            End If
        End While
        cmd.Dispose()
        conn.Close()

    End Sub

    Private Sub load_btn_Click(sender As Object, e As EventArgs) Handles load_btn.Click
        Dim src As String = src_cb.Text
        Dim dest As String = des_cb.Text

        Dim cid As String = updateBooking.cid_lbl.Text
        Dim bid As String = updateBooking.bid_lbl.Text
        Dim seater As String = ""
        Dim username = loginForm.TextBox1.Text
        Dim querry As String = "Select * From [CabData] Where [UserName]= '" + username + "';"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\mayan\Desktop\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"
        Dim conn As New OleDbConnection(dbsource)
        Dim cmd As New OleDbCommand(querry, conn)
        conn.Open()
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        While reader.Read()
            cid = CStr(reader(0))
            seater = CStr(reader(13))

        End While
        cmd.Dispose()
        conn.Close()

        Dim time As String = DateTime.Now.ToShortTimeString
        Dim h As Integer = DateTime.Now.TimeOfDay.Hours
        Dim m As Integer = DateTime.Now.TimeOfDay.Minutes
        If src = "" Then
            MessageBox.Show("Select Source")
        ElseIf dest = "" Then
            MessageBox.Show("Select Destination")
        ElseIf day_cb.Text = "" Then
            MessageBox.Show("Select Day")
        ElseIf String.Compare(src, dest) = 0 Then
            MessageBox.Show("Source And Destination must be diffrent")
        ElseIf hour_tb.Text = "" Then
            MessageBox.Show("Hour Field is Empty")
        ElseIf CInt(hour_tb.Text) > 23 Then
            MessageBox.Show("Hour must be less than 24")
        ElseIf min_tb.Text = "" Then
            MessageBox.Show("Minute Field is Empty")
        ElseIf CInt(min_tb.Text) > 59 Then
            MessageBox.Show("Minute must be less than 60")
        ElseIf day_cb.Text = "" Then
            MessageBox.Show("Select passenger")
        ElseIf String.Compare(day_cb.Text, "Today") = 0 And ((CInt(hour_tb.Text) < h) Or (CInt(hour_tb.Text) = h And CInt(min_tb.Text <= m))) Then
            MessageBox.Show("Time selected has already been passed")

        Else

            Dim hours As Integer = CInt(hour_tb.Text)
            Dim dat As String
            Dim Day As String
            Dim numofpassengers As Integer = CInt(no_pass.Text)

            Day = day_cb.Text

            If Day = "Today" Then

                dat = DateAndTime.Now.ToShortDateString


            ElseIf Day = "Tomorrow" Then
                dat = DateAndTime.Now.AddDays(1).ToShortDateString
            Else
                dat = DateAndTime.Now.AddDays(2).ToShortDateString

            End If
          
            querry = "SELECT Booking.CabId FROM Booking WHERE " + " Booking.BookingID <> " + updateBooking.bid_lbl.Text + " AND " + CStr(hours) + " BETWEEN Booking.Hour - 1 AND Booking.Hour + 1 AND Format(Booking.Day, 'Short Date') = '" + dat + "' AND Booking.CabId = " + cid + ";"
            conn = New OleDbConnection(dbsource)
            cmd = New OleDbCommand(querry, conn)
            Dim flag As Object = Nothing
            Try
                conn.Open()
                flag = cmd.ExecuteScalar()
                cmd.Dispose()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            If flag = Nothing Then

                If numofpassengers <= CInt(seater) Then
                    querry = "UPDATE Booking SET [Source] = '" + src_cb.Text + "', [Destination] = '" + des_cb.Text + "' , [Occupancy] = " + no_pass.Text + ", [Hour] = " + hour_tb.Text + ", [Minute]= " + min_tb.Text + ", [Day] = '" + dat + "' Where [BookingID] = " + updateBooking.bid_lbl.Text + " ;"
                    MessageBox.Show(querry)
                    conn = New OleDbConnection(dbsource)
                    Dim cmdup As New OleDbCommand(querry, conn)

                    Try
                        conn.Open()
                        cmdup.ExecuteNonQuery()
                        cmdup.Dispose()
                        conn.Close()
                        MessageBox.Show("Updated Success")
                        updateBooking.Close()
                        dashboardCab.Show()
                        Me.Close()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                Else
                    MessageBox.Show("Enter the Correct number of passengers", "Error")

                End If
            Else
                MessageBox.Show("You are violating the booking time conditions", "Error")
            End If
        End If
    End Sub

End Class