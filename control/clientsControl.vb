Public Class clientsControl

    Dim _clientDAO As clientDAO

    Public Sub add(ByVal c As client)
        _clientDAO = New clientDAO
        _clientDAO.addNewClient(c)
    End Sub
End Class
