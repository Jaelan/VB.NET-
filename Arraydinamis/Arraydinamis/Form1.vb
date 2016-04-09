Public Class Form1
    Dim indexs_data As Byte = 0
    Dim jumlah_data As Byte = 5
    Dim npm_mahasiswa() As String
    Dim nama_mahasiswa() As String

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If indexs_data > jumlah_data - 1 Then
            MsgBox("List data sudah penuh!!")
        Else
            npm_mahasiswa(indexs_data) = txtnpm.Text
            nama_mahasiswa(indexs_data) = txtnama.Text
            txtnama.Clear()
            txtnpm.Clear()
            indexs_data = indexs_data + 1
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim npm_mahasiswa(5)
        ReDim nama_mahasiswa(5)

    End Sub

    Private Sub btnlihatdata_Click(sender As Object, e As EventArgs) Handles btnlihatdata.Click
        Dim i As Byte
        If indexs_data > 0 Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            For i = 0 To indexs_data - 1
                ListBox1.Items.Add(npm_mahasiswa(i))
                ListBox2.Items.Add(nama_mahasiswa(i))
            Next
        End If
    End Sub

    Private Sub btnsetarray_Click(sender As Object, e As EventArgs) Handles btnsetarray.Click
        jumlah_data = InputBox("Jumlah Array", "Set Jumlah Array", 5)
        ReDim npm_mahasiswa(jumlah_data)
        ReDim nama_mahasiswa(jumlah_data)
        indexs_data = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
