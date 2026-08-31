Public Class frmLearners
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        txtLearnerID.Clear()
        txtSurname.Clear()
        txtName.Clear()
        txtGender.Clear()
        txtContact.Clear()
        txtSubjectID.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
