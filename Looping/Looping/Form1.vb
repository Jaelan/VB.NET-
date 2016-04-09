Public Class Form1

    Dim angka_awal, angka_akhir As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        angka_awal = TextBox1.Text
        angka_akhir = TextBox2.Text

        While angka_awal < (angka_akhir + 1)
            ListBox1.Items.Add(angka_awal)
            angka_awal = angka_awal + 1
        End While

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        angka_awal = TextBox1.Text
        angka_akhir = TextBox2.Text
        ListBox2.Items.Clear()

        Do While angka_awal < (angka_akhir + 1)
            ListBox2.Items.Add(angka_awal)
            angka_awal = angka_awal + 1
        Loop

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        angka_awal = TextBox1.Text
        angka_akhir = TextBox2.Text
        ListBox3.Items.Clear()

        Do
            ListBox3.Items.Add(angka_awal)
            angka_awal += 1
        Loop Until angka_awal > (angka_akhir)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        angka_awal = TextBox1.Text
        angka_akhir = TextBox2.Text
        ListBox4.Items.Clear()

        For Me.angka_awal = angka_awal To angka_akhir
            ListBox4.Items.Add(angka_awal)
        Next
    End Sub
End Class
