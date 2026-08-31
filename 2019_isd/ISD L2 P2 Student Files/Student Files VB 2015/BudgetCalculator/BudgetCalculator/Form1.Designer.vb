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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grpIncome = New System.Windows.Forms.GroupBox
        Me.btnCalcIncome = New System.Windows.Forms.Button
        Me.txtOtherIncome = New System.Windows.Forms.TextBox
        Me.txtSalary = New System.Windows.Forms.TextBox
        Me.lblTotalIncome = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpExpenses = New System.Windows.Forms.GroupBox
        Me.lblTotalExpenses = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnCalcExpenses = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtEntertainment = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtWaterElec = New System.Windows.Forms.TextBox
        Me.txtGroceries = New System.Windows.Forms.TextBox
        Me.txtRent = New System.Windows.Forms.TextBox
        Me.btnCalcNetIncome = New System.Windows.Forms.Button
        Me.lblDisplay = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.grpIncome.SuspendLayout()
        Me.grpExpenses.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpIncome
        '
        Me.grpIncome.Controls.Add(Me.btnCalcIncome)
        Me.grpIncome.Controls.Add(Me.txtOtherIncome)
        Me.grpIncome.Controls.Add(Me.txtSalary)
        Me.grpIncome.Controls.Add(Me.lblTotalIncome)
        Me.grpIncome.Controls.Add(Me.Label4)
        Me.grpIncome.Controls.Add(Me.Label3)
        Me.grpIncome.Controls.Add(Me.Label2)
        Me.grpIncome.Location = New System.Drawing.Point(12, 82)
        Me.grpIncome.Name = "grpIncome"
        Me.grpIncome.Size = New System.Drawing.Size(256, 223)
        Me.grpIncome.TabIndex = 0
        Me.grpIncome.TabStop = False
        Me.grpIncome.Text = "Income"
        '
        'btnCalcIncome
        '
        Me.btnCalcIncome.Location = New System.Drawing.Point(21, 121)
        Me.btnCalcIncome.Name = "btnCalcIncome"
        Me.btnCalcIncome.Size = New System.Drawing.Size(217, 35)
        Me.btnCalcIncome.TabIndex = 6
        Me.btnCalcIncome.Text = "Calculate Total Income"
        Me.btnCalcIncome.UseVisualStyleBackColor = True
        '
        'txtOtherIncome
        '
        Me.txtOtherIncome.Location = New System.Drawing.Point(136, 69)
        Me.txtOtherIncome.Name = "txtOtherIncome"
        Me.txtOtherIncome.Size = New System.Drawing.Size(102, 22)
        Me.txtOtherIncome.TabIndex = 5
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(136, 31)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(102, 22)
        Me.txtSalary.TabIndex = 4
        '
        'lblTotalIncome
        '
        Me.lblTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalIncome.Location = New System.Drawing.Point(154, 184)
        Me.lblTotalIncome.Name = "lblTotalIncome"
        Me.lblTotalIncome.Size = New System.Drawing.Size(84, 24)
        Me.lblTotalIncome.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total Monthly Income:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Other Income:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Salary:"
        '
        'grpExpenses
        '
        Me.grpExpenses.Controls.Add(Me.lblTotalExpenses)
        Me.grpExpenses.Controls.Add(Me.Label10)
        Me.grpExpenses.Controls.Add(Me.btnCalcExpenses)
        Me.grpExpenses.Controls.Add(Me.Label8)
        Me.grpExpenses.Controls.Add(Me.txtEntertainment)
        Me.grpExpenses.Controls.Add(Me.Label7)
        Me.grpExpenses.Controls.Add(Me.Label6)
        Me.grpExpenses.Controls.Add(Me.Label5)
        Me.grpExpenses.Controls.Add(Me.txtWaterElec)
        Me.grpExpenses.Controls.Add(Me.txtGroceries)
        Me.grpExpenses.Controls.Add(Me.txtRent)
        Me.grpExpenses.Enabled = False
        Me.grpExpenses.Location = New System.Drawing.Point(299, 82)
        Me.grpExpenses.Name = "grpExpenses"
        Me.grpExpenses.Size = New System.Drawing.Size(257, 223)
        Me.grpExpenses.TabIndex = 1
        Me.grpExpenses.TabStop = False
        Me.grpExpenses.Text = "Expenses"
        '
        'lblTotalExpenses
        '
        Me.lblTotalExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalExpenses.Location = New System.Drawing.Point(155, 184)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Size = New System.Drawing.Size(84, 24)
        Me.lblTotalExpenses.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 16)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Total Monthly Expenses:"
        '
        'btnCalcExpenses
        '
        Me.btnCalcExpenses.Location = New System.Drawing.Point(9, 153)
        Me.btnCalcExpenses.Name = "btnCalcExpenses"
        Me.btnCalcExpenses.Size = New System.Drawing.Size(230, 23)
        Me.btnCalcExpenses.TabIndex = 7
        Me.btnCalcExpenses.Text = "Calculate Total Expenses"
        Me.btnCalcExpenses.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Entertainment:"
        '
        'txtEntertainment
        '
        Me.txtEntertainment.Location = New System.Drawing.Point(128, 125)
        Me.txtEntertainment.Name = "txtEntertainment"
        Me.txtEntertainment.Size = New System.Drawing.Size(111, 22)
        Me.txtEntertainment.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Water && Electricity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Groceries:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Rent:"
        '
        'txtWaterElec
        '
        Me.txtWaterElec.Location = New System.Drawing.Point(128, 90)
        Me.txtWaterElec.Name = "txtWaterElec"
        Me.txtWaterElec.Size = New System.Drawing.Size(111, 22)
        Me.txtWaterElec.TabIndex = 6
        '
        'txtGroceries
        '
        Me.txtGroceries.Location = New System.Drawing.Point(128, 56)
        Me.txtGroceries.Name = "txtGroceries"
        Me.txtGroceries.Size = New System.Drawing.Size(111, 22)
        Me.txtGroceries.TabIndex = 7
        '
        'txtRent
        '
        Me.txtRent.Location = New System.Drawing.Point(128, 18)
        Me.txtRent.Name = "txtRent"
        Me.txtRent.Size = New System.Drawing.Size(111, 22)
        Me.txtRent.TabIndex = 8
        '
        'btnCalcNetIncome
        '
        Me.btnCalcNetIncome.Location = New System.Drawing.Point(12, 320)
        Me.btnCalcNetIncome.Name = "btnCalcNetIncome"
        Me.btnCalcNetIncome.Size = New System.Drawing.Size(544, 44)
        Me.btnCalcNetIncome.TabIndex = 2
        Me.btnCalcNetIncome.Text = "Calculate Net Income/Loss"
        Me.btnCalcNetIncome.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplay.Location = New System.Drawing.Point(12, 381)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(544, 65)
        Me.lblDisplay.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 458)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 42)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(467, 458)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 42)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(161, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(230, 29)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Budget Calculator"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(483, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(573, 512)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnCalcNetIncome)
        Me.Controls.Add(Me.grpExpenses)
        Me.Controls.Add(Me.grpIncome)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Budget Calculator"
        Me.grpIncome.ResumeLayout(False)
        Me.grpIncome.PerformLayout()
        Me.grpExpenses.ResumeLayout(False)
        Me.grpExpenses.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpIncome As System.Windows.Forms.GroupBox
    Friend WithEvents grpExpenses As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalcIncome As System.Windows.Forms.Button
    Friend WithEvents txtOtherIncome As System.Windows.Forms.TextBox
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalIncome As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWaterElec As System.Windows.Forms.TextBox
    Friend WithEvents txtGroceries As System.Windows.Forms.TextBox
    Friend WithEvents txtRent As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcNetIncome As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalcExpenses As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEntertainment As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalExpenses As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
