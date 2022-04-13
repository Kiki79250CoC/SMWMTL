
Imports System.Configuration

Public Class Frm03_Settings
#Region "        DMWAPI "

    ' Detect DWM activation
    <Runtime.InteropServices.DllImport("dwmapi.dll")> Private Shared Function DwmIsCompositionEnabled(ByRef enabled As Boolean) As Integer
    End Function
    Public Function AeroEnabled() As Boolean
        If Environment.OSVersion.Version.Major < 6 Then Return False
        Dim Enabled As Boolean
        DwmIsCompositionEnabled(Enabled)
        Return Enabled
    End Function

    ' Border extension
    <Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential)> Public Structure Side
        Public Left As Integer
        Public Right As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure
    <Runtime.InteropServices.DllImport("dwmapi.dll")> Public Shared Function DwmExtendFrameIntoClientArea(hWnd As IntPtr, ByRef pMarinset As Side) As Integer
    End Function

#End Region
#Region "        Values "

    ' Windows Version informations (Kernel + Build)
    ReadOnly Win_NT_Version As String = $"{Environment.OSVersion.Version.Major}.{Environment.OSVersion.Version.Minor}"
    ReadOnly Win_BuildNbr As String = Environment.OSVersion.Version.Build

    ' Config file location and initial location for open and save dialogs
    ReadOnly ConfigFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath

#End Region

    Private Sub Frm03_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Icon = My.Resources.AppIcon

        ' Execute some code according to Windows Version that SMWMTL is running on.
        Select Case Win_NT_Version
            Case "6.0", "6.1"
#Region "                Code that applies to Windows Vista and 7 "

                Z99_UIDeco01.Image = My.Resources.UI_RightMask_7
                Z99_UIDeco02.Image = My.Resources.UI_LeftMask_7

                AppOption_DWMExtension.Text = Frm99_TranslateForm.UI03_DWM_WinVista.Text

                Taskmgr_CurrentOSIcon.Image = My.Resources.Taskmgr_Icon_WinVista_7
                Select Case Win_NT_Version
                    Case "6.0"
                        Winver_CurrentOSIcon.Image = My.Resources.Winver_Logo_WinVista

                    Case "6.1"
                        Winver_CurrentOSIcon.Image = My.Resources.Winver_Logo_Win7

                End Select

#End Region

            Case "6.2", "6.3"
#Region "                Code that applies to Windows 8 and 8.1 "

                Z99_UIDeco01.Image = My.Resources.UI_RightMask_8
                Z99_UIDeco02.Image = My.Resources.UI_LeftMask_8

                AppOption_DWMExtension.Text = Frm99_TranslateForm.UI03_DWM_Win8.Text

                Winver_CurrentOSIcon.Image = My.Resources.Winver_Logo_Win8
                Taskmgr_CurrentOSIcon.Image = My.Resources.Taskmgr_Icon_Win8_10

#End Region

            Case "6.4", "10.0"
#Region "                Code that applies to Windows 10 and 11 "

                AppOption_DWMExtension.Text = Frm99_TranslateForm.UI03_DWM_Win8.Text

                If Win_BuildNbr >= "21800" Then
                    Z99_UIDeco01.Image = My.Resources.UI_RightMask_11
                    Z99_UIDeco02.Image = My.Resources.UI_LeftMask_11

                    Winver_CurrentOSIcon.Image = My.Resources.Winver_Logo_Win11
                    Taskmgr_CurrentOSIcon.Image = My.Resources.Taskmgr_Icon_Win11

                Else
                    Z99_UIDeco01.Image = My.Resources.UI_RightMask_10
                    Z99_UIDeco02.Image = My.Resources.UI_LeftMask_10

                    Winver_CurrentOSIcon.Image = My.Resources.Winver_Logo_Win10
                    Taskmgr_CurrentOSIcon.Image = My.Resources.Taskmgr_Icon_Win8_10

                End If

