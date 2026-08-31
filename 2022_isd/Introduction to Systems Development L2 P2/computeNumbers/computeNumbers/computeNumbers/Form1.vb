Option Strict On
Option Explicit On
Public Class Form1
    Dim intFirstNumber As Integer
    Dim intSecondNumber As Integer
    Dim intHighestNumber As Integer
    Dim decDivision As Decimal
    Dim intRemainder As Integer
    Dim decAverage As Decimal

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstDisplay.Items.Add("Summary calculations")
        lstDisplay.Items.Add("---------------------------------------------------")
        lstDisplay.Items.Add("")
    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
          
    End Sub
   
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim i As Integer

        For i = 3 To lstDisplay.Items.Count - 1
            lstDisplay.Items.RemoveAt(lstDisplay.Items.Count - 1)
        Next
      
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Do you want to exit the program", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

        End If
    End Sub
End Class
