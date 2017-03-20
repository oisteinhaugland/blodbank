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
        Me.loggInnKnapp = New System.Windows.Forms.Button()
        Me.brukerNavnTextbox = New System.Windows.Forms.TextBox()
        Me.passordTextBox = New System.Windows.Forms.TextBox()
        Me.brukernavnLabel = New System.Windows.Forms.Label()
        Me.passordLabel = New System.Windows.Forms.Label()
        Me.registrerBrukerKnapp = New System.Windows.Forms.Button()
        Me.glemtPassordKnapp = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'loggInnKnapp
        '
        Me.loggInnKnapp.Location = New System.Drawing.Point(111, 208)
        Me.loggInnKnapp.Name = "loggInnKnapp"
        Me.loggInnKnapp.Size = New System.Drawing.Size(102, 39)
        Me.loggInnKnapp.TabIndex = 3
        Me.loggInnKnapp.Text = "Logg Inn"
        Me.loggInnKnapp.UseVisualStyleBackColor = True
        '
        'brukerNavnTextbox
        '
        Me.brukerNavnTextbox.Location = New System.Drawing.Point(111, 113)
        Me.brukerNavnTextbox.Name = "brukerNavnTextbox"
        Me.brukerNavnTextbox.Size = New System.Drawing.Size(100, 20)
        Me.brukerNavnTextbox.TabIndex = 1
        '
        'passordTextBox
        '
        Me.passordTextBox.Location = New System.Drawing.Point(111, 162)
        Me.passordTextBox.Name = "passordTextBox"
        Me.passordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.passordTextBox.TabIndex = 2
        '
        'brukernavnLabel
        '
        Me.brukernavnLabel.AutoSize = True
        Me.brukernavnLabel.Location = New System.Drawing.Point(108, 97)
        Me.brukernavnLabel.Name = "brukernavnLabel"
        Me.brukernavnLabel.Size = New System.Drawing.Size(105, 13)
        Me.brukernavnLabel.TabIndex = 3
        Me.brukernavnLabel.Text = "Skriv inn brukernavn"
        '
        'passordLabel
        '
        Me.passordLabel.AutoSize = True
        Me.passordLabel.Location = New System.Drawing.Point(108, 146)
        Me.passordLabel.Name = "passordLabel"
        Me.passordLabel.Size = New System.Drawing.Size(88, 13)
        Me.passordLabel.TabIndex = 5
        Me.passordLabel.Text = "Skriv inn passord"
        '
        'registrerBrukerKnapp
        '
        Me.registrerBrukerKnapp.Location = New System.Drawing.Point(217, 208)
        Me.registrerBrukerKnapp.Name = "registrerBrukerKnapp"
        Me.registrerBrukerKnapp.Size = New System.Drawing.Size(100, 39)
        Me.registrerBrukerKnapp.TabIndex = 4
        Me.registrerBrukerKnapp.Text = "Ny bruker"
        Me.registrerBrukerKnapp.UseVisualStyleBackColor = True
        '
        'glemtPassordKnapp
        '
        Me.glemtPassordKnapp.Location = New System.Drawing.Point(111, 267)
        Me.glemtPassordKnapp.Name = "glemtPassordKnapp"
        Me.glemtPassordKnapp.Size = New System.Drawing.Size(102, 33)
        Me.glemtPassordKnapp.TabIndex = 5
        Me.glemtPassordKnapp.Text = "Glemt passord?"
        Me.glemtPassordKnapp.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(622, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "HashTest"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'loggInn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 543)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.glemtPassordKnapp)
        Me.Controls.Add(Me.registrerBrukerKnapp)
        Me.Controls.Add(Me.passordLabel)
        Me.Controls.Add(Me.brukernavnLabel)
        Me.Controls.Add(Me.passordTextBox)
        Me.Controls.Add(Me.brukerNavnTextbox)
        Me.Controls.Add(Me.loggInnKnapp)
        Me.Name = "loggInn"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loggInnKnapp As Button
    Friend WithEvents brukerNavnTextbox As TextBox
    Friend WithEvents passordTextBox As TextBox
    Friend WithEvents brukernavnLabel As Label
    Friend WithEvents passordLabel As Label
    Friend WithEvents registrerBrukerKnapp As Button
    Friend WithEvents glemtPassordKnapp As Button
    Friend WithEvents Button1 As Button
End Class
