Imports System.Data.OleDb
Imports System.Data

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles changePassword.Click

        Me.Hide()
        form3.show()


    End Sub

    Private Sub prevPage_Click(sender As Object, e As EventArgs) Handles prevPage.Click
        MessageBox.Show("You are on the home page of your dashboard...Click on Sign out button to log out.")

    End Sub

    Private Sub signOut_Click(sender As Object, e As EventArgs) Handles signOut.Click
        MessageBox.Show("Signing out from your account. ")
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub addMember_Click(sender As Object, e As EventArgs) Handles addMember.Click

        Me.Hide()
        Form4.Show()


    End Sub

    Private Sub deleteMember_Click(sender As Object, e As EventArgs) Handles deleteMember.Click
        Me.Hide()
        Form5.Show()



    End Sub
End Class