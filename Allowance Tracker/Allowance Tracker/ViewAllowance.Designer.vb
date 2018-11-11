<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewAllowance
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewAllowance))
        Me.AllowanceTracker1DataSet1 = New Allowance_Tracker.AllowanceTracker1DataSet1()
        Me.AllowanceTracker1DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBackAllowance = New System.Windows.Forms.Button()
        Me.btnExitAllowance = New System.Windows.Forms.Button()
        Me.TblAllowanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAllowanceTableAdapter = New Allowance_Tracker.AllowanceTracker1DataSet1TableAdapters.tblAllowanceTableAdapter()
        Me.TblAllowanceBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        CType(Me.AllowanceTracker1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllowanceTracker1DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAllowanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAllowanceBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AllowanceTracker1DataSet1
        '
        Me.AllowanceTracker1DataSet1.DataSetName = "AllowanceTracker1DataSet1"
        Me.AllowanceTracker1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AllowanceTracker1DataSet1BindingSource
        '
        Me.AllowanceTracker1DataSet1BindingSource.DataSource = Me.AllowanceTracker1DataSet1
        Me.AllowanceTracker1DataSet1BindingSource.Position = 0
        '
        'btnBackAllowance
        '
        Me.btnBackAllowance.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBackAllowance.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnBackAllowance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackAllowance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackAllowance.ForeColor = System.Drawing.Color.DimGray
        Me.btnBackAllowance.Location = New System.Drawing.Point(33, 391)
        Me.btnBackAllowance.Name = "btnBackAllowance"
        Me.btnBackAllowance.Size = New System.Drawing.Size(120, 37)
        Me.btnBackAllowance.TabIndex = 15
        Me.btnBackAllowance.Text = "Back"
        Me.btnBackAllowance.UseVisualStyleBackColor = False
        '
        'btnExitAllowance
        '
        Me.btnExitAllowance.BackColor = System.Drawing.Color.Gainsboro
        Me.btnExitAllowance.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnExitAllowance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitAllowance.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitAllowance.ForeColor = System.Drawing.Color.DimGray
        Me.btnExitAllowance.Location = New System.Drawing.Point(169, 391)
        Me.btnExitAllowance.Name = "btnExitAllowance"
        Me.btnExitAllowance.Size = New System.Drawing.Size(120, 37)
        Me.btnExitAllowance.TabIndex = 16
        Me.btnExitAllowance.Text = "Exit"
        Me.btnExitAllowance.UseVisualStyleBackColor = False
        '
        'TblAllowanceBindingSource
        '
        Me.TblAllowanceBindingSource.DataMember = "tblAllowance"
        Me.TblAllowanceBindingSource.DataSource = Me.AllowanceTracker1DataSet1BindingSource
        '
        'TblAllowanceTableAdapter
        '
        Me.TblAllowanceTableAdapter.ClearBeforeFill = True
        '
        'TblAllowanceBindingSource1
        '
        Me.TblAllowanceBindingSource1.DataMember = "tblAllowance"
        Me.TblAllowanceBindingSource1.DataSource = Me.AllowanceTracker1DataSet1BindingSource
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(37, 187)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(121, 97)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ViewAllowance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnExitAllowance)
        Me.Controls.Add(Me.btnBackAllowance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ViewAllowance"
        Me.Text = "View Allowance"
        CType(Me.AllowanceTracker1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllowanceTracker1DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAllowanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAllowanceBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AllowanceTracker1DataSet1 As AllowanceTracker1DataSet1
    Friend WithEvents AllowanceTracker1DataSet1BindingSource As BindingSource
    Friend WithEvents btnBackAllowance As Button
    Friend WithEvents btnExitAllowance As Button
    Friend WithEvents TblAllowanceBindingSource As BindingSource
    Friend WithEvents TblAllowanceTableAdapter As AllowanceTracker1DataSet1TableAdapters.tblAllowanceTableAdapter
    Friend WithEvents TblAllowanceBindingSource1 As BindingSource
    Friend WithEvents ListView1 As ListView
End Class
