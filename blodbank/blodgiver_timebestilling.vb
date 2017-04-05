Public Class blodgiver_timebestilling
    Dim timebestList As New List(Of timebestilling)
    Dim bestilteTimer As New DataTable
    Dim ledigeTimer As New DataTable

    Private Sub MinSideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinSideToolStripMenuItem.Click
        blodgiverMinSide.Show()
        Me.Hide()
    End Sub

    Private Sub EgenerklæringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgenerklæringToolStripMenuItem.Click
        blodgiver_egenerklering.Show()
        Me.Hide()
    End Sub

    Private Sub blodgiver_timebestilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.BackColor = Color.FromArgb(247, 247, 247)
        Kalender.MinDate = Date.Today

        'Dim test As New DataTable
        'test = sql_sporring("SELECT * FROM Timebestilling Where er_aktiv = 1")
        'Dim testing(test.Rows.Count) As Date

        'Dim enDato As New List(Of Date)

        'For Each rad In test.Rows
        '    enDato.Add(rad("bestilling_dato"))
        'Next

        'MonthCalendar1.BoldedDates = 

        ComboBox1.Items.Add("09.00")
        ComboBox1.Items.Add("10.00")
        ComboBox1.Items.Add("11.00")
        ComboBox1.Items.Add("12.00")
        ComboBox1.Items.Add("13.00")
        ComboBox1.Items.Add("14.00")

        'ledigeTidspunkt.Items.Clear()
        'ledigeTimer = sql_sporring("SELECT bestilling_tidspunkt FROM Timebestilling")
        'For Each rad In ledigeTimer.Rows
        '    ledigeTidspunkt.Items.Add(ledigeTimer)
        'Next

    End Sub

    Private Sub bestillKnapp_Click(sender As Object, e As EventArgs) Handles bestillKnapp.Click
        Dim datoFormat As String = "dd/MM/yyyy"
        Dim valgtDato = Kalender.SelectionRange.Start.ToString(datoFormat)

        Dim bestillTime As New DataTable
        Dim tidspunkt As String = ComboBox1.SelectedItem()

        Try
            bestillTime = sql_sporring("INSERT INTO Timebestilling(bestilling_dato, bestilling_tidspunkt, blodgiver_id, er_aktiv)
        values('" & konverterDatoFormatTilMySql(valgtDato) & "',
               '" & tidspunkt & "',
            '" & innlogget_blodgiver_id & "',
            1
            )")
            Dim registrertTime As String = "Du har nå bestilt time. Dato for timen er " & valgtDato & ", klokken " & tidspunkt
            MsgBox(registrertTime)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub avbestillKnapp_Click(sender As Object, e As EventArgs) Handles avbestillKnapp.Click
        Dim valgtDato As String = DineTimer.SelectedItem
        Dim avbestilling
        Dim index = DineTimer.SelectedIndex

        Try
            sql_sporring("UPDATE Timebestilling SET er_aktiv = 0 WHERE timebestilling_id = " & timebestList(index).timebestilling_id)
            Dim avbestiltTime As String = "Du har nå avbestilt timen din den " & valgtDato & ". Bestill gjerne en ny time."
            MsgBox(avbestiltTime)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub HentTimebestilling_Click(sender As Object, e As EventArgs) Handles HentTimebestilling.Click

        DineTimer.Items.Clear()

        bestilteTimer = sql_sporring("Select * FROM Timebestilling WHERE blodgiver_id = " & innlogget_blodgiver_id & " And er_aktiv = 1")

        For Each rad In bestilteTimer.Rows
            DineTimer.Items.Add("Timedato: " & rad("bestilling_dato") & ", klokken: " & rad("bestilling_tidspunkt"))
            timebestList.Add(New timebestilling(rad("timebestilling_id"), rad("bestilling_dato"), rad("bestilling_tidspunkt"), rad("blodgiver_id"), rad("er_aktiv")))
        Next

    End Sub

End Class