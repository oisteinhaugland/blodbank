Module FellesFunksjoner

    Public Function IntegertilKlokkeSlett(ByVal tid As Integer)
        Dim tidspunkt
        Select Case tid
            Case 9
                tidspunkt = "09:00"
            Case 10
                tidspunkt = "10:00"
            Case 11
                tidspunkt = "11:00"
            Case 12
                tidspunkt = "12:00"
            Case 13
                tidspunkt = "13:00"
            Case 14
                tidspunkt = "14:00"
            Case 15
                tidspunkt = "15:00"
        End Select
        Return tidspunkt
    End Function

    Public Function KonverterKlokkeslettTilInteger(ByVal tid As String)
        Dim tidspunkt
        Select Case tid
            Case "09:00"
                tidspunkt = 9
            Case "10:00"
                tidspunkt = 10
            Case "11:00"
                tidspunkt = 11
            Case "12:00"
                tidspunkt = 12
            Case "13:00"
                tidspunkt = 13
            Case "14:00"
                tidspunkt = 14
            Case "15:00"
                tidspunkt = 15
        End Select
        Return tidspunkt
    End Function


    Public Sub timebestillingMetode(kalender, listbox)
        Dim valgtDato As String = konverterDatoFormatTilMySql(kalender.SelectionRange.Start.ToShortDateString())
        Dim aktiveTimer = sql_sporring("SELECT er_aktiv, bestilling_tidspunkt FROM Timebestilling where bestilling_dato ='" & valgtDato & "' and er_aktiv = 1")

        Dim klokke As Integer = 9
        listbox.Items.Clear()
        Dim tidsPunkt = ""
        Dim hvisTid = True

        If aktiveTimer.Rows.Count <> 0 Then 'hvis det er timer på den dagen

            'skjekk om tidspunktet er en av radene
            For i = 0 To 6

                For Each rad In aktiveTimer.Rows
                    If rad("bestilling_tidspunkt") = klokke Then
                        hvisTid = False
                    End If
                Next
                tidsPunkt = IntegertilKlokkeSlett(klokke)
                If hvisTid Then
                    listbox.Items.Add(tidsPunkt)
                End If
                klokke += 1
                hvisTid = True
            Next
        Else
            For i = 0 To 6
                tidsPunkt = IntegertilKlokkeSlett(klokke)
                listbox.Items.Add(tidsPunkt)
                klokke += 1
            Next
        End If
    End Sub


    Public Function konverterBlodtypeTilTekst(ByVal id As Integer)
        Dim blodtypeString
        Select Case id
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

        Return blodtypeString
    End Function


    Public Function konverterBlodEgenskapTilTekst(ByVal Egid As Integer)
        Dim blodegString
        Select Case Egid
            Case 1
                blodegString = "Legemer"
            Case 2
                blodegString = "Plater"
            Case 3
                blodegString = "Plasma"
        End Select
        Return blodegString
    End Function


End Module
