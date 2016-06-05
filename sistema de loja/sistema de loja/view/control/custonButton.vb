Imports Sistema_de_loja

Public Class custonButton
    Private Sub pnButtonCuston_Click(sender As Object, e As EventArgs) Handles pnButtonCuston.Click, picbtncuston.Click, lblButtonCuston.Click

        Dim control As Boolean = tsControl.Visible
        Dim str As String = Me.Name

        Select Case str
            Case "custonClientes"
                If control <> True Then
                    pnCC.Show()
                    tsControl.Show()

                Else
                    loadpnView()
                End If
            Case "custonFornecedores"
                If control <> True Then
                    tsControl.Show()

                Else
                    loadpnView()
                End If

            Case "custonProdutos"
                If control <> True Then
                    tsControl.Show()

                Else
                    loadpnView()
                End If
        End Select








        
    End Sub

End Class
