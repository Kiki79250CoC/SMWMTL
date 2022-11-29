
Imports System.ComponentModel
Imports System.Net

Public Class Frm04_UpdatesModal
#Region "        Values "

    ' Application folder
    ReadOnly Locate As String = My.Application.Info.DirectoryPath

    ' Required WebBrowsers for UpdateSearch.
    Private UpdateWC1 As WebClient ' Step 1
    Private UpdateWC2 As WebClient ' Step 2 - Download Version String (A.BB.CCCC.DD)
    Private UpdateWC3 As WebClient ' Step 2 - Download Changelog
    Private UpdateWC4 As WebClient ' Step 2 - Download Link for Downloading Update
    Private UpdateWC5 As WebClient ' Step 2 - Download Shortened version number (A.BB)

    Private UpdateDL As WebClient  ' Update download

#End Region

    Private Sub Frm04_UpdatesModal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                UI_BtmBar_Panel.BackgroundImage = My.Resources.UI_BottomBar

                UI_Changelog_TextBox.BackColor = Color.FromArgb(25, 25, 25)
                UI_ChangelogPanel.BackColor = Color.FromArgb(25, 25, 25)
                UI_Changelog_TextBox.ForeColor = Color.White

        End Select

        ' Disable "Update pending" if last check is +6 hours or if last checked version number is < / = than current
        If My.Settings.UPDATE_PENDING = True And Now > My.Settings.LAST_UPDATE_CHECK_DATE.AddHours(6) OrElse My.Settings.UPDATE_PENDING = True And My.Settings.UPDATE_FOUND_CVERSION <= $"{My.Resources.APP_VERSION_WITHZERO}.{My.Resources.APP_VERSION_BUILD}" Then

            My.Settings.UPDATE_PENDING = False
            My.Settings.UPDATE_PENDING_DOWNLOAD = False
            My.Settings.UPDATE_PENDING_INSTALLATION = False

        End If

        ' Displaying Versions numbers for Application (A.BB.CCCC.DD) and Update engine (E.FF)
        AppVersion_Label.Text = $"{Frm99_TranslateForm.UI04_AppCurrentVersion.Text} {My.Resources.APP_VERSION} Build {My.Resources.APP_VERSION_BUILD} ({My.Resources.APP_VERSION}.{My.Resources.APP_VERSION_BUILD})"
        AppUpdateEngineVersion_Label.Text = $"{Frm99_TranslateForm.UI04_UpdateEngineVersion.Text} {My.Resources.UPDATE_ENGINE_VERSION}"

        ' Displaying last update search date and hour
        UI_LastCheckedUpdate.Text = $"{Frm99_TranslateForm.UI04_UpdateLastCheck.Text} {My.Settings.LAST_UPDATE_CHECK_DATE}"

        ' Initialization Previous update if detected
        Select Case My.Settings.UPDATE_PENDING
            Case True

                UI_StatPanel.BackgroundImage = My.Resources.UpdateBackJaune
                UI_StatPanel_Icon.Image = My.Resources.UI_Badge_Warning
                UI_StatPanel_Title.Text = Frm99_TranslateForm.UI04_StatPanel_TitleUpdatesFound.Text
                UI_StatPanel_Description.Text = Frm99_TranslateForm.UI04_StatPanel_DescUpdatesFound.Text

                UI_InfoTitleText.Text = $"{Frm99_TranslateForm.UI04_NewerVersion.Text} {My.Settings.UPDATE_FOUND_CVERSION_WITHOUT_BUILDNBR} ({My.Settings.UPDATE_FOUND_CVERSION.TrimStart(“0”)})"
                UI_InfoDescriptionText.Text = $"{Frm99_TranslateForm.UI04_CurrentVersion.Text} {My.Resources.APP_VERSION} ({My.Resources.APP_VERSION}.{My.Resources.APP_VERSION_BUILD})"

                UI_Changelog_TextBox.Text = My.Settings.UPDATE_FOUND_CHANGELOG

                Select Case My.Settings.UPDATE_PENDING_DOWNLOAD
                    Case True
                        UI_DownloadUpdateBtn.Visible = True

                    Case False
                        UI_DownloadUpdateBtn.Visible = False

                End Select

                Select Case My.Settings.UPDATE_PENDING_INSTALLATION
                    Case True
                        UI_InstallUpdateBtn.Visible = True

                    Case False
                        UI_InstallUpdateBtn.Visible = False

                End Select

                Select Case My.Settings.UPDATE_AUTOMATIC_INSTALLATION
                    Case True
                        Select Case My.Settings.UPDATE_SILENT_INSTALL
                            Case True
                                UI_CurrentProcessProgress.Visible = True
                                UI_CurrentProcessText.Visible = True

                                UI_CurrentProcessProgress.Value = 0
                                UI_CurrentProcessText.Text = Frm99_TranslateForm.UI04_UpdateInstallOnAppClose.Text

                                UI_InstallUpdateBtn.Enabled = False

                                My.Settings.UPDATE_SILENT_INSTALL = True

                            Case False
                                UI_CurrentProcessText.Text = Frm99_TranslateForm.UI04_UpdateInstalling.Text
                                UI_InstallUpdateBtn.Enabled = True

                        End Select

                    Case False
                        UI_CurrentProcessProgress.Visible = False
                        UI_CurrentProcessText.Visible = False
                End Select

            Case False

                ' Première étape : Définir le Titre, la description et l'icône du panneau d'en-tête.

                UI_StatPanel_Title.Text = Frm99_TranslateForm.UI04_StatPanel_TitleHome.Text
                UI_StatPanel_Description.Text = Frm99_TranslateForm.UI04_StatPanel_DescHome.Text

                ' Définition des descriptions

                UI_InfoTitleText.Text = Frm99_TranslateForm.UI04_MainTextTitle01.Text
                UI_InfoDescriptionText.Text = Frm99_TranslateForm.UI04_MainTextDesc01.Text

                UI_Changelog_TextBox.Text = Nothing

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

    End Sub

    ' Bouton de Lancement du processus de Recherche des Mises à jour du logiciel

    Private Sub UI_SearchUpdateBtn_Click(sender As Object, e As EventArgs) Handles UI_SearchUpdateBtn.Click

        ' WebClients preparation for update search process.
        UpdateWC1 = New WebClient() ' Step 1
        UpdateWC2 = New WebClient() ' Step 2 - Download Version String (A.BB.CCCC.DD)
        UpdateWC3 = New WebClient() ' Step 3 - Download Changelog
        UpdateWC4 = New WebClient() ' Step 3 - Download Link for Downloading Update
        UpdateWC5 = New WebClient() ' Step 3 - Download Shortened major version

        UpdateWC3.Encoding = System.Text.Encoding.UTF8

        UI_SearchUpdateBtn.Enabled = False
        UI_DownloadUpdateBtn.Visible = False
        UI_InstallUpdateBtn.Visible = False

        UI_StatPanel.BackgroundImage = My.Resources.UpdateBackBleu
        UI_StatPanel_Icon.Image = My.Resources.UI_Badge_Search
        UI_StatPanel_Title.Text = Frm99_TranslateForm.UI04_StatPanel_TitleSearch.Text
        UI_StatPanel_Description.Text = Frm99_TranslateForm.UI04_StatPanel_DescSearch.Text

        UI_CurrentProcessText.Visible = True
        UI_CurrentProcessText.Text = Frm99_TranslateForm.UI04_UpdateCheckInProgress.Text
        UI_CurrentProcessProgress.Visible = True
        UI_CurrentProcessProgress.Style = ProgressBarStyle.Marquee
        UI_DownloadState.Visible = False

        UI_InfoTitleText.Text = Frm99_TranslateForm.UI04_MainTextTitle01.Text
        UI_InfoDescriptionText.Text = Frm99_TranslateForm.UI04_MainTextDesc01.Text

        UI_Changelog_TextBox.Text = Nothing

        UpdateSearch_Step1()

    End Sub

    Sub UpdateSearch_Step1()

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
                    UI_StatPanel.BackgroundImage = My.Resources.UpdateBackVert
                    UI_StatPanel_Icon.Image = My.Resources.UI_Badge_OK
                    UI_StatPanel_Title.Text = Frm99_TranslateForm.UI04_StatPanel_TitleNoUpdate.Text
                    UI_StatPanel_Description.Text = Frm99_TranslateForm.UI04_StatPanel_DescNoUpdate.Text

                    UI_CurrentProcessText.Visible = False
                    UI_CurrentProcessProgress.Visible = False

                    UI_SearchUpdateBtn.Enabled = True

                    My.Settings.LAST_UPDATE_CHECK_DATE = Now
                    UI_LastCheckedUpdate.Text = $"{Frm99_TranslateForm.UI04_UpdateLastCheck.Text} {My.Settings.LAST_UPDATE_CHECK_DATE}"

                    My.Settings.UPDATE_SILENT_INSTALL = False

                Case Else
                    UI_StatPanel.BackgroundImage = My.Resources.UpdateBackRouge
                    UI_StatPanel_Icon.Image = My.Resources.UI_Badge_Error
                    UI_StatPanel_Title.Text = Frm99_TranslateForm.UI04_StatPanel_TitleSearchFailed.Text
                    UI_StatPanel_Description.Text = Frm99_TranslateForm.UI04_StatPanel_DescSearchFailed.Text

                    UI_CurrentProcessText.Visible = False
                    UI_CurrentProcessProgress.Visible = False

                    UI_SearchUpdateBtn.Enabled = True

                    My.Settings.LAST_UPDATE_CHECK_DATE = Now
                    UI_LastCheckedUpdate.Text = $"{Frm99_TranslateForm.UI04_UpdateLastCheck.Text} {My.Settings.LAST_UPDATE_CHECK_DATE}"

                    My.Settings.UPDATE_SILENT_INSTALL = False

            End Select

        Else ' Download Failed

            UI_StatPanel.BackgroundImage = My.Resources.UpdateBackRouge
            UI_StatPanel_Icon.Image = My.Resources.UI_Badge_Error
            UI_StatPanel_Title.Text = Frm99_TranslateForm.UI04_StatPanel_TitleSearchFailed.Text
            UI_StatPanel_Description.Text = Frm99_TranslateForm.UI04_StatPanel_DescSearchFailed.Text

            UI_CurrentProcessText.Visible = False
            UI_CurrentProcessProgress.Visible = False

            UI_SearchUpdateBtn.Enabled = True

            My.Settings.LAST_UPDATE_CHECK_DATE = Now
            UI_LastCheckedUpdate.Text = $"{Frm99_TranslateForm.UI04_UpdateLastCheck.Text} {My.Settings.LAST_UPDATE_CHECK_DATE}"

            My.Settings.UPDATE_SILENT_INSTALL = False

        End If

    End Sub

    Sub UpdateSearch_Step2()

