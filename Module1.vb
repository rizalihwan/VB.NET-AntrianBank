Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As New DataSet
    Public DA As OleDbDataAdapter
    Public RD As OleDbDataReader
    Public lokasidata As String
    Public Sub konek()
        lokasidata = "provider=microsoft.jet.oledb.4.0;data source=BAP.mdb"
        conn = New OleDbConnection(lokasidata)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Public Sub telerr()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = "select max(no_antrian_tlr) as iaia from dataantrianb "
        RD = objcmd.ExecuteReader()
        RD.Read()
        If RD.HasRows Then
            Form3.TextBox1.Text = RD.Item("iaia")

        Else
        End If
    End Sub
    Public Sub counter_strike()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = "select max(no_antrian_cs) as okok from dataantrian "
        RD = objcmd.ExecuteReader()
        RD.Read()


    End Sub
End Module