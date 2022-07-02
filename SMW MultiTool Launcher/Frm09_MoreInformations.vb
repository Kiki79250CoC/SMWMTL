
Imports System.Globalization

Public Class Frm09_MoreInformations
#Region "        Values "

    ' Application executable location
    ReadOnly Locate As String = My.Application.Info.DirectoryPath

    ' Windows NT Kernel version
    ReadOnly Win_NT_Version As String = $"{Environment.OSVersion.Version.Major}.{Environment.OSVersion.Version.Minor}"

    ' Build number
    ReadOnly Win_BuildNbr As String = Environment.OSVersion.Version.Build

    ' Software compile date
    ReadOnly CompileDate As New DateTime(My.Resources.BUILD_DATE_YEAR, My.Resources.BUILD_DATE_MONTH, My.Resources.BUILD_DATE_DAY)

#End Region

    Private Sub Frm09_MoreInformations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Icon = My.Resources.AppIcon

        Select Case My.Settings.UI_DARK_MODE
            Case True
                ForeColor = Color.White
                BackColor = Color.FromArgb(36, 36, 36)
                UI_StatPanel.BackColor = Color.FromArgb(25, 25, 25)
                UI_BtmBar_Panel.BackColor = Color.FromArgb(25, 25, 25)
                UI_HeaderBorder.BackgroundImage = My.Resources.UI_BorderLineBottom
                UI_BtmBar_Panel.BackgroundImage = My.Resources.UI_BottomBar

                For Each Tabs As TabPage In {UI_Tab01_LegalNotice, UI_Tab02_License, UI_Tab03_Changelog, UI_Tab04_OtherCredits}
                    Tabs.BackColor = Color.FromArgb(36, 36, 36)
                Next

                For Each TxtBx As RichTextBox In {Licence_TextBox, Changelog_TextBox}
                    TxtBx.BackColor = Color.FromArgb(25, 25, 25)
                    TxtBx.ForeColor = Color.White
                Next

                For Each Panels As Panel In {UI_LicensePanel, UI_ChangelogPanel}
                    Panels.BackColor = Color.FromArgb(25, 25, 25)
                Next

                For Each Title As Label In {LegalNotice_Text01, OtherCredits_Text01}
                    Title.ForeColor = Color.White
                Next

                Developement_Tool_GroupBox_Pic.Image = My.Resources.VSLogo_Dark

        End Select

        ' Hiding the title and the window icon
        Select Case My.Settings.HIDE_TITLE
            Case True
                Text = Nothing

        End Select
        Select Case My.Settings.HIDE_ICON
            Case True
                Select Case My.Settings.BLANK_ICON
                    Case True
                        Icon = My.Resources.Blank16x16

                    Case False
                        ShowIcon = False

                End Select

        End Select

        ' Window opacity
        Select Case My.Settings.APP_OPACITY_TOGGLE
            Case True
                Select Case My.Settings.APP_OPACITY_APPLY_MODE
                    Case Is >= 1
                        Opacity = My.Settings.APP_OPACITY / 100

                End Select

        End Select

        ' Dynamic values
        Select Case My.Computer.Info.InstalledUICulture.ToString.Contains("fr")
            Case True
                Licence_TextBox.Text = My.Resources.SMWMTL_License_fr.Replace("$version", $"{My.Resources.APP_VERSION} (Build {My.Resources.APP_VERSION_BUILD}{If(My.Settings.IS_PRERELEASE = True, $" • {My.Resources.RELEASE_STATE}", "")})").Replace("$Author", My.Resources.APP_AUTHOR).Replace("$Year", $"{If(Year(Now) > My.Resources.BUILD_DATE_YEAR, Year(Now), My.Resources.BUILD_DATE_YEAR)}").Replace("$CompileDate", $"{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CompileDate.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture(If(My.Computer.Info.InstalledUICulture.ToString().Contains("fr"), "fr-FR", "en-US"))))}")
                Changelog_TextBox.Text = If(My.Resources.IS_LTS = "True", My.Resources.SMWMTL_Changelog_LTS_fr, My.Resources.SMWMTL_Changelog_fr)

            Case False
                Licence_TextBox.Text = My.Resources.SMWMTL_License.Replace("$version", $"{My.Resources.APP_VERSION} (Build {My.Resources.APP_VERSION_BUILD}{If(My.Settings.IS_PRERELEASE = True, $" • {My.Resources.RELEASE_STATE}", "")})").Replace("$Author", My.Resources.APP_AUTHOR).Replace("$Year", $"{If(Year(Now) > My.Resources.BUILD_DATE_YEAR, Year(Now), My.Resources.BUILD_DATE_YEAR)}").Replace("$CompileDate", $"{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CompileDate.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture(If(My.Computer.Info.InstalledUICulture.ToString().Contains("fr"), "fr-FR", "en-US"))))}")
                Changelog_TextBox.Text = If(My.Resources.IS_LTS = "True", My.Resources.SMWMTL_Changelog_LTS, My.Resources.SMWMTL_Changelog)

        End Select

        LegalNotice_Text02.Text = LegalNotice_Text02.Text.Replace("$Author$", My.Resources.APP_AUTHOR)

        Developement_Tool_GroupBox_Text.Text = Developement_Tool_GroupBox_Text.Text.Replace("BUILDN", My.Resources.APP_VERSION_BUILD).Trim()

    End Sub

    ' Bottom bar buttons

    ' "Legal notice" button
    Private Sub UI_LegalNoticeBtn_Click(sender As Object, e As EventArgs) Handles UI_LegalNoticeBtn.Click
        InformationsTabControl.SelectedIndex = 0
        UI_StatPanel_Title.Text = UI_LegalNoticeBtn.Text
    End Sub

    ' "SMWMTL License" button
    Private Sub UI_AppLicenseBtn_Click(sender As Object, e As EventArgs) Handles UI_AppLicenseBtn.Click
        InformationsTabControl.SelectedIndex = 1
        UI_StatPanel_Title.Text = UI_AppLicenseBtn.Text
    End Sub

    ' "SMWMTL changelog" button
    Private Sub UI_AppChangelogBtn_Click(sender As Object, e As EventArgs) Handles UI_AppChangelogBtn.Click
        InformationsTabControl.SelectedIndex = 2
        UI_StatPanel_Title.Text = UI_AppChangelogBtn.Text
    End Sub

    ' "Other credits" button
    Private Sub UI_OtherCreditsBtn_Click(sender As Object, e As EventArgs) Handles UI_OtherCreditsBtn.Click
        InformationsTabControl.SelectedIndex = 3
        UI_StatPanel_Title.Text = UI_OtherCreditsBtn.Text
    End Sub

    ' "Close" button
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Close()
    End Sub

    ' Page end

End Class