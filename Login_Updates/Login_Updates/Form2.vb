Imports System.Data.OleDb
Public Class Form2
    Dim cmdUpdate As New OleDbCommand

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
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Dell\Desktop\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"
            Dim conn As New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            If pword = pass Then
                cmdUpdate.CommandText = "UPDATE [CabData] SET [Contact] = '" & txtcontact.Text & "' , [City] = " & chcity.Checked & ", [Shillong] = " & chshillong.Checked & " , [Tawang] = " & chtawang.Checked & ",[Gangtok] = " & chgangtok.Checked & " Where [UserName] = '" & usertxt.Text & "';"
                cmdUpdate.CommandType = CommandType.Text
                MessageBox.Show("UPDATE [CabData] SET [Contact] = '" & txtcontact.Text & "' , [City] = " & chcity.Checked & ", [Shillong] = " & chshillong.Checked & " , [Tawang] = " & chtawang.Checked & ",[Gangtok] = " & chgangtok.Checked & " Where [UserName] = " & usertxt.Text & ";")
                cmdUpdate.Connection = conn
                cmdUpdate.ExecuteNonQuery()
                MessageBox.Show("Record Updated Successfully", "Success")
            Else
                MessageBox.Show("Wrong Password", "Error")
            End If
        End If
        cmdUpdate.Dispose()
    End Sub

    Private Sub butclear_Click(sender As Object, e As EventArgs) Handles butclear.Click
        Me.usertxt.Text = ""
        Me.txtcontact.Text = ""
        Me.txtpass.Text = ""
    End Sub

    Private Sub chshow_CheckedChanged(sender As Object, e As EventArgs) Handles chshow.CheckedChanged
        If chshow.Checked Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub


    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles butback.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usertxt.Text = Update_Login.TextBox1.Text
        Dim username As String = usertxt.Text
        Dim querry As String = "Select * From [CabData] Where [UserName]= '" + username + "';"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Dell\Desktop\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"
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
End Class


'''''''' New 

'Imports System.Data.OleDb
'Imports System.Data

'Public Class memberUpdate

'    Private Sub info_Click(sender As Object, e As EventArgs)

'    End Sub

'    Private Sub vehicle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vehicle.SelectedIndexChanged

'    End Sub


'    Private Sub memberUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Panel2.Visible = False

'        vehicle.DropDownStyle = ComboBoxStyle.DropDownList
'        vehicle.Items.Clear()
'        vehicle.Items.Add("Cab Driver")
'        vehicle.Items.Add("E-Rickshaw")
'        vehicle.Text = "Kindly select the vehicle type : "
'    End Sub

'    Private Sub submit1_Click(sender As Object, e As EventArgs) Handles submit1.Click

'        If vehicle.Text = "Cab Driver" Or vehicle.Text = "E-Rickshaw" Then
'            Panel2.Visible = True
'        End If

'        If usrName.Text = "" Or vehicle.Text = "" Then
'            MessageBox.Show("Kindly Fill all the fields!!")

'        Else

'            Dim vehData As String
'            If vehicle.Text = "Cab Driver" Then
'                vehData = "CabData"


'                Dim querry As String = " Select * from [CabData] where [UserName] = '" + usrName.Text + "';"
'                'Dim querry As String = "Update [" + vehData + "] Set [Password] = '" & txtPassword.Text & "' Where [UserName]= '" & user & "';"

'                Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\mayan\Desktop\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"

'                Dim conn = New OleDbConnection(dbsource)
'                Dim cmd As New OleDbCommand(querry, conn)
'                conn.Open()

'                Dim reader As OleDbDataReader

'                reader = cmd.ExecuteReader()

'                While reader.Read()
'                    'txtPassword.Text = CStr(reader(4))
'                    txtContactNo.Text = CStr(reader(2))
'                    City.Checked = CStr(reader(5))
'                    shillong.Checked = CStr(reader(6))
'                    gangtok.Checked = CStr(reader(7))
'                    tawang.Checked = CStr(reader(8))

'                    txtCityTrips.Text = CStr(reader(9))
'                    txtShillongTrips.Text = CStr(reader(10))
'                    txtGangtokTrips.Text = CStr(reader(11))
'                    txtTawangTrips.Text = CStr(reader(12))

'                    txtSeater.Text = CStr(reader(13))
'                    txtVehicleName.Text = CStr(reader(14))

'                End While

'                cmd.Dispose()
'                conn.Close()

'            End If

'        End If
'    End Sub


'    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs)

'    End Sub
'    Private Sub confirmPassword_Click(sender As Object, e As EventArgs)

'    End Sub
'    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

'    End Sub
'    Private Sub password_Click(sender As Object, e As EventArgs) Handles password.Click

'    End Sub
'    Private Sub showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles showPassword.CheckedChanged

'        If showPassword.Checked = True Then

'            txtPassword.PasswordChar = ""
'            'txtConfirmPassword.PasswordChar = ""
'        Else
'            txtPassword.PasswordChar = "*"
'            'txtConfirmPassword.PasswordChar = "*"

'        End If


'    End Sub

'    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

'    End Sub

'    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtVehicleName.TextChanged

'    End Sub

'    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles vehicleName.Click

'    End Sub

'    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click

'        Dim querry As String = " Update [CabData] Set  [Contact] ='" + CStr(txtContactNo.Text) + "' "

'        querry += " , [City] = " + CStr(City.Checked) + " , [Shillong] = " + CStr(shillong.Checked) + " , [Gangtok] = "
'        querry += CStr(gangtok.Checked) + " , [Tawang] = " + CStr(tawang.Checked) + " , [CityTrips] = " + CStr(txtCityTrips.Text)
'        querry += " , [ShillongTrips] = " + CStr(txtShillongTrips.Text) + " , [TawangTrips] = " + CStr(txtTawangTrips.Text) + " , [GangtokTrips] = " + CStr(txtGangtokTrips.Text)
'        querry += " , [Seater] = " + CStr(txtSeater.Text) + " , [VehicleName] = '" + CStr(txtVehicleName.Text) + "' "
'        querry += " WHERE [UserName] = '" + usrName.Text + "' ;"

'        ' [Password] = '" + txtPassword.Text + "' AND

'        MessageBox.Show(querry)

'        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\mayan\Desktop\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"

'        Try
'            Dim conn = New OleDbConnection(dbsource)
'            Dim cmd As New OleDbCommand(querry, conn)
'            conn.Open()
'            cmd.ExecuteNonQuery()
'            cmd.Dispose()
'            conn.Close()

'            Me.Hide()
'            dashboardStaff.Show()

'        Catch ex As Exception
'            MsgBox(ex.Message)
'        End Try

'    End Sub

'End Class