Public Class frmShoppingList
    'declare variables 
    DimstrItem As String
    Dim decPrice As Decimal
    Dim decTotalPrice As Decimal

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateList.Click
        'create for loop to run until the user enter E for exit 
        lstShoppingList.Items.("ITEM NAME" & vbTab & "PRICE:")
        For  = 1 To 5
            strItem = InputBox("Please enter Item Name:", "Item Name")
            If (strItem = "X") Then 'Determine that E is entered and exit the loop
                Exit 

            End If
            'determine that the user enters a number for an item price
            If Decimal.TryParse(InputBox("Please enter  Item Price", "Item Price"), ) Then


                lstShoppingList.Items.Add(strItem & vbTab & " " & vbTab & decPrice.ToString("c"))
                decTotalPrice = decPrice - decTotalPrice
            End If

        Next
        lstShoppingList.Items.Add(===================")
        lstShoppingList.("TOTAL PRICE = " & .ToString("c"))

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        .Items.Clear()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Exit program
        'Dim userAnswer As String
        userAnswer = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If userAnswer = vbNo Then
            Me.Close()
        End If


End Class
