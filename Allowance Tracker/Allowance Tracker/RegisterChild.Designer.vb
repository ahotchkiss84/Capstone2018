<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterChild
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterChild))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblChildName = New System.Windows.Forms.Label()
        Me.txtChildNameReg = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtChildPasswordReg = New System.Windows.Forms.TextBox()
        Me.btnSubmitChildReg = New System.Windows.Forms.Button()
        Me.btnClearChildReg = New System.Windows.Forms.Button()
        Me.btnBackChildReg = New System.Windows.Forms.Button()
        Me.lblErrorRegisterChild = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHeading.Location = New System.Drawing.Point(34, 141)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(273, 33)
        Me.lblHeading.TabIndex = 7
        Me.lblHeading.Text = "New Child Account"
        '
        'lblChildName
        '
        Me.lblChildName.AutoSize = True
        Me.lblChildName.BackColor = System.Drawing.Color.Transparent
        Me.lblChildName.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChildName.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblChildName.Location = New System.Drawing.Point(12, 189)
        Me.lblChildName.Name = "lblChildName"
        Me.lblChildName.Size = New System.Drawing.Size(120, 48)
        Me.lblChildName.TabIndex = 8
        Me.lblChildName.Text = "Child" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "First Name:"
        '
        'txtChildNameReg
        '
        Me.txtChildNameReg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChildNameReg.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChildNameReg.Location = New System.Drawing.Point(136, 211)
        Me.txtChildNameReg.Name = "txtChildNameReg"
        Me.txtChildNameReg.Size = New System.Drawing.Size(192, 26)
        Me.txtChildNameReg.TabIndex = 11
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblPassword.Location = New System.Drawing.Point(12, 263)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(109, 24)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Password:"
        '
        'txtChildPasswordReg
        '
        Me.txtChildPasswordReg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChildPasswordReg.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChildPasswordReg.Location = New System.Drawing.Point(136, 263)
        Me.txtChildPasswordReg.Name = "txtChildPasswordReg"
        Me.txtChildPasswordReg.Size = New System.Drawing.Size(192, 26)
        Me.txtChildPasswordReg.TabIndex = 13
        Me.txtChildPasswordReg.UseSystemPasswordChar = True
        '
        'btnSubmitChildReg
        '
        Me.btnSubmitChildReg.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSubmitChildReg.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnSubmitChildReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitChildReg.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitChildReg.ForeColor = System.Drawing.Color.DimGray
        Me.btnSubmitChildReg.Location = New System.Drawing.Point(42, 328)
        Me.btnSubmitChildReg.Name = "btnSubmitChildReg"
        Me.btnSubmitChildReg.Size = New System.Drawing.Size(120, 37)
        Me.btnSubmitChildReg.TabIndex = 14
        Me.btnSubmitChildReg.Text = "Submit"
        Me.btnSubmitChildReg.UseVisualStyleBackColor = False
        '
        'btnClearChildReg
        '
        Me.btnClearChildReg.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClearChildReg.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnClearChildReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearChildReg.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearChildReg.ForeColor = System.Drawing.Color.DimGray
        Me.btnClearChildReg.Location = New System.Drawing.Point(179, 328)
        Me.btnClearChildReg.Name = "btnClearChildReg"
        Me.btnClearChildReg.Size = New System.Drawing.Size(120, 37)
        Me.btnClearChildReg.TabIndex = 15
        Me.btnClearChildReg.Text = "Clear"
        Me.btnClearChildReg.UseVisualStyleBackColor = False
        '
        'btnBackChildReg
        '
        Me.btnBackChildReg.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBackChildReg.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnBackChildReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackChildReg.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackChildReg.ForeColor = System.Drawing.Color.DimGray
        Me.btnBackChildReg.Location = New System.Drawing.Point(110, 383)
        Me.btnBackChildReg.Name = "btnBackChildReg"
        Me.btnBackChildReg.Size = New System.Drawing.Size(120, 37)
        Me.btnBackChildReg.TabIndex = 16
        Me.btnBackChildReg.Text = "Back"
        Me.btnBackChildReg.UseVisualStyleBackColor = False
        '
        'lblErrorRegisterChild
        '
        Me.lblErrorRegisterChild.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorRegisterChild.ForeColor = System.Drawing.Color.Maroon
        Me.lblErrorRegisterChild.Location = New System.Drawing.Point(13, 298)
        Me.lblErrorRegisterChild.Name = "lblErrorRegisterChild"
        Me.lblErrorRegisterChild.Size = New System.Drawing.Size(315, 23)
        Me.lblErrorRegisterChild.TabIndex = 17
        Me.lblErrorRegisterChild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblErrorRegisterChild.Visible = False
        '
        'RegisterChild
        '
        Me.AcceptButton = Me.btnSubmitChildReg
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.lblErrorRegisterChild)
        Me.Controls.Add(Me.btnBackChildReg)
        Me.Controls.Add(Me.btnClearChildReg)
        Me.Controls.Add(Me.btnSubmitChildReg)
        Me.Controls.Add(Me.txtChildPasswordReg)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtChildNameReg)
        Me.Controls.Add(Me.lblChildName)
        Me.Controls.Add(Me.lblHeading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RegisterChild"
        Me.Text = "Register Child"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblChildName As Label
    Friend WithEvents txtChildNameReg As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtChildPasswordReg As TextBox
    Friend WithEvents btnSubmitChildReg As Button
    Friend WithEvents btnClearChildReg As Button
    Friend WithEvents btnBackChildReg As Button
    Friend WithEvents lblErrorRegisterChild As Label
End Class
