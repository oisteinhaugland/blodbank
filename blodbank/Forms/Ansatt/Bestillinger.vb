Public Class Bestillinger
    Dim bestillinger As List(Of Bestillingsinfo)
    Dim enheterPåLager As List(Of lager)
    Dim bestillTable As New DataTable
    Dim enhetTable As New DataTable


    Private Sub AnsattBestillinger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Location = New Point(0, 0)
        Me.BackColor = Color.FromArgb(247, 247, 247)

        utleveringLabel.Hide()
        motatteBestillinger.Items.Clear()
        motatteBestillinger.Items.Add("Bestillings(id)" & vbTab & "Blodegenskap" & vbTab & "Blodtype" & vbTab & "Blod mengde" & vbTab & "Ordre dato")
        motatteBestillinger.Items.Add(" ")



    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        'Oppdater knapp for å se innkommende bestillinger
        motatteBestillinger.Items.Clear()
        motatteBestillinger.Items.Add("Bestillings(id)" & vbTab & "Blodegenskap" & vbTab & "Blodtype" & vbTab & "Blod mengde" & vbTab & "Ordre dato")
        motatteBestillinger.Items.Add(" ")

        bestillTable = sql_sporring("SELECT * FROM Blod_bestillinger WHERE behandlet = 0")
        Dim counter = 0
        bestillinger = New List(Of Bestillingsinfo)
        For Each rad In bestillTable.Rows
            Dim blodegString
            Select Case rad("blodegenskap_id")
                Case 1
                    blodegString = "Legemer"
                Case 2
                    blodegString = "Plater"
                Case 3
                    blodegString = "Plasma"
            End Select

            Dim blodtypeString
            Select Case rad("blod_type")
                Case 1
                    blodtypeString = "A+"
                Case 2
                    blodtypeString = "A-"
                Case 3
                    blodtypeString = "B+"
                Case 4
                    blodtypeString = "B-"
                Case 5
                    blodtypeString = "AB+"
                Case 6
                    blodtypeString = "AB-"
                Case 7
                    blodtypeString = "O+"
                Case 8
                    blodtypeString = "O-"
            End Select

            motatteBestillinger.Items.Add(rad("blodbestilling_id") & vbTab & vbTab & blodegString & vbTab & vbTab & blodtypeString & vbTab & vbTab & rad("blod_mengde") & vbTab & vbTab & rad("ordre_dato"))


            bestillinger.Add(New Bestillingsinfo(rad("blodbestilling_id"), rad("blodegenskap_id"), rad("blod_mengde"), rad("ordre_dato"), rad("behandlet"), rad("blod_type")))



        Next

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'INSERT settninger for å kunne jobbe med simulerte bestillinger"
        Dim ordredato_sql1 As String = konverterDatoFormatTilMySql(InputBox(" "))
        Dim ordredato_sql2 As String = konverterDatoFormatTilMySql(InputBox(" "))
        Dim ordredato_sql3 As String = konverterDatoFormatTilMySql(InputBox(" "))
        Dim ordredato_sql4 As String = konverterDatoFormatTilMySql(InputBox(" "))
        Dim ordredato_sql5 As String = konverterDatoFormatTilMySql(InputBox(" "))

        sql_sporring("INSERT INTO Blod_bestillinger (blodegenskap_id, blod_type, blod_mengde, ordre_dato) VALUES (3, 1, 4,'" & ordredato_sql1 & "')")
        sql_sporring("INSERT INTO Blod_bestillinger (blodegenskap_id, blod_type, blod_mengde, ordre_dato) VALUES (2, 2, 2,'" & ordredato_sql2 & "')")
        sql_sporring("INSERT INTO Blod_bestillinger (blodegenskap_id, blod_type, blod_mengde, ordre_dato) VALUES (1, 3, 1,'" & ordredato_sql3 & "')")
        sql_sporring("INSERT INTO Blod_bestillinger (blodegenskap_id, blod_type, blod_mengde, ordre_dato) VALUES (3, 4, 3,'" & ordredato_sql4 & "')")
        sql_sporring("INSERT INTO Blod_bestillinger (blodegenskap_id, blod_type, blod_mengde, ordre_dato) VALUES (2, 8, 5,'" & ordredato_sql5 & "')")


    End Sub

    Private Sub bekreft_Utlevering_Click(sender As Object, e As EventArgs) Handles bekreft_Utlevering.Click

        For i = 0 To bestillinger.Count - 1 'for hver bestilling


            For indeks = 0 To enheterPåLager.Count - 1 'for hver av de tilgjengelige enhetene på lager
                If enheterPåLager(indeks).hentBlodType = bestillinger(i).blod_type And enheterPåLager(indeks).hentBlogenskap = bestillinger(i).blod_egenskap Then
                    bestillinger(i).antall_enheter_behandlet += 1
                End If
                sql_sporring("UPDATE Blodlager SET lager_status = 0 WHERE Blodlager.enhet_id =" & enheterPåLager(indeks).hentId)

            Next

            bestillinger(i).ny_blod_mengde = bestillinger(i).ny_mengde(bestillinger(i).blod_mengde, bestillinger(i).antall_enheter_behandlet)

            If bestillinger(i).antall_enheter_behandlet = bestillinger(i).blod_mengde Then
                sql_sporring("UPDATE Blod_bestillinger
                SET behandlet = 1
                WHERE blodbestilling_id =" & bestillinger(i).blod_bestillings_id)
            Else
                sql_sporring("UPDATE Blod_bestillinger
                SET blod_mengde = " & bestillinger(i).ny_blod_mengde & "
                WHERE blodbestilling_id =" & bestillinger(i).blod_bestillings_id)
            End If
        Next

        motatteBestillinger.Items.Clear()
        utleveringLabel.Visible = True
        motatteBestillinger.Items.Add("Bestillings(id)" & vbTab & "Blodegenskap" & vbTab & "Blodtype" & vbTab & "Blod mengde" & vbTab & "Ordre dato")
        motatteBestillinger.Items.Add(" ")

        utleveringLabel.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Reset knapp for å kunne gjøre det igjen

        bestillTable = sql_sporring("SELECT * FROM Blod_bestillinger")
        For Each rad In bestillTable.Rows

            sql_sporring("UPDATE Blod_bestillinger SET behandlet = 0 WHERE blodbestilling_id > 0")
        Next
        motatteBestillinger.Items.Clear()
        utleveringLabel.Visible = False
        motatteBestillinger.Items.Add("Bestillings(id)" & vbTab & "Blodegenskap" & vbTab & "Blodtype" & vbTab & "Blod mengde" & vbTab & "Ordre dato")
        motatteBestillinger.Items.Add(" ")


    End Sub

    Private Sub RegistrerBlodgivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrerBlodgivingToolStripMenuItem.Click
        Me.Hide()
        Blodgivning.Show()

    End Sub

    Private Sub motatteBestillinger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles motatteBestillinger.SelectedIndexChanged

    End Sub

    Private Sub søkLagerBtn_Click(sender As Object, e As EventArgs) Handles søkLagerBtn.Click

        vareLagerListBox.Items.Clear()
        enheterPåLager = New List(Of lager)
        For i = 0 To bestillinger.Count - 1

            enhetTable = sql_sporring("SELECT * FROM Blodlager where lager_status = 1 AND blodtype_id =" & bestillinger(i).blod_type & " and blodegenskap_id =" & bestillinger(i).blod_egenskap & " and holdbarhet >='" & konverterDatoFormatTilMySql(Date.Today).ToString & "' LIMIT " & bestillinger(i).blod_mengde)


            For Each rad In enhetTable.Rows
                enheterPåLager.Add(New lager(rad("enhet_id"), rad("blodegenskap_id"), rad("blodtype_id")))

                Dim blodegString
                Select Case rad("blodegenskap_id")
                    Case 1
                        blodegString = "Legemer"
                    Case 2
                        blodegString = "Plater"
                    Case 3
                        blodegString = "Plasma"
                End Select

                Dim blodtypeString
                Select Case rad("blodtype_id")
                    Case 1
                        blodtypeString = "A+"
                    Case 2
                        blodtypeString = "A-"
                    Case 3
                        blodtypeString = "B+"
                    Case 4
                        blodtypeString = "B-"
                    Case 5
                        blodtypeString = "AB+"
                    Case 6
                        blodtypeString = "AB-"
                    Case 7
                        blodtypeString = "O+"
                    Case 8
                        blodtypeString = "O-"
                End Select

                Dim enhet As String = rad("enhet_id") & "-" & blodtypeString & "-" & blodegString
                vareLagerListBox.Items.Add(enhet)

            Next

        Next

    End Sub


End Class