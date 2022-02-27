Public Class donateblood
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
    Public amt, dn, dt, group As String
    Private Sub DonarBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DonarBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.ProjectDataSet)

    End Sub

    Private Sub donateblood_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.donar' table. You can move, or remove it, as needed.
        Me.DonarTableAdapter1.Fill(Me.ProjectDataSet.donar)
        'TODO: This line of code loads data into the 'ProjectDataSet1.donar' table. You can move, or remove it, as needed.
        ' Me.DonarTableAdapter.Fill(Me.ProjectDataSet1.donar)
        dbprovider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbsource = "Data Source=C:\Users\LENOVO\Desktop\PROJECT.NET\project.mdb"
        con.ConnectionString = dbprovider & dbsource
        con.Open()
        query = "select * from donate"
        da = New OleDb.OleDbDataAdapter(query, con)
        da.Fill(ds, "donate")
        'DataGridView1.DataSource = ds.Tables("donate")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As Integer
        query = "insert into donate values('" & TextBox1.Text & "','" & ComboBox1.Text & "'," & CInt(TextBox2.Text) & ",'" & DateTimePicker1.Text & "')"
        CMD = New OleDb.OleDbCommand(query, con)
        x = CMD.ExecuteNonQuery()
        If (x) Then
            MsgBox("BLOOD DONATED")
        Else
            MsgBox("CANNOT DONATE BLOOD")
        End If
        ds.Tables.Clear()
        da.Fill(ds, "donate")
        ' DataGridView1.DataSource = ds.Tables("donate")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        insertdonar.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        group = ComboBox1.Text
        amt = TextBox2.Text
        dt = DateTimePicker1.Text
        dn = TextBox1.Text
        Form1.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RadioButton1.Checked Then
            DonarDataGridView.DataSource = Me.ProjectDataSet.donar.Select("donarname like'" & TextBox3.Text & "'")
            'MsgBox("DATA FOUND")

        End If
        If RadioButton2.Checked Then
            DonarDataGridView.DataSource = Me.ProjectDataSet.donar.Select("bloodgroup like'" & TextBox3.Text & "'")
            ' MsgBox("DATA FOUND")

        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) < 48 And Asc(e.KeyChar) <> 8 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("YOU CAN ONLY INPUT NUMBERS")
        End If
    End Sub

   
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class