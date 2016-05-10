Imports Sistema_de_loja

Module loadHeader
    Dim head As New header
    Dim tab As New tabMain
    Dim str As String

    Public Sub loadHeaderMain(ByVal index As Integer)
        main.Panel2.Controls.Add(head)
        head.Dock = DockStyle.Top
        head.pictLogin.Image = head.imgListHeaderLog.Images(index)
        head.Show()
    End Sub

    Public Sub loadTabMain()
        main.Panel2.Controls.Add(tab)
        tab.Dock = DockStyle.Top
        tab.Show()
    End Sub

    Public Sub loadingpanel2(ByVal value As String)
        str = value.Trim.ToString
        main.Panel2.Controls.Clear()
        Select Case str
            Case "admin"
                loadTabMain()
                loadHeaderMain(1)
            Case "oper"
                loadHeaderMain(1)
        End Select
    End Sub

End Module
