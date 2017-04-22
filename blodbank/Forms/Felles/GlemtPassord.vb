Public Class GlemtPassord
    Dim ep As New Epost
    Dim v As New Validering
    Dim hash As New Hash

    Dim ePost = ""
    Dim salt
    Dim midlertidigPassord


    Private Sub GlemtPassord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'maksimerer vindu, setter farge og midstiller gui
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 255, 255)

        box2.Left = ((Me.ClientSize.Width - box2.Width) / 2) + (box2.Width / 2)
        box1.Left = (Me.ClientSize.Width - box1.Width) / 2 - (box3.Width / 2)
        box3.Left = (Me.ClientSize.Width - box3.Width) / 2

        'Hindrer bruker å bruke boksene før de skal.
        box3.Enabled = False
        box2.Enabled = False
    End Sub


    Public Function loggInnGlemtPassord(bruker, pwd)
        Dim glemtPassordBrukerRegistrert As Boolean
        Dim epost = sql_sporring("SELECT * from Blodgiver Where epost ='" & bruker & "' and hashedPwd ='" & pwd & "'")
        If epost.Rows.Count <> 0 Then
            glemtPassordBrukerRegistrert = True
        Else
            glemtPassordBrukerRegistrert = False
        End If

        If glemtPassordBrukerRegistrert Then
            Return True
        Else
            Return False
        End If
    End Function


    'Sender epost med midlertidig passord til bruker.
    Private Sub sendNyttPassordBtn_click(sender As Object, e As EventArgs) Handles sendNyttPassordBtn.Click
        Dim epostSjekk = skrivInnEpostTextBox.Text

        'validering
        If v.formatSkjekk(epostSjekk, v.ePostFormat) Then
            Dim eposter = sql_sporring("SELECT * from Blodgiver where epost ='" & epostSjekk & "'")
            For Each rad In eposter.Rows
                ePost = rad("epost")
            Next

            'hvis en epost ble funnet
            If ePost <> "" Then
                salt = hash.CreateRandomSalt
                midlertidigPassord = hash.Hash512(salt, salt)

                'send epost
                ep.sendEpost(epostSjekk, "Nytt passord - Blodbanken", "Her er ett midlertidig passord for blodbanken. Vennligst logg inn. Du vil bli sendt videre til et skjema der du fyller inn det midlertidige passordet ditt, og registrerer et nytt passord. " & vbCrLf & "Midlertidig passord: " & midlertidigPassord)

                'oppdater db passord og salt
                sql_sporring("Update Blodgiver SET hashedPwd ='" & midlertidigPassord & "'  where epost ='" & ePost & "' ")

                'Bekreftelse.
                MsgBox("Epost sendt til mail adresse.")
                box2.Enabled = True
            End If
        Else
            MsgBox("Ugyldig e-post")
        End If
    End Sub


    Private Sub registrerNyttPassordBtn_click(sender As Object, e As EventArgs) Handles registrerNyttPassordBtn.Click
        'hvis passordet stemmer med format og er likt i begge felter.
        If v.formatSkjekk(nyttPassordTextBox.Text, v.passordFormat) And (nyttPassordTextBox.Text = gjenntaNyttPassord.Text) Then
            Dim nyttSalt = hash.CreateRandomSalt()
            Dim nyttPassord = hash.Hash512(nyttPassordTextBox.Text, nyttSalt)

            sql_sporring("Update Blodgiver SET salt = '" & nyttSalt & "', hashedPwd ='" & nyttPassord & "'  where epost ='" & ePost & "' ")
            MsgBox("Ditt nye passord er nå registret. Du vil nå bli sendt tilbake til start.")
            loggInn.Show()
            Me.Close()
        Else
            MsgBox("Passordet må bestå av: 1 liten bokstav, 1 stor bokstav, 1 tall, 1 tegn og det må være lengre enn 4 tegn.  Begge felter må være lik.")
        End If

    End Sub


    Private Sub loggInnMedNyttPassordBtn_click(sender As Object, e As EventArgs) Handles loggInnMedNyttPassorBtn.Click
        If loggInnGlemtPassord(epostTextBox.Text, midlertidigPassordTextBox.Text) Then
            box3.Enabled = True
        Else
            MsgBox("Det midlertidige passordet stemte ikke, prøv igjen.")
        End If
    End Sub


    'Navigering
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles tilbakeBtn.Click
        loggInn.Show()
        Me.Close()
    End Sub
End Class
