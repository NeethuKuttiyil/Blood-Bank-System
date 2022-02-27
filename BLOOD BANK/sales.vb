Public Class sales
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
    ' Dim ds As New DataSet
    Dim table As New DataTable("purchase")
    Public group, price, nm, hn, no, tot, age, gender As String
    Private Sub sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbprovider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbsource = "Data Source=C:\Users\LENOVO\Desktop\PROJECT.NET\project.accdb"
        con.ConnectionString = dbprovider & dbsource
        con.Open()
        query = "select * from purchase"
        da = New OleDb.OleDbDataAdapter(query, con)
        da.Fill(ds, "purchase")
        DataGridView1.DataSource = ds.Tables("purchase")
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DataGridView1.Rows(index)
        TextBox10.Text = selectedrow.Cells(0).Value.ToString()
        TextBox1.Text = selectedrow.Cells(1).Value.ToString()
        TextBox2.Text = selectedrow.Cells(2).Value.ToString()
        TextBox3.Text = selectedrow.Cells(3).Value.ToString()
        TextBox4.Text = selectedrow.Cells(4).Value.ToString()
        TextBox5.Text = selectedrow.Cells(5).Value.ToString()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox9.Text = TextBox2.Text * TextBox8.Text
        MsgBox("TOTAL AMOUNT CALCULATED    " + TextBox9.Text)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        group = TextBox1.Text
        price = TextBox2.Text
        nm = TextBox6.Text
        hn = TextBox7.Text
        no = TextBox8.Text
        tot = TextBox9.Text
        age = TextBox12.Text
        gender = TextBox11.Text
        Form3.Show()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim x As Integer
        query = "insert into patient values('" & TextBox6.Text & "','" & TextBox7.Text & "'," & CInt(TextBox8.Text) & "," & CInt(TextBox9.Text) & ",'" & DateTimePicker1.Text & "'," & CInt(TextBox12.Text) & ",'" & ComboBox1.Text & "','" & TextBox11.Text & "')"
        CMD = New OleDb.OleDbCommand(query, con)
        x = CMD.ExecuteNonQuery()
        If (x) Then
            MsgBox("BLOOD DONATED TO PATIENT")
        Else
            MsgBox("COULD NOT DONATE BLOOD TO PATIENT")
        End If
        ds.Tables.Clear()
        da.Fill(ds, "patient")
        '  DataGridView1.DataSource = ds.Tables("purchase")
    End Sub

    Private Sub TextBox11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox11.KeyPress
        If Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("YOU CAN ONLY INPUT NUMBERS")
        End If
    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        If Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("YOU CAN ONLY INPUT NUMBERS")
        End If
    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("YOU CAN ONLY INPUT NUMBERS")
        End If
    End Sub

    Private Sub TextBox12_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox12.KeyPress
        If Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("YOU CAN ONLY INPUT NUMBERS")
        End If
    End Sub

   
   
   
End Class