#End Region

        End Select

        ' Disable some options in function of DWM activation state
        Select Case AeroEnabled()
            Case True
                AppOption_WinClassicEnhancements.Enabled = False

            Case False
                AppOption_DWMExtension.Enabled = False

        End Select

        ' Settings load

        ' Améliorations visuelles pour Windows Classic
        For Each ImgBx As PictureBox In {Z99_UIDeco01, Z99_UIDeco02, Z99_UIDeco03, Z99_UIDeco04}
            Select Case My.Settings.WIN_CLASSIC_ENHANCEMENTS
                Case True
                    ImgBx.Visible = False

                Case False
                    ImgBx.Visible = True

            End Select
        Next

        ' DWMAPI extension (Option enabled) and Theme (Option Disabled)
        Select Case My.Settings.DWM_EXTENSION
            Case True
                Select Case AeroEnabled()
                    Case True
                        Dim side As New Side With {.Left = 9, .Right = 9, .Top = 29, .Bottom = If(Win_NT_Version = "6.0", 11, 9)}
                        Dim result As Integer = DwmExtendFrameIntoClientArea(Handle, side)

                        BackColor = Color.Black

                End Select

            Case False



        End Select

        ' Hiding the title and the window icon
        Select Case My.Settings.HIDE_TITLE
            Case True
                Text = Nothing

            Case False
                Select Case My.Settings.DEVELOPER_MODE
                    Case True
                        Text += If(Text.Contains(Frm99_TranslateForm.UI03_DevModeEnabledTitleText.Text), Nothing, $" • {Frm99_TranslateForm.UI03_DevModeEnabledTitleText.Text}")

                End Select

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
                    Case 1
                        Opacity = My.Settings.APP_OPACITY / 100

                End Select

        End Select

        ' Settings text dynamic modifications
        AppOption_DisplayCompleteVersionOnMainWindow.Text = AppOption_DisplayCompleteVersionOnMainWindow.Text.Replace("$VER", My.Resources.APP_VERSION_COMPLETE)

        ' Set "Appearance" tab as active tab
        UI_MainSettingsTab.SelectedTab = UI_SettingsTab01

        ' Developer Mode hidden buttons
        UI_Btn_ExperimentalSettings.Visible = My.Settings.DEVELOPER_MODE

        ' Modifiable Settings load process
        SettingsLoad()

    End Sub
    Sub SettingsLoad()

        ' ----- APPEARANCE TAB -----

        ' Application look
        AppOption_DWMExtension.Checked = My.Settings.DWM_EXTENSION
        AppOption_WinClassicEnhancements.Checked = My.Settings.WIN_CLASSIC_ENHANCEMENTS

        AppOption_DarkThemeToggle.Checked = My.Settings.UI_DARK_MODE

        ' Appearance tweaks
        AppOption_LockAtTopMost.Checked = My.Settings.LOCK_AT_TOPMOST

        AppOption_HideTitle.Checked = My.Settings.HIDE_TITLE
        AppOption_HideIcon.Checked = My.Settings.HIDE_ICON
        AppOption_ShowBlankIcon.Checked = My.Settings.BLANK_ICON

        AppOption_CustomTitleText.Checked = My.Settings.ADDITIONAL_TITLE_TEXT
        AppOption_AdditionalTitleTextType.SelectedIndex = My.Settings.ADDITIONAL_TITLE_TEXT_TYPE
        AppOption_TitleCustomText.Text = My.Settings.CUSTOM_TITLE_TEXT

        ' Application Opacity
        AppOption_AppOpacity.Checked = My.Settings.APP_OPACITY_TOGGLE
        AppOption_AppOpacityApplyMode.SelectedIndex = My.Settings.APP_OPACITY_APPLY_MODE
        AppOption_OpacityValue.Value = My.Settings.APP_OPACITY

        ' Theme
        AppOption_Theme.SelectedIndex = My.Settings.SELECTED_THEME

        ' ----- ICONS AND BUTTONS TAB -----

        ' Windows Version Button Icon
        AppOption_WinverIcon.SelectedIndex = My.Settings.WINVER_ICON
        AppOption_WinverIconBasedOnCurrentOS.Checked = My.Settings.WINVER_USE_CURRENT_OS_ICON

        ' Task Manager Button Icon
        AppOption_TaskmgrIconLineColor.SelectedIndex = My.Settings.TASKMGR_ICON_LINE
        AppOption_TaskmgrIconBackColor.SelectedIndex = My.Settings.TASKMGR_ICON_BACK
        AppOption_TaskmgrIconBasedOnCurrentOS.Checked = My.Settings.TASKMGR_USE_WINDOWS_ICON

        ' Bottom bar buttons options
        AppOption_DisplayHelpButton.Checked = My.Settings.SHOW_HELP_BTN
        AppOption_DisplaySuggestUpdateButton.Checked = My.Settings.SHOW_SUGGESTUPDATE_BTN
        AppOption_DisplayReportCrashButton.Checked = My.Settings.SHOW_REPORTCRASH_BTN
        AppOption_DisplayWinverButton.Checked = My.Settings.SHOW_WINVER_BTN
        AppOption_BuiltInWinver.Checked = My.Settings.BUILT_IN_WINVER
        AppOption_DisplayTaskmgrButton.Checked = My.Settings.SHOW_TASKMGR_BTN

        AppOption_HideBottomBtns.Checked = My.Settings.HIDE_ALL_BOTTOM_BUTTONS
        AppOption_BtmBarSeparators.Checked = My.Settings.SHOW_BTN_SEPARATORS
        AppOption_UseShell32About.Checked = My.Settings.USE_SHELL32_ABOUTBOX

        ' ----- LAUNCHER TAB -----

        ' Main window
        AppOption_DisplayCompleteVersionOnMainWindow.Checked = My.Settings.DISPLAY_COMPLETEVERSION_IN_MAIN_WINDOW

        AppOption_ColumnsNumberComboBox.SelectedIndex = My.Settings.MAINWINDOW_DISPLAYED_COLUMN_NBR

        AppOption_DisplayBtn_LunarMagic.Checked = My.Settings.DISPLAYBTN_LUNARMAGIC
        AppOption_DisplayBtn_LunarExpand.Checked = My.Settings.DISPLAYBTN_LUNAREXPAND
        AppOption_DisplayBtn_RecoverLM.Checked = My.Settings.DISPLAYBTN_RECOVERLM
        AppOption_DisplayBtn_SnesGFX.Checked = My.Settings.DISPLAYBTN_SNESGFX
        AppOption_DisplayBtn_MarioLPE.Checked = My.Settings.DISPLAYBTN_MARIOLPE
        AppOption_DisplayBtn_HeAdder.Checked = My.Settings.DISPLAYBTN_HEADDER
        AppOption_DisplayBtn_HDMARipper.Checked = My.Settings.DISPLAYBTN_HDMARIPPER
        AppOption_DisplayBtn_MMLEdit.Checked = My.Settings.DISPLAYBTN_MMLEDIT
        AppOption_DisplayBtn_AddMusicK.Checked = My.Settings.DISPLAYBTN_ADDMUSICK
        AppOption_DisplayBtn_LvMusUtil.Checked = My.Settings.DISPLAYBTN_LVMUSUTIL
        AppOption_DisplayBtn_BRRPlayer.Checked = My.Settings.DISPLAYBTN_BRRPLAYER
        AppOption_DisplayBtn_Blockreator.Checked = My.Settings.DISPLAYBTN_BLOCKREATOR
        AppOption_DisplayBtn_Pixi.Checked = My.Settings.DISPLAYBTN_PIXI
        AppOption_DisplayBtn_Mode7Tilemap.Checked = My.Settings.DISPLAYBTN_MODE7TILEMAP
        AppOption_DisplayBtn_SPC700Player.Checked = My.Settings.DISPLAYBTN_SPC700PLAYER
        AppOption_DisplayBtn_Flips.Checked = My.Settings.DISPLAYBTN_FLIPS
        AppOption_DisplayBtn_StatusEffects.Checked = My.Settings.DISPLAYBTN_STATUSEFFECTS
        AppOption_DisplayBtn_SPCTool.Checked = My.Settings.DISPLAYBTN_SNESCOLORTOOL
        AppOption_DisplayBtn_EffectTools.Checked = My.Settings.DISPLAYBTN_EFFECTTOOLS
        AppOption_DisplayBtn_GopherPopcornStew.Checked = My.Settings.DISPLAYBTN_GOPHERPOPCORNSTEW
        AppOption_DisplayBtn_PetiteMM.Checked = My.Settings.DISPLAYBTN_PETITEMM
        AppOption_DisplayBtn_Asar.Checked = My.Settings.DISPLAYBTN_ASAR
        AppOption_DisplayBtn_Snes9x.Checked = My.Settings.DISPLAYBTN_SNES_EMU
        AppOption_DisplayBtn_MarioStartEditor.Checked = My.Settings.DISPLAYBTN_MARIOSTARTEDITOR
        AppOption_DisplayBtn_InteractionEdit.Checked = My.Settings.DISPLAYBTN_INTERACTIONEDIT
        AppOption_DisplayBtn_MultipleMidwayPoints.Checked = My.Settings.DISPLAYBTN_MULTIPLEMIDWAYPOINTS
        AppOption_DisplayBtn_SpriteGFX.Checked = My.Settings.DISPLAYBTN_SPRITEGFX
        AppOption_DisplayBtn_GraphEdit.Checked = My.Settings.DISPLAYBTN_GRAPHEDIT
        AppOption_DisplayBtn_YYCHR.Checked = My.Settings.DISPLAYBTN_YYCHR
        AppOption_DisplayBtn_SMWCust.Checked = My.Settings.DISPLAYBTN_SMWCUST
        AppOption_DisplayBtn_SHTools.Checked = My.Settings.DISPLAYBTN_SHTOOLS
        AppOption_DisplayBtn_UberASM.Checked = My.Settings.DISPLAYBTN_UBERASM
        AppOption_DisplayBtn_GradientTool.Checked = My.Settings.DISPLAYBTN_GRADIENTTOOL

        ' About box
        AppOption_EnableLegacyAboutBox.Checked = My.Settings.SHOW_LEGACYABOUTBTN
        AppOption_HideVersionStringInAboutBox.Checked = My.Settings.SHOW_APP_VERSION_STRING

        ' Application integration in Windows
        AppOption_ShowSystrayIcon.Checked = My.Settings.SHOW_TRAY_ICON

        ' Keyboard shortcuts
        AppOption_OpenAboutDialogKeyboardShortcut.Checked = My.Settings.KEYBOARD_SCT_ABOUTDIALOG
        AppOption_OpenHelpKeyboardShortcut.Checked = My.Settings.KEYBOARD_SCT_HELP
        AppOption_OpenSuggestUpdateKeyboardShortcut.Checked = My.Settings.KEYBOARD_SCT_SUGGESTUPDATE
        AppOption_OpenSettingsKeyboardShortcut.Checked = My.Settings.KEYBOARD_SCT_SETTINGS

        AppOption_QuickRestartKeyboardShortcut.Checked = My.Settings.KEYBOARD_SCT_RESTART
        AppOption_CustomShortcutsKeyboardShortcut.Checked = My.Settings.KEYBOARD_SCT_CUSTOMSHORTCUTS

        ' ----- CUSTOM SHORTCUTS TAB -----

        ' General
        AppOption_EnableCustomShortcuts.Checked = My.Settings.ENABLE_CUSTOM_SHORTCUTS

        ' Shortcut 1
        AppOption_EnableCustomShortcut_1.Checked = My.Settings.ENABLE_CUSTOM_SHORTCUT_1
        AppOption_Shortcut1_Path.Text = My.Settings.CUSTOM_SHORTCUT_1_PATH
        AppOption_Shortcut1_LaunchWith.SelectedIndex = My.Settings.CUSTOM_SHORTCUT_1_LAUNCH_WITH
        AppOption_Shortcut1_Icon.SelectedIndex = My.Settings.CUSTOM_SHORTCUT_1_ICON

        ' Shortcut 2
        AppOption_EnableCustomShortcut_2.Checked = My.Settings.ENABLE_CUSTOM_SHORTCUT_2
        AppOption_Shortcut2_Path.Text = My.Settings.CUSTOM_SHORTCUT_2_PATH
        AppOption_Shortcut2_LaunchWith.SelectedIndex = My.Settings.CUSTOM_SHORTCUT_2_LAUNCH_WITH
        AppOption_Shortcut2_Icon.SelectedIndex = My.Settings.CUSTOM_SHORTCUT_2_ICON

        ' Shortcut 3
        AppOption_EnableCustomShortcut_3.Checked = My.Settings.ENABLE_CUSTOM_SHORTCUT_3
        AppOption_Shortcut3_Path.Text = My.Settings.CUSTOM_SHORTCUT_3_PATH
        AppOption_Shortcut3_LaunchWith.SelectedIndex = My.Settings.CUSTOM_SHORTCUT_3_LAUNCH_WITH
        AppOption_Shortcut3_Icon.SelectedIndex = My.Settings.CUSTOM_SHORTCUT_3_ICON

        ' Shortcut 4
        AppOption_EnableCustomShortcut_4.Checked = My.Settings.ENABLE_CUSTOM_SHORTCUT_4
        AppOption_Shortcut4_Path.Text = My.Settings.CUSTOM_SHORTCUT_4_PATH
        AppOption_Shortcut4_LaunchWith.SelectedIndex = My.Settings.CUSTOM_SHORTCUT_4_LAUNCH_WITH
        AppOption_Shortcut4_Icon.SelectedIndex = My.Settings.CUSTOM_SHORTCUT_4_ICON

        ' Shortcut 5
        AppOption_EnableCustomShortcut_5.Checked = My.Settings.ENABLE_CUSTOM_SHORTCUT_5
        AppOption_Shortcut5_Path.Text = My.Settings.CUSTOM_SHORTCUT_5_PATH
        AppOption_Shortcut5_LaunchWith.SelectedIndex = My.Settings.CUSTOM_SHORTCUT_5_LAUNCH_WITH
        AppOption_Shortcut5_Icon.SelectedIndex = My.Settings.CUSTOM_SHORTCUT_5_ICON

        ' Shortcut 6
        AppOption_EnableCustomShortcut_6.Checked = My.Settings.ENABLE_CUSTOM_SHORTCUT_6
        AppOption_Shortcut6_Path.Text = My.Settings.CUSTOM_SHORTCUT_6_PATH
        AppOption_Shortcut6_LaunchWith.SelectedIndex = My.Settings.CUSTOM_SHORTCUT_6_LAUNCH_WITH
        AppOption_Shortcut6_Icon.SelectedIndex = My.Settings.CUSTOM_SHORTCUT_6_ICON

        ' ----- UPDATES TAB -----

        ' At startup
        AppOption_SearchUpdateAtAppStart.Checked = My.Settings.UPDATE_SEARCH_AT_STARTUP
        AppOption_UpdateAtStartup_DiscreteMode.Checked = My.Settings.UPDATE_SEARCH_AT_STARTUP_DISCRETE_MODE
        AppOption_UseLegacyUpdatePopups.Checked = My.Settings.USE_LEGACY_UPDATE_POPUPS

        ' "About SMWMTL" window
        AppOption_DisplayUpdateSearchModuleOnAboutWindow.Checked = My.Settings.ENABLE_UPDATE_INDICATOR_ON_ABOUT_WINDOW
        AppOption_DisplayUpdateSearchVersionOnAboutWindow.Checked = My.Settings.SHOW_UPDATE_SYSTEM_INFOS_ON_ABOUT_SCREEN

        ' "SMWMTL_Update" window
        AppOption_UpdateAutomaticDownload.Checked = My.Settings.UPDATE_AUTOMATIC_DOWNLOAD
        AppOption_UpdateAutomaticInstall.Checked = My.Settings.UPDATE_AUTOMATIC_INSTALLATION
        AppOption_UpdateAutomaticInstallSilentMode.Checked = My.Settings.UPDATE_AUTOMATIC_INSTALLATION_SILENT_MODE

        ' ----- APPLICATIONS TAB -----

        ' Lunar Magic - Slot 1
        AppOption_EnableLMSlot1.Checked = My.Settings.LM_SLOT1_ENABLED
        AppOption_EnableHeaderMagicLMSlot1.Checked = My.Settings.LM_SLOT1_ENABLE_HEADERMAGIC
        AppOption_LMslot1_Name.Text = My.Settings.LM_SLOT1_NAME
        AppOption_LMslot1_Version.SelectedIndex = My.Settings.LM_SLOT1_VERSION
        AppOption_LMslot1_Path.Text = My.Settings.LM_SLOT1_PATH

        ' Lunar Magic - Slot 2
        AppOption_EnableLMSlot2.Checked = My.Settings.LM_SLOT2_ENABLED
        AppOption_EnableHeaderMagicLMSlot2.Checked = My.Settings.LM_SLOT2_ENABLE_HEADERMAGIC
        AppOption_LMslot2_Name.Text = My.Settings.LM_SLOT2_NAME
        AppOption_LMslot2_Version.SelectedIndex = My.Settings.LM_SLOT2_VERSION
        AppOption_LMslot2_Path.Text = My.Settings.LM_SLOT2_PATH

        ' Lunar Magic - Slot 3
        AppOption_EnableLMSlot3.Checked = My.Settings.LM_SLOT3_ENABLED
        AppOption_EnableHeaderMagicLMSlot3.Checked = My.Settings.LM_SLOT3_ENABLE_HEADERMAGIC
        AppOption_LMslot3_Name.Text = My.Settings.LM_SLOT3_NAME
        AppOption_LMslot3_Version.SelectedIndex = My.Settings.LM_SLOT3_VERSION
        AppOption_LMslot3_Path.Text = My.Settings.LM_SLOT3_PATH

        ' Lunar Magic - 1 Click to Launch
        AppOption_EnableLM1CTL.Checked = My.Settings.LM_1CTL_ENABLED
        AppOption_LM1CTL_DisplaySelectorOnCTRLClick.Checked = My.Settings.LM_1CTL_SHOW_SELECTOR_ON_CTRLCLICK
        AppOption_LM1CTL_VersionSelector.SelectedIndex = My.Settings.LM_1CTL_SELECTED_VERSION

        ' Emulator selection
        AppOption_SnesEmuSelector.SelectedIndex = My.Settings.SNES_SELECTED_EMULATOR

        ' Snes9x options
        AppOption_Snes9x_x86Executable.Text = My.Settings.SNES9x_PATH_x86
        AppOption_Snes9x_x64Executable.Text = My.Settings.SNES9x_PATH_x64
        AppOption_Snes9x_SelectedArch.SelectedIndex = My.Settings.SNES9x_SELECTED_ARCH
        AppOption_Snes9x_UseColoredIcon.Checked = My.Settings.SNES9x_USE_COLORED_ICON

        ' Bsnes options
        AppOption_BsnesExecutable.Text = My.Settings.BSNES_PATH_x64

        ' Smallhacker's Tools
        AppOption_DisplayBtn_ILBPE.Checked = My.Settings.DISPLAYBTN_ILBPE
        AppOption_DisplayBtn_SMWBBPE.Checked = My.Settings.DISPLAYBTN_SMWBBPE
        AppOption_DisplayBtn_SMWENI.Checked = My.Settings.DISPLAYBTN_SMWENI
        AppOption_DisplayBtn_SMWENE.Checked = My.Settings.DISPLAYBTN_SMWENE
        AppOption_DisplayBtn_SMWMTE.Checked = My.Settings.DISPLAYBTN_SMWMTE
        AppOption_DisplayBtn_SMWPTE.Checked = My.Settings.DISPLAYBTN_SMWPTE
        AppOption_DisplayBtn_SMWSBE.Checked = My.Settings.DISPLAYBTN_SMWSBE
        AppOption_DisplayBtn_SMWTYMI.Checked = My.Settings.DISPLAYBTN_SMWTYMI

        AppOption_ILBPE_Path.Text = My.Settings.SH_ILBPE_PATH
        AppOption_SMWBBPE_Path.Text = My.Settings.SH_SMWBBPE_PATH
        AppOption_SMWENI_Path.Text = My.Settings.SH_SMWENI_PATH
        AppOption_SMWENE_Path.Text = My.Settings.SH_SMWENE_PATH
        AppOption_SMWMTE_Path.Text = My.Settings.SH_SMWMTE_PATH
        AppOption_SMWPTE_Path.Text = My.Settings.SH_SMWPTE_PATH
        AppOption_SMWSBE_Path.Text = My.Settings.SH_SMWSBE_PATH
        AppOption_SMWTYMI_Path.Text = My.Settings.SH_SMWTYMI_PATH

        ' Other 1
        AppOption_LunarExpand_Path.Text = My.Settings.LUNAREXPAND_PATH
        AppOption_RecoverLM_Path.Text = My.Settings.RECOVERLM_PATH
        AppOption_SnesGFX_Path.Text = My.Settings.SNESGFX_PATH
        AppOption_MarioLuigiLPE_Path.Text = My.Settings.MARIOLLPE_PATH
        AppOption_HeAdder_Path.Text = My.Settings.HEADDER_PATH
        AppOption_HdmaGR_Path.Text = My.Settings.HDMA_GRAD_RIPPER_PATH
        AppOption_MMLEdit_Path.Text = My.Settings.MMLEDIT_PATH
        AppOption_AMK_CMD_Path.Text = My.Settings.ADDMUSICK_CMD_PATH
        AppOption_AMK_GUI_Path.Text = My.Settings.ADDMUSICK_GUI_PATH
        AppOption_LvMusUtil_Path.Text = My.Settings.LVMUSUTIL_PATH
        AppOption_BRRPlayer_Path.Text = My.Settings.BRRPLAYER_PATH

        ' Other 2
        AppOption_Blockreator_Path.Text = My.Settings.BLOCKREATOR_PATH
        AppOption_Pixi_Path.Text = My.Settings.PIXI_MAIN_PATH
        AppOption_PixiConfigurator_Path.Text = My.Settings.PIXI_CONFIG_PATH
        AppOption_M7Map_Path.Text = My.Settings.M7MAP_PATH
        AppOption_SPC700Player_Path.Text = My.Settings.SPC700PLAYER_PATH
        AppOption_FloatingIPS_Path.Text = My.Settings.FLOATINGIPS_PATH
        AppOption_StatusEffects_Path.Text = My.Settings.STATUSEFFECTS_PATH
        AppOption_SnesColorTool_Path.Text = My.Settings.SNESCOLORTOOL_PATH
        AppOption_EffectTool_Path.Text = My.Settings.EFFECTTOOL_PATH
        AppOption_GPS_Path.Text = My.Settings.GOPHERPOPCORNSTEW_PATH
        AppOption_PetiteMM_Path.Text = My.Settings.PETITEMM_PATH

        ' Other 3
        AppOption_Asar_Path.Text = My.Settings.ASAR_PATH
        AppOption_MarioSE_Path.Text = My.Settings.MARIOSTARTEDITOR_PATH
        AppOption_InteractionEditor_Path.Text = My.Settings.INTERACTIONEDITOR_PATH
        AppOption_MultipleMidwayPoints_Path.Text = My.Settings.MULTIPLEMIDWAYPOINTS_PATH
        AppOption_SpriteGFX_Path.Text = My.Settings.SPRITEGFXCREATOR_PATH
        AppOption_GraphicEditor_Path.Text = My.Settings.GRAPHICEDITOR_PATH
        AppOption_YYCHR_Path.Text = My.Settings.YYCHR_PATH
        AppOption_SMWCustomizer_Path.Text = My.Settings.SMWCUSTOMIZER_PATH
        AppOption_UberASM_Path.Text = My.Settings.UBERASM_PATH
        AppOption_GradientTool_Path.Text = My.Settings.GRADIENTTOOL_PATH

    End Sub

    ' Buttons
    Private Sub UI_Btn_OK_Click(sender As Object, e As EventArgs) Handles UI_Btn_OK.Click

        ' ----- APPEARANCE TAB -----

        ' Application look
        My.Settings.DWM_EXTENSION = AppOption_DWMExtension.Checked
        My.Settings.WIN_CLASSIC_ENHANCEMENTS = AppOption_WinClassicEnhancements.Checked

        My.Settings.UI_DARK_MODE = AppOption_DarkThemeToggle.Checked

        ' Appearance tweaks
        My.Settings.LOCK_AT_TOPMOST = AppOption_LockAtTopMost.Checked

        My.Settings.HIDE_TITLE = AppOption_HideTitle.Checked
        My.Settings.HIDE_ICON = AppOption_HideIcon.Checked
        My.Settings.BLANK_ICON = AppOption_ShowBlankIcon.Checked

        My.Settings.ADDITIONAL_TITLE_TEXT = AppOption_CustomTitleText.Checked
        My.Settings.ADDITIONAL_TITLE_TEXT_TYPE = AppOption_AdditionalTitleTextType.SelectedIndex
        My.Settings.CUSTOM_TITLE_TEXT = AppOption_TitleCustomText.Text

        ' Application Opacity
        My.Settings.APP_OPACITY_TOGGLE = AppOption_AppOpacity.Checked
        My.Settings.APP_OPACITY_APPLY_MODE = AppOption_AppOpacityApplyMode.SelectedIndex
        My.Settings.APP_OPACITY = AppOption_OpacityValue.Value

        ' Theme
        My.Settings.SELECTED_THEME = AppOption_Theme.SelectedIndex

        ' ----- ICONS AND BUTTONS TAB -----

        ' Windows Version Button Icon
        My.Settings.WINVER_ICON = AppOption_WinverIcon.SelectedIndex
        My.Settings.WINVER_USE_CURRENT_OS_ICON = AppOption_WinverIconBasedOnCurrentOS.Checked

        ' Task Manager Button Icon
        My.Settings.TASKMGR_ICON_LINE = AppOption_TaskmgrIconLineColor.SelectedIndex
        My.Settings.TASKMGR_ICON_BACK = AppOption_TaskmgrIconBackColor.SelectedIndex
        My.Settings.TASKMGR_USE_WINDOWS_ICON = AppOption_TaskmgrIconBasedOnCurrentOS.Checked

        ' Bottom bar buttons options
        My.Settings.SHOW_HELP_BTN = AppOption_DisplayHelpButton.Checked
        My.Settings.SHOW_SUGGESTUPDATE_BTN = AppOption_DisplaySuggestUpdateButton.Checked
        My.Settings.SHOW_REPORTCRASH_BTN = AppOption_DisplayReportCrashButton.Checked
        My.Settings.SHOW_WINVER_BTN = AppOption_DisplayWinverButton.Checked
        My.Settings.BUILT_IN_WINVER = AppOption_BuiltInWinver.Checked
        My.Settings.SHOW_TASKMGR_BTN = AppOption_DisplayTaskmgrButton.Checked
        My.Settings.USE_SHELL32_ABOUTBOX = AppOption_UseShell32About.Checked

        My.Settings.HIDE_ALL_BOTTOM_BUTTONS = AppOption_HideBottomBtns.Checked
        My.Settings.SHOW_BTN_SEPARATORS = AppOption_BtmBarSeparators.Checked

        ' ----- LAUNCHER TAB -----

        ' Main window
        My.Settings.DISPLAY_COMPLETEVERSION_IN_MAIN_WINDOW = AppOption_DisplayCompleteVersionOnMainWindow.Checked

        My.Settings.MAINWINDOW_DISPLAYED_COLUMN_NBR = AppOption_ColumnsNumberComboBox.SelectedIndex

        My.Settings.DISPLAYBTN_LUNARMAGIC = AppOption_DisplayBtn_LunarMagic.Checked
        My.Settings.DISPLAYBTN_LUNAREXPAND = AppOption_DisplayBtn_LunarExpand.Checked
        My.Settings.DISPLAYBTN_RECOVERLM = AppOption_DisplayBtn_RecoverLM.Checked
        My.Settings.DISPLAYBTN_SNESGFX = AppOption_DisplayBtn_SnesGFX.Checked
        My.Settings.DISPLAYBTN_MARIOLPE = AppOption_DisplayBtn_MarioLPE.Checked
        My.Settings.DISPLAYBTN_HEADDER = AppOption_DisplayBtn_HeAdder.Checked
        My.Settings.DISPLAYBTN_HDMARIPPER = AppOption_DisplayBtn_HDMARipper.Checked
        My.Settings.DISPLAYBTN_MMLEDIT = AppOption_DisplayBtn_MMLEdit.Checked
        My.Settings.DISPLAYBTN_ADDMUSICK = AppOption_DisplayBtn_AddMusicK.Checked
        My.Settings.DISPLAYBTN_LVMUSUTIL = AppOption_DisplayBtn_LvMusUtil.Checked
        My.Settings.DISPLAYBTN_BRRPLAYER = AppOption_DisplayBtn_BRRPlayer.Checked
        My.Settings.DISPLAYBTN_BLOCKREATOR = AppOption_DisplayBtn_Blockreator.Checked
        My.Settings.DISPLAYBTN_PIXI = AppOption_DisplayBtn_Pixi.Checked
        My.Settings.DISPLAYBTN_MODE7TILEMAP = AppOption_DisplayBtn_Mode7Tilemap.Checked
        My.Settings.DISPLAYBTN_SPC700PLAYER = AppOption_DisplayBtn_SPC700Player.Checked
        My.Settings.DISPLAYBTN_FLIPS = AppOption_DisplayBtn_Flips.Checked
        My.Settings.DISPLAYBTN_STATUSEFFECTS = AppOption_DisplayBtn_StatusEffects.Checked
        My.Settings.DISPLAYBTN_SNESCOLORTOOL = AppOption_DisplayBtn_SPCTool.Checked
        My.Settings.DISPLAYBTN_EFFECTTOOLS = AppOption_DisplayBtn_EffectTools.Checked
        My.Settings.DISPLAYBTN_GOPHERPOPCORNSTEW = AppOption_DisplayBtn_GopherPopcornStew.Checked
        My.Settings.DISPLAYBTN_PETITEMM = AppOption_DisplayBtn_PetiteMM.Checked
        My.Settings.DISPLAYBTN_ASAR = AppOption_DisplayBtn_Asar.Checked
        My.Settings.DISPLAYBTN_SNES_EMU = AppOption_DisplayBtn_Snes9x.Checked
        My.Settings.DISPLAYBTN_MARIOSTARTEDITOR = AppOption_DisplayBtn_MarioStartEditor.Checked
        My.Settings.DISPLAYBTN_INTERACTIONEDIT = AppOption_DisplayBtn_InteractionEdit.Checked
        My.Settings.DISPLAYBTN_MULTIPLEMIDWAYPOINTS = AppOption_DisplayBtn_MultipleMidwayPoints.Checked
        My.Settings.DISPLAYBTN_SPRITEGFX = AppOption_DisplayBtn_SpriteGFX.Checked
        My.Settings.DISPLAYBTN_GRAPHEDIT = AppOption_DisplayBtn_GraphEdit.Checked
        My.Settings.DISPLAYBTN_YYCHR = AppOption_DisplayBtn_YYCHR.Checked
        My.Settings.DISPLAYBTN_SMWCUST = AppOption_DisplayBtn_SMWCust.Checked
        My.Settings.DISPLAYBTN_SHTOOLS = AppOption_DisplayBtn_SHTools.Checked
        My.Settings.DISPLAYBTN_UBERASM = AppOption_DisplayBtn_UberASM.Checked
        My.Settings.DISPLAYBTN_GRADIENTTOOL = AppOption_DisplayBtn_GradientTool.Checked

        ' About box
        My.Settings.SHOW_LEGACYABOUTBTN = AppOption_EnableLegacyAboutBox.Checked
        My.Settings.SHOW_APP_VERSION_STRING = AppOption_HideVersionStringInAboutBox.Checked

        ' Application integration in Windows
        My.Settings.SHOW_TRAY_ICON = AppOption_ShowSystrayIcon.Checked

        ' Keyboard shortcuts
        My.Settings.KEYBOARD_SCT_ABOUTDIALOG = AppOption_OpenAboutDialogKeyboardShortcut.Checked
        My.Settings.KEYBOARD_SCT_HELP = AppOption_OpenHelpKeyboardShortcut.Checked
        My.Settings.KEYBOARD_SCT_SUGGESTUPDATE = AppOption_OpenSuggestUpdateKeyboardShortcut.Checked
        My.Settings.KEYBOARD_SCT_SETTINGS = AppOption_OpenSettingsKeyboardShortcut.Checked

        My.Settings.KEYBOARD_SCT_RESTART = AppOption_QuickRestartKeyboardShortcut.Checked
        My.Settings.KEYBOARD_SCT_CUSTOMSHORTCUTS = AppOption_CustomShortcutsKeyboardShortcut.Checked

        ' ----- CUSTOM SHORTCUTS TAB -----

        ' General
        My.Settings.ENABLE_CUSTOM_SHORTCUTS = AppOption_EnableCustomShortcuts.Checked

        ' Shortcut 1
        My.Settings.ENABLE_CUSTOM_SHORTCUT_1 = AppOption_EnableCustomShortcut_1.Checked
        My.Settings.CUSTOM_SHORTCUT_1_PATH = AppOption_Shortcut1_Path.Text
        My.Settings.CUSTOM_SHORTCUT_1_LAUNCH_WITH = AppOption_Shortcut1_LaunchWith.SelectedIndex
        My.Settings.CUSTOM_SHORTCUT_1_ICON = AppOption_Shortcut1_Icon.SelectedIndex

        ' Shortcut 2
        My.Settings.ENABLE_CUSTOM_SHORTCUT_2 = AppOption_EnableCustomShortcut_2.Checked
        My.Settings.CUSTOM_SHORTCUT_2_PATH = AppOption_Shortcut2_Path.Text
        My.Settings.CUSTOM_SHORTCUT_2_LAUNCH_WITH = AppOption_Shortcut2_LaunchWith.SelectedIndex
        My.Settings.CUSTOM_SHORTCUT_2_ICON = AppOption_Shortcut2_Icon.SelectedIndex

        ' Shortcut 3
        My.Settings.ENABLE_CUSTOM_SHORTCUT_3 = AppOption_EnableCustomShortcut_3.Checked
        My.Settings.CUSTOM_SHORTCUT_3_PATH = AppOption_Shortcut3_Path.Text
        My.Settings.CUSTOM_SHORTCUT_3_LAUNCH_WITH = AppOption_Shortcut3_LaunchWith.SelectedIndex
        My.Settings.CUSTOM_SHORTCUT_3_ICON = AppOption_Shortcut3_Icon.SelectedIndex

        ' Shortcut 4
        My.Settings.ENABLE_CUSTOM_SHORTCUT_4 = AppOption_EnableCustomShortcut_4.Checked
        My.Settings.CUSTOM_SHORTCUT_4_PATH = AppOption_Shortcut4_Path.Text
        My.Settings.CUSTOM_SHORTCUT_4_LAUNCH_WITH = AppOption_Shortcut4_LaunchWith.SelectedIndex
        My.Settings.CUSTOM_SHORTCUT_4_ICON = AppOption_Shortcut4_Icon.SelectedIndex

        ' Shortcut 5
        My.Settings.ENABLE_CUSTOM_SHORTCUT_5 = AppOption_EnableCustomShortcut_5.Checked
        My.Settings.CUSTOM_SHORTCUT_5_PATH = AppOption_Shortcut5_Path.Text
        My.Settings.CUSTOM_SHORTCUT_5_LAUNCH_WITH = AppOption_Shortcut5_LaunchWith.SelectedIndex
        My.Settings.CUSTOM_SHORTCUT_5_ICON = AppOption_Shortcut5_Icon.SelectedIndex

        ' Shortcut 6
        My.Settings.ENABLE_CUSTOM_SHORTCUT_6 = AppOption_EnableCustomShortcut_6.Checked
        My.Settings.CUSTOM_SHORTCUT_6_PATH = AppOption_Shortcut6_Path.Text
        My.Settings.CUSTOM_SHORTCUT_6_LAUNCH_WITH = AppOption_Shortcut6_LaunchWith.SelectedIndex
        My.Settings.CUSTOM_SHORTCUT_6_ICON = AppOption_Shortcut6_Icon.SelectedIndex

        ' ----- UPDATES TAB -----

        ' At startup
        My.Settings.UPDATE_SEARCH_AT_STARTUP = AppOption_SearchUpdateAtAppStart.Checked
        My.Settings.UPDATE_SEARCH_AT_STARTUP_DISCRETE_MODE = AppOption_UpdateAtStartup_DiscreteMode.Checked
        My.Settings.USE_LEGACY_UPDATE_POPUPS = AppOption_UseLegacyUpdatePopups.Checked

        ' "About SMWMTL" window
        My.Settings.ENABLE_UPDATE_INDICATOR_ON_ABOUT_WINDOW = AppOption_DisplayUpdateSearchModuleOnAboutWindow.Checked
        My.Settings.SHOW_UPDATE_SYSTEM_INFOS_ON_ABOUT_SCREEN = AppOption_DisplayUpdateSearchVersionOnAboutWindow.Checked

        ' "SMWMTL_Update" window
        My.Settings.UPDATE_AUTOMATIC_DOWNLOAD = AppOption_UpdateAutomaticDownload.Checked
        My.Settings.UPDATE_AUTOMATIC_INSTALLATION = AppOption_UpdateAutomaticInstall.Checked
        My.Settings.UPDATE_AUTOMATIC_INSTALLATION_SILENT_MODE = AppOption_UpdateAutomaticInstallSilentMode.Checked

        ' ----- APPLICATIONS TAB -----

        ' Lunar Magic - Slot 1
        My.Settings.LM_SLOT1_ENABLED = AppOption_EnableLMSlot1.Checked
        My.Settings.LM_SLOT1_ENABLE_HEADERMAGIC = AppOption_EnableHeaderMagicLMSlot1.Checked
        My.Settings.LM_SLOT1_NAME = AppOption_LMslot1_Name.Text
        My.Settings.LM_SLOT1_VERSION = AppOption_LMslot1_Version.SelectedIndex
        My.Settings.LM_SLOT1_PATH = AppOption_LMslot1_Path.Text

        ' Lunar Magic - Slot 2
        My.Settings.LM_SLOT2_ENABLED = AppOption_EnableLMSlot2.Checked
        My.Settings.LM_SLOT2_ENABLE_HEADERMAGIC = AppOption_EnableHeaderMagicLMSlot2.Checked
        My.Settings.LM_SLOT2_NAME = AppOption_LMslot2_Name.Text
        My.Settings.LM_SLOT2_VERSION = AppOption_LMslot2_Version.SelectedIndex
        My.Settings.LM_SLOT2_PATH = AppOption_LMslot2_Path.Text

        ' Lunar Magic - Slot 3
        My.Settings.LM_SLOT3_ENABLED = AppOption_EnableLMSlot3.Checked
        My.Settings.LM_SLOT3_ENABLE_HEADERMAGIC = AppOption_EnableHeaderMagicLMSlot3.Checked
        My.Settings.LM_SLOT3_NAME = AppOption_LMslot3_Name.Text
        My.Settings.LM_SLOT3_VERSION = AppOption_LMslot3_Version.SelectedIndex
        My.Settings.LM_SLOT3_PATH = AppOption_LMslot3_Path.Text

        ' Lunar Magic - 1 Click to Launch
        My.Settings.LM_1CTL_ENABLED = AppOption_EnableLM1CTL.Checked
        My.Settings.LM_1CTL_SHOW_SELECTOR_ON_CTRLCLICK = AppOption_LM1CTL_DisplaySelectorOnCTRLClick.Checked
        My.Settings.LM_1CTL_SELECTED_VERSION = AppOption_LM1CTL_VersionSelector.SelectedIndex

        ' Emulator selection
        My.Settings.SNES_SELECTED_EMULATOR = AppOption_SnesEmuSelector.SelectedIndex

        ' Snes9x options
        My.Settings.SNES9x_PATH_x86 = AppOption_Snes9x_x86Executable.Text
        My.Settings.SNES9x_PATH_x64 = AppOption_Snes9x_x64Executable.Text
        My.Settings.SNES9x_SELECTED_ARCH = AppOption_Snes9x_SelectedArch.SelectedIndex
        My.Settings.SNES9x_USE_COLORED_ICON = AppOption_Snes9x_UseColoredIcon.Checked

        ' Bsnes options
        My.Settings.BSNES_PATH_x64 = AppOption_BsnesExecutable.Text

        ' Smallhacker's Tools
        My.Settings.DISPLAYBTN_ILBPE = AppOption_DisplayBtn_ILBPE.Checked
        My.Settings.DISPLAYBTN_SMWBBPE = AppOption_DisplayBtn_SMWBBPE.Checked
        My.Settings.DISPLAYBTN_SMWENI = AppOption_DisplayBtn_SMWENI.Checked
        My.Settings.DISPLAYBTN_SMWENE = AppOption_DisplayBtn_SMWENE.Checked
        My.Settings.DISPLAYBTN_SMWMTE = AppOption_DisplayBtn_SMWMTE.Checked
        My.Settings.DISPLAYBTN_SMWPTE = AppOption_DisplayBtn_SMWPTE.Checked
        My.Settings.DISPLAYBTN_SMWSBE = AppOption_DisplayBtn_SMWSBE.Checked
        My.Settings.DISPLAYBTN_SMWTYMI = AppOption_DisplayBtn_SMWTYMI.Checked

        My.Settings.SH_ILBPE_PATH = AppOption_ILBPE_Path.Text
        My.Settings.SH_SMWBBPE_PATH = AppOption_SMWBBPE_Path.Text
        My.Settings.SH_SMWENI_PATH = AppOption_SMWENI_Path.Text
        My.Settings.SH_SMWENE_PATH = AppOption_SMWENE_Path.Text
        My.Settings.SH_SMWMTE_PATH = AppOption_SMWMTE_Path.Text
        My.Settings.SH_SMWPTE_PATH = AppOption_SMWPTE_Path.Text
        My.Settings.SH_SMWSBE_PATH = AppOption_SMWSBE_Path.Text
        My.Settings.SH_SMWTYMI_PATH = AppOption_SMWTYMI_Path.Text

        ' Other 1
        My.Settings.LUNAREXPAND_PATH = AppOption_LunarExpand_Path.Text
        My.Settings.RECOVERLM_PATH = AppOption_RecoverLM_Path.Text
        My.Settings.SNESGFX_PATH = AppOption_SnesGFX_Path.Text
        My.Settings.MARIOLLPE_PATH = AppOption_MarioLuigiLPE_Path.Text
        My.Settings.HEADDER_PATH = AppOption_HeAdder_Path.Text
        My.Settings.HDMA_GRAD_RIPPER_PATH = AppOption_HdmaGR_Path.Text
        My.Settings.MMLEDIT_PATH = AppOption_MMLEdit_Path.Text
        My.Settings.ADDMUSICK_CMD_PATH = AppOption_AMK_CMD_Path.Text
        My.Settings.ADDMUSICK_GUI_PATH = AppOption_AMK_GUI_Path.Text
        My.Settings.LVMUSUTIL_PATH = AppOption_LvMusUtil_Path.Text
        My.Settings.BRRPLAYER_PATH = AppOption_BRRPlayer_Path.Text

        ' Other 2
        My.Settings.BLOCKREATOR_PATH = AppOption_Blockreator_Path.Text
        My.Settings.PIXI_MAIN_PATH = AppOption_Pixi_Path.Text
        My.Settings.PIXI_CONFIG_PATH = AppOption_PixiConfigurator_Path.Text
        My.Settings.M7MAP_PATH = AppOption_M7Map_Path.Text
        My.Settings.SPC700PLAYER_PATH = AppOption_SPC700Player_Path.Text
        My.Settings.FLOATINGIPS_PATH = AppOption_FloatingIPS_Path.Text
        My.Settings.STATUSEFFECTS_PATH = AppOption_StatusEffects_Path.Text
        My.Settings.SNESCOLORTOOL_PATH = AppOption_SnesColorTool_Path.Text
        My.Settings.EFFECTTOOL_PATH = AppOption_EffectTool_Path.Text
        My.Settings.GOPHERPOPCORNSTEW_PATH = AppOption_GPS_Path.Text
        My.Settings.PETITEMM_PATH = AppOption_PetiteMM_Path.Text

        ' Other 3
        My.Settings.ASAR_PATH = AppOption_Asar_Path.Text
        My.Settings.MARIOSTARTEDITOR_PATH = AppOption_MarioSE_Path.Text
        My.Settings.INTERACTIONEDITOR_PATH = AppOption_InteractionEditor_Path.Text
        My.Settings.MULTIPLEMIDWAYPOINTS_PATH = AppOption_MultipleMidwayPoints_Path.Text
        My.Settings.SPRITEGFXCREATOR_PATH = AppOption_SpriteGFX_Path.Text
        My.Settings.GRAPHICEDITOR_PATH = AppOption_GraphicEditor_Path.Text
        My.Settings.YYCHR_PATH = AppOption_YYCHR_Path.Text
        My.Settings.SMWCUSTOMIZER_PATH = AppOption_SMWCustomizer_Path.Text
        My.Settings.UBERASM_PATH = AppOption_UberASM_Path.Text
        My.Settings.GRADIENTTOOL_PATH = AppOption_GradientTool_Path.Text

        ' Save Settings
        My.Settings.Save()

        ' Confirmation message and application restart
        MessageBox.Show(Frm99_TranslateForm.UI03_SettingsAppliedDesc.Text, Frm99_TranslateForm.UI03_SettingsAppliedTitle.Text, CType(MsgBoxStyle.OkOnly, MessageBoxButtons), MessageBoxIcon.Information)
        Application.Restart()

    End Sub
    Private Sub UI_Btn_Cancel_Click(sender As Object, e As EventArgs) Handles UI_Btn_Cancel.Click
        Close()
    End Sub
    Private Sub UI_Btn_UpdatesModal_Click(sender As Object, e As EventArgs) Handles UI_Btn_UpdatesModal.Click
        Frm04_UpdatesModal.ShowDialog()
    End Sub
    Private Sub UI_Btn_ExperimentalSettings_Click(sender As Object, e As EventArgs) Handles UI_Btn_ExperimentalSettings.Click
        Dim f As New Frm96_HiddenFeatures
        f.ShowDialog()
    End Sub

    ' Links
    Private Sub AppOption_CustomTextFormattingCodes_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_CustomTextFormattingCodes.LinkClicked
        MsgBox(Frm99_TranslateForm.UI03_FormattingCodes.Text, , AppOption_CustomTextFormattingCodes.Text)
    End Sub


    ' Additional code for UI updates

    ' Hide Window Icon
    Private Sub AppOption_HideIcon_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_HideIcon.CheckedChanged
        Select Case AppOption_HideIcon.Checked
            Case True
                AppOption_ShowBlankIcon.Enabled = True
                UI_Tab01_Cat02_UnderOption01.Image = My.Resources.CbxUnderOption

            Case False
                AppOption_ShowBlankIcon.Enabled = False
                UI_Tab01_Cat02_UnderOption01.Image = My.Resources.CbxUnderOptionUnavailable

        End Select
    End Sub

    ' Hide Window Icon
    Private Sub AppOption_CustomTitleText_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_CustomTitleText.CheckedChanged
        Select Case AppOption_CustomTitleText.Checked
            Case True
                AppOption_AdditionalTitleTextType.Enabled = True

                Select Case AppOption_AdditionalTitleTextType.SelectedIndex = 2
                    Case True
                        AppOption_TitleCustomText.Enabled = True

                    Case False
                        AppOption_TitleCustomText.Enabled = False

                End Select

            Case False
                AppOption_AdditionalTitleTextType.Enabled = False
                AppOption_TitleCustomText.Enabled = False

        End Select
    End Sub

    ' Custom Window Title text - Selector
    Private Sub AppOption_AdditionalTitleTextType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AppOption_AdditionalTitleTextType.SelectedIndexChanged
        Select Case AppOption_AdditionalTitleTextType.SelectedIndex = 2
            Case True
                AppOption_TitleCustomText.Enabled = True

            Case False
                AppOption_TitleCustomText.Enabled = False

        End Select
    End Sub

    ' Custom text character counter
    Private Sub AppOption_TitleCustomText_TextChanged(sender As Object, e As EventArgs) Handles AppOption_TitleCustomText.TextChanged
        ChrCount01.Text = $"{AppOption_TitleCustomText.Text.Length}/{AppOption_TitleCustomText.MaxLength}"
    End Sub

    ' Application Opacity
    Private Sub AppOption_AppOpacity_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_AppOpacity.CheckedChanged
        AppOption_AppOpacityApplyMode.Enabled = AppOption_AppOpacity.Checked
        AppOption_OpacityValue.Enabled = AppOption_AppOpacity.Checked
    End Sub

    ' Opacity percentage value
    Private Sub AppOption_OpacityValue_ValueChanged(sender As Object, e As EventArgs) Handles AppOption_OpacityValue.ValueChanged
        AppOption_OpacityPercentage.Text = $"{AppOption_OpacityValue.Value} %"
    End Sub

    ' Winver button Icon
    Private Sub AppOption_WinverIcon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AppOption_WinverIcon.SelectedIndexChanged
