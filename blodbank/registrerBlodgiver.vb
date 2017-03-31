Imports System.Text.RegularExpressions

Public Class registrerBlodgiver

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

        If formatSkjekk(epostTextbox.Text, epostFormat) Then
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


        Dim Personnummer As String
        If formatSkjekk(personNrTextBox.Text, personnummerformat) Then
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



        If formatSkjekk(fodselsdatoTextBox.Text, datoFormat) Then
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
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.BackColor = Color.FromArgb(247, 247, 247)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        loggInn.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub postNrTextBox_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles postNrTextBox.KeyPress,
        telefonTextBox.KeyPress, personNrTextBox.KeyPress, fodselsdatoTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub fornavnTextbox_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fornavnTextbox.KeyPress,
        etterNavnTextBox.KeyPress, poststedTextBox.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
End Class




