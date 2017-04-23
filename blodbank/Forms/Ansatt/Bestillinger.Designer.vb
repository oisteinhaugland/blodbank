<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bestillinger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bestillinger))
        Me.motatteBestillinger = New System.Windows.Forms.ListBox()
        Me.bekreft_Utlevering = New System.Windows.Forms.Button()
        Me.hentBestillinger = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HjemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduktoversiktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InnkallingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrerBlodgivingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.vareLagerListBox = New System.Windows.Forms.ListBox()
        Me.søkLagerBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelEgeneskap = New System.Windows.Forms.Label()
        Me.LabelBestillingID = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.utleveringLabel = New System.Windows.Forms.Label()
        Me.guiPanel = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.guiPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'motatteBestillinger
        '
        Me.motatteBestillinger.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.motatteBestillinger.FormattingEnabled = True
        Me.motatteBestillinger.ItemHeight = 19
        Me.motatteBestillinger.Location = New System.Drawing.Point(15, 138)
        Me.motatteBestillinger.Name = "motatteBestillinger"
        Me.motatteBestillinger.Size = New System.Drawing.Size(609, 289)
        Me.motatteBestillinger.TabIndex = 0
        '
        'bekreft_Utlevering
        '
        Me.bekreft_Utlevering.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bekreft_Utlevering.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bekreft_Utlevering.Location = New System.Drawing.Point(21, 332)
        Me.bekreft_Utlevering.Name = "bekreft_Utlevering"
        Me.bekreft_Utlevering.Size = New System.Drawing.Size(287, 88)
        Me.bekreft_Utlevering.TabIndex = 4
        Me.bekreft_Utlevering.Text = "Bekreft utlevering"
        Me.bekreft_Utlevering.UseVisualStyleBackColor = False
        '
        'hentBestillinger
        '
        Me.hentBestillinger.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.hentBestillinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.hentBestillinger.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hentBestillinger.Location = New System.Drawing.Point(15, 18)
        Me.hentBestillinger.Name = "hentBestillinger"
        Me.hentBestillinger.Size = New System.Drawing.Size(608, 88)
        Me.hentBestillinger.TabIndex = 1
        Me.hentBestillinger.Text = "Hent ut motatte bestillinger"
        Me.hentBestillinger.UseVisualStyleBackColor = False
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1192, 27)
        Me.MenuStrip1.TabIndex = 11
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
        'vareLagerListBox
        '
        Me.vareLagerListBox.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.vareLagerListBox.FormattingEnabled = True
        Me.vareLagerListBox.ItemHeight = 19
        Me.vareLagerListBox.Location = New System.Drawing.Point(21, 149)
        Me.vareLagerListBox.Name = "vareLagerListBox"
        Me.vareLagerListBox.Size = New System.Drawing.Size(288, 175)
        Me.vareLagerListBox.TabIndex = 3
        '
        'søkLagerBtn
        '
        Me.søkLagerBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.søkLagerBtn.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.søkLagerBtn.Location = New System.Drawing.Point(21, 18)
        Me.søkLagerBtn.Name = "søkLagerBtn"
        Me.søkLagerBtn.Size = New System.Drawing.Size(287, 88)
        Me.søkLagerBtn.TabIndex = 2
        Me.søkLagerBtn.Text = "Vis tilgjengelige produkter"
        Me.søkLagerBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1176, 27)
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
        Me.Panel3.Size = New System.Drawing.Size(1160, 16)
        Me.Panel3.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LabelEgeneskap)
        Me.GroupBox1.Controls.Add(Me.LabelBestillingID)
        Me.GroupBox1.Controls.Add(Me.motatteBestillinger)
        Me.GroupBox1.Controls.Add(Me.hentBestillinger)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(637, 452)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(512, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ordre Dato"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(394, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Antall"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(265, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Blodtype"
        '
        'LabelEgeneskap
        '
        Me.LabelEgeneskap.AutoSize = True
        Me.LabelEgeneskap.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LabelEgeneskap.Location = New System.Drawing.Point(153, 112)
        Me.LabelEgeneskap.Name = "LabelEgeneskap"
        Me.LabelEgeneskap.Size = New System.Drawing.Size(84, 23)
        Me.LabelEgeneskap.TabIndex = 7
        Me.LabelEgeneskap.Text = "Egenskap"
        '
        'LabelBestillingID
        '
        Me.LabelBestillingID.AutoSize = True
        Me.LabelBestillingID.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold)
        Me.LabelBestillingID.Location = New System.Drawing.Point(11, 112)
        Me.LabelBestillingID.Name = "LabelBestillingID"
        Me.LabelBestillingID.Size = New System.Drawing.Size(113, 23)
        Me.LabelBestillingID.TabIndex = 6
        Me.LabelBestillingID.Text = "Bestillings ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.søkLagerBtn)
        Me.GroupBox2.Controls.Add(Me.vareLagerListBox)
        Me.GroupBox2.Controls.Add(Me.bekreft_Utlevering)
        Me.GroupBox2.Controls.Add(Me.utleveringLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(643, 3)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(364, 451)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(148, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 23)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Egenskap"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(50, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 23)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Blodtype"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(17, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ID"
        '
        'utleveringLabel
        '
        Me.utleveringLabel.AutoSize = True
        Me.utleveringLabel.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.utleveringLabel.Location = New System.Drawing.Point(17, 423)
        Me.utleveringLabel.Name = "utleveringLabel"
        Me.utleveringLabel.Size = New System.Drawing.Size(342, 23)
        Me.utleveringLabel.TabIndex = 10
        Me.utleveringLabel.Text = "Utlevering vellykket, varelager er oppdatert"
        '
        'guiPanel
        '
        Me.guiPanel.Controls.Add(Me.GroupBox1)
        Me.guiPanel.Controls.Add(Me.GroupBox2)
        Me.guiPanel.Location = New System.Drawing.Point(35, 42)
        Me.guiPanel.Name = "guiPanel"
        Me.guiPanel.Size = New System.Drawing.Size(1016, 460)
        Me.guiPanel.TabIndex = 6
        '
        'Bestillinger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1192, 628)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.guiPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Bestillinger"
        Me.Text = "Bestillinger"
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

    Friend WithEvents motatteBestillinger As ListBox
    Friend WithEvents bekreft_Utlevering As Button
    Friend WithEvents hentBestillinger As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HjemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduktoversiktToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InnkallingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BestillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrerBlodgivingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents vareLagerListBox As ListBox
    Friend WithEvents søkLagerBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents utleveringLabel As Label
    Friend WithEvents guiPanel As Panel
    Friend WithEvents LabelBestillingID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelEgeneskap As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
