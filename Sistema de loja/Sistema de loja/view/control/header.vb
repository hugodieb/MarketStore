﻿Imports Sistema_de_loja
Imports Sistema_de_loja.userDAO

Public Class header

    Dim frmuserDAO As New userDAO
    Private Sub pictLogin_Click(sender As Object, e As EventArgs) Handles pictLogin.Click
        verifyUserLogado()
    End Sub

    Public Sub verifyUserLogado()
        Dim userLog As New frmLogin
        Dim frm As New userDAO
        Dim statusPerfil As Boolean = frm.statusLogUser

        Select Case statusPerfil
            Case False
                frmLogin.ShowDialog()
            Case True
                frmuserDAO.logout()
        End Select

    End Sub

End Class
