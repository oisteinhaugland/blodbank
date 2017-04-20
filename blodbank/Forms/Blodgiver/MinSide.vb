Public Class MinSide
    Dim b As New loggInn

    Public Sub loggUt()
        label_innlogget_fornavn.Text = ""
        label_innlogget_etternavn.Text = ""
        label_innlogget_adresse.Text = ""
        label_innlogget_fodselsdato.Text = ""
        label_innlogget_forrige_blodtapp.Text = ""
        label_innlogget_karantene.Text = ""
        label_innlogget_post_nr.Text = ""
        label_innlogget_post_sted.Text = ""
        label_innlogget_telefon.Text = ""
        label_innlogget_kjønn.Text = ""

        Me.Close()
        Egenklæring.Close()
        Timebestillinger.Close()
    End Sub

    Public Sub fyllBrukerInformasjon()
        label_innlogget_fornavn.Text = innlogget_fornavn
        label_innlogget_etternavn.Text = innlogget_etternavn
        label_innlogget_adresse.Text = innlogget_adresse
<<<<<<< HEAD
=======
        label_innlogget_blodtype.Text = konverterBlodtypeTilTekst(innlogget_blodtype)
>>>>>>> c207d5ac913625f424e3f6322c55e2c091e2a93c
        label_innlogget_fodselsdato.Text = innlogget_fodseldato
        label_innlogget_forrige_blodtapp.Text = innlogget_forrige_blodtapp
        label_innlogget_post_nr.Text = innlogget_post_nr
        label_innlogget_post_sted.Text = innlogget_post_sted
        label_innlogget_telefon.Text = innlogget_telefon
        label_innlogget_kjønn.Text = innlogget_kjønn
<<<<<<< HEAD

        If innlogget_karantene = "00:00:00" Then
            label_innlogget_karantene.Text = "Ingen karantene"
        Else
            label_innlogget_karantene.Text = innlogget_karantene
        End If

        'label_innlogget_fornavn.Text = b.aktivBruker(0).hentBgID
        'label_innlogget_fornavn.Text = b.aktivBruker(0).hentfNavn
        'label_innlogget_etternavn.Text = b.aktivBruker(0).hentENavn
        'label_innlogget_adresse.Text = b.aktivBruker(0).hentAdresse
        'label_innlogget_fodselsdato.Text = b.aktivBruker(0).hentfDato
        'label_innlogget_forrige_blodtapp.Text = b.aktivBruker(0).hentfBlodtapp
        'label_innlogget_karantene.Text = b.aktivBruker(0).hentKarantene
        'label_innlogget_post_nr.Text = b.aktivBruker(0).hentpNr
        'label_innlogget_post_sted.Text = b.aktivBruker(0).hentpSted
        'label_innlogget_telefon.Text = b.aktivBruker(0).hentTlf
        'label_innlogget_kjønn.Text = b.aktivBruker(0).hentKjønn

        Dim blodtype As String
        Select Case innlogget_blodtype
            Case 1
                blodtype = "A+"
            Case 2
                blodtype = "A-"
            Case 3
                blodtype = "B+"
            Case 4
                blodtype = "B-"
            Case 5
                blodtype = "AB+"
            Case 6
                blodtype = "AB-"
            Case 7
                blodtype = "O+"
            Case 8
                blodtype = "O-"

        End Select
        label_innlogget_blodtype.Text = blodtype
=======
        label_forrige_blodprosent.Text = innlogget_blodprosent & "%"

>>>>>>> c207d5ac913625f424e3f6322c55e2c091e2a93c
    End Sub

    Private Sub blodgiverMinSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 255, 255)
        Me.Location = New Point(0, 0)
        fyllBrukerInformasjon()
        Dim antBivninger
        antBivninger = sql_sporring("SELECT COUNT(blodgivning_id) as antallblodgivninger FROM Blodgivning INNER JOIN Blodgiver ON Blodgivning.blodgiver_id = Blodgiver.blodgiver_id WHERE Blodgiver.blodgiver_id =" & innlogget_blodgiver_id)

        For Each rad In antBivninger.Rows
            label_antall_blodgivninger.Text = rad("antallblodgivninger")
        Next

    End Sub

    'Navigasjon
    Private Sub TimebestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimebestillingToolStripMenuItem.Click
        Timebestillinger.Show()
        Me.Hide()
    End Sub

    Private Sub EgenerklæringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgenerklæringToolStripMenuItem.Click
        Egenklæring.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loggInn.Show()
        loggUt()
    End Sub
End Class