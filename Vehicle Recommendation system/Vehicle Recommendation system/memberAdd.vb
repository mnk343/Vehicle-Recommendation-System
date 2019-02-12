Imports System.Data.OleDb
Imports System.Data

Public Class memberAdd


    Private Sub memberAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        contactNo.Visible = False
        userName.Visible = False
        password.Visible = False
        confirmPassword.Visible = False

        txtName.Visible = False
        txtPassword.Visible = False
        txtConfirmPassword.Visible = False
        txtContactNo.Visible = False
        showPassword.Visible = False
        submit.Visible = False


        vehicle.DropDownStyle = ComboBoxStyle.DropDownList
        vehicle.Items.Clear()
        vehicle.Items.Add("Cab Driver")
        vehicle.Items.Add("E-Rickshaw")
        vehicle.Text = "Kindly select the vehicle type : "

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub options_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub vehicle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vehicle.SelectedIndexChanged

        If vehicle.Text = "Cab Driver" Or vehicle.Text = "E-Rickshaw" Then
            contactNo.Visible = True
            userName.Visible = True
            password.Visible = True
            confirmPassword.Visible = True

            txtName.Visible = True
            txtPassword.Visible = True
            txtConfirmPassword.Visible = True
            txtContactNo.Visible = True

            showPassword.Visible = True
            submit.Visible = True

        End If

    End Sub

    Private Sub submit_MouseClick(sender As Object, e As MouseEventArgs) Handles submit.MouseClick
        submit.BackColor = Color.LightSeaGreen
    End Sub


    Private Sub submit_MouseHover(sender As Object, e As EventArgs) Handles submit.MouseHover
        submit.BackColor = Color.LightGray
    End Sub

    Private Sub submit_MouseLeave(sender As Object, e As EventArgs) Handles submit.MouseLeave
        submit.BackColor = Color.Transparent
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click

        If txtName.Text = "" Or txtPassword.Text = "" Or txtConfirmPassword.Text = "" Or txtContactNo.Text = "" Then
            MsgBox("Plz Fill All the information")

        ElseIf txtPassword.Text = txtConfirmPassword.Text Then


            Dim path As String = My.Application.Info.DirectoryPath + "\Vehicle Recommendation System Database.accdb"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
            Dim conn = New OleDbConnection(dbsource)
            Dim number As Integer = 0
            Dim querry As String
            If vehicle.Text = "Cab Driver" Then
                querry = "SELECT Count(*) FROM CabData WHERE UserName =  '" + txtName.Text + "' ;"
                Dim cmd As New OleDbCommand(querry, conn)
                conn.Open()
                number += cmd.ExecuteScalar()
                cmd.Dispose()
                conn.Close()
            ElseIf vehicle.Text = "E-Rickshaw" Then
                querry = "SELECT Count(*) FROM [E-RickshawData] WHERE UserName =  '" + txtName.Text + "' ;"
                Dim cmd = New OleDbCommand(querry, conn)

                conn.Open()

                number += cmd.ExecuteScalar()
                ' MessageBox.Show(number)
                cmd.Dispose()
                conn.Close()
            End If
           

            conn = New OleDbConnection(dbsource)

            
            If number > 0 Then
                MessageBox.Show("Username already exists. Kindly enter some other value.")

            Else

                Dim addInfo As String
                addInfo = ""

                If vehicle.Text = "Cab Driver" Then
                    addInfo = "CabData"

                ElseIf vehicle.Text = "E-Rickshaw" Then
                    addInfo = "E-RickshawData"
                End If

                querry = "INSERT INTO [" + addInfo + "] ( [UserName] , [Contact] , [Password]  ) VALUES ( ?,?,?)"
                Dim cmd = New OleDbCommand(querry, conn)

                'MessageBox.Show(querry)

                conn = New OleDbConnection(dbsource)
                cmd = New OleDbCommand(querry, conn)
                cmd.Parameters.Add(New OleDbParameter("UserName", CType(txtName.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Contact", CType(txtContactNo.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Password", CType(txtPassword.Text, String)))

                conn.Open()
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()

                MessageBox.Show("Value has been inserted successfully!!")
                Me.Hide()
                dashboardStaff.Show()

            End If

            Else

                MessageBox.Show("Passwords should match")

            End If

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

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

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        dashboardStaff.Show()

        Me.Close()

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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
