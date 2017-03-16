Public Class registrerBlodgiver

    Private Function konverterDatoFormatTilMySql(dato)
        Dim konvertertdato As Date = konvertertdato.ToString("yyyy-MM-dd")
        Return konvertertdato
    End Function


    Private Sub registrer_bruker()
        Dim Fornavn As String = fornavnTextbox.Text
        Dim Etternavn As String = etterNavnTextBox.Text
        Dim TelefonNr As Integer = telefonTextBox.Text 'lag regex som replacer alt annet en tall
        Dim Epost As String = epostTextbox.Text
        ' Dim Fodselsdato = konverterDatoFormatTilMySql(fodselsdatoTextBox.Text)
        Dim Adresse As String = adresseTextBox.Text
        Dim Post_nr As Integer = postNrTextBox.Text
        Dim Post_sted As String = poststedTextBox.Text
        Dim Passord As String
        If passordTextBox.Text = gjenntaPassordTextbox.Text Then
            Passord = passordTextBox.Text
        Else
            MsgBox("Passordet må gjenntas korrekt. Vennligst fyll inn på nytt.")
        End If

        '" '& 'str_to_date('10-11-1993', '%d-%m-%y'),fodseldato 
        'fodeslsdato er ikke med i insert enda, legg  den til


        Try
            sql_sporring("insert into blodgiver(fornavn, etternavn, telefon,epost,adresse,post_nr,post_sted,passord)
        values (" & Fornavn & ",
            " & Etternavn & ",
            " & TelefonNr & ",
            " & Epost & ",
            " & Adresse & ",
            " & Post_nr & ",
            " & Post_sted & ", 
            " & Passord & "
        )")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub registrerBrukerKnapp_Click(sender As Object, e As EventArgs) Handles registrerBrukerKnapp.Click
        'Dim Fodselsdato As New Date
        'Fodselsdato = fodselsdatoTextBox.Text
        'MsgBox(konverterDatoFormatTilMySql(fodselsdatoTextBox.Text))


        registrer_bruker()
        'Me.Close()
        'loggInn.Show()
    End Sub





    Private Sub registrerBlodgiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class