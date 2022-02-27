Public Class bloodedit
    Dim con As New OleDb.OleDbConnection
    Dim da As New OleDb.OleDbDataAdapter
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim tb As New DataTable("purchase")
    Dim ds As New DataSet
    Dim dbprovider As String
    Dim dbsource As String
    Dim query As String
    Dim query1 As String
    Dim CMD As New OleDb.OleDbCommand
    Dim cm As CurrencyManager
    Private Sub bloodedit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.blood' table. You can move, or remove it, as needed.
        '  Me.BloodTableAdapter.Fill(Me.ProjectDataSet.blood)
        dbprovider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbsource = "Data Source=C:\Users\LENOVO\Desktop\PROJECT.NET\project.mdb"
        con.ConnectionString = dbprovider & dbsource
        con.Open()
        query = "select * from purchase"
        da = New OleDb.OleDbDataAdapter(query, con)
        da.Fill(ds, "purchase")
        ' DataGridView1.DataSource = ds.Tables("blood")
        DataGridView1.DataSource = ds.Tables("purchase")
        cm = CType(Me.BindingContext(ds, "purchase"), CurrencyManager)
        TextBox1.DataBindings.Add("text", ds, "purchase.bloodid")
        ComboBox1.DataBindings.Add("text", ds, "purchase.group")
        TextBox2.DataBindings.Add("text", ds, "purchase.price")
        TextBox3.DataBindings.Add("text", ds, "purchase.bottles")
        TextBox4.DataBindings.Add("text", ds, "purchase.totalprice")
        '  DateTimePicker1.DataBindings.Add("text", ds, "purchase.purchasedate")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As Integer
        ' price() bottles
        query = "update purchase SET price=" + " " & TextBox2.Text & ",bottles=" + "  " & TextBox3.Text & " where bloodid=" + " " & TextBox1.Text & ""
        CMD = New OleDb.OleDbCommand(query, con)
        x = CMD.ExecuteNonQuery()
        If (x) Then
            MsgBox("BLOOD DETAILS UPDATED")
        Else
            MsgBox("CANNOT UPDATE BLOOD DETAILS")
        End If
        ds.Tables.Clear()
        da.Fill(ds, "purcahase")
        DataGridView1.DataSource = ds.Tables("purchase")
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cm.Position = 0

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cm.Position -= 1
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        cm.Position += 1
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        cm.Position = cm.Count - 1
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim x As Integer
        'query = "delete from blood where bid=300"
        query = "delete from purchase where bloodid=" & TextBox1.Text & ""

        CMD = New OleDb.OleDbCommand(query, con)
        x = CMD.ExecuteNonQuery()
        If (x) Then
            MsgBox("DATA DELETED SUCCESSFULLY....!!")
        Else
            MsgBox("SOMETHING WENT WRONG CANNOT DELETE DATA")
        End If
        ds.Tables.Clear()
        da.Fill(ds, "purchase")
        DataGridView1.DataSource = ds.Tables("purchase")

    End Sub
End Class