Imports System.Net.Mail
Public Class ansattInnkalling
    Dim ansattInnkallingTable As New DataTable
    Dim Norminnkalling As New DataTable


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


    End Sub

    Private Sub blodInfoKnapp_Click(sender As Object, e As EventArgs) Handles blodInfoKnapp.Click



        ansattInnkallingTable = sql_sporring("SELECT * FROM Blodgiver WHERE godkjent_egenerklering = '1'")

        klareBlodgivere.Items.Clear()


        For Each rad In ansattInnkallingTable.Rows
            klareBlodgivere.Items.Add(rad("blodgiver_id") & vbTab & rad("fornavn") & vbTab & rad("etternavn") & vbTab & Space(2) & rad("epost") & vbTab & Space(2) & rad("telefon") & Space(4) & rad("blodtype"))

        Next

    End Sub
    Dim innkallingList As New List(Of Innkalling)
    Private Sub normalInnkallingKnapp_Click(sender As Object, e As EventArgs) Handles NormalInnkallingKnapp.Click


        Norminnkalling = sql_sporring("SELECT blodgiver_id, fornavn, etternavn, epost FROM Blodgiver WHERE godkjent_egenerklering = '1'")

        Dim innkallingString
    For Each rad In Norminnkalling.Rows
            innkallingList.Add(New Innkalling(rad("blodgiver_id"), rad("fornavn"), rad("etternavn"), rad("epost")))

        Next

        'Selecteditem i listbox for å hente ut fornavn, etternavn og epost

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




        If TidTekst.Text = "" Then
                MsgBox("Vennligst skriv inn tidspunkt for timen")
                valLabel.Visible = True
            Else
                valLabel.Visible = False
            MsgBox(innkallingString & " er innkalt til time hos blodbanken." & vbCrLf & "Timen er " & dato & ", klokken: " & tidspunkt & "." & vbCrLf)


        End If


    End Sub

    Private Sub RegisrerBlodgivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisrerBlodgivingToolStripMenuItem.Click
        Me.Hide()
        ansattRegBlodgiving.Show()
    End Sub

    Private Sub HasteInnkallingKnapp_Click(sender As Object, e As EventArgs) Handles HasteInnkallingKnapp.Click

    End Sub
End Class