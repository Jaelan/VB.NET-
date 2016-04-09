Public Class Form1
    Dim f As Double
    Dim s As Double
    Dim a As Double
    Dim op As String
    Dim n As Int32

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button8.Click, Button7.Click, Button5.Click, Button4.Click, Button3.Click, Button9.Click, Button6.Click, Button28.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click
        Dim b As Button = sender
        If Label1.Text = "0" Then
            Label1.Text = b.Text
        Else
            Label1.Text = Label1.Text + b.Text
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Label1.Text = "0"
        Label2.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "0"
        Label2.Text = Label2.Text + ""
    End Sub

    Private Sub aritmatika(sender As Object, e As EventArgs) Handles Button20.Click, Button2.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click
        Dim ops As Button = sender
        f = Label1.Text
        Label2.Text = Label1.Text
        Label1.Text = ""
        op = ops.Text

        Label2.Text = Label2.Text + " " + op

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        s = Label1.Text

        If op = "+" Then
            a = f + s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "-" Then
            a = f - s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "/" Then
            a = f / s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "*" Then
            a = f * s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "Mod" Then
            a = f Mod s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "Exp" Then
            a = f ^ s
            Label1.Text = a
            Label2.Text = ""

        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If Int32.TryParse(Label1.Text, n) Then
            Label1.Text = Convert.ToString(n, 2)
        Else
            Label1.Text = ""
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        a = Math.Sin(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        a = Math.Cos(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        a = Math.Tan(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        a = Math.Log10(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        a = Math.Sqrt(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        a = Math.Log(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tombol.Enabled = False
        Label1.Text = ""
        Label1.Enabled = False
        Label2.Text = ""
        Label2.Enabled = False
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        a = Label1.Text * Label1.Text
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        a = Label1.Text * Label1.Text * Label1.Text
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        tombol.Enabled = True
        Label1.Text = "0"
        Label1.Enabled = True
        Label2.Text = ""
        Label2.Enabled = True
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        tombol.Enabled = False
        Label1.Text = ""
        Label1.Enabled = False
        Label2.Text = ""
        Label2.Enabled = False
    End Sub

End Class
