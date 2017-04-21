Public Class GlemtPassord
    Dim ep As New Epost
    Dim v As New Validering

    Dim hash As New Hash

    Dim epost = ""
    Dim salt
    Dim midlertidigPassord

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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loggInn.Show()
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim epostSjekk = TextBox1.Text


        Dim groupbox = GroupBox1
        If v.formatSkjekk(epostSjekk, v.epostFormat) Then
            Dim eposter = sql_sporring("SELECT * from Blodgiver where epost ='" & epostSjekk & "'")
            For Each rad In eposter.Rows
                epost = rad("epost")
            Next

            If epost <> "" Then
                salt = hash.CreateRandomSalt
                midlertidigPassord = hash.Hash512(salt, salt)
                ep.sendEpost(epostSjekk, "Nytt passord - Blodbanken", "Her er ett midlertidig passord for blodbanken. Vennligst logg inn. Du vil bli sendt videre til et skjema der du fyller inn det midlertidige passordet ditt, og registrerer et nytt passord. " & vbCrLf & "Midlertidig passord: " & midlertidigPassord)
                sql_sporring("Update Blodgiver SET hashedPwd ='" & midlertidigPassord & "'  where epost ='" & epost & "' ")
                MsgBox("Epost sendt til mail adresse.")
                GroupBox3.Enabled = True
            End If
        Else
            MsgBox("Ugyldig e-post")
        End If
    End Sub

    Private Sub GlemtPassord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 255, 255)
        Me.Bounds = My.Computer.Screen.WorkingArea
        GroupBox3.Left = (Me.ClientSize.Width - GroupBox2.Width) / 1.35
        GroupBox1.Left = (Me.ClientSize.Width - GroupBox2.Width) / 3.25

        GroupBox2.Left = (Me.ClientSize.Width - GroupBox2.Width) / 2
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If v.formatSkjekk(TextBox2.Text, v.passordFormat) And (TextBox2.Text = TextBox3.Text) Then
            Dim nyttSalt = hash.CreateRandomSalt()
            Dim nyttPassord = hash.Hash512(TextBox2.Text, nyttSalt)

            sql_sporring("Update Blodgiver SET salt = '" & nyttSalt & "', hashedPwd ='" & nyttPassord & "'  where epost ='" & epost & "' ")

            MsgBox("Ditt nye passord er nå registret. Du vil nå bli sendt tilbake til start.")
            loggInn.Show()
            Me.Close()
        Else
            MsgBox("Passordet må bestå av: 1 liten bokstav, 1 stor bokstav, 1 tall, 1 tegn og det må være lengre enn 4 tegn.  Begge felter må være lik.")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If loggInnGlemtPassord(TextBox4.Text, TextBox5.Text) Then
            GroupBox2.Enabled = True
        Else
            MsgBox("Det midlertidige passordet stemte ikke, prøv igjen.")
        End If
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class