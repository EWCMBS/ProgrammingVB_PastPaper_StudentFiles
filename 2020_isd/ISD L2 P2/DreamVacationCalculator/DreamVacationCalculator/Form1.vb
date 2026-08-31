O
Public Class Form1
    'Declare global variables
    Dim intNoDays As Integer
    Dim intSizeGroup As Integer
    Const decAccommodationpp As Decimal = 80.0
    Const DecTrasportCostpp As Decimal = 10.0
    Const decExtLevy As Decimal = 0.15

    Dim decAccommodationCost As Decimal
    Dim decTrasportCost As Decimal
    Dim decTotalCost As Decimal
    Dim decLevy As Decimal
    Dim decTotalDue As Decimal


    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Assign values of textbox to variables
        intNoDays = txtNofDay.Text
        intSizeGroup = txtSizeGroup.Text
        'calculate accommodation cost
        decAccommodationCost =
        'calculate trasport cost
        decTrasportCost = 
        'calculate totalcost 
        decTotalCost = decAccommodationCost + decTrasportCost
        'determine size of group greater than  six
        If intSizeGroup = 6 Then
            'calculate extra levy charge
            decLevy = 
        End If
        'calcculate totaldue for the vacation including levy

        'display accommodation cost, transport cost, levy cost and totaldue 
        lblDisplayAccommodationCost.Size = decAccommodationCost.ToString("c2")

        lblDisplayTransCost.Text = decTrasportCost.ToString("c2")

        lblDisplayLevy.Text = decLevy.ToString("c2")
        lblDisplayTotalCost.Text = decTotalDue.ToString("c2")

        clearContent()
    End Sub
    Sub clearContent()
        txtNofDay.Text = ""
        txtNofDay.Focus()
        txtSizeGroup.Text = ("")
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Exit program
        Dim intAnswer As Integer
        intAnswer = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If intAnswer = vbYes Then
            Me.Close()
        End If


End Class
