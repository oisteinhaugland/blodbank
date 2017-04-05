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


    Private Sub registrerBlodInfo()

        Dim blodgiverID As Integer = IDtekst.Text
        Dim blodtype As String = blodtypeTekst.Text
        Dim plasma As Integer = plasmaTekst.Text
        Dim blodlegemer As Integer = blodlegemeTekst.Text
        Dim blodplater As Integer = blodplateTekst.Text
        Dim datoTapp As String

        Dim datoFormat As String = "^(\d){2}\.(\d){2}\.(\d){4}$"
        Dim TappedatoformatMatch As Match = Regex.Match((TappeDato.Text), datoFormat)
        If TappedatoformatMatch.Success Then
            Dim Tdato As String = konverterDatoFormatTilMySql(TappeDato.Text)
        Else
            MsgBox("Tappedato er ikke riktig datoformat. Vennligst fyll inn dd.mm.åååå")
        End If

        Try
            sql_sporring("INSERT INTO Blodtapp(blodgiver_id, blodlegemer_mengde, blodplater_mengde, plasma_mengde, tappe_dato, blodtype_id)
        values ('" & blodgiverID & "',
               '" & blodlegemer & "',
                '" & blodplater & "',
                '" & plasma & "',
                '" & datoTapp & "',
                '" & blodtype & "' 
                )")
            Dim registrertTapp As String = "Blodtapp for bruker " & blodgiverID & " er nå registrert."
            MsgBox(registrertTapp)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub LagreBlodtapp_Click(sender As Object, e As EventArgs) Handles LagreBlodtapp.Click
        registrerBlodInfo()
    End Sub

End Class