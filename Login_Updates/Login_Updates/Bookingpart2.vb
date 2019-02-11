Imports System.Data.OleDb
Public Class Bookingpart2
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


    Private Sub Bookingpart2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        day_cb.Items.Add("Tommorow")
        day_cb.Items.Add("Day after Tommorow")


        Dim bookid = updatebooking.bid_lbl.Text
        Dim querry As String = "Select * From [Booking] Where [BookingID]= " + bookid + ";"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Dell\Desktop\Vehicle-Recommendation-System\Vehicle-Recommendation-System-Database.accdb'"
        Dim conn As New OleDbConnection(dbsource)
        Dim cmd As New OleDbCommand(querry, conn)
        conn.Open()
        MessageBox.Show(querry)
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
                day_cb.Text = "Tommorow"

            ElseIf dat = DateAndTime.Now.AddDays(2).ToShortDateString Then
                day_cb.Text = "Day after Tommorow"
            End If
        End While
        cmd.Dispose()
        conn.Close()







    End Sub

    Private Sub load_btn_Click(sender As Object, e As EventArgs) Handles load_btn.Click

        Dim src As String = src_cb.Text
        Dim dest As String = des_cb.Text

        Dim cid As String = updatebooking.cid_lbl.Text
        Dim bid As String = updatebooking.bid_lbl.Text
        Dim seater As String = ""
        Dim username = Update_Login.TextBox1.Text
        Dim querry As String = "Select * From [CabData] Where [UserName]= '" + username + "';"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Dell\Desktop\Vehicle-Recommendation-System\Vehicle-Recommendation-System-Database.accdb'"
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
            'Dim hours As Integer = 15
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
            'dat = "10-02-2019"


            Access.ExecQuery("SELECT Booking.CabId FROM Booking WHERE " + CStr(hours) + " BETWEEN Booking.Hour - 1 AND Booking.Hour + 1 AND Format(Booking.Day, 'Short Date') = '" + dat + "' AND Booking.CabId = " + cid + " AND Booking.BookingID <> " + bid + ";")
            Dim count2_dgv As New DataGridView
            If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
            count2_dgv.DataSource = Access.DBDT

            Dim row_count As Integer = count2_dgv.RowCount
            MessageBox.Show(row_count)
            If row_count = 0 Then
                MessageBox.Show("Hello")
                If numofpassengers <= CInt(seater) Then
                    ' insertion query

                    querry = "UPDATE [Booking] SET [Source]= '" + src_cb.Text + "', [Destination] = '" + des_cb.Text + "' , [Occupancy] = " + no_pass.Text + ", [Hour] = " + hour_tb.Text + ", [Minute]= " + min_tb.Text + ", [Date] = '" + dat + "' Where [BookingID] = " + updatebooking.bid_lbl.Text + ";"

                    'conn = New OleDbConnection(dbsource)
                    Dim cmdup As New OleDbCommand(querry, conn)
                    'cmdup.Parameters.Add(New OleDbParameter("CabId", CType(cid, String)))
                    'cmdup.Parameters.Add(New OleDbParameter("Driver", CType(username, String)))
                    'cmdup.Parameters.Add(New OleDbParameter("Occupancy", CType(numofpassengers, String)))
                    'cmdup.Parameters.Add(New OleDbParameter("Source", CType(src_cb.Text, String)))
                    'cmdup.Parameters.Add(New OleDbParameter("Destination", CType(des_cb.Text, String)))
                    'cmdup.Parameters.Add(New OleDbParameter("Hour", CType(hour_tb.Text, String)))
                    'cmdup.Parameters.Add(New OleDbParameter("Minute", CType(min_tb.Text, String)))
                    'cmdup.Parameters.Add(New OleDbParameter("Day", dat))

                    Try
                        conn.Open()

                        cmdup.ExecuteNonQuery()
                        cmdup.Dispose()
                        conn.Close()
                        MessageBox.Show("Updated Success")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try



                Else
                    MessageBox.Show("Enter the Correct number of passengers", "Error")

                End If
            Else
                MessageBox.Show("You are already overbooked", "Error")
            End If
        End If
    End Sub



End Class