<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InnkallingAnsatt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InnkallingAnsatt))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HjemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduktoversiktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InnkallingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisrerBlodgivingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HasteInnkallingKnapp = New System.Windows.Forms.Button()
        Me.NormalInnkallingKnapp = New System.Windows.Forms.Button()
        Me.klareBlodgivere = New System.Windows.Forms.ListBox()
        Me.blodInfoKnapp = New System.Windows.Forms.Button()
        Me.ledigeTimerKalender = New System.Windows.Forms.MonthCalendar()
        Me.ledigeTimer = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelFornavn = New System.Windows.Forms.Label()
        Me.LabelEpost = New System.Windows.Forms.Label()
        Me.LabelTlf = New System.Windows.Forms.Label()
        Me.LabelEtterNavn = New System.Windows.Forms.Label()
        Me.LabelBlodtype = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.velgBlogivereGroupBox = New System.Windows.Forms.GroupBox()
        Me.datoOgTidspunktGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.guiPanel = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.velgBlogivereGroupBox.SuspendLayout()
        Me.datoOgTidspunktGroupBox.SuspendLayout()
        Me.guiPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HjemToolStripMenuItem, Me.ProduktoversiktToolStripMenuItem, Me.InnkallingToolStripMenuItem, Me.BestillingToolStripMenuItem, Me.RegisrerBlodgivingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1179, 27)
        Me.MenuStrip1.TabIndex = 8
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
        'RegisrerBlodgivingToolStripMenuItem
        '
        Me.RegisrerBlodgivingToolStripMenuItem.Name = "RegisrerBlodgivingToolStripMenuItem"
        Me.RegisrerBlodgivingToolStripMenuItem.Size = New System.Drawing.Size(151, 23)
        Me.RegisrerBlodgivingToolStripMenuItem.Text = "Registrer blodgiving"
        '
        'HasteInnkallingKnapp
        '
        Me.HasteInnkallingKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.HasteInnkallingKnapp.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HasteInnkallingKnapp.Location = New System.Drawing.Point(281, 287)
        Me.HasteInnkallingKnapp.Name = "HasteInnkallingKnapp"
        Me.HasteInnkallingKnapp.Size = New System.Drawing.Size(242, 86)
        Me.HasteInnkallingKnapp.TabIndex = 10
        Me.HasteInnkallingKnapp.Text = "Send hasteinnkalling"
        Me.HasteInnkallingKnapp.UseVisualStyleBackColor = False
        '
        'NormalInnkallingKnapp
        '
        Me.NormalInnkallingKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.NormalInnkallingKnapp.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NormalInnkallingKnapp.Location = New System.Drawing.Point(13, 287)
        Me.NormalInnkallingKnapp.Name = "NormalInnkallingKnapp"
        Me.NormalInnkallingKnapp.Size = New System.Drawing.Size(256, 86)
        Me.NormalInnkallingKnapp.TabIndex = 9
        Me.NormalInnkallingKnapp.Text = "Send normal innkalling (e-post)"
        Me.NormalInnkallingKnapp.UseVisualStyleBackColor = False
        '
        'klareBlodgivere
        '
        Me.klareBlodgivere.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.klareBlodgivere.FormattingEnabled = True
        Me.klareBlodgivere.ItemHeight = 18
        Me.klareBlodgivere.Location = New System.Drawing.Point(14, 80)
        Me.klareBlodgivere.Name = "klareBlodgivere"
        Me.klareBlodgivere.Size = New System.Drawing.Size(496, 166)
        Me.klareBlodgivere.TabIndex = 12
        '
        'blodInfoKnapp
        '
        Me.blodInfoKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.blodInfoKnapp.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blodInfoKnapp.Location = New System.Drawing.Point(14, 287)
        Me.blodInfoKnapp.Name = "blodInfoKnapp"
        Me.blodInfoKnapp.Size = New System.Drawing.Size(495, 86)
        Me.blodInfoKnapp.TabIndex = 16
        Me.blodInfoKnapp.Text = "Hent blodgiverinformasjon"
        Me.blodInfoKnapp.UseVisualStyleBackColor = False
        '
        'ledigeTimerKalender
        '
        Me.ledigeTimerKalender.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ledigeTimerKalender.Location = New System.Drawing.Point(21, 80)
        Me.ledigeTimerKalender.Name = "ledigeTimerKalender"
        Me.ledigeTimerKalender.TabIndex = 18
        '
        'ledigeTimer
        '
        Me.ledigeTimer.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.ledigeTimer.FormattingEnabled = True
        Me.ledigeTimer.ItemHeight = 19
        Me.ledigeTimer.Location = New System.Drawing.Point(288, 89)
        Me.ledigeTimer.Name = "ledigeTimer"
        Me.ledigeTimer.Size = New System.Drawing.Size(221, 156)
        Me.ledigeTimer.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(278, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 23)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Ledige timer:"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(15, 46)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(27, 23)
        Me.LabelID.TabIndex = 22
        Me.LabelID.Text = "ID"
        '
        'LabelFornavn
        '
        Me.LabelFornavn.AutoSize = True
        Me.LabelFornavn.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFornavn.Location = New System.Drawing.Point(71, 46)
        Me.LabelFornavn.Name = "LabelFornavn"
        Me.LabelFornavn.Size = New System.Drawing.Size(74, 23)
        Me.LabelFornavn.TabIndex = 23
        Me.LabelFornavn.Text = "Fornavn"
        '
        'LabelEpost
        '
        Me.LabelEpost.AutoSize = True
        Me.LabelEpost.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEpost.Location = New System.Drawing.Point(244, 47)
        Me.LabelEpost.Name = "LabelEpost"
        Me.LabelEpost.Size = New System.Drawing.Size(54, 23)
        Me.LabelEpost.TabIndex = 25
        Me.LabelEpost.Text = "Epost"
        '
        'LabelTlf
        '
        Me.LabelTlf.AutoSize = True
        Me.LabelTlf.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTlf.Location = New System.Drawing.Point(316, 47)
        Me.LabelTlf.Name = "LabelTlf"
        Me.LabelTlf.Size = New System.Drawing.Size(68, 23)
        Me.LabelTlf.TabIndex = 26
        Me.LabelTlf.Text = "Telefon"
        '
        'LabelEtterNavn
        '
        Me.LabelEtterNavn.AutoSize = True
        Me.LabelEtterNavn.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEtterNavn.Location = New System.Drawing.Point(148, 47)
        Me.LabelEtterNavn.Name = "LabelEtterNavn"
        Me.LabelEtterNavn.Size = New System.Drawing.Size(86, 23)
        Me.LabelEtterNavn.TabIndex = 27
        Me.LabelEtterNavn.Text = "Etternavn"
        '
        'LabelBlodtype
        '
        Me.LabelBlodtype.AutoSize = True
        Me.LabelBlodtype.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBlodtype.Location = New System.Drawing.Point(400, 47)
        Me.LabelBlodtype.Name = "LabelBlodtype"
        Me.LabelBlodtype.Size = New System.Drawing.Size(82, 23)
        Me.LabelBlodtype.TabIndex = 28
        Me.LabelBlodtype.Text = "Blodtype"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1163, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(16, 601)
        Me.Panel1.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(16, 601)
        Me.Panel2.TabIndex = 31
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(16, 612)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1147, 16)
        Me.Panel3.TabIndex = 32
        '
        'velgBlogivereGroupBox
        '
        Me.velgBlogivereGroupBox.Controls.Add(Me.klareBlodgivere)
        Me.velgBlogivereGroupBox.Controls.Add(Me.blodInfoKnapp)
        Me.velgBlogivereGroupBox.Controls.Add(Me.LabelID)
        Me.velgBlogivereGroupBox.Controls.Add(Me.LabelFornavn)
        Me.velgBlogivereGroupBox.Controls.Add(Me.LabelEpost)
        Me.velgBlogivereGroupBox.Controls.Add(Me.LabelBlodtype)
        Me.velgBlogivereGroupBox.Controls.Add(Me.LabelTlf)
        Me.velgBlogivereGroupBox.Controls.Add(Me.LabelEtterNavn)
        Me.velgBlogivereGroupBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.velgBlogivereGroupBox.Location = New System.Drawing.Point(2, 2)
        Me.velgBlogivereGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.velgBlogivereGroupBox.Name = "velgBlogivereGroupBox"
        Me.velgBlogivereGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.velgBlogivereGroupBox.Size = New System.Drawing.Size(530, 390)
        Me.velgBlogivereGroupBox.TabIndex = 33
        Me.velgBlogivereGroupBox.TabStop = False
        Me.velgBlogivereGroupBox.Text = "Velg blodgiver med godkjent egenerklæring:"
        '
        'datoOgTidspunktGroupBox
        '
        Me.datoOgTidspunktGroupBox.Controls.Add(Me.Label2)
        Me.datoOgTidspunktGroupBox.Controls.Add(Me.ledigeTimer)
        Me.datoOgTidspunktGroupBox.Controls.Add(Me.NormalInnkallingKnapp)
        Me.datoOgTidspunktGroupBox.Controls.Add(Me.HasteInnkallingKnapp)
        Me.datoOgTidspunktGroupBox.Controls.Add(Me.ledigeTimerKalender)
        Me.datoOgTidspunktGroupBox.Controls.Add(Me.Label4)
        Me.datoOgTidspunktGroupBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datoOgTidspunktGroupBox.Location = New System.Drawing.Point(541, 2)
        Me.datoOgTidspunktGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.datoOgTidspunktGroupBox.Name = "datoOgTidspunktGroupBox"
        Me.datoOgTidspunktGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.datoOgTidspunktGroupBox.Size = New System.Drawing.Size(535, 390)
        Me.datoOgTidspunktGroupBox.TabIndex = 34
        Me.datoOgTidspunktGroupBox.TabStop = False
        Me.datoOgTidspunktGroupBox.Text = "Velg dato og tidspunkt:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Ledige timer:"
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInfo.Location = New System.Drawing.Point(550, 394)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(41, 23)
        Me.LabelInfo.TabIndex = 29
        Me.LabelInfo.Text = "Info"
        '
        'guiPanel
        '
        Me.guiPanel.Controls.Add(Me.LabelInfo)
        Me.guiPanel.Controls.Add(Me.velgBlogivereGroupBox)
        Me.guiPanel.Controls.Add(Me.datoOgTidspunktGroupBox)
        Me.guiPanel.Location = New System.Drawing.Point(37, 52)
        Me.guiPanel.Name = "guiPanel"
        Me.guiPanel.Size = New System.Drawing.Size(1080, 482)
        Me.guiPanel.TabIndex = 35
        '
        'InnkallingAnsatt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1179, 628)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.guiPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "InnkallingAnsatt"
        Me.Text = "Innkalling"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.velgBlogivereGroupBox.ResumeLayout(False)
        Me.velgBlogivereGroupBox.PerformLayout()
        Me.datoOgTidspunktGroupBox.ResumeLayout(False)
        Me.datoOgTidspunktGroupBox.PerformLayout()
        Me.guiPanel.ResumeLayout(False)
        Me.guiPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HjemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduktoversiktToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InnkallingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BestillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HasteInnkallingKnapp As Button
    Friend WithEvents NormalInnkallingKnapp As Button
    Friend WithEvents klareBlodgivere As ListBox
    Friend WithEvents blodInfoKnapp As Button
    Friend WithEvents RegisrerBlodgivingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ledigeTimerKalender As MonthCalendar
    Friend WithEvents ledigeTimer As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelFornavn As Label
    Friend WithEvents LabelEpost As Label
    Friend WithEvents LabelTlf As Label
    Friend WithEvents LabelEtterNavn As Label
    Friend WithEvents LabelBlodtype As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents velgBlogivereGroupBox As GroupBox
    Friend WithEvents datoOgTidspunktGroupBox As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelInfo As Label
    Friend WithEvents guiPanel As Panel
End Class
