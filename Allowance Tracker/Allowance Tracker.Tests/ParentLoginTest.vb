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
    Public Class ParentLoginTest

        <Test>
        Public Sub TestMethod()
            Dim applicationDirectory = TestContext.CurrentContext.TestDirectory
            Dim applicationPath = Path.Combine(applicationDirectory, "Allowance Tracker.exe")
            Dim app As Application = Application.Launch(applicationPath)
            Dim window As Window = app.GetWindow("Allowance Tracker", InitializeOption.NoCache)

            Dim buttonObj As Button = window.Get(Of Button)("btnParentsHome")
            buttonObj.Click()

            Dim windowParents As Window = app.GetWindow("Parents", InitializeOption.NoCache)

            Dim buttonLoginObj As Button = windowParents.Get(Of Button)("btnParentLogin")
            buttonLoginObj.Click()

            Dim windowParentLogin As Window = app.GetWindow("Parent Login", InitializeOption.NoCache)

            Dim txtUserObj As TextBox = windowParentLogin.Get(Of TextBox)("txtUsernameParentLogin")
            txtUserObj.Text = "TestUser"

            Dim txtPassObj As TextBox = windowParentLogin.Get(Of TextBox)("txtPasswordParentLogin")
            txtPassObj.Text = "TestPass"

            Dim buttonSubmitObj As Button = windowParentLogin.Get(Of Button)("btnSubmitParentLogin")
            buttonSubmitObj.Click()

            Dim windowParentMain As Window = app.GetWindow("Parent Main", InitializeOption.NoCache)

            Assert.IsNotNull(windowParentMain)

            app.Close()
        End Sub

    End Class

End Namespace