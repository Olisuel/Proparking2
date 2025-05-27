Imports MySql.Data.MySqlClient
Module Connection
    Private ReadOnly connectionString As String = "Server=localhost;Database=vehicle-parking-db;User ID=root;Password='';"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    Public Sub ExecuteQuery(query As String)
        Using connection As MySqlConnection = GetConnection()
            Try
                connection.Open()
                Dim command As New MySqlCommand(query, connection)
                command.ExecuteNonQuery()
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
End Module
