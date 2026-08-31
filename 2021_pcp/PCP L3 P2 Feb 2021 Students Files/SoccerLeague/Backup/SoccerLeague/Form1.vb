Option Explicit On
Option Strict On
Imports System.IO
Public Class Form1
    ' ***************************************
    ' COMPUTER NUMBER    :
    ' EXAMINATION NUMBER :
    '****************************************

    Dim strMonths() As String = {"", "January", "February", "March", "April", "May", "June", _
                                "July", "August", "September", "October", "December"}
    Private Sub PopulateComboBox()
        Dim reader As StreamReader
        '1.1 populate the combo box with content of text file


        reader.Close()
    End Sub
    Private Sub frmRussia2018_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '1.2 invoke the subroutine and set first item in the combo box
        

        lblDate.Text = "Date: " & strMonths(Today.Month) & " " & Today.Day.ToString & ", " & Today.Year.ToString
    End Sub
    ' 1.6 sub procedure to calculate the Passing Rate of a player
    

    '1.7 sub procedure to calculate the Striking rate of a player

   
        
        
       



    ' display the output
    Sub DisplayPerformanceRate(ByVal rate As Single, ByVal msg As String)
        'disply player's details
        lblPlayerName.Text = "Player Name: " & txtPlayerName.Text
        lblTeamName.Text = "Team Name: " & txtTeamName.Text
        lblPerformance.Text = msg & rate.ToString("N2") & "%"
    End Sub
    Private Sub btnCalcPerformance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcPerformance.Click
        Dim sngPerformanceRate As Single

        '1.8 calling procedures and functions to perform
       
       
        
    End Sub

    Private Sub btnNextPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextPlayer.Click
        ClearControls()
    End Sub
    ' 1.3 sub procedure to reset ALL labels and text boxes




    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '1.4 disable or enable a textbox depending on the value parameter received.

    Private Sub cboPosition_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPosition.SelectedIndexChanged
        '1.5 invoke the subprocedure with appropriate arguments
       


    End Sub
End Class
