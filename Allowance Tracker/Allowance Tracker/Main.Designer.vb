<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnParentsHome = New System.Windows.Forms.Button()
        Me.btnKidsHome = New System.Windows.Forms.Button()
        Me.btnExitHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnParentsHome
        '
        Me.btnParentsHome.BackColor = System.Drawing.Color.Gainsboro
        Me.btnParentsHome.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnParentsHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParentsHome.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParentsHome.ForeColor = System.Drawing.Color.DimGray
        Me.btnParentsHome.Location = New System.Drawing.Point(111, 196)
        Me.btnParentsHome.Name = "btnParentsHome"
        Me.btnParentsHome.Size = New System.Drawing.Size(120, 37)
        Me.btnParentsHome.TabIndex = 0
        Me.btnParentsHome.Text = "Parents"
        Me.btnParentsHome.UseVisualStyleBackColor = False
        '
        'btnKidsHome
        '
        Me.btnKidsHome.BackColor = System.Drawing.Color.Gainsboro
        Me.btnKidsHome.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnKidsHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKidsHome.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKidsHome.ForeColor = System.Drawing.Color.DimGray
        Me.btnKidsHome.Location = New System.Drawing.Point(111, 249)
        Me.btnKidsHome.Name = "btnKidsHome"
        Me.btnKidsHome.Size = New System.Drawing.Size(120, 37)
        Me.btnKidsHome.TabIndex = 1
        Me.btnKidsHome.Text = "Kids"
        Me.btnKidsHome.UseVisualStyleBackColor = False
        '
        'btnExitHome
        '
        Me.btnExitHome.BackColor = System.Drawing.Color.Gainsboro
        Me.btnExitHome.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnExitHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitHome.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitHome.ForeColor = System.Drawing.Color.DimGray
        Me.btnExitHome.Location = New System.Drawing.Point(111, 302)
        Me.btnExitHome.Name = "btnExitHome"
        Me.btnExitHome.Size = New System.Drawing.Size(120, 37)
        Me.btnExitHome.TabIndex = 2
        Me.btnExitHome.Text = "Exit"
        Me.btnExitHome.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(340, 440)
        Me.Controls.Add(Me.btnExitHome)
        Me.Controls.Add(Me.btnKidsHome)
        Me.Controls.Add(Me.btnParentsHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Main"
        Me.Text = "Allowance Tracker"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnParentsHome As Button
    Friend WithEvents btnKidsHome As Button
    Friend WithEvents btnExitHome As Button
End Class
