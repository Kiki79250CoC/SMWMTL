
Imports System.Environment
Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.ApplicationServices
Imports SMWMTLextensions.Dialogs

Public Class ApplicationInfo

    Public Shared ReadOnly ExecutableLocation As String = My.Application.Info.DirectoryPath
    Public Shared ReadOnly ExecutablePath As String = Path.GetFileName(Application.ExecutablePath)
    Public Shared ReadOnly AppDataFolder As String = GetFolderPath(SpecialFolder.LocalApplicationData)
    Public Shared ReadOnly ConfigFile As String = Configuration.ConfigurationManager.OpenExeConfiguration(Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath

    Public Shared ReadOnly AppInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Reflection.Assembly.GetExecutingAssembly().Location)
    Public Shared ReadOnly AppVersion As New Version(AppInfo.ProductMajorPart, AppInfo.ProductMinorPart, AppInfo.ProductBuildPart, AppInfo.ProductPrivatePart)

    Public Shared ReadOnly AppVerMM As String = $"{AppVersion.Major}.{AppVersion.Minor}"
    Public Shared ReadOnly AppVerBR As String = $"{AppVersion.Build}.{AppVersion.Revision:00}"

    Public Shared ReadOnly CompileDate As Date = OSInteract.PELinkerTimestamp(Reflection.Assembly.GetExecutingAssembly().Location)

End Class

Public Class SystemInterop

    Public Shared ReadOnly CltOSV As New Version(OSVersion.Version.Major, OSVersion.Version.Minor, OSVersion.Version.Build)

    ' AeroGlass (Windows Vista, 7, 8, 8.1)
    <StructLayout(LayoutKind.Sequential)> Public Structure Side
        Public Left As Integer
        Public Right As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure
    <DllImport("dwmapi.dll")>
    Public Shared Function DwmExtendFrameIntoClientArea(hWnd As IntPtr, ByRef pMarinset As Side) As Integer
    End Function

    ' Mica/Acrylic (Windows 10 1803+/11)
    Public Enum DWM_WindowAttribute
        UseImmersiveMode = 20
        SystemBackdropType = 38
        BorderColor = 34
    End Enum
    <DllImport("dwmapi.dll")>
    Public Shared Function DwmSetWindowAttribute(hwnd As IntPtr, dwAttribute As DWM_WindowAttribute, ByRef pvAttribute As Integer, cbAttribute As Integer) As Integer
    End Function

End Class

Namespace My
#Region "    Debug flag"
    Public Module Common
#If DEBUG Then
        Public IsDebug As Boolean = True
#Else
    Public IsDebug As Boolean = False
#End If
    End Module
