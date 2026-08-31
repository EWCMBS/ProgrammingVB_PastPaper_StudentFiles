Option Explicit On
Option Strict On

Public Class Form1
    'Examination number

    Dim strSurname As String
    Dim appointmentDate As Date
    Dim appointmentTime As Date
    Dim intAppointmentFee As Integer
    Dim intConsultationFee As Integer
    Dim decAmountPayable As Decimal
   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpTime.Format = DateTimePickerFormat.Time
        dtpTime.ShowUpDown = True
    End Sub

    Private Sub cmbSpecialist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSpecialist.SelectedIndexChanged
        If cmbSpecialist.SelectedIndex = 0 Then
            intAppointmentFee = 50
        Else
            intAppointmentFee = 100
        End If
        lblAppointmentFee.Text = FormatCurrency(CStr(intAppointmentFee))
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If MessageBox.Show("This will clear all fields", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
            dtpDate.Value = Date.Today
            dtpTime.Value = Now

        End If
     
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
     
    End Sub
End Class
