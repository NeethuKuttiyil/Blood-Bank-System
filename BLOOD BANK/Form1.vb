Imports System.Drawing.Printing
Public Class Form1

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Label6.Text = My.Forms.donateblood.dn
        Label7.Text = My.Forms.donateblood.group
        Label8.Text = My.Forms.donateblood.amt
        Label6.Text = My.Forms.donateblood.dt
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim printdoc As New PrintDocument()
        printdoc.DocumentName = "Print Document"
        PrintDialog1.Document = printdoc
        If (PrintDialog1.ShowDialog() = DialogResult.OK) Then

        End If
        printdoc.Print()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = DateAndTime.Now.ToLongDateString()
        Label5.Text = DateAndTime.Now.ToLongTimeString()



    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub
End Class