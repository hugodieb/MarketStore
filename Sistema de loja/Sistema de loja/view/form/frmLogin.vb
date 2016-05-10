Imports Sistema_de_loja.loginCntrol

Public Class frmLogin

    Dim control As loginCntrol
    Public user_ As User
    Dim isValid As Boolean = False

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        isValid = validFrmLogin()
        If isValid Then
            loginSystem()
        Else
            MsgBox("Voçê deve preencher todos os campos para logar no sistema.", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Public Function validFrmLogin() As Boolean

        If txtUserName.Text = "" Or txtPassword.Text = "" Then
            Return False
        End If

        Return True
    End Function

    Public Sub loginSystem()
        user_ = New User
        user_.nameUser = txtUserName.Text
        user_.passwordUser = txtPassword.Text
        control = New loginCntrol
        control.login(user_)
    End Sub

End Class
