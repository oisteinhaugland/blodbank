Imports System.Net.Mail
Public Class Epost
    Public Sub sendEpost(mottaker, emne, innhold)

        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()
        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("blodbank.gruppe05@gmail.com", "blodbank1234")
        Smtp_Server.Port = 587
        Smtp_Server.EnableSsl = True
        Smtp_Server.Host = "smtp.gmail.com"

        e_mail = New MailMessage()
        e_mail.From = New MailAddress("blodbank.gruppe05@gmail.com")
        e_mail.To.Add(mottaker)
        e_mail.Subject = emne
        e_mail.IsBodyHtml = False
        e_mail.Body = innhold
        Smtp_Server.Send(e_mail)

    End Sub
End Class
