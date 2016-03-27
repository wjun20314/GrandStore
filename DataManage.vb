Imports System.Data.SqlClient
Imports System.Text

Public Class DataManage
    Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Chun\Documents\Visual Studio 2012\Projects\FinalYearProject\FinalYearProject\GrandStore.mdf"";Integrated Security=True;Connect Timeout=30")
    Private GetRandomInt32Value As New RandomInt32Value
    Dim possibleChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
    Private bindingSource1 As New BindingSource()
    Private bindingSource2 As New BindingSource()
    Private bindingSource3 As New BindingSource()
    Private bindingSource4 As New BindingSource()


    Private Sub DataManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshAll()
    End Sub

    Private Sub refreshAll() Handles TabControl.SelectedIndexChanged
        If TabControl.SelectedTab.Equals(TabPage1) Then
            genMID()
            refreshMatDgv()
            lblSearch.Text = "** Search by using Material ID, Type or Brand"
        ElseIf TabControl.SelectedTab.Equals(TabPage2) Then
            genUID()
            refreshSuppDgv()
            lblSearch.Text = "** Search by using Supplier ID, Comapny Name or Person's name in-charge"
        Else
            genSID()
            refreshStaffDbv()
            lblSearch.Text = "** Search by using Staff ID, IC or Position"
        End If
    End Sub

    Private Sub genMID()
        Dim cmd As New SqlCommand
        Dim lastmid As String = ""
        Dim _num As Integer = 0

        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cmd = New SqlCommand("SELECT MAX(mID) as lastid FROM Material", conn)
        lastmid = cmd.ExecuteScalar()

        _num = lastmid.Substring(1) + 1

        If _num < 10 Then
            lastmid = "M000" + _num.ToString
        ElseIf _num > 9 And _num < 100 Then
            lastmid = "M00" + _num.ToString
        ElseIf _num > 99 And _num < 1000 Then
            lastmid = "M0" + _num.ToString
        ElseIf _num > 999 And _num < 9999 Then
            lastmid = "M" + _num.ToString
        Else
            lastmid = 0
        End If

        matID.Text = lastmid
        conn.Close()
    End Sub

    Private Sub refreshMatDgv()
        dgv.AutoGenerateColumns = True
        dgv.DataSource = GetData("SELECT * FROM Material")
    End Sub

    Private Sub genUID()
        Dim cmd As New SqlCommand
        Dim lastsuppid As String = ""
        Dim _num As Integer = 0

        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cmd = New SqlCommand("Select MAX(suppID) as newsuppid From Supplier", conn)
        lastsuppid = cmd.ExecuteScalar()

        _num = lastsuppid.Substring(1) + 1

        If _num < 10 Then
            lastsuppid = "U000" + _num.ToString
        ElseIf _num > 9 And _num < 100 Then
            lastsuppid = "U00" + _num.ToString
        ElseIf _num > 99 And _num < 1000 Then
            lastsuppid = "U0" + _num.ToString
        ElseIf _num > 999 And _num < 9999 Then
            lastsuppid = "U" + _num.ToString
        Else
            lastsuppid = 0
        End If

        txtsuppID.Text = lastsuppid
        conn.Close()
    End Sub

    Private Sub refreshSuppDgv()
        dgv.AutoGenerateColumns = True
        dgv.DataSource = GetData("SELECT * FROM Supplier")
    End Sub

    Private Sub genSID()
        Dim cmd As New SqlCommand
        Dim lastid As String = ""
        Dim _no As Integer = 0

        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cmd = New SqlCommand("Select MAX(sID) as lastid From Staff", conn)
        lastid = cmd.ExecuteScalar()

        _no = lastid.Substring(1) + 1

        If _no < 10 Then
            lastid = "S000" + _no.ToString
        ElseIf _no > 9 And _no < 100 Then
            lastid = "S00" + _no.ToString
        ElseIf _no > 99 And _no < 1000 Then
            lastid = "S0" + _no.ToString
        ElseIf _no > 999 And _no < 9999 Then
            lastid = "S" + _no.ToString
        Else
            lastid = 0
        End If

        sfID.Text = lastid
        conn.Close()
    End Sub

    Private Sub refreshStaffDbv()
        dgv.AutoGenerateColumns = True
        dgv.DataSource = GetData("SELECT sID, sName, IC, age, phoneNo, address, email, position FROM Staff")
    End Sub

    Private Shared Function GetData(ByVal sqlCommand As String) As DataTable
        Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Chun\Documents\Visual Studio 2012\Projects\FinalYearProject\FinalYearProject\GrandStore.mdf"";Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand
        Dim adapter As SqlDataAdapter = New SqlDataAdapter()

        cmd = New SqlCommand(sqlCommand, conn)
        adapter.SelectCommand = cmd

        Dim table As New DataTable
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)
        Return table
    End Function

    Private Sub dgv_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.RowHeaderMouseDoubleClick
        If TabControl.SelectedTab.Equals(TabPage1) Then
            Dim i As Integer = e.RowIndex
            Dim varMID As String
            Dim varMName As String
            Dim varType As String
            Dim varQty As String
            Dim varLocation As String
            Dim varBrand As String
            Dim varOrderP As String
            Dim varOrderQty As String
            Dim varRemark As String

            varMID = CStr(dgv.Rows(i).Cells(0).Value)
            varMName = CStr(dgv.Rows(i).Cells(1).Value)
            varType = CStr(dgv.Rows(i).Cells(2).Value)
            varQty = CStr(dgv.Rows(i).Cells(3).Value)
            varLocation = CStr(dgv.Rows(i).Cells(4).Value)
            varBrand = CStr(dgv.Rows(i).Cells(5).Value)
            varOrderP = CStr(dgv.Rows(i).Cells(6).Value)
            varOrderQty = CStr(dgv.Rows(i).Cells(7).Value)
            varRemark = CStr(dgv.Rows(i).Cells(8).Value)
            matID.Text = varMID
            matName.Text = varMName
            matType.Text = varType
            matQty.Text = varQty
            matLocation.Text = varLocation
            matBrand.Text = varBrand
            mOrderPoint.Text = varOrderP
            mOrderQty.Text = varOrderQty
            matRemark.Text = varRemark
        ElseIf TabControl.SelectedTab.Equals(TabPage2) Then
            Dim i As Integer = e.RowIndex
            Dim varUID As String
            Dim varCName As String
            Dim varCAddress As String
            Dim varCC As String
            Dim varCEmail As String
            Dim varPName As String
            Dim varPC As String
            Dim varPEmail As String

            varUID = CStr(dgv.Rows(i).Cells(0).Value)
            varCName = CStr(dgv.Rows(i).Cells(1).Value)
            varCAddress = CStr(dgv.Rows(i).Cells(2).Value)
            varCC = CStr(dgv.Rows(i).Cells(3).Value)
            varCEmail = CStr(dgv.Rows(i).Cells(4).Value)
            varPName = CStr(dgv.Rows(i).Cells(5).Value)
            varPC = CStr(dgv.Rows(i).Cells(6).Value)
            varPEmail = CStr(dgv.Rows(i).Cells(7).Value)
            txtsuppID.Text = varUID
            txtCName.Text = varCName
            txtCAddress.Text = varCAddress
            txtCTel.Text = varCC
            txtCEmail.Text = varCEmail
            txtPName.Text = varPName
            txtPContact.Text = varPC
            txtPEmail.Text = varPEmail
        Else
            Dim i As Integer = e.RowIndex
            Dim varsfid As String
            Dim varsfname As String
            Dim varsfic As String
            Dim varsfage As String
            Dim varsfphone As String
            Dim varsfaddress As String
            Dim varsfemail As String
            Dim varsfposi As String

            varsfid = CStr(dgv.Rows(i).Cells(0).Value)
            varsfname = CStr(dgv.Rows(i).Cells(1).Value)
            varsfic = CStr(dgv.Rows(i).Cells(2).Value)
            varsfage = CStr(dgv.Rows(i).Cells(3).Value)
            varsfphone = CStr(dgv.Rows(i).Cells(4).Value)
            varsfaddress = CStr(dgv.Rows(i).Cells(5).Value)
            varsfemail = CStr(dgv.Rows(i).Cells(6).Value)
            varsfposi = CStr(dgv.Rows(i).Cells(7).Value)
            sfID.Text = varsfid
            sfName.Text = varsfname
            sfIC.Text = varsfic
            sfAge.Text = varsfage
            sfPhone.Text = varsfphone
            sfAddress.Text = varsfaddress
            sfEmail.Text = varsfemail
            sfPosition.Text = varsfposi
            accID.Enabled = False
        End If
    End Sub

    Private Sub matReset_Click(sender As Object, e As EventArgs) Handles matReset.Click
        genMID()
        matName.Text = ""
        matType.SelectedIndex = 0
        matQty.Text = ""
        matLocation.Text = ""
        matBrand.Text = ""
        mOrderPoint.Text = ""
        mOrderQty.Text = ""
        matRemark.Text = ""
    End Sub

    Private Sub matAdd_Click(sender As Object, e As EventArgs) Handles matAdd.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim varmid As String = matID.Text.Trim
        Dim varmname As String = matName.Text.Trim
        Dim varmtype As String = matType.Text.Trim
        Dim varqty As Integer
        Dim varlocation As String = matLocation.Text.Trim
        Dim varbrand As String = matBrand.Text.Trim
        Dim varorderpoint As Integer
        Dim varorderqty As Integer
        Dim varremark As String = matRemark.Text.Trim
        Dim cmd As New SqlCommand

        If varmname = "" Then
            err.AppendLine("- Material name is blank, please fill in.")
            ctr = If(ctr, matName)
        End If

        If varmtype = "" Then
            err.AppendLine("- Material type is not selected.")
            ctr = If(ctr, matType)
        End If

        If matQty.Text = "" Then
            err.AppendLine("- Quantity is blank, please fill in.")
            ctr = If(ctr, matQty)
        End If

        If varlocation = "" Then
            err.AppendLine("- Location is blank, please fill in.")
            ctr = If(ctr, matLocation)
        End If

        If varbrand = "" Then
            err.AppendLine("- Brand name is blank, please fill in.")
            ctr = If(ctr, matBrand)
        End If

        If mOrderPoint.Text = "" Then
            err.AppendLine("- Reorder point is blank, please fill in.")
            ctr = If(ctr, mOrderPoint)
        End If

        If mOrderQty.Text = "" Then
            err.AppendLine("- Order quantity is blank, please fill in.")
            ctr = If(ctr, mOrderQty)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        Else

            Try
                conn.Open()
            Catch ex As Exception
                MessageBox.Show("Error Found : " + ex.Message, "Source code problem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            varqty = matQty.Text
            varorderpoint = mOrderPoint.Text
            varorderqty = mOrderQty.Text
            cmd = New SqlCommand("Insert into Material(mID, mName, type, qty, mLocation, mBrand, reorderPoint, reorderQty, remark) Values (@mID, @mName, @mType, @mQty, @mLocation, @mBrand, @mOrderpoint, @mOrderqty, @mRemark)", conn)
            cmd.Parameters.AddWithValue("@mID", varmid)
            cmd.Parameters.AddWithValue("@mName", varmname)
            cmd.Parameters.AddWithValue("@mType", varmtype)
            cmd.Parameters.AddWithValue("@mQty", varqty)
            cmd.Parameters.AddWithValue("@mLocation", varlocation)
            cmd.Parameters.AddWithValue("@mBrand", varbrand)
            cmd.Parameters.AddWithValue("@mOrderpoint", varorderpoint)
            cmd.Parameters.AddWithValue("@mOrderqty", varorderqty)
            cmd.Parameters.AddWithValue("@mRemark", varremark)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Material records is inserted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshMatDgv()
        End If
    End Sub

    Private Sub matUpdate_Click(sender As Object, e As EventArgs) Handles matUpdate.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim varmid As String = matID.Text.Trim
        Dim varmname As String = matName.Text.Trim
        Dim varmtype As String = matType.Text.Trim
        Dim varqty As Integer
        Dim varlocation As String = matLocation.Text.Trim
        Dim varbrand As String = matBrand.Text.Trim
        Dim varorderpoint As Integer
        Dim varorderqty As Integer
        Dim varremark As String = matRemark.Text.Trim
        Dim cmd As New SqlCommand

        If varmname = "" Then
            err.AppendLine("- Material name is blank, please fill in.")
            ctr = If(ctr, matName)
        End If

        If varmtype = "" Then
            err.AppendLine("- Material type is not selected.")
            ctr = If(ctr, matType)
        End If

        If matQty.Text = "" Then
            err.AppendLine("- Quantity is blank, please fill in.")
            ctr = If(ctr, matQty)
        End If

        If varlocation = "" Then
            err.AppendLine("- Location is blank, please fill in.")
            ctr = If(ctr, matLocation)
        End If

        If varbrand = "" Then
            err.AppendLine("- Brand name is blank, please fill in.")
            ctr = If(ctr, matBrand)
        End If

        If mOrderPoint.Text = "" Then
            err.AppendLine("- Reorder point is blank, please fill in.")
            ctr = If(ctr, mOrderPoint)
        End If

        If mOrderQty.Text = "" Then
            err.AppendLine("- Order quantity is blank, please fill in.")
            ctr = If(ctr, mOrderQty)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        Else
            Try
                conn.Open()
            Catch ex As Exception
                MessageBox.Show("Error Found : " + ex.Message, "Source code problem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            varqty = matQty.Text
            varorderpoint = mOrderPoint.Text
            varorderqty = mOrderQty.Text
            cmd = New SqlCommand("Update Material set mName=@mName, type=@mType, qty=@mQty, mLocation=@mLocation, mBrand=@mBrand, reorderPoint=@mOrderpoint, reorderQty=@mOrderqty, remark=@mRemark where mID=@mID", conn)
            cmd.Parameters.AddWithValue("@mID", varmid)
            cmd.Parameters.AddWithValue("@mName", varmname)
            cmd.Parameters.AddWithValue("@mType", varmtype)
            cmd.Parameters.AddWithValue("@mQty", varqty)
            cmd.Parameters.AddWithValue("@mLocation", varlocation)
            cmd.Parameters.AddWithValue("@mBrand", varbrand)
            cmd.Parameters.AddWithValue("@mOrderpoint", varorderpoint)
            cmd.Parameters.AddWithValue("@mOrderqty", varorderqty)
            cmd.Parameters.AddWithValue("@mRemark", varremark)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Material Record is updated", "Update Infomration", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshMatDgv()
        End If
    End Sub

    Private Sub suppreset_Click(sender As Object, e As EventArgs) Handles suppreset.Click
        genUID()
        txtCName.Text = ""
        txtCAddress.Text = ""
        txtCTel.Text = ""
        txtCEmail.Text = ""
        txtPName.Text = ""
        txtPContact.Text = ""
        txtPEmail.Text = ""
    End Sub

    Private Sub suppAdd_Click(sender As Object, e As EventArgs) Handles suppAdd.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim varsuppID As String = txtsuppID.Text.Trim
        Dim CName As String = txtCName.Text.Trim
        Dim CAddress As String = txtCAddress.Text.Trim
        Dim CTel As String = txtCTel.Text.Trim
        Dim CEmail As String = txtCEmail.Text.Trim
        Dim PName As String = txtPName.Text.Trim
        Dim PContact As String = txtPContact.Text.Trim
        Dim PEmail As String = txtPEmail.Text.Trim
        Dim cmd As New SqlCommand

        If CName = "" Then
            err.AppendLine("- Company name is blank, please fill in.")
            ctr = If(ctr, txtCName)
        End If

        If CAddress = "" Then
            err.AppendLine("- Comapny address is blank, please fill in.")
            ctr = If(ctr, txtCAddress)
        End If

        If CTel = "" Then
            err.AppendLine("- Company contact no. is blank, please fill in.")
            ctr = If(ctr, txtCTel)
        End If

        If CEmail = "" Then
            err.AppendLine("- Company email is blank, please fill in.")
            ctr = If(ctr, txtCEmail)
        End If

        If PName = "" Then
            err.AppendLine("- In-charge person's name is blank, please fill in.")
            ctr = If(ctr, txtPName)
        End If

        If PContact = "" Then
            err.AppendLine("- In-charge person's contact no. is blank, please fill in.")
            ctr = If(ctr, txtPContact)
        End If

        If PEmail = "" Then
            err.AppendLine("- In-charge person's email is blank, please fill in.")
            ctr = If(ctr, txtPEmail)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        Else

            Try
                conn.Open()
            Catch ex As Exception
                MessageBox.Show("Error Found : " + ex.Message, "Source code problem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            cmd = New SqlCommand("Insert into Supplier(suppID, cName, cAddress, cContact, CEmail, suppName, suppNo, suppEmail) Values (@uID, @cname, @caddress, @ccon, @cemail, @personname, @personalcon, @personalemail)", conn)
            cmd.Parameters.AddWithValue("@uID", varsuppID)
            cmd.Parameters.AddWithValue("@cname", CName)
            cmd.Parameters.AddWithValue("@caddress", CAddress)
            cmd.Parameters.AddWithValue("@ccon", CTel)
            cmd.Parameters.AddWithValue("@cemail", CEmail)
            cmd.Parameters.AddWithValue("@personname", PName)
            cmd.Parameters.AddWithValue("@personalcon", PContact)
            cmd.Parameters.AddWithValue("@personalemail", PEmail)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Supplier record is inserted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshSuppDgv()
        End If
    End Sub

    Private Sub suppUpdate_Click(sender As Object, e As EventArgs) Handles suppUpdate.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim varsuppID As String = txtsuppID.Text.Trim
        Dim CName As String = txtCName.Text.Trim
        Dim CAddress As String = txtCAddress.Text.Trim
        Dim CTel As String = txtCTel.Text.Trim
        Dim CEmail As String = txtCEmail.Text.Trim
        Dim PName As String = txtPName.Text.Trim
        Dim PContact As String = txtPContact.Text.Trim
        Dim PEmail As String = txtPEmail.Text.Trim
        Dim cmd As New SqlCommand

        If CName = "" Then
            err.AppendLine("- Company name is blank, please fill in.")
            ctr = If(ctr, txtCName)
        End If

        If CAddress = "" Then
            err.AppendLine("- Comapny address is blank, please fill in.")
            ctr = If(ctr, txtCAddress)
        End If

        If CTel = "" Then
            err.AppendLine("- Company contact no. is blank, please fill in.")
            ctr = If(ctr, txtCTel)
        End If

        If CEmail = "" Then
            err.AppendLine("- Company email is blank, please fill in.")
            ctr = If(ctr, txtCEmail)
        End If

        If PName = "" Then
            err.AppendLine("- In-charge person's name is blank, please fill in.")
            ctr = If(ctr, txtPName)
        End If

        If PContact = "" Then
            err.AppendLine("- In-charge person's contact no. is blank, please fill in.")
            ctr = If(ctr, txtPContact)
        End If

        If PEmail = "" Then
            err.AppendLine("- In-charge person's email is blank, please fill in.")
            ctr = If(ctr, txtPEmail)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        Else

            Try
                conn.Open()
            Catch ex As Exception
                MessageBox.Show("Error Found : " + ex.Message, "Source code problem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            cmd = New SqlCommand("Update Supplier set cName=@cname, cAddress=@caddress, cContact=@ccon, CEmail=@cemail, suppName=@personname, suppNo=@personalcon, suppEmail=@personalemail where suppID=@uID", conn)
            cmd.Parameters.AddWithValue("@uID", varsuppID)
            cmd.Parameters.AddWithValue("@cname", CName)
            cmd.Parameters.AddWithValue("@caddress", CAddress)
            cmd.Parameters.AddWithValue("@ccon", CTel)
            cmd.Parameters.AddWithValue("@cemail", CEmail)
            cmd.Parameters.AddWithValue("@personname", PName)
            cmd.Parameters.AddWithValue("@personalcon", PContact)
            cmd.Parameters.AddWithValue("@personalemail", PEmail)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Supplier record is updated", "Update Infomration", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshSuppDgv()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        genSID()
        sfName.Text = ""
        sfIC.Text = ""
        sfAge.Text = ""
        sfPhone.Text = ""
        sfAddress.Text = ""
        sfEmail.Text = ""
        sfPosition.SelectedItem = "Staff"
        accID.Enabled = True
        accID.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim varstaffid As String = sfID.Text
        Dim varname As String = sfName.Text.Trim
        Dim varIC As String = sfIC.Text.Trim
        Dim varage As Integer
        Dim varphoneno As String = sfPhone.Text.Trim
        Dim varaddress As String = sfAddress.Text.Trim
        Dim varemail As String = sfEmail.Text.Trim
        Dim varposition As String = sfPosition.Text.Trim
        Dim varID As String = accID.Text.Trim
        Dim cmd As New SqlCommand

        If varname = "" Then
            err.AppendLine("- Name is blank, please fill in.")
            ctr = If(ctr, sfName)
        End If

        If varIC = "" Then
            err.AppendLine("- IC is blank, please fill in.")
            ctr = If(ctr, sfIC)
        End If

        If sfAge.Text = "" Then
            err.AppendLine("- Age is blank, please fill in.")
            ctr = If(ctr, sfAge)
        End If

        If varphoneno = "" Then
            err.AppendLine("- Phone No. is blank, please fill in.")
            ctr = If(ctr, sfPhone)
        End If

        If varaddress = "" Then
            err.AppendLine("- Address is blank, please fill in.")
            ctr = If(ctr, sfAddress)
        End If

        If varemail = "" Then
            err.AppendLine("- Email is blank, please fill in.")
            ctr = If(ctr, sfEmail)
        End If

        If varposition = "" Then
            err.AppendLine("- Position is not selected.")
            ctr = If(ctr, sfPosition)
        End If

        If varID = "" Then
            err.AppendLine("- User ID is blank, please fill in.")
            ctr = If(ctr, accID)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        Else
            Dim strbuilder As New StringBuilder
            Dim longcharacter As String = ""
            For i As Integer = 0 To 4
                Dim randInt32 As Integer = GetRandomInt32Value.GetRandomInt()
                Dim r As New Random(randInt32)
                Dim cpossibleChars() As Char
                cpossibleChars = possibleChars.ToCharArray()

                Dim nextInt As Integer = r.[Next](cpossibleChars.Length)
                Dim c As Char = cpossibleChars(nextInt)
                longcharacter = strbuilder.Append(c).ToString
            Next

            Try
                conn.Open()
            Catch ex As Exception
                MessageBox.Show("Error Found : " + ex.Message, "Source code problem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            varage = sfAge.Text
            cmd = New SqlCommand("Insert into Staff(sID, sName, IC, age, phoneNo, address, email, position, userID, password, securityCode) Values (@sID, @varname, @varIC, @varage, @varphoneno, @varaddress, @varemail, @varposition, @varID, @varpass, @last)", conn)
            cmd.Parameters.AddWithValue("@sID", varstaffid)
            cmd.Parameters.AddWithValue("@varname", varname)
            cmd.Parameters.AddWithValue("@varIC", varIC)
            cmd.Parameters.AddWithValue("@varage", varage.ToString)
            cmd.Parameters.AddWithValue("@varphoneno", varphoneno)
            cmd.Parameters.AddWithValue("@varaddress", varaddress)
            cmd.Parameters.AddWithValue("@varemail", varemail)
            cmd.Parameters.AddWithValue("@varposition", varposition)
            cmd.Parameters.AddWithValue("@varID", varID)
            cmd.Parameters.AddWithValue("@varpass", varID)
            cmd.Parameters.AddWithValue("@last", longcharacter)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Staff records is inserted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshStaffDbv()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim varstaffid As String = sfID.Text
        Dim varname As String = sfName.Text.Trim
        Dim varIC As String = sfIC.Text.Trim
        Dim varage As Integer
        Dim varphoneno As String = sfPhone.Text.Trim
        Dim varaddress As String = sfAddress.Text.Trim
        Dim varemail As String = sfEmail.Text.Trim
        Dim varposition As String = sfPosition.Text.Trim
        Dim varID As String = accID.Text.Trim
        Dim cmd As New SqlCommand

        If varname = "" Then
            err.AppendLine("- Name is blank, please fill in.")
            ctr = If(ctr, sfName)
        End If

        If varIC = "" Then
            err.AppendLine("- IC is blank, please fill in.")
            ctr = If(ctr, sfIC)
        End If

        If sfAge.Text = "" Then
            err.AppendLine("- Age is blank, please fill in.")
            ctr = If(ctr, sfAge)
        End If

        If varphoneno = "" Then
            err.AppendLine("- Phone No. is blank, please fill in.")
            ctr = If(ctr, sfPhone)
        End If

        If varaddress = "" Then
            err.AppendLine("- Address is blank, please fill in.")
            ctr = If(ctr, sfAddress)
        End If

        If varemail = "" Then
            err.AppendLine("- Email is blank, please fill in.")
            ctr = If(ctr, sfEmail)
        End If

        If varposition = "" Then
            err.AppendLine("- Position is not selected.")
            ctr = If(ctr, sfPosition)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        Else

            Try
                conn.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            varage = sfAge.Text
            cmd = New SqlCommand("Update Staff set sName=@varname, IC=@varIC, age=@varage, phoneNo=@varphoneno, address=@varaddress, email=@varemail, position=@varposition where sID=@varstaffid", conn)
            cmd.Parameters.AddWithValue("@varstaffid", varstaffid)
            cmd.Parameters.AddWithValue("@varname", varname)
            cmd.Parameters.AddWithValue("@varIC", varIC)
            cmd.Parameters.AddWithValue("@varage", varage)
            cmd.Parameters.AddWithValue("@varphoneno", varphoneno)
            cmd.Parameters.AddWithValue("@varaddress", varaddress)
            cmd.Parameters.AddWithValue("@varemail", varemail)
            cmd.Parameters.AddWithValue("@varposition", varposition)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Staff records is updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshStaffDbv()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim _dbid = sfID.Text
        Dim ans As Integer
        Dim _dbposition As String = "Retired"

        ans = MessageBox.Show("Are you sure want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ans = DialogResult.Yes Then
            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim read As SqlDataReader
            Dim temp As String = ""

            Try
                conn.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            cmd = New SqlCommand("Select sID, position from Staff where sID=@ans", conn)
            cmd.Parameters.AddWithValue("@ans", _dbid)
            read = cmd.ExecuteReader()

            If read.HasRows Then
                While read.Read()
                    temp = read("position")
                End While
                conn.Close()

                If temp.Equals("Retired") Then
                    MessageBox.Show("Incorrect position, this staff is retired before.", "Invalid Position", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    conn.Open()
                    cmd2 = New SqlCommand("Update Staff set position=@varposition where sID=@sID", conn)
                    cmd2.Parameters.AddWithValue("@varposition", _dbposition)
                    cmd2.Parameters.AddWithValue("@sID", _dbid)
                    cmd2.ExecuteNonQuery()
                    MessageBox.Show("Staff successful update", "Retired Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    refreshStaffDbv()
                End If

            Else
                MessageBox.Show("No such record in database", "Retired Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles manageFilter.Click
        Dim userinput As String = txtManage.Text

        If TabControl.SelectedTab.Equals(TabPage1) Then
            dgv.AutoGenerateColumns = True
            dgv.DataSource = GetData("SELECT * FROM Material WHERE mID ='" + userinput + "' OR type ='" + userinput + "' OR mBrand ='" + userinput + "'")
        ElseIf TabControl.SelectedTab.Equals(TabPage2) Then
            dgv.AutoGenerateColumns = True
            dgv.DataSource = GetData("SELECT * FROM Supplier WHERE suppID ='" + userinput + "' OR cName ='" + userinput + "' OR suppName ='" + userinput + "'")
        Else
            dgv.AutoGenerateColumns = True
            dgv.DataSource = GetData("SELECT sID, sName, IC, age, phoneNo, address, email, position FROM Staff WHERE sID ='" + userinput + "' OR IC ='" + userinput + "' OR position ='" + userinput + "'")
        End If
    End Sub
End Class