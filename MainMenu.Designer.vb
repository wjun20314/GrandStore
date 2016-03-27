<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.btnAcc = New System.Windows.Forms.Button()
        Me.btnRepl = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnInOut = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnManage = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLogged = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAcc
        '
        Me.btnAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcc.Image = Global.FinalYearProject.My.Resources.Resources.account
        Me.btnAcc.Location = New System.Drawing.Point(486, 123)
        Me.btnAcc.Name = "btnAcc"
        Me.btnAcc.Size = New System.Drawing.Size(100, 105)
        Me.btnAcc.TabIndex = 6
        Me.btnAcc.Text = "Account"
        Me.btnAcc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAcc.UseVisualStyleBackColor = True
        '
        'btnRepl
        '
        Me.btnRepl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepl.Image = Global.FinalYearProject.My.Resources.Resources.StockPlus
        Me.btnRepl.Location = New System.Drawing.Point(260, 123)
        Me.btnRepl.Name = "btnRepl"
        Me.btnRepl.Size = New System.Drawing.Size(100, 105)
        Me.btnRepl.TabIndex = 4
        Me.btnRepl.Text = "Replenishment"
        Me.btnRepl.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRepl.UseVisualStyleBackColor = True
        '
        'btnHistory
        '
        Me.btnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.Image = Global.FinalYearProject.My.Resources.Resources.history
        Me.btnHistory.Location = New System.Drawing.Point(486, 12)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(100, 105)
        Me.btnHistory.TabIndex = 3
        Me.btnHistory.Text = "History"
        Me.btnHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnInOut
        '
        Me.btnInOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInOut.Image = Global.FinalYearProject.My.Resources.Resources.import_export_icon
        Me.btnInOut.Location = New System.Drawing.Point(373, 12)
        Me.btnInOut.Name = "btnInOut"
        Me.btnInOut.Size = New System.Drawing.Size(100, 105)
        Me.btnInOut.TabIndex = 2
        Me.btnInOut.Text = "Import/Export"
        Me.btnInOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInOut.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Image = Global.FinalYearProject.My.Resources.Resources.printer
        Me.btnReport.Location = New System.Drawing.Point(373, 123)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(100, 105)
        Me.btnReport.TabIndex = 5
        Me.btnReport.Text = "Reports"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnManage
        '
        Me.btnManage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManage.Image = Global.FinalYearProject.My.Resources.Resources.manage
        Me.btnManage.Location = New System.Drawing.Point(260, 12)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.Size = New System.Drawing.Size(100, 105)
        Me.btnManage.TabIndex = 1
        Me.btnManage.Text = "Manage"
        Me.btnManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnManage.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalYearProject.My.Resources.Resources.gs
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'lblLogged
        '
        Me.lblLogged.AutoSize = True
        Me.lblLogged.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogged.Location = New System.Drawing.Point(12, 173)
        Me.lblLogged.Name = "lblLogged"
        Me.lblLogged.Size = New System.Drawing.Size(72, 15)
        Me.lblLogged.TabIndex = 23
        Me.lblLogged.Text = "Logged on :"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(12, 200)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(79, 15)
        Me.lblPosition.TabIndex = 22
        Me.lblPosition.Text = "Administrator"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(57, 147)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(84, 15)
        Me.lblUser.TabIndex = 21
        Me.lblUser.Text = "Lee Wei Chun"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "User :"
        '
        'btn
        '
        Me.btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.Image = CType(resources.GetObject("btn.Image"), System.Drawing.Image)
        Me.btn.Location = New System.Drawing.Point(602, 12)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(100, 105)
        Me.btn.TabIndex = 24
        Me.btn.Text = "Privilege"
        Me.btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(602, 123)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 105)
        Me.btnLogout.TabIndex = 25
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 244)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.lblLogged)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAcc)
        Me.Controls.Add(Me.btnRepl)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnInOut)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnManage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAcc As System.Windows.Forms.Button
    Friend WithEvents btnRepl As System.Windows.Forms.Button
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents btnInOut As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnManage As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLogged As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
