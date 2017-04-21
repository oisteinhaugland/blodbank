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
        Me.Button5 = New System.Windows.Forms.Button()
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.utleveringLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'motatteBestillinger
        '
        Me.motatteBestillinger.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.motatteBestillinger.FormattingEnabled = True
        Me.motatteBestillinger.ItemHeight = 19
        Me.motatteBestillinger.Location = New System.Drawing.Point(15, 125)
        Me.motatteBestillinger.Name = "motatteBestillinger"
        Me.motatteBestillinger.Size = New System.Drawing.Size(609, 289)
        Me.motatteBestillinger.TabIndex = 0
        '
        'bekreft_Utlevering
        '
        Me.bekreft_Utlevering.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.bekreft_Utlevering.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bekreft_Utlevering.Location = New System.Drawing.Point(21, 314)
        Me.bekreft_Utlevering.Name = "bekreft_Utlevering"
        Me.bekreft_Utlevering.Size = New System.Drawing.Size(287, 88)
        Me.bekreft_Utlevering.TabIndex = 1
        Me.bekreft_Utlevering.Text = "Bekreft utlevering"
        Me.bekreft_Utlevering.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(15, 18)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(608, 88)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Hent ut motatte bestillinger"
        Me.Button5.UseVisualStyleBackColor = False
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
        Me.vareLagerListBox.Location = New System.Drawing.Point(21, 125)
        Me.vareLagerListBox.Name = "vareLagerListBox"
        Me.vareLagerListBox.Size = New System.Drawing.Size(288, 175)
        Me.vareLagerListBox.TabIndex = 12
        '
        'søkLagerBtn
        '
        Me.søkLagerBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.søkLagerBtn.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.søkLagerBtn.Location = New System.Drawing.Point(21, 18)
        Me.søkLagerBtn.Name = "søkLagerBtn"
        Me.søkLagerBtn.Size = New System.Drawing.Size(287, 88)
        Me.søkLagerBtn.TabIndex = 13
        Me.søkLagerBtn.Text = "Hent produkter basert på bestilling"
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
        Me.GroupBox1.Controls.Add(Me.motatteBestillinger)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(69, 160)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(637, 452)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.05702!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.94298!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(16, 27)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.89396!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.10604!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1160, 614)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.søkLagerBtn)
        Me.GroupBox2.Controls.Add(Me.vareLagerListBox)
        Me.GroupBox2.Controls.Add(Me.bekreft_Utlevering)
        Me.GroupBox2.Controls.Add(Me.utleveringLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(710, 160)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(338, 451)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'utleveringLabel
        '
        Me.utleveringLabel.AutoSize = True
        Me.utleveringLabel.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.utleveringLabel.Location = New System.Drawing.Point(4, 417)
        Me.utleveringLabel.Name = "utleveringLabel"
        Me.utleveringLabel.Size = New System.Drawing.Size(342, 23)
        Me.utleveringLabel.TabIndex = 10
        Me.utleveringLabel.Text = "Utlevering vellykket, varelager er oppdatert"
        '
        'Bestillinger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1192, 628)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Bestillinger"
        Me.Text = "Bestillinger"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents motatteBestillinger As ListBox
    Friend WithEvents bekreft_Utlevering As Button
    Friend WithEvents Button5 As Button
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents utleveringLabel As Label
End Class
