Public Class cab_info


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub cab_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            MessageBox.Show("Select Passenger")
        ElseIf String.Compare(day_cb.Text, "Today") = 0 Then
            If CInt(hour_tb.Text) < h Then
                MessageBox.Show("Time selected has already been passed")
            ElseIf CInt(hour_tb.Text) = h And CInt(min_tb.Text <= m) Then
                MessageBox.Show("Time selected has already been passed")
            Else
                Maps.Show()
            End If
        Else
            Maps.Show()
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

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Form1.Show()
        Me.hide()

    End Sub
End Class


