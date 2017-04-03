Public Class ansattInnkalling
    Dim ansattInnkallingTable As New DataTable
    Private Sub HjemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HjemToolStripMenuItem.Click
        ansattStartSide.Show()
        Me.Hide()
    End Sub

    Private Sub ProduktoversiktToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktoversiktToolStripMenuItem.Click
        ansattProduktoversikt.Show()
        Me.Hide()
    End Sub

    Private Sub BestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestillingToolStripMenuItem.Click
        ansattBestillinger.Show()
        Me.Hide()
    End Sub

    Private Sub ansattInnkalling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.BackColor = Color.FromArgb(247, 247, 247)



        ansattInnkallingTable = sql_sporring("SELECT * FROM Blodgiver WHERE godkjent_egenerklering = '1'")

        klareBlodgivere.Items.Clear()

        klareBlodgivere.Items.Add("Id" & vbTab & "Fornavn" & vbTab & "Etternavn" & vbTab & Space(2) & "Epost" & vbTab & vbTab & Space(2) & "Telefon" & Space(6) & "Blodtype")
        klareBlodgivere.Items.Add(" ")

        For Each rad In ansattInnkallingTable.Rows
            klareBlodgivere.Items.Add(rad("blodgiver_id") & vbTab & rad("fornavn") & vbTab & rad("etternavn") & vbTab & Space(2) & rad("epost") & vbTab & Space(2) & rad("telefon") & Space(4) & rad("blodtype"))

        Next

    End Sub

    Private Sub blodInfoKnapp_Click(sender As Object, e As EventArgs) Handles blodInfoKnapp.Click

        ansattInnkallingTable = sql_sporring("SELECT * FROM Blodgiver WHERE godkjent_egenerklering = '1'")

        klareBlodgivere.Items.Clear()

        klareBlodgivere.Items.Add("Id" & vbTab & "Fornavn" & vbTab & "Etternavn" & vbTab & Space(2) & "Epost" & vbTab & vbTab & Space(2) & "Telefon" & Space(6) & "Blodtype")
        klareBlodgivere.Items.Add(" ")

        For Each rad In ansattInnkallingTable.Rows
            klareBlodgivere.Items.Add(rad("blodgiver_id") & vbTab & rad("fornavn") & vbTab & rad("etternavn") & vbTab & Space(2) & rad("epost") & vbTab & Space(2) & rad("telefon") & Space(4) & rad("blodtype"))

        Next

    End Sub

    Private Sub normalInnkallingKnapp_Click(sender As Object, e As EventArgs) Handles NormalInnkallingKnapp.Click
        'Dim blodgiver As String = klareBlodgivere.SelectedItem
        'Dim innkallingList As New List(Of String)


        'ansattInnkallingTable = sql_sporring("SELECT * FROM Blodgiver WHERE godkjent_egenerklering = '1'")
        'For Each rad In ansattInnkallingTable.Rows
        '    innkallingList.Add(rad("fornavn") & " " & rad("etternavn"))
        '    MsgBox(innkallingList)
        'Next

        Dim innkallingString As String = klareBlodgivere.SelectedItem
        Dim dato = Me.timeDato.Value.Date.ToString()
        Dim tidspunkt = TidTekst.Text
        dato = Format(timeDato.Value, "dd/mm/yyyy")

        MsgBox(innkallingString & " er innkalt til time hos blodbanken. Timen er " & dato & ", klokken" & tidspunkt & " bekreft ved å trykke ok")

        'MsgBox(blodgiver & " er innkalt til time hos blodbanken. Din time er " & dato & ", klokken " & tidspunkt & ". Vennligst bekreft blabla...")
        ' Sendes på mail
    End Sub

    Private Sub RegisrerBlodgivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisrerBlodgivingToolStripMenuItem.Click
        Me.Hide()
        ansattRegBlodgiving.Show()
    End Sub
End Class