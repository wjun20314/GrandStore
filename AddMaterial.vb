Imports System.Text
Imports System.Data.SqlClient


Public Class AddMaterial
    Private Sub AddMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        genMID()
    End Sub

    Private Sub genMID()
        Dim conn As SqlConnection
        Dim cmd As New SqlCommand
        Dim read As SqlDataReader

        Dim lastmid As String = ""
        Dim _num As Integer = 0

        conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Chun\Documents\Visual Studio 2012\Projects\FinalYearProject\FinalYearProject\GrandStore.mdf"";Integrated Security=True;Connect Timeout=30")

        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cmd = New SqlCommand("SELECT MAX(mID) as lastid FROM Material", conn)
        read = cmd.ExecuteReader()

        If read.HasRows Then
            While read.Read()
                lastmid = read("lastid")
            End While
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

            txtMID.Text = lastmid
        End If
    End Sub

    Private Sub rst_Click(sender As Object, e As EventArgs) Handles rst.Click
        genMID()
        txtMName.Text = ""
        txtMType.SelectedIndex = 0
        txtMQty.Text = ""
        txtMLocation.Text = ""
        txtMBrand.Text = ""
        txtOPoint.Text = ""
        txtOQty.Text = ""
        txtMRemark.Text = ""
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim varmid As String = txtMID.Text.Trim
        Dim varmname As String = txtMName.Text.Trim
        Dim varmtype As String = txtMType.Text.Trim
        Dim varqty As Integer
        Dim varlocation As String = txtMLocation.Text.Trim
        Dim varbrand As String = txtMBrand.Text.Trim
        Dim varorderpoint As Integer
        Dim varorderqty As Integer
        Dim varremark As String = txtMRemark.Text.Trim
        Dim conn As SqlConnection
        Dim cmd As New SqlCommand

        If varmname = "" Then
            err.AppendLine("- Material name is blank, please fill in.")
            ctr = If(ctr, txtMName)
        End If

        If varmtype = "" Then
            err.AppendLine("- Material type is not selected.")
            ctr = If(ctr, txtMType)
        End If

        If txtMQty.Text = "" Then
            err.AppendLine("- Quantity is blank, please fill in.")
            ctr = If(ctr, txtMQty)
        End If

        If varlocation = "" Then
            err.AppendLine("- Location is blank, please fill in.")
            ctr = If(ctr, txtMLocation)
        End If

        If varbrand = "" Then
            err.AppendLine("- Brand name is blank, please fill in.")
            ctr = If(ctr, txtMBrand)
        End If

        If txtOPoint.Text = "" Then
            err.AppendLine("- Reorder point is blank, please fill in.")
            ctr = If(ctr, txtOPoint)
        End If

        If txtOQty.Text = "" Then
            err.AppendLine("- Order quantity is blank, please fill in.")
            ctr = If(ctr, txtOQty)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        Else
            conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Chun\Documents\Visual Studio 2012\Projects\FinalYearProject\FinalYearProject\GrandStore.mdf"";Integrated Security=True;Connect Timeout=30")

            Try
                conn.Open()
            Catch ex As Exception
                MessageBox.Show("Error Found : " + ex.Message, "Source code problem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            varqty = txtMQty.Text
            varorderpoint = txtOPoint.Text
            varorderqty = txtOQty.Text
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

            MessageBox.Show("Material records is inserted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            genMID()
        End If
    End Sub
End Class