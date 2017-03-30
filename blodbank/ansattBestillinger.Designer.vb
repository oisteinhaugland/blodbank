<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ansattBestillinger
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
        Me.motatteBestillinger = New System.Windows.Forms.ListBox()
        Me.bekreft_Utlevering = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.utleveringLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HjemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduktoversiktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InnkallingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrerBlodgivingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'motatteBestillinger
        '
        Me.motatteBestillinger.FormattingEnabled = True
        Me.motatteBestillinger.Location = New System.Drawing.Point(98, 133)
        Me.motatteBestillinger.Name = "motatteBestillinger"
        Me.motatteBestillinger.Size = New System.Drawing.Size(120, 95)
        Me.motatteBestillinger.TabIndex = 0
        '
        'bekreft_Utlevering
        '
        Me.bekreft_Utlevering.Location = New System.Drawing.Point(247, 133)
        Me.bekreft_Utlevering.Name = "bekreft_Utlevering"
        Me.bekreft_Utlevering.Size = New System.Drawing.Size(136, 27)
        Me.bekreft_Utlevering.TabIndex = 1
        Me.bekreft_Utlevering.Text = "Bekreft utlevering"
        Me.bekreft_Utlevering.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(247, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Logg ut"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(247, 166)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Produktoversikt"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(389, 78)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Location = New System.Drawing.Point(73, 104)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(145, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Hent ut bestillinger"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(308, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bestilling"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Motatte Bestillinger:"
        '
        'utleveringLabel
        '
        Me.utleveringLabel.AutoSize = True
        Me.utleveringLabel.Location = New System.Drawing.Point(57, 231)
        Me.utleveringLabel.Name = "utleveringLabel"
        Me.utleveringLabel.Size = New System.Drawing.Size(204, 13)
        Me.utleveringLabel.TabIndex = 10
        Me.utleveringLabel.Text = "Utlevering vellyket, varelager er oppdatert"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HjemToolStripMenuItem, Me.ProduktoversiktToolStripMenuItem, Me.InnkallingToolStripMenuItem, Me.BestillingToolStripMenuItem, Me.RegistrerBlodgivingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(655, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HjemToolStripMenuItem
        '
        Me.HjemToolStripMenuItem.Name = "HjemToolStripMenuItem"
        Me.HjemToolStripMenuItem.Size = New System.Drawing.Size(48, 22)
        Me.HjemToolStripMenuItem.Text = "Hjem"
        '
        'ProduktoversiktToolStripMenuItem
        '
        Me.ProduktoversiktToolStripMenuItem.Name = "ProduktoversiktToolStripMenuItem"
        Me.ProduktoversiktToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ProduktoversiktToolStripMenuItem.Text = "Produktoversikt"
        '
        'InnkallingToolStripMenuItem
        '
        Me.InnkallingToolStripMenuItem.Name = "InnkallingToolStripMenuItem"
        Me.InnkallingToolStripMenuItem.Size = New System.Drawing.Size(71, 22)
        Me.InnkallingToolStripMenuItem.Text = "Innkalling"
        '
        'BestillingToolStripMenuItem
        '
        Me.BestillingToolStripMenuItem.Name = "BestillingToolStripMenuItem"
        Me.BestillingToolStripMenuItem.Size = New System.Drawing.Size(67, 22)
        Me.BestillingToolStripMenuItem.Text = "Bestilling"
        '
        'RegistrerBlodgivingToolStripMenuItem
        '
        Me.RegistrerBlodgivingToolStripMenuItem.Name = "RegistrerBlodgivingToolStripMenuItem"
        Me.RegistrerBlodgivingToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.RegistrerBlodgivingToolStripMenuItem.Text = "Registrer blodgiving"
        '
        'ansattBestillinger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 463)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.utleveringLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bekreft_Utlevering)
        Me.Controls.Add(Me.motatteBestillinger)
        Me.Name = "ansattBestillinger"
        Me.Text = "ansattBestillinger"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents motatteBestillinger As ListBox
    Friend WithEvents bekreft_Utlevering As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents utleveringLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HjemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduktoversiktToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InnkallingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BestillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrerBlodgivingToolStripMenuItem As ToolStripMenuItem
End Class
