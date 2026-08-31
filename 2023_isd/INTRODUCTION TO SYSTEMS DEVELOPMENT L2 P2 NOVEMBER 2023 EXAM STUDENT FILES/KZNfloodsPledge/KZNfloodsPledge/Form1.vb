Option Strict On

'Examination number
Public Class Form1

    Dim strName As String
    Dim strSurname As String
    Dim strContact As String
    Dim strAddress As String
    Dim dDate As Date
    Dim intDonationAmount As Integer
    Dim strCurrency As String
    Dim decCurrencyRate As Decimal
    Dim decAmountConverted As Decimal

    Private Sub cmbCurrency_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCurrency.SelectedIndexChanged

        If cmbCurrency.SelectedIndex = 0 Then
           
        ElseIf cmbCurrency.SelectedIndex = 1 Then
            
        ElseIf cmbCurrency.SelectedIndex = 2 Then
           
        Else
            
        End If

    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        If chkConfirm.Checked = False Then
            MessageBox.Show("Please agree and confirm", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information)
            chkConfirm.Select()
            Exit Sub
        End If

        strName = txtNames.Text
        strSurname = txtSurname.Text
        strContact = txtContactNo.Text

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
       
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Exit the program", "Terminate", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub

End Class
