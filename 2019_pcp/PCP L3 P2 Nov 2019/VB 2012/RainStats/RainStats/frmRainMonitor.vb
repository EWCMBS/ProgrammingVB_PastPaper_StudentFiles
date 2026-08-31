Option Explicit On
Option Strict On
Public Class frmRainMonitor

    ' ************************************
    ' Examination Number :
    '*************************************

    Dim sngArr2014Figures() As Single = {41.2, 28.8, 15.8, 74.8, 70.4, 70.2}
    Dim sngArr2015Figures() As Single = {95.6, 12.2, 35.6, 27.2, 99.2, 67.2}
    Dim sngArr2016Figures() As Single = {22.2, 41.6, 22.2, 18.2, 75.6, 52.8}
    Dim sngArr2017Figures() As Single = {12.6, 14.4, 15.6, 16.4, 28.0, 15.2}
    Dim sngArr2018Figures() As Single = {24.2, 60.2, 98.6, 55.4, 57.6, 81.6}

    'Total rainfall per year array
    Dim sngArrTotalPerYear(intNoOfYears - 1) As Single

    'Global Constants
    Const intNoOfYears As Integer = 5
    Const intNoOfMonths As Integer = 6

    ' Global variables
    Dim strWettestMonth As String
    Dim sngHighestFigure As Single

    ' data lines
    Dim headingLine As String
    Dim dataLine1 As String
    Dim dataLine2 As String
    Dim dataLine3 As String
    Dim dataLine4 As String
    Dim dataLine5 As String


    Private Sub Initialisation()
        'Q2.1

        
    End Sub

    'Q2.2
    
    'Q2.3
    

    ' Calculate all totals
    Private Sub CalcRainfallTotals()
        'QUESTION 2.4 - add program code



    End Sub

    'Q2.5



    'Q2.6


    Private Sub InitDataLines()
        headingLine = ""
        dataLine1 = " ".PadRight(1) & "2014:" & " ".PadRight(1)
        dataLine2 = " ".PadRight(1) & "2015:" & " ".PadRight(1)
        dataLine3 = " ".PadRight(1) & "2016:" & " ".PadRight(1)
        dataLine4 = " ".PadRight(1) & "2017:" & " ".PadRight(1)
        dataLine5 = " ".PadRight(1) & "2018:" & " ".PadRight(1)
    End Sub
    Private Sub PrepareDataLines()
        Dim i As Integer
        headingLine = " ".PadRight(7) & "Jan" & " ".PadRight(4) & "Feb" & " ".PadRight(4) & _
        "Mar" & " ".PadRight(4) & "Apr" & " ".PadRight(4) & "May" & " ".PadRight(4) & "Jun"
        i = 0
        Do While (i < sngArr2014Figures.Length)
            dataLine1 = dataLine1 & sngArr2014Figures(i).ToString("N1") & " ".PadRight(3)
            dataLine2 = dataLine2 & sngArr2015Figures(i).ToString("N1") & " ".PadRight(3)
            dataLine3 = dataLine3 & sngArr2016Figures(i).ToString("N1") & " ".PadRight(3)
            dataLine4 = dataLine4 & sngArr2017Figures(i).ToString("N1") & " ".PadRight(3)
            dataLine5 = dataLine5 & sngArr2018Figures(i).ToString("N1") & " ".PadRight(3)
            i = i + 1
        Loop
    End Sub
    Sub DisplayRainfallData()
        Dim drawLine As String = "------------------------------------------------------------" & _
        "--------------------------------------"
        lstDisplayRainfallData.Items.Clear()
        lstDisplayRainfallData.Items.Add(headingLine)
        lstDisplayRainfallData.Items.Add(drawLine)
        lstDisplayRainfallData.Items.Add(dataLine1)
        lstDisplayRainfallData.Items.Add(drawLine)
        lstDisplayRainfallData.Items.Add(dataLine2)
        lstDisplayRainfallData.Items.Add(drawLine)
        lstDisplayRainfallData.Items.Add(dataLine3)
        lstDisplayRainfallData.Items.Add(drawLine)
        lstDisplayRainfallData.Items.Add(dataLine4)
        lstDisplayRainfallData.Items.Add(drawLine)
        lstDisplayRainfallData.Items.Add(dataLine5)
        lstDisplayRainfallData.Items.Add(drawLine)
    End Sub


    Private Sub btnRainfallFigures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRainfallFigures.Click
        TabControl1.SelectedIndex = 0
        Call InitDataLines()
        Call PrepareDataLines()
        Call DisplayRainfallData()
    End Sub


    Sub DisplayStats()
        lbl2006Total.Text = sngArrTotalPerYear(0).ToString("N1") & "mm"
        lbl2007Total.Text = sngArrTotalPerYear(1).ToString("N1") & "mm"
        lbl2008Total.Text = sngArrTotalPerYear(2).ToString("N1") & "mm"
        lbl2009Total.Text = sngArrTotalPerYear(3).ToString("N1") & "mm"
        lbl2010Total.Text = sngArrTotalPerYear(4).ToString("N1") & "mm"
        lblDriestYear.Text = DetermineDriestYear()
        lblWettestMonth.Text = strWettestMonth
        lblAvgRainfall.Text = CalcMonthlyAvgRainfail().ToString("N1") & "mm"
    End Sub
    Private Sub btnRainfallStats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRainfallStats.Click
        TabControl1.SelectedIndex = 1
        Call Initialisation()
        Call CalcRainfallTotals()
        Call DisplayStats()
    End Sub

    Sub ClearAll()
        lstDisplayRainfallData.Items.Clear()
        lbl2006Total.Text = ""
        lbl2007Total.Text = ""
        lbl2008Total.Text = ""
        lbl2009Total.Text = ""
        lbl2010Total.Text = ""
        lblDriestYear.Text = ""
        lblWettestMonth.Text = ""
        lblAvgRainfall.Text = ""
    End Sub

    Private Sub btnClearALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearALL.Click
        Call ClearAll()
    End Sub
End Class