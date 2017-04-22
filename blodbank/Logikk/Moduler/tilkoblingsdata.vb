Imports MySql.Data.MySqlClient
Module Tilkoblingsdata
    'Tilkoblingsinformasjon til phpMyAdmin Konto team 5
    Private team_passord As String = "M2oHUQ17"
    Private team_brukernavn As String = "g_oops_05"
    Private tjener_navn As String = "mysql.stud.iie.ntnu.no"
    Public db_oppkobling As New MySqlConnection(
                            "Server=" & tjener_navn & ";" &
                            "Database=" & team_brukernavn & ";" &
                            "Uid=" & team_brukernavn & ";" &
                            "Pwd=" & team_passord & ";" &
                            "Convert Zero Datetime=True"
                            )

    'Funksjon for å kjøre SQL spørringer
    Public Function sql_sporring(ByRef sql As String) As DataTable

        Dim data_tabell As New DataTable

        Try
            db_oppkobling.Open()
            Dim sql_kommando As New MySqlCommand(sql, db_oppkobling)
            Dim data_adapter As New MySqlDataAdapter

            data_adapter.SelectCommand = sql_kommando
            data_adapter.Fill(data_tabell)

            db_oppkobling.Close()
        Catch ex As MySqlException
            MessageBox.Show("Tilkoblingsfeil: " & ex.Message)
            db_oppkobling.Close()
        End Try
        Return data_tabell

    End Function

    Public Function selectBlogiver()
        Return sql_sporring("SELECT * FROM Blodgiver")
    End Function

    Public Function selectAnsatt()
        Return sql_sporring("SELECT * FROM Ansatt")
    End Function

    Public Function konverterDatoFormatTilMySql(dato As String) As String
        Dim innskrevetDato As Date = dato
        Return innskrevetDato.ToString("yyyy-MM-dd")
    End Function

End Module
