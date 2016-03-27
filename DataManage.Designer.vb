<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataManage
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
        Me.matRemark = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.mOrderQty = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.mOrderPoint = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.matBrand = New System.Windows.Forms.TextBox()
        Me.matID = New System.Windows.Forms.TextBox()
        Me.matLocation = New System.Windows.Forms.TextBox()
        Me.matQty = New System.Windows.Forms.TextBox()
        Me.matName = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.matType = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.txtCEmail = New System.Windows.Forms.TextBox()
        Me.txtCTel = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtsuppID = New System.Windows.Forms.TextBox()
        Me.txtCName = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCAddress = New System.Windows.Forms.TextBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.matUpdate = New System.Windows.Forms.Button()
        Me.matReset = New System.Windows.Forms.Button()
        Me.matAdd = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.suppUpdate = New System.Windows.Forms.Button()
        Me.suppreset = New System.Windows.Forms.Button()
        Me.suppAdd = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPEmail = New System.Windows.Forms.TextBox()
        Me.txtPContact = New System.Windows.Forms.TextBox()
        Me.txtPName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.accID = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.sfPosition = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sfID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.sfEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sfAddress = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sfName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sfPhone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.sfAge = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.sfIC = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.txtManage = New System.Windows.Forms.TextBox()
        Me.manageFilter = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.gb1.SuspendLayout()
        Me.gb2.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.matRemark)
        Me.gb1.Controls.Add(Me.Label34)
        Me.gb1.Controls.Add(Me.Label33)
        Me.gb1.Controls.Add(Me.mOrderQty)
        Me.gb1.Controls.Add(Me.Label32)
        Me.gb1.Controls.Add(Me.Label30)
        Me.gb1.Controls.Add(Me.Label28)
        Me.gb1.Controls.Add(Me.mOrderPoint)
        Me.gb1.Controls.Add(Me.Label27)
        Me.gb1.Controls.Add(Me.Label26)
        Me.gb1.Controls.Add(Me.matBrand)
        Me.gb1.Controls.Add(Me.matID)
        Me.gb1.Controls.Add(Me.matLocation)
        Me.gb1.Controls.Add(Me.matQty)
        Me.gb1.Controls.Add(Me.matName)
        Me.gb1.Controls.Add(Me.Label25)
        Me.gb1.Controls.Add(Me.matType)
        Me.gb1.Controls.Add(Me.Label24)
        Me.gb1.Location = New System.Drawing.Point(18, 19)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(268, 288)
        Me.gb1.TabIndex = 4
        Me.gb1.TabStop = False
        Me.gb1.Text = "Material Info"
        '
        'matRemark
        '
        Me.matRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matRemark.Location = New System.Drawing.Point(119, 248)
        Me.matRemark.Name = "matRemark"
        Me.matRemark.Size = New System.Drawing.Size(133, 21)
        Me.matRemark.TabIndex = 39
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(8, 251)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(63, 15)
        Me.Label34.TabIndex = 38
        Me.Label34.Text = "Remarks :"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(8, 224)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(105, 15)
        Me.Label33.TabIndex = 36
        Me.Label33.Text = "Reorder Quantity :"
        '
        'mOrderQty
        '
        Me.mOrderQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mOrderQty.Location = New System.Drawing.Point(119, 221)
        Me.mOrderQty.Name = "mOrderQty"
        Me.mOrderQty.Size = New System.Drawing.Size(133, 21)
        Me.mOrderQty.TabIndex = 37
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(8, 197)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(89, 15)
        Me.Label32.TabIndex = 34
        Me.Label32.Text = "Reorder Point :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(8, 170)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(83, 15)
        Me.Label30.TabIndex = 32
        Me.Label30.Text = "Brand Name :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(8, 143)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(60, 15)
        Me.Label28.TabIndex = 30
        Me.Label28.Text = "Location :"
        '
        'mOrderPoint
        '
        Me.mOrderPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mOrderPoint.Location = New System.Drawing.Point(119, 194)
        Me.mOrderPoint.Name = "mOrderPoint"
        Me.mOrderPoint.Size = New System.Drawing.Size(133, 21)
        Me.mOrderPoint.TabIndex = 35
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(8, 116)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(57, 15)
        Me.Label27.TabIndex = 28
        Me.Label27.Text = "Quantity :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(8, 85)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(39, 15)
        Me.Label26.TabIndex = 26
        Me.Label26.Text = "Type :"
        '
        'matBrand
        '
        Me.matBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matBrand.Location = New System.Drawing.Point(119, 167)
        Me.matBrand.Name = "matBrand"
        Me.matBrand.Size = New System.Drawing.Size(133, 21)
        Me.matBrand.TabIndex = 33
        '
        'matID
        '
        Me.matID.Enabled = False
        Me.matID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matID.Location = New System.Drawing.Point(119, 26)
        Me.matID.Name = "matID"
        Me.matID.Size = New System.Drawing.Size(133, 21)
        Me.matID.TabIndex = 23
        '
        'matLocation
        '
        Me.matLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matLocation.Location = New System.Drawing.Point(119, 140)
        Me.matLocation.Name = "matLocation"
        Me.matLocation.Size = New System.Drawing.Size(133, 21)
        Me.matLocation.TabIndex = 31
        '
        'matQty
        '
        Me.matQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matQty.Location = New System.Drawing.Point(119, 113)
        Me.matQty.Name = "matQty"
        Me.matQty.Size = New System.Drawing.Size(133, 21)
        Me.matQty.TabIndex = 29
        '
        'matName
        '
        Me.matName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matName.Location = New System.Drawing.Point(119, 53)
        Me.matName.Name = "matName"
        Me.matName.Size = New System.Drawing.Size(133, 21)
        Me.matName.TabIndex = 25
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 56)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(95, 15)
        Me.Label25.TabIndex = 24
        Me.Label25.Text = "Material Name :"
        '
        'matType
        '
        Me.matType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.matType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matType.FormattingEnabled = True
        Me.matType.Items.AddRange(New Object() {"Battery", "Cable", "DVD Drive", "Fan", "Graphic Card", "Hard Drive", "Heat Sink", "Motherboard", "Plastic Kit", "Power Supply", "Processor", "RAM"})
        Me.matType.Location = New System.Drawing.Point(119, 80)
        Me.matType.Name = "matType"
        Me.matType.Size = New System.Drawing.Size(133, 23)
        Me.matType.Sorted = True
        Me.matType.TabIndex = 27
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(73, 15)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "Material ID :"
        '
        'gb2
        '
        Me.gb2.Controls.Add(Me.txtCEmail)
        Me.gb2.Controls.Add(Me.txtCTel)
        Me.gb2.Controls.Add(Me.Label19)
        Me.gb2.Controls.Add(Me.Label20)
        Me.gb2.Controls.Add(Me.Label21)
        Me.gb2.Controls.Add(Me.Label22)
        Me.gb2.Controls.Add(Me.txtsuppID)
        Me.gb2.Controls.Add(Me.txtCName)
        Me.gb2.Controls.Add(Me.Label23)
        Me.gb2.Controls.Add(Me.txtCAddress)
        Me.gb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb2.Location = New System.Drawing.Point(18, 19)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(296, 175)
        Me.gb2.TabIndex = 5
        Me.gb2.TabStop = False
        Me.gb2.Text = "Company Info"
        '
        'txtCEmail
        '
        Me.txtCEmail.Location = New System.Drawing.Point(137, 133)
        Me.txtCEmail.Name = "txtCEmail"
        Me.txtCEmail.Size = New System.Drawing.Size(144, 21)
        Me.txtCEmail.TabIndex = 20
        '
        'txtCTel
        '
        Me.txtCTel.Location = New System.Drawing.Point(137, 107)
        Me.txtCTel.Name = "txtCTel"
        Me.txtCTel.Size = New System.Drawing.Size(144, 21)
        Me.txtCTel.TabIndex = 18
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 15)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Company Name :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 15)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Company Email :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 81)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 15)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Company Address :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 15)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Supplier ID :"
        '
        'txtsuppID
        '
        Me.txtsuppID.Enabled = False
        Me.txtsuppID.Location = New System.Drawing.Point(137, 27)
        Me.txtsuppID.Name = "txtsuppID"
        Me.txtsuppID.Size = New System.Drawing.Size(144, 21)
        Me.txtsuppID.TabIndex = 12
        '
        'txtCName
        '
        Me.txtCName.Location = New System.Drawing.Point(137, 53)
        Me.txtCName.Name = "txtCName"
        Me.txtCName.Size = New System.Drawing.Size(144, 21)
        Me.txtCName.TabIndex = 14
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 110)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(109, 15)
        Me.Label23.TabIndex = 17
        Me.Label23.Text = "Company Contact :"
        '
        'txtCAddress
        '
        Me.txtCAddress.Location = New System.Drawing.Point(137, 78)
        Me.txtCAddress.Name = "txtCAddress"
        Me.txtCAddress.Size = New System.Drawing.Size(144, 21)
        Me.txtCAddress.TabIndex = 16
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Left
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(346, 430)
        Me.TabControl.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.matUpdate)
        Me.TabPage1.Controls.Add(Me.matReset)
        Me.TabPage1.Controls.Add(Me.matAdd)
        Me.TabPage1.Controls.Add(Me.gb1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(338, 402)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Material"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'matUpdate
        '
        Me.matUpdate.Image = Global.FinalYearProject.My.Resources.Resources.open_16
        Me.matUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.matUpdate.Location = New System.Drawing.Point(199, 321)
        Me.matUpdate.Name = "matUpdate"
        Me.matUpdate.Size = New System.Drawing.Size(80, 25)
        Me.matUpdate.TabIndex = 50
        Me.matUpdate.Text = "&Update"
        Me.matUpdate.UseVisualStyleBackColor = True
        '
        'matReset
        '
        Me.matReset.Image = Global.FinalYearProject.My.Resources.Resources.recycle_16
        Me.matReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.matReset.Location = New System.Drawing.Point(27, 321)
        Me.matReset.Name = "matReset"
        Me.matReset.Size = New System.Drawing.Size(80, 25)
        Me.matReset.TabIndex = 48
        Me.matReset.Text = "&Reset"
        Me.matReset.UseVisualStyleBackColor = True
        '
        'matAdd
        '
        Me.matAdd.Image = Global.FinalYearProject.My.Resources.Resources.document_add_16
        Me.matAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.matAdd.Location = New System.Drawing.Point(113, 321)
        Me.matAdd.Name = "matAdd"
        Me.matAdd.Size = New System.Drawing.Size(80, 25)
        Me.matAdd.TabIndex = 49
        Me.matAdd.Text = "&Add"
        Me.matAdd.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.suppUpdate)
        Me.TabPage2.Controls.Add(Me.suppreset)
        Me.TabPage2.Controls.Add(Me.suppAdd)
        Me.TabPage2.Controls.Add(Me.groupBox2)
        Me.TabPage2.Controls.Add(Me.gb2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(338, 402)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Supplier"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'suppUpdate
        '
        Me.suppUpdate.Image = Global.FinalYearProject.My.Resources.Resources.open_16
        Me.suppUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.suppUpdate.Location = New System.Drawing.Point(211, 343)
        Me.suppUpdate.Name = "suppUpdate"
        Me.suppUpdate.Size = New System.Drawing.Size(80, 25)
        Me.suppUpdate.TabIndex = 50
        Me.suppUpdate.Text = "Update"
        Me.suppUpdate.UseVisualStyleBackColor = True
        '
        'suppreset
        '
        Me.suppreset.Image = Global.FinalYearProject.My.Resources.Resources.recycle_16
        Me.suppreset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.suppreset.Location = New System.Drawing.Point(39, 343)
        Me.suppreset.Name = "suppreset"
        Me.suppreset.Size = New System.Drawing.Size(80, 25)
        Me.suppreset.TabIndex = 48
        Me.suppreset.Text = "&Reset"
        Me.suppreset.UseVisualStyleBackColor = True
        '
        'suppAdd
        '
        Me.suppAdd.Image = Global.FinalYearProject.My.Resources.Resources.document_add_16
        Me.suppAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.suppAdd.Location = New System.Drawing.Point(125, 343)
        Me.suppAdd.Name = "suppAdd"
        Me.suppAdd.Size = New System.Drawing.Size(80, 25)
        Me.suppAdd.TabIndex = 49
        Me.suppAdd.Text = "&Add"
        Me.suppAdd.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.txtPEmail)
        Me.groupBox2.Controls.Add(Me.txtPContact)
        Me.groupBox2.Controls.Add(Me.txtPName)
        Me.groupBox2.Controls.Add(Me.Label16)
        Me.groupBox2.Controls.Add(Me.Label17)
        Me.groupBox2.Controls.Add(Me.Label18)
        Me.groupBox2.Location = New System.Drawing.Point(18, 212)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(296, 118)
        Me.groupBox2.TabIndex = 19
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Personal Info"
        '
        'txtPEmail
        '
        Me.txtPEmail.Location = New System.Drawing.Point(137, 79)
        Me.txtPEmail.Name = "txtPEmail"
        Me.txtPEmail.Size = New System.Drawing.Size(144, 21)
        Me.txtPEmail.TabIndex = 16
        '
        'txtPContact
        '
        Me.txtPContact.Location = New System.Drawing.Point(137, 52)
        Me.txtPContact.Name = "txtPContact"
        Me.txtPContact.Size = New System.Drawing.Size(144, 21)
        Me.txtPContact.TabIndex = 14
        '
        'txtPName
        '
        Me.txtPName.Location = New System.Drawing.Point(137, 25)
        Me.txtPName.Name = "txtPName"
        Me.txtPName.Size = New System.Drawing.Size(144, 21)
        Me.txtPName.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 15)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Person In-Charge :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 82)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 15)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Email :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 15)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Contact No. :"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.btnUpdate)
        Me.TabPage3.Controls.Add(Me.btnDelete)
        Me.TabPage3.Controls.Add(Me.btnReset)
        Me.TabPage3.Controls.Add(Me.btnAdd)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(338, 402)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Staff"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.accID)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.sfPosition)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.sfID)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.sfEmail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.sfAddress)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.sfName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.sfPhone)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.sfAge)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.sfIC)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 306)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Staff Info"
        '
        'accID
        '
        Me.accID.Location = New System.Drawing.Point(89, 267)
        Me.accID.Name = "accID"
        Me.accID.Size = New System.Drawing.Size(160, 21)
        Me.accID.TabIndex = 55
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(8, 270)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(51, 15)
        Me.Label40.TabIndex = 54
        Me.Label40.Text = "User ID:"
        '
        'sfPosition
        '
        Me.sfPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sfPosition.FormattingEnabled = True
        Me.sfPosition.Items.AddRange(New Object() {"Manager", "Retired", "Staff", "Supervisor"})
        Me.sfPosition.Location = New System.Drawing.Point(89, 238)
        Me.sfPosition.Name = "sfPosition"
        Me.sfPosition.Size = New System.Drawing.Size(160, 23)
        Me.sfPosition.Sorted = True
        Me.sfPosition.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Staff ID :"
        '
        'sfID
        '
        Me.sfID.Enabled = False
        Me.sfID.Location = New System.Drawing.Point(89, 27)
        Me.sfID.Name = "sfID"
        Me.sfID.Size = New System.Drawing.Size(161, 21)
        Me.sfID.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Position :"
        '
        'sfEmail
        '
        Me.sfEmail.Location = New System.Drawing.Point(89, 211)
        Me.sfEmail.Name = "sfEmail"
        Me.sfEmail.Size = New System.Drawing.Size(161, 21)
        Me.sfEmail.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Name :"
        '
        'sfAddress
        '
        Me.sfAddress.Location = New System.Drawing.Point(89, 162)
        Me.sfAddress.Name = "sfAddress"
        Me.sfAddress.Size = New System.Drawing.Size(161, 42)
        Me.sfAddress.TabIndex = 49
        Me.sfAddress.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Address :"
        '
        'sfName
        '
        Me.sfName.Location = New System.Drawing.Point(89, 54)
        Me.sfName.Name = "sfName"
        Me.sfName.Size = New System.Drawing.Size(160, 21)
        Me.sfName.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Email :"
        '
        'sfPhone
        '
        Me.sfPhone.Location = New System.Drawing.Point(89, 135)
        Me.sfPhone.Name = "sfPhone"
        Me.sfPhone.Size = New System.Drawing.Size(160, 21)
        Me.sfPhone.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 15)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "IC :"
        '
        'sfAge
        '
        Me.sfAge.Location = New System.Drawing.Point(89, 108)
        Me.sfAge.Name = "sfAge"
        Me.sfAge.Size = New System.Drawing.Size(54, 21)
        Me.sfAge.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 15)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Phone No :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 15)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Age :"
        '
        'sfIC
        '
        Me.sfIC.Location = New System.Drawing.Point(89, 81)
        Me.sfIC.Name = "sfIC"
        Me.sfIC.Size = New System.Drawing.Size(160, 21)
        Me.sfIC.TabIndex = 43
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = Global.FinalYearProject.My.Resources.Resources.open_16
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.Location = New System.Drawing.Point(81, 364)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 25)
        Me.btnUpdate.TabIndex = 62
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.FinalYearProject.My.Resources.Resources.delete_16
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.Location = New System.Drawing.Point(167, 364)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 25)
        Me.btnDelete.TabIndex = 63
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Image = Global.FinalYearProject.My.Resources.Resources.recycle_16
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.Location = New System.Drawing.Point(80, 333)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(80, 25)
        Me.btnReset.TabIndex = 60
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.FinalYearProject.My.Resources.Resources.document_add_16
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(166, 333)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 25)
        Me.btnAdd.TabIndex = 61
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(352, 24)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(601, 341)
        Me.dgv.TabIndex = 7
        '
        'txtManage
        '
        Me.txtManage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManage.Location = New System.Drawing.Point(543, 391)
        Me.txtManage.Name = "txtManage"
        Me.txtManage.Size = New System.Drawing.Size(174, 21)
        Me.txtManage.TabIndex = 8
        '
        'manageFilter
        '
        Me.manageFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageFilter.Location = New System.Drawing.Point(723, 389)
        Me.manageFilter.Name = "manageFilter"
        Me.manageFilter.Size = New System.Drawing.Size(80, 25)
        Me.manageFilter.TabIndex = 9
        Me.manageFilter.Text = "&Filter"
        Me.manageFilter.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.ForeColor = System.Drawing.Color.Red
        Me.lblSearch.Location = New System.Drawing.Point(352, 368)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(230, 13)
        Me.lblSearch.TabIndex = 10
        Me.lblSearch.Text = "** Search by using Material ID, Type and Brand"
        '
        'DataManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 430)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.manageFilter)
        Me.Controls.Add(Me.txtManage)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DataManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Management"
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.gb2.ResumeLayout(False)
        Me.gb2.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb1 As System.Windows.Forms.GroupBox
    Friend WithEvents matRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents mOrderQty As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents mOrderPoint As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents matBrand As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents matLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents matType As System.Windows.Forms.ComboBox
    Friend WithEvents matQty As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents matName As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents matID As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents gb2 As System.Windows.Forms.GroupBox
    Private WithEvents txtCEmail As System.Windows.Forms.TextBox
    Private WithEvents txtCTel As System.Windows.Forms.TextBox
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents Label21 As System.Windows.Forms.Label
    Private WithEvents Label22 As System.Windows.Forms.Label
    Private WithEvents txtsuppID As System.Windows.Forms.TextBox
    Private WithEvents txtCName As System.Windows.Forms.TextBox
    Private WithEvents Label23 As System.Windows.Forms.Label
    Private WithEvents txtCAddress As System.Windows.Forms.TextBox
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents txtPEmail As System.Windows.Forms.TextBox
    Private WithEvents txtPContact As System.Windows.Forms.TextBox
    Private WithEvents txtPName As System.Windows.Forms.TextBox
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents matUpdate As System.Windows.Forms.Button
    Friend WithEvents matReset As System.Windows.Forms.Button
    Friend WithEvents matAdd As System.Windows.Forms.Button
    Friend WithEvents suppUpdate As System.Windows.Forms.Button
    Friend WithEvents suppreset As System.Windows.Forms.Button
    Friend WithEvents suppAdd As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents accID As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents sfPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents sfID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents sfEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents sfAddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents sfName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents sfPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents sfAge As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents sfIC As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtManage As System.Windows.Forms.TextBox
    Friend WithEvents manageFilter As System.Windows.Forms.Button
    Friend WithEvents lblSearch As System.Windows.Forms.Label
End Class
