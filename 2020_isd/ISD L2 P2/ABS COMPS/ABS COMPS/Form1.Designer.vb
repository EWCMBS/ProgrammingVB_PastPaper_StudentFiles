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
        Me.txtUnits = New System.Windows.Forms.TextBox
        Me.txtCostPrice = New System.Windows.Forms.TextBox
        Me.txtProduct = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblDisplayProfit = New System.Windows.Forms.Label
        Me.lblDisplayTotalIncome = New System.Windows.Forms.Label
        Me.lblDisplaySellingPrice = New System.Windows.Forms.Label
        Me.lblDisplaymark = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUnits)
        Me.GroupBox1.Controls.Add(Me.txtCostPrice)
        Me.GroupBox1.Controls.Add(Me.txtProduct)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Provide Product Information:"
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(129, 60)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(75, 22)
        Me.txtUnits.TabIndex = 1
        '
        'txtCostPrice
        '
        Me.txtCostPrice.Location = New System.Drawing.Point(129, 92)
        Me.txtCostPrice.Name = "txtCostPrice"
        Me.txtCostPrice.Size = New System.Drawing.Size(75, 22)
        Me.txtCostPrice.TabIndex = 1
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(129, 26)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(123, 22)
        Me.txtProduct.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cost Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Number ofUnits:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product  Item:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDisplayProfit)
        Me.GroupBox2.Controls.Add(Me.lblDisplayTotalIncome)
        Me.GroupBox2.Controls.Add(Me.lblDisplaySellingPrice)
        Me.GroupBox2.Controls.Add(Me.lblDisplaymark)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 261)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 156)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Calculations:"
        '
        'lblDisplayProfit
        '
        Me.lblDisplayProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayProfit.Location = New System.Drawing.Point(121, 121)
        Me.lblDisplayProfit.Name = "lblDisplayProfit"
        Me.lblDisplayProfit.Size = New System.Drawing.Size(84, 23)
        Me.lblDisplayProfit.TabIndex = 1
        Me.lblDisplayProfit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayTotalIncome
        '
        Me.lblDisplayTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayTotalIncome.Location = New System.Drawing.Point(121, 88)
        Me.lblDisplayTotalIncome.Name = "lblDisplayTotalIncome"
        Me.lblDisplayTotalIncome.Size = New System.Drawing.Size(84, 23)
        Me.lblDisplayTotalIncome.TabIndex = 1
        Me.lblDisplayTotalIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplaySellingPrice
        '
        Me.lblDisplaySellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplaySellingPrice.Location = New System.Drawing.Point(121, 59)
        Me.lblDisplaySellingPrice.Name = "lblDisplaySellingPrice"
        Me.lblDisplaySellingPrice.Size = New System.Drawing.Size(84, 23)
        Me.lblDisplaySellingPrice.TabIndex = 1
        Me.lblDisplaySellingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplaymark
        '
        Me.lblDisplaymark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplaymark.Location = New System.Drawing.Point(121, 27)
        Me.lblDisplaymark.Name = "lblDisplaymark"
        Me.lblDisplaymark.Size = New System.Drawing.Size(84, 23)
        Me.lblDisplaymark.TabIndex = 1
        Me.lblDisplaymark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total Income:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Profit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Selling Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "MarkUp Price:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(25, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Calculate "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(148, 209)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 31)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(244, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 31)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "&Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-5, -1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(182, 43)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "ABS SALES"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 411)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Your EXAMINATION NUMBER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUnits As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDisplayProfit As System.Windows.Forms.Label
    Friend WithEvents lblDisplayTotalIncome As System.Windows.Forms.Label
    Friend WithEvents lblDisplaySellingPrice As System.Windows.Forms.Label
    Friend WithEvents lblDisplaymark As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
