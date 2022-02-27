Imports System.Drawing.Printing
Public Class Form3

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Label5.Text = My.Forms.sales.group
        Label8.Text = My.Forms.sales.price
        Label9.Text = My.Forms.sales.nm
        Label11.Text = My.Forms.sales.hn
        Label12.Text = My.Forms.sales.no
        Label17.Text = My.Forms.sales.tot
        Label24.Text = My.Forms.sales.tot

    End Sub



    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label13.Text = DateAndTime.Now.ToLongDateString()
        Label15.Text = DateAndTime.Now.ToLongTimeString()

    End Sub

    Private Sub Panel13_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel13.Paint

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Panel10_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel10.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim printdoc As New PrintDocument()
        printdoc.DocumentName = "Print Document"
        PrintDialog1.Document = printdoc
        If (PrintDialog1.ShowDialog() = DialogResult.OK) Then

        End If
        printdoc.Print()
    End Sub
End Class