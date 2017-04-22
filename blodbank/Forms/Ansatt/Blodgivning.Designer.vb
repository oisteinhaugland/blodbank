<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Blodgivning
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Blodgivning))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HjemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduktoversiktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InnkallingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrerBlodgivingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelBlodgiverID = New System.Windows.Forms.Label()
        Me.LabelMengdePlasma = New System.Windows.Forms.Label()
        Me.LabelMengdeBlodlegemer = New System.Windows.Forms.Label()
        Me.LabelMengdeBlodplater = New System.Windows.Forms.Label()
        Me.LabelDatoBlodtapp = New System.Windows.Forms.Label()
        Me.LagreBlodtapp = New System.Windows.Forms.Button()
        Me.IDtekst = New System.Windows.Forms.TextBox()
        Me.plasmaTekst = New System.Windows.Forms.TextBox()
        Me.blodlegemeTekst = New System.Windows.Forms.TextBox()
        Me.blodplateTekst = New System.Windows.Forms.TextBox()
        Me.TappeDato = New System.Windows.Forms.TextBox()
        Me.blodTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.bGiverIdTextBox = New System.Windows.Forms.TextBox()
        Me.registrerBlodtypeKnapp = New System.Windows.Forms.Button()
        Me.blodprosentTekst = New System.Windows.Forms.TextBox()
        Me.registrerBlodTappGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelBlodProsent = New System.Windows.Forms.Label()
        Me.registrerBlodtypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.guiPanel = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.registrerBlodTappGroupBox.SuspendLayout()
        Me.registrerBlodtypeGroupBox.SuspendLayout()
        Me.guiPanel.SuspendLayout()
        Me.SuspendLayout()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1213, 27)
        Me.MenuStrip1.TabIndex = 9
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
        'LabelBlodgiverID
        '
        Me.LabelBlodgiverID.AutoSize = True
        Me.LabelBlodgiverID.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBlodgiverID.Location = New System.Drawing.Point(23, 32)
        Me.LabelBlodgiverID.Name = "LabelBlodgiverID"
        Me.LabelBlodgiverID.Size = New System.Drawing.Size(112, 23)
        Me.LabelBlodgiverID.TabIndex = 10
        Me.LabelBlodgiverID.Text = "Blodgiver ID:"
        '
        'LabelMengdePlasma
        '
        Me.LabelMengdePlasma.AutoSize = True
        Me.LabelMengdePlasma.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMengdePlasma.Location = New System.Drawing.Point(23, 67)
        Me.LabelMengdePlasma.Name = "LabelMengdePlasma"
        Me.LabelMengdePlasma.Size = New System.Drawing.Size(141, 23)
        Me.LabelMengdePlasma.TabIndex = 12
        Me.LabelMengdePlasma.Text = "Mendge plasma:"
        '
        'LabelMengdeBlodlegemer
        '
        Me.LabelMengdeBlodlegemer.AutoSize = True
        Me.LabelMengdeBlodlegemer.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMengdeBlodlegemer.Location = New System.Drawing.Point(23, 101)
        Me.LabelMengdeBlodlegemer.Name = "LabelMengdeBlodlegemer"
        Me.LabelMengdeBlodlegemer.Size = New System.Drawing.Size(186, 23)
        Me.LabelMengdeBlodlegemer.TabIndex = 13
        Me.LabelMengdeBlodlegemer.Text = "Mengde blodlegemer:"
        '
        'LabelMengdeBlodplater
        '
        Me.LabelMengdeBlodplater.AutoSize = True
        Me.LabelMengdeBlodplater.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMengdeBlodplater.Location = New System.Drawing.Point(23, 140)
        Me.LabelMengdeBlodplater.Name = "LabelMengdeBlodplater"
        Me.LabelMengdeBlodplater.Size = New System.Drawing.Size(168, 23)
        Me.LabelMengdeBlodplater.TabIndex = 14
        Me.LabelMengdeBlodplater.Text = "Mengde blodplater:"
        '
        'LabelDatoBlodtapp
        '
        Me.LabelDatoBlodtapp.AutoSize = True
        Me.LabelDatoBlodtapp.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDatoBlodtapp.Location = New System.Drawing.Point(23, 209)
        Me.LabelDatoBlodtapp.Name = "LabelDatoBlodtapp"
        Me.LabelDatoBlodtapp.Size = New System.Drawing.Size(155, 23)
        Me.LabelDatoBlodtapp.TabIndex = 15
        Me.LabelDatoBlodtapp.Text = "Dato for blodtapp:"
        '
        'LagreBlodtapp
        '
        Me.LagreBlodtapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LagreBlodtapp.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LagreBlodtapp.Location = New System.Drawing.Point(11, 271)
        Me.LagreBlodtapp.Name = "LagreBlodtapp"
        Me.LagreBlodtapp.Size = New System.Drawing.Size(439, 86)
        Me.LagreBlodtapp.TabIndex = 16
        Me.LagreBlodtapp.Text = "Lagre informasjon"
        Me.LagreBlodtapp.UseVisualStyleBackColor = False
        '
        'IDtekst
        '
        Me.IDtekst.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDtekst.Location = New System.Drawing.Point(209, 33)
        Me.IDtekst.Name = "IDtekst"
        Me.IDtekst.Size = New System.Drawing.Size(133, 24)
        Me.IDtekst.TabIndex = 17
        '
        'plasmaTekst
        '
        Me.plasmaTekst.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plasmaTekst.Location = New System.Drawing.Point(209, 68)
        Me.plasmaTekst.Name = "plasmaTekst"
        Me.plasmaTekst.Size = New System.Drawing.Size(133, 24)
        Me.plasmaTekst.TabIndex = 19
        '
        'blodlegemeTekst
        '
        Me.blodlegemeTekst.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blodlegemeTekst.Location = New System.Drawing.Point(209, 102)
        Me.blodlegemeTekst.Name = "blodlegemeTekst"
        Me.blodlegemeTekst.Size = New System.Drawing.Size(133, 24)
        Me.blodlegemeTekst.TabIndex = 20
        '
        'blodplateTekst
        '
        Me.blodplateTekst.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blodplateTekst.Location = New System.Drawing.Point(209, 141)
        Me.blodplateTekst.Name = "blodplateTekst"
        Me.blodplateTekst.Size = New System.Drawing.Size(133, 24)
        Me.blodplateTekst.TabIndex = 21
        '
        'TappeDato
        '
        Me.TappeDato.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TappeDato.Location = New System.Drawing.Point(209, 208)
        Me.TappeDato.Name = "TappeDato"
        Me.TappeDato.Size = New System.Drawing.Size(133, 24)
        Me.TappeDato.TabIndex = 22
        '
        'blodTypeComboBox
        '
        Me.blodTypeComboBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.blodTypeComboBox.FormattingEnabled = True
        Me.blodTypeComboBox.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.blodTypeComboBox.Location = New System.Drawing.Point(142, 101)
        Me.blodTypeComboBox.Name = "blodTypeComboBox"
        Me.blodTypeComboBox.Size = New System.Drawing.Size(165, 31)
        Me.blodTypeComboBox.TabIndex = 26
        '
        'bGiverIdTextBox
        '
        Me.bGiverIdTextBox.Location = New System.Drawing.Point(142, 59)
        Me.bGiverIdTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.bGiverIdTextBox.Name = "bGiverIdTextBox"
        Me.bGiverIdTextBox.Size = New System.Drawing.Size(165, 31)
        Me.bGiverIdTextBox.TabIndex = 28
        '
        'registrerBlodtypeKnapp
        '
        Me.registrerBlodtypeKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.registrerBlodtypeKnapp.Location = New System.Drawing.Point(6, 271)
        Me.registrerBlodtypeKnapp.Margin = New System.Windows.Forms.Padding(2)
        Me.registrerBlodtypeKnapp.Name = "registrerBlodtypeKnapp"
        Me.registrerBlodtypeKnapp.Size = New System.Drawing.Size(349, 86)
        Me.registrerBlodtypeKnapp.TabIndex = 29
        Me.registrerBlodtypeKnapp.Text = "Registrer"
        Me.registrerBlodtypeKnapp.UseVisualStyleBackColor = False
        '
        'blodprosentTekst
        '
        Me.blodprosentTekst.Font = New System.Drawing.Font("Calibri", 10.2!)
        Me.blodprosentTekst.Location = New System.Drawing.Point(209, 176)
        Me.blodprosentTekst.Margin = New System.Windows.Forms.Padding(2)
        Me.blodprosentTekst.Name = "blodprosentTekst"
        Me.blodprosentTekst.Size = New System.Drawing.Size(133, 24)
        Me.blodprosentTekst.TabIndex = 31
        '
        'registrerBlodTappGroupBox
        '
        Me.registrerBlodTappGroupBox.Controls.Add(Me.Label2)
        Me.registrerBlodTappGroupBox.Controls.Add(Me.LabelBlodProsent)
        Me.registrerBlodTappGroupBox.Controls.Add(Me.blodprosentTekst)
        Me.registrerBlodTappGroupBox.Controls.Add(Me.TappeDato)
        Me.registrerBlodTappGroupBox.Controls.Add(Me.LabelBlodgiverID)
        Me.registrerBlodTappGroupBox.Controls.Add(Me.LagreBlodtapp)
        Me.registrerBlodTappGroupBox.Controls.Add(Me.blodplateTekst)
        Me.registrerBlodTappGroupBox.Controls.Add(Me.LabelMengdePlasma)
        Me.registrerBlodTappGroupBox.Controls.Add(Me.blodlegemeTekst)
        Me.registrerBlodTappGroupBox.Controls.Add(Me.LabelMengdeBlodlegemer)
        Me.registrerBlodTappGroupBox.Controls.Add(Me.plasmaTekst)
        Me.registrerBlodTappGroupBox.Controls.Add(Me.LabelMengdeBlodplater)
        Me.registrerBlodTappGroupBox.Controls.Add(Me.IDtekst)
        Me.registrerBlodTappGroupBox.Controls.Add(Me.LabelDatoBlodtapp)
        Me.registrerBlodTappGroupBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrerBlodTappGroupBox.Location = New System.Drawing.Point(4, 2)
        Me.registrerBlodTappGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.registrerBlodTappGroupBox.Name = "registrerBlodTappGroupBox"
        Me.registrerBlodTappGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.registrerBlodTappGroupBox.Size = New System.Drawing.Size(469, 370)
        Me.registrerBlodTappGroupBox.TabIndex = 30
        Me.registrerBlodTappGroupBox.TabStop = False
        Me.registrerBlodTappGroupBox.Text = "Registrer blodtapping:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 23)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "dd.mm.åååå"
        '
        'LabelBlodProsent
        '
        Me.LabelBlodProsent.AutoSize = True
        Me.LabelBlodProsent.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBlodProsent.Location = New System.Drawing.Point(23, 175)
        Me.LabelBlodProsent.Name = "LabelBlodProsent"
        Me.LabelBlodProsent.Size = New System.Drawing.Size(108, 23)
        Me.LabelBlodProsent.TabIndex = 32
        Me.LabelBlodProsent.Text = "Blodprosent"
        '
        'registrerBlodtypeGroupBox
        '
        Me.registrerBlodtypeGroupBox.Controls.Add(Me.Label11)
        Me.registrerBlodtypeGroupBox.Controls.Add(Me.Label10)
        Me.registrerBlodtypeGroupBox.Controls.Add(Me.registrerBlodtypeKnapp)
        Me.registrerBlodtypeGroupBox.Controls.Add(Me.bGiverIdTextBox)
        Me.registrerBlodtypeGroupBox.Controls.Add(Me.blodTypeComboBox)
        Me.registrerBlodtypeGroupBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrerBlodtypeGroupBox.Location = New System.Drawing.Point(489, 2)
        Me.registrerBlodtypeGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.registrerBlodtypeGroupBox.Name = "registrerBlodtypeGroupBox"
        Me.registrerBlodtypeGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.registrerBlodtypeGroupBox.Size = New System.Drawing.Size(410, 370)
        Me.registrerBlodtypeGroupBox.TabIndex = 31
        Me.registrerBlodtypeGroupBox.TabStop = False
        Me.registrerBlodtypeGroupBox.Text = "Registrer blodtype til blodgiver"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 23)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Blodtype"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 23)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Blodgiver ID:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1197, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(16, 601)
        Me.Panel1.TabIndex = 32
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(16, 601)
        Me.Panel2.TabIndex = 33
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(16, 612)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1181, 16)
        Me.Panel3.TabIndex = 34
        '
        'guiPanel
        '
        Me.guiPanel.Controls.Add(Me.registrerBlodTappGroupBox)
        Me.guiPanel.Controls.Add(Me.registrerBlodtypeGroupBox)
        Me.guiPanel.Location = New System.Drawing.Point(45, 98)
        Me.guiPanel.Name = "guiPanel"
        Me.guiPanel.Size = New System.Drawing.Size(905, 382)
        Me.guiPanel.TabIndex = 35
        '
        'Blodgivning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1213, 628)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.guiPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Blodgivning"
        Me.Text = "Registrer blodgiving"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.registrerBlodTappGroupBox.ResumeLayout(False)
        Me.registrerBlodTappGroupBox.PerformLayout()
        Me.registrerBlodtypeGroupBox.ResumeLayout(False)
        Me.registrerBlodtypeGroupBox.PerformLayout()
        Me.guiPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HjemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduktoversiktToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InnkallingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BestillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrerBlodgivingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelBlodgiverID As Label
    Friend WithEvents LabelMengdePlasma As Label
    Friend WithEvents LabelMengdeBlodlegemer As Label
    Friend WithEvents LabelMengdeBlodplater As Label
    Friend WithEvents LabelDatoBlodtapp As Label
    Friend WithEvents LagreBlodtapp As Button
    Friend WithEvents IDtekst As TextBox
    Friend WithEvents plasmaTekst As TextBox
    Friend WithEvents blodlegemeTekst As TextBox
    Friend WithEvents blodplateTekst As TextBox
    Friend WithEvents TappeDato As TextBox
    Friend WithEvents blodTypeComboBox As ComboBox
    Friend WithEvents bGiverIdTextBox As TextBox
    Friend WithEvents registrerBlodtypeKnapp As Button
    Friend WithEvents Label8 As Label

    'Friend WithEvents Label8 As Label
    Friend WithEvents blodprosentTekst As TextBox

    Friend WithEvents registrerBlodTappGroupBox As GroupBox
    Friend WithEvents registrerBlodtypeGroupBox As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelBlodProsent As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents guiPanel As Panel
End Class
