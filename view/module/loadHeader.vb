Imports Sistema_de_loja
Imports Sistema_de_loja.main

Module loadHeader
    Dim str As String

    Public Sub loadHeaderMain(ByVal index As Integer)
        main.pnTop.Controls.Add(head)
        head.pictLogin.Image = head.imgListHeaderLog.Images(index)
        statusLampLoginLogout()
    End Sub

    Public Sub loadTabMain(ByVal index As Integer)

        head.pictLogin.Image = head.imgListHeaderLog.Images(index)
        main.Controls.Add(mdAcessoBD.tbm)

        loadButtonstbMain()
    End Sub

    Public Sub loadingpanel2(ByVal value As String)
        str = value.Trim.ToString

        Select Case str
            Case "admin"
                loadTabMain(1)
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

    Private Sub loadButtonstbMain()
        Dim arrayNameButton() As String = {"Clientes", "Produtos", "Fornecedores", "Usuários"}
        Dim arrayIndexImgButton() As Integer = {0, 1, 2, 3}

        If Not tbm.flwBtnCad.TabIndex <> 0 Then

            For i As Integer = 0 To arrayNameButton.Length - 1
                Dim btnCuston As New custonButton
                btnCuston.Width = 80
                btnCuston.Height = 71
                btnCuston.picbtncuston.Image = btnCuston.imgButtonCuston.Images(arrayIndexImgButton(i))
                btnCuston.lblButtonCuston.Text = arrayNameButton(i)
                btnCuston.Name = "custon" + arrayNameButton(i)
                tbm.flwBtnCad.TabIndex = (i)
                tbm.flwBtnCad.Controls.Add(btnCuston)
            Next

        Else
            Exit Sub
        End If
    End Sub

End Module
