Imports MySql.Data.MySqlClient

Module tilkoblingsdata
    'Tilkoblingsinformasjon til phpMyAdmin Konto team 5
    Private team_passord As String = "M2oHUQ17"
    Private team_brukernavn As String = "g_oops_05"
    Private tjener_navn As String = "mysql.stud.iie.ntnu.no"
    Private db_tilkobling_str As String
    Private db_oppkobling As New MySqlConnection

    'Brukerinformasjon.
    Public innlogget_bruker As String
    Public innlogget_etternavn As String
    Public innlogget_fornavn As String
    Public innlogget_adresse As String
    Public innlogget_blodgiver_id As Integer
    Public innlogget_blodtype As String
    Public innlogget_epost As String
    Public innlogget_fodseldato As Date '
    Public innlogget_forrige_blodtapp As Date
    Public innlogget_godkjent_egenerklering As Boolean
    Public innlogget_karantene As Integer
    Public innlogget_passord As String
    Public innlogget_post_nr As Integer
    Public innlogget_post_sted As String
    Public innlogget_telefon As Integer
    Public innlogget_personnummer As Integer


    'Funksjon for å kjøre SQL spørringer
    Public Function sql_sporring(ByRef sql As String) As DataTable
        'string for database opptilkobling
        db_tilkobling_str = "Server=" & tjener_navn & ";" &
                            "Database=" & team_brukernavn & ";" &
                            "Uid=" & team_brukernavn & ";" &
                            "Pwd=" & team_passord & ";"
        db_oppkobling.ConnectionString = db_tilkobling_str

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
        Return sql_sporring("SELECT epost,passord FROM Ansatt")
    End Function







End Module
