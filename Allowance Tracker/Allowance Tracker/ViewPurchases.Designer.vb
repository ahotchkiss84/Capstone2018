<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPurchases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewPurchases))
        Me.lstvPurchase = New System.Windows.Forms.ListView()
        Me.colDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnBackPurchase = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstvPurchase
        '
        Me.lstvPurchase.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDate, Me.colAmount, Me.colDescription})
        Me.lstvPurchase.Location = New System.Drawing.Point(12, 141)
        Me.lstvPurchase.Name = "lstvPurchase"
        Me.lstvPurchase.Size = New System.Drawing.Size(316, 245)
        Me.lstvPurchase.TabIndex = 0
        Me.lstvPurchase.UseCompatibleStateImageBehavior = False
        Me.lstvPurchase.View = System.Windows.Forms.View.Details
        '
        'colDate
        '
        Me.colDate.Text = "Date"
        Me.colDate.Width = 77
        '
        'colAmount
        '
        Me.colAmount.Text = "Item Amount"
        Me.colAmount.Width = 73
        '
        'colDescription
        '
        Me.colDescription.Text = "Item Description"
        Me.colDescription.Width = 160
        '
        'btnBackPurchase
        '
        Me.btnBackPurchase.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBackPurchase.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnBackPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackPurchase.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackPurchase.ForeColor = System.Drawing.Color.DimGray
        Me.btnBackPurchase.Location = New System.Drawing.Point(110, 394)
        Me.btnBackPurchase.Name = "btnBackPurchase"
        Me.btnBackPurchase.Size = New System.Drawing.Size(120, 37)
        Me.btnBackPurchase.TabIndex = 15
        Me.btnBackPurchase.Text = "Back"
        Me.btnBackPurchase.UseVisualStyleBackColor = False
        '
        'ViewPurchases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.btnBackPurchase)
        Me.Controls.Add(Me.lstvPurchase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ViewPurchases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "View Purchases"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstvPurchase As ListView
    Friend WithEvents colDate As ColumnHeader
    Friend WithEvents colAmount As ColumnHeader
    Friend WithEvents colDescription As ColumnHeader
    Friend WithEvents btnBackPurchase As Button
End Class
