Public Class RegistroEmpleado
    Dim emp As New Empleado
    Dim registros As New DataTable
    Dim con As New Conectar

    'Private Sub DgvEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick
    '    Dim n As System.DateTime
    '    txtcedula.Text = dgvEmpleados.Rows(dgvEmpleados.CurrentRow.Index).Cells(1).Value
    '    txtnombre.Text = dgvEmpleados.Rows(dgvEmpleados.CurrentRow.Index).Cells(2).Value
    '    txtapellido1.Text = dgvEmpleados.Rows(dgvEmpleados.CurrentRow.Index).Cells(3).Value
    '    txtapellido2.Text = dgvEmpleados.Rows(dgvEmpleados.CurrentRow.Index).Cells(4).Value
    '    n = Convert.ToString(dgvEmpleados.Rows(dgvEmpleados.CurrentRow.Index).Cells(5).Value)
    '    mskfecha.Text = n.ToString("dd/MM/yyyy")
    '    txtdireccion.Text = dgvEmpleados.Rows(dgvEmpleados.CurrentRow.Index).Cells(6).Value
    '    txtcorreo.Text = dgvEmpleados.Rows(dgvEmpleados.CurrentRow.Index).Cells(7).Value
    '    txttelefono.Text = dgvEmpleados.Rows(dgvEmpleados.CurrentRow.Index).Cells(8).Value
    '    txtusuario.Text = dgvEmpleados.Rows(dgvEmpleados.CurrentRow.Index).Cells(9).Value
    '    txtcontraseña.Text = dgvEmpleados.Rows(dgvEmpleados.CurrentRow.Index).Cells(10).Value
    '    cmbPuesto.SelectedIndex = dgvEmpleados.Rows(dgvEmpleados.CurrentRow.Index).Cells(11).Value
    'End Sub
    'Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
    '    Validar()
    '    If Validar() = "" And CheckPass() = "" Then
    '        CargarAtribEmple()
    '        registros = emp.buscarEmpleado(emp.Cedula)
    '        If registros.Rows.Count > 0 Then
    '            emp.actualizarEmpleado(emp.Cedula)
    '            registros = Nothing
    '        Else
    '            emp.agregarEmpleado()
    '        End If
    '        MostraGrid()
    '        limpiar()
    '        MsgBox("Agregado")
    '    Else
    '        MessageBox.Show("Datos Incompletos" + Validar() + CheckPass(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub
    Sub cargaTipo()
        With cbPuesto.Items
            .Add("Administracion")
            .Add("Bodegas")
            .Add("Cajas")
        End With
    End Sub
    Private Sub limpiar()
        txtNombre.Text = ""
        txtApellido1.Text = ""
        txtApellido2.Text = ""
        txtTelefono.Text = ""
        txtCorreo.Text = ""
        txtDireccion.Text = ""
        txtCedula.Text = ""
        maskedFechaNacimiento.ResetText()
        txtUsuario.Text = ""
        txtContraseña.Text = ""
        txtConfirmarContra.Text = ""
        cbPuesto.SelectedIndex = -1
    End Sub
    Private Function Validar() As String
        If txtNombre.Text = "" Then
            Return "Ingrese el Nombre "
        ElseIf txtApellido1.Text = "" Or txtApellido2.Text = "" Then
            Return "Ingrese el apellidos"
        ElseIf (Not IsNumeric(txtCedula.Text)) Then
            Return "Ingres un Valor Numerico..."
        ElseIf txtTelefono.Text = "" Then
            Return "No a ingresado un numero telefonico"
        ElseIf txtCorreo.Text = "" Then
            Return "No a ingresado un correo"
        ElseIf txtDireccion.Text = "" Then
            Return "Ingrese una direccion "
        ElseIf maskedFechaNacimiento.Text = "" Then
            Return "Ingrese la fecha de nacimiento"
        ElseIf txtUsuario.Text = "" Then
            Return "Usuario Invalido"
        ElseIf txtConfirmarContra.Text = "" Or txtContraseña.Text = "" Then
            Return "Usuario Invalido"
        End If
        Return ""
    End Function
    Private Function CheckPass()
        If txtContraseña.Text <> txtConfirmarContra.Text Then
            Return "Las contraseñas no coinciden"
        End If
        Return ""
    End Function
    Private Sub CargarAtribEmple()
        Dim n As System.DateTime
        n = Convert.ToDateTime(maskedFechaNacimiento.Text)
        emp.FechNacimiento = n.ToString("yyyy/MM/dd")
        emp.Nombre = txtNombre.Text
        emp.Apellido1 = txtApellido1.Text
        emp.Apellido2 = txtApellido2.Text
        emp.Telefono = txtTelefono.Text
        emp.Correo = txtCorreo.Text
        emp.Direccion = txtDireccion.Text
        emp.Cedula = txtCedula.Text
        emp.NombreUsuario = txtUsuario.Text
        emp.Contraseña = txtContraseña.Text
    End Sub
    Private Sub Mskfecha_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)
        MessageBox.Show("Datos mal Ingresados, Orden(aaaa/mm/dd)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    'Private Sub RegistroEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    cargaTipo()
    '    dgvEmpleados.DataSource = emp.Todos()
    'End Sub
    'Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
    '    Try
    '        MessageBox.Show("Realmente quiere eliminar este Empleado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    '        If DialogResult.Yes Then
    '            emp.eliminarEmpleado(txtcedula.Text)
    '            MessageBox.Show("Empleado Eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            MostraGrid()
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Revisar datos de conexion")
    '    End Try
    'End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub RegistroEmpleado_Load(sender As Object, e As EventArgs)

    End Sub

    'Private ram As DataTable = New DataTable()

    'Private Sub MostraGrid()
    '    Try
    '        Dim sql As String
    '        'Dim i As Integer
    '        sql = "Select * from TbEmpleado"
    '        'dgvEmpleados.Rows.Clear()
    '        registros = Nothing
    '        registros = con.Obtener_Registros(sql)
    '        dgvEmpleados.DataSource = registros
    '        'For i = 0 To registros.Rows.Count
    '        '    dgvEmpleados.Rows.Add(CStr(registros.Rows(i).ItemArray(0)), registros.Rows(i).ItemArray(1), registros.Rows(i).ItemArray(2),
    '        '    registros.Rows(i).ItemArray(3), registros.Rows(i).ItemArray(4), registros.Rows(i).ItemArray(5), registros.Rows(i).ItemArray(6),
    '        '    registros.Rows(i).ItemArray(7), registros.Rows(i).ItemArray(8), registros.Rows(i).ItemArray(9), registros.Rows(i).ItemArray(10),
    '        '    registros.Rows(i).ItemArray(11), CStr(registros.Rows(i).ItemArray(12)))
    '        'Next
    '        limpiar()
    '    Catch ex As Exception
    '        MsgBox("Revisar MostrarGrid")
    '    End Try
    'End Sub


End Class