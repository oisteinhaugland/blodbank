'Imports System.Net.Mail
Public Class loggInn

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loggInnKnapp.Click
        Dim tabell As New DataTable
        tabell = selectBlogiver()

        For Each rad In tabell.Rows
            Dim brukernavn = rad("epost")
            Dim passord = rad("passord")
            If brukerNavnTextbox.Text = brukernavn And passordTextBox.Text = passord Then
                innlogget_bruker = brukernavn
                blodgiverMinSide.Show()
                Me.Hide()
            Else
                MsgBox("Feil brukernavn eller passord")
            End If
        Next

    End Sub


    Private Sub registrerBrukerKnapp_Click(sender As Object, e As EventArgs) Handles registrerBrukerKnapp.Click
        registrerBlodgiver.Show()
        Me.Hide()
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