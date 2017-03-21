Imports MySql.Data.MySqlClient

'Imports System.Net.Mail

Public Class loggInn
    Public melding_logg_inn_feil As String = "Feil brukernavn eller passord, vennligst prøv igjen."


    Public Function loggInnBlodgiver()
        Dim tabell As New DataTable
        tabell = selectBlogiver()
        Dim loggetInn As Boolean = False

        For Each rad In tabell.Rows
            Dim brukernavn = rad("epost")
            Dim passord = rad("passord")
            Dim fornavn = rad("fornavn")
            Dim etternavn = rad("etternavn")
            Dim adresse = rad("adresse")
            Dim blodgiver_id = rad("blodgiver_id")
            Dim blodtype = rad("blodtype")
            Dim epost = rad("epost")
            Dim fodseldato = rad("fodseldato")
            Dim forrige_blodtapp = rad("forrige_blodtapp")
            Dim godkjent_egenerklering = rad("godkjent_egenerklering")
            Dim karantene = rad("karantene")
            Dim post_nr = rad("post_nr")
            Dim post_sted = rad("post_sted")
            Dim telefon = rad("telefon")
            Dim personnummer = rad("personnummer")

            If brukerNavnTextbox.Text = brukernavn And passordTextBox.Text = passord Then

                innlogget_bruker = brukernavn
                innlogget_fornavn = fornavn
                innlogget_etternavn = etternavn
                innlogget_adresse = adresse
                innlogget_blodgiver_id = blodgiver_id
                'innlogget_blodtype = blodtype
                innlogget_epost = epost
                innlogget_fodseldato = fodseldato
                'innlogget_forrige_blodtapp = forrige_blodtapp
                'innlogget_godkjent_egenerklering = godkjent_egenerklering
                'innlogget_karantene = karantene
                innlogget_post_nr = post_nr
                innlogget_post_sted = post_sted
                innlogget_telefon = telefon
                innlogget_personnummer = personnummer
                loggetInn = True
            End If
        Next

        If loggetInn Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function loggInnAnsatt()
        Dim tabell As New DataTable
        tabell = selectAnsatt()
        Dim loggetInn As Boolean = False

        For Each rad In tabell.Rows
            Dim brukernavn = rad("epost")
            Dim passord = rad("passord")
            'Dim fornavn = rad("fornavn")
            'Dim etternavn = rad("etternavn")
            'Dim adresse = rad("adresse")
            'Dim epost = rad("epost")
            ''Dim fodseldato = rad("fodseldato")
            'Dim post_nr = rad("post_nr")
            'Dim post_sted = rad("post_sted")
            'Dim telefon = rad("telefon")
            'Dim personnummer = rad("personnummer")


            If brukerNavnTextbox.Text = brukernavn And passordTextBox.Text = passord Then
                innlogget_bruker = brukernavn
                'innlogget_fornavn = fornavn
                'innlogget_etternavn = etternavn
                'innlogget_adresse = adresse
                'innlogget_epost = epost
                'innlogget_fodseldato = fodseldato
                'innlogget_post_nr = post_nr
                'innlogget_post_sted = post_sted
                'innlogget_telefon = telefon
                loggetInn = True
            End If
        Next

        If loggetInn Then
            Return True
        Else
            Return False
        End If





    End Function

    Private Sub loggInnKnapp_Click_1(sender As Object, e As EventArgs) Handles loggInnKnapp.Click

        If loggInnBlodgiver() Then
            Me.Hide()
            blodgiverMinSide.Show()
        ElseIf loggInnAnsatt() Then
            Me.Hide()
            ansattStartSide.Show()
        Else
            MsgBox(melding_logg_inn_feil)
        End If
    End Sub



    'sett standar possisjon til topp left.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.BackColor = Color.FromArgb(247, 247, 247)
    End Sub

    'registrer ny blodgiver nagivasjon
    Private Sub registrerBrukerKnapp_Click(sender As Object, e As EventArgs) Handles registrerBrukerKnapp.Click
        registrerBlodgiver.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        hashtest.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        blodgiverMinSide.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        ansattStartSide.Show()
    End Sub
End Class

'<<<<<<< HEAD:blodbank/Form1.vb
''Noratest
''Emilie
'=======
''Vi tester igjen
'>>>>>>> refs/remotes/origin/master:blodbank/loggInn.vb








' funka ikke enda
'Private Sub glemtPassordKnapp_Click(sender As Object, e As EventArgs) Handles glemtPassordKnapp.Click
'    Dim EmailMessage As New MailMessage()
'    Try
'        Dim SmtpServer As New SmtpClient()
'        Dim mail As New MailMessage()
'        SmtpServer.Credentials = New _
'        Net.NetworkCredential("haugland.1193@gmail.com", "edSeiler1917@")
'        SmtpServer.Port = 587
'        SmtpServer.Host = "smtp.gmail.com"
'        mail = New MailMessage()
'        mail.From = New MailAddress("haugland.1193@gmail.com")
'        mail.To.Add("mathias.bytingsvik@gmail.com")
'        mail.Subject = "Test Mail"
'        mail.Body = "This is for testing SMTP mail from GMAIL MATHIAS, du er flink"
'        SmtpServer.Send(mail)
'        MsgBox("mail send")
'    Catch ex As Exception
'        MsgBox(ex.ToString)
'    End Try

'End Sub