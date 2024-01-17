
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Environment

Namespace My

    Partial Friend Class MyApplication

        Private ReadOnly AppVersion As FileVersionInfo = FileVersionInfo.GetVersionInfo(Reflection.Assembly.GetExecutingAssembly().Location)

        Private Function GetFileVersionInfo(filename As String) As Version
            Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion)
        End Function

        ' ---------------------------------------------------------------------------------------------------------------------

        Private Sub App_JumpStart(sender As Object, e As StartupEventArgs) Handles Me.Startup




            ' Migrates "AstragonQC_Softwares" settings folder to "AstragonQC_Software"
            Dim LocalAppData As String = GetFolderPath(SpecialFolder.LocalApplicationData)

            If IO.Directory.Exists($"{LocalAppData}\AstragonQC_Softwares") Then
                MsgBox("bite")






            End If

            ' Block Windows XP execution, even with HEX-Operating system number hack

            MsgBox($"{AppVersion.ProductMajorPart}.{AppVersion.ProductMinorPart}")

            If OSVersion.Version.Major < 6 Then

                MsgBox($"{Frm99_TranslateForm.UI00_UnsupportedOS.Text} {Application.Info.AssemblyName}.", MsgBoxStyle.Critical, Application.Info.AssemblyName)
                End

            End If

            ' Block execution if "Application.exe.config" file is missing
            Select Case IO.File.Exists($"{IO.Path.GetFileName(Windows.Forms.Application.ExecutablePath)}.config")
                Case False
                    MsgBox($"{Frm99_TranslateForm.UI00_ConfigFileMissing.Text.Replace("$SFL", $"{IO.Path.GetFileName(Windows.Forms.Application.ExecutablePath)}.config")}", MsgBoxStyle.Critical, Application.Info.AssemblyName)
                    End

            End Select

            ' -----------------------------------------------------------------------------------------------------------------

            ' Code that applies on Custom SMWMTL releases

            Select Case Resources.RELEASE_TYPE
                Case "SMWC"

                    ' Force deleting already downloaded update package

                    Try

                        IO.File.Delete($"{Application.Info.DirectoryPath}\UpdatePkg.exe")

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
            Select Case IO.File.Exists($"{Application.Info.DirectoryPath}\UpdatePkg.exe")
                Case True
                    Select Case GetFileVersionInfo($"{Application.Info.DirectoryPath}\UpdatePkg.exe").ToString
                        Case Is <= $"{Resources.APP_VERSION}.{Resources.APP_VERSION_BUILD}"
                            Try

                                IO.File.Delete($"{Application.Info.DirectoryPath}\UpdatePkg.exe")

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
            Settings.EXECUTABLE_CURRENT_VERSION = $"{Resources.APP_VERSION}.{Resources.APP_VERSION_BUILD}"

            ' Settings refresh
            Settings.Save()
            Settings.Reload()

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
        Private Sub App_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException

            e.ExitApplication = False
            MsgBox(e.Exception.Message.ToString(), MsgBoxStyle.Critical, Application.Info.AssemblyName)

        End Sub

    End Class

End Namespace
