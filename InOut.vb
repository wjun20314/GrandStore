Imports System.Data.SqlClient
Imports System.Text

Public Class InOut
    Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Chun\Documents\Visual Studio 2012\Projects\FinalYearProject\FinalYearProject\GrandStore.mdf"";Integrated Security=True;Connect Timeout=30")
    Dim lasthid As String = ""

    Private Sub InOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        genMID()
        refreshInDgv()
        genOID()
        refreshOutDgv()
        genhID()

        Dim cmd As New SqlCommand
        Dim read As SqlDataReader
        Dim tempID As String

        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cmd = New SqlCommand("Select mID From Material", conn)
        read = cmd.ExecuteReader()

        If read.HasRows Then
            While read.Read()
                tempID = read("mID")
                cboMID.Items.Add(tempID)
            End While
        End If

        conn.Close()
    End Sub

    Private Sub cbmatid_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboMID.SelectedValueChanged
        Dim cmd As New SqlCommand
        Dim read As SqlDataReader
        Dim cbotempselect As String = cboMID.Text.Trim
        Dim cbotempselectvalue As String = ""

        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cmd = New SqlCommand("SELECT mName FROM Material WHERE mID = '" + cbotempselect.ToString + "'", conn)
        read = cmd.ExecuteReader()

        If read.HasRows Then
            While read.Read()
                cbotempselectvalue = read("mName")
            End While
        End If

        mName.Text = cbotempselectvalue
    End Sub

    Private Sub refreshInDgv()
        Dim dt As DataTable = New DataTable("Inbound")
        Dim dc As DataColumn = dt.Columns.Add("Material ID")

        dc.AllowDBNull = False
        dc.Unique = True
        dt.Columns.Add("Material Name")
        dt.Columns.Add("Material Type")
        dt.Columns.Add("Quantity")
        inDgv.DataSource = GetData("SELECT mID, mName, type, qty FROM Material")
    End Sub

    Private Sub refreshOutDgv()
        outDgv.AutoGenerateColumns = True
        outDgv.DataSource = GetData("SELECT * FROM OrderTable WHERE date = '" + System.DateTime.Now.ToString("yyyy/MM/dd") + "'")
    End Sub

    Private Shared Function GetData(ByVal sqlCommand As String) As DataTable
        Dim conn As SqlConnection
        Dim cmd As New SqlCommand
        Dim adapter As SqlDataAdapter = New SqlDataAdapter()

        conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Chun\Documents\Visual Studio 2012\Projects\FinalYearProject\FinalYearProject\GrandStore.mdf"";Integrated Security=True;Connect Timeout=30")
        cmd = New SqlCommand(sqlCommand, conn)
        adapter.SelectCommand = cmd
        conn.Close()

        Dim table As New DataTable
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        adapter.Fill(table)
        Return table
    End Function

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
        conn.Close()

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

        txtMID.Text = lastmid
    End Sub

    Private Sub genhID()
        Dim cmd As New SqlCommand
        Dim _num As Integer = 0

        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cmd = New SqlCommand("SELECT MAX(hID) as lastid FROM History", conn)
        lasthid = cmd.ExecuteScalar()
        _num = lasthid.Substring(1) + 1
        conn.Close()

        If _num < 10 Then
            lasthid = "H000" + _num.ToString
        ElseIf _num > 9 And _num < 100 Then
            lasthid = "H00" + _num.ToString
        ElseIf _num > 99 And _num < 1000 Then
            lasthid = "H0" + _num.ToString
        ElseIf _num > 999 And _num < 9999 Then
            lasthid = "H" + _num.ToString
        Else
            lasthid = 0
        End If

    End Sub

    Private Sub inDgv_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles inDgv.RowHeaderMouseDoubleClick
        Dim i As Integer = e.RowIndex
        Dim varMID As String
        Dim varMName As String
        Dim varType As String

        varMID = CStr(inDgv.Rows(i).Cells(0).Value)
        varMName = CStr(inDgv.Rows(i).Cells(1).Value)
        varType = CStr(inDgv.Rows(i).Cells(2).Value)
        txtMID.Text = varMID
        txtMName.Text = varMName
        txtType.Text = varType
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        genMID()
        txtMName.Text = ""
        txtType.Text = ""
        txtQty.Text = ""
        refreshInDgv()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim varmid As String = txtMID.Text.Trim
        Dim varmname As String = txtMName.Text.Trim
        Dim varmtype As String = txtType.Text.Trim
        Dim varqty As Integer
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand

        If varmname = "" Then
            err.AppendLine("- Material name is blank, please fill in.")
            ctr = If(ctr, txtMID)
        End If

        If varmtype = "" Then
            err.AppendLine("- Material type is not selected.")
            ctr = If(ctr, txtMName)
        End If

        If txtQty.Text = "" Then
            err.AppendLine("- Quantity is blank, please fill in.")
            ctr = If(ctr, txtQty)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        Else

            varqty = txtQty.Text
            Try
                conn.Open()
                cmd = New SqlCommand("Update Material set qty=(qty+@mQty) where mID=@mID", conn)
                cmd.Parameters.AddWithValue("@mQty", varqty.ToString)
                cmd.Parameters.AddWithValue("@mID", varmid)

                cmd2 = New SqlCommand("INSERT into History(hID, date, time, category, oID, mID, qty) values(@hid, @currdate, @currtime, @cate, @oid, @mid, @quantity)", conn)
                cmd2.Parameters.AddWithValue("@hid", lasthid)
                cmd2.Parameters.AddWithValue("@currdate", System.DateTime.Now.ToString("yyyy/MM/dd"))
                cmd2.Parameters.AddWithValue("@currtime", System.DateTime.Now.ToString("HH:mm:ss"))
                cmd2.Parameters.AddWithValue("@cate", "Stock import")
                cmd2.Parameters.AddWithValue("@oid", "-")
                cmd2.Parameters.AddWithValue("@mid", varmid)
                cmd2.Parameters.AddWithValue("@quantity", varqty)
            Catch ex As Exception
                MessageBox.Show("Error Found : " + ex.Message, "Source code problem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            MessageBox.Show("Material Record is updated", "Update Infomration", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshInDgv()
            conn.Close()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddMaterial.ShowDialog()
    End Sub

    Private Sub genOID()
        Dim cmd As New SqlCommand
        Dim lastoid As String = ""
        Dim _num As Integer = 0

        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cmd = New SqlCommand("Select MAX(oID) as lastid From OrderTable", conn)
        lastoid = cmd.ExecuteScalar()
        _num = lastoid.Substring(1) + 1
        conn.Close()

        If _num < 10 Then
            lastoid = "O000" + _num.ToString
        ElseIf _num > 9 And _num < 100 Then
            lastoid = "O00" + _num.ToString
        ElseIf _num > 99 And _num < 1000 Then
            lastoid = "O0" + _num.ToString
        ElseIf _num > 999 And _num < 9999 Then
            lastoid = "O" + _num.ToString
        Else
            lastoid = 0
        End If

        txtOID.Text = lastoid
    End Sub

    Private Sub outReset_Click(sender As Object, e As EventArgs) Handles outReset.Click
        genOID()
        qty.Text = ""
        refreshOutDgv()
    End Sub

    Private Sub outAdd_Click(sender As Object, e As EventArgs) Handles outAdd.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim varoid As String = txtOID.Text
        Dim varcbomid As String = cboMID.Text.Trim
        Dim varoname As String = mName.Text.Trim
        Dim varqty As Integer
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim cmd3 As New SqlCommand

        If varcbomid = "" Then
            err.AppendLine("- Material ID is not selected.")
            ctr = If(ctr, cboMID)
        End If

        If qty.Text = "" Then
            err.AppendLine("- Quantity is blank, please fill in.")
            ctr = If(ctr, qty)
        End If


        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        Else
            varqty = qty.Text

            Try
                conn.Open()
                cmd = New SqlCommand("Insert into OrderTable(oID, mID, name, date, time, quantity) Values (@OID, @MID, @NAME, @DATE, @TIMR, @QUANTITY)", conn)
                cmd.Parameters.AddWithValue("@OID", varoid)
                cmd.Parameters.AddWithValue("@MID", varcbomid)
                cmd.Parameters.AddWithValue("@NAME", varoname)
                cmd.Parameters.AddWithValue("@DATE", System.DateTime.Now.ToString("yyyy/MM/dd"))
                cmd.Parameters.AddWithValue("@TIMR", System.DateTime.Now.ToString("HH:mm:ss"))
                cmd.Parameters.AddWithValue("@QUANTITY", varqty)

                cmd2 = New SqlCommand("Update Material set qty=(qty-@amount) WHERE mID=@mid", conn)
                cmd2.Parameters.AddWithValue("@amount", varqty)
                cmd2.Parameters.AddWithValue("@mid", varcbomid)

                cmd3 = New SqlCommand("Insert into Repl SELECT * FROM Material where qty <= reorderPoint", conn)

            Catch ex As SqlException
                MessageBox.Show("No duplicate item in same order", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            cmd3.ExecuteNonQuery()
        End If

        MessageBox.Show("Order records is inserted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        refreshOutDgv()
    End Sub

    Private Sub outGenerateOrder_Click(sender As Object, e As EventArgs) Handles outGenerateOrder.Click

    End Sub

    Private Sub btnISearch_Click(sender As Object, e As EventArgs) Handles btnISearch.Click
        Dim ivalue As String = txtI.Text
        inDgv.AutoGenerateColumns = True
        inDgv.DataSource = GetData("SELECT mID, mName, type, qty FROM Material WHERE mID ='" + ivalue + "' OR mName ='" + ivalue + "' OR type ='" + ivalue + "'")
    End Sub

    Private Sub btnOSearch_Click(sender As Object, e As EventArgs) Handles btnOSearch.Click
        Dim ovalue As String = txtO.Text
        outDgv.AutoGenerateColumns = True
        outDgv.DataSource = GetData("SELECT * FROM OrderTable WHERE oID ='" + ovalue + "' AND date = '" + System.DateTime.Now.ToString("yyyy/MM/dd") + "' OR mID ='" + ovalue + "' AND date = '" + System.DateTime.Now.ToString("yyyy/MM/dd") + "' OR name ='" + ovalue + "' AND date = '" + System.DateTime.Now.ToString("yyyy/MM/dd") + "'")
    End Sub
End Class