Public Class CabMap

    Private Sub CabMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        WebBrowser1.Navigate(Booking.Label1.Text)

    End Sub
End Class