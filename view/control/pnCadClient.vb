Imports Sistema_de_loja.mdAcessoBD
Imports System.Text.RegularExpressions

Public Class pnCadClient

    Dim k As Integer
    Dim z As Integer

    Private Sub pnCadClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cleanviewClient()
        calculateLocationgpView()
        Me.Location = New Point(k, z)
    End Sub

    Private Sub pnCadClient_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        cleanviewClient()
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

    Public Sub cleanviewClient()
        txtNameCadClient.Text = ""
        txtCPFCadClient.Text = ""
        txtRgCadClient.Text = ""
        txtAddressCadClient.Text = ""
        txtComplementCadClient.Text = ""
        txtDistrictCadClient.Text = ""
        txtPhoneCadClient.Text = ""
        txtCellPhoneCadClient.Text = ""
    End Sub

    Private Sub txtNameCadClient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNameCadClient.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack Then
            cderrorname.SetError(txtNameCadClient, "Somente letras sem numeros.")
            e.Handled = True
        Else
            cderrorname.Clear()
        End If
    End Sub

    Private Sub txtCPFCadClient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCPFCadClient.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "-" Then
            cderrorcpf.SetError(txtCPFCadClient, "Somente numeros.")
            e.Handled = True
        Else
            cderrorcpf.Clear()
        End If
    End Sub

    Private Sub txtRgCadClient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRgCadClient.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "-" Then
            cderrorrg.SetError(txtRgCadClient, "Somente numeros.")
            e.Handled = True
        Else
            cderrorrg.Clear()
        End If
    End Sub
   
    Private Sub txtDistrictCadClient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDistrictCadClient.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack Then
            cderrorstreet.SetError(txtDistrictCadClient, "Somente letras sem numeros.")
            e.Handled = True
        Else
            cderrorstreet.Clear()
        End If
    End Sub

    Private Sub txtPhoneCadClient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneCadClient.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "-" Then
            cderrorphone.SetError(txtPhoneCadClient, "Somente numeros.")
            e.Handled = True
        Else
            cderrorphone.Clear()
        End If
    End Sub

    Private Sub txtCellPhoneCadClient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCellPhoneCadClient.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "-" Then
            cderrorcellphone.SetError(txtCellPhoneCadClient, "Somente numeros.")
            e.Handled = True
        Else
            cderrorcellphone.Clear()
        End If
    End Sub

    Private Sub txtCPFCadClient_Validated(sender As Object, e As EventArgs) Handles txtCPFCadClient.Validated
        Dim strregex As String = "^\d{9}-\d{2}$"

        Dim reg_exp As New Regex(strregex)

        If Not reg_exp.IsMatch(txtCPFCadClient.Text) Then
            txtCPFCadClient.BackColor = Color.Yellow
        Else
            txtCPFCadClient.BackColor = Color.White
        End If
    End Sub

    Private Sub txtRgCadClient_Validated(sender As Object, e As EventArgs) Handles txtRgCadClient.Validated
        Dim strregex As String = "^\d{8}-\d{1}$"

        Dim reg_exp As New Regex(strregex)

        If Not reg_exp.IsMatch(txtRgCadClient.Text) Then
            txtRgCadClient.BackColor = Color.Yellow
        Else
            txtRgCadClient.BackColor = Color.White
        End If
    End Sub

    Private Sub txtPhoneCadClient_Validated(sender As Object, e As EventArgs) Handles txtPhoneCadClient.Validated
        Dim strregex As String = "^\d{4}-\d{4}$"

        Dim reg_exp As New Regex(strregex)

        If Not reg_exp.IsMatch(txtPhoneCadClient.Text) Then
            txtPhoneCadClient.BackColor = Color.Yellow
        Else
            txtPhoneCadClient.BackColor = Color.White
        End If
    End Sub

    Private Sub txtCellPhoneCadClient_Validated(sender As Object, e As EventArgs) Handles txtCellPhoneCadClient.Validated
        Dim strregex As String = "^\d{4}-\d{4}$"

        Dim reg_exp As New Regex(strregex)

        If Not reg_exp.IsMatch(txtCellPhoneCadClient.Text) Then
            txtCellPhoneCadClient.BackColor = Color.Yellow
        Else
            txtCellPhoneCadClient.BackColor = Color.White
        End If
    End Sub
End Class
