Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nama As String
        nama = TextBox1.Text

        If nama = "jaelan" Then
            MsgBox("Selamat Datang " & nama & "!!", MsgBoxStyle.Information, "Jaelan ada")
        Else
            MsgBox(" Maaf " & nama & " namamu tidak terdaftar!! ", MsgBoxStyle.Information, "Tidak Ada")
        End If
    End Sub
End Class
