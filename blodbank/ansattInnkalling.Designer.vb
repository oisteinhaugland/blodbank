<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ansattInnkalling
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HjemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduktoversiktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InnkallingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BestillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisrerBlodgivingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HasteInnkallingKnapp = New System.Windows.Forms.Button()
        Me.NormalInnkallingKnapp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.klareBlodgivere = New System.Windows.Forms.ListBox()
        Me.timeDato = New System.Windows.Forms.DateTimePicker()
        Me.TidTekst = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.blodInfoKnapp = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HjemToolStripMenuItem, Me.ProduktoversiktToolStripMenuItem, Me.InnkallingToolStripMenuItem, Me.BestillingToolStripMenuItem, Me.RegisrerBlodgivingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(973, 24)
        Me.MenuStrip1.TabIndex = 8
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
        'RegisrerBlodgivingToolStripMenuItem
        '
        Me.RegisrerBlodgivingToolStripMenuItem.Name = "RegisrerBlodgivingToolStripMenuItem"
        Me.RegisrerBlodgivingToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.RegisrerBlodgivingToolStripMenuItem.Text = "Registrer blodgiving"
        '
        'HasteInnkallingKnapp
        '
        Me.HasteInnkallingKnapp.Location = New System.Drawing.Point(202, 340)
        Me.HasteInnkallingKnapp.Name = "HasteInnkallingKnapp"
        Me.HasteInnkallingKnapp.Size = New System.Drawing.Size(171, 59)
        Me.HasteInnkallingKnapp.TabIndex = 10
        Me.HasteInnkallingKnapp.Text = "Send hasteinnkalling"
        Me.HasteInnkallingKnapp.UseVisualStyleBackColor = True
        '
        'NormalInnkallingKnapp
        '
        Me.NormalInnkallingKnapp.Location = New System.Drawing.Point(10, 340)
        Me.NormalInnkallingKnapp.Name = "NormalInnkallingKnapp"
        Me.NormalInnkallingKnapp.Size = New System.Drawing.Size(171, 59)
        Me.NormalInnkallingKnapp.TabIndex = 9
        Me.NormalInnkallingKnapp.Text = "Send normal inkkaling (e-post)"
        Me.NormalInnkallingKnapp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Innkalling"
        '
        'klareBlodgivere
        '
        Me.klareBlodgivere.FormattingEnabled = True
        Me.klareBlodgivere.Location = New System.Drawing.Point(11, 75)
        Me.klareBlodgivere.Name = "klareBlodgivere"
        Me.klareBlodgivere.Size = New System.Drawing.Size(438, 173)
        Me.klareBlodgivere.TabIndex = 12
        '
        'timeDato
        '
        Me.timeDato.Location = New System.Drawing.Point(23, 269)
        Me.timeDato.Name = "timeDato"
        Me.timeDato.Size = New System.Drawing.Size(200, 20)
        Me.timeDato.TabIndex = 13
        '
        'TidTekst
        '
        Me.TidTekst.Location = New System.Drawing.Point(101, 306)
        Me.TidTekst.Name = "TidTekst"
        Me.TidTekst.Size = New System.Drawing.Size(122, 20)
        Me.TidTekst.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Tidspunkt"
        '
        'blodInfoKnapp
        '
        Me.blodInfoKnapp.Location = New System.Drawing.Point(455, 35)
        Me.blodInfoKnapp.Name = "blodInfoKnapp"
        Me.blodInfoKnapp.Size = New System.Drawing.Size(229, 81)
        Me.blodInfoKnapp.TabIndex = 16
        Me.blodInfoKnapp.Text = "Hent blogiverinformajson"
        Me.blodInfoKnapp.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Blodgivere med godkjent egenerklering"
        '
        'ansattInnkalling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 554)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.blodInfoKnapp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TidTekst)
        Me.Controls.Add(Me.timeDato)
        Me.Controls.Add(Me.klareBlodgivere)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HasteInnkallingKnapp)
        Me.Controls.Add(Me.NormalInnkallingKnapp)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ansattInnkalling"
        Me.Text = "ansattInnkalling"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HjemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduktoversiktToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InnkallingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BestillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HasteInnkallingKnapp As Button
    Friend WithEvents NormalInnkallingKnapp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents klareBlodgivere As ListBox
    Friend WithEvents timeDato As DateTimePicker
    Friend WithEvents TidTekst As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents blodInfoKnapp As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents RegisrerBlodgivingToolStripMenuItem As ToolStripMenuItem
End Class
