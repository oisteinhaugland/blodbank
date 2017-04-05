Public Class blodgiverMinSide

    Public Sub fyllBrukerInformasjon()
        label_innlogget_fornavn.Text = innlogget_bruker
        label_innlogget_fornavn.Text = innlogget_fornavn
        label_innlogget_etternavn.Text = innlogget_etternavn
        label_innlogget_adresse.Text = innlogget_adresse
        label_innlogget_blodtype.Text = innlogget_blodtype
        label_innlogget_fodselsdato.Text = innlogget_fodseldato
        label_innlogget_forrige_blodtapp.Text = innlogget_forrige_blodtapp
        label_innlogget_karantene.Text = innlogget_karantene
        label_innlogget_post_nr.Text = innlogget_post_nr
        label_innlogget_post_sted.Text = innlogget_post_sted
        label_innlogget_telefon.Text = innlogget_telefon
        label_innlogget_kjønn.Text = innlogget_kjønn
    End Sub

    Private Sub blodgiverMinSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.BackColor = Color.FromArgb(247, 247, 247)
        fyllBrukerInformasjon()
    End Sub


    'Navigasjon
    Private Sub TimebestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimebestillingToolStripMenuItem.Click
        blodgiver_timebestilling.Show()
        Me.Hide()
    End Sub

    Private Sub EgenerklæringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgenerklæringToolStripMenuItem.Click
        blodgiver_egenerklering.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loggInn.Show()
        Me.Hide()
        Me.Close()
    End Sub

End Class