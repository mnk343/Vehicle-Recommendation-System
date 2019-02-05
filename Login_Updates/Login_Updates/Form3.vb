Imports System.Data.OleDb
Public Class Form3

    Dim cmdUpdate As New OleDbCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cid As String = ""
        Dim pword As String = ""
        Dim pass As String = ""
        If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Enter the Details to continue")
        ElseIf String.Compare(TextBox4.Text, TextBox5.Text) > 0 Or String.Compare(TextBox4.Text, TextBox5.Text) < 0 Then
            MessageBox.Show("The New Password in two boxes don't match", "Error")
        ElseIf String.Compare(TextBox3.Text, TextBox5.Text) = 0 Then
            MessageBox.Show("The Old and New Password are same", "Attention")
        Else
            cid = TextBox1.Text
            pword = TextBox3.Text
            Dim querry As String = "Select [Password] From [CabData] Where [CabId]= " & cid & ";"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Dell\Downloads\database.accdb'"
            Dim conn As New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MessageBox.Show("CabID Doesn't Exist or Username to given CabID is wrong")
            End Try
            If pword = pass Then
                cmdUpdate.CommandText = "UPDATE [CabData] SET [Password] = '" & TextBox5.Text & "' Where [CabID] = " & TextBox1.Text & ";"
                cmdUpdate.CommandType = CommandType.Text
                cmdUpdate.Connection = conn
                cmdUpdate.ExecuteNonQuery()
                MessageBox.Show("Password Changed Successfully", "Success")
            Else
                MessageBox.Show("Old Password is Wrong", "Error")
            End If
        End If
        cmdUpdate.Dispose()
        Me.Hide()
        Form2.Show()
    End Sub

End Class