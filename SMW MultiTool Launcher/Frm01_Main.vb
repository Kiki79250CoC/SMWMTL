
Imports System.Globalization
Imports System.Net

Public Class Frm01_Main
#Region "        DWMAPI + Shell32 API "

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

    ' Shell32-based About box
    Declare Ansi Function ShellAbout Lib "shell32.dll" Alias "ShellAboutA" (hWnd As IntPtr, szApp As String, szOtherStuff As String, hIcon As IntPtr) As Integer

#End Region
#Region "        Values "

    ' Windows Version informations (Kernel + Build)
    ReadOnly Win_NT_Version As String = $"{Environment.OSVersion.Version.Major}.{Environment.OSVersion.Version.Minor}"
    ReadOnly Win_BuildNbr As String = Environment.OSVersion.Version.Build

    ' Executable location
    ReadOnly Locate As String = My.Application.Info.DirectoryPath

    ' Window Title
    Public WindowTitle As String
    ReadOnly PersonalizedTextSpacing As String = If(My.Settings.HIDE_TITLE = False, " • ", Nothing)

    ' Account Username
    ReadOnly WSHNetwork = CreateObject("WScript.Network")

    ' Software Compilation date
    ReadOnly CompileDate As New DateTime(My.Resources.BUILD_DATE_YEAR, My.Resources.BUILD_DATE_MONTH, My.Resources.BUILD_DATE_DAY)

    ' Required WebBrowsers for Update search.
    Private UpdateWC1 As WebClient ' Step 1
    Private UpdateWC2 As WebClient ' Step 2 - Download Version String (A.BB.CCCC.DD)
    Private UpdateWC3 As WebClient ' Step 3 - Download Changelog
    Private UpdateWC4 As WebClient ' Step 3 - Download Link for Downloading Update
    Private UpdateWC5 As WebClient ' Step 3 - Download Shortened major version

    ' Bottom bar retract button tooltip
    Private MenuRetractBtn_ToolTip As ToolTip

#End Region

    Private Sub Frm01_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set Icons for window and tray icon
        Icon = My.Resources.AppIcon
        SystemTrayIcon.Icon = My.Resources.AppIcon

#Region "            Pre-release build tag "

        Select Case My.Settings.IS_PRERELEASE
            Case True
                Beta.Visible = True
                Beta2.Visible = True

                Beta.Text = $"{My.Application.Info.AssemblyName} Codename {My.Resources.APP_CODENAME} Build {My.Resources.APP_VERSION_BUILD}"
                Beta2.Text = $"{My.Resources.RELEASE_STATE} • {Frm99_TranslateForm.UI01_ForTestingPurposes.Text}"

                If My.Resources.RELEASE_STATE.Contains("Alpha") Then
                    Text += " Alpha"
                ElseIf My.Resources.RELEASE_STATE.Contains("Beta") Then
                    Text += " Beta"
                ElseIf My.Resources.RELEASE_STATE.Contains("Candidate") Then
                    Text += " RC"
                End If

            Case False
                Beta.Visible = False
                Beta2.Visible = False

        End Select

#End Region

        WindowTitle = Text

        ' Settings load

        ' Dark mode
        Select Case My.Settings.UI_DARK_MODE
            Case True
                Select Case My.Settings.EX_SET_DARKMODE_HOMEUPDATEBAR
                    Case True
#Region "                        Dark Mode application "

                        Applications_TabPanel.BackColor = Color.FromArgb(36, 36, 36)
                        SubMenu_TabPanel.BackColor = Color.FromArgb(36, 36, 36)

                        Beta.ForeColor = Color.FromArgb(255, 90, 90)
                        Beta2.ForeColor = Color.FromArgb(255, 90, 90)

                        ApplicationText.ForeColor = Color.White
                        OptionsText.ForeColor = Color.White
                        SubMenu_AppTitle.ForeColor = Color.White

                        For Each Btns As Button In {LM_Button, LE_Button, RLM_Button, SNESGFX_Button, MarioLPE_Button, HeAdder_Button, HDMA_GR_Button, MML_Edit_Button, AMK_Button, LvlMusicUtil_Button, BRRPlayer_Button, Blockreator_Button, PIXI_Button, M7MAP_Button, SPC700_Button, FLIPS_Button, STAEFF_Button, SNESColorTool_Button, EFFTOOL_Button, GPS_Button, PMM_Button, Asar_Button, Snes9x_Button, Bsnes_Button, MarioStartE_Button, InterEdit_Button, MMP_Button, SprGFXCrea_Button, GraphEdit_Button, YYCHR_Button, SMWCust_Button, SMHACKER_Button, UberASM_Button, GradTool_Button, UnusedBtn01, UnusedBtn02, UnusedBtn03, UnusedBtn04, UnusedBtn05, UnusedBtn06, UnusedBtn07, UnusedBtn08, UnusedBtn09, UnusedBtn10, UnusedBtn11, UnusedBtn12, UnusedBtn13, UnusedBtn14, UnusedBtn15, UnusedBtn16, UnusedBtn17, UnusedBtn18, UnusedBtn19, UnusedBtn20, UnusedBtn21, UnusedBtn22, UnusedBtn23, UnusedBtn24, UnusedBtn25, UnusedBtn26, UnusedBtn27, UnusedBtn28, UnusedBtn29, UnusedBtn30, UnusedBtn31, UnusedBtn32, UnusedBtn33, UnusedBtn34, UnusedBtn35, UnusedBtn36, UnusedBtn37, UnusedBtn38, UnusedBtn39, UnusedBtn40, CLOSE_SUBMENU, LM_Option_1, LM_Option_2, LM_Option_3, AMK_Option_1, AMK_Option_2, AMK_Option_3, PIXI_Option_1, PIXI_Option_2, SMWCust_Option_1, SMWCust_Option_2, SH_Option_1, SH_Option_2, SH_Option_3, SH_Option_4, SH_Option_5, SH_Option_6, SH_Option_7, SH_Option_8, SubMenu_PlaceHolder01, SubMenu_PlaceHolder02, SubMenu_PlaceHolder03, SubMenu_PlaceHolder04, SubMenu_PlaceHolder05, SubMenu_PlaceHolder06, SubMenu_PlaceHolder07, SubMenu_PlaceHolder08, SubMenu_PlaceHolder09, SubMenu_PlaceHolder10, SubMenu_PlaceHolder11, SubMenu_PlaceHolder12, SubMenu_PlaceHolder13, SubMenu_PlaceHolder14, SubMenu_PlaceHolder15, SubMenu_PlaceHolder16, SubMenu_PlaceHolder17, Shortcut_PlaceHolder1, Shortcut_PlaceHolder2, Shortcut_PlaceHolder3, Shortcut_PlaceHolder4, Shortcut_PlaceHolder5, Shortcut_PlaceHolder6, Shortcut_1, Shortcut_2, Shortcut_3, Shortcut_4, Shortcut_5, Shortcut_6}
                            Btns.FlatStyle = FlatStyle.Flat
                            Btns.BackColor = Color.FromArgb(36, 36, 36)

                            Btns.FlatAppearance.BorderColor = Color.DimGray
                            Btns.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 47, 47)
                            Btns.FlatAppearance.MouseDownBackColor = Color.FromArgb(58, 58, 58)
                        Next

                        For Each ImgBx As PictureBox In {SubMenu_Gradient1, SubMenu_Gradient2, Shortcut_GradientLine, Application_Gradient1}
                            ImgBx.Image = My.Resources.GradientLine_Gray
                        Next

                        CLOSE_SUBMENU.Image = My.Resources.Close_DarkMode

                        UpdateSearchState_Panel.BackColor = Color.FromArgb(25, 25, 25)
                        UpdateSearchState_PanelTopBar.BackgroundImage = My.Resources.UI_BottomBar
                        UpdateSearchState_Label.ForeColor = Color.White

                        UI_Btn_GoToUpdateModal.LinkColor = Color.LightGray
                        UI_Btn_GoToUpdateModal.VisitedLinkColor = Color.LightGray
                        UI_Btn_GoToUpdateModal.ActiveLinkColor = Color.DimGray

                        PMM_Button.Image = My.Resources.AppIcon_PetiteMM_DarkMode
                        SMHACKER_Button.Image = My.Resources.AppIcon_Smallhacker_DarkMode
                        UberASM_Button.Image = My.Resources.AppIcon_UberASM_DarkMode

#End Region

                End Select

        End Select

        ' Enhancements for Windows Classic
        For Each ImgBx As PictureBox In {Deco1, Deco2, Deco3, Deco4, Deco5}
            Select Case My.Settings.WIN_CLASSIC_ENHANCEMENTS
                Case True
                    ImgBx.Visible = False

                Case False
                    ImgBx.Visible = True

                    Select Case Win_NT_Version
                        Case "6.0", "6.1"
#Region "                        Code that applies to Windows Vista & 7 "

                            TabLineDeco.Image = My.Resources.UI_TabMask_7
                            Deco3.Image = My.Resources.UI_RightMask_7
                            Deco2.Image = My.Resources.UI_LeftMask_7

#End Region

                        Case "6.2", "6.3"
#Region "                        Code that applies to Windows 8 and 8.1 "

                            TabLineDeco.Image = My.Resources.UI_TabMask_8
                            Deco3.Image = My.Resources.UI_RightMask_8
                            Deco2.Image = My.Resources.UI_LeftMask_8

#End Region

                        Case "10.0"
#Region "                        Code that applies to Windows 10 and 11 "

                            TabLineDeco.Image = If(Win_BuildNbr >= "21800", My.Resources.UI_TabMask_11, My.Resources.UI_TabMask_10)
                            Deco3.Image = If(Win_BuildNbr >= "21800", My.Resources.UI_RightMask_11, My.Resources.UI_RightMask_10)
                            Deco2.Image = If(Win_BuildNbr >= "21800", My.Resources.UI_LeftMask_11, My.Resources.UI_LeftMask_10)

#End Region

                    End Select

            End Select
        Next

        ' Update search at startup
        Select Case My.Settings.UPDATE_SEARCH_AT_STARTUP
            Case True
                ' Set Icon and "Search updates" text
                UpdateSearchState_Pic.Image = My.Resources.HomeUpdateSearching
                UpdateSearchState_Panel.BackgroundImage = My.Resources.MW_UpdateSearchBlue
                UpdateSearchState_Label.Text = Frm99_TranslateForm.UI01_UpdateSearchState_InProgress.Text

                ' WebClients preparation for update search process.
                UpdateWC1 = New WebClient() ' Step 1
                UpdateWC2 = New WebClient() ' Step 2 - Download Version String (A.BB.CCCC.DD)
                UpdateWC3 = New WebClient() ' Step 3 - Download Changelog
                UpdateWC4 = New WebClient() ' Step 3 - Download Link for Downloading Update
                UpdateWC5 = New WebClient() ' Step 3 - Download Shortened major version

                UpdateWC3.Encoding = System.Text.Encoding.UTF8

            Case False
                UpdateSearchState_Panel.Visible = False
                TabControl3.Visible = False
                Deco3.Visible = False
                Deco2.Visible = False

                Size = New Size(Width, Height - UpdateSearchState_Panel.Height)

        End Select

        ' ---------------------------------------------------------------------------------------------------------------------

        ' DWMAPI extension (Option enabled) and Theme (Option Disabled)
        Select Case My.Settings.DWM_EXTENSION
            Case True
                Select Case AeroEnabled()
                    Case True
                        Dim side As New Side With {.Left = 13, .Right = 13, .Top = 33, .Bottom = If(Win_NT_Version = "6.0", 56, 54)}
                        Dim result As Integer = DwmExtendFrameIntoClientArea(Handle, side)

                        BackColor = Color.Black

                End Select

            Case False
                Select Case My.Settings.UI_DARK_MODE
                    Case True
                        Select Case My.Settings.EX_SET_DARKMODE_HOMEUPDATEBAR
                            Case True
                                BackColor = Color.FromArgb(25, 25, 25)

                        End Select
                End Select

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

        ' Custom Title text
        Select Case My.Settings.ADDITIONAL_TITLE_TEXT
            Case True

                Select Case My.Settings.ADDITIONAL_TITLE_TEXT_TYPE
                    Case 0
                        Text = $"{If(My.Settings.HIDE_TITLE = True, Nothing, WindowTitle)}{PersonalizedTextSpacing}{WSHNetwork.Username}"

                    Case 1
                        Text = $"{If(My.Settings.HIDE_TITLE = True, Nothing, WindowTitle)}{PersonalizedTextSpacing}{Now}"
                        Titlebar_Clock.Start()

                    Case 2
                        Text = $"{If(My.Settings.HIDE_TITLE = True, Nothing, WindowTitle)}{If(My.Settings.CUSTOM_TITLE_TEXT = Nothing, Nothing, $"{PersonalizedTextSpacing}{My.Settings.CUSTOM_TITLE_TEXT}")}"

                        Text = Text.Replace("$RS", My.Resources.RELEASE_STATE)
                        Text = Text.Replace("$MV", My.Resources.APP_VERSION)
                        Text = Text.Replace("$CV", My.Resources.APP_VERSION_COMPLETE)
                        Text = Text.Replace("$BN", My.Resources.APP_VERSION_BUILD)
                        Text = Text.Replace("$BDD", My.Resources.BUILD_DATE_DAY)
                        Text = Text.Replace("$BDM", My.Resources.BUILD_DATE_MONTH)
                        Text = Text.Replace("$BDY", My.Resources.BUILD_DATE_YEAR)
                        Text = Text.Replace("$BDV", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CompileDate.ToString(If(My.Computer.Info.InstalledUICulture.ToString().Contains("fr"), "dd MMMM yyyy", "MMMM dd, yyyy"), CultureInfo.CreateSpecificCulture(If(My.Computer.Info.InstalledUICulture.ToString().Contains("fr"), "fr-FR", "en-US")))))
                        Text = Text.Replace("$BDC", My.Resources.BUILD_DATE_COMBINED)
                        Text = Text.Replace("$ABS", $"{My.Application.Info.AssemblyName}_{My.Resources.APP_CODENAME}_{My.Resources.APP_VERSION_COMPLETE}_x{If(Environment.Is64BitProcess = True, "64", "86")}_{My.Resources.BUILD_DATE_COMBINED}")
                        Text = Text.Replace("$CN", My.Resources.APP_CODENAME)

                End Select

        End Select

        ' Window opacity
        Opacity = If(My.Settings.APP_OPACITY_TOGGLE = True, My.Settings.APP_OPACITY / 100, 100)

        ' Displaying Build number in the sub-menu tab title
        SubMenu_TabPage.Text += If(My.Settings.DISPLAY_COMPLETEVERSION_IN_MAIN_WINDOW = True, $" {My.Resources.APP_VERSION_COMPLETE}", $" {My.Resources.APP_VERSION}")

        ' Lock in foreground
        TopMost = My.Settings.LOCK_AT_TOPMOST

        ' Systray icon
        SystemTrayIcon.Visible = My.Settings.SHOW_TRAY_ICON
        SystemTrayIcon.Text = $"{WindowTitle} • Version {My.Resources.APP_VERSION}"
        SystemTrayIcon.ContextMenu = SysTray_Menu

        ' ---------------------------------------------------------------------------------------------------------------------

        ' Boutons de la barre inférieure
        Dim BtmbarBtns As New List(Of Button) From {BtmBar_HelpBtn, BtmBar_SuggestBtn, BtmBar_BugReportBtn, BtmBar_WinverBtn, BtmBar_TaskmgrBtn, BtmBar_AboutBtn}
        Dim BtmbarSeps As New List(Of PictureBox) From {BtmBar_Separator_1, BtmBar_Separator_2, BtmBar_Separator_3, BtmBar_Separator_4}

        Select Case My.Settings.HIDE_ALL_BOTTOM_BUTTONS
            Case True
                BtmBar_MenuRetractBtnCbx.Visible = True

                For Each Buttons In BtmbarBtns
                    Buttons.Visible = False
                Next
                For Each BtnSeparators In BtmbarSeps
                    BtnSeparators.Visible = False
                Next

            Case False
                BtmBar_MenuRetractBtnCbx.Visible = False

                BtmBar_HelpBtn.Visible = My.Settings.SHOW_HELP_BTN
                BtmBar_SuggestBtn.Visible = My.Settings.SHOW_SUGGESTUPDATE_BTN
                BtmBar_BugReportBtn.Visible = My.Settings.SHOW_REPORTCRASH_BTN
                BtmBar_WinverBtn.Visible = My.Settings.SHOW_WINVER_BTN
                BtmBar_TaskmgrBtn.Visible = My.Settings.SHOW_TASKMGR_BTN
                BtmBar_AboutBtn.Visible = True

                Select Case My.Settings.SHOW_BTN_SEPARATORS
                    Case True

                        BtmBar_Separator_4.Visible = BtmBar_HelpBtn.Visible

                        If BtmBar_SuggestBtn.Visible = True OrElse BtmBar_BugReportBtn.Visible = True Then
                            BtmBar_Separator_3.Visible = True
                        End If

                        If BtmBar_WinverBtn.Visible = True OrElse BtmBar_TaskmgrBtn.Visible = True Then
                            BtmBar_Separator_2.Visible = True
                        End If

                    Case False
                        For Each BtnSeparators In BtmbarSeps
                            BtnSeparators.Visible = False
                        Next

                End Select

        End Select

        ' "Winver" button icon
        Select Case My.Settings.WINVER_USE_CURRENT_OS_ICON
            Case True
#Region "                Set icon from Windows version "

                Select Case Win_NT_Version
                    Case "6.0"
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_WinVista

                    Case "6.1"
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win7

                    Case "6.2", "6.3"
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win8

                    Case "10.0"
                        If Win_BuildNbr >= "21800" Then
                            BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win11
                        Else
                            BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win10
                        End If

                    Case Else
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win7

                End Select

#End Region

            Case False
