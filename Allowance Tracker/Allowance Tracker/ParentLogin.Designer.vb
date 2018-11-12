<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParentLogin))
        Me.lblHeadingParentLogin = New System.Windows.Forms.Label()
        Me.lblUsernameParentLogin = New System.Windows.Forms.Label()
        Me.lblPasswordParentLogin = New System.Windows.Forms.Label()
        Me.txtUsernameParentLogin = New System.Windows.Forms.TextBox()
        Me.txtPasswordParentLogin = New System.Windows.Forms.TextBox()
        Me.btnSubmitParentLogin = New System.Windows.Forms.Button()
        Me.btnClearParentLogin = New System.Windows.Forms.Button()
        Me.btnForgotPasswordParentLogin = New System.Windows.Forms.Button()
        Me.btnBackParentLogin = New System.Windows.Forms.Button()
        Me.lblErrorParentLogin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeadingParentLogin
        '
        Me.lblHeadingParentLogin.AutoSize = True
        Me.lblHeadingParentLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblHeadingParentLogin.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadingParentLogin.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHeadingParentLogin.Location = New System.Drawing.Point(76, 138)
        Me.lblHeadingParentLogin.Name = "lblHeadingParentLogin"
        Me.lblHeadingParentLogin.Size = New System.Drawing.Size(188, 33)
        Me.lblHeadingParentLogin.TabIndex = 5
        Me.lblHeadingParentLogin.Text = "Parents Login"
        '
        'lblUsernameParentLogin
        '
        Me.lblUsernameParentLogin.AutoSize = True
        Me.lblUsernameParentLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblUsernameParentLogin.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameParentLogin.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblUsernameParentLogin.Location = New System.Drawing.Point(12, 185)
        Me.lblUsernameParentLogin.Name = "lblUsernameParentLogin"
        Me.lblUsernameParentLogin.Size = New System.Drawing.Size(118, 24)
        Me.lblUsernameParentLogin.TabIndex = 6
        Me.lblUsernameParentLogin.Text = "Username:"
        '
        'lblPasswordParentLogin
        '
        Me.lblPasswordParentLogin.AutoSize = True
        Me.lblPasswordParentLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordParentLogin.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordParentLogin.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblPasswordParentLogin.Location = New System.Drawing.Point(12, 225)
        Me.lblPasswordParentLogin.Name = "lblPasswordParentLogin"
        Me.lblPasswordParentLogin.Size = New System.Drawing.Size(109, 24)
        Me.lblPasswordParentLogin.TabIndex = 7
        Me.lblPasswordParentLogin.Text = "Password:"
        '
        'txtUsernameParentLogin
        '
        Me.txtUsernameParentLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsernameParentLogin.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameParentLogin.Location = New System.Drawing.Point(136, 185)
        Me.txtUsernameParentLogin.Name = "txtUsernameParentLogin"
        Me.txtUsernameParentLogin.Size = New System.Drawing.Size(192, 26)
        Me.txtUsernameParentLogin.TabIndex = 8
        '
        'txtPasswordParentLogin
        '
        Me.txtPasswordParentLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswordParentLogin.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordParentLogin.Location = New System.Drawing.Point(136, 225)
        Me.txtPasswordParentLogin.Name = "txtPasswordParentLogin"
        Me.txtPasswordParentLogin.Size = New System.Drawing.Size(192, 26)
        Me.txtPasswordParentLogin.TabIndex = 9
        Me.txtPasswordParentLogin.UseSystemPasswordChar = True
        '
        'btnSubmitParentLogin
        '
        Me.btnSubmitParentLogin.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSubmitParentLogin.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnSubmitParentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitParentLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitParentLogin.ForeColor = System.Drawing.Color.DimGray
        Me.btnSubmitParentLogin.Location = New System.Drawing.Point(32, 292)
        Me.btnSubmitParentLogin.Name = "btnSubmitParentLogin"
        Me.btnSubmitParentLogin.Size = New System.Drawing.Size(120, 37)
        Me.btnSubmitParentLogin.TabIndex = 10
        Me.btnSubmitParentLogin.Text = "Submit"
        Me.btnSubmitParentLogin.UseVisualStyleBackColor = False
        '
        'btnClearParentLogin
        '
        Me.btnClearParentLogin.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClearParentLogin.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnClearParentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearParentLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearParentLogin.ForeColor = System.Drawing.Color.DimGray
        Me.btnClearParentLogin.Location = New System.Drawing.Point(167, 292)
        Me.btnClearParentLogin.Name = "btnClearParentLogin"
        Me.btnClearParentLogin.Size = New System.Drawing.Size(120, 37)
        Me.btnClearParentLogin.TabIndex = 11
        Me.btnClearParentLogin.Text = "Clear"
        Me.btnClearParentLogin.UseVisualStyleBackColor = False
        '
        'btnForgotPasswordParentLogin
        '
        Me.btnForgotPasswordParentLogin.BackColor = System.Drawing.Color.Gainsboro
        Me.btnForgotPasswordParentLogin.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnForgotPasswordParentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForgotPasswordParentLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForgotPasswordParentLogin.ForeColor = System.Drawing.Color.DimGray
        Me.btnForgotPasswordParentLogin.Location = New System.Drawing.Point(82, 341)
        Me.btnForgotPasswordParentLogin.Name = "btnForgotPasswordParentLogin"
        Me.btnForgotPasswordParentLogin.Size = New System.Drawing.Size(171, 37)
        Me.btnForgotPasswordParentLogin.TabIndex = 12
        Me.btnForgotPasswordParentLogin.Text = "Forgot Password"
        Me.btnForgotPasswordParentLogin.UseVisualStyleBackColor = False
        '
        'btnBackParentLogin
        '
        Me.btnBackParentLogin.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBackParentLogin.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnBackParentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackParentLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackParentLogin.ForeColor = System.Drawing.Color.DimGray
        Me.btnBackParentLogin.Location = New System.Drawing.Point(110, 391)
        Me.btnBackParentLogin.Name = "btnBackParentLogin"
        Me.btnBackParentLogin.Size = New System.Drawing.Size(120, 37)
        Me.btnBackParentLogin.TabIndex = 13
        Me.btnBackParentLogin.Text = "Back"
        Me.btnBackParentLogin.UseVisualStyleBackColor = False
        '
        'lblErrorParentLogin
        '
        Me.lblErrorParentLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorParentLogin.ForeColor = System.Drawing.Color.Maroon
        Me.lblErrorParentLogin.Location = New System.Drawing.Point(13, 257)
        Me.lblErrorParentLogin.Name = "lblErrorParentLogin"
        Me.lblErrorParentLogin.Size = New System.Drawing.Size(315, 23)
        Me.lblErrorParentLogin.TabIndex = 14
        Me.lblErrorParentLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblErrorParentLogin.Visible = False
        '
        'ParentLogin
        '
        Me.AcceptButton = Me.btnSubmitParentLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.lblErrorParentLogin)
        Me.Controls.Add(Me.btnBackParentLogin)
        Me.Controls.Add(Me.btnForgotPasswordParentLogin)
        Me.Controls.Add(Me.btnClearParentLogin)
        Me.Controls.Add(Me.btnSubmitParentLogin)
        Me.Controls.Add(Me.txtPasswordParentLogin)
        Me.Controls.Add(Me.txtUsernameParentLogin)
        Me.Controls.Add(Me.lblPasswordParentLogin)
        Me.Controls.Add(Me.lblUsernameParentLogin)
        Me.Controls.Add(Me.lblHeadingParentLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ParentLogin"
        Me.Text = "Parent Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeadingParentLogin As Label
    Friend WithEvents lblUsernameParentLogin As Label
    Friend WithEvents lblPasswordParentLogin As Label
    Friend WithEvents txtUsernameParentLogin As TextBox
    Friend WithEvents txtPasswordParentLogin As TextBox
    Friend WithEvents btnSubmitParentLogin As Button
    Friend WithEvents btnClearParentLogin As Button
    Friend WithEvents btnForgotPasswordParentLogin As Button
    Friend WithEvents btnBackParentLogin As Button
    Friend WithEvents lblErrorParentLogin As Label
End Class
