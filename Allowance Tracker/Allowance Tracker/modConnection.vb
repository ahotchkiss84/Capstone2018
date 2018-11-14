Imports System.Data.OleDb
Module modConnection
    ' initializes the variables for transfering information into access database

    Public cn As New OleDb.OleDbConnection
    Public cm As New OleDb.OleDbCommand
    Public dr As OleDbDataReader

    Public Sub connection()
        ' Locates the access database

        cn = New OleDb.OleDbConnection
        With cn
            'Provider must be Microsoft.Jet.OLEDB.4.0, find the access file, and test the connection
            .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.CommonAppDataPath & "\AllowanceTracker.mdb"
            .Open()
        End With
    End Sub

End Module
