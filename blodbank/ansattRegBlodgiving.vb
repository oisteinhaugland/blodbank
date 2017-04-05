Imports System.Text.RegularExpressions
Public Class ansattRegBlodgiving
    Private Sub HjemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HjemToolStripMenuItem.Click
        ansattStartSide.Show()
        Me.Hide()
    End Sub
    Private Sub ansattRegBlodgiving_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.BackColor = Color.FromArgb(247, 247, 247)
        blodTypeBox.SelectedIndex = 0
        blodTypeBox.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub ProduktoversiktToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktoversiktToolStripMenuItem.Click
        ansattProduktoversikt.Show()
        Me.Hide()
    End Sub

    Private Sub InnkallingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InnkallingToolStripMenuItem.Click
        ansattInnkalling.Show()
        Me.Hide()
    End Sub



    Private Sub BestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BestillingToolStripMenuItem.Click
        ansattBestillinger.Show()
        Me.Hide()
    End Sub


    Dim blodgiverID As Integer
    Dim blodtype As String
    Dim plasmaMengde As Integer
    Dim blodlegemer As Integer
    Dim blodplater As Integer
    Dim datoTapp As String
    Private Sub registrerBlodInfo()

        plasmaHoldbarhet = konverterDatoFormatTilMySql(DateAdd(DateInterval.Day, 365, Today.Date))
        blodplaterHoldbarhet = konverterDatoFormatTilMySql(DateAdd(DateInterval.Day, 7, Today.Date))
        blodlegemerHoldbarhet = konverterDatoFormatTilMySql(DateAdd(DateInterval.Day, 25, Today.Date))


        Dim validert As Boolean = True
        Dim validertDato As Boolean = True
        Dim feilmelding1 = "Registrer feil mengde. Feltet kan ikke stå tomt og kan ikke være større enn 9."
        Dim feilmelding2 = "Datoformatet er ikke riktig. Vennligst følg formatet dd.mm.åååå"
        If formatSkjekk(IDtekst.Text, blodgiverIdFormat) Then blodgiverID = IDtekst.Text
        blodtype = blodTypeBox.SelectedIndex
        Dim blodtype_id
        Select Case blodtype
            Case 0
                blodtype_id = 1
            Case 1
                blodtype_id = 2
            Case 2
                blodtype_id = 3
            Case 3
                blodtype_id = 4
            Case 4
                blodtype_id = 5
            Case 5
                blodtype_id = 6
            Case 6
                blodtype_id = 7
            Case 7
                blodtype_id = 8
        End Select


        If formatSkjekk(plasmaTekst.Text, registrerMengdeFormat) Then plasmaMengde = plasmaTekst.Text Else validert = False
        If formatSkjekk(blodlegemeTekst.Text, registrerMengdeFormat) Then blodlegemer = blodlegemeTekst.Text Else validert = False
        If formatSkjekk(blodplateTekst.Text, registrerMengdeFormat) Then blodplater = blodplateTekst.Text Else validert = False
        If formatSkjekk(TappeDato.Text, datoFormat) Then datoTapp = konverterDatoFormatTilMySql(TappeDato.Text) Else validertDato = False

        If validert And validertDato Then
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
        plasmaHoldbarhet = DateAdd(DateInterval.Day, 365, Today.Date)
        blodplaterHoldbarhet = DateAdd(DateInterval.Day, 7, Today.Date)
        blodlegemerHoldbarhet = DateAdd(DateInterval.Day, 25, Today.Date)

        MsgBox(konverterDatoFormatTilMySql(plasmaHoldbarhet))
    End Sub

End Class