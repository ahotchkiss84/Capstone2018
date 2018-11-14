Option Explicit On

Imports System
Imports System.IO
Imports NUnit.Framework
Imports TestStack.White
Imports TestStack.White.Factory
Imports TestStack.White.UIItems
Imports TestStack.White.UIItems.ListBoxItems
Imports TestStack.White.UIItems.WindowItems

Namespace Allowance_Tracker.Tests

    <TestFixture>
    Public Class SeparateChildLoginsTest

        <Test>
        Public Sub ValidateControlForSeparateUsersExists()
            Dim applicationDirectory = TestContext.CurrentContext.TestDirectory
            Dim applicationPath = Path.Combine(applicationDirectory, "Allowance Tracker.exe")
            Dim app As Application = Application.Launch(applicationPath)
            Dim window As Window = app.GetWindow("Allowance Tracker", InitializeOption.NoCache)

            Dim buttonObj As Button = window.Get(Of Button)("btnKidsHome")
            buttonObj.Click()

            Dim windowKids As Window = app.GetWindow("Kids", InitializeOption.NoCache)

            Dim buttonLoginObj As Button = windowKids.Get(Of Button)("btnLoginKid")
            buttonLoginObj.Click()

            Dim windowKidLogin As Window = app.GetWindow("Kid Login", InitializeOption.NoCache)

            Assert.That("cboChooseName.Items", [Is].All.GreaterThan(1))

            app.Close()

        End Sub

    End Class

End Namespace