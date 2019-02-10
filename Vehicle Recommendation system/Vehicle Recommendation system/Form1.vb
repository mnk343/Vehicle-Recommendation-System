Public Class Form1

    Private Sub outstation_Click(sender As Object, e As EventArgs) Handles outstation.Click
        Me.Hide()
        outstation1.Show()
    End Sub

    Private Sub outCampus_Click(sender As Object, e As EventArgs) Handles outCampus.Click
        Me.Hide()
        OutCampus1.Show()
    End Sub


    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub inCampus_Click(sender As Object, e As EventArgs) Handles inCampus.Click

        Me.Hide()
        toCampus.Show()

    End Sub
End Class