#Region "        Code Step 2 "

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

#End Region

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
                    UI_StatPanel.BackgroundImage = My.Resources.UpdateBackVert
                    UI_StatPanel_Icon.Image = My.Resources.UI_Badge_OK
                    UI_StatPanel_Title.Text = Frm99_TranslateForm.UI04_StatPanel_TitleNoUpdate.Text
                    UI_StatPanel_Description.Text = Frm99_TranslateForm.UI04_StatPanel_DescNoUpdate.Text

                    UI_CurrentProcessText.Visible = False
                    UI_CurrentProcessProgress.Visible = False

                    UI_SearchUpdateBtn.Enabled = True

                    My.Settings.UPDATE_PENDING = False
                    My.Settings.UPDATE_FOUND_CVERSION = My.Resources.APP_VERSION_WITHZERO

                    My.Settings.LAST_UPDATE_CHECK_DATE = Now
                    UI_LastCheckedUpdate.Text = $"{Frm99_TranslateForm.UI04_UpdateLastCheck.Text} {My.Settings.LAST_UPDATE_CHECK_DATE}"

                    My.Settings.UPDATE_SILENT_INSTALL = False

            End Select

        Else ' Download Failed

            UI_StatPanel.BackgroundImage = My.Resources.UpdateBackRouge
            UI_StatPanel_Icon.Image = My.Resources.UI_Badge_Error
            UI_StatPanel_Title.Text = Frm99_TranslateForm.UI04_StatPanel_TitleSearchFailed.Text
            UI_StatPanel_Description.Text = Frm99_TranslateForm.UI04_StatPanel_DescSearchFailed.Text

            UI_CurrentProcessText.Visible = False
            UI_CurrentProcessProgress.Visible = False

            UI_SearchUpdateBtn.Enabled = True

            My.Settings.LAST_UPDATE_CHECK_DATE = Now
            UI_LastCheckedUpdate.Text = $"{Frm99_TranslateForm.UI04_UpdateLastCheck.Text} {My.Settings.LAST_UPDATE_CHECK_DATE}"

        End If

    End Sub

    Sub UpdateSearch_Step3()

