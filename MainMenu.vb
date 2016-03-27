Public Class MainMenu
    Public mmsid As String
    Public mmsname As String
    Public mmposition As String
    Public mmuid As String
    Public mmemail As String

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim temp As String

        temp = Login.holdID
        mmsid = temp
        temp = Login.holdname
        mmsname = temp
        temp = Login.holdposi
        mmposition = temp
        temp = Login.holduserid
        mmuid = temp
        temp = Login.holdemail
        mmemail = temp

        lblUser.Text = mmsname
        lblLogged.Text = System.DateTime.Now
        lblPosition.Text = mmposition
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        DataManage.ShowDialog()
    End Sub

    Private Sub btnInOut_Click(sender As Object, e As EventArgs) Handles btnInOut.Click
        InOut.ShowDialog()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        History.ShowDialog()
    End Sub

    Private Sub btnRepl_Click(sender As Object, e As EventArgs) Handles btnRepl.Click
        Replenishment.ShowDialog()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ReportSelect.ShowDialog()
    End Sub

    Private Sub btnAcc_Click(sender As Object, e As EventArgs) Handles btnAcc.Click
        Forget_Password2.ShowDialog()
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Privilege.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Close()
    End Sub

    'Private Sub crossButton(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    If (MessageBox.Show("Are you sure want exit the system?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
    '        Me.Close()
    '    Else
    '        e.Cancel = True
    '    End If
    'End Sub
End Class