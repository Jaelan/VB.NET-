Public Class Form1
    Dim a As Single
    Dim b As Single
    Dim hasil2 As Single



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        a = bil1.Text
        b = bil2.Text
        hasil2 = a And b
        hasil.Text = Format(hasil2, "True/false")

        RadioButton1.Enabled = False
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True
        RadioButton6.Enabled = True
        RadioButton7.Enabled = True
        RadioButton8.Enabled = True
        RadioButton9.Enabled = True

   

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        a = bil1.Text
        b = bil2.Text
        hasil2 = a Or b
        hasil.Text = Format(hasil2, "True/false")

        RadioButton1.Enabled = True
        RadioButton2.Enabled = False
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True
        RadioButton6.Enabled = True
        RadioButton7.Enabled = True
        RadioButton8.Enabled = True
        RadioButton9.Enabled = True

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

        a = bil1.Text
        b = bil2.Text
        hasil2 = a <> b
        hasil.Text = Format(hasil2, "True/false")

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = False
        RadioButton5.Enabled = True
        RadioButton6.Enabled = True
        RadioButton7.Enabled = True
        RadioButton8.Enabled = True
        RadioButton9.Enabled = True

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        a = bil1.Text
        b = bil2.Text
        hasil2 = a <= b
        hasil.Text = Format(hasil2, "True/false")

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = False
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True
        RadioButton6.Enabled = True
        RadioButton7.Enabled = True
        RadioButton8.Enabled = True
        RadioButton9.Enabled = True

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged

        a = bil1.Text
        b = bil2.Text
        hasil2 = a < b
        hasil.Text = Format(hasil2, "True/false")

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True
        RadioButton6.Enabled = True
        RadioButton7.Enabled = True
        RadioButton8.Enabled = False
        RadioButton9.Enabled = True
    

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        a = bil1.Text
        b = bil2.Text
        hasil2 = a > b
        hasil.Text = Format(hasil2, "True/false")

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True
        RadioButton6.Enabled = True
        RadioButton7.Enabled = False
        RadioButton8.Enabled = True
        RadioButton9.Enabled = True
      

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        a = bil1.Text
        b = bil2.Text
        hasil2 = a >= b
        hasil.Text = Format(hasil2, "True/false")

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True
        RadioButton6.Enabled = False
        RadioButton7.Enabled = True
        RadioButton8.Enabled = True
        RadioButton9.Enabled = True

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        a = bil1.Text
        b = bil2.Text
        hasil2 = a = b
        hasil.Text = Format(hasil2, "True/false")

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = False
        RadioButton6.Enabled = True
        RadioButton7.Enabled = True
        RadioButton8.Enabled = True
        RadioButton9.Enabled = True
    

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bil1.Clear()
        bil2.Clear()
        hasil.Text = 0

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True
        RadioButton6.Enabled = True
        RadioButton7.Enabled = True
        RadioButton8.Enabled = True
        RadioButton9.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged

        a = bil1.Text
        b = bil2.Text
        hasil2 = a Xor b
        hasil.Text = Format(hasil2, "True/false")

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True
        RadioButton6.Enabled = True
        RadioButton7.Enabled = True
        RadioButton8.Enabled = True
        RadioButton9.Enabled = False
   
    End Sub

End Class
