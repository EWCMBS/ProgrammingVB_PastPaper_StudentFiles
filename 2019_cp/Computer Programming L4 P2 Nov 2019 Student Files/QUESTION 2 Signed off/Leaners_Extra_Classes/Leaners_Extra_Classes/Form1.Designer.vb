<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLearners
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
        Me.lblGender = New System.Windows.Forms.Label
        Me.lblSubject = New System.Windows.Forms.Label
        Me.lblContact = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.txtGender = New System.Windows.Forms.TextBox
        Me.lblSurname = New System.Windows.Forms.Label
        Me.lblLearnerID = New System.Windows.Forms.Label
        Me.txtSubjectID = New System.Windows.Forms.TextBox
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.txtLearnerID = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.tbextralclass = New System.Windows.Forms.TabControl
        Me.tapLearner = New System.Windows.Forms.TabPage
        Me.Button3 = New System.Windows.Forms.Button
        Me.tapSubject = New System.Windows.Forms.TabPage
        Me.txtTeacherId = New System.Windows.Forms.TextBox
        Me.lblTeacherID = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSubjectList = New System.Windows.Forms.Button
        Me.dgvSubject = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.tbextralclass.SuspendLayout()
        Me.tapLearner.SuspendLayout()
        Me.tapSubject.SuspendLayout()
        CType(Me.dgvSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.lblSubject)
        Me.GroupBox1.Controls.Add(Me.lblContact)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.txtGender)
        Me.GroupBox1.Controls.Add(Me.lblSurname)
        Me.GroupBox1.Controls.Add(Me.lblLearnerID)
        Me.GroupBox1.Controls.Add(Me.txtSubjectID)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtSurname)
        Me.GroupBox1.Controls.Add(Me.txtLearnerID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 244)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Learner's Information:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(48, 136)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(67, 20)
        Me.lblGender.TabIndex = 1
        Me.lblGender.Text = "Gender:"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(37, 216)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(84, 20)
        Me.lblSubject.TabIndex = 1
        Me.lblSubject.Text = "SubjectID:"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(46, 176)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(69, 20)
        Me.lblContact.TabIndex = 1
        Me.lblContact.Text = "Contact:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(60, 96)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'txtGender
        '
        Me.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(148, 133)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(134, 26)
        Me.txtGender.TabIndex = 3
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(37, 69)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(78, 20)
        Me.lblSurname.TabIndex = 1
        Me.lblSurname.Text = "Surname:"
        '
        'lblLearnerID
        '
        Me.lblLearnerID.AutoSize = True
        Me.lblLearnerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLearnerID.Location = New System.Drawing.Point(30, 35)
        Me.lblLearnerID.Name = "lblLearnerID"
        Me.lblLearnerID.Size = New System.Drawing.Size(85, 20)
        Me.lblLearnerID.TabIndex = 1
        Me.lblLearnerID.Text = "LearnerID:"
        '
        'txtSubjectID
        '
        Me.txtSubjectID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubjectID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectID.Location = New System.Drawing.Point(148, 210)
        Me.txtSubjectID.Name = "txtSubjectID"
        Me.txtSubjectID.Size = New System.Drawing.Size(134, 26)
        Me.txtSubjectID.TabIndex = 5
        '
        'txtContact
        '
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(148, 173)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(134, 26)
        Me.txtContact.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(148, 96)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(219, 26)
        Me.txtName.TabIndex = 2
        '
        'txtSurname
        '
        Me.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(148, 64)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(219, 26)
        Me.txtSurname.TabIndex = 1
        '
        'txtLearnerID
        '
        Me.txtLearnerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLearnerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLearnerID.Location = New System.Drawing.Point(148, 32)
        Me.txtLearnerID.Name = "txtLearnerID"
        Me.txtLearnerID.Size = New System.Drawing.Size(106, 26)
        Me.txtLearnerID.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(176, 296)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 37)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbextralclass
        '
        Me.tbextralclass.Controls.Add(Me.tapLearner)
        Me.tbextralclass.Controls.Add(Me.tapSubject)
        Me.tbextralclass.Location = New System.Drawing.Point(-1, -6)
        Me.tbextralclass.Name = "tbextralclass"
        Me.tbextralclass.SelectedIndex = 0
        Me.tbextralclass.Size = New System.Drawing.Size(645, 433)
        Me.tbextralclass.TabIndex = 3
        '
        'tapLearner
        '
        Me.tapLearner.Controls.Add(Me.Button3)
        Me.tapLearner.Controls.Add(Me.Button2)
        Me.tapLearner.Controls.Add(Me.GroupBox1)
        Me.tapLearner.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tapLearner.Location = New System.Drawing.Point(4, 22)
        Me.tapLearner.Name = "tapLearner"
        Me.tapLearner.Padding = New System.Windows.Forms.Padding(3)
        Me.tapLearner.Size = New System.Drawing.Size(637, 407)
        Me.tapLearner.TabIndex = 0
        Me.tapLearner.Text = "Learner Register "
        Me.tapLearner.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(47, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 37)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Add Leaner"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tapSubject
        '
        Me.tapSubject.Controls.Add(Me.txtTeacherId)
        Me.tapSubject.Controls.Add(Me.lblTeacherID)
        Me.tapSubject.Controls.Add(Me.btnExit)
        Me.tapSubject.Controls.Add(Me.btnSubjectList)
        Me.tapSubject.Controls.Add(Me.dgvSubject)
        Me.tapSubject.Location = New System.Drawing.Point(4, 22)
        Me.tapSubject.Name = "tapSubject"
        Me.tapSubject.Padding = New System.Windows.Forms.Padding(3)
        Me.tapSubject.Size = New System.Drawing.Size(637, 407)
        Me.tapSubject.TabIndex = 1
        Me.tapSubject.Text = "View Subject Teacher"
        Me.tapSubject.UseVisualStyleBackColor = True
        '
        'txtTeacherId
        '
        Me.txtTeacherId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTeacherId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeacherId.Location = New System.Drawing.Point(158, 240)
        Me.txtTeacherId.Name = "txtTeacherId"
        Me.txtTeacherId.Size = New System.Drawing.Size(63, 26)
        Me.txtTeacherId.TabIndex = 4
        '
        'lblTeacherID
        '
        Me.lblTeacherID.AutoSize = True
        Me.lblTeacherID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherID.Location = New System.Drawing.Point(9, 246)
        Me.lblTeacherID.Name = "lblTeacherID"
        Me.lblTeacherID.Size = New System.Drawing.Size(131, 20)
        Me.lblTeacherID.TabIndex = 3
        Me.lblTeacherID.Text = "Enter TeacherID:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(163, 286)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 34)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubjectList
        '
        Me.btnSubjectList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubjectList.Location = New System.Drawing.Point(6, 286)
        Me.btnSubjectList.Name = "btnSubjectList"
        Me.btnSubjectList.Size = New System.Drawing.Size(142, 34)
        Me.btnSubjectList.TabIndex = 1
        Me.btnSubjectList.Text = "Subject List"
        Me.btnSubjectList.UseVisualStyleBackColor = True
        '
        'dgvSubject
        '
        Me.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubject.Location = New System.Drawing.Point(6, 6)
        Me.dgvSubject.Name = "dgvSubject"
        Me.dgvSubject.Size = New System.Drawing.Size(609, 222)
        Me.dgvSubject.TabIndex = 0
        '
        'frmLearners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 439)
        Me.Controls.Add(Me.tbextralclass)
        Me.Name = "frmLearners"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Learner's_Extra_Subject"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbextralclass.ResumeLayout(False)
        Me.tapLearner.ResumeLayout(False)
        Me.tapSubject.ResumeLayout(False)
        Me.tapSubject.PerformLayout()
        CType(Me.dgvSubject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtLearnerID As System.Windows.Forms.TextBox
    Friend WithEvents txtSubjectID As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblLearnerID As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbextralclass As System.Windows.Forms.TabControl
    Friend WithEvents tapLearner As System.Windows.Forms.TabPage
    Friend WithEvents tapSubject As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSubjectList As System.Windows.Forms.Button
    Friend WithEvents dgvSubject As System.Windows.Forms.DataGridView
    Friend WithEvents txtTeacherId As System.Windows.Forms.TextBox
    Friend WithEvents lblTeacherID As System.Windows.Forms.Label

End Class
