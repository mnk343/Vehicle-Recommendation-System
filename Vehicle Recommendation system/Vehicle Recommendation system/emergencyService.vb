Imports System.Net.Mail

Public Class emergencyService

    Private Sub txtsub_TextChanged(sender As Object, e As EventArgs) Handles txtsub.TextChanged

    End Sub

    Private Sub emergencyService_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Send_Click(sender As Object, e As EventArgs) Handles Send.Click


        Dim textTo As String = ""

        If txtsub.Text.Length = 0 Then
            MessageBox.Show("Write a proper Subject,Else a common Subject will be sent")
            txtsub.Text &= "Need Help"
        End If

        If choose.Text = "Hospital" Then
            textTo = "annanyapr@gmail.com"

        ElseIf choose.Text = "Fire Station" Then
            textTo = "avira170101014@iitg.ac.in"

        ElseIf choose.Text = "Police" Then
            textTo = "arany170101011@iitg.ac.in"

        End If
        Try
            Dim Smtp_Server As New SmtpClient
            Dim email As New MailMessage
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("softwarelab25@gmail.com", "Software123")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            email = New MailMessage
            email.From = New MailAddress("softwarelab25@gmail.com")
            email.To.Add(textTo)
            email.Subject = txtsub.Text
            email.IsBodyHtml = True
            email.Body = txtaddress.Text
            Smtp_Server.Send(email)
            MessageBox.Show("Message has been sent", "Success")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class

