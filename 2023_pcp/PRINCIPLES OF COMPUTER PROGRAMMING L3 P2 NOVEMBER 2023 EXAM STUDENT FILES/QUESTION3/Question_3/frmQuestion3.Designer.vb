<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion3
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
        Me.grpInput = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClearList = New System.Windows.Forms.Button
        Me.btnAdd_KL = New System.Windows.Forms.Button
        Me.txtDayKL = New System.Windows.Forms.TextBox
        Me.lblInfoPricePerKL = New System.Windows.Forms.Label
        Me.grpAnalysis = New System.Windows.Forms.GroupBox
        Me.lstAnalysis = New System.Windows.Forms.ListBox
        Me.btnComputeValues = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.grpInput.SuspendLayout()
        Me.grpAnalysis.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.Label1)
        Me.grpInput.Controls.Add(Me.btnClearList)
        Me.grpInput.Controls.Add(Me.btnAdd_KL)
        Me.grpInput.Controls.Add(Me.txtDayKL)
        Me.grpInput.Controls.Add(Me.lblInfoPricePerKL)
        Me.grpInput.Location = New System.Drawing.Point(9, 10)
        Me.grpInput.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpInput.Size = New System.Drawing.Size(442, 132)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Data Input"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(42, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "[ NOTE: 1 = Monday .... 5 = Friday ]"
        '
        'btnClearList
        '
        Me.btnClearList.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnClearList.Location = New System.Drawing.Point(286, 94)
        Me.btnClearList.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(152, 32)
        Me.btnClearList.TabIndex = 5
        Me.btnClearList.Text = "Clear List"
        Me.btnClearList.UseVisualStyleBackColor = False
        '
        'btnAdd_KL
        '
        Me.btnAdd_KL.BackColor = System.Drawing.Color.MistyRose
        Me.btnAdd_KL.Location = New System.Drawing.Point(12, 94)
        Me.btnAdd_KL.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAdd_KL.Name = "btnAdd_KL"
        Me.btnAdd_KL.Size = New System.Drawing.Size(272, 32)
        Me.btnAdd_KL.TabIndex = 4
        Me.btnAdd_KL.Text = "Add Kilo-Liters"
        Me.btnAdd_KL.UseVisualStyleBackColor = False
        '
        'txtDayKL
        '
        Me.txtDayKL.Location = New System.Drawing.Point(286, 29)
        Me.txtDayKL.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDayKL.Name = "txtDayKL"
        Me.txtDayKL.Size = New System.Drawing.Size(54, 22)
        Me.txtDayKL.TabIndex = 2
        '
        'lblInfoPricePerKL
        '
        Me.lblInfoPricePerKL.AutoSize = True
        Me.lblInfoPricePerKL.Location = New System.Drawing.Point(42, 31)
        Me.lblInfoPricePerKL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfoPricePerKL.Name = "lblInfoPricePerKL"
        Me.lblInfoPricePerKL.Size = New System.Drawing.Size(240, 16)
        Me.lblInfoPricePerKL.TabIndex = 0
        Me.lblInfoPricePerKL.Text = "Enter Kilo Litres used for the day (1 - 5) "
        '
        'grpAnalysis
        '
        Me.grpAnalysis.Controls.Add(Me.lstAnalysis)
        Me.grpAnalysis.Location = New System.Drawing.Point(11, 147)
        Me.grpAnalysis.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpAnalysis.Name = "grpAnalysis"
        Me.grpAnalysis.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpAnalysis.Size = New System.Drawing.Size(440, 236)
        Me.grpAnalysis.TabIndex = 1
        Me.grpAnalysis.TabStop = False
        Me.grpAnalysis.Text = "Analysis:"
        '
        'lstAnalysis
        '
        Me.lstAnalysis.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.lstAnalysis.FormattingEnabled = True
        Me.lstAnalysis.ItemHeight = 14
        Me.lstAnalysis.Location = New System.Drawing.Point(7, 24)
        Me.lstAnalysis.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lstAnalysis.Name = "lstAnalysis"
        Me.lstAnalysis.Size = New System.Drawing.Size(433, 200)
        Me.lstAnalysis.TabIndex = 0
        '
        'btnComputeValues
        '
        Me.btnComputeValues.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnComputeValues.Location = New System.Drawing.Point(12, 396)
        Me.btnComputeValues.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnComputeValues.Name = "btnComputeValues"
        Me.btnComputeValues.Size = New System.Drawing.Size(281, 38)
        Me.btnComputeValues.TabIndex = 2
        Me.btnComputeValues.Text = "Analyse Water Consumption"
        Me.btnComputeValues.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.MistyRose
        Me.btnClose.Location = New System.Drawing.Point(297, 396)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 38)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close Program"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmQuestion3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(478, 466)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnComputeValues)
        Me.Controls.Add(Me.grpAnalysis)
        Me.Controls.Add(Me.grpInput)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQuestion3"
        Me.ShowInTaskbar = False
        Me.Text = "QUESTION 3"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpAnalysis.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents lblInfoPricePerKL As Label
    Friend WithEvents btnAdd_KL As Button
    Friend WithEvents txtDayKL As TextBox
    Friend WithEvents grpAnalysis As GroupBox
    Friend WithEvents lstAnalysis As ListBox
    Friend WithEvents btnComputeValues As Button
    Friend WithEvents btnClearList As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
