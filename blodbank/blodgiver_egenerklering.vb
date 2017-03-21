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
        sendEgenerklering.Enabled = False
        TabControl1.Hide()

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


    Private Sub MyTabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        sideIndeks = TabControl1.SelectedIndex
    End Sub

    Private Sub GroupBox10_Enter(sender As Object, e As EventArgs) Handles GroupBox10.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Removes the selected tab: 
        Dim valgtKjonn = False
        If RadioButton119.Checked Then
            TabControl1.TabPages(6).Enabled = False
            valgtKjonn = True
        ElseIf RadioButton120.Checked Then
            TabControl1.TabPages(7).Enabled = False
            valgtKjonn = True
        Else
            MsgBox("Vennligst bekreft ett kjønn")
        End If

        If valgtKjonn Then
            TabControl1.Show()
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
End Class