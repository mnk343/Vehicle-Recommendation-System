Public Class rickshaw_map

    Private Sub rickshaw_map_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        WebBrowser1.Navigate(E_rickshaw.Label1.Text)
        'Label1.Text = E_rickshaw.Label1.Text
    End Sub
End Class