<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KidMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KidMain))
        Me.btnCheckAllowanceBalance = New System.Windows.Forms.Button()
        Me.btnCheckPurchaseHistory = New System.Windows.Forms.Button()
        Me.btnReturnHomeKid = New System.Windows.Forms.Button()
        Me.btnCurrentBalance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCheckAllowanceBalance
        '
        Me.btnCheckAllowanceBalance.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCheckAllowanceBalance.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnCheckAllowanceBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckAllowanceBalance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAllowanceBalance.ForeColor = System.Drawing.Color.DimGray
        Me.btnCheckAllowanceBalance.Location = New System.Drawing.Point(53, 160)
        Me.btnCheckAllowanceBalance.Name = "btnCheckAllowanceBalance"
        Me.btnCheckAllowanceBalance.Size = New System.Drawing.Size(235, 37)
        Me.btnCheckAllowanceBalance.TabIndex = 14
        Me.btnCheckAllowanceBalance.Text = "Check Allowance History"
        Me.btnCheckAllowanceBalance.UseVisualStyleBackColor = False
        '
        'btnCheckPurchaseHistory
        '
        Me.btnCheckPurchaseHistory.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCheckPurchaseHistory.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnCheckPurchaseHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckPurchaseHistory.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckPurchaseHistory.ForeColor = System.Drawing.Color.DimGray
        Me.btnCheckPurchaseHistory.Location = New System.Drawing.Point(53, 216)
        Me.btnCheckPurchaseHistory.Name = "btnCheckPurchaseHistory"
        Me.btnCheckPurchaseHistory.Size = New System.Drawing.Size(235, 37)
        Me.btnCheckPurchaseHistory.TabIndex = 15
        Me.btnCheckPurchaseHistory.Text = "Check Purchase History"
        Me.btnCheckPurchaseHistory.UseVisualStyleBackColor = False
        '
        'btnReturnHomeKid
        '
        Me.btnReturnHomeKid.BackColor = System.Drawing.Color.Gainsboro
        Me.btnReturnHomeKid.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnReturnHomeKid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnHomeKid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnHomeKid.ForeColor = System.Drawing.Color.DimGray
        Me.btnReturnHomeKid.Location = New System.Drawing.Point(53, 328)
        Me.btnReturnHomeKid.Name = "btnReturnHomeKid"
        Me.btnReturnHomeKid.Size = New System.Drawing.Size(235, 37)
        Me.btnReturnHomeKid.TabIndex = 16
        Me.btnReturnHomeKid.Text = "Return Home"
        Me.btnReturnHomeKid.UseVisualStyleBackColor = False
        '
        'btnCurrentBalance
        '
        Me.btnCurrentBalance.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCurrentBalance.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnCurrentBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCurrentBalance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentBalance.ForeColor = System.Drawing.Color.DimGray
        Me.btnCurrentBalance.Location = New System.Drawing.Point(53, 272)
        Me.btnCurrentBalance.Name = "btnCurrentBalance"
        Me.btnCurrentBalance.Size = New System.Drawing.Size(235, 37)
        Me.btnCurrentBalance.TabIndex = 17
        Me.btnCurrentBalance.Text = "Current Account Balance"
        Me.btnCurrentBalance.UseVisualStyleBackColor = False
        '
        'KidMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.btnCurrentBalance)
        Me.Controls.Add(Me.btnReturnHomeKid)
        Me.Controls.Add(Me.btnCheckPurchaseHistory)
        Me.Controls.Add(Me.btnCheckAllowanceBalance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "KidMain"
        Me.Text = "Kid Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCheckAllowanceBalance As Button
    Friend WithEvents btnCheckPurchaseHistory As Button
    Friend WithEvents btnReturnHomeKid As Button
    Friend WithEvents btnCurrentBalance As Button
End Class
