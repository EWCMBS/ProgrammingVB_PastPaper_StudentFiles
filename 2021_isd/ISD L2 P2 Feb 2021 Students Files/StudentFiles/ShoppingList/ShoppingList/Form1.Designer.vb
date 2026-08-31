<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShoppingList
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
        Me.btnCreateList = New System.Windows.Forms.Button
        Me.lstShoppingList = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnCreateList
        '
        Me.btnCreateList.Location = New System.Drawing.Point(37, 56)
        Me.btnCreateList.Name = "btnCreateList"
        Me.btnCreateList.Size = New System.Drawing.Size(215, 41)
        Me.btnCreateList.TabIndex = 0
        Me.btnCreateList.Text = "&Create Shopping  List"
        Me.btnCreateList.UseVisualStyleBackColor = True
        '
        'lstShoppingList
        '
        Me.lstShoppingList.FormattingEnabled = True
        Me.lstShoppingList.Location = New System.Drawing.Point(30, 120)
        Me.lstShoppingList.Name = "lstShoppingList"
        Me.lstShoppingList.Size = New System.Drawing.Size(222, 186)
        Me.lstShoppingList.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "My Shopping List Calculator:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(30, 321)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 35)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(146, 321)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 35)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmShoppingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 360)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstShoppingList)
        Me.Controls.Add(Me.btnCreateList)
        Me.Name = "frmShoppingList"
        Me.Text = "Your EXAMINAION NUMBER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateList As System.Windows.Forms.Button
    Friend WithEvents lstShoppingList As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
