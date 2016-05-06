Imports Sistema_de_loja

Module loadHeader

    Public Sub loadHeaderMain()

        Dim head As New header
        main.Controls.Add(head)
        head.Dock = DockStyle.Top
        head.Show()
    End Sub

End Module
