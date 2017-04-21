Imports MySql.Data.MySqlClient
Module tilkoblingsdata
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
    'Brukerinformasjon.
    Public innlogget_bruker As String
    Public innlogget_etternavn As String
    Public innlogget_fornavn As String
    Public innlogget_adresse As String
    Public innlogget_blodgiver_id As Integer
    Public innlogget_blodprosent As Integer
    Public innlogget_blodtype As String
    Public innlogget_epost As String
    Public innlogget_fodseldato As String
    Public innlogget_forrige_blodtapp As Date
    Public innlogget_godkjent_egenerklering As Boolean
    Public innlogget_karantene As Date
    Public innlogget_passord As String
    Public innlogget_post_nr As Integer
    Public innlogget_post_sted As String
    Public innlogget_telefon As Integer
    Public innlogget_personnummer As Integer
    Public innlogget_kjønn As String
    Public innlogget_ansatt_id As Integer
    'Public innlogget_fodseldato As String
    'Public innlogget_forrige_blodtapp As String
    'Public innlogget_karantene As Date
    'Public innlogget_godkjent_egenerklering As Integer
    'lagringsvarabler for ulike egenskaper  

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


    Public Function IntegertilKlokkeSlett(ByVal tid As Integer)
        Dim tidspunkt
        Select Case tid
            Case 9
                tidspunkt = "09:00"
            Case 10
                tidspunkt = "10:00"
            Case 11
                tidspunkt = "11:00"
            Case 12
                tidspunkt = "12:00"
            Case 13
                tidspunkt = "13:00"
            Case 14
                tidspunkt = "14:00"
            Case 15
                tidspunkt = "15:00"
        End Select
        Return tidspunkt
    End Function



    Public Sub timebestillingMetode(kalender, listbox)
        Dim valgtDato As String = konverterDatoFormatTilMySql(kalender.SelectionRange.Start.ToShortDateString())
        Dim aktiveTimer = sql_sporring("SELECT er_aktiv, bestilling_tidspunkt FROM Timebestilling where bestilling_dato ='" & valgtDato & "' and er_aktiv = 1")

        Dim klokke As Integer = 9
        listbox.Items.Clear()
        Dim tidsPunkt = ""
        Dim hvisTid = True

        If aktiveTimer.Rows.Count <> 0 Then 'hvis det er timer på den dagen

            'skjekk om tidspunktet er en av radene
            For i = 0 To 6

                For Each rad In aktiveTimer.Rows
                    If rad("bestilling_tidspunkt") = klokke Then
                        hvisTid = False
                    End If
                Next
                tidsPunkt = IntegertilKlokkeSlett(klokke)
                If hvisTid Then
                    listbox.Items.Add(tidsPunkt)
                End If
                klokke += 1
                hvisTid = True
            Next
        Else
            For i = 0 To 6
                tidsPunkt = IntegertilKlokkeSlett(klokke)
                listbox.Items.Add(tidsPunkt)
                klokke += 1
            Next
        End If
    End Sub


    Public Function konverterBlodtypeTilTekst(ByVal id As Integer)
        Dim blodtypeString
        Select Case id
            Case 1
                blodtypeString = "A+"
            Case 2
                blodtypeString = "A-"
            Case 3
                blodtypeString = "B+"
            Case 4
                blodtypeString = "B-"
            Case 5
                blodtypeString = "AB+"
            Case 6
                blodtypeString = "AB-"
            Case 7
                blodtypeString = "O+"
            Case 8
                blodtypeString = "O-"
        End Select

        Return blodtypeString
    End Function
    Public Function konverterBlodEgenskapTilTekst(ByVal Egid As Integer)
        Dim blodegString
        Select Case Egid
            Case 1
                blodegString = "Legemer"
            Case 2
                blodegString = "Plater"
            Case 3
                blodegString = "Plasma"
        End Select
        Return blodegString
    End Function

    'Public innlogget_karantene As date
    'SELECT * FROM `Blodgivning` inner join Blodgiver AS b on b.blodgiver_id = Blodgivning.blodgiver_id where b.blodgiver_id = VARIABEL order by blogivning_dato DESC LIMIT 1
End Module
