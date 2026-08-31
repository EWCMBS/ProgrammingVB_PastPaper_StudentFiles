Option Explicit On
Option Strict On

Imports System.IO

'INSERT EXAMINATION NUMBER HERE

Public Class Form1



    'Q2.1.1 number of candidates and classroom size
    
    'Q2.1.2 data storages
   
	
	'Q2.1.3
   
   
    'other variables
    Dim intVotesCount As Integer
    Dim intNomineeCount As Integer
    Dim reader As StreamReader
    Dim total_votes() As Integer = {0, 0, 0, 0}

    ' populate the class list into an array
    Private Sub GenerateRegister()
        Dim counter As Integer
        Try
            reader = New StreamReader("ClassList.txt")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        counter = 0
        While Not reader.EndOfStream
            'Q2.2.1 generate a class list
           
			
			'Q2.2.2
            
			
			'Increment counter
            counter = counter + 1
        End While
        reader.Close()
    End Sub

    Private Sub Initialisation()
        intNomineeCount = 0
        intVotesCount = 0
        ProgressBar1.Maximum = 15
        ProgressBar1.Minimum = 0
    End Sub
	
    Private Sub frmClassRep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
		btnCastVote.Enabled = False
        btnViewResults.Enabled = False
		
        'Q2.3.1 invoke the procedue to generate class register
        
		
		'Clear the combo box
        cboVotersList.Items.Clear()
		
		'Q2.3.2 populate the combo box with data from an array
        
		
		'Select first item
        cboVotersList.SelectedIndex = 0
		'Call initialise
        Call Initialisation()
    End Sub
	
	
    'Q2.4 user defined function to check illegibility to stand for elections
    
	
	
	
    Private Sub btnSubmitNominee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitNominee.Click
       
        Dim NomineeName As String
        Dim nomineeStatus As Boolean
        NomineeName = (txtSurname.Text & " " & txtInitials.Text).ToUpper
        nomineeStatus = EligibleToStand(NomineeName)

        If nomineeStatus = True Then
            If intNomineeCount <= (strCandidates.Length - 1) Then
                
				'Q2.5.1 add a nominee to the list
                
                
				'
				ClearAll()
                txtSurname.Focus()
                
				If intNomineeCount = (strCandidates.Length - 1) Then
                    
                    cboCandidates.Items.Clear()
					
					'Q2.5.2 populate the candidates combo box
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
	
	Private Sub btnCastVote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCastVote.Click
        
		If intVotesCount < intNoOfClassMembers Then
        
		    ReDim Preserve intVotes(intVotesCount)
			'Q2.6 record the student vote
			
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
	


    Private Sub btnViewResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewResults.Click
        lblTotalVotesCast.Text = VotesCounting()
        DisplayResults()
        btnViewResults.Enabled = False
    End Sub
End Class
