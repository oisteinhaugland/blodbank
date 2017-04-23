Public Class Startside
    Dim dagensTimerListe As New List(Of Timebestilling)
    Dim timeSporring As New DataTable



    Private Sub ansattStartSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maksimerer vindu, setter farge.
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 255, 255)

        'midstiller gui
        guiPanel.Left = (Me.ClientSize.Width - guiPanel.Width) \ 2
        guiPanel.Top = (Me.ClientSize.Height - guiPanel.Height) \ 2

        'tømmer liste
        dagensTimer.Items.Clear()
        Dim dagensDato As Date = Today.Date

        'finner antall timer for dagen, og navnet.
        timeSporring = sql_sporring("SELECT * FROM Timebestilling INNER JOIN Blodgiver ON Timebestilling.blodgiver_id = Blodgiver.blodgiver_id where er_aktiv AND bestilling_dato ='" & konverterDatoFormatTilMySql(Today.Date) & "'ORDER BY bestilling_tidspunkt")
        For Each rad In timeSporring.Rows
            Dim tidsPunkt
            Select Case rad("bestilling_tidspunkt")
                Case 9
                    tidsPunkt = Convert.ToString("09:00")
                Case 10
                    tidsPunkt = Convert.ToString("10:00")
                Case 11
                    tidsPunkt = Convert.ToString("11:00")
                Case 12
                    tidsPunkt = Convert.ToString("12:00")
                Case 13
                    tidsPunkt = Convert.ToString("13:00")
                Case 14
                    tidsPunkt = Convert.ToString("14:00")
                Case 15
                    tidsPunkt = Convert.ToString("15:00")
            End Select
            dagensTimer.Items.Add(rad("fornavn") & " " & rad("etternavn") & vbTab & tidsPunkt)
            dagensTimerListe.Add(New Timebestilling(rad("timebestilling_id"), rad("bestilling_dato"), rad("bestilling_tidspunkt"), rad("blodgiver_id"), rad("er_aktiv")))
        Next

        'setter velkomsttekst og dagens dato.
        Dim velkomst As String = "Velkommen " & innloggetFornavn & " " & innloggetEtternavn & "!"
        LabelVelkommen.Text = velkomst
        LabelDagensDatoTid.Text = Today.Date
    End Sub



    '####################################################################
    'NAVIGASJON
    '####################################################################


    'logger ut
    Private Sub loggUtBtn_click(sender As Object, e As EventArgs) Handles loggUtBtn.Click
        loggInn.Show()
        Me.Close()
        Produktoversikt.Close()
        InnkallingAnsatt.Close()
        Blodgivning.Close()
        Bestillinger.Close()
    End Sub

    Private Sub ProduktoversiktToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktoversiktToolStripMenuItem.Click
        Produktoversikt.Show()
        Me.Hide()
    End Sub


    Private Sub InnkallingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InnkallingToolStripMenuItem.Click
        InnkallingAnsatt.Show()
        Me.Hide()
    End Sub


    Private Sub BestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestillingToolStripMenuItem.Click
        Bestillinger.Show()
        Me.Hide()
    End Sub


    Private Sub RegistrerBlodgivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrerBlodgivingToolStripMenuItem.Click
        Blodgivning.Show()
        Me.Hide()
    End Sub

End Class