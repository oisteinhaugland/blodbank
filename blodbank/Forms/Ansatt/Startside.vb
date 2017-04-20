Public Class Startside
    Dim dagenstimerList As New List(Of timebestilling)
    Dim timespørring As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        loggInn.Show()
    End Sub

    Private Sub ansattStartSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.BackColor = Color.FromArgb(247, 247, 247)

        dagensTimer.Items.Clear()
        Dim dagensDato As Date = Today.Date

        'timespørring = sql_sporring("SELECT * FROM Timebestilling WHERE er_aktiv = 1 AND bestilling_dato ='" & konverterDatoFormatTilMySql(Today.Date) & "'ORDER BY bestilling_tidspunkt")
        timespørring = sql_sporring("SELECT * FROM Timebestilling INNER JOIN Blodgiver ON Timebestilling.blodgiver_id = Blodgiver.blodgiver_id where er_aktiv AND bestilling_dato ='" & konverterDatoFormatTilMySql(Today.Date) & "'ORDER BY bestilling_tidspunkt")
        For Each rad In timespørring.Rows

            Dim tidspunkt
            Select Case rad("bestilling_tidspunkt")
                Case 9
                    tidspunkt = Convert.ToString("09:00")
                Case 10
                    tidspunkt = Convert.ToString("10:00")
                Case 11
                    tidspunkt = Convert.ToString("11:00")
                Case 12
                    tidspunkt = Convert.ToString("12:00")
                Case 13
                    tidspunkt = Convert.ToString("13:00")
                Case 14
                    tidspunkt = Convert.ToString("14:00")
                Case 15
                    tidspunkt = Convert.ToString("15:00")
            End Select
            dagensTimer.Items.Add(rad("fornavn") & " " & rad("etternavn") & vbTab & tidspunkt)
            dagenstimerList.Add(New timebestilling(rad("timebestilling_id"), rad("bestilling_dato"), rad("bestilling_tidspunkt"), rad("blodgiver_id"), rad("er_aktiv")))
        Next
        Dim velkomst As String = "Velkommen!"
        Label8.Text = velkomst
        Label7.Text = Today.Date


    End Sub

    Private Sub ProduktoversiktToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktoversiktToolStripMenuItem.Click
        Produktoversikt.Show()
        Me.Hide()
    End Sub

    Private Sub InnkallingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InnkallingToolStripMenuItem.Click
        ansattInnkalling.Show()
        Me.Hide()
    End Sub

    Private Sub BestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestillingToolStripMenuItem.Click
        Bestillinger.Show()
        Me.Hide()

    End Sub

    Private Sub RegistrerBlodgivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrerBlodgivingToolStripMenuItem.Click
        Me.Hide()
        Blodgivning.Show()
    End Sub

End Class