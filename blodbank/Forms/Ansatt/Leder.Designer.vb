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
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend9 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend10 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend11 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend12 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.statistikkTabControl = New System.Windows.Forms.TabControl()
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
        Me.LabelTilgjengeligStats = New System.Windows.Forms.Label()
        Me.loggUtBtn = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.statistikkTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.chartLederPlasma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.chartLederBlodplater, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.chartLederBlodlegemer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.chartKjonn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'statistikkTabControl
        '
        Me.statistikkTabControl.Controls.Add(Me.TabPage1)
        Me.statistikkTabControl.Controls.Add(Me.TabPage2)
        Me.statistikkTabControl.Controls.Add(Me.TabPage3)
        Me.statistikkTabControl.Controls.Add(Me.TabPage4)
        Me.statistikkTabControl.Controls.Add(Me.TabPage5)
        Me.statistikkTabControl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statistikkTabControl.Location = New System.Drawing.Point(45, 55)
        Me.statistikkTabControl.Name = "statistikkTabControl"
        Me.statistikkTabControl.SelectedIndex = 0
        Me.statistikkTabControl.Size = New System.Drawing.Size(828, 484)
        Me.statistikkTabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chartLederPlasma)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(820, 456)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Plasma oversikt"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chartLederPlasma
        '
        ChartArea9.Name = "ChartArea1"
        Me.chartLederPlasma.ChartAreas.Add(ChartArea9)
        Legend9.Name = "Legend1"
        Me.chartLederPlasma.Legends.Add(Legend9)
        Me.chartLederPlasma.Location = New System.Drawing.Point(0, 0)
        Me.chartLederPlasma.Name = "chartLederPlasma"
        Series9.ChartArea = "ChartArea1"
        Series9.Legend = "Legend1"
        Series9.Name = "Series1"
        Me.chartLederPlasma.Series.Add(Series9)
        Me.chartLederPlasma.Size = New System.Drawing.Size(817, 455)
        Me.chartLederPlasma.TabIndex = 0
        Me.chartLederPlasma.Text = "Chart1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chartLederBlodplater)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(820, 456)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Blodplate oversikt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chartLederBlodplater
        '
        ChartArea10.Name = "ChartArea1"
        Me.chartLederBlodplater.ChartAreas.Add(ChartArea10)
        Legend10.Name = "Legend1"
        Me.chartLederBlodplater.Legends.Add(Legend10)
        Me.chartLederBlodplater.Location = New System.Drawing.Point(0, 0)
        Me.chartLederBlodplater.Name = "chartLederBlodplater"
        Series10.ChartArea = "ChartArea1"
        Series10.Legend = "Legend1"
        Series10.Name = "Series1"
        Me.chartLederBlodplater.Series.Add(Series10)
        Me.chartLederBlodplater.Size = New System.Drawing.Size(817, 455)
        Me.chartLederBlodplater.TabIndex = 1
        Me.chartLederBlodplater.Text = "Chart2"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chartLederBlodlegemer)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(820, 456)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Blodlegemer oversikt"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chartLederBlodlegemer
        '
        ChartArea11.Name = "ChartArea1"
        Me.chartLederBlodlegemer.ChartAreas.Add(ChartArea11)
        Legend11.Name = "Legend1"
        Me.chartLederBlodlegemer.Legends.Add(Legend11)
        Me.chartLederBlodlegemer.Location = New System.Drawing.Point(0, 0)
        Me.chartLederBlodlegemer.Name = "chartLederBlodlegemer"
        Series11.ChartArea = "ChartArea1"
        Series11.Legend = "Legend1"
        Series11.Name = "Series1"
        Me.chartLederBlodlegemer.Series.Add(Series11)
        Me.chartLederBlodlegemer.Size = New System.Drawing.Size(817, 455)
        Me.chartLederBlodlegemer.TabIndex = 1
        Me.chartLederBlodlegemer.Text = "Chart3"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.chartKjonn)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(820, 456)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Kjønnsfordeling"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'chartKjonn
        '
        ChartArea12.Name = "ChartArea1"
        Me.chartKjonn.ChartAreas.Add(ChartArea12)
        Legend12.Name = "Legend1"
        Me.chartKjonn.Legends.Add(Legend12)
        Me.chartKjonn.Location = New System.Drawing.Point(0, 0)
        Me.chartKjonn.Name = "chartKjonn"
        Series12.ChartArea = "ChartArea1"
        Series12.Legend = "Legend1"
        Series12.Name = "Series1"
        Me.chartKjonn.Series.Add(Series12)
        Me.chartKjonn.Size = New System.Drawing.Size(817, 455)
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
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(820, 456)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Bestillinger"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'bestillingerLabel
        '
        Me.bestillingerLabel.AutoSize = True
        Me.bestillingerLabel.Location = New System.Drawing.Point(613, 92)
        Me.bestillingerLabel.Name = "bestillingerLabel"
        Me.bestillingerLabel.Size = New System.Drawing.Size(43, 15)
        Me.bestillingerLabel.TabIndex = 8
        Me.bestillingerLabel.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(613, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Antall bestillinger:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(511, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ordedato"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(341, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Blodmengde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Blodegenskap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Blodtype"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bestillings Id"
        '
        'ledelseBestillinger
        '
        Me.ledelseBestillinger.FormattingEnabled = True
        Me.ledelseBestillinger.ItemHeight = 15
        Me.ledelseBestillinger.Location = New System.Drawing.Point(41, 64)
        Me.ledelseBestillinger.Name = "ledelseBestillinger"
        Me.ledelseBestillinger.Size = New System.Drawing.Size(566, 364)
        Me.ledelseBestillinger.TabIndex = 0
        '
        'LabelTilgjengeligStats
        '
        Me.LabelTilgjengeligStats.AutoSize = True
        Me.LabelTilgjengeligStats.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTilgjengeligStats.Location = New System.Drawing.Point(42, 24)
        Me.LabelTilgjengeligStats.Name = "LabelTilgjengeligStats"
        Me.LabelTilgjengeligStats.Size = New System.Drawing.Size(363, 26)
        Me.LabelTilgjengeligStats.TabIndex = 1
        Me.LabelTilgjengeligStats.Text = "Velkommen! Her er tilgjengelig statistikk"
        '
        'loggUtBtn
        '
        Me.loggUtBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.loggUtBtn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggUtBtn.Location = New System.Drawing.Point(582, 26)
        Me.loggUtBtn.Name = "loggUtBtn"
        Me.loggUtBtn.Size = New System.Drawing.Size(168, 45)
        Me.loggUtBtn.TabIndex = 2
        Me.loggUtBtn.Text = "Logg Ut"
        Me.loggUtBtn.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(16, 634)
        Me.Panel5.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1044, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(16, 634)
        Me.Panel1.TabIndex = 35
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 618)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(16, 16)
        Me.Panel3.TabIndex = 36
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(16, 618)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1028, 16)
        Me.Panel2.TabIndex = 36
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(16, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1028, 20)
        Me.Panel4.TabIndex = 37
        '
        'Leder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 634)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.loggUtBtn)
        Me.Controls.Add(Me.LabelTilgjengeligStats)
        Me.Controls.Add(Me.statistikkTabControl)
        Me.Name = "Leder"
        Me.Text = "Leder"
        Me.statistikkTabControl.ResumeLayout(False)
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
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents statistikkTabControl As TabControl
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
    Friend WithEvents LabelTilgjengeligStats As Label
    Friend WithEvents loggUtBtn As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
End Class
