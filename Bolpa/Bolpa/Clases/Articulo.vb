Public Class Articulo

    Dim con As New Conectar
    Private _idArticulo As Integer
    Private _descripcion As String
    Private _nomArt As String
    Private _precio As Decimal
    Private _stockInventario As Integer
    Private _iva As Decimal
    Private _fechCaducidad As String
    Private _imagen As Image

    Public Property FechaCaducidad As String
        Get
            Return _fechCaducidad
        End Get
        Set(ByVal value As String)
            _fechCaducidad = value
        End Set
    End Property

    Public Property Iva As Decimal
        Get
            Return _iva
        End Get
        Set(ByVal value As Decimal)
            _iva = value
        End Set
    End Property

    Public Property StockInventario As Integer
        Get
            Return _stockInventario
        End Get
        Set(ByVal value As Integer)
            _stockInventario = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(ByVal value As Decimal)
            _precio = value
        End Set
    End Property

    Public Property NombreArticulo As String
        Get
            Return _nomArt
        End Get
        Set(ByVal value As String)
            _nomArt = value
        End Set
    End Property

    Public Property DescripcionArt As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property IdArticulo As Integer
        Get
            Return _idArticulo
        End Get
        Set(ByVal value As Integer)
            _idArticulo = value
        End Set
    End Property

    Public Function ImagenAByte(ByVal imagen As Image) As Byte()
        Dim ms As New IO.MemoryStream
        imagen.Save(ms, imagen.RawFormat)
        ImagenAByte = ms.GetBuffer
    End Function

    Public Function ByteAImagen(ByVal b As Byte()) As Image
        Dim ms As New IO.MemoryStream(b)
        _imagen = Image.FromStream(ms)
        ByteAImagen = _imagen
    End Function

    Sub agregar()
        agregarArticulo()
        agregarInventario()
        agregarFamilia()
        agregarSubFamilia()
    End Sub

    Sub eliminar()
        eliminarArticulo()
        eliminarInventario()
    End Sub

    Sub actualizar()

    End Sub

    Sub agregarArticulo()
        con.ejecutar_sql("Insert into TbArticulo values ('" & IdArticulo & "','" & DescripcionArt & "','" & Precio & "',
        '" & ImagenAByte(_imagen).ToString & "','" & FechaCaducidad & "','" & Iva & "')")
    End Sub

    Sub eliminarArticulo()
        con.ejecutar_sql("delete From TbArticulo where CodigoArticulo =" & IdArticulo & "")
    End Sub

    'Sub actualizarArticulo()
    '   con.ejecutar_sql("update TbCliente set Nombre='" + Nombre + "'
    '    ,Apellido1='" + Apellido1 + "',Apellido2='" + Apellido2 + "' where Cedula = '" + Cedula + "'")
    'End Sub

    Public Function buscarArticulo(ByVal cedula As String) As DataTable
        Return con.Obtener_Registros("Select * from TbArticulo where CodigoArticulo ='" & IdArticulo & "'")
    End Function

    Sub agregarInventario()
        con.ejecutar_sql("Insert into TbInventario values ('" & IdArticulo & "','" & Precio & "',
        '" & StockInventario & "')")
    End Sub

    Sub eliminarInventario()
        con.ejecutar_sql("delete From TbInventario where CodigoArticulo =" & IdArticulo & "")
    End Sub

    'Sub actualizarInventario()
    '   con.ejecutar_sql("update TbInventario set Nombre='" + Nombre + "'
    '    ,Apellido1='" + Apellido1 + "',Apellido2='" + Apellido2 + "' where Cedula = '" + Cedula + "'")
    'End Sub

    Public Function buscarInventario(ByVal cedula As String) As DataTable
        Return con.Obtener_Registros("Select * from TbInventario where CodigoArticulo ='" & IdArticulo & "'")
    End Function

    Sub agregarFamilia()
        con.ejecutar_sql("Insert into TbFamilia values ('" & NombreArticulo & "')")
    End Sub

    Sub agregarSubFamilia()
        con.ejecutar_sql("Insert into TbSubFamilia values ('" & NombreArticulo & "')")
    End Sub

End Class
