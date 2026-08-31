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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.txtDonationAmount = New System.Windows.Forms.TextBox
        Me.cmbCurrency = New System.Windows.Forms.ComboBox
        Me.txtNames = New System.Windows.Forms.TextBox
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.txtContactNo = New System.Windows.Forms.TextBox
        Me.rctAddress = New System.Windows.Forms.RichTextBox
        Me.label13 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblAmountConverted = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblCurrencySelected = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblSummary = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblCurrencyRate = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.chkConfirm = New System.Windows.Forms.CheckBox
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Names"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Surname"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.txtDonationAmount)
        Me.GroupBox1.Controls.Add(Me.cmbCurrency)
        Me.GroupBox1.Controls.Add(Me.txtNames)
        Me.GroupBox1.Controls.Add(Me.txtSurname)
        Me.GroupBox1.Controls.Add(Me.txtContactNo)
        Me.GroupBox1.Controls.Add(Me.rctAddress)
        Me.GroupBox1.Controls.Add(Me.label13)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 331)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Donor info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Select your currency"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(139, 208)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 14
        '
        'txtDonationAmount
        '
        Me.txtDonationAmount.Location = New System.Drawing.Point(139, 242)
        Me.txtDonationAmount.Name = "txtDonationAmount"
        Me.txtDonationAmount.Size = New System.Drawing.Size(200, 20)
        Me.txtDonationAmount.TabIndex = 13
        '
        'cmbCurrency
        '
        Me.cmbCurrency.FormattingEnabled = True
        Me.cmbCurrency.Items.AddRange(New Object() {"BRL - ZAR", "RUB - ZAR", "INR - ZAR", "RMB - ZAR"})
        Me.cmbCurrency.Location = New System.Drawing.Point(139, 275)
        Me.cmbCurrency.Name = "cmbCurrency"
        Me.cmbCurrency.Size = New System.Drawing.Size(202, 21)
        Me.cmbCurrency.TabIndex = 12
        '
        'txtNames
        '
        Me.txtNames.Location = New System.Drawing.Point(139, 43)
        Me.txtNames.Name = "txtNames"
        Me.txtNames.Size = New System.Drawing.Size(200, 20)
        Me.txtNames.TabIndex = 11
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(139, 75)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(200, 20)
        Me.txtSurname.TabIndex = 10
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(139, 111)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(200, 20)
        Me.txtContactNo.TabIndex = 9
        '
        'rctAddress
        '
        Me.rctAddress.Location = New System.Drawing.Point(139, 149)
        Me.rctAddress.Name = "rctAddress"
        Me.rctAddress.Size = New System.Drawing.Size(200, 50)
        Me.rctAddress.TabIndex = 8
        Me.rctAddress.Text = ""
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(16, 245)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(88, 13)
        Me.label13.TabIndex = 5
        Me.label13.Text = "Donation amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact no"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(22, 309)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(282, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "I (we) wish to have our contribution remain anonymous"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Amount converted to rands"
        '
        'lblAmountConverted
        '
        Me.lblAmountConverted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmountConverted.Location = New System.Drawing.Point(159, 116)
        Me.lblAmountConverted.Name = "lblAmountConverted"
        Me.lblAmountConverted.Size = New System.Drawing.Size(206, 23)
        Me.lblAmountConverted.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCurrencySelected)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblSummary)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblCurrencyRate)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.lblAmountConverted)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.chkConfirm)
        Me.GroupBox2.Location = New System.Drawing.Point(395, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 331)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Summary"
        '
        'lblCurrencySelected
        '
        Me.lblCurrencySelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrencySelected.Location = New System.Drawing.Point(157, 43)
        Me.lblCurrencySelected.Name = "lblCurrencySelected"
        Me.lblCurrencySelected.Size = New System.Drawing.Size(206, 23)
        Me.lblCurrencySelected.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Currency selected"
        '
        'lblSummary
        '
        Me.lblSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSummary.Location = New System.Drawing.Point(159, 153)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(209, 105)
        Me.lblSummary.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Pledge info summary"
        '
        'lblCurrencyRate
        '
        Me.lblCurrencyRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrencyRate.Location = New System.Drawing.Point(160, 82)
        Me.lblCurrencyRate.Name = "lblCurrencyRate"
        Me.lblCurrencyRate.Size = New System.Drawing.Size(206, 23)
        Me.lblCurrencyRate.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Currency rate"
        '
        'chkConfirm
        '
        Me.chkConfirm.AutoSize = True
        Me.chkConfirm.Location = New System.Drawing.Point(22, 275)
        Me.chkConfirm.Name = "chkConfirm"
        Me.chkConfirm.Size = New System.Drawing.Size(301, 17)
        Me.chkConfirm.TabIndex = 21
        Me.chkConfirm.Text = "I agree and confirm that the information  above is accurate"
        Me.chkConfirm.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(12, 438)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 38)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(304, 438)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 38)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(644, 438)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 38)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(201, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(360, 42)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "KZN Floods Pledge"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 501)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Examination number"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label13 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDonationAmount As System.Windows.Forms.TextBox
    Friend WithEvents cmbCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents txtNames As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents rctAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents lblAmountConverted As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkConfirm As System.Windows.Forms.CheckBox
    Friend WithEvents lblSummary As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblCurrencyRate As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblCurrencySelected As System.Windows.Forms.Label

End Class
