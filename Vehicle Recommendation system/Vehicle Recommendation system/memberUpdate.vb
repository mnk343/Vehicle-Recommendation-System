Imports System.Data.OleDb
Imports System.Data

Public Class memberUpdate

    Private Sub info_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub vehicle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vehicle.SelectedIndexChanged

        If vehicle.Text = "Cab Driver" Or vehicle.Text = "E-Rickshaw" Then
            Panel2.Visible = True
        End If

    End Sub


    Private Sub memberUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Visible = False

        vehicle.DropDownStyle = ComboBoxStyle.DropDownList
        vehicle.Items.Clear()
        vehicle.Items.Add("Cab Driver")
        vehicle.Items.Add("E-Rickshaw")
        vehicle.Text = "Kindly select the vehicle type : "
    End Sub

    Private Sub submit1_Click(sender As Object, e As EventArgs) Handles submit1.Click

        If usrName.Text = "" Or vehicle.Text = "" Then
            MessageBox.Show("Kindly Fill all the fields!!")

        Else

            Dim vehData As String
            If vehicle.Text = "Cab Driver" Then
                vehData = "CabData"


                Dim querry As String = " Select * from [CabData] where [UserName] = '" + usrName.Text + "';"
                'Dim querry As String = "Update [" + vehData + "] Set [Password] = '" & txtPassword.Text & "' Where [UserName]= '" & user & "';"

                Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\mayan\Desktop\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"

                Dim conn = New OleDbConnection(dbsource)
                Dim cmd As New OleDbCommand(querry, conn)
                conn.Open()

                Dim reader As OleDbDataReader

                reader = cmd.ExecuteReader()

                While reader.Read()
                    MessageBox.Show(reader(9))
                End While
                







                    cmd.Dispose()
                    conn.Close()

            End If






















        End If

    End Sub













    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged

    End Sub
    Private Sub confirmPassword_Click(sender As Object, e As EventArgs) Handles confirmPassword.Click

    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
    Private Sub password_Click(sender As Object, e As EventArgs) Handles password.Click

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
End Class