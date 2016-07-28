Imports Sistema_de_loja
Imports Sistema_de_loja.main
Imports Sistema_de_loja.pnCadClient

Module loadFormViews

    Public Sub loadpnView(c As Control)
        main.Controls.Add(c)
        main.Controls.Add(tsControl)
    End Sub
End Module
