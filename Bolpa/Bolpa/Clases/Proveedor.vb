Public Class Proveedor
    Inherits Identificacion
    Private _tipoIdentificacion As String
    Private _fechRelacion As String
    Private _provincia As String
    Private _canton As String
    Private _representante As String
    Public Property TipoIdenti As String
        Get
            Return _tipoIdentificacion
        End Get
        Set(ByVal value As String)
            _tipoIdentificacion = value
        End Set
    End Property

    Public Property Provincia As String
        Get
            Return _provincia
        End Get
        Set(ByVal value As String)
            _provincia = value
        End Set
    End Property

    Public Property FechRelacion As String
        Get
            Return _fechRelacion
        End Get
        Set(ByVal value As String)
            _fechRelacion = value
        End Set
    End Property

    Public Property Canton As String
        Get
            Return _canton
        End Get
        Set(ByVal value As String)
            _canton = value
        End Set
    End Property
    Public Property Representante As String
        Get
            Return _representante
        End Get
        Set(ByVal value As String)
            _representante = value
        End Set
    End Property
End Class