#Region "                Set icon from preference "

                Select Case My.Settings.WINVER_ICON
                    Case 0
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_ReactOS

                    Case 1
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Ubuntu

                    Case 2
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Debian

                    Case 3
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Apple

                    Case 4
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win1x2x

                    Case 5
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win9x

                    Case 6
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_WinME

                    Case 7
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win2000

                    Case 8
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_WinWhistler

                    Case 9
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_WinXP

                    Case 10
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_WinXP_MCE

                    Case 11
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_WinLonghorn

                    Case 12
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_WinVista

                    Case 13
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_WinLive

                    Case 14
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_WinMC

                    Case 15
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win7

                    Case 16
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win7Flat

                    Case 17
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win8

                    Case 18
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win8Colored

                    Case 19
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win10

                    Case 20
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win10X

                    Case 21
                        BtmBar_WinverBtn.Image = My.Resources.Winver_Logo_Win11

                End Select

#End Region

        End Select

        ' "Task Manager" button icon
        Select Case My.Settings.TASKMGR_USE_WINDOWS_ICON
            Case True
#Region "                Set icon from Windows version "

                Select Case Win_NT_Version
                    Case "6.0", "6.1"
                        BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_WinVista_7

                    Case "6.2", "6.3", "6.4", "10.0"
                        If Win_BuildNbr >= "21800" Then
                            BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_Win11
                        Else
                            BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_Win8_10
                        End If

                End Select

#End Region

            Case False
#Region "                Set icon from preference "


                Select Case My.Settings.TASKMGR_ICON_BACK
                    Case 0
                        Select Case My.Settings.TASKMGR_ICON_LINE
                            Case 0
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_DRed

                            Case 1
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_DGreen

                            Case 2
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_DBlue

                            Case 3
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_DPurple

                            Case 4
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_DYellow

                            Case 5
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_DOrange

                            Case 6
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_DPink

                            Case 7
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_DBrown

                            Case 8
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_DGray

                            Case 9
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_DWhite

                        End Select

                    Case 1
                        Select Case My.Settings.TASKMGR_ICON_LINE
                            Case 0
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_LRed

                            Case 1
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_LGreen

                            Case 2
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_LBlue

                            Case 3
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_LPurple

                            Case 4
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_LYellow

                            Case 5
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_LOrange

                            Case 6
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_LPink

                            Case 7
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_LBrown

                            Case 8
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_LGray

                            Case 9
                                BtmBar_TaskmgrBtn.Image = My.Resources.Taskmgr_Icon_LWhite

                        End Select

                End Select
#End Region

        End Select

        ' Number of columns displayed
        Select Case My.Settings.MAINWINDOW_DISPLAYED_COLUMN_NBR
            Case 0
                Size = New Size(Width - 192, Height)

            Case 1
                Size = New Size(Width - 144, Height)

            Case 2
                Size = New Size(Width - 96, Height)

            Case 3
                Size = New Size(Width - 48, Height)

        End Select
        CenterToScreen()

        ' Buttons visibility
        LM_Button.Visible = My.Settings.DISPLAYBTN_LUNARMAGIC
        LE_Button.Visible = My.Settings.DISPLAYBTN_LUNAREXPAND
        RLM_Button.Visible = My.Settings.DISPLAYBTN_RECOVERLM
        SNESGFX_Button.Visible = My.Settings.DISPLAYBTN_SNESGFX
        MarioLPE_Button.Visible = My.Settings.DISPLAYBTN_MARIOLPE
        HeAdder_Button.Visible = My.Settings.DISPLAYBTN_HEADDER
        HDMA_GR_Button.Visible = My.Settings.DISPLAYBTN_HDMARIPPER
        MML_Edit_Button.Visible = My.Settings.DISPLAYBTN_MMLEDIT
        AMK_Button.Visible = My.Settings.DISPLAYBTN_ADDMUSICK
        LvlMusicUtil_Button.Visible = My.Settings.DISPLAYBTN_LVMUSUTIL
        BRRPlayer_Button.Visible = My.Settings.DISPLAYBTN_BRRPLAYER
        Blockreator_Button.Visible = My.Settings.DISPLAYBTN_BLOCKREATOR
        PIXI_Button.Visible = My.Settings.DISPLAYBTN_PIXI
        M7MAP_Button.Visible = My.Settings.DISPLAYBTN_MODE7TILEMAP
        SPC700_Button.Visible = My.Settings.DISPLAYBTN_SPC700PLAYER
        FLIPS_Button.Visible = My.Settings.DISPLAYBTN_FLIPS
        STAEFF_Button.Visible = My.Settings.DISPLAYBTN_STATUSEFFECTS
        SNESColorTool_Button.Visible = My.Settings.DISPLAYBTN_SNESCOLORTOOL
        EFFTOOL_Button.Visible = My.Settings.DISPLAYBTN_EFFECTTOOLS
        GPS_Button.Visible = My.Settings.DISPLAYBTN_GOPHERPOPCORNSTEW
        PMM_Button.Visible = My.Settings.DISPLAYBTN_PETITEMM
        Asar_Button.Visible = My.Settings.DISPLAYBTN_ASAR
        Snes9x_Button.Visible = My.Settings.DISPLAYBTN_SNES_EMU
        MarioStartE_Button.Visible = My.Settings.DISPLAYBTN_MARIOSTARTEDITOR
        InterEdit_Button.Visible = My.Settings.DISPLAYBTN_INTERACTIONEDIT
        MMP_Button.Visible = My.Settings.DISPLAYBTN_MULTIPLEMIDWAYPOINTS
        SprGFXCrea_Button.Visible = My.Settings.DISPLAYBTN_SPRITEGFX
        GraphEdit_Button.Visible = My.Settings.DISPLAYBTN_GRAPHEDIT
        YYCHR_Button.Visible = My.Settings.DISPLAYBTN_YYCHR
        SMWCust_Button.Visible = My.Settings.DISPLAYBTN_SMWCUST
        SMHACKER_Button.Visible = My.Settings.DISPLAYBTN_SHTOOLS
        UberASM_Button.Visible = My.Settings.DISPLAYBTN_UBERASM
        GradTool_Button.Visible = My.Settings.DISPLAYBTN_GRADIENTTOOL

        ' Custom shortcuts
        For Each Shortcuts As Button In {Shortcut_1, Shortcut_2, Shortcut_3, Shortcut_4, Shortcut_5, Shortcut_6}
            Shortcuts.Visible = My.Settings.ENABLE_CUSTOM_SHORTCUTS
        Next
        Select Case My.Settings.ENABLE_CUSTOM_SHORTCUTS
            Case True
                ' Shortcut 1
                Select Case My.Settings.ENABLE_CUSTOM_SHORTCUT_1
                    Case True
                        Shortcut_1.Enabled = True

                        Dim Shortcut1_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = $"{Frm99_TranslateForm.UI01_ShortcutTitle.Text} {Shortcut_1.Tag}"}

#Region "                            'Launch with' setting "

                        Select Case My.Settings.CUSTOM_SHORTCUT_1_LAUNCH_WITH
                            Case 0
                                Shortcut1_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutManagedByWindows.Text}"

                            Case 1
                                Shortcut1_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 1{If(My.Settings.LM_SLOT1_NAME = Nothing, "", $" • {My.Settings.LM_SLOT1_NAME}")})"

                            Case 2
                                Shortcut1_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 2{If(My.Settings.LM_SLOT2_NAME = Nothing, "", $" • {My.Settings.LM_SLOT2_NAME}")})"

                            Case 3
                                Shortcut1_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 3{If(My.Settings.LM_SLOT3_NAME = Nothing, "", $" • {My.Settings.LM_SLOT3_NAME}")})"

                            Case 4
                                Shortcut1_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Level Music Utility"

                            Case 5
                                Shortcut1_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} BRR Player"

                            Case 6
                                Shortcut1_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} SPC700 Player"

                            Case 7
                                Shortcut1_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Floating BPS"

                            Case 8
                                Shortcut1_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Snes9x"

                            Case 9
                                Shortcut1_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Bsnes"

                            Case 10
                                Shortcut1_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Graphics Editor"

                            Case 11
                                Shortcut1_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} YY-CHR"

                        End Select

#End Region

                        Shortcut1_ToolTip.SetToolTip(Shortcut_1, $"{Frm99_TranslateForm.UI01_ShortcutPath.Text} {My.Settings.CUSTOM_SHORTCUT_1_PATH}")

                    Case False
                        Shortcut_1.Enabled = False

                End Select

#Region "                    'Icon' setting "

                Select Case My.Settings.CUSTOM_SHORTCUT_1_ICON
                    Case 0
                        Shortcut_1.Image = My.Resources.Shortcut_Default_1

                    Case 1
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_LM

                    Case 2
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_LE

                    Case 3
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_RLM

                    Case 4
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_SnesGFX

                    Case 5
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_MLLP

                    Case 6
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_HA

                    Case 7
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_H_DMA

                    Case 8
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_MML

                    Case 9
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_AMK

                    Case 10
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_LMU

                    Case 11
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_Organ

                    Case 12
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_Blockreator

                    Case 13
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_PIXI

                    Case 14
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_M7M

                    Case 15
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_SPCPlayer

                    Case 16
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_FLIPS

                    Case 17
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_StatusEffects

                    Case 18
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_SPCT

                    Case 19
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_EffectTool

                    Case 20
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_Molester

                    Case 21
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_GPS

                    Case 22
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_Asar

                    Case 23
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_Snes9x

                    Case 24
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_Snes9xC

                    Case 25
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_MSE

                    Case 26
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_Interaction

                    Case 27
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_MMP

                    Case 28
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_SGFXC

                    Case 29
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_GraphEdit

                    Case 30
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_YYCHR

                    Case 31
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_SMWC

                    Case 32
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_SHTools

                    Case 33
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_UASM

                    Case 34
                        Shortcut_1.Image = My.Resources.Shortcut_Icon_GradientTool

                End Select

#End Region

                ' Shortcut 2
                Select Case My.Settings.ENABLE_CUSTOM_SHORTCUT_2
                    Case True
                        Shortcut_2.Enabled = True

                        Dim Shortcut2_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = $"{Frm99_TranslateForm.UI01_ShortcutTitle.Text} {Shortcut_2.Tag}"}

#Region "                            'Launch with' setting "

                        Select Case My.Settings.CUSTOM_SHORTCUT_2_LAUNCH_WITH
                            Case 0
                                Shortcut2_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutManagedByWindows.Text}"

                            Case 1
                                Shortcut2_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 1{If(My.Settings.LM_SLOT1_NAME = Nothing, "", $" • {My.Settings.LM_SLOT1_NAME}")})"

                            Case 2
                                Shortcut2_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 2{If(My.Settings.LM_SLOT2_NAME = Nothing, "", $" • {My.Settings.LM_SLOT2_NAME}")})"

                            Case 3
                                Shortcut2_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 3{If(My.Settings.LM_SLOT3_NAME = Nothing, "", $" • {My.Settings.LM_SLOT3_NAME}")})"

                            Case 4
                                Shortcut2_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Level Music Utility"

                            Case 5
                                Shortcut2_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} BRR Player"

                            Case 6
                                Shortcut2_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} SPC700 Player"

                            Case 7
                                Shortcut2_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Floating BPS"

                            Case 8
                                Shortcut2_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Snes9x"

                            Case 9
                                Shortcut2_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Bsnes"

                            Case 10
                                Shortcut2_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Graphics Editor"

                            Case 11
                                Shortcut2_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} YY-CHR"

                        End Select

#End Region

                        Shortcut2_ToolTip.SetToolTip(Shortcut_2, $"{Frm99_TranslateForm.UI01_ShortcutPath.Text} {My.Settings.CUSTOM_SHORTCUT_2_PATH}")

                    Case False
                        Shortcut_2.Enabled = False

                End Select

#Region "                    'Icon' setting "

                Select Case My.Settings.CUSTOM_SHORTCUT_2_ICON
                    Case 0
                        Shortcut_2.Image = My.Resources.Shortcut_Default_2

                    Case 1
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_LM

                    Case 2
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_LE

                    Case 3
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_RLM

                    Case 4
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_SnesGFX

                    Case 5
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_MLLP

                    Case 6
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_HA

                    Case 7
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_H_DMA

                    Case 8
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_MML

                    Case 9
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_AMK

                    Case 10
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_LMU

                    Case 11
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_Organ

                    Case 12
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_Blockreator

                    Case 13
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_PIXI

                    Case 14
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_M7M

                    Case 15
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_SPCPlayer

                    Case 16
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_FLIPS

                    Case 17
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_StatusEffects

                    Case 18
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_SPCT

                    Case 19
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_EffectTool

                    Case 20
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_Molester

                    Case 21
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_GPS

                    Case 22
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_Asar

                    Case 23
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_Snes9x

                    Case 24
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_Snes9xC

                    Case 25
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_MSE

                    Case 26
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_Interaction

                    Case 27
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_MMP

                    Case 28
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_SGFXC

                    Case 29
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_GraphEdit

                    Case 30
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_YYCHR

                    Case 31
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_SMWC

                    Case 32
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_SHTools

                    Case 33
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_UASM

                    Case 34
                        Shortcut_2.Image = My.Resources.Shortcut_Icon_GradientTool

                End Select

#End Region

                ' Shortcut 3
                Select Case My.Settings.ENABLE_CUSTOM_SHORTCUT_3
                    Case True
                        Shortcut_3.Enabled = True

                        Dim Shortcut3_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = $"{Frm99_TranslateForm.UI01_ShortcutTitle.Text} {Shortcut_3.Tag}"}

#Region "                            'Launch with' setting "

                        Select Case My.Settings.CUSTOM_SHORTCUT_3_LAUNCH_WITH
                            Case 0
                                Shortcut3_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutManagedByWindows.Text}"

                            Case 1
                                Shortcut3_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 1{If(My.Settings.LM_SLOT1_NAME = Nothing, "", $" • {My.Settings.LM_SLOT1_NAME}")})"

                            Case 2
                                Shortcut3_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 2{If(My.Settings.LM_SLOT2_NAME = Nothing, "", $" • {My.Settings.LM_SLOT2_NAME}")})"

                            Case 3
                                Shortcut3_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 3{If(My.Settings.LM_SLOT3_NAME = Nothing, "", $" • {My.Settings.LM_SLOT3_NAME}")})"

                            Case 4
                                Shortcut3_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Level Music Utility"

                            Case 5
                                Shortcut3_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} BRR Player"

                            Case 6
                                Shortcut3_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} SPC700 Player"

                            Case 7
                                Shortcut3_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Floating BPS"

                            Case 8
                                Shortcut3_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Snes9x"

                            Case 9
                                Shortcut3_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Bsnes"

                            Case 10
                                Shortcut3_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Graphics Editor"

                            Case 11
                                Shortcut3_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} YY-CHR"

                        End Select

#End Region

                        Shortcut3_ToolTip.SetToolTip(Shortcut_3, $"{Frm99_TranslateForm.UI01_ShortcutPath.Text} {My.Settings.CUSTOM_SHORTCUT_3_PATH}")

                    Case False
                        Shortcut_3.Enabled = False

                End Select

#Region "                    'Icon' setting "

                Select Case My.Settings.CUSTOM_SHORTCUT_3_ICON
                    Case 0
                        Shortcut_3.Image = My.Resources.Shortcut_Default_3

                    Case 1
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_LM

                    Case 2
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_LE

                    Case 3
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_RLM

                    Case 4
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_SnesGFX

                    Case 5
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_MLLP

                    Case 6
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_HA

                    Case 7
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_H_DMA

                    Case 8
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_MML

                    Case 9
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_AMK

                    Case 10
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_LMU

                    Case 11
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_Organ

                    Case 12
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_Blockreator

                    Case 13
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_PIXI

                    Case 14
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_M7M

                    Case 15
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_SPCPlayer

                    Case 16
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_FLIPS

                    Case 17
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_StatusEffects

                    Case 18
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_SPCT

                    Case 19
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_EffectTool

                    Case 20
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_Molester

                    Case 21
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_GPS

                    Case 22
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_Asar

                    Case 23
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_Snes9x

                    Case 24
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_Snes9xC

                    Case 25
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_MSE

                    Case 26
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_Interaction

                    Case 27
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_MMP

                    Case 28
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_SGFXC

                    Case 29
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_GraphEdit

                    Case 30
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_YYCHR

                    Case 31
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_SMWC

                    Case 32
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_SHTools

                    Case 33
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_UASM

                    Case 34
                        Shortcut_3.Image = My.Resources.Shortcut_Icon_GradientTool

                End Select

#End Region

                ' Shortcut 4
                Select Case My.Settings.ENABLE_CUSTOM_SHORTCUT_4
                    Case True
                        Shortcut_4.Enabled = True

                        Dim Shortcut4_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = $"{Frm99_TranslateForm.UI01_ShortcutTitle.Text} {Shortcut_4.Tag}"}

#Region "                            'Launch with' setting "

                        Select Case My.Settings.CUSTOM_SHORTCUT_4_LAUNCH_WITH
                            Case 0
                                Shortcut4_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutManagedByWindows.Text}"

                            Case 1
                                Shortcut4_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 1{If(My.Settings.LM_SLOT1_NAME = Nothing, "", $" • {My.Settings.LM_SLOT1_NAME}")})"

                            Case 2
                                Shortcut4_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 2{If(My.Settings.LM_SLOT2_NAME = Nothing, "", $" • {My.Settings.LM_SLOT2_NAME}")})"

                            Case 3
                                Shortcut4_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 3{If(My.Settings.LM_SLOT3_NAME = Nothing, "", $" • {My.Settings.LM_SLOT3_NAME}")})"

                            Case 4
                                Shortcut4_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Level Music Utility"

                            Case 5
                                Shortcut4_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} BRR Player"

                            Case 6
                                Shortcut4_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} SPC700 Player"

                            Case 7
                                Shortcut4_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Floating BPS"

                            Case 8
                                Shortcut4_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Snes9x"

                            Case 9
                                Shortcut4_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Bsnes"

                            Case 10
                                Shortcut4_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Graphics Editor"

                            Case 11
                                Shortcut4_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} YY-CHR"

                        End Select

