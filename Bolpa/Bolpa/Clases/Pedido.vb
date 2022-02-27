Public Class Pedidos
    Private _idpedido As Integer
    Private _cantidad As Integer
    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property IdPedido As Integer
        Get
            Return _idpedido
        End Get
        Set(ByVal value As Integer)
            _idpedido = value
        End Set
    End Property
End Class
