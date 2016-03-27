Imports System.Data.SqlClient
Imports System.Data
Imports System.Text

Public Class Login
    Public holdID As String
    Public holdUserName As String
    Public holdname As String
    Public holdposi As String
    Public holduserid As String
    Public holdemail As String
    Public holdsecurity As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userID As String = txtID.Text.Trim
        Dim pass As String = txtPass.Text.Trim
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim conn As SqlConnection
        Dim cmd As New SqlCommand
        Dim read As SqlDataReader

        conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Chun\Documents\Visual Studio 2012\Projects\FinalYearProject\FinalYearProject\GrandStore.mdf"";Integrated Security=True;Connect Timeout=30")

        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If userID = "" Then
            err.AppendLine("- Username is blank, please fill in before you proceed")
            ctr = If(ctr, txtID)
        End If

        If pass = "" Then
            err.AppendLine("- Password is blank, please fill in before you proceed.")
            ctr = If(ctr, txtPass)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        End If

        cmd = New SqlCommand("Select * From Staff where userID=@userID AND password=@password", conn)
        cmd.Parameters.AddWithValue("@userID", txtID.Text)
        cmd.Parameters.AddWithValue("@password", txtPass.Text)
        read = cmd.ExecuteReader()

        If read.HasRows Then
            While read.Read()
                holdID = read("sID")
                holdname = read("sName")
                holdposi = read("position")
                holduserid = read("userID")
                holdemail = read("email")
            End While

            holdUserName = txtID.Text
            MessageBox.Show("Welcome to GrandSell", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MainMenu.Show()
            Me.Close()
        Else
            MessageBox.Show("Login faild, invalid ID or password.", "Login Faild", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtID.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles forgetPass.Click
        Forget_Password.ShowDialog()
    End Sub
End Class