#End Region

                        Shortcut4_ToolTip.SetToolTip(Shortcut_4, $"{Frm99_TranslateForm.UI01_ShortcutPath.Text} {My.Settings.CUSTOM_SHORTCUT_4_PATH}")

                    Case False
                        Shortcut_4.Enabled = False

                End Select

#Region "                    'Icon' setting "

                Select Case My.Settings.CUSTOM_SHORTCUT_4_ICON
                    Case 0
                        Shortcut_4.Image = My.Resources.Shortcut_Default_4

                    Case 1
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_LM

                    Case 2
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_LE

                    Case 3
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_RLM

                    Case 4
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_SnesGFX

                    Case 5
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_MLLP

                    Case 6
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_HA

                    Case 7
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_H_DMA

                    Case 8
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_MML

                    Case 9
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_AMK

                    Case 10
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_LMU

                    Case 11
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_Organ

                    Case 12
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_Blockreator

                    Case 13
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_PIXI

                    Case 14
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_M7M

                    Case 15
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_SPCPlayer

                    Case 16
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_FLIPS

                    Case 17
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_StatusEffects

                    Case 18
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_SPCT

                    Case 19
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_EffectTool

                    Case 20
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_Molester

                    Case 21
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_GPS

                    Case 22
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_Asar

                    Case 23
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_Snes9x

                    Case 24
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_Snes9xC

                    Case 25
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_MSE

                    Case 26
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_Interaction

                    Case 27
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_MMP

                    Case 28
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_SGFXC

                    Case 29
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_GraphEdit

                    Case 30
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_YYCHR

                    Case 31
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_SMWC

                    Case 32
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_SHTools

                    Case 33
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_UASM

                    Case 34
                        Shortcut_4.Image = My.Resources.Shortcut_Icon_GradientTool

                End Select

#End Region

                ' Shortcut 5
                Select Case My.Settings.ENABLE_CUSTOM_SHORTCUT_5
                    Case True
                        Shortcut_5.Enabled = True

                        Dim Shortcut5_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = $"{Frm99_TranslateForm.UI01_ShortcutTitle.Text} {Shortcut_5.Tag}"}

#Region "                            'Launch with' setting "

                        Select Case My.Settings.CUSTOM_SHORTCUT_5_LAUNCH_WITH
                            Case 0
                                Shortcut5_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutManagedByWindows.Text}"

                            Case 1
                                Shortcut5_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 1{If(My.Settings.LM_SLOT1_NAME = Nothing, "", $" • {My.Settings.LM_SLOT1_NAME}")})"

                            Case 2
                                Shortcut5_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 2{If(My.Settings.LM_SLOT2_NAME = Nothing, "", $" • {My.Settings.LM_SLOT2_NAME}")})"

                            Case 3
                                Shortcut5_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 3{If(My.Settings.LM_SLOT3_NAME = Nothing, "", $" • {My.Settings.LM_SLOT3_NAME}")})"

                            Case 4
                                Shortcut5_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Level Music Utility"

                            Case 5
                                Shortcut5_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} BRR Player"

                            Case 6
                                Shortcut5_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} SPC700 Player"

                            Case 7
                                Shortcut5_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Floating BPS"

                            Case 8
                                Shortcut5_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Snes9x"

                            Case 9
                                Shortcut5_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Bsnes"

                            Case 10
                                Shortcut5_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Graphics Editor"

                            Case 11
                                Shortcut5_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} YY-CHR"

                        End Select

#End Region

                        Shortcut5_ToolTip.SetToolTip(Shortcut_5, $"{Frm99_TranslateForm.UI01_ShortcutPath.Text} {My.Settings.CUSTOM_SHORTCUT_5_PATH}")

                    Case False
                        Shortcut_5.Enabled = False

                End Select

#Region "                    'Icon' setting "

                Select Case My.Settings.CUSTOM_SHORTCUT_5_ICON
                    Case 0
                        Shortcut_5.Image = My.Resources.Shortcut_Default_5

                    Case 1
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_LM

                    Case 2
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_LE

                    Case 3
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_RLM

                    Case 4
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_SnesGFX

                    Case 5
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_MLLP

                    Case 6
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_HA

                    Case 7
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_H_DMA

                    Case 8
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_MML

                    Case 9
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_AMK

                    Case 10
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_LMU

                    Case 11
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_Organ

                    Case 12
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_Blockreator

                    Case 13
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_PIXI

                    Case 14
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_M7M

                    Case 15
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_SPCPlayer

                    Case 16
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_FLIPS

                    Case 17
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_StatusEffects

                    Case 18
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_SPCT

                    Case 19
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_EffectTool

                    Case 20
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_Molester

                    Case 21
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_GPS

                    Case 22
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_Asar

                    Case 23
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_Snes9x

                    Case 24
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_Snes9xC

                    Case 25
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_MSE

                    Case 26
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_Interaction

                    Case 27
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_MMP

                    Case 28
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_SGFXC

                    Case 29
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_GraphEdit

                    Case 30
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_YYCHR

                    Case 31
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_SMWC

                    Case 32
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_SHTools

                    Case 33
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_UASM

                    Case 34
                        Shortcut_5.Image = My.Resources.Shortcut_Icon_GradientTool

                End Select

#End Region

                ' Shortcut 6
                Select Case My.Settings.ENABLE_CUSTOM_SHORTCUT_6
                    Case True
                        Shortcut_6.Enabled = True

                        Dim Shortcut6_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = $"{Frm99_TranslateForm.UI01_ShortcutTitle.Text} {Shortcut_6.Tag}"}

#Region "                            'Launch with' setting "

                        Select Case My.Settings.CUSTOM_SHORTCUT_5_LAUNCH_WITH
                            Case 0
                                Shortcut6_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutManagedByWindows.Text}"

                            Case 1
                                Shortcut6_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 1{If(My.Settings.LM_SLOT1_NAME = Nothing, "", $" • {My.Settings.LM_SLOT1_NAME}")})"

                            Case 2
                                Shortcut6_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 2{If(My.Settings.LM_SLOT2_NAME = Nothing, "", $" • {My.Settings.LM_SLOT2_NAME}")})"

                            Case 3
                                Shortcut6_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Lunar Magic (Slot 3{If(My.Settings.LM_SLOT3_NAME = Nothing, "", $" • {My.Settings.LM_SLOT3_NAME}")})"

                            Case 4
                                Shortcut6_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Level Music Utility"

                            Case 5
                                Shortcut6_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} BRR Player"

                            Case 6
                                Shortcut6_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} SPC700 Player"

                            Case 7
                                Shortcut6_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Floating BPS"

                            Case 8
                                Shortcut6_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Snes9x"

                            Case 9
                                Shortcut6_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Bsnes"

                            Case 10
                                Shortcut6_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} Graphics Editor"

                            Case 11
                                Shortcut6_ToolTip.ToolTipTitle += $" • {Frm99_TranslateForm.UI01_ShortcutLaunchWith.Text} YY-CHR"

                        End Select

#End Region

                        Shortcut6_ToolTip.SetToolTip(Shortcut_6, $"{Frm99_TranslateForm.UI01_ShortcutPath.Text} {My.Settings.CUSTOM_SHORTCUT_6_PATH}")

                    Case False
                        Shortcut_6.Enabled = False

                End Select

#Region "                    'Icon' setting "

                Select Case My.Settings.CUSTOM_SHORTCUT_6_ICON
                    Case 0
                        Shortcut_6.Image = My.Resources.Shortcut_Default_6

                    Case 1
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_LM

                    Case 2
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_LE

                    Case 3
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_RLM

                    Case 4
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_SnesGFX

                    Case 5
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_MLLP

                    Case 6
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_HA

                    Case 7
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_H_DMA

                    Case 8
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_MML

                    Case 9
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_AMK

                    Case 10
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_LMU

                    Case 11
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_Organ

                    Case 12
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_Blockreator

                    Case 13
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_PIXI

                    Case 14
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_M7M

                    Case 15
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_SPCPlayer

                    Case 16
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_FLIPS

                    Case 17
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_StatusEffects

                    Case 18
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_SPCT

                    Case 19
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_EffectTool

                    Case 20
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_Molester

                    Case 21
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_GPS

                    Case 22
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_Asar

                    Case 23
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_Snes9x

                    Case 24
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_Snes9xC

                    Case 25
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_MSE

                    Case 26
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_Interaction

                    Case 27
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_MMP

                    Case 28
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_SGFXC

                    Case 29
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_GraphEdit

                    Case 30
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_YYCHR

                    Case 31
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_SMWC

                    Case 32
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_SHTools

                    Case 33
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_UASM

                    Case 34
                        Shortcut_6.Image = My.Resources.Shortcut_Icon_GradientTool

                End Select

#End Region

        End Select

        ' ---------------------------------------------------------------------------------------------------------------------
        ' Applications buttons

        ' Lunar Magic - Slot 1
        Select Case My.Settings.LM_SLOT1_ENABLED
            Case True
                Select Case IO.File.Exists(My.Settings.LM_SLOT1_PATH)
                    Case True
                        LM_Option_1.Enabled = True

#Region "                            Button Icon set "

                        Select Case My.Settings.LM_SLOT1_VERSION
                            Case 0
                                LM_Option_1.Image = My.Resources.LM_NEWER
                            Case 1
                                LM_Option_1.Image = My.Resources.LM_100
                            Case 2
                                LM_Option_1.Image = My.Resources.LM_101
                            Case 3
                                LM_Option_1.Image = My.Resources.LM_102
                            Case 4
                                LM_Option_1.Image = My.Resources.LM_103
                            Case 5
                                LM_Option_1.Image = My.Resources.LM_110
                            Case 6
                                LM_Option_1.Image = My.Resources.LM_111
                            Case 7
                                LM_Option_1.Image = My.Resources.LM_120
                            Case 8
                                LM_Option_1.Image = My.Resources.LM_130
                            Case 9
                                LM_Option_1.Image = My.Resources.LM_131
                            Case 10
                                LM_Option_1.Image = My.Resources.LM_140
                            Case 11
                                LM_Option_1.Image = My.Resources.LM_141
                            Case 12
                                LM_Option_1.Image = My.Resources.LM_142
                            Case 13
                                LM_Option_1.Image = My.Resources.LM_143
                            Case 14
                                LM_Option_1.Image = My.Resources.LM_150
                            Case 15
                                LM_Option_1.Image = My.Resources.LM_151
                            Case 16
                                LM_Option_1.Image = My.Resources.LM_160
                            Case 17
                                LM_Option_1.Image = My.Resources.LM_161
                            Case 18
                                LM_Option_1.Image = My.Resources.LM_162
                            Case 19
                                LM_Option_1.Image = My.Resources.LM_163
                            Case 20
                                LM_Option_1.Image = My.Resources.LM_164
                            Case 21
                                LM_Option_1.Image = My.Resources.LM_165
                            Case 22
                                LM_Option_1.Image = My.Resources.LM_170
                            Case 23
                                LM_Option_1.Image = My.Resources.LM_171
                            Case 24
                                LM_Option_1.Image = My.Resources.LM_180
                            Case 25
                                LM_Option_1.Image = My.Resources.LM_181
                            Case 26
                                LM_Option_1.Image = My.Resources.LM_182
                            Case 27
                                LM_Option_1.Image = My.Resources.LM_190
                            Case 28
                                LM_Option_1.Image = My.Resources.LM_191
                            Case 29
                                LM_Option_1.Image = My.Resources.LM_200
                            Case 30
                                LM_Option_1.Image = My.Resources.LM_201
                            Case 31
                                LM_Option_1.Image = My.Resources.LM_210
                            Case 32
                                LM_Option_1.Image = My.Resources.LM_211
                            Case 33
                                LM_Option_1.Image = My.Resources.LM_212
                            Case 34
                                LM_Option_1.Image = My.Resources.LM_220
                            Case 35
                                LM_Option_1.Image = My.Resources.LM_221
                            Case 36
                                LM_Option_1.Image = My.Resources.LM_222
                            Case 37
                                LM_Option_1.Image = My.Resources.LM_230
                            Case 38
                                LM_Option_1.Image = My.Resources.LM_231
                            Case 39
                                LM_Option_1.Image = My.Resources.LM_232
                            Case 40
                                LM_Option_1.Image = My.Resources.LM_240
                            Case 41
                                LM_Option_1.Image = My.Resources.LM_241
                            Case 42
                                LM_Option_1.Image = My.Resources.LM_242
                            Case 43
                                LM_Option_1.Image = My.Resources.LM_243
                            Case 44
                                LM_Option_1.Image = My.Resources.LM_250
                            Case 45
                                LM_Option_1.Image = My.Resources.LM_251
                            Case 46
                                LM_Option_1.Image = My.Resources.LM_252
                            Case 47
                                LM_Option_1.Image = My.Resources.LM_253
                            Case 48
                                LM_Option_1.Image = My.Resources.LM_300
                            Case 49
                                LM_Option_1.Image = My.Resources.LM_301
                            Case 50
                                LM_Option_1.Image = My.Resources.LM_302
                            Case 51
                                LM_Option_1.Image = My.Resources.LM_303
                            Case 52
                                LM_Option_1.Image = My.Resources.LM_304
                            Case 53
                                LM_Option_1.Image = My.Resources.LM_310
                            Case 54
                                LM_Option_1.Image = My.Resources.LM_311
                            Case 55
                                LM_Option_1.Image = My.Resources.LM_320
                            Case 56
                                LM_Option_1.Image = My.Resources.LM_321
                            Case 57
                                LM_Option_1.Image = My.Resources.LM_330
                            Case 58
                                LM_Option_1.Image = My.Resources.LM_331
                            Case 59
                                LM_Option_1.Image = My.Resources.LM_NORMAL
                        End Select

#End Region

                    Case False
                        LM_Option_1.Enabled = False
                        LM_Option_1.Image = My.Resources.LM_NORMAL

                End Select

            Case False
                LM_Option_1.Enabled = False
                LM_Option_1.Image = My.Resources.LM_NORMAL

        End Select

        Dim LM_SubBtn1_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = $"{LM_Button.Tag} • Slot 1{If(My.Settings.LM_SLOT1_NAME = Nothing, "", $" ({My.Settings.LM_SLOT1_NAME})")}"}
        LM_SubBtn1_ToolTip.SetToolTip(LM_Option_1, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.LM_SLOT1_PATH}")

        ' Lunar Magic - Slot 2
        Select Case My.Settings.LM_SLOT1_ENABLED
            Case True
                Select Case IO.File.Exists(My.Settings.LM_SLOT2_PATH)
                    Case True
                        LM_Option_2.Enabled = True

#Region "                            Button Icon set "

                        Select Case My.Settings.LM_SLOT2_VERSION
                            Case 0
                                LM_Option_2.Image = My.Resources.LM_NEWER
                            Case 1
                                LM_Option_2.Image = My.Resources.LM_100
                            Case 2
                                LM_Option_2.Image = My.Resources.LM_101
                            Case 3
                                LM_Option_2.Image = My.Resources.LM_102
                            Case 4
                                LM_Option_2.Image = My.Resources.LM_103
                            Case 5
                                LM_Option_2.Image = My.Resources.LM_110
                            Case 6
                                LM_Option_2.Image = My.Resources.LM_111
                            Case 7
                                LM_Option_2.Image = My.Resources.LM_120
                            Case 8
                                LM_Option_2.Image = My.Resources.LM_130
                            Case 9
                                LM_Option_2.Image = My.Resources.LM_131
                            Case 10
                                LM_Option_2.Image = My.Resources.LM_140
                            Case 11
                                LM_Option_2.Image = My.Resources.LM_141
                            Case 12
                                LM_Option_2.Image = My.Resources.LM_142
                            Case 13
                                LM_Option_2.Image = My.Resources.LM_143
                            Case 14
                                LM_Option_2.Image = My.Resources.LM_150
                            Case 15
                                LM_Option_2.Image = My.Resources.LM_151
                            Case 16
                                LM_Option_2.Image = My.Resources.LM_160
                            Case 17
                                LM_Option_2.Image = My.Resources.LM_161
                            Case 18
                                LM_Option_2.Image = My.Resources.LM_162
                            Case 19
                                LM_Option_2.Image = My.Resources.LM_163
                            Case 20
                                LM_Option_2.Image = My.Resources.LM_164
                            Case 21
                                LM_Option_2.Image = My.Resources.LM_165
                            Case 22
                                LM_Option_2.Image = My.Resources.LM_170
                            Case 23
                                LM_Option_2.Image = My.Resources.LM_171
                            Case 24
                                LM_Option_2.Image = My.Resources.LM_180
                            Case 25
                                LM_Option_2.Image = My.Resources.LM_181
                            Case 26
                                LM_Option_2.Image = My.Resources.LM_182
                            Case 27
                                LM_Option_2.Image = My.Resources.LM_190
                            Case 28
                                LM_Option_2.Image = My.Resources.LM_191
                            Case 29
                                LM_Option_2.Image = My.Resources.LM_200
                            Case 30
                                LM_Option_2.Image = My.Resources.LM_201
                            Case 31
                                LM_Option_2.Image = My.Resources.LM_210
                            Case 32
                                LM_Option_2.Image = My.Resources.LM_211
                            Case 33
                                LM_Option_2.Image = My.Resources.LM_212
                            Case 34
                                LM_Option_2.Image = My.Resources.LM_220
                            Case 35
                                LM_Option_2.Image = My.Resources.LM_221
                            Case 36
                                LM_Option_2.Image = My.Resources.LM_222
                            Case 37
                                LM_Option_2.Image = My.Resources.LM_230
                            Case 38
                                LM_Option_2.Image = My.Resources.LM_231
                            Case 39
                                LM_Option_2.Image = My.Resources.LM_232
                            Case 40
                                LM_Option_2.Image = My.Resources.LM_240
                            Case 41
                                LM_Option_2.Image = My.Resources.LM_241
                            Case 42
                                LM_Option_2.Image = My.Resources.LM_242
                            Case 43
                                LM_Option_2.Image = My.Resources.LM_243
                            Case 44
                                LM_Option_2.Image = My.Resources.LM_250
                            Case 45
                                LM_Option_2.Image = My.Resources.LM_251
                            Case 46
                                LM_Option_2.Image = My.Resources.LM_252
                            Case 47
                                LM_Option_2.Image = My.Resources.LM_253
                            Case 48
                                LM_Option_2.Image = My.Resources.LM_300
                            Case 49
                                LM_Option_2.Image = My.Resources.LM_301
                            Case 50
                                LM_Option_2.Image = My.Resources.LM_302
                            Case 51
                                LM_Option_2.Image = My.Resources.LM_303
                            Case 52
                                LM_Option_2.Image = My.Resources.LM_304
                            Case 53
                                LM_Option_2.Image = My.Resources.LM_310
                            Case 54
                                LM_Option_2.Image = My.Resources.LM_311
                            Case 55
                                LM_Option_2.Image = My.Resources.LM_320
                            Case 56
                                LM_Option_2.Image = My.Resources.LM_321
                            Case 57
                                LM_Option_2.Image = My.Resources.LM_330
                            Case 58
                                LM_Option_2.Image = My.Resources.LM_331
                            Case 59
                                LM_Option_2.Image = My.Resources.LM_NORMAL
                        End Select

