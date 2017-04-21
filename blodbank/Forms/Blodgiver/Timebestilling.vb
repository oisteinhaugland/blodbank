Public Class Timebestillinger
    Dim timebestList As New List(Of timebestilling)
    Dim bestilteTimer As New DataTable
    Dim ledigeTimer As New DataTable

    Private Sub MinSideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinSideToolStripMenuItem.Click
        MinSide.Show()
        Me.Hide()
    End Sub

    Private Sub EgenerklæringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgenerklæringToolStripMenuItem.Click
        Egenklæring.Show()
        Me.Hide()
    End Sub

    Private Sub blodgiver_timebestilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 255, 255)
        Me.Location = New Point(0, 0)
        Kalender.MinDate = Date.Today
        Kalender.MaxSelectionCount = 1
        bestillKnapp.Enabled = False
        avbestillKnapp.Enabled = False


    End Sub

    Private Sub bestillKnapp_Click(sender As Object, e As EventArgs) Handles bestillKnapp.Click
        Dim datoFormat As String = "dd/MM/yyyy"
        Dim valgtDato = Kalender.SelectionRange.Start.ToString(datoFormat)

        Dim bestillTime As New DataTable
        Dim temp = ListBox2.SelectedItem()
        Dim tidspunkt As Integer
        tidspunkt = IntegertilKlokkeSlett(temp)

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

        bestillKnapp.Enabled = False
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
        avbestillKnapp.Enabled = False
    End Sub

    Private Sub HentTimebestilling_Click(sender As Object, e As EventArgs) Handles HentTimebestilling.Click

        DineTimer.Items.Clear()

        bestilteTimer = sql_sporring("Select * FROM Timebestilling WHERE blodgiver_id = " & innlogget_blodgiver_id & " And er_aktiv = 1")

        For Each rad In bestilteTimer.Rows
            DineTimer.Items.Add("Timedato: " & rad("bestilling_dato") & ", klokken: " & rad("bestilling_tidspunkt"))
            timebestList.Add(New timebestilling(rad("timebestilling_id"), rad("bestilling_dato"), rad("bestilling_tidspunkt"), rad("blodgiver_id"), rad("er_aktiv")))
        Next

    End Sub

    Private Sub Kalender_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Kalender.DateChanged
        timebestillingMetode(Kalender, ListBox2)
        bestillKnapp.Enabled = False
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        bestillKnapp.Enabled = True
    End Sub

    Private Sub DineTimer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DineTimer.SelectedIndexChanged
        avbestillKnapp.Enabled = True
    End Sub

End Class