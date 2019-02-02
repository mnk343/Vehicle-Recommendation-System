Imports System.Data.OleDb
Imports System.Data

Public Class OutStation

    Private Sub OutStation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Vehicle_Recommendation_System_DatabaseDataSet.CarHireData' table. You can move, or remove it, as needed.
        Me.CarHireDataTableAdapter.Fill(Me.Vehicle_Recommendation_System_DatabaseDataSet.CarHireData)
        Dim querry As String = "Select * From CarHireData;"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='|DataDirectory|\Vehicle Recommendation System Database.accdb' "
        Dim conn = New OleDbConnection(dbsource)
        Dim cmd As New OleDbCommand(querry, conn)
        conn.Open()
        Dim a As New DataTable
        Dim b As New BindingSource






    End Sub
End Class