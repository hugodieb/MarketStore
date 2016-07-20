Imports System.Data.SqlClient
Imports Sistema_de_loja
Imports Sistema_de_loja.User
Imports Sistema_de_loja.main
Imports System.Configuration
Imports Sistema_de_loja.mdAcessoBD

Public Class userDAO

    Dim sql As String = Nothing
    Dim cmd As SqlCommand = Nothing
    Dim dr As SqlDataReader = Nothing
    Public Sub login(ByVal user As User)

        Using con As New SqlConnection

            Try
                con.ConnectionString = ConfigurationManager.AppSettings("ConnectionBD")
                con.Open()

                sql = "select * from person where ((name=@name) and (password=@password))"
                cmd = New SqlCommand(sql, con)

                cmd.Parameters.Add(New SqlParameter("@name", user.nameUser))
                cmd.Parameters.Add(New SqlParameter("@password", user.passwordUser))
                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    dr.Read()
                    Dim strPerfil As String
                    strPerfil = dr.Item("typeUser")
                    nameUser = dr.Item("name")
                    main.lblNameUser.Text = nameUser.Trim.ToString
                    status = True

                    loadingpanel2(strPerfil)
                    frmLogin.Dispose()

                Else
                    MsgBox("Usuário não encontrado na base de dados.", MsgBoxStyle.Information)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("Não houve uma conexão com o banco de dados, se persistir o erro, favor entrar em contato com o administrador do sistema.", MsgBoxStyle.Information)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Public Sub logout()
        Dim name As String
        name = tbm.Name

        If (main.Controls.Contains(tbm)) Then
            main.Controls.Remove(mdAcessoBD.tbm)
        End If

        status = False
        nameUser = Nothing
        main.lblNameUser.Text = nameUser
        loadHeaderMain(0)
        statusLampLoginLogout()
    End Sub
End Class
