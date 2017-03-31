Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Module tilkoblingsdata
    'Tilkoblingsinformasjon til phpMyAdmin Konto team 5
    Private team_passord As String = "M2oHUQ17"
    Private team_brukernavn As String = "g_oops_05"
    Private tjener_navn As String = "mysql.stud.iie.ntnu.no"
    Public db_oppkobling As New MySqlConnection("Server=" & tjener_navn & ";" &
                            "Database=" & team_brukernavn & ";" &
                            "Uid=" & team_brukernavn & ";" &
                            "Pwd=" & team_passord & ";" &
                            "Convert Zero Datetime=True"
                            )

    'Brukerinformasjon.
    Public innlogget_bruker As String
    Public innlogget_etternavn As String
    Public innlogget_fornavn As String
    Public innlogget_adresse As String
    Public innlogget_blodgiver_id As Integer
    Public innlogget_blodtype As String
    Public innlogget_epost As String
<<<<<<< c58c20ae731f138e1aef550ecc348148ee2d3479
    Public innlogget_fodseldato As String
    Public innlogget_forrige_blodtapp As Date
    Public innlogget_godkjent_egenerklering As Boolean
    Public innlogget_karantene As Date
=======
    Public innlogget_godkjent_egenerklering As Integer
>>>>>>> lagre enheter og blodgivninger i db, siste blodtapp på min side
    Public innlogget_passord As String
    Public innlogget_post_nr As Integer
    Public innlogget_post_sted As String
    Public innlogget_telefon As Integer
    Public innlogget_personnummer As Integer
    Public innlogget_kjønn As String

    Public innlogget_fodseldato As String
    Public innlogget_forrige_blodtapp As String
    Public innlogget_karantene As Date

    Public innlogget_ansatt_id As Integer

    Public datoFormat As String = "^(\d){2}\.(\d){2}\.(\d){4}$"
    Public personnummerformat As String = "^(\d){5}$"
    Public epostFormat As String = "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"
    Public registrerMengdeFormat As String = "^(\d)$"
    Public blodgiverIdFormat As String = "^(\d){0,4}$"
    Public blodtypeFormat As String = "^(\){0,4}$"

    Public plasmaHoldbarhet
    Public blodlegemerHoldbarhet
    Public blodplaterHoldbarhet

    'Funksjon for å kjøre SQL spørringer
    Public Function sql_sporring(ByRef sql As String) As DataTable
<<<<<<< c58c20ae731f138e1aef550ecc348148ee2d3479
        'string for database opptilkobling
        db_tilkobling_str = "Server=" & tjener_navn & ";" &
                            "Database=" & team_brukernavn & ";" &
                            "Uid=" & team_brukernavn & ";" &
                            "Pwd=" & team_passord & ";" &
                            "Convert Zero Datetime=True"
        db_oppkobling.ConnectionString = db_tilkobling_str
=======
>>>>>>> lagre enheter og blodgivninger i db, siste blodtapp på min side

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

<<<<<<< c58c20ae731f138e1aef550ecc348148ee2d3479
    Public Function konverterDatoFormatKarantene(dato As String) As String
        Dim karanteneDato As Date = dato
        Return karanteneDato.ToString("yyyy-MM-dd")
    End Function

=======
    Public Function formatSkjekk(ByVal text As String, ByVal regularexpression As String)
        Dim match As Match = Regex.Match((text), regularexpression)
        If match.Success Then
            Return True
        Else
            Return False
        End If
    End Function
>>>>>>> lagre enheter og blodgivninger i db, siste blodtapp på min side

    'Public innlogget_karantene As date

    'SELECT * FROM `Blodgivning` inner join Blodgiver AS b on b.blodgiver_id = Blodgivning.blodgiver_id where b.blodgiver_id = VARIABEL order by blogivning_dato DESC LIMIT 1

End Module
