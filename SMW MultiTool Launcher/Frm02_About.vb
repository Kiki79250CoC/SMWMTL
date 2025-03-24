
Imports System.Globalization
Imports System.Net

Public Class Frm02_About
#Region "        Values "

    ' Required WebBrowsers for UpdateSearch.
    Private UpdateWC1 As WebClient ' Step 1
    Private UpdateWC2 As WebClient ' Step 2 - Download Version String (A.BB.CCCC.DD)
    Private UpdateWC3 As WebClient ' Step 2 - Download Changelog
    Private UpdateWC4 As WebClient ' Step 2 - Download Link for Downloading Update
    Private UpdateWC5 As WebClient ' Step 3 - Download Shortened major version

#End Region

    Private Sub Frm02_About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Icon = If(My.Settings.HIDE_ICON = True, If(My.Settings.BLANK_ICON = True, My.Resources.Blank16x16, Nothing), My.Resources.AppIcon)
        Text = If(My.Settings.HIDE_TITLE = True, Nothing, $"{My.Resources.Strings.UI_Frm02_FrmTitle} {Frm01_Main.WindowTitle}")

        ' Showing values string for Version, Build, etc.
        ' +----------------------------------+-------------------------------------------------------------------------------------------
        ' | Line 1 (AppVersion_Label)        | Version A.BB · Build CCCC.DD (A.BB.CCCC.DD · JJJJJJ · SMWMTL_Update v<UpdateSysVer>)
        ' | Line 2 (AppCombil_Label)         | Compiled on EE FFFF GGGG.
        ' | Line 3 (AppVersionStringLabel)   | SMWMTL_<Codename>_A.BB.CCCC.DD-<BuildDevStateInfo>_<Arch>_HHHHHH-TTTT
        ' | Line 4 (AppCopyrightLabel)       | Copyright © 2014-20II <Author>
        ' +----------------------------------+-------------------------------------------------------------------------------------------

        AppVersion_Label.Text = $"{My.Resources.Strings.UI_Frm02_VersionStr_Version} {ApplicationInfo.AppVerMM}{If(My.Resources.RELEASE_TYPE = "Normal", Nothing, "s")} · {My.Resources.Strings.UI_Frm02_VersionStr_Build} {ApplicationInfo.AppVerBR}{If(My.Settings.IS_PRERELEASE Or My.Resources.IS_LTS = "True" Or (Not My.Resources.RELEASE_TYPE = "Normal"), $" ({If(My.Settings.IS_PRERELEASE, $"{My.Resources.APP_VERSION_BRANCH}{If(My.IsDebug, "chk", "rel")}.{My.Resources.APP_VERSION_BRANCH_RN}", Nothing)}{If(My.Settings.IS_PRERELEASE And My.Resources.IS_LTS = "True", " · ", Nothing)}{If(My.Resources.IS_LTS = "True", $"Update Base Release v{My.Resources.UBR_REVISION}", Nothing)}{If(My.Resources.IS_LTS = "True" And (Not My.Resources.RELEASE_TYPE = "Normal"), " · ", Nothing)}{If(Not My.Resources.RELEASE_TYPE = "Normal", $"{"Custom build for "}{My.Resources.RELEASE_TYPE}", Nothing)})", Nothing)}{If(My.Settings.SHOW_UPDATE_SYSTEM_INFOS_ON_ABOUT_SCREEN, $" · SMWMTL_Update v{My.Resources.UPDATE_ENGINE_VERSION}", Nothing)}"
        AppCompil_Label.Text = $"{My.Resources.Strings.UI_Frm02_CompStr_Compiled} {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ApplicationInfo.CompileDate.ToString(My.Resources.Strings.App_Const_CompDate_Frm, CultureInfo.CreateSpecificCulture(My.Resources.Strings.App_Const_CompDate_Lng)))}"

        AppVersionStringLabel.Text = $"{My.Application.Info.AssemblyName}_{My.Resources.APP_CODENAME}_{ApplicationInfo.AppVerMM}.{ApplicationInfo.AppVerBR}-{My.Resources.APP_VERSION_BRANCH}{If(My.IsDebug, "chk", "rel")}.{My.Resources.APP_VERSION_BRANCH_RN}_{My.Resources.RELEASE_TYPE}_UA{My.Resources.UPDATE_ENGINE_VERSION}_{Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").ToLower}_{ApplicationInfo.CompileDate:yyMMdd-HHmm}"

        AppCopyrightLabel.Text += $"2014-{If(Year(Now) > ApplicationInfo.CompileDate.Date.ToString("yyyy"), Year(Now), ApplicationInfo.CompileDate.Date.ToString("yyyy"))} {My.Application.Info.CompanyName}"

        ' -------------------------------------------------------------------------------------------------------------------------------

        ' Settings load

        ' DarkMode Toggle
        Select Case My.Settings.UI_DARK_MODE
            Case True
                ForeColor = Color.White
                BackColor = Color.FromArgb(36, 36, 36)
                UI_StatPanel.BackColor = Color.FromArgb(25, 25, 25)
                UI_BtmBar_Panel.BackColor = Color.FromArgb(25, 25, 25)

                UI_Separator1.Image = My.Resources.UI_ButtonSeparator
                With UI_Btn_GoToUpdateModal
                    .LinkColor = Color.LightGray
                    .VisitedLinkColor = Color.LightGray
                    .ActiveLinkColor = Color.DimGray
                End With

        End Select

        If Environment.OSVersion.Version.Build >= 10240 Then
            SystemInterop.DwmSetWindowAttribute(Handle, SystemInterop.DWM_WindowAttribute.SystemBackdropType, 2, Runtime.InteropServices.Marshal.SizeOf(Of Integer)())
            SystemInterop.DwmSetWindowAttribute(Handle, SystemInterop.DWM_WindowAttribute.UseImmersiveMode, If(My.Settings.UI_DARK_MODE, 1, 0), Runtime.InteropServices.Marshal.SizeOf(Of Integer)())

        End If

        ' Detecting LTS variant of SMWMTL for about picture.
        AppLogo_Image.Image = If(My.Resources.IS_LTS = "True", My.Resources.About_LogoLTS, My.Resources.About_Logo)












        ' Window opacity
        Select Case My.Settings.APP_OPACITY_TOGGLE
            Case True
                Select Case My.Settings.APP_OPACITY_APPLY_MODE
                    Case Is >= 1
                        Opacity = My.Settings.APP_OPACITY / 100

                End Select

        End Select

        ' Hiding version string
        Select Case My.Settings.SHOW_APP_VERSION_STRING
            Case False
                UI_StatPanel.Visible = False
                Size = New Size(Width, Height - UI_StatPanel.Height)
                CenterToScreen()

        End Select

        ' ---------------------------------------------------------------------------------------------------------------------
        ' Special condition that hides all the buttons on the bottom bar when the initial configuration tool is launched
        Select Case My.Settings.ENABLE_UPDATE_INDICATOR_ON_ABOUT_WINDOW
            Case True
                UpdateWC1 = New WebClient() ' Step 1
                UpdateWC2 = New WebClient() ' Step 2 - Download Version String (A.BB.CCCC.DD)
                UpdateWC3 = New WebClient() ' Step 2 - Download Changelog
                UpdateWC4 = New WebClient() ' Step 2 - Download Link for Downloading Update
                UpdateWC5 = New WebClient() ' Step 3 - Download Shortened major version

                UpdateWC3.Encoding = System.Text.Encoding.UTF8

                Info_UpdateStatusIcon.Visible = True
                UI_UpdateStatusPanel.Visible = True

                Info_UpdateStatusIcon.Image = My.Resources.HomeUpdateSearching
                Info_UpdateStatus.Text = Frm99_TranslateForm.UI02_UpdateSearch.Text
                UI_BtmBar_Panel.BackgroundImage = My.Resources.MW_UpdateSearchBlue

        End Select

    End Sub

    Private Sub Frm02_About_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ' Settings search (Processed only if Update Module is visible).
        Select Case My.Settings.ENABLE_UPDATE_INDICATOR_ON_ABOUT_WINDOW
            Case True
                UpdateSearch_Step1()

        End Select

    End Sub

    ' Buttons at the bottom of the Window.
    ' ------------------------------------

    ' "OK" Button
    Private Sub UI_Btn_OK_Click(sender As Object, e As EventArgs) Handles UI_Btn_OK.Click
        Close()
    End Sub

    ' "Legal Notice" Button
    Private Sub UI_Btn_Mentions_Click(sender As Object, e As EventArgs) Handles UI_Btn_Mentions.Click
        Dim f As New Frm09_MoreInformations()

        Select Case My.Resources.RELEASE_TYPE
            Case "SMWC"

                With f

                    .LegalNotice_Text03.Visible = True
                    .LegalNotice_Text04.Visible = True

                End With

            Case Else
        End Select

        f.ShowDialog()
    End Sub

    ' "About (Legacy - 2.0x)" Button
    Private Sub UI_Btn_LegacyAbout_Click(sender As Object, e As EventArgs) Handles UI_Btn_LegacyAbout.Click
        Dim f As New Frm97_LegacyAbout()
        f.ShowDialog()
    End Sub

    ' "Update SMWMTL" button
    Private Sub UI_Btn_GoToUpdateModal_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UI_Btn_GoToUpdateModal.LinkClicked
        Dim f As New Frm04_UpdatesModal()
        f.ShowDialog()
    End Sub

    ' Clickable things that are not buttons
    ' ------------------------------------

    ' 
    Private Sub AppVersionStringLabel_Click(sender As Object, e As EventArgs) Handles AppVersionStringLabel.Click

        My.Computer.Clipboard.SetText(AppVersionStringLabel.Text)

    End Sub

    ' UPDATE SEARCH MODULE
    ' ------------------------------------
    ' Checking on Internet for Update availability.

    Sub UpdateSearch_Step1()

        ' STEP 1 - Checking Update server state.

        AddHandler UpdateWC1.DownloadStringCompleted, AddressOf UpdateSearch_Step1_DownloadCompletion

        Select Case My.Resources.IS_LTS
            ' Stable Build
            Case "False"
                Select Case My.Settings.IS_PRERELEASE
                    ' Released Version
                    Case False
                        UpdateWC1.DownloadStringAsync(New Uri("https://www.dropbox.com/s/t9cmxufijyh9qf3/Stable_Release_ServerStatus.txt?dl=1"))

                    ' Beta Version
                    Case True
                        UpdateWC1.DownloadStringAsync(New Uri("https://www.dropbox.com/s/al736op7klrak3k/Stable_Beta_ServerStatus.txt?dl=1"))

                End Select

            ' LTS Build
            Case "True"
                Select Case My.Settings.IS_PRERELEASE
                    ' Released Version
                    Case False
                        UpdateWC1.DownloadStringAsync(New Uri("https://www.dropbox.com/s/kah7gt93uokpur2/LTS_Release_ServerStatus.txt?dl=1"))

                    ' Beta Version
                    Case True
                        UpdateWC1.DownloadStringAsync(New Uri("https://www.dropbox.com/s/mu3fc61fghfasrf/LTS_Beta_ServerStatus.txt?dl=1"))

                End Select

        End Select

    End Sub
    Private Sub UpdateSearch_Step1_DownloadCompletion(sender As Object, e As DownloadStringCompletedEventArgs)

        If e.Error Is Nothing Then ' Download Successed

            Select Case e.Result
                Case "Enabled"
                    UpdateSearch_Step2()

                Case "Disabled"
                    Info_UpdateStatus.Text = Frm99_TranslateForm.UI02_UpdateNotFound.Text
                    Info_UpdateStatusIcon.Image = My.Resources.HomeUpdateNoUpdate
                    UI_BtmBar_Panel.BackgroundImage = My.Resources.MW_UpdateSearchGreen

                Case Else
                    Info_UpdateStatus.Text = Frm99_TranslateForm.UI02_UnableCheckUpdates.Text
                    Info_UpdateStatusIcon.Image = My.Resources.HomeUpdateError
                    UI_BtmBar_Panel.BackgroundImage = My.Resources.MW_UpdateSearchRed

            End Select

        Else ' Download Failed

            Info_UpdateStatus.Text = Frm99_TranslateForm.UI02_UnableCheckUpdates.Text
            Info_UpdateStatusIcon.Image = My.Resources.HomeUpdateError
            UI_BtmBar_Panel.BackgroundImage = My.Resources.MW_UpdateSearchRed

        End If

    End Sub

    Sub UpdateSearch_Step2()

        ' STEP 2 - Checking the version number (A.BB.CCCC.DD) and comparing with the current version.
        '          If the downloaded version is higher than the current one, an update is available.

        AddHandler UpdateWC2.DownloadStringCompleted, AddressOf UpdateSearch_Step2_DownloadCompletion

        Select Case My.Resources.IS_LTS
            ' Stable Build
            Case "False"
                Select Case My.Settings.IS_PRERELEASE
                    ' Released Version
                    Case False
                        UpdateWC2.DownloadStringAsync(New Uri("https://www.dropbox.com/s/0af44pzev0ha8vu/Stable_Release_Version.txt?dl=1"))

                    ' Beta Version
                    Case True
                        UpdateWC2.DownloadStringAsync(New Uri("https://www.dropbox.com/s/zcro5kazs4wd89g/Stable_Beta_Version.txt?dl=1"))

                End Select

            ' LTS Build
            Case "True"
                Select Case My.Settings.IS_PRERELEASE
                    ' Released Version
                    Case False
                        UpdateWC2.DownloadStringAsync(New Uri("https://www.dropbox.com/s/ln9mwiw5zr7akuj/LTS_Release_Version.txt?dl=1"))

                    ' Beta Version
                    Case True
                        UpdateWC2.DownloadStringAsync(New Uri("https://www.dropbox.com/s/3innhph9mh0yjtc/LTS_Beta_Version.txt?dl=1"))

                End Select

        End Select

    End Sub
    Private Sub UpdateSearch_Step2_DownloadCompletion(sender As Object, e As DownloadStringCompletedEventArgs)

        If e.Error Is Nothing Then ' Download Successed

            Select Case e.Result > $"{My.Resources.APP_VERSION_WITHZERO}.{My.Resources.APP_VERSION_BUILD}"
                Case True
                    My.Settings.UPDATE_PENDING = True
                    My.Settings.UPDATE_FOUND_CVERSION = e.Result
                    My.Settings.UPDATE_PENDING_DOWNLOAD = True

                    If e.Result > My.Settings.LAST_UPDATED_VERSION_CHECKED Then

                        My.Settings.LAST_UPDATED_VERSION_CHECKED = e.Result

                    End If

                    UpdateSearch_Step3()

                Case False
                    Info_UpdateStatus.Text = Frm99_TranslateForm.UI02_UpdateNotFound.Text
                    Info_UpdateStatusIcon.Image = My.Resources.HomeUpdateNoUpdate
                    UI_BtmBar_Panel.BackgroundImage = My.Resources.MW_UpdateSearchGreen

                    My.Settings.UPDATE_PENDING = False
                    My.Settings.UPDATE_FOUND_CVERSION = My.Resources.APP_VERSION_WITHZERO

                    My.Settings.LAST_UPDATE_CHECK_DATE = Now

            End Select

        Else ' Download Failed

            Info_UpdateStatus.Text = Frm99_TranslateForm.UI02_UnableCheckUpdates.Text
            Info_UpdateStatusIcon.Image = My.Resources.HomeUpdateError
            UI_BtmBar_Panel.BackgroundImage = My.Resources.MW_UpdateSearchRed

        End If

    End Sub

    Sub UpdateSearch_Step3()

        ' STEP 3 - Download additional files (short Version String, Changelog, Update link) for updating SMWMTL.

        AddHandler UpdateWC3.DownloadStringCompleted, AddressOf UpdateSearch_Step3_DownloadCompletion1
        AddHandler UpdateWC4.DownloadStringCompleted, AddressOf UpdateSearch_Step3_DownloadCompletion2
        AddHandler UpdateWC5.DownloadStringCompleted, AddressOf UpdateSearch_Step3_DownloadCompletion3

        Select Case My.Resources.IS_LTS
            ' Stable Build
            Case "False"
                Select Case My.Settings.IS_PRERELEASE
                    ' Released Version
                    Case False
                        ' Download Changelog
                        If My.Computer.Info.InstalledUICulture.ToString.Contains("fr") Then
                            UpdateWC3.DownloadStringAsync(New Uri("https://www.dropbox.com/s/u71isj45fj5me1v/Stable_Release_ChangelogFR.txt?dl=1"))
                        Else
                            UpdateWC3.DownloadStringAsync(New Uri("https://www.dropbox.com/s/pv44bx0nb4y70ix/Stable_Release_ChangelogEN.txt?dl=1"))
                        End If

                        ' Download Link for Downloading Update
                        UpdateWC4.DownloadStringAsync(New Uri("https://www.dropbox.com/s/72tkr38i5n7bhds/Stable_Release_UpdateInstallerLink.txt?dl=1"))

                        ' Download shortened version string
                        UpdateWC5.DownloadStringAsync(New Uri("https://www.dropbox.com/s/8irfigjxn8s1qb7/Stable_Release_VersionShortened.txt?dl=1"))

                    ' Beta Version
                    Case True
                        ' Download Changelog
                        If My.Computer.Info.InstalledUICulture.ToString.Contains("fr") Then
                            UpdateWC3.DownloadStringAsync(New Uri("https://www.dropbox.com/s/9ozdroap1qvnl0m/Stable_Beta_ChangelogFR.txt?dl=1"))
                        Else
                            UpdateWC3.DownloadStringAsync(New Uri("https://www.dropbox.com/s/4zuaszdgbbf9so5/Stable_Beta_ChangelogEN.txt?dl=1"))
                        End If

                        ' Download Link for Downloading Update
                        UpdateWC4.DownloadStringAsync(New Uri("https://www.dropbox.com/s/hcghsoxhgwu0oal/Stable_Beta_UpdateInstallerLink.txt?dl=1"))

                        ' Download shortened version string
                        UpdateWC5.DownloadStringAsync(New Uri("https://www.dropbox.com/s/u1eq7tevg3e3m33/Stable_Beta_VersionShortened.txt?dl=1"))

                End Select

            ' LTS Build
            Case "True"
                Select Case My.Settings.IS_PRERELEASE
                    ' Released Version
                    Case False
                        ' Download Changelog
                        If My.Computer.Info.InstalledUICulture.ToString.Contains("fr") Then
                            UpdateWC3.DownloadStringAsync(New Uri("https://www.dropbox.com/s/nw0lxo51ua67o9q/LTS_Release_ChangelogFR.txt?dl=1"))
                        Else
                            UpdateWC3.DownloadStringAsync(New Uri("https://www.dropbox.com/s/0u7bhf9x7yvnibk/LTS_Release_ChangelogEN.txt?dl=1"))
                        End If

                        ' Download Link for Downloading Update
                        UpdateWC4.DownloadStringAsync(New Uri("https://www.dropbox.com/s/7tg7c23vllj3r0f/LTS_Release_UpdateInstallerLink.txt?dl=1"))

                        ' Download shortened version string
                        UpdateWC5.DownloadStringAsync(New Uri("https://www.dropbox.com/s/bfgskk47kd181ss/LTS_Release_VersionShortened.txt?dl=1"))

                    ' Beta Version
                    Case True
                        ' Download Changelog
                        If My.Computer.Info.InstalledUICulture.ToString.Contains("fr") Then
                            UpdateWC3.DownloadStringAsync(New Uri("https://www.dropbox.com/s/1gmp8288s5qglo6/LTS_Beta_ChangelogFR.txt?dl=1"))
                        Else
                            UpdateWC3.DownloadStringAsync(New Uri("https://www.dropbox.com/s/j679bc6icicvnsc/LTS_Beta_ChangelogEN.txt?dl=1"))
                        End If

                        ' Download Link for Downloading Update
                        UpdateWC4.DownloadStringAsync(New Uri("https://www.dropbox.com/s/tr35436boojyv8k/LTS_Beta_UpdateInstallerLink.txt?dl=1"))

                        ' Download shortened version string
                        UpdateWC5.DownloadStringAsync(New Uri("https://www.dropbox.com/s/1hrofil1a798puk/LTS_Beta_VersionShortened.txt?dl=1"))

                End Select

        End Select

    End Sub
    Private Sub UpdateSearch_Step3_DownloadCompletion1(sender As Object, e As DownloadStringCompletedEventArgs)

        ' Download Changelog

        If e.Error Is Nothing Then ' Download Successed

            My.Settings.UPDATE_FOUND_CHANGELOG = e.Result

        Else ' Download Failed

            My.Settings.UPDATE_FOUND_CHANGELOG = Frm99_TranslateForm.UI04_ErrorWhenDownloadingData.Text

        End If

    End Sub
    Private Sub UpdateSearch_Step3_DownloadCompletion2(sender As Object, e As DownloadStringCompletedEventArgs)

        ' Download Link for Downloading Update

        If e.Error Is Nothing Then ' Download Successed

            My.Settings.UPDATE_FOUND_DOWNLOAD_LINK = e.Result

        Else ' Download Failed

            My.Settings.UPDATE_FOUND_DOWNLOAD_LINK = Nothing

        End If

    End Sub
    Private Sub UpdateSearch_Step3_DownloadCompletion3(sender As Object, e As DownloadStringCompletedEventArgs)

        If e.Error Is Nothing Then ' Download Successed

            Info_UpdateStatusIcon.Image = My.Resources.HomeUpdateAvailable
            Info_UpdateStatus.Text = Frm99_TranslateForm.UI02_UpdateFound.Text
            UI_BtmBar_Panel.BackgroundImage = My.Resources.MW_UpdateSearchYellow

            UI_Btn_GoToUpdateModal.Visible = True

            My.Settings.UPDATE_FOUND_CVERSION_WITHOUT_BUILDNBR = e.Result

            My.Settings.LAST_UPDATE_CHECK_DATE = Now

        Else

            My.Settings.UPDATE_FOUND_CVERSION_WITHOUT_BUILDNBR = Frm99_TranslateForm.UI04_ErrorWhenDownloadingData.Text

            Info_UpdateStatus.Text = Frm99_TranslateForm.UI02_UnableCheckUpdates.Text
            Info_UpdateStatusIcon.Image = My.Resources.HomeUpdateError
            UI_BtmBar_Panel.BackgroundImage = My.Resources.MW_UpdateSearchRed

        End If

    End Sub

    ' Page End

End Class