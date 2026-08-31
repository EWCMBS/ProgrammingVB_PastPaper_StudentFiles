<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FunFit_Form
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FunFit_Form))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTimeWk2 = New System.Windows.Forms.TextBox
        Me.txtTimeWk1 = New System.Windows.Forms.TextBox
        Me.txtDistanceWk2 = New System.Windows.Forms.TextBox
        Me.txtDistanceWk1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblBestSession = New System.Windows.Forms.Label
        Me.lblTotalTime = New System.Windows.Forms.Label
        Me.lblAvgDist = New System.Windows.Forms.Label
        Me.lblTotdistance = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCalculcate = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTimeWk2)
        Me.GroupBox1.Controls.Add(Me.txtTimeWk1)
        Me.GroupBox1.Controls.Add(Me.txtDistanceWk2)
        Me.GroupBox1.Controls.Add(Me.txtDistanceWk1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(63, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Process athletes performance:"
        '
        'txtTimeWk2
        '
        Me.txtTimeWk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimeWk2.Location = New System.Drawing.Point(283, 88)
        Me.txtTimeWk2.Name = "txtTimeWk2"
        Me.txtTimeWk2.Size = New System.Drawing.Size(68, 26)
        Me.txtTimeWk2.TabIndex = 3
        Me.txtTimeWk2.Text = "0"
        Me.txtTimeWk2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTimeWk1
        '
        Me.txtTimeWk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimeWk1.Location = New System.Drawing.Point(283, 49)
        Me.txtTimeWk1.Name = "txtTimeWk1"
        Me.txtTimeWk1.Size = New System.Drawing.Size(68, 26)
        Me.txtTimeWk1.TabIndex = 1
        Me.txtTimeWk1.Text = "0"
        Me.txtTimeWk1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDistanceWk2
        '
        Me.txtDistanceWk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDistanceWk2.Location = New System.Drawing.Point(112, 88)
        Me.txtDistanceWk2.Name = "txtDistanceWk2"
        Me.txtDistanceWk2.Size = New System.Drawing.Size(165, 26)
        Me.txtDistanceWk2.TabIndex = 2
        Me.txtDistanceWk2.Text = "0"
        Me.txtDistanceWk2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDistanceWk1
        '
        Me.txtDistanceWk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDistanceWk1.Location = New System.Drawing.Point(112, 49)
        Me.txtDistanceWk1.Name = "txtDistanceWk1"
        Me.txtDistanceWk1.Size = New System.Drawing.Size(165, 26)
        Me.txtDistanceWk1.TabIndex = 0
        Me.txtDistanceWk1.Text = "0"
        Me.txtDistanceWk1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(279, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Time (min)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Distance covered (Km)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Session"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(37, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Week 2:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Week 1:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblBestSession)
        Me.GroupBox2.Controls.Add(Me.lblTotalTime)
        Me.GroupBox2.Controls.Add(Me.lblAvgDist)
        Me.GroupBox2.Controls.Add(Me.lblTotdistance)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(71, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(426, 203)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Performance Outline:"
        '
        'lblBestSession
        '
        Me.lblBestSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBestSession.Location = New System.Drawing.Point(166, 137)
        Me.lblBestSession.Name = "lblBestSession"
        Me.lblBestSession.Size = New System.Drawing.Size(254, 58)
        Me.lblBestSession.TabIndex = 2
        '
        'lblTotalTime
        '
        Me.lblTotalTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalTime.Location = New System.Drawing.Point(166, 103)
        Me.lblTotalTime.Name = "lblTotalTime"
        Me.lblTotalTime.Size = New System.Drawing.Size(254, 23)
        Me.lblTotalTime.TabIndex = 2
        '
        'lblAvgDist
        '
        Me.lblAvgDist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvgDist.Location = New System.Drawing.Point(166, 65)
        Me.lblAvgDist.Name = "lblAvgDist"
        Me.lblAvgDist.Size = New System.Drawing.Size(254, 23)
        Me.lblAvgDist.TabIndex = 1
        '
        'lblTotdistance
        '
        Me.lblTotdistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotdistance.Location = New System.Drawing.Point(166, 29)
        Me.lblTotdistance.Name = "lblTotdistance"
        Me.lblTotdistance.Size = New System.Drawing.Size(254, 23)
        Me.lblTotdistance.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(74, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total Time:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Best Session:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Average Distance:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Distance:"
        '
        'btnCalculcate
        '
        Me.btnCalculcate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculcate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalculcate.ImageIndex = 0
        Me.btnCalculcate.ImageList = Me.ImageList1
        Me.btnCalculcate.Location = New System.Drawing.Point(361, 368)
        Me.btnCalculcate.Name = "btnCalculcate"
        Me.btnCalculcate.Size = New System.Drawing.Size(130, 44)
        Me.btnCalculcate.TabIndex = 0
        Me.btnCalculcate.Text = "&Calculate"
        Me.btnCalculcate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCalculcate.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "AQUA ICONS APPLICATIONS CALCULATOR.png")
        Me.ImageList1.Images.SetKeyName(1, "Button Close.png")
        Me.ImageList1.Images.SetKeyName(2, "Door.png")
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 2
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(692, 368)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 44)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "&Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.ImageKey = "Button Close.png"
        Me.btnClear.ImageList = Me.ImageList1
        Me.btnClear.Location = New System.Drawing.Point(555, 368)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(119, 44)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "C&lear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(503, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 330)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'FunFit_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 422)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculcate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FunFit_Form"
        Me.Text = "Fit And Fun System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTimeWk2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeWk1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDistanceWk2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDistanceWk1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotdistance As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTime As System.Windows.Forms.Label
    Friend WithEvents lblAvgDist As System.Windows.Forms.Label
    Friend WithEvents btnCalculcate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lblBestSession As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
