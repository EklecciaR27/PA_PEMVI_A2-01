Imports MySql.Data.MySqlClient

Module ModuleConnect
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public UN As String

    Sub Koneksi()
        Try
            Dim STR As String = "server = localhost;
                                 userid = root;
                                 password = ;
                                 database = db_pa_vb"
            'Nama db sesuai dg namanya
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
