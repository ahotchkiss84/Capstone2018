Public Class ViewAllowance
    Private Sub ViewAllowance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conn As New System.Data.OleDb.OleDbConnection()
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\AllowanceTracker1.mdb"

        Dim sql As String = "SELECT * FROM tblAllowance WHERE ChildName='" & KidLogin.strCurrentUser & "'"
        Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

        sqlCom.Connection = conn
        conn.Open()

    End Sub
End Class