Public Class Bestillinger
    Dim bestillinger As List(Of Bestillingsinfo)
    Dim enheterPåLager As List(Of Lager)
    Dim bestillTable As New DataTable
    Dim enhetTable As New DataTable


    Private Sub AnsattBestillinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'maskimerer og setter farge.
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 255, 255)

        'midstiller GUI
        guiPanel.Left = (Me.ClientSize.Width - guiPanel.Width) \ 2
        guiPanel.Top = (Me.ClientSize.Height - guiPanel.Height) \ 2

        utleveringLabel.Hide()
        motatteBestillinger.Items.Clear() '
        vareLagerListBox.SelectedIndex = -1

        bekreft_Utlevering.Enabled = False
        søkLagerBtn.Enabled = False


    End Sub


    Private Sub hentBestillinger_click(sender As Object, e As EventArgs) Handles hentBestillinger.Click

        'Oppdater knapp for å se innkommende bestillinger
        motatteBestillinger.Items.Clear()

        'hent aktive bestillinger
        bestillTable = sql_sporring("SELECT * FROM Blod_bestillinger WHERE behandlet = 0")

        Dim teller = 0
        bestillinger = New List(Of Bestillingsinfo)


        For Each rad In bestillTable.Rows

            Dim blodEgenskapString = konverterBlodEgenskapTilTekst(rad("blodegenskap_id"))
            Dim blodTypeStringBest = konverterBlodtypeTilTekst(rad("blod_type"))

            motatteBestillinger.Items.Add(rad("blodbestilling_id") & vbTab & vbTab & blodEgenskapString & vbTab & vbTab & blodTypeStringBest & vbTab & vbTab & rad("blod_mengde") & vbTab & vbTab & rad("ordre_dato"))
            bestillinger.Add(New Bestillingsinfo(rad("blodbestilling_id"), rad("blodegenskap_id"), rad("blod_mengde"), rad("ordre_dato"), rad("behandlet"), rad("blod_type")))

        Next

        'aktiver søk lager.
        søkLagerBtn.Enabled = True
    End Sub


    Private Sub bekreft_Utlevering_Click(sender As Object, e As EventArgs) Handles bekreft_Utlevering.Click

        For i = 0 To bestillinger.Count - 1 'for hver bestilling

            For indeks = 0 To enheterPåLager.Count - 1 'for hver av de tilgjengelige enhetene på lager
                If enheterPåLager(indeks).hentBlodType = bestillinger(i).blod_type And enheterPåLager(indeks).hentBlogenskap = bestillinger(i).blod_egenskap Then
                    bestillinger(i).antall_enheter_behandlet += 1
                End If
                sql_sporring("UPDATE Blodlager SET lager_status = 0 WHERE Blodlager.enhet_id =" & enheterPåLager(indeks).hentId)

            Next

            'Kode for endring i lagermengde ved utlevering
            bestillinger(i).ny_blod_mengde = bestillinger(i).ny_mengde(bestillinger(i).blod_mengde, bestillinger(i).antall_enheter_behandlet)

            If bestillinger(i).antall_enheter_behandlet = bestillinger(i).blod_mengde Then
                sql_sporring("UPDATE Blod_bestillinger
                SET behandlet = 1
                WHERE blodbestilling_id =" & bestillinger(i).blod_bestillings_id)
            Else
                sql_sporring("UPDATE Blod_bestillinger
                SET blod_mengde = " & bestillinger(i).ny_blod_mengde & "
                WHERE blodbestilling_id =" & bestillinger(i).blod_bestillings_id)
            End If
        Next

        motatteBestillinger.Items.Clear()
        utleveringLabel.Visible = True

        utleveringLabel.Show()

        søkLagerBtn.Enabled = False
        bekreft_Utlevering.Enabled = False

    End Sub

    'Søk lager
    Private Sub søkLagerBtn_Click(sender As Object, e As EventArgs) Handles søkLagerBtn.Click

        vareLagerListBox.Items.Clear()
        enheterPåLager = New List(Of Lager)

        'for hver bestilling
        For i = 0 To bestillinger.Count - 1
            enhetTable = sql_sporring("SELECT * FROM Blodlager where lager_status = 1 AND blodtype_id =" & bestillinger(i).blod_type & " and blodegenskap_id =" & bestillinger(i).blod_egenskap & " and holdbarhet >='" & konverterDatoFormatTilMySql(Date.Today).ToString & "' LIMIT " & bestillinger(i).blod_mengde)

            For Each rad In enhetTable.Rows
                enheterPåLager.Add(New Lager(rad("enhet_id"), rad("blodegenskap_id"), rad("blodtype_id")))

                'Bruker funksjoner for blodtype- og blodegenskapskonvertering [Tilkoblingsdata.vb]
                Dim blodtypeString = konverterBlodtypeTilTekst(rad("blodtype_id"))
                Dim blodegString = konverterBlodEgenskapTilTekst(rad("blodegenskap_id"))
                Dim enhet As String = rad("enhet_id") & "  " & blodtypeString & vbTab & vbTab & blodegString
                vareLagerListBox.Items.Add(enhet)

            Next
        Next

        bekreft_Utlevering.Enabled = True
    End Sub


    '####################################################################
    'NAVIGASJON
    '####################################################################


    Private Sub RegistrerBlodgivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrerBlodgivingToolStripMenuItem.Click
        Blodgivning.Show()
        Me.Hide()
    End Sub
    Private Sub InnkallingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InnkallingToolStripMenuItem.Click
        InnkallingAnsatt.Show()
        Me.Hide()
    End Sub

    Private Sub ProduktoversiktToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktoversiktToolStripMenuItem.Click
        Produktoversikt.Show()
        Me.Hide()
    End Sub

    Private Sub HjemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HjemToolStripMenuItem.Click
        Startside.Show()
        Me.Hide()
    End Sub

End Class