Public Class Form3
    Public counter As Integer
    Public counterb As Integer
    Dim go As String

    Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM dataantrian", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "dataantrian")
        DataGridView2.DataSource = DS.Tables("dataantrian")
        DataGridView2.Enabled = True
    End Sub
    Sub panggildatab()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM dataantrianb", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "dataantrianb")
        DataGridView1.DataSource = DS.Tables("dataantrianb")
        DataGridView1.Enabled = True
    End Sub
    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = go
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panggildata()
        panggildatab()

        counter = Val(Form2.Label2.Text)
        Call telerr()
        Call counter_strike()
        Label8.Hide()
        Button2.Hide()
        Button4.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        TextBox1.Text = Val(TextBox1.Text) + 1
        Label3.Text = DateTimePicker1.Text
        go = "insert into dataantrianb (no_antrian_tlr,tgl_antrian_tlr) values ('" & TextBox1.Text & "','" & Label3.Text & "')"
        Call jalan()
        MsgBox("tiket terambil")
        Call panggildatab()
        counter = Val(TextBox1.Text)
        tiket1.Label1.Text = Format(counter, "0 0 0")
        tiket1.Show()
        Form1.Label1.Text = Format(counter, "0 0 0")
        Form2.Label2.Text = Format(counter, "0 0 0")
        Form1.Button1.Hide()
        Dim b As String() = Form1.Label1.Text.Split(New Char() {" "c})
        Dim a As String
        For Each a In b
            Form1.ComboBox1.Items.Add(a)
        Next
        tiket1.Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form4.Show()
        TextBox2.Text = Val(TextBox2.Text) + 1
        Label5.Text = DateTimePicker1.Text
        go = "insert into dataantrian (no_antrian_cs,tgl_antrian_cs) values('" & TextBox2.Text & "','" & Label5.Text & "')"
        Call jalan()
        MsgBox("Tiket terambil")
        Call panggildata()

        counterb = Val(TextBox2.Text)
        tiket2.Label1.Text = Format(counterb, "0 0 0")
        tiket2.Show()
        Form4.Label2.Text = Format(counterb, "0 0 0")
        Form2.Label3.Text = Format(counterb, "0 0 0")
        Form4.Button1.Hide()
        Dim b As String() = Form4.Label2.Text.Split(New Char() {" "c})
        Dim a As String
        For Each a In b
            Form4.ComboBox1.Items.Add(a)
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        go = "delete from dataantrianb no_antrian_tlr"
        Call jalan()
        MsgBox("Data terhapus")
        Call panggildatab()
        TextBox1.Text = 0
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        go = "delete from dataantrian no_antrian_cs"
        Call jalan()
        MsgBox("Data terhapus")
        Call panggildata()
        TextBox2.Text = 0
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form5.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Label1.Show()
        Button1.Show()
        Button2.Show()
        Button5.Show()
        Button3.Hide()
        Button4.Hide()
        Button6.Hide()
        DataGridView1.Hide()
        DataGridView2.Hide()
        Label6.Show()
        Label7.Show()
        Label8.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
End Class