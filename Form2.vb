Imports System.Data.OleDb
Public Class Form2
    Dim cmdUpdate As New OleDbCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cid As String = ""
        Dim pword As String = ""
        Dim username As String = ""
        Dim pass As String = ""
        If TextBox1.Text = "" Or TextBox5.Text = "" Then
            MessageBox.Show("Enter the Details to continue")
        Else
            cid = TextBox1.Text
            pword = TextBox5.Text
           
            Dim querry As String = "Select [Password] From [CabData] Where [CabId]= " & cid & ";"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Dell\Downloads\database.accdb'"
            Dim conn As New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MessageBox.Show("CabID Doesn't Exist")
            End Try
            If pword = pass Then
                cmdUpdate.CommandText = "UPDATE CabData SET UserName = '" & TextBox2.Text & "',Contact = '" & TextBox3.Text & "',City= " & CheckBox4.Checked & ",Shillong= " & CheckBox1.Checked & ",Tawang= " & CheckBox3.Checked & ",Gangtok= " & CheckBox1.Checked & " Where CabID = " & TextBox1.Text & ";"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox5.Text = ""
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            TextBox5.PasswordChar = ""
        Else
            TextBox5.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub


    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class