Public Class Form1
    Dim nilai As Double
    Dim nilai1 As Double
    Dim nilai2 As Double
    Dim nilai3 As Double
    Dim a As String
    Dim b As Integer
    Dim g As String
    Dim k As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles proses.Click

        a = nama.Text
        b = npm.Text

        nilai1 = Val(tugas.Text) * 20 / 100
        nilai2 = Val(uts.Text) * 30 / 100
        nilai3 = Val(uas.Text) * 50 / 100

        nilai = nilai1 + nilai2 + nilai3

        If nilai >= 90 Then
            MsgBox(" Npm " & b & " nama " & a & " nilai " & nilai & " dengan Grade A ", MsgBoxStyle.Information, "Pertahankan")
        ElseIf nilai < 90 And nilai >= 85 Then
            MsgBox(" Npm " & b & " nama " & a & " nilai " & nilai & " dengan Grade AB ", MsgBoxStyle.Information, "Pertahankan")
        ElseIf nilai < 85 And nilai >= 80 Then
            MsgBox(" Npm " & b & " nama " & a & " nilai " & nilai & " dengan Grade B ", MsgBoxStyle.Information, "Tingkatkan")
        ElseIf nilai < 80 And nilai >= 75 Then
            MsgBox(" Npm " & b & " nama " & a & " nilai " & nilai & " dengan Grade BC ", MsgBoxStyle.Information, "Tingkatkan")
        ElseIf nilai < 75 And nilai >= 70 Then
            MsgBox(" Npm " & b & " nama " & a & " nilai " & nilai & " dengan Grade C ", MsgBoxStyle.Information, "Tingkatkan")
        ElseIf nilai < 70 And nilai >= 65 Then
            MsgBox(" Npm " & b & " nama " & a & " nilai " & nilai & " dengan Grade D ", MsgBoxStyle.Information, "Perbaiki")
        ElseIf nilai < 65 Then
            MsgBox(" Npm " & b & " nama " & a & " nilai " & nilai & " dengan Grade E ", MsgBoxStyle.Information, "Perbaiki")
        End If


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        tugas.Text = ""
        uts.Text = ""
        uas.Text = ""
        npm.Text = ""
        nama.Text = ""
       
    End Sub

    Private Sub tugas_TextChanged(sender As Object, e As EventArgs) Handles tugas.TextChanged

    End Sub
End Class