#End Region

    Partial Friend Class MyApplication

        Private Sub App_JumpStart(sender As Object, e As StartupEventArgs) Handles Me.Startup

            ' Block all Windows versions below Vista SP2 (and XP if HexHack/OCA)
            If Not OSBehavior.IsOSSupported Then
                Try
                    Dim SupportedOSList = New TaskDialogButton("SupportedOSList", Resources.Strings.Msg_TD_UnsupportedOS_BtnSupportedOS)
                    Dim SeeLTSVersions = New TaskDialogButton("SeeLTSVersions", Resources.Strings.Msg_TD_UnsupportedOS_BtnSeeLTS)
                    Dim CloseBtn = New TaskDialogButton("CloseBtn", Resources.Strings.App_GText_Close) With {.Default = True}

                    Using TaskDlg As New TaskDialog
                        AddHandler SupportedOSList.Click,
                        Sub()
                            TaskDlg.Close()
                            Process.Start("https://github.com/Kiki79250CoC/SMWMTL/blob/Dev/SystemComp.md")
                        End Sub
                        AddHandler SeeLTSVersions.Click,
                        Sub()
                            TaskDlg.Close()
                            Process.Start("https://github.com/Kiki79250CoC/SMWMTL/releases?q=%222.10-LTS%22&expanded=true")
                        End Sub
                        AddHandler CloseBtn.Click,
                        Sub()
                            TaskDlg.Close()
                        End Sub

                        TaskDlg.Caption = $"{Application.Info.AssemblyName} · {Resources.Strings.App_GText_ErrorF}"
                        TaskDlg.InstructionText = Resources.Strings.Msg_TD_UnsupportedOS_InstructionText
                        TaskDlg.Icon = TaskDialogStandardIcon.DefaultIcon_Error
                        TaskDlg.Text = String.Format(Resources.Strings.Msg_TD_UnsupportedOS_Text, Application.Info.AssemblyName)

                        TaskDlg.Controls.Add(SupportedOSList)
                        TaskDlg.Controls.Add(SeeLTSVersions)
                        TaskDlg.Controls.Add(CloseBtn)

                        TaskDlg.OwnerWindowHandle = Frm01_Main.Handle
                        TaskDlg.Show()
                    End Using
                Catch ex As Exception
                    MsgBox(String.Format(Resources.Strings.Msg_TD_UnsupportedOS_Text, Application.Info.AssemblyName), MsgBoxStyle.Critical, Application.Info.AssemblyName)
                End Try
                End
            End If

            ' Block execution if "SMWMTL.exe.config" file is missing
            If Not File.Exists($"{ApplicationInfo.ExecutablePath}.config") Then
                Using TaskDlg As New TaskDialog
                    TaskDlg.Caption = $"{Application.Info.AssemblyName} · {Resources.Strings.App_GText_ErrorC}"
                    TaskDlg.InstructionText = Resources.Strings.Msg_TD_ConfigFile_Missing_InstructionText
                    TaskDlg.Icon = TaskDialogStandardIcon.DefaultIcon_Error
                    TaskDlg.Text = String.Format(Resources.Strings.Msg_TD_ConfigFile_Missing_Text, $"{Path.GetFileName(Windows.Forms.Application.ExecutablePath)}.config")
                    TaskDlg.OwnerWindowHandle = Frm01_Main.Handle
                    TaskDlg.Show()
                End Using
                End
            End If

            ' Migrates "AstragonQC_Softwares" settings folder to "AstragonQC_Software" (if 2.2x installed)
            Dim OldDir = $"{ApplicationInfo.AppDataFolder}\AstragonQC_Softwares\SMWMTL.exe_StrongName_r5fdzx4hx5s3ws3oxg5rca4llvs4yb2p\1.1.0.0"

            If Directory.Exists(OldDir) AndAlso Not File.Exists($"{OldDir}\.Migrated") Then

                If File.Exists(ApplicationInfo.ConfigFile) Then
                    File.Delete(ApplicationInfo.ConfigFile)
                End If

                File.Copy($"{OldDir}\user.config", ApplicationInfo.ConfigFile)
                File.Create($"{OldDir}\.Migrated")

            End If







            ' -----------------------------------------------------------------------------------------------------------------

            ' Code that applies on Custom SMWMTL releases -- TO BE REMOVED

            Select Case Resources.RELEASE_TYPE
                Case "SMWC"

                    ' Force deleting already downloaded update package

                    Try

                        File.Delete($"{Application.Info.DirectoryPath}\UpdatePkg.exe")

                    Catch ex As Exception

                    End Try

                    ' Force disabling some settings

                    Settings.UPDATE_PENDING = False
                    Settings.UPDATE_PENDING_DOWNLOAD = False
                    Settings.UPDATE_PENDING_INSTALLATION = False
                    Settings.UPDATE_SILENT_INSTALL = False

                    Settings.SHOW_WINVER_BTN = False
                    Settings.BUILT_IN_WINVER = False
                    Settings.SHOW_TASKMGR_BTN = False
                    Settings.USE_SHELL32_ABOUTBOX = False

                    Settings.DISPLAY_COMPLETEVERSION_IN_MAIN_WINDOW = False
                    Settings.SHOW_LEGACYABOUTBTN = False

                    Settings.UPDATE_SEARCH_AT_STARTUP = False
                    Settings.UPDATE_SEARCH_AT_STARTUP_DISCRETE_MODE = False
                    Settings.USE_LEGACY_UPDATE_POPUPS = False
                    Settings.ENABLE_UPDATE_INDICATOR_ON_ABOUT_WINDOW = False
                    Settings.SHOW_UPDATE_SYSTEM_INFOS_ON_ABOUT_SCREEN = False
                    Settings.UPDATE_AUTOMATIC_DOWNLOAD = False
                    Settings.UPDATE_AUTOMATIC_INSTALLATION = False
                    Settings.UPDATE_AUTOMATIC_INSTALLATION_SILENT_MODE = False

                    Settings.EX_SET_DARKMODE_HOMEUPDATEBAR = False

                    ' Hiding useless options from Settings page

                    With Frm03_Settings

                        .UI_Btn_UpdatesModal.Visible = False
                        .DownArrowMenu_Sep03.Visible = False
                        .DownArrowMenu_HD_ExperimentalSettings.Visible = False
                        .UI_Btn_ExperimentalSettings.Location = New Point(29, 2)

                        .UI_Tab02_Cat01.Visible = False
                        .UI_Tab02_Cat02.Visible = False

                        .UI_Tab02_Cat03.Location = New Point(3, 25)
                        .UI_Tab02_Cat03.Height = 142

                        .AppOption_DisplayWinverButton.Visible = False
                        .WinverButtonIcon.Visible = False
                        .UI_Tab02_Cat03_UnderOption01.Visible = False
                        .AppOption_BuiltInWinver.Visible = False
                        .BuiltInWinverButtonIcon.Visible = False
                        .AppOption_BuiltInAboutWindows_Prewiew.Visible = False
                        .AppOption_DisplayTaskmgrButton.Visible = False
                        .TaskmgrButtonIcon.Visible = False
                        .AppOption_DisplayAboutButton.Visible = False
                        .AboutButtonIcon.Visible = False
                        .UI_Tab02_Cat03_UnderOption02.Visible = False
                        .AppOption_UseShell32About.Visible = False
                        .Shell32AboutIcon.Visible = False

                        .AppOption_DisplayCompleteVersionOnMainWindow.Visible = False

                        .AppOption_ColumnsNumberComboBox.Location = New Point(Frm03_Settings.AppOption_ColumnsNumberComboBox.Location.X, Frm03_Settings.AppOption_ColumnsNumberComboBox.Location.Y - 23)
                        .Text_007.Location = New Point(Frm03_Settings.Text_007.Location.X, Frm03_Settings.Text_007.Location.Y - 23)
                        .Text_008.Location = New Point(Frm03_Settings.Text_008.Location.X, Frm03_Settings.Text_008.Location.Y - 23)

                        .AppOption_DisplayBtn_LunarMagic.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_LunarMagic.Location.X, Frm03_Settings.AppOption_DisplayBtn_LunarMagic.Location.Y - 23)
                        .AppOption_DisplayBtn_LunarExpand.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_LunarExpand.Location.X, Frm03_Settings.AppOption_DisplayBtn_LunarExpand.Location.Y - 23)
                        .AppOption_DisplayBtn_RecoverLM.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_RecoverLM.Location.X, Frm03_Settings.AppOption_DisplayBtn_RecoverLM.Location.Y - 23)
                        .AppOption_DisplayBtn_SnesGFX.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_SnesGFX.Location.X, Frm03_Settings.AppOption_DisplayBtn_SnesGFX.Location.Y - 23)
                        .AppOption_DisplayBtn_MarioLPE.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_MarioLPE.Location.X, Frm03_Settings.AppOption_DisplayBtn_MarioLPE.Location.Y - 23)
                        .AppOption_DisplayBtn_HeAdder.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_HeAdder.Location.X, Frm03_Settings.AppOption_DisplayBtn_HeAdder.Location.Y - 23)
                        .AppOption_DisplayBtn_HDMARipper.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_HDMARipper.Location.X, Frm03_Settings.AppOption_DisplayBtn_HDMARipper.Location.Y - 23)
                        .AppOption_DisplayBtn_MMLEdit.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_MMLEdit.Location.X, Frm03_Settings.AppOption_DisplayBtn_MMLEdit.Location.Y - 23)
                        .AppOption_DisplayBtn_AddMusicK.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_AddMusicK.Location.X, Frm03_Settings.AppOption_DisplayBtn_AddMusicK.Location.Y - 23)
                        .AppOption_DisplayBtn_LvMusUtil.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_LvMusUtil.Location.X, Frm03_Settings.AppOption_DisplayBtn_LvMusUtil.Location.Y - 23)
                        .AppOption_DisplayBtn_BRRPlayer.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_BRRPlayer.Location.X, Frm03_Settings.AppOption_DisplayBtn_BRRPlayer.Location.Y - 23)
                        .AppOption_DisplayBtn_Blockreator.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_Blockreator.Location.X, Frm03_Settings.AppOption_DisplayBtn_Blockreator.Location.Y - 23)
                        .AppOption_DisplayBtn_Pixi.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_Pixi.Location.X, Frm03_Settings.AppOption_DisplayBtn_Pixi.Location.Y - 23)
                        .AppOption_DisplayBtn_Mode7Tilemap.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_Mode7Tilemap.Location.X, Frm03_Settings.AppOption_DisplayBtn_Mode7Tilemap.Location.Y - 23)
                        .AppOption_DisplayBtn_SPC700Player.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_SPC700Player.Location.X, Frm03_Settings.AppOption_DisplayBtn_SPC700Player.Location.Y - 23)
                        .AppOption_DisplayBtn_Flips.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_Flips.Location.X, Frm03_Settings.AppOption_DisplayBtn_Flips.Location.Y - 23)
                        .AppOption_DisplayBtn_StatusEffects.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_StatusEffects.Location.X, Frm03_Settings.AppOption_DisplayBtn_StatusEffects.Location.Y - 23)
                        .AppOption_DisplayBtn_SPCTool.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_SPCTool.Location.X, Frm03_Settings.AppOption_DisplayBtn_SPCTool.Location.Y - 23)
                        .AppOption_DisplayBtn_EffectTools.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_EffectTools.Location.X, Frm03_Settings.AppOption_DisplayBtn_EffectTools.Location.Y - 23)
                        .AppOption_DisplayBtn_GopherPopcornStew.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_GopherPopcornStew.Location.X, Frm03_Settings.AppOption_DisplayBtn_GopherPopcornStew.Location.Y - 23)
                        .AppOption_DisplayBtn_PetiteMM.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_PetiteMM.Location.X, Frm03_Settings.AppOption_DisplayBtn_PetiteMM.Location.Y - 23)
                        .AppOption_DisplayBtn_Asar.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_Asar.Location.X, Frm03_Settings.AppOption_DisplayBtn_Asar.Location.Y - 23)
                        .AppOption_DisplayBtn_Snes9x.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_Snes9x.Location.X, Frm03_Settings.AppOption_DisplayBtn_Snes9x.Location.Y - 23)
                        .AppOption_DisplayBtn_MarioStartEditor.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_MarioStartEditor.Location.X, Frm03_Settings.AppOption_DisplayBtn_MarioStartEditor.Location.Y - 23)
                        .AppOption_DisplayBtn_InteractionEdit.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_InteractionEdit.Location.X, Frm03_Settings.AppOption_DisplayBtn_InteractionEdit.Location.Y - 23)
                        .AppOption_DisplayBtn_MultipleMidwayPoints.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_MultipleMidwayPoints.Location.X, Frm03_Settings.AppOption_DisplayBtn_MultipleMidwayPoints.Location.Y - 23)
                        .AppOption_DisplayBtn_SpriteGFX.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_SpriteGFX.Location.X, Frm03_Settings.AppOption_DisplayBtn_SpriteGFX.Location.Y - 23)
                        .AppOption_DisplayBtn_GraphEdit.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_GraphEdit.Location.X, Frm03_Settings.AppOption_DisplayBtn_GraphEdit.Location.Y - 23)
                        .AppOption_DisplayBtn_YYCHR.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_YYCHR.Location.X, Frm03_Settings.AppOption_DisplayBtn_YYCHR.Location.Y - 23)
                        .AppOption_DisplayBtn_SMWCust.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_SMWCust.Location.X, Frm03_Settings.AppOption_DisplayBtn_SMWCust.Location.Y - 23)
                        .AppOption_DisplayBtn_SHTools.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_SHTools.Location.X, Frm03_Settings.AppOption_DisplayBtn_SHTools.Location.Y - 23)
                        .AppOption_DisplayBtn_UberASM.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_UberASM.Location.X, Frm03_Settings.AppOption_DisplayBtn_UberASM.Location.Y - 23)
                        .AppOption_DisplayBtn_GradientTool.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_GradientTool.Location.X, Frm03_Settings.AppOption_DisplayBtn_GradientTool.Location.Y - 23)

                        .AppOption_DisplayBtn_Btn34.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_Btn34.Location.X, Frm03_Settings.AppOption_DisplayBtn_Btn34.Location.Y - 23)
                        .AppOption_DisplayBtn_Btn35.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_Btn35.Location.X, Frm03_Settings.AppOption_DisplayBtn_Btn35.Location.Y - 23)

                        .AppOption_DisplayBtn_CheckAll.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_CheckAll.Location.X, Frm03_Settings.AppOption_DisplayBtn_CheckAll.Location.Y - 23)
                        .AppOption_DisplayBtn_UncheckAll.Location = New Point(Frm03_Settings.AppOption_DisplayBtn_UncheckAll.Location.X, Frm03_Settings.AppOption_DisplayBtn_UncheckAll.Location.Y - 23)

                        .UI_Tab03_Cat01.Height = Frm03_Settings.UI_Tab03_Cat01.Height - 23

                        .AppOption_EnableLegacyAboutBox.Visible = False

                        .UI_Tab03_Cat02.Location = New Point(Frm03_Settings.UI_Tab03_Cat02.Location.X, Frm03_Settings.UI_Tab03_Cat02.Location.Y - 23)
                        .UI_Tab03_Cat02.Height = 42

                        .AppOption_HideVersionStringInAboutBox.Location = New Point(9, 19)

                        .UI_Tab03_Cat03.Location = New Point(Frm03_Settings.UI_Tab03_Cat03.Location.X, Frm03_Settings.UI_Tab03_Cat03.Location.Y - 43)
                        .UI_Tab03_Cat04.Location = New Point(Frm03_Settings.UI_Tab03_Cat04.Location.X, Frm03_Settings.UI_Tab03_Cat04.Location.Y - 43)

                        .UI_MainSettingsTab.TabPages.Remove(Frm03_Settings.UI_SettingsTab05)

                    End With

                Case Else

            End Select

            ' -----------------------------------------------------------------------------------------------------------------

            ' Update - "UpdatePkg.exe" file handling
            Select Case File.Exists($"{Application.Info.DirectoryPath}\UpdatePkg.exe")
                Case True
                    Select Case Version.Parse(FileVersionInfo.GetVersionInfo($"{ApplicationInfo.ExecutableLocation}\UpdatePkg.exe").FileVersion).ToString
                        Case Is <= $"{Resources.APP_VERSION}.{Resources.APP_VERSION_BUILD}"
                            Try

                                File.Delete($"{Application.Info.DirectoryPath}\UpdatePkg.exe")

                            Catch ex As Exception

                            End Try

                        Case Is > $"{Resources.APP_VERSION}.{Resources.APP_VERSION_BUILD}"
                            Select Case Settings.UPDATE_SILENT_INSTALL
                                Case True
                                    Try

                                        Dim ProcStart As New ProcessStartInfo With {.FileName = $"{Application.Info.DirectoryPath}\UpdatePkg.exe", .WorkingDirectory = Application.Info.DirectoryPath, .Arguments = "/VERYSILENT /CURRENTUSER /CLOSEAPPLICATIONS /NOCANCEL"}
                                        Process.Start(ProcStart)

                                    Catch ex As Exception

                                        MsgBox(ex.Message, MsgBoxStyle.Critical, Application.Info.AssemblyName)

                                    End Try

                            End Select

                    End Select

            End Select

            ' Set current version number
            Settings.EXECUTABLE_CURRENT_VERSION = ApplicationInfo.AppVersion.ToString

            ' Settings refresh
            With Settings
                .Save()
                .Reload()
            End With

            ' Updates module v3
            ' -----------------------------------------------------------------------------------------------------------------

            ' Untrigger silent update when current version is the same or above the last version found in update
            If Settings.UPDATE_SILENT_INSTALL = True And Settings.UPDATE_FOUND_CVERSION <= Resources.APP_VERSION_WITHZERO Then

                Settings.UPDATE_SILENT_INSTALL = False

            End If

            ' Disable "Update pending" if last check is +6 hours or if last checked version number is < / = than current
            If Settings.UPDATE_PENDING = True And Now > Settings.LAST_UPDATE_CHECK_DATE.AddHours(6) OrElse Settings.UPDATE_PENDING = True And Settings.UPDATE_FOUND_CVERSION <= $"{Resources.APP_VERSION_WITHZERO}.{Resources.APP_VERSION_BUILD}" Then

                Settings.UPDATE_PENDING = False
                Settings.UPDATE_PENDING_DOWNLOAD = False
                Settings.UPDATE_PENDING_INSTALLATION = False

            End If

            ' -----------------------------------------------------------------------------------------------------------------

            ' Enable the Pre-Release mode is this build is a beta one
            Select Case Resources.RELEASE_STATE
                Case "Pre-Stable", "Stable", "Stable LTS"
                    Settings.IS_PRERELEASE = False

                Case Else
                    Settings.IS_PRERELEASE = True

            End Select

        End Sub

        Public Sub TaskDialog_Opened(sender As Object, e As EventArgs)
            Dim taskDialog = TryCast(sender, TaskDialog)
            'taskDialog.Icon = taskDialog.Icon
            'taskDialog.FooterIcon = taskDialog.FooterIcon

            With taskDialog
                .Icon = .Icon
                .FooterIcon = .FooterIcon
            End With



        End Sub

        Private Sub App_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            e.ExitApplication = False

            'Dim CopyBtn = New TaskDialogButton("CopyBtn", Resources.Strings.Msg_TD_GeneralException_BtnCopy)
            'Dim OKBtn = New TaskDialogButton("OKBtn", Resources.Strings.App_GText_OK) With {.Default = True}
            'Using TaskDlg As New TaskDialog
            '    TaskDlg.Caption = $"{Application.Info.AssemblyName} · {Resources.Strings.Msg_TD_GeneralException_Title}"
            '    TaskDlg.InstructionText = Resources.Strings.Msg_TD_GeneralException_Title
            '    TaskDlg.Icon = TaskDialogStandardIcon.DefaultIcon_Error

            '    TaskDlg.Text = String.Format(Resources.Strings.Msg_TD_GeneralException_Text, e.Exception.Message)

            '    AddHandler CopyBtn.Click,
            '    Sub()
            '        TaskDlg.Close()
            '        Clipboard.SetText($"SMWMTL · Generated Exception report{vbCrLf}-----------------------------------{vbCrLf + vbCrLf}ERROR {e.Exception.HResult}{vbCrLf + vbCrLf}{e.Exception.Message}{vbCrLf + vbCrLf}{e.Exception.StackTrace}")
            '    End Sub
            '    TaskDlg.Controls.Add(CopyBtn)

            '    AddHandler OKBtn.Click,
            '    Sub()
            '        TaskDlg.Close()
            '    End Sub
            '    TaskDlg.Controls.Add(OKBtn)

            '    TaskDlg.DetailsExpandedLabel = Resources.Strings.Msg_TD_GeneralException_SeeDetailsText
            '    TaskDlg.DetailsExpandedText = String.Format(Resources.Strings.Msg_TD_GeneralException_ExpandedText + vbCrLf, e.Exception.StackTrace)
            '    TaskDlg.ExpansionMode = TaskDialogExpandedDetailsLocation.ExpandFooter

            '    TaskDlg.OwnerWindowHandle = Frm01_Main.Handle
            '    TaskDlg.Show()
            'End Using
        End Sub

    End Class

End Namespace
