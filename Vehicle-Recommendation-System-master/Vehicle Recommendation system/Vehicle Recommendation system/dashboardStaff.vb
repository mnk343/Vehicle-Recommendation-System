Imports System.Data.OleDb
Imports System.Data

Public Class dashboardStaff

    Private Sub dashboardStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub changePassword_Click(sender As Object, e As EventArgs) Handles changePassword.Click

        Me.Hide()
        passwordChange.Show()

    End Sub

    Private Sub prevPage_Click(sender As Object, e As EventArgs) Handles prevPage.Click
        MessageBox.Show("You are on the home page of your dashboard...Click on Sign out button to log out.")

    End Sub

    Private Sub signOut_Click(sender As Object, e As EventArgs) Handles signOut.Click
        MessageBox.Show("Signing out from your account. ")
        Me.Hide()
        loginForm.Show()

    End Sub

    Private Sub addMember_Click(sender As Object, e As EventArgs) Handles addMember.Click

        Me.Hide()
        memberAdd.Show()

    End Sub

    Private Sub deleteMember_Click(sender As Object, e As EventArgs) Handles deleteMember.Click
        Me.Hide()
        memberDelete.Show()

    End Sub

    Private Sub changePassword_MouseClick(sender As Object, e As MouseEventArgs) Handles changePassword.MouseClick
        changePassword.BackColor = Color.LightSeaGreen
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

    Private Sub changePassword_MouseHover(sender As Object, e As EventArgs) Handles changePassword.MouseHover
        changePassword.BackColor = Color.LightGray
    End Sub

    Private Sub changePassword_MouseLeave(sender As Object, e As EventArgs) Handles changePassword.MouseLeave
        changePassword.BackColor = Color.Black
    End Sub

    Private Sub addMember_MouseClick(sender As Object, e As MouseEventArgs) Handles addMember.MouseClick
        addMember.BackColor = Color.LightSeaGreen
    End Sub


    Private Sub addMember_MouseHover(sender As Object, e As EventArgs) Handles addMember.MouseHover
        addMember.BackColor = Color.LightGray
    End Sub

    Private Sub addMember_MouseLeave(sender As Object, e As EventArgs) Handles addMember.MouseLeave
        addMember.BackColor = Color.Black
    End Sub

    Private Sub deleteMember_MouseClick(sender As Object, e As MouseEventArgs) Handles deleteMember.MouseClick
        deleteMember.BackColor = Color.LightSeaGreen
    End Sub


    Private Sub deleteMember_MouseHover(sender As Object, e As EventArgs) Handles deleteMember.MouseHover
        deleteMember.BackColor = Color.LightGray
    End Sub

    Private Sub deleteMember_MouseLeave(sender As Object, e As EventArgs) Handles deleteMember.MouseLeave
        deleteMember.BackColor = Color.Black
    End Sub

    Private Sub signOut_MouseClick(sender As Object, e As MouseEventArgs) Handles signOut.MouseClick
        signOut.BackColor = Color.LightSeaGreen
    End Sub


    Private Sub signOut_MouseHover(sender As Object, e As EventArgs) Handles signOut.MouseHover
        signOut.BackColor = Color.LightGray
    End Sub

    Private Sub signOut_MouseLeave(sender As Object, e As EventArgs) Handles signOut.MouseLeave
        signOut.BackColor = Color.Transparent
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        memberUpdate.show()
        Me.Hide()

    End Sub
End Class