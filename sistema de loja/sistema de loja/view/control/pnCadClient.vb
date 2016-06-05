Public Class pnCadClient

    Dim w As Integer
    Dim h As Integer

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
        Me.Dock = DockStyle.Fill
        calculateLocationgpView()
        Me.flwControlCadClient.Location = New Point(w, h)
    End Sub


    Private Sub calculateLocationgpView()
        Dim x As Integer
        Dim y As Integer
        Dim k As Integer
        Dim z As Integer

        x = Me.Size.Width
        y = (Me.Size.Height) - (main.pntabmain.Size.Height)
        k = Me.flwControlCadClient.Size.Width
        z = Me.flwControlCadClient.Size.Height

        w = (x - k) / 2
        h = (y - z) / 2 + main.pntabmain.Size.Height
    End Sub

End Class
