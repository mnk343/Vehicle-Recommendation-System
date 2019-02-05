Imports System.Data.OleDb
Imports System.Data

Public Class Form1

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles onDuty.CheckedChanged

        Dim querry As String = "Update [CabData] SET [Status] ="
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Dell\Downloads\database.accdb'"
        Dim conn As New OleDbConnection(dbsource)
        conn.Open()

        If onDuty.Checked = False Then
            querry += "False " + "Where [CabId]=1 ; "
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()


        Else
            querry += "True " + "Where [CabId]=1 ; "
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim querry As String = "SELECT [Status] FROM [CabData] WHERE [CabId] = 1 "
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Dell\Downloads\database.accdb'"
        Dim conn As New OleDbConnection(dbsource)
        conn.Open()
        Dim cmd As New OleDbCommand(querry, conn)

        Dim value As String
        value = cmd.ExecuteScalar().ToString()

        If value = "True" Then
            onDuty.Checked = True

        End If


    End Sub
End Class
