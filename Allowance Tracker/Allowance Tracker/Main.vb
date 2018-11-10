Public Class Main
    Private Sub btnParents_Click(sender As Object, e As EventArgs) Handles btnParentsHome.Click
        ' This code executes when the user clicks the Parent button on the main form. 
        ' It opens the Parents.vb form.

        Parents.Show()
        Me.Hide()

    End Sub

    Private Sub btnKids_Click(sender As Object, e As EventArgs) Handles btnKidsHome.Click
        ' This code executes when the user clicks the Kid button on the main form.
        ' It opens the Kids.vb form.

        Kids.Show()
        Me.Hide()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExitHome.Click
        ' This code executes when the user clicks the Exit button

        Close()

    End Sub
End Class
