Option Explicit On
Option Strict On

Imports System.IO


'INSERT EXAMINATION NUMBER HERE

Public Class frmAnalyze

    'String variable for a message
    Private strMessage As String = "Enter a string"

    'Q1.1
    'Declare a variable for the input


    Private Sub tmrMessage_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMessage.Tick
        txtInput.Text += strMessage.Substring(txtInput.Text.Length, 1)
        If txtInput.Text = strMessage Then
            txtInput.Text = strMessage
            tmrMessage.Enabled = False
            txtInput.SelectAll()
        End If
    End Sub


    Private Sub frmAnalyze_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Q1.2.1
        'Clear the text box using a method


        'Q1.2.2
        'Activate timer to display a message inside textbox


        'By default select the Vowel radio button
        radVowels.Checked = True

    End Sub

    'Q1.3
    'User defined function to determine the number of vowels 
    'Q1.3.1

    'Q1.3.2
    'Declare a counter variable


    'Q1.3.3
    '(a)

    '(b)


    '(c)


    'Q1.3.4



    'Q1.4
    'User defined function procedure


    'Q1.5
    Private Sub chkBoth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBoth.CheckedChanged
        'Q1.5.1
        
    End Sub

    'Q1.6
    Private Sub btnAnalyse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalyse.Click

        'Q1.6.1
        'Validate if text or not
        

        'Q1.6.2
        'Assign textbox to variable, in lowercase with no spaces


        'Q1.6.3
        'Invoke sub procedure



    End Sub

    'Q1.7
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

       

    End Sub

    'Q1.8
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

    End Sub

    Private Sub Display()

        If radVowels.Checked = True Then
            lstAnalysis.Items.Clear()
            lstAnalysis.Items.Add("********************************")
            lstAnalysis.Items.Add("Input String: " & txtInput.Text)
            lstAnalysis.Items.Add("")
            lstAnalysis.Items.Add("Total Word Count: " & strInputString.Length)
            lstAnalysis.Items.Add("")
            lstAnalysis.Items.Add("Vowel Count: " & CountVowel(strInputString))

        ElseIf radConsonants.Checked = True Then
            lstAnalysis.Items.Clear()
            lstAnalysis.Items.Add("********************************")
            lstAnalysis.Items.Add("Input String: " & txtInput.Text)
            lstAnalysis.Items.Add("")
            lstAnalysis.Items.Add("Total Word Count: " & strInputString.Length)
            lstAnalysis.Items.Add("")
            lstAnalysis.Items.Add("Consonant Count: " & CalcConsonant(CountVowel(strInputString), strInputString.Length))

        ElseIf chkBoth.Checked = True Then

            lstAnalysis.Items.Clear()
            lstAnalysis.Items.Add("********************************")
            lstAnalysis.Items.Add("Input String: " & txtInput.Text)
            lstAnalysis.Items.Add("")
            lstAnalysis.Items.Add("Total Word Count: " & strInputString.Length)
            lstAnalysis.Items.Add("")
            lstAnalysis.Items.Add("Vowel Count: " & CountVowel(strInputString))
            lstAnalysis.Items.Add("")
            lstAnalysis.Items.Add("Consonant Count: " & CalcConsonant(CountVowel(strInputString), strInputString.Length))


        End If
    End Sub

    Private Sub ResetInterface()
        txtInput.Text = vbNullString
        radConsonants.Checked = False
        radVowels.Checked = False
        chkBoth.Checked = False
        lstAnalysis.Items.Clear()

    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Do you want to exit the application?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then Application.Exit()
    End Sub

End Class
