Imports System.Text.RegularExpressions

Public Class toolStripControl
    Dim clientCtrl As clientsControl
    Dim isValid As Boolean = Nothing

    Private Sub toolStripControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 161)
    End Sub

    Private Sub tsCancel_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If MsgBox("Quer realmente fechar esta janela?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            main.Controls.Remove(pnCC)
            main.Controls.Remove(tsControl)
            pnCC.cderrorname.Clear()
        Else : Exit Sub
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        If main.Controls.Contains(pnCC) Then
            saveClient()
            pnCC.cleanviewClient()
        End If
    End Sub

    Private Sub saveClient()
        Dim c As New client

        c.nameClient = pnCC.txtNameCadClient.Text
        c.cpfClient = pnCC.txtCPFCadClient.Text
        c.rgClient = pnCC.txtRgCadClient.Text.Trim
        c.addressClient = pnCC.txtAddressCadClient.Text.Trim
        c.complementClient = pnCC.txtComplementCadClient.Text.Trim
        c.districtClient = pnCC.txtDistrictCadClient.Text.Trim
        c.phoneClient = pnCC.txtPhoneCadClient.Text.Trim
        c.cellPhoneClient = pnCC.txtCellPhoneCadClient.Text.Trim

        clientCtrl = New clientsControl
        clientCtrl.add(c)
    End Sub

End Class
