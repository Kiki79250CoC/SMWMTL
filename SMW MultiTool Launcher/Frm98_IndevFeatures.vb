
Public Class Frm98_IndevFeatures

    Private Sub Frm98_IndevFeatures_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Icon = My.Resources.AppIcon

        ' Experimental Settings
        ExSet_DarkModeHomeUpdateBar.Checked = My.Settings.EX_SET_DARKMODE_HOMEUPDATEBAR
        ExSet_W10AeroGlass.Checked = My.Settings.EX_W10_AERO

    End Sub
    Private Sub ValidateBtn_Click(sender As Object, e As EventArgs) Handles ValidateBtn.Click

        ' Save Settings
        My.Settings.EX_SET_DARKMODE_HOMEUPDATEBAR = ExSet_DarkModeHomeUpdateBar.Checked
        My.Settings.EX_W10_AERO = ExSet_W10AeroGlass.Checked

        Close()

    End Sub
    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub

End Class