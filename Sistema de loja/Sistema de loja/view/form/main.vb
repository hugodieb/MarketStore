
Public Class main

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadHeaderMain()

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

End Class
