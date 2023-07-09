Imports MySql.Data.MySqlClient

Module SQLcon
    Private con As MySqlConnection = New MySqlConnection("server= localhost; database=databasecc; uid = root; pwd=;")
    Public cmd As MySqlCommand
    Public sql As String


    ' execute an insert update ...
    Public Sub exe_mysql(ByVal sql As String)

        Try
            con.Open()
            Dim cs As String = sql
            cmd = New MySqlCommand(cs, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        con.Close()
    End Sub


End Module
