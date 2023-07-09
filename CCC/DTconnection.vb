Imports MySql.Data.MySqlClient

Public Class DTconnection
    Dim connect As MySqlConnection = New MySqlConnection("server= localhost; database=databasecc; uid = root; pwd=;")
    Public Function open() As MySqlConnection
        Try
            connect.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connect
    End Function

    Public Function close() As MySqlConnection
        Try
            connect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connect
    End Function
End Class
