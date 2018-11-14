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

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This code executes on startup and creates the database if it does not exist.

        If Not IO.File.Exists(Application.CommonAppDataPath & "\AllowanceTracker.mdb") Then
            IO.File.WriteAllBytes(Application.CommonAppDataPath & "\AllowanceTracker.mdb", My.Resources.AllowanceTracker)
        End If
    End Sub
End Class
