Public Class User

    Private name As String
    Private password As String
    Private typeUser As String

    Public Sub setName(ByRef name As String)
        Me.name = name
    End Sub

    Public Function getName()
        Return Me.name
    End Function

    Public Sub setPassword(ByRef password As String)
        Me.password = password
    End Sub

    Public Function getPassword()
        Return Me.password
    End Function

    Public Sub setTypeUser(ByRef type As String)
        Me.typeUser = type
    End Sub

    Public Function getTypeUser()
        Return Me.typeUser
    End Function

End Class
