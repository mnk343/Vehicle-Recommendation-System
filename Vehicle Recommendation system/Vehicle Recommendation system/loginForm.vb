Imports System.Data.OleDb
Imports System.Data

Public Class loginForm

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uname As String = ""
        Dim pword As String
        Dim username As String = ""
        Dim pass As String = ""

        If TextBox1.Text.Length = 0 Then
            MessageBox.Show("Enter Username to Continue")
        ElseIf TextBox2.Text.Length = 0 Then
            MessageBox.Show("Enter password to Continue")

        ElseIf staff.Checked = True Then

            uname = TextBox1.Text
            pword = TextBox2.Text
            Dim querry As String = "Select Password From Staff where Name= '" & uname & "';"

            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\mayan\Desktop\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Username does not exist")
            End Try
            If (pword = pass) Then
                MsgBox("Login success")
                Me.Hide()
                dashboardStaff.Show()

            Else
                MsgBox("Login Failed")
                TextBox1.Clear()
                TextBox2.Clear()
            End If

        ElseIf cab.Checked = True Then

            Dim password As String = ""

            username = TextBox1.Text
            password = TextBox2.Text

            Dim querry As String = "Select Password from Cabdata where UserName = '" + username + "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\mayan\Desktop\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"
            Dim conn As New OleDbConnection(dbsource)
            conn.Open()
            Dim cmd As New OleDbCommand(querry, conn)
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            If password = pass Then
                dashboardCab.Show()
                Me.Hide()
            Else
                MessageBox.Show("Wrong Password", "Error")
                TextBox2.Text = ""
            End If

        ElseIf er.Checked = True Then

        Else
            MessageBox.Show(" Kindly select an option !!")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

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

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub staff_CheckedChanged(sender As Object, e As EventArgs) Handles staff.CheckedChanged

    End Sub
End Class
