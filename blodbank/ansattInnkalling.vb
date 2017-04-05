Imports System.Net.Mail
Public Class ansattInnkalling
    Dim ansattInnkallingTable As New DataTable
    Dim Norminnkalling As New DataTable
    Dim innkallingList As New List(Of Innkalling)


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

        Dim testdata = sql_sporring("SELECT blodgiver_id, fornavn, etternavn, epost, blodtype_id FROM Blodgiver WHERE godkjent_egenerklering = '1'")



    End Sub

    Private Sub blodInfoKnapp_Click(sender As Object, e As EventArgs) Handles blodInfoKnapp.Click
        klareBlodgivere.Items.Clear()
        ansattInnkallingTable = sql_sporring("SELECT * FROM Blodgiver WHERE godkjent_egenerklering = '1'")
        For Each rad In ansattInnkallingTable.Rows

            Dim blodtypeStringInk
            Select Case rad("blodtype_id")
                Case 1
                    blodtypeStringInk = "A+"
                Case 2
                    blodtypeStringInk = "A-"
                Case 3
                    blodtypeStringInk = "B+"
                Case 4
                    blodtypeStringInk = "B-"
                Case 5
                    blodtypeStringInk = "AB+"
                Case 6
                    blodtypeStringInk = "AB-"
                Case 7
                    blodtypeStringInk = "O+"
                Case 8
                    blodtypeStringInk = "O-"
            End Select

            'For Each i In ansattInnkallingTable.Rows
            innkallingList.Add(New Innkalling(rad("blodgiver_id"), rad("fornavn"), rad("etternavn"), rad("epost"), rad("telefon"), rad("blodtype_id")))
            klareBlodgivere.Items.Add(rad("blodgiver_id") & vbTab & rad("fornavn") & vbTab & rad("etternavn") & vbTab & Space(2) & rad("epost") & vbTab & Space(2) & rad("telefon") & Space(4) & blodtypeStringInk)
        Next

    End Sub
    Private Sub normalInnkallingKnapp_Click(sender As Object, e As EventArgs) Handles NormalInnkallingKnapp.Click


        Norminnkalling = sql_sporring("SELECT * FROM Blodgiver WHERE godkjent_egenerklering = '1'")

        Dim innkallingString
        For Each rad In Norminnkalling.Rows
            innkallingList.Add(New Innkalling(rad("blodgiver_id"), rad("fornavn"), rad("etternavn"), rad("epost"), rad("telefon"), rad("blodtype_id")))

        Next

        'Selecteditem i listbox for Â hente ut fornavn, etternavn og epost

        Dim index = klareBlodgivere.SelectedIndex
        innkallingString = innkallingList(index).fornavn & " " & innkallingList(index).etternavn
        Dim innkallingEpost = innkallingList(index).epost
        Dim dato = Me.timeDato.Value.Date.ToString()
        dato = Format(timeDato.Value, "dd/MM/yyyy")
        Dim tidspunkt = TidTekst.Text


        Dim mailTekst As String = "Hei vi melder om innkalling til blodgivertime den " & dato & " kl: " & tidspunkt & ". Gi beskjed dersom du ikke kan komme. " & vbCrLf & vbCrLf & "Med vennlig hilsen" & vbCrLf & vbCrLf & "Blodbanken ved St. Olavs Hospital"

        'Epost funksjonalitet for innkalling

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("blodbank.gruppe05@gmail.com", "blodbank1234")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("blodbank.gruppe05@gmail.com")
            e_mail.To.Add(innkallingEpost)
            e_mail.Subject = "Blodgivertime"
            e_mail.IsBodyHtml = False
            e_mail.Body = (mailTekst)
            Smtp_Server.Send(e_mail)

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try

        MsgBox(innkallingString & " er innkalt til time hos blodbanken." & vbCrLf & "Timen er " & dato & ", klokken: " & tidspunkt & "." & vbCrLf)


    End Sub

    Private Sub RegisrerBlodgivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisrerBlodgivingToolStripMenuItem.Click
        Me.Hide()
        ansattRegBlodgiving.Show()
    End Sub


End Class