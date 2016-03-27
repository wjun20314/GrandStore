Imports System.Data.SqlClient

Public Class History

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshHisDgv()
    End Sub

    Private Sub refreshHisDgv()
        historydgv.AutoGenerateColumns = True
        historydgv.DataSource = GetData("SELECT * FROM History")
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

    Private Sub btnhfilter_Click(sender As Object, e As EventArgs) Handles btnhfilter.Click
        Dim userinput As String = txtHistory.Text
        historydgv.AutoGenerateColumns = True
        historydgv.DataSource = GetData("SELECT * FROM History WHERE hID ='" + userinput + "' OR date ='" + userinput + "' OR oID ='" + userinput + "'")
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        dlgPreview.Show()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub
End Class