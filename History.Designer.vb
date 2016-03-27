<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.btnhfilter = New System.Windows.Forms.Button()
        Me.txtHistory = New System.Windows.Forms.TextBox()
        Me.historydgv = New System.Windows.Forms.DataGridView()
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.historydgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(810, 14)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 68
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Location = New System.Drawing.Point(703, 14)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(101, 23)
        Me.btnPreview.TabIndex = 67
        Me.btnPreview.Text = "Print Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(249, 18)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(257, 15)
        Me.Label39.TabIndex = 66
        Me.Label39.Text = "** Search by using History ID, Date or Order ID"
        '
        'btnhfilter
        '
        Me.btnhfilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhfilter.Location = New System.Drawing.Point(168, 14)
        Me.btnhfilter.Name = "btnhfilter"
        Me.btnhfilter.Size = New System.Drawing.Size(75, 23)
        Me.btnhfilter.TabIndex = 65
        Me.btnhfilter.Text = "Filter"
        Me.btnhfilter.UseVisualStyleBackColor = True
        '
        'txtHistory
        '
        Me.txtHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHistory.Location = New System.Drawing.Point(12, 15)
        Me.txtHistory.Name = "txtHistory"
        Me.txtHistory.Size = New System.Drawing.Size(150, 21)
        Me.txtHistory.TabIndex = 64
        '
        'historydgv
        '
        Me.historydgv.AllowUserToAddRows = False
        Me.historydgv.AllowUserToDeleteRows = False
        Me.historydgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.historydgv.Location = New System.Drawing.Point(12, 52)
        Me.historydgv.Name = "historydgv"
        Me.historydgv.ReadOnly = True
        Me.historydgv.Size = New System.Drawing.Size(874, 342)
        Me.historydgv.TabIndex = 63
        '
        'dlgPreview
        '
        Me.dlgPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreview.Enabled = True
        Me.dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), System.Drawing.Icon)
        Me.dlgPreview.Name = "dlgPreview"
        Me.dlgPreview.Visible = False
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 410)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.btnhfilter)
        Me.Controls.Add(Me.txtHistory)
        Me.Controls.Add(Me.historydgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "History"
        Me.Text = "History"
        CType(Me.historydgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents btnhfilter As System.Windows.Forms.Button
    Friend WithEvents txtHistory As System.Windows.Forms.TextBox
    Friend WithEvents historydgv As System.Windows.Forms.DataGridView
    Friend WithEvents printDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents dlgPreview As System.Windows.Forms.PrintPreviewDialog
End Class
