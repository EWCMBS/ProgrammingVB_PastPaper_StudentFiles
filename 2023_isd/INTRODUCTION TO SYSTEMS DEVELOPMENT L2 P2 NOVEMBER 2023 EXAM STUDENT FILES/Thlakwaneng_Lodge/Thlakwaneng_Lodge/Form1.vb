
'Examination number
Public Class Form1

    Dim intInitialPrice As Integer

    Private Sub cmbRooms_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRooms.SelectedIndexChanged
    
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim strFullName As String
        Dim strContact As String
        Dim checkinDate As Date
        Dim checkoutDate As Date
        Dim dateDifference As System.TimeSpan
        Dim noOfNights As Integer
        Dim decAmount As Decimal

        checkinDate = DateTimePicker1.Value

        dateDifference = checkoutDate.Subtract(checkinDate)
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
      
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

    End Sub

End Class
