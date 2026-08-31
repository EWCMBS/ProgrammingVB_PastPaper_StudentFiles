Option Explicit On
Option Strict On

'Water Tracker
' ***************************************
' COMPUTER NUMBER    :
' EXAMINATION NUMBER :
'****************************************

Public Class frmWaterTrack

    'Declare arrays to store the data
    Dim strArrDaysofWeek() As String = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}
    Dim intArrSampleLevel(6) As Integer 'Water Sample Array
    Dim dblArrPhLevel(6) As Double      'pH Level Array

    Dim intCount As Integer = 0       'Loop Counter Variable
    Dim intCounter As Integer = 0     'Index counter variable for array
    Dim dblAveragepH As Double
    Dim intTotalSampleLevel As Integer

    Private Sub frmWaterTrack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboDaysOfWeek.Text = "Select a day"

        'Q2.2


        'Set properties of Buttons
        btnAdd.Enabled = False
        btnDisplay.Enabled = False
        btnClear.Enabled = False
    End Sub

    'Q2.3


    'Q2.4

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Q2.5.1


        'Enter Data into Arrays
        'redimension the arrays everytime an element is added
        'The preserver keyword keeps data elements that are already in the array
        'ReDim Preserve strArrDayofWeek(intCounter)
        ReDim Preserve intArrSampleLevel(intCounter)
        ReDim Preserve dblArrPhLevel(intCounter)

        'Q2.5.2
        'Check for valid numeric input
        'assign water level to array variable
        If IsNumeric(txtWaterLevel.Text) = True Then
            intArrSampleLevel(intCounter) = CInt(txtWaterLevel.Text)
        Else
            MessageBox.Show("Enter a valid litre amount", "Entry Error")
            txtWaterLevel.SelectAll()
            txtWaterLevel.Focus()
            Exit Sub
        End If

        'Q2.5.3
        'Check for valid numeric input
        'assign pH level to array variable
        If IsNumeric(txtPhLevel.Text) = True Then
            dblArrPhLevel(intCounter) = CDbl(txtPhLevel.Text)
        Else
            MessageBox.Show("Enter a valid pH amount", "Entry Error")
            txtPhLevel.SelectAll()
            txtPhLevel.Focus()
            Exit Sub
        End If

        intCounter += 1


        'Remove index from combo box
        If cboDaysOfWeek.Items.Count = 1 Then
            cboDaysOfWeek.Text = "No Days Left"
            txtPhLevel.Clear()
            txtWaterLevel.Clear()

            If btnDisplay.Enabled = False Then btnDisplay.Enabled = True

            btnAdd.Enabled = False
            txtPhLevel.Enabled = False
            txtWaterLevel.Enabled = False

            Exit Sub
        Else
            'Q2.5.4

            cboDaysOfWeek.Text = "Select a day"
        End If

        'reset control properties
        txtWaterLevel.Clear()
        txtPhLevel.Clear()

    End Sub

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        lstDisplay.Items.Clear()
        DrawHeadings()
        Dim x, y As Integer
        Dim strTempDay As String = ""
        Dim intTempSampleLevel As Integer = 0
        Dim dblTempPh As Double = 0

        If radSortWaterLevel.Checked = True Then
            'Q2.6.1
            'Sorting algorithm

        End If


        If radSortPhLevel.Checked = True Then
            'Q2.6.2
            'Sorting algorithm

        End If

        For intCount = 0 To UBound(intArrSampleLevel)
            lstDisplay.Items.Add(strArrDaysofWeek(intCount).PadRight(10) & intArrSampleLevel(intCount).ToString("N0").PadLeft(10) & "L" _
            & dblArrPhLevel(intCount).ToString("F2").PadLeft(15))
        Next intCount


        'Display the total sample level
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Total Sample Level: ".PadRight(10) & _
                             intTotalSampleLevel.ToString("N0").PadLeft(10) & "L")
        lstDisplay.Items.Add("")

        'Display average pH levels
        lstDisplay.Items.Add("Average pH Water Level: ".PadRight(20) & _
                             dblAveragepH.ToString("F2").PadLeft(10))
        lstDisplay.Items.Add("")


    End Sub


    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        'Display the data in the list box
        'Calculate the total water samples
        'Calculate the average pH Level

        DrawHeadings()

        For intCount = 0 To UBound(strArrDaysofWeek)
            lstDisplay.Items.Add(strArrDaysofWeek(intCount).PadRight(10) & intArrSampleLevel(intCount).ToString("N0").PadLeft(10) & "L" _
            & dblArrPhLevel(intCount).ToString("F2").PadLeft(15))
        Next

        'Call User Defined Functions
        intTotalSampleLevel = CalcTotalSample()
        dblAveragepH = CalcpHAve()

        'Display the total sample level
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Total Sample Level: ".PadRight(10) & _
                             intTotalSampleLevel.ToString("N0").PadLeft(10) & "L")
        lstDisplay.Items.Add("")

        'Display average pH levels
        lstDisplay.Items.Add("Average pH Water Level: ".PadRight(20) & _
                             dblAveragepH.ToString("F2").PadLeft(10))
        lstDisplay.Items.Add("")

        'enable the clear button
        btnClear.Enabled = True
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clear the List Box 
        lstDisplay.Items.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Close the form and end application
        Me.Close()
    End Sub


    Private Sub cboDaysOfWeek_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDaysOfWeek.SelectedIndexChanged
        btnAdd.Enabled = True
    End Sub

    Public Sub DrawHeadings()
        lstDisplay.Items.Clear()
        lstDisplay.Items.Add("Day".PadRight(10) & "Sample Level (L)".PadLeft(10) & "pH Level".PadLeft(10))
        lstDisplay.Items.Add("")
    End Sub
End Class
