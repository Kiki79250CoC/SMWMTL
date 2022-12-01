
Public Class Frm05_UpdateDetected

    Private Sub Frm05_UpdateDetected_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Doing actions according to custom releases

        Select Case My.Resources.RELEASE_TYPE
            Case "SMWC"
                Opacity = 0
                Height = 0
                Width = 0
                Close()
                Throw New UnauthorizedAccessException

        End Select

        Icon = My.Resources.AppIcon

        ' DarkMode Toggle
        Select Case My.Settings.UI_DARK_MODE
            Case True
                ForeColor = Color.White
                BackColor = Color.FromArgb(36, 36, 36)
                UI_StatPanel.BackColor = Color.FromArgb(25, 25, 25)
                UI_BtmBar_Panel.BackColor = Color.FromArgb(25, 25, 25)
                UI_HeaderBorder.BackgroundImage = My.Resources.UI_BorderLineBottom
                UI_BtmBar_PanelBorder.BackgroundImage = My.Resources.UI_BottomBar

                UI_AppLogo.Image = My.Resources.UpdateLogo_Dark
                UI_UpdateGraphicLine01.Image = My.Resources.UI_UpdatePopupGradient
                UI_Changelog_TextBox.BackColor = Color.FromArgb(25, 25, 25)
                UI_ChangelogPanel.BackColor = Color.FromArgb(25, 25, 25)
                UI_Changelog_TextBox.ForeColor = Color.White

        End Select

    End Sub

    ' "Download and install" button
    Private Sub UI_InstallUpdateBtn_Click(sender As Object, e As EventArgs) Handles UI_InstallUpdateBtn.Click
        Close()
        Frm04_UpdatesModal.ShowDialog()
    End Sub

    ' "Not now" button
    Private Sub UI_DeclineUpdateBtn_Click(sender As Object, e As EventArgs) Handles UI_DeclineUpdateBtn.Click
        Close()
    End Sub

    Private Sub UI_IgnoreVersionUpdateBtn_Click(sender As Object, e As EventArgs) Handles UI_IgnoreVersionUpdateBtn.Click
        My.Settings.UPDATE_IGNORED_VERSION = My.Settings.UPDATE_FOUND_CVERSION_WITHOUT_BUILDNBR
        Close()
    End Sub
End Class