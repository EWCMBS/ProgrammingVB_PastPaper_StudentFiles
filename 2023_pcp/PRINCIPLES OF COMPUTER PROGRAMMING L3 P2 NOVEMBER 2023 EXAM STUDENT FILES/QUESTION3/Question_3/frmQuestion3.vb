REM EXAMINATION NUMBER:____________
REM WORKSTATION NUMBER:____________
REM EXAMINATION   DATE:____________

Option Explicit On
Option Strict On

Public Class frmQuestion3
    '--
    ' Question 3.1 - declare single dimension array
    '---

    '--
    ' Question 3.2 - declare all required variables
    '---
   


    Private Sub frmQuestion2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        ' initialise variables - set it to their default values
        '


    End Sub
    '--
    '-- CLOSE PROGRAM
    '---
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_KL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd_KL.Click
        '--
        ' Question 3.3.1 - validate kilo litre input - is it empty?
        '--
       

        '--
        ' Question 3.3.2 - check if list is full
        '--

        

        '--
        ' Question 3.3.3 - display the entered value in the listbox, clear the kilolitre text field
        '--
       

    End Sub

    Private Sub btnClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearList.Click
       
    End Sub

    Private Sub btnComputeValues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComputeValues.Click
        '--
        ' Question 3.4.1 - Check if the list is VALID i.e. 5 values are available
        '--




        
        '---
        ' Question 3.4.2 - use a loop to find the highest KiloLitres, TotalKLs, day on which highest KLs were consumed 
        '---
       





        '--
        ' Question 3.4.3 - calculate total cost for the tot kilolitres used; average cost; average kilo litres used; 
        '                  highest cost for kilo litres consumed in a day
        '---





        '--
        ' Question 3.4.5 - display all the calculated values in the list view
        '----





    End Sub

    Private Sub lstAnalysis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAnalysis.SelectedIndexChanged

    End Sub
End Class
