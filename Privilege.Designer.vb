<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Privilege
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mcb1 = New System.Windows.Forms.CheckBox()
        Me.mcb3 = New System.Windows.Forms.CheckBox()
        Me.mcb2 = New System.Windows.Forms.CheckBox()
        Me.mcb4 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.supcb4 = New System.Windows.Forms.CheckBox()
        Me.supcb2 = New System.Windows.Forms.CheckBox()
        Me.supcb3 = New System.Windows.Forms.CheckBox()
        Me.supcb1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.sfcb4 = New System.Windows.Forms.CheckBox()
        Me.sfcb2 = New System.Windows.Forms.CheckBox()
        Me.sfcb3 = New System.Windows.Forms.CheckBox()
        Me.sfcb1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(258, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "** Selected choice is accessible to the module"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mcb4)
        Me.GroupBox1.Controls.Add(Me.mcb2)
        Me.GroupBox1.Controls.Add(Me.mcb3)
        Me.GroupBox1.Controls.Add(Me.mcb1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 83)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manager"
        '
        'mcb1
        '
        Me.mcb1.AutoSize = True
        Me.mcb1.Location = New System.Drawing.Point(15, 28)
        Me.mcb1.Name = "mcb1"
        Me.mcb1.Size = New System.Drawing.Size(72, 19)
        Me.mcb1.TabIndex = 0
        Me.mcb1.Text = "Manage"
        Me.mcb1.UseVisualStyleBackColor = True
        '
        'mcb3
        '
        Me.mcb3.AutoSize = True
        Me.mcb3.Location = New System.Drawing.Point(15, 51)
        Me.mcb3.Name = "mcb3"
        Me.mcb3.Size = New System.Drawing.Size(73, 19)
        Me.mcb3.TabIndex = 2
        Me.mcb3.Text = "Privilege"
        Me.mcb3.UseVisualStyleBackColor = True
        '
        'mcb2
        '
        Me.mcb2.AutoSize = True
        Me.mcb2.Location = New System.Drawing.Point(128, 28)
        Me.mcb2.Name = "mcb2"
        Me.mcb2.Size = New System.Drawing.Size(99, 19)
        Me.mcb2.TabIndex = 1
        Me.mcb2.Text = "Import/Export"
        Me.mcb2.UseVisualStyleBackColor = True
        '
        'mcb4
        '
        Me.mcb4.AutoSize = True
        Me.mcb4.Location = New System.Drawing.Point(128, 51)
        Me.mcb4.Name = "mcb4"
        Me.mcb4.Size = New System.Drawing.Size(110, 19)
        Me.mcb4.TabIndex = 3
        Me.mcb4.Text = "Replenishment"
        Me.mcb4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.supcb4)
        Me.GroupBox2.Controls.Add(Me.supcb2)
        Me.GroupBox2.Controls.Add(Me.supcb3)
        Me.GroupBox2.Controls.Add(Me.supcb1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 83)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Supervisor"
        '
        'supcb4
        '
        Me.supcb4.AutoSize = True
        Me.supcb4.Location = New System.Drawing.Point(128, 51)
        Me.supcb4.Name = "supcb4"
        Me.supcb4.Size = New System.Drawing.Size(110, 19)
        Me.supcb4.TabIndex = 7
        Me.supcb4.Text = "Replenishment"
        Me.supcb4.UseVisualStyleBackColor = True
        '
        'supcb2
        '
        Me.supcb2.AutoSize = True
        Me.supcb2.Location = New System.Drawing.Point(128, 28)
        Me.supcb2.Name = "supcb2"
        Me.supcb2.Size = New System.Drawing.Size(99, 19)
        Me.supcb2.TabIndex = 5
        Me.supcb2.Text = "Import/Export"
        Me.supcb2.UseVisualStyleBackColor = True
        '
        'supcb3
        '
        Me.supcb3.AutoSize = True
        Me.supcb3.Location = New System.Drawing.Point(15, 51)
        Me.supcb3.Name = "supcb3"
        Me.supcb3.Size = New System.Drawing.Size(73, 19)
        Me.supcb3.TabIndex = 6
        Me.supcb3.Text = "Privilege"
        Me.supcb3.UseVisualStyleBackColor = True
        '
        'supcb1
        '
        Me.supcb1.AutoSize = True
        Me.supcb1.Location = New System.Drawing.Point(15, 28)
        Me.supcb1.Name = "supcb1"
        Me.supcb1.Size = New System.Drawing.Size(72, 19)
        Me.supcb1.TabIndex = 4
        Me.supcb1.Text = "Manage"
        Me.supcb1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.sfcb4)
        Me.GroupBox3.Controls.Add(Me.sfcb2)
        Me.GroupBox3.Controls.Add(Me.sfcb3)
        Me.GroupBox3.Controls.Add(Me.sfcb1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 241)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(246, 83)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Staff"
        '
        'sfcb4
        '
        Me.sfcb4.AutoSize = True
        Me.sfcb4.Location = New System.Drawing.Point(128, 51)
        Me.sfcb4.Name = "sfcb4"
        Me.sfcb4.Size = New System.Drawing.Size(110, 19)
        Me.sfcb4.TabIndex = 11
        Me.sfcb4.Text = "Replenishment"
        Me.sfcb4.UseVisualStyleBackColor = True
        '
        'sfcb2
        '
        Me.sfcb2.AutoSize = True
        Me.sfcb2.Location = New System.Drawing.Point(128, 28)
        Me.sfcb2.Name = "sfcb2"
        Me.sfcb2.Size = New System.Drawing.Size(99, 19)
        Me.sfcb2.TabIndex = 9
        Me.sfcb2.Text = "Import/Export"
        Me.sfcb2.UseVisualStyleBackColor = True
        '
        'sfcb3
        '
        Me.sfcb3.AutoSize = True
        Me.sfcb3.Location = New System.Drawing.Point(15, 51)
        Me.sfcb3.Name = "sfcb3"
        Me.sfcb3.Size = New System.Drawing.Size(73, 19)
        Me.sfcb3.TabIndex = 10
        Me.sfcb3.Text = "Privilege"
        Me.sfcb3.UseVisualStyleBackColor = True
        '
        'sfcb1
        '
        Me.sfcb1.AutoSize = True
        Me.sfcb1.Location = New System.Drawing.Point(15, 28)
        Me.sfcb1.Name = "sfcb1"
        Me.sfcb1.Size = New System.Drawing.Size(72, 19)
        Me.sfcb1.TabIndex = 8
        Me.sfcb1.Text = "Manage"
        Me.sfcb1.UseVisualStyleBackColor = True
        '
        'Privilege
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 343)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Privilege"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Privilege Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mcb4 As System.Windows.Forms.CheckBox
    Friend WithEvents mcb2 As System.Windows.Forms.CheckBox
    Friend WithEvents mcb3 As System.Windows.Forms.CheckBox
    Friend WithEvents mcb1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents supcb4 As System.Windows.Forms.CheckBox
    Friend WithEvents supcb2 As System.Windows.Forms.CheckBox
    Friend WithEvents supcb3 As System.Windows.Forms.CheckBox
    Friend WithEvents supcb1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents sfcb4 As System.Windows.Forms.CheckBox
    Friend WithEvents sfcb2 As System.Windows.Forms.CheckBox
    Friend WithEvents sfcb3 As System.Windows.Forms.CheckBox
    Friend WithEvents sfcb1 As System.Windows.Forms.CheckBox
End Class
