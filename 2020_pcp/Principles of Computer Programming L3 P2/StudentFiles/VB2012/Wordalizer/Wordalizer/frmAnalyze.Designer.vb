<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalyze
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalyze))
        Me.grpInput = New System.Windows.Forms.GroupBox
        Me.txtInput = New System.Windows.Forms.TextBox
        Me.lblInfo1 = New System.Windows.Forms.Label
        Me.tmrMessage = New System.Windows.Forms.Timer(Me.components)
        Me.grpSelection = New System.Windows.Forms.GroupBox
        Me.chkBoth = New System.Windows.Forms.CheckBox
        Me.radConsonants = New System.Windows.Forms.RadioButton
        Me.radVowels = New System.Windows.Forms.RadioButton
        Me.grpAnalysis = New System.Windows.Forms.GroupBox
        Me.lstAnalysis = New System.Windows.Forms.ListBox
        Me.btnAnalyse = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.grpInput.SuspendLayout()
        Me.grpSelection.SuspendLayout()
        Me.grpAnalysis.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.txtInput)
        Me.grpInput.Controls.Add(Me.lblInfo1)
        Me.grpInput.Location = New System.Drawing.Point(12, 12)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(307, 70)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(9, 37)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(292, 23)
        Me.txtInput.TabIndex = 1
        Me.txtInput.Text = "Enter string"
        '
        'lblInfo1
        '
        Me.lblInfo1.AutoSize = True
        Me.lblInfo1.Location = New System.Drawing.Point(6, 19)
        Me.lblInfo1.Name = "lblInfo1"
        Me.lblInfo1.Size = New System.Drawing.Size(231, 15)
        Me.lblInfo1.TabIndex = 0
        Me.lblInfo1.Text = "Enter a word/sentence to analyse"
        '
        'tmrMessage
        '
        Me.tmrMessage.Interval = 150
        '
        'grpSelection
        '
        Me.grpSelection.Controls.Add(Me.chkBoth)
        Me.grpSelection.Controls.Add(Me.radConsonants)
        Me.grpSelection.Controls.Add(Me.radVowels)
        Me.grpSelection.Location = New System.Drawing.Point(12, 88)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.Size = New System.Drawing.Size(307, 51)
        Me.grpSelection.TabIndex = 2
        Me.grpSelection.TabStop = False
        Me.grpSelection.Text = "Selection Criteria:"
        '
        'chkBoth
        '
        Me.chkBoth.AutoSize = True
        Me.chkBoth.Location = New System.Drawing.Point(228, 22)
        Me.chkBoth.Name = "chkBoth"
        Me.chkBoth.Size = New System.Drawing.Size(54, 19)
        Me.chkBoth.TabIndex = 2
        Me.chkBoth.Text = "Both"
        Me.chkBoth.UseVisualStyleBackColor = True
        '
        'radConsonants
        '
        Me.radConsonants.AutoSize = True
        Me.radConsonants.Location = New System.Drawing.Point(95, 21)
        Me.radConsonants.Name = "radConsonants"
        Me.radConsonants.Size = New System.Drawing.Size(95, 19)
        Me.radConsonants.TabIndex = 1
        Me.radConsonants.TabStop = True
        Me.radConsonants.Text = "Consonants"
        Me.radConsonants.UseVisualStyleBackColor = True
        '
        'radVowels
        '
        Me.radVowels.AutoSize = True
        Me.radVowels.Location = New System.Drawing.Point(9, 21)
        Me.radVowels.Name = "radVowels"
        Me.radVowels.Size = New System.Drawing.Size(67, 19)
        Me.radVowels.TabIndex = 0
        Me.radVowels.TabStop = True
        Me.radVowels.Text = "Vowels"
        Me.radVowels.UseVisualStyleBackColor = True
        '
        'grpAnalysis
        '
        Me.grpAnalysis.Controls.Add(Me.lstAnalysis)
        Me.grpAnalysis.Location = New System.Drawing.Point(12, 181)
        Me.grpAnalysis.Name = "grpAnalysis"
        Me.grpAnalysis.Size = New System.Drawing.Size(307, 164)
        Me.grpAnalysis.TabIndex = 3
        Me.grpAnalysis.TabStop = False
        Me.grpAnalysis.Text = "Analysis:"
        '
        'lstAnalysis
        '
        Me.lstAnalysis.FormattingEnabled = True
        Me.lstAnalysis.ItemHeight = 15
        Me.lstAnalysis.Location = New System.Drawing.Point(9, 25)
        Me.lstAnalysis.Name = "lstAnalysis"
        Me.lstAnalysis.Size = New System.Drawing.Size(292, 124)
        Me.lstAnalysis.TabIndex = 0
        '
        'btnAnalyse
        '
        Me.btnAnalyse.Image = CType(resources.GetObject("btnAnalyse.Image"), System.Drawing.Image)
        Me.btnAnalyse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnalyse.Location = New System.Drawing.Point(13, 145)
        Me.btnAnalyse.Name = "btnAnalyse"
        Me.btnAnalyse.Size = New System.Drawing.Size(306, 30)
        Me.btnAnalyse.TabIndex = 4
        Me.btnAnalyse.Text = "&Analyse"
        Me.btnAnalyse.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(238, 351)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(12, 351)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 31)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "&Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(127, 351)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmAnalyze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(331, 394)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAnalyse)
        Me.Controls.Add(Me.grpAnalysis)
        Me.Controls.Add(Me.grpSelection)
        Me.Controls.Add(Me.grpInput)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAnalyze"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Word Analyzer - EXAMINATION NUMBER"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpSelection.ResumeLayout(False)
        Me.grpSelection.PerformLayout()
        Me.grpAnalysis.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpInput As System.Windows.Forms.GroupBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents lblInfo1 As System.Windows.Forms.Label
    Friend WithEvents tmrMessage As System.Windows.Forms.Timer
    Friend WithEvents grpSelection As System.Windows.Forms.GroupBox
    Friend WithEvents radConsonants As System.Windows.Forms.RadioButton
    Friend WithEvents radVowels As System.Windows.Forms.RadioButton
    Friend WithEvents chkBoth As System.Windows.Forms.CheckBox
    Friend WithEvents grpAnalysis As System.Windows.Forms.GroupBox
    Friend WithEvents btnAnalyse As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lstAnalysis As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button

End Class
