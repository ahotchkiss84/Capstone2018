
Public Class KidLogin

    Public strCurrentUser As String

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmitKidLogin.Click
        ' This event handler executes when the user clicks the login button
        ' and takes the user to the kids login form.

        If cboChooseName.Text = "" Then
            lblErrorChildLogin.Visible = True
            lblErrorChildLogin.Text = "Please choose your name from the list."
            cboChooseName.Focus()
        ElseIf txtPasswordKidLogin.Text = "" Then
            lblErrorChildLogin.Visible = True
            lblErrorChildLogin.Text = "Please enter the password."
            txtPasswordKidLogin.Focus()

        Else
            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.CommonAppDataPath & "\AllowanceTracker.mdb"
            Try
                Dim sql As String = "SELECT * FROM tblChildInformation WHERE ChildName='" & cboChooseName.Text & "' AND ChildPassword = '" & txtPasswordKidLogin.Text & "'"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

                sqlCom.Connection = conn
                conn.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()
                If sqlRead.Read() Then
                    strCurrentUser = cboChooseName.Text
                    txtPasswordKidLogin.Text = ""
                    cboChooseName.Text = ""
                    lblErrorChildLogin.Text = ""
                    KidMain.Show()
                    Me.Hide()
                Else

                    ' If user enter wrong username and password combination
                    ' Throw an error message
                    lblErrorChildLogin.Text = "Child and Password do not match."

                    'Clear all fields
                    cboChooseName.Text = ""
                    txtPasswordKidLogin.Text = ""

                    'Focus on Username field
                    cboChooseName.Focus()
                End If

            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
            conn.Close()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClearKidLogin.Click
        ' This event handler executes when the user clicks the clear button and clears the form

        cboChooseName.Text = ""
        txtPasswordKidLogin.Text = ""
        lblErrorChildLogin.Text = ""

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBackKidLogin.Click
        ' This code executes when the user clicks the Back button and returns
        ' the user to the Kids.vb screen.

        Kids.Show()
        Me.Close()

    End Sub

    Private Sub KidLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This code populates the datatable for the combo box and connects to the database
        ' on form load

        Me.Bounds = Main.Bounds

        Dim conn As New System.Data.OleDb.OleDbConnection()
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.CommonAppDataPath & "\AllowanceTracker.mdb"
        Dim sda As New System.Data.OleDb.OleDbDataAdapter("SELECT ChildName FROM tblChildInformation", conn)
        'Fill the DataTable with records from Table.
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        'Insert the Default Item to DataTable.
        Dim row As DataRow = dt.NewRow()
        dt.Rows.InsertAt(row, 0)

        'Assign DataTable as DataSource.
        cboChooseName.DataSource = dt
        cboChooseName.DisplayMember = "ChildName"

    End Sub
End Class