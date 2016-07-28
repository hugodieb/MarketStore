Public Class toolStripControl

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        pnCC.Hide()
        tsControl.Hide()
    End Sub

    Private Sub toolStripControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 161)
    End Sub
End Class
