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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSizeGroup = New System.Windows.Forms.TextBox
        Me.txtNofDay = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblDisplayTotalCost = New System.Windows.Forms.Label
        Me.lblDisplayLevy = New System.Windows.Forms.Label
        Me.lblDisplayTransCost = New System.Windows.Forms.Label
        Me.lblDisplayAccommodationCost = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dream Vacation"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSizeGroup)
        Me.GroupBox1.Controls.Add(Me.txtNofDay)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 91)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Provide Vacation Information:"
        '
        'txtSizeGroup
        '
        Me.txtSizeGroup.Location = New System.Drawing.Point(108, 60)
        Me.txtSizeGroup.Name = "txtSizeGroup"
        Me.txtSizeGroup.Size = New System.Drawing.Size(51, 20)
        Me.txtSizeGroup.TabIndex = 1
        '
        'txtNofDay
        '
        Me.txtNofDay.Location = New System.Drawing.Point(108, 23)
        Me.txtNofDay.Name = "txtNofDay"
        Me.txtNofDay.Size = New System.Drawing.Size(51, 20)
        Me.txtNofDay.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Size of Group:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(17, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Number of Days:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(22, 183)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(158, 53)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDisplayTotalCost)
        Me.GroupBox2.Controls.Add(Me.lblDisplayLevy)
        Me.GroupBox2.Controls.Add(Me.lblDisplayTransCost)
        Me.GroupBox2.Controls.Add(Me.lblDisplayAccommodationCost)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 264)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 186)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vacation Costs:"
        '
        'lblDisplayTotalCost
        '
        Me.lblDisplayTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayTotalCost.Location = New System.Drawing.Point(162, 126)
        Me.lblDisplayTotalCost.Name = "lblDisplayTotalCost"
        Me.lblDisplayTotalCost.Size = New System.Drawing.Size(84, 24)
        Me.lblDisplayTotalCost.TabIndex = 1
        '
        'lblDisplayLevy
        '
        Me.lblDisplayLevy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayLevy.Location = New System.Drawing.Point(162, 91)
        Me.lblDisplayLevy.Name = "lblDisplayLevy"
        Me.lblDisplayLevy.Size = New System.Drawing.Size(84, 24)
        Me.lblDisplayLevy.TabIndex = 1
        '
        'lblDisplayTransCost
        '
        Me.lblDisplayTransCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayTransCost.Location = New System.Drawing.Point(162, 58)
        Me.lblDisplayTransCost.Name = "lblDisplayTransCost"
        Me.lblDisplayTransCost.Size = New System.Drawing.Size(84, 24)
        Me.lblDisplayTransCost.TabIndex = 1
        '
        'lblDisplayAccommodationCost
        '
        Me.lblDisplayAccommodationCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayAccommodationCost.Location = New System.Drawing.Point(162, 26)
        Me.lblDisplayAccommodationCost.Name = "lblDisplayAccommodationCost"
        Me.lblDisplayAccommodationCost.Size = New System.Drawing.Size(84, 24)
        Me.lblDisplayAccommodationCost.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "TotalCost:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Extra Levy:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Transport Cost:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Accommotion Cost:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(198, 203)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 454)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Your EXAMINATION  NUMBER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSizeGroup As System.Windows.Forms.TextBox
    Friend WithEvents txtNofDay As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDisplayLevy As System.Windows.Forms.Label
    Friend WithEvents lblDisplayTransCost As System.Windows.Forms.Label
    Friend WithEvents lblDisplayAccommodationCost As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDisplayTotalCost As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
