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
        Me.fornavnTextbox = New System.Windows.Forms.TextBox()
        Me.epostTextbox = New System.Windows.Forms.TextBox()
        Me.etterNavnTextBox = New System.Windows.Forms.TextBox()
        Me.passordTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.kjønnLabel = New System.Windows.Forms.Label()
        Me.fornavnLabel = New System.Windows.Forms.Label()
        Me.epostLabel = New System.Windows.Forms.Label()
        Me.etterNavnLabel = New System.Windows.Forms.Label()
        Me.passordLabel = New System.Windows.Forms.Label()
        Me.gjenntaPassordTextbox = New System.Windows.Forms.TextBox()
        Me.gjentaPassordLabel = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.fodselsDatoLabel = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fornavnTextbox
        '
        Me.fornavnTextbox.Location = New System.Drawing.Point(150, 34)
        Me.fornavnTextbox.Name = "fornavnTextbox"
        Me.fornavnTextbox.Size = New System.Drawing.Size(100, 20)
        Me.fornavnTextbox.TabIndex = 0
        '
        'epostTextbox
        '
        Me.epostTextbox.Location = New System.Drawing.Point(150, 119)
        Me.epostTextbox.Name = "epostTextbox"
        Me.epostTextbox.Size = New System.Drawing.Size(100, 20)
        Me.epostTextbox.TabIndex = 1
        '
        'etterNavnTextBox
        '
        Me.etterNavnTextBox.Location = New System.Drawing.Point(150, 60)
        Me.etterNavnTextBox.Name = "etterNavnTextBox"
        Me.etterNavnTextBox.Size = New System.Drawing.Size(100, 20)
        Me.etterNavnTextBox.TabIndex = 2
        '
        'passordTextBox
        '
        Me.passordTextBox.Location = New System.Drawing.Point(151, 298)
        Me.passordTextBox.Name = "passordTextBox"
        Me.passordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.passordTextBox.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.kjønnLabel)
        Me.Panel1.Location = New System.Drawing.Point(78, 377)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(72, 73)
        Me.Panel1.TabIndex = 4
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 44)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Kvinne"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Mann"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'kjønnLabel
        '
        Me.kjønnLabel.AutoSize = True
        Me.kjønnLabel.Location = New System.Drawing.Point(4, 5)
        Me.kjønnLabel.Name = "kjønnLabel"
        Me.kjønnLabel.Size = New System.Drawing.Size(34, 13)
        Me.kjønnLabel.TabIndex = 0
        Me.kjønnLabel.Text = "Kjønn"
        '
        'fornavnLabel
        '
        Me.fornavnLabel.AutoSize = True
        Me.fornavnLabel.Location = New System.Drawing.Point(67, 34)
        Me.fornavnLabel.Name = "fornavnLabel"
        Me.fornavnLabel.Size = New System.Drawing.Size(50, 13)
        Me.fornavnLabel.TabIndex = 5
        Me.fornavnLabel.Text = "Fornavn*"
        '
        'epostLabel
        '
        Me.epostLabel.AutoSize = True
        Me.epostLabel.Location = New System.Drawing.Point(69, 119)
        Me.epostLabel.Name = "epostLabel"
        Me.epostLabel.Size = New System.Drawing.Size(41, 13)
        Me.epostLabel.TabIndex = 6
        Me.epostLabel.Text = "E-post*"
        '
        'etterNavnLabel
        '
        Me.etterNavnLabel.AutoSize = True
        Me.etterNavnLabel.Location = New System.Drawing.Point(67, 63)
        Me.etterNavnLabel.Name = "etterNavnLabel"
        Me.etterNavnLabel.Size = New System.Drawing.Size(57, 13)
        Me.etterNavnLabel.TabIndex = 7
        Me.etterNavnLabel.Text = "Etternavn*"
        '
        'passordLabel
        '
        Me.passordLabel.AutoSize = True
        Me.passordLabel.Location = New System.Drawing.Point(72, 299)
        Me.passordLabel.Name = "passordLabel"
        Me.passordLabel.Size = New System.Drawing.Size(45, 13)
        Me.passordLabel.TabIndex = 8
        Me.passordLabel.Text = "Passord"
        '
        'gjenntaPassordTextbox
        '
        Me.gjenntaPassordTextbox.Location = New System.Drawing.Point(151, 325)
        Me.gjenntaPassordTextbox.Name = "gjenntaPassordTextbox"
        Me.gjenntaPassordTextbox.Size = New System.Drawing.Size(100, 20)
        Me.gjenntaPassordTextbox.TabIndex = 9
        '
        'gjentaPassordLabel
        '
        Me.gjentaPassordLabel.AutoSize = True
        Me.gjentaPassordLabel.Location = New System.Drawing.Point(71, 329)
        Me.gjentaPassordLabel.Name = "gjentaPassordLabel"
        Me.gjentaPassordLabel.Size = New System.Drawing.Size(79, 13)
        Me.gjentaPassordLabel.TabIndex = 10
        Me.gjentaPassordLabel.Text = "Gjenta Passord"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(588, 44)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 11
        '
        'fodselsDatoLabel
        '
        Me.fodselsDatoLabel.AutoSize = True
        Me.fodselsDatoLabel.Location = New System.Drawing.Point(591, 25)
        Me.fodselsDatoLabel.Name = "fodselsDatoLabel"
        Me.fodselsDatoLabel.Size = New System.Drawing.Size(70, 13)
        Me.fodselsDatoLabel.TabIndex = 12
        Me.fodselsDatoLabel.Text = "Fødselsdato: "
        '
        'personNrTextBox
        '
        Me.personNrTextBox.Location = New System.Drawing.Point(561, 313)
        Me.personNrTextBox.Name = "personNrTextBox"
        Me.personNrTextBox.Size = New System.Drawing.Size(100, 20)
        Me.personNrTextBox.TabIndex = 13
        '
        'personNrLabel
        '
        Me.personNrLabel.AutoSize = True
        Me.personNrLabel.Location = New System.Drawing.Point(478, 316)
        Me.personNrLabel.Name = "personNrLabel"
        Me.personNrLabel.Size = New System.Drawing.Size(84, 13)
        Me.personNrLabel.TabIndex = 14
        Me.personNrLabel.Text = "Personnummer* "
        '
        'registrerBrukerKnapp
        '
        Me.registrerBrukerKnapp.Location = New System.Drawing.Point(178, 377)
        Me.registrerBrukerKnapp.Name = "registrerBrukerKnapp"
        Me.registrerBrukerKnapp.Size = New System.Drawing.Size(161, 71)
        Me.registrerBrukerKnapp.TabIndex = 15
        Me.registrerBrukerKnapp.Text = "Registrer bruker"
        Me.registrerBrukerKnapp.UseVisualStyleBackColor = True
        '
        'telefonTextBox
        '
        Me.telefonTextBox.Location = New System.Drawing.Point(150, 93)
        Me.telefonTextBox.Name = "telefonTextBox"
        Me.telefonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.telefonTextBox.TabIndex = 16
        '
        'telefonLabel
        '
        Me.telefonLabel.AutoSize = True
        Me.telefonLabel.Location = New System.Drawing.Point(67, 96)
        Me.telefonLabel.Name = "telefonLabel"
        Me.telefonLabel.Size = New System.Drawing.Size(47, 13)
        Me.telefonLabel.TabIndex = 17
        Me.telefonLabel.Text = "Telefon*"
        '
        'fødselsdatoLabel
        '
        Me.fødselsdatoLabel.AutoSize = True
        Me.fødselsdatoLabel.Location = New System.Drawing.Point(67, 148)
        Me.fødselsdatoLabel.Name = "fødselsdatoLabel"
        Me.fødselsdatoLabel.Size = New System.Drawing.Size(68, 13)
        Me.fødselsdatoLabel.TabIndex = 19
        Me.fødselsdatoLabel.Text = "Fødselsdato*"
        '
        'fodselsdatoTextBox
        '
        Me.fodselsdatoTextBox.Location = New System.Drawing.Point(150, 145)
        Me.fodselsdatoTextBox.Name = "fodselsdatoTextBox"
        Me.fodselsdatoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.fodselsdatoTextBox.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "dd-mm-åååå"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(662, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "5 siste"
        '
        'adresseLabel
        '
        Me.adresseLabel.AutoSize = True
        Me.adresseLabel.Location = New System.Drawing.Point(67, 200)
        Me.adresseLabel.Name = "adresseLabel"
        Me.adresseLabel.Size = New System.Drawing.Size(45, 13)
        Me.adresseLabel.TabIndex = 23
        Me.adresseLabel.Text = "Adresse"
        '
        'adresseTextBox
        '
        Me.adresseTextBox.Location = New System.Drawing.Point(150, 197)
        Me.adresseTextBox.Name = "adresseTextBox"
        Me.adresseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.adresseTextBox.TabIndex = 22
        '
        'postnrLabel
        '
        Me.postnrLabel.AutoSize = True
        Me.postnrLabel.Location = New System.Drawing.Point(67, 233)
        Me.postnrLabel.Name = "postnrLabel"
        Me.postnrLabel.Size = New System.Drawing.Size(66, 13)
        Me.postnrLabel.TabIndex = 25
        Me.postnrLabel.Text = "Postnr/sted*"
        '
        'postNrTextBox
        '
        Me.postNrTextBox.Location = New System.Drawing.Point(150, 230)
        Me.postNrTextBox.Name = "postNrTextBox"
        Me.postNrTextBox.Size = New System.Drawing.Size(52, 20)
        Me.postNrTextBox.TabIndex = 24
        '
        'poststedTextBox
        '
        Me.poststedTextBox.Location = New System.Drawing.Point(208, 230)
        Me.poststedTextBox.Name = "poststedTextBox"
        Me.poststedTextBox.Size = New System.Drawing.Size(131, 20)
        Me.poststedTextBox.TabIndex = 26
        '
        'registrerBlodgiver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 532)
        Me.Controls.Add(Me.poststedTextBox)
        Me.Controls.Add(Me.postnrLabel)
        Me.Controls.Add(Me.postNrTextBox)
        Me.Controls.Add(Me.adresseLabel)
        Me.Controls.Add(Me.adresseTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fødselsdatoLabel)
        Me.Controls.Add(Me.fodselsdatoTextBox)
        Me.Controls.Add(Me.telefonLabel)
        Me.Controls.Add(Me.telefonTextBox)
        Me.Controls.Add(Me.registrerBrukerKnapp)
        Me.Controls.Add(Me.personNrLabel)
        Me.Controls.Add(Me.personNrTextBox)
        Me.Controls.Add(Me.fodselsDatoLabel)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.gjentaPassordLabel)
        Me.Controls.Add(Me.gjenntaPassordTextbox)
        Me.Controls.Add(Me.passordLabel)
        Me.Controls.Add(Me.etterNavnLabel)
        Me.Controls.Add(Me.epostLabel)
        Me.Controls.Add(Me.fornavnLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.passordTextBox)
        Me.Controls.Add(Me.etterNavnTextBox)
        Me.Controls.Add(Me.epostTextbox)
        Me.Controls.Add(Me.fornavnTextbox)
        Me.Name = "registrerBlodgiver"
        Me.Text = "nyBruker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fornavnTextbox As TextBox
    Friend WithEvents epostTextbox As TextBox
    Friend WithEvents etterNavnTextBox As TextBox
    Friend WithEvents passordTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents kjønnLabel As Label
    Friend WithEvents fornavnLabel As Label
    Friend WithEvents epostLabel As Label
    Friend WithEvents etterNavnLabel As Label
    Friend WithEvents passordLabel As Label
    Friend WithEvents gjenntaPassordTextbox As TextBox
    Friend WithEvents gjentaPassordLabel As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents fodselsDatoLabel As Label
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
End Class
