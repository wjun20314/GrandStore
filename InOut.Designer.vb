<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InOut
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
        Me.inDgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboMID = New System.Windows.Forms.ComboBox()
        Me.txtOID = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.outGenerateOrder = New System.Windows.Forms.Button()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.mName = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.outReset = New System.Windows.Forms.Button()
        Me.outAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtType = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtMID = New System.Windows.Forms.TextBox()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.outDgv = New System.Windows.Forms.DataGridView()
        Me.btnISearch = New System.Windows.Forms.Button()
        Me.txtI = New System.Windows.Forms.TextBox()
        Me.txtO = New System.Windows.Forms.TextBox()
        Me.btnOSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.inDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.outDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inDgv
        '
        Me.inDgv.AllowUserToAddRows = False
        Me.inDgv.AllowUserToDeleteRows = False
        Me.inDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.inDgv.Location = New System.Drawing.Point(306, 20)
        Me.inDgv.Name = "inDgv"
        Me.inDgv.ReadOnly = True
        Me.inDgv.Size = New System.Drawing.Size(660, 194)
        Me.inDgv.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboMID)
        Me.GroupBox2.Controls.Add(Me.txtOID)
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.outGenerateOrder)
        Me.GroupBox2.Controls.Add(Me.Label50)
        Me.GroupBox2.Controls.Add(Me.qty)
        Me.GroupBox2.Controls.Add(Me.mName)
        Me.GroupBox2.Controls.Add(Me.Label52)
        Me.GroupBox2.Controls.Add(Me.Label53)
        Me.GroupBox2.Controls.Add(Me.outReset)
        Me.GroupBox2.Controls.Add(Me.outAdd)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 247)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(277, 200)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Outbound"
        '
        'cboMID
        '
        Me.cboMID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMID.FormattingEnabled = True
        Me.cboMID.ItemHeight = 15
        Me.cboMID.Location = New System.Drawing.Point(114, 46)
        Me.cboMID.Name = "cboMID"
        Me.cboMID.Size = New System.Drawing.Size(147, 23)
        Me.cboMID.TabIndex = 11
        '
        'txtOID
        '
        Me.txtOID.Enabled = False
        Me.txtOID.Location = New System.Drawing.Point(114, 21)
        Me.txtOID.Name = "txtOID"
        Me.txtOID.Size = New System.Drawing.Size(147, 21)
        Me.txtOID.TabIndex = 10
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(6, 24)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(59, 15)
        Me.Label42.TabIndex = 95
        Me.Label42.Text = "Order ID :"
        '
        'outGenerateOrder
        '
        Me.outGenerateOrder.Location = New System.Drawing.Point(54, 163)
        Me.outGenerateOrder.Name = "outGenerateOrder"
        Me.outGenerateOrder.Size = New System.Drawing.Size(166, 25)
        Me.outGenerateOrder.TabIndex = 16
        Me.outGenerateOrder.Text = "&Generate Order"
        Me.outGenerateOrder.UseVisualStyleBackColor = True
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(6, 102)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(57, 15)
        Me.Label50.TabIndex = 90
        Me.Label50.Text = "Quantity :"
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(114, 99)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(147, 21)
        Me.qty.TabIndex = 13
        '
        'mName
        '
        Me.mName.Location = New System.Drawing.Point(114, 73)
        Me.mName.Name = "mName"
        Me.mName.Size = New System.Drawing.Size(147, 21)
        Me.mName.TabIndex = 12
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(6, 76)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(95, 15)
        Me.Label52.TabIndex = 88
        Me.Label52.Text = "Material Name :"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(6, 49)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(73, 15)
        Me.Label53.TabIndex = 87
        Me.Label53.Text = "Material ID :"
        '
        'outReset
        '
        Me.outReset.Image = Global.FinalYearProject.My.Resources.Resources.recycle_16
        Me.outReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.outReset.Location = New System.Drawing.Point(54, 132)
        Me.outReset.Name = "outReset"
        Me.outReset.Size = New System.Drawing.Size(80, 25)
        Me.outReset.TabIndex = 14
        Me.outReset.Text = "&Reset"
        Me.outReset.UseVisualStyleBackColor = True
        '
        'outAdd
        '
        Me.outAdd.Image = Global.FinalYearProject.My.Resources.Resources.document_add_16
        Me.outAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.outAdd.Location = New System.Drawing.Point(140, 132)
        Me.outAdd.Name = "outAdd"
        Me.outAdd.Size = New System.Drawing.Size(80, 25)
        Me.outAdd.TabIndex = 15
        Me.outAdd.Text = "Add"
        Me.outAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.txtType)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.txtMID)
        Me.GroupBox1.Controls.Add(Me.txtMName)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 200)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inbound"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.FinalYearProject.My.Resources.Resources.document_add_16
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(181, 149)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 25)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtType
        '
        Me.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtType.FormattingEnabled = True
        Me.txtType.Items.AddRange(New Object() {"Battery", "Cable", "DVD Drive", "Fan", "Graphic Card", "Hard Drive", "Heat Sink", "Motherboard", "Plastic Kit", "Power Supply", "Processor", "RAM"})
        Me.txtType.Location = New System.Drawing.Point(114, 76)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(147, 23)
        Me.txtType.Sorted = True
        Me.txtType.TabIndex = 3
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 27)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(73, 15)
        Me.Label36.TabIndex = 16
        Me.Label36.Text = "Material ID :"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 79)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(39, 15)
        Me.Label31.TabIndex = 25
        Me.Label31.Text = "Type :"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 54)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(95, 15)
        Me.Label37.TabIndex = 17
        Me.Label37.Text = "Material Name :"
        '
        'txtMID
        '
        Me.txtMID.Enabled = False
        Me.txtMID.Location = New System.Drawing.Point(114, 24)
        Me.txtMID.Name = "txtMID"
        Me.txtMID.Size = New System.Drawing.Size(147, 21)
        Me.txtMID.TabIndex = 1
        '
        'txtMName
        '
        Me.txtMName.Location = New System.Drawing.Point(114, 51)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(147, 21)
        Me.txtMName.TabIndex = 2
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 106)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(57, 15)
        Me.Label38.TabIndex = 19
        Me.Label38.Text = "Quantity :"
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = Global.FinalYearProject.My.Resources.Resources.open_16
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.Location = New System.Drawing.Point(95, 149)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 25)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(113, 103)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(148, 21)
        Me.txtQty.TabIndex = 4
        '
        'btnReset
        '
        Me.btnReset.Image = Global.FinalYearProject.My.Resources.Resources.recycle_16
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.Location = New System.Drawing.Point(9, 149)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(80, 25)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'outDgv
        '
        Me.outDgv.AllowUserToAddRows = False
        Me.outDgv.AllowUserToDeleteRows = False
        Me.outDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.outDgv.Location = New System.Drawing.Point(306, 253)
        Me.outDgv.Name = "outDgv"
        Me.outDgv.ReadOnly = True
        Me.outDgv.Size = New System.Drawing.Size(660, 194)
        Me.outDgv.TabIndex = 33
        '
        'btnISearch
        '
        Me.btnISearch.Location = New System.Drawing.Point(891, 220)
        Me.btnISearch.Name = "btnISearch"
        Me.btnISearch.Size = New System.Drawing.Size(75, 23)
        Me.btnISearch.TabIndex = 9
        Me.btnISearch.Text = "Filter"
        Me.btnISearch.UseVisualStyleBackColor = True
        '
        'txtI
        '
        Me.txtI.Location = New System.Drawing.Point(753, 222)
        Me.txtI.Name = "txtI"
        Me.txtI.Size = New System.Drawing.Size(132, 20)
        Me.txtI.TabIndex = 8
        '
        'txtO
        '
        Me.txtO.Location = New System.Drawing.Point(753, 455)
        Me.txtO.Name = "txtO"
        Me.txtO.Size = New System.Drawing.Size(132, 20)
        Me.txtO.TabIndex = 17
        '
        'btnOSearch
        '
        Me.btnOSearch.Location = New System.Drawing.Point(891, 453)
        Me.btnOSearch.Name = "btnOSearch"
        Me.btnOSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnOSearch.TabIndex = 18
        Me.btnOSearch.Text = "Filter"
        Me.btnOSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(303, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "** Search by using Material ID, Name or Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(303, 458)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "** Search by using Order ID, Material ID or Material Name"
        '
        'InOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 484)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtO)
        Me.Controls.Add(Me.btnOSearch)
        Me.Controls.Add(Me.txtI)
        Me.Controls.Add(Me.btnISearch)
        Me.Controls.Add(Me.outDgv)
        Me.Controls.Add(Me.inDgv)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inbound / Outbound"
        CType(Me.inDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.outDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inDgv As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMID As System.Windows.Forms.ComboBox
    Friend WithEvents txtOID As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents outGenerateOrder As System.Windows.Forms.Button
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents qty As System.Windows.Forms.TextBox
    Friend WithEvents mName As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents outReset As System.Windows.Forms.Button
    Friend WithEvents outAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtType As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtMID As System.Windows.Forms.TextBox
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents outDgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnISearch As System.Windows.Forms.Button
    Friend WithEvents txtI As System.Windows.Forms.TextBox
    Friend WithEvents txtO As System.Windows.Forms.TextBox
    Friend WithEvents btnOSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