#Region "        Winver Icon - Selector "

        Select Case AppOption_WinverIcon.SelectedIndex
            Case 0
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_ReactOS

            Case 1
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Ubuntu

            Case 2
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Debian

            Case 3
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Apple

            Case 4
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win1x2x

            Case 5
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win3xNT4

            Case 6
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win9x2000

            Case 7
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinME

            Case 8
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinWhistler

            Case 9
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinXP

            Case 10
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinXP_MCE

            Case 11
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinLonghorn

            Case 12
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinVista

            Case 13
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinLive

            Case 14
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinMC

            Case 15
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win7

            Case 16
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win7Flat

            Case 17
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win8

            Case 18
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win8Colored

            Case 19
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win10

            Case 20
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win10X

            Case 21
                WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win11

        End Select

#End Region
    End Sub
    Private Sub AppOption_WinverIconBasedOnCurrentOS_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_WinverIconBasedOnCurrentOS.CheckedChanged
        Select Case AppOption_WinverIconBasedOnCurrentOS.Checked
            Case True
                Select Case Win_NT_Version
                    Case "6.0"
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinVista

                    Case "6.1"
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win7

                    Case "6.2", "6.3"
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win8

                    Case "10.0"
                        WinverIcon_Preview.Image = If(Win_BuildNbr >= "21800", My.Resources.Winver_LogoL_Win11, My.Resources.Winver_LogoL_Win10)

                End Select

            Case False
