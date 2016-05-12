Imports Sistema_de_loja
Imports Sistema_de_loja.main

Module loadHeader
    Dim head As New header
    Dim tab As New tabMain
    Dim str As String

    Public Sub loadHeaderMain(ByVal index As Integer)
        main.pnTop.Controls.Add(head)
        head.Dock = DockStyle.Top
        head.pictLogin.Image = head.imgListHeaderLog.Images(index)
        statusLampLoginLogout()
        head.Show()
    End Sub

    Public Sub loadTabMain()
        main.pnTop.Controls.Add(tab)
        tab.Dock = DockStyle.Top
        tab.Show()
    End Sub

    Public Sub loadingpanel2(ByVal value As String)
        str = value.Trim.ToString
        main.pnTop.Controls.Clear()
        Select Case str
            Case "admin"
                loadTabMain()
                loadHeaderMain(1)
            Case "oper"
                loadHeaderMain(1)
        End Select

        statusLampLoginLogout()

    End Sub

    Public Sub statusLampLoginLogout()
        Dim loginLogout As String = status

        If loginLogout Then
            head.picLamp.Image = head.imgListLamp.Images(0)
        Else
            head.picLamp.Image = head.imgListLamp.Images(1)
        End If
    End Sub
End Module
