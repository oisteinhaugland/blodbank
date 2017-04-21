<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registrerBlodgiver
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registrerBlodgiver))
        Me.fornavnTextbox = New System.Windows.Forms.TextBox()
        Me.epostTextbox = New System.Windows.Forms.TextBox()
        Me.etterNavnTextBox = New System.Windows.Forms.TextBox()
        Me.passordTextBox = New System.Windows.Forms.TextBox()
        Me.fornavnLabel = New System.Windows.Forms.Label()
        Me.epostLabel = New System.Windows.Forms.Label()
        Me.etterNavnLabel = New System.Windows.Forms.Label()
        Me.passordLabel = New System.Windows.Forms.Label()
        Me.gjenntaPassordTextbox = New System.Windows.Forms.TextBox()
        Me.gjentaPassordLabel = New System.Windows.Forms.Label()
        Me.personNrTextBox = New System.Windows.Forms.TextBox()
        Me.personNrLabel = New System.Windows.Forms.Label()
        Me.registrerBrukerKnapp = New System.Windows.Forms.Button()
        Me.telefonTextBox = New System.Windows.Forms.TextBox()
        Me.telefonLabel = New System.Windows.Forms.Label()
        Me.fødselsdatoLabel = New System.Windows.Forms.Label()
        Me.fodselsdatoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.adresseLabel = New System.Windows.Forms.Label()
        Me.adresseTextBox = New System.Windows.Forms.TextBox()
        Me.postnrLabel = New System.Windows.Forms.Label()
        Me.postNrTextBox = New System.Windows.Forms.TextBox()
        Me.poststedTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FileSystemWatcher2 = New System.IO.FileSystemWatcher()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.FileSystemWatcher2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fornavnTextbox
        '
        Me.fornavnTextbox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fornavnTextbox.Location = New System.Drawing.Point(3, 5)
        Me.fornavnTextbox.Name = "fornavnTextbox"
        Me.fornavnTextbox.Size = New System.Drawing.Size(139, 24)
        Me.fornavnTextbox.TabIndex = 0
        '
        'epostTextbox
        '
        Me.epostTextbox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.epostTextbox.Location = New System.Drawing.Point(3, 96)
        Me.epostTextbox.Name = "epostTextbox"
        Me.epostTextbox.Size = New System.Drawing.Size(139, 24)
        Me.epostTextbox.TabIndex = 3
        '
        'etterNavnTextBox
        '
        Me.etterNavnTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etterNavnTextBox.Location = New System.Drawing.Point(3, 36)
        Me.etterNavnTextBox.Name = "etterNavnTextBox"
        Me.etterNavnTextBox.Size = New System.Drawing.Size(139, 24)
        Me.etterNavnTextBox.TabIndex = 1
        '
        'passordTextBox
        '
        Me.passordTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passordTextBox.Location = New System.Drawing.Point(3, 242)
        Me.passordTextBox.Name = "passordTextBox"
        Me.passordTextBox.Size = New System.Drawing.Size(139, 24)
        Me.passordTextBox.TabIndex = 9
        Me.passordTextBox.UseSystemPasswordChar = True
        '
        'fornavnLabel
        '
        Me.fornavnLabel.AutoSize = True
        Me.fornavnLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fornavnLabel.Location = New System.Drawing.Point(13, 4)
        Me.fornavnLabel.Name = "fornavnLabel"
        Me.fornavnLabel.Size = New System.Drawing.Size(83, 23)
        Me.fornavnLabel.TabIndex = 5
        Me.fornavnLabel.Text = "Fornavn*"
        '
        'epostLabel
        '
        Me.epostLabel.AutoSize = True
        Me.epostLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.epostLabel.Location = New System.Drawing.Point(13, 95)
        Me.epostLabel.Name = "epostLabel"
        Me.epostLabel.Size = New System.Drawing.Size(69, 23)
        Me.epostLabel.TabIndex = 6
        Me.epostLabel.Text = "E-post*"
        '
        'etterNavnLabel
        '
        Me.etterNavnLabel.AutoSize = True
        Me.etterNavnLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etterNavnLabel.Location = New System.Drawing.Point(13, 35)
        Me.etterNavnLabel.Name = "etterNavnLabel"
        Me.etterNavnLabel.Size = New System.Drawing.Size(95, 23)
        Me.etterNavnLabel.TabIndex = 7
        Me.etterNavnLabel.Text = "Etternavn*"
        '
        'passordLabel
        '
        Me.passordLabel.AutoSize = True
        Me.passordLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passordLabel.Location = New System.Drawing.Point(13, 241)
        Me.passordLabel.Name = "passordLabel"
        Me.passordLabel.Size = New System.Drawing.Size(72, 23)
        Me.passordLabel.TabIndex = 8
        Me.passordLabel.Text = "Passord"
        '
        'gjenntaPassordTextbox
        '
        Me.gjenntaPassordTextbox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gjenntaPassordTextbox.Location = New System.Drawing.Point(3, 272)
        Me.gjenntaPassordTextbox.Name = "gjenntaPassordTextbox"
        Me.gjenntaPassordTextbox.Size = New System.Drawing.Size(139, 24)
        Me.gjenntaPassordTextbox.TabIndex = 10
        Me.gjenntaPassordTextbox.UseSystemPasswordChar = True
        '
        'gjentaPassordLabel
        '
        Me.gjentaPassordLabel.AutoSize = True
        Me.gjentaPassordLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gjentaPassordLabel.Location = New System.Drawing.Point(13, 271)
        Me.gjentaPassordLabel.Name = "gjentaPassordLabel"
        Me.gjentaPassordLabel.Size = New System.Drawing.Size(129, 23)
        Me.gjentaPassordLabel.TabIndex = 10
        Me.gjentaPassordLabel.Text = "Gjenta Passord"
        '
        'personNrTextBox
        '
        Me.personNrTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personNrTextBox.Location = New System.Drawing.Point(3, 155)
        Me.personNrTextBox.Name = "personNrTextBox"
        Me.personNrTextBox.Size = New System.Drawing.Size(139, 24)
        Me.personNrTextBox.TabIndex = 5
        '
        'personNrLabel
        '
        Me.personNrLabel.AutoSize = True
        Me.personNrLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personNrLabel.Location = New System.Drawing.Point(13, 153)
        Me.personNrLabel.Name = "personNrLabel"
        Me.personNrLabel.Size = New System.Drawing.Size(145, 23)
        Me.personNrLabel.TabIndex = 14
        Me.personNrLabel.Text = "Personnummer* "
        '
        'registrerBrukerKnapp
        '
        Me.registrerBrukerKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.registrerBrukerKnapp.Dock = System.Windows.Forms.DockStyle.Right
        Me.registrerBrukerKnapp.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrerBrukerKnapp.Location = New System.Drawing.Point(211, 3)
        Me.registrerBrukerKnapp.Name = "registrerBrukerKnapp"
        Me.registrerBrukerKnapp.Size = New System.Drawing.Size(344, 97)
        Me.registrerBrukerKnapp.TabIndex = 11
        Me.registrerBrukerKnapp.Text = "Registrer bruker"
        Me.registrerBrukerKnapp.UseVisualStyleBackColor = False
        '
        'telefonTextBox
        '
        Me.telefonTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonTextBox.Location = New System.Drawing.Point(3, 67)
        Me.telefonTextBox.Name = "telefonTextBox"
        Me.telefonTextBox.Size = New System.Drawing.Size(139, 24)
        Me.telefonTextBox.TabIndex = 2
        '
        'telefonLabel
        '
        Me.telefonLabel.AutoSize = True
        Me.telefonLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonLabel.Location = New System.Drawing.Point(13, 66)
        Me.telefonLabel.Name = "telefonLabel"
        Me.telefonLabel.Size = New System.Drawing.Size(77, 23)
        Me.telefonLabel.TabIndex = 17
        Me.telefonLabel.Text = "Telefon*"
        '
        'fødselsdatoLabel
        '
        Me.fødselsdatoLabel.AutoSize = True
        Me.fødselsdatoLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fødselsdatoLabel.Location = New System.Drawing.Point(13, 125)
        Me.fødselsdatoLabel.Name = "fødselsdatoLabel"
        Me.fødselsdatoLabel.Size = New System.Drawing.Size(115, 23)
        Me.fødselsdatoLabel.TabIndex = 19
        Me.fødselsdatoLabel.Text = "Fødselsdato*"
        '
        'fodselsdatoTextBox
        '
        Me.fodselsdatoTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fodselsdatoTextBox.Location = New System.Drawing.Point(3, 126)
        Me.fodselsdatoTextBox.Name = "fodselsdatoTextBox"
        Me.fodselsdatoTextBox.Size = New System.Drawing.Size(139, 24)
        Me.fodselsdatoTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "dd.mm.åååå"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 23)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "5 siste"
        '
        'adresseLabel
        '
        Me.adresseLabel.AutoSize = True
        Me.adresseLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adresseLabel.Location = New System.Drawing.Point(13, 183)
        Me.adresseLabel.Name = "adresseLabel"
        Me.adresseLabel.Size = New System.Drawing.Size(75, 23)
        Me.adresseLabel.TabIndex = 23
        Me.adresseLabel.Text = "Adresse"
        '
        'adresseTextBox
        '
        Me.adresseTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adresseTextBox.Location = New System.Drawing.Point(3, 184)
        Me.adresseTextBox.Name = "adresseTextBox"
        Me.adresseTextBox.Size = New System.Drawing.Size(139, 24)
        Me.adresseTextBox.TabIndex = 6
        '
        'postnrLabel
        '
        Me.postnrLabel.AutoSize = True
        Me.postnrLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postnrLabel.Location = New System.Drawing.Point(13, 212)
        Me.postnrLabel.Name = "postnrLabel"
        Me.postnrLabel.Size = New System.Drawing.Size(113, 23)
        Me.postnrLabel.TabIndex = 25
        Me.postnrLabel.Text = "Postnr/sted*"
        '
        'postNrTextBox
        '
        Me.postNrTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postNrTextBox.Location = New System.Drawing.Point(3, 213)
        Me.postNrTextBox.Name = "postNrTextBox"
        Me.postNrTextBox.Size = New System.Drawing.Size(56, 24)
        Me.postNrTextBox.TabIndex = 7
        '
        'poststedTextBox
        '
        Me.poststedTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poststedTextBox.Location = New System.Drawing.Point(74, 213)
        Me.poststedTextBox.Name = "poststedTextBox"
        Me.poststedTextBox.Size = New System.Drawing.Size(131, 24)
        Me.poststedTextBox.TabIndex = 8
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(561, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(344, 97)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Gå tilbake / Avbryt registrering"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(16, 628)
        Me.Panel5.TabIndex = 28
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1133, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(16, 628)
        Me.Panel6.TabIndex = 29
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(16, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1117, 20)
        Me.Panel3.TabIndex = 30
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.registrerBrukerKnapp, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(16, 365)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.1635!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.8365!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1117, 263)
        Me.TableLayoutPanel1.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.fornavnTextbox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.gjenntaPassordTextbox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.passordTextBox)
        Me.Panel1.Controls.Add(Me.poststedTextBox)
        Me.Panel1.Controls.Add(Me.postNrTextBox)
        Me.Panel1.Controls.Add(Me.etterNavnTextBox)
        Me.Panel1.Controls.Add(Me.adresseTextBox)
        Me.Panel1.Controls.Add(Me.telefonTextBox)
        Me.Panel1.Controls.Add(Me.personNrTextBox)
        Me.Panel1.Controls.Add(Me.epostTextbox)
        Me.Panel1.Controls.Add(Me.fodselsdatoTextBox)
        Me.Panel1.Location = New System.Drawing.Point(560, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 331)
        Me.Panel1.TabIndex = 32
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.fornavnLabel)
        Me.Panel2.Controls.Add(Me.epostLabel)
        Me.Panel2.Controls.Add(Me.postnrLabel)
        Me.Panel2.Controls.Add(Me.etterNavnLabel)
        Me.Panel2.Controls.Add(Me.adresseLabel)
        Me.Panel2.Controls.Add(Me.passordLabel)
        Me.Panel2.Controls.Add(Me.gjentaPassordLabel)
        Me.Panel2.Controls.Add(Me.personNrLabel)
        Me.Panel2.Controls.Add(Me.fødselsdatoLabel)
        Me.Panel2.Controls.Add(Me.telefonLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(308, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 332)
        Me.Panel2.TabIndex = 33
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(16, 29)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1117, 336)
        Me.TableLayoutPanel2.TabIndex = 32
        '
        'FileSystemWatcher2
        '
        Me.FileSystemWatcher2.EnableRaisingEvents = True
        Me.FileSystemWatcher2.SynchronizingObject = Me
        '
        'registrerBlodgiver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1149, 628)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "registrerBlodgiver"
        Me.Text = "Registrer bruker"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.FileSystemWatcher2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fornavnTextbox As TextBox
    Friend WithEvents epostTextbox As TextBox
    Friend WithEvents etterNavnTextBox As TextBox
    Friend WithEvents passordTextBox As TextBox
    Friend WithEvents fornavnLabel As Label
    Friend WithEvents epostLabel As Label
    Friend WithEvents etterNavnLabel As Label
    Friend WithEvents passordLabel As Label
    Friend WithEvents gjenntaPassordTextbox As TextBox
    Friend WithEvents gjentaPassordLabel As Label
    Friend WithEvents personNrTextBox As TextBox
    Friend WithEvents personNrLabel As Label
    Friend WithEvents registrerBrukerKnapp As Button
    Friend WithEvents telefonTextBox As TextBox
    Friend WithEvents telefonLabel As Label
    Friend WithEvents fødselsdatoLabel As Label
    Friend WithEvents fodselsdatoTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents adresseLabel As Label
    Friend WithEvents adresseTextBox As TextBox
    Friend WithEvents postnrLabel As Label
    Friend WithEvents postNrTextBox As TextBox
    Friend WithEvents poststedTextBox As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher

    Friend WithEvents Button1 As Button


    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FileSystemWatcher2 As IO.FileSystemWatcher
End Class
