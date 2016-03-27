Public Class SendingEmail

    Private Sub SendingEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bar.Maximum = 100
        lblMsg.Text = "Sending email, please wait..."

        While bar.Value < bar.Maximum
            bar.Value += 1
        End While
        Me.Close()
    End Sub
End Class