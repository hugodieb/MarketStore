Imports System.Data.SqlClient
Imports System.Configuration

Module bdSQL
    Public stringConnection As String
    Public Function getConnection() As SqlConnection
        stringConnection = ConfigurationManager.AppSettings("ConnectionBD")
        Return New SqlConnection(stringConnection)
    End Function

End Module
