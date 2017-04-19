<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hashtest
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
        Me.plainPassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hashedPassword = New System.Windows.Forms.RichTextBox()
        Me.passwordcheck = New System.Windows.Forms.Button()
        Me.convertedToPlainpassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'plainPassword
        '
        Me.plainPassword.Location = New System.Drawing.Point(59, 53)
        Me.plainPassword.Name = "plainPassword"
        Me.plainPassword.Size = New System.Drawing.Size(100, 20)
        Me.plainPassword.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(181, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Hash"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Plain password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hashed Password"
        '
        'hashedPassword
        '
        Me.hashedPassword.Location = New System.Drawing.Point(49, 132)
        Me.hashedPassword.Name = "hashedPassword"
        Me.hashedPassword.Size = New System.Drawing.Size(352, 205)
        Me.hashedPassword.TabIndex = 4
        Me.hashedPassword.Text = ""
        '
        'passwordcheck
        '
        Me.passwordcheck.Location = New System.Drawing.Point(337, 52)
        Me.passwordcheck.Name = "passwordcheck"
        Me.passwordcheck.Size = New System.Drawing.Size(189, 23)
        Me.passwordcheck.TabIndex = 5
        Me.passwordcheck.Text = "passwordcheck"
        Me.passwordcheck.UseVisualStyleBackColor = True
        '
        'convertedToPlainpassword
        '
        Me.convertedToPlainpassword.Location = New System.Drawing.Point(337, 82)
        Me.convertedToPlainpassword.Name = "convertedToPlainpassword"
        Me.convertedToPlainpassword.Size = New System.Drawing.Size(189, 20)
        Me.convertedToPlainpassword.TabIndex = 6
        '
        'hashtest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 395)
        Me.Controls.Add(Me.convertedToPlainpassword)
        Me.Controls.Add(Me.passwordcheck)
        Me.Controls.Add(Me.hashedPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.plainPassword)
        Me.Name = "hashtest"
        Me.Text = "hashtest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents plainPassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents hashedPassword As RichTextBox
    Friend WithEvents passwordcheck As Button
    Friend WithEvents convertedToPlainpassword As TextBox
End Class
