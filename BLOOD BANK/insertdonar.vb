Imports Microsoft.VisualBasic
Public Class insertdonar
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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Val(TextBox3.Text) < 18 Then
            MsgBox("DONORS AGE Should be GREATER Than 18Years...!!")
        End If
        Dim x As Integer
        'Dim d As String
        'Dim gender As String
        'If RadioButton1.Checked = True Then
        'gender = True
        'ElseIf RadioButton2.Checked = True Then
        'gender = True
        'End If
        'If RadioButton3.Checked = True Then
        'd = True
        'ElseIf RadioButton4.Text = True Then
        'd = True
        'End If
        ' query = "insert into donar values(" & CInt(TextBox1.Text) & ",'" & TextBox2.Text & "','" & TextBox3.Text & "',)"
        query = "insert into donar values(" & CInt(TextBox1.Text) & ",'" & TextBox2.Text & "'," & CInt(TextBox3.Text) & ",'" & DateTimePicker1.Text & "','" & ComboBox2.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "'," & CInt(TextBox6.Text) & ",'" & ComboBox3.Text & "','" & TextBox7.Text & "')"
        CMD = New OleDb.OleDbCommand(query, con)
        x = CMD.ExecuteNonQuery()
        If (x) Then
            MsgBox("NEW DONAR REGISTERED")
        Else
            MsgBox("CANNOT REGISTER DONAR DETAILS")
        End If
        ds.Tables.Clear()
        da.Fill(ds, "donar")
        ' DataGridView1.DataSource = ds.Tables("donar")

    End Sub

    Private Sub insertdonar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbprovider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbsource = "Data Source=C:\Users\LENOVO\Desktop\PROJECT.NET\project.mdb"
        con.ConnectionString = dbprovider & dbsource
        con.Open()
        query = "select * from donar"
        da = New OleDb.OleDbDataAdapter(query, con)
        da.Fill(ds, "donar")
        ' DataGridView1.DataSource = ds.Tables("donar")
    End Sub




    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
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


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim today, dob As Integer
        today = Date.Today.Year
        dob = DateTimePicker1.Value.Year
        TextBox3.Text = today - dob
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("YOU CAN ONLY INPUT NUMBERS")
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("YOU CAN ONLY INPUT NUMBERS")
        End If
    End Sub

  
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        

    End Sub
End Class