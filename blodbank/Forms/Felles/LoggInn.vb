﻿Imports MySql.Data.MySqlClient

'Imports System.Net.Mail

Public Class loggInn
    Dim Hash As New Hash
    'Public aktivBruker As New List(Of Bruker)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized


        ' Me.Bounds = My.Computer.Screen.WorkingArea
        Panel8.Left = (Me.ClientSize.Width - Panel8.Width) \ 2
        Panel8.Top = (Me.ClientSize.Height - Panel8.Height) \ 2
        Me.BackColor = Color.FromArgb(255, 255, 255)

    End Sub

    Private melding_logg_inn_feil As String = "Feil brukernavn eller passord, vennligst prøv igjen."

    Public Function loggInnBlodgiver(bruker, pwd)
        Dim blodGivere As New DataTable
        Dim innloggetBruker As New DataTable

        Dim vanligpassord = passordTextBox.Text
        Dim registrertSalt
        Dim registrertPwd
        Dim loggetInn As Boolean = False
        Dim kjønn

        'tabell = sql_sporring("SELECT * FROM Blodgiver WHERE epost ='" & bruker & "' AND hashedPwd = '" & pwd & "'")
        blodGivere = sql_sporring("SELECT * FROM Blodgiver WHERE epost ='" & bruker & "'")
        For Each rad In blodGivere.Rows
            registrertSalt = rad("salt")
            registrertPwd = rad("hashedPwd")
        Next

        Dim innskrevetPassord = Hash.Hash512(vanligpassord, registrertSalt)
        innloggetBruker = sql_sporring("SELECT * FROM Blodgiver WHERE epost ='" & bruker & "' AND hashedPwd = '" & innskrevetPassord & "'")

        If innloggetBruker.Rows.Count <> 0 Then
            For Each rad In innloggetBruker.Rows
                Dim brukernavn = rad("epost")
                Dim passord = rad("passord")
                Dim fornavn = rad("fornavn")
                Dim etternavn = rad("etternavn")
                Dim adresse = rad("adresse")
                Dim blodgiver_id = rad("blodgiver_id")
                Dim blodtype = rad("blodtype_id")
                Dim epost = rad("epost")
                Dim fodseldato = rad("fodseldato")
                Dim godkjent_egenerklering = rad("godkjent_egenerklering")
                Dim karantene = rad("karantene")
                Dim post_nr = rad("post_nr")
                Dim post_sted = rad("post_sted")
                Dim telefon = rad("telefon")
                Dim personnummer = rad("personnummer")
                Dim forrige_blodtapp
                Dim blodprosent = rad("blodprosent")




                If brukernavn <> String.Empty Then
                    'aktivBruker.Clear()
                    'aktivBruker.Add(New Bruker(blodgiver_id, fornavn, etternavn, fodseldato, adresse, epost, post_nr, post_sted, telefon, personnummer, blodtype, karantene, godkjent_egenerklering))

                    innlogget_bruker = brukernavn
                    innlogget_fornavn = fornavn
                    innlogget_etternavn = etternavn
                    innlogget_adresse = adresse
                    innlogget_blodgiver_id = blodgiver_id
                    innlogget_blodtype = blodtype
                    innlogget_epost = epost
                    innlogget_fodseldato = fodseldato
                    innlogget_godkjent_egenerklering = godkjent_egenerklering
                    innlogget_karantene = karantene
                    innlogget_post_nr = post_nr
                    innlogget_post_sted = post_sted
                    innlogget_telefon = telefon
                    innlogget_personnummer = personnummer
                    innlogget_blodprosent = blodprosent

                    Try
                        Dim ny_tabbel = sql_sporring("SELECT * FROM 
                            Blodgivning inner join Blodgiver AS b
                            on b.blodgiver_id = Blodgivning.blodgiver_id where b.blodgiver_id = '" & innlogget_blodgiver_id & "'
                            order by blodgivning_dato DESC limit 1")

                        For Each row In ny_tabbel.Rows
                            forrige_blodtapp = row("blodgivning_dato")
                        Next

                    Catch ex As Exception
                        forrige_blodtapp = "Aldri gitt blod"
                    End Try

                    innlogget_forrige_blodtapp = forrige_blodtapp
                    kjønn = CInt(innlogget_personnummer.ToString.Substring(2, 1))
                    loggetInn = True
                End If

            Next
            loggetInn = True
        Else
            loggetInn = False
        End If

        If (kjønn Mod 2) = 0 Then
            innlogget_kjønn = "Kvinne"
        Else
            innlogget_kjønn = "Mann"
        End If

        If loggetInn Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function loggInnLeder(bruker, pwd)
        Dim tabell As New DataTable
        tabell = sql_sporring("SELECT * FROM Ansatt WHERE epost ='" & bruker & "'")
        Dim loggetInn As Boolean = False

        For Each rad In tabell.Rows
            Dim brukernavn = rad("epost")
            Dim passord = rad("passord")
            Dim ansatt_id = rad("ansatt_id")
            Dim lederstatus = rad("lederstatus")

            If bruker = brukernavn And pwd = passord And lederstatus <> 0 Then
                innlogget_bruker = brukernavn
                innlogget_ansatt_id = ansatt_id
                loggetInn = True
            End If
        Next

        If loggetInn Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function loggInnAnsatt()
        Dim tabell As New DataTable
        tabell = selectAnsatt()
        Dim loggetInn As Boolean = False

        For Each rad In tabell.Rows
            Dim brukernavn = rad("epost")
            Dim passord = rad("passord")
            Dim ansatt_id = rad("ansatt_id")
            'Dim fornavn = rad("fornavn")
            'Dim etternavn = rad("etternavn")
            'Dim adresse = rad("adresse")
            'Dim epost = rad("epost")
            ''Dim fodseldato = rad("fodseldato")
            'Dim post_nr = rad("post_nr")
            'Dim post_sted = rad("post_sted")
            'Dim telefon = rad("telefon")
            'Dim personnummer = rad("personnummer")


            If brukerNavnTextbox.Text = brukernavn And passordTextBox.Text = passord Then
                innlogget_bruker = brukernavn
                innlogget_ansatt_id = ansatt_id
                'innlogget_fornavn = fornavn
                'innlogget_etternavn = etternavn
                'innlogget_adresse = adresse
                'innlogget_epost = epost
                'innlogget_fodseldato = fodseldato
                'innlogget_post_nr = post_nr
                'innlogget_post_sted = post_sted
                'innlogget_telefon = telefon
                loggetInn = True
            End If
        Next

        If loggetInn Then
            Return True
        Else
            Return False
        End If

    End Function


    Private Sub loggInnKnapp_Click_1(sender As Object, e As EventArgs) Handles loggInnKnapp.Click
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

    'sett standar possisjon til topp left.


    'registrer ny blodgiver nagivasjon
    Private Sub registrerBrukerKnapp_Click(sender As Object, e As EventArgs) Handles registrerBrukerKnapp.Click
        registrerBlodgiver.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hashtest.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MinSide.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Startside.Show()
        Me.Hide()
    End Sub

    Private Sub glemtPassordKnapp_Click(sender As Object, e As EventArgs) Handles glemtPassordKnapp.Click
        GlemtPassord.Show()
        Me.Hide()
    End Sub


End Class







' funka ikke enda
'Private Sub glemtPassordKnapp_Click(sender As Object, e As EventArgs) Handles glemtPassordKnapp.Click
'    Dim EmailMessage As New MailMessage()
'    Try
'        Dim SmtpServer As New SmtpClient()
'        Dim mail As New MailMessage()
'        SmtpServer.Credentials = New _
'        Net.NetworkCredential("haugland.1193@gmail.com", "edSeiler1917@")
'        SmtpServer.Port = 587
'        SmtpServer.Host = "smtp.gmail.com"
'        mail = New MailMessage()
'        mail.From = New MailAddress("haugland.1193@gmail.com")
'        mail.To.Add("mathias.bytingsvik@gmail.com")
'        mail.Subject = "Test Mail"
'        mail.Body = "This is for testing SMTP mail from GMAIL MATHIAS, du er flink"
'        SmtpServer.Send(mail)
'        MsgBox("mail send")
'    Catch ex As Exception
'        MsgBox(ex.ToString)
'    End Try

'End Sub



'Public Function fucuck(bruker, pwd)
'    Dim brukernavn = ""
'    Dim passord = ""
'    Dim fornavn
'    Dim etternavn
'    Dim adresse
'    Dim blodgiver_id
'    Dim blodtype
'    Dim epost
'    Dim fodseldato
'    Dim godkjent_egenerklering
'    Dim karantene
'    Dim post_nr
'    Dim post_sted
'    Dim telefon
'    Dim personnummer


'Dim forrige_blodtapp

'Try
'    Dim ny_tabbel = sql_sporring("SELECT * FROM 
'    `Blodgivning` inner join Blodgiver AS b
'    on b.blodgiver_id = Blodgivning.` blodgiver_id` where b.blodgiver_id = '" & innlogget_blodgiver_id & "'
'    order by ` blogivning_dato` DESC limit 1")

'    For Each row In ny_tabbel.Rows
'        forrige_blodtapp = row("forrige_blodtapp")
'    Next

'Catch ex As Exception
'    forrige_blodtapp = "Aldri gitt blod"
'End Try






'    Dim sporring = "SELECT * FROM Blodgiver WHERE epost ='" & bruker & "' AND passord = '" & pwd & "'"
'    Dim sql As New MySqlCommand(sporring, db_oppkobling)

'    Try
'        db_oppkobling.Open()
'        Dim leser = sql.ExecuteReader()
'        While leser.Read()
'            brukernavn = leser("epost")
'            passord = leser("passord")
'            fornavn = leser("fornavn")
'            etternavn = leser("etternavn")
'            adresse = leser("adresse")
'            blodgiver_id = leser("blodgiver_id")
'            blodtype = leser("blodtype")
'            epost = leser("epost")
'            fodseldato = leser("fodseldato")
'            godkjent_egenerklering = leser("godkjent_egenerklering")
'            karantene = leser("karantene")
'            post_nr = leser("post_nr")
'            post_sted = leser("post_sted")
'            telefon = leser("telefon")
'            personnummer = leser("personnummer")
'        End While

'        db_oppkobling.Close()

'    Catch ex As Exception
'        MsgBox(ex.Message)
'        db_oppkobling.Close()
'    End Try



'    Dim forrige_blodtapp As String


'    If brukernavn <> String.Empty Then


'        innlogget_bruker = brukernavn
'        innlogget_fornavn = fornavn
'        innlogget_etternavn = etternavn
'        innlogget_adresse = adresse
'        innlogget_blodgiver_id = blodgiver_id
'        innlogget_blodtype = blodtype
'        innlogget_epost = epost
'        innlogget_fodseldato = fodseldato
'        innlogget_godkjent_egenerklering = godkjent_egenerklering
'        innlogget_karantene = karantene
'        innlogget_post_nr = post_nr
'        innlogget_post_sted = post_sted
'        innlogget_telefon = telefon
'        innlogget_personnummer = personnummer


'        Try
'            Dim ny_tabbel = sql_sporring("SELECT * FROM 
'                        Blodgivning inner join Blodgiver AS b
'                        on b.blodgiver_id = Blodgivning.blodgiver_id where b.blodgiver_id = '" & innlogget_blodgiver_id & "'
'                        order by blodgivning_dato DESC limit 1")

'            For Each row In ny_tabbel.Rows
'                forrige_blodtapp = row("blodgivning_dato")
'            Next

'        Catch ex As Exception
'            forrige_blodtapp = "Aldri gitt blod"
'        End Try

'        innlogget_forrige_blodtapp = forrige_blodtapp
'        Return True
'    Else
'        Return False
'    End If

'End Function









'innloggetBruker = sql_sporring("SELECT * from Blodgiver WHERE epost ='" & bruker & "' AND hashedPwd ='" & passordTest & "'")

'If innloggetBruker.Rows.Count <> 0 Then
'    loggetInn = True
'End If

'Dim skjekkaPassord = Hash.Hash512(vanligpassord, brukerSalt)

'If skjekkaPassord = brukerHashedPassord Then

'    For Each rad In tabell.Rows
'        Dim brukernavn = rad("epost")
'        Dim passord = rad("passord")
'        Dim fornavn = rad("fornavn")
'        Dim etternavn = rad("etternavn")
'        Dim adresse = rad("adresse")
'        Dim blodgiver_id = rad("blodgiver_id")
'        Dim blodtype = rad("blodtype_id")
'        Dim epost = rad("epost")
'        Dim fodseldato = rad("fodseldato")

'        'Dim forrige_blodtapp = rad("forrige_blodtapp")

'        Dim godkjent_egenerklering = rad("godkjent_egenerklering")
'        Dim karantene = rad("karantene")
'        Dim post_nr = rad("post_nr")
'        Dim post_sted = rad("post_sted")
'        Dim telefon = rad("telefon")
'        Dim personnummer = rad("personnummer")
'        Dim forrige_blodtapp

'        Try
'            Dim ny_tabbel = sql_sporring("SELECT * FROM 
'        `Blodgivning` inner join Blodgiver AS b
'        on b.blodgiver_id = Blodgivning.blodgiver_id where b.blodgiver_id = '" & innlogget_blodgiver_id & "'
'        order by blodgivning_dato DESC limit 1")

'            For Each row In ny_tabbel.Rows
'                forrige_blodtapp = row("forrige_blodtapp")
'            Next

'        Catch ex As Exception
'            forrige_blodtapp = "Aldri gitt blod"
'        End Try

'        If brukernavn <> String.Empty Then

'            innlogget_bruker = brukernavn
'            innlogget_fornavn = fornavn
'            innlogget_etternavn = etternavn
'            innlogget_adresse = adresse
'            innlogget_blodgiver_id = blodgiver_id
'            innlogget_blodtype = blodtype
'            innlogget_epost = epost
'            innlogget_fodseldato = fodseldato

'            'innlogget_forrige_blodtapp = forrige_blodtapp
'            innlogget_godkjent_egenerklering = godkjent_egenerklering
'            innlogget_karantene = karantene

'            innlogget_post_nr = post_nr
'            innlogget_post_sted = post_sted
'            innlogget_telefon = telefon
'            innlogget_personnummer = personnummer
'            loggetInn = True

'            innlogget_godkjent_egenerklering = godkjent_egenerklering
'            innlogget_karantene = karantene
'            innlogget_post_nr = post_nr
'            innlogget_post_sted = post_sted
'            innlogget_telefon = telefon
'            innlogget_personnummer = personnummer

'            Try
'                Dim ny_tabbel = sql_sporring("SELECT * FROM 
'                Blodgivning inner join Blodgiver AS b
'                on b.blodgiver_id = Blodgivning.blodgiver_id where b.blodgiver_id = '" & innlogget_blodgiver_id & "'
'                order by blodgivning_dato DESC limit 1")

'                For Each row In ny_tabbel.Rows
'                    forrige_blodtapp = row("blodgivning_dato")
'                Next

'            Catch ex As Exception
'                forrige_blodtapp = "Aldri gitt blod"
'            End Try

'            innlogget_forrige_blodtapp = forrige_blodtapp


'            kjønn = CInt(innlogget_personnummer.ToString.Substring(2, 1))
'            loggetInn = True
'        End If

'    Next


'Else
'    MsgBox("you fucking failed")
'End If









'For Each rad In blodGivere.Rows
'    Dim brukernavn = rad("epost")
'    Dim passord = rad("passord")
'    Dim fornavn = rad("fornavn")
'    Dim etternavn = rad("etternavn")
'    Dim adresse = rad("adresse")
'    Dim blodgiver_id = rad("blodgiver_id")
'    Dim blodtype = rad("blodtype_id")
'    Dim epost = rad("epost")
'    Dim fodseldato = rad("fodseldato")
'    Dim godkjent_egenerklering = rad("godkjent_egenerklering")
'    Dim karantene = rad("karantene")
'    Dim post_nr = rad("post_nr")
'    Dim post_sted = rad("post_sted")
'    Dim telefon = rad("telefon")
'    Dim personnummer = rad("personnummer")
'    Dim forrige_blodtapp

'For Each rad In tabell.Rows
'    Dim brukernavn = rad("epost")
'    Dim passord = rad("passord")
'    Dim fornavn = rad("fornavn")
'    Dim etternavn = rad("etternavn")
'    Dim adresse = rad("adresse")
'    Dim blodgiver_id = rad("blodgiver_id")
'    Dim blodtype = rad("blodtype_id")
'    Dim epost = rad("epost")
'    Dim fodseldato = rad("fodseldato")

'    'Dim forrige_blodtapp = rad("forrige_blodtapp")

'    Dim godkjent_egenerklering = rad("godkjent_egenerklering")
'    Dim karantene = rad("karantene")
'    Dim post_nr = rad("post_nr")
'    Dim post_sted = rad("post_sted")
'    Dim telefon = rad("telefon")
'    Dim personnummer = rad("personnummer")
'    Dim forrige_blodtapp
'    Dim blodprosent = rad("blodprosent")

'    Try
'        Dim ny_tabbel = sql_sporring("SELECT * FROM 
'        `Blodgivning` inner join Blodgiver AS b
'        on b.blodgiver_id = Blodgivning.blodgiver_id where b.blodgiver_id = '" & innlogget_blodgiver_id & "'
'        order by blodgivning_dato DESC limit 1")

'        For Each row In ny_tabbel.Rows
'            forrige_blodtapp = row("forrige_blodtapp")
'        Next

'    Catch ex As Exception
'        forrige_blodtapp = "Aldri gitt blod"
'    End Try

'    If brukernavn <> String.Empty Then


'        '    'spørring som finner siste blodtapp av bruker.
'        '    'Try
'        '    '    Dim ny_tabbel = sql_sporring("SELECT * FROM 
'        '    '    `Blodgivning` inner join Blodgiver AS b
'        '    '    on b.blodgiver_id = Blodgivning.blodgiver_id where b.blodgiver_id = '" & innlogget_blodgiver_id & "'
'        '    '    order by blodgivning_dato DESC limit 1")


'        '    '    For Each row In ny_tabbel.Rows
'        '    '        forrige_blodtapp = row("forrige_blodtapp")
'        '    '    Next
'        '    'Catch ex As Exception
'        '    '    forrige_blodtapp = "Aldri gitt blod"
'        '    'End Try

'        innlogget_godkjent_egenerklering = godkjent_egenerklering
'        innlogget_karantene = karantene
'        innlogget_post_nr = post_nr
'        innlogget_post_sted = post_sted
'        innlogget_telefon = telefon
'        innlogget_personnummer = personnummer
'        innlogget_blodprosent = blodprosent


'        '    'hvis du fant en bruker med matchende kombinasjon av brukernavn og passord fyll ut informasjon
'        '    If brukernavn <> String.Empty Then


'        '        innlogget_bruker = brukernavn
'        '        innlogget_fornavn = fornavn
'        '        innlogget_etternavn = etternavn
'        '        innlogget_adresse = adresse
'        '        innlogget_blodgiver_id = blodgiver_id
'        '        innlogget_blodtype = blodtype
'        '        innlogget_epost = epost
'        '        innlogget_fodseldato = fodseldato

'        '        'innlogget_forrige_blodtapp = forrige_blodtapp
'        '        innlogget_godkjent_egenerklering = godkjent_egenerklering
'        '        innlogget_karantene = karantene

'        '        innlogget_post_nr = post_nr
'        '        innlogget_post_sted = post_sted
'        '        innlogget_telefon = telefon
'        '        innlogget_personnummer = personnummer
'        '        loggetInn = True

'        '        innlogget_godkjent_egenerklering = godkjent_egenerklering
'        '        innlogget_karantene = karantene
'        '        innlogget_post_nr = post_nr
'        '        innlogget_post_sted = post_sted
'        '        innlogget_telefon = telefon
'        '        innlogget_personnummer = personnummer

'        '        'spørring som finner siste blodtapp av bruker.
'        '        Try
'        '            Dim ny_tabbel = sql_sporring("SELECT * FROM 
'        '                Blodgivning inner join Blodgiver AS b
'        '                on b.blodgiver_id = Blodgivning.blodgiver_id where b.blodgiver_id = '" & innlogget_blodgiver_id & "'
'        '                order by blodgivning_dato DESC limit 1")

'        '            For Each row In ny_tabbel.Rows
'        '                forrige_blodtapp = row("blodgivning_dato")
'        '            Next

'        '        Catch ex As Exception
'        '            forrige_blodtapp = "Aldri gitt blod"
'        '        End Try

'        '        innlogget_forrige_blodtapp = forrige_blodtapp


'        '        kjønn = CInt(innlogget_personnummer.ToString.Substring(2, 1))
'    End If

'Next

