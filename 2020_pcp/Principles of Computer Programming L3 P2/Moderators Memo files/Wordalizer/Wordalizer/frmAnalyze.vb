Option Explicit On
Option Strict On

Imports System.IO


'INSERT EXAMINATION NUMBER HERE

Public Class frmAnalyze

    'String variable for a message
    Private strMessage As String = "Enter a string"

    'Q1.1
    'Declare a variable for the input
    Dim strInputString As String = ""

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
        txtInput.Clear()

        'Q1.2.2
        'Activate timer to display a message inside textbox
        tmrMessage.Enabled = True

        'By default select the Vowel radio button
        radVowels.Checked = True

    End Sub

    'Q1.3
    'User defined function to determine the number of vowels 
    'Q1.3.1
    Private Function CountVowel(ByRef InputString As String) As Integer
        'Q1.3.2
        'Decalre a counter variable
        Dim Count As Integer = 0

        'Q1.3.3
        '(a)
        For Each letter As Char In InputString
            '(b)
            Select Case letter
                Case CChar("a")
                    '(c)
                    Count += 1
                Case CChar("e")
                    Count += 1
                Case CChar("i")
                    Count += 1
                Case CChar("o")
                    Count += 1
                Case CChar("u")
                    Count += 1
            End Select
        Next
        'Q1.3.4
        Return Count
    End Function

    'Q1.4
    'User defined function procedure
    Private Function CalcConsonant(ByVal VowelCount As Integer, ByVal WordCount As Integer) As Integer
        Return WordCount - VowelCount
    End Function

    'Q1.5
    Private Sub chkBoth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBoth.CheckedChanged
        'Q1.5.1
        If chkBoth.Checked = True Then
            '(a)
            radVowels.Checked = False
            radConsonants.Checked = False
            radVowels.Enabled = False
            radConsonants.Enabled = False
        ElseIf chkBoth.Checked = False Then
            '(b)
            radVowels.Enabled = True
            radConsonants.Enabled = True
        End If
    End Sub

    'Q1.6
    Private Sub btnAnalyse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalyse.Click

        'Q1.6.1
        'Validate if text or not
        If Integer.TryParse(txtInput.Text, 0) = True Then
            MessageBox.Show("String input only", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtInput.Focus()
            Exit Sub
        End If


        'OR
        If IsNumeric(txtInput.Text) = True Then
            MessageBox.Show("String input only", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtInput.Focus()
            Exit Sub
        End If

        'OR
        If Double.TryParse(txtInput.Text, 0D) = True Then
            MessageBox.Show("String input only", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtInput.Focus()
            Exit Sub
        End If

        'Q1.6.2
        'Assign textbox to variable, in lowercase with no spaces
        strInputString = LCase(txtInput.Text.Replace(" ", ""))

        'Q1.6.4
        Call Display()

    End Sub

    'Q1.7
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Q1.7.1
        Try
            'Q1.7.2
            Using SaveToFile As StreamWriter = New StreamWriter("Results.txt")

                'Q1.7.3
                For i As Integer = 0 To (lstAnalysis.Items.Count - 1)

                    SaveToFile.WriteLine(lstAnalysis.Items.Item(i))

                Next

                'Q1.7.4
                MessageBox.Show("The file has been saved", "File Saved.", MessageBoxButtons.OK)

            End Using
        Catch ex As Exception
            '(a)
            'Alert user with a pop up dialog box
            MessageBox.Show(ex.Message, "Error")
            '(b)
            Call ResetInterface()
            '(c)
            Exit Sub
        End Try
    End Sub

    'Q1.8
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ResetInterface()
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
