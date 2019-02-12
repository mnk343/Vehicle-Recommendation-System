Imports System.Data.OleDb
Imports System.Data

Public Class memberDelete

    Private Sub memberDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click

        If txtName.Text = "" Then
            MessageBox.Show("Kindly enter a name")

        Else
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\mayan\Desktop\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"
            Dim conn = New OleDbConnection(dbsource)

            Dim querry As String = "SELECT Count(*) FROM CabData WHERE UserName =  '" + txtName.Text + "' ;"
            Dim cmd As New OleDbCommand(querry, conn)

            conn.Open()
            Dim number As Integer = 0

            number = cmd.ExecuteScalar()
            'MessageBox.Show(number)
            cmd.Dispose()
            conn.Close()

            conn = New OleDbConnection(dbsource)

            querry = "SELECT Count(*) FROM [E-RickshawData] WHERE UserName =  '" + txtName.Text + "' ;"
            cmd = New OleDbCommand(querry, conn)

            conn.Open()

            number += cmd.ExecuteScalar()
            ' MessageBox.Show(number)
            cmd.Dispose()
            conn.Close()

            If number = 0 Then
                MessageBox.Show("The username doesnot exist in our database. Kindly enter some other value!")
            Else
                querry = " DELETE * FROM [CabData] WHERE UserName = '" + txtName.Text + " '; "
                conn = New OleDbConnection(dbsource)
                cmd = New OleDbCommand(querry, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()

                querry = " DELETE * FROM [E-RickshawData] WHERE UserName = '" + txtName.Text + " '; "
                conn = New OleDbConnection(dbsource)
                cmd = New OleDbCommand(querry, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()
                MessageBox.Show("The user has been deleted successfully!!")

                dashboardStaff.Show()
                Me.Close()

            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        dashboardStaff.Show()

    End Sub

    Private Sub delete_MouseClick(sender As Object, e As MouseEventArgs) Handles delete.MouseClick
        delete.BackColor = Color.LightSeaGreen
    End Sub


    Private Sub delete_MouseHover(sender As Object, e As EventArgs) Handles delete.MouseHover
        delete.BackColor = Color.LightGray
    End Sub

    Private Sub delete_MouseLeave(sender As Object, e As EventArgs) Handles delete.MouseLeave
        delete.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        Button1.BackColor = Color.LightSeaGreen
    End Sub


    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.LightGray
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Transparent
    End Sub
End Class