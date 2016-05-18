Imports Sistema_de_loja 
Module mdAcessoBD
    Public status As Boolean
    Public head As New header
    Public tbm As New tabMain
    Public nameUser As String
    Public Enum btnNome
        clientes
        Fornecedor
        Produtos
        Usuarios
    End Enum
    Public Enum btnPic
        add = 0
        codBarra = 1
    End Enum
End Module
