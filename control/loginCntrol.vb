Imports Sistema_de_loja.User
Imports Sistema_de_loja.frmLogin

Public Class loginCntrol

    Dim userDAO As userDAO

    Public Sub login(ByVal user_ As User)

        userDAO = New userDAO
        userDAO.login(user_)

    End Sub
End Class
