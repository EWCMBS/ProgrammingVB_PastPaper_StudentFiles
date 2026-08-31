<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWaterTrack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWaterTrack))
        Me.grpData = New System.Windows.Forms.GroupBox
        Me.btnDisplay = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.cboDaysOfWeek = New System.Windows.Forms.ComboBox
        Me.txtPhLevel = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtWaterLevel = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.grpOutPut = New System.Windows.Forms.GroupBox
        Me.lstDisplay = New System.Windows.Forms.ListBox
        Me.grpSort = New System.Windows.Forms.GroupBox
        Me.radSortPhLevel = New System.Windows.Forms.RadioButton
        Me.radSortWaterLevel = New System.Windows.Forms.RadioButton
        Me.btnSort = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.grpData.SuspendLayout()
        Me.grpOutPut.SuspendLayout()
        Me.grpSort.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpData
        '
        Me.grpData.Controls.Add(Me.PictureBox1)
        Me.grpData.Controls.Add(Me.btnDisplay)
        Me.grpData.Controls.Add(Me.btnAdd)
        Me.grpData.Controls.Add(Me.cboDaysOfWeek)
        Me.grpData.Controls.Add(Me.txtPhLevel)
        Me.grpData.Controls.Add(Me.Label2)
        Me.grpData.Controls.Add(Me.Label5)
        Me.grpData.Controls.Add(Me.txtWaterLevel)
        Me.grpData.Controls.Add(Me.Label4)
        Me.grpData.Controls.Add(Me.Label3)
        Me.grpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpData.ForeColor = System.Drawing.Color.Black
        Me.grpData.Location = New System.Drawing.Point(11, 9)
        Me.grpData.Margin = New System.Windows.Forms.Padding(2)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(2)
        Me.grpData.Size = New System.Drawing.Size(175, 236)
        Me.grpData.TabIndex = 4
        Me.grpData.TabStop = False
        Me.grpData.Text = "Enter Data:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Image = CType(resources.GetObject("btnDisplay.Image"), System.Drawing.Image)
        Me.btnDisplay.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDisplay.Location = New System.Drawing.Point(91, 191)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(77, 30)
        Me.btnDisplay.TabIndex = 14
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAdd.Location = New System.Drawing.Point(4, 191)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(68, 30)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cboDaysOfWeek
        '
        Me.cboDaysOfWeek.ForeColor = System.Drawing.Color.Black
        Me.cboDaysOfWeek.FormattingEnabled = True
        Me.cboDaysOfWeek.Location = New System.Drawing.Point(11, 37)
        Me.cboDaysOfWeek.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboDaysOfWeek.Name = "cboDaysOfWeek"
        Me.cboDaysOfWeek.Size = New System.Drawing.Size(127, 24)
        Me.cboDaysOfWeek.TabIndex = 0
        '
        'txtPhLevel
        '
        Me.txtPhLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhLevel.ForeColor = System.Drawing.Color.Black
        Me.txtPhLevel.Location = New System.Drawing.Point(11, 155)
        Me.txtPhLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhLevel.Name = "txtPhLevel"
        Me.txtPhLevel.Size = New System.Drawing.Size(87, 22)
        Me.txtPhLevel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 124)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "pH Level:"
        '
        'txtWaterLevel
        '
        Me.txtWaterLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWaterLevel.ForeColor = System.Drawing.Color.Black
        Me.txtWaterLevel.Location = New System.Drawing.Point(11, 96)
        Me.txtWaterLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtWaterLevel.Name = "txtWaterLevel"
        Me.txtWaterLevel.Size = New System.Drawing.Size(87, 22)
        Me.txtWaterLevel.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 63)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sample Water Level:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Day of Week"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExit.Location = New System.Drawing.Point(597, 249)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(68, 26)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnClear.Location = New System.Drawing.Point(11, 249)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(68, 26)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "C&lear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'grpOutPut
        '
        Me.grpOutPut.Controls.Add(Me.grpSort)
        Me.grpOutPut.Controls.Add(Me.lstDisplay)
        Me.grpOutPut.Location = New System.Drawing.Point(191, 11)
        Me.grpOutPut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpOutPut.Name = "grpOutPut"
        Me.grpOutPut.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpOutPut.Size = New System.Drawing.Size(474, 234)
        Me.grpOutPut.TabIndex = 13
        Me.grpOutPut.TabStop = False
        Me.grpOutPut.Text = "Results"
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(5, 17)
        Me.lstDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(334, 199)
        Me.lstDisplay.TabIndex = 9
        '
        'grpSort
        '
        Me.grpSort.Controls.Add(Me.radSortPhLevel)
        Me.grpSort.Controls.Add(Me.radSortWaterLevel)
        Me.grpSort.Controls.Add(Me.btnSort)
        Me.grpSort.Location = New System.Drawing.Point(349, 15)
        Me.grpSort.Name = "grpSort"
        Me.grpSort.Size = New System.Drawing.Size(120, 123)
        Me.grpSort.TabIndex = 14
        Me.grpSort.TabStop = False
        Me.grpSort.Text = "Sort by:"
        '
        'radSortPhLevel
        '
        Me.radSortPhLevel.AutoSize = True
        Me.radSortPhLevel.Location = New System.Drawing.Point(6, 66)
        Me.radSortPhLevel.Name = "radSortPhLevel"
        Me.radSortPhLevel.Size = New System.Drawing.Size(89, 17)
        Me.radSortPhLevel.TabIndex = 5
        Me.radSortPhLevel.Text = "pH Level"
        Me.radSortPhLevel.UseVisualStyleBackColor = True
        '
        'radSortWaterLevel
        '
        Me.radSortWaterLevel.AutoSize = True
        Me.radSortWaterLevel.Checked = True
        Me.radSortWaterLevel.Location = New System.Drawing.Point(6, 27)
        Me.radSortWaterLevel.Name = "radSortWaterLevel"
        Me.radSortWaterLevel.Size = New System.Drawing.Size(113, 17)
        Me.radSortWaterLevel.TabIndex = 4
        Me.radSortWaterLevel.TabStop = True
        Me.radSortWaterLevel.Text = "Water Level"
        Me.radSortWaterLevel.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Image = CType(resources.GetObject("btnSort.Image"), System.Drawing.Image)
        Me.btnSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSort.Location = New System.Drawing.Point(47, 88)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(67, 30)
        Me.btnSort.TabIndex = 3
        Me.btnSort.Text = "Sor&t"
        Me.btnSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(103, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 45)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'frmWaterTrack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(669, 281)
        Me.Controls.Add(Me.grpOutPut)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpData)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWaterTrack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Water Tracker - Examination Number"
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
        Me.grpOutPut.ResumeLayout(False)
        Me.grpSort.ResumeLayout(False)
        Me.grpSort.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpData As System.Windows.Forms.GroupBox
    Friend WithEvents txtWaterLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtPhLevel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cboDaysOfWeek As System.Windows.Forms.ComboBox
    Friend WithEvents grpOutPut As System.Windows.Forms.GroupBox
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents grpSort As System.Windows.Forms.GroupBox
    Friend WithEvents radSortPhLevel As System.Windows.Forms.RadioButton
    Friend WithEvents radSortWaterLevel As System.Windows.Forms.RadioButton
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
