﻿Imports System.Data.OleDb
Imports System.Data

Public Class loginForm

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uname As String = ""
        Dim pword As String
        Dim username As String = ""
        Dim pass As String = ""


        Dim count_checkbox As Integer = 0
        If staff.Checked Then
            count_checkbox += 1
        End If
        If er.Checked Then
            count_checkbox += 1
        End If
        If cab.Checked Then
            count_checkbox += 1
        End If

        If count_checkbox = 0 Then
            MessageBox.Show(" Please Select a checkbox")
        ElseIf count_checkbox > 1 Then
            MessageBox.Show(" Please Select only one checkbox")
        Else

            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Plz Fill All the info")
            Else
                uname = TextBox1.Text
                pword = TextBox2.Text
                Dim querry As String = "Select Password From Staff where Name= '" & uname & "';"

                Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Admin\Desktop\new\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"
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
            End If
        End If

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub cab_chkbox_CheckedChanged(sender As Object, e As EventArgs) Handles cab.CheckedChanged
        If cab.Checked = True Then
            cab.Checked = True
            staff.Checked = False
            er.Checked = False
        End If
    End Sub

    Private Sub rickshaw_chkbox_CheckedChanged(sender As Object, e As EventArgs) Handles er.CheckedChanged
        If er.Checked = True Then
            staff.Checked = False
            cab.Checked = False
            er.Checked = True
        End If
    End Sub

    Private Sub staff_chkbox_CheckedChanged(sender As Object, e As EventArgs) Handles staff.CheckedChanged
        If staff.Checked = True Then
            cab.Checked = False
            er.Checked = False
            staff.Checked = True
        End If
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

