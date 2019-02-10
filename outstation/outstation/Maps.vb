Imports System.Text
Public Class Maps

    Private Sub Maps_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim query As New StringBuilder
            Me.WindowState = FormWindowState.Maximized

            Dim src As String
            Dim des As String

            Dim iitg As String = "IIT Guwahati"
            Dim kam As String = "Kamakhya"
            Dim air As String = "Airport"
            Dim pb As String = "Pan Bazar"
            Dim rail As String = "Railway"

            src = Cab_info.src_cb.Text
            des = Cab_info.des_cb.Text


            query.Append("https://bing.com/maps/default.aspx?rtp=adr.")
            




            If String.Compare(des, iitg) = 0 Then
                des = "IIT%20Guwahati"
            End If

            If String.Compare(des, pb) = 0 Then
                des = "Pan%20Bazzar"
            End If

            

            If String.Compare(des, rail) = 0 Then
                des = "Guwahati%20Railway%20Station"
            End If


            If String.Compare(src, iitg) = 0 Then
                src = "IIT%20Guwahati"
            End If

            If String.Compare(src, pb) = 0 Then
                src = "Pan%20Bazzar"
            End If

            

            If String.Compare(src, rail) = 0 Then
                src = "Guwahati%20Railway%20Station"
            End If


            Dim distance As Decimal

            If String.Compare(src, iitg) = 0 Or String.Compare(des, iitg) = 0 Then
                If String.Compare(src, kam) = 0 Or String.Compare(des, kam) = 0 Then
                    distance = 14.3
                End If
                If String.Compare(src, pb) = 0 Or String.Compare(des, pb) = 0 Then
                    distance = 19.4
                End If
                If String.Compare(src, rail) = 0 Or String.Compare(des, rail) = 0 Then
                    distance = 19.7
                End If

                If String.Compare(src, air) = 0 Or String.Compare(des, air) = 0 Then
                    distance = 23.6
                End If
            End If

            If String.Compare(src, kam) = 0 Or String.Compare(des, kam) = 0 Then

                If String.Compare(src, pb) = 0 Or String.Compare(des, pb) = 0 Then
                    distance = 9.1
                End If
                If String.Compare(src, rail) = 0 Or String.Compare(des, rail) = 0 Then
                    distance = 9.4
                End If

                If String.Compare(src, air) = 0 Or String.Compare(des, air) = 0 Then
                    distance = 17.8
                End If


            End If

            If String.Compare(src, kam) = 0 Or String.Compare(des, kam) = 0 Then

                If String.Compare(src, pb) = 0 Or String.Compare(des, pb) = 0 Then
                    distance = 9.1
                End If
                If String.Compare(src, rail) = 0 Or String.Compare(des, rail) = 0 Then
                    distance = 9.4
                End If

                If String.Compare(src, air) = 0 Or String.Compare(des, air) = 0 Then
                    distance = 17.8
                End If


            End If



            If String.Compare(src, pb) = 0 Or String.Compare(des, pb) = 0 Then


                If String.Compare(src, rail) = 0 Or String.Compare(des, rail) = 0 Then
                    distance = 1.2
                End If

                If String.Compare(src, air) = 0 Or String.Compare(des, air) = 0 Then
                    distance = 22.9
                End If


            End If

            If String.Compare(src, rail) = 0 Or String.Compare(des, rail) = 0 Then


                If String.Compare(src, air) = 0 Or String.Compare(des, air) = 0 Then
                    distance = 7.0
                End If


            End If






            Distance_lbl.Text = distance







            query.Append(src)
            query.Append("~adr.")
            query.Append(des)

            Distance_lbl.Text = distance

            map_browser.Navigate(query.ToString)






        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    
    Private Sub map_browser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles map_browser.DocumentCompleted

    End Sub

    Private Sub Share_Click(sender As Object, e As EventArgs) Handles Sharebtn.Click
        Share.Show()
    End Sub

    Private Sub Booking_Click(sender As Object, e As EventArgs) Handles Booking.Click
        BookingCab.Show()
    End Sub
End Class