#End Region

                    Case False
                        LM_Option_2.Enabled = False
                        LM_Option_2.Image = My.Resources.LM_NORMAL

                End Select

            Case False
                LM_Option_2.Enabled = False
                LM_Option_2.Image = My.Resources.LM_NORMAL

        End Select

        Dim LM_SubBtn2_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = $"{LM_Button.Tag} • Slot 2{If(My.Settings.LM_SLOT2_NAME = Nothing, "", $" ({My.Settings.LM_SLOT2_NAME})")}"}
        LM_SubBtn2_ToolTip.SetToolTip(LM_Option_2, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.LM_SLOT2_PATH}")

        ' Lunar Magic - Slot 3
        Select Case My.Settings.LM_SLOT3_ENABLED
            Case True
                Select Case IO.File.Exists(My.Settings.LM_SLOT3_PATH)
                    Case True
                        LM_Option_3.Enabled = True

#Region "                            Button Icon set "

                        Select Case My.Settings.LM_SLOT3_VERSION
                            Case 0
                                LM_Option_3.Image = My.Resources.LM_NEWER
                            Case 1
                                LM_Option_3.Image = My.Resources.LM_100
                            Case 2
                                LM_Option_3.Image = My.Resources.LM_101
                            Case 3
                                LM_Option_3.Image = My.Resources.LM_102
                            Case 4
                                LM_Option_3.Image = My.Resources.LM_103
                            Case 5
                                LM_Option_3.Image = My.Resources.LM_110
                            Case 6
                                LM_Option_3.Image = My.Resources.LM_111
                            Case 7
                                LM_Option_3.Image = My.Resources.LM_120
                            Case 8
                                LM_Option_3.Image = My.Resources.LM_130
                            Case 9
                                LM_Option_3.Image = My.Resources.LM_131
                            Case 10
                                LM_Option_3.Image = My.Resources.LM_140
                            Case 11
                                LM_Option_3.Image = My.Resources.LM_141
                            Case 12
                                LM_Option_3.Image = My.Resources.LM_142
                            Case 13
                                LM_Option_3.Image = My.Resources.LM_143
                            Case 14
                                LM_Option_3.Image = My.Resources.LM_150
                            Case 15
                                LM_Option_3.Image = My.Resources.LM_151
                            Case 16
                                LM_Option_3.Image = My.Resources.LM_160
                            Case 17
                                LM_Option_3.Image = My.Resources.LM_161
                            Case 18
                                LM_Option_3.Image = My.Resources.LM_162
                            Case 19
                                LM_Option_3.Image = My.Resources.LM_163
                            Case 20
                                LM_Option_3.Image = My.Resources.LM_164
                            Case 21
                                LM_Option_3.Image = My.Resources.LM_165
                            Case 22
                                LM_Option_3.Image = My.Resources.LM_170
                            Case 23
                                LM_Option_3.Image = My.Resources.LM_171
                            Case 24
                                LM_Option_3.Image = My.Resources.LM_180
                            Case 25
                                LM_Option_3.Image = My.Resources.LM_181
                            Case 26
                                LM_Option_3.Image = My.Resources.LM_182
                            Case 27
                                LM_Option_3.Image = My.Resources.LM_190
                            Case 28
                                LM_Option_3.Image = My.Resources.LM_191
                            Case 29
                                LM_Option_3.Image = My.Resources.LM_200
                            Case 30
                                LM_Option_3.Image = My.Resources.LM_201
                            Case 31
                                LM_Option_3.Image = My.Resources.LM_210
                            Case 32
                                LM_Option_3.Image = My.Resources.LM_211
                            Case 33
                                LM_Option_3.Image = My.Resources.LM_212
                            Case 34
                                LM_Option_3.Image = My.Resources.LM_220
                            Case 35
                                LM_Option_3.Image = My.Resources.LM_221
                            Case 36
                                LM_Option_3.Image = My.Resources.LM_222
                            Case 37
                                LM_Option_3.Image = My.Resources.LM_230
                            Case 38
                                LM_Option_3.Image = My.Resources.LM_231
                            Case 39
                                LM_Option_3.Image = My.Resources.LM_232
                            Case 40
                                LM_Option_3.Image = My.Resources.LM_240
                            Case 41
                                LM_Option_3.Image = My.Resources.LM_241
                            Case 42
                                LM_Option_3.Image = My.Resources.LM_242
                            Case 43
                                LM_Option_3.Image = My.Resources.LM_243
                            Case 44
                                LM_Option_3.Image = My.Resources.LM_250
                            Case 45
                                LM_Option_3.Image = My.Resources.LM_251
                            Case 46
                                LM_Option_3.Image = My.Resources.LM_252
                            Case 47
                                LM_Option_3.Image = My.Resources.LM_253
                            Case 48
                                LM_Option_3.Image = My.Resources.LM_300
                            Case 49
                                LM_Option_3.Image = My.Resources.LM_301
                            Case 50
                                LM_Option_3.Image = My.Resources.LM_302
                            Case 51
                                LM_Option_3.Image = My.Resources.LM_303
                            Case 52
                                LM_Option_3.Image = My.Resources.LM_304
                            Case 53
                                LM_Option_3.Image = My.Resources.LM_310
                            Case 54
                                LM_Option_3.Image = My.Resources.LM_311
                            Case 55
                                LM_Option_3.Image = My.Resources.LM_320
                            Case 56
                                LM_Option_3.Image = My.Resources.LM_321
                            Case 57
                                LM_Option_3.Image = My.Resources.LM_330
                            Case 58
                                LM_Option_3.Image = My.Resources.LM_331
                            Case 59
                                LM_Option_3.Image = My.Resources.LM_NORMAL
                        End Select

