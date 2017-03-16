Imports System.Text.RegularExpressions

Public Class registrerBlodgiver

    Private Function konverterDatoFormatTilMySql(dato As String) As String
        Dim innskrevetDato As Date = dato
        Return innskrevetDato.ToString("yyyy-MM-dd")
    End Function


    Private Sub registrer_bruker()
        Dim errors = 0

        Dim Fornavn As String = fornavnTextbox.Text
        Dim Etternavn As String = etterNavnTextBox.Text
        Dim TelefonNr As Integer = telefonTextBox.Text 'lag regex som replacer alt annet en tall
        Dim Epost As String = epostTextbox.Text
        Dim Fodselsdato As String
        Dim Adresse As String = adresseTextBox.Text
        Dim Post_nr As Integer = postNrTextBox.Text
        Dim Post_sted As String = poststedTextBox.Text
        Dim Passord As String

        If passordTextBox.Text = gjenntaPassordTextbox.Text Then
            Passord = passordTextBox.Text
        Else
            MsgBox("Passordet må gjenntas korrekt. Vennligst fyll inn på nytt.")
        End If

        Dim datoFormat As String = "^(\d){2}\.(\d){2}\.(\d){4}$"
        Dim fodselsdatoformatMatch As Match = Regex.Match((fodselsdatoTextBox.Text), datoFormat)
        If fodselsdatoformatMatch.Success Then
            Dim Fodselsnummer As String = konverterDatoFormatTilMySql(fodselsdatoTextBox.Text)
        Else
            MsgBox("Ikke riktig datoformat. Vennligst fyll inn dd.mm.åååå")
        End If


        Try
            sql_sporring("insert into Blodgiver(fornavn, etternavn, telefon,epost,fodselsdato,adresse,post_nr,post_sted,passord)
        values ('" & Fornavn & "',
            '" & Etternavn & "',
            " & TelefonNr & ",
            '" & Epost & "',
             '" & Fodselsdato & "',
            '" & Adresse & "',
            " & Post_nr & ",
            '" & Post_sted & "', 
            '" & Passord & "'
        )")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Dim registreringsmelding As String = "Takk " & Fornavn & ". Din bruker er nå registrert. Vennligst logg inn med brukernavn (Epost) og passord"
            MsgBox(registreringsmelding)
    End Sub



    Private Sub registrerBrukerKnapp_Click(sender As Object, e As EventArgs) Handles registrerBrukerKnapp.Click
        registrer_bruker()
        Me.Close()
        loggInn.Show()
    End Sub





    Private Sub registrerBlodgiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(Date.Today)
        'MsgBox(konverterDatoFormatTilMySql(fodselsdatoTextBox.Text))



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class