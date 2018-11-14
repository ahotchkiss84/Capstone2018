Imports System.Data.OleDb

Public Class KidMain
    Private Sub btnReturnHomeKid_Click(sender As Object, e As EventArgs) Handles btnReturnHomeKid.Click
        ' This code executes when the user clicks the Return Home button and 
        ' returns the user to the Main screen

        KidLogin.strCurrentUser = ""
        Main.Show()
        Me.Close()

    End Sub

    Private Sub btnCheckAllowanceBalance_Click(sender As Object, e As EventArgs) Handles btnCheckAllowanceBalance.Click
        ' This code executes when the user clicks the Check Allowance Balance button and
        ' takes the user to the View Allowance screen.

        ViewAllowance.Show()
        Me.Close()

    End Sub

    Private Sub btnCheckPurchaseHistory_Click(sender As Object, e As EventArgs) Handles btnCheckPurchaseHistory.Click
        ' This code executes when the user clicks the Check Purchase History button and
        ' takes the user to the View Purchases screen.

        ViewPurchases.Show()
        Me.Close()

    End Sub

    Private Sub KidMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' this event handler executes on load. Displays the welcome message and current account balance.

        lblKidWelcome.Text = "Hello, " & KidLogin.strCurrentUser & "!"

        Call connection()

        Dim adapter As New OleDbDataAdapter
        Dim ds As New DataSet
        Dim itemcoll(100) As String

        Dim conn As New System.Data.OleDb.OleDbConnection()
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.CommonAppDataPath & "\AllowanceTracker.mdb"

        Dim sql As String = "SELECT IIF(
   ISNull((SELECT SUM(AllowanceAmount) FROM tblAllowance WHERE ChildsName = '" & KidLogin.strCurrentUser & "')),
   0,
   (SELECT SUM(AllowanceAmount) FROM tblAllowance WHERE ChildsName = '" & KidLogin.strCurrentUser & "'))
- IIF(
   ISNull((SELECT Sum(PurchaseAmount) FROM tblPurchases WHERE ChildsName = '" & KidLogin.strCurrentUser & "')),
   0,
   (SELECT Sum(PurchaseAmount) FROM tblPurchases WHERE ChildsName = '" & KidLogin.strCurrentUser & "'))
FROM Dual;"
        Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

        sqlCom.Connection = conn
        conn.Open()

        Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

        If sqlRead.Read() Then

            lblAccountBalance.Text = "Your current account balance is $" & sqlRead.Item(0)

        End If

        conn.Close()
    End Sub
End Class