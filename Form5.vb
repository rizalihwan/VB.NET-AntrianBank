Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "001" And TextBox2.Text = "devan" Then
            MsgBox("Login Berhasil")
            Form3.Label1.Hide()
            Form3.Label8.Hide()
            Form3.Button1.Hide()
            Form3.Button2.Hide()
            Form3.Button5.Hide()
            Form3.Button3.Show()
            Form3.Button4.Show()
            Form3.Button6.Show()
            Form3.DataGridView1.Show()
            Form3.DataGridView2.Hide()
            Form3.Label6.Hide()
            Form3.Label7.Hide()
            Form3.Label8.Hide()
            Me.Close()
        ElseIf ComboBox1.Text = "002" And TextBox2.Text = "rizal" Then
            MsgBox("Login Berhasil")
            Form3.Label1.Hide()
            Form3.Label8.Hide()
            Form3.Button1.Hide()
            Form3.Button2.Hide()
            Form3.Button5.Hide()
            Form3.Button3.Show()
            Form3.Button4.Show()
            Form3.Button6.Show()
            Form3.DataGridView1.Show()
            Form3.DataGridView2.Hide()
            Form3.Label6.Hide()
            Form3.Label7.Hide()
            Form3.Label8.Hide()
            Me.Close()
        Else
            MsgBox("login gagal")
        End If
        Form3.Show()
        ComboBox1.SelectedIndex = -1
        TextBox2.Clear()
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("001")
            .Add("002")
        End With
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class