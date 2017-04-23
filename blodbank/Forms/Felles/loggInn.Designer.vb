<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loggInn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loggInn))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.guiPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.registrerBrukerKnapp = New System.Windows.Forms.Button()
        Me.glemtPassordKnapp = New System.Windows.Forms.Button()
        Me.loggInnKnapp = New System.Windows.Forms.Button()
        Me.passordLabel = New System.Windows.Forms.Label()
        Me.brukerNavnTextbox = New System.Windows.Forms.TextBox()
        Me.passordTextBox = New System.Windows.Forms.TextBox()
        Me.brukernavnLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.guiPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(941, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(16, 628)
        Me.Panel6.TabIndex = 19
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(16, 628)
        Me.Panel5.TabIndex = 20
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(16, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(925, 20)
        Me.Panel3.TabIndex = 21
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(16, 612)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(925, 16)
        Me.Panel4.TabIndex = 22
        '
        'guiPanel
        '
        Me.guiPanel.Controls.Add(Me.Panel1)
        Me.guiPanel.Controls.Add(Me.Panel2)
        Me.guiPanel.Controls.Add(Me.logo)
        Me.guiPanel.Location = New System.Drawing.Point(217, 50)
        Me.guiPanel.Margin = New System.Windows.Forms.Padding(50)
        Me.guiPanel.Name = "guiPanel"
        Me.guiPanel.Padding = New System.Windows.Forms.Padding(50)
        Me.guiPanel.Size = New System.Drawing.Size(594, 629)
        Me.guiPanel.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.registrerBrukerKnapp)
        Me.Panel1.Controls.Add(Me.glemtPassordKnapp)
        Me.Panel1.Controls.Add(Me.loggInnKnapp)
        Me.Panel1.Controls.Add(Me.passordLabel)
        Me.Panel1.Controls.Add(Me.brukerNavnTextbox)
        Me.Panel1.Controls.Add(Me.passordTextBox)
        Me.Panel1.Controls.Add(Me.brukernavnLabel)
        Me.Panel1.Location = New System.Drawing.Point(4, 125)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(583, 463)
        Me.Panel1.TabIndex = 24
        '
        'registrerBrukerKnapp
        '
        Me.registrerBrukerKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.registrerBrukerKnapp.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrerBrukerKnapp.Location = New System.Drawing.Point(181, 363)
        Me.registrerBrukerKnapp.Name = "registrerBrukerKnapp"
        Me.registrerBrukerKnapp.Size = New System.Drawing.Size(220, 80)
        Me.registrerBrukerKnapp.TabIndex = 5
        Me.registrerBrukerKnapp.Text = "Ny bruker"
        Me.registrerBrukerKnapp.UseVisualStyleBackColor = False
        '
        'glemtPassordKnapp
        '
        Me.glemtPassordKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.glemtPassordKnapp.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glemtPassordKnapp.Location = New System.Drawing.Point(297, 277)
        Me.glemtPassordKnapp.Name = "glemtPassordKnapp"
        Me.glemtPassordKnapp.Size = New System.Drawing.Size(220, 80)
        Me.glemtPassordKnapp.TabIndex = 4
        Me.glemtPassordKnapp.Text = "Glemt passord?"
        Me.glemtPassordKnapp.UseVisualStyleBackColor = False
        '
        'loggInnKnapp
        '
        Me.loggInnKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.loggInnKnapp.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggInnKnapp.Location = New System.Drawing.Point(71, 277)
        Me.loggInnKnapp.Name = "loggInnKnapp"
        Me.loggInnKnapp.Size = New System.Drawing.Size(220, 80)
        Me.loggInnKnapp.TabIndex = 3
        Me.loggInnKnapp.Text = "Logg Inn"
        Me.loggInnKnapp.UseVisualStyleBackColor = False
        '
        'passordLabel
        '
        Me.passordLabel.AutoSize = True
        Me.passordLabel.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passordLabel.Location = New System.Drawing.Point(176, 167)
        Me.passordLabel.Name = "passordLabel"
        Me.passordLabel.Size = New System.Drawing.Size(213, 33)
        Me.passordLabel.TabIndex = 5
        Me.passordLabel.Text = "Skriv inn passord:"
        '
        'brukerNavnTextbox
        '
        Me.brukerNavnTextbox.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brukerNavnTextbox.Location = New System.Drawing.Point(181, 115)
        Me.brukerNavnTextbox.Name = "brukerNavnTextbox"
        Me.brukerNavnTextbox.Size = New System.Drawing.Size(226, 40)
        Me.brukerNavnTextbox.TabIndex = 1
        '
        'passordTextBox
        '
        Me.passordTextBox.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passordTextBox.Location = New System.Drawing.Point(181, 212)
        Me.passordTextBox.Name = "passordTextBox"
        Me.passordTextBox.Size = New System.Drawing.Size(226, 40)
        Me.passordTextBox.TabIndex = 2
        Me.passordTextBox.UseSystemPasswordChar = True
        '
        'brukernavnLabel
        '
        Me.brukernavnLabel.AutoSize = True
        Me.brukernavnLabel.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brukernavnLabel.Location = New System.Drawing.Point(176, 68)
        Me.brukernavnLabel.Name = "brukernavnLabel"
        Me.brukernavnLabel.Size = New System.Drawing.Size(253, 33)
        Me.brukernavnLabel.TabIndex = 3
        Me.brukernavnLabel.Text = "Skriv inn brukernavn:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 122)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(591, 469)
        Me.Panel2.TabIndex = 25
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(117, 11)
        Me.logo.Margin = New System.Windows.Forms.Padding(2)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(379, 107)
        Me.logo.TabIndex = 26
        Me.logo.TabStop = False
        '
        'loggInn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(957, 628)
        Me.Controls.Add(Me.guiPanel)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "loggInn"
        Me.Text = "Blodbanken"
        Me.guiPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents guiPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents registrerBrukerKnapp As Button
    Friend WithEvents glemtPassordKnapp As Button
    Friend WithEvents loggInnKnapp As Button
    Friend WithEvents passordLabel As Label
    Friend WithEvents brukerNavnTextbox As TextBox
    Friend WithEvents passordTextBox As TextBox
    Friend WithEvents brukernavnLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents logo As PictureBox
End Class
