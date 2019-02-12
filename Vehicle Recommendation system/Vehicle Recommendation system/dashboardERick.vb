Imports System.Data.OleDb
Imports System.Text
Imports System.Math

Public Class dashboardERick
    Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\mayan\Desktop\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"
    Private Access As New DBControl

    Private Sub dashboardERick_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Text = loginForm.TextBox1.Text
        Dim username As String = Label2.Text

        Dim querry As String = "Select * From [E-RickshawData] Where [UserName]= '" + username + "';"
        Dim conn As New OleDbConnection(dbsource)
        Dim cmd As New OleDbCommand(querry, conn)
        conn.Open()

        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        While reader.Read()
            chduty.Checked = CStr(reader(3))
        End While
        cmd.Dispose()
        conn.Close()




    End Sub

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click
        E_RickshawUpdate.Show()
        Me.Hide()
    End Sub


    Private Sub chduty_CheckedChanged(sender As Object, e As EventArgs) Handles chduty.CheckedChanged
        Dim querry As String = "Update [E-RickshawData] SET [Status] ="
        Dim conn As New OleDbConnection(dbsource)
        conn.Open()
        Dim username As String = Label2.Text
        If chduty.Checked = False Then
            querry += "False " + "Where [UserName]= '" + username + "';"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()


        Else
            querry += "True " + "Where [UserName]= '" + username + "';"
            Dim cmd As New OleDbCommand(querry, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()

        End If
    End Sub
End Class

