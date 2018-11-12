<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrackAllowance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrackAllowance))
        Me.lblAllowanceAmount = New System.Windows.Forms.Label()
        Me.lblDateAllowance = New System.Windows.Forms.Label()
        Me.lblNoteAllowance = New System.Windows.Forms.Label()
        Me.txtAllowanceAmount = New System.Windows.Forms.TextBox()
        Me.txtNoteAllowance = New System.Windows.Forms.TextBox()
        Me.dtpAllowance = New System.Windows.Forms.DateTimePicker()
        Me.btnSubmitAllowance = New System.Windows.Forms.Button()
        Me.btnClearAllowance = New System.Windows.Forms.Button()
        Me.btnHomeAllowance = New System.Windows.Forms.Button()
        Me.lblErrorTrackAllowance = New System.Windows.Forms.Label()
        Me.lblChildNameAllowance = New System.Windows.Forms.Label()
        Me.cboChildNameAllowance = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblAllowanceAmount
        '
        Me.lblAllowanceAmount.AutoSize = True
        Me.lblAllowanceAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAllowanceAmount.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllowanceAmount.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblAllowanceAmount.Location = New System.Drawing.Point(12, 202)
        Me.lblAllowanceAmount.Name = "lblAllowanceAmount"
        Me.lblAllowanceAmount.Size = New System.Drawing.Size(216, 24)
        Me.lblAllowanceAmount.TabIndex = 8
        Me.lblAllowanceAmount.Text = "Allowance Amount:"
        '
        'lblDateAllowance
        '
        Me.lblDateAllowance.AutoSize = True
        Me.lblDateAllowance.BackColor = System.Drawing.Color.Transparent
        Me.lblDateAllowance.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateAllowance.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblDateAllowance.Location = New System.Drawing.Point(12, 246)
        Me.lblDateAllowance.Name = "lblDateAllowance"
        Me.lblDateAllowance.Size = New System.Drawing.Size(66, 24)
        Me.lblDateAllowance.TabIndex = 9
        Me.lblDateAllowance.Text = "Date:"
        '
        'lblNoteAllowance
        '
        Me.lblNoteAllowance.AutoSize = True
        Me.lblNoteAllowance.BackColor = System.Drawing.Color.Transparent
        Me.lblNoteAllowance.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteAllowance.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblNoteAllowance.Location = New System.Drawing.Point(12, 293)
        Me.lblNoteAllowance.Name = "lblNoteAllowance"
        Me.lblNoteAllowance.Size = New System.Drawing.Size(66, 24)
        Me.lblNoteAllowance.TabIndex = 10
        Me.lblNoteAllowance.Text = "Note:"
        '
        'txtAllowanceAmount
        '
        Me.txtAllowanceAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAllowanceAmount.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllowanceAmount.Location = New System.Drawing.Point(234, 202)
        Me.txtAllowanceAmount.Name = "txtAllowanceAmount"
        Me.txtAllowanceAmount.Size = New System.Drawing.Size(90, 26)
        Me.txtAllowanceAmount.TabIndex = 12
        '
        'txtNoteAllowance
        '
        Me.txtNoteAllowance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoteAllowance.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoteAllowance.Location = New System.Drawing.Point(84, 293)
        Me.txtNoteAllowance.Name = "txtNoteAllowance"
        Me.txtNoteAllowance.Size = New System.Drawing.Size(240, 26)
        Me.txtNoteAllowance.TabIndex = 13
        '
        'dtpAllowance
        '
        Me.dtpAllowance.CalendarFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAllowance.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAllowance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAllowance.Location = New System.Drawing.Point(162, 243)
        Me.dtpAllowance.Name = "dtpAllowance"
        Me.dtpAllowance.Size = New System.Drawing.Size(162, 33)
        Me.dtpAllowance.TabIndex = 14
        Me.dtpAllowance.Value = New Date(2018, 11, 9, 0, 0, 0, 0)
        '
        'btnSubmitAllowance
        '
        Me.btnSubmitAllowance.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSubmitAllowance.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnSubmitAllowance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitAllowance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitAllowance.ForeColor = System.Drawing.Color.DimGray
        Me.btnSubmitAllowance.Location = New System.Drawing.Point(41, 352)
        Me.btnSubmitAllowance.Name = "btnSubmitAllowance"
        Me.btnSubmitAllowance.Size = New System.Drawing.Size(120, 37)
        Me.btnSubmitAllowance.TabIndex = 15
        Me.btnSubmitAllowance.Text = "Submit"
        Me.btnSubmitAllowance.UseVisualStyleBackColor = False
        '
        'btnClearAllowance
        '
        Me.btnClearAllowance.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClearAllowance.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnClearAllowance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAllowance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAllowance.ForeColor = System.Drawing.Color.DimGray
        Me.btnClearAllowance.Location = New System.Drawing.Point(179, 352)
        Me.btnClearAllowance.Name = "btnClearAllowance"
        Me.btnClearAllowance.Size = New System.Drawing.Size(120, 37)
        Me.btnClearAllowance.TabIndex = 16
        Me.btnClearAllowance.Text = "Clear"
        Me.btnClearAllowance.UseVisualStyleBackColor = False
        '
        'btnHomeAllowance
        '
        Me.btnHomeAllowance.BackColor = System.Drawing.Color.Gainsboro
        Me.btnHomeAllowance.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnHomeAllowance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHomeAllowance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomeAllowance.ForeColor = System.Drawing.Color.DimGray
        Me.btnHomeAllowance.Location = New System.Drawing.Point(110, 395)
        Me.btnHomeAllowance.Name = "btnHomeAllowance"
        Me.btnHomeAllowance.Size = New System.Drawing.Size(120, 37)
        Me.btnHomeAllowance.TabIndex = 17
        Me.btnHomeAllowance.Text = "Home"
        Me.btnHomeAllowance.UseVisualStyleBackColor = False
        '
        'lblErrorTrackAllowance
        '
        Me.lblErrorTrackAllowance.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorTrackAllowance.ForeColor = System.Drawing.Color.Maroon
        Me.lblErrorTrackAllowance.Location = New System.Drawing.Point(16, 321)
        Me.lblErrorTrackAllowance.Name = "lblErrorTrackAllowance"
        Me.lblErrorTrackAllowance.Size = New System.Drawing.Size(308, 23)
        Me.lblErrorTrackAllowance.TabIndex = 18
        Me.lblErrorTrackAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblErrorTrackAllowance.Visible = False
        '
        'lblChildNameAllowance
        '
        Me.lblChildNameAllowance.AutoSize = True
        Me.lblChildNameAllowance.BackColor = System.Drawing.Color.Transparent
        Me.lblChildNameAllowance.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChildNameAllowance.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblChildNameAllowance.Location = New System.Drawing.Point(12, 161)
        Me.lblChildNameAllowance.Name = "lblChildNameAllowance"
        Me.lblChildNameAllowance.Size = New System.Drawing.Size(153, 24)
        Me.lblChildNameAllowance.TabIndex = 7
        Me.lblChildNameAllowance.Text = "Choose Child:"
        '
        'cboChildNameAllowance
        '
        Me.cboChildNameAllowance.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChildNameAllowance.FormattingEnabled = True
        Me.cboChildNameAllowance.Location = New System.Drawing.Point(171, 160)
        Me.cboChildNameAllowance.Name = "cboChildNameAllowance"
        Me.cboChildNameAllowance.Size = New System.Drawing.Size(153, 30)
        Me.cboChildNameAllowance.TabIndex = 19
        '
        'TrackAllowance
        '
        Me.AcceptButton = Me.btnSubmitAllowance
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.cboChildNameAllowance)
        Me.Controls.Add(Me.lblErrorTrackAllowance)
        Me.Controls.Add(Me.btnHomeAllowance)
        Me.Controls.Add(Me.btnClearAllowance)
        Me.Controls.Add(Me.btnSubmitAllowance)
        Me.Controls.Add(Me.dtpAllowance)
        Me.Controls.Add(Me.txtNoteAllowance)
        Me.Controls.Add(Me.txtAllowanceAmount)
        Me.Controls.Add(Me.lblNoteAllowance)
        Me.Controls.Add(Me.lblDateAllowance)
        Me.Controls.Add(Me.lblAllowanceAmount)
        Me.Controls.Add(Me.lblChildNameAllowance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "TrackAllowance"
        Me.Text = "Track Allowance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAllowanceAmount As Label
    Friend WithEvents lblDateAllowance As Label
    Friend WithEvents lblNoteAllowance As Label
    Friend WithEvents txtAllowanceAmount As TextBox
    Friend WithEvents txtNoteAllowance As TextBox
    Friend WithEvents dtpAllowance As DateTimePicker
    Friend WithEvents btnSubmitAllowance As Button
    Friend WithEvents btnClearAllowance As Button
    Friend WithEvents btnHomeAllowance As Button
    Friend WithEvents lblErrorTrackAllowance As Label
    Friend WithEvents lblChildNameAllowance As Label
    Friend WithEvents cboChildNameAllowance As ComboBox
End Class
