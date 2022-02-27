Public Class Principal

    Private Sub obtenerFormulario(frm As Form)
        If (Panel.Controls.Count > 0) Then
            Panel.Controls.RemoveAt(0)
            frm.TopLevel = False
            frm.Dock = DockStyle.Fill
            Panel.Controls.Add(frm)
            Panel.Tag = frm
            frm.Show()
        Else
            frm.TopLevel = False
            frm.Dock = DockStyle.Fill
            Panel.Controls.Add(frm)
            Panel.Tag = frm
            frm.Show()
        End If
    End Sub
    Dim BusEnt As New BuscarEntidad
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        BusEnt.Condicionante = 0
        obtenerFormulario(New BuscarEntidad())  'Cliente
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        BusEnt.Condicionante = 1
        obtenerFormulario(New BuscarEntidad())  'Empleado
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        BusEnt.Condicionante = 2
        obtenerFormulario(New BuscarEntidad())  'Proveedor
    End Sub

    Private Sub CobroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CobroToolStripMenuItem.Click

        obtenerFormulario(New Facturacion())
    End Sub

    Private Sub GenerarFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarFacturaToolStripMenuItem.Click

        obtenerFormulario(New Facturacion())
    End Sub

    Private Sub DeudasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeudasToolStripMenuItem.Click

        obtenerFormulario(New Facturacion())
    End Sub

    Private Sub TsmiInventario_Click(sender As Object, e As EventArgs) Handles tsmiInventario.Click

        obtenerFormulario(New Inventario())
    End Sub

    Private Sub TsmiReportes_Click(sender As Object, e As EventArgs) Handles tsmiReportes.Click
        obtenerFormulario(New Reportes())
    End Sub
End Class