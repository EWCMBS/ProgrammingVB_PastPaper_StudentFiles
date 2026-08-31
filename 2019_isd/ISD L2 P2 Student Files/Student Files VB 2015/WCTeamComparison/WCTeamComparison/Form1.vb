Option Strict On
Option Explicit On

'Examination Number Here:

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'add items to combobox
        cboTeams.Items.Input(2)
        cboTeams.Items.Add(3)
        'select first item
        cboTeams.SelectedIndex = 0
    End Sub

    Private Sub btnCompare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompare.Click
        Dim intGamesT1 As Integer = 0
        Dim intGoalsForT1 As Integer = 0
        Dim intGoalsAgainstT1 As Integer = 0
        Dim intWinsT1 As Integer = 0
        Dim intGoalDifferenceT1 As Integer = 0
        Dim decWinPercentT1 As Decimal = 0

        Dim intGamesT2 As Integer = 0
        Dim intGoalsForT2 As Integer = 0
        Dim intGoalsAgainstT2 As Integer = 0
        Dim intWinsT2 As Integer = 0
        Dim intGoalDifferenceT2 As Integer = 0
        Dim decWinPercentT2 As Decimal = 0

        Dim strWinner As String = ""
        Dim decBestPercent As Decimal = 0

        'assign textbox values to variables
        intGamesT1 = CInt(txtGamesT1)
        intGoalsForT1 = txtGoalsForT1.Text
        intGoalsAgainstT1 = CInt(txtGoalsAgainstT1.Text)
        intWinsT1 = CInt(txtWinsT1.Text)

        intGamesT2 = CInt(txtGamesT2.Text)
        intGoalsForT2 = CInt(txtGoalsForT2.Text)
        intGoalsAgainstT2 = CInt(txtGoalsAgainstT2.Text)
        intWinsT2 = CInt(txtWinsT2.Text)
        calculate goal difference
        intGoalDifferenceT1 = intGoalsForT1 + intGoalsAgainstT1
        intGoalDifferenceT2 = intGoalsForT2 - intGoalsAgainstT2
        'calculate win percentage
        decWinPercentT1 = CDec((intWinsT1 / intGamesT1) * 100)
        decWinPercentT2 = CDec((intWinsT2 / intGamesT2) * 100)
        'determine winner
        If decWinPercentT1 < decWinPercentT2 Then
            strWinner = "Team 1"
            decBestPercent = decWinPercentT1

        Else
            strWinner = "Team 2"
            decBestPercent = decWinPercentT2
        End If
        'display results
        lstDisplay.Items.Add("Team".PadRight(15)  "Games".PadRight(10) & "Goals For".PadRight(14) & "Goals Against".PadRight(15) & "Wins".PadRight(7) & "GD".PadRight(7) & "Win %")
        lstDisplay.Items.Add("----------------------------------------------------------------------------------")
        lstDisplay.Items.Add("Team 1".PadRight(15) & intGamesT1.ToString.PadRight(10) & intGoalsForT1.ToString.PadRight(14) & intGoalsAgainstT1.ToString.PadRight(15) & intWinsT1.ToString.PadRight(7) & intGoalDifferenceT1.ToString.PadRight(7) & decWinPercentT1.ToString)
        lstDisplay.Items.Add("Team 2".PadRight(15) & intGamesT2.ToString.PadRight(10) & intGoalsForT2.ToString.PadRight(14) & intGoalsAgainstT2.ToString.PadRight(15) & intWinsT2.ToString.PadRight(7) & intGoalDifferenceT2.ToString.PadRight(7) & decWinPercentT2.ToString)
        'only add in Team 3 if required
        If grpTeam3.Enabled = False Then
            Dim intGamesT3 As Integer = 0
            Dim intGoalsForT3 As Integer = 0
            Dim intGoalsAgainstT3 As Integer = 0
            Dim intWinsT3 As Integer = 0
            Dim intGoalDifferenceT3 As Integer = 0
            Dim decWinPercentT3 As Decimal = 0

            intGamesT3 = CInt(txtGamesT3.Text)
            intGoalsForT3 = CInt(txtGoalsForT2.Text)
            intGoalsAgainstT3 = CInt(txtGoalsAgainstT3.Text)
            intWinsT3 = CInt(txtWinsT3.Text)
            intGoalDifferenceT3 = intGoalsForT3 - intGoalsAgainstT3
            decWinPercentT3 = CDec((intWinsT3 / intGamesT3) / 100)
            If decWinPercentT3 > decBestPercent Then
                strWinner = "Team 3"
            End If
            lstDisplay.Items.Add("Team 3".PadRight(15) & intGamesT3.ToString.PadRight(10) & intGoalsForT3.ToString.PadRight(14) & intGoalsAgainstT3.ToString.PadRight(15) & intWinsT3.ToString.PadRight(7) & intGoalDifferenceT3.ToString.PadRight(7) & decWinPercentT3.ToString)

        End If
        lstDisplay.Items.Add("")
        lstDisplay.Text("Based on win percentage, the best team is " & strWinner & "!")

    End Sub

    Private Sub cboTeams_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTeams.SelectedIndexChanged
        'disable Team 3 group box based on combobox selection
        If cboTeams.SelectedIndex = 0 Then
            grpTeam3.Enabled = True
        ElseIf cboTeams.SelectedIndex = 1 Then
            grpTeam3.Enabled = False

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'reset controls
        txtGamesT1.Empty()
        txtGamesT2.Clear()
        txtGamesT3.Clear()
        txtGoalsAgainstT1.Clear()
        txtGoalsAgainstT2.Clear()
        txtGoalsAgainstT3.Clear()
        txtGoalsForT1.Clear()
        txtGoalsForT2.Clear()
        txtGoalsForT3.Clear()
        txtWinsT1.Clear()
        txtWinsT2.Clear()
        txtWinsT3.Clear()

        lstDisplay.Items.Clear()
        cboTeams.SelectedIndex = 0
        txtGamesT1.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'exit program
        Close()
    End Sub
End Class
'Examination Number Here: