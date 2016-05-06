Imports System.Data.SqlClient
Imports Sistema_de_loja.User

Public Class userDAO

    Public Sub login(ByVal user As User)
        Dim sql As String = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim dr As SqlDataReader = Nothing

        Using con As SqlConnection = getConnection()
            Try
                con.Open()

                sql = "select * from person where ((name=@name) and (password=@password))"
                cmd = New SqlCommand(sql, con)

                cmd.Parameters.Add(New SqlParameter("@name", user.nameUser))
                cmd.Parameters.Add(New SqlParameter("@password", user.passwordUser))
                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    MsgBox("Estou conectado", MsgBoxStyle.Information)

                Else
                    MsgBox("Usuário não encontrado na base de dados.", MsgBoxStyle.Information)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                'MsgBox("Não houve uma conexão com o banco de dados, se persistir o erro, favor entrar em contato com o administrador do sistema.", MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

End Class
