Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports Microsoft.Office.Interop.Access
Public Class TrackPurchases
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmitPurchases.Click
        ' This event handler executes when the user clicks the submit button and
        ' stores the entered information in the access database.

        If cboChooseNamePurchases.Text = "" Then
            lblErrorPurchases.Visible = True
            lblErrorPurchases.Text = "Please enter a name."
            cboChooseNamePurchases.Focus()

        ElseIf txtItemCostPurchases.Text = "" Then
            lblErrorPurchases.Visible = True
            lblErrorPurchases.Text = "Please enter item cost."
            txtItemCostPurchases.Focus()

        ElseIf txtNotePurchases.Text = "" Then
            lblErrorPurchases.Visible = True
            lblErrorPurchases.Text = "Please enter a description of the item purchased."
            txtNotePurchases.Focus()

        Else

            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblPurchases (ChildsName,PurchaseAmount,ItemDescription,PurchaseDate) VALUES (@ChildsName,@PurchaseAmount,@ItemDescription,@PurchaseDate)"

                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@ChildsName", System.Data.OleDb.OleDbType.VarChar, 255, Me.cboChooseNamePurchases.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@PurchaseAmount", System.Data.OleDb.OleDbType.Currency, 6, Me.txtItemCostPurchases.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@ItemDescription", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtNotePurchases.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@PurchaseDate", System.Data.OleDb.OleDbType.DBDate, 133, Me.dtpPurchases.Text))

                cm.Parameters("@ChildsName").Value = Me.cboChooseNamePurchases.Text
                cm.Parameters("@PurchaseAmount").Value = Me.txtItemCostPurchases.Text
                cm.Parameters("@ItemDescription").Value = Me.txtNotePurchases.Text
                cm.Parameters("@PurchaseDate").Value = Me.dtpPurchases.Text

                cm.ExecuteNonQuery()
                lblErrorPurchases.Visible = True
                lblErrorPurchases.Text = "Purchase Information Saved!"

                Me.cboChooseNamePurchases.Text = ""
                Me.txtItemCostPurchases.Text = ""
                Me.txtNotePurchases.Text = ""
                Exit Sub
            End With
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClearPurchases.Click
        ' This button executes when the user clicks the clear button and clears the form.

        cboChooseNamePurchases.Text = ""
        txtItemCostPurchases.Text = ""
        txtNotePurchases.Text = ""
        lblErrorPurchases.Text = ""

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHomePurchases.Click
        ' This event handler executes when the user clicks the home button and returns
        ' to the parent main form.

        ParentMain.Show()
        Me.Close()

    End Sub

    Private Sub TrackPurchases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cboChooseNamePurchases.DataSource = dt
        cboChooseNamePurchases.DisplayMember = "ChildName"

        conn.Close()
    End Sub
End Class