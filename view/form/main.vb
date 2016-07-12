
Public Class main

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim index As Integer = 0
        loadHeaderMain(index)
    End Sub

    Private Sub linkface_Click(sender As Object, e As EventArgs) Handles linkface.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/corinthians")
    End Sub

    Private Sub linkinstagram_Click(sender As Object, e As EventArgs) Handles linkinstagram.Click
        System.Diagnostics.Process.Start("https://www.instagram.com/corinthians/")
    End Sub

    Private Sub linktwitter_Click(sender As Object, e As EventArgs) Handles linktwitter.Click
        System.Diagnostics.Process.Start("https://twitter.com/corinthians?lang=pt")
    End Sub

    Private Sub hr_Tick(sender As Object, e As EventArgs) Handles hr.Tick

        calendarData.Text = Today
        calendarHora.Text = TimeOfDay

    End Sub

End Class
