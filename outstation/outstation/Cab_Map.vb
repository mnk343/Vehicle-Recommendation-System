Public Class Cab_Map

    Private Sub Cab_Map_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        WebBrowser1.Navigate(BookingCab.Label1.Text)
    End Sub
End Class