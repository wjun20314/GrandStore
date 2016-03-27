<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Replenishment
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
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.manRepl = New System.Windows.Forms.RadioButton()
        Me.autoRepl = New System.Windows.Forms.RadioButton()
        Me.replDgv = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.replQty = New System.Windows.Forms.TextBox()
        Me.btnRepl = New System.Windows.Forms.Button()
        Me.gb1.SuspendLayout()
        CType(Me.replDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.manRepl)
        Me.gb1.Controls.Add(Me.autoRepl)
        Me.gb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb1.Location = New System.Drawing.Point(12, 12)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(341, 55)
        Me.gb1.TabIndex = 2
        Me.gb1.TabStop = False
        Me.gb1.Text = "Replenishment Settings"
        '
        'manRepl
        '
        Me.manRepl.AutoSize = True
        Me.manRepl.Location = New System.Drawing.Point(168, 25)
        Me.manRepl.Name = "manRepl"
        Me.manRepl.Size = New System.Drawing.Size(155, 19)
        Me.manRepl.TabIndex = 1
        Me.manRepl.Text = "Manual-Replenishment"
        Me.manRepl.UseVisualStyleBackColor = True
        '
        'autoRepl
        '
        Me.autoRepl.AutoSize = True
        Me.autoRepl.Checked = True
        Me.autoRepl.Location = New System.Drawing.Point(15, 25)
        Me.autoRepl.Name = "autoRepl"
        Me.autoRepl.Size = New System.Drawing.Size(137, 19)
        Me.autoRepl.TabIndex = 0
        Me.autoRepl.TabStop = True
        Me.autoRepl.Text = "Auto-Replenishment"
        Me.autoRepl.UseVisualStyleBackColor = True
        '
        'replDgv
        '
        Me.replDgv.AllowUserToAddRows = False
        Me.replDgv.AllowUserToDeleteRows = False
        Me.replDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.replDgv.Location = New System.Drawing.Point(12, 83)
        Me.replDgv.Name = "replDgv"
        Me.replDgv.ReadOnly = True
        Me.replDgv.Size = New System.Drawing.Size(472, 239)
        Me.replDgv.TabIndex = 3
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.FinalYearProject.My.Resources.Resources.recycle_16
        Me.btnRefresh.Location = New System.Drawing.Point(441, 44)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(43, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'replQty
        '
        Me.replQty.Location = New System.Drawing.Point(139, 340)
        Me.replQty.Name = "replQty"
        Me.replQty.Size = New System.Drawing.Size(137, 20)
        Me.replQty.TabIndex = 5
        '
        'btnRepl
        '
        Me.btnRepl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepl.Location = New System.Drawing.Point(282, 338)
        Me.btnRepl.Name = "btnRepl"
        Me.btnRepl.Size = New System.Drawing.Size(75, 23)
        Me.btnRepl.TabIndex = 6
        Me.btnRepl.Text = "&Replenish"
        Me.btnRepl.UseVisualStyleBackColor = True
        '
        'Replenishment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 375)
        Me.Controls.Add(Me.btnRepl)
        Me.Controls.Add(Me.replQty)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.replDgv)
        Me.Controls.Add(Me.gb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Replenishment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Replenishment"
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        CType(Me.replDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents manRepl As System.Windows.Forms.RadioButton
    Friend WithEvents autoRepl As System.Windows.Forms.RadioButton
    Friend WithEvents replDgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents replQty As System.Windows.Forms.TextBox
    Friend WithEvents btnRepl As System.Windows.Forms.Button
End Class
