Imports System.ComponentModel

Public Class registrerBlodgiver
    Dim v As New Validering

    Private Sub registrerBlodgiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maksimerer vindu og setter bakgrunsfarge
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 255, 255)

        'Setter begrensninger på tekstfelt
        personNrTextBox.MaxLength = 5
        postNrTextBox.MaxLength = 4
        telefonTextBox.MaxLength = 8
        ErrorProvider1.BlinkRate = 0

        'Midstiller GUI
        Panel4.Left = (Me.ClientSize.Width - Panel4.Width) \ 2
        Panel4.Top = (Me.ClientSize.Height - Panel4.Height) \ 2
    End Sub


    'Overordnet funksjon for å aktivere validering og registrering.
    Private Sub validerSkjemaOgRegistrerBruker()
        Dim validert As Boolean = True
        'Setter alle tekstboksene i fokus, som gjør at valideringen tar sted.
        For Each kontroll As Control In GroupBox1.Controls
            If TypeOf kontroll Is TextBox Then
                kontroll.Focus()
                GetNextControl(kontroll, True).Focus()
            End If
            If ErrorProvider1.GetError(kontroll) <> "" Then
                validert = False
            End If
        Next

        If validert Then
            registrer_bruker()
        Else
            MsgBox("Skjemaet er ikke fylt ut korrekt, vennligst prøv igjen. Hold over utropstegnet for å se detaljer.")
        End If
    End Sub

    'Sub som først skjekker en tekstbox mot et regex og setter en feilmelding hvis det ikke stemmer.
    Private Sub settError(ByRef enTekstbox As TextBox, ByVal etFormat As String, ByVal enFeilmelding As String)
        If Not v.formatSkjekk(enTekstbox.Text, etFormat) Then
            ErrorProvider1.SetError(enTekstbox, enFeilmelding)
        Else
            ErrorProvider1.SetError(enTekstbox, "")
        End If
    End Sub

    'Sub for registrering av bruker, kjøres bare etter skjemaet er format validert.
    Private Sub registrer_bruker()
        Dim hash As New Hash
        Dim forNavn As String = fornavnTextbox.Text
        Dim etterNavn As String = etterNavnTextBox.Text
        Dim ePost As String = epostTextbox.Text
        Dim fodselsDato As String = konverterDatoFormatTilMySql(fodselsdatoTextBox.Text)
        Dim personNr As Integer
        Dim adresse As String = adresseTextBox.Text
        Dim postNr As Integer = CInt(postNrTextBox.Text)
        Dim postSted As String = poststedTextBox.Text
        Dim tlfNr As Integer = CInt(telefonTextBox.Text)
        Dim salt As String = hash.CreateRandomSalt()
        Dim hashetPassord As String = hash.Hash512(passordTextBox.Text, salt)

        'for å skjekke om eposten allerede finnes i databasen
        If v.formatSkjekk(epostTextbox.Text, v.ePostFormat) Then
            Dim kolonner As New DataTable
            kolonner = sql_sporring("Select fornavn from Blodgiver where epost ='" & epostTextbox.Text & "'")
            Dim teller = 0
            For Each rad In kolonner.Rows
                teller += 1
            Next
            If teller = 0 Then
                ePost = epostTextbox.Text
            Else
                MsgBox("Eposten er allerede registret. Vennligst fyll inn en ny.")
                Exit Sub
            End If
        End If

        'for å skjekke om personnummerret allerede finnes i databasen
        If v.formatSkjekk(personNrTextBox.Text, v.personNrFormat) Then
            Dim kolonner As New DataTable
            kolonner = sql_sporring("Select fornavn from Blodgiver where personnummer =" & personNrTextBox.Text)
            Dim teller = 0
            For Each rad In kolonner.Rows
                teller += 1
            Next

            If teller = 0 Then
                personNr = personNrTextBox.Text
            Else
                MsgBox("Du er allerede registrert.")
                Exit Sub
            End If
        End If

        'insert setting. bruker sql_sporring fra tilkoblingsdata modul.
        sql_sporring("insert into Blodgiver(fornavn, etternavn, telefon,epost,fodseldato,adresse,post_nr,post_sted,salt,hashedPwd,personnummer)
        values ('" & forNavn & "',
            '" & etterNavn & "',
            " & tlfNr & ",
            '" & ePost & "',
             '" & fodselsDato & "',
            '" & adresse & "',
            " & postNr & ",
            '" & postSted & "', 
            '" & salt & "',
            '" & hashetPassord & "',
            '" & personNr & "'
        )")

        Dim registreringsmelding As String = "Takk " & forNavn & ". Din bruker er nå registrert. Vennligst logg inn med brukernavn (Epost) og passord"
        MsgBox(registreringsmelding)
        loggInn.Show()
        Me.Close()

    End Sub

    Private Sub registrerBrukerKnapp_Click(sender As Object, e As EventArgs) Handles registrerBrukerKnapp.Click
        validerSkjemaOgRegistrerBruker()
    End Sub

    Private Sub avbrytRegistrering_Click(sender As Object, e As EventArgs) Handles avbrytRegistrering.Click
        loggInn.Show()
        Me.Close()
    End Sub


    '####################################################################
    'VALIDERING
    '####################################################################

    'tillater kun tall'
    Private Sub postNrTextBox_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles postNrTextBox.KeyPress, telefonTextBox.KeyPress, personNrTextBox.KeyPress, fodselsdatoTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' tillater kun bokstaver'
    Private Sub fornavnTextbox_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fornavnTextbox.KeyPress, etterNavnTextBox.KeyPress, poststedTextBox.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Validering for epost'
    Private Sub epostTextbox_Validating(sender As Object, e As CancelEventArgs) Handles epostTextbox.Validating
        settError(epostTextbox, v.ePostFormat, "Vennligst fyll inn din epost. Følg vanlig epost format.")
    End Sub

    Private Sub etternavnTextbox_Validating(sender As Object, e As CancelEventArgs) Handles etterNavnTextBox.Validating
        settError(etterNavnTextBox, v.navnFormat, "Vennligst fyll ut feltet, det må bestå av bokstaver")
    End Sub

    Private Sub fornavnTextbox_Validating(sender As Object, e As CancelEventArgs) Handles fornavnTextbox.Validating
        settError(fornavnTextbox, v.navnFormat, "Vennligst fyll ut feltet.det må bestå av bokstaver")
    End Sub

    'Validering for telefonnr'
    Private Sub telefonTextBox_Validating(sender As Object, e As CancelEventArgs) Handles telefonTextBox.Validating
        settError(telefonTextBox, v.tlfFormat, "Telefonnummer må bestå av 8 siffer")
    End Sub

    'Validering for fodselsdato'
    Private Sub fodselsdatoTextBox_Validating(sender As Object, e As CancelEventArgs) Handles fodselsdatoTextBox.Validating
        settError(fodselsdatoTextBox, v.datoFormat, "Fødseslsdato Ikke riktig datoformat. Vennligst fyll inn dd.mm.åååå")

        Dim innskrevetFodselsDato As Date
        If v.formatSkjekk(fodselsdatoTextBox.Text, v.datoFormat) Then
            Dim edate = fodselsdatoTextBox.Text
            innskrevetFodselsDato = Date.ParseExact(edate, "dd.MM.yyyy",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)
            If innskrevetFodselsDato >= DateAdd(DateInterval.Year, -18, Date.Today) Then
                ErrorProvider1.SetError(fodselsdatoTextBox, "Regitrert fødselsdato er for ung. Du må våre mellom 18 og 65 år.")
            ElseIf innskrevetFodselsDato <= DateAdd(DateInterval.Year, -65, Date.Today) Then
                ErrorProvider1.SetError(fodselsdatoTextBox, "Regitrert fødselsdato er for gammel. Du må våre mellom 18 og 65 år.")
            End If
        End If

    End Sub
    'validering for personnummer
    Private Sub personNrTextBox_Validating(sender As Object, e As CancelEventArgs) Handles personNrTextBox.Validating
        settError(personNrTextBox, v.personNrFormat, "Personnummer har feilt format. Fyll inn 5 sifre")
    End Sub

    'Validering for adresse'
    Private Sub adresseTextBox_Validating(sender As Object, e As CancelEventArgs) Handles adresseTextBox.Validating
        settError(adresseTextBox, v.adresseFormat, "En adresse består av bostaver etterfulgt av et tall")
    End Sub

    'Validering for postnr'
    Private Sub postNrTextBox_Validating(sender As Object, e As CancelEventArgs) Handles postNrTextBox.Validating
        settError(postNrTextBox, v.postNrFormat, "Postnummer består av 4 siffer.")
    End Sub

    'Validering for poststed'
    Private Sub poststedTextBox_Validating(sender As Object, e As CancelEventArgs) Handles poststedTextBox.Validating
        settError(poststedTextBox, v.postStedFormat, "Feltet kan ikke stå tomt. Vennligst fyll ut din Adresse")
    End Sub

    'Validering for passord'
    Private Sub gjenntaPassordTextbox_Validating(sender As Object, e As CancelEventArgs) Handles gjenntaPassordTextbox.Validating
        If gjenntaPassordTextbox.Text = passordTextBox.Text Then
            settError(gjenntaPassordTextbox, v.passordFormat, "Passordet må være minst 8 tegn og inneholde minst en stor og en liten bokstav og ett tall.")
        Else
            settError(gjenntaPassordTextbox, v.passordFormat, "Passordene må være like.")
        End If
    End Sub

    'validering for passord
    Private Sub PassordTextbox_Validating(sender As Object, e As CancelEventArgs) Handles passordTextBox.Validating
        If gjenntaPassordTextbox.Text = passordTextBox.Text Then
            settError(passordTextBox, v.passordFormat, "Passordet må være minst 8 tegn og inneholde minst en stor og en liten bokstav og ett tall.")
        Else
            settError(passordTextBox, v.passordFormat, "Passordene må være like.")
        End If
    End Sub
End Class