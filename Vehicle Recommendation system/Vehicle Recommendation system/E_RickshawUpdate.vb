Imports System.Data.OleDb

Public Class E_RickshawUpdate
    Dim cmdUpdate As New OleDbCommand
    Dim path As String = My.Application.Info.DirectoryPath + "\Vehicle Recommendation System Database.accdb"
    Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
    Private Sub E_RickshawUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usertxt.Text = loginForm.TextBox1.Text
        Dim username As String = usertxt.Text
        Dim querry As String = "Select * From [E-RickshawData] Where [UserName]= '" + username + "';"
        Dim conn As New OleDbConnection(dbsource)
        Dim cmd As New OleDbCommand(querry, conn)
        conn.Open()

        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        While reader.Read()
            lat_txt.Text = CStr(reader(5))
            long_txt.Text = CStr(reader(6))
            txtcontact.Text = CStr(reader(2))
        End While
        cmd.Dispose()
        conn.Close()
    End Sub

    Private Sub no_pass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lat_txt.KeyPress, long_txt.KeyPress


        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 46 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub butupd_Click(sender As Object, e As EventArgs) Handles butupd.Click
        Dim user As String
        Dim pword As String
        Dim pass As String


        If IsNumeric(txtcontact.Text) And IsNumeric(lat_txt.Text) And IsNumeric(long_txt.Text) Then
            If CInt(long_txt.Text) <= 180 And CInt(long_txt.Text) >= -180 And CInt(lat_txt.Text) <= 90 And (lat_txt.Text) >= -90 Then
                If txtpass.Text.Length = 0 Then
                    MessageBox.Show("Enter your Password to Continue")
                Else
                    user = usertxt.Text
                    pword = txtpass.Text
                    pass = ""
                    Dim querry As String = "Select Password From [E-RickshawData] Where Username= '" & user & "';"
                    'Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Dell\Desktop\Vehicle-Recommendation-System\Vehicle-Recommendation-System-Database.accdb'"
                    Dim conn As New OleDbConnection(dbsource)
                    Dim cmd As New OleDbCommand(querry, conn)
                    conn.Open()
                    Try
                        pass = cmd.ExecuteScalar().ToString
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                    If pword = pass Then
                        cmdUpdate.CommandText = "UPDATE [E-RickshawData] SET [Contact] = '" + txtcontact.Text + "', [Latitude] = " + lat_txt.Text + ", [Longitude] = " + long_txt.Text + "  Where [UserName] = '" + usertxt.Text + "';"
                        cmdUpdate.CommandType = CommandType.Text
                        cmdUpdate.Connection = conn
                        cmdUpdate.ExecuteNonQuery()
                        MessageBox.Show("Record Updated Successfully", "Success")
                    Else
                        MessageBox.Show("Wrong Password", "Error")
                    End If
                End If
                cmdUpdate.Dispose()
            Else
                MessageBox.Show("Enter a correct Numerical value")

            End If
        Else
            MessageBox.Show("Enter a correct Numerical value")

        End If
    End Sub

    Private Sub txtcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontact.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub butclear_Click(sender As Object, e As EventArgs) Handles butclear.Click
        Me.txtpass.Text = ""

    End Sub

    Private Sub chshow_CheckedChanged(sender As Object, e As EventArgs) Handles chshow.CheckedChanged
        If chshow.Checked Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If
    End Sub

    Private Sub butback_Click(sender As Object, e As EventArgs) Handles butback.Click
        dashboardERick.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        E_RickshawChangePassword.Show()

    End Sub

    
End Class
