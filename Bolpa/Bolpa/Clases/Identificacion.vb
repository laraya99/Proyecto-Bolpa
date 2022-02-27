Public Class Identificacion
    Private _cedula As String
    Private _nombre As String
    Private _apellido1 As String
    Private _apellido2 As String
    Private _telefono As String
    Private _correo As String
    Private _direccion As String

    Public Property Cedula As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property Apellido1 As String
        Get
            Return _apellido1
        End Get
        Set(value As String)
            _apellido1 = value
        End Set
    End Property
    Public Property Apellido2 As String
        Get
            Return _apellido2
        End Get
        Set(value As String)
            _apellido2 = value
        End Set
    End Property
    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property
    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

End Class