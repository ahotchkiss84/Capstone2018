Public Class Parents
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegisterParent.Click
        ' This code executes when the user clicks on the Register button and takes
        ' the user to the Parent Registration page.

        ParentRegistration.Show()
        Me.Close()

    End Sub

    Private Sub btnParentLogin_Click(sender As Object, e As EventArgs) Handles btnParentLogin.Click
        ' This code executes when the user clicks on the Login button and takes
        ' the user to the Parent Login page.

        ParentLogin.Show()
        Me.Close()

    End Sub

    Private Sub btnReturnHome_Click(sender As Object, e As EventArgs) Handles btnHomeParent.Click
        ' This code executes when the user clicks the Home button.
        ' Returns the user to Main.vb

        Main.Show()
        Me.Close()

    End Sub

    Private Sub Parents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Bounds = Main.Bounds

    End Sub
End Class