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
    Public Class CheckPurchaseTest

        <Test>
        Public Sub ParentMakePurchaseChildView()
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

            Dim buttonCheckObj As Button = windowKidMain.Get(Of Button)("btnCheckPurchaseHistory")
            buttonCheckObj.Click()

            Dim windowPurchases As Window = app.GetWindow("View Purchases", InitializeOption.NoCache)

            Assert.IsNotNull(windowPurchases)

            app.Close()
        End Sub

    End Class

End Namespace