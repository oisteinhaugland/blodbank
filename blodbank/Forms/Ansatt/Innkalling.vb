Imports System.Net.Mail
Public Class ansattInnkalling
    Dim ansattInnkallingTable As New DataTable
    Dim Norminnkalling As New DataTable
    Dim innkallingListe As New List(Of Innkalling)
    Dim epost As New Epost


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

    Private Sub ansattInnkalling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Label7.Text = "Hasteinkalling skjer etter behov." & vbCrLf & "Funksjonaliteten sender haste e-post." & vbCrLf & "For raske bekreftelser bruk telefon."
        Me.Location = New Point(0, 0)
        Me.BackColor = Color.FromArgb(247, 247, 247)
        MonthCalendar1.MinDate = Date.Today
        MonthCalendar1.MaxSelectionCount = 1

    End Sub

    Private Sub blodInfoKnapp_Click(sender As Object, e As EventArgs) Handles blodInfoKnapp.Click
        klareBlodgivere.Items.Clear()
        Dim Tremnddato As Date
        Tremnddato = DateAdd(DateInterval.Month, -3, Date.Today)
        ansattInnkallingTable = sql_sporring("SELECT Blodgiver.blodgiver_id, fornavn, etternavn, epost, telefon, Blodgiver.blodtype_id, max(blodgivning_dato) as sistBlodgivning  FROM Blodgiver INNER JOIN Blodgivning ON Blodgiver.blodgiver_id = Blodgivning.blodgiver_id WHERE godkjent_egenerklering = '1'  GROUP BY Blodgiver.blodgiver_id")

        For Each rad In ansattInnkallingTable.Rows

            Dim blodtypeStringInk = konverterBlodtypeTilTekst(rad("blodtype_id"))


            If rad("sistBlodgivning") < Tremnddato Then

                innkallingListe.Add(New Innkalling(rad("blodgiver_id"), rad("fornavn"), rad("etternavn"), rad("epost"), rad("telefon"), rad("blodtype_id")))
                klareBlodgivere.Items.Add(rad("blodgiver_id") & vbTab & vbTab & rad("fornavn") & vbTab & rad("etternavn") & vbTab & Space(2) & rad("epost") & Space(4) & rad("telefon") & Space(1) & vbTab & blodtypeStringInk)
            End If
        Next

    End Sub
    Private Sub normalInnkallingKnapp_Click(sender As Object, e As EventArgs) Handles NormalInnkallingKnapp.Click

        Norminnkalling = sql_sporring("SELECT * FROM Blodgiver WHERE godkjent_egenerklering = '1'")

        Dim innkallingString
        Dim index = klareBlodgivere.SelectedIndex
        If klareBlodgivere.SelectedIndex < 0 Then
            MsgBox("Vennligst velg blodgiver")
        Else
            innkallingString = innkallingListe(index).fornavn & " " & innkallingListe(index).etternavn
            For Each rad In Norminnkalling.Rows
                innkallingListe.Add(New Innkalling(rad("blodgiver_id"), rad("fornavn"), rad("etternavn"), rad("epost"), rad("telefon"), rad("blodtype_id")))

            Next
            Dim datoFormat As String = "dd/MM/yyyy"
            Dim valgtDato = MonthCalendar1.SelectionRange.Start.ToString(datoFormat)

            Dim innkallTime As New DataTable
            Dim temp = ledigeTimer.SelectedItem()
            Dim tidspunkt As Integer
            Select Case temp
                Case "09:00"
                    tidspunkt = 9
                Case "10:00"
                    tidspunkt = 10
                Case "11:00"
                    tidspunkt = 11
                Case "12:00"
                    tidspunkt = 12
                Case "13:00"
                    tidspunkt = 13
                Case "14:00"
                    tidspunkt = 14
                Case "15:00"
                    tidspunkt = 15
            End Select

            Try
                If tidspunkt <> 0 Then

                    innkallTime = sql_sporring("INSERT INTO Timebestilling(bestilling_dato, bestilling_tidspunkt, blodgiver_id, er_aktiv)
        values('" & konverterDatoFormatTilMySql(valgtDato) & "',
               '" & tidspunkt & "',
            '" & innkallingListe(index).blodgiver_id & "',
            1
            )")
                    MsgBox(innkallingString & " er innkalt til time hos blodbanken." & vbCrLf & "Epost er sendt. Timen er registert for " & valgtDato & ", klokken: " & tidspunkt & ":00." & vbCrLf)
                Else
                    MsgBox("Vennligst velg tidspunkt for timen.")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try

                Dim mailTekst As String = "Hei vi melder om innkalling til blodgivertime den " & valgtDato & " kl: " & tidspunkt & ". Gi beskjed dersom du ikke kan komme. " & vbCrLf & vbCrLf & "Med vennlig hilsen" & vbCrLf & vbCrLf & "Blodbanken ved St. Olavs Hospital"
                Dim innkallingEpost = innkallingListe(klareBlodgivere.SelectedIndex).epost

                'Epost funksjonalitet for innkalling
                epost.sendEpost(innkallingEpost, "Blodgivertime", mailTekst)

            Catch error_t As Exception
                MsgBox("Vennligst velg blodgiver før innkalling.")
            End Try
        End If
        ledigeTimer.Items.Clear()
    End Sub

    Private Sub RegisrerBlodgivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisrerBlodgivingToolStripMenuItem.Click
        Me.Hide()
        Blodgivning.Show()
    End Sub

    Private Sub HasteinnkallingKnapp_Click(sender As Object, e As EventArgs) Handles HasteInnkallingKnapp.Click

        Dim innkallingStringHast As String

        Dim datoFormat As String = "dd/MM/yyyy"
        Dim index2 = klareBlodgivere.SelectedIndex
        If klareBlodgivere.SelectedIndex < 0 Then
            MsgBox("Vennligst velg blodgiver")
        Else
            innkallingStringHast = innkallingListe(index2).fornavn & " " & innkallingListe(index2).etternavn
            Dim innkallingEpost = innkallingListe(index2).epost
            Dim dato2 = MonthCalendar1.SelectionRange.Start.ToString(datoFormat)


            Dim innkallTimeHast As New DataTable
            Dim temp = ledigeTimer.SelectedItem()
            Dim tidspunkt As Integer
            Select Case temp
                Case "09:00"
                    tidspunkt = 9
                Case "10:00"
                    tidspunkt = 10
                Case "11:00"
                    tidspunkt = 11
                Case "12:00"
                    tidspunkt = 12
                Case "13:00"
                    tidspunkt = 13
                Case "14:00"
                    tidspunkt = 14
                Case "15:00"
                    tidspunkt = 15
            End Select

            Try

                If tidspunkt <> 0 Then

                    innkallTimeHast = sql_sporring("INSERT INTO Timebestilling(bestilling_dato, bestilling_tidspunkt, blodgiver_id, er_aktiv)
        values('" & konverterDatoFormatTilMySql(dato2) & "',
               '" & tidspunkt & "',
            '" & innkallingListe(index2).blodgiver_id & "',
            1
            )")
                    MsgBox(innkallingStringHast & " er hasteinnkalt til time hos blodbanken." & vbCrLf & "Epost er sendt. Timen er " & dato2 & ", klokken: " & tidspunkt & ":00." & vbCrLf)

                Else
                    MsgBox("Vennligst velg tidspunkt for timen.")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try

                'Bruker metoden vi har laget i epost klassen.
                Dim mailTekst As String = "Hei vi melder om nødsituasjon som krever en hasteinnkalling til blodgivertime den " & dato2 & " kl: " & tidspunkt & ":00" & ". Bekreft snarest" & vbCrLf & vbCrLf & "Med vennlig hilsen" & vbCrLf & vbCrLf & "Blodbanken ved St. Olavs Hospital"
                epost.sendEpost(innkallingEpost, "HASTEINNKALLING - BLODBANKEN", mailTekst)

            Catch error_t As Exception
                MsgBox("Vennligst velg blodgiver før innkalling.")
            End Try
        End If
        ledigeTimer.Items.Clear()

    End Sub
    Private Sub Kalender_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim valgtDato As String = konverterDatoFormatTilMySql(MonthCalendar1.SelectionRange.Start.ToShortDateString())
        Dim aktiveTimer = sql_sporring("SELECT er_aktiv, bestilling_tidspunkt FROM Timebestilling where bestilling_dato ='" & valgtDato & "' and er_aktiv = 1")

        Dim klokke As Integer = 9
        ledigeTimer.Items.Clear()
        Dim tidsPunkt = ""
        Dim hvisTid = True

        If aktiveTimer.Rows.Count <> 0 Then 'hvis det er timer pÂ den dagen
            'skjekk om tidspunktet er en av radene
            For i = 0 To 6

                For Each rad In aktiveTimer.Rows
                    If rad("bestilling_tidspunkt") = klokke Then
                        hvisTid = False
                    End If
                Next
                Select Case klokke
                    Case 9
                        tidsPunkt = "09:00"
                    Case 10
                        tidsPunkt = "10:00"
                    Case 11
                        tidsPunkt = "11:00"
                    Case 12
                        tidsPunkt = "12:00"
                    Case 13
                        tidsPunkt = "13:00"
                    Case 14
                        tidsPunkt = "14:00"
                    Case 15
                        tidsPunkt = "15:00"
                End Select
                If hvisTid Then
                    ledigeTimer.Items.Add(tidsPunkt)
                End If
                klokke += 1
                hvisTid = True
            Next
        Else
            For i = 0 To 6
                Select Case klokke
                    Case 9
                        tidsPunkt = "09:00"
                    Case 10
                        tidsPunkt = "10:00"
                    Case 11
                        tidsPunkt = "11:00"
                    Case 12
                        tidsPunkt = "12:00"
                    Case 13
                        tidsPunkt = "13:00"
                    Case 14
                        tidsPunkt = "14:00"
                    Case 15
                        tidsPunkt = "15:00"
                End Select
                ledigeTimer.Items.Add(tidsPunkt)
                klokke += 1
            Next
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class