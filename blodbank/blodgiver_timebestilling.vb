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
        Kalender.MaxSelectionCount = 1

        'Dim test As New DataTable
        'test = sql_sporring("SELECT * FROM Timebestilling Where er_aktiv = 1")
        'Dim testing(test.Rows.Count) As Date

        'Dim enDato As New List(Of Date)

        'For Each rad In test.Rows
        '    enDato.Add(rad("bestilling_dato"))
        'Next

        'MonthCalendar1.BoldedDates = 


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
        Dim temp = ListBox2.SelectedItem()
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

    Private Sub Kalender_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Kalender.DateChanged
        Dim valgtDato As String = konverterDatoFormatTilMySql(Kalender.SelectionRange.Start.ToShortDateString())
        Dim aktiveTimer = sql_sporring("SELECT er_aktiv, bestilling_tidspunkt FROM Timebestilling where bestilling_dato ='" & valgtDato & "' and er_aktiv = 1")

        Dim klokke As Integer = 9
        ListBox2.Items.Clear()
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
                    ListBox2.Items.Add(tidsPunkt)
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
                ListBox2.Items.Add(tidsPunkt)
                klokke += 1
            Next
        End If
    End Sub
End Class