<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion4
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
        Me.btnExit = New System.Windows.Forms.Button
        Me.grpQuestion3 = New System.Windows.Forms.GroupBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblFileStatus = New System.Windows.Forms.Label
        Me.txtTelephone = New System.Windows.Forms.TextBox
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtMobileNo = New System.Windows.Forms.TextBox
        Me.txtRecID = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSubmitRecord = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.grpQuestion3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(314, 420)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 31)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpQuestion3
        '
        Me.grpQuestion3.Controls.Add(Me.txtEmail)
        Me.grpQuestion3.Controls.Add(Me.Label8)
        Me.grpQuestion3.Controls.Add(Me.GroupBox1)
        Me.grpQuestion3.Controls.Add(Me.txtTelephone)
        Me.grpQuestion3.Controls.Add(Me.txtSurname)
        Me.grpQuestion3.Controls.Add(Me.txtFirstName)
        Me.grpQuestion3.Controls.Add(Me.txtMobileNo)
        Me.grpQuestion3.Controls.Add(Me.txtRecID)
        Me.grpQuestion3.Controls.Add(Me.Label5)
        Me.grpQuestion3.Controls.Add(Me.Label4)
        Me.grpQuestion3.Controls.Add(Me.Label3)
        Me.grpQuestion3.Controls.Add(Me.Label2)
        Me.grpQuestion3.Controls.Add(Me.Label1)
        Me.grpQuestion3.Location = New System.Drawing.Point(26, 107)
        Me.grpQuestion3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpQuestion3.Name = "grpQuestion3"
        Me.grpQuestion3.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpQuestion3.Size = New System.Drawing.Size(405, 298)
        Me.grpQuestion3.TabIndex = 4
        Me.grpQuestion3.TabStop = False
        Me.grpQuestion3.Text = "Student Info"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(143, 252)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(205, 22)
        Me.txtEmail.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 253)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Email Address:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFileStatus)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(18, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 52)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Status"
        '
        'lblFileStatus
        '
        Me.lblFileStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFileStatus.Location = New System.Drawing.Point(10, 19)
        Me.lblFileStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFileStatus.Name = "lblFileStatus"
        Me.lblFileStatus.Size = New System.Drawing.Size(348, 20)
        Me.lblFileStatus.TabIndex = 11
        Me.lblFileStatus.Text = "Status Not Available"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(143, 189)
        Me.txtTelephone.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(142, 22)
        Me.txtTelephone.TabIndex = 9
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(143, 155)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(205, 22)
        Me.txtSurname.TabIndex = 8
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(143, 120)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(205, 22)
        Me.txtFirstName.TabIndex = 7
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(143, 220)
        Me.txtMobileNo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(142, 22)
        Me.txtMobileNo.TabIndex = 6
        '
        'txtRecID
        '
        Me.txtRecID.Location = New System.Drawing.Point(143, 88)
        Me.txtRecID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtRecID.Name = "txtRecID"
        Me.txtRecID.Size = New System.Drawing.Size(60, 22)
        Me.txtRecID.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 190)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Landline Telephone:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 156)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Surname:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Firstname:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 221)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mobile No:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Group ID:"
        '
        'btnSubmitRecord
        '
        Me.btnSubmitRecord.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitRecord.Location = New System.Drawing.Point(26, 420)
        Me.btnSubmitRecord.Name = "btnSubmitRecord"
        Me.btnSubmitRecord.Size = New System.Drawing.Size(283, 31)
        Me.btnSubmitRecord.TabIndex = 5
        Me.btnSubmitRecord.Text = "Submit Student Record"
        Me.btnSubmitRecord.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(383, 36)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "MZANSI TVET COLLEGE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(23, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(280, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "MATH STUDENTS CONTACT DETAILS"
        '
        'frmQuestion4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(463, 479)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSubmitRecord)
        Me.Controls.Add(Me.grpQuestion3)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQuestion4"
        Me.Text = "QUESTION 4"
        Me.grpQuestion3.ResumeLayout(False)
        Me.grpQuestion3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents grpQuestion3 As GroupBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents txtRecID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFileStatus As Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSubmitRecord As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
