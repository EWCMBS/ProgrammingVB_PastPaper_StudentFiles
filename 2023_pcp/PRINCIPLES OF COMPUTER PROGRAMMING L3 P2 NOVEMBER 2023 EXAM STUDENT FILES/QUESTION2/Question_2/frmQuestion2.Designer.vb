<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion2
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
        Me.grpInstallments_Q1_2 = New System.Windows.Forms.GroupBox
        Me.btnClearInstallments = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbPaymentPeriod = New System.Windows.Forms.ComboBox
        Me.lstInstallments = New System.Windows.Forms.ListBox
        Me.btnCalcPaymentPlan = New System.Windows.Forms.Button
        Me.txtAccBalance = New System.Windows.Forms.TextBox
        Me.lblInfoPaymentPlan = New System.Windows.Forms.Label
        Me.lblInfoTotalAmount = New System.Windows.Forms.Label
        Me.grpQuestion1_1 = New System.Windows.Forms.GroupBox
        Me.lblQuestion1_1 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpInstallments_Q1_2.SuspendLayout()
        Me.grpQuestion1_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInstallments_Q1_2
        '
        Me.grpInstallments_Q1_2.Controls.Add(Me.btnClearInstallments)
        Me.grpInstallments_Q1_2.Controls.Add(Me.Label2)
        Me.grpInstallments_Q1_2.Controls.Add(Me.cmbPaymentPeriod)
        Me.grpInstallments_Q1_2.Controls.Add(Me.lstInstallments)
        Me.grpInstallments_Q1_2.Controls.Add(Me.btnCalcPaymentPlan)
        Me.grpInstallments_Q1_2.Controls.Add(Me.txtAccBalance)
        Me.grpInstallments_Q1_2.Controls.Add(Me.lblInfoPaymentPlan)
        Me.grpInstallments_Q1_2.Controls.Add(Me.lblInfoTotalAmount)
        Me.grpInstallments_Q1_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInstallments_Q1_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grpInstallments_Q1_2.Location = New System.Drawing.Point(33, 134)
        Me.grpInstallments_Q1_2.Name = "grpInstallments_Q1_2"
        Me.grpInstallments_Q1_2.Size = New System.Drawing.Size(602, 315)
        Me.grpInstallments_Q1_2.TabIndex = 8
        Me.grpInstallments_Q1_2.TabStop = False
        Me.grpInstallments_Q1_2.Text = "Instalment Calculator"
        '
        'btnClearInstallments
        '
        Me.btnClearInstallments.BackColor = System.Drawing.Color.Gray
        Me.btnClearInstallments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearInstallments.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearInstallments.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClearInstallments.Location = New System.Drawing.Point(382, 68)
        Me.btnClearInstallments.Name = "btnClearInstallments"
        Me.btnClearInstallments.Size = New System.Drawing.Size(196, 37)
        Me.btnClearInstallments.TabIndex = 10
        Me.btnClearInstallments.Text = "Clear All"
        Me.btnClearInstallments.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(21, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Please select a payment period (in months)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPaymentPeriod
        '
        Me.cmbPaymentPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaymentPeriod.FormattingEnabled = True
        Me.cmbPaymentPeriod.Items.AddRange(New Object() {"3", "6", "9"})
        Me.cmbPaymentPeriod.Location = New System.Drawing.Point(291, 75)
        Me.cmbPaymentPeriod.Name = "cmbPaymentPeriod"
        Me.cmbPaymentPeriod.Size = New System.Drawing.Size(85, 24)
        Me.cmbPaymentPeriod.TabIndex = 8
        '
        'lstInstallments
        '
        Me.lstInstallments.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lstInstallments.FormattingEnabled = True
        Me.lstInstallments.ItemHeight = 14
        Me.lstInstallments.Location = New System.Drawing.Point(18, 142)
        Me.lstInstallments.Name = "lstInstallments"
        Me.lstInstallments.Size = New System.Drawing.Size(561, 158)
        Me.lstInstallments.TabIndex = 7
        '
        'btnCalcPaymentPlan
        '
        Me.btnCalcPaymentPlan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCalcPaymentPlan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcPaymentPlan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcPaymentPlan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalcPaymentPlan.Location = New System.Drawing.Point(383, 26)
        Me.btnCalcPaymentPlan.Name = "btnCalcPaymentPlan"
        Me.btnCalcPaymentPlan.Size = New System.Drawing.Size(196, 37)
        Me.btnCalcPaymentPlan.TabIndex = 6
        Me.btnCalcPaymentPlan.Text = "Calculate Instalments"
        Me.btnCalcPaymentPlan.UseVisualStyleBackColor = False
        '
        'txtAccBalance
        '
        Me.txtAccBalance.Location = New System.Drawing.Point(291, 40)
        Me.txtAccBalance.Name = "txtAccBalance"
        Me.txtAccBalance.Size = New System.Drawing.Size(85, 22)
        Me.txtAccBalance.TabIndex = 3
        '
        'lblInfoPaymentPlan
        '
        Me.lblInfoPaymentPlan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoPaymentPlan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInfoPaymentPlan.Location = New System.Drawing.Point(15, 119)
        Me.lblInfoPaymentPlan.Name = "lblInfoPaymentPlan"
        Me.lblInfoPaymentPlan.Size = New System.Drawing.Size(305, 22)
        Me.lblInfoPaymentPlan.TabIndex = 2
        Me.lblInfoPaymentPlan.Text = "Payment Plan Instalments"
        '
        'lblInfoTotalAmount
        '
        Me.lblInfoTotalAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoTotalAmount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInfoTotalAmount.Location = New System.Drawing.Point(66, 39)
        Me.lblInfoTotalAmount.Name = "lblInfoTotalAmount"
        Me.lblInfoTotalAmount.Size = New System.Drawing.Size(223, 24)
        Me.lblInfoTotalAmount.TabIndex = 0
        Me.lblInfoTotalAmount.Text = "Enter your current account balance"
        Me.lblInfoTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpQuestion1_1
        '
        Me.grpQuestion1_1.BackColor = System.Drawing.Color.White
        Me.grpQuestion1_1.Controls.Add(Me.lblQuestion1_1)
        Me.grpQuestion1_1.Location = New System.Drawing.Point(33, 11)
        Me.grpQuestion1_1.Name = "grpQuestion1_1"
        Me.grpQuestion1_1.Size = New System.Drawing.Size(602, 77)
        Me.grpQuestion1_1.TabIndex = 9
        Me.grpQuestion1_1.TabStop = False
        '
        'lblQuestion1_1
        '
        Me.lblQuestion1_1.AutoSize = True
        Me.lblQuestion1_1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion1_1.Location = New System.Drawing.Point(77, 31)
        Me.lblQuestion1_1.Name = "lblQuestion1_1"
        Me.lblQuestion1_1.Size = New System.Drawing.Size(445, 27)
        Me.lblQuestion1_1.TabIndex = 1
        Me.lblQuestion1_1.Text = "MZANSI TVET HIGHER HEALTH CLINIC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(177, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "** INSTALMENT PLAN CALCULATOR  **"
        '
        'frmQuestion2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(675, 481)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpQuestion1_1)
        Me.Controls.Add(Me.grpInstallments_Q1_2)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQuestion2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUESTION 2"
        Me.grpInstallments_Q1_2.ResumeLayout(False)
        Me.grpInstallments_Q1_2.PerformLayout()
        Me.grpQuestion1_1.ResumeLayout(False)
        Me.grpQuestion1_1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpQuestion1_2333 As GroupBox
    Friend WithEvents grpInstallments_Q1_2 As GroupBox
    Friend WithEvents btnCalcPaymentPlan As Button
    Friend WithEvents txtAccBalance As TextBox
    Friend WithEvents lblInfoPaymentPlan As Label
    Friend WithEvents lblInfoTotalAmount As Label
    Friend WithEvents chkLoyaltyCard As CheckBox
    Friend WithEvents grpQuestion1_1 As GroupBox
    Friend WithEvents lblQuestion1_1 As Label
    Friend WithEvents lstInstallments As ListBox
    Friend WithEvents cmbPaymentPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClearInstallments As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
