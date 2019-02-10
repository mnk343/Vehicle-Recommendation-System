Imports System.Text
Imports System.Math
Public Class E_rickshaw

    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function



    Private Sub SearchMember(Name As String)
        ' ADD PARAMETERS & RUN QUERY
        Access.AddParam("@user", "%" & Name & "%")
        Access.ExecQuery("SELECT UserName,Contact " & _
                         "FROM [E-RickshawData] " & _
                         "WHERE username LIKE @user AND Status=TRUE ")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRIDVIEW
        e_dgv.DataSource = Access.DBDT
    End Sub

    Private Sub cmdFind_Click(sender As System.Object, e As System.EventArgs) Handles cmdFind.Click
        SearchMember(txtFind.Text)
    End Sub



    Private Sub E_rickshaw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Access.ExecQuery("SELECT UserName,Contact FROM [E-RickshawData] WHERE Status=TRUE")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        e_dgv.DataSource = Access.DBDT



        Access.ExecQuery("SELECT Latitude,Longitude,UserName FROM [E-RickshawData] WHERE Status=TRUE")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        e_fullData_dgv.DataSource = Access.DBDT



        Dim min As Double = 1000000
        Dim lat1 As Double = 26.192824   ' Of User
        Dim lon1 As Double = 91.695249   ' Of User 
        Dim R As Double = 6371

        Dim driver As String = "Temp"
        Dim row_of_driver As Integer = 0


        Dim newCol As New DataGridViewTextBoxColumn

        newCol.HeaderText = "Distance"
        newCol.Name = "Distance"
        newCol.Visible = True
        newCol.Width = 80


        'Dim cell As New DataGridViewCell

        ' newCol.CellTemplate = cell


        ' newCol.DataPropertyName = e_dgv.Columns(0).DataPropertyName
        e_dgv.Columns.Add(newCol)






        For row_index As Integer = 0 To e_fullData_dgv.RowCount - 1


            Dim lat2 As Double = e_fullData_dgv.Rows(row_index).Cells(0).Value
            Dim lon2 As Double = e_fullData_dgv.Rows(row_index).Cells(1).Value

            Dim dlat As Double = (lat2 - lat1) * (Math.PI / 180)
            Dim dLon As Double = (lon2 - lon1) * (Math.PI / 180)
            Dim a As Double = Math.Sin(dlat / 2) * Math.Sin(dlat / 2) +
                                Math.Cos((lat2) * (Math.PI / 180)) * Math.Cos((lat2) * (Math.PI / 180)) *
                                Math.Sin(dLon / 2) * Math.Sin(dLon / 2)

            Dim d As Double = R * 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a))
            d *= 1000
            d = Math.Round(d, 3)
            Dim distance As String = CStr(d)
            distance += " m"

            If (row_index <= e_dgv.RowCount - 1) Then
                e_dgv.Rows(row_index).Cells(2).Value = distance
            End If

            If d < min Then
                min = d
                driver = e_dgv.Rows(row_index).Cells(0).Value

                row_of_driver = row_index
            End If


        Next
       
        Dim sug As String = "Closest Driver from you is " + driver + " at distance " + e_dgv.Rows(row_of_driver).Cells(2).Value + " meters"
       

        Label2.Text = sug
        e_dgv.Rows(row_of_driver).DefaultCellStyle.BackColor = Color.Red
        e_dgv.Rows(row_of_driver).DefaultCellStyle.ForeColor = Color.White

    End Sub

    Private Sub e_dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles e_dgv.CellDoubleClick
        Dim row_index As Integer
        Dim query As New StringBuilder
        row_index = e.RowIndex
        If row_index >= 0 Then
            Dim row As DataGridViewRow = e_fullData_dgv.Rows([row_index])

            Dim lat As String = row.Cells(0).Value.ToString
            Dim longi As String = row.Cells(1).Value.ToString

            'rtp=pos.42.2_-122.3~pos.55.2_-127.0
            query.Append("https://bing.com/maps/default.aspx?rtp=pos.26.192824_91.695249~pos.")
            'query.Append("https://bing.com/maps/default.aspx?sp=point.")
            query.Append(lat)
            query.Append("_")
            query.Append(longi)
            'query.Append("_")
            'query.Append(row.Cells(2).Value.ToString)
            query.Append("&lvl=15")
            Label1.Text = query.ToString

            
            rickshaw_map.Show()

        End If
    End Sub
End Class