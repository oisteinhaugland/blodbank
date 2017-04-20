Imports System.Net.Mail
<<<<<<< HEAD

Public Class Epost
    Public Sub sendEpost(ByVal mottaker As String, ByVal emne As String, ByVal innhold As String)
=======
Public Class Epost
    Public Sub sendEpost(mottaker, emne, innhold)
>>>>>>> c207d5ac913625f424e3f6322c55e2c091e2a93c

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
