Public Class city

    Private Sub OutCampus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub from_city_lbl_Click(sender As Object, e As EventArgs) Handles from_city_lbl.Click
        to_pnl.Hide()
        to_city_lbl.BackColor = Color.White
        from_city_lbl.BackColor = Color.Blue

        to_city_lbl.ForeColor = Color.Black
        from_city_lbl.ForeColor = Color.White
        to_header.Hide()


    End Sub


    Private Sub to_city_lbl_Click(sender As Object, e As EventArgs) Handles to_city_lbl.Click




        to_pnl.Show()
        to_city_lbl.BackColor = Color.Blue
        from_city_lbl.BackColor = Color.White

        to_city_lbl.ForeColor = Color.White
        from_city_lbl.ForeColor = Color.Black
        to_header.Show()

    End Sub


    Private Sub to_bus_Click(sender As Object, e As EventArgs) Handles to_bus.Click
        To_City_Bus.Show()
    End Sub
End Class