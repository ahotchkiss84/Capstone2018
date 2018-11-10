<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KidLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KidLogin))
        Me.cboChooseName = New System.Windows.Forms.ComboBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblChooseName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPasswordKidLogin = New System.Windows.Forms.TextBox()
        Me.btnSubmitKidLogin = New System.Windows.Forms.Button()
        Me.btnClearKidLogin = New System.Windows.Forms.Button()
        Me.btnBackKidLogin = New System.Windows.Forms.Button()
        Me.lblErrorChildLogin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboChooseName
        '
        Me.cboChooseName.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChooseName.FormattingEnabled = True
        Me.cboChooseName.Location = New System.Drawing.Point(184, 209)
        Me.cboChooseName.Name = "cboChooseName"
        Me.cboChooseName.Size = New System.Drawing.Size(144, 30)
        Me.cboChooseName.TabIndex = 9
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHeading.Location = New System.Drawing.Point(99, 160)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(143, 33)
        Me.lblHeading.TabIndex = 6
        Me.lblHeading.Text = "Kids Login"
        '
        'lblChooseName
        '
        Me.lblChooseName.AutoSize = True
        Me.lblChooseName.BackColor = System.Drawing.Color.Transparent
        Me.lblChooseName.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseName.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblChooseName.Location = New System.Drawing.Point(12, 210)
        Me.lblChooseName.Name = "lblChooseName"
        Me.lblChooseName.Size = New System.Drawing.Size(166, 24)
        Me.lblChooseName.TabIndex = 7
        Me.lblChooseName.Text = "Choose Name:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblPassword.Location = New System.Drawing.Point(12, 252)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(109, 24)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "Password:"
        '
        'txtPasswordKidLogin
        '
        Me.txtPasswordKidLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswordKidLogin.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordKidLogin.Location = New System.Drawing.Point(136, 252)
        Me.txtPasswordKidLogin.Name = "txtPasswordKidLogin"
        Me.txtPasswordKidLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordKidLogin.Size = New System.Drawing.Size(192, 26)
        Me.txtPasswordKidLogin.TabIndex = 10
        Me.txtPasswordKidLogin.UseSystemPasswordChar = True
        '
        'btnSubmitKidLogin
        '
        Me.btnSubmitKidLogin.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSubmitKidLogin.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnSubmitKidLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitKidLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitKidLogin.ForeColor = System.Drawing.Color.DimGray
        Me.btnSubmitKidLogin.Location = New System.Drawing.Point(42, 313)
        Me.btnSubmitKidLogin.Name = "btnSubmitKidLogin"
        Me.btnSubmitKidLogin.Size = New System.Drawing.Size(120, 37)
        Me.btnSubmitKidLogin.TabIndex = 11
        Me.btnSubmitKidLogin.Text = "Submit"
        Me.btnSubmitKidLogin.UseVisualStyleBackColor = False
        '
        'btnClearKidLogin
        '
        Me.btnClearKidLogin.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClearKidLogin.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnClearKidLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearKidLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearKidLogin.ForeColor = System.Drawing.Color.DimGray
        Me.btnClearKidLogin.Location = New System.Drawing.Point(178, 313)
        Me.btnClearKidLogin.Name = "btnClearKidLogin"
        Me.btnClearKidLogin.Size = New System.Drawing.Size(120, 37)
        Me.btnClearKidLogin.TabIndex = 12
        Me.btnClearKidLogin.Text = "Clear"
        Me.btnClearKidLogin.UseVisualStyleBackColor = False
        '
        'btnBackKidLogin
        '
        Me.btnBackKidLogin.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBackKidLogin.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnBackKidLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackKidLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackKidLogin.ForeColor = System.Drawing.Color.DimGray
        Me.btnBackKidLogin.Location = New System.Drawing.Point(110, 356)
        Me.btnBackKidLogin.Name = "btnBackKidLogin"
        Me.btnBackKidLogin.Size = New System.Drawing.Size(120, 37)
        Me.btnBackKidLogin.TabIndex = 14
        Me.btnBackKidLogin.Text = "Back"
        Me.btnBackKidLogin.UseVisualStyleBackColor = False
        '
        'lblErrorChildLogin
        '
        Me.lblErrorChildLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorChildLogin.ForeColor = System.Drawing.Color.Maroon
        Me.lblErrorChildLogin.Location = New System.Drawing.Point(16, 284)
        Me.lblErrorChildLogin.Name = "lblErrorChildLogin"
        Me.lblErrorChildLogin.Size = New System.Drawing.Size(312, 23)
        Me.lblErrorChildLogin.TabIndex = 15
        Me.lblErrorChildLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblErrorChildLogin.Visible = False
        '
        'KidLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.lblErrorChildLogin)
        Me.Controls.Add(Me.btnBackKidLogin)
        Me.Controls.Add(Me.btnClearKidLogin)
        Me.Controls.Add(Me.btnSubmitKidLogin)
        Me.Controls.Add(Me.txtPasswordKidLogin)
        Me.Controls.Add(Me.cboChooseName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblChooseName)
        Me.Controls.Add(Me.lblHeading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "KidLogin"
        Me.Text = "Kid Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblChooseName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPasswordKidLogin As TextBox
    Friend WithEvents btnSubmitKidLogin As Button
    Friend WithEvents btnClearKidLogin As Button
    Friend WithEvents btnBackKidLogin As Button
    Friend WithEvents lblErrorChildLogin As Label
    Friend WithEvents cboChooseName As ComboBox
End Class
