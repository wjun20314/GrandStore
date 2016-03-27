Imports System.Data.SqlClient

Public Class Replenishment
    Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Chun\Documents\Visual Studio 2012\Projects\FinalYearProject\FinalYearProject\GrandStore.mdf"";Integrated Security=True;Connect Timeout=30")
    Dim i As Integer

    Private Sub Replenishment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshReplDgv()

        My.Settings.Reload()
        With My.Settings
            If .rbauto = True Then autoRepl.Checked = True
            If .rbman = True Then manRepl.Checked = True
        End With

    End Sub

    Private Sub autoRepl_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles autoRepl.CheckedChanged
        replQty.Enabled = False
        btnRepl.Enabled = False

        If autoRepl.Checked = True Then
            With My.Settings
                .rbauto = True
                .rbman = False
            End With
        End If

    End Sub

    Private Sub manRepl_CheckedChanged(sender As Object, e As EventArgs) Handles manRepl.CheckedChanged
        replQty.Enabled = True
        btnRepl.Enabled = True

        If manRepl.Checked = True Then
            With My.Settings
                .rbauto = False
                .rbman = True
            End With
        End If
    End Sub

    Private Sub refreshReplDgv()
        replDgv.AutoGenerateColumns = True
        replDgv.DataSource = GetData("SELECT mID, mName, mType, mQty, mBrand, reorderPoint, reorderQty FROM Repl")
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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshReplDgv()
    End Sub

    Private Sub replDgv_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles replDgv.RowHeaderMouseClick
        i = e.RowIndex
    End Sub

    Private Sub btnRepl_Click(sender As Object, e As EventArgs) Handles btnRepl.Click
        Dim amount As Integer = replQty.Text
        Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Chun\Documents\Visual Studio 2012\Projects\FinalYearProject\FinalYearProject\GrandStore.mdf"";Integrated Security=True;Connect Timeout=30")
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim cmd3 As New SqlCommand
        Dim read As SqlDataReader
        Dim varmid As String
        Dim varmname As String
        Dim varmqty As String
        Dim suppID = ""
        Dim suppName = ""
        Dim suppEmail = ""
        Dim getMail As New MailService("smtp.gmail.com", "redplusclinic@gmail.com", "1914866381lwc")

        If replDgv.SelectedRows.Count = 0 And replDgv.SelectedRows.Count > 2 Then
            MessageBox.Show("Please select a row record for replenishment", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf replQty.Text = "" Then
            MessageBox.Show("Please enter a value", "Null Value", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            varmid = CStr(replDgv.Rows(i).Cells(0).Value)
            varmname = CStr(replDgv.Rows(i).Cells(1).Value)
            varmqty = CStr(replDgv.Rows(i).Cells(3).Value)

            Try
                conn.Open()
            Catch ex As Exception
                MessageBox.Show("Error Found : " + ex.Message, "Source code problem", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            cmd = New SqlCommand("SELECT uID FROM Repl WHERE mID=@mid", conn)
            cmd.Parameters.AddWithValue("@mid", varmid)
            suppID = cmd.ExecuteScalar()

            cmd2 = New SqlCommand("SELECT suppName, suppEmail FROM Supplier WHERE suppID=@uid", conn)
            cmd2.Parameters.AddWithValue("@uid", suppID)
            read = cmd2.ExecuteReader()

            If read.HasRows Then
                While read.Read()
                    suppName = read("suppName")
                    suppEmail = read("suppEmail")
                End While

            End If
            conn.Close()

            Dim bodymsg As String = "Dear " & suppName & "," & "</br></br>Request replenishment for " & varmname &
                                    " with quantity " & amount & ".</br><br>Thank you." & "</br></br>Best Regards, " &
                                    MainMenu.mmsname & "</br>" & "GrandStore " & MainMenu.mmposition

            getMail.sendMail("redplusclinic@gmail.com", suppEmail, "Request Replenishment", bodymsg)
            MessageBox.Show("Replenishment email had sent", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim connect As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Chun\Documents\Visual Studio 2012\Projects\FinalYearProject\FinalYearProject\GrandStore.mdf"";Integrated Security=True;Connect Timeout=30")
            connect.Open()
            cmd3 = New SqlCommand("DELETE FROM Repl WHERE mID=@rmid AND uID=@ruid", connect)
            cmd3.Parameters.AddWithValue("@rmid", varmid)
            cmd3.Parameters.AddWithValue("@ruid", suppID)
            cmd3.ExecuteNonQuery()
            connect.Close()
        End If
    End Sub

    Private Sub Replenishment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
    End Sub
End Class