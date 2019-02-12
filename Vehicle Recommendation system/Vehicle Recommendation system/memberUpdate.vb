Imports System.Data.OleDb
Imports System.Data

Public Class memberUpdate

    Private Sub info_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub vehicle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vehicle.SelectedIndexChanged

    End Sub


    Private Sub memberUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Visible = False

        vehicle.DropDownStyle = ComboBoxStyle.DropDownList
        vehicle.Items.Clear()
        vehicle.Items.Add("Cab Driver")
        vehicle.Text = "Kindly select the vehicle type : "
    End Sub

    Private Sub submit1_Click(sender As Object, e As EventArgs) Handles submit1.Click

        If vehicle.Text = "Cab Driver" Or vehicle.Text = "E-Rickshaw" Then
        End If

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

                If reader.HasRows Then
                    While reader.Read()

                        Panel2.Show()
                        txtPassword.Text = CStr(reader(4))
                        txtContactNo.Text = CStr(reader(2))
                        City.Checked = CStr(reader(5))
                        shillong.Checked = CStr(reader(6))
                        gangtok.Checked = CStr(reader(7))
                        tawang.Checked = CStr(reader(8))

                        txtCityTrips.Text = CStr(reader(9))
                        txtShillongTrips.Text = CStr(reader(10))
                        txtGangtokTrips.Text = CStr(reader(11))
                        txtTawangTrips.Text = CStr(reader(12))

                        txtSeater.Text = CStr(reader(13))
                        txtVehicleName.Text = CStr(reader(14))

                    End While
                    cmd.Dispose()
                    conn.Close()
                Else
                    MessageBox.Show("The user does not exist in our Database!!")
                End If

            End If

        End If
    End Sub


    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub confirmPassword_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
    Private Sub password_Click(sender As Object, e As EventArgs) Handles password.Click

    End Sub
    Private Sub showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles showPassword.CheckedChanged

        If showPassword.Checked = True Then

            txtPassword.PasswordChar = ""
            'txtConfirmPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
            'txtConfirmPassword.PasswordChar = "*"

        End If


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtVehicleName.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles vehicleName.Click

    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click

        Dim querry As String = " Update [CabData] Set [Password]= '" + txtPassword.Text + "' AND  [Contact] ='" + CStr(txtContactNo.Text) + "' "

        querry += " , [City] = " + CStr(City.Checked) + " , [Shillong] = " + CStr(shillong.Checked) + " , [Gangtok] = "
        querry += CStr(gangtok.Checked) + " , [Tawang] = " + CStr(tawang.Checked) + " , [CityTrips] = " + CStr(txtCityTrips.Text)
        querry += " , [ShillongTrips] = " + CStr(txtShillongTrips.Text) + " , [TawangTrips] = " + CStr(txtTawangTrips.Text) + " , [GangtokTrips] = " + CStr(txtGangtokTrips.Text)
        querry += " , [Seater] = " + CStr(txtSeater.Text) + " , [VehicleName] = '" + CStr(txtVehicleName.Text) + "' "
        querry += " WHERE [UserName] = '" + usrName.Text + "' ;"

        ' [Password] = '" + txtPassword.Text + "' AND

        ' MessageBox.Show(querry)

        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\mayan\Desktop\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"

        Try
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()

            Me.Hide()
            dashboardStaff.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dashboardStaff.Show()
        Me.Close()

    End Sub
End Class