Public Class FunFit_Form
    ' Question 1.2.1


    Private Sub bntcalculcate_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles btnCalculcate.Click

        ' Question 1.2.1


        ' Question 1.2.2


        ' Question 1.2.3


        ' Question 1.2.4
       


        ' Question 1.3 .... This is a Printout of screen form

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnExit.Click
        '' Close program - Given to code
        Application.Exit()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, _
 ByVal e As System.EventArgs) Handles btnClear.Click
        'Code given
        lblAvgDist.Text = ""
        lblBestSession.Text = ""
        lblTotalTime.Text = ""
        lblTotdistance.Text = ""
        lblBestSession.Text = ""
        txtDistanceWk1.Text = "0"
        txtDistanceWk2.Text = "0"
        txtTimeWk1.Text = "0"
        txtTimeWk2.Text = "0"
        txtDistanceWk1.Focus()
    End Sub

End Class
