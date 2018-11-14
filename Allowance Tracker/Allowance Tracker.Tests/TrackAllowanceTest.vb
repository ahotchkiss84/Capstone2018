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
    Public Class TrackAllowanceTest

        <Test>
        Public Sub ParentAddAllowance()
            Dim applicationDirectory = TestContext.CurrentContext.TestDirectory
            Dim applicationPath = Path.Combine(applicationDirectory, "Allowance Tracker.exe")
            Dim app As Application = Application.Launch(applicationPath)
            Dim window As Window = app.GetWindow("Allowance Tracker", InitializeOption.NoCache)

            Dim buttonObj As Button = Window.Get(Of Button)("btnParentsHome")
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

            Dim buttonAllowanceObj As Button = windowMainParent.Get(Of Button)("btnTrackAllowance")
            buttonAllowanceObj.Click()

            Dim windowTrack As Window = app.GetWindow("Track Allowance", InitializeOption.NoCache)

            Dim cboUserObj As ComboBox = windowTrack.Get(Of ComboBox)("cboChildNameAllowance")
            cboUserObj.Select("TestKid")

            Dim txtAmtObj As TextBox = windowTrack.Get(Of TextBox)("txtAllowanceAmount")
            txtAmtObj.Text = "0.00"

            Dim txtNoteObj As TextBox = windowTrack.Get(Of TextBox)("txtNoteAllowance")
            txtAmtObj.Text = "Test"

            Dim buttonSubmitAllowanceObj As Button = windowTrack.Get(Of Button)("btnSubmitAllowance")
            buttonSubmitAllowanceObj.Click()

            Equals("Allowance Information Saved!")

            app.Close()

        End Sub

    End Class

End Namespace