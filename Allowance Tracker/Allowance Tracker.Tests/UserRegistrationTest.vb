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
    Public Class UserRegistrationTest

        <Test>
        Public Sub NewParentUserRegistration()
            Dim applicationDirectory = TestContext.CurrentContext.TestDirectory
            Dim applicationPath = Path.Combine(applicationDirectory, "Allowance Tracker.exe")
            Dim app As Application = Application.Launch(applicationPath)
            Dim window As Window = app.GetWindow("Allowance Tracker", InitializeOption.NoCache)

            Dim buttonObj As Button = window.Get(Of Button)("btnParentsHome")
            buttonObj.Click()

            Dim windowParent As Window = app.GetWindow("Parents", InitializeOption.NoCache)

            Dim buttonRegObj As Button = windowParent.Get(Of Button)("btnRegisterParent")
            buttonRegObj.Click()

            Dim windowRegisterParent As Window = app.GetWindow("Parent Registration", InitializeOption.NoCache)

            Dim txtObj As TextBox = windowRegisterParent.Get(Of TextBox)("txtParentNameReg")
            txtObj.Text = "Alicea"

            Dim txtUserObj As TextBox = windowRegisterParent.Get(Of TextBox)("txtUsernameParentReg")
            txtUserObj.Text = "TestUser"

            Dim txtPassObj As TextBox = windowRegisterParent.Get(Of TextBox)("txtPasswordParentReg")
            txtPassObj.Text = "TestPass"

            Dim buttonSubmitObj As Button = windowRegisterParent.Get(Of Button)("btnSubmitParentReg")
            buttonSubmitObj.Click()

            Equals("Registration Complete!")

            app.Close()

        End Sub

    End Class

End Namespace