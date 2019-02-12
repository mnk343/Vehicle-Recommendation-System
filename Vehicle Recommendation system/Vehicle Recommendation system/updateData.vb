Imports System.Data.OleDb

Public Class updateData
    Dim cmdUpdate As New OleDbCommand

    Private Sub updateData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usertxt.Text = loginForm.TextBox1.Text
        Dim username As String = usertxt.Text
        Dim querry As String = "Select * From [CabData] Where [UserName]= '" + username + "';"

        Dim path As String = My.Application.Info.DirectoryPath + "\Vehicle Recommendation System Database.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn As New OleDbConnection(dbsource)
        Dim cmd As New OleDbCommand(querry, conn)
        conn.Open()

        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        While reader.Read()
            chcity.Checked = CStr(reader(5))
            chshillong.Checked() = CStr(reader(6))
            chtawang.Checked() = CStr(reader(8))
            chgangtok.Checked() = CStr(reader(7))
            txtcontact.Text = CStr(reader(2))
        End While
        cmd.Dispose()
        conn.Close()
    End Sub

    Private Sub butclear_Click(sender As Object, e As EventArgs) Handles butclear.Click
        Me.txtpass.Text = ""

    End Sub

    Private Sub butupd_Click(sender As Object, e As EventArgs) Handles butupd.Click
        Dim user As String
        Dim pword As String
        Dim pass As String

        If txtpass.Text.Length = 0 Then
            MessageBox.Show("Enter your Password to Continue")
        Else
            user = usertxt.Text
            pword = txtpass.Text
            pass = ""
            Dim querry As String = "Select Password From CabData Where Username= '" & user & "';"

            Dim path As String = My.Application.Info.DirectoryPath + "\Vehicle Recommendation System Database.accdb"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
            Dim conn As New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            If pword = pass Then
                cmdUpdate.CommandText = "UPDATE [CabData] SET [Contact] = '" & txtcontact.Text & "'  Where [UserName] = '" & usertxt.Text & "';"
                cmdUpdate.CommandType = CommandType.Text
                cmdUpdate.Connection = conn
                cmdUpdate.ExecuteNonQuery()
                MessageBox.Show("Record Updated Successfully", "Success")
            Else
                MessageBox.Show("Wrong Password", "Error")
            End If
        End If
        cmdUpdate.Dispose()
    End Sub

    Private Sub butback_Click(sender As Object, e As EventArgs) Handles butback.Click
        Me.Hide()
        dashboardCab.Show()
    End Sub

    Private Sub chcity_CheckedChanged(sender As Object, e As EventArgs) Handles chcity.CheckedChanged
        Dim querry As String = "Update [CabData] SET [City] ="

        Dim path As String = My.Application.Info.DirectoryPath + "\Vehicle Recommendation System Database.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn As New OleDbConnection(dbsource)
        conn.Open()
        Dim username As String = usertxt.Text
        If chcity.Checked = False Then
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

    Private Sub chshillong_CheckedChanged(sender As Object, e As EventArgs) Handles chshillong.CheckedChanged
        Dim querry As String = "Update [CabData] SET [Shillong] ="

        Dim path As String = My.Application.Info.DirectoryPath + "\Vehicle Recommendation System Database.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn As New OleDbConnection(dbsource)
        conn.Open()
        Dim username As String = usertxt.Text
        If chshillong.Checked = False Then
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

    Private Sub chtawang_CheckedChanged(sender As Object, e As EventArgs) Handles chtawang.CheckedChanged
        Dim querry As String = "Update [CabData] SET [Tawang] ="

        Dim path As String = My.Application.Info.DirectoryPath + "\Vehicle Recommendation System Database.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
       Dim conn As New OleDbConnection(dbsource)
        conn.Open()
        Dim username As String = usertxt.Text
        If chtawang.Checked = False Then
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

    Private Sub chgangtok_CheckedChanged(sender As Object, e As EventArgs) Handles chgangtok.CheckedChanged
        Dim querry As String = "Update [CabData] SET [Gangtok] ="

        Dim path As String = My.Application.Info.DirectoryPath + "\Vehicle Recommendation System Database.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn As New OleDbConnection(dbsource)
        conn.Open()
        Dim username As String = usertxt.Text
        If chgangtok.Checked = False Then
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ChangePassword.Show()
    End Sub

    Private Sub chshow_CheckedChanged(sender As Object, e As EventArgs) Handles chshow.CheckedChanged
        If chshow.Checked Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If
    End Sub

  
End Class