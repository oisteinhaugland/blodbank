Imports System.Text.RegularExpressions
Public Class Blodgivning

    Private Sub ansattRegBlodgiving_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'maksimer vindu og sett farge
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 255, 255)

        'midstill GUI
        guiPanel.Left = (Me.ClientSize.Width - guiPanel.Width) \ 2
        guiPanel.Top = (Me.ClientSize.Height - guiPanel.Height) \ 2

        'fiks liste
        blodTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        blodTypeComboBox.SelectedIndex = 0

        'validering
        registrerBlodtypeKnapp.Enabled = False
    End Sub

    Dim blodgiverID As Integer
    Dim blodType As String
    Dim plasmaMengde As Integer
    Dim blodLegemer As Integer
    Dim blodPlater As Integer
    Dim datoTapp As String
    Dim blodProsent As Integer


    'registrering av blodInformasjon
    Private Sub registrerBlodInfo()
        Dim v As New Validering

        'hodlbarehet for respektive egenskapet
        Dim plasmaHoldbarhet = konverterDatoFormatTilMySql(DateAdd(DateInterval.Day, 365, Today.Date))
        Dim blodplaterHoldbarhet = konverterDatoFormatTilMySql(DateAdd(DateInterval.Day, 7, Today.Date))
        Dim blodlegemerHoldbarhet = konverterDatoFormatTilMySql(DateAdd(DateInterval.Day, 25, Today.Date))

        Dim validert As Boolean = True
        Dim validertDato As Boolean = True

        'feilmeldinger
        Dim feilmelding1 = "Registrer feil mengde. Feltet kan ikke stå tomt og kan ikke være større enn 9."
        Dim feilmelding2 = "Datoformatet er ikke riktig. Vennligst følg formatet dd.mm.åååå"

        Dim eksistererIdIDB = sql_sporring("SELECT * FROM Blodgiver")
        Dim eksitererId As Boolean = False
        For Each rad In eksistererIdIDB.Rows
            If rad("blodgiver_id") = IDtekst.Text Then
                eksitererId = True
            End If
        Next
        If v.formatSkjekk(IDtekst.Text, v.blodgiverIdFormat) And eksitererId = True Then blodgiverID = IDtekst.Text Else validert = False

        Dim blodgiver = sql_sporring("SELECT blodtype_id FROM Blodgiver where blodgiver_id = '" & IDtekst.Text & "'")
        Dim blodtype_id

        For Each row In blodgiver.Rows
            blodtype_id = row("blodtype_id")
        Next

        If v.formatSkjekk(plasmaTekst.Text, v.registrerMengdeFormat) Then plasmaMengde = plasmaTekst.Text Else validert = False
        If v.formatSkjekk(blodlegemeTekst.Text, v.registrerMengdeFormat) Then blodLegemer = blodlegemeTekst.Text Else validert = False
        If v.formatSkjekk(blodplateTekst.Text, v.registrerMengdeFormat) Then blodPlater = blodplateTekst.Text Else validert = False
        If v.formatSkjekk(TappeDato.Text, v.datoFormat) Then datoTapp = konverterDatoFormatTilMySql(TappeDato.Text) Else validertDato = False
        If v.formatSkjekk(blodprosentTekst.Text, v.registrerBlodprosentFormat) Then blodProsent = blodprosentTekst.Text Else validert = False

        If validert And validertDato Then
            Dim brukere = sql_sporring("SELECT blodgiver_id FROM Blodgiver ")

            Try
                sql_sporring("INSERT INTO Blodgivning(blodgiver_id, blodlegemer_mengde, blodplater_mengde, plasma_mengde, blodgivning_dato, blodtype_id, ansatt_id)
        values ('" & blodgiverID & "',
               '" & blodLegemer & "',
                '" & blodPlater & "',
                '" & plasmaMengde & "',
                '" & datoTapp & "',
                '" & blodtype_id & "' ,
                '" & innloggetAnsattId & "' 
                )")
                sql_sporring("UPDATE Blodgiver SET blodprosent =" & blodProsent & " WHERE blodgiver_id =" & blodgiverID)

                Dim registrertTapp As String = "Blodtapp for bruker " & blodgiverID & " er nå registrert."
                MsgBox(registrertTapp)


                'Hvis plasma mengde er større en 0
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

                'Hvis blodplate mengde er større en 0
                If blodPlater > 0 Then
                    For i = 0 To blodPlater - 1
                        sql_sporring("INSERT INTO Blodlager (lager_status, blodtype_id, blodegenskap_id, holdbarhet)
                        values (
                         1,                        
                        " & blodtype_id & ",
                        2,
                        '" & blodplaterHoldbarhet & "'

                        )")
                    Next
                End If

                'Hvis blodLegemer mengde er større en 0
                If blodLegemer > 0 Then
                    For i = 0 To blodLegemer - 1
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
            'hvis den er validert men ikke har riktig dato.
        ElseIf validert And Not validertDato Then
            MsgBox(feilmelding2)
            'hvis den ikke er validert men har riktig dato
        ElseIf Not validert And validertDato Then
            MsgBox(feilmelding1)

            'hvis den ikke har noen av delene.
        Else
            MsgBox(feilmelding1)
            MsgBox(feilmelding2)
        End If
    End Sub

    'registrer blodtype.
    Private Sub regBlodtype(sender As Object, e As EventArgs) Handles registrerBlodtypeKnapp.Click

        Dim id = bGiverIdTextBox.Text
        Dim blodGiver = sql_sporring("SELECT blodtype_id FROM Blodgiver where blodgiver_id = " & id & " and blodtype_id = NULL")

        Dim blodType = blodTypeComboBox.SelectedIndex
        Dim bId
        Select Case blodType
            Case 0
                bId = 0
            Case 1
                bId = 1
            Case 2
                bId = 2
            Case 3
                bId = 3
            Case 4
                bId = 4
            Case 5
                bId = 5
            Case 6
                bId = 6
            Case 7
                bId = 7
        End Select

        'hvis blodgiver ikke har blodtype
        If blodGiver.Rows.Count <> 0 Then
            sql_sporring("UPDATE Blodgiver SET blodtype_id = " & bId & " where blodgiver_id = " & id)
        Else
            MsgBox("Blodgiver har allerede registrert blodtype")
        End If
    End Sub


    'validering, hindrer brukerer å trykke feil.
    Private Sub bGiverIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles bGiverIdTextBox.TextChanged
        If bGiverIdTextBox.Text <> String.Empty Then
            registrerBlodtypeKnapp.Enabled = True
        Else
            registrerBlodtypeKnapp.Enabled = False
        End If
    End Sub


    'registrer blodatapp
    Private Sub LagreBlodtapp_Click(sender As Object, e As EventArgs) Handles LagreBlodtapp.Click
        registrerBlodInfo()
    End Sub


    '####################################################################
    'NAVIGASJON
    '####################################################################


    Private Sub HjemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HjemToolStripMenuItem.Click
        Startside.Show()
        Me.Hide()
    End Sub


    Private Sub ProduktoversiktToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktoversiktToolStripMenuItem.Click
        Produktoversikt.Show()
        Me.Hide()
    End Sub


    Private Sub InnkallingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InnkallingToolStripMenuItem.Click
        InnkallingAnsatt.Show()
        Me.Hide()
    End Sub


    Private Sub BestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestillingToolStripMenuItem.Click
        Bestillinger.Show()
        Me.Hide()
    End Sub


End Class