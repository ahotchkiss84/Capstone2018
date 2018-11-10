Public Class KidMain
    Private Sub btnReturnHomeKid_Click(sender As Object, e As EventArgs) Handles btnReturnHomeKid.Click
        ' This code executes when the user clicks the Return Home button and 
        ' returns the user to the Main screen

        Main.Show()
        Me.Hide()

    End Sub

    Private Sub btnCheckAllowanceBalance_Click(sender As Object, e As EventArgs) Handles btnCheckAllowanceBalance.Click
        ' This code executes when the user clicks the Check Allowance Balance button and
        ' takes the user to the View Allowance screen.

        ViewAllowance.Show()
        Me.Hide()

    End Sub

    Private Sub btnCheckPurchaseHistory_Click(sender As Object, e As EventArgs) Handles btnCheckPurchaseHistory.Click
        ' This code executes when the user clicks the Check Purchase History button and
        ' takes the user to the View Purchases screen.

        ViewPurchases.Show()
        Me.Hide()

    End Sub
End Class