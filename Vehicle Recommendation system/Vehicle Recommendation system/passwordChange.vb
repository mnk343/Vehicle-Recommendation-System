Imports System.Data.OleDb
Imports System.Data


Public Class passwordChange

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles showPassword.CheckedChanged

        If showPassword.Checked = True Then

            txtPassword.PasswordChar = ""
            txtConfirmPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
            txtConfirmPassword.PasswordChar = "*"

        End If
    End Sub

    Private Sub prevPage_Click(sender As Object, e As EventArgs) Handles prevPage.Click

        dashboardStaff.Show()
        Me.Close()

    End Sub

    Private Sub changePassword_Click(sender As Object, e As EventArgs) Handles changePassword.Click

        If txtPassword.Text = "" And txtConfirmPassword.Text = "" Then

            MessageBox.Show("Kindly fill all the details to change your password ")

        ElseIf txtPassword.Text = txtConfirmPassword.Text Then

            Dim user As String

            user = loginForm.TextBox1.Text
            Dim querry As String = "Update [Staff] Set [Password] = '" & txtPassword.Text & "' Where [Name]= '" & user & "';"


            Dim path As String = My.Application.Info.DirectoryPath + "\Vehicle Recommendation System Database.accdb"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
            Try
                Dim conn = New OleDbConnection(dbsource)
                Dim cmd As New OleDbCommand(querry, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()

                MessageBox.Show("Password has been changed !! ")
                Me.Hide()
                dashboardStaff.Show()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Else
            MessageBox.Show("Entered passwrods dont match. Kindly make sure they do. ")

        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub prevPage_MouseClick(sender As Object, e As MouseEventArgs) Handles prevPage.MouseClick
        prevPage.BackColor = Color.LightSeaGreen
    End Sub


    Private Sub prevPage_MouseHover(sender As Object, e As EventArgs) Handles prevPage.MouseHover
        prevPage.BackColor = Color.LightGray
    End Sub

    Private Sub prevPage_MouseLeave(sender As Object, e As EventArgs) Handles prevPage.MouseLeave
        prevPage.BackColor = Color.Transparent
    End Sub

    Private Sub changePassword_MouseClick(sender As Object, e As MouseEventArgs) Handles changePassword.MouseClick
        changePassword.BackColor = Color.LightSeaGreen
    End Sub


    Private Sub changePassword_MouseHover(sender As Object, e As EventArgs) Handles changePassword.MouseHover
        changePassword.BackColor = Color.LightGray
    End Sub

    Private Sub changePassword_MouseLeave(sender As Object, e As EventArgs) Handles changePassword.MouseLeave
        changePassword.BackColor = Color.Transparent
    End Sub

End Class