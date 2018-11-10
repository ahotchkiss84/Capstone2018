<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeadingForgotPassword = New System.Windows.Forms.Label()
        Me.lblUsernameForgotPassword = New System.Windows.Forms.Label()
        Me.txtUsernameForgotPassword = New System.Windows.Forms.TextBox()
        Me.lblNewPasswordForgotPassword = New System.Windows.Forms.Label()
        Me.txtNewPasswordForgotPassword = New System.Windows.Forms.TextBox()
        Me.btnSubmitForgotPassword = New System.Windows.Forms.Button()
        Me.btnClearForgotPassword = New System.Windows.Forms.Button()
        Me.btnBackForgotPassword = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeadingForgotPassword
        '
        Me.lblHeadingForgotPassword.AutoSize = True
        Me.lblHeadingForgotPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblHeadingForgotPassword.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadingForgotPassword.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHeadingForgotPassword.Location = New System.Drawing.Point(44, 154)
        Me.lblHeadingForgotPassword.Name = "lblHeadingForgotPassword"
        Me.lblHeadingForgotPassword.Size = New System.Drawing.Size(253, 33)
        Me.lblHeadingForgotPassword.TabIndex = 6
        Me.lblHeadingForgotPassword.Text = "Change Password"
        '
        'lblUsernameForgotPassword
        '
        Me.lblUsernameForgotPassword.AutoSize = True
        Me.lblUsernameForgotPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblUsernameForgotPassword.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameForgotPassword.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblUsernameForgotPassword.Location = New System.Drawing.Point(12, 208)
        Me.lblUsernameForgotPassword.Name = "lblUsernameForgotPassword"
        Me.lblUsernameForgotPassword.Size = New System.Drawing.Size(118, 24)
        Me.lblUsernameForgotPassword.TabIndex = 7
        Me.lblUsernameForgotPassword.Text = "Username:"
        '
        'txtUsernameForgotPassword
        '
        Me.txtUsernameForgotPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsernameForgotPassword.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameForgotPassword.Location = New System.Drawing.Point(136, 208)
        Me.txtUsernameForgotPassword.Name = "txtUsernameForgotPassword"
        Me.txtUsernameForgotPassword.Size = New System.Drawing.Size(192, 26)
        Me.txtUsernameForgotPassword.TabIndex = 9
        '
        'lblNewPasswordForgotPassword
        '
        Me.lblNewPasswordForgotPassword.AutoSize = True
        Me.lblNewPasswordForgotPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPasswordForgotPassword.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPasswordForgotPassword.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblNewPasswordForgotPassword.Location = New System.Drawing.Point(12, 242)
        Me.lblNewPasswordForgotPassword.Name = "lblNewPasswordForgotPassword"
        Me.lblNewPasswordForgotPassword.Size = New System.Drawing.Size(109, 48)
        Me.lblNewPasswordForgotPassword.TabIndex = 10
        Me.lblNewPasswordForgotPassword.Text = "New " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password:"
        '
        'txtNewPasswordForgotPassword
        '
        Me.txtNewPasswordForgotPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewPasswordForgotPassword.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPasswordForgotPassword.Location = New System.Drawing.Point(136, 264)
        Me.txtNewPasswordForgotPassword.Name = "txtNewPasswordForgotPassword"
        Me.txtNewPasswordForgotPassword.Size = New System.Drawing.Size(192, 26)
        Me.txtNewPasswordForgotPassword.TabIndex = 11
        '
        'btnSubmitForgotPassword
        '
        Me.btnSubmitForgotPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSubmitForgotPassword.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnSubmitForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitForgotPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitForgotPassword.ForeColor = System.Drawing.Color.DimGray
        Me.btnSubmitForgotPassword.Location = New System.Drawing.Point(40, 336)
        Me.btnSubmitForgotPassword.Name = "btnSubmitForgotPassword"
        Me.btnSubmitForgotPassword.Size = New System.Drawing.Size(120, 37)
        Me.btnSubmitForgotPassword.TabIndex = 12
        Me.btnSubmitForgotPassword.Text = "Submit"
        Me.btnSubmitForgotPassword.UseVisualStyleBackColor = False
        '
        'btnClearForgotPassword
        '
        Me.btnClearForgotPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClearForgotPassword.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnClearForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearForgotPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForgotPassword.ForeColor = System.Drawing.Color.DimGray
        Me.btnClearForgotPassword.Location = New System.Drawing.Point(181, 336)
        Me.btnClearForgotPassword.Name = "btnClearForgotPassword"
        Me.btnClearForgotPassword.Size = New System.Drawing.Size(120, 37)
        Me.btnClearForgotPassword.TabIndex = 13
        Me.btnClearForgotPassword.Text = "Clear"
        Me.btnClearForgotPassword.UseVisualStyleBackColor = False
        '
        'btnBackForgotPassword
        '
        Me.btnBackForgotPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBackForgotPassword.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnBackForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackForgotPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackForgotPassword.ForeColor = System.Drawing.Color.DimGray
        Me.btnBackForgotPassword.Location = New System.Drawing.Point(110, 388)
        Me.btnBackForgotPassword.Name = "btnBackForgotPassword"
        Me.btnBackForgotPassword.Size = New System.Drawing.Size(120, 37)
        Me.btnBackForgotPassword.TabIndex = 14
        Me.btnBackForgotPassword.Text = "Back"
        Me.btnBackForgotPassword.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.ForeColor = System.Drawing.Color.Maroon
        Me.lblError.Location = New System.Drawing.Point(1, 301)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(340, 23)
        Me.lblError.TabIndex = 15
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError.Visible = False
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Allowance_Tracker.My.Resources.Resources.BoCbgmain
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnBackForgotPassword)
        Me.Controls.Add(Me.btnClearForgotPassword)
        Me.Controls.Add(Me.btnSubmitForgotPassword)
        Me.Controls.Add(Me.txtNewPasswordForgotPassword)
        Me.Controls.Add(Me.lblNewPasswordForgotPassword)
        Me.Controls.Add(Me.txtUsernameForgotPassword)
        Me.Controls.Add(Me.lblUsernameForgotPassword)
        Me.Controls.Add(Me.lblHeadingForgotPassword)
        Me.Name = "ForgotPassword"
        Me.Text = "ForgotPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeadingForgotPassword As Label
    Friend WithEvents lblUsernameForgotPassword As Label
    Friend WithEvents txtUsernameForgotPassword As TextBox
    Friend WithEvents lblNewPasswordForgotPassword As Label
    Friend WithEvents txtNewPasswordForgotPassword As TextBox
    Friend WithEvents btnSubmitForgotPassword As Button
    Friend WithEvents btnClearForgotPassword As Button
    Friend WithEvents btnBackForgotPassword As Button
    Friend WithEvents lblError As Label
End Class
