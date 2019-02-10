Imports System.Net.Mail
Imports System.Data.SqlClient
Public Class Form1

    Private Sub Send_Click(sender As Object, e As EventArgs) Handles Send.Click
        If txtfrom.Text.Length = 0 Then
            MessageBox.Show("Write a starting Mail Address,Else a common from default will be sent")
            txtfrom.Text &= "softwarelab25@gmail.com"
        End If
        If txtsub.Text.Length = 0 Then
            MessageBox.Show("Write a proper Subject,Else a common Subject will be sent")
            txtsub.Text &= "Need Help"
        End If
        If choose.Text = "Hospital" Then
            txtto.Text = "annanyapr@gmail.com"
        ElseIf choose.Text = "Fire Station" Then
            txtto.Text = "avira170101014@iitg.ac.in"
        ElseIf choose.Text = "Police" Then
            txtto.Text = "arany170101011@iitg.ac.in"
        Else
            MessageBox.Show("Choose Atleast 1 from the above", "Error")
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
            email.From = New MailAddress(txtfrom.Text)
            email.To.Add(txtto.Text)
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
