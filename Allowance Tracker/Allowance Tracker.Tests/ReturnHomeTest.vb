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
    Public Class ReturnHomeTest

        <Test>
        Public Sub ReturnToHomeScreen()
            Dim applicationDirectory = TestContext.CurrentContext.TestDirectory
            Dim applicationPath = Path.Combine(applicationDirectory, "Allowance Tracker.exe")
            Dim app As Application = Application.Launch(applicationPath)
            Dim window As Window = app.GetWindow("Allowance Tracker", InitializeOption.NoCache)

            Dim buttonObj As Button = window.Get(Of Button)("btnParentsHome")
            buttonObj.Click()

            Dim windowParent As Window = app.GetWindow("Parents", InitializeOption.NoCache)

            Dim buttonHomeObj As Button = windowParent.Get(Of Button)("btnHomeParent")
            buttonHomeObj.Click()

            Dim windowMain As Window = app.GetWindow("Allowance Tracker", InitializeOption.NoCache)
            Assert.IsNotNull(windowMain)

            app.Close()

        End Sub

    End Class

End Namespace