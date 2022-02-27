Imports System.Data
Imports System.Data.OleDb
Imports System.Data.DataTable

Public Class login
    Dim con As New OleDb.OleDbConnection
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim dbprovider As String
    Dim dbsource As String
    Dim query As String
    'Dim CMD As New OleDb.OleDbCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dbprovider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbsource = "Data Source=C:\Users\LENOVO\Desktop\PROJECT.NET\project.mdb"
        con.ConnectionString = dbprovider & dbsource
        Dim CMD As New OleDbCommand("select * from login where USERNAME=@user1 and PASSWORD=@pass1", con)
        CMD.Parameters.Add("@user1", OleDbType.VarChar).Value = TextBox1.Text
        CMD.Parameters.Add("@pass1", OleDbType.VarChar).Value = TextBox2.Text
        Dim adapter1 As New OleDbDataAdapter(CMD)
        Dim table As New DataTable
        adapter1.Fill(table)
        If table.Rows.Count <= 0 Then
            MsgBox("Error username or password")
        Else
            MsgBox("LOGIN SUCCESSFUL...!!!")
            MsgBox("WELCOME TO BLOOD BANK MANAGEMENT SYSTEM...!!")
            Timer1.Enabled = True
            ' menus.Show()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Value = ProgressBar1.Value + 5
        Label4.Text = ProgressBar1.Value & "%" & "Completed"
        If ProgressBar1.Value >= 100 Then
            Timer1.Enabled = False
            menus.Show()
        End If
    End Sub
End Class
