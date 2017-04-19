Imports System.Text.RegularExpressions
Public Class Blodgivning
    Private Sub HjemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HjemToolStripMenuItem.Click
        Startside.Show()
        Me.Hide()
    End Sub
    Private Sub ansattRegBlodgiving_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.BackColor = Color.FromArgb(247, 247, 247)
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex = 0

    End Sub

    Private Sub ProduktoversiktToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktoversiktToolStripMenuItem.Click
        Produktoversikt.Show()
        Me.Hide()
    End Sub

    Private Sub InnkallingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InnkallingToolStripMenuItem.Click
        ansattInnkalling.Show()
        Me.Hide()
    End Sub



    Private Sub BestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestillingToolStripMenuItem.Click
        Bestillinger.Show()
        Me.Hide()
    End Sub


    Dim blodgiverID As Integer
    Dim blodtype As String
    Dim plasmaMengde As Integer
    Dim blodlegemer As Integer
    Dim blodplater As Integer
    Dim datoTapp As String
    Private Sub registrerBlodInfo()
        Dim v As New Validering

        Dim plasmaHoldbarhet = konverterDatoFormatTilMySql(DateAdd(DateInterval.Day, 365, Today.Date))
        Dim blodplaterHoldbarhet = konverterDatoFormatTilMySql(DateAdd(DateInterval.Day, 7, Today.Date))
        Dim blodlegemerHoldbarhet = konverterDatoFormatTilMySql(DateAdd(DateInterval.Day, 25, Today.Date))


        Dim validert As Boolean = True
        Dim validertDato As Boolean = True
        Dim feilmelding1 = "Registrer feil mengde. Feltet kan ikke stå tomt og kan ikke være større enn 9."
        Dim feilmelding2 = "Datoformatet er ikke riktig. Vennligst følg formatet dd.mm.åååå"
        If v.formatSkjekk(IDtekst.Text, v.blodgiverIdFormat) Then blodgiverID = IDtekst.Text
        Dim blodgiver = sql_sporring("SELECT blodtype_id FROM Blodgiver where blodgiver_id = " & IDtekst.Text)
        Dim blodtype_id
        For Each row In blodgiver.Rows
            blodtype_id = row("blodtype_id")
        Next

        If v.formatSkjekk(plasmaTekst.Text, v.registrerMengdeFormat) Then plasmaMengde = plasmaTekst.Text Else validert = False
        If v.formatSkjekk(blodlegemeTekst.Text, v.registrerMengdeFormat) Then blodlegemer = blodlegemeTekst.Text Else validert = False
        If v.formatSkjekk(blodplateTekst.Text, v.registrerMengdeFormat) Then blodplater = blodplateTekst.Text Else validert = False
        If v.formatSkjekk(TappeDato.Text, v.datoFormat) Then datoTapp = konverterDatoFormatTilMySql(TappeDato.Text) Else validertDato = False




        If validert And validertDato Then

            Dim brukere = sql_sporring("SELECT blodgiver_id FROM Blodgiver ")

            Try
                sql_sporring("INSERT INTO Blodgivning(blodgiver_id, blodlegemer_mengde, blodplater_mengde, plasma_mengde, blodgivning_dato, blodtype_id, ansatt_id)
        values ('" & blodgiverID & "',
               '" & blodlegemer & "',
                '" & blodplater & "',
                '" & plasmaMengde & "',
                '" & datoTapp & "',
                '" & blodtype_id & "' ,
                '" & innlogget_ansatt_id & "' 
                )")

                Dim registrertTapp As String = "Blodtapp for bruker " & blodgiverID & " er nå registrert."
                MsgBox(registrertTapp)
                If plasmaMengde > 0 Then
                    For i = 0 To plasmaMengde - 1
                        sql_sporring("INSERT INTO Blodlager (lager_status, blodtype_id, blodegenskap_id, holdbarhet)
                        values (
                        1,
                        " & blodtype_id & ",
                        '3',
                        '" & plasmaHoldbarhet & "'
                      
                        )")
                    Next
                End If

                If blodplater > 0 Then
                    For i = 0 To blodplater - 1
                        sql_sporring("INSERT INTO Blodlager (lager_status, blodtype_id, blodegenskap_id, holdbarhet)
                        values (
                         1,                        
                        " & blodtype_id & ",
                        2,
                        '" & blodplaterHoldbarhet & "'

                        )")
                    Next
                End If

                If blodlegemer > 0 Then
                    For i = 0 To blodlegemer - 1
                        sql_sporring("INSERT INTO Blodlager (lager_status, blodtype_id, blodegenskap_id, holdbarhet)
                        values (
                        1,                        
                        " & blodtype_id & ",
                        1,
                        '" & blodlegemerHoldbarhet & "'

                        )")
                    Next
                End If




            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf validert And Not validertDato Then
            MsgBox(feilmelding2)
        ElseIf Not validert And validertDato Then
            MsgBox(feilmelding1)
        Else
            MsgBox(feilmelding1)
            MsgBox(feilmelding2)
        End If


    End Sub

    Private Sub LagreBlodtapp_Click(sender As Object, e As EventArgs) Handles LagreBlodtapp.Click
        registrerBlodInfo()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'plasmaHoldbarhet = DateAdd(DateInterval.Day, 365, Today.Date)
        'blodplaterHoldbarhet = DateAdd(DateInterval.Day, 7, Today.Date)
        'blodlegemerHoldbarhet = DateAdd(DateInterval.Day, 25, Today.Date)

        'MsgBox(konverterDatoFormatTilMySql(plasmaHoldbarhet))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id = TextBox1.Text
        Dim blodgiver = sql_sporring("SELECT blodtype_id FROM Blodgiver where blodgiver_id = " & id & " and blodtype_id = NULL")

        Dim blodtype = ComboBox1.SelectedIndex
        Dim b_id
        Select Case blodtype
            Case 0
                b_id = 0
            Case 1
                b_id = 1
            Case 2
                b_id = 2
            Case 3
                b_id = 3
            Case 4
                b_id = 4
            Case 5
                b_id = 5
            Case 6
                b_id = 6
            Case 7
                b_id = 7
        End Select

        If blodgiver.Rows.Count <> 0 Then
            sql_sporring("UPDATE Blodgiver SET blodtype_id = " & b_id & " where blodgiver_id = " & id)
        Else
            MsgBox("blogiver har allerede registrert blodtype")
        End If

    End Sub
End Class