#Region "                Set icon selected from the combobox "

                Select Case AppOption_WinverIcon.SelectedIndex
                    Case 0
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_ReactOS

                    Case 1
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Ubuntu

                    Case 2
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Debian

                    Case 3
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Apple

                    Case 4
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win1x2x

                    Case 5
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win3xNT4

                    Case 6
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win9x2000

                    Case 7
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinME

                    Case 8
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinWhistler

                    Case 9
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinXP

                    Case 10
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinXP_MCE

                    Case 11
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinLonghorn

                    Case 12
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinVista

                    Case 13
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinLive

                    Case 14
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_WinMC

                    Case 15
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win7

                    Case 16
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win7Flat

                    Case 17
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win8

                    Case 18
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win8Colored

                    Case 19
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win10

                    Case 20
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win10X

                    Case 21
                        WinverIcon_Preview.Image = My.Resources.Winver_LogoL_Win11

                End Select

#End Region

        End Select
    End Sub

    ' Task Manager button Icon
    Private Sub AppOption_TaskmgrIconLineColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AppOption_TaskmgrIconLineColor.SelectedIndexChanged
#Region "        Taskmgr Icon - Line color Selector "
        Select Case AppOption_TaskmgrIconLineColor.SelectedIndex
            Case 0
                Select Case AppOption_TaskmgrIconBackColor.SelectedIndex
                    Case 0
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DRed32

                    Case 1
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LRed32

                End Select

            Case 1
                Select Case AppOption_TaskmgrIconBackColor.SelectedIndex
                    Case 0
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DGreen32

                    Case 1
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LGreen32

                End Select

            Case 2
                Select Case AppOption_TaskmgrIconBackColor.SelectedIndex
                    Case 0
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DBlue32

                    Case 1
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LBlue32

                End Select

            Case 3
                Select Case AppOption_TaskmgrIconBackColor.SelectedIndex
                    Case 0
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DPurple32

                    Case 1
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LPurple32

                End Select

            Case 4
                Select Case AppOption_TaskmgrIconBackColor.SelectedIndex
                    Case 0
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DYellow32

                    Case 1
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LYellow32

                End Select

            Case 5
                Select Case AppOption_TaskmgrIconBackColor.SelectedIndex
                    Case 0
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DOrange32

                    Case 1
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LOrange32

                End Select

            Case 6
                Select Case AppOption_TaskmgrIconBackColor.SelectedIndex
                    Case 0
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DPink32

                    Case 1
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LPink32

                End Select

            Case 7
                Select Case AppOption_TaskmgrIconBackColor.SelectedIndex
                    Case 0
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DBrown32

                    Case 1
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LBrown32

                End Select

            Case 8
                Select Case AppOption_TaskmgrIconBackColor.SelectedIndex
                    Case 0
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DGray32

                    Case 1
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LGray32

                End Select

            Case 9
                Select Case AppOption_TaskmgrIconBackColor.SelectedIndex
                    Case 0
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DWhite32

                    Case 1
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LWhite32

                End Select

        End Select
