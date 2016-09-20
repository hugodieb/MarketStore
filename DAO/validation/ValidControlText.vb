Imports System.Text.RegularExpressions

Public Class ValidControlText

    Public Sub validCadClient(ByVal c As pnCadClient)
        Dim strSurname As String = "^[a-zA-Z\s]+$"
        Dim reSurname As New Regex(strSurname)
    End Sub

End Class