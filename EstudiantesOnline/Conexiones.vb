Imports System.Web
Imports System.Data.SqlClient
Public Class Conexiones
    Public Shared Cnn As SqlClient.SqlConnection
    Public Shared Validar As String = "0"

    Public Shared Sub AbrirConexion()
        Cnn = New SqlConnection("Server=localhost\SQLEXPRESS;Database=escuela;User Id=julio;Password=ciencia123;")

    End Sub


End Class
