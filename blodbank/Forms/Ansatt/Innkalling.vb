Imports System.Net.Mail
Public Class InnkallingAnsatt
    Dim ansattInnkallingTable As New DataTable
    Dim normalInnkalling As New DataTable
    Dim innkallingListe As New List(Of Innkalling)
    Dim ePost As New Epost


    Private Sub ansattInnkalling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'maksimerer vindu, og setter farge
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 255, 255)

        'midstiller gui
        guiPanel.Left = (Me.ClientSize.Width - guiPanel.Width) \ 2
        guiPanel.Top = (Me.ClientSize.Height - guiPanel.Height) \ 2

        'fyller litt informasjon og manipulerer monthcalender.
        LabelInfo.Text = "Hasteinkalling skjer etter behov." & vbCrLf & "Funksjonaliteten sender haste e-post." & vbCrLf & "For raske bekreftelser bruk telefon."
        ledigeTimerKalender.MinDate = Date.Today
        ledigeTimerKalender.MaxSelectionCount = 1

        'valiering, hindrer brukere å trykke feil.
        HasteInnkallingKnapp.Enabled = False
        NormalInnkallingKnapp.Enabled = False
    End Sub


    'finner gyldige blodgivere.
    Private Sub blodInfoKnapp_Click(sender As Object, e As EventArgs) Handles blodInfoKnapp.Click

        klareBlodgivere.Items.Clear()

        'tre måneder fra dagens dato
        Dim treMndDato As Date
        treMndDato = DateAdd(DateInterval.Month, -3, Date.Today)
        ansattInnkallingTable = sql_sporring("SELECT Blodgiver.blodgiver_id, fornavn, etternavn, epost, telefon, Blodgiver.blodtype_id, max(blodgivning_dato) as sistBlodgivning  FROM Blodgiver INNER JOIN Blodgivning ON Blodgiver.blodgiver_id = Blodgivning.blodgiver_id WHERE godkjent_egenerklering = '1'  GROUP BY Blodgiver.blodgiver_id")

        For Each rad In ansattInnkallingTable.Rows

            'Bruker en funksjon for blodtypekonvertering
            Dim blodtypeStringInk = konverterBlodtypeTilTekst(rad("blodtype_id"))

            If rad("sistBlodgivning") < treMndDato Then
                innkallingListe.Add(New Innkalling(rad("blodgiver_id"), rad("fornavn"), rad("etternavn"), rad("epost"), rad("telefon"), rad("blodtype_id")))
                klareBlodgivere.Items.Add(rad("blodgiver_id") & vbTab & rad("fornavn") & vbTab & rad("etternavn") & vbTab & Space(2) & rad("epost") & Space(4) & rad("telefon") & Space(1) & vbTab & blodtypeStringInk)
            End If
        Next

    End Sub


    'Sender NormalInnkalling 
    Private Sub normalInnkallingKnapp_Click(sender As Object, e As EventArgs) Handles NormalInnkallingKnapp.Click
        normalInnkalling = sql_sporring("SELECT * FROM Blodgiver WHERE godkjent_egenerklering = '1'")

        Dim innkallingString
        Dim indeks = klareBlodgivere.SelectedIndex

        'validering for å velge blodgiver å sende til.
        If klareBlodgivere.SelectedIndex < 0 Then
            MsgBox("Vennligst velg blodgiver")
        Else
            innkallingString = innkallingListe(indeks).fornavn & " " & innkallingListe(indeks).etternavn

            For Each rad In normalInnkalling.Rows
                innkallingListe.Add(New Innkalling(rad("blodgiver_id"), rad("fornavn"), rad("etternavn"), rad("epost"), rad("telefon"), rad("blodtype_id")))
            Next

            'datoformat
            Dim datoFormat As String = "dd/MM/yyyy"
            Dim valgtDato = ledigeTimerKalender.SelectionRange.Start.ToString(datoFormat)

            Dim innkallTime As New DataTable

            'sender tidspunkt til database basert på valgt item i listboks.
            Dim valgtTime = ledigeTimer.SelectedItem()
            Dim tidspunkt As Integer = 0
            tidspunkt = KonverterKlokkeslettTilInteger(valgtTime)
            If tidspunkt <> 0 Then
                innkallTime = sql_sporring("INSERT INTO Timebestilling(bestilling_dato, bestilling_tidspunkt, blodgiver_id, er_aktiv)
        values('" & konverterDatoFormatTilMySql(valgtDato) & "',
               '" & tidspunkt & "',
            '" & innkallingListe(indeks).blodgiver_id & "',
            1
            )")
                MsgBox(innkallingString & " er innkalt til time hos blodbanken." & vbCrLf & "Epost er sendt. Timen er registert for " & valgtDato & ", klokken: " & tidspunkt & ":00." & vbCrLf)
            Else
                MsgBox("Vennligst velg tidspunkt for timen.")
            End If
            Dim mailTekst As String = "Hei " & innkallingListe(indeks).fornavn & " " & innkallingListe(indeks).etternavn & " vi melder om innkalling til blodgivertime den " & valgtDato & " kl: " & tidspunkt & ". Gi beskjed dersom du ikke kan komme. " & vbCrLf & vbCrLf & "Med vennlig hilsen" & vbCrLf & vbCrLf & "Blodbanken ved St. Olavs Hospital"
            Dim innkallingEpost = innkallingListe(klareBlodgivere.SelectedIndex).epost

            'Bruker metoden vi har laget i  entitetsklassen for epost funksjonalitet. (Epost.vb)
            ePost.sendEpost(innkallingEpost, "Blodgivertime", mailTekst)

        End If
        ledigeTimer.Items.Clear()
    End Sub


    'sender hasteinnkalling
    Private Sub HasteinnkallingKnapp_Click(sender As Object, e As EventArgs) Handles HasteInnkallingKnapp.Click

        Dim innkallingStringHast As String
        Dim datoFormat As String = "dd/MM/yyyy"

        Dim indeks = klareBlodgivere.SelectedIndex

        If indeks < 0 Then
            MsgBox("Vennligst velg blodgiver")
        Else
            innkallingStringHast = innkallingListe(indeks).fornavn & " " & innkallingListe(indeks).etternavn

            'henter valgt bruker sin epost, og setter 
            Dim innkallingEpost = innkallingListe(indeks).epost
            Dim dato = ledigeTimerKalender.SelectionRange.Start.ToString(datoFormat)

            Dim innkallTimeHast As New DataTable

            Dim valgtTime = ledigeTimer.SelectedItem()
            Dim tidspunkt As Integer = 0
            tidspunkt = KonverterKlokkeslettTilInteger(valgtTime)

            innkallTimeHast = sql_sporring("INSERT INTO Timebestilling(bestilling_dato, bestilling_tidspunkt, blodgiver_id, er_aktiv)
                    values('" & konverterDatoFormatTilMySql(dato) & "',
               '" & tidspunkt & "',
                '" & innkallingListe(indeks).blodgiver_id & "',
                 1
                )")

            MsgBox(innkallingStringHast & " er hasteinnkalt til time hos blodbanken." & vbCrLf & "Epost er sendt. Timen er " & dato & ", klokken: " & tidspunkt & ":00." & vbCrLf)

            'Bruker metoden vi har laget i  entitetsklassen for epost funksjonalitet. (Epost.vb)
            Dim mailTekst As String = "Hei " & innkallingListe(indeks).fornavn & " " & innkallingListe(indeks).etternavn & ". Vi melder om nødsituasjon som krever en hasteinnkalling til blodgivertime den " & dato & " kl: " & tidspunkt & ":00" & ". Bekreft snarest" & vbCrLf & vbCrLf & "Med vennlig hilsen" & vbCrLf & vbCrLf & "Blodbanken ved St. Olavs Hospital"
            ePost.sendEpost(innkallingEpost, "HASTEINNKALLING - BLODBANKEN", mailTekst)
        End If

        ledigeTimer.Items.Clear()
    End Sub


    'validering, hindrer brukere å trykke feil.
    Private Sub Kalender_DateChanged(sender As Object, e As DateRangeEventArgs) Handles ledigeTimerKalender.DateChanged
        'bruker metode for timebestilling  fra tilkoblingsdata
        timebestillingMetode(ledigeTimerKalender, ledigeTimer)
        HasteInnkallingKnapp.Enabled = False
        NormalInnkallingKnapp.Enabled = False
    End Sub


    'validering, hindrer burkere å trykke feil.
    Private Sub ledigeTimer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ledigeTimer.SelectedIndexChanged
        HasteInnkallingKnapp.Enabled = True
        NormalInnkallingKnapp.Enabled = True
    End Sub


    '####################################################################
    'NAVIGASJON
    '####################################################################


    Private Sub HjemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HjemToolStripMenuItem.Click
        Startside.Show()
        Me.Hide()
    End Sub


    Private Sub ProduktoversiktToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktoversiktToolStripMenuItem.Click
        Produktoversikt.Show()
        Me.Hide()
    End Sub


    Private Sub BestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestillingToolStripMenuItem.Click
        Bestillinger.Show()
        Me.Hide()
    End Sub


    Private Sub RegisrerBlodgivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisrerBlodgivingToolStripMenuItem.Click
        Me.Hide()
        Blodgivning.Show()
    End Sub


End Class