Imports MySql.Data.MySqlClient

Imports System.Net.Mail


Public Class loggInn

    'Tilkoblingsinformasjon til phpMyAdmin Konto team 5
    Private team_passord As String = "M2oHUQ17"
    Private team_brukernavn As String = "g_oops_05"
    Private tjener_navn As String = "mysql.stud.iie.ntnu.no"
    Private db_tilkobling_str As String
    Private db_oppkobling As New MySqlConnection

    'Funksjon for å kjøre SQL spørringer
    Private Function sql_sporring(ByRef sql As String) As DataTable
        Dim data_tabell As New DataTable

        Try
            db_oppkobling.Open()
            Dim sql_kommando As New MySqlCommand(sql, db_oppkobling)
            Dim data_adapter As New MySqlDataAdapter

            data_adapter.SelectCommand = sql_kommando
            data_adapter.Fill(data_tabell)

            db_oppkobling.Close()
        Catch ex As MySqlException
            MessageBox.Show("goofed: " & ex.Message)
            db_oppkobling.Close()
        End Try

        Return data_tabell

    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'String for å koble seg til phpMyAdmin
        db_tilkobling_str = "Server=" & tjener_navn & ";" &
                            "Database=" & team_brukernavn & ";" &
                            "Uid=" & team_brukernavn & ";" &
                            "Pwd=" & team_passord & ";"

        db_oppkobling.ConnectionString = db_tilkobling_str
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loggInnKnapp.Click
        sql_sporring("CREATE TABLE Person (Id int, Fornavn char(25), Etternavn char(25), mail char(25))")
    End Sub


    Private Sub registrerBrukerKnapp_Click(sender As Object, e As EventArgs) Handles registrerBrukerKnapp.Click
        Me.Hide()
        registrerBlodgiver.Show()
    End Sub


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
End Class
'Vi tester igjen
