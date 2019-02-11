Imports System.Data.OleDb
Public Class Update_Login
    Dim cmdUpdate As New OleDbCommand
    Dim username As String
    Dim password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        username = ""
        password = ""
        Dim pass As String = ""
        If TextBox1.Text.Length = 0 Then
            MessageBox.Show("Enter Username to Continue")
        ElseIf TextBox2.Text.Length = 0 Then
            MessageBox.Show("Enter password to Continue")
        Else
            username = TextBox1.Text
            password = TextBox2.Text

            Dim querry As String = "Select Password from Cabdata where UserName = '" + username + "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Dell\Desktop\Vehicle-Recommendation-System\Vehicle-Recommendation-System\Vehicle-Recommendation-System-Database.accdb'"
            Dim conn As New OleDbConnection(dbsource)
            conn.Open()
            Dim cmd As New OleDbCommand(querry, conn)
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            If password = pass Then
                Dashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Wrong Password", "Error")
                TextBox2.Text = ""
            End If
            cmdUpdate.Dispose()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub Update_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class