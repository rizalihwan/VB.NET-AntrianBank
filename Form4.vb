Public Class Form4

    Public counterb As Integer
    Sub play0()
        My.Computer.Audio.Play(My.Resources._0_D,
       AudioPlayMode.WaitToComplete)
    End Sub
    Sub play1()
        My.Computer.Audio.Play(My.Resources._1_D,
       AudioPlayMode.WaitToComplete)
    End Sub
    Sub play2()
        My.Computer.Audio.Play(My.Resources._2_D,
       AudioPlayMode.WaitToComplete)
    End Sub
    Sub play3()
        My.Computer.Audio.Play(My.Resources._3_D,
       AudioPlayMode.WaitToComplete)
    End Sub
    Sub play4()
        My.Computer.Audio.Play(My.Resources._4_D,
       AudioPlayMode.WaitToComplete)
    End Sub
    Sub play5()
        My.Computer.Audio.Play(My.Resources._5_D,
       AudioPlayMode.WaitToComplete)
    End Sub
    Sub play6()
        My.Computer.Audio.Play(My.Resources._6_D,
       AudioPlayMode.WaitToComplete)
    End Sub
    Sub play7()
        My.Computer.Audio.Play(My.Resources._7_D,
       AudioPlayMode.WaitToComplete)
    End Sub
    Sub play8()
        My.Computer.Audio.Play(My.Resources._8_D,
       AudioPlayMode.WaitToComplete)
    End Sub
    Sub play9()
        My.Computer.Audio.Play(My.Resources._9_D,
       AudioPlayMode.WaitToComplete)
    End Sub
    Private Sub audio()
        My.Computer.Audio.Play(My.Resources.no_antrian_D,
       AudioPlayMode.WaitToComplete)
        ComboBox1.SelectedIndex = 0
        If ComboBox1.Text = "0" Then
            play0()
        ElseIf ComboBox1.Text = "1" Then
            play1()
        ElseIf ComboBox1.Text = "2" Then
            play2()
        ElseIf ComboBox1.Text = "3" Then
            play3()
        ElseIf ComboBox1.Text = "4" Then
            play4()
        ElseIf ComboBox1.Text = "5" Then
            play5()
        ElseIf ComboBox1.Text = "6" Then
            play6()
        ElseIf ComboBox1.Text = "7" Then
            play7()
        ElseIf ComboBox1.Text = "8" Then
            play8()
        ElseIf ComboBox1.Text = "9" Then
            play9()
        End If
        ComboBox1.SelectedIndex = 1
        If ComboBox1.Text = "0" Then
            play0()
        ElseIf ComboBox1.Text = "1" Then
            play1()
        ElseIf ComboBox1.Text = "2" Then
            play2()
        ElseIf ComboBox1.Text = "3" Then
            play3()
        ElseIf ComboBox1.Text = "4" Then
            play4()
        ElseIf ComboBox1.Text = "5" Then
            play5()
        ElseIf ComboBox1.Text = "6" Then
            play6()
        ElseIf ComboBox1.Text = "7" Then
            play7()
        ElseIf ComboBox1.Text = "8" Then
            play8()
        ElseIf ComboBox1.Text = "9" Then
            play9()
        End If
        ComboBox1.SelectedIndex = 2
        If ComboBox1.Text = "0" Then
            play0()
        ElseIf ComboBox1.Text = "1" Then
            play1()
        ElseIf ComboBox1.Text = "2" Then
            play2()
        ElseIf ComboBox1.Text = "3" Then
            play3()
        ElseIf ComboBox1.Text = "4" Then
            play4()
        ElseIf ComboBox1.Text = "5" Then
            play5()
        ElseIf ComboBox1.Text = "6" Then
            play6()
        ElseIf ComboBox1.Text = "7" Then
            play7()
        ElseIf ComboBox1.Text = "8" Then
            play8()
        ElseIf ComboBox1.Text = "9" Then
            play9()
        End If
        My.Computer.Audio.Play(My.Resources.Loket_D,
       AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(My.Resources.B_D,
       AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        audio()

        Form2.Label3.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        counterb = counterb + 1
        ComboBox1.Items.Clear()
        Label2.Text = Format(counterb, "0 0 0")
        Form2.Label3.Text = Format(counterb, "0 0 0")

        Dim b As String() = Label2.Text.Split(New Char() {" "c})
        Dim a As String
        For Each a In b
            ComboBox1.Items.Add(a)
        Next
        If Label2.Text = "0 9 9" Then
            counterb = counterb - 99
        End If
        If Label2.Text = tiket2.Label1.Text Then
            Button1.Hide()
        End If
    End Sub

    Private Sub Form4_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        counterb = Val(Form2.Label3.Text)
        Label1.Text = DateTimePicker1.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Label3.ForeColor = Color.Red
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        counterb = counterb - 1
        ComboBox1.Items.Clear()
        Label2.Text = Format(counterb, "0 0 0")
        Form2.Label3.Text = Format(counterb, "0 0 0")
        Dim b As String() = Label2.Text.Split(New Char() {" "c})
        Dim a As String
        For Each a In b
            ComboBox1.Items.Add(a)
        Next
        If Label2.Text = "0 0 0" Then
            counterb = counterb + 99
        End If

        Button1.Show()
    End Sub
End Class