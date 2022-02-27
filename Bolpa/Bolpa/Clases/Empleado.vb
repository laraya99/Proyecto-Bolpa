Public Class Empleado
    Inherits Identificacion
    Dim con As New Conectar
    Dim registro As New DataTable
    Private _nombreUsuario As String
    Private _contraseña As String
    Private _puesto As String
    Private _salario As Decimal
    Private _fechNacimiento As String

    Public Property FechNacimiento As String
        Get
            Return _fechNacimiento
        End Get
        Set(ByVal value As String)
            _fechNacimiento = value
        End Set
    End Property
    Public Property NombreUsuario As String
        Get
            Return _nombreUsuario
        End Get
        Set(value As String)
            _nombreUsuario = value
        End Set
    End Property
    Public Property Contraseña As String
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value
        End Set
    End Property
    Public Property Puesto As String
        Get
            Return _puesto
        End Get
        Set(value As String)
            _puesto = value
        End Set
    End Property
    Public Property Salario As String
        Get
            Return _salario
        End Get
        Set(value As String)
            _salario = value
        End Set
    End Property

    Sub agregarEmpleado()
        con.ejecutar_sql("Insert into TbEmpleado values ('" & Cedula & "','" & Nombre & "','" & Apellido1 & "',
        '" & Apellido2 & "','" & FechNacimiento & "','" & Direccion & "','" & Correo & "', '" & Telefono & "'
        ,'" & NombreUsuario & "','" & Contraseña & "','" & Puesto & "')")
    End Sub

    Sub eliminarEmpleado(ByVal cedula As String)
        con.ejecutar_sql("delete From TbEmpleado where Cedula = '" & cedula & "'")
    End Sub

    Sub actualizarEmpleado(ByVal cedula As String)
        con.ejecutar_sql("update TbEmpleado set Cedula = '" & cedula & "', Nombre='" & Nombre & "'
            ,Apellido1='" & Apellido1 & "',Apellido2='" & Apellido2 & "' ,FechNacimiento = '" & FechNacimiento & "',
            Direccion = '" & Direccion & "',Correo = '" & Correo & "'
            Telefono = '" & Telefono & "',NomUsuario = '" & NombreUsuario & "',Contraseña = '" & Contraseña & "',
            Puesto = '" & Puesto & "' where Cedula = '" & cedula & "'")
    End Sub

    Public Function buscarEmpleado(ByVal cedula As String) As DataTable
        Return con.Obtener_Registros("Select * from TbEmpleado where Cedula ='" + cedula + "'")
    End Function
    'Function Todos()
    '    registro = con.Obtener_Registros("Select * from TbEmpleado")
    '    Return registro
    'End Function


End Class
