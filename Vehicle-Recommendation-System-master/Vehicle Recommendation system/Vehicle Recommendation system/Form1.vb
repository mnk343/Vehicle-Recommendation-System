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

    

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub inCampus_Click(sender As Object, e As EventArgs) Handles inCampus.Click

    End Sub

    Private Sub emergency_Click(sender As Object, e As EventArgs) Handles emergency.Click

    End Sub
End Class
