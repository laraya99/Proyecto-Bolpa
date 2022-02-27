Public Class AgregarCliente
    Dim cli As New Cliente
    Dim Contenedora As New DataTable
    Private Sub AgregaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaTipo()
        Botones()
    End Sub

    Sub Botones()
        'If cmbCurso.Enabled = True Then
        '        txtnombre.Enabled = True
        '       txtApellido.Enabled = True
        '       txtcurso.Enabled = True
        '       txtempresa.Enabled = True
        '       cmbCurso.Enabled = False
        '      btnAgregar.Enabled = True
        '      btnActualizar.Enabled = True
        '     btnEliminar.Enabled = True
        'End If

    End Sub
    Public Sub CargarAtribProf()
        Dim n As System.DateTime
        n = Convert.ToDateTime(maskedFechaNacimiento.Text)
        cli.FechNacimiento = n.ToString("yyyy/MM/dd")
        cli.Nombre = txtNombre.Text
        cli.Apellido1 = txtApellido1.Text
        cli.Apellido2 = txtApellido2.Text
        cli.Telefono = txtTelefono.Text
        cli.Correo = txtCorreo.Text
        cli.Direccion = txtDireccion.Text
        cli.Cedula = txtCedula.Text
        cli.TipoIdenti = cbTipoCliente.SelectedIndex
        'cli.FechNacimiento = CDate(MaskedTextBox1.Text)

    End Sub
    Sub cargaTipo()
        With cbTipoCliente.Items
            .Add("Fisico")
            .Add("Juridico")
        End With
    End Sub
    Public Sub limpiar()
        txtNombre.Text = ""
        txtApellido1.Text = ""
        txtApellido2.Text = ""
        cbTipoCliente.SelectedItem = -1
        txtTelefono.Text = ""
        txtCorreo.Text = ""
        txtDireccion.Text = ""
        txtCedula.Text = ""
        maskedFechaNacimiento.ResetText()
    End Sub
    Public Function Validar() As String
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
        ElseIf txtCedula.Text = "" Then
            Return "Ingrese el numero de cedula"
        ElseIf maskedFechaNacimiento.Text = "" Then
            Return "Ingrese la fecha de nacimiento"
        ElseIf cbTipoCliente.SelectedItem = "" Then
            Return "No has seleccionado un tipo de cliete"
        End If
        Return ""
    End Function

    'Private Sub BtnInsertar_Click_1(sender As Object, e As EventArgs) Handles btnInsertar.Click
    '    Validar()
    '    If Validar() = "" Then
    '        CargarAtribProf()
    '        cli.agregarCliente()
    '        dgv1.DataSource = cli.Todos()
    '        limpiar()
    '        MsgBox("Agregado")
    '    Else
    '        MessageBox.Show("Datos Incompletos" + Validar(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles maskedFechaNacimiento.MaskInputRejected
        MessageBox.Show("Datos mal Ingresados, Orden(aaaa/mm/dd)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class