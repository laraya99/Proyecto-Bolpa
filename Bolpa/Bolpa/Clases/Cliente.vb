Public Class Cliente
    Inherits Identificacion
    Dim con As New Conectar
    Dim registro As New DataTable
    Private _tipoIdentificacion As String
    Private _fechNacimiento As String
    Public Property TipoIdenti As String
        Get
            Return _tipoIdentificacion
        End Get
        Set(ByVal value As String)
            _tipoIdentificacion = value
        End Set
    End Property

    Public Property FechNacimiento As String
        Get
            Return _fechNacimiento
        End Get
        Set(ByVal value As String)
            _fechNacimiento = value
        End Set
    End Property
    Sub agregarCliente()
        con.ejecutar_sql("Insert into TbCliente values ('" & Cedula & "','" & Nombre & "','" & Apellido1 & "',
        '" & Apellido2 & "','" & FechNacimiento & "','" & Direccion & "','" & Correo & "', '" & Telefono & "'
        ,'" & TipoIdenti & "')")
    End Sub

    Sub eliminarCliente()
        con.ejecutar_sql("delete From TbCliente where Cedula =" + Cedula + "")
    End Sub

    Sub actualizarCliente()
        con.ejecutar_sql("update TbCliente set Nombre='" + Nombre + "'
        ,Apellido1='" + Apellido1 + "',Apellido2='" + Apellido2 + "' where Cedula = '" + Cedula + "'")
    End Sub

    Public Function buscarCliente(ByVal cedula As String) As DataTable
        Return con.Obtener_Registros("Select * from TbCliente where Cedula ='" + cedula + "'")
    End Function
    Function Todos()
        registro = con.Obtener_Registros("Select * from TbCliente")
        Return registro
    End Function
End Class