#End Region

                    Case False
                        LM_Option_3.Enabled = False
                        LM_Option_3.Image = My.Resources.LM_NORMAL

                End Select

            Case False
                LM_Option_3.Enabled = False
                LM_Option_3.Image = My.Resources.LM_NORMAL

        End Select

        Dim LM_SubBtn3_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = $"{LM_Button.Tag} • Slot 3{If(My.Settings.LM_SLOT3_NAME = Nothing, "", $" ({My.Settings.LM_SLOT3_NAME})")}"}
        LM_SubBtn3_ToolTip.SetToolTip(LM_Option_3, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.LM_SLOT3_PATH}")

        ' Lunar Magic - Main button
        If LM_Option_1.Enabled = False And LM_Option_2.Enabled = False And LM_Option_3.Enabled = False Then
            LM_Button.Enabled = False
        Else
            LM_Button.Enabled = True
        End If

        Dim LM_MainBtn_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500}

        Select Case My.Settings.LM_1CTL_ENABLED
            Case True
                Select Case My.Settings.LM_1CTL_SELECTED_VERSION
                    Case 0
                        LM_MainBtn_ToolTip.ToolTipTitle = $"{LM_Button.Tag} • {Frm99_TranslateForm.UI01_SelectedLMSlot.Text} 1{If(My.Settings.LM_SLOT1_NAME = Nothing, "", $" ({My.Settings.LM_SLOT1_NAME})")}"
                        LM_MainBtn_ToolTip.SetToolTip(LM_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.LM_SLOT1_PATH}")
                        LM_Button.Image = LM_Option_1.Image

                        Select Case IO.File.Exists(My.Settings.LM_SLOT1_PATH)
                            Case False
                                LM_MainBtn_ToolTip.SetToolTip(LM_Button, $"{Frm99_TranslateForm.UI01_LM1CTL_PathError.Text} ({My.Settings.LM_SLOT1_PATH})")
                                LM_Button.Image = My.Resources.LM_1CTL_Error

                        End Select

                    Case 1
                        LM_MainBtn_ToolTip.ToolTipTitle = $"{LM_Button.Tag} • {Frm99_TranslateForm.UI01_SelectedLMSlot.Text} 2{If(My.Settings.LM_SLOT2_NAME = Nothing, "", $" ({My.Settings.LM_SLOT2_NAME})")}"
                        LM_MainBtn_ToolTip.SetToolTip(LM_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.LM_SLOT2_PATH}")
                        LM_Button.Image = LM_Option_2.Image

                        Select Case IO.File.Exists(My.Settings.LM_SLOT2_PATH)
                            Case False
                                LM_MainBtn_ToolTip.SetToolTip(LM_Button, $"{Frm99_TranslateForm.UI01_LM1CTL_PathError.Text} ({My.Settings.LM_SLOT2_PATH})")
                                LM_Button.Image = My.Resources.LM_1CTL_Error

                        End Select

                    Case 2
                        LM_MainBtn_ToolTip.ToolTipTitle = $"{LM_Button.Tag} • {Frm99_TranslateForm.UI01_SelectedLMSlot.Text} 3{If(My.Settings.LM_SLOT3_NAME = Nothing, "", $" ({My.Settings.LM_SLOT3_NAME})")}"
                        LM_MainBtn_ToolTip.SetToolTip(LM_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.LM_SLOT3_PATH}")
                        LM_Button.Image = LM_Option_3.Image

                        Select Case IO.File.Exists(My.Settings.LM_SLOT3_PATH)
                            Case False
                                LM_MainBtn_ToolTip.SetToolTip(LM_Button, $"{Frm99_TranslateForm.UI01_LM1CTL_PathError.Text} ({My.Settings.LM_SLOT3_NAME})")
                                LM_Button.Image = My.Resources.LM_1CTL_Error

                        End Select

                End Select

            Case False
                LM_MainBtn_ToolTip.ToolTipTitle = LM_Button.Tag
                LM_MainBtn_ToolTip.SetToolTip(LM_Button, Frm99_TranslateForm.UI01_OpenSubMenuDesc.Text)
                LM_Button.Image = My.Resources.LM_NORMAL

        End Select

        ' Lunar Expand
        Dim LE_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = LE_Button.Tag}
        LE_ToolTip.SetToolTip(LE_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.LUNAREXPAND_PATH}")
        LE_Button.Enabled = IO.File.Exists(My.Settings.LUNAREXPAND_PATH)

        ' Recover Lunar Magic
        Dim RLM_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = RLM_Button.Tag}
        RLM_ToolTip.SetToolTip(RLM_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.RECOVERLM_PATH}")
        RLM_Button.Enabled = IO.File.Exists(My.Settings.RECOVERLM_PATH)

        ' SnesGFX
        Dim SNESGFX_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = SNESGFX_Button.Tag}
        SNESGFX_ToolTip.SetToolTip(SNESGFX_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.SNESGFX_PATH}")
        SNESGFX_Button.Enabled = IO.File.Exists(My.Settings.SNESGFX_PATH)

        ' Mario/Luigi Live Palette Editor
        Dim MarioLPE_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = MarioLPE_Button.Tag}
        MarioLPE_ToolTip.SetToolTip(MarioLPE_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.MARIOLLPE_PATH}")
        MarioLPE_Button.Enabled = IO.File.Exists(My.Settings.MARIOLLPE_PATH)

        ' HeAdder
        Dim HeAdder_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = HeAdder_Button.Tag}
        HeAdder_ToolTip.SetToolTip(HeAdder_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.HEADDER_PATH}")
        HeAdder_Button.Enabled = IO.File.Exists(My.Settings.HEADDER_PATH)

        ' H-DMA Gradient Ripper
        Dim HDMA_GR_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = HDMA_GR_Button.Tag}
        HDMA_GR_ToolTip.SetToolTip(HDMA_GR_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.HDMA_GRAD_RIPPER_PATH}")
        HDMA_GR_Button.Enabled = IO.File.Exists(My.Settings.HDMA_GRAD_RIPPER_PATH)

        ' ---------------------------------------------------------------------------------------------------------------------

        ' MML Editing Tool
        Dim MML_Edit_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = MML_Edit_Button.Tag}
        MML_Edit_ToolTip.SetToolTip(MML_Edit_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.MMLEDIT_PATH}")
        MML_Edit_Button.Enabled = IO.File.Exists(My.Settings.MMLEDIT_PATH)

        ' AddMusick - Via CMD Version
        Dim AMK_Option_1_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_ViaCMD.Text}
        AMK_Option_1_ToolTip.SetToolTip(AMK_Option_1, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.ADDMUSICK_CMD_PATH}")
        AMK_Option_1.Enabled = IO.File.Exists(My.Settings.ADDMUSICK_CMD_PATH)

        ' AddMusick - Via GUI Version
        Dim AMK_Option_2_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_ViaGUI.Text}
        AMK_Option_2_ToolTip.SetToolTip(AMK_Option_2, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.ADDMUSICK_GUI_PATH}")
        AMK_Option_2.Enabled = IO.File.Exists(My.Settings.ADDMUSICK_GUI_PATH)

        ' AddMusick - Open folder
        Dim AMK_Option_3_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_OpenFolder.Text}
        Try
            AMK_Option_3_ToolTip.SetToolTip(AMK_Option_3, $"{Frm99_TranslateForm.UI01_FolderPath.Text} {IO.Directory.GetParent(My.Settings.ADDMUSICK_CMD_PATH)}")
        Catch ex As Exception
            AMK_Option_3_ToolTip.SetToolTip(AMK_Option_3, $"{Frm99_TranslateForm.UI01_FolderPath.Text} ...")
        End Try
        Try
            AMK_Option_3.Enabled = IO.Directory.Exists(IO.Directory.GetParent(My.Settings.ADDMUSICK_CMD_PATH).ToString)
        Catch ex As Exception
            AMK_Option_3.Enabled = False
        End Try

        ' AddMusicK - Main button
        Dim AMK_MainBtn_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = AMK_Button.Tag}
        AMK_MainBtn_ToolTip.SetToolTip(AMK_Button, Frm99_TranslateForm.UI01_OpenSubMenuDesc.Text)
        If AMK_Option_1.Enabled = False And AMK_Option_2.Enabled = False And AMK_Option_3.Enabled = False Then
            AMK_Button.Enabled = False
        Else
            AMK_Button.Enabled = True
        End If

        ' Level Music Utility
        Dim LvMusUtil_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = LvlMusicUtil_Button.Tag}
        LvMusUtil_ToolTip.SetToolTip(LvlMusicUtil_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.LVMUSUTIL_PATH}")
        LvlMusicUtil_Button.Enabled = IO.File.Exists(My.Settings.LVMUSUTIL_PATH)

        ' BRR Player
        Dim BRRPlayer_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = BRRPlayer_Button.Tag}
        BRRPlayer_ToolTip.SetToolTip(BRRPlayer_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.BRRPLAYER_PATH}")
        BRRPlayer_Button.Enabled = IO.File.Exists(My.Settings.BRRPLAYER_PATH)

        ' ---------------------------------------------------------------------------------------------------------------------
        ' Blockreator
        Dim Blockreator_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Blockreator_Button.Tag}
        Blockreator_ToolTip.SetToolTip(Blockreator_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.BLOCKREATOR_PATH}")
        Blockreator_Button.Enabled = IO.File.Exists(My.Settings.BLOCKREATOR_PATH)

        ' Pixi - Run program
        Dim PIXI_Option_1_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_RunApp.Text}
        PIXI_Option_1_ToolTip.SetToolTip(PIXI_Option_1, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.PIXI_MAIN_PATH}")
        PIXI_Option_1.Enabled = IO.File.Exists(My.Settings.PIXI_MAIN_PATH)

        ' Pixi - Open Configurator
        Dim PIXI_Option_2_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_OpenConfig.Text}
        PIXI_Option_2_ToolTip.SetToolTip(PIXI_Option_2, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.PIXI_CONFIG_PATH}")
        PIXI_Option_2.Enabled = IO.File.Exists(My.Settings.PIXI_CONFIG_PATH)

        ' Pixi - Main button
        Dim PIXI_MainBtn_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = PIXI_Button.Tag}
        PIXI_MainBtn_ToolTip.SetToolTip(PIXI_Button, Frm99_TranslateForm.UI01_OpenSubMenuDesc.Text)
        If PIXI_Option_1.Enabled = False And PIXI_Option_2.Enabled = False Then
            PIXI_Button.Enabled = False
        Else
            PIXI_Button.Enabled = True
        End If

        ' M7Map
        Dim M7MAP_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = M7MAP_Button.Tag}
        M7MAP_ToolTip.SetToolTip(M7MAP_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.M7MAP_PATH}")
        M7MAP_Button.Enabled = IO.File.Exists(My.Settings.M7MAP_PATH)

        ' SNES SPC700 Player
        Dim SPC700_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = SPC700_Button.Tag}
        SPC700_ToolTip.SetToolTip(SPC700_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.SPC700PLAYER_PATH}")
        SPC700_Button.Enabled = IO.File.Exists(My.Settings.SPC700PLAYER_PATH)

        ' Floating IPS
        Dim FLIPS_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = FLIPS_Button.Tag}
        FLIPS_ToolTip.SetToolTip(FLIPS_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.FLOATINGIPS_PATH}")
        FLIPS_Button.Enabled = IO.File.Exists(My.Settings.FLOATINGIPS_PATH)

        ' Status Effects
        Dim STAEFF_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = STAEFF_Button.Tag}
        STAEFF_ToolTip.SetToolTip(STAEFF_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.STATUSEFFECTS_PATH}")
        STAEFF_Button.Enabled = IO.File.Exists(My.Settings.STATUSEFFECTS_PATH)

        ' SNES Color Tool
        Dim SNESColorTool_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = SNESColorTool_Button.Tag}
        SNESColorTool_ToolTip.SetToolTip(SNESColorTool_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.SNESCOLORTOOL_PATH}")
        SNESColorTool_Button.Enabled = IO.File.Exists(My.Settings.SNESCOLORTOOL_PATH)

        ' Effect Tool
        Dim EFFTOOL_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = EFFTOOL_Button.Tag}
        EFFTOOL_ToolTip.SetToolTip(EFFTOOL_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.EFFECTTOOL_PATH}")
        EFFTOOL_Button.Enabled = IO.File.Exists(My.Settings.EFFECTTOOL_PATH)

        ' Gopher Popcorn Stew
        Dim GPS_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = GPS_Button.Tag}
        GPS_ToolTip.SetToolTip(GPS_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.GOPHERPOPCORNSTEW_PATH}")
        GPS_Button.Enabled = IO.File.Exists(My.Settings.GOPHERPOPCORNSTEW_PATH)

        ' PetiteMM
        Dim PMM_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = PMM_Button.Tag}
        PMM_ToolTip.SetToolTip(PMM_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.PETITEMM_PATH}")
        PMM_Button.Enabled = IO.Directory.Exists(My.Settings.PETITEMM_PATH)

        ' ---------------------------------------------------------------------------------------------------------------------
        ' Asar
        Dim Asar_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Asar_Button.Tag}
        Asar_ToolTip.SetToolTip(Asar_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.ASAR_PATH}")
        Asar_Button.Enabled = IO.File.Exists(My.Settings.ASAR_PATH)

        ' Snes9x / Bsnes
        Select Case My.Settings.SNES_SELECTED_EMULATOR
            Case 0
                Snes9x_Button.Visible = True
                Bsnes_Button.Visible = False

            Case 1
                Snes9x_Button.Visible = False
                Bsnes_Button.Visible = True

            Case 2
                Snes9x_Button.Visible = True
                Bsnes_Button.Visible = True

        End Select

        ' Snes9x
        Dim Snes9x_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = $"{Snes9x_Button.Tag} • {Frm99_TranslateForm.UI01_SelectedArch.Text} {If(My.Settings.SNES9x_SELECTED_ARCH = 0, "x86", "x64")}"}
        Snes9x_ToolTip.SetToolTip(Snes9x_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {If(My.Settings.SNES9x_SELECTED_ARCH = 0, My.Settings.SNES9x_PATH_x86, My.Settings.SNES9x_PATH_x64)}")

        Select Case My.Settings.SNES9x_USE_COLORED_ICON
            Case True
                Snes9x_Button.Image = If(My.Settings.SNES9x_SELECTED_ARCH = 0, My.Resources.Snes9x_C_x86, My.Resources.Snes9x_C_x64)

            Case False
                Snes9x_Button.Image = If(My.Settings.SNES9x_SELECTED_ARCH = 0, My.Resources.Snes9x_x86, My.Resources.Snes9x_x64)

        End Select

        Snes9x_Button.Enabled = IO.File.Exists(If(My.Settings.SNES9x_SELECTED_ARCH = 0, My.Settings.SNES9x_PATH_x86, My.Settings.SNES9x_PATH_x64))

        ' Bsnes
        Dim Bsnes_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Bsnes_Button.Tag}
        Bsnes_ToolTip.SetToolTip(Bsnes_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.BSNES_PATH_x64}")
        Bsnes_Button.Enabled = IO.File.Exists(My.Settings.BSNES_PATH_x64)

        ' Mario Start Editor
        Dim MarioStartE_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = MarioStartE_Button.Tag}
        MarioStartE_ToolTip.SetToolTip(MarioStartE_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.MARIOSTARTEDITOR_PATH}")
        MarioStartE_Button.Enabled = IO.File.Exists(My.Settings.MARIOSTARTEDITOR_PATH)

        ' Interaction Editor
        Dim InterEdit_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = InterEdit_Button.Tag}
        InterEdit_ToolTip.SetToolTip(InterEdit_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.INTERACTIONEDITOR_PATH}")
        InterEdit_Button.Enabled = IO.File.Exists(My.Settings.INTERACTIONEDITOR_PATH)

        ' Multiple Midway Points
        Dim MMP_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = MMP_Button.Tag}
        MMP_ToolTip.SetToolTip(MMP_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.MULTIPLEMIDWAYPOINTS_PATH}")
        MMP_Button.Enabled = IO.File.Exists(My.Settings.MULTIPLEMIDWAYPOINTS_PATH)

        ' Sprite GFX Creator
        Dim SprGFXCrea_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = SprGFXCrea_Button.Tag}
        SprGFXCrea_ToolTip.SetToolTip(SprGFXCrea_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.SPRITEGFXCREATOR_PATH}")
        SprGFXCrea_Button.Enabled = IO.File.Exists(My.Settings.SPRITEGFXCREATOR_PATH)

        ' Graphic Editor
        Dim GraphEdit_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = GraphEdit_Button.Tag}
        GraphEdit_ToolTip.SetToolTip(GraphEdit_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.GRAPHICEDITOR_PATH}")
        GraphEdit_Button.Enabled = IO.File.Exists(My.Settings.GRAPHICEDITOR_PATH)

        ' ---------------------------------------------------------------------------------------------------------------------
        ' YY-CHR
        Dim YYCHR_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = YYCHR_Button.Tag}
        YYCHR_ToolTip.SetToolTip(YYCHR_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.YYCHR_PATH}")
        YYCHR_Button.Enabled = IO.File.Exists(My.Settings.YYCHR_PATH)

        ' SMW Customizer - Run Program
        Dim SMWCust_Option_1_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_RunApp.Text}
        SMWCust_Option_1_ToolTip.SetToolTip(SMWCust_Option_1, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.SMWCUSTOMIZER_PATH}")
        SMWCust_Option_1.Enabled = IO.File.Exists(My.Settings.SMWCUSTOMIZER_PATH)

        ' SMW Customizer - Kill Process
        Dim SMWCust_Option_2_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_KillProcess.Text}
        SMWCust_Option_2_ToolTip.SetToolTip(SMWCust_Option_2, $"{Frm99_TranslateForm.UI01_ShellCommand.Text} taskkill /F /IM Customizer.exe /T")

        ' SMW Customizer - Main button
        Dim SMWCust_MainBtn_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = SMWCust_Button.Tag}
        SMWCust_MainBtn_ToolTip.SetToolTip(SMWCust_Button, Frm99_TranslateForm.UI01_OpenSubMenuDesc.Text)
        SMWCust_Button.Enabled = SMWCust_Option_1.Enabled

        ' Iggy/Larry Battle Platform Editor
        Dim SH_SubBtn1_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = SH_Option_1.Tag}
        SH_SubBtn1_ToolTip.SetToolTip(SH_Option_1, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.SMWCUSTOMIZER_PATH}")
        SH_Option_1.Enabled = IO.File.Exists(My.Settings.SH_ILBPE_PATH)

        ' SMW Boss Battle Palette Editor
        Dim SH_SubBtn2_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = SH_Option_2.Tag}
        SH_SubBtn2_ToolTip.SetToolTip(SH_Option_2, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.SMWCUSTOMIZER_PATH}")
        SH_Option_2.Enabled = IO.File.Exists(My.Settings.SH_SMWBBPE_PATH)

        ' SMW Enemy Name Exporter
        Dim SH_SubBtn3_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = SH_Option_3.Tag}
        SH_SubBtn3_ToolTip.SetToolTip(SH_Option_3, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.SMWCUSTOMIZER_PATH}")
        SH_Option_3.Enabled = IO.File.Exists(My.Settings.SH_SMWENE_PATH)

        ' SMW Enemy Name Importer
        Dim SH_SubBtn4_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = SH_Option_4.Tag}
        SH_SubBtn4_ToolTip.SetToolTip(SH_Option_4, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.SMWCUSTOMIZER_PATH}")
        SH_Option_4.Enabled = IO.File.Exists(My.Settings.SH_SMWENI_PATH)

        ' SMW Miscellaneous Text Editor
        Dim SH_SubBtn5_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = SH_Option_5.Tag}
        SH_SubBtn5_ToolTip.SetToolTip(SH_Option_5, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.SMWCUSTOMIZER_PATH}")
        SH_Option_5.Enabled = IO.File.Exists(My.Settings.SH_SMWMTE_PATH)

        ' SMW Player Tilemap Editor
        Dim SH_SubBtn6_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = SH_Option_6.Tag}
        SH_SubBtn6_ToolTip.SetToolTip(SH_Option_6, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.SMWCUSTOMIZER_PATH}")
        SH_Option_6.Enabled = IO.File.Exists(My.Settings.SH_SMWPTE_PATH)

        ' SMW Status Bar Editor
        Dim SH_SubBtn7_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = SH_Option_7.Tag}
        SH_SubBtn7_ToolTip.SetToolTip(SH_Option_7, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.SMWCUSTOMIZER_PATH}")
        SH_Option_7.Enabled = IO.File.Exists(My.Settings.SH_SMWSBE_PATH)

        ' SMW Thank You Message Importer
        Dim SH_SubBtn8_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = SH_Option_8.Tag}
        SH_SubBtn8_ToolTip.SetToolTip(SH_Option_8, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.SMWCUSTOMIZER_PATH}")
        SH_Option_8.Enabled = IO.File.Exists(My.Settings.SH_SMWTYMI_PATH)

        ' Smallhacker's Tools - Main button
        Dim SH_MainBtn_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_Smallhacker.Text}
        SH_MainBtn_ToolTip.SetToolTip(SMHACKER_Button, Frm99_TranslateForm.UI01_OpenSubMenuDesc.Text)

        If SH_Option_1.Enabled = False And SH_Option_2.Enabled = False And SH_Option_3.Enabled = False And SH_Option_4.Enabled = False And SH_Option_5.Enabled = False And SH_Option_6.Enabled = False And SH_Option_7.Enabled = False And SH_Option_8.Enabled = False Then
            SMHACKER_Button.Enabled = False
        Else
            SMHACKER_Button.Enabled = True
        End If

        ' UberASM
        Dim UberASM_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = UberASM_Button.Tag}
        UberASM_ToolTip.SetToolTip(UberASM_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.UBERASM_PATH}")
        Try
            UberASM_Button.Enabled = IO.Directory.Exists(My.Settings.UBERASM_PATH)
        Catch ex As Exception
            UberASM_Button.Enabled = False
        End Try

        ' GradientTool
        Dim GradTool_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = GradTool_Button.Tag}
        GradTool_ToolTip.SetToolTip(GradTool_Button, $"{Frm99_TranslateForm.UI01_ExecutablePath.Text} {My.Settings.GRADIENTTOOL_PATH}")
        GradTool_Button.Enabled = IO.File.Exists(My.Settings.GRADIENTTOOL_PATH)

        ' ---------------------------------------------------------------------------------------------------------------------
        ' Bottom bar buttons

        ' "Settings" button
        Dim SettingsBtn_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_SettingsBtnTitle.Text}
        SettingsBtn_ToolTip.SetToolTip(BtmBar_OptionsBtn, Frm99_TranslateForm.UI01_SettingsBtnDesc.Text)

        ' "Help" button
        Dim HelpBtn_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_HelpBtnTitle.Text}
        HelpBtn_ToolTip.SetToolTip(BtmBar_HelpBtn, Frm99_TranslateForm.UI01_HelpBtnDesc.Text)

        ' "Suggest Tool/Update" button
        Dim SuggestBtn_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_SuggestUpdateBtnTitle.Text}
        SuggestBtn_ToolTip.SetToolTip(BtmBar_SuggestBtn, Frm99_TranslateForm.UI01_SuggestUpdateBtnDesc.Text)

        ' "Report Bug/Crash" button
        Dim CrashBtn_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_ReportCrashBtnTitle.Text}
        CrashBtn_ToolTip.SetToolTip(BtmBar_BugReportBtn, Frm99_TranslateForm.UI01_ReportCrashBtnDesc.Text)

        ' "OS Version" button
        Dim WinverBtn_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_WinverBtnTitle.Text}
        WinverBtn_ToolTip.SetToolTip(BtmBar_WinverBtn, Frm99_TranslateForm.UI01_WinverBtnDesc.Text)

        ' "Task Manager" button
        Dim TaskmgrBtn_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_TaskmgrBtnTitle.Text}
        TaskmgrBtn_ToolTip.SetToolTip(BtmBar_TaskmgrBtn, Frm99_TranslateForm.UI01_TaskmgrBtnDesc.Text)

        ' "About SMWMTL" button
        Dim AboutBtn_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_AboutProgramBtnTitle.Text}
        AboutBtn_ToolTip.SetToolTip(BtmBar_AboutBtn, Frm99_TranslateForm.UI01_AboutProgramBtnDesc.Text)

        ' "Show/Hide bottom bar elements" button
        MenuRetractBtn_ToolTip = New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_ShowBottomButtonsBtnTitle.Text}
        MenuRetractBtn_ToolTip.SetToolTip(BtmBar_MenuRetractBtnCbx, Frm99_TranslateForm.UI01_ShowBottomButtonsBtnDesc.Text)

        ' "Close sub-menu" button
        Dim CloseSubMenuBtn_ToolTip As New ToolTip With {.Active = True, .AutoPopDelay = 5000, .InitialDelay = 500, .ToolTipTitle = Frm99_TranslateForm.UI01_CloseSubMenu.Text}
        CloseSubMenuBtn_ToolTip.SetToolTip(CLOSE_SUBMENU, Frm99_TranslateForm.UI01_CloseSubMenuDesc.Text)

        ' ---------------------------------------------------------------------------------------------------------------------
        ' Finalizing settings load
        LM_Button.Select()

    End Sub

#Region " ~~ Timer Titre de la fenêtre ~~ "

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Titlebar_Clock.Tick

        Text = $"{If(My.Settings.HIDE_TITLE = True, Nothing, WindowTitle)}{PersonalizedTextSpacing}{Now}"

    End Sub

#End Region

    ' Mises à jour de SMWMTL

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Select Case My.Settings.UPDATE_SEARCH_AT_STARTUP
            Case True
                UpdateSearch_Step1()

        End Select

    End Sub

    ' UPDATE SEARCH MODULE
    ' ------------------------------------
    ' Checking on Internet for Update availability.

    Sub UpdateSearch_Step1()

#Region "        Code Step 1 "

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

