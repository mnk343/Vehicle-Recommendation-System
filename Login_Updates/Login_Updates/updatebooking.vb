﻿Imports System.Data.OleDb
Imports System.Text
Imports System.Math


Public Class updatebooking


    Private Access As New DBControl

    Private Sub updatebooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim cid As String = ""
        Dim seater As String = ""
        Dim username = Update_Login.TextBox1.Text
        Dim querry As String = "Select * From [CabData] Where [UserName]= '" + username + "';"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Lenovo\Desktop\buffer\Vehicle-Recommendation-System\Vehicle-Recommendation-System-Database.accdb'"
        Dim conn As New OleDbConnection(dbsource)
        Dim cmd As New OleDbCommand(querry, conn)
        conn.Open()
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        While reader.Read()
            cid = CStr(reader(0))
            seater = CStr(reader(13))

        End While
        cid_lbl.Text = cid
        cmd.Dispose()
        conn.Close()

        Access.ExecQuery("SELECT Booking.* FROM Booking WHERE Booking.CabId = " + cid + ";")


        book_dgv.DataSource = Access.DBDT








    End Sub




    Private Sub book_dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles book_dgv.CellDoubleClick

        Dim row_index As Integer
        Dim query As New StringBuilder
        row_index = e.RowIndex
        If row_index >= 0 Then
            Dim row As DataGridViewRow = book_dgv.Rows([row_index])

            Dim bid As String = row.Cells(0).Value.ToString
            bid_lbl.Text = bid
            MessageBox.Show(bid_lbl.Text)
            Bookingpart2.Show()

            Me.Hide()
        End If

    End Sub


End Class