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
    Public Class NewChildAccountTest

        <Test>
        Public Sub ParentRegisterNewChildUser()
            Dim applicationDirectory = TestContext.CurrentContext.TestDirectory
            Dim applicationPath = Path.Combine(applicationDirectory, "Allowance Tracker.exe")
            Dim app As Application = Application.Launch(applicationPath)
            Dim window As Window = app.GetWindow("Allowance Tracker", InitializeOption.NoCache)

            Dim buttonObj As Button = window.Get(Of Button)("btnParentsHome")
            buttonObj.Click()

            Dim windowParent As Window = app.GetWindow("Parents", InitializeOption.NoCache)

            Dim buttonLoginObj As Button = windowParent.Get(Of Button)("btnParentLogin")
            buttonLoginObj.Click()

            Dim windowLoginParent As Window = app.GetWindow("Parent Login", InitializeOption.NoCache)

            Dim txtUserObj As TextBox = windowLoginParent.Get(Of TextBox)("txtUsernameParentLogin")
            txtUserObj.Text = "TestUser"

            Dim txtPassObj As TextBox = windowLoginParent.Get(Of TextBox)("txtPasswordParentLogin")
            txtPassObj.Text = "TestPass"

            Dim buttonSubmitObj As Button = windowLoginParent.Get(Of Button)("btnSubmitParentLogin")
            buttonSubmitObj.Click()

            Dim windowMainParent As Window = app.GetWindow("Parent Main", InitializeOption.NoCache)

            Dim buttonRegObj As Button = windowMainParent.Get(Of Button)("btnNewChild")
            buttonRegObj.Click()

            Dim windowRegChild As Window = app.GetWindow("Register Child", InitializeOption.NoCache)

            Dim txtNameObj As TextBox = windowRegChild.Get(Of TextBox)("txtChildNameReg")
            txtNameObj.Text = "TestKid"

            Dim txtChildPassObj As TextBox = windowRegChild.Get(Of TextBox)("txtChildPasswordReg")
            txtChildPassObj.Text = "TestPass"

            Dim buttonSubmitRegObj As Button = windowRegChild.Get(Of Button)("btnSubmitChildReg")
            buttonSubmitRegObj.Click()

            Equals("Registration Complete!")

            app.Close()

        End Sub

    End Class

End Namespace