Public Class User

    Private Id As Integer
    Private name As String
    Private password As String
    Private perfil As String

    Public Property nameUser() As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property passwordUser() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property typeUser() As String
        Get
            Return perfil
        End Get
        Set(value As String)
            perfil = value
        End Set
    End Property

End Class
