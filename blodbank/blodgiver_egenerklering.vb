Public Class blodgiver_egenerklering

    Private Function validerEgenerklering()
        Dim alle_sporsmål_besvart = True

        Dim spmcounter = 0
        Dim tabcounter = 0
        Dim groupboxcounter = 0
        Dim antallchecekd = 0
        Dim radiobtn As RadioButton
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


                                        If radiobtn.Checked Then
                                            antallchecekd += 1
                                        End If


                                    End If
                                Next



                            'funker ikke enda, den skjekker enkelt atm, vil bare skjekke hver group
                            'For Each svar In panel.Controls.OfType(Of RadioButton) 'for hver radiobuttongroup i panelet
                            '    'svar.Checked = True
                            '    If svar.Checked = False Then
                            '        antallSvarIkkeBesvart += 1
                            '        alle_sporsmål_besvart = False
                            '    End If
                            'Next




                        Next

                    End If
                Next

            End If
        Next
        Dim check = "Antall tabs: " & tabcounter & vbCrLf & "Antall spm: " & spmcounter & vbCrLf & "Antall Groupboxes: " & groupboxcounter & vbCrLf & "Antall spm checked: " & antallchecekd

        MsgBox(check)
        If antallchecekd <> spmcounter Then
            '            MsgBox("fucking fail")
            alle_sporsmål_besvart = False
        Else
            alle_sporsmål_besvart = True

        End If

        'MsgBox("Tabs: " & tabcounter & vbCrLf & "GroupBox: " & groupboxcounter & vbCrLf & "Spørsmål: " & spmcounter)
        'MsgBox(antallSvarIkkeBesvart)
        If alle_sporsmål_besvart Then
            Return True
        Else
            Return False
        End If
    End Function






    Dim sideIndeks = 0
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
        egenerkleringTabControl.Hide()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If sideIndeks <> 9 Then
            sideIndeks += 1
            egenerkleringTabControl.SelectedIndex = sideIndeks
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

    Private Sub GroupBox10_Enter(sender As Object, e As EventArgs) Handles GroupBox10.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Removes the selected tab: 
        Dim valgtKjonn = False
        If RadioButton119.Checked Then
            egenerkleringTabControl.TabPages(6).Enabled = False
            'egenerkleringTabControl.TabPages(6).remove
            'egenerkleringTabControl.TabPages.Remove(TabPage7)
            valgtKjonn = True
        ElseIf RadioButton120.Checked Then
            egenerkleringTabControl.TabPages(7).Enabled = False
            'egenerkleringTabControl.TabPages.Remove(TabPage7)
            valgtKjonn = True
        Else
            MsgBox("Vennligst bekreft ett kjønn")
        End If

        If valgtKjonn Then
            egenerkleringTabControl.Show()
            Dim knapp As Button = DirectCast(sender, Button)
            knapp.Enabled = False
            RadioButton120.Enabled = False
            RadioButton119.Enabled = False
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            sendEgenerklering.Enabled = True
        Else
            sendEgenerklering.Enabled = False
        End If
    End Sub

    Private Sub sendEgenerklering_Click(sender As Object, e As EventArgs) Handles sendEgenerklering.Click
        validerEgenerklering()
        'MsgBox(validerEgenerklering())

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class