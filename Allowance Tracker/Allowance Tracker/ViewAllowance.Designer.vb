<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAllowance
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
        Me.lstvAllowance = New System.Windows.Forms.ListView()
        Me.colDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNote = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnBackAllowance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstvAllowance
        '
        Me.lstvAllowance.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDate, Me.colAmount, Me.colNote})
        Me.lstvAllowance.Location = New System.Drawing.Point(12, 143)
        Me.lstvAllowance.Name = "lstvAllowance"
        Me.lstvAllowance.Size = New System.Drawing.Size(316, 245)
        Me.lstvAllowance.TabIndex = 0
        Me.lstvAllowance.UseCompatibleStateImageBehavior = False
        Me.lstvAllowance.View = System.Windows.Forms.View.Details
        '
        'colDate
        '
        Me.colDate.Text = "Date"
        Me.colDate.Width = 82
        '
        'colAmount
        '
        Me.colAmount.Text = "Amount"
        Me.colAmount.Width = 67
        '
        'colNote
        '
        Me.colNote.Text = "Note"
        Me.colNote.Width = 163
        '
        'btnBackAllowance
        '
        Me.btnBackAllowance.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBackAllowance.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnBackAllowance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackAllowance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackAllowance.ForeColor = System.Drawing.Color.DimGray
        Me.btnBackAllowance.Location = New System.Drawing.Point(110, 394)
        Me.btnBackAllowance.Name = "btnBackAllowance"
        Me.btnBackAllowance.Size = New System.Drawing.Size(120, 37)
        Me.btnBackAllowance.TabIndex = 14
        Me.btnBackAllowance.Text = "Back"
        Me.btnBackAllowance.UseVisualStyleBackColor = False
        '
        'ViewAllowance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Allowance_Tracker.My.Resources.Resources.BoCbgmain
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.btnBackAllowance)
        Me.Controls.Add(Me.lstvAllowance)
        Me.Name = "ViewAllowance"
        Me.Text = "View Allowance"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstvAllowance As ListView
    Friend WithEvents colDate As ColumnHeader
    Friend WithEvents colAmount As ColumnHeader
    Friend WithEvents colNote As ColumnHeader
    Friend WithEvents btnBackAllowance As Button
End Class
