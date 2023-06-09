Imports MySql.Data.MySqlClient
Module Conectar
    Public con As String = "Server=localhost; database=db_ingecosmo; User ID=root; Password=; "
    Public mycon As MySqlConnection = New MySqlConnection(con)
    Public rs As MySqlCommand = New MySqlCommand
    Public Function Prueba() As Boolean
        Try
            mycon.Open()
            Return True
        Catch ex As MySqlException
            MessageBox.Show("No se pudo conectar al servidor")
            Return False
        End Try
    End Function

End Module
