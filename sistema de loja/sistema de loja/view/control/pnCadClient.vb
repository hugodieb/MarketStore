Imports Sistema_de_loja.mdAcessoBD

Public Class pnCadClient

    Dim k As Integer
    Dim z As Integer

    Private Sub pnCadClient_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        txtNameCadClient.Text = ""
        txtCPFCadClient.Text = ""
        txtRgCadClient.Text = ""
        txtAddressCadClient.Text = ""
        txtComplementCadClient.Text = ""
        txtDistrictCadClient.Text = ""
        txttxtPhoneCadClientCadClient.Text = ""
        txtCellPhoneCadClient.Text = ""
    End Sub

    Private Sub pnCadClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calculateLocationgpView()
        Me.Location = New Point(k, z)
    End Sub


    Private Sub calculateLocationgpView()
        Dim a As Integer
        Dim b As Integer

        Dim c As Integer
        Dim d As Integer
        Dim e As Integer
        Dim f As Integer

        c = main.Height
        d = main.pnTop.Height
        e = main.pnBotton.Height
        f = tbm.Height


        k = (main.Width - Me.flwControlCadClient.Width) / 2 'largura painel principal
        a = c - (d + e + f) ' altura do pn que sobra no main
        b = a / 2
        z = b   ' altura onde fica o pncadclient

    End Sub

End Class
