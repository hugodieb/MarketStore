Imports System.Data.SqlClient

Module mdAcessoBD
    Public status As Boolean
    Dim sql As String

    Public Function getConnection() As SqlConnection

        sql = "Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\projetos_vb\myStore\Sistema de loja\Sistema de loja\myStore.mdf;Integrated Security=True"

        Return New SqlConnection(sql)
    End Function

End Module
