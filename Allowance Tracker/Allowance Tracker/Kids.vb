﻿Public Class Kids
    Private Sub btnKidLogin_Click(sender As Object, e As EventArgs) Handles btnLoginKid.Click
        ' This code executes when a user clicks the Login button.
        ' Takes the user to the kids login screen.

        KidLogin.Show()
        Me.Hide()

    End Sub

    Private Sub btnReturnHome_Click(sender As Object, e As EventArgs) Handles btnHomeKid.Click
        ' This code executes when a user clicks the Home button.
        ' Returns the user to the main screen.

        Main.Show()
        Me.Hide()

    End Sub
End Class