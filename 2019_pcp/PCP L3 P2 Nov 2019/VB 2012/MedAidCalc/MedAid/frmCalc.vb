Option Explicit On
Option Strict On

Public Class frmCalc

    ' ***********************************
    ' EXAMINATION NUMBER:
    ' ***********************************

    'Dependant Arrays
    Dim strArrSpouse() As String = {"None", "Husband", "Wife", "Partner"}
    Dim strArrParents() As String = {"None", "One", "Two", "Three", "Four"}

    'Form level variable declarations
    Dim decBasicMonthlyCost As Decimal = 0
    Dim decFinalMonthlyCost As Decimal = 0
    Dim decDiscountAmount As Decimal = 0

    Dim decMainMemberPrice As Decimal = 0
    Dim decChildPrice As Decimal = 0
    Dim decAdultPrice As Decimal = 0

    Dim intNoOfChildren As Integer = 0
    Dim intNoOfAdults As Integer = 0

    'Constant declaration
    Const decDiscountPercentage As Decimal = 0.05D

    Private Sub frmMediAidContribution_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Q1.1.1


        'Q1.1.2


        'Q1.1.3


        'Q1.1.4


        'Q1.1.5



        'Q1.1.6


    End Sub

    Private Sub chkAdult_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdult.CheckedChanged
        'Q1.2


    End Sub


    Private Sub chkChild_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChild.CheckedChanged
        'Q1.3


    End Sub

    Private Sub cboMemberIncome_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMemberIncome.SelectedIndexChanged
        If cboMemberIncome.SelectedIndex = 0 Then
            chkAdult.Enabled = False
            chkChild.Enabled = False
        ElseIf cboMemberIncome.SelectedIndex = 1 Then
            chkAdult.Enabled = False
            chkChild.Enabled = False
        Else
            chkAdult.Enabled = True
            chkChild.Enabled = True
        End If


        'Q1.4
        

    End Sub

    'Q1.5



    'Q1.6


    'Q1.7
    

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click

        'Validate
        'Included validation
        If cboMemberIncome.SelectedIndex = 0 Then cboMemberIncome.DroppedDown = True

        If chkAdult.Checked = True And cboSpouse.SelectedIndex = 0 And cboParents.SelectedIndex = 0 Then
            MessageBox.Show("No Adult dependents selected")
            chkAdult.Checked = False
        End If

        If chkChild.Checked = True And CInt(txtNumberChildren.Text) < 1I Then
            MessageBox.Show("No Child dependents selected")
            chkChild.Checked = False
        End If


        'Q1.8.1


        'Q1.8.2


        'Q1.8.3


        'Q1.8.4


        'Q1.8.5


        'Output to list box
        DisplayHeading()
        DrawLine()
        DisplayDataLine()

    End Sub



#Region "Pre-written Sub Procedures"
    'Pre-written Sub Procedures

    Private Sub DrawLine()
        Dim strTheLine As String
        strTheLine = "-----------------------------------------------------------------------------------" & _
        "------------------------------------------------------------------"
        lstDisplayContribution.Items.Add(strTheLine)
    End Sub

    Private Sub DisplayHeading()
        Dim strHeadingLine As String
        ' strHeadingLine = "   ".PadRight(5) & "Income Category" & " ".PadLeft(10) & "Ädults" & " ".PadLeft(5) & "Children" & _
        '" ".PadLeft(5) & "Basic Contribution" & " ".PadLeft(5) & "Discount" & " ".PadRight(5) & _
        '"Total Monthly Contribution"

        strHeadingLine = "Main_Member" & " ".PadLeft(3) & "Adult(s) " & " ".PadLeft(1) & "Children" & _
       " ".PadLeft(3) & "Basic_Contribution" & " ".PadLeft(2) & "Discount" & " ".PadRight(2) & _
       "Monthly_Contribution"

        lstDisplayContribution.Items.Clear()
        lstDisplayContribution.Items.Add(strHeadingLine)
    End Sub

    Private Sub DisplayDataLine()
        Dim strDataLine As String
        ' strDataLine = cboMemberIncome.SelectedText.PadRight(9) & " ".PadLeft(15) & intNoOfAdults.ToString & _
        ' " ".PadLeft(20) & txtNumberChildren.Text.ToString & " ".PadLeft(25) & decBasicMonthlyCost.ToString("C2") & _
        '" ".PadLeft(22) & decCalcDiscountAmount.ToString("C2") & " ".PadRight(20) & decFinalMonthlyCost.ToString("C2")

        strDataLine = decMainMemberPrice.ToString("C2") & " ".PadLeft(6) & intNoOfAdults & " ".PadLeft(8) & _
        intNoOfChildren & " ".PadLeft(11) & decBasicMonthlyCost.ToString("C2") & " ".PadLeft(8) & _
        decDiscountAmount.ToString("C2") & " ".PadLeft(8) & decFinalMonthlyCost.ToString("C2")

        lstDisplayContribution.Items.Add(strDataLine)
    End Sub

    Private Sub PopIncomeCategories()
        cboMemberIncome.Items.Add("Choose Income Category:")
        cboMemberIncome.Items.Add("R6 300 or below")
        cboMemberIncome.Items.Add("R6 301 - R8 500")
        cboMemberIncome.Items.Add("R8 501 - R11 700")
        cboMemberIncome.Items.Add("R11 501 or more")
    End Sub

    Private Sub txtNumberChildren_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumberChildren.TextChanged
        If txtNumberChildren.Text = "" Then
            Exit Sub
        Else
            lblChildPrice.Text = (CInt(txtNumberChildren.Text) * decChildPrice).ToString("C2") & " for child(ren)"
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblAdultPrice.Text = ""
        txtNumberChildren.Text = CStr(0)
        lstDisplayContribution.Items.Clear()
        cboMemberIncome.SelectedIndex = 0
        cboSpouse.SelectedIndex = 0
        cboParents.SelectedIndex = 0
        grpAdultDependent.Enabled = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure?", "Closing Application", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

#End Region

    
    
End Class