#Region "        Code Step 3 "

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

#End Region

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

        ' Download shortened version string

        If e.Error Is Nothing Then ' Download Successed

            My.Settings.UPDATE_FOUND_CVERSION_WITHOUT_BUILDNBR = e.Result

            UI_StatPanel.BackgroundImage = My.Resources.UpdateBackJaune
            UI_StatPanel_Icon.Image = My.Resources.UI_Badge_Warning
            UI_StatPanel_Title.Text = Frm99_TranslateForm.UI04_StatPanel_TitleUpdatesFound.Text
            UI_StatPanel_Description.Text = Frm99_TranslateForm.UI04_StatPanel_DescUpdatesFound.Text

            UI_InfoTitleText.Text = $"{Frm99_TranslateForm.UI04_NewerVersion.Text} {My.Settings.UPDATE_FOUND_CVERSION_WITHOUT_BUILDNBR} ({My.Settings.UPDATE_FOUND_CVERSION.TrimStart(“0”)})"
            UI_InfoDescriptionText.Text = $"{Frm99_TranslateForm.UI04_CurrentVersion.Text} {My.Resources.APP_VERSION} ({My.Resources.APP_VERSION}.{My.Resources.APP_VERSION_BUILD})"

            UI_Changelog_TextBox.Text = My.Settings.UPDATE_FOUND_CHANGELOG

            My.Settings.UPDATE_PENDING_DOWNLOAD = True
            UI_DownloadUpdateBtn.Visible = True

            UI_CurrentProcessText.Visible = False
            UI_CurrentProcessProgress.Visible = False

            UI_SearchUpdateBtn.Enabled = True

            My.Settings.LAST_UPDATE_CHECK_DATE = Now
            UI_LastCheckedUpdate.Text = $"{Frm99_TranslateForm.UI04_UpdateLastCheck.Text} {My.Settings.LAST_UPDATE_CHECK_DATE}"

            My.Settings.UPDATE_SILENT_INSTALL = False

            Select Case My.Settings.UPDATE_AUTOMATIC_DOWNLOAD
                Case True
                    UpdateDownloadProcess()
            End Select

        Else ' Download Failed

            UI_StatPanel.BackgroundImage = My.Resources.UpdateBackRouge
            UI_StatPanel_Icon.Image = My.Resources.UI_Badge_Error
            UI_StatPanel_Title.Text = Frm99_TranslateForm.UI04_StatPanel_TitleSearchFailed.Text
            UI_StatPanel_Description.Text = Frm99_TranslateForm.UI04_StatPanel_DescSearchFailed.Text

            UI_CurrentProcessText.Visible = False
            UI_CurrentProcessProgress.Visible = False

            UI_SearchUpdateBtn.Enabled = True

            My.Settings.LAST_UPDATE_CHECK_DATE = Now
            UI_LastCheckedUpdate.Text = $"{Frm99_TranslateForm.UI04_UpdateLastCheck.Text} {My.Settings.LAST_UPDATE_CHECK_DATE}"

            My.Settings.UPDATE_SILENT_INSTALL = False

        End If

    End Sub

    Private Sub UI_DownloadUpdateBtn_Click(sender As Object, e As EventArgs) Handles UI_DownloadUpdateBtn.Click
        UpdateDownloadProcess()
    End Sub
    Sub UpdateDownloadProcess()

        ControlBox = False

        UpdateDL = New WebClient() ' Update download

        UI_DownloadUpdateBtn.Enabled = False
        UI_SearchUpdateBtn.Enabled = False

        UI_CurrentProcessProgress.Visible = True
        UI_CurrentProcessProgress.Style = ProgressBarStyle.Blocks
        UI_CurrentProcessProgress.Value = 0

        UI_CurrentProcessText.Visible = True
        UI_CurrentProcessText.Text = Frm99_TranslateForm.UI04_UpdateDownloading.Text

        UI_DownloadState.Visible = True
        UI_DownloadState.Text = $"..."

        AddHandler UpdateDL.DownloadProgressChanged, AddressOf ProgChangedUpdateDL
        AddHandler UpdateDL.DownloadFileCompleted, AddressOf UpdateDLDone

        Try

            UpdateDL.DownloadFileAsync(New Uri(My.Settings.UPDATE_FOUND_DOWNLOAD_LINK), $"{Locate}\UpdatePkg.exe")

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.AssemblyName)

        End Try

    End Sub
    Private Sub ProgChangedUpdateDL(sender As Object, e As DownloadProgressChangedEventArgs)

        UI_CurrentProcessProgress.Value = e.ProgressPercentage
        UI_DownloadState.Text = $"{e.ProgressPercentage} % • {e.BytesReceived / 1024D / 1024D:0.00}/{e.TotalBytesToReceive / 1024D / 1024D:0.00} {Frm99_TranslateForm.UI04_MegabyteUnit.Text} {Frm99_TranslateForm.UI04_DownloadedText.Text}"

    End Sub
    Sub UpdateDLDone(sender As Object, e As AsyncCompletedEventArgs)

        If e.Error Is Nothing Then ' Download Successed

            ControlBox = True

            UI_DownloadUpdateBtn.Visible = False
            UI_DownloadUpdateBtn.Enabled = True
            UI_InstallUpdateBtn.Visible = True
            UI_SearchUpdateBtn.Enabled = True

            My.Settings.UPDATE_PENDING_INSTALLATION = True
            My.Settings.UPDATE_PENDING_DOWNLOAD = False

            UI_DownloadState.Visible = False

            Select Case My.Settings.UPDATE_AUTOMATIC_INSTALLATION
                Case True
                    Select Case My.Settings.UPDATE_AUTOMATIC_INSTALLATION_SILENT_MODE
                        Case True
                            UI_CurrentProcessProgress.Value = 0
                            UI_CurrentProcessText.Text = Frm99_TranslateForm.UI04_UpdateInstallOnAppClose.Text

                            My.Settings.UPDATE_SILENT_INSTALL = True

                        Case False
                            UI_CurrentProcessText.Text = Frm99_TranslateForm.UI04_UpdateInstalling.Text
                            UI_CurrentProcessProgress.Style = ProgressBarStyle.Marquee

                            UpdateInstall()

                    End Select

                Case False
                    UI_CurrentProcessProgress.Visible = False
                    UI_CurrentProcessText.Visible = False
            End Select

        Else ' Download Failed

            ControlBox = True

            UI_DownloadUpdateBtn.Visible = True
            UI_DownloadUpdateBtn.Enabled = True
            UI_InstallUpdateBtn.Visible = False
            UI_SearchUpdateBtn.Enabled = True

            UI_CurrentProcessProgress.Visible = False
            UI_CurrentProcessText.Visible = False
            UI_DownloadState.Visible = False

            My.Settings.UPDATE_PENDING_INSTALLATION = False
            My.Settings.UPDATE_PENDING_DOWNLOAD = True

            My.Settings.UPDATE_SILENT_INSTALL = False

        End If

    End Sub

    Private Sub UI_InstallUpdateBtn_Click(sender As Object, e As EventArgs) Handles UI_InstallUpdateBtn.Click
        UpdateInstall()
    End Sub
    Sub UpdateInstall()

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = $"{Locate}\UpdatePkg.exe", .WorkingDirectory = Locate, .Arguments = "/SILENT /CURRENTUSER /CLOSEAPPLICATIONS /NOCANCEL"}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.AssemblyName)

        End Try

    End Sub

    ' Page end

End Class