<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParentRegistration))
        Me.lblHeadingParentReg = New System.Windows.Forms.Label()
        Me.lblParentNameReg = New System.Windows.Forms.Label()
        Me.lblUsernameParentReg = New System.Windows.Forms.Label()
        Me.lblPasswordParentReg = New System.Windows.Forms.Label()
        Me.txtParentNameReg = New System.Windows.Forms.TextBox()
        Me.txtUsernameParentReg = New System.Windows.Forms.TextBox()
        Me.txtPasswordParentReg = New System.Windows.Forms.TextBox()
        Me.btnSubmitParentReg = New System.Windows.Forms.Button()
        Me.btnClearParentReg = New System.Windows.Forms.Button()
        Me.btnBackParentReg = New System.Windows.Forms.Button()
        Me.lblErrorParentReg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeadingParentReg
        '
        Me.lblHeadingParentReg.AutoSize = True
        Me.lblHeadingParentReg.BackColor = System.Drawing.Color.Transparent
        Me.lblHeadingParentReg.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadingParentReg.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHeadingParentReg.Location = New System.Drawing.Point(63, 138)
        Me.lblHeadingParentReg.Name = "lblHeadingParentReg"
        Me.lblHeadingParentReg.Size = New System.Drawing.Size(212, 33)
        Me.lblHeadingParentReg.TabIndex = 6
        Me.lblHeadingParentReg.Text = "Parent Register"
        '
        'lblParentNameReg
        '
        Me.lblParentNameReg.AutoSize = True
        Me.lblParentNameReg.BackColor = System.Drawing.Color.Transparent
        Me.lblParentNameReg.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParentNameReg.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblParentNameReg.Location = New System.Drawing.Point(11, 181)
        Me.lblParentNameReg.Name = "lblParentNameReg"
        Me.lblParentNameReg.Size = New System.Drawing.Size(120, 48)
        Me.lblParentNameReg.TabIndex = 7
        Me.lblParentNameReg.Text = "Parent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "First Name:"
        '
        'lblUsernameParentReg
        '
        Me.lblUsernameParentReg.AutoSize = True
        Me.lblUsernameParentReg.BackColor = System.Drawing.Color.Transparent
        Me.lblUsernameParentReg.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameParentReg.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblUsernameParentReg.Location = New System.Drawing.Point(13, 240)
        Me.lblUsernameParentReg.Name = "lblUsernameParentReg"
        Me.lblUsernameParentReg.Size = New System.Drawing.Size(118, 24)
        Me.lblUsernameParentReg.TabIndex = 8
        Me.lblUsernameParentReg.Text = "Username:"
        '
        'lblPasswordParentReg
        '
        Me.lblPasswordParentReg.AutoSize = True
        Me.lblPasswordParentReg.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordParentReg.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordParentReg.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblPasswordParentReg.Location = New System.Drawing.Point(13, 278)
        Me.lblPasswordParentReg.Name = "lblPasswordParentReg"
        Me.lblPasswordParentReg.Size = New System.Drawing.Size(109, 24)
        Me.lblPasswordParentReg.TabIndex = 9
        Me.lblPasswordParentReg.Text = "Password:"
        '
        'txtParentNameReg
        '
        Me.txtParentNameReg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtParentNameReg.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParentNameReg.Location = New System.Drawing.Point(137, 203)
        Me.txtParentNameReg.Name = "txtParentNameReg"
        Me.txtParentNameReg.Size = New System.Drawing.Size(192, 26)
        Me.txtParentNameReg.TabIndex = 10
        '
        'txtUsernameParentReg
        '
        Me.txtUsernameParentReg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsernameParentReg.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameParentReg.Location = New System.Drawing.Point(137, 240)
        Me.txtUsernameParentReg.Name = "txtUsernameParentReg"
        Me.txtUsernameParentReg.Size = New System.Drawing.Size(192, 26)
        Me.txtUsernameParentReg.TabIndex = 11
        '
        'txtPasswordParentReg
        '
        Me.txtPasswordParentReg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswordParentReg.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordParentReg.Location = New System.Drawing.Point(137, 278)
        Me.txtPasswordParentReg.Name = "txtPasswordParentReg"
        Me.txtPasswordParentReg.Size = New System.Drawing.Size(192, 26)
        Me.txtPasswordParentReg.TabIndex = 12
        Me.txtPasswordParentReg.UseSystemPasswordChar = True
        '
        'btnSubmitParentReg
        '
        Me.btnSubmitParentReg.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSubmitParentReg.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnSubmitParentReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitParentReg.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitParentReg.ForeColor = System.Drawing.Color.DimGray
        Me.btnSubmitParentReg.Location = New System.Drawing.Point(41, 346)
        Me.btnSubmitParentReg.Name = "btnSubmitParentReg"
        Me.btnSubmitParentReg.Size = New System.Drawing.Size(120, 37)
        Me.btnSubmitParentReg.TabIndex = 13
        Me.btnSubmitParentReg.Text = "Submit"
        Me.btnSubmitParentReg.UseVisualStyleBackColor = False
        '
        'btnClearParentReg
        '
        Me.btnClearParentReg.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClearParentReg.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnClearParentReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearParentReg.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearParentReg.ForeColor = System.Drawing.Color.DimGray
        Me.btnClearParentReg.Location = New System.Drawing.Point(178, 346)
        Me.btnClearParentReg.Name = "btnClearParentReg"
        Me.btnClearParentReg.Size = New System.Drawing.Size(120, 37)
        Me.btnClearParentReg.TabIndex = 14
        Me.btnClearParentReg.Text = "Clear"
        Me.btnClearParentReg.UseVisualStyleBackColor = False
        '
        'btnBackParentReg
        '
        Me.btnBackParentReg.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBackParentReg.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnBackParentReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackParentReg.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackParentReg.ForeColor = System.Drawing.Color.DimGray
        Me.btnBackParentReg.Location = New System.Drawing.Point(109, 396)
        Me.btnBackParentReg.Name = "btnBackParentReg"
        Me.btnBackParentReg.Size = New System.Drawing.Size(120, 37)
        Me.btnBackParentReg.TabIndex = 15
        Me.btnBackParentReg.Text = "Back"
        Me.btnBackParentReg.UseVisualStyleBackColor = False
        '
        'lblErrorParentReg
        '
        Me.lblErrorParentReg.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorParentReg.ForeColor = System.Drawing.Color.Maroon
        Me.lblErrorParentReg.Location = New System.Drawing.Point(17, 315)
        Me.lblErrorParentReg.Name = "lblErrorParentReg"
        Me.lblErrorParentReg.Size = New System.Drawing.Size(312, 23)
        Me.lblErrorParentReg.TabIndex = 16
        Me.lblErrorParentReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblErrorParentReg.Visible = False
        '
        'ParentRegistration
        '
        Me.AcceptButton = Me.btnSubmitParentReg
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.lblErrorParentReg)
        Me.Controls.Add(Me.btnBackParentReg)
        Me.Controls.Add(Me.btnClearParentReg)
        Me.Controls.Add(Me.btnSubmitParentReg)
        Me.Controls.Add(Me.txtPasswordParentReg)
        Me.Controls.Add(Me.txtUsernameParentReg)
        Me.Controls.Add(Me.txtParentNameReg)
        Me.Controls.Add(Me.lblPasswordParentReg)
        Me.Controls.Add(Me.lblUsernameParentReg)
        Me.Controls.Add(Me.lblParentNameReg)
        Me.Controls.Add(Me.lblHeadingParentReg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ParentRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parent Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeadingParentReg As Label
    Friend WithEvents lblParentNameReg As Label
    Friend WithEvents lblUsernameParentReg As Label
    Friend WithEvents lblPasswordParentReg As Label
    Friend WithEvents txtParentNameReg As TextBox
    Friend WithEvents txtUsernameParentReg As TextBox
    Friend WithEvents txtPasswordParentReg As TextBox
    Friend WithEvents btnSubmitParentReg As Button
    Friend WithEvents btnClearParentReg As Button
    Friend WithEvents btnBackParentReg As Button
    Friend WithEvents lblErrorParentReg As Label
End Class
