Public Class Form1

    Dim index_data As Byte = 0
    Private jumlah_data As Byte = 5
    Dim mahasiswa(5, 2)

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If index_data > jumlah_data - 1 Then
            MsgBox("List Data Penuh!!")
        Else
            mahasiswa(index_data, 0) = txtnpm.Text
            mahasiswa(index_data, 1) = txtnama.Text
            txtnama.Clear()
            txtnpm.Clear()
            index_data = index_data + 1
        End If
    End Sub

    Private Sub btnlihatdata_Click(sender As Object, e As EventArgs) Handles btnlihatdata.Click
        Dim i As Byte
        If index_data > 0 Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()

            For i = 0 To index_data - 1
                ListBox1.Items.Add(mahasiswa(i, 0))
                ListBox2.Items.Add(mahasiswa(i, 1))
            Next
        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub
End Class
