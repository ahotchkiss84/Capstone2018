Imports System.Data.OleDb

Public Class ViewAllowance
    Private Sub ViewAllowance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Bounds = Main.Bounds
        Call connection()

        Dim adapter As New OleDbDataAdapter
        Dim ds As New DataSet
        Dim itemcoll(100) As String

        Dim conn As New System.Data.OleDb.OleDbConnection()
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.CommonAppDataPath & "\AllowanceTracker.mdb"

        Dim sql As String = "SELECT AllowanceDate, AllowanceAmount, AllowanceNote FROM tblAllowance WHERE ChildsName='" & KidLogin.strCurrentUser & "'"
        Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

        sqlCom.Connection = conn
        conn.Open()

        Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

        While sqlRead.Read()
            Dim row(3) As String
            row(0) = sqlRead.Item(0)
            row(1) = sqlRead.Item(1)
            row(2) = sqlRead.Item(2)

            Dim lvi As New ListViewItem(row)
            Me.lstvAllowance.Items.Add(lvi)
        End While

        conn.Close()

    End Sub

    Private Sub btnBackAllowance_Click(sender As Object, e As EventArgs) Handles btnBackAllowance.Click
        ' This event handler executes when the user clicks the back button and returns
        ' to the kid main form


        KidMain.Show()
        Me.Close()

    End Sub
End Class