#End Region

    End Sub
    Private Sub UpdateSearch_Step1_DownloadCompletion(sender As Object, e As DownloadStringCompletedEventArgs)

        If e.Error Is Nothing Then ' Download Successed

            Select Case e.Result
                Case "Enabled"
                    UpdateSearch_Step2()

                Case "Disabled"
                    UpdateSearchState_Label.Text = Frm99_TranslateForm.UI01_UpdateSearchState_NotAvailable.Text
                    UpdateSearchState_Pic.Image = My.Resources.HomeUpdateNoUpdate
                    UpdateSearchState_Panel.BackgroundImage = My.Resources.MW_UpdateSearchGreen

                Case Else
                    UpdateSearchState_Label.Text = Frm99_TranslateForm.UI01_UpdateSearchState_Failed.Text
                    UpdateSearchState_Pic.Image = My.Resources.HomeUpdateError
                    UpdateSearchState_Panel.BackgroundImage = My.Resources.MW_UpdateSearchRed

            End Select

        Else ' Download Failed

            UpdateSearchState_Label.Text = Frm99_TranslateForm.UI01_UpdateSearchState_Failed.Text
            UpdateSearchState_Pic.Image = My.Resources.HomeUpdateError
            UpdateSearchState_Panel.BackgroundImage = My.Resources.MW_UpdateSearchRed

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
                    UpdateSearchState_Label.Text = Frm99_TranslateForm.UI01_UpdateSearchState_NotAvailable.Text
                    UpdateSearchState_Pic.Image = My.Resources.HomeUpdateNoUpdate
                    UpdateSearchState_Panel.BackgroundImage = My.Resources.MW_UpdateSearchGreen

                    My.Settings.UPDATE_PENDING = False
                    My.Settings.UPDATE_FOUND_CVERSION = My.Resources.APP_VERSION_WITHZERO

                    My.Settings.LAST_UPDATE_CHECK_DATE = Now

            End Select

        Else ' Download Failed

            UpdateSearchState_Label.Text = Frm99_TranslateForm.UI01_UpdateSearchState_Failed.Text
            UpdateSearchState_Pic.Image = My.Resources.HomeUpdateError
            UpdateSearchState_Panel.BackgroundImage = My.Resources.MW_UpdateSearchRed

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

            Frm05_UpdateDetected.UI_UpdateText_NewVersion.Text = $"{e.Result} {Frm99_TranslateForm.UI05_IsAvailableText.Text}"
            Frm05_UpdateDetected.UI_Changelog_TextBox.Text = My.Settings.UPDATE_FOUND_CHANGELOG

            UpdateSearchState_Pic.Image = My.Resources.HomeUpdateAvailable
            UpdateSearchState_Label.Text = Frm99_TranslateForm.UI01_UpdateSearchState_Available.Text.Replace("$VER", e.Result).Replace("$BLD", My.Settings.UPDATE_FOUND_CVERSION.TrimStart("0").Replace(e.Result, Nothing).TrimStart("."))
            UpdateSearchState_Panel.BackgroundImage = My.Resources.MW_UpdateSearchYellow

            UI_Btn_GoToUpdateModal.Visible = True

            SysTray_Menu_Separator01.Visible = True
            SysTray_Menu_UpdateAvailable.Visible = True
            SysTray_Menu_UpdateAvailable.Text = UpdateSearchState_Label.Text

            My.Settings.LAST_UPDATE_CHECK_DATE = Now

            Select Case My.Settings.UPDATE_SEARCH_AT_STARTUP_DISCRETE_MODE
                Case False
                    Select Case e.Result = My.Settings.UPDATE_IGNORED_VERSION
                        Case False
                            Select Case My.Settings.USE_LEGACY_UPDATE_POPUPS
                                Case True
                                    Select Case My.Settings.SHOW_TRAY_ICON
                                        Case True
                                            SystemTrayIcon.ShowBalloonTip(10000, $"{Frm99_TranslateForm.UI01_LegacyBalloonTipTitle.Text.Replace("$VER", e.Result)}", $"{Frm99_TranslateForm.UI01_LegacyUpdatePopupText01.Text & vbNewLine & vbNewLine & Frm99_TranslateForm.UI01_LegacyUpdatePopupText02.Text} {My.Resources.APP_VERSION} (Build {My.Resources.APP_VERSION_BUILD}){vbNewLine & Frm99_TranslateForm.UI01_LegacyUpdatePopupText03.Text} {e.Result} (Build {My.Settings.UPDATE_FOUND_CVERSION.TrimStart("0").Replace(e.Result, Nothing).TrimStart(".")}){vbNewLine & vbNewLine & Frm99_TranslateForm.UI01_LegacyUpdatePopupText04.Text}", ToolTipIcon.Info)

                                        Case False
                                            MessageBox.Show($"{Frm99_TranslateForm.UI01_LegacyUpdatePopupText01.Text & vbNewLine & vbNewLine & Frm99_TranslateForm.UI01_LegacyUpdatePopupText02.Text} {My.Resources.APP_VERSION} (Build {My.Resources.APP_VERSION_BUILD}){vbNewLine & Frm99_TranslateForm.UI01_LegacyUpdatePopupText03.Text} {e.Result} (Build {My.Settings.UPDATE_FOUND_CVERSION.TrimStart("0").Replace(e.Result, Nothing).TrimStart(".")}){vbNewLine & vbNewLine & Frm99_TranslateForm.UI01_LegacyUpdatePopupText04.Text}", $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_LegacyBalloonTipTitle.Text.Replace("$VER", e.Result)}", CType(MsgBoxStyle.OkOnly, MessageBoxButtons), MessageBoxIcon.Information)

                                    End Select

                                Case False
                                    Frm05_UpdateDetected.ShowDialog()

                            End Select

                    End Select

            End Select

        Else ' Download Failed

            UpdateSearchState_Label.Text = Frm99_TranslateForm.UI01_UpdateSearchState_Failed.Text
            UpdateSearchState_Pic.Image = My.Resources.HomeUpdateError
            UpdateSearchState_Panel.BackgroundImage = My.Resources.MW_UpdateSearchRed

        End If

    End Sub

    ' "See details..." link button
    Private Sub UI_Btn_GoToUpdateModal_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UI_Btn_GoToUpdateModal.LinkClicked

        Dim f As New Frm04_UpdatesModal
        f.ShowDialog()

    End Sub

    ' ---------------------------------------------------------------------------------------------------------------------
    ' Applications buttons

    ' Lunar Magic - Main button
    Private Sub LM_Button_Click(sender As Object, e As EventArgs) Handles LM_Button.Click

        Select Case My.Settings.LM_1CTL_ENABLED
            Case True
                Select Case My.Settings.LM_1CTL_SHOW_SELECTOR_ON_CTRLCLICK
                    Case True
                        Select Case My.Computer.Keyboard.CtrlKeyDown
                            Case True
                                LM_Button.Enabled = False
                                LM_Option_1.Visible = True
                                LM_Option_2.Visible = True
                                LM_Option_3.Visible = True

                                AMK_Button.Enabled = False
                                PIXI_Button.Enabled = False
                                SMWCust_Button.Enabled = False
                                SMHACKER_Button.Enabled = False

                                CLOSE_SUBMENU.Visible = True

                                SubMenu_AppTitle.Text = LM_Button.Tag

                                LM_Option_1.Select()

                            Case False
                                Select Case My.Settings.LM_1CTL_SELECTED_VERSION
                                    Case 0
                                        LM_Option_1_Click(LM_Option_1, EventArgs.Empty)

                                    Case 1
                                        LM_Option_2_Click(LM_Option_2, EventArgs.Empty)

                                    Case 2
                                        LM_Option_3_Click(LM_Option_3, EventArgs.Empty)

                                End Select

                        End Select

                    Case False
                        Select Case My.Settings.LM_1CTL_SELECTED_VERSION
                            Case 0
                                LM_Option_1_Click(LM_Option_1, EventArgs.Empty)

                            Case 1
                                LM_Option_2_Click(LM_Option_2, EventArgs.Empty)

                            Case 2
                                LM_Option_3_Click(LM_Option_3, EventArgs.Empty)

                        End Select

                End Select

            Case False
                LM_Button.Enabled = False
                AMK_Button.Enabled = False
                PIXI_Button.Enabled = False
                SMWCust_Button.Enabled = False
                SMHACKER_Button.Enabled = False

                CLOSE_SUBMENU.Visible = True

                LM_Option_1.Visible = True
                LM_Option_2.Visible = True
                LM_Option_3.Visible = True

                SubMenu_AppTitle.Text = LM_Button.Tag

                LM_Option_1.Select()

        End Select

    End Sub

    ' Lunar Magic - Sub button 1
    Private Sub LM_Option_1_Click(sender As Object, e As EventArgs) Handles LM_Option_1.Click

        Try

            Select Case My.Settings.LM_SLOT1_ENABLE_HEADERMAGIC
                Case True
                    If IO.File.Exists($"{IO.Directory.GetParent(My.Settings.LM_SLOT1_PATH)}\launcher.exe").ToString() = True Then
                        Process.Start($"{IO.Directory.GetParent(My.Settings.LM_SLOT1_PATH)}\launcher.exe")
                    Else
                        Process.Start(My.Settings.LM_SLOT1_PATH)
                    End If

                Case False
                    Process.Start(My.Settings.LM_SLOT1_PATH)

            End Select

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({LM_Button.Tag})")

        End Try

    End Sub

    ' Lunar Magic - Sub button 2
    Private Sub LM_Option_2_Click(sender As Object, e As EventArgs) Handles LM_Option_2.Click

        Try

            Select Case My.Settings.LM_SLOT2_ENABLE_HEADERMAGIC
                Case True
                    If IO.File.Exists($"{IO.Directory.GetParent(My.Settings.LM_SLOT2_PATH)}\launcher.exe").ToString() = True Then
                        Process.Start($"{IO.Directory.GetParent(My.Settings.LM_SLOT2_PATH)}\launcher.exe")
                    Else
                        Process.Start(My.Settings.LM_SLOT2_PATH)
                    End If

                Case False
                    Process.Start(My.Settings.LM_SLOT2_PATH)

            End Select

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({LM_Button.Tag})")

        End Try

    End Sub

    ' Lunar Magic - Sub button 3
    Private Sub LM_Option_3_Click(sender As Object, e As EventArgs) Handles LM_Option_3.Click

        Try

            Select Case My.Settings.LM_SLOT3_ENABLE_HEADERMAGIC
                Case True
                    If IO.File.Exists($"{IO.Directory.GetParent(My.Settings.LM_SLOT3_PATH)}\launcher.exe").ToString() = True Then
                        Process.Start($"{IO.Directory.GetParent(My.Settings.LM_SLOT3_PATH)}\launcher.exe")
                    Else
                        Process.Start(My.Settings.LM_SLOT3_PATH)
                    End If

                Case False
                    Process.Start(My.Settings.LM_SLOT3_PATH)

            End Select

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({LM_Button.Tag})")

        End Try

    End Sub

    ' Lunar Expand
    Private Sub LE_Button_Click(sender As Object, e As EventArgs) Handles LE_Button.Click

        Try

            Process.Start(My.Settings.LUNAREXPAND_PATH)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({LE_Button.Tag})")

        End Try

    End Sub

    ' Recover Lunar Magic
    Private Sub RLM_Button_Click(sender As Object, e As EventArgs) Handles RLM_Button.Click

        Dim f As New Y_Recover_LM_GUI()
        f.Show()

    End Sub

    ' SnesGFX
    Private Sub SNESGFX_Button_Click(sender As Object, e As EventArgs) Handles SNESGFX_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.SNESGFX_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.SNESGFX_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({SNESGFX_Button.Tag})")

        End Try

    End Sub

    ' Mario/Luigi Live Palette Editor
    Private Sub MarioLPE_Button_Click(sender As Object, e As EventArgs) Handles MarioLPE_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.MARIOLLPE_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.MARIOLLPE_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({MarioLPE_Button.Tag})")

        End Try

    End Sub

    ' HeAdder
    Private Sub HeAdder_Button_Click(sender As Object, e As EventArgs) Handles HeAdder_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.HEADDER_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.HEADDER_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({HeAdder_Button.Tag})")

        End Try

    End Sub

    ' H-DMA Gradient Ripper
    Private Sub HDMA_GR_Button_Click(sender As Object, e As EventArgs) Handles HDMA_GR_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.HDMA_GRAD_RIPPER_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.HDMA_GRAD_RIPPER_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({HDMA_GR_Button.Tag})")

        End Try

    End Sub

    ' ---------------------------------------------------------------------------------------------------------------------
    ' MML Editing Tool
    Private Sub MML_Edit_Button_Click(sender As Object, e As EventArgs) Handles MML_Edit_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.MMLEDIT_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.MMLEDIT_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({MML_Edit_Button.Tag})")

        End Try

    End Sub

    ' AddMusicK - Main button
    Private Sub AMK_Button_Click(sender As Object, e As EventArgs) Handles AMK_Button.Click

        If My.Settings.LM_1CTL_ENABLED = False OrElse My.Settings.LM_1CTL_SHOW_SELECTOR_ON_CTRLCLICK = True Then
            LM_Button.Enabled = False
        End If

        AMK_Button.Enabled = False
        PIXI_Button.Enabled = False
        SMWCust_Button.Enabled = False
        SMHACKER_Button.Enabled = False

        CLOSE_SUBMENU.Visible = True

        AMK_Option_1.Visible = True
        AMK_Option_2.Visible = True
        AMK_Option_3.Visible = True

        SubMenu_AppTitle.Text = AMK_Button.Tag

        AMK_Option_1.Select()

    End Sub

    ' AddMusicK - CMD Version
    Private Sub AMK_Option_1_Click(sender As Object, e As EventArgs) Handles AMK_Option_1.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.ADDMUSICK_CMD_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.ADDMUSICK_CMD_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({AMK_Button.Tag} • {AMK_Option_1.Tag})")

        End Try

    End Sub

    ' AddMusicK - GUI Version
    Private Sub AMK_Option_2_Click(sender As Object, e As EventArgs) Handles AMK_Option_2.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.ADDMUSICK_GUI_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.ADDMUSICK_GUI_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({AMK_Button.Tag} • {AMK_Option_2.Tag})")

        End Try

    End Sub

    ' AddMusicK - Open Folder
    Private Sub AMK_Option_3_Click(sender As Object, e As EventArgs) Handles AMK_Option_3.Click

        Try

            Process.Start(IO.Directory.GetParent(My.Settings.ADDMUSICK_GUI_PATH).ToString())

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({AMK_Button.Tag} • {AMK_Option_3.Tag})")

        End Try

    End Sub

    ' Level Music Utility
    Private Sub LvlMusicUtil_Button_Click(sender As Object, e As EventArgs) Handles LvlMusicUtil_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.LVMUSUTIL_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.LVMUSUTIL_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({LvlMusicUtil_Button.Tag})")

        End Try

    End Sub

    ' BRR Player
    Private Sub BRRPlayer_Button_Click(sender As Object, e As EventArgs) Handles BRRPlayer_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.BRRPLAYER_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.BRRPLAYER_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({BRRPlayer_Button.Tag})")

        End Try

    End Sub

    ' Blockreator
    Private Sub Blockreator_Button_Click(sender As Object, e As EventArgs) Handles Blockreator_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.BLOCKREATOR_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.BLOCKREATOR_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({Blockreator_Button.Tag})")

        End Try

    End Sub

    ' Pixi - Main button
    Private Sub PIXI_Button_Click(sender As Object, e As EventArgs) Handles PIXI_Button.Click

        If My.Settings.LM_1CTL_ENABLED = False OrElse My.Settings.LM_1CTL_SHOW_SELECTOR_ON_CTRLCLICK = True Then
            LM_Button.Enabled = False
        End If

        AMK_Button.Enabled = False
        PIXI_Button.Enabled = False
        SMWCust_Button.Enabled = False
        SMHACKER_Button.Enabled = False

        CLOSE_SUBMENU.Visible = True

        PIXI_Option_1.Visible = True
        PIXI_Option_2.Visible = True

        SubMenu_AppTitle.Text = PIXI_Button.Tag

        PIXI_Option_1.Select()

    End Sub

    ' Pixi - Run program
    Private Sub PIXI_Option_1_Click(sender As Object, e As EventArgs) Handles PIXI_Option_1.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.PIXI_MAIN_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.PIXI_MAIN_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({PIXI_Option_1.Tag})")

        End Try

    End Sub

    ' Pixi Run Configurator
    Private Sub PIXI_Option_2_Click(sender As Object, e As EventArgs) Handles PIXI_Option_2.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.PIXI_CONFIG_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.PIXI_CONFIG_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({PIXI_Option_2.Tag})")

        End Try

    End Sub

    ' M7Map
    Private Sub M7MAP_Button_Click(sender As Object, e As EventArgs) Handles M7MAP_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.M7MAP_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.M7MAP_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({M7MAP_Button.Tag})")

        End Try

    End Sub

    ' ---------------------------------------------------------------------------------------------------------------------
    ' SNES SPC700 Player
    Private Sub SPC700_Button_Click(sender As Object, e As EventArgs) Handles SPC700_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.SPC700PLAYER_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.SPC700PLAYER_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({SPC700_Button.Tag})")

        End Try

    End Sub

    ' Floating IPS/BPS
    Private Sub FLIPS_Button_Click(sender As Object, e As EventArgs) Handles FLIPS_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.FLOATINGIPS_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.FLOATINGIPS_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({FLIPS_Button.Tag})")

        End Try

    End Sub

    ' Status Effects
    Private Sub STAEFF_Button_Click(sender As Object, e As EventArgs) Handles STAEFF_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.STATUSEFFECTS_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.STATUSEFFECTS_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({STAEFF_Button.Tag})")

        End Try

    End Sub

    ' SNES Color Tool
    Private Sub SNESColorTool_Button_Click(sender As Object, e As EventArgs) Handles SNESColorTool_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.SNESCOLORTOOL_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.SNESCOLORTOOL_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({SNESColorTool_Button.Tag})")

        End Try

    End Sub

    ' Effect Tool
    Private Sub EFFTOOL_Button_Click(sender As Object, e As EventArgs) Handles EFFTOOL_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.EFFECTTOOL_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.EFFECTTOOL_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({EFFTOOL_Button.Tag})")

        End Try

    End Sub

    ' Gopher Popcorn Stew
    Private Sub GPS_Button_Click(sender As Object, e As EventArgs) Handles GPS_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.GOPHERPOPCORNSTEW_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.GOPHERPOPCORNSTEW_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({GPS_Button.Tag})")

        End Try

    End Sub

    ' PetiteMM
    Private Sub PMM_Button_Click(sender As Object, e As EventArgs) Handles PMM_Button.Click

        Try

            Process.Start(My.Settings.PETITEMM_PATH)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({PMM_Button.Tag})")

        End Try

    End Sub

    ' ---------------------------------------------------------------------------------------------------------------------
    ' Asar
    Private Sub Asar_Button_Click(sender As Object, e As EventArgs) Handles Asar_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.ASAR_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.ASAR_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({Asar_Button.Tag})")

        End Try

    End Sub

    ' Snes9x
    Private Sub Snes9x_Button_Click(sender As Object, e As EventArgs) Handles Snes9x_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = If(My.Settings.SNES9x_SELECTED_ARCH = 0, My.Settings.SNES9x_PATH_x86, My.Settings.SNES9x_PATH_x64), .WorkingDirectory = IO.Directory.GetParent(If(My.Settings.SNES9x_SELECTED_ARCH = 0, My.Settings.SNES9x_PATH_x86, My.Settings.SNES9x_PATH_x64)).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({Snes9x_Button.Tag})")

        End Try

    End Sub

    ' Bsnes
    Private Sub Bsnes_Button_Click(sender As Object, e As EventArgs) Handles Bsnes_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.BSNES_PATH_x64, .WorkingDirectory = IO.Directory.GetParent(My.Settings.BSNES_PATH_x64).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({Bsnes_Button.Tag})")

        End Try

    End Sub

    ' Mario Start Editor
    Private Sub MarioStartE_Button_Click(sender As Object, e As EventArgs) Handles MarioStartE_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.MARIOSTARTEDITOR_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.MARIOSTARTEDITOR_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({MarioStartE_Button.Tag})")

        End Try

    End Sub

    ' Interaction Editor
    Private Sub InterEdit_Button_Click(sender As Object, e As EventArgs) Handles InterEdit_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.INTERACTIONEDITOR_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.INTERACTIONEDITOR_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({InterEdit_Button.Tag})")

        End Try

    End Sub

    ' Multiple Midway Points
    Private Sub MMP_Button_Click(sender As Object, e As EventArgs) Handles MMP_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.MULTIPLEMIDWAYPOINTS_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.MULTIPLEMIDWAYPOINTS_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({MMP_Button.Tag})")

        End Try

    End Sub

    ' GFX Sprite Creator
    Private Sub SprGFXCrea_Button_Click(sender As Object, e As EventArgs) Handles SprGFXCrea_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.SPRITEGFXCREATOR_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.SPRITEGFXCREATOR_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({SprGFXCrea_Button.Tag})")

        End Try

    End Sub

    ' ---------------------------------------------------------------------------------------------------------------------
    ' Graphics Editor
    Private Sub GraphEdit_Button_Click(sender As Object, e As EventArgs) Handles GraphEdit_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.GRAPHICEDITOR_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.GRAPHICEDITOR_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({GraphEdit_Button.Tag})")

        End Try

    End Sub

    ' YY-CHR
    Private Sub YYCHR_Button_Click(sender As Object, e As EventArgs) Handles YYCHR_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.YYCHR_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.YYCHR_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({YYCHR_Button.Tag})")

        End Try

    End Sub

    ' SMW Customizer - Main button
    Private Sub SMWCust_Button_Click(sender As Object, e As EventArgs) Handles SMWCust_Button.Click

        If My.Settings.LM_1CTL_ENABLED = False OrElse My.Settings.LM_1CTL_SHOW_SELECTOR_ON_CTRLCLICK = True Then
            LM_Button.Enabled = False
        End If

        AMK_Button.Enabled = False
        PIXI_Button.Enabled = False
        SMWCust_Button.Enabled = False
        SMHACKER_Button.Enabled = False

        CLOSE_SUBMENU.Visible = True

        SMWCust_Option_1.Visible = True
        SMWCust_Option_2.Visible = True

        SubMenu_AppTitle.Text = SMWCust_Button.Tag

        SMWCust_Option_1.Select()

    End Sub

    ' SMW Customizer - Run Program
    Private Sub SMWCust_Option_1_Click(sender As Object, e As EventArgs) Handles SMWCust_Option_1.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.SMWCUSTOMIZER_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.SMWCUSTOMIZER_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({SMWCust_Button.Tag} • {SMWCust_Option_1.Tag})")

        End Try

    End Sub

    ' SMW Customizer - Kill Process
    Private Sub SMWCust_Option_2_Click(sender As Object, e As EventArgs) Handles SMWCust_Option_2.Click

        Try

            Shell("taskkill /F /IM Customizer.exe /T", 0)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({SMWCust_Button.Tag} • {Frm99_TranslateForm.UI01_KillProcess.Text})")

        End Try

    End Sub

    ' Smallhacker's Tools - Main button
    Private Sub SMHACKER_Button_Click(sender As Object, e As EventArgs) Handles SMHACKER_Button.Click

        If My.Settings.LM_1CTL_ENABLED = False OrElse My.Settings.LM_1CTL_SHOW_SELECTOR_ON_CTRLCLICK = True Then
            LM_Button.Enabled = False
        End If

        AMK_Button.Enabled = False
        PIXI_Button.Enabled = False
        SMWCust_Button.Enabled = False
        SMHACKER_Button.Enabled = False

        CLOSE_SUBMENU.Visible = True

        SH_Option_1.Visible = My.Settings.DISPLAYBTN_ILBPE
        SH_Option_2.Visible = My.Settings.DISPLAYBTN_SMWBBPE
        SH_Option_3.Visible = My.Settings.DISPLAYBTN_SMWENE
        SH_Option_4.Visible = My.Settings.DISPLAYBTN_SMWENI
        SH_Option_5.Visible = My.Settings.DISPLAYBTN_SMWMTE
        SH_Option_6.Visible = My.Settings.DISPLAYBTN_SMWPTE
        SH_Option_7.Visible = My.Settings.DISPLAYBTN_SMWSBE
        SH_Option_8.Visible = My.Settings.DISPLAYBTN_SMWTYMI

        SubMenu_AppTitle.Text = Frm99_TranslateForm.UI01_Smallhacker.Text

        SH_Option_1.Select()

    End Sub

    ' Smallhacker's Tools - Iggy/Larry Battle Platform Editor
    Private Sub SH_Option_1_Click(sender As Object, e As EventArgs) Handles SH_Option_1.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.SH_ILBPE_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.SH_ILBPE_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({Frm99_TranslateForm.UI01_Smallhacker.Text} • {SH_Option_1.Tag})")

        End Try

    End Sub

    ' Smallhacker's Tools - SMW Boss Battle Palette Editor
    Private Sub SH_Option_2_Click(sender As Object, e As EventArgs) Handles SH_Option_2.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.SH_SMWBBPE_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.SH_SMWBBPE_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({Frm99_TranslateForm.UI01_Smallhacker.Text} • {SH_Option_2.Tag})")

        End Try

    End Sub

    ' Smallhacker's Tools - SMW Enemy Name Exporter
    Private Sub SH_Option_3_Click(sender As Object, e As EventArgs) Handles SH_Option_3.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.SH_SMWENE_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.SH_SMWENE_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({Frm99_TranslateForm.UI01_Smallhacker.Text} • {SH_Option_3.Tag})")

        End Try

    End Sub

    ' Smallhacker's Tools - SMW Enemy Name Importer
    Private Sub SH_Option_4_Click(sender As Object, e As EventArgs) Handles SH_Option_4.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.SH_SMWENI_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.SH_SMWENI_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({Frm99_TranslateForm.UI01_Smallhacker.Text} • {SH_Option_4.Tag})")

        End Try

    End Sub

    ' Smallhacker's Tools - SMW Miscellaneous Text Editor
    Private Sub SH_Option_5_Click(sender As Object, e As EventArgs) Handles SH_Option_5.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.SH_SMWMTE_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.SH_SMWMTE_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({Frm99_TranslateForm.UI01_Smallhacker.Text} • {SH_Option_5.Tag})")

        End Try

    End Sub

    ' Smallhacker's Tools - SMW Player Tilemap Editor
    Private Sub SH_Option_6_Click(sender As Object, e As EventArgs) Handles SH_Option_6.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.SH_SMWPTE_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.SH_SMWPTE_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({Frm99_TranslateForm.UI01_Smallhacker.Text} • {SH_Option_6.Tag})")

        End Try

    End Sub

    ' Smallhacker's Tools - SMW Status bar Editor
    Private Sub SH_Option_7_Click(sender As Object, e As EventArgs) Handles SH_Option_7.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.SH_SMWSBE_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.SH_SMWSBE_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({Frm99_TranslateForm.UI01_Smallhacker.Text} • {SH_Option_7.Tag})")

        End Try

    End Sub

    ' Smallhacker's Tools - SMW Thank You Message Importer
    Private Sub SH_Option_8_Click(sender As Object, e As EventArgs) Handles SH_Option_8.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.SH_SMWTYMI_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.SH_SMWTYMI_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({Frm99_TranslateForm.UI01_Smallhacker.Text} • {SH_Option_8.Tag})")

        End Try

    End Sub

    ' UberASM
    Private Sub UberASM_Button_Click(sender As Object, e As EventArgs) Handles UberASM_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.UBERASM_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.UBERASM_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({UberASM_Button.Tag})")

        End Try

    End Sub

    ' GradientTool
    Private Sub GradTool_Button_Click(sender As Object, e As EventArgs) Handles GradTool_Button.Click

        Try

            Dim ProcStart As New ProcessStartInfo With {.FileName = My.Settings.GRADIENTTOOL_PATH, .WorkingDirectory = IO.Directory.GetParent(My.Settings.GRADIENTTOOL_PATH).ToString()}
            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({GradTool_Button.Tag})")

        End Try

    End Sub

    ' ---------------------------------------------------------------------------------------------------------------------
    ' "Close sub-menu" button

    Private Sub CLOSE_SUBMENU_Click(sender As Object, e As EventArgs) Handles CLOSE_SUBMENU.Click

        ' Lunar Magic
        Select Case My.Settings.LM_1CTL_ENABLED
            Case True
                Select Case My.Settings.LM_1CTL_SELECTED_VERSION
                    Case 0
                        LM_Button.Enabled = LM_Option_1.Enabled

                    Case 1
                        LM_Button.Enabled = LM_Option_2.Enabled

                    Case 2
                        LM_Button.Enabled = LM_Option_3.Enabled

                End Select

            Case False
                If LM_Option_1.Enabled = False And LM_Option_2.Enabled = False And LM_Option_3.Enabled = False Then
                    LM_Button.Enabled = False
                Else
                    LM_Button.Enabled = True
                End If

        End Select

        ' AddMusicK
        If AMK_Option_1.Enabled = False And AMK_Option_2.Enabled = False And AMK_Option_3.Enabled = False Then
            AMK_Button.Enabled = False
        Else
            AMK_Button.Enabled = True
        End If

        ' PIXI Sprite Insertion Tool
        If PIXI_Option_1.Enabled = False And PIXI_Option_2.Enabled = False Then
            PIXI_Button.Enabled = False
        Else
            PIXI_Button.Enabled = True
        End If

        ' SMW Customizer
        SMWCust_Button.Enabled = SMWCust_Option_1.Enabled

        ' Outils de SmallHacker
        If SH_Option_1.Enabled = False And SH_Option_2.Enabled = False And SH_Option_3.Enabled = False And SH_Option_4.Enabled = False And SH_Option_5.Enabled = False And SH_Option_6.Enabled = False And SH_Option_7.Enabled = False And SH_Option_8.Enabled = False Then
            SMHACKER_Button.Enabled = False
        Else
            SMHACKER_Button.Enabled = True
        End If

        Dim SubOptionsBtns As New List(Of Button) From {CLOSE_SUBMENU, LM_Option_1, LM_Option_2, LM_Option_3, AMK_Option_1, AMK_Option_2, AMK_Option_3, PIXI_Option_1, PIXI_Option_2, SMWCust_Option_1, SMWCust_Option_2, SH_Option_1, SH_Option_2, SH_Option_3, SH_Option_4, SH_Option_5, SH_Option_6, SH_Option_7, SH_Option_8}
        For Each SubMenuBtns In SubOptionsBtns
            SubMenuBtns.Visible = False
        Next

        ' Text
        SubMenu_AppTitle.Text = "-"
        LM_Button.Select()

    End Sub

    ' ---------------------------------------------------------------------------------------------------------------------
    ' Custom shortcuts buttons

    ' Shortcut 1
    Private Sub Shortcut_1_Click(sender As Object, e As EventArgs) Handles Shortcut_1.Click

        Dim ProcStart As New ProcessStartInfo With {.Arguments = Chr(34) & My.Settings.CUSTOM_SHORTCUT_1_PATH & Chr(34)}

        Try

