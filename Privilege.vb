Public Class Privilege

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        With My.Settings
            If .Mmanage = True Then mcb1.Checked = True
            If .Minout = True Then mcb2.Checked = True
            If .Mpri = True Then mcb3.Checked = True
            If .Mrepl = True Then mcb4.Checked = True

            If .Supmange = True Then supcb1.Checked = True
            If .Supinout = True Then supcb2.Checked = True
            If .Suppri = True Then supcb3.Checked = True
            If .Suprepl = True Then supcb4.Checked = True

            If .Sfmanage = True Then sfcb1.Checked = True
            If .Supinout = True Then sfcb2.Checked = True
            If .Sfpri = True Then sfcb3.Checked = True
            If .Sfrepl = True Then sfcb4.Checked = True
        End With
    End Sub

    Private Sub mcb1_CheckedChanged(sender As Object, e As EventArgs) Handles mcb1.CheckedChanged
        If mcb1.Checked = True Then My.Settings.Mmanage = True Else My.Settings.Mmanage = False
    End Sub

    Private Sub mcb2_CheckedChanged(sender As Object, e As EventArgs) Handles mcb2.CheckedChanged
        If mcb2.Checked = True Then My.Settings.Minout = True Else My.Settings.Minout = False
    End Sub

    Private Sub mcb3_CheckedChanged(sender As Object, e As EventArgs) Handles mcb3.CheckedChanged
        If mcb3.Checked = True Then My.Settings.Mpri = True Else My.Settings.Mpri = False
    End Sub

    Private Sub mcb4_CheckedChanged(sender As Object, e As EventArgs) Handles mcb4.CheckedChanged
        If mcb4.Checked = True Then My.Settings.Mrepl = True Else My.Settings.Mrepl = False
    End Sub

    Private Sub supcb1_CheckedChanged(sender As Object, e As EventArgs) Handles supcb1.CheckedChanged
        If supcb1.Checked = True Then My.Settings.Supmange = True Else My.Settings.Supmange = False
    End Sub

    Private Sub supcb2_CheckedChanged(sender As Object, e As EventArgs) Handles supcb2.CheckedChanged
        If supcb2.Checked = True Then My.Settings.Supinout = True Else My.Settings.Supinout = False
    End Sub

    Private Sub supcb3_CheckedChanged(sender As Object, e As EventArgs) Handles supcb3.CheckedChanged
        If supcb3.Checked = True Then My.Settings.Suppri = True Else My.Settings.Suppri = False
    End Sub

    Private Sub supcb4_CheckedChanged(sender As Object, e As EventArgs) Handles supcb4.CheckedChanged
        If supcb4.Checked = True Then My.Settings.Suprepl = True Else My.Settings.Suprepl = False
    End Sub

    Private Sub sfcb1_CheckedChanged(sender As Object, e As EventArgs) Handles sfcb1.CheckedChanged
        If sfcb1.Checked = True Then My.Settings.Sfmanage = True Else My.Settings.Sfmanage = False
    End Sub

    Private Sub sfcb2_CheckedChanged(sender As Object, e As EventArgs) Handles sfcb2.CheckedChanged
        If sfcb2.Checked = True Then My.Settings.Sfinout = True Else My.Settings.Sfinout = False
    End Sub

    Private Sub sfcb3_CheckedChanged(sender As Object, e As EventArgs) Handles sfcb3.CheckedChanged
        If sfcb3.Checked = True Then My.Settings.Sfpri = True Else My.Settings.Sfpri = False
    End Sub

    Private Sub sfcb4_CheckedChanged(sender As Object, e As EventArgs) Handles sfcb4.CheckedChanged
        If sfcb4.Checked = True Then My.Settings.Sfrepl = True Else My.Settings.Sfrepl = False
    End Sub

    Private Sub Privilege_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
    End Sub
End Class