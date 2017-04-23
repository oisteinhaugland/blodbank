Public Class Timebestillinger
    Dim timebestList As New List(Of Timebestilling)
    Dim bestilteTimer As New DataTable
    Dim ledigeTimer As New DataTable
    Dim feilMelding = "Beklager det har oppstått en feil. Vennligst kontakt din nærmeste blodbank-ansatt"

    Private Sub blodgiver_timebestilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maksimere vindu, setter farge 
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 255, 255)

        'manipulering av kalender
        kalenderTimer.MinDate = Date.Today
        kalenderTimer.MaxSelectionCount = 1
        bestillKnapp.Enabled = False
        avbestillKnapp.Enabled = False

        'gui sentrering.
        guiPanel.Left = (Me.ClientSize.Width - guiPanel.Width) \ 2
        guiPanel.Top = (Me.ClientSize.Height - guiPanel.Height) \ 2
    End Sub


    Private Sub bestillKnapp_Click(sender As Object, e As EventArgs) Handles bestillKnapp.Click
        'hindre error med mysqldb, velger riktig format.
        Dim datoFormat As String = "dd/MM/yyyy"
        Dim valgtDato = kalenderTimer.SelectionRange.Start.ToString(datoFormat)

        Dim bestillTime As New DataTable
        Dim valgtTime = ledigeTimerListBox.SelectedItem()


        Dim tidsPunkt As Integer
        tidsPunkt = KonverterKlokkeslettTilInteger(valgtTime)

        Try
            bestillTime = sql_sporring("INSERT INTO Timebestilling(bestilling_dato, bestilling_tidspunkt, blodgiver_id, er_aktiv)
        values('" & konverterDatoFormatTilMySql(valgtDato) & "',
               '" & tidsPunkt & "',
            '" & innloggetBlodgiverId & "',
            1
            )")
            Dim registrertTime As String = "Du har nå bestilt time. Dato for timen er " & valgtDato & ", klokken " & tidsPunkt & ":00"
            MsgBox(registrertTime)
        Catch ex As Exception
            MsgBox(feilMelding)
        End Try

        bestillKnapp.Enabled = False
    End Sub


    Private Sub avbestillKnapp_Click(sender As Object, e As EventArgs) Handles avbestillKnapp.Click
        Dim valgtDato As String = dineTimer.SelectedItem
        Dim avbestilling
        Dim indeks = dineTimer.SelectedIndex

        Try
            sql_sporring("UPDATE Timebestilling SET er_aktiv = 0 WHERE timebestilling_id = " & timebestList(indeks).timebestilling_id)
            Dim avbestiltTime As String = "Du har nå avbestilt timen din den " & valgtDato & ". Bestill gjerne en ny time."
            MsgBox(avbestiltTime)
        Catch ex As Exception
            MsgBox(feilMelding)
        End Try
        avbestillKnapp.Enabled = False
    End Sub


    Private Sub HentTimebestilling_Click(sender As Object, e As EventArgs) Handles hentTimebestilling.Click
        dineTimer.Items.Clear()

        'hent timer til innlogget bruker
        bestilteTimer = sql_sporring("Select * FROM Timebestilling WHERE blodgiver_id = " & innloggetBlodgiverId & " And er_aktiv = 1")

        For Each rad In bestilteTimer.Rows
            dineTimer.Items.Add("Timedato: " & rad("bestilling_dato") & ", klokken: " & rad("bestilling_tidspunkt") & ":00")

            'legger til bestillinger i en liste av klassen for kunne avbestillge timere ut i fra valgt time i listboks.
            timebestList.Add(New Timebestilling(rad("timebestilling_id"), rad("bestilling_dato"), rad("bestilling_tidspunkt"), rad("blodgiver_id"), rad("er_aktiv")))
        Next

    End Sub


    'Kalender og timebestilling subs. Validering. Hindrer brukere å trykke på knapper til feil tidspunkt.
    Private Sub Kalender_DateChanged(sender As Object, e As DateRangeEventArgs) Handles kalenderTimer.DateChanged
        timebestillingMetode(kalenderTimer, ledigeTimerListBox)
        bestillKnapp.Enabled = False
    End Sub

    Private Sub ledigeTimerListBoxEndretDato(sender As Object, e As EventArgs) Handles ledigeTimerListBox.SelectedIndexChanged
        bestillKnapp.Enabled = True
    End Sub


    Private Sub DineTimer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dineTimer.SelectedIndexChanged
        avbestillKnapp.Enabled = True
    End Sub


    '####################################################################
    'NAVIGASJON
    '####################################################################


    Private Sub MinSideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinSideToolStripMenuItem.Click
        MinSide.Show()
        Me.Hide()
    End Sub


    Private Sub EgenerklæringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgenerklæringToolStripMenuItem.Click
        Egenklæring.Show()
        Me.Hide()
    End Sub

End Class