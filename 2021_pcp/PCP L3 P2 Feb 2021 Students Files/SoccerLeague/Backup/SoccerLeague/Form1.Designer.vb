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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNoOfPasses = New System.Windows.Forms.TextBox
        Me.cboPosition = New System.Windows.Forms.ComboBox
        Me.txtSuccesfulPasses = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCalcPerformance = New System.Windows.Forms.Button
        Me.txtGolasScored = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtShotsOnTarget = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTeamName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPlayerName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblDate = New System.Windows.Forms.Label
        Me.btnNextPlayer = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblPerformance = New System.Windows.Forms.Label
        Me.lblTeamName = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblPlayerName = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNoOfPasses)
        Me.GroupBox1.Controls.Add(Me.cboPosition)
        Me.GroupBox1.Controls.Add(Me.txtSuccesfulPasses)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnCalcPerformance)
        Me.GroupBox1.Controls.Add(Me.txtGolasScored)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtShotsOnTarget)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTeamName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPlayerName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 269)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Player Information:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Select: "
        '
        'txtNoOfPasses
        '
        Me.txtNoOfPasses.Location = New System.Drawing.Point(148, 135)
        Me.txtNoOfPasses.MaxLength = 3
        Me.txtNoOfPasses.Name = "txtNoOfPasses"
        Me.txtNoOfPasses.Size = New System.Drawing.Size(70, 23)
        Me.txtNoOfPasses.TabIndex = 5
        '
        'cboPosition
        '
        Me.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Location = New System.Drawing.Point(145, 23)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(160, 24)
        Me.cboPosition.TabIndex = 1
        '
        'txtSuccesfulPasses
        '
        Me.txtSuccesfulPasses.Location = New System.Drawing.Point(148, 189)
        Me.txtSuccesfulPasses.MaxLength = 3
        Me.txtSuccesfulPasses.Name = "txtSuccesfulPasses"
        Me.txtSuccesfulPasses.Size = New System.Drawing.Size(70, 23)
        Me.txtSuccesfulPasses.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Successful Passes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Number Of Passes:"
        '
        'btnCalcPerformance
        '
        Me.btnCalcPerformance.Location = New System.Drawing.Point(18, 220)
        Me.btnCalcPerformance.Name = "btnCalcPerformance"
        Me.btnCalcPerformance.Size = New System.Drawing.Size(290, 32)
        Me.btnCalcPerformance.TabIndex = 8
        Me.btnCalcPerformance.Text = "Calculate Performance Rate"
        Me.btnCalcPerformance.UseVisualStyleBackColor = True
        '
        'txtGolasScored
        '
        Me.txtGolasScored.Location = New System.Drawing.Point(148, 162)
        Me.txtGolasScored.MaxLength = 2
        Me.txtGolasScored.Name = "txtGolasScored"
        Me.txtGolasScored.Size = New System.Drawing.Size(70, 23)
        Me.txtGolasScored.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Goals Scored:"
        '
        'txtShotsOnTarget
        '
        Me.txtShotsOnTarget.Location = New System.Drawing.Point(148, 109)
        Me.txtShotsOnTarget.MaxLength = 3
        Me.txtShotsOnTarget.Name = "txtShotsOnTarget"
        Me.txtShotsOnTarget.Size = New System.Drawing.Size(70, 23)
        Me.txtShotsOnTarget.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Shots on Target:"
        '
        'txtTeamName
        '
        Me.txtTeamName.Location = New System.Drawing.Point(145, 79)
        Me.txtTeamName.MaxLength = 40
        Me.txtTeamName.Name = "txtTeamName"
        Me.txtTeamName.Size = New System.Drawing.Size(160, 23)
        Me.txtTeamName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Team Name:"
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Location = New System.Drawing.Point(145, 53)
        Me.txtPlayerName.MaxLength = 50
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(160, 23)
        Me.txtPlayerName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player Name:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.btnNextPlayer)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Location = New System.Drawing.Point(-3, 313)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 63)
        Me.Panel1.TabIndex = 7
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(35, 22)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(51, 17)
        Me.lblDate.TabIndex = 17
        Me.lblDate.Text = "Label4"
        '
        'btnNextPlayer
        '
        Me.btnNextPlayer.Location = New System.Drawing.Point(362, 22)
        Me.btnNextPlayer.Name = "btnNextPlayer"
        Me.btnNextPlayer.Size = New System.Drawing.Size(120, 28)
        Me.btnNextPlayer.TabIndex = 9
        Me.btnNextPlayer.Text = "Next Player"
        Me.btnNextPlayer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(520, 23)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 28)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SoccerLeague.My.Resources.Resources.football
        Me.PictureBox1.Location = New System.Drawing.Point(364, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'lblPerformance
        '
        Me.lblPerformance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPerformance.Location = New System.Drawing.Point(361, 247)
        Me.lblPerformance.Name = "lblPerformance"
        Me.lblPerformance.Size = New System.Drawing.Size(269, 32)
        Me.lblPerformance.TabIndex = 25
        Me.lblPerformance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTeamName
        '
        Me.lblTeamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTeamName.Location = New System.Drawing.Point(361, 215)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(269, 32)
        Me.lblTeamName.TabIndex = 24
        Me.lblTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(366, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Performance Statistics"
        '
        'lblPlayerName
        '
        Me.lblPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayerName.Location = New System.Drawing.Point(361, 184)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(269, 32)
        Me.lblPlayerName.TabIndex = 22
        Me.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(642, 378)
        Me.Controls.Add(Me.lblPerformance)
        Me.Controls.Add(Me.lblTeamName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "EXAMINATION NUMBER HERE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfPasses As System.Windows.Forms.TextBox
    Friend WithEvents cboPosition As System.Windows.Forms.ComboBox
    Friend WithEvents txtSuccesfulPasses As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCalcPerformance As System.Windows.Forms.Button
    Friend WithEvents txtGolasScored As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtShotsOnTarget As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTeamName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPlayerName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnNextPlayer As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPerformance As System.Windows.Forms.Label
    Friend WithEvents lblTeamName As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label

End Class
