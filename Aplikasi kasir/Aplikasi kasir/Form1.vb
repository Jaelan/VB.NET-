Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Penghapus"
                harga.Text = "55000"
            Case "Pensil"
                harga.Text = "45000"
            Case "Penggaris"
                harga.Text = "50000"
        End Select
    End Sub


    Private Sub jumlah_TextChanged(sender As Object, e As EventArgs) Handles jumlah.TextChanged
        subtot.Text = Val(jumlah.Text) * Val(harga.Text)
    End Sub

    Private Sub subtot_TextChanged(sender As Object, e As EventArgs) Handles subtot.TextChanged
        If subtot.Text > 200000 Then
            diskon.Text = Val(subtot.Text) - Val(total.Text)
            Label7.Text = "10%"
            total.Text = Val(subtot.Text) * 10 / 100
        End If

        If subtot.Text > 500000 Then
            diskon.Text = Val(subtot.Text) - Val(total.Text)
            Label7.Text = "15%"
            total.Text = Val(subtot.Text) * 15 / 100
        End If

        If subtot.Text > 1000000 Then
            diskon.Text = Val(subtot.Text) - Val(total.Text)
            Label7.Text = "20%"
            total.Text = Val(subtot.Text) * 20 / 100
        End If

        If subtot.Text < 200000 Then
            diskon.Text = "0"
            Label7.Text = "%"
            total.Text = subtot.Text
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Text = ""
        harga.Text = 0
        jumlah.Text = ""
        subtot.Text = 0
        diskon.Text = 0
        total.Text = 0
        Label7.Text = "%"
    End Sub
End Class
