Public Class AgregarArticulo

    Private Sub AgregarArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (btnDinamico.Text = "") Then
            btnDinamico.Text = Bolpa.Inventario.tipo

        End If
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Dim txt As Object = Text
        txt = Mid(txtCantidad.ToString, Len(txtCantidad.ToString))
        If (Not IsNumeric(txt)) Then
            txtCantidad.Text = ""
        End If
    End Sub
End Class