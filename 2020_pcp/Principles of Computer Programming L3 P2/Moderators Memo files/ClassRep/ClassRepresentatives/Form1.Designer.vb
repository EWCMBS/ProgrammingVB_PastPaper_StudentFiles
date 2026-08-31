<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gboCandidate = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInitials = New System.Windows.Forms.TextBox()
        Me.btnSubmitNominee = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCandidates = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCastVote = New System.Windows.Forms.Button()
        Me.cboVotersList = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalVotesCast = New System.Windows.Forms.Label()
        Me.btnViewResults = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gboCandidate.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class Representative Voting System"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(26, 86)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(539, 317)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.gboCandidate)
        Me.TabPage1.Controls.Add(Me.btnSubmitNominee)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(531, 284)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Nomination Form"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gboCandidate
        '
        Me.gboCandidate.Controls.Add(Me.Label2)
        Me.gboCandidate.Controls.Add(Me.txtSurname)
        Me.gboCandidate.Controls.Add(Me.Label3)
        Me.gboCandidate.Controls.Add(Me.txtInitials)
        Me.gboCandidate.Location = New System.Drawing.Point(90, 42)
        Me.gboCandidate.Name = "gboCandidate"
        Me.gboCandidate.Size = New System.Drawing.Size(367, 126)
        Me.gboCandidate.TabIndex = 7
        Me.gboCandidate.TabStop = False
        Me.gboCandidate.Text = "Candidate Information:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Surname:"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(107, 44)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(215, 26)
        Me.txtSurname.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Initials:"
        '
        'txtInitials
        '
        Me.txtInitials.Location = New System.Drawing.Point(107, 76)
        Me.txtInitials.Name = "txtInitials"
        Me.txtInitials.Size = New System.Drawing.Size(100, 26)
        Me.txtInitials.TabIndex = 3
        '
        'btnSubmitNominee
        '
        Me.btnSubmitNominee.Location = New System.Drawing.Point(90, 195)
        Me.btnSubmitNominee.Name = "btnSubmitNominee"
        Me.btnSubmitNominee.Size = New System.Drawing.Size(367, 35)
        Me.btnSubmitNominee.TabIndex = 4
        Me.btnSubmitNominee.Text = "Submit your Nominee"
        Me.btnSubmitNominee.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.cboCandidates)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.btnCastVote)
        Me.TabPage2.Controls.Add(Me.cboVotersList)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(531, 284)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Voting Process"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(245, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Choose your preferred candidate:"
        '
        'cboCandidates
        '
        Me.cboCandidates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCandidates.FormattingEnabled = True
        Me.cboCandidates.Location = New System.Drawing.Point(67, 110)
        Me.cboCandidates.Name = "cboCandidates"
        Me.cboCandidates.Size = New System.Drawing.Size(396, 28)
        Me.cboCandidates.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Check name on voters roll:"
        '
        'btnCastVote
        '
        Me.btnCastVote.Location = New System.Drawing.Point(67, 153)
        Me.btnCastVote.Name = "btnCastVote"
        Me.btnCastVote.Size = New System.Drawing.Size(396, 44)
        Me.btnCastVote.TabIndex = 12
        Me.btnCastVote.Text = "CLICK HERE TO VOTE"
        Me.btnCastVote.UseVisualStyleBackColor = True
        '
        'cboVotersList
        '
        Me.cboVotersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVotersList.FormattingEnabled = True
        Me.cboVotersList.Location = New System.Drawing.Point(67, 40)
        Me.cboVotersList.Name = "cboVotersList"
        Me.cboVotersList.Size = New System.Drawing.Size(396, 28)
        Me.cboVotersList.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblPercentage)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Location = New System.Drawing.Point(67, 214)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 60)
        Me.Panel1.TabIndex = 7
        '
        'lblPercentage
        '
        Me.lblPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.Location = New System.Drawing.Point(189, 17)
        Me.lblPercentage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(187, 23)
        Me.lblPercentage.TabIndex = 8
        Me.lblPercentage.Text = "% voted"
        Me.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(18, 17)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(164, 23)
        Me.ProgressBar1.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage3.Controls.Add(Me.ListView1)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.lblTotalVotesCast)
        Me.TabPage3.Controls.Add(Me.btnViewResults)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(531, 284)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Results View"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(44, 38)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(303, 160)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(104, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total Votes Cast:"
        '
        'lblTotalVotesCast
        '
        Me.lblTotalVotesCast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalVotesCast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVotesCast.Location = New System.Drawing.Point(242, 218)
        Me.lblTotalVotesCast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalVotesCast.Name = "lblTotalVotesCast"
        Me.lblTotalVotesCast.Size = New System.Drawing.Size(81, 23)
        Me.lblTotalVotesCast.TabIndex = 11
        Me.lblTotalVotesCast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnViewResults
        '
        Me.btnViewResults.Location = New System.Drawing.Point(382, 38)
        Me.btnViewResults.Name = "btnViewResults"
        Me.btnViewResults.Size = New System.Drawing.Size(112, 160)
        Me.btnViewResults.TabIndex = 10
        Me.btnViewResults.Text = "Click To View"
        Me.btnViewResults.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(426, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(592, 63)
        Me.Panel2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(592, 469)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EXAMINATION NUMBER HERE"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gboCandidate.ResumeLayout(False)
        Me.gboCandidate.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtInitials As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSubmitNominee As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents gboCandidate As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblPercentage As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnCastVote As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCandidates As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboVotersList As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnViewResults As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotalVotesCast As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView

End Class
