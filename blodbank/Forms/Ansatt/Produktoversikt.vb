
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Produktoversikt
    Private Sub HjemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HjemToolStripMenuItem.Click
        Startside.Show()
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

    Private Sub RegistrerBlodgivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrerBlodgivingToolStripMenuItem.Click
        Me.Hide()
        Blodgivning.Show()
    End Sub

    Private Sub ansattProduktoversikt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(247, 247, 247)

        Dim prodOversikt = sql_sporring("SELECT * FROM Blodlager")

        Dim antallPlasma As Integer
        Dim antallBlodlegemer As Integer
        Dim antallBlodplater As Integer

        Dim PlasmaAntallAp, PlasmaAntallAm, PlasmaAntallBp, PlasmaAntallBm, PlasmaAntallABp, PlasmaAntallABm, PlasmaAntallOp, PlasmaAntallOm As Integer
        Dim BlodLegemerAntallAp, BlodLegemerAntallAm, BlodLegemerAntallBp, BlodLegemerAntallBm, BlodLegemerAntallABp, BlodLegemerAntallABm, BlodLegemerAntallOp, BlodLegemerAntallOm As Integer
        Dim BlodPlaterAntallAp, BlodPlaterAntallAm, BlodPlaterAntallBp, BlodPlaterAntallBm, BlodPlaterAntallABp, BlodPlaterAntallABm, BlodPlaterAntallOp, BlodPlaterAntallOm As Integer


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
        chartPlasma.Series.Clear()
        chartPlasma.Series.Add("Plasma oversikt")

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

        chartPlasma.Series.Add(pOversikt)
        '__________________________________________________________
        chartBlodplater.Series.Clear()
        chartBlodplater.Series.Add("Blodplater oversikt")

        Dim blodplatOversikt As New Series
        blodplatOversikt.XAxisType = AxisType.Primary
        blodplatOversikt.SmartLabelStyle.Enabled = False
        blodplatOversikt.LabelAngle = 45
        blodplatOversikt.IsVisibleInLegend = False
        'blodplatOversikt.ChartType = SeriesChartType.Bar
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

        chartBlodplater.Series.Add(blodplatOversikt)
        '__________________________________________________________
        chartBlodlegemer.Series.Clear()
        chartBlodlegemer.Series.Add("Blodlegemer oversikt")

        Dim blodlegOversikt As New Series
        blodlegOversikt.XAxisType = AxisType.Primary
        blodlegOversikt.SmartLabelStyle.Enabled = False
        blodlegOversikt.LabelAngle = 45
        blodlegOversikt.IsVisibleInLegend = False
        'blodlegOversikt.ChartType = SeriesChartType.Bar
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

        chartBlodlegemer.Series.Add(blodlegOversikt)
    End Sub

    Private Sub chartBlodLager_Click(sender As Object, e As EventArgs) Handles chartPlasma.Click

    End Sub

    Private Sub chartBlodlegemer_Click(sender As Object, e As EventArgs) Handles chartBlodlegemer.Click

    End Sub
End Class