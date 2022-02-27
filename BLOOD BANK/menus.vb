Public Class menus

    Private Sub REGISTERNEWDONARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTERNEWDONARToolStripMenuItem.Click
        insertdonar.Show()
    End Sub

    Private Sub SEARCHDONARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHDONARToolStripMenuItem.Click
        search.Show()
    End Sub

    Private Sub EDITDETAILSToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITDETAILSToolStripMenuItem.Click
        editdonar.Show()
    End Sub
   
      Private Sub VIEWBLOODDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWBLOODDETAILSToolStripMenuItem.Click
        bloodedit.Show()
    End Sub

  
    Private Sub BLOODBANKDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLOODBANKDETAILSToolStripMenuItem.Click
        donateblood.Show()
    End Sub

    Private Sub NEWBLOODToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEWBLOODToolStripMenuItem.Click
        bloodsearch.Show()
    End Sub

    Private Sub ADDNEWBLOODToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' bloodedit.Show()
    End Sub

    Private Sub BLOODBANKDETAILSToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLOODBANKDETAILSToolStripMenuItem1.Click
        purchase.Show()
    End Sub

    Private Sub REPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTToolStripMenuItem.Click
        sales.Show()
    End Sub

   
    Private Sub DONARREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DONARREPORTToolStripMenuItem.Click
        reportdonar.Show()
    End Sub

    Private Sub BLOODREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLOODREPORTToolStripMenuItem.Click
        reportblood.Show()
    End Sub

    Private Sub SALESREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALESREPORTToolStripMenuItem.Click
        reportsales.Show()
    End Sub

    Private Sub menus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class