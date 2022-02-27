Public Class BuscarEntidad
    Dim con As New Conectar
    Private registros As DataTable = New DataTable()
    Private _condicionante As Integer
    Public Property Condicionante As Integer
        Get
            Return _condicionante
        End Get
        Set(ByVal value As Integer)
            _condicionante = value
        End Set
    End Property
    Private Sub Selector()
        Dim sql As String = ""
        Select Case Condicionante
            Case 0  'Cliente
                sql = "Select * from TbCliente"
                MostraGridCliente(sql)
            Case 1  'Empleado
                sql = "Select * from TbEmpleado"
                MostraGridCliente(sql)
            Case Else  'Proveedor
                sql = "Select * from TbProveedor"
                MostraGridCliente(sql)
        End Select
    End Sub
    Private Sub Filtrar_Datos()
        'If String.IsNullOrEmpty(txtbuscar.Text) Then
        '    registros.DefaultView.RowFilter = ""
        'Else
        '    registros.DefaultView.RowFilter = "Nombre" + " like '" + txtbuscar.Text + "%'"
        'End If
    End Sub
    Private Sub BuscarCliente_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'Selector()
        'Filtrar_Datos()
    End Sub
    Private Sub MostraGridCliente(sql)
        Try
            registros = Nothing
            registros = con.Obtener_Registros(sql)
            dgv1.DataSource = registros
        Catch ex As Exception
            MsgBox("Revisar MostrarGrid")
        End Try
    End Sub

    Private Sub Txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Dim txt As Object = txtbuscar.ToString
        txt = Mid(txtbuscar.ToString, Len(txtbuscar.ToString))

        If (IsNumeric(txt)) Then
            Filtrar_Datos()
            dgv1.DataSource = registros.DefaultView
        Else
            txtbuscar.Text = ""
        End If

    End Sub


    'Private Sub BuscarCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
    '    If Convert.ToInt16(e.KeyValue) = Convert.ToInt16(Keys.Escape) Then
    '        '  PCedula_Cliente = ""
    '        Me.Close()
    '    End If
    'End Sub
    'Private Sub Datos_DoubleClick_1(sender As Object, e As EventArgs) Handles Datos.DoubleClick
    '    Dim Fila_Seleccionada As Integer = 0

    '    If dgv1.Rows.Count > 0 Then
    '        Fila_Seleccionada = dgv1.CurrentRow.Index
    '        'PCedula_Cliente = ""
    '        'PCedula_Cliente = Convert.ToString(Datos(0, Fila_Seleccionada).Value)
    '        'Me.Close()
    '    End If
    'End Sub
End Class
