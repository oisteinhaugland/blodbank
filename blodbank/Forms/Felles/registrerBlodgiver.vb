
Imports System.ComponentModel
Imports System.Text.RegularExpressions


Public Class registrerBlodgiver
    Dim hash As New hashtest
    Private Function konverterDatoFormatTilMySql(dato As String) As String
        Dim innskrevetDato As Date = dato
        Return innskrevetDato.ToString("yyyy-MM-dd")
    End Function




    Private Sub registrer_bruker()



        Dim errors = 1
        Dim Fornavn As String = fornavnTextbox.Text
        Dim Etternavn As String = etterNavnTextBox.Text
        Dim post_nr As Integer
        Dim Epost As String = epostTextbox.Text
        Dim Fodselsdato As String
        Dim Adresse As String = adresseTextBox.Text
        Dim Post_sted As String = poststedTextBox.Text
        Dim Passord As String
        Dim TelefonNr As Integer
        Dim salt
        Dim hashedPwd

        If passordTextBox.Text = gjenntaPassordTextbox.Text Then

            salt = hash.CreateRandomSalt()
            hashedPwd = hash.Hash512(passordTextBox.Text, salt)
        Else

            ErrorProvider1.SetError(gjenntaPassordTextbox, "Passordet mÂ gjenntas korrekt. Vennligst fyll inn pÂ nytt.")
            Exit Sub
        End If

        ErrorProvider1.BlinkRate = 0

        Dim telefonformat As String = "\d+"
        Dim telefon_format_match As Match = Regex.Match(telefonTextBox.Text, telefonformat)
        If telefon_format_match.Success Then
            TelefonNr = CInt(telefonTextBox.Text)
        Else
            ErrorProvider1.SetError(telefonTextBox, "Telefonnr mÂ ha minst 8 siffer")

        End If


        Dim postNrformat As String = "^(\d){4}"
        Dim postnr_format_match As Match = Regex.Match(postNrTextBox.Text, postNrformat)
        If postnr_format_match.Success Then
            post_nr = CInt(postNrTextBox.Text)
        Else
            ErrorProvider1.SetError(poststedTextBox, "Postnummer mÂ vÊre 4 tall")
        End If

        Dim poststedFormat As String = "\w+"
        Dim poststed_format_match As Match = Regex.Match(poststedTextBox.Text, poststedFormat)
        If Not poststed_format_match.Success Then
            ErrorProvider1.SetError(poststedTextBox, "Vennligst fyll ut felt")
        End If


        Dim navnFormat As String = "\w+"
        Dim navn_format_match As Match = Regex.Match(fornavnTextbox.Text + etterNavnTextBox.Text, navnFormat)
        If Not navn_format_match.Success Then
            ErrorProvider1.SetError(fornavnTextbox, "Vennligst fyll ut felt")
            ErrorProvider1.SetError(etterNavnTextBox, "Vennligst fyll ut felt")
        End If


        Dim adresseFormat As String = "(\w+)\s(\d+)"
        Dim adresse_format_match As Match = Regex.Match((adresseTextBox.Text), adresseFormat)
        If Not adresse_format_match.Success Then
            ErrorProvider1.SetError(adresseTextBox, "Vennligst fyll ut felt i korrekt format")

        Else
            ErrorProvider1.SetError(adresseTextBox, "")
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
            ErrorProvider1.SetError(epostTextbox, "Eposten har feil format. Vennligst fyll inn en epost.")
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
                ErrorProvider1.SetError(personNrTextBox, "Personnummer har feilt format. Fyll inn 5 sifre")
                Exit Sub

            End If
        End If




        Dim datoFormat As String = "^(\d){2}\.(\d){2}\.(\d){4}$"
        Dim fodselsdatoformatMatch As Match = Regex.Match((fodselsdatoTextBox.Text), datoFormat)
        If fodselsdatoformatMatch.Success Then
            Dim Fodselsnummer As String = konverterDatoFormatTilMySql(fodselsdatoTextBox.Text)
        Else
            ErrorProvider1.SetError(fodselsdatoTextBox, "F¯dseslsdato Ikke riktig datoformat. Vennligst fyll inn dd.mm.ÂÂÂÂ")
            MsgBox("lol")
            Exit Sub
        End If


        ' If errors = 0 Then
        Try
            sql_sporring("insert into Blodgiver(fornavn, etternavn, telefon,epost,fodselsdato,adresse,post_nr,post_sted,salt,hashedPwd,personnummer)
        values ('" & Fornavn & "',
            '" & Etternavn & "',
            " & TelefonNr & ",
            '" & Epost & "',
             '" & Fodselsdato & "',
            '" & Adresse & "',
            " & post_nr & ",
            '" & Post_sted & "', 
            '" & salt & "',
            '" & hashedPwd & "',
            '" & Personnummer & "'
        )")
            Dim registreringsmelding As String = "Takk " & Fornavn & ". Din bruker er nå registrert. Vennligst logg inn med brukernavn (Epost) og passord"
            MsgBox(registreringsmelding)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Else
        MsgBox("feltene er ikke fylt ut korrekt.")
        'End If


    End Sub


    Private Sub registrerBrukerKnapp_Click(sender As Object, e As EventArgs) Handles registrerBrukerKnapp.Click
        registrer_bruker()
        'Me.Close()
        'loggInn.Show()
    End Sub


    Private Sub registrerBlodgiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        loggInn.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub postNrTextBox_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles postNrTextBox.KeyPress,
        telefonTextBox.KeyPress, personNrTextBox.KeyPress, fodselsdatoTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        personNrTextBox.MaxLength = 5
        postNrTextBox.MaxLength = 4

    End Sub

    Private Sub fornavnTextbox_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fornavnTextbox.KeyPress,
        etterNavnTextBox.KeyPress, poststedTextBox.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub



End Class