#Region "            'Launch with' setting"

            Select Case My.Settings.CUSTOM_SHORTCUT_1_LAUNCH_WITH
                Case 0 ' Managed by Windows
                    ProcStart.FileName = ProcStart.Arguments
                    ProcStart.Arguments = Nothing

                Case 1 ' Lunar Magic Slot 1
                    ProcStart.FileName = My.Settings.LM_SLOT1_PATH

                Case 2 ' Lunar Magic Slot 2
                    ProcStart.FileName = My.Settings.LM_SLOT2_PATH

                Case 3 ' Lunar Magic Slot 3
                    ProcStart.FileName = My.Settings.LM_SLOT3_PATH

                Case 4 ' Level Music Utility
                    ProcStart.FileName = My.Settings.LVMUSUTIL_PATH

                Case 5 ' BRR Player
                    ProcStart.FileName = My.Settings.BRRPLAYER_PATH

                Case 6 ' SPC700 Player
                    ProcStart.FileName = My.Settings.SPC700PLAYER_PATH

                Case 7 ' Floating BPS
                    ProcStart.FileName = My.Settings.FLOATINGIPS_PATH

                Case 8 ' Snes9x
                    ProcStart.FileName = If(My.Settings.SNES9x_SELECTED_ARCH = 0, My.Settings.SNES9x_PATH_x86, My.Settings.SNES9x_PATH_x64)

                Case 9 ' Bsnes
                    ProcStart.FileName = My.Settings.BSNES_PATH_x64

                Case 10 ' Graphic Editor
                    ProcStart.FileName = My.Settings.GRAPHICEDITOR_PATH

                Case 11 ' YY-CHR
                    ProcStart.FileName = My.Settings.YYCHR_PATH

            End Select

#End Region

            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message & vbNewLine & vbNewLine & Frm99_TranslateForm.UI01_ExecutablePath.Text & vbNewLine & My.Settings.CUSTOM_SHORTCUT_1_PATH, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ShortcutError.Text} ({Frm99_TranslateForm.UI01_ShortcutTitle.Text} {Shortcut_1.Tag})")

        End Try

    End Sub

    ' Shortcut 2
    Private Sub Shortcut_2_Click(sender As Object, e As EventArgs) Handles Shortcut_2.Click

        Dim ProcStart As New ProcessStartInfo With {.Arguments = Chr(34) & My.Settings.CUSTOM_SHORTCUT_2_PATH & Chr(34)}

        Try

#Region "            'Launch with' setting"

            Select Case My.Settings.CUSTOM_SHORTCUT_2_LAUNCH_WITH
                Case 0 ' Managed by Windows
                    ProcStart.FileName = ProcStart.Arguments
                    ProcStart.Arguments = Nothing

                Case 1 ' Lunar Magic Slot 1
                    ProcStart.FileName = My.Settings.LM_SLOT1_PATH

                Case 2 ' Lunar Magic Slot 2
                    ProcStart.FileName = My.Settings.LM_SLOT2_PATH

                Case 3 ' Lunar Magic Slot 3
                    ProcStart.FileName = My.Settings.LM_SLOT3_PATH

                Case 4 ' Level Music Utility
                    ProcStart.FileName = My.Settings.LVMUSUTIL_PATH

                Case 5 ' BRR Player
                    ProcStart.FileName = My.Settings.BRRPLAYER_PATH

                Case 6 ' SPC700 Player
                    ProcStart.FileName = My.Settings.SPC700PLAYER_PATH

                Case 7 ' Floating BPS
                    ProcStart.FileName = My.Settings.FLOATINGIPS_PATH

                Case 8 ' Snes9x
                    ProcStart.FileName = If(My.Settings.SNES9x_SELECTED_ARCH = 0, My.Settings.SNES9x_PATH_x86, My.Settings.SNES9x_PATH_x64)

                Case 9 ' Bsnes
                    ProcStart.FileName = My.Settings.BSNES_PATH_x64

                Case 10 ' Graphic Editor
                    ProcStart.FileName = My.Settings.GRAPHICEDITOR_PATH

                Case 11 ' YY-CHR
                    ProcStart.FileName = My.Settings.YYCHR_PATH

            End Select

#End Region

            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message & vbNewLine & vbNewLine & Frm99_TranslateForm.UI01_ExecutablePath.Text & vbNewLine & My.Settings.CUSTOM_SHORTCUT_2_PATH, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ShortcutError.Text} ({Frm99_TranslateForm.UI01_ShortcutTitle.Text} {Shortcut_2.Tag})")

        End Try

    End Sub

    ' Shortcut 3
    Private Sub Shortcut_3_Click(sender As Object, e As EventArgs) Handles Shortcut_3.Click

        Dim ProcStart As New ProcessStartInfo With {.Arguments = Chr(34) & My.Settings.CUSTOM_SHORTCUT_3_PATH & Chr(34)}

        Try

#Region "            'Launch with' setting"

            Select Case My.Settings.CUSTOM_SHORTCUT_3_LAUNCH_WITH
                Case 0 ' Managed by Windows
                    ProcStart.FileName = ProcStart.Arguments
                    ProcStart.Arguments = Nothing

                Case 1 ' Lunar Magic Slot 1
                    ProcStart.FileName = My.Settings.LM_SLOT1_PATH

                Case 2 ' Lunar Magic Slot 2
                    ProcStart.FileName = My.Settings.LM_SLOT2_PATH

                Case 3 ' Lunar Magic Slot 3
                    ProcStart.FileName = My.Settings.LM_SLOT3_PATH

                Case 4 ' Level Music Utility
                    ProcStart.FileName = My.Settings.LVMUSUTIL_PATH

                Case 5 ' BRR Player
                    ProcStart.FileName = My.Settings.BRRPLAYER_PATH

                Case 6 ' SPC700 Player
                    ProcStart.FileName = My.Settings.SPC700PLAYER_PATH

                Case 7 ' Floating BPS
                    ProcStart.FileName = My.Settings.FLOATINGIPS_PATH

                Case 8 ' Snes9x
                    ProcStart.FileName = If(My.Settings.SNES9x_SELECTED_ARCH = 0, My.Settings.SNES9x_PATH_x86, My.Settings.SNES9x_PATH_x64)

                Case 9 ' Bsnes
                    ProcStart.FileName = My.Settings.BSNES_PATH_x64

                Case 10 ' Graphic Editor
                    ProcStart.FileName = My.Settings.GRAPHICEDITOR_PATH

                Case 11 ' YY-CHR
                    ProcStart.FileName = My.Settings.YYCHR_PATH

            End Select

#End Region

            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message & vbNewLine & vbNewLine & Frm99_TranslateForm.UI01_ExecutablePath.Text & vbNewLine & My.Settings.CUSTOM_SHORTCUT_3_PATH, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ShortcutError.Text} ({Frm99_TranslateForm.UI01_ShortcutTitle.Text} {Shortcut_3.Tag})")

        End Try

    End Sub

    ' Shortcut 4
    Private Sub Shortcut_4_Click(sender As Object, e As EventArgs) Handles Shortcut_4.Click

        Dim ProcStart As New ProcessStartInfo With {.Arguments = Chr(34) & My.Settings.CUSTOM_SHORTCUT_4_PATH & Chr(34)}

        Try

