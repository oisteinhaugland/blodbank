Public Class blodgiver_egenerklering
    'Varibel for navigering av tabsider
    Dim sideIndeks = 0


    'Funksjon som valider og sender egenerklæring til db hvis den er godkjent
    Private Function validerEgenerkleringOgSendTilDB()
        Dim spmcounter = 0                'Variabel for telling       
        Dim tabcounter = 0                'Variabel for telling       
        Dim groupboxcounter = 0           'Variabel for telling       
        Dim antallchecekd = 0             'Variabel for telling       
        Dim radiobtn As RadioButton       'Variabel for telling       
        Dim radiobtnTag
        Dim tagVerdier As String

        For Each tabb In egenerkleringTabControl.Controls 'for hver tab
            If tabb.Enabled = True Then 'hvis tab er aktiv 
                tabcounter += 1
                For Each ctrl As Control In tabb.Controls 'for hver control
                    If TypeOf ctrl Is GroupBox Then 'hvis controllen er en groupbox
                        groupboxcounter += 1
                        For Each Panel As Panel In ctrl.Controls ' for hver panel i groupbox
                            spmcounter += 1
                            Dim control As Control
                            For Each control In Panel.Controls.OfType(Of RadioButton)
                                radiobtn = DirectCast(control, RadioButton)
                                If radiobtn.Checked Then
                                    antallchecekd += 1
                                    radiobtnTag = radiobtn.Tag
                                    tagVerdier &= radiobtnTag & ","
                                End If
                            Next
                        Next
                    End If
                Next
            End If
        Next

        'Dim check = "Antall tabs: " & tabcounter & vbCrLf & "Antall spm: " & spmcounter & vbCrLf & "Antall Groupboxes: " & groupboxcounter & vbCrLf & "Antall spm checked: " & antallchecekd


        MsgBox(tagVerdier)

        If antallchecekd <> spmcounter Then
            Return False
        Else
            tagVerdier = tagVerdier.Substring(0, tagVerdier.Length - 1) 'tar vekk siste komma

            Select Case innlogget_kjønn
                Case "Mann"
                    Try
                        sql_sporring("INSERT INTO egenerklering_spm(bruker_id,spm1,spm2,spm3, spm4,spm5,spm6,spm7,spm8,spm9,spm10,spm11,spm12,spm13,spm14,spm15,spm16,spm17,spm18,spm19,spm20,spm21,spm22,spm23,spm24,spm25,spm26,spm27,spm28,spm29,spm30,spm31,spm32,spm33,spm34,spm35,spm36,spm37,spm38,spm39,spm40,spm41,spm42,spm43,spm44,spm49,spm50,spm51,spm52,spm53,spm54,spm55,spm56,spm57,spm58,spm59) VALUES ('" & innlogget_blodgiver_id & "'," & tagVerdier & ")")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Case "Kvinne"
                    Try
                        sql_sporring("INSERT INTO egenerklering_spm(bruker_id,spm1,spm2,spm3, spm4,spm5,spm6,spm7,spm8,spm9,spm10,spm11,spm12,spm13,spm14,spm15,spm16,spm17,spm18,spm19,spm20,spm21,spm22,spm23,spm24,spm25,spm26,spm27,spm28,spm29,spm30,spm31,spm32,spm33,spm34,spm35,spm36,spm37,spm38,spm39,spm40,spm41,spm42,spm43,spm44,spm45,spm46,spm47,spm48,spm50,spm51,spm52,spm53,spm54,spm55,spm56,spm57,spm58,spm59) VALUES ('" & innlogget_blodgiver_id & "'," & tagVerdier & ")")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
            End Select
            Return True
        End If
    End Function



    Private Sub sendEgenerklering_Click_1(sender As Object, e As EventArgs) Handles sendEgenerklering.Click
        If validerEgenerkleringOgSendTilDB() Then
            MsgBox("Takk for din registrering")
        Else
            MsgBox("Egenerklæringen er ikke fylt ut.")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If sideIndeks <> 9 Then
            sideIndeks += 1
            egenerkleringTabControl.SelectedIndex = sideIndeks
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            sendEgenerklering.Enabled = True
        Else
            sendEgenerklering.Enabled = False
        End If
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If sideIndeks <> 0 Then
            sideIndeks -= 1
            egenerkleringTabControl.SelectedIndex = sideIndeks
        End If
    End Sub

    Private Sub MyTabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles egenerkleringTabControl.SelectedIndexChanged
        sideIndeks = egenerkleringTabControl.SelectedIndex
    End Sub

    Private Sub TimebestillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimebestillingToolStripMenuItem.Click
        blodgiver_timebestilling.Show()
        Me.Hide()

    End Sub

    Private Sub MinSideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinSideToolStripMenuItem.Click
        blodgiverMinSide.Show()
        Me.Hide()
    End Sub

    Private Sub blodgiver_egenerklering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.BackColor = Color.FromArgb(247, 247, 247)
        sendEgenerklering.Enabled = False

        Select Case innlogget_kjønn
            Case "Mann"
                egenerkleringTabControl.TabPages(6).Enabled = False
            Case "Kvinne"
                egenerkleringTabControl.TabPages(7).Enabled = False
        End Select
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'autofyll
        Dim spmcounter = 0                'Variabel for telling       
        Dim tabcounter = 0                'Variabel for telling       
        Dim groupboxcounter = 0           'Variabel for telling       
        Dim antallchecekd = 0             'Variabel for telling       
        Dim radiobtn As RadioButton       'Variabel for telling       
        Dim radiobtnTag
        Dim tagVerdier As String
        For Each tabb In egenerkleringTabControl.Controls 'for hver tab
            If tabb.Enabled = True Then 'hvis tab er aktiv 
                tabcounter += 1
                For Each ctrl As Control In tabb.Controls 'for hver control
                    If TypeOf ctrl Is GroupBox Then 'hvis controllen er en groupbox
                        groupboxcounter += 1
                        For Each panel As Panel In ctrl.Controls ' for hver panel i groupbox
                            spmcounter += 1
                            Dim control As Control
                            For Each control In panel.Controls
                                If TypeOf control Is RadioButton Then
                                    radiobtn = DirectCast(control, RadioButton)
                                    radiobtn.Checked = True
                                End If
                            Next
                        Next
                    End If
                Next
            End If
        Next

    End Sub



End Class