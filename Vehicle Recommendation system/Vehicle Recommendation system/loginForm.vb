Imports System.Data.OleDb
Imports System.Data

Public Class loginForm


    Private Sub cab_CheckedChanged(sender As Object, e As EventArgs) Handles cab.CheckedChanged
        If cab.Checked = True Then
            cab.Checked = True
            staff.Checked = False
            er.Checked = False
        End If
    End Sub

    Private Sub er_CheckedChanged(sender As Object, e As EventArgs) Handles er.CheckedChanged
        If er.Checked = True Then
            staff.Checked = False
            cab.Checked = False
            er.Checked = True
        End If
    End Sub

    Private Sub staff_CheckedChanged(sender As Object, e As EventArgs) Handles staff.CheckedChanged
        If staff.Checked = True Then
            cab.Checked = False
            er.Checked = False
            staff.Checked = True
        End If
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
            Dim password As String = ""

            username = ""
            password = ""
            If TextBox1.Text.Length = 0 Then
                MessageBox.Show("Enter Username to Continue")
            ElseIf TextBox2.Text.Length = 0 Then
                MessageBox.Show("Enter password to Continue")
            Else
                username = TextBox1.Text
                password = TextBox2.Text

                Dim querry As String = "Select Password from [E-RickshawData] where UserName = '" + username + "';"
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
                    dashboardERick.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Wrong Password", "Error")
                    TextBox2.Text = ""
                End If
                cmd.Dispose()
                conn.Close()
            End If
        Else
            MessageBox.Show(" Kindly select an option !!")
        End If

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class

