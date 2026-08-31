<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion1
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
        Me.lblInfoHeading1 = New System.Windows.Forms.Label()
        Me.grpQuestion1_1 = New System.Windows.Forms.GroupBox()
        Me.lblDisplayCustInfo = New System.Windows.Forms.Label()
        Me.btnQuestion1_1 = New System.Windows.Forms.Button()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtIdNumber = New System.Windows.Forms.TextBox()
        Me.lblInfoSurname = New System.Windows.Forms.Label()
        Me.lblInfoFirstName = New System.Windows.Forms.Label()
        Me.lblInfoID_Number = New System.Windows.Forms.Label()
        Me.grpQuestion1_2 = New System.Windows.Forms.GroupBox()
        Me.radMultiPartner = New System.Windows.Forms.RadioButton()
        Me.radStandAlone = New System.Windows.Forms.RadioButton()
        Me.lblInfoHeading2 = New System.Windows.Forms.Label()
        Me.grpQuestion1_4 = New System.Windows.Forms.GroupBox()
        Me.lblDisplayMembershipNumber = New System.Windows.Forms.Label()
        Me.btnQuestion1_4 = New System.Windows.Forms.Button()
        Me.chkLoyaltyCard = New System.Windows.Forms.CheckBox()
        Me.grpQuestion1_3 = New System.Windows.Forms.GroupBox()
        Me.lblDisplayPoints = New System.Windows.Forms.Label()
        Me.btnQuestion1_3 = New System.Windows.Forms.Button()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.lblInfoRewards = New System.Windows.Forms.Label()
        Me.lblInfoTotalAmount = New System.Windows.Forms.Label()
        Me.grpQuestion1_1.SuspendLayout()
        Me.grpQuestion1_2.SuspendLayout()
        Me.grpQuestion1_4.SuspendLayout()
        Me.grpQuestion1_3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInfoHeading1
        '
        Me.lblInfoHeading1.AutoSize = True
        Me.lblInfoHeading1.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoHeading1.Location = New System.Drawing.Point(12, 9)
        Me.lblInfoHeading1.Name = "lblInfoHeading1"
        Me.lblInfoHeading1.Size = New System.Drawing.Size(1058, 42)
        Me.lblInfoHeading1.TabIndex = 0
        Me.lblInfoHeading1.Text = "MZANSI SUPERSTORE LOYALTY PROGRAMME CARD APPLICATION"
        '
        'grpQuestion1_1
        '
        Me.grpQuestion1_1.Controls.Add(Me.lblDisplayCustInfo)
        Me.grpQuestion1_1.Controls.Add(Me.btnQuestion1_1)
        Me.grpQuestion1_1.Controls.Add(Me.txtSurname)
        Me.grpQuestion1_1.Controls.Add(Me.txtFirstName)
        Me.grpQuestion1_1.Controls.Add(Me.txtIdNumber)
        Me.grpQuestion1_1.Controls.Add(Me.lblInfoSurname)
        Me.grpQuestion1_1.Controls.Add(Me.lblInfoFirstName)
        Me.grpQuestion1_1.Controls.Add(Me.lblInfoID_Number)
        Me.grpQuestion1_1.Location = New System.Drawing.Point(12, 55)
        Me.grpQuestion1_1.Name = "grpQuestion1_1"
        Me.grpQuestion1_1.Size = New System.Drawing.Size(403, 288)
        Me.grpQuestion1_1.TabIndex = 1
        Me.grpQuestion1_1.TabStop = False
        Me.grpQuestion1_1.Text = "Question 1.1"
        '
        'lblDisplayCustInfo
        '
        Me.lblDisplayCustInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayCustInfo.Location = New System.Drawing.Point(15, 208)
        Me.lblDisplayCustInfo.Name = "lblDisplayCustInfo"
        Me.lblDisplayCustInfo.Size = New System.Drawing.Size(368, 67)
        Me.lblDisplayCustInfo.TabIndex = 7
        '
        'btnQuestion1_1
        '
        Me.btnQuestion1_1.Location = New System.Drawing.Point(206, 161)
        Me.btnQuestion1_1.Name = "btnQuestion1_1"
        Me.btnQuestion1_1.Size = New System.Drawing.Size(160, 38)
        Me.btnQuestion1_1.TabIndex = 6
        Me.btnQuestion1_1.Text = "Question 1.1"
        Me.btnQuestion1_1.UseVisualStyleBackColor = True
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(134, 116)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(234, 36)
        Me.txtSurname.TabIndex = 5
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(134, 71)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(234, 36)
        Me.txtFirstName.TabIndex = 4
        '
        'txtIdNumber
        '
        Me.txtIdNumber.Location = New System.Drawing.Point(134, 24)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(234, 36)
        Me.txtIdNumber.TabIndex = 3
        '
        'lblInfoSurname
        '
        Me.lblInfoSurname.Location = New System.Drawing.Point(6, 119)
        Me.lblInfoSurname.Name = "lblInfoSurname"
        Me.lblInfoSurname.Size = New System.Drawing.Size(131, 23)
        Me.lblInfoSurname.TabIndex = 2
        Me.lblInfoSurname.Text = "Surname:"
        Me.lblInfoSurname.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInfoFirstName
        '
        Me.lblInfoFirstName.Location = New System.Drawing.Point(6, 74)
        Me.lblInfoFirstName.Name = "lblInfoFirstName"
        Me.lblInfoFirstName.Size = New System.Drawing.Size(131, 31)
        Me.lblInfoFirstName.TabIndex = 1
        Me.lblInfoFirstName.Text = "First Name:"
        Me.lblInfoFirstName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInfoID_Number
        '
        Me.lblInfoID_Number.Location = New System.Drawing.Point(6, 27)
        Me.lblInfoID_Number.Name = "lblInfoID_Number"
        Me.lblInfoID_Number.Size = New System.Drawing.Size(131, 25)
        Me.lblInfoID_Number.TabIndex = 0
        Me.lblInfoID_Number.Text = "ID Number:"
        Me.lblInfoID_Number.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grpQuestion1_2
        '
        Me.grpQuestion1_2.Controls.Add(Me.radMultiPartner)
        Me.grpQuestion1_2.Controls.Add(Me.radStandAlone)
        Me.grpQuestion1_2.Controls.Add(Me.lblInfoHeading2)
        Me.grpQuestion1_2.Location = New System.Drawing.Point(12, 349)
        Me.grpQuestion1_2.Name = "grpQuestion1_2"
        Me.grpQuestion1_2.Size = New System.Drawing.Size(403, 195)
        Me.grpQuestion1_2.TabIndex = 2
        Me.grpQuestion1_2.TabStop = False
        Me.grpQuestion1_2.Text = "Question 1.2"
        '
        'radMultiPartner
        '
        Me.radMultiPartner.AutoSize = True
        Me.radMultiPartner.Location = New System.Drawing.Point(30, 153)
        Me.radMultiPartner.Name = "radMultiPartner"
        Me.radMultiPartner.Size = New System.Drawing.Size(336, 32)
        Me.radMultiPartner.TabIndex = 2
        Me.radMultiPartner.TabStop = True
        Me.radMultiPartner.Text = "Multi-partner Programme"
        Me.radMultiPartner.UseVisualStyleBackColor = True
        '
        'radStandAlone
        '
        Me.radStandAlone.AutoSize = True
        Me.radStandAlone.Location = New System.Drawing.Point(30, 103)
        Me.radStandAlone.Name = "radStandAlone"
        Me.radStandAlone.Size = New System.Drawing.Size(310, 32)
        Me.radStandAlone.TabIndex = 1
        Me.radStandAlone.TabStop = True
        Me.radStandAlone.Text = "Stand Alone Programme"
        Me.radStandAlone.UseVisualStyleBackColor = True
        '
        'lblInfoHeading2
        '
        Me.lblInfoHeading2.Location = New System.Drawing.Point(11, 27)
        Me.lblInfoHeading2.Name = "lblInfoHeading2"
        Me.lblInfoHeading2.Size = New System.Drawing.Size(352, 50)
        Me.lblInfoHeading2.TabIndex = 0
        Me.lblInfoHeading2.Text = "Choose the loyalty programme which you prefer:"
        '
        'grpQuestion1_4
        '
        Me.grpQuestion1_4.Controls.Add(Me.lblDisplayMembershipNumber)
        Me.grpQuestion1_4.Controls.Add(Me.btnQuestion1_4)
        Me.grpQuestion1_4.Controls.Add(Me.chkLoyaltyCard)
        Me.grpQuestion1_4.Location = New System.Drawing.Point(439, 349)
        Me.grpQuestion1_4.Name = "grpQuestion1_4"
        Me.grpQuestion1_4.Size = New System.Drawing.Size(403, 195)
        Me.grpQuestion1_4.TabIndex = 3
        Me.grpQuestion1_4.TabStop = False
        Me.grpQuestion1_4.Text = "Question 1.4"
        '
        'lblDisplayMembershipNumber
        '
        Me.lblDisplayMembershipNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayMembershipNumber.Location = New System.Drawing.Point(15, 136)
        Me.lblDisplayMembershipNumber.Name = "lblDisplayMembershipNumber"
        Me.lblDisplayMembershipNumber.Size = New System.Drawing.Size(368, 37)
        Me.lblDisplayMembershipNumber.TabIndex = 8
        '
        'btnQuestion1_4
        '
        Me.btnQuestion1_4.Location = New System.Drawing.Point(223, 73)
        Me.btnQuestion1_4.Name = "btnQuestion1_4"
        Me.btnQuestion1_4.Size = New System.Drawing.Size(160, 38)
        Me.btnQuestion1_4.TabIndex = 7
        Me.btnQuestion1_4.Text = "Question 1.4"
        Me.btnQuestion1_4.UseVisualStyleBackColor = True
        '
        'chkLoyaltyCard
        '
        Me.chkLoyaltyCard.AutoSize = True
        Me.chkLoyaltyCard.Location = New System.Drawing.Point(19, 44)
        Me.chkLoyaltyCard.Name = "chkLoyaltyCard"
        Me.chkLoyaltyCard.Size = New System.Drawing.Size(376, 32)
        Me.chkLoyaltyCard.TabIndex = 0
        Me.chkLoyaltyCard.Text = "Generate membership number"
        Me.chkLoyaltyCard.UseVisualStyleBackColor = True
        '
        'grpQuestion1_3
        '
        Me.grpQuestion1_3.Controls.Add(Me.lblDisplayPoints)
        Me.grpQuestion1_3.Controls.Add(Me.btnQuestion1_3)
        Me.grpQuestion1_3.Controls.Add(Me.txtTotalAmount)
        Me.grpQuestion1_3.Controls.Add(Me.lblInfoRewards)
        Me.grpQuestion1_3.Controls.Add(Me.lblInfoTotalAmount)
        Me.grpQuestion1_3.Location = New System.Drawing.Point(439, 55)
        Me.grpQuestion1_3.Name = "grpQuestion1_3"
        Me.grpQuestion1_3.Size = New System.Drawing.Size(403, 288)
        Me.grpQuestion1_3.TabIndex = 8
        Me.grpQuestion1_3.TabStop = False
        Me.grpQuestion1_3.Text = "Question 1.3"
        '
        'lblDisplayPoints
        '
        Me.lblDisplayPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayPoints.Location = New System.Drawing.Point(15, 208)
        Me.lblDisplayPoints.Name = "lblDisplayPoints"
        Me.lblDisplayPoints.Size = New System.Drawing.Size(368, 67)
        Me.lblDisplayPoints.TabIndex = 7
        '
        'btnQuestion1_3
        '
        Me.btnQuestion1_3.Location = New System.Drawing.Point(223, 104)
        Me.btnQuestion1_3.Name = "btnQuestion1_3"
        Me.btnQuestion1_3.Size = New System.Drawing.Size(160, 38)
        Me.btnQuestion1_3.TabIndex = 6
        Me.btnQuestion1_3.Text = "Question 1.3"
        Me.btnQuestion1_3.UseVisualStyleBackColor = True
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(298, 39)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(85, 36)
        Me.txtTotalAmount.TabIndex = 3
        '
        'lblInfoRewards
        '
        Me.lblInfoRewards.Location = New System.Drawing.Point(15, 185)
        Me.lblInfoRewards.Name = "lblInfoRewards"
        Me.lblInfoRewards.Size = New System.Drawing.Size(305, 23)
        Me.lblInfoRewards.TabIndex = 2
        Me.lblInfoRewards.Text = "Reward Points Accumulated"
        '
        'lblInfoTotalAmount
        '
        Me.lblInfoTotalAmount.Location = New System.Drawing.Point(6, 27)
        Me.lblInfoTotalAmount.Name = "lblInfoTotalAmount"
        Me.lblInfoTotalAmount.Size = New System.Drawing.Size(286, 78)
        Me.lblInfoTotalAmount.TabIndex = 0
        Me.lblInfoTotalAmount.Text = "Enter your total purchase amount for today:"
        Me.lblInfoTotalAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmQuestion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1025, 625)
        Me.Controls.Add(Me.grpQuestion1_3)
        Me.Controls.Add(Me.grpQuestion1_4)
        Me.Controls.Add(Me.grpQuestion1_2)
        Me.Controls.Add(Me.grpQuestion1_1)
        Me.Controls.Add(Me.lblInfoHeading1)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQuestion1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Question 1"
        Me.grpQuestion1_1.ResumeLayout(False)
        Me.grpQuestion1_1.PerformLayout()
        Me.grpQuestion1_2.ResumeLayout(False)
        Me.grpQuestion1_2.PerformLayout()
        Me.grpQuestion1_4.ResumeLayout(False)
        Me.grpQuestion1_4.PerformLayout()
        Me.grpQuestion1_3.ResumeLayout(False)
        Me.grpQuestion1_3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoHeading1 As Label
    Friend WithEvents grpQuestion1_1 As GroupBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtIdNumber As TextBox
    Friend WithEvents lblInfoSurname As Label
    Friend WithEvents lblInfoFirstName As Label
    Friend WithEvents lblInfoID_Number As Label
    Friend WithEvents btnQuestion1_1 As Button
    Friend WithEvents lblDisplayCustInfo As Label
    Friend WithEvents grpQuestion1_2 As GroupBox
    Friend WithEvents lblInfoHeading2 As Label
    Friend WithEvents radMultiPartner As RadioButton
    Friend WithEvents radStandAlone As RadioButton
    Friend WithEvents grpQuestion1_4 As GroupBox
    Friend WithEvents grpQuestion1_3 As GroupBox
    Friend WithEvents lblDisplayPoints As Label
    Friend WithEvents btnQuestion1_3 As Button
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents lblInfoRewards As Label
    Friend WithEvents lblInfoTotalAmount As Label
    Friend WithEvents chkLoyaltyCard As CheckBox
    Friend WithEvents lblDisplayMembershipNumber As Label
    Friend WithEvents btnQuestion1_4 As Button
End Class
