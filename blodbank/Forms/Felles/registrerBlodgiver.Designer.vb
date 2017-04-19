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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Personalia = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Personalia.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fornavnTextbox
        '
        Me.fornavnTextbox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fornavnTextbox.Location = New System.Drawing.Point(312, 54)
        Me.fornavnTextbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fornavnTextbox.Name = "fornavnTextbox"
        Me.fornavnTextbox.Size = New System.Drawing.Size(184, 28)
        Me.fornavnTextbox.TabIndex = 0
        '
        'epostTextbox
        '
        Me.epostTextbox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.epostTextbox.Location = New System.Drawing.Point(312, 166)
        Me.epostTextbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.epostTextbox.Name = "epostTextbox"
        Me.epostTextbox.Size = New System.Drawing.Size(184, 28)
        Me.epostTextbox.TabIndex = 3
        '
        'etterNavnTextBox
        '
        Me.etterNavnTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etterNavnTextBox.Location = New System.Drawing.Point(312, 92)
        Me.etterNavnTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.etterNavnTextBox.Name = "etterNavnTextBox"
        Me.etterNavnTextBox.Size = New System.Drawing.Size(184, 28)
        Me.etterNavnTextBox.TabIndex = 1
        '
        'passordTextBox
        '
        Me.passordTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passordTextBox.Location = New System.Drawing.Point(312, 346)
        Me.passordTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.passordTextBox.Name = "passordTextBox"
        Me.passordTextBox.Size = New System.Drawing.Size(184, 28)
        Me.passordTextBox.TabIndex = 9
        '
        'fornavnLabel
        '
        Me.fornavnLabel.AutoSize = True
        Me.fornavnLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fornavnLabel.Location = New System.Drawing.Point(101, 51)
        Me.fornavnLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.fornavnLabel.Name = "fornavnLabel"
        Me.fornavnLabel.Size = New System.Drawing.Size(107, 29)
        Me.fornavnLabel.TabIndex = 5
        Me.fornavnLabel.Text = "Fornavn*"
        '
        'epostLabel
        '
        Me.epostLabel.AutoSize = True
        Me.epostLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.epostLabel.Location = New System.Drawing.Point(101, 163)
        Me.epostLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.epostLabel.Name = "epostLabel"
        Me.epostLabel.Size = New System.Drawing.Size(88, 29)
        Me.epostLabel.TabIndex = 6
        Me.epostLabel.Text = "E-post*"
        '
        'etterNavnLabel
        '
        Me.etterNavnLabel.AutoSize = True
        Me.etterNavnLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etterNavnLabel.Location = New System.Drawing.Point(101, 89)
        Me.etterNavnLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.etterNavnLabel.Name = "etterNavnLabel"
        Me.etterNavnLabel.Size = New System.Drawing.Size(123, 29)
        Me.etterNavnLabel.TabIndex = 7
        Me.etterNavnLabel.Text = "Etternavn*"
        '
        'passordLabel
        '
        Me.passordLabel.AutoSize = True
        Me.passordLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passordLabel.Location = New System.Drawing.Point(101, 343)
        Me.passordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.passordLabel.Name = "passordLabel"
        Me.passordLabel.Size = New System.Drawing.Size(93, 29)
        Me.passordLabel.TabIndex = 8
        Me.passordLabel.Text = "Passord"
        '
        'gjenntaPassordTextbox
        '
        Me.gjenntaPassordTextbox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gjenntaPassordTextbox.Location = New System.Drawing.Point(312, 382)
        Me.gjenntaPassordTextbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gjenntaPassordTextbox.Name = "gjenntaPassordTextbox"
        Me.gjenntaPassordTextbox.Size = New System.Drawing.Size(132, 28)
        Me.gjenntaPassordTextbox.TabIndex = 10
        '
        'gjentaPassordLabel
        '
        Me.gjentaPassordLabel.AutoSize = True
        Me.gjentaPassordLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gjentaPassordLabel.Location = New System.Drawing.Point(101, 379)
        Me.gjentaPassordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.gjentaPassordLabel.Name = "gjentaPassordLabel"
        Me.gjentaPassordLabel.Size = New System.Drawing.Size(164, 29)
        Me.gjentaPassordLabel.TabIndex = 10
        Me.gjentaPassordLabel.Text = "Gjenta Passord"
        '
        'personNrTextBox
        '
        Me.personNrTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personNrTextBox.Location = New System.Drawing.Point(312, 238)
        Me.personNrTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.personNrTextBox.Name = "personNrTextBox"
        Me.personNrTextBox.Size = New System.Drawing.Size(184, 28)
        Me.personNrTextBox.TabIndex = 5
        '
        'personNrLabel
        '
        Me.personNrLabel.AutoSize = True
        Me.personNrLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personNrLabel.Location = New System.Drawing.Point(101, 234)
        Me.personNrLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.personNrLabel.Name = "personNrLabel"
        Me.personNrLabel.Size = New System.Drawing.Size(187, 29)
        Me.personNrLabel.TabIndex = 14
        Me.personNrLabel.Text = "Personnummer* "
        '
        'registrerBrukerKnapp
        '
        Me.registrerBrukerKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.registrerBrukerKnapp.Dock = System.Windows.Forms.DockStyle.Right
        Me.registrerBrukerKnapp.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrerBrukerKnapp.Location = New System.Drawing.Point(252, 4)
        Me.registrerBrukerKnapp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.registrerBrukerKnapp.Name = "registrerBrukerKnapp"
        Me.registrerBrukerKnapp.Size = New System.Drawing.Size(463, 151)
        Me.registrerBrukerKnapp.TabIndex = 11
        Me.registrerBrukerKnapp.Text = "Registrer bruker"
        Me.registrerBrukerKnapp.UseVisualStyleBackColor = False
        '
        'telefonTextBox
        '
        Me.telefonTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonTextBox.Location = New System.Drawing.Point(312, 130)
        Me.telefonTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.telefonTextBox.Name = "telefonTextBox"
        Me.telefonTextBox.Size = New System.Drawing.Size(184, 28)
        Me.telefonTextBox.TabIndex = 2
        '
        'telefonLabel
        '
        Me.telefonLabel.AutoSize = True
        Me.telefonLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefonLabel.Location = New System.Drawing.Point(101, 127)
        Me.telefonLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.telefonLabel.Name = "telefonLabel"
        Me.telefonLabel.Size = New System.Drawing.Size(99, 29)
        Me.telefonLabel.TabIndex = 17
        Me.telefonLabel.Text = "Telefon*"
        '
        'fødselsdatoLabel
        '
        Me.fødselsdatoLabel.AutoSize = True
        Me.fødselsdatoLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fødselsdatoLabel.Location = New System.Drawing.Point(101, 199)
        Me.fødselsdatoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.fødselsdatoLabel.Name = "fødselsdatoLabel"
        Me.fødselsdatoLabel.Size = New System.Drawing.Size(146, 29)
        Me.fødselsdatoLabel.TabIndex = 19
        Me.fødselsdatoLabel.Text = "Fødselsdato*"
        '
        'fodselsdatoTextBox
        '
        Me.fodselsdatoTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fodselsdatoTextBox.Location = New System.Drawing.Point(312, 202)
        Me.fodselsdatoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fodselsdatoTextBox.Name = "fodselsdatoTextBox"
        Me.fodselsdatoTextBox.Size = New System.Drawing.Size(184, 28)
        Me.fodselsdatoTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(525, 199)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 29)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "dd.mm.åååå"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(525, 234)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 29)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "5 siste"
        '
        'adresseLabel
        '
        Me.adresseLabel.AutoSize = True
        Me.adresseLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adresseLabel.Location = New System.Drawing.Point(101, 271)
        Me.adresseLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.adresseLabel.Name = "adresseLabel"
        Me.adresseLabel.Size = New System.Drawing.Size(94, 29)
        Me.adresseLabel.TabIndex = 23
        Me.adresseLabel.Text = "Adresse"
        '
        'adresseTextBox
        '
        Me.adresseTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adresseTextBox.Location = New System.Drawing.Point(312, 274)
        Me.adresseTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.adresseTextBox.Name = "adresseTextBox"
        Me.adresseTextBox.Size = New System.Drawing.Size(184, 28)
        Me.adresseTextBox.TabIndex = 6
        '
        'postnrLabel
        '
        Me.postnrLabel.AutoSize = True
        Me.postnrLabel.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postnrLabel.Location = New System.Drawing.Point(101, 307)
        Me.postnrLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.postnrLabel.Name = "postnrLabel"
        Me.postnrLabel.Size = New System.Drawing.Size(143, 29)
        Me.postnrLabel.TabIndex = 25
        Me.postnrLabel.Text = "Postnr/sted*"
        '
        'postNrTextBox
        '
        Me.postNrTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postNrTextBox.Location = New System.Drawing.Point(312, 310)
        Me.postNrTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.postNrTextBox.Name = "postNrTextBox"
        Me.postNrTextBox.Size = New System.Drawing.Size(73, 28)
        Me.postNrTextBox.TabIndex = 7
        '
        'poststedTextBox
        '
        Me.poststedTextBox.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poststedTextBox.Location = New System.Drawing.Point(407, 310)
        Me.poststedTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.poststedTextBox.Name = "poststedTextBox"
        Me.poststedTextBox.Size = New System.Drawing.Size(173, 28)
        Me.poststedTextBox.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(723, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(463, 151)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Gå tilbake / Avbryt registrering"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Personalia
        '
        Me.Personalia.Controls.Add(Me.fornavnTextbox)
        Me.Personalia.Controls.Add(Me.epostTextbox)
        Me.Personalia.Controls.Add(Me.etterNavnTextBox)
        Me.Personalia.Controls.Add(Me.personNrTextBox)
        Me.Personalia.Controls.Add(Me.postnrLabel)
        Me.Personalia.Controls.Add(Me.poststedTextBox)
        Me.Personalia.Controls.Add(Me.adresseLabel)
        Me.Personalia.Controls.Add(Me.telefonTextBox)
        Me.Personalia.Controls.Add(Me.fødselsdatoLabel)
        Me.Personalia.Controls.Add(Me.fodselsdatoTextBox)
        Me.Personalia.Controls.Add(Me.telefonLabel)
        Me.Personalia.Controls.Add(Me.postNrTextBox)
        Me.Personalia.Controls.Add(Me.personNrLabel)
        Me.Personalia.Controls.Add(Me.Label1)
        Me.Personalia.Controls.Add(Me.gjentaPassordLabel)
        Me.Personalia.Controls.Add(Me.Label2)
        Me.Personalia.Controls.Add(Me.passordLabel)
        Me.Personalia.Controls.Add(Me.gjenntaPassordTextbox)
        Me.Personalia.Controls.Add(Me.etterNavnLabel)
        Me.Personalia.Controls.Add(Me.adresseTextBox)
        Me.Personalia.Controls.Add(Me.epostLabel)
        Me.Personalia.Controls.Add(Me.passordTextBox)
        Me.Personalia.Controls.Add(Me.fornavnLabel)
        Me.Personalia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Personalia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Personalia.Location = New System.Drawing.Point(657, 156)
        Me.Personalia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Personalia.Name = "Personalia"
        Me.Personalia.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Personalia.Size = New System.Drawing.Size(739, 476)
        Me.Personalia.TabIndex = 27
        Me.Personalia.TabStop = False
        Me.Personalia.Text = "Personalia"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(22, 953)
        Me.Panel5.TabIndex = 28
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1460, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(22, 953)
        Me.Panel6.TabIndex = 29
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(22, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1438, 25)
        Me.Panel3.TabIndex = 30
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.registrerBrukerKnapp, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(22, 675)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.29443!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.70557!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1438, 278)
        Me.TableLayoutPanel1.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Location = New System.Drawing.Point(650, 147)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(753, 492)
        Me.Panel1.TabIndex = 32
        '
        'registrerBlodgiver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1482, 953)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Personalia)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "registrerBlodgiver"
        Me.Text = "Registrer bruker"
        Me.Personalia.ResumeLayout(False)
        Me.Personalia.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Personalia As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
End Class
