Imports Sistema_de_loja 
Module mdAcessoBD
    Public status As Boolean
    Public head As New header
    Public tbm As New tabMain
    Public btnCuston As New custonButton
    Public nameUser As String
    Public pnCC As New pnCadClient
    Public tsControl As New toolStripControl
    Public pnfill As New pnFill
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
