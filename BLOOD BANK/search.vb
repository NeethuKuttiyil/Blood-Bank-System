Public Class search

    Private Sub DonarBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DonarBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.ProjectDataSet)

    End Sub

    Private Sub search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.donar' table. You can move, or remove it, as needed.
        Me.DonarTableAdapter1.Fill(Me.ProjectDataSet.donar)
        'TODO: This line of code loads data into the 'ProjectDataSet1.donar' table. You can move, or remove it, as needed.
        '  Me.DonarTableAdapter.Fill(Me.ProjectDataSet1.donar)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            DonarDataGridView.DataSource = Me.ProjectDataSet.donar.Select("donarid =" & TextBox1.Text & "")
            MsgBox("DATA FOUND")

        End If
        If RadioButton2.Checked Then
            DonarDataGridView.DataSource = Me.ProjectDataSet.donar.Select("donarname like'" & TextBox1.Text & "'")
            MsgBox("DATA FOUND")

        End If
        If RadioButton3.Checked Then
            DonarDataGridView.DataSource = Me.ProjectDataSet.donar.Select("bloodgroup like'" & TextBox1.Text & "'")
            MsgBox("DATA FOUND")
        End If
    End Sub
End Class