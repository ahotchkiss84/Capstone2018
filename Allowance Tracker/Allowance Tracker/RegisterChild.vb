Public Class RegisterChild
    Private Sub btnSubmitChildReg_Click(sender As Object, e As EventArgs) Handles btnSubmitChildReg.Click
        ' Stores the information entered by the user in the access database
        If txtChildNameReg.Text = "" Then
            lblErrorRegisterChild.Visible = True
            lblErrorRegisterChild.Text = "Please enter the child's name."
            txtChildNameReg.Focus()

        ElseIf txtChildPasswordReg.Text = "" Then
            lblErrorRegisterChild.Visible = True
            lblErrorRegisterChild.Text = "Please enter a password."
            txtChildPasswordReg.Focus()

        Else

            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblChildInformation (ChildName,ChildPassword) VALUES (@ChildName,@ChildPassword)"

                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@ChildName", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtChildNameReg.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@ChildPassword", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtChildPasswordReg.Text))

                cm.Parameters("@ChildName").Value = Me.txtChildNameReg.Text
                cm.Parameters("@ChildPassword").Value = Me.txtChildPasswordReg.Text

                cm.ExecuteNonQuery()
                lblErrorRegisterChild.Visible = True
                lblErrorRegisterChild.Text = "Registration Complete!"

                Me.txtChildNameReg.Text = ""
                Me.txtChildPasswordReg.Text = ""
                Exit Sub
            End With
        End If

    End Sub

    Private Sub btnClearChildReg_Click(sender As Object, e As EventArgs) Handles btnClearChildReg.Click
        ' Clears the form

        txtChildNameReg.Text = ""
        txtChildPasswordReg.Text = ""
        lblErrorRegisterChild.Text = ""
        txtChildNameReg.Focus()
    End Sub

    Private Sub btnBackChildReg_Click(sender As Object, e As EventArgs) Handles btnBackChildReg.Click
        ' This code executes when the user clicks the back button and returns
        ' the user to the Parent Main screen.

        ParentMain.Show()
        Me.Close()

    End Sub

    Private Sub RegisterChild_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Calls the connection

        Call connection()
    End Sub
End Class