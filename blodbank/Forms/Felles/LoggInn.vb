Public Class loggInn
    Dim Hash As New Hash


    Private Sub LoggInn_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'maximerer vindu, setter farge og midtstiller gui
        WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 255, 255)
        guiPanel.Left = (Me.ClientSize.Width - guiPanel.Width) \ 2
        guiPanel.Top = (Me.ClientSize.Height - guiPanel.Height) \ 2
    End Sub


    'function for logg inn
    'Blodgivere har salt/hashet passord.
    Public Function loggInnBlodgiver(bruker, pwd)
        Dim blodGivere As New DataTable
        Dim innloggetBruker As New DataTable

        Dim vanligPassord = passordTextBox.Text
        Dim registrertSalt
        Dim registrertPwd
        Dim kjønn
        Dim loggetInn As Boolean = False


        'Finn salt og registrert hashedpassord
        blodGivere = sql_sporring("SELECT * FROM Blodgiver WHERE epost ='" & bruker & "'")
        For Each rad In blodGivere.Rows
            registrertSalt = rad("salt")
            registrertPwd = rad("hashedPwd")
        Next


        'tester kombinasjonen av innskrevet passord og det registrerte saltet.
        Dim innskrevetPassord = Hash.Hash512(vanligPassord, registrertSalt)
        innloggetBruker = sql_sporring("SELECT * FROM Blodgiver WHERE epost ='" & bruker & "' AND hashedPwd = '" & innskrevetPassord & "'")


        'Hvis antall rows er større en 0, har du logget inn.
        If innloggetBruker.Rows.Count <> 0 Then
            For Each rad In innloggetBruker.Rows
                'henter informasjon fra db
                Dim brukerNavn = rad("epost")
                Dim forNavn = rad("fornavn")
                Dim etterNavn = rad("etternavn")
                Dim adresse = rad("adresse")
                Dim blodgiverId = rad("blodgiver_id")
                Dim blodType = rad("blodtype_id")
                Dim ePost = rad("epost")
                Dim fodselDato = rad("fodseldato")
                Dim godkjentEgenErklering = rad("godkjent_egenerklering")
                Dim karantene = rad("karantene")
                Dim postNr = rad("post_nr")
                Dim postSted = rad("post_sted")
                Dim tlfNr = rad("telefon")
                Dim personNr = rad("personnummer")
                Dim forrigeBlodtapp
                Dim blodProsent = rad("blodprosent")

                'hvis ett brukernavn ble funnet, fyll ut brukerinformasjon.
                If brukerNavn <> String.Empty Then
                    BrukerInformasjon.innloggetBruker = brukerNavn
                    innloggetFornavn = forNavn
                    innloggetEtternavn = etterNavn
                    innloggetAdresse = adresse
                    innloggetBlodgiverId = blodgiverId
                    innloggetBlodtype = blodType
                    innloggetEpost = ePost
                    innloggetFodseldato = fodselDato
                    innloggetGodkjentEgenerklering = godkjentEgenErklering
                    innloggetKarantene = karantene
                    innloggetPostNr = postNr
                    innloggetPostSted = postSted
                    innloggetTlf = tlfNr
                    innloggetPersonNr = personNr
                    innloggetBlodprosent = blodProsent

                    'Finn forrige blodtapping.
                    Try
                        Dim blodTappingTabell = sql_sporring("SELECT * FROM 
                            Blodgivning inner join Blodgiver AS b
                            on b.blodgiver_id = Blodgivning.blodgiver_id where b.blodgiver_id = '" & innloggetBlodgiverId & "'
                            order by blodgivning_dato DESC limit 1")

                        For Each row In blodTappingTabell.Rows
                            forrigeBlodtapp = row("blodgivning_dato")
                        Next
                    Catch ex As Exception
                        forrigeBlodtapp = "Aldri gitt blod"
                    End Try

                    innloggetForrigeBlodtapp = forrigeBlodtapp

                    'finner tredje tallet i personnummer
                    kjønn = CInt(innloggetPersonNr.ToString.Substring(2, 1))
                    loggetInn = True
                End If

            Next
            loggetInn = True
        Else
            loggetInn = False
        End If

        'hvis tallet er partall.
        If (kjønn Mod 2) = 0 Then
            innloggetKjønn = "Kvinne"
        Else
            innloggetKjønn = "Mann"
        End If

        If loggetInn Then
            Return True
        Else
            Return False
        End If
    End Function


    'logg inn leder.
    Public Function loggInnLeder(bruker, pwd)
        Dim tabell As New DataTable
        tabell = sql_sporring("SELECT * FROM Ansatt WHERE epost ='" & bruker & "'")
        Dim loggetInn As Boolean = False

        For Each rad In tabell.Rows
            Dim brukerNavn = rad("epost")
            Dim passord = rad("passord")
            Dim ansattId = rad("ansatt_id")
            Dim lederStatus = rad("lederstatus")

            If bruker = brukerNavn And pwd = passord And lederStatus <> 0 Then
                innloggetBruker = brukerNavn
                innloggetAnsattId = ansattId
                loggetInn = True
            End If
        Next

        If loggetInn Then
            Return True
        Else
            Return False
        End If
    End Function


    'funksjon for anstatt logginn
    Public Function loggInnAnsatt()
        Dim tabell As New DataTable
        tabell = selectAnsatt()
        Dim loggetInn As Boolean = False

        For Each rad In tabell.Rows
            Dim brukerNavn = rad("epost")
            Dim passord = rad("passord")
            Dim ansattId = rad("ansatt_id")
            Dim forNavn = rad("fornavn")
            Dim etterNavn = rad("etternavn")

            If brukerNavnTextbox.Text = brukerNavn And passordTextBox.Text = passord Then
                innloggetBruker = brukerNavn
                innloggetAnsattId = ansattId
                innloggetFornavn = forNavn
                innloggetEtternavn = etterNavn
                loggetInn = True
                Exit For
            End If
        Next

        If loggetInn Then
            Return True
        Else
            Return False
        End If

    End Function


    Private Sub loggInnKnapp_Click_1(sender As Object, e As EventArgs) Handles loggInnKnapp.Click
        Dim melding_logg_inn_feil As String = "Feil brukernavn eller passord, vennligst prøv igjen."

        'Kjører logginn funksjonene og tøm tekstfeltene ved logginn..
        If loggInnLeder(brukerNavnTextbox.Text, passordTextBox.Text) Then
            Leder.Show()
            Me.Hide()
            brukerNavnTextbox.Text = ""
            passordTextBox.Text = ""
        ElseIf loggInnAnsatt() Then
            Startside.Show() '
            Me.Hide()
            brukerNavnTextbox.Text = ""
            passordTextBox.Text = ""
        ElseIf loggInnBlodgiver(brukerNavnTextbox.Text, passordTextBox.Text) Then
            MinSide.Show()
            Me.Hide()
            brukerNavnTextbox.Text = ""
            passordTextBox.Text = ""
        Else
            MsgBox(melding_logg_inn_feil)
        End If
    End Sub


    '####################################################################
    'NAVIGASJON
    '####################################################################


    Private Sub registrerBrukerKnapp_Click(sender As Object, e As EventArgs) Handles registrerBrukerKnapp.Click
        registrerBlodgiver.Show()
        Me.Hide()
    End Sub

    Private Sub glemtPassordKnapp_Click(sender As Object, e As EventArgs) Handles glemtPassordKnapp.Click
        GlemtPassord.Show()
        Me.Hide()
    End Sub

End Class