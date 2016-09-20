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

    Private Sub txtNameCadClient_Leave(sender As Object, e As EventArgs) Handles txtNameCadClient.Leave
        'If Not A Matching Format Entered
        If Not Regex.Match(txtNameCadClient.Text, "^[a-zA-Z\s]*$", RegexOptions.IgnoreCase).Success Then 'Only Letters

            MessageBox.Show("Entre somente com letras do alfabeto!") 'Inform User

            txtNameCadClient.Focus() 'Return Focus
            txtNameCadClient.Clear() 'Clear TextBox

        End If
    End Sub

    ' Private Sub txtCPFCadClient_Leave(sender As Object, e As EventArgs) Handles txtCPFCadClient.Leave
    'If Not A Matching Format Entered
    '    If Not Regex.Match(txtCPFCadClient.Text, "^(\d{11})*$", RegexOptions.IgnoreCase).Success Then 'Only numbers

    '      MessageBox.Show("Entre com numero de cpf valido!") 'Inform User

    '     txtCPFCadClient.Focus() 'Return Focus
    '     txtCPFCadClient.Clear() 'Clear TextBox

    '  End If
    '  End Sub

    Private Sub txtNameCadClient_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNameCadClient.Validating
        If txtNameCadClient.Text.Trim.Length = 0 Then
            cderrorname.SetError(txtNameCadClient, "Informe o nome.")
        End If

    End Sub

    'Private Sub txtCPFCadClient_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCPFCadClient.Validating

    'If Not A Matching Format Entered
    '  If Not Regex.Match(txtCPFCadClient.Text, "^(\d{11})*$", RegexOptions.IgnoreCase).Success Then 'Only numbers

    'MessageBox.Show("Entre com numero de cpf valido!") 'Inform User

    '  txtCPFCadClient.Focus() 'Return Focus
    '  txtCPFCadClient.Clear() 'Clear TextBox
    '  txtCPFCadClient.BackColor = Color.Yellow

    '   End If

    '  If txtCPFCadClient.Text.Trim.Length = 0 Then
    'cderrorcpf.SetError(txtCPFCadClient, "Informe cpf valido")
    ' End If
    '  End Sub

    Private Sub txtNameCadClient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNameCadClient.KeyPress
        If txtNameCadClient.Text.Trim.Length > 0 Then
            cderrorname.Clear()

        End If
    End Sub

    Private Sub txtCPFCadClient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCPFCadClient.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            cderrorcpf.SetError(txtCPFCadClient, "Somente numeros.")
        End If

    End Sub

    Private Sub txtRgCadClient_Leave(sender As Object, e As EventArgs) Handles txtRgCadClient.Leave
        'If Not A Matching Format Entered
        If Not Regex.Match(txtRgCadClient.Text, "^(\d{6})*$", RegexOptions.IgnoreCase).Success Then 'Only numbers

            MessageBox.Show("Entre com numero de rg valido!") 'Inform User

            txtRgCadClient.Focus() 'Return Focus
            txtRgCadClient.Clear() 'Clear TextBox
        End If
    End Sub
End Class
