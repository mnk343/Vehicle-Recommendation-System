Imports System.Data.OleDb
Public Class ChangePassword

    Dim cmdUpdate As New OleDbCommand
    Dim username As String
    Dim password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        username = ""
        password = ""
        Dim pass As String = ""
        If TextBox3.Text.Length = 0 Then
            MessageBox.Show("Enter Password to Continue")
        ElseIf TextBox4.Text.Length = 0 Or TextBox5.Text.Length = 0 Then
            MessageBox.Show("Enter password to Continue")
        ElseIf TextBox4.Text <> TextBox5.Text Then
            MessageBox.Show("New Password & Confirm Password are not same")
        Else
            username = TextBox1.Text
            password = TextBox3.Text

            Dim querry As String = "Select Password from Cabdata where UserName = '" + username + "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Dell\Desktop\Vehicle-Recommendation-System\Vehicle-Recommendation-System-Database.accdb'"
            Dim conn As New OleDbConnection(dbsource)
            conn.Open()
            Dim cmd As New OleDbCommand(querry, conn)
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            If password = pass Then
                cmdUpdate.CommandText = "UPDATE [CabData] SET [Password] = '" & TextBox4.Text & "'  Where [UserName] = '" & TextBox1.Text & "';"
                cmdUpdate.CommandType = CommandType.Text
                cmdUpdate.Connection = conn
                cmdUpdate.ExecuteNonQuery()
                MessageBox.Show("New Password has been saved Successfully", "Success")
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
            Else
                MessageBox.Show("Old Password is Wrong", "Error")
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
            End If
            cmdUpdate.Dispose()
        End If
        cmdUpdate.Dispose()
        Me.Hide()
        updateData.Show()
    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Update_Login.TextBox1.Text
    End Sub
End Class