Public Class ForgotPassword
    Private Sub btnClearForgotPassword_Click(sender As Object, e As EventArgs) Handles btnClearForgotPassword.Click
        ' This event handler executes when the user clicks the Clear button and clears the form.

        txtNewPasswordForgotPassword.Clear()
        txtUsernameForgotPassword.Clear()
        txtUsernameForgotPassword.Focus()

    End Sub

    Private Sub btnBackForgotPassword_Click(sender As Object, e As EventArgs) Handles btnBackForgotPassword.Click
        ' This event handler executes when the user clicks the back button and returns the user
        ' to the ParentLogin form.

        ParentLogin.Show()
        Me.Hide()

    End Sub

    Private Sub btnSubmitForgotPassword_Click(sender As Object, e As EventArgs) Handles btnSubmitForgotPassword.Click
        ' This event handler executes when the user clicks the submit button and overwrites the old
        ' password in the access database.

        Dim conn As New System.Data.OleDb.OleDbConnection()
        Dim sql = "SELECT ParentUser FROM tblUserInformation"
        Dim cmd As New System.Data.OleDb.OleDbCommand(sql)
        cmd = New System.Data.OleDb.OleDbCommand(sql, conn)
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\AllowanceTracker1.mdb"
        conn.Open()
        Dim dr As System.Data.OleDb.OleDbDataReader = cmd.ExecuteReader

        If txtUsernameForgotPassword.Text = "" Then
            lblError.Visible = True
            lblError.Text = "Please enter the username whose password you need to change."
            txtUsernameForgotPassword.Focus()

        ElseIf txtNewPasswordForgotPassword.Text = "" Then
            lblError.Visible = True
            lblError.Text = "Please enter the new password."

        Else
            'This is where the change password code goes
            Dim cmdText = "UPDATE tblUserInformation SET ParentPassword = @ParentPassword " &
                      "WHERE ParentUser = @ParentUser AND ParentPassword = @ParentPassword"
            dr.Close()
            Dim cmdUpdate As New System.Data.OleDb.OleDbCommand(cmdText, conn)
            cmdUpdate.Parameters.AddWithValue("@ParentPassword", txtNewPasswordForgotPassword.Text)
            cmdUpdate.Parameters.AddWithValue("@ParentUser", txtUsernameForgotPassword.Text)
            cmdUpdate.ExecuteNonQuery()
            lblError.Text = "Your password has been changed!"
            txtUsernameForgotPassword.Text = ""
            txtNewPasswordForgotPassword.Text = ""

        End If

    End Sub
End Class