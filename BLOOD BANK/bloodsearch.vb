Public Class bloodsearch

    Private Sub PurchaseDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PurchaseDataGridView.DataSource = Me.ProjectDataSet.purchase.Select("group ='" & ComboBox1.Text & "'")
    End Sub

    Private Sub PurchaseBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PurchaseBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.ProjectDataSet)

    End Sub

    Private Sub bloodsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.purchase' table. You can move, or remove it, as needed.
        Me.PurchaseTableAdapter1.Fill(Me.ProjectDataSet.purchase)
        'TODO: This line of code loads data into the 'ProjectDataSet1.purchase' table. You can move, or remove it, as needed.
        '  Me.PurchaseTableAdapter.Fill(Me.ProjectDataSet1.purchase)

    End Sub

   

    Private Sub PurchaseDataGridView_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PurchaseDataGridView.CellClick
        GroupBox1.Show()
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = PurchaseDataGridView.Rows(index)
        TextBox1.Text = selectedrow.Cells(0).Value.ToString()
        TextBox2.Text = selectedrow.Cells(1).Value.ToString()
        TextBox3.Text = selectedrow.Cells(2).Value.ToString()
        TextBox4.Text = selectedrow.Cells(3).Value.ToString()
        TextBox5.Text = selectedrow.Cells(4).Value.ToString()
    End Sub

    Private Sub PurchaseDataGridView_CellContentClick_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PurchaseDataGridView.CellContentClick

    End Sub
End Class