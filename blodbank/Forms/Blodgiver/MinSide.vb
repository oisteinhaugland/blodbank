﻿Public Class MinSide
    'Dim b As New loggInn

    Private Sub blodgiverMinSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'maksimer vindu, sett farge og fyll brukerinfo
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 255, 255)
        fyllBrukerInformasjon()

        'midstill gui
        guiPanel.Left = (Me.ClientSize.Width - guiPanel.Width) \ 2
        guiPanel.Top = (Me.ClientSize.Height - guiPanel.Height) \ 2

        'finn antall blodgivninger til bruker.
        Dim antallBlodGivninger
        antallBlodGivninger = sql_sporring("SELECT COUNT(blodgivning_id) as antallblodgivninger FROM Blodgivning INNER JOIN Blodgiver ON Blodgivning.blodgiver_id = Blodgiver.blodgiver_id WHERE Blodgiver.blodgiver_id =" & innlogget_blodgiver_id)
        For Each rad In antallBlodGivninger.Rows
            label_antall_blodgivninger.Text = rad("antallblodgivninger")
        Next
    End Sub


    'sub for utfylling av labels
    Public Sub fyllBrukerInformasjon()
        label_innlogget_fornavn.Text = innlogget_fornavn
        label_innlogget_etternavn.Text = innlogget_etternavn
        label_innlogget_adresse.Text = innlogget_adresse
        label_innlogget_blodtype.Text = konverterBlodtypeTilTekst(innlogget_blodtype)
        label_innlogget_fodselsdato.Text = innlogget_fodseldato
        label_innlogget_forrige_blodtapp.Text = innlogget_forrige_blodtapp
        label_innlogget_post_nr.Text = innlogget_post_nr
        label_innlogget_post_sted.Text = innlogget_post_sted
        label_innlogget_telefon.Text = innlogget_telefon
        label_innlogget_kjønn.Text = innlogget_kjønn
        label_forrige_blodprosent.Text = innlogget_blodprosent & "%"

        If innlogget_karantene = "00:00:00" Then
            label_innlogget_karantene1.Text = "Ingen karantene"
        Else
            label_innlogget_karantene1.Text = innlogget_karantene
        End If
    End Sub


    'Klarer labelene og logg ut.
    Public Sub loggUt()
        label_innlogget_fornavn.Text = ""
        label_innlogget_etternavn.Text = ""
        label_innlogget_adresse.Text = ""
        label_innlogget_fodselsdato.Text = ""
        label_innlogget_forrige_blodtapp.Text = ""
        label_innlogget_karantene1.Text = ""
        label_innlogget_post_nr.Text = ""
        label_innlogget_post_sted.Text = ""
        label_innlogget_telefon.Text = ""
        label_innlogget_kjønn.Text = ""

        loggInn.Show()
        Egenklæring.Close()
        Timebestillinger.Close()
        Me.Close()
    End Sub


    '####################################################################
    'NAVIGASJON
    '####################################################################


    Private Sub TimebestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimebestillingToolStripMenuItem.Click
        Timebestillinger.Show()
        Me.Hide()
    End Sub


    Private Sub EgenerklæringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgenerklæringToolStripMenuItem.Click
        Egenklæring.Show()
        Me.Hide()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loggUtBtn.Click
        loggInn.Show()
        loggUt()
    End Sub


End Class