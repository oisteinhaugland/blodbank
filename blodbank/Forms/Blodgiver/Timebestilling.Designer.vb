<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Timebestillinger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Timebestillinger))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MinSideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimebestillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EgenerklæringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kalenderTimer = New System.Windows.Forms.MonthCalendar()
        Me.bestillKnapp = New System.Windows.Forms.Button()
        Me.avbestillKnapp = New System.Windows.Forms.Button()
        Me.dineTimer = New System.Windows.Forms.ListBox()
        Me.ledigeTimerListBox = New System.Windows.Forms.ListBox()
        Me.hentTimebestilling = New System.Windows.Forms.Button()
        Me.LabelLedigeTimer = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.timeBestillingGroupBox = New System.Windows.Forms.GroupBox()
        Me.LabelOnsketDato = New System.Windows.Forms.Label()
        Me.avbestillingGroupBox = New System.Windows.Forms.GroupBox()
        Me.guiPanel = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.timeBestillingGroupBox.SuspendLayout()
        Me.avbestillingGroupBox.SuspendLayout()
        Me.guiPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinSideToolStripMenuItem, Me.TimebestillingToolStripMenuItem, Me.EgenerklæringToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1125, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MinSideToolStripMenuItem
        '
        Me.MinSideToolStripMenuItem.Name = "MinSideToolStripMenuItem"
        Me.MinSideToolStripMenuItem.Size = New System.Drawing.Size(77, 23)
        Me.MinSideToolStripMenuItem.Text = "Min Side"
        '
        'TimebestillingToolStripMenuItem
        '
        Me.TimebestillingToolStripMenuItem.Name = "TimebestillingToolStripMenuItem"
        Me.TimebestillingToolStripMenuItem.Size = New System.Drawing.Size(113, 23)
        Me.TimebestillingToolStripMenuItem.Text = "Timebestilling"
        '
        'EgenerklæringToolStripMenuItem
        '
        Me.EgenerklæringToolStripMenuItem.Name = "EgenerklæringToolStripMenuItem"
        Me.EgenerklæringToolStripMenuItem.Size = New System.Drawing.Size(114, 23)
        Me.EgenerklæringToolStripMenuItem.Text = "Egenerklæring"
        '
        'kalenderTimer
        '
        Me.kalenderTimer.Location = New System.Drawing.Point(26, 119)
        Me.kalenderTimer.Margin = New System.Windows.Forms.Padding(6)
        Me.kalenderTimer.Name = "kalenderTimer"
        Me.kalenderTimer.TabIndex = 3
        '
        'bestillKnapp
        '
        Me.bestillKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bestillKnapp.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bestillKnapp.Location = New System.Drawing.Point(27, 307)
        Me.bestillKnapp.Margin = New System.Windows.Forms.Padding(2)
        Me.bestillKnapp.Name = "bestillKnapp"
        Me.bestillKnapp.Size = New System.Drawing.Size(439, 86)
        Me.bestillKnapp.TabIndex = 4
        Me.bestillKnapp.Text = "Bestill time"
        Me.bestillKnapp.UseVisualStyleBackColor = False
        '
        'avbestillKnapp
        '
        Me.avbestillKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.avbestillKnapp.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avbestillKnapp.Location = New System.Drawing.Point(23, 307)
        Me.avbestillKnapp.Margin = New System.Windows.Forms.Padding(2)
        Me.avbestillKnapp.Name = "avbestillKnapp"
        Me.avbestillKnapp.Size = New System.Drawing.Size(416, 86)
        Me.avbestillKnapp.TabIndex = 5
        Me.avbestillKnapp.Text = "Avbestilt valgt time"
        Me.avbestillKnapp.UseVisualStyleBackColor = False
        '
        'dineTimer
        '
        Me.dineTimer.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dineTimer.FormattingEnabled = True
        Me.dineTimer.ItemHeight = 19
        Me.dineTimer.Location = New System.Drawing.Point(23, 148)
        Me.dineTimer.Name = "dineTimer"
        Me.dineTimer.Size = New System.Drawing.Size(417, 137)
        Me.dineTimer.TabIndex = 7
        '
        'ledigeTimerListBox
        '
        Me.ledigeTimerListBox.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.ledigeTimerListBox.FormattingEnabled = True
        Me.ledigeTimerListBox.ItemHeight = 19
        Me.ledigeTimerListBox.Location = New System.Drawing.Point(291, 119)
        Me.ledigeTimerListBox.Name = "ledigeTimerListBox"
        Me.ledigeTimerListBox.Size = New System.Drawing.Size(175, 156)
        Me.ledigeTimerListBox.TabIndex = 10
        '
        'hentTimebestilling
        '
        Me.hentTimebestilling.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.hentTimebestilling.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hentTimebestilling.Location = New System.Drawing.Point(23, 46)
        Me.hentTimebestilling.Name = "hentTimebestilling"
        Me.hentTimebestilling.Size = New System.Drawing.Size(416, 86)
        Me.hentTimebestilling.TabIndex = 11
        Me.hentTimebestilling.Text = "Hent dine timer"
        Me.hentTimebestilling.UseVisualStyleBackColor = False
        '
        'LabelLedigeTimer
        '
        Me.LabelLedigeTimer.AutoSize = True
        Me.LabelLedigeTimer.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLedigeTimer.Location = New System.Drawing.Point(281, 81)
        Me.LabelLedigeTimer.Name = "LabelLedigeTimer"
        Me.LabelLedigeTimer.Size = New System.Drawing.Size(114, 23)
        Me.LabelLedigeTimer.TabIndex = 12
        Me.LabelLedigeTimer.Text = "Ledige timer:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1109, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(16, 595)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 606)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 16)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 27)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(16, 579)
        Me.Panel3.TabIndex = 15
        '
        'timeBestillingGroupBox
        '
        Me.timeBestillingGroupBox.Controls.Add(Me.LabelOnsketDato)
        Me.timeBestillingGroupBox.Controls.Add(Me.kalenderTimer)
        Me.timeBestillingGroupBox.Controls.Add(Me.ledigeTimerListBox)
        Me.timeBestillingGroupBox.Controls.Add(Me.LabelLedigeTimer)
        Me.timeBestillingGroupBox.Controls.Add(Me.bestillKnapp)
        Me.timeBestillingGroupBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeBestillingGroupBox.Location = New System.Drawing.Point(2, 2)
        Me.timeBestillingGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.timeBestillingGroupBox.Name = "timeBestillingGroupBox"
        Me.timeBestillingGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.timeBestillingGroupBox.Size = New System.Drawing.Size(537, 432)
        Me.timeBestillingGroupBox.TabIndex = 16
        Me.timeBestillingGroupBox.TabStop = False
        Me.timeBestillingGroupBox.Text = "Timebestilling"
        '
        'LabelOnsketDato
        '
        Me.LabelOnsketDato.AutoSize = True
        Me.LabelOnsketDato.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOnsketDato.Location = New System.Drawing.Point(31, 81)
        Me.LabelOnsketDato.Name = "LabelOnsketDato"
        Me.LabelOnsketDato.Size = New System.Drawing.Size(146, 23)
        Me.LabelOnsketDato.TabIndex = 13
        Me.LabelOnsketDato.Text = "Velg ønsket dato:"
        '
        'avbestillingGroupBox
        '
        Me.avbestillingGroupBox.Controls.Add(Me.dineTimer)
        Me.avbestillingGroupBox.Controls.Add(Me.avbestillKnapp)
        Me.avbestillingGroupBox.Controls.Add(Me.hentTimebestilling)
        Me.avbestillingGroupBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avbestillingGroupBox.Location = New System.Drawing.Point(543, 2)
        Me.avbestillingGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.avbestillingGroupBox.Name = "avbestillingGroupBox"
        Me.avbestillingGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.avbestillingGroupBox.Size = New System.Drawing.Size(490, 432)
        Me.avbestillingGroupBox.TabIndex = 17
        Me.avbestillingGroupBox.TabStop = False
        Me.avbestillingGroupBox.Text = "Avbestill time"
        '
        'guiPanel
        '
        Me.guiPanel.Controls.Add(Me.timeBestillingGroupBox)
        Me.guiPanel.Controls.Add(Me.avbestillingGroupBox)
        Me.guiPanel.Location = New System.Drawing.Point(21, 93)
        Me.guiPanel.Name = "guiPanel"
        Me.guiPanel.Size = New System.Drawing.Size(1039, 439)
        Me.guiPanel.TabIndex = 18
        '
        'Timebestillinger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1125, 622)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.guiPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Timebestillinger"
        Me.Text = "Timebestilling"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.timeBestillingGroupBox.ResumeLayout(False)
        Me.timeBestillingGroupBox.PerformLayout()
        Me.avbestillingGroupBox.ResumeLayout(False)
        Me.guiPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MinSideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimebestillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EgenerklæringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents kalenderTimer As MonthCalendar
    Friend WithEvents bestillKnapp As Button
    Friend WithEvents avbestillKnapp As Button
    Friend WithEvents dineTimer As ListBox
    Friend WithEvents ledigeTimerListBox As ListBox
    Friend WithEvents hentTimebestilling As Button
    Friend WithEvents LabelLedigeTimer As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents timeBestillingGroupBox As GroupBox
    Friend WithEvents avbestillingGroupBox As GroupBox
    Friend WithEvents LabelOnsketDato As Label
    Friend WithEvents guiPanel As Panel
End Class
