<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Startside
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Startside))
        Me.loggUtBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HjemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduktoversiktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InnkallingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrerBlodgivingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelDagensDato = New System.Windows.Forms.Label()
        Me.LabelTimerForDagen = New System.Windows.Forms.Label()
        Me.dagensTimer = New System.Windows.Forms.ListBox()
        Me.LabelNavn = New System.Windows.Forms.Label()
        Me.LabelTid = New System.Windows.Forms.Label()
        Me.LabelDagensDatoTid = New System.Windows.Forms.Label()
        Me.LabelVelkommen = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.guiPanel = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.guiPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'loggUtBtn
        '
        Me.loggUtBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.loggUtBtn.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold)
        Me.loggUtBtn.Location = New System.Drawing.Point(25, 280)
        Me.loggUtBtn.Name = "loggUtBtn"
        Me.loggUtBtn.Size = New System.Drawing.Size(375, 86)
        Me.loggUtBtn.TabIndex = 1
        Me.loggUtBtn.Text = "Logg ut / avslutt"
        Me.loggUtBtn.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HjemToolStripMenuItem, Me.ProduktoversiktToolStripMenuItem, Me.InnkallingToolStripMenuItem, Me.BestillingToolStripMenuItem, Me.RegistrerBlodgivingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1204, 27)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HjemToolStripMenuItem
        '
        Me.HjemToolStripMenuItem.Name = "HjemToolStripMenuItem"
        Me.HjemToolStripMenuItem.Size = New System.Drawing.Size(55, 23)
        Me.HjemToolStripMenuItem.Text = "Hjem"
        '
        'ProduktoversiktToolStripMenuItem
        '
        Me.ProduktoversiktToolStripMenuItem.Name = "ProduktoversiktToolStripMenuItem"
        Me.ProduktoversiktToolStripMenuItem.Size = New System.Drawing.Size(121, 23)
        Me.ProduktoversiktToolStripMenuItem.Text = "Produktoversikt"
        '
        'InnkallingToolStripMenuItem
        '
        Me.InnkallingToolStripMenuItem.Name = "InnkallingToolStripMenuItem"
        Me.InnkallingToolStripMenuItem.Size = New System.Drawing.Size(84, 23)
        Me.InnkallingToolStripMenuItem.Text = "Innkalling"
        '
        'BestillingToolStripMenuItem
        '
        Me.BestillingToolStripMenuItem.Name = "BestillingToolStripMenuItem"
        Me.BestillingToolStripMenuItem.Size = New System.Drawing.Size(82, 23)
        Me.BestillingToolStripMenuItem.Text = "Bestilling"
        '
        'RegistrerBlodgivingToolStripMenuItem
        '
        Me.RegistrerBlodgivingToolStripMenuItem.Name = "RegistrerBlodgivingToolStripMenuItem"
        Me.RegistrerBlodgivingToolStripMenuItem.Size = New System.Drawing.Size(151, 23)
        Me.RegistrerBlodgivingToolStripMenuItem.Text = "Registrer blodgiving"
        '
        'LabelDagensDato
        '
        Me.LabelDagensDato.AutoSize = True
        Me.LabelDagensDato.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.LabelDagensDato.Location = New System.Drawing.Point(43, 140)
        Me.LabelDagensDato.Name = "LabelDagensDato"
        Me.LabelDagensDato.Size = New System.Drawing.Size(142, 29)
        Me.LabelDagensDato.TabIndex = 8
        Me.LabelDagensDato.Text = "Dagens dato:"
        '
        'LabelTimerForDagen
        '
        Me.LabelTimerForDagen.AutoSize = True
        Me.LabelTimerForDagen.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTimerForDagen.Location = New System.Drawing.Point(20, 85)
        Me.LabelTimerForDagen.Name = "LabelTimerForDagen"
        Me.LabelTimerForDagen.Size = New System.Drawing.Size(202, 33)
        Me.LabelTimerForDagen.TabIndex = 9
        Me.LabelTimerForDagen.Text = "Timer for dagen:"
        '
        'dagensTimer
        '
        Me.dagensTimer.Font = New System.Drawing.Font("Calibri", 20.0!)
        Me.dagensTimer.FormattingEnabled = True
        Me.dagensTimer.ItemHeight = 33
        Me.dagensTimer.Location = New System.Drawing.Point(17, 157)
        Me.dagensTimer.Name = "dagensTimer"
        Me.dagensTimer.Size = New System.Drawing.Size(423, 235)
        Me.dagensTimer.TabIndex = 10
        '
        'LabelNavn
        '
        Me.LabelNavn.AutoSize = True
        Me.LabelNavn.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNavn.Location = New System.Drawing.Point(20, 121)
        Me.LabelNavn.Name = "LabelNavn"
        Me.LabelNavn.Size = New System.Drawing.Size(73, 33)
        Me.LabelNavn.TabIndex = 11
        Me.LabelNavn.Text = "Navn"
        '
        'LabelTid
        '
        Me.LabelTid.AutoSize = True
        Me.LabelTid.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTid.Location = New System.Drawing.Point(228, 121)
        Me.LabelTid.Name = "LabelTid"
        Me.LabelTid.Size = New System.Drawing.Size(56, 33)
        Me.LabelTid.TabIndex = 12
        Me.LabelTid.Text = "Tid:"
        '
        'LabelDagensDatoTid
        '
        Me.LabelDagensDatoTid.AutoSize = True
        Me.LabelDagensDatoTid.Font = New System.Drawing.Font("Calibri", 18.0!)
        Me.LabelDagensDatoTid.Location = New System.Drawing.Point(191, 140)
        Me.LabelDagensDatoTid.Name = "LabelDagensDatoTid"
        Me.LabelDagensDatoTid.Size = New System.Drawing.Size(78, 29)
        Me.LabelDagensDatoTid.TabIndex = 13
        Me.LabelDagensDatoTid.Text = "Label7"
        '
        'LabelVelkommen
        '
        Me.LabelVelkommen.AutoSize = True
        Me.LabelVelkommen.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelVelkommen.Location = New System.Drawing.Point(43, 89)
        Me.LabelVelkommen.Name = "LabelVelkommen"
        Me.LabelVelkommen.Size = New System.Drawing.Size(78, 29)
        Me.LabelVelkommen.TabIndex = 14
        Me.LabelVelkommen.Text = "Label8"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1188, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(16, 601)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(16, 601)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(16, 612)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1172, 16)
        Me.Panel3.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelVelkommen)
        Me.GroupBox1.Controls.Add(Me.loggUtBtn)
        Me.GroupBox1.Controls.Add(Me.LabelDagensDatoTid)
        Me.GroupBox1.Controls.Add(Me.LabelDagensDato)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(422, 412)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelTid)
        Me.GroupBox2.Controls.Add(Me.dagensTimer)
        Me.GroupBox2.Controls.Add(Me.LabelNavn)
        Me.GroupBox2.Controls.Add(Me.LabelTimerForDagen)
        Me.GroupBox2.Location = New System.Drawing.Point(428, 2)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(454, 412)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'guiPanel
        '
        Me.guiPanel.Controls.Add(Me.GroupBox2)
        Me.guiPanel.Controls.Add(Me.GroupBox1)
        Me.guiPanel.Location = New System.Drawing.Point(50, 112)
        Me.guiPanel.Name = "guiPanel"
        Me.guiPanel.Size = New System.Drawing.Size(885, 416)
        Me.guiPanel.TabIndex = 20
        '
        'Startside
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1204, 628)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.guiPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Startside"
        Me.Text = "Startside"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.guiPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loggUtBtn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HjemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduktoversiktToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InnkallingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BestillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrerBlodgivingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelDagensDato As Label
    Friend WithEvents LabelTimerForDagen As Label
    Friend WithEvents dagensTimer As ListBox
    Friend WithEvents LabelNavn As Label
    Friend WithEvents LabelTid As Label
    Friend WithEvents LabelDagensDatoTid As Label
    Friend WithEvents LabelVelkommen As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents guiPanel As Panel
End Class
