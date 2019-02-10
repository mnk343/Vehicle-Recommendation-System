Public Class cab_info

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
        day_cb.Items.Add("Tommorow")
        day_cb.Items.Add("Day after Tommorow")

    End Sub

    Private Sub load_btn_Click(sender As Object, e As EventArgs) Handles load_btn.Click
        Dim src As String = src_cb.Text
        Dim dest As String = des_cb.Text
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



    Private Sub load_btn_MouseClick(sender As Object, e As MouseEventArgs) Handles load_btn.MouseClick
        load_btn.BackColor = Color.LightSeaGreen
    End Sub


    Private Sub load_btn_MouseHover(sender As Object, e As EventArgs) Handles load_btn.MouseHover
        load_btn.BackColor = Color.LightGray
    End Sub

    Private Sub load_btn_MouseLeave(sender As Object, e As EventArgs) Handles load_btn.MouseLeave
        load_btn.BackColor = Color.MediumSeaGreen

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
