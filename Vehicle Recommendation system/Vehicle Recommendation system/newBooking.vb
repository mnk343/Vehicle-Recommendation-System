Imports System.Data.OleDb

Public Class newBooking
    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

   

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        dashboardCab.Show()
        Me.Close()

    End Sub

    Private Sub newBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    End Sub

    Private Sub load_btn_Click(sender As Object, e As EventArgs) Handles load_btn.Click
        Dim src As String = src_cb.Text
        Dim dest As String = des_cb.Text

        Dim cid As String = ""
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
            MessageBox.Show("Select Day")
        ElseIf no_pass.Text = "" Then
            MessageBox.Show("Select No of Passengers")
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


            querry = "SELECT Booking.CabId FROM Booking WHERE " + CStr(hours) + " BETWEEN Booking.Hour - 1 AND Booking.Hour + 1 AND Format(Booking.Day, 'Short Date') = '" + dat + "' AND Booking.CabId = " + cid + ";"
            conn = New OleDbConnection(dbsource)
            cmd = New OleDbCommand(querry, conn)
            conn.Open()
            Dim flag As Object = cmd.ExecuteScalar()
            cmd.Dispose()
            conn.Close()


            If flag = Nothing Then

                If numofpassengers <= CInt(seater) Then
                    ' insertion query

                    querry = "INSERT INTO [Booking] ( [CabId] , [Driver] , [Occupancy] ,[Source] , [Destination] , [Hour] , [Minute], [Day] ) VALUES ( ?,?,?,?,?,?,?,?)"

                    Dim cmdup As New OleDbCommand(querry, conn)
                    cmdup.Parameters.Add(New OleDbParameter("CabId", CType(cid, String)))
                    cmdup.Parameters.Add(New OleDbParameter("Driver", CType(username, String)))
                    cmdup.Parameters.Add(New OleDbParameter("Occupancy", CType(numofpassengers, String)))
                    cmdup.Parameters.Add(New OleDbParameter("Source", CType(src_cb.Text, String)))
                    cmdup.Parameters.Add(New OleDbParameter("Destination", CType(des_cb.Text, String)))
                    cmdup.Parameters.Add(New OleDbParameter("Hour", CType(hour_tb.Text, String)))
                    cmdup.Parameters.Add(New OleDbParameter("Minute", CType(min_tb.Text, String)))
                    cmdup.Parameters.Add(New OleDbParameter("Day", dat))

                    Try
                        conn.Open()

                        cmdup.ExecuteNonQuery()
                        cmdup.Dispose()
                        conn.Close()
                        MessageBox.Show("Success")
                        dashboardCab.Show()
                        Me.Close()

                    Catch ex As Exception
                        MessageBox.Show(querry)
                    End Try
                Else
                    MessageBox.Show("Enter the Correct number of passengers", "Error")
                End If
            Else
                MessageBox.Show("You are violating the booking time conditions", "Error")
            End If
        End If
    End Sub




    Private Sub no_pass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles no_pass.KeyPress, hour_tb.KeyPress, min_tb.KeyPress


        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class









