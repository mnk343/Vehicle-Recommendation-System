Public Class Form1

    Private Access As New DBControl

    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' RUN QUERY
        Access.ExecQuery("SELECT CabId, UserName, Contact FROM CabData WHERE Status = TRUE;")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT
    End Sub


    Private Sub shilong_btn_Click(sender As Object, e As EventArgs) Handles shilong_btn.Click
        find_text_box.Text = ""
        ' RUN QUERY
        Access.ExecQuery("SELECT CabId, UserName, Contact  FROM CabData WHERE Shillong = TRUE AND Status = TRUE;")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT
    End Sub

    Private Sub tawang_btn_Click(sender As Object, e As EventArgs) Handles tawang_btn.Click
        find_text_box.Text = ""
        ' RUN QUERY

        Access.ExecQuery("SELECT CabId, UserName, Contact  FROM CabData WHERE Tawang = TRUE AND Status = TRUE;")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT
    End Sub

    Private Sub gang_btn_Click(sender As Object, e As EventArgs) Handles gang_btn.Click
        ' RUN QUERY
        find_text_box.Text = ""
        Access.ExecQuery("SELECT CabId, UserName, Contact  FROM CabData WHERE Gangtok = TRUE AND Status = TRUE;")
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRID
        dgvData.DataSource = Access.DBDT
    End Sub


    Private Sub SearchMember(Name As String)
        ' ADD PARAMETERS & RUN QUERY
        Access.AddParam("@user", "%" & Name & "%")
        Access.ExecQuery("SELECT CabId, UserName, Contact " & _
                         "FROM CabData " & _
                         "WHERE UserName LIKE @user AND Status = TRUE")

        ' REPORT & ABORT ON ERRORS
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' FILL DATAGRIDVIEW
        dgvData.DataSource = Access.DBDT
    End Sub


    Private Sub find_outstation_btn_Click(sender As Object, e As EventArgs) Handles find_outstation_btn.Click
        SearchMember(find_text_box.Text)
    End Sub
End Class
