Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False

        ListBox.Items.Add("TIRP")
        ListBox.Items.Add("TIRM")
        ListBox.Items.Add("TIKM")
        ListBox.Items.Add("TIFRP")
        ListBox.Items.Add("TIFRM")
        ListBox.Items.Add("TIFKM")
        ListBox.Items.Add("DKVRP")
        ListBox.Items.Add("DKVRM")
        ListBox.Items.Add("DKVKM")
    End Sub

    Private Sub Biaya_Click(sender As Object, e As EventArgs) Handles Biaya.Click
        Select Case ListBox.Text
            Case "TIRP"
                TextBox1.Text = "3.000.000"
            Case "TIRM"
                TextBox1.Text = "3.250.000"
            Case "TIKM"
                TextBox1.Text = "4.000.000"
            Case "TIFRP"
                TextBox1.Text = "3.250.000"
            Case "TIFRM"
                TextBox1.Text = "4.250.000"
            Case "TIFKM"
                TextBox1.Text = "4.000.000"
            Case "DKVRP"
                TextBox1.Text = "2.250.000"
            Case "DKVRM"
                TextBox1.Text = "3.000.000"
            Case "DKVKM"
                TextBox1.Text = "3.500.000"
        End Select

     

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text

            Case "Sate"
                TextBox1.Text = "10.000"
            Case "Bubur"
                TextBox1.Text = "5000"
            Case "Cilok"
                TextBox1.Text = "1000"
            Case "Gorengan"
                TextBox1.Text = "500"
            Case "Teh"
                TextBox1.Text = "2000"
            Case "Susu"
                TextBox1.Text = "4.000"

        End Select



    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim a As Double
        Dim b As Double

        a = Val(TextBox2.Text)
        b = Val(TextBox3.Text)

        Label1.Text = a * b
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.ResetText()
        TextBox2.Clear()
        TextBox3.Clear()
        Label1.Text = "TOTAL"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.ResetText()
        TextBox2.Clear()
        TextBox3.Clear()
        Label1.Text = "TOTAL"
    End Sub
End Class
