Public Class ParentRegistration
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmitParentReg.Click
        ' Stores the information entered by the user in the access database

        If txtParentNameReg.Text = "" Then
            lblErrorParentReg.Visible = True
            lblErrorParentReg.Text = "Please enter a name."
            txtParentNameReg.Focus()

        ElseIf txtUsernameParentReg.Text = "" Then
            lblErrorParentReg.Visible = True
            lblErrorParentReg.Text = "Please enter a username."
            txtUsernameParentReg.Focus()

        ElseIf txtPasswordParentReg.Text = "" Then
            lblErrorParentReg.Visible = True
            lblErrorParentReg.Text = "Please enter a password."
            txtPasswordParentReg.Focus()

        Else

            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblUserInformation (ParentName,ParentUser,ParentPassword) VALUES (@ParentName,@ParentUser,@ParentPassword)"

                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@ParentName", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtParentNameReg.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@ParentUser", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtUsernameParentReg.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@ParentPassword", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtPasswordParentReg.Text))

                cm.Parameters("@ParentName").Value = Me.txtParentNameReg.Text
                cm.Parameters("@ParentUser").Value = Me.txtUsernameParentReg.Text
                cm.Parameters("@ParentPassword").Value = Me.txtPasswordParentReg.Text

                cm.ExecuteNonQuery()
                lblErrorParentReg.Visible = True
                lblErrorParentReg.Text = "Registration Complete!"

                Me.txtParentNameReg.Text = ""
                Me.txtUsernameParentReg.Text = ""
                Me.txtPasswordParentReg.Text = ""
                Exit Sub
            End With
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClearParentReg.Click
        ' Clears the form

        txtParentNameReg.Text = ""
        txtUsernameParentReg.Text = ""
        txtPasswordParentReg.Text = ""
        lblErrorParentReg.Text = ""
        txtParentNameReg.Focus()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBackParentReg.Click
        ' This code executes when the user clicks the Back button
        ' and returns the user to the Parents.vb screen.

        Parents.Show()
        Me.Hide()

    End Sub

    Private Sub ParentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Calls the connection method for the access database

        Call connection()

    End Sub
End Class