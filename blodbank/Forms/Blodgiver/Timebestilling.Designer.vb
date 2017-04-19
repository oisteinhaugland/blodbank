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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(blodgiver_timebestilling))
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1478, 37)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MinSideToolStripMenuItem
        '
        Me.MinSideToolStripMenuItem.Name = "MinSideToolStripMenuItem"
        Me.MinSideToolStripMenuItem.Size = New System.Drawing.Size(112, 33)
        Me.MinSideToolStripMenuItem.Text = "Min Side"
        '
        'TimebestillingToolStripMenuItem
        '
        Me.TimebestillingToolStripMenuItem.Name = "TimebestillingToolStripMenuItem"
        Me.TimebestillingToolStripMenuItem.Size = New System.Drawing.Size(163, 33)
        Me.TimebestillingToolStripMenuItem.Text = "Timebestilling"
        '
        'EgenerklæringToolStripMenuItem
        '
        Me.EgenerklæringToolStripMenuItem.Name = "EgenerklæringToolStripMenuItem"
        Me.EgenerklæringToolStripMenuItem.Size = New System.Drawing.Size(167, 33)
        Me.EgenerklæringToolStripMenuItem.Text = "Egenerklæring"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(70, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 44)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Timebestilling"
        '
        'Kalender
        '
        Me.Kalender.Location = New System.Drawing.Point(61, 81)
        Me.Kalender.Name = "Kalender"
        Me.Kalender.TabIndex = 3
        '
        'bestillKnapp
        '
        Me.bestillKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bestillKnapp.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.bestillKnapp.Location = New System.Drawing.Point(61, 372)
        Me.bestillKnapp.Name = "bestillKnapp"
        Me.bestillKnapp.Size = New System.Drawing.Size(610, 66)
        Me.bestillKnapp.TabIndex = 4
        Me.bestillKnapp.Text = "Bestill time"
        Me.bestillKnapp.UseVisualStyleBackColor = False
        '
        'avbestillKnapp
        '
        Me.avbestillKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.avbestillKnapp.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.avbestillKnapp.Location = New System.Drawing.Point(50, 372)
        Me.avbestillKnapp.Name = "avbestillKnapp"
        Me.avbestillKnapp.Size = New System.Drawing.Size(316, 66)
        Me.avbestillKnapp.TabIndex = 5
        Me.avbestillKnapp.Text = "Avbestilt valgt time"
        Me.avbestillKnapp.UseVisualStyleBackColor = False
        '
        'DineTimer
        '
        Me.DineTimer.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.DineTimer.FormattingEnabled = True
        Me.DineTimer.ItemHeight = 29
        Me.DineTimer.Location = New System.Drawing.Point(50, 118)
        Me.DineTimer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DineTimer.Name = "DineTimer"
        Me.DineTimer.Size = New System.Drawing.Size(314, 236)
        Me.DineTimer.TabIndex = 7
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 29
        Me.ListBox2.Location = New System.Drawing.Point(492, 81)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(179, 265)
        Me.ListBox2.TabIndex = 10
        '
        'HentTimebestilling
        '
        Me.HentTimebestilling.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.HentTimebestilling.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.HentTimebestilling.Location = New System.Drawing.Point(50, 50)
        Me.HentTimebestilling.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HentTimebestilling.Name = "HentTimebestilling"
        Me.HentTimebestilling.Size = New System.Drawing.Size(316, 60)
        Me.HentTimebestilling.TabIndex = 11
        Me.HentTimebestilling.Text = "Hent dine timer"
        Me.HentTimebestilling.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(487, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Ledige timer:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1453, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(25, 907)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 919)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1453, 25)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(25, 882)
        Me.Panel3.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Kalender)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.bestillKnapp)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(182, 220)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(741, 501)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Timebestilling"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DineTimer)
        Me.GroupBox2.Controls.Add(Me.avbestillKnapp)
        Me.GroupBox2.Controls.Add(Me.HentTimebestilling)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(974, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(441, 501)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Avbestill time"
        '
        'blodgiver_timebestilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1478, 944)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "blodgiver_timebestilling"
        Me.Text = "Timebestilling"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
