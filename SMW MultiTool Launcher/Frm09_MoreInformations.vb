
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

        LoadLocalization()

        Icon = My.Resources.AppIcon

        Select Case My.Settings.UI_DARK_MODE
            Case True
                ForeColor = Color.White
                BackColor = Color.FromArgb(36, 36, 36)

                For Each UIElement In {UI_StatPanel, UI_BtmBar_Panel, UI_LegalNoticeTabControl, UI_LicensePanel, UI_ChangelogPanel, UI_Legal_CustomBuildWrn, UI_OtherCredits_DevTools}
                    UIElement.DarkMode = True
                Next

                For Each Tabs As TabPage In {UI_Tab_LegalNotice, UI_Tab_LicenseApp, UI_Tab_Changelog, UI_Tab_OtherCredits}
                    Tabs.BackColor = Color.FromArgb(47, 47, 47)
                Next

                For Each Panels As Panel In {UI_LicensePanel, UI_ChangelogPanel, UI_OtherCredits_DevTools}
                    Panels.BackColor = Color.FromArgb(25, 25, 25)
                Next

                For Each TxtBx As RichTextBox In {Licence_TextBox, Changelog_TextBox}
                    TxtBx.BackColor = Color.FromArgb(25, 25, 25)
                    TxtBx.ForeColor = Color.White
                Next

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

        ' Icon list for left Tabs
        Dim UI_LegalNoticeTabIconList As New ImageList
        UI_LegalNoticeTabControl.ImageList = UI_LegalNoticeTabIconList

        UI_LegalNoticeTabIconList.Images.Add(If(My.Settings.UI_DARK_MODE, My.Resources.SysIconModifyW, My.Resources.SysIconModify))
        UI_Tab_LegalNotice.ImageIndex = 0

        UI_LegalNoticeTabIconList.Images.Add(If(My.Settings.UI_DARK_MODE, My.Resources.SysIconModifyW, My.Resources.SysIconModify))
        UI_Tab_LicenseApp.ImageIndex = 1

        UI_LegalNoticeTabIconList.Images.Add(If(My.Settings.UI_DARK_MODE, My.Resources.SysIconModifyW, My.Resources.SysIconModify))
        UI_Tab_Changelog.ImageIndex = 2

        UI_LegalNoticeTabIconList.Images.Add(If(My.Settings.UI_DARK_MODE, My.Resources.SysIconModifyW, My.Resources.SysIconModify))
        UI_Tab_OtherCredits.ImageIndex = 3

        ' Dynamic values
        Select Case My.Resources.Strings.App_Const_CompDate_Lng
            Case "fr-FR"
                Licence_TextBox.Text = My.Resources.SMWMTL_License_fr.Replace("$version", $"{ApplicationInfo.AppVerDisplay} (Build {ApplicationInfo.AppVerBR}{If(AppCompFlags.IsDebug, $" • {ApplicationInfo.BranchName}", "")})").Replace("$Author", My.Application.Info.CompanyName).Replace("$Year", $"{If(Year(Now) > ApplicationInfo.CompileDate.Date.ToString("yyyy"), Year(Now), ApplicationInfo.CompileDate.Date.ToString("yyyy"))}").Replace("$CompileDate", $"{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ApplicationInfo.CompileDate.ToString(My.Resources.Strings.App_Const_CompDate_Frm, CultureInfo.CreateSpecificCulture(My.Resources.Strings.App_Const_CompDate_Lng)))}")
                Changelog_TextBox.Text = If(AppCompFlags.IsLTS, My.Resources.SMWMTL_Changelog_LTS_fr, My.Resources.SMWMTL_Changelog_fr)

            Case Else
                Licence_TextBox.Text = My.Resources.SMWMTL_License.Replace("$version", $"{ApplicationInfo.AppVerDisplay} (Build {ApplicationInfo.AppVerBR}{If(AppCompFlags.IsDebug, $" • {ApplicationInfo.BranchName}", "")})").Replace("$Author", My.Application.Info.CompanyName).Replace("$Year", $"{If(Year(Now) > ApplicationInfo.CompileDate.Date.ToString("yyyy"), Year(Now), ApplicationInfo.CompileDate.Date.ToString("yyyy"))}").Replace("$CompileDate", $"{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ApplicationInfo.CompileDate.ToString(My.Resources.Strings.App_Const_CompDate_Frm, CultureInfo.CreateSpecificCulture(My.Resources.Strings.App_Const_CompDate_Lng)))}")
                Changelog_TextBox.Text = If(AppCompFlags.IsLTS = "True", My.Resources.SMWMTL_Changelog_LTS, My.Resources.SMWMTL_Changelog)

        End Select

        LegalNoticeText_Description.Text = LegalNoticeText_Description.Text.Replace("$Author$", My.Application.Info.CompanyName)
        Developement_Tool_GroupBox_Text.Text = Developement_Tool_GroupBox_Text.Text.Replace("BUILDN", ApplicationInfo.AppVerBR).Trim()

        ' Non-Zero SKU ID
        UI_Legal_CustomBuildWrn.Visible = Not AppCompFlags.AppSKUID = 1

    End Sub

    ' Zoom
    Protected Overrides Sub OnMouseWheel(e As MouseEventArgs)

    End Sub

    ' "Close" button
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Close()
    End Sub

    ' Localization
    Private Sub LoadLocalization()
        Text = My.Resources.Strings_Frm09.FrmTitle

        UI_StatPanel_Title.Text = My.Resources.Strings_Frm09.StatPanel_Title
        UI_StatPanel_Description.Text = String.Format(My.Resources.Strings_Frm09.StatPanel_Description, My.Application.Info.AssemblyName)

        UI_Tab_LegalNotice.Text = My.Resources.Strings_Frm09.UI_Tab_LegalNotice
        UI_Tab_LicenseApp.Text = String.Format(My.Resources.Strings_Frm09.UI_Tab_LicenseApp, My.Application.Info.AssemblyName)
        UI_Tab_Changelog.Text = My.Resources.Strings_Frm09.UI_Tab_Changelog
        UI_Tab_OtherCredits.Text = My.Resources.Strings_Frm09.UI_Tab_OtherCredits

        LegalNotice_CustomBuildWarn_Title.Text = String.Format(My.Resources.Strings_Frm09.LegalNotice_CustomBuildWarn_Title, My.Application.Info.AssemblyName)
        LegalNotice_CustomBuildWarn_Description.Text = String.Format(My.Resources.Strings_Frm09.LegalNotice_CustomBuildWarn_Description, My.Application.Info.AssemblyName)

        LegalNoticeText_Title.Text = My.Resources.Strings_Frm09.LegalNoticeText_Title
        LegalNoticeText_Description.Text = String.Format(My.Resources.Strings_Frm09.LegalNoticeText_Description, My.Application.Info.CompanyName, My.Resources.APP_AUTHOR_NAME)











        CloseBtn.Text = My.Resources.Strings.App_GText_Close

    End Sub

    ' Page end

End Class