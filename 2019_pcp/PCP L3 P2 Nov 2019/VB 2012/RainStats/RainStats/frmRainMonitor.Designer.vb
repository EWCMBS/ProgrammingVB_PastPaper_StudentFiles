<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRainMonitor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClearALL = New System.Windows.Forms.Button
        Me.btnRainfallStats = New System.Windows.Forms.Button
        Me.btnRainfallFigures = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lstDisplayRainfallData = New System.Windows.Forms.ListBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblAvgRainfall = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblWettestMonth = New System.Windows.Forms.Label
        Me.lblDriestYear = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl2008Total = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbl2010Total = New System.Windows.Forms.Label
        Me.lbl2006Total = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lbl2009Total = New System.Windows.Forms.Label
        Me.lbl2007Total = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClearALL
        '
        Me.btnClearALL.Location = New System.Drawing.Point(357, 12)
        Me.btnClearALL.Name = "btnClearALL"
        Me.btnClearALL.Size = New System.Drawing.Size(85, 51)
        Me.btnClearALL.TabIndex = 2
        Me.btnClearALL.Text = "&Clear All"
        Me.btnClearALL.UseVisualStyleBackColor = True
        '
        'btnRainfallStats
        '
        Me.btnRainfallStats.Location = New System.Drawing.Point(178, 12)
        Me.btnRainfallStats.Name = "btnRainfallStats"
        Me.btnRainfallStats.Size = New System.Drawing.Size(164, 51)
        Me.btnRainfallStats.TabIndex = 0
        Me.btnRainfallStats.Text = "Calculate Rainfall &Statistics"
        Me.btnRainfallStats.UseVisualStyleBackColor = True
        '
        'btnRainfallFigures
        '
        Me.btnRainfallFigures.Location = New System.Drawing.Point(16, 12)
        Me.btnRainfallFigures.Name = "btnRainfallFigures"
        Me.btnRainfallFigures.Size = New System.Drawing.Size(148, 51)
        Me.btnRainfallFigures.TabIndex = 1
        Me.btnRainfallFigures.Text = "Show Rainfall &Figures"
        Me.btnRainfallFigures.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(10, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(430, 267)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage1.Controls.Add(Me.lstDisplayRainfallData)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(422, 239)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Rainfall Figures"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lstDisplayRainfallData
        '
        Me.lstDisplayRainfallData.FormattingEnabled = True
        Me.lstDisplayRainfallData.ItemHeight = 15
        Me.lstDisplayRainfallData.Location = New System.Drawing.Point(38, 22)
        Me.lstDisplayRainfallData.Name = "lstDisplayRainfallData"
        Me.lstDisplayRainfallData.Size = New System.Drawing.Size(350, 184)
        Me.lstDisplayRainfallData.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(422, 239)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rainfall statistics"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAvgRainfall)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblWettestMonth)
        Me.GroupBox2.Controls.Add(Me.lblDriestYear)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 108)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'lblAvgRainfall
        '
        Me.lblAvgRainfall.BackColor = System.Drawing.Color.Transparent
        Me.lblAvgRainfall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvgRainfall.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgRainfall.Location = New System.Drawing.Point(227, 66)
        Me.lblAvgRainfall.Name = "lblAvgRainfall"
        Me.lblAvgRainfall.Size = New System.Drawing.Size(116, 27)
        Me.lblAvgRainfall.TabIndex = 18
        Me.lblAvgRainfall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(74, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(147, 15)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "The driest year was:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(-3, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "The average rainfall per month:"
        '
        'lblWettestMonth
        '
        Me.lblWettestMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblWettestMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWettestMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWettestMonth.Location = New System.Drawing.Point(227, 38)
        Me.lblWettestMonth.Name = "lblWettestMonth"
        Me.lblWettestMonth.Size = New System.Drawing.Size(116, 27)
        Me.lblWettestMonth.TabIndex = 15
        Me.lblWettestMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDriestYear
        '
        Me.lblDriestYear.BackColor = System.Drawing.Color.Transparent
        Me.lblDriestYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDriestYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriestYear.Location = New System.Drawing.Point(227, 13)
        Me.lblDriestYear.Name = "lblDriestYear"
        Me.lblDriestYear.Size = New System.Drawing.Size(116, 25)
        Me.lblDriestYear.TabIndex = 16
        Me.lblDriestYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(60, 44)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(161, 15)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "The wettest month was:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbl2008Total)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbl2010Total)
        Me.GroupBox1.Controls.Add(Me.lbl2006Total)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lbl2009Total)
        Me.GroupBox1.Controls.Add(Me.lbl2007Total)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 93)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total rainfall for each year:"
        '
        'lbl2008Total
        '
        Me.lbl2008Total.BackColor = System.Drawing.Color.Transparent
        Me.lbl2008Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2008Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2008Total.Location = New System.Drawing.Point(150, 48)
        Me.lbl2008Total.Name = "lbl2008Total"
        Me.lbl2008Total.Size = New System.Drawing.Size(66, 27)
        Me.lbl2008Total.TabIndex = 11
        Me.lbl2008Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(38, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "2014"
        '
        'lbl2010Total
        '
        Me.lbl2010Total.BackColor = System.Drawing.Color.Transparent
        Me.lbl2010Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2010Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2010Total.Location = New System.Drawing.Point(282, 48)
        Me.lbl2010Total.Name = "lbl2010Total"
        Me.lbl2010Total.Size = New System.Drawing.Size(62, 27)
        Me.lbl2010Total.TabIndex = 10
        Me.lbl2010Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2006Total
        '
        Me.lbl2006Total.BackColor = System.Drawing.Color.Transparent
        Me.lbl2006Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2006Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2006Total.Location = New System.Drawing.Point(18, 48)
        Me.lbl2006Total.Name = "lbl2006Total"
        Me.lbl2006Total.Size = New System.Drawing.Size(66, 27)
        Me.lbl2006Total.TabIndex = 2
        Me.lbl2006Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(294, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 15)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "2018"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(102, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 15)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "2015"
        '
        'lbl2009Total
        '
        Me.lbl2009Total.BackColor = System.Drawing.Color.Transparent
        Me.lbl2009Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2009Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2009Total.Location = New System.Drawing.Point(216, 48)
        Me.lbl2009Total.Name = "lbl2009Total"
        Me.lbl2009Total.Size = New System.Drawing.Size(66, 27)
        Me.lbl2009Total.TabIndex = 8
        Me.lbl2009Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2007Total
        '
        Me.lbl2007Total.BackColor = System.Drawing.Color.Transparent
        Me.lbl2007Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2007Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2007Total.Location = New System.Drawing.Point(84, 48)
        Me.lbl2007Total.Name = "lbl2007Total"
        Me.lbl2007Total.Size = New System.Drawing.Size(66, 27)
        Me.lbl2007Total.TabIndex = 4
        Me.lbl2007Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(231, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 15)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "2017"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(164, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 15)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "2016"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnRainfallStats)
        Me.Panel1.Controls.Add(Me.btnClearALL)
        Me.Panel1.Controls.Add(Me.btnRainfallFigures)
        Me.Panel1.Location = New System.Drawing.Point(-6, 292)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 71)
        Me.Panel1.TabIndex = 3
        '
        'frmMonthlyRainfallMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(456, 368)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMonthlyRainfallMonitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examination Number"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRainfallStats As System.Windows.Forms.Button
    Friend WithEvents btnRainfallFigures As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lstDisplayRainfallData As System.Windows.Forms.ListBox
    Friend WithEvents lbl2010Total As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lbl2009Total As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl2007Total As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl2006Total As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblWettestMonth As System.Windows.Forms.Label
    Friend WithEvents btnClearALL As System.Windows.Forms.Button
    Friend WithEvents lblDriestYear As System.Windows.Forms.Label
    Friend WithEvents lblAvgRainfall As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl2008Total As System.Windows.Forms.Label
End Class
