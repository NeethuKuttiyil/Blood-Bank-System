Public Class purchase
    Dim con As New OleDb.OleDbConnection
    Dim da As New OleDb.OleDbDataAdapter
    Dim dr As System.Data.OleDb.OleDbDataReader
    Dim tb As New DataTable("purchase")
    Dim datatableall, datatable1id As DataTable
    Dim ds As New DataSet
    Dim dbprovider As String
    Dim dbsource As String
    Dim query As String
    Dim query1 As String
    Dim CMD As New OleDb.OleDbCommand
    Public group, price, nm, bt, tot, dat As String
    Private Sub purchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbprovider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbsource = "Data Source=C:\Users\LENOVO\Desktop\PROJECT.NET\project.accdb"
        con.ConnectionString = dbprovider & dbsource
        con.Open()
        query = "select * from purchase"
        da = New OleDb.OleDbDataAdapter(query, con)
        da.Fill(ds, "purchase")
        '  DataGridView1.DataSource = ds.Tables("purchase")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '  Dim sum As Integer
        TextBox3.Text = CInt(TextBox1.Text) * CInt(TextBox2.Text)
        MsgBox("TOTAL PRICE OF BOTTLES   " + TextBox3.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim x As Integer
        query = "insert into purchase values(" & CInt(TextBox5.Text) & ",'" & ComboBox1.Text & "'," & CInt(TextBox1.Text) & "," & CInt(TextBox2.Text) & "," & CInt(TextBox3.Text) & ",'" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "')"
        CMD = New OleDb.OleDbCommand(query, con)
        x = CMD.ExecuteNonQuery()
        If (x) Then
            MsgBox("DATA SAVED")
            MsgBox("BLOOD PURCHASED SUCCESSFULLY")
        Else
            MsgBox("DATA NOT SAVED")
        End If
        ds.Tables.Clear()
        da.Fill(ds, "purchase")
        ' DataGridView1.DataSource = ds.Tables("purchase")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        group = ComboBox1.Text
        price = TextBox1.Text
        nm = TextBox4.Text
        bt = TextBox2.Text
        tot = TextBox3.Text
        dat = DateTimePicker1.Text
        Form2.Show()
    End Sub

   

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("YOU CAN ONLY INPUT NUMBERS")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("YOU CAN ONLY INPUT NUMBERS")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("YOU CAN ONLY INPUT NUMBERS")
        End If
    End Sub

   
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("YOU CAN ONLY INPUT NUMBERS")
        End If
    End Sub

   
   
   
   
End Class