#End Region
    End Sub
    Private Sub AppOption_TaskmgrIconBackColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AppOption_TaskmgrIconBackColor.SelectedIndexChanged
#Region "        Taskmgr Icon - Back color Selector "
        Select Case AppOption_TaskmgrIconBackColor.SelectedIndex
            Case 0
                Select Case AppOption_TaskmgrIconLineColor.SelectedIndex
                    Case 0
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DRed32

                    Case 1
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DGreen32

                    Case 2
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DBlue32

                    Case 3
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DPurple32

                    Case 4
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DYellow32

                    Case 5
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DOrange32

                    Case 6
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DPink32

                    Case 7
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DBrown32

                    Case 8
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DGray32

                    Case 9
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DWhite32

                End Select

            Case 1
                Select Case AppOption_TaskmgrIconLineColor.SelectedIndex
                    Case 0
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LRed32

                    Case 1
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LGreen32

                    Case 2
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LBlue32

                    Case 3
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LPurple32

                    Case 4
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LYellow32

                    Case 5
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LOrange32

                    Case 6
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LPink32

                    Case 7
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LBrown32

                    Case 8
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LGray32

                    Case 9
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LWhite32

                End Select

        End Select
#End Region
    End Sub
    Private Sub AppOption_TaskmgrIconBasedOnCurrentOS_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_TaskmgrIconBasedOnCurrentOS.CheckedChanged
        Select Case AppOption_TaskmgrIconBasedOnCurrentOS.Checked
            Case True
                Select Case Win_NT_Version
                    Case "6.0", "6.1"
                        TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_WinVista_7_32

                    Case "6.2", "6.3", "10.0"
                        TaskmgrIcon_Preview.Image = If(Win_BuildNbr >= "21800", My.Resources.Taskmgr_Icon_Win11_32, My.Resources.Taskmgr_Icon_Win8_10_32)

                End Select

            Case False
