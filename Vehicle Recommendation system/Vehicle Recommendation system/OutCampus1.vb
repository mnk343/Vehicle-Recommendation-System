Public Class OutCampus1

    Private Sub bus_Click(sender As Object, e As EventArgs) Handles bus.Click

        Me.Hide()
        outBus.Show()

    End Sub

    Private Sub cab_Click(sender As Object, e As EventArgs) Handles cab.Click

        Me.Hide()
        cab_info.show()

    End Sub
End Class