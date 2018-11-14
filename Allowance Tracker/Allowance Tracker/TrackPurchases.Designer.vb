<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrackPurchases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrackPurchases))
        Me.lblChildNamePurchases = New System.Windows.Forms.Label()
        Me.lblItemCostPurchases = New System.Windows.Forms.Label()
        Me.txtItemCostPurchases = New System.Windows.Forms.TextBox()
        Me.lblDescriptionPurchases = New System.Windows.Forms.Label()
        Me.txtNotePurchases = New System.Windows.Forms.TextBox()
        Me.lblDatePurchases = New System.Windows.Forms.Label()
        Me.dtpPurchases = New System.Windows.Forms.DateTimePicker()
        Me.btnSubmitPurchases = New System.Windows.Forms.Button()
        Me.btnClearPurchases = New System.Windows.Forms.Button()
        Me.btnHomePurchases = New System.Windows.Forms.Button()
        Me.lblErrorPurchases = New System.Windows.Forms.Label()
        Me.cboChooseNamePurchases = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblChildNamePurchases
        '
        Me.lblChildNamePurchases.AutoSize = True
        Me.lblChildNamePurchases.BackColor = System.Drawing.Color.Transparent
        Me.lblChildNamePurchases.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChildNamePurchases.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblChildNamePurchases.Location = New System.Drawing.Point(12, 154)
        Me.lblChildNamePurchases.Name = "lblChildNamePurchases"
        Me.lblChildNamePurchases.Size = New System.Drawing.Size(153, 24)
        Me.lblChildNamePurchases.TabIndex = 8
        Me.lblChildNamePurchases.Text = "Choose Child:"
        '
        'lblItemCostPurchases
        '
        Me.lblItemCostPurchases.AutoSize = True
        Me.lblItemCostPurchases.BackColor = System.Drawing.Color.Transparent
        Me.lblItemCostPurchases.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCostPurchases.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblItemCostPurchases.Location = New System.Drawing.Point(12, 199)
        Me.lblItemCostPurchases.Name = "lblItemCostPurchases"
        Me.lblItemCostPurchases.Size = New System.Drawing.Size(114, 24)
        Me.lblItemCostPurchases.TabIndex = 13
        Me.lblItemCostPurchases.Text = "Item Cost:"
        '
        'txtItemCostPurchases
        '
        Me.txtItemCostPurchases.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtItemCostPurchases.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCostPurchases.Location = New System.Drawing.Point(234, 199)
        Me.txtItemCostPurchases.Name = "txtItemCostPurchases"
        Me.txtItemCostPurchases.Size = New System.Drawing.Size(90, 26)
        Me.txtItemCostPurchases.TabIndex = 14
        '
        'lblDescriptionPurchases
        '
        Me.lblDescriptionPurchases.AutoSize = True
        Me.lblDescriptionPurchases.BackColor = System.Drawing.Color.Transparent
        Me.lblDescriptionPurchases.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionPurchases.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblDescriptionPurchases.Location = New System.Drawing.Point(12, 241)
        Me.lblDescriptionPurchases.Name = "lblDescriptionPurchases"
        Me.lblDescriptionPurchases.Size = New System.Drawing.Size(127, 24)
        Me.lblDescriptionPurchases.TabIndex = 15
        Me.lblDescriptionPurchases.Text = "Description:"
        '
        'txtNotePurchases
        '
        Me.txtNotePurchases.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNotePurchases.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotePurchases.Location = New System.Drawing.Point(145, 241)
        Me.txtNotePurchases.Name = "txtNotePurchases"
        Me.txtNotePurchases.Size = New System.Drawing.Size(179, 26)
        Me.txtNotePurchases.TabIndex = 16
        '
        'lblDatePurchases
        '
        Me.lblDatePurchases.AutoSize = True
        Me.lblDatePurchases.BackColor = System.Drawing.Color.Transparent
        Me.lblDatePurchases.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatePurchases.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblDatePurchases.Location = New System.Drawing.Point(12, 288)
        Me.lblDatePurchases.Name = "lblDatePurchases"
        Me.lblDatePurchases.Size = New System.Drawing.Size(66, 24)
        Me.lblDatePurchases.TabIndex = 17
        Me.lblDatePurchases.Text = "Date:"
        '
        'dtpPurchases
        '
        Me.dtpPurchases.CalendarFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurchases.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurchases.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPurchases.Location = New System.Drawing.Point(162, 284)
        Me.dtpPurchases.Name = "dtpPurchases"
        Me.dtpPurchases.Size = New System.Drawing.Size(162, 33)
        Me.dtpPurchases.TabIndex = 18
        Me.dtpPurchases.Value = New Date(2018, 11, 9, 0, 0, 0, 0)
        '
        'btnSubmitPurchases
        '
        Me.btnSubmitPurchases.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSubmitPurchases.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnSubmitPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitPurchases.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitPurchases.ForeColor = System.Drawing.Color.DimGray
        Me.btnSubmitPurchases.Location = New System.Drawing.Point(41, 351)
        Me.btnSubmitPurchases.Name = "btnSubmitPurchases"
        Me.btnSubmitPurchases.Size = New System.Drawing.Size(120, 37)
        Me.btnSubmitPurchases.TabIndex = 19
        Me.btnSubmitPurchases.Text = "Submit"
        Me.btnSubmitPurchases.UseVisualStyleBackColor = False
        '
        'btnClearPurchases
        '
        Me.btnClearPurchases.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClearPurchases.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnClearPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearPurchases.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearPurchases.ForeColor = System.Drawing.Color.DimGray
        Me.btnClearPurchases.Location = New System.Drawing.Point(179, 351)
        Me.btnClearPurchases.Name = "btnClearPurchases"
        Me.btnClearPurchases.Size = New System.Drawing.Size(120, 37)
        Me.btnClearPurchases.TabIndex = 20
        Me.btnClearPurchases.Text = "Clear"
        Me.btnClearPurchases.UseVisualStyleBackColor = False
        '
        'btnHomePurchases
        '
        Me.btnHomePurchases.BackColor = System.Drawing.Color.Gainsboro
        Me.btnHomePurchases.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnHomePurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHomePurchases.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomePurchases.ForeColor = System.Drawing.Color.DimGray
        Me.btnHomePurchases.Location = New System.Drawing.Point(107, 398)
        Me.btnHomePurchases.Name = "btnHomePurchases"
        Me.btnHomePurchases.Size = New System.Drawing.Size(120, 37)
        Me.btnHomePurchases.TabIndex = 21
        Me.btnHomePurchases.Text = "Home"
        Me.btnHomePurchases.UseVisualStyleBackColor = False
        '
        'lblErrorPurchases
        '
        Me.lblErrorPurchases.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorPurchases.ForeColor = System.Drawing.Color.Maroon
        Me.lblErrorPurchases.Location = New System.Drawing.Point(13, 323)
        Me.lblErrorPurchases.Name = "lblErrorPurchases"
        Me.lblErrorPurchases.Size = New System.Drawing.Size(311, 23)
        Me.lblErrorPurchases.TabIndex = 22
        Me.lblErrorPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblErrorPurchases.Visible = False
        '
        'cboChooseNamePurchases
        '
        Me.cboChooseNamePurchases.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChooseNamePurchases.FormattingEnabled = True
        Me.cboChooseNamePurchases.Location = New System.Drawing.Point(171, 154)
        Me.cboChooseNamePurchases.Name = "cboChooseNamePurchases"
        Me.cboChooseNamePurchases.Size = New System.Drawing.Size(153, 30)
        Me.cboChooseNamePurchases.TabIndex = 23
        '
        'TrackPurchases
        '
        Me.AcceptButton = Me.btnSubmitPurchases
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.cboChooseNamePurchases)
        Me.Controls.Add(Me.lblErrorPurchases)
        Me.Controls.Add(Me.btnHomePurchases)
        Me.Controls.Add(Me.btnClearPurchases)
        Me.Controls.Add(Me.btnSubmitPurchases)
        Me.Controls.Add(Me.dtpPurchases)
        Me.Controls.Add(Me.lblDatePurchases)
        Me.Controls.Add(Me.txtNotePurchases)
        Me.Controls.Add(Me.lblDescriptionPurchases)
        Me.Controls.Add(Me.txtItemCostPurchases)
        Me.Controls.Add(Me.lblItemCostPurchases)
        Me.Controls.Add(Me.lblChildNamePurchases)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "TrackPurchases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Track Purchases"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChildNamePurchases As Label
    Friend WithEvents lblItemCostPurchases As Label
    Friend WithEvents txtItemCostPurchases As TextBox
    Friend WithEvents lblDescriptionPurchases As Label
    Friend WithEvents txtNotePurchases As TextBox
    Friend WithEvents lblDatePurchases As Label
    Friend WithEvents dtpPurchases As DateTimePicker
    Friend WithEvents btnSubmitPurchases As Button
    Friend WithEvents btnClearPurchases As Button
    Friend WithEvents btnHomePurchases As Button
    Friend WithEvents lblErrorPurchases As Label
    Friend WithEvents cboChooseNamePurchases As ComboBox
End Class
