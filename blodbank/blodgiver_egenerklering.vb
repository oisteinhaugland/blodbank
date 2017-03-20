Public Class blodgiver_egenerklering
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

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If sideIndeks <> 9 Then
            sideIndeks += 1
            TabControl1.SelectedIndex = sideIndeks
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If sideIndeks <> 0 Then
            sideIndeks -= 1
            TabControl1.SelectedIndex = sideIndeks
        End If
    End Sub
End Class