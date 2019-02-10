Imports System.Text
Public Class Maps

    Dim fare As Decimal

    Private Sub map_browser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub CalculateFare(dist As Decimal)

        fare = 50
        If dist > 2 Then
            If dist > 10 Then
                fare += 8 * 20
                fare += (dist - 10) * 15
            Else
                fare += (dist - 2) * 20
            End If

        End If
    End Sub


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
            Dim distance As Decimal

            src = cab_info.src_cb.Text
            des = cab_info.des_cb.Text

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

            showDist.Text = CStr(distance)
            CalculateFare(distance)
            money.Text = fare

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

            query.Append(src)
            query.Append("~adr.")
            query.Append(des)

            map_browser.Navigate(query.ToString)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub Booking_Click(sender As Object, e As EventArgs) Handles Booking.Click
        Booking1.Show()
        Me.Hide()

    End Sub

    Private Sub Sharebtn_Click(sender As Object, e As EventArgs) Handles Sharebtn.Click
        Share.Show()
        Me.Hide()
    End Sub

    Private Sub money_Click(sender As Object, e As EventArgs) Handles money.Click

    End Sub
End Class