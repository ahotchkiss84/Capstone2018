Public Class ParentLogin
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmitParentLogin.Click
        ' This event handler executes when the user clicks the Submit button. It checks the
        ' database to verify the entered username and password.

        If txtUsernameParentLogin.Text = "" Then
            lblErrorParentLogin.Visible = True
            lblErrorParentLogin.Text = "Please enter the username."
            txtUsernameParentLogin.Focus()
        ElseIf txtPasswordParentLogin.Text = "" Then
            lblErrorParentLogin.Visible = True
            lblErrorParentLogin.Text = "Please enter the password."
            txtPasswordParentLogin.Focus()

        Else
            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\AllowanceTracker1.mdb"
            Try
                Dim sql As String = "SELECT * FROM tblUserInformation WHERE ParentUser='" & txtUsernameParentLogin.Text & "' AND ParentPassword = '" & txtPasswordParentLogin.Text & "'"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

                sqlCom.Connection = conn
                conn.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()
                If sqlRead.Read() Then
                    txtPasswordParentLogin.Text = ""
                    txtUsernameParentLogin.Text = ""
                    ParentMain.Show()
                    Me.Hide()
                Else

                    ' If user enter wrong username and password combination
                    ' Throw an error message
                    lblErrorParentLogin.Text = "Username and Password do not match."

                    'Clear all fields
                    txtUsernameParentLogin.Text = ""
                    txtPasswordParentLogin.Text = ""

                    'Focus on Username field
                    txtUsernameParentLogin.Focus()
                End If

            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClearParentLogin.Click
        ' This event handler executes when the user clicks the Clear button. It clears the form

        txtUsernameParentLogin.Clear()
        txtPasswordParentLogin.Clear()
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPasswordParentLogin.Click
        ' This event handler executes when the user clicks the Forgot Password button and opens
        ' the ForgotPassword form.
        ForgotPassword.Show()
        Me.Hide()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBackParentLogin.Click
        ' This code executes when the user clicks the Back button and returns the user
        ' to the Parents.vb screen.

        Parents.Show()
        Me.Hide()

    End Sub
End Class