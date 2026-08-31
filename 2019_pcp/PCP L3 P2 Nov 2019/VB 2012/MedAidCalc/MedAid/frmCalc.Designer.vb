<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalc))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNumberChildren = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboParents = New System.Windows.Forms.ComboBox
        Me.cboSpouse = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lstDisplayContribution = New System.Windows.Forms.ListBox
        Me.cboMemberIncome = New System.Windows.Forms.ComboBox
        Me.lblAdultPrice = New System.Windows.Forms.Label
        Me.grpAdultDependent = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnCalc = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.grpMainMember = New System.Windows.Forms.GroupBox
        Me.grpChildDependent = New System.Windows.Forms.GroupBox
        Me.lblChildPrice = New System.Windows.Forms.Label
        Me.chkAdult = New System.Windows.Forms.CheckBox
        Me.chkChild = New System.Windows.Forms.CheckBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAdultDependent.SuspendLayout()
        Me.grpMainMember.SuspendLayout()
        Me.grpChildDependent.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 169)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Contribution Calculator"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Spouse"
        '
        'txtNumberChildren
        '
        Me.txtNumberChildren.Location = New System.Drawing.Point(8, 36)
        Me.txtNumberChildren.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNumberChildren.MaxLength = 3
        Me.txtNumberChildren.Name = "txtNumberChildren"
        Me.txtNumberChildren.Size = New System.Drawing.Size(34, 23)
        Me.txtNumberChildren.TabIndex = 3
        Me.txtNumberChildren.Text = "0"
        Me.txtNumberChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Number of Children:"
        '
        'cboParents
        '
        Me.cboParents.FormattingEnabled = True
        Me.cboParents.Location = New System.Drawing.Point(144, 36)
        Me.cboParents.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboParents.Name = "cboParents"
        Me.cboParents.Size = New System.Drawing.Size(109, 23)
        Me.cboParents.TabIndex = 2
        '
        'cboSpouse
        '
        Me.cboSpouse.FormattingEnabled = True
        Me.cboSpouse.Location = New System.Drawing.Point(19, 36)
        Me.cboSpouse.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboSpouse.Name = "cboSpouse"
        Me.cboSpouse.Size = New System.Drawing.Size(110, 23)
        Me.cboSpouse.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(548, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 145)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lstDisplayContribution
        '
        Me.lstDisplayContribution.FormattingEnabled = True
        Me.lstDisplayContribution.ItemHeight = 15
        Me.lstDisplayContribution.Location = New System.Drawing.Point(16, 193)
        Me.lstDisplayContribution.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.lstDisplayContribution.Name = "lstDisplayContribution"
        Me.lstDisplayContribution.Size = New System.Drawing.Size(679, 64)
        Me.lstDisplayContribution.TabIndex = 11
        '
        'cboMemberIncome
        '
        Me.cboMemberIncome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMemberIncome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboMemberIncome.FormattingEnabled = True
        Me.cboMemberIncome.Location = New System.Drawing.Point(5, 16)
        Me.cboMemberIncome.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboMemberIncome.Name = "cboMemberIncome"
        Me.cboMemberIncome.Size = New System.Drawing.Size(267, 23)
        Me.cboMemberIncome.TabIndex = 0
        '
        'lblAdultPrice
        '
        Me.lblAdultPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdultPrice.Location = New System.Drawing.Point(299, 15)
        Me.lblAdultPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAdultPrice.Name = "lblAdultPrice"
        Me.lblAdultPrice.Size = New System.Drawing.Size(216, 23)
        Me.lblAdultPrice.TabIndex = 10
        Me.lblAdultPrice.Visible = False
        '
        'grpAdultDependent
        '
        Me.grpAdultDependent.Controls.Add(Me.Label5)
        Me.grpAdultDependent.Controls.Add(Me.cboParents)
        Me.grpAdultDependent.Controls.Add(Me.Label3)
        Me.grpAdultDependent.Controls.Add(Me.cboSpouse)
        Me.grpAdultDependent.Enabled = False
        Me.grpAdultDependent.Location = New System.Drawing.Point(25, 84)
        Me.grpAdultDependent.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpAdultDependent.Name = "grpAdultDependent"
        Me.grpAdultDependent.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpAdultDependent.Size = New System.Drawing.Size(257, 73)
        Me.grpAdultDependent.TabIndex = 15
        Me.grpAdultDependent.TabStop = False
        Me.grpAdultDependent.Text = "Adult Dependents:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(141, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Parents/In-Laws"
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Image = CType(resources.GetObject("btnCalc.Image"), System.Drawing.Image)
        Me.btnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalc.Location = New System.Drawing.Point(11, 263)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(107, 47)
        Me.btnCalc.TabIndex = 16
        Me.btnCalc.Text = "C&alculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(578, 263)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 47)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(294, 263)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 47)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'grpMainMember
        '
        Me.grpMainMember.Controls.Add(Me.cboMemberIncome)
        Me.grpMainMember.Controls.Add(Me.lblAdultPrice)
        Me.grpMainMember.Location = New System.Drawing.Point(11, 9)
        Me.grpMainMember.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpMainMember.Name = "grpMainMember"
        Me.grpMainMember.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpMainMember.Size = New System.Drawing.Size(533, 44)
        Me.grpMainMember.TabIndex = 19
        Me.grpMainMember.TabStop = False
        Me.grpMainMember.Text = "Main Member:"
        '
        'grpChildDependent
        '
        Me.grpChildDependent.Controls.Add(Me.lblChildPrice)
        Me.grpChildDependent.Controls.Add(Me.txtNumberChildren)
        Me.grpChildDependent.Controls.Add(Me.Label4)
        Me.grpChildDependent.Enabled = False
        Me.grpChildDependent.Location = New System.Drawing.Point(286, 84)
        Me.grpChildDependent.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpChildDependent.Name = "grpChildDependent"
        Me.grpChildDependent.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpChildDependent.Size = New System.Drawing.Size(246, 73)
        Me.grpChildDependent.TabIndex = 20
        Me.grpChildDependent.TabStop = False
        Me.grpChildDependent.Text = "Child Dependents"
        '
        'lblChildPrice
        '
        Me.lblChildPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChildPrice.Location = New System.Drawing.Point(46, 36)
        Me.lblChildPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChildPrice.Name = "lblChildPrice"
        Me.lblChildPrice.Size = New System.Drawing.Size(182, 23)
        Me.lblChildPrice.TabIndex = 11
        Me.lblChildPrice.Visible = False
        '
        'chkAdult
        '
        Me.chkAdult.AutoSize = True
        Me.chkAdult.Location = New System.Drawing.Point(16, 58)
        Me.chkAdult.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkAdult.Name = "chkAdult"
        Me.chkAdult.Size = New System.Drawing.Size(138, 19)
        Me.chkAdult.TabIndex = 21
        Me.chkAdult.Text = "Adult Dependents"
        Me.chkAdult.UseVisualStyleBackColor = True
        '
        'chkChild
        '
        Me.chkChild.AutoSize = True
        Me.chkChild.Location = New System.Drawing.Point(281, 58)
        Me.chkChild.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkChild.Name = "chkChild"
        Me.chkChild.Size = New System.Drawing.Size(138, 19)
        Me.chkChild.TabIndex = 22
        Me.chkChild.Text = "Child Dependents"
        Me.chkChild.UseVisualStyleBackColor = True
        '
        'frmCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 319)
        Me.Controls.Add(Me.chkChild)
        Me.Controls.Add(Me.chkAdult)
        Me.Controls.Add(Me.grpChildDependent)
        Me.Controls.Add(Me.grpMainMember)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpAdultDependent)
        Me.Controls.Add(Me.lstDisplayContribution)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examination Number Here"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAdultDependent.ResumeLayout(False)
        Me.grpAdultDependent.PerformLayout()
        Me.grpMainMember.ResumeLayout(False)
        Me.grpChildDependent.ResumeLayout(False)
        Me.grpChildDependent.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumberChildren As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstDisplayContribution As System.Windows.Forms.ListBox
    Friend WithEvents cboMemberIncome As System.Windows.Forms.ComboBox
    Friend WithEvents lblAdultPrice As System.Windows.Forms.Label
    Friend WithEvents cboSpouse As System.Windows.Forms.ComboBox
    Friend WithEvents cboParents As System.Windows.Forms.ComboBox
    Friend WithEvents grpAdultDependent As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents grpMainMember As System.Windows.Forms.GroupBox
    Friend WithEvents grpChildDependent As System.Windows.Forms.GroupBox
    Friend WithEvents chkAdult As System.Windows.Forms.CheckBox
    Friend WithEvents chkChild As System.Windows.Forms.CheckBox
    Friend WithEvents lblChildPrice As System.Windows.Forms.Label

End Class
