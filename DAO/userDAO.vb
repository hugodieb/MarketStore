Imports System.Data.SqlClient
Imports Sistema_de_loja
Imports Sistema_de_loja.User
Imports Sistema_de_loja.main
Imports System.Configuration
Imports Sistema_de_loja.mdAcessoBD
Imports Sistema_de_loja.bdSQL
Imports Sistema_de_loja.pnCadClient

Public Class userDAO

    Dim sql As String = Nothing
    Dim cmd As SqlCommand = Nothing
    Dim dr As SqlDataReader = Nothing

    Public Sub login(ByVal user As User)

        Using con As SqlConnection = getConnection()

            Try
                con.Open()

                sql = "select * from person where ((name=@name) and (password=@password))"
                cmd = New SqlCommand(sql, con)

                cmd.Parameters.Add(New SqlParameter("@name", user.nameUser))
                cmd.Parameters.Add(New SqlParameter("@password", user.passwordUser))
                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    dr.Read()
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

        Select Case strPerfil.Trim.ToString
            Case "admin"

                Dim list As New List(Of String)
                Dim ctr As New Control

                For Each ctr In main.Controls
                    list.Add(ctr.Name)
                Next

                If list.Contains("toolStripControl") Then
                    MsgBox("Por favor fechar a janela de cadastro antes de dar LogOff. !")
                    list.Clear()
                    Exit Sub
                Else
                    main.Controls.Remove(tbm)
                End If

        End Select

        status = False
        nameUser = Nothing
        main.lblNameUser.Text = nameUser
        loadHeaderMain(0)
        statusLampLoginLogout()
    End Sub
End Class
