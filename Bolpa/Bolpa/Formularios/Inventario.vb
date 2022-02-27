Public Class Inventario

    Public Shared tipo As String = ""

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tipo = Button3.Text
        obtenerFormulario(New AgregarArticulo())
    End Sub
    Private Sub obtenerFormulario(frm As Form)
        If (Principal.Panel.Controls.Count > 0) Then
            Principal.Panel.Controls.RemoveAt(0)
            frm.TopLevel = False
            frm.Dock = DockStyle.Fill
            Principal.Panel.Controls.Add(frm)
            Principal.Panel.Tag = frm
            frm.Show()
        Else
            frm.TopLevel = False
            frm.Dock = DockStyle.Fill
            Principal.Panel.Controls.Add(frm)
            Principal.Panel.Tag = frm
            frm.Show()
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click, btnActualizar.TextChanged
        tipo = btnActualizar.Text
        obtenerFormulario(New AgregarArticulo())
    End Sub


End Class