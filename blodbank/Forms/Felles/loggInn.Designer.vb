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
        Me.loggInnKnapp = New System.Windows.Forms.Button()
        Me.brukerNavnTextbox = New System.Windows.Forms.TextBox()
        Me.passordTextBox = New System.Windows.Forms.TextBox()
        Me.brukernavnLabel = New System.Windows.Forms.Label()
        Me.passordLabel = New System.Windows.Forms.Label()
        Me.registrerBrukerKnapp = New System.Windows.Forms.Button()
        Me.glemtPassordKnapp = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loggInnKnapp
        '
        Me.loggInnKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.loggInnKnapp.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggInnKnapp.Location = New System.Drawing.Point(241, 438)
        Me.loggInnKnapp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.loggInnKnapp.Name = "loggInnKnapp"
        Me.loggInnKnapp.Size = New System.Drawing.Size(300, 75)
        Me.loggInnKnapp.TabIndex = 3
        Me.loggInnKnapp.Text = "Logg Inn"
        Me.loggInnKnapp.UseVisualStyleBackColor = False
        '
        'brukerNavnTextbox
        '
        Me.brukerNavnTextbox.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brukerNavnTextbox.Location = New System.Drawing.Point(241, 141)
        Me.brukerNavnTextbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.brukerNavnTextbox.Name = "brukerNavnTextbox"
        Me.brukerNavnTextbox.Size = New System.Drawing.Size(300, 48)
        Me.brukerNavnTextbox.TabIndex = 1
        '
        'passordTextBox
        '
        Me.passordTextBox.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passordTextBox.Location = New System.Drawing.Point(241, 261)
        Me.passordTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.passordTextBox.Name = "passordTextBox"
        Me.passordTextBox.Size = New System.Drawing.Size(300, 48)
        Me.passordTextBox.TabIndex = 2
        '
        'brukernavnLabel
        '
        Me.brukernavnLabel.AutoSize = True
        Me.brukernavnLabel.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brukernavnLabel.Location = New System.Drawing.Point(234, 84)
        Me.brukernavnLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.brukernavnLabel.Name = "brukernavnLabel"
        Me.brukernavnLabel.Size = New System.Drawing.Size(316, 41)
        Me.brukernavnLabel.TabIndex = 3
        Me.brukernavnLabel.Text = "Skriv inn brukernavn:"
        '
        'passordLabel
        '
        Me.passordLabel.AutoSize = True
        Me.passordLabel.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passordLabel.Location = New System.Drawing.Point(234, 205)
        Me.passordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.passordLabel.Name = "passordLabel"
        Me.passordLabel.Size = New System.Drawing.Size(266, 41)
        Me.passordLabel.TabIndex = 5
        Me.passordLabel.Text = "Skriv inn passord:"
        '
        'registrerBrukerKnapp
        '
        Me.registrerBrukerKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.registrerBrukerKnapp.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrerBrukerKnapp.Location = New System.Drawing.Point(82, 346)
        Me.registrerBrukerKnapp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.registrerBrukerKnapp.Name = "registrerBrukerKnapp"
        Me.registrerBrukerKnapp.Size = New System.Drawing.Size(300, 75)
        Me.registrerBrukerKnapp.TabIndex = 4
        Me.registrerBrukerKnapp.Text = "Ny bruker"
        Me.registrerBrukerKnapp.UseVisualStyleBackColor = False
        '
        'glemtPassordKnapp
        '
        Me.glemtPassordKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.glemtPassordKnapp.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glemtPassordKnapp.Location = New System.Drawing.Point(400, 346)
        Me.glemtPassordKnapp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.glemtPassordKnapp.Name = "glemtPassordKnapp"
        Me.glemtPassordKnapp.Size = New System.Drawing.Size(300, 75)
        Me.glemtPassordKnapp.TabIndex = 5
        Me.glemtPassordKnapp.Text = "Glemt passord?"
        Me.glemtPassordKnapp.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 350)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "HashTest"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(100, 408)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(216, 66)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "midlertidig logg inn (blogiver)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(100, 498)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(216, 66)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "midlertidig logg inn (ansatt)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1460, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(22, 953)
        Me.Panel6.TabIndex = 19
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(22, 953)
        Me.Panel5.TabIndex = 20
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(22, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1438, 25)
        Me.Panel3.TabIndex = 21
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(22, 931)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1438, 22)
        Me.Panel4.TabIndex = 22
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
        Me.Panel1.Location = New System.Drawing.Point(696, 266)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 570)
        Me.Panel1.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(693, 263)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(770, 576)
        Me.Panel2.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(817, 109)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(753, 132)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'loggInn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1482, 953)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "loggInn"
        Me.Text = "Blodbanken"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loggInnKnapp As Button
    Friend WithEvents brukerNavnTextbox As TextBox
    Friend WithEvents passordTextBox As TextBox
    Friend WithEvents brukernavnLabel As Label
    Friend WithEvents passordLabel As Label
    Friend WithEvents registrerBrukerKnapp As Button
    Friend WithEvents glemtPassordKnapp As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
