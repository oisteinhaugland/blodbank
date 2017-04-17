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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.registrerBrukerKnapp = New System.Windows.Forms.Button()
        Me.loggInnKnapp = New System.Windows.Forms.Button()
        Me.passordTextBox = New System.Windows.Forms.TextBox()
        Me.passordLabel = New System.Windows.Forms.Label()
        Me.glemtPassordKnapp = New System.Windows.Forms.Button()
        Me.brukerNavnTextbox = New System.Windows.Forms.TextBox()
        Me.brukernavnLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(182, 127)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "HashTest"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(107, 182)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(216, 66)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "midlertidig logg inn (blogiver)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(107, 290)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(216, 66)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "midlertidig logg inn (ansatt)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(806, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(575, 132)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.registrerBrukerKnapp)
        Me.Panel1.Controls.Add(Me.loggInnKnapp)
        Me.Panel1.Controls.Add(Me.passordTextBox)
        Me.Panel1.Controls.Add(Me.passordLabel)
        Me.Panel1.Controls.Add(Me.glemtPassordKnapp)
        Me.Panel1.Controls.Add(Me.brukerNavnTextbox)
        Me.Panel1.Controls.Add(Me.brukernavnLabel)
        Me.Panel1.Location = New System.Drawing.Point(743, 238)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(609, 552)
        Me.Panel1.TabIndex = 15
        '
        'registrerBrukerKnapp
        '
        Me.registrerBrukerKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.registrerBrukerKnapp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.registrerBrukerKnapp.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrerBrukerKnapp.Location = New System.Drawing.Point(323, 330)
        Me.registrerBrukerKnapp.Margin = New System.Windows.Forms.Padding(4)
        Me.registrerBrukerKnapp.Name = "registrerBrukerKnapp"
        Me.registrerBrukerKnapp.Size = New System.Drawing.Size(231, 75)
        Me.registrerBrukerKnapp.TabIndex = 4
        Me.registrerBrukerKnapp.Text = "Ny bruker"
        Me.registrerBrukerKnapp.UseVisualStyleBackColor = False
        '
        'loggInnKnapp
        '
        Me.loggInnKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.loggInnKnapp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loggInnKnapp.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggInnKnapp.Location = New System.Drawing.Point(63, 330)
        Me.loggInnKnapp.Margin = New System.Windows.Forms.Padding(4)
        Me.loggInnKnapp.Name = "loggInnKnapp"
        Me.loggInnKnapp.Size = New System.Drawing.Size(231, 75)
        Me.loggInnKnapp.TabIndex = 3
        Me.loggInnKnapp.Text = "Logg Inn"
        Me.loggInnKnapp.UseVisualStyleBackColor = False
        '
        'passordTextBox
        '
        Me.passordTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.passordTextBox.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.passordTextBox.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passordTextBox.Location = New System.Drawing.Point(153, 238)
        Me.passordTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.passordTextBox.Name = "passordTextBox"
        Me.passordTextBox.Size = New System.Drawing.Size(327, 48)
        Me.passordTextBox.TabIndex = 2
        Me.passordTextBox.UseWaitCursor = True
        '
        'passordLabel
        '
        Me.passordLabel.AutoSize = True
        Me.passordLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.passordLabel.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passordLabel.Location = New System.Drawing.Point(146, 180)
        Me.passordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.passordLabel.Name = "passordLabel"
        Me.passordLabel.Size = New System.Drawing.Size(260, 40)
        Me.passordLabel.TabIndex = 5
        Me.passordLabel.Text = "Skriv inn passord:"
        '
        'glemtPassordKnapp
        '
        Me.glemtPassordKnapp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.glemtPassordKnapp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.glemtPassordKnapp.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glemtPassordKnapp.Location = New System.Drawing.Point(172, 435)
        Me.glemtPassordKnapp.Margin = New System.Windows.Forms.Padding(4)
        Me.glemtPassordKnapp.Name = "glemtPassordKnapp"
        Me.glemtPassordKnapp.Size = New System.Drawing.Size(286, 71)
        Me.glemtPassordKnapp.TabIndex = 5
        Me.glemtPassordKnapp.Text = "Glemt passord?"
        Me.glemtPassordKnapp.UseVisualStyleBackColor = False
        '
        'brukerNavnTextbox
        '
        Me.brukerNavnTextbox.BackColor = System.Drawing.SystemColors.Window
        Me.brukerNavnTextbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.brukerNavnTextbox.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brukerNavnTextbox.Location = New System.Drawing.Point(153, 92)
        Me.brukerNavnTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.brukerNavnTextbox.Name = "brukerNavnTextbox"
        Me.brukerNavnTextbox.Size = New System.Drawing.Size(327, 48)
        Me.brukerNavnTextbox.TabIndex = 1
        '
        'brukernavnLabel
        '
        Me.brukernavnLabel.AutoSize = True
        Me.brukernavnLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.brukernavnLabel.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brukernavnLabel.Location = New System.Drawing.Point(146, 34)
        Me.brukernavnLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.brukernavnLabel.Name = "brukernavnLabel"
        Me.brukernavnLabel.Size = New System.Drawing.Size(312, 40)
        Me.brukernavnLabel.TabIndex = 3
        Me.brukernavnLabel.Text = "Skriv inn brukernavn:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(740, 235)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(615, 558)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1482, 25)
        Me.Panel3.TabIndex = 17
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1457, 25)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(25, 928)
        Me.Panel6.TabIndex = 18
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 928)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1457, 25)
        Me.Panel4.TabIndex = 19
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 25)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(25, 903)
        Me.Panel5.TabIndex = 20
        '
        'loggInn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1482, 953)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "loggInn"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents registrerBrukerKnapp As Button
    Friend WithEvents loggInnKnapp As Button
    Friend WithEvents passordTextBox As TextBox
    Friend WithEvents passordLabel As Label
    Friend WithEvents glemtPassordKnapp As Button
    Friend WithEvents brukerNavnTextbox As TextBox
    Friend WithEvents brukernavnLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
End Class
