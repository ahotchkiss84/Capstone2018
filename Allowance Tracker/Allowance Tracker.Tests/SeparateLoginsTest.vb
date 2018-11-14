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
    Public Class SeparateLoginsTest

        <Test>
        Public Sub SeparateLoginsForParentAndChild()
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

            Dim cboUserObj As ComboBox = windowKidLogin.Get(Of ComboBox)("cboChooseName")
            cboUserObj.Select("TestKid")

            Dim txtPassObj As TextBox = windowKidLogin.Get(Of TextBox)("txtPasswordKidLogin")
            txtPassObj.Text = "TestPass"

            Dim buttonSubmitObj As Button = windowKidLogin.Get(Of Button)("btnSubmitKidLogin")
            buttonSubmitObj.Click()

            Dim windowKidMain As Window = app.GetWindow("Kid Main", InitializeOption.NoCache)

            Dim buttonHomeObj As Button = windowKidMain.Get(Of Button)("btnReturnHomeKid")
            buttonHomeObj.Click()

            Dim windowHome As Window = app.GetWindow("Allowance Tracker", InitializeOption.NoCache)

            Dim buttonParentObj As Button = windowHome.Get(Of Button)("btnParentsHome")
            buttonParentObj.Click()

            Dim windowParents As Window = app.GetWindow("Parents", InitializeOption.NoCache)

            Dim buttonLoginParentObj As Button = windowParents.Get(Of Button)("btnParentLogin")
            buttonLoginParentObj.Click()

            Dim windowParentLogin As Window = app.GetWindow("Parent Login", InitializeOption.NoCache)

            Dim txtUserObj As TextBox = windowParentLogin.Get(Of TextBox)("txtUsernameParentLogin")
            txtUserObj.Text = "TestUser"

            Dim txtParentPassObj As TextBox = windowParentLogin.Get(Of TextBox)("txtPasswordParentLogin")
            txtParentPassObj.Text = "TestPass"

            Dim buttonParentSubmitObj As Button = windowParentLogin.Get(Of Button)("btnSubmitParentLogin")
            buttonParentSubmitObj.Click()

            Dim windowParentMain As Window = app.GetWindow("Parent Main", InitializeOption.NoCache)

            Assert.IsNotNull(windowParentMain)

            app.Close()

        End Sub

    End Class

End Namespace