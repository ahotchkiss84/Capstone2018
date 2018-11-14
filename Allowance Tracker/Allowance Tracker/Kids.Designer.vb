<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kids
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kids))
        Me.btnLoginKid = New System.Windows.Forms.Button()
        Me.btnHomeKid = New System.Windows.Forms.Button()
        Me.lblKidsHeading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLoginKid
        '
        Me.btnLoginKid.BackColor = System.Drawing.Color.Gainsboro
        Me.btnLoginKid.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnLoginKid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginKid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginKid.ForeColor = System.Drawing.Color.DimGray
        Me.btnLoginKid.Location = New System.Drawing.Point(110, 202)
        Me.btnLoginKid.Name = "btnLoginKid"
        Me.btnLoginKid.Size = New System.Drawing.Size(120, 37)
        Me.btnLoginKid.TabIndex = 3
        Me.btnLoginKid.Text = "Login"
        Me.btnLoginKid.UseVisualStyleBackColor = False
        '
        'btnHomeKid
        '
        Me.btnHomeKid.BackColor = System.Drawing.Color.Gainsboro
        Me.btnHomeKid.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnHomeKid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHomeKid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeKid.ForeColor = System.Drawing.Color.DimGray
        Me.btnHomeKid.Location = New System.Drawing.Point(110, 258)
        Me.btnHomeKid.Name = "btnHomeKid"
        Me.btnHomeKid.Size = New System.Drawing.Size(120, 37)
        Me.btnHomeKid.TabIndex = 4
        Me.btnHomeKid.Text = "Home"
        Me.btnHomeKid.UseVisualStyleBackColor = False
        '
        'lblKidsHeading
        '
        Me.lblKidsHeading.AutoSize = True
        Me.lblKidsHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblKidsHeading.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKidsHeading.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblKidsHeading.Location = New System.Drawing.Point(137, 146)
        Me.lblKidsHeading.Name = "lblKidsHeading"
        Me.lblKidsHeading.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblKidsHeading.Size = New System.Drawing.Size(66, 33)
        Me.lblKidsHeading.TabIndex = 5
        Me.lblKidsHeading.Text = "Kids"
        '
        'Kids
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.lblKidsHeading)
        Me.Controls.Add(Me.btnHomeKid)
        Me.Controls.Add(Me.btnLoginKid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Kids"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Kids"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoginKid As Button
    Friend WithEvents btnHomeKid As Button
    Friend WithEvents lblKidsHeading As Label
End Class
