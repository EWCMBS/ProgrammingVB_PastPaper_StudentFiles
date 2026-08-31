<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuestion3
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
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.btnQuestion3_2 = New System.Windows.Forms.Button()
        Me.txtLetter = New System.Windows.Forms.TextBox()
        Me.lblInfoEnterLetter = New System.Windows.Forms.Label()
        Me.grpWords = New System.Windows.Forms.GroupBox()
        Me.lblLineCount = New System.Windows.Forms.Label()
        Me.lstWords = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpInput.SuspendLayout()
        Me.grpWords.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.btnQuestion3_2)
        Me.grpInput.Controls.Add(Me.txtLetter)
        Me.grpInput.Controls.Add(Me.lblInfoEnterLetter)
        Me.grpInput.Location = New System.Drawing.Point(12, 12)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(589, 129)
        Me.grpInput.TabIndex = 1
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Data Input"
        '
        'btnQuestion3_2
        '
        Me.btnQuestion3_2.Location = New System.Drawing.Point(378, 74)
        Me.btnQuestion3_2.Name = "btnQuestion3_2"
        Me.btnQuestion3_2.Size = New System.Drawing.Size(178, 38)
        Me.btnQuestion3_2.TabIndex = 4
        Me.btnQuestion3_2.Text = "Q3.2 - Search"
        Me.btnQuestion3_2.UseVisualStyleBackColor = True
        '
        'txtLetter
        '
        Me.txtLetter.Location = New System.Drawing.Point(378, 26)
        Me.txtLetter.Name = "txtLetter"
        Me.txtLetter.Size = New System.Drawing.Size(178, 36)
        Me.txtLetter.TabIndex = 2
        '
        'lblInfoEnterLetter
        '
        Me.lblInfoEnterLetter.AutoSize = True
        Me.lblInfoEnterLetter.Location = New System.Drawing.Point(22, 34)
        Me.lblInfoEnterLetter.Name = "lblInfoEnterLetter"
        Me.lblInfoEnterLetter.Size = New System.Drawing.Size(350, 28)
        Me.lblInfoEnterLetter.TabIndex = 0
        Me.lblInfoEnterLetter.Text = "Enter letter(s) to search:"
        '
        'grpWords
        '
        Me.grpWords.Controls.Add(Me.lblLineCount)
        Me.grpWords.Controls.Add(Me.lstWords)
        Me.grpWords.Location = New System.Drawing.Point(12, 155)
        Me.grpWords.Name = "grpWords"
        Me.grpWords.Size = New System.Drawing.Size(521, 280)
        Me.grpWords.TabIndex = 2
        Me.grpWords.TabStop = False
        Me.grpWords.Text = "Words:"
        '
        'lblLineCount
        '
        Me.lblLineCount.AutoSize = True
        Me.lblLineCount.Location = New System.Drawing.Point(11, 27)
        Me.lblLineCount.Name = "lblLineCount"
        Me.lblLineCount.Size = New System.Drawing.Size(90, 28)
        Me.lblLineCount.TabIndex = 1
        Me.lblLineCount.Text = "Label1"
        '
        'lstWords
        '
        Me.lstWords.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.ItemHeight = 28
        Me.lstWords.Location = New System.Drawing.Point(9, 52)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(506, 200)
        Me.lstWords.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(21, 441)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(512, 37)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmQuestion3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(758, 493)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpWords)
        Me.Controls.Add(Me.grpInput)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQuestion3"
        Me.Text = "Question 3"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpWords.ResumeLayout(False)
        Me.grpWords.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents btnQuestion3_2 As Button
    Friend WithEvents txtLetter As TextBox
    Friend WithEvents lblInfoEnterLetter As Label
    Friend WithEvents grpWords As GroupBox
    Friend WithEvents lstWords As ListBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblLineCount As Label
End Class
