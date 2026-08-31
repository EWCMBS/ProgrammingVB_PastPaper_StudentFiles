REM EXAMINATION NUMBER:____________
REM WORKSTATION NUMBER:____________
REM EXAMINATION   DATE:____________

Option Explicit On
Option Strict On

Public Class frmQuestion2

    Private Sub btnClearInstallments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearInstallments.Click
        '--
        ' Question 2.1 - clear all the installment plan items that were selected
        '----


        ' do not remove this line!!
        cmbPaymentPeriod.SelectedItem = "3"
    End Sub

    Private Sub frmQuestion1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbPaymentPeriod.SelectedItem = "3"
    End Sub

    Private Sub btnCalcPaymentPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcPaymentPlan.Click
        '--
        '  Question 2.2.1 - declare all variables
        '--
        





        '--
        ' Question 2.2.2 - convert input values to proper numeric values
        '---
      

        '---
        ' Question 2.2.3 - start select case to claculate instalments and show it in list box
        '----







    End Sub

End Class
