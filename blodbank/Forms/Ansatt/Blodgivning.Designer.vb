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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LagreBlodtapp = New System.Windows.Forms.Button()
        Me.IDtekst = New System.Windows.Forms.TextBox()
        Me.plasmaTekst = New System.Windows.Forms.TextBox()
        Me.blodlegemeTekst = New System.Windows.Forms.TextBox()
        Me.blodplateTekst = New System.Windows.Forms.TextBox()
        Me.TappeDato = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bGiverIdTextBox = New System.Windows.Forms.TextBox()
        Me.registrerBlodtypeKnapp = New System.Windows.Forms.Button()
        Me.blodprosentTekst = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Blodgiver ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Mendge plasma:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Mengde blodlegemer:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Mengde blodplater:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Dato for blodtapp:"
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
        Me.IDtekst.Location = New System.Drawing.Point(249, 32)
        Me.IDtekst.Name = "IDtekst"
        Me.IDtekst.Size = New System.Drawing.Size(133, 24)
        Me.IDtekst.TabIndex = 17
        '
        'plasmaTekst
        '
        Me.plasmaTekst.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plasmaTekst.Location = New System.Drawing.Point(249, 68)
        Me.plasmaTekst.Name = "plasmaTekst"
        Me.plasmaTekst.Size = New System.Drawing.Size(133, 24)
        Me.plasmaTekst.TabIndex = 19
        '
        'blodlegemeTekst
        '
        Me.blodlegemeTekst.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blodlegemeTekst.Location = New System.Drawing.Point(249, 101)
        Me.blodlegemeTekst.Name = "blodlegemeTekst"
        Me.blodlegemeTekst.Size = New System.Drawing.Size(133, 24)
        Me.blodlegemeTekst.TabIndex = 20
        '
        'blodplateTekst
        '
        Me.blodplateTekst.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blodplateTekst.Location = New System.Drawing.Point(249, 136)
        Me.blodplateTekst.Name = "blodplateTekst"
        Me.blodplateTekst.Size = New System.Drawing.Size(133, 24)
        Me.blodplateTekst.TabIndex = 21
        '
        'TappeDato
        '
        Me.TappeDato.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TappeDato.Location = New System.Drawing.Point(249, 215)
        Me.TappeDato.Name = "TappeDato"
        Me.TappeDato.Size = New System.Drawing.Size(133, 24)
        Me.TappeDato.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(19, 618)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 29)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Registrer blodtapp"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 61)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Button1???"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.ComboBox1.Location = New System.Drawing.Point(142, 101)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(165, 37)
        Me.ComboBox1.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(589, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Registrer Blodtype til Blogiver"
        '
        'bGiverIdTextBox
        '
        Me.bGiverIdTextBox.Location = New System.Drawing.Point(142, 59)
        Me.bGiverIdTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.bGiverIdTextBox.Name = "bGiverIdTextBox"
        Me.bGiverIdTextBox.Size = New System.Drawing.Size(165, 30)
        Me.bGiverIdTextBox.TabIndex = 28
        '
        'registrerBlodtypeKnapp
        '
        Me.registrerBlodtypeKnapp.Location = New System.Drawing.Point(6, 271)
        Me.registrerBlodtypeKnapp.Margin = New System.Windows.Forms.Padding(2)
        Me.registrerBlodtypeKnapp.Name = "registrerBlodtypeKnapp"
        Me.registrerBlodtypeKnapp.Size = New System.Drawing.Size(349, 86)
        Me.registrerBlodtypeKnapp.TabIndex = 29
        Me.registrerBlodtypeKnapp.Text = "Registrer"
        Me.registrerBlodtypeKnapp.UseVisualStyleBackColor = True
        '
        'blodprosentTekst
        '
        Me.blodprosentTekst.Location = New System.Drawing.Point(249, 173)
        Me.blodprosentTekst.Margin = New System.Windows.Forms.Padding(2)
        Me.blodprosentTekst.Name = "blodprosentTekst"
        Me.blodprosentTekst.Size = New System.Drawing.Size(133, 30)
        Me.blodprosentTekst.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.blodprosentTekst)
        Me.GroupBox1.Controls.Add(Me.TappeDato)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LagreBlodtapp)
        Me.GroupBox1.Controls.Add(Me.blodplateTekst)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.blodlegemeTekst)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.plasmaTekst)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.IDtekst)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(130, 219)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(455, 370)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrer blodtapping:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.registrerBlodtypeKnapp)
        Me.GroupBox2.Controls.Add(Me.bGiverIdTextBox)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(589, 219)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(452, 370)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registrer blodtype til blodgiver"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1194, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(19, 601)
        Me.Panel1.TabIndex = 32
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(19, 601)
        Me.Panel2.TabIndex = 33
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(19, 608)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1175, 20)
        Me.Panel3.TabIndex = 34
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(19, 562)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1175, 46)
        Me.TableLayoutPanel1.TabIndex = 35
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(19, 27)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.80241!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.19759!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1175, 591)
        Me.TableLayoutPanel2.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 23)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Blodprosent"
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
        'Blodgivning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1213, 628)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Blodgivning"
        Me.Text = "Registrer blodgiving"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HjemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduktoversiktToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InnkallingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BestillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrerBlodgivingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LagreBlodtapp As Button
    Friend WithEvents IDtekst As TextBox
    Friend WithEvents plasmaTekst As TextBox
    Friend WithEvents blodlegemeTekst As TextBox
    Friend WithEvents blodplateTekst As TextBox
    Friend WithEvents TappeDato As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox

    Friend WithEvents Label2 As Label
    Friend WithEvents bGiverIdTextBox As TextBox
    Friend WithEvents registrerBlodtypeKnapp As Button
    Friend WithEvents Label8 As Label

    'Friend WithEvents Label8 As Label
    Friend WithEvents blodprosentTekst As TextBox

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class
