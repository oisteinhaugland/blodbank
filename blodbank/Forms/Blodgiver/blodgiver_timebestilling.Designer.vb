<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class blodgiver_timebestilling
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MinSideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimebestillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EgenerklæringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Kalender = New System.Windows.Forms.MonthCalendar()
        Me.bestillKnapp = New System.Windows.Forms.Button()
        Me.avbestillKnapp = New System.Windows.Forms.Button()
        Me.DineTimer = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.HentTimebestilling = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinSideToolStripMenuItem, Me.TimebestillingToolStripMenuItem, Me.EgenerklæringToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(809, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MinSideToolStripMenuItem
        '
        Me.MinSideToolStripMenuItem.Name = "MinSideToolStripMenuItem"
        Me.MinSideToolStripMenuItem.Size = New System.Drawing.Size(65, 22)
        Me.MinSideToolStripMenuItem.Text = "Min Side"
        '
        'TimebestillingToolStripMenuItem
        '
        Me.TimebestillingToolStripMenuItem.Name = "TimebestillingToolStripMenuItem"
        Me.TimebestillingToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.TimebestillingToolStripMenuItem.Text = "Timebestilling"
        '
        'EgenerklæringToolStripMenuItem
        '
        Me.EgenerklæringToolStripMenuItem.Name = "EgenerklæringToolStripMenuItem"
        Me.EgenerklæringToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.EgenerklæringToolStripMenuItem.Text = "Egenerklæring"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Timebestilling"
        '
        'Kalender
        '
        Me.Kalender.Location = New System.Drawing.Point(25, 77)
        Me.Kalender.Margin = New System.Windows.Forms.Padding(6)
        Me.Kalender.Name = "Kalender"
        Me.Kalender.TabIndex = 3
        '
        'bestillKnapp
        '
        Me.bestillKnapp.Location = New System.Drawing.Point(254, 243)
        Me.bestillKnapp.Margin = New System.Windows.Forms.Padding(2)
        Me.bestillKnapp.Name = "bestillKnapp"
        Me.bestillKnapp.Size = New System.Drawing.Size(85, 43)
        Me.bestillKnapp.TabIndex = 4
        Me.bestillKnapp.Text = "Bestill time"
        Me.bestillKnapp.UseVisualStyleBackColor = True
        '
        'avbestillKnapp
        '
        Me.avbestillKnapp.Location = New System.Drawing.Point(352, 243)
        Me.avbestillKnapp.Margin = New System.Windows.Forms.Padding(2)
        Me.avbestillKnapp.Name = "avbestillKnapp"
        Me.avbestillKnapp.Size = New System.Drawing.Size(211, 43)
        Me.avbestillKnapp.TabIndex = 5
        Me.avbestillKnapp.Text = "Avbestilt valgt time"
        Me.avbestillKnapp.UseVisualStyleBackColor = True
        '
        'DineTimer
        '
        Me.DineTimer.FormattingEnabled = True
        Me.DineTimer.Location = New System.Drawing.Point(352, 78)
        Me.DineTimer.Name = "DineTimer"
        Me.DineTimer.Size = New System.Drawing.Size(211, 160)
        Me.DineTimer.TabIndex = 7
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(254, 78)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(85, 160)
        Me.ListBox2.TabIndex = 10
        '
        'HentTimebestilling
        '
        Me.HentTimebestilling.Location = New System.Drawing.Point(352, 34)
        Me.HentTimebestilling.Name = "HentTimebestilling"
        Me.HentTimebestilling.Size = New System.Drawing.Size(211, 39)
        Me.HentTimebestilling.TabIndex = 11
        Me.HentTimebestilling.Text = "Hent dine timer"
        Me.HentTimebestilling.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Ledige Timer"
        '
        'blodgiver_timebestilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HentTimebestilling)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.DineTimer)
        Me.Controls.Add(Me.avbestillKnapp)
        Me.Controls.Add(Me.bestillKnapp)
        Me.Controls.Add(Me.Kalender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "blodgiver_timebestilling"
        Me.Text = "blodgiver_timebestilling"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MinSideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimebestillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EgenerklæringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Kalender As MonthCalendar
    Friend WithEvents bestillKnapp As Button
    Friend WithEvents avbestillKnapp As Button
    Friend WithEvents DineTimer As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents HentTimebestilling As Button
    Friend WithEvents Label2 As Label
End Class
