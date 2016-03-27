Imports System.Text
Imports System.Data.SqlClient

Public Class Forget_Password
    Private GetRandomInt32Value As New RandomInt32Value
    Dim possibleChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtSID.Text = ""
        txtID.Text = ""
        txtNewPass.Text = ""
        txtSecCode.Text = ""
    End Sub

    Private Sub btnReqCode_Click(sender As Object, e As EventArgs) Handles btnReqCode.Click
        Dim conn As SqlConnection
        Dim cmd As SqlCommand
        Dim cmd2 As New SqlCommand
        Dim sccode As String = ""
        Dim err As New StringBuilder
        Dim ctr As Control = Nothing
        Dim ctrSID As String = txtSID.Text.Trim
        Dim ctrID As String = txtID.Text.Trim
        Dim strbuilder As New StringBuilder
        Dim longcharacter As String = ""
        Dim getMail As New MailService("smtp.gmail.com", "redplusclinic@gmail.com", "1914866381lwc")
        Dim email As String

        If ctrSID = "" Then
            err.AppendLine("- Staff ID is blank, please fill in field")
            ctr = If(ctr, txtSID)
        End If

        If ctrID = "" Then
            err.AppendLine("- Username is blank, please fill in field")
            ctr = If(ctr, txtID)
        End If

        For i As Integer = 0 To 4
            Dim randInt32 As Integer = GetRandomInt32Value.GetRandomInt()
            Dim r As New Random(randInt32)
            Dim cpossibleChars() As Char
            cpossibleChars = possibleChars.ToCharArray()

            Dim nextInt As Integer = r.[Next](cpossibleChars.Length)
            Dim c As Char = cpossibleChars(nextInt)
            longcharacter = strbuilder.Append(c).ToString
        Next

        Dim bodymsg As String = "Hi " & ctrSID + ",</br></br>" & "This is your security code " & longcharacter &
            ", please reset your password that you familiar to remember.</br></br>Thank you.</br></br>Best Regards,</br>GrandStore System Administrator"

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Chun\Documents\Visual Studio 2012\Projects\FinalYearProject\FinalYearProject\GrandStore.mdf"";Integrated Security=True;Connect Timeout=30")
            Try
                conn.Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            cmd = New SqlCommand("SELECT email FROM Staff WHERE sID=@sid AND userID=@uid", conn)
            cmd.Parameters.AddWithValue("@sid", ctrSID)
            cmd.Parameters.AddWithValue("@uid", ctrID)
            email = cmd.ExecuteScalar()

            cmd2 = New SqlCommand("UPDATE Staff set securityCode=@sccode WHERE sID=@staffid", conn)
            cmd2.Parameters.AddWithValue("@sccode", longcharacter)
            cmd2.Parameters.AddWithValue("@staffid", ctrSID)
            cmd2.ExecuteNonQuery()

            getMail.sendMail("redplusclinic@gmail.com", email, "Security Code", bodymsg)
            MessageBox.Show("Security code had sent to your email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnResetPass_Click(sender As Object, e As EventArgs) Handles btnResetPass.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim ctrSID As String = txtSID.Text.Trim
        Dim ctrID As String = txtID.Text.Trim
        Dim ctrNewPass As String = txtNewPass.Text.Trim
        Dim ctrSCode As String = txtSecCode.Text.Trim
        Dim conn As SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim codetemp As String = ""

        If ctrSID = "" Then
            err.AppendLine("- Staff ID is blank, please fill in field")
            ctr = If(ctr, txtSID)
        End If

        If ctrID = "" Then
            err.AppendLine("- Username is blank, please fill in field")
            ctr = If(ctr, txtID)
        End If

        If ctrNewPass = "" Then
            err.AppendLine("- New Password is blank, please fill in field")
            ctr = If(ctr, txtNewPass)
        End If

        If ctrSCode = "" Then
            err.AppendLine("- Security Code is blank, please fill in before reset your password")
            ctr = If(ctr, txtSecCode)
        End If

        conn = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Chun\Documents\Visual Studio 2012\Projects\FinalYearProject\FinalYearProject\GrandStore.mdf"";Integrated Security=True;Connect Timeout=30")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        cmd = New SqlCommand("SELECT securityCode FROM Staff WHERE sID=@sid AND userID=@userid", conn)
        cmd.Parameters.AddWithValue("@sid", ctrSID)
        cmd.Parameters.AddWithValue("@userid", ctrID)
        codetemp = cmd.ExecuteScalar

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf ctrSCode <> codetemp Then
            MessageBox.Show("Security Code is incorrect", "Verification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            cmd2 = New SqlCommand("UPDATE Staff set password=@password WHERE sID=@staffid", conn)
            cmd2.Parameters.AddWithValue("@password", ctrNewPass)
            cmd2.Parameters.AddWithValue("@staffid", ctrSID)
            cmd2.ExecuteNonQuery()
            MessageBox.Show("Your password was changed", "Successful Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class