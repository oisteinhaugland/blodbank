﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
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
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1482, 32)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MinSideToolStripMenuItem
        '
        Me.MinSideToolStripMenuItem.Name = "MinSideToolStripMenuItem"
        Me.MinSideToolStripMenuItem.Size = New System.Drawing.Size(95, 28)
        Me.MinSideToolStripMenuItem.Text = "Min Side"
        '
        'TimebestillingToolStripMenuItem
        '
        Me.TimebestillingToolStripMenuItem.Name = "TimebestillingToolStripMenuItem"
        Me.TimebestillingToolStripMenuItem.Size = New System.Drawing.Size(138, 28)
        Me.TimebestillingToolStripMenuItem.Text = "Timebestilling"
        '
        'EgenerklæringToolStripMenuItem
        '
        Me.EgenerklæringToolStripMenuItem.Name = "EgenerklæringToolStripMenuItem"
        Me.EgenerklæringToolStripMenuItem.Size = New System.Drawing.Size(140, 28)
        Me.EgenerklæringToolStripMenuItem.Text = "Egenerklæring"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 201)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Timebestilling"
        '
        'Kalender
        '
        Me.Kalender.Location = New System.Drawing.Point(35, 147)
        Me.Kalender.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Kalender.Name = "Kalender"
        Me.Kalender.TabIndex = 3
        '
        'bestillKnapp
        '
        Me.bestillKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bestillKnapp.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bestillKnapp.Location = New System.Drawing.Point(36, 378)
        Me.bestillKnapp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bestillKnapp.Name = "bestillKnapp"
        Me.bestillKnapp.Size = New System.Drawing.Size(585, 106)
        Me.bestillKnapp.TabIndex = 4
        Me.bestillKnapp.Text = "Bestill time"
        Me.bestillKnapp.UseVisualStyleBackColor = False
        '
        'avbestillKnapp
        '
        Me.avbestillKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.avbestillKnapp.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avbestillKnapp.Location = New System.Drawing.Point(31, 378)
        Me.avbestillKnapp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.avbestillKnapp.Name = "avbestillKnapp"
        Me.avbestillKnapp.Size = New System.Drawing.Size(555, 106)
        Me.avbestillKnapp.TabIndex = 5
        Me.avbestillKnapp.Text = "Avbestilt valgt time"
        Me.avbestillKnapp.UseVisualStyleBackColor = False
        '
        'DineTimer
        '
        Me.DineTimer.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.DineTimer.FormattingEnabled = True
        Me.DineTimer.ItemHeight = 24
        Me.DineTimer.Location = New System.Drawing.Point(31, 182)
        Me.DineTimer.Margin = New System.Windows.Forms.Padding(4)
        Me.DineTimer.Name = "DineTimer"
        Me.DineTimer.Size = New System.Drawing.Size(555, 172)
        Me.DineTimer.TabIndex = 7
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 24
        Me.ListBox2.Location = New System.Drawing.Point(389, 158)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(232, 196)
        Me.ListBox2.TabIndex = 10
        '
        'HentTimebestilling
        '
        Me.HentTimebestilling.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.HentTimebestilling.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HentTimebestilling.Location = New System.Drawing.Point(31, 56)
        Me.HentTimebestilling.Margin = New System.Windows.Forms.Padding(4)
        Me.HentTimebestilling.Name = "HentTimebestilling"
        Me.HentTimebestilling.Size = New System.Drawing.Size(555, 106)
        Me.HentTimebestilling.TabIndex = 11
        Me.HentTimebestilling.Text = "Hent dine timer"
        Me.HentTimebestilling.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Ledige timer:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1460, 32)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(22, 921)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 933)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1460, 20)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 32)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(22, 901)
        Me.Panel3.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Kalender)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.bestillKnapp)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(63, 203)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(653, 521)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Timebestilling"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 29)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Velg ønsket dato:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DineTimer)
        Me.GroupBox2.Controls.Add(Me.avbestillKnapp)
        Me.GroupBox2.Controls.Add(Me.HentTimebestilling)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(722, 203)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(620, 521)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Avbestill time"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(22, 804)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1438, 129)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(22, 32)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.76204!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.23796!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1438, 726)
        Me.TableLayoutPanel2.TabIndex = 21
        '
        'blodgiver_timebestilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1482, 953)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "blodgiver_timebestilling"
        Me.Text = "Timebestilling"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label3 As Label
End Class
