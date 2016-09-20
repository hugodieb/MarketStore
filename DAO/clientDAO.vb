Imports System.Data.SqlClient
Imports System.Configuration
Public Class clientDAO

    Dim sql As String
    Dim cmd As SqlCommand

    Public Sub addNewClient(ByVal c As client)

        Using con As SqlConnection = getConnection()
            Try
                con.Open()
                sql = "INSERT INTO client (name,cpf,rg,address,complement,district,phone,cellPhone) VALUES ('" & c.nameClient & "', '" & c.cpfClient & "', '" & c.rgClient & "', '" & c.addressClient & "', '" & c.complementClient & "', '" & c.districtClient & "', '" & c.phoneClient & "', '" & c.cellPhoneClient & "')"
                cmd = New SqlCommand(sql, con)

                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub


End Class
