Imports System.Data.OleDb
Imports System.Text
Imports System.Math

Public Class updateBooking
    Private Access As New DBControl

    Private Sub updateBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cid As String = ""
        Dim seater As String = ""
        Dim username = loginForm.TextBox1.Text
        Dim querry As String = "Select * From [CabData] Where [UserName]= '" + username + "';"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\mayan\Desktop\Vehicle-Recommendation-System\Vehicle Recommendation System Database.accdb'"
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

        book_dgv.BorderStyle = BorderStyle.None
        book_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        book_dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        book_dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
        book_dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke

        book_dgv.EnableHeadersVisualStyles = False
        book_dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        book_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
        book_dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        book_dgv.RowTemplate.Height = 22
        book_dgv.DefaultCellStyle.Padding.Bottom.Equals(4)
        book_dgv.DefaultCellStyle.Padding.Bottom.Equals(4)
        Label1.Hide()

        If book_dgv.RowCount = 1 Then
            book_dgv.Hide()
            Label1.Show()
        End If


    End Sub

    Private Sub book_dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles book_dgv.CellDoubleClick

        Dim row_index As Integer
        Dim query As New StringBuilder
        row_index = e.RowIndex
        If row_index >= 0 Then
            Dim row As DataGridViewRow = book_dgv.Rows([row_index])

            Dim bid As String = row.Cells(0).Value.ToString
            bid_lbl.Text = bid
            'MessageBox.Show(bid_lbl.Text)
            bookingPart2.Show()

            Me.Hide()
        End If

    End Sub

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles back.Click
        dashboardCab.Show()
        Me.Close()

    End Sub

    
End Class