Public Class ansattInnkalling
    Private Sub HjemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HjemToolStripMenuItem.Click
        ansattStartSide.Show()
        Me.Hide()
    End Sub

    Private Sub ProduktoversiktToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktoversiktToolStripMenuItem.Click
        ansattProduktoversikt.Show()
        Me.Hide()
    End Sub

    Private Sub BestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestillingToolStripMenuItem.Click
        ansattBestilling.Show()
        Me.Hide()
    End Sub

    Private Sub ansattInnkalling_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub blodInfoKnapp_Click(sender As Object, e As EventArgs) Handles blodInfoKnapp.Click

        Dim ansattInnkallingTable As New DataTable

        ansattInnkallingTable = sql_sporring("SELECT * FROM Blodgiver WHERE godkjent_egenerklering = '1' AND forrige_blodtapp > '1990-04-01'")

        klareBlodgivere.Items.Clear()

        klareBlodgivere.Items.Add("Id" & "  " & "Fornavn" & "  " & "Etternavn" & "  " & "Epost" & "         " & "        Telefon" & "       " & "   Blodtype")
        For Each rad In ansattInnkallingTable.Rows
            klareBlodgivere.Items.Add(rad("blodgiver_id") & "   " & rad("fornavn") & "        " & rad("etternavn") & "     " & rad("epost") & "  " & rad("telefon") & "     " & rad("blodtype"))

        Next

    End Sub

    Private Sub normalInnkallingKnapp_Click(sender As Object, e As EventArgs) Handles NormalInnkallingKnapp.Click

        Dim blodgiver As String = klareBlodgivere.SelectedItem
        Dim dato = Me.timeDato.Value.Date.ToString()
        Dim tidspunkt = TidTekst.Text

        dato = Format(timeDato.Value, "dd/mm/yyyy")

        MsgBox(blodgiver & " er innkalt til time hos blodbanken. Din time er " & dato & ", klokken " & tidspunkt & ". Vennligst bekreft blabla...")
        ' Sendes på mail
    End Sub
End Class