#Region "                Set icon selected from the two comboboxes "
                Select Case AppOption_TaskmgrIconBackColor.SelectedIndex
                    Case 0
                        Select Case AppOption_TaskmgrIconLineColor.SelectedIndex
                            Case 0
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DRed32

                            Case 1
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DGreen32

                            Case 2
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DBlue32

                            Case 3
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DPurple32

                            Case 4
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DYellow32

                            Case 5
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DOrange32

                            Case 6
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DPink32

                            Case 7
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DBrown32

                            Case 8
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DGray32

                            Case 9
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_DWhite32

                        End Select

                    Case 1
                        Select Case AppOption_TaskmgrIconLineColor.SelectedIndex
                            Case 0
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LRed32

                            Case 1
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LGreen32

                            Case 2
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LBlue32

                            Case 3
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LPurple32

                            Case 4
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LYellow32

                            Case 5
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LOrange32

                            Case 6
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LPink32

                            Case 7
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LBrown32

                            Case 8
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LGray32

                            Case 9
                                TaskmgrIcon_Preview.Image = My.Resources.Taskmgr_Icon_LWhite32

                        End Select

                End Select
#End Region

        End Select
    End Sub
    Private Sub BuiltInAboutWindows_Prewiew_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_BuiltInAboutWindows_Prewiew.LinkClicked
        Dim f As New Frm06_OS_Version
        f.ShowDialog()
    End Sub

    ' Displaying main window apps buttons
    Private Sub AppOption_DisplayBtn_CheckAll_Click(sender As Object, e As EventArgs) Handles AppOption_DisplayBtn_CheckAll.Click
        For Each Cbx As CheckBox In {AppOption_DisplayBtn_LunarMagic, AppOption_DisplayBtn_LunarExpand, AppOption_DisplayBtn_RecoverLM, AppOption_DisplayBtn_SnesGFX, AppOption_DisplayBtn_MarioLPE, AppOption_DisplayBtn_HeAdder, AppOption_DisplayBtn_HDMARipper, AppOption_DisplayBtn_MMLEdit, AppOption_DisplayBtn_AddMusicK, AppOption_DisplayBtn_LvMusUtil, AppOption_DisplayBtn_BRRPlayer, AppOption_DisplayBtn_Blockreator, AppOption_DisplayBtn_Pixi, AppOption_DisplayBtn_Mode7Tilemap, AppOption_DisplayBtn_SPC700Player, AppOption_DisplayBtn_Flips, AppOption_DisplayBtn_StatusEffects, AppOption_DisplayBtn_SPCTool, AppOption_DisplayBtn_EffectTools, AppOption_DisplayBtn_GopherPopcornStew, AppOption_DisplayBtn_PetiteMM, AppOption_DisplayBtn_Asar, AppOption_DisplayBtn_Snes9x, AppOption_DisplayBtn_MarioStartEditor, AppOption_DisplayBtn_InteractionEdit, AppOption_DisplayBtn_MultipleMidwayPoints, AppOption_DisplayBtn_SpriteGFX, AppOption_DisplayBtn_GraphEdit, AppOption_DisplayBtn_YYCHR, AppOption_DisplayBtn_SMWCust, AppOption_DisplayBtn_SHTools, AppOption_DisplayBtn_UberASM, AppOption_DisplayBtn_GradientTool}
            Cbx.Checked = True
        Next
    End Sub
    Private Sub AppOption_DisplayBtn_UncheckAll_Click(sender As Object, e As EventArgs) Handles AppOption_DisplayBtn_UncheckAll.Click
        For Each Cbx As CheckBox In {AppOption_DisplayBtn_LunarMagic, AppOption_DisplayBtn_LunarExpand, AppOption_DisplayBtn_RecoverLM, AppOption_DisplayBtn_SnesGFX, AppOption_DisplayBtn_MarioLPE, AppOption_DisplayBtn_HeAdder, AppOption_DisplayBtn_HDMARipper, AppOption_DisplayBtn_MMLEdit, AppOption_DisplayBtn_AddMusicK, AppOption_DisplayBtn_LvMusUtil, AppOption_DisplayBtn_BRRPlayer, AppOption_DisplayBtn_Blockreator, AppOption_DisplayBtn_Pixi, AppOption_DisplayBtn_Mode7Tilemap, AppOption_DisplayBtn_SPC700Player, AppOption_DisplayBtn_Flips, AppOption_DisplayBtn_StatusEffects, AppOption_DisplayBtn_SPCTool, AppOption_DisplayBtn_EffectTools, AppOption_DisplayBtn_GopherPopcornStew, AppOption_DisplayBtn_PetiteMM, AppOption_DisplayBtn_Asar, AppOption_DisplayBtn_Snes9x, AppOption_DisplayBtn_MarioStartEditor, AppOption_DisplayBtn_InteractionEdit, AppOption_DisplayBtn_MultipleMidwayPoints, AppOption_DisplayBtn_SpriteGFX, AppOption_DisplayBtn_GraphEdit, AppOption_DisplayBtn_YYCHR, AppOption_DisplayBtn_SMWCust, AppOption_DisplayBtn_SHTools, AppOption_DisplayBtn_UberASM, AppOption_DisplayBtn_GradientTool}
            Cbx.Checked = False
        Next
    End Sub

    ' Main Custom shortcuts toggle
    Private Sub AppOption_EnableCustomShortcuts_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_EnableCustomShortcuts.CheckedChanged
        For Each GrpBx As GroupBox In {UI_Tab04_Cat02, UI_Tab04_Cat03, UI_Tab04_Cat04, UI_Tab04_Cat05, UI_Tab04_Cat06, UI_Tab04_Cat07}
            GrpBx.Enabled = AppOption_EnableCustomShortcuts.Checked
        Next
    End Sub

    ' Shortcut 1
    Private Sub AppOption_EnableCustomShortcut_1_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_EnableCustomShortcut_1.CheckedChanged
        AppOption_Shortcut1_SelectFile.Enabled = AppOption_EnableCustomShortcut_1.Checked
        AppOption_Shortcut1_Path.Enabled = AppOption_EnableCustomShortcut_1.Checked
        AppOption_Shortcut1_LaunchWith.Enabled = AppOption_EnableCustomShortcut_1.Checked
        AppOption_Shortcut1_Icon.Enabled = AppOption_EnableCustomShortcut_1.Checked
    End Sub
    Private Sub AppOption_Shortcut1_SelectFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_Shortcut1_SelectFile.LinkClicked
        Dim result As DialogResult = SelectFileForShortcut.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_Shortcut1_Path.Text = IO.Path.GetFullPath(SelectFileForShortcut.FileName)
        End If
    End Sub

    ' Shortcut 2
    Private Sub AppOption_EnableCustomShortcut_2_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_EnableCustomShortcut_2.CheckedChanged
        AppOption_Shortcut2_SelectFile.Enabled = AppOption_EnableCustomShortcut_2.Checked
        AppOption_Shortcut2_Path.Enabled = AppOption_EnableCustomShortcut_2.Checked
        AppOption_Shortcut2_LaunchWith.Enabled = AppOption_EnableCustomShortcut_2.Checked
        AppOption_Shortcut2_Icon.Enabled = AppOption_EnableCustomShortcut_2.Checked
    End Sub
    Private Sub AppOption_Shortcut2_SelectFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_Shortcut2_SelectFile.LinkClicked
        Dim result As DialogResult = SelectFileForShortcut.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_Shortcut2_Path.Text = IO.Path.GetFullPath(SelectFileForShortcut.FileName)
        End If
    End Sub

    ' Shortcut 3
    Private Sub AppOption_EnableCustomShortcut_3_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_EnableCustomShortcut_3.CheckedChanged
        AppOption_Shortcut3_SelectFile.Enabled = AppOption_EnableCustomShortcut_3.Checked
        AppOption_Shortcut3_Path.Enabled = AppOption_EnableCustomShortcut_3.Checked
        AppOption_Shortcut3_LaunchWith.Enabled = AppOption_EnableCustomShortcut_3.Checked
        AppOption_Shortcut3_Icon.Enabled = AppOption_EnableCustomShortcut_3.Checked
    End Sub
    Private Sub AppOption_Shortcut3_SelectFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_Shortcut3_SelectFile.LinkClicked
        Dim result As DialogResult = SelectFileForShortcut.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_Shortcut3_Path.Text = IO.Path.GetFullPath(SelectFileForShortcut.FileName)
        End If
    End Sub

    ' Shortcut 4
    Private Sub AppOption_EnableCustomShortcut_4_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_EnableCustomShortcut_4.CheckedChanged
        AppOption_Shortcut4_SelectFile.Enabled = AppOption_EnableCustomShortcut_4.Checked
        AppOption_Shortcut4_Path.Enabled = AppOption_EnableCustomShortcut_4.Checked
        AppOption_Shortcut4_LaunchWith.Enabled = AppOption_EnableCustomShortcut_4.Checked
        AppOption_Shortcut4_Icon.Enabled = AppOption_EnableCustomShortcut_4.Checked
    End Sub
    Private Sub AppOption_Shortcut4_SelectFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_Shortcut4_SelectFile.LinkClicked
        Dim result As DialogResult = SelectFileForShortcut.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_Shortcut4_Path.Text = IO.Path.GetFullPath(SelectFileForShortcut.FileName)
        End If
    End Sub

    ' Shortcut 5
    Private Sub AppOption_EnableCustomShortcut_5_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_EnableCustomShortcut_5.CheckedChanged
        AppOption_Shortcut5_SelectFile.Enabled = AppOption_EnableCustomShortcut_5.Checked
        AppOption_Shortcut5_Path.Enabled = AppOption_EnableCustomShortcut_5.Checked
        AppOption_Shortcut5_LaunchWith.Enabled = AppOption_EnableCustomShortcut_5.Checked
        AppOption_Shortcut5_Icon.Enabled = AppOption_EnableCustomShortcut_5.Checked
    End Sub
    Private Sub AppOption_Shortcut5_SelectFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_Shortcut5_SelectFile.LinkClicked
        Dim result As DialogResult = SelectFileForShortcut.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_Shortcut5_Path.Text = IO.Path.GetFullPath(SelectFileForShortcut.FileName)
        End If
    End Sub

    ' Shortcut 6
    Private Sub AppOption_EnableCustomShortcut_6_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_EnableCustomShortcut_6.CheckedChanged
        AppOption_Shortcut6_SelectFile.Enabled = AppOption_EnableCustomShortcut_6.Checked
        AppOption_Shortcut6_Path.Enabled = AppOption_EnableCustomShortcut_6.Checked
        AppOption_Shortcut6_LaunchWith.Enabled = AppOption_EnableCustomShortcut_6.Checked
        AppOption_Shortcut6_Icon.Enabled = AppOption_EnableCustomShortcut_6.Checked
    End Sub
    Private Sub AppOption_Shortcut6_SelectFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_Shortcut6_SelectFile.LinkClicked
        Dim result As DialogResult = SelectFileForShortcut.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_Shortcut6_Path.Text = IO.Path.GetFullPath(SelectFileForShortcut.FileName)
        End If
    End Sub

    ' Enable/Disable Main windows update at startup sub options
    Private Sub AppOption_SearchUpdateAtAppStart_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_SearchUpdateAtAppStart.CheckedChanged
        AppOption_UpdateAtStartup_DiscreteMode.Enabled = AppOption_SearchUpdateAtAppStart.Checked
        AppOption_UseLegacyUpdatePopups.Enabled = AppOption_SearchUpdateAtAppStart.Checked

        UI_Tab04_Cat01_UnderOption01.Image = If(AppOption_SearchUpdateAtAppStart.Checked = True, My.Resources.CbxUnderOption, My.Resources.CbxUnderOptionUnavailable)
        UI_Tab04_Cat01_UnderOption02.Image = If(AppOption_SearchUpdateAtAppStart.Checked = True, My.Resources.CbxUnderOptionL, My.Resources.CbxUnderOptionUnavailableL)
    End Sub

    ' Enable/Disable Install Update in Silent Mode
    Private Sub AppOption_UpdateAutomaticInstall_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_UpdateAutomaticInstall.CheckedChanged
        AppOption_UpdateAutomaticInstallSilentMode.Enabled = AppOption_UpdateAutomaticInstall.Checked

        UI_Tab04_Cat03_UnderOption01.Image = If(AppOption_UpdateAutomaticInstall.Checked = True, My.Resources.CbxUnderOption, My.Resources.CbxUnderOptionUnavailable)
    End Sub

    ' Lunar Magic slots
    ' Slot 1
    Private Sub AppOption_EnableLMSlot1_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_EnableLMSlot1.CheckedChanged
        AppOption_EnableHeaderMagicLMSlot1.Enabled = AppOption_EnableLMSlot1.Checked
        AppOption_LMslot1_Name.Enabled = AppOption_EnableLMSlot1.Checked
        AppOption_LMslot1_Version.Enabled = AppOption_EnableLMSlot1.Checked
        AppOption_LMslot1_Path.Enabled = AppOption_EnableLMSlot1.Checked
        AppOption_LMslot1_SelectExecutable.Enabled = AppOption_EnableLMSlot1.Checked
    End Sub
    Private Sub AppOption_LMslot1_Name_TextChanged(sender As Object, e As EventArgs) Handles AppOption_LMslot1_Name.TextChanged
        AppOption_LM1CTL_VersionSelector.Items(0) = AppOption_LMslot1_Name.Text
    End Sub
    Private Sub AppOption_LMslot1_SelectExecutable_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_LMslot1_SelectExecutable.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_LMslot1_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Slot 2
    Private Sub AppOption_EnableLMSlot2_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_EnableLMSlot2.CheckedChanged
        AppOption_EnableHeaderMagicLMSlot2.Enabled = AppOption_EnableLMSlot2.Checked
        AppOption_LMslot2_Name.Enabled = AppOption_EnableLMSlot2.Checked
        AppOption_LMslot2_Version.Enabled = AppOption_EnableLMSlot2.Checked
        AppOption_LMslot2_Path.Enabled = AppOption_EnableLMSlot2.Checked
        AppOption_LMslot2_SelectExecutable.Enabled = AppOption_EnableLMSlot2.Checked
    End Sub
    Private Sub AppOption_LMslot2_Name_TextChanged(sender As Object, e As EventArgs) Handles AppOption_LMslot2_Name.TextChanged
        AppOption_LM1CTL_VersionSelector.Items(1) = AppOption_LMslot2_Name.Text
    End Sub
    Private Sub AppOption_LMslot2_SelectExecutable_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_LMslot2_SelectExecutable.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_LMslot2_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Slot 3
    Private Sub AppOption_EnableLMSlot3_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_EnableLMSlot3.CheckedChanged
        AppOption_EnableHeaderMagicLMSlot3.Enabled = AppOption_EnableLMSlot3.Checked
        AppOption_LMslot3_Name.Enabled = AppOption_EnableLMSlot3.Checked
        AppOption_LMslot3_Version.Enabled = AppOption_EnableLMSlot3.Checked
        AppOption_LMslot3_Path.Enabled = AppOption_EnableLMSlot3.Checked
        AppOption_LMslot3_SelectExecutable.Enabled = AppOption_EnableLMSlot3.Checked
    End Sub
    Private Sub AppOption_LMslot3_Name_TextChanged(sender As Object, e As EventArgs) Handles AppOption_LMslot3_Name.TextChanged
        AppOption_LM1CTL_VersionSelector.Items(2) = AppOption_LMslot3_Name.Text
    End Sub
    Private Sub AppOption_LMslot3_SelectExecutable_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_LMslot3_SelectExecutable.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_LMslot3_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Lunar Magic "1 Click to Launch"
    Private Sub AppOption_EnableLM1CTL_CheckedChanged(sender As Object, e As EventArgs) Handles AppOption_EnableLM1CTL.CheckedChanged
        AppOption_LM1CTL_DisplaySelectorOnCTRLClick.Enabled = AppOption_EnableLM1CTL.Checked
        AppOption_LM1CTL_VersionSelector.Enabled = AppOption_EnableLM1CTL.Checked
    End Sub

    ' Snes9x x86 Executable
    Private Sub AppOption_Snes9x_Selectx86Executable_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_Snes9x_Selectx86Executable.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_Snes9x_x86Executable.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Snes9x x64 Executable
    Private Sub AppOption_Snes9x_Selectx64Executable_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_Snes9x_Selectx64Executable.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_Snes9x_x64Executable.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Bsnes Executable.
    Private Sub AppOption_SelectBsnesExecutable_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_SelectBsnesExecutable.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_BsnesExecutable.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Iggy/Larry Battle Platform Editor
    Private Sub AppOption_ILBPE_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_ILBPE_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_ILBPE_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' SMW Boss Battle Palette Editor
    Private Sub AppOption_SMWBBPE_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_SMWBBPE_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_SMWBBPE_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' SMW Enemy Name Importer
    Private Sub AppOption_SMWENI_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_SMWENI_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_SMWENI_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' SMW Enemy Name Exporter
    Private Sub AppOption_SMWENE_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_SMWENE_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_SMWENE_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' SMW Miscellaneous Text Editor
    Private Sub AppOption_SMWMTE_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_SMWMTE_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_SMWMTE_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' SMW Player Tilemap Editor
    Private Sub AppOption_SMWPTE_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_SMWPTE_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_SMWPTE_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' SMW Status Bar Editor
    Private Sub AppOption_SMWSBE_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_SMWSBE_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_SMWSBE_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' SMW Thank You Message Importer
    Private Sub AppOption_SMWTYMI_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_SMWTYMI_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_SMWTYMI_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Lunar Expand
    Private Sub AppOption_LunarExpand_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_LunarExpand_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_LunarExpand_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Recover Lunar Magic
    Private Sub AppOption_RecoverLM_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_RecoverLM_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_RecoverLM_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' SnesGFX
    Private Sub AppOption_SnesGFX_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_SnesGFX_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_SnesGFX_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Mario/Luigi Live Palette Editor
    Private Sub AppOption_MarioLuigiLPE_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_MarioLuigiLPE_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_MarioLuigiLPE_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' HeAdder
    Private Sub AppOption_HeAdder_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_HeAdder_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_HeAdder_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' H-DMA Gradient Ripper
    Private Sub AppOption_HdmaGR_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_HdmaGR_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_HdmaGR_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' MML Editing Tool
    Private Sub AppOption_MMLEdit_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_MMLEdit_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_MMLEdit_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' AddMusicK - CMD Edition
    Private Sub AppOption_AMK_CMD_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_AMK_CMD_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_AMK_CMD_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' AddMusicK - GUI Edition
    Private Sub AppOption_AMK_GUI_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_AMK_GUI_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_AMK_GUI_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Level Music Utility
    Private Sub AppOption_LvMusUtil_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_LvMusUtil_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_LvMusUtil_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' BRR Player
    Private Sub AppOption_BRRPlayer_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_BRRPlayer_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_BRRPlayer_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Blockreator
    Private Sub AppOption_Blockreator_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_Blockreator_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_Blockreator_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Pixi - Main executable
    Private Sub AppOption_Pixi_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_Pixi_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_Pixi_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Pixi - Configurator
    Private Sub AppOption_PixiConfigurator_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_PixiConfigurator_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_PixiConfigurator_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' M7Map
    Private Sub AppOption_M7Map_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_M7Map_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_M7Map_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' SNES SPC700 Player
    Private Sub AppOption_SPC700Player_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_SPC700Player_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_SPC700Player_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Floating IPS/BPS
    Private Sub AppOption_FloatingIPS_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_FloatingIPS_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_FloatingIPS_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Status Effects
    Private Sub AppOption_StatusEffects_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_StatusEffects_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_StatusEffects_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' SNES Color Tool
    Private Sub AppOption_SnesColorTool_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_SnesColorTool_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_SnesColorTool_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Effect Tool
    Private Sub AppOption_EffectTool_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_EffectTool_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_EffectTool_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Gopher Popcorn Stew
    Private Sub AppOption_GPS_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_GPS_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_GPS_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' PetiteMM
    Private Sub AppOption_PetiteMM_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_PetiteMM_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationDirectory_OpenFolderBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_PetiteMM_Path.Text = IO.Path.GetFullPath(SelectApplicationDirectory_OpenFolderBox.SelectedPath)
        End If
    End Sub

    ' Asar
    Private Sub AppOption_Asar_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_Asar_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_Asar_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Mario Start Editor
    Private Sub AppOption_MarioSE_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_MarioSE_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_MarioSE_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Interaction Editor
    Private Sub AppOption_InteractionEditor_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_InteractionEditor_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_InteractionEditor_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Multiple Midway Points
    Private Sub AppOption_MultipleMidwayPoints_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_MultipleMidwayPoints_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_MultipleMidwayPoints_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Sprite GFX Creator
    Private Sub AppOption_SpriteGFX_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_SpriteGFX_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_SpriteGFX_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' Graphic Editor
    Private Sub AppOption_GraphicEditor_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_GraphicEditor_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_GraphicEditor_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' YY-CHR
    Private Sub AppOption_YYCHR_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_YYCHR_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_YYCHR_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' SMW Customizer
    Private Sub AppOption_SMWCustomizer_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_SMWCustomizer_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_SMWCustomizer_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' UberASM
    Private Sub AppOption_UberASM_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_UberASM_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationDirectory_OpenFolderBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_UberASM_Path.Text = IO.Path.GetFullPath(SelectApplicationDirectory_OpenFolderBox.SelectedPath)
        End If
    End Sub

    ' GradientTool
    Private Sub AppOption_GradientTool_SelectPath_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AppOption_GradientTool_SelectPath.LinkClicked
        Dim result As DialogResult = SelectApplicationExecutable_OpenFileBox.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            AppOption_GradientTool_Path.Text = IO.Path.GetFullPath(SelectApplicationExecutable_OpenFileBox.FileName)
        End If
    End Sub

    ' -----| The "▼" Sub menu |-----
    Private Sub UI_Btn_SubOptionsMenu_Click(sender As Object, e As EventArgs) Handles UI_Btn_SubOptionsMenu.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Question)

            Select Case My.Settings.DEVELOPER_MODE
                Case False
                    Dim AnsDev As String
                    AnsDev = MessageBox.Show(Frm99_TranslateForm.UI03_DevModeToggleOnRequestDesc.Text, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI03_DevModeToggleTitleText.Text}", CType(MsgBoxStyle.YesNo, MessageBoxButtons), MessageBoxIcon.Question)

                    Select Case AnsDev
                        Case vbYes
                            My.Settings.DEVELOPER_MODE = True
                            My.Settings.Save()

                            MessageBox.Show(Frm99_TranslateForm.UI03_DevModeToggleOnConfirmDesc.Text, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI03_DevModeToggleTitleText.Text}", CType(MsgBoxStyle.OkOnly, MessageBoxButtons), MessageBoxIcon.Information)
                            Application.Restart()

                    End Select

                Case True
                    Dim AnsDev As String
                    AnsDev = MessageBox.Show(Frm99_TranslateForm.UI03_DevModeToggleOffRequestDesc.Text, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI03_DevModeToggleTitleText.Text}", CType(MsgBoxStyle.YesNo, MessageBoxButtons), MessageBoxIcon.Question)

                    Select Case AnsDev
                        Case vbYes
                            My.Settings.DEVELOPER_MODE = False
                            My.Settings.Save()

                            MessageBox.Show(Frm99_TranslateForm.UI03_DevModeToggleOffConfirmDesc.Text, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI03_DevModeToggleTitleText.Text}", CType(MsgBoxStyle.OkOnly, MessageBoxButtons), MessageBoxIcon.Information)
                            Application.Restart()

                    End Select

            End Select

        Else
            DownArrowMenu.Show(UI_Btn_SubOptionsMenu, DownArrowMenuPos.Location, 17)
        End If
    End Sub

    ' Sub menu items
    Private Sub DownArrowMenu_ReloadSettings_Click(sender As Object, e As EventArgs) Handles DownArrowMenu_ReloadSettings.Click
        SettingsLoad()
    End Sub
    Private Sub DownArrowMenu_ImportSettings_Click(sender As Object, e As EventArgs) Handles DownArrowMenu_ImportSettings.Click
        ImportSettings_OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Try
            Dim result As DialogResult = ImportSettings_OpenFileDialog.ShowDialog()

            If result = Windows.Forms.DialogResult.OK Then

                IO.File.Delete(ConfigFile)
                IO.File.Copy(IO.Path.GetFullPath(ImportSettings_OpenFileDialog.FileName), ConfigFile)

                My.Settings.Save()

                MessageBox.Show(Frm99_TranslateForm.UI03_SettingsIMportSuccessDesc.Text, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI03_SettingsImportSuccessTitle.Text}", CType(MsgBoxStyle.OkOnly, MessageBoxButtons), MessageBoxIcon.Information)
                Application.Restart()

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {ImportSettings_OpenFileDialog.Title}")

        End Try
    End Sub
    Private Sub DownArrowMenu_ExportSettings_Click(sender As Object, e As EventArgs) Handles DownArrowMenu_ExportSettings.Click
        ExportSettings_SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Try

            Dim result As DialogResult = ExportSettings_SaveFileDialog.ShowDialog()

            If result = Windows.Forms.DialogResult.OK Then

                IO.File.Delete(IO.Path.GetFullPath(ExportSettings_SaveFileDialog.FileName))
                IO.File.Copy(ConfigFile, IO.Path.GetFullPath(ExportSettings_SaveFileDialog.FileName))

                MessageBox.Show($"{Frm99_TranslateForm.UI03_SettingsExportSuccessDesc.Text}{vbNewLine}{Chr(34)}{IO.Path.GetFullPath(ExportSettings_SaveFileDialog.FileName)}{Chr(34)}.", $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI03_SettingsExportSuccessTitle.Text}", CType(MsgBoxStyle.OkOnly, MessageBoxButtons), MessageBoxIcon.Information)

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {ExportSettings_SaveFileDialog.Title}")

        End Try
    End Sub
    Private Sub DownArrowMenu_ResetSettings_Click(sender As Object, e As EventArgs) Handles DownArrowMenu_ResetSettings.Click
        FrmDlg01_ResetConfirmation.ShowDialog()

        If FrmDlg01_ResetConfirmation.DialogResult = Windows.Forms.DialogResult.OK Then

            My.Settings.Reset()
            My.Settings.Save()

            MessageBox.Show(Frm99_TranslateForm.UI03_SettingsResetDesc.Text, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI03_SettingsResetTitle.Text}", CType(MsgBoxStyle.OkOnly, MessageBoxButtons), MessageBoxIcon.Information)
            Application.Restart()

        End If
    End Sub
    Private Sub DownArrowMenu_HD_ExperimentalSettings_Click(sender As Object, e As EventArgs) Handles DownArrowMenu_HD_ExperimentalSettings.Click
        Frm98_IndevFeatures.ShowDialog()
    End Sub

    ' Page End

End Class