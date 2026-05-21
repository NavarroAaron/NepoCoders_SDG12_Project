Imports System.Data.SqlClient

Public Class ManagerDB

    Private Shared connectionString As String =
        "Server=localhost\SQLEXPRESS;Database=NepoCodersDB;Trusted_Connection=True;"

    Public Shared Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

End Class