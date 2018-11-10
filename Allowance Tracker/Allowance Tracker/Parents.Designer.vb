<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parents))
        Me.btnRegisterParent = New System.Windows.Forms.Button()
        Me.btnParentLogin = New System.Windows.Forms.Button()
        Me.btnHomeParent = New System.Windows.Forms.Button()
        Me.lblHeadingParents = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRegisterParent
        '
        Me.btnRegisterParent.BackColor = System.Drawing.Color.Gainsboro
        Me.btnRegisterParent.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnRegisterParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterParent.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterParent.ForeColor = System.Drawing.Color.DimGray
        Me.btnRegisterParent.Location = New System.Drawing.Point(111, 227)
        Me.btnRegisterParent.Name = "btnRegisterParent"
        Me.btnRegisterParent.Size = New System.Drawing.Size(120, 37)
        Me.btnRegisterParent.TabIndex = 1
        Me.btnRegisterParent.Text = "Register"
        Me.btnRegisterParent.UseVisualStyleBackColor = False
        '
        'btnParentLogin
        '
        Me.btnParentLogin.BackColor = System.Drawing.Color.Gainsboro
        Me.btnParentLogin.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnParentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParentLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParentLogin.ForeColor = System.Drawing.Color.DimGray
        Me.btnParentLogin.Location = New System.Drawing.Point(111, 281)
        Me.btnParentLogin.Name = "btnParentLogin"
        Me.btnParentLogin.Size = New System.Drawing.Size(120, 37)
        Me.btnParentLogin.TabIndex = 2
        Me.btnParentLogin.Text = "Login"
        Me.btnParentLogin.UseVisualStyleBackColor = False
        '
        'btnHomeParent
        '
        Me.btnHomeParent.BackColor = System.Drawing.Color.Gainsboro
        Me.btnHomeParent.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnHomeParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHomeParent.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeParent.ForeColor = System.Drawing.Color.DimGray
        Me.btnHomeParent.Location = New System.Drawing.Point(111, 335)
        Me.btnHomeParent.Name = "btnHomeParent"
        Me.btnHomeParent.Size = New System.Drawing.Size(120, 37)
        Me.btnHomeParent.TabIndex = 3
        Me.btnHomeParent.Text = "Home"
        Me.btnHomeParent.UseVisualStyleBackColor = False
        '
        'lblHeadingParents
        '
        Me.lblHeadingParents.AutoSize = True
        Me.lblHeadingParents.BackColor = System.Drawing.Color.Transparent
        Me.lblHeadingParents.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadingParents.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblHeadingParents.Location = New System.Drawing.Point(115, 154)
        Me.lblHeadingParents.Name = "lblHeadingParents"
        Me.lblHeadingParents.Size = New System.Drawing.Size(111, 33)
        Me.lblHeadingParents.TabIndex = 4
        Me.lblHeadingParents.Text = "Parents"
        '
        'Parents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.lblHeadingParents)
        Me.Controls.Add(Me.btnHomeParent)
        Me.Controls.Add(Me.btnParentLogin)
        Me.Controls.Add(Me.btnRegisterParent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Parents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Parents"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegisterParent As Button
    Friend WithEvents btnParentLogin As Button
    Friend WithEvents btnHomeParent As Button
    Friend WithEvents lblHeadingParents As Label
End Class
