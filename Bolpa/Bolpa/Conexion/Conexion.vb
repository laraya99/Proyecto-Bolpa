Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Conectar
    Private atrBase As SqlConnection = New SqlConnection()
    Private atrSql As SqlCommand = New SqlCommand()
    Private atrSincronizador As SqlDataAdapter = New SqlDataAdapter()
    Private atrRegistros As DataTable = New DataTable()

    Private Sub conectar_bd()
        atrBase.Close()
        atrBase.ConnectionString = "Data Source=DESKTOP-SMBDLLD\SQLEXPRESS;Initial Catalog=BdBolpa;Integrated Security=True"
        atrBase.Open()
    End Sub

    Private Sub desconectar_bd()
        atrBase.Close()
    End Sub

    'este metodo recibe por parametro una sentencia sql (insert, update, delete) y la ejecuta en la BD 
    Public Sub ejecutar_sql(ByVal sql As String)
        conectar_bd() 'abre conexion
        atrSql.Connection = atrBase
        atrSql.CommandText = sql ' resibe la sentencia
        atrSql.ExecuteNonQuery()   'la ejecuta
        desconectar_bd()   'cierra la conexion
    End Sub

    'este metodo recibe por parametro una sentencia sql (select) y la ejecuta en la BD y devuelve los resgistros 
    Public Function Obtener_Registros(ByVal sql As String) As DataTable
        ejecutar_sql(sql)   'envia y ejecuta la sentencia Select
        atrSincronizador.SelectCommand = atrSql
        atrRegistros.Clear() 'limpia el datatable de los datos antiguos
        atrRegistros.Reset() ' resetea los campos del datatable
        atrSincronizador.Fill(atrRegistros) 'llena el datable con el resultado de la consulta Select (campos y registros)
        Return atrRegistros    ' retorna el datatable con los registros de la sentencia Select
    End Function
End Class


