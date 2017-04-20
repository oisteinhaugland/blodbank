Imports System.ComponentModel

Public Class registrerBlodgiver
    Dim v As New Validering

    Private Sub registrerBlodgiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(247, 247, 247)
        personNrTextBox.MaxLength = 5
        postNrTextBox.MaxLength = 4
        telefonTextBox.MaxLength = 8
        ErrorProvider1.BlinkRate = 0
    End Sub


    'overordnet funksjon for å aktivere validering og registrering.
    Private Sub validerSkjemaOgRegistrerBruker()
        Dim validert As Boolean = True
        'Setter alle tekstboksene i fokus, som gjør at valideringen tar sted.
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Focus()
                GetNextControl(control, True).Focus()
            End If
            If ErrorProvider1.GetError(control) <> "" Then
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
    Private Sub setError(ByRef enTekstbox As TextBox, ByVal etFormat As String, ByVal enFeilmelding As String)
        If Not v.formatSkjekk(enTekstbox.Text, etFormat) Then 'navn_format_match.Success Then
            ErrorProvider1.SetError(enTekstbox, enFeilmelding)
        Else
            ErrorProvider1.SetError(enTekstbox, "")
        End If
    End Sub

    Private Sub registrer_bruker()
        Dim Hash As New Hash
        Dim Fornavn As String = fornavnTextbox.Text
        Dim Etternavn As String = etterNavnTextBox.Text
        Dim Epost As String = epostTextbox.Text
        Dim FodselsDato As String = konverterDatoFormatTilMySql(fodselsdatoTextBox.Text)
        Dim PersonNr As Integer
        Dim Adresse As String = adresseTextBox.Text
        Dim PostNr As Integer = CInt(postNrTextBox.Text)
        Dim PostSted As String = poststedTextBox.Text
        Dim TelefonNr As Integer = CInt(telefonTextBox.Text)
        Dim salt As String = Hash.CreateRandomSalt()
        Dim hashedPwd As String = Hash.Hash512(passordTextBox.Text, salt)

        'for å skjekke om eposten allerede finnes i databasen
        If v.formatSkjekk(epostTextbox.Text, v.epostFormat) Then
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
        End If

        'for å skjekke om personnummerret allerede finnes i databasen
        If v.formatSkjekk(personNrTextBox.Text, v.personnummerFormat) Then
            Dim kolonner As New DataTable
            kolonner = sql_sporring("Select fornavn from Blodgiver where personnummer =" & personNrTextBox.Text)
            Dim count = 0
            For Each rad In kolonner.Rows
                count += 1
            Next

            If count = 0 Then
                PersonNr = personNrTextBox.Text
            Else
                MsgBox("Du er allerede registrert.")
                Exit Sub
            End If
        End If


        Try
            sql_sporring("insert into Blodgiver(fornavn, etternavn, telefon,epost,fodseldato,adresse,post_nr,post_sted,salt,hashedPwd,personnummer)
        values ('" & Fornavn & "',
            '" & Etternavn & "',
            " & TelefonNr & ",
            '" & Epost & "',
             '" & FodselsDato & "',
            '" & Adresse & "',
            " & PostNr & ",
            '" & PostSted & "', 
            '" & salt & "',
            '" & hashedPwd & "',
            '" & PersonNr & "'
        )")
            Dim registreringsmelding As String = "Takk " & Fornavn & ". Din bruker er nå registrert. Vennligst logg inn med brukernavn (Epost) og passord"
            MsgBox(registreringsmelding)
            loggInn.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub registrerBrukerKnapp_Click(sender As Object, e As EventArgs) Handles registrerBrukerKnapp.Click
        validerSkjemaOgRegistrerBruker()
    End Sub

    Private Sub avbrytReg(sender As Object, e As EventArgs) Handles avbrytRegistrering.Click
        loggInn.Show()
        Me.Close()
    End Sub

    'S¯rger for at tekstboks kun tillater tall'
    Private Sub postNrTextBox_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles postNrTextBox.KeyPress, telefonTextBox.KeyPress, personNrTextBox.KeyPress, fodselsdatoTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'S¯rger for at tekstboks kun tillater bokstaver'
    Private Sub fornavnTextbox_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fornavnTextbox.KeyPress, etterNavnTextBox.KeyPress, poststedTextBox.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    'Validering for epost'

    Private Sub epostTextbox_Validating(sender As Object, e As CancelEventArgs) Handles epostTextbox.Validating
        setError(epostTextbox, v.epostFormat, "Vennligst fyll inn din epost. Følg vanlig epost format.")
    End Sub

    Private Sub etternavnTextbox_Validating(sender As Object, e As CancelEventArgs) Handles etterNavnTextBox.Validating
        setError(etterNavnTextBox, v.navnFormat, "Vennligst fyll ut feltet, det må bestå av bokstaver")
    End Sub

    Private Sub fornavnTextbox_Validating(sender As Object, e As CancelEventArgs) Handles fornavnTextbox.Validating
        setError(fornavnTextbox, v.navnFormat, "Vennligst fyll ut feltet.det må bestå av bokstaver")
    End Sub

    'Validering for telefonnr'
    Private Sub telefonTextBox_Validating(sender As Object, e As CancelEventArgs) Handles telefonTextBox.Validating
        setError(telefonTextBox, v.telefonformat, "Telefonnummer må bestå av 8 siffer")
    End Sub

    'Validering for f¯dselsdato'
    Private Sub fodselsdatoTextBox_Validating(sender As Object, e As CancelEventArgs) Handles fodselsdatoTextBox.Validating
        setError(fodselsdatoTextBox, v.datoFormat, "Fødseslsdato Ikke riktig datoformat. Vennligst fyll inn dd.mm.åååå")

        Dim expenddt As Date
        If v.formatSkjekk(fodselsdatoTextBox.Text, v.datoFormat) Then
            Dim edate = fodselsdatoTextBox.Text
            expenddt = Date.ParseExact(edate, "dd.MM.yyyy",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)
            If expenddt >= DateAdd(DateInterval.Year, -18, Date.Today) Then
                ErrorProvider1.SetError(fodselsdatoTextBox, "Regitrert fødselsdato er for ung. Du må våre mellom 18 og 65 år.")
            ElseIf expenddt <= DateAdd(DateInterval.Year, -65, Date.Today) Then
                ErrorProvider1.SetError(fodselsdatoTextBox, "Regitrert fødselsdato er for gammel. Du må våre mellom 18 og 65 år.")
            End If
        End If

    End Sub
    'validering for personnummer
    Private Sub personNrTextBox_Validating(sender As Object, e As CancelEventArgs) Handles personNrTextBox.Validating
        setError(personNrTextBox, v.personnummerFormat, "Personnummer har feilt format. Fyll inn 5 sifre")
    End Sub

    'Validering for adresse'
    Private Sub adresseTextBox_Validating(sender As Object, e As CancelEventArgs) Handles adresseTextBox.Validating
        setError(adresseTextBox, v.adresseFormat, "En adresse består av bostaver etterfulgt av et tall")
    End Sub

    'Validering for postnr'
    Private Sub postNrTextBox_Validating(sender As Object, e As CancelEventArgs) Handles postNrTextBox.Validating
        setError(postNrTextBox, v.postNrformat, "Postnummer består av 4 siffer.")
    End Sub

    'Validering for poststed'
    Private Sub poststedTextBox_Validating(sender As Object, e As CancelEventArgs) Handles poststedTextBox.Validating
        setError(poststedTextBox, v.poststedFormat, "Feltet kan ikke stå tomt. Vennligst fyll ut din Adresse")
    End Sub

    'Validering for passord'
    Private Sub gjenntaPassordTextbox_Validating(sender As Object, e As CancelEventArgs) Handles gjenntaPassordTextbox.Validating
        If gjenntaPassordTextbox.Text = passordTextBox.Text Then
            setError(gjenntaPassordTextbox, v.passordFormat, "Passordet må være minst 8 tegn og inneholde minst en stor og en liten bokstav og ett tall.")
        Else
            setError(gjenntaPassordTextbox, v.passordFormat, "Passordene må være like.")
        End If
    End Sub

    Private Sub PassordTextbox_Validating(sender As Object, e As CancelEventArgs) Handles passordTextBox.Validating
        If gjenntaPassordTextbox.Text = passordTextBox.Text Then
            setError(passordTextBox, v.passordFormat, "Passordet må være minst 8 tegn og inneholde minst en stor og en liten bokstav og ett tall.")
        Else
            setError(passordTextBox, v.passordFormat, "Passordene må være like.")
        End If
    End Sub
End Class