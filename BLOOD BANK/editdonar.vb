Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class editdonar
    Dim con As New OleDb.OleDbConnection
    Dim da As New OleDb.OleDbDataAdapter
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim tb As New DataTable("donar")
    Dim datatableall, datatable1id As DataTable
    Dim ds As New DataSet
    Dim dbprovider As String
    Dim dbsource As String
    Dim query As String
    Dim query1 As String
    Dim CMD As New OleDb.OleDbCommand
    Dim cm As CurrencyManager
    Private Sub editdonar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        dbprovider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbsource = "Data Source=C:\Users\LENOVO\Desktop\PROJECT.NET\project.mdb"
        con.ConnectionString = dbprovider & dbsource
        con.Open()
        query = "select * from donar"
        da = New OleDb.OleDbDataAdapter(query, con)
        da.Fill(ds, "donar")
        '  DataGridView1.DataSource = ds.Tables("donar")
        DataGridView1.DataSource = ds.Tables("donar")
        cm = CType(Me.BindingContext(ds, "donar"), CurrencyManager)
      
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim x As Integer
        'query = "delete from blood where bid=300"
        query = "delete from donar where donarid=" & TextBox1.Text & ""

        CMD = New OleDb.OleDbCommand(query, con)
        x = CMD.ExecuteNonQuery()
        If (x) Then
            MsgBox("DATA DELETED SUCCESSFULLY....!!")
        Else
            MsgBox("SOMETHING WENT WRONG CANNOT DELETE DATA")
        End If
        ds.Tables.Clear()
        da.Fill(ds, "donar")
        DataGridView1.DataSource = ds.Tables("donar")
        
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DataGridView1.Rows(index)
        TextBox1.Text = selectedrow.Cells(0).Value.ToString()
        TextBox2.Text = selectedrow.Cells(1).Value.ToString()
        TextBox3.Text = selectedrow.Cells(2).Value.ToString()
        TextBox8.Text = selectedrow.Cells(3).Value.ToString()
        ComboBox1.Text = selectedrow.Cells(4).Value.ToString()
        TextBox4.Text = selectedrow.Cells(5).Value.ToString()
        TextBox5.Text = selectedrow.Cells(6).Value.ToString()
        ComboBox2.Text = selectedrow.Cells(7).Value.ToString()
        TextBox6.Text = selectedrow.Cells(8).Value.ToString()
        ComboBox3.Text = selectedrow.Cells(9).Value.ToString()
        TextBox7.Text = selectedrow.Cells(10).Value.ToString()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
      
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As Integer
        'query = "delete from blood where bid=300"
        'query = "delete from donar where donarid=" & TextBox1.Text & ""
        query = "update donar set donarname=" + " '" & TextBox2.Text & "',age=" + " " & TextBox3.Text & ",address=" + " '" & TextBox4.Text & "',phno=" + " '" & TextBox5.Text & "',weight=" + " " & TextBox6.Text & ",disease=" + " '" & TextBox7.Text & "' where donarid =" + " " & TextBox1.Text & " "
        CMD = New OleDb.OleDbCommand(query, con)
        x = CMD.ExecuteNonQuery()
        If (x) Then
            MsgBox("DONAR DATA UPDATED SUCCESSFULLY")
        Else
            MsgBox("CANNOT UPDATE DATA OF THE DONAR")
        End If
        ds.Tables.Clear()
        da.Fill(ds, "donar")
        DataGridView1.DataSource = ds.Tables("donar")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cm.Position = 0
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        cm.Position -= 1
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        cm.Position += 1
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        cm.Position = cm.Count - 1
    End Sub
End Class