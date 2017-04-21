<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leder
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
        Dim ChartArea21 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend21 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series21 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea22 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend22 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series22 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea23 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend23 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series23 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea24 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend24 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series24 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chartLederPlasma = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chartLederBlodplater = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.chartLederBlodlegemer = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.chartKjonn = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.bestillingerLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ledelseBestillinger = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.chartLederPlasma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.chartLederBlodplater, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.chartLederBlodlegemer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.chartKjonn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(45, 55)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(828, 484)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chartLederPlasma)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(820, 458)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Plasma oversikt"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chartLederPlasma
        '
        ChartArea21.Name = "ChartArea1"
        Me.chartLederPlasma.ChartAreas.Add(ChartArea21)
        Legend21.Name = "Legend1"
        Me.chartLederPlasma.Legends.Add(Legend21)
        Me.chartLederPlasma.Location = New System.Drawing.Point(0, 0)
        Me.chartLederPlasma.Name = "chartLederPlasma"
        Series21.ChartArea = "ChartArea1"
        Series21.Legend = "Legend1"
        Series21.Name = "Series1"
        Me.chartLederPlasma.Series.Add(Series21)
        Me.chartLederPlasma.Size = New System.Drawing.Size(817, 455)
        Me.chartLederPlasma.TabIndex = 0
        Me.chartLederPlasma.Text = "Chart1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chartLederBlodplater)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(820, 458)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Blodplate oversikt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chartLederBlodplater
        '
        ChartArea22.Name = "ChartArea1"
        Me.chartLederBlodplater.ChartAreas.Add(ChartArea22)
        Legend22.Name = "Legend1"
        Me.chartLederBlodplater.Legends.Add(Legend22)
        Me.chartLederBlodplater.Location = New System.Drawing.Point(1, 0)
        Me.chartLederBlodplater.Name = "chartLederBlodplater"
        Series22.ChartArea = "ChartArea1"
        Series22.Legend = "Legend1"
        Series22.Name = "Series1"
        Me.chartLederBlodplater.Series.Add(Series22)
        Me.chartLederBlodplater.Size = New System.Drawing.Size(823, 458)
        Me.chartLederBlodplater.TabIndex = 1
        Me.chartLederBlodplater.Text = "Chart2"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chartLederBlodlegemer)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(820, 458)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Blodlegemer oversikt"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chartLederBlodlegemer
        '
        ChartArea23.Name = "ChartArea1"
        Me.chartLederBlodlegemer.ChartAreas.Add(ChartArea23)
        Legend23.Name = "Legend1"
        Me.chartLederBlodlegemer.Legends.Add(Legend23)
        Me.chartLederBlodlegemer.Location = New System.Drawing.Point(1, 0)
        Me.chartLederBlodlegemer.Name = "chartLederBlodlegemer"
        Series23.ChartArea = "ChartArea1"
        Series23.Legend = "Legend1"
        Series23.Name = "Series1"
        Me.chartLederBlodlegemer.Series.Add(Series23)
        Me.chartLederBlodlegemer.Size = New System.Drawing.Size(813, 452)
        Me.chartLederBlodlegemer.TabIndex = 1
        Me.chartLederBlodlegemer.Text = "Chart3"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.chartKjonn)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(820, 458)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Kjønnsfordeling"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'chartKjonn
        '
        ChartArea24.Name = "ChartArea1"
        Me.chartKjonn.ChartAreas.Add(ChartArea24)
        Legend24.Name = "Legend1"
        Me.chartKjonn.Legends.Add(Legend24)
        Me.chartKjonn.Location = New System.Drawing.Point(1, 0)
        Me.chartKjonn.Name = "chartKjonn"
        Series24.ChartArea = "ChartArea1"
        Series24.Legend = "Legend1"
        Series24.Name = "Series1"
        Me.chartKjonn.Series.Add(Series24)
        Me.chartKjonn.Size = New System.Drawing.Size(816, 455)
        Me.chartKjonn.TabIndex = 2
        Me.chartKjonn.Text = "Chart3"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.bestillingerLabel)
        Me.TabPage5.Controls.Add(Me.Label6)
        Me.TabPage5.Controls.Add(Me.Label5)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.Label3)
        Me.TabPage5.Controls.Add(Me.Label2)
        Me.TabPage5.Controls.Add(Me.Label1)
        Me.TabPage5.Controls.Add(Me.ledelseBestillinger)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(820, 458)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Bestillinger"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'bestillingerLabel
        '
        Me.bestillingerLabel.AutoSize = True
        Me.bestillingerLabel.Location = New System.Drawing.Point(613, 92)
        Me.bestillingerLabel.Name = "bestillingerLabel"
        Me.bestillingerLabel.Size = New System.Drawing.Size(39, 13)
        Me.bestillingerLabel.TabIndex = 8
        Me.bestillingerLabel.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(613, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Antall bestillinger:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(436, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ordedato"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(304, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Blodmengde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Blodegenskap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Blodtype"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bestillings Id"
        '
        'ledelseBestillinger
        '
        Me.ledelseBestillinger.FormattingEnabled = True
        Me.ledelseBestillinger.Location = New System.Drawing.Point(41, 64)
        Me.ledelseBestillinger.Name = "ledelseBestillinger"
        Me.ledelseBestillinger.Size = New System.Drawing.Size(566, 368)
        Me.ledelseBestillinger.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Velkommen! Her er tilgjengelig statistikk"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(582, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 45)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Logg Ut"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Leder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 634)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Leder"
        Me.Text = "Leder"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.chartLederPlasma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.chartLederBlodplater, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.chartLederBlodlegemer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.chartKjonn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents chartLederPlasma As DataVisualization.Charting.Chart
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents bestillingerLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ledelseBestillinger As ListBox
    Friend WithEvents chartLederBlodplater As DataVisualization.Charting.Chart
    Friend WithEvents chartLederBlodlegemer As DataVisualization.Charting.Chart
    Friend WithEvents chartKjonn As DataVisualization.Charting.Chart
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
