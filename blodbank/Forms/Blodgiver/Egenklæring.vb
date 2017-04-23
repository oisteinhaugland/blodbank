Public Class Egenklæring
    Dim sideIndeks = 0
    Dim karanteneTable As New DataTable
    Dim dagensDato As Date
    Dim karantene30 As Boolean
    Dim karantene180 As Boolean
    Dim karantene365 As Boolean
    Dim karantene1 As Boolean
    Dim karanteneList As List(Of Blodgiver)

    Private Sub blodgiver_egenerklering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'maskimerer vindu, setter farge og skruv av send egenerklering knapp.
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 255, 255)
        sendEgenerklering.Enabled = False

        'midstill gui
        guiPanel.Left = (Me.ClientSize.Width - guiPanel.Width) \ 2
        guiPanel.Top = (Me.ClientSize.Height - guiPanel.Height) \ 2

        'hvis du har karantene får du ikke lov til å fylle ut egenerklering.
        If innloggetKarantene > Date.Today Then
            MsgBox("Advarsel: Du har karantene. Du kan ikke fylle ut egenerklæringskjemaet før karantenen er ferdig.")
            egenerkleringTabControl.Enabled = False
        End If

        'Skrur av irrelevante spørsmål.
        Select Case innloggetKjønn
            Case "Mann"
                egenerkleringTabControl.TabPages(6).Enabled = False
            Case "Kvinne"
                egenerkleringTabControl.TabPages(7).Enabled = False
        End Select
    End Sub

    'Funksjon som valider og sender egenerklæring til db hvis den er godkjent
    Private Function validerEgenerkleringOgSendTilDB()
        Dim spmTeller = 0
        Dim tabTeller = 0
        Dim groupBoxTeller = 0
        Dim antallAvhuket = 0
        Dim radioBtn As RadioButton
        Dim radioBtnTag
        Dim tagVerdier As String

        For Each tabb In egenerkleringTabControl.Controls 'for hver tab
            If tabb.Enabled = True Then 'hvis tab er aktiv 
                tabTeller += 1
                For Each ctrl As Control In tabb.Controls 'for hver control
                    If TypeOf ctrl Is GroupBox Then 'hvis controllen er en groupbox
                        groupBoxTeller += 1
                        For Each Panel As Panel In ctrl.Controls ' for hver panel i groupbox
                            spmTeller += 1
                            Dim control As Control
                            For Each control In Panel.Controls.OfType(Of RadioButton) 'for hver radiobutton
                                radioBtn = DirectCast(control, RadioButton)
                                If radioBtn.Checked Then
                                    antallAvhuket += 1
                                    radioBtnTag = radioBtn.Tag
                                    tagVerdier &= radioBtnTag & ","
                                End If
                            Next
                        Next
                    End If
                Next
            End If
        Next


        'hvis du ikke har fylt ut alle spørsmålene, returner false.  
        If antallAvhuket <> spmTeller Then
            Return False
        Else
            tagVerdier = tagVerdier.Substring(0, tagVerdier.Length - 1) 'tar vekk siste komma
            'insert sprøsmålsverdiene til db.
            Select Case innloggetKjønn
                Case "Mann"
                    Try
                        sql_sporring("INSERT INTO egenerklering_spm(blodgiver_id,spm1,spm2,spm3, spm4,spm5,spm6,spm7,spm8,spm9,spm10,spm11,spm12,spm13,spm14,spm15,spm16,spm17,spm18,spm19,spm20,spm21,spm22,spm23,spm24,spm25,spm26,spm27,spm28,spm29,spm30,spm31,spm32,spm33,spm34,spm35,spm36,spm37,spm38,spm39,spm40,spm41,spm42,spm43,spm44,spm49,spm50,spm51,spm52,spm53,spm54,spm55,spm56,spm57,spm58,spm59) VALUES ('" & innloggetBlodgiverId & "'," & tagVerdier & ")")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Case "Kvinne"
                    Try
                        sql_sporring("INSERT INTO egenerklering_spm(blodgiver_id,spm1,spm2,spm3, spm4,spm5,spm6,spm7,spm8,spm9,spm10,spm11,spm12,spm13,spm14,spm15,spm16,spm17,spm18,spm19,spm20,spm21,spm22,spm23,spm24,spm25,spm26,spm27,spm28,spm29,spm30,spm31,spm32,spm33,spm34,spm35,spm36,spm37,spm38,spm39,spm40,spm41,spm42,spm43,spm44,spm45,spm46,spm47,spm48,spm50,spm51,spm52,spm53,spm54,spm55,spm56,spm57,spm58,spm59) VALUES ('" & innloggetBlodgiverId & "'," & tagVerdier & ")")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
            End Select
            Return True
        End If
    End Function


    Private Sub sendEgenerklering_Click(sender As Object, e As EventArgs) Handles sendEgenerklering.Click
        karanteneList = New List(Of Blodgiver)

        'Lager datovariabler som samsvarer med SQL
        Dim dagensDato As Date
        konverterDatoFormatTilMySql(Date.Today)
        dagensDato = Date.Today

        If validerEgenerkleringOgSendTilDB() Then
            MsgBox("Takk for din registrering")
            karanteneList = New List(Of Blodgiver)

            'Karantener
            If RadioButton100.Checked Then
                karantene365 = True
            End If
            If RadioButton16.Checked Or RadioButton4.Checked Or RadioButton48.Checked Then
                karantene30 = True
            End If

            If RadioButton30.Checked Or RadioButton26.Checked Or RadioButton86.Checked Or RadioButton94.Checked Or RadioButton84.Checked Or RadioButton78.Checked Then
                karantene180 = True

            End If

            If RadioButton18.Checked Then
                karantene1 = True
            End If

            karanteneTable = sql_sporring("SELECT * FROM Blodgiver where blodgiver_id = " & innloggetBlodgiverId)
            For Each rad In karanteneTable.Rows

                If karantene1 = True Then
                    sql_sporring("UPDATE Blodgiver SET karantene = '" & konverterDatoFormatTilMySql(dagensDato.AddDays(1)) & "' WHERE blodgiver_id =" & innloggetBlodgiverId)
                End If
                If karantene30 = True Then
                    sql_sporring("UPDATE Blodgiver SET karantene = '" & konverterDatoFormatTilMySql(dagensDato.AddDays(30)) & "' WHERE blodgiver_id =" & innloggetBlodgiverId)
                End If
                If karantene180 = True Then
                    sql_sporring("UPDATE Blodgiver SET karantene = '" & konverterDatoFormatTilMySql(dagensDato.AddDays(180)) & "' WHERE blodgiver_id =" & innloggetBlodgiverId)
                End If
                If karantene365 = True Then
                    sql_sporring("UPDATE Blodgiver SET karantene = '" & konverterDatoFormatTilMySql(dagensDato.AddDays(365)) & "' WHERE blodgiver_id =" & innloggetBlodgiverId)
                End If
            Next
        Else
            MsgBox("Egenerklæringen er ikke fylt ut.")
        End If
    End Sub


    Private Sub bekreftInformasjonCheckBox_click(sender As Object, e As EventArgs) Handles bekreftInformasjonCheckBox.CheckedChanged
        If bekreftInformasjonCheckBox.Checked Then
            sendEgenerklering.Enabled = True
        Else
            sendEgenerklering.Enabled = False
        End If
    End Sub

    Private Sub nestSideBtn_click(sender As Object, e As EventArgs) Handles nestSideBtn.Click
        If sideIndeks <> 9 Then
            sideIndeks += 1
            egenerkleringTabControl.SelectedIndex = sideIndeks
        End If
    End Sub


    Private Sub forrigeSideBtn_click(sender As Object, e As EventArgs) Handles forrigeSideBtn.Click
        If sideIndeks <> 0 Then
            sideIndeks -= 1
            egenerkleringTabControl.SelectedIndex = sideIndeks
        End If
    End Sub


    Private Sub MyTabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles egenerkleringTabControl.SelectedIndexChanged
        sideIndeks = egenerkleringTabControl.SelectedIndex
    End Sub



    '####################################################################
    'NAVIGASJON
    '####################################################################


    Private Sub TimebestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimebestillingToolStripMenuItem.Click
        Timebestillinger.Show()
        Me.Hide()

    End Sub


    Private Sub MinSideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinSideToolStripMenuItem.Click
        MinSide.Show()
        Me.Hide()
    End Sub

End Class