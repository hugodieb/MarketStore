Public Class client
    Private id As Integer
    Private name As String
    Private cpf As String
    Private rg As String
    Private address As String
    Private complement As String
    Private district As String
    Private phone As String
    Private cellPhone As String

    Public Property nameClient() As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property cpfClient() As String
        Get
            Return cpf
        End Get
        Set(value As String)
            cpf = value
        End Set
    End Property

    Public Property rgClient() As String
        Get
            Return rg

        End Get
        Set(value As String)
            rg = value
        End Set
    End Property

    Public Property addressClient() As String
        Get
            Return address
        End Get
        Set(value As String)
            address = value
        End Set
    End Property

    Public Property complementClient() As String
        Get
            Return complement
        End Get
        Set(value As String)
            complement = value
        End Set
    End Property

    Public Property districtClient() As String
        Get
            Return district
        End Get
        Set(value As String)
            district = value
        End Set
    End Property

    Public Property phoneClient() As String
        Get
            Return phone
        End Get
        Set(value As String)
            phone = value
        End Set
    End Property

    Public Property cellPhoneClient() As String
        Get
            Return cellPhone
        End Get
        Set(value As String)
            cellPhone = value
        End Set
    End Property

End Class
