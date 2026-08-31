Imports System.IO
Public Class Form1
    '2.1.1 number of candidates and classroom size
    Const intNoOfNominees As Integer = 4
    Const intNoOfClassMembers As Integer = 15
    '2.1.2 data storages
    Dim strCandidates(intNoOfNominees) As String
    Dim strClassRegister() As String
    Dim intVotes() As Integer
    'other variables
    Dim intVotesCount As Integer
    Dim intNomineeCount As Integer
    Dim ReadFile As StreamReader
    Dim total_votes() As Integer = {0, 0, 0, 0}

    ' populate the class list into an array
    Private Sub GenerateRegister()
        Dim counter As Integer
        Try
            ReadFile = New StreamReader("ClassList.txt")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        counter = 0
        While Not ReadFile.EndOfStream
            '2.2 generate a class list
            ReDim Preserve strClassRegister(counter)
            strClassRegister(counter) = ReadFile.ReadLine
            counter = counter + 1
        End While
        ReadFile.Close()
    End Sub

    Private Sub Initialisation()
        intNomineeCount = 0
        intVotesCount = 0
        ProgressBar1.Maximum = 15
        ProgressBar1.Minimum = 0
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnCastVote.Enabled = False
        btnViewResults.Enabled = False
        '2.3.1 invoke the procedue to generate class register
        GenerateRegister()
        '2.3.2 populate the combo box with data from an array
        cboVotersList.Items.Clear()
        For i As Integer = 0 To strClassRegister.Length - 1
            cboVotersList.Items.Add(strClassRegister(i))
        Next
        cboVotersList.SelectedIndex = 0
        Initialisation()
    End Sub
    '2.4 user defined function to check illegibility to stand for elections
    Public Function EligibleToStand(ByVal c_name As String) As Boolean
        Dim status As Boolean
        Dim i As Integer
        ' assuming NOT ilegible to stand for election
        status = False
        i = 0
        Do Until (i > strClassRegister.Length - 1)
            If (c_name = strClassRegister(i)) Then
                status = True
                Exit Do
            End If
            i = i + 1
        Loop
        Return status
    End Function

    Private Sub btnSubmitNominee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitNominee.Click
        Dim NomineeName As String
        Dim nomineeStatus As Boolean
        NomineeName = (txtSurname.Text & " " & txtInitials.Text).ToUpper
        nomineeStatus = EligibleToStand(NomineeName)
        If nomineeStatus = True Then
            If intNomineeCount <= (strCandidates.Length - 1) Then
                '2.5.1 add a nominee to the list
                strCandidates(intNomineeCount) = NomineeName
                intNomineeCount = intNomineeCount + 1
                MessageBox.Show("Nomination recorded successfully!!", "Class Rep Nomination Process", MessageBoxButtons.OK)
                'ClearAll()
                txtSurname.Focus()

                If intNomineeCount = (strCandidates.Length - 1) Then
                    '2.5.2 populate the candidates combo box
                    cboCandidates.Items.Clear()
                    For i As Integer = 0 To intNomineeCount - 1
                        cboCandidates.Items.Add(strCandidates(i))
                    Next

                    cboCandidates.SelectedIndex = 0
                    MsgBox("Maximum number of nominees has been reached.", MsgBoxStyle.Information, "Nomination Process")
                    TabControl1.SelectedIndex = 1
                    gboCandidate.Enabled = False
                    btnSubmitNominee.Enabled = False
                    btnCastVote.Enabled = True
                End If
            Else
                MsgBox("Only FOUR candidates can be nominated.", MsgBoxStyle.Information, "Nomination Process")
            End If
        Else
            MessageBox.Show("Your preferred nominee is NOT a member in this class!!", "Class Rep Nomination Process", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub ClearAll()
        txtSurname.Text = ""
        txtInitials.Text = ""
    End Sub
    Private Function VotesCounting() As Integer
        Dim i As Integer = 0
        Dim total_votes_cast As Integer = 0
        Do Until i > (intVotes.Length - 1)
            Select Case intVotes(i)
                Case 0
                    total_votes(0) = total_votes(0) + 1
                Case 1
                    total_votes(1) = total_votes(1) + 1
                Case 2
                    total_votes(2) = total_votes(2) + 1
                Case 3
                    total_votes(3) = total_votes(3) + 1
                Case Else
                    'do nothing
            End Select
            total_votes_cast = total_votes_cast + 1
            i = i + 1
        Loop
        Return total_votes_cast
    End Function
    Private Sub DisplayResults()
        Dim i As Integer = 0
        ListView1.Items.Clear()
        ListView1.Columns.Clear()
        ListView1.Columns.Add("CANDIDATES", 140, HorizontalAlignment.Left)
        ListView1.Columns.Add("VOTES", 170, HorizontalAlignment.Center)
        Do Until i > (total_votes.Length - 1)
            ListView1.Items.Add(strCandidates(i))
            ListView1.Items(i).SubItems.Add(total_votes(i))
            i = i + 1
        Loop
    End Sub
    Private Sub btnCastVote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCastVote.Click
        If intVotesCount < intNoOfClassMembers Then
            '2.6 record the student vote
            ReDim Preserve intVotes(intVotesCount)
            intVotes(intVotesCount) = cboCandidates.SelectedIndex
            intVotesCount = intVotesCount + 1
            cboVotersList.Items.RemoveAt(cboVotersList.SelectedIndex)

            ProgressBar1.Value = intVotesCount
            lblPercentage.Text = ((ProgressBar1.Value / strClassRegister.Length) * 100).ToString("N1") & "% of votes counted."
            If intVotesCount = intNoOfClassMembers Then
                cboVotersList.Enabled = False
                cboCandidates.Enabled = False
                btnViewResults.Enabled = True
            Else
                cboVotersList.SelectedIndex = 0
            End If
        Else
            'do nothing
        End If
    End Sub

    Private Sub btnViewResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewResults.Click
        lblTotalVotesCast.Text = VotesCounting()
        DisplayResults()
        btnViewResults.Enabled = False
    End Sub

    
End Class
