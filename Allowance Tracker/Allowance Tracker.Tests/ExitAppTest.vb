Option Explicit On

Imports System
Imports System.IO
Imports NUnit.Framework
Imports TestStack.White
Imports TestStack.White.Factory
Imports TestStack.White.UIItems
Imports TestStack.White.UIItems.WindowItems

Namespace Allowance_Tracker.Tests

    <TestFixture>
    Public Class ExitAppTest

        <Test>
        Public Sub AppClose()
            Dim applicationDirectory = TestContext.CurrentContext.TestDirectory
            Dim applicationPath = Path.Combine(applicationDirectory, "Allowance Tracker.exe")
            Dim app As Application = Application.Launch(applicationPath)
            Dim window As Window = app.GetWindow("Allowance Tracker", InitializeOption.NoCache)

            Dim buttonObj As Button = window.Get(Of Button)("btnExitHome")
            buttonObj.Click()

            Assert.Pass("App Exited")
        End Sub

    End Class

End Namespace