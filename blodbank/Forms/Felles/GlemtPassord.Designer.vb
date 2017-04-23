<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GlemtPassord
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
        Me.tilbakeBtn = New System.Windows.Forms.Button()
        Me.skrivInnEpostTextBox = New System.Windows.Forms.TextBox()
        Me.LabelEpost2 = New System.Windows.Forms.Label()
        Me.sendNyttPassordBtn = New System.Windows.Forms.Button()
        Me.box1 = New System.Windows.Forms.GroupBox()
        Me.box3 = New System.Windows.Forms.GroupBox()
        Me.LabelGjentaPassord = New System.Windows.Forms.Label()
        Me.LabelSkrivPassord = New System.Windows.Forms.Label()
        Me.nyttPassordTextBox = New System.Windows.Forms.TextBox()
        Me.gjenntaNyttPassord = New System.Windows.Forms.TextBox()
        Me.registrerNyttPassordBtn = New System.Windows.Forms.Button()
        Me.loggInnMedNyttPassorBtn = New System.Windows.Forms.Button()
        Me.box2 = New System.Windows.Forms.GroupBox()
        Me.LabelMidlertidigPassord = New System.Windows.Forms.Label()
        Me.LabelEpost = New System.Windows.Forms.Label()
        Me.epostTextBox = New System.Windows.Forms.TextBox()
        Me.midlertidigPassordTextBox = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.box1.SuspendLayout()
        Me.box3.SuspendLayout()
        Me.box2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tilbakeBtn
        '
        Me.tilbakeBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.tilbakeBtn.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tilbakeBtn.Location = New System.Drawing.Point(54, 214)
        Me.tilbakeBtn.Name = "tilbakeBtn"
        Me.tilbakeBtn.Size = New System.Drawing.Size(278, 80)
        Me.tilbakeBtn.TabIndex = 6
        Me.tilbakeBtn.Text = "Tilbake til Logg Inn"
        Me.tilbakeBtn.UseVisualStyleBackColor = False
        '
        'skrivInnEpostTextBox
        '
        Me.skrivInnEpostTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.skrivInnEpostTextBox.Location = New System.Drawing.Point(54, 65)
        Me.skrivInnEpostTextBox.Name = "skrivInnEpostTextBox"
        Me.skrivInnEpostTextBox.Size = New System.Drawing.Size(278, 27)
        Me.skrivInnEpostTextBox.TabIndex = 4
        '
        'LabelEpost2
        '
        Me.LabelEpost2.AutoSize = True
        Me.LabelEpost2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEpost2.Location = New System.Drawing.Point(49, 36)
        Me.LabelEpost2.Name = "LabelEpost2"
        Me.LabelEpost2.Size = New System.Drawing.Size(171, 26)
        Me.LabelEpost2.TabIndex = 2
        Me.LabelEpost2.Text = "Skriv inn din epost"
        '
        'sendNyttPassordBtn
        '
        Me.sendNyttPassordBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.sendNyttPassordBtn.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendNyttPassordBtn.Location = New System.Drawing.Point(54, 115)
        Me.sendNyttPassordBtn.Name = "sendNyttPassordBtn"
        Me.sendNyttPassordBtn.Size = New System.Drawing.Size(278, 80)
        Me.sendNyttPassordBtn.TabIndex = 5
        Me.sendNyttPassordBtn.Text = "Send nytt passord til din epost"
        Me.sendNyttPassordBtn.UseVisualStyleBackColor = False
        '
        'box1
        '
        Me.box1.Controls.Add(Me.tilbakeBtn)
        Me.box1.Controls.Add(Me.LabelEpost2)
        Me.box1.Controls.Add(Me.sendNyttPassordBtn)
        Me.box1.Controls.Add(Me.skrivInnEpostTextBox)
        Me.box1.Location = New System.Drawing.Point(512, 103)
        Me.box1.Name = "box1"
        Me.box1.Size = New System.Drawing.Size(374, 316)
        Me.box1.TabIndex = 4
        Me.box1.TabStop = False
        '
        'box3
        '
        Me.box3.Controls.Add(Me.LabelGjentaPassord)
        Me.box3.Controls.Add(Me.LabelSkrivPassord)
        Me.box3.Controls.Add(Me.nyttPassordTextBox)
        Me.box3.Controls.Add(Me.gjenntaNyttPassord)
        Me.box3.Controls.Add(Me.registrerNyttPassordBtn)
        Me.box3.Location = New System.Drawing.Point(290, 425)
        Me.box3.Name = "box3"
        Me.box3.Size = New System.Drawing.Size(418, 205)
        Me.box3.TabIndex = 5
        Me.box3.TabStop = False
        '
        'LabelGjentaPassord
        '
        Me.LabelGjentaPassord.AutoSize = True
        Me.LabelGjentaPassord.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGjentaPassord.Location = New System.Drawing.Point(22, 59)
        Me.LabelGjentaPassord.Name = "LabelGjentaPassord"
        Me.LabelGjentaPassord.Size = New System.Drawing.Size(191, 26)
        Me.LabelGjentaPassord.TabIndex = 9
        Me.LabelGjentaPassord.Text = "Gjennta nytt passord"
        '
        'LabelSkrivPassord
        '
        Me.LabelSkrivPassord.AutoSize = True
        Me.LabelSkrivPassord.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSkrivPassord.Location = New System.Drawing.Point(22, 18)
        Me.LabelSkrivPassord.Name = "LabelSkrivPassord"
        Me.LabelSkrivPassord.Size = New System.Drawing.Size(197, 26)
        Me.LabelSkrivPassord.TabIndex = 8
        Me.LabelSkrivPassord.Text = "Skriv inn nytt passord"
        '
        'nyttPassordTextBox
        '
        Me.nyttPassordTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nyttPassordTextBox.Location = New System.Drawing.Point(233, 20)
        Me.nyttPassordTextBox.Name = "nyttPassordTextBox"
        Me.nyttPassordTextBox.Size = New System.Drawing.Size(160, 27)
        Me.nyttPassordTextBox.TabIndex = 7
        Me.nyttPassordTextBox.UseSystemPasswordChar = True
        '
        'gjenntaNyttPassord
        '
        Me.gjenntaNyttPassord.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gjenntaNyttPassord.Location = New System.Drawing.Point(233, 61)
        Me.gjenntaNyttPassord.Name = "gjenntaNyttPassord"
        Me.gjenntaNyttPassord.Size = New System.Drawing.Size(160, 27)
        Me.gjenntaNyttPassord.TabIndex = 8
        Me.gjenntaNyttPassord.UseSystemPasswordChar = True
        '
        'registrerNyttPassordBtn
        '
        Me.registrerNyttPassordBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.registrerNyttPassordBtn.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrerNyttPassordBtn.Location = New System.Drawing.Point(27, 106)
        Me.registrerNyttPassordBtn.Name = "registrerNyttPassordBtn"
        Me.registrerNyttPassordBtn.Size = New System.Drawing.Size(366, 80)
        Me.registrerNyttPassordBtn.TabIndex = 9
        Me.registrerNyttPassordBtn.Text = "Registrer Passord"
        Me.registrerNyttPassordBtn.UseVisualStyleBackColor = False
        '
        'loggInnMedNyttPassorBtn
        '
        Me.loggInnMedNyttPassorBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.loggInnMedNyttPassorBtn.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggInnMedNyttPassorBtn.Location = New System.Drawing.Point(47, 214)
        Me.loggInnMedNyttPassorBtn.Name = "loggInnMedNyttPassorBtn"
        Me.loggInnMedNyttPassorBtn.Size = New System.Drawing.Size(278, 80)
        Me.loggInnMedNyttPassorBtn.TabIndex = 3
        Me.loggInnMedNyttPassorBtn.Text = "Logg inn med nytt passord"
        Me.loggInnMedNyttPassorBtn.UseVisualStyleBackColor = False
        '
        'box2
        '
        Me.box2.Controls.Add(Me.LabelMidlertidigPassord)
        Me.box2.Controls.Add(Me.LabelEpost)
        Me.box2.Controls.Add(Me.epostTextBox)
        Me.box2.Controls.Add(Me.midlertidigPassordTextBox)
        Me.box2.Controls.Add(Me.loggInnMedNyttPassorBtn)
        Me.box2.Location = New System.Drawing.Point(125, 103)
        Me.box2.Name = "box2"
        Me.box2.Size = New System.Drawing.Size(374, 316)
        Me.box2.TabIndex = 7
        Me.box2.TabStop = False
        '
        'LabelMidlertidigPassord
        '
        Me.LabelMidlertidigPassord.AutoSize = True
        Me.LabelMidlertidigPassord.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMidlertidigPassord.Location = New System.Drawing.Point(42, 139)
        Me.LabelMidlertidigPassord.Name = "LabelMidlertidigPassord"
        Me.LabelMidlertidigPassord.Size = New System.Drawing.Size(225, 26)
        Me.LabelMidlertidigPassord.TabIndex = 13
        Me.LabelMidlertidigPassord.Text = "Ditt midlertidige passord"
        '
        'LabelEpost
        '
        Me.LabelEpost.AutoSize = True
        Me.LabelEpost.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEpost.Location = New System.Drawing.Point(42, 36)
        Me.LabelEpost.Name = "LabelEpost"
        Me.LabelEpost.Size = New System.Drawing.Size(94, 26)
        Me.LabelEpost.TabIndex = 12
        Me.LabelEpost.Text = "Din epost"
        '
        'epostTextBox
        '
        Me.epostTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.epostTextBox.Location = New System.Drawing.Point(47, 65)
        Me.epostTextBox.Name = "epostTextBox"
        Me.epostTextBox.Size = New System.Drawing.Size(160, 27)
        Me.epostTextBox.TabIndex = 1
        '
        'midlertidigPassordTextBox
        '
        Me.midlertidigPassordTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midlertidigPassordTextBox.Location = New System.Drawing.Point(47, 168)
        Me.midlertidigPassordTextBox.Name = "midlertidigPassordTextBox"
        Me.midlertidigPassordTextBox.Size = New System.Drawing.Size(160, 27)
        Me.midlertidigPassordTextBox.TabIndex = 2
        Me.midlertidigPassordTextBox.UseSystemPasswordChar = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(16, 620)
        Me.Panel5.TabIndex = 21
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1195, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(16, 620)
        Me.Panel6.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(16, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1179, 20)
        Me.Panel3.TabIndex = 23
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(16, 604)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1179, 16)
        Me.Panel4.TabIndex = 24
        '
        'GlemtPassord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1211, 620)
        Me.Controls.Add(Me.box3)
        Me.Controls.Add(Me.box2)
        Me.Controls.Add(Me.box1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "GlemtPassord"
        Me.Text = "GlemtPassord"
        Me.box1.ResumeLayout(False)
        Me.box1.PerformLayout()
        Me.box3.ResumeLayout(False)
        Me.box3.PerformLayout()
        Me.box2.ResumeLayout(False)
        Me.box2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tilbakeBtn As Button
    Friend WithEvents skrivInnEpostTextBox As TextBox
    Friend WithEvents LabelEpost2 As Label
    Friend WithEvents sendNyttPassordBtn As Button
    Friend WithEvents box1 As GroupBox
    Friend WithEvents box3 As GroupBox
    Friend WithEvents LabelGjentaPassord As Label
    Friend WithEvents LabelSkrivPassord As Label
    Friend WithEvents nyttPassordTextBox As TextBox
    Friend WithEvents gjenntaNyttPassord As TextBox
    Friend WithEvents registrerNyttPassordBtn As Button
    Friend WithEvents loggInnMedNyttPassorBtn As Button
    Friend WithEvents box2 As GroupBox
    Friend WithEvents LabelMidlertidigPassord As Label
    Friend WithEvents midlertidigPassordTextBox As TextBox
    Friend WithEvents LabelEpost As Label
    Friend WithEvents epostTextBox As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
