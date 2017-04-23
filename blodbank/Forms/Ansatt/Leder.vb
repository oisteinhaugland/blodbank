Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class Leder
    Dim lederbestillinger As List(Of Bestillingsinfo)
    Dim ledelseTable As New DataTable

    Private Sub Leder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'maksimerer og setter farge
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 255, 255)

        'midstiller gui
        LabelTilgjengeligStats.Left = ((Me.ClientSize.Width - LabelTilgjengeligStats.Width) \ 2)
        LabelTilgjengeligStats.Top = (Me.ClientSize.Height - statistikkTabControl.Height) \ 2.8
        LabelTilgjengeligStats.Font = New Font("Calibri", 16, FontStyle.Bold)

        statistikkTabControl.Left = (Me.ClientSize.Width - statistikkTabControl.Width) \ 2
        statistikkTabControl.Top = (Me.ClientSize.Height - statistikkTabControl.Height) \ 2
        ledelseBestillinger.Items.Clear()

        loggUtBtn.Left = ((Me.ClientSize.Width - loggUtBtn.Width) \ 2) + LabelTilgjengeligStats.Width - (loggUtBtn.Width / 3)
        loggUtBtn.Top = (Me.ClientSize.Height - statistikkTabControl.Height) \ 2.8


        Dim prodOversikt = sql_sporring("SELECT * FROM Blodlager")
        'antall egenskaper
        Dim antallPlasma As Integer
        Dim antallBlodlegemer As Integer
        Dim antallBlodplater As Integer

        'antall blodtyper av hver egenskap
        Dim PlasmaAntallAp, PlasmaAntallAm, PlasmaAntallBp, PlasmaAntallBm, PlasmaAntallABp, PlasmaAntallABm, PlasmaAntallOp, PlasmaAntallOm As Integer
        Dim BlodLegemerAntallAp, BlodLegemerAntallAm, BlodLegemerAntallBp, BlodLegemerAntallBm, BlodLegemerAntallABp, BlodLegemerAntallABm, BlodLegemerAntallOp, BlodLegemerAntallOm As Integer
        Dim BlodPlaterAntallAp, BlodPlaterAntallAm, BlodPlaterAntallBp, BlodPlaterAntallBm, BlodPlaterAntallABp, BlodPlaterAntallABm, BlodPlaterAntallOp, BlodPlaterAntallOm As Integer

        'finn antall plasma
        Dim plasmaOversikt = sql_sporring("SELECT * FROM Blodlager WHERE blodegenskap_id = 3")
        For Each rad In plasmaOversikt.Rows
            Select Case rad("blodtype_id")
                Case 1
                    PlasmaAntallAp += 1
                Case 2
                    PlasmaAntallAm += 1
                Case 3
                    PlasmaAntallBp += 1
                Case 4
                    PlasmaAntallBm += 1
                Case 5
                    PlasmaAntallABp += 1
                Case 6
                    PlasmaAntallABm += 1
                Case 7
                    PlasmaAntallOp += 1
                Case 8
                    PlasmaAntallOm += 1
            End Select
        Next

        'finn antall ¨blodplater
        Dim blodplaterOversikt = sql_sporring("SELECT * FROM Blodlager WHERE blodegenskap_id = 2")
        For Each rad In blodplaterOversikt.Rows
            Select Case rad("blodtype_id")
                Case 1
                    BlodPlaterAntallAp += 1
                Case 2
                    BlodPlaterAntallAm += 1
                Case 3
                    BlodPlaterAntallBp += 1
                Case 4
                    BlodPlaterAntallBm += 1
                Case 5
                    BlodPlaterAntallABp += 1
                Case 6
                    BlodPlaterAntallABm += 1
                Case 7
                    BlodPlaterAntallOp += 1
                Case 8
                    BlodPlaterAntallOm += 1
            End Select
        Next

        'finn antall blodlegemer
        Dim blodlegemerOversikt = sql_sporring("SELECT * FROM Blodlager WHERE blodegenskap_id = 1")
        For Each rad In blodlegemerOversikt.Rows
            Select Case rad("blodtype_id")
                Case 1
                    BlodLegemerAntallAp += 1
                Case 2
                    BlodLegemerAntallAm += 1
                Case 3
                    BlodLegemerAntallBp += 1
                Case 4
                    BlodLegemerAntallBm += 1
                Case 5
                    BlodLegemerAntallABp += 1
                Case 6
                    BlodLegemerAntallABm += 1
                Case 7
                    BlodLegemerAntallOp += 1
                Case 8
                    BlodLegemerAntallOm += 1
            End Select
        Next


        For Each rad In prodOversikt.Rows
            If rad("blodegenskap_id") = 3 Then
                antallPlasma += 1
            ElseIf rad("blodegenskap_id") = 2 Then
                antallBlodplater += 1
            Else
                antallBlodlegemer += 1
            End If

        Next

        '__________________________________________________________
        'plasma oversikt
        chartLederPlasma.Series.Clear()
        chartLederPlasma.Series.Add("Plasma oversikt")

        Dim pOversikt As New Series
        pOversikt.XAxisType = AxisType.Primary
        pOversikt.SmartLabelStyle.Enabled = False
        pOversikt.LabelAngle = 45
        pOversikt.IsVisibleInLegend = False
        'pOversikt.ChartType = SeriesChartType.Bar
        pOversikt.XValueType = ChartValueType.String

        With pOversikt.Points
            .AddXY("A+", PlasmaAntallAp)
            .AddXY("A-", PlasmaAntallAm)
            .AddXY("B+", PlasmaAntallBp)
            .AddXY("B-", PlasmaAntallBm)
            .AddXY("AB+", PlasmaAntallABp)
            .AddXY("AB-", PlasmaAntallABm)
            .AddXY("O+", PlasmaAntallOp)
            .AddXY("O-", PlasmaAntallOm)
        End With

        chartLederPlasma.Series.Add(pOversikt)
        '__________________________________________________________
        'blodplater oversikt

        chartLederBlodplater.Series.Clear()
        chartLederBlodplater.Series.Add("Blodplater oversikt")

        Dim blodplatOversikt As New Series
        blodplatOversikt.XAxisType = AxisType.Primary
        blodplatOversikt.SmartLabelStyle.Enabled = False
        blodplatOversikt.LabelAngle = 45
        blodplatOversikt.IsVisibleInLegend = False
        blodplatOversikt.XValueType = ChartValueType.String

        With blodplatOversikt.Points
            .AddXY("A+", BlodPlaterAntallAp)
            .AddXY("A-", BlodPlaterAntallAm)
            .AddXY("B+", BlodPlaterAntallBp)
            .AddXY("B-", BlodPlaterAntallBm)
            .AddXY("AB+", BlodPlaterAntallABp)
            .AddXY("AB-", BlodPlaterAntallABm)
            .AddXY("O+", BlodPlaterAntallOp)
            .AddXY("O-", BlodPlaterAntallOm)
        End With

        chartLederBlodplater.Series.Add(blodplatOversikt)
        '__________________________________________________________
        'blodlegemer oversikt 

        chartLederBlodlegemer.Series.Clear()
        chartLederBlodlegemer.Series.Add("Blodlegemer oversikt")

        Dim blodlegOversikt As New Series
        blodlegOversikt.XAxisType = AxisType.Primary
        blodlegOversikt.SmartLabelStyle.Enabled = False
        blodlegOversikt.LabelAngle = 45
        blodlegOversikt.IsVisibleInLegend = False
        blodlegOversikt.XValueType = ChartValueType.String

        With blodlegOversikt.Points
            .AddXY("A+", BlodLegemerAntallAp)
            .AddXY("A-", BlodLegemerAntallAm)
            .AddXY("B+", BlodLegemerAntallBp)
            .AddXY("B-", BlodLegemerAntallBm)
            .AddXY("AB+", BlodLegemerAntallABp)
            .AddXY("AB-", BlodLegemerAntallABm)
            .AddXY("O+", BlodLegemerAntallOp)
            .AddXY("O-", BlodLegemerAntallOm)
        End With

        chartLederBlodlegemer.Series.Add(blodlegOversikt)

        Dim antallKvinner As Integer = 0
        Dim antallMenn As Integer = 0

        Dim antallPersoner = sql_sporring("SELECT personnummer FROM Blodgiver")
        For Each rad In antallPersoner.Rows
            Dim temp = rad("personnummer").ToString
            If temp.Substring(2, 1) Mod 2 = 0 Then
                antallKvinner += 1
            Else
                antallMenn += 1
            End If
        Next

        '__________________________________________________________
        'antall kjønn chart.

        chartKjonn.Series.Clear()
        chartKjonn.Series.Add("Antall kvinner")

        
        Dim kvinnerOversikt As New Series
        kvinnerOversikt.XAxisType = AxisType.Primary
        kvinnerOversikt.SmartLabelStyle.Enabled = False
        kvinnerOversikt.LabelAngle = 45
        kvinnerOversikt.IsVisibleInLegend = False
        kvinnerOversikt.XValueType = ChartValueType.String

        With kvinnerOversikt.Points
            .AddXY("Kvinner", antallKvinner)
            .AddXY("Menn", antallMenn)

        End With

        chartKjonn.Series.Add(kvinnerOversikt)
        chartKjonn.Series.Add("Antall menn")

        Dim mannOversikt As New Series
        mannOversikt.XAxisType = AxisType.Primary
        mannOversikt.SmartLabelStyle.Enabled = False
        mannOversikt.LabelAngle = 45
        mannOversikt.IsVisibleInLegend = False
        mannOversikt.XValueType = ChartValueType.String

        With mannOversikt.Points
        End With

        chartKjonn.Series.Add(mannOversikt)
    End Sub


    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles statistikkTabControl.SelectedIndexChanged
        'hent aktive bestillinger
        If statistikkTabControl.SelectedIndex = 4 Then
            ledelseBestillinger.Items.Clear()
            ledelseTable = sql_sporring("SELECT * FROM Blod_bestillinger WHERE behandlet = 0")
            Dim teller = 0

            For Each rad In ledelseTable.Rows
                Dim blodtypeString = konverterBlodtypeTilTekst(rad("blod_type"))
                Dim blodegString = konverterBlodEgenskapTilTekst(rad("blodegenskap_id"))
                teller += 1
                ledelseBestillinger.Items.Add(rad("blodbestilling_id") & vbTab & vbTab & blodegString & vbTab & vbTab & blodtypeString & vbTab & vbTab & rad("blod_mengde") & vbTab & vbTab & rad("ordre_dato"))
            Next
            bestillingerLabel.Text = teller
        End If
    End Sub


    'logg ut
    Private Sub loggUtBtn_click(sender As Object, e As EventArgs) Handles loggUtBtn.Click
        loggInn.Show()
        Me.Close()
    End Sub
End Class