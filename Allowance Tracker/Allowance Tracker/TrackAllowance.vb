Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports Microsoft.Office.Interop.Access

Public Class TrackAllowance

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmitAllowance.Click
        ' This event handler executes when the user clicks the submit button and
        ' stores the entered information in the access database.

        If cboChildNameAllowance.Text = "" Then
            lblErrorTrackAllowance.Visible = True
            lblErrorTrackAllowance.Text = "Please select a child."
            cboChildNameAllowance.Focus()

        ElseIf txtAllowanceAmount.Text = "" Then
            lblErrorTrackAllowance.Visible = True
            lblErrorTrackAllowance.Text = "Please enter an amount earned. Amount can be 0."
            txtAllowanceAmount.Focus()

        Else

            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblAllowance (ChildsName,AllowanceAmount,AllowanceDate,AllowanceNote) VALUES (@ChildsName,@AllowanceAmount,@AllowanceDate,@AllowanceNote)"

                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@ChildsName", System.Data.OleDb.OleDbType.VarChar, 255, Me.cboChildNameAllowance.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@Amount", System.Data.OleDb.OleDbType.Currency, 6, Me.txtAllowanceAmount.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@AllowanceDate", System.Data.OleDb.OleDbType.DBDate, 133, Me.dtpAllowance.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@Note", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtNoteAllowance.Text))

                cm.Parameters("@ChildsName").Value = Me.cboChildNameAllowance.Text
                cm.Parameters("@Amount").Value = Me.txtAllowanceAmount.text
                cm.Parameters("@AllowanceDate").Value = Me.dtpAllowance.Text
                cm.Parameters("@Note").Value = Me.txtNoteAllowance.Text

                cm.ExecuteNonQuery()
                lblErrorTrackAllowance.Visible = True
                lblErrorTrackAllowance.Text = "Allowance Information Saved!"

                Me.txtAllowanceAmount.Text = ""
                Me.cboChildNameAllowance.Text = ""
                Me.txtNoteAllowance.Text = ""
                Exit Sub
            End With
            cn.Close()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClearAllowance.Click

        cboChildNameAllowance.Text = ""
        txtAllowanceAmount.Text = ""
        txtNoteAllowance.Text = ""
        lblErrorTrackAllowance.Text = ""
        cboChildNameAllowance.Focus()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHomeAllowance.Click
        ' This event handler executes when the user clicks the home button and
        ' returns the user to the parent main form.

        ParentMain.Show()
        Me.Close()

    End Sub

    Private Sub TrackAllowance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Calls the connection method for the access database

        Call connection()

        ' This code populates the datatable for the combo box and connects to the database
        ' on form load

        Dim conn As New System.Data.OleDb.OleDbConnection()
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\AllowanceTracker1.mdb"
        Dim sda As New System.Data.OleDb.OleDbDataAdapter("SELECT ChildName FROM tblChildInformation", conn)
        'Fill the DataTable with records from Table.
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        'Insert the Default Item to DataTable.
        Dim row As DataRow = dt.NewRow()
        dt.Rows.InsertAt(row, 0)

        'Assign DataTable as DataSource.
        cboChildNameAllowance.DataSource = dt
        cboChildNameAllowance.DisplayMember = "ChildName"

        conn.Close()

    End Sub
End Class