#Region "            'Launch with' setting"

            Select Case My.Settings.CUSTOM_SHORTCUT_4_LAUNCH_WITH
                Case 0 ' Managed by Windows
                    ProcStart.FileName = ProcStart.Arguments
                    ProcStart.Arguments = Nothing

                Case 1 ' Lunar Magic Slot 1
                    ProcStart.FileName = My.Settings.LM_SLOT1_PATH

                Case 2 ' Lunar Magic Slot 2
                    ProcStart.FileName = My.Settings.LM_SLOT2_PATH

                Case 3 ' Lunar Magic Slot 3
                    ProcStart.FileName = My.Settings.LM_SLOT3_PATH

                Case 4 ' Level Music Utility
                    ProcStart.FileName = My.Settings.LVMUSUTIL_PATH

                Case 5 ' BRR Player
                    ProcStart.FileName = My.Settings.BRRPLAYER_PATH

                Case 6 ' SPC700 Player
                    ProcStart.FileName = My.Settings.SPC700PLAYER_PATH

                Case 7 ' Floating BPS
                    ProcStart.FileName = My.Settings.FLOATINGIPS_PATH

                Case 8 ' Snes9x
                    ProcStart.FileName = If(My.Settings.SNES9x_SELECTED_ARCH = 0, My.Settings.SNES9x_PATH_x86, My.Settings.SNES9x_PATH_x64)

                Case 9 ' Bsnes
                    ProcStart.FileName = My.Settings.BSNES_PATH_x64

                Case 10 ' Graphic Editor
                    ProcStart.FileName = My.Settings.GRAPHICEDITOR_PATH

                Case 11 ' YY-CHR
                    ProcStart.FileName = My.Settings.YYCHR_PATH

            End Select

#End Region

            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message & vbNewLine & vbNewLine & Frm99_TranslateForm.UI01_ExecutablePath.Text & vbNewLine & My.Settings.CUSTOM_SHORTCUT_4_PATH, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ShortcutError.Text} ({Frm99_TranslateForm.UI01_ShortcutTitle.Text} {Shortcut_4.Tag})")

        End Try

    End Sub

    ' Shortcut 5
    Private Sub Shortcut_5_Click(sender As Object, e As EventArgs) Handles Shortcut_5.Click

        Dim ProcStart As New ProcessStartInfo With {.Arguments = Chr(34) & My.Settings.CUSTOM_SHORTCUT_5_PATH & Chr(34)}

        Try

#Region "            'Launch with' setting"

            Select Case My.Settings.CUSTOM_SHORTCUT_5_LAUNCH_WITH
                Case 0 ' Managed by Windows
                    ProcStart.FileName = ProcStart.Arguments
                    ProcStart.Arguments = Nothing

                Case 1 ' Lunar Magic Slot 1
                    ProcStart.FileName = My.Settings.LM_SLOT1_PATH

                Case 2 ' Lunar Magic Slot 2
                    ProcStart.FileName = My.Settings.LM_SLOT2_PATH

                Case 3 ' Lunar Magic Slot 3
                    ProcStart.FileName = My.Settings.LM_SLOT3_PATH

                Case 4 ' Level Music Utility
                    ProcStart.FileName = My.Settings.LVMUSUTIL_PATH

                Case 5 ' BRR Player
                    ProcStart.FileName = My.Settings.BRRPLAYER_PATH

                Case 6 ' SPC700 Player
                    ProcStart.FileName = My.Settings.SPC700PLAYER_PATH

                Case 7 ' Floating BPS
                    ProcStart.FileName = My.Settings.FLOATINGIPS_PATH

                Case 8 ' Snes9x
                    ProcStart.FileName = If(My.Settings.SNES9x_SELECTED_ARCH = 0, My.Settings.SNES9x_PATH_x86, My.Settings.SNES9x_PATH_x64)

                Case 9 ' Bsnes
                    ProcStart.FileName = My.Settings.BSNES_PATH_x64

                Case 10 ' Graphic Editor
                    ProcStart.FileName = My.Settings.GRAPHICEDITOR_PATH

                Case 11 ' YY-CHR
                    ProcStart.FileName = My.Settings.YYCHR_PATH

            End Select

#End Region

            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message & vbNewLine & vbNewLine & Frm99_TranslateForm.UI01_ExecutablePath.Text & vbNewLine & My.Settings.CUSTOM_SHORTCUT_5_PATH, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ShortcutError.Text} ({Frm99_TranslateForm.UI01_ShortcutTitle.Text} {Shortcut_5.Tag})")

        End Try

    End Sub

    ' Shortcut 6
    Private Sub Shortcut_6_Click(sender As Object, e As EventArgs) Handles Shortcut_6.Click

        Dim ProcStart As New ProcessStartInfo With {.Arguments = Chr(34) & My.Settings.CUSTOM_SHORTCUT_6_PATH & Chr(34)}

        Try

#Region "            'Launch with' setting"

            Select Case My.Settings.CUSTOM_SHORTCUT_6_LAUNCH_WITH
                Case 0 ' Managed by Windows
                    ProcStart.FileName = ProcStart.Arguments
                    ProcStart.Arguments = Nothing

                Case 1 ' Lunar Magic Slot 1
                    ProcStart.FileName = My.Settings.LM_SLOT1_PATH

                Case 2 ' Lunar Magic Slot 2
                    ProcStart.FileName = My.Settings.LM_SLOT2_PATH

                Case 3 ' Lunar Magic Slot 3
                    ProcStart.FileName = My.Settings.LM_SLOT3_PATH

                Case 4 ' Level Music Utility
                    ProcStart.FileName = My.Settings.LVMUSUTIL_PATH

                Case 5 ' BRR Player
                    ProcStart.FileName = My.Settings.BRRPLAYER_PATH

                Case 6 ' SPC700 Player
                    ProcStart.FileName = My.Settings.SPC700PLAYER_PATH

                Case 7 ' Floating BPS
                    ProcStart.FileName = My.Settings.FLOATINGIPS_PATH

                Case 8 ' Snes9x
                    ProcStart.FileName = If(My.Settings.SNES9x_SELECTED_ARCH = 0, My.Settings.SNES9x_PATH_x86, My.Settings.SNES9x_PATH_x64)

                Case 9 ' Bsnes
                    ProcStart.FileName = My.Settings.BSNES_PATH_x64

                Case 10 ' Graphic Editor
                    ProcStart.FileName = My.Settings.GRAPHICEDITOR_PATH

                Case 11 ' YY-CHR
                    ProcStart.FileName = My.Settings.YYCHR_PATH

            End Select

#End Region

            Process.Start(ProcStart)

        Catch ex As Exception

            MsgBox(ex.Message & vbNewLine & vbNewLine & Frm99_TranslateForm.UI01_ExecutablePath.Text & vbNewLine & My.Settings.CUSTOM_SHORTCUT_6_PATH, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ShortcutError.Text} ({Frm99_TranslateForm.UI01_ShortcutTitle.Text} {Shortcut_6.Tag})")

        End Try

    End Sub

    ' ---------------------------------------------------------------------------------------------------------------------
    ' Bottom bar buttons

    ' "Settings" button
    Private Sub BtmBar_OptionsBtn_Click(sender As Object, e As EventArgs) Handles BtmBar_OptionsBtn.Click

        TopMost = False

        Frm03_Settings.ShowDialog()

        Select Case My.Settings.LOCK_AT_TOPMOST
            Case True
                TopMost = False
        End Select

    End Sub

    ' "Help" button
    Private Sub BtmBar_HelpBtn_Click(sender As Object, e As EventArgs) Handles BtmBar_HelpBtn.Click

        Try
            Process.Start("https://github.com/Kiki79250CoC/SMWMTL/wiki")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, My.Application.Info.AssemblyName)
        End Try

    End Sub

    ' "Suggest Tool / Update" button
    Private Sub BtmBar_SuggestBtn_Click(sender As Object, e As EventArgs) Handles BtmBar_SuggestBtn.Click

        TopMost = False

        Dim SuggestApp As New Frm08_SuggestFeature
        SuggestApp.ShowDialog()

        Select Case My.Settings.LOCK_AT_TOPMOST
            Case True
                TopMost = False
        End Select

    End Sub

    ' "Report Bug / Crash" button
    Private Sub BtmBar_BugReportBtn_Click(sender As Object, e As EventArgs) Handles BtmBar_BugReportBtn.Click

        TopMost = False

        Dim BugFound As New Frm07_BugsFound
        BugFound.ShowDialog()

        Select Case My.Settings.LOCK_AT_TOPMOST
            Case True
                TopMost = False
        End Select

    End Sub

    ' "OS Version" button
    Private Sub BtmBar_WinverBtn_Click(sender As Object, e As EventArgs) Handles BtmBar_WinverBtn.Click

        TopMost = False

        Select Case My.Settings.BUILT_IN_WINVER
            Case True
                Dim f As New Frm06_OS_Version
                f.ShowDialog()

            Case False
                Try
                    Process.Start("Winver.exe")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({Frm99_TranslateForm.UI01_WinverBtnTitle.Text})")
                End Try

        End Select

        Select Case My.Settings.LOCK_AT_TOPMOST
            Case True
                TopMost = False
        End Select

    End Sub

    ' "Task manager" button
    Private Sub BtmBar_TaskmgrBtn_Click(sender As Object, e As EventArgs) Handles BtmBar_TaskmgrBtn.Click

        TopMost = False

        Try
            Process.Start("taskmgr.exe")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI01_ProgramErrorTitle.Text} ({Frm99_TranslateForm.UI01_TaskmgrBtnTitle.Text})")
        End Try

        Select Case My.Settings.LOCK_AT_TOPMOST
            Case True
                TopMost = False
        End Select

    End Sub

    ' "About SMWMTL" button
    Private Sub BtmBar_AboutBtn_Click(sender As Object, e As EventArgs) Handles BtmBar_AboutBtn.Click

        TopMost = False

        Select Case My.Settings.USE_SHELL32_ABOUTBOX
            Case True
                ShellAbout(Handle, WindowTitle, $"     {My.Application.Info.AssemblyName}_{My.Resources.APP_CODENAME}_{My.Resources.APP_VERSION_COMPLETE}_x64_{My.Resources.BUILD_DATE_COMBINED}", Icon.Handle)

            Case False
                Dim About As New Frm02_About
                About.ShowDialog()

        End Select

        Select Case My.Settings.LOCK_AT_TOPMOST
            Case True
                TopMost = False
        End Select

    End Sub

    ' "Show/Hide bottom bar" button
    Private Sub BtmBar_MenuRetractBtnCbx_CheckedChanged(sender As Object, e As EventArgs) Handles BtmBar_MenuRetractBtnCbx.CheckedChanged

        Dim BtmbarBtns As New List(Of Button) From {BtmBar_HelpBtn, BtmBar_SuggestBtn, BtmBar_BugReportBtn, BtmBar_WinverBtn, BtmBar_TaskmgrBtn, BtmBar_AboutBtn}
        Dim BtmbarSeps As New List(Of PictureBox) From {BtmBar_Separator_1, BtmBar_Separator_2, BtmBar_Separator_3, BtmBar_Separator_4}

        Select Case BtmBar_MenuRetractBtnCbx.Checked
            Case True
                MenuRetractBtn_ToolTip.ToolTipTitle = Frm99_TranslateForm.UI01_HideBottomButtonsBtnTitle.Text
                MenuRetractBtn_ToolTip.SetToolTip(BtmBar_MenuRetractBtnCbx, Frm99_TranslateForm.UI01_HideBottomButtonsBtnDesc.Text)

                BtmBar_HelpBtn.Visible = My.Settings.SHOW_HELP_BTN
                BtmBar_SuggestBtn.Visible = My.Settings.SHOW_SUGGESTUPDATE_BTN
                BtmBar_BugReportBtn.Visible = My.Settings.SHOW_REPORTCRASH_BTN
                BtmBar_WinverBtn.Visible = My.Settings.SHOW_WINVER_BTN
                BtmBar_TaskmgrBtn.Visible = My.Settings.SHOW_TASKMGR_BTN
                BtmBar_AboutBtn.Visible = True

                Select Case My.Settings.SHOW_BTN_SEPARATORS
                    Case True

                        BtmBar_Separator_4.Visible = BtmBar_HelpBtn.Visible

                        If BtmBar_SuggestBtn.Visible = True OrElse BtmBar_BugReportBtn.Visible = True Then
                            BtmBar_Separator_3.Visible = True
                        End If

                        If BtmBar_WinverBtn.Visible = True OrElse BtmBar_TaskmgrBtn.Visible = True Then
                            BtmBar_Separator_2.Visible = True
                        End If

                    Case False
                        For Each BtnSeparators In BtmbarSeps
                            BtnSeparators.Visible = False
                        Next

                End Select

                BtmBar_Separator_1.Visible = BtmBar_HelpBtn.Visible

            Case False
                MenuRetractBtn_ToolTip.ToolTipTitle = Frm99_TranslateForm.UI01_ShowBottomButtonsBtnTitle.Text
                MenuRetractBtn_ToolTip.SetToolTip(BtmBar_MenuRetractBtnCbx, Frm99_TranslateForm.UI01_ShowBottomButtonsBtnDesc.Text)

                For Each Buttons In BtmbarBtns
                    Buttons.Visible = False
                Next
                For Each BtnSeparators In BtmbarSeps
                    BtnSeparators.Visible = False
                Next

        End Select

    End Sub

    ' ---------------------------------------------------------------------------------------------------------------------
    ' System tray menu items

    ' Update available
    Private Sub SysTray_Menu_UpdateAvailable_Click(sender As Object, e As EventArgs) Handles SysTray_Menu_UpdateAvailable.Click
        Frm04_UpdatesModal.ShowDialog()
    End Sub

    ' Open Settings
    Private Sub SysTray_Menu_OpenSettings_Click(sender As Object, e As EventArgs) Handles SysTray_Menu_OpenSettings.Click
        Frm03_Settings.ShowDialog()
    End Sub

    ' Restart SMWMTL
    Private Sub SysTray_Menu_RestartApplication_Click(sender As Object, e As EventArgs) Handles SysTray_Menu_RestartApplication.Click
        My.Settings.Save()
        Application.Restart()
    End Sub

    ' Close SMWMTL
    Private Sub SysTray_Menu_CloseApplication_Click(sender As Object, e As EventArgs) Handles SysTray_Menu_CloseApplication.Click
        My.Settings.Save()
        Application.Exit()
    End Sub

    ' ---------------------------------------------------------------------------------------------------------------------

    ' Keyboard shortcuts
    Private Sub Frm01_Main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        ' Keyboard shortcuts for normal actions

        ' CTRL + F12 - Open "About SMWMTL" window
        If e.Control AndAlso (e.KeyCode = Keys.F12) Then
            Select Case My.Settings.KEYBOARD_SCT_ABOUTDIALOG
                Case True
                    BtmBar_AboutBtn_Click(BtmBar_AboutBtn, EventArgs.Empty)

            End Select
        End If

        ' F1 - Open help
        If e.KeyCode = Keys.F1 Then
            Select Case My.Settings.KEYBOARD_SCT_HELP
                Case True
                    BtmBar_HelpBtn_Click(BtmBar_HelpBtn, EventArgs.Empty)

            End Select
        End If

        ' CTRL + S - Open "Suggest Tool / Update" window
        If e.Control AndAlso (e.KeyCode = Keys.S) Then
            Select Case My.Settings.KEYBOARD_SCT_SUGGESTUPDATE
                Case True
                    BtmBar_SuggestBtn_Click(BtmBar_SuggestBtn, EventArgs.Empty)

            End Select
        End If

        ' CTRL + P - Open settings
        If e.Control AndAlso (e.KeyCode = Keys.P) Then
            Select Case My.Settings.KEYBOARD_SCT_SETTINGS
                Case True
                    BtmBar_OptionsBtn_Click(BtmBar_OptionsBtn, EventArgs.Empty)

            End Select
        End If

        ' CTRL + SHIFT + DELETE - Quickly restart SMWMTL
        If e.Control AndAlso e.Shift AndAlso (e.KeyCode = Keys.Delete) Then
            Select Case My.Settings.KEYBOARD_SCT_RESTART
                Case True
                    Application.Restart()

            End Select
        End If

        ' Keyboard shortcuts for custom ones

        ' Shortcut 1
        If e.Control AndAlso e.KeyCode = Keys.NumPad1 OrElse e.Control AndAlso e.KeyCode = 49 Then
            Select Case My.Settings.KEYBOARD_SCT_CUSTOMSHORTCUTS
                Case True
                    Shortcut_1_Click(Shortcut_1, EventArgs.Empty)

            End Select
        End If

        ' Shortcut 2
        If e.Control AndAlso e.KeyCode = Keys.NumPad2 OrElse e.Control AndAlso e.KeyCode = 50 Then
            Select Case My.Settings.KEYBOARD_SCT_CUSTOMSHORTCUTS
                Case True
                    Shortcut_2_Click(Shortcut_2, EventArgs.Empty)

            End Select
        End If

        ' Shortcut 3
        If e.Control AndAlso e.KeyCode = Keys.NumPad3 OrElse e.Control AndAlso e.KeyCode = 51 Then
            Select Case My.Settings.KEYBOARD_SCT_CUSTOMSHORTCUTS
                Case True
                    Shortcut_3_Click(Shortcut_3, EventArgs.Empty)

            End Select
        End If

        ' Shortcut 4
        If e.Control AndAlso e.KeyCode = Keys.NumPad4 OrElse e.Control AndAlso e.KeyCode = 52 Then
            Select Case My.Settings.KEYBOARD_SCT_CUSTOMSHORTCUTS
                Case True
                    Shortcut_4_Click(Shortcut_4, EventArgs.Empty)

            End Select
        End If

        ' Shortcut 5
        If e.Control AndAlso e.KeyCode = Keys.NumPad5 OrElse e.Control AndAlso e.KeyCode = 53 Then
            Select Case My.Settings.KEYBOARD_SCT_CUSTOMSHORTCUTS
                Case True
                    Shortcut_5_Click(Shortcut_5, EventArgs.Empty)

            End Select
        End If

        ' Shortcut 6
        If e.Control AndAlso e.KeyCode = Keys.NumPad6 OrElse e.Control AndAlso e.KeyCode = 54 Then
            Select Case My.Settings.KEYBOARD_SCT_CUSTOMSHORTCUTS
                Case True
                    Shortcut_6_Click(Shortcut_6, EventArgs.Empty)

            End Select
        End If

    End Sub

    ' Page end

End Class