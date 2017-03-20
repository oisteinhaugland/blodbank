Imports System.Text.RegularExpressions

Public Class registrerBlodgiver

    Private Function konverterDatoFormatTilMySql(dato As String) As String
        Dim innskrevetDato As Date = dato
        Return innskrevetDato.ToString("yyyy-MM-dd")
    End Function


    Private Sub registrer_bruker()
        Dim errors = 1
        Dim Fornavn As String = fornavnTextbox.Text
        Dim Etternavn As String = etterNavnTextBox.Text
        Dim TelefonNr As Integer = telefonTextBox.Text 'lag regex som replacer alt annet en tall
        Dim post_nr As Integer = postNrTextBox.Text
        Dim Epost As String = epostTextbox.Text
        Dim Fodselsdato As String
        Dim Adresse As String = adresseTextBox.Text
        Dim Post_sted As String = poststedTextBox.Text
        Dim Passord As String



        If passordTextBox.Text = gjenntaPassordTextbox.Text Then
            Passord = passordTextBox.Text
        Else
            MsgBox("Passordet må gjenntas korrekt. Vennligst fyll inn på nytt.")
            Exit Sub
        End If


        Dim epostFormat As String = "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$"
        Dim email_format_match As Match = Regex.Match((epostTextbox.Text), epostFormat)

        If email_format_match.Success Then
            Dim kolonner As New DataTable
            kolonner = sql_sporring("Select fornavn from Blodgiver where epost ='" & epostTextbox.Text & "'")
            Dim count = 0
            For Each rad In kolonner.Rows
                count += 1
            Next
            If count = 0 Then
                Epost = epostTextbox.Text
            Else
                MsgBox("Eposten er allerede registret. Vennligst fyll inn en ny.")
                Exit Sub
            End If
        Else
            MsgBox("Eposten har feil format. Vennligst fyll inn en epost.")
            Exit Sub
        End If




        Dim Personnummer As Integer
        Dim personnummerformat As String = "^(\d){5}$"
        Dim personnummer_format_match As Match = Regex.Match((personNrTextBox.Text), personnummerformat)

        If personnummer_format_match.Success Then
            Dim kolonner As New DataTable
            kolonner = sql_sporring("Select fornavn from Blodgiver where personnummer =" & personNrTextBox.Text)
            Dim count = 0
            For Each rad In kolonner.Rows
                count += 1
            Next
            If count = 0 Then
                Personnummer = personNrTextBox.Text

            Else
                MsgBox("Du kan ikke registrere deg igjen")
                Exit Sub
            End If
        Else
            MsgBox("Personnummer har feilt format. Fyll inn 5 sifre")
            Exit Sub
        End If





        Dim datoFormat As String = "^(\d){2}\.(\d){2}\.(\d){4}$"
        Dim fodselsdatoformatMatch As Match = Regex.Match((fodselsdatoTextBox.Text), datoFormat)
        If fodselsdatoformatMatch.Success Then
            Dim Fodselsnummer As String = konverterDatoFormatTilMySql(fodselsdatoTextBox.Text)
        Else
            MsgBox("Fødseslsdato Ikke riktig datoformat. Vennligst fyll inn dd.mm.åååå")
            Exit Sub
        End If


        If errors = 0 Then
            Try
                sql_sporring("insert into Blodgiver(fornavn, etternavn, telefon,epost,fodselsdato,adresse,post_nr,post_sted,passord,personnummer)
        values ('" & Fornavn & "',
            '" & Etternavn & "',
            " & TelefonNr & ",
            '" & Epost & "',
             '" & Fodselsdato & "',
            '" & Adresse & "',
            " & post_nr & ",
            '" & Post_sted & "', 
            '" & Passord & "',
            '" & Personnummer & "'
        )")
                Dim registreringsmelding As String = "Takk " & Fornavn & ". Din bruker er nå registrert. Vennligst logg inn med brukernavn (Epost) og passord"
                MsgBox(registreringsmelding)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("feltene er ikke fylt ut korrekt.")
        End If


    End Sub



    Private Sub registrerBrukerKnapp_Click(sender As Object, e As EventArgs) Handles registrerBrukerKnapp.Click
        registrer_bruker()
        'Me.Close()
        'loggInn.Show()
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