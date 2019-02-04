Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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

        
    End Sub
End Class