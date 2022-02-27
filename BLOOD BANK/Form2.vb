Imports System.Drawing.Printing
Public Class Form2

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

        Label5.Text = My.Forms.purchase.group
        Label8.Text = My.Forms.purchase.price
        Label9.Text = My.Forms.purchase.nm
        Label11.Text = My.Forms.purchase.bt
        Label12.Text = My.Forms.purchase.tot
        ' Label13.Text = My.Forms.purchase.dat
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label13.Text = DateAndTime.Now.ToLongDateString()
        Label15.Text = DateAndTime.Now.ToLongTimeString()

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