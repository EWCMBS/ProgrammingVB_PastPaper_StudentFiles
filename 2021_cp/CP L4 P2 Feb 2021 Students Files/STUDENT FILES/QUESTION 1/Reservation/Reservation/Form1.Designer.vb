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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpOut = New System.Windows.Forms.DateTimePicker
        Me.dtpIn = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcontact = New System.Windows.Forms.TextBox
        Me.txtid = New System.Windows.Forms.TextBox
        Me.txtsurname = New System.Windows.Forms.TextBox
        Me.radConferance = New System.Windows.Forms.RadioButton
        Me.radSports = New System.Windows.Forms.RadioButton
        Me.radPool = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.lstDisplay = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpOut)
        Me.GroupBox1.Controls.Add(Me.dtpIn)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Dates:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date Out:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date In:"
        '
        'dtpOut
        '
        Me.dtpOut.Location = New System.Drawing.Point(108, 65)
        Me.dtpOut.Name = "dtpOut"
        Me.dtpOut.Size = New System.Drawing.Size(97, 23)
        Me.dtpOut.TabIndex = 0
        '
        'dtpIn
        '
        Me.dtpIn.Location = New System.Drawing.Point(108, 29)
        Me.dtpIn.Name = "dtpIn"
        Me.dtpIn.Size = New System.Drawing.Size(97, 23)
        Me.dtpIn.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtcontact)
        Me.GroupBox2.Controls.Add(Me.txtid)
        Me.GroupBox2.Controls.Add(Me.txtsurname)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 132)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Information:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Contact:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ID Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Surname:"
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(128, 93)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(119, 23)
        Me.txtcontact.TabIndex = 0
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(128, 61)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(119, 23)
        Me.txtid.TabIndex = 0
        '
        'txtsurname
        '
        Me.txtsurname.Location = New System.Drawing.Point(128, 30)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(119, 23)
        Me.txtsurname.TabIndex = 0
        '
        'radConferance
        '
        Me.radConferance.AutoSize = True
        Me.radConferance.Location = New System.Drawing.Point(24, 95)
        Me.radConferance.Name = "radConferance"
        Me.radConferance.Size = New System.Drawing.Size(150, 20)
        Me.radConferance.TabIndex = 0
        Me.radConferance.TabStop = True
        Me.radConferance.Text = "Conferance Room"
        Me.radConferance.UseVisualStyleBackColor = True
        '
        'radSports
        '
        Me.radSports.AutoSize = True
        Me.radSports.Location = New System.Drawing.Point(24, 62)
        Me.radSports.Name = "radSports"
        Me.radSports.Size = New System.Drawing.Size(110, 20)
        Me.radSports.TabIndex = 0
        Me.radSports.TabStop = True
        Me.radSports.Text = "Sport Fields"
        Me.radSports.UseVisualStyleBackColor = True
        '
        'radPool
        '
        Me.radPool.AutoSize = True
        Me.radPool.Location = New System.Drawing.Point(24, 28)
        Me.radPool.Name = "radPool"
        Me.radPool.Size = New System.Drawing.Size(135, 20)
        Me.radPool.TabIndex = 0
        Me.radPool.TabStop = True
        Me.radPool.Text = "Swimming Pool:"
        Me.radPool.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(167, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 57)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(283, 221)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(204, 134)
        Me.lstDisplay.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(94, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 36)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Facility Managment:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.radConferance)
        Me.GroupBox5.Controls.Add(Me.radPool)
        Me.GroupBox5.Controls.Add(Me.radSports)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(283, 85)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(190, 130)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Facility"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 57)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Make Reservation"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 528)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "FAM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtsurname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents radConferance As System.Windows.Forms.RadioButton
    Friend WithEvents radSports As System.Windows.Forms.RadioButton
    Friend WithEvents radPool As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
