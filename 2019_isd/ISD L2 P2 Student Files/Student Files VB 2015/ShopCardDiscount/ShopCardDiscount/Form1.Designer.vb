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
        Me.radPlatinum = New System.Windows.Forms.RadioButton
        Me.radSilver = New System.Windows.Forms.RadioButton
        Me.radBronze = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSpent = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkPrime = New System.Windows.Forms.CheckBox
        Me.chkGreen = New System.Windows.Forms.CheckBox
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.lblDisplay = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radPlatinum)
        Me.GroupBox1.Controls.Add(Me.radSilver)
        Me.GroupBox1.Controls.Add(Me.radBronze)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 146)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Card Type"
        '
        'radPlatinum
        '
        Me.radPlatinum.AutoSize = True
        Me.radPlatinum.Location = New System.Drawing.Point(20, 99)
        Me.radPlatinum.Name = "radPlatinum"
        Me.radPlatinum.Size = New System.Drawing.Size(109, 20)
        Me.radPlatinum.TabIndex = 2
        Me.radPlatinum.TabStop = True
        Me.radPlatinum.Text = "Platinum Card"
        Me.radPlatinum.UseVisualStyleBackColor = True
        '
        'radSilver
        '
        Me.radSilver.AutoSize = True
        Me.radSilver.Location = New System.Drawing.Point(20, 63)
        Me.radSilver.Name = "radSilver"
        Me.radSilver.Size = New System.Drawing.Size(92, 20)
        Me.radSilver.TabIndex = 1
        Me.radSilver.TabStop = True
        Me.radSilver.Text = "Silver Card"
        Me.radSilver.UseVisualStyleBackColor = True
        '
        'radBronze
        '
        Me.radBronze.AutoSize = True
        Me.radBronze.Location = New System.Drawing.Point(20, 27)
        Me.radBronze.Name = "radBronze"
        Me.radBronze.Size = New System.Drawing.Size(100, 20)
        Me.radBronze.TabIndex = 0
        Me.radBronze.TabStop = True
        Me.radBronze.Text = "Bronze Card"
        Me.radBronze.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(243, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Spent"
        '
        'txtSpent
        '
        Me.txtSpent.Location = New System.Drawing.Point(346, 46)
        Me.txtSpent.Name = "txtSpent"
        Me.txtSpent.Size = New System.Drawing.Size(100, 22)
        Me.txtSpent.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPrime)
        Me.GroupBox2.Controls.Add(Me.chkGreen)
        Me.GroupBox2.Location = New System.Drawing.Point(246, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 96)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Extra Benefits"
        '
        'chkPrime
        '
        Me.chkPrime.AutoSize = True
        Me.chkPrime.Location = New System.Drawing.Point(22, 56)
        Me.chkPrime.Name = "chkPrime"
        Me.chkPrime.Size = New System.Drawing.Size(115, 20)
        Me.chkPrime.TabIndex = 1
        Me.chkPrime.Text = "Prime Member"
        Me.chkPrime.UseVisualStyleBackColor = True
        '
        'chkGreen
        '
        Me.chkGreen.AutoSize = True
        Me.chkGreen.Location = New System.Drawing.Point(22, 30)
        Me.chkGreen.Name = "chkGreen"
        Me.chkGreen.Size = New System.Drawing.Size(163, 20)
        Me.chkGreen.TabIndex = 0
        Me.chkGreen.Text = "Green Loyalty Member"
        Me.chkGreen.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(22, 199)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(424, 40)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Total Discount"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplay.Location = New System.Drawing.Point(22, 253)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(424, 51)
        Me.lblDisplay.TabIndex = 5
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(22, 322)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 31)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(371, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(466, 370)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtSpent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Shop Card Discount"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSpent As System.Windows.Forms.TextBox
    Friend WithEvents radPlatinum As System.Windows.Forms.RadioButton
    Friend WithEvents radSilver As System.Windows.Forms.RadioButton
    Friend WithEvents radBronze As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPrime As System.Windows.Forms.CheckBox
    Friend WithEvents chkGreen As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
