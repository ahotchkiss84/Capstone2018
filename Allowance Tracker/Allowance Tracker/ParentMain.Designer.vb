<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParentMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParentMain))
        Me.btnNewChild = New System.Windows.Forms.Button()
        Me.btnTrackAllowance = New System.Windows.Forms.Button()
        Me.btnTrackPurchase = New System.Windows.Forms.Button()
        Me.btnHomeParentMain = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewChild
        '
        Me.btnNewChild.BackColor = System.Drawing.Color.Gainsboro
        Me.btnNewChild.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnNewChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewChild.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewChild.ForeColor = System.Drawing.Color.DimGray
        Me.btnNewChild.Location = New System.Drawing.Point(68, 176)
        Me.btnNewChild.Name = "btnNewChild"
        Me.btnNewChild.Size = New System.Drawing.Size(204, 37)
        Me.btnNewChild.TabIndex = 13
        Me.btnNewChild.Text = "New Child Account"
        Me.btnNewChild.UseVisualStyleBackColor = False
        '
        'btnTrackAllowance
        '
        Me.btnTrackAllowance.BackColor = System.Drawing.Color.Gainsboro
        Me.btnTrackAllowance.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnTrackAllowance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrackAllowance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrackAllowance.ForeColor = System.Drawing.Color.DimGray
        Me.btnTrackAllowance.Location = New System.Drawing.Point(68, 226)
        Me.btnTrackAllowance.Name = "btnTrackAllowance"
        Me.btnTrackAllowance.Size = New System.Drawing.Size(204, 37)
        Me.btnTrackAllowance.TabIndex = 14
        Me.btnTrackAllowance.Text = "Track Allowance"
        Me.btnTrackAllowance.UseVisualStyleBackColor = False
        '
        'btnTrackPurchase
        '
        Me.btnTrackPurchase.BackColor = System.Drawing.Color.Gainsboro
        Me.btnTrackPurchase.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnTrackPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrackPurchase.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrackPurchase.ForeColor = System.Drawing.Color.DimGray
        Me.btnTrackPurchase.Location = New System.Drawing.Point(68, 275)
        Me.btnTrackPurchase.Name = "btnTrackPurchase"
        Me.btnTrackPurchase.Size = New System.Drawing.Size(204, 37)
        Me.btnTrackPurchase.TabIndex = 15
        Me.btnTrackPurchase.Text = "Track Purchase"
        Me.btnTrackPurchase.UseVisualStyleBackColor = False
        '
        'btnHomeParentMain
        '
        Me.btnHomeParentMain.BackColor = System.Drawing.Color.Gainsboro
        Me.btnHomeParentMain.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnHomeParentMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHomeParentMain.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeParentMain.ForeColor = System.Drawing.Color.DimGray
        Me.btnHomeParentMain.Location = New System.Drawing.Point(68, 324)
        Me.btnHomeParentMain.Name = "btnHomeParentMain"
        Me.btnHomeParentMain.Size = New System.Drawing.Size(204, 37)
        Me.btnHomeParentMain.TabIndex = 16
        Me.btnHomeParentMain.Text = "Return Home"
        Me.btnHomeParentMain.UseVisualStyleBackColor = False
        '
        'ParentMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.btnHomeParentMain)
        Me.Controls.Add(Me.btnTrackPurchase)
        Me.Controls.Add(Me.btnTrackAllowance)
        Me.Controls.Add(Me.btnNewChild)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ParentMain"
        Me.Text = "Parent Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNewChild As Button
    Friend WithEvents btnTrackAllowance As Button
    Friend WithEvents btnTrackPurchase As Button
    Friend WithEvents btnHomeParentMain As Button
End Class
