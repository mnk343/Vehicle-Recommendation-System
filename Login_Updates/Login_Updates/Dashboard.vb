Imports System.Data.OleDb
Imports System.Data

Public Class Dashboard

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click
        Me.Hide()
        updateData.Show()
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chduty.CheckedChanged

        Dim querry As String = "Update [CabData] SET [Status] ="
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Lenovo\Desktop\buffer\Vehicle-Recommendation-System\Vehicle-Recommendation-System-Database.accdb'"
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

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Update_Login.TextBox1.Text
        Dim username As String = Label2.Text
        Dim querry As String = "Select * From [CabData] Where [UserName]= '" + username + "';"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Lenovo\Desktop\buffer\Vehicle-Recommendation-System\Vehicle-Recommendation-System-Database.accdb'"
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



    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        updatebooking.Show()
        Me.Hide()
    End Sub

    Private Sub newbook_Click(sender As Object, e As EventArgs) Handles newbook.Click
        NewBooking.Show()
        Me.Hide()
    End Sub
End Class
