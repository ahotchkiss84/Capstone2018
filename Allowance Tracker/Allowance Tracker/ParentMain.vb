Public Class ParentMain
    Private Sub btnNewChild_Click(sender As Object, e As EventArgs) Handles btnNewChild.Click
        ' This code executes when the user clicks on the New Child Account button and
        ' displays the register child form

        RegisterChild.Show()
        Me.Close()

    End Sub

    Private Sub btnTrackAllowance_Click(sender As Object, e As EventArgs) Handles btnTrackAllowance.Click
        ' This code executes when the user clicks on the Track Allowance button and
        ' takes the user to the Track Allowance screen.

        TrackAllowance.Show()
        Me.Close()

    End Sub

    Private Sub btnTrackPurchase_Click(sender As Object, e As EventArgs) Handles btnTrackPurchase.Click
        ' This code executes when the user clicks on the Track Purchase button and takes
        ' the user to the Track Purchase screen.

        TrackPurchases.Show()
        Me.Close()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHomeParentMain.Click
        ' This code executes when the user clicks on the Home button and
        ' returns the user to the Main screen.

        Main.Show()
        Me.Close()

    End Sub
End Class