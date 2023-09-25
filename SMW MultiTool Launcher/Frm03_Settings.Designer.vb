<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm03_Settings
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm03_Settings))
        Me.UI_MainSettingsTab = New System.Windows.Forms.TabControl()
        Me.UI_SettingsTab01 = New System.Windows.Forms.TabPage()
        Me.UI_Tab01_Title02 = New System.Windows.Forms.Label()
        Me.UI_Tab01_Cat04 = New System.Windows.Forms.GroupBox()
        Me.Text_003 = New System.Windows.Forms.Label()
        Me.AppOption_Theme = New System.Windows.Forms.ComboBox()
        Me.UI_Tab01_Cat03 = New System.Windows.Forms.GroupBox()
        Me.AppOption_OpacityValue = New System.Windows.Forms.TrackBar()
        Me.AppOption_OpacityPercentage = New System.Windows.Forms.Label()
        Me.Text_002 = New System.Windows.Forms.Label()
        Me.AppOption_AppOpacityApplyMode = New System.Windows.Forms.ComboBox()
        Me.AppOption_AppOpacity = New System.Windows.Forms.CheckBox()
        Me.Text_001 = New System.Windows.Forms.Label()
        Me.UI_Tab01_Cat02 = New System.Windows.Forms.GroupBox()
        Me.AppOption_CustomTextFormattingCodes = New System.Windows.Forms.LinkLabel()
        Me.AppOption_TitleCustomText = New System.Windows.Forms.TextBox()
        Me.ChrCount01 = New System.Windows.Forms.Label()
        Me.AppOption_AdditionalTitleTextType = New System.Windows.Forms.ComboBox()
        Me.AppOption_CustomTitleText = New System.Windows.Forms.CheckBox()
        Me.UI_Tab01_Cat02_UnderOption01 = New System.Windows.Forms.PictureBox()
        Me.AppOption_HideTitle = New System.Windows.Forms.CheckBox()
        Me.AppOption_ShowBlankIcon = New System.Windows.Forms.CheckBox()
        Me.AppOption_HideIcon = New System.Windows.Forms.CheckBox()
        Me.AppOption_LockAtTopMost = New System.Windows.Forms.CheckBox()
        Me.UI_Tab01_Title01 = New System.Windows.Forms.Label()
        Me.UI_Tab01_Cat01 = New System.Windows.Forms.GroupBox()
        Me.AppOption_DarkThemeToggle = New System.Windows.Forms.CheckBox()
        Me.AppOption_WinClassicEnhancements = New System.Windows.Forms.CheckBox()
        Me.AppOption_DWMExtension = New System.Windows.Forms.CheckBox()
        Me.UI_SettingsTab02 = New System.Windows.Forms.TabPage()
        Me.UI_Tab02_Title01 = New System.Windows.Forms.Label()
        Me.UI_Tab02_Cat03 = New System.Windows.Forms.GroupBox()
        Me.Shell32AboutIcon = New System.Windows.Forms.PictureBox()
        Me.AppOption_UseShell32About = New System.Windows.Forms.CheckBox()
        Me.UI_Tab02_Cat03_UnderOption02 = New System.Windows.Forms.PictureBox()
        Me.UI_Tab02_Cat04 = New System.Windows.Forms.GroupBox()
        Me.BtmBarSeparatorsIcon = New System.Windows.Forms.PictureBox()
        Me.AppOption_BtmBarSeparators = New System.Windows.Forms.CheckBox()
        Me.HideBottomBtnsIcon = New System.Windows.Forms.PictureBox()
        Me.AppOption_HideBottomBtns = New System.Windows.Forms.CheckBox()
        Me.AboutButtonIcon = New System.Windows.Forms.PictureBox()
        Me.TaskmgrButtonIcon = New System.Windows.Forms.PictureBox()
        Me.BuiltInWinverButtonIcon = New System.Windows.Forms.PictureBox()
        Me.WinverButtonIcon = New System.Windows.Forms.PictureBox()
        Me.ReportCrashButtonIcon = New System.Windows.Forms.PictureBox()
        Me.SuggestUpdateButtonIcon = New System.Windows.Forms.PictureBox()
        Me.HelpButtonIcon = New System.Windows.Forms.PictureBox()
        Me.UI_Tab02_Cat03_UnderOption01 = New System.Windows.Forms.PictureBox()
        Me.AppOption_BuiltInAboutWindows_Prewiew = New System.Windows.Forms.LinkLabel()
        Me.AppOption_DisplayReportCrashButton = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayAboutButton = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayTaskmgrButton = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayHelpButton = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplaySuggestUpdateButton = New System.Windows.Forms.CheckBox()
        Me.AppOption_BuiltInWinver = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayWinverButton = New System.Windows.Forms.CheckBox()
        Me.UI_Tab02_Cat02 = New System.Windows.Forms.GroupBox()
        Me.Text_006 = New System.Windows.Forms.Label()
        Me.Text_005 = New System.Windows.Forms.Label()
        Me.TaskmgrIcon_Preview = New System.Windows.Forms.PictureBox()
        Me.Taskmgr_CurrentOSIcon = New System.Windows.Forms.PictureBox()
        Me.AppOption_TaskmgrIconBasedOnCurrentOS = New System.Windows.Forms.CheckBox()
        Me.AppOption_TaskmgrIconLineColor = New System.Windows.Forms.ComboBox()
        Me.AppOption_TaskmgrIconBackColor = New System.Windows.Forms.ComboBox()
        Me.UI_Tab02_Cat01 = New System.Windows.Forms.GroupBox()
        Me.WinverIcon_Preview = New System.Windows.Forms.PictureBox()
        Me.Winver_CurrentOSIcon = New System.Windows.Forms.PictureBox()
        Me.AppOption_WinverIconBasedOnCurrentOS = New System.Windows.Forms.CheckBox()
        Me.Text_004 = New System.Windows.Forms.Label()
        Me.AppOption_WinverIcon = New System.Windows.Forms.ComboBox()
        Me.UI_SettingsTab03 = New System.Windows.Forms.TabPage()
        Me.UI_Tab03_Cat03 = New System.Windows.Forms.GroupBox()
        Me.AppOption_ShowSystrayIcon = New System.Windows.Forms.CheckBox()
        Me.UI_Tab03_Cat04 = New System.Windows.Forms.GroupBox()
        Me.AppOption_OpenAboutDialogKeyboardShortcut = New System.Windows.Forms.CheckBox()
        Me.AppOption_OpenSuggestUpdateKeyboardShortcut = New System.Windows.Forms.CheckBox()
        Me.AppOption_OpenHelpKeyboardShortcut = New System.Windows.Forms.CheckBox()
        Me.AppOption_CustomShortcutsKeyboardShortcut = New System.Windows.Forms.CheckBox()
        Me.AppOption_OpenSettingsKeyboardShortcut = New System.Windows.Forms.CheckBox()
        Me.AppOption_QuickRestartKeyboardShortcut = New System.Windows.Forms.CheckBox()
        Me.UI_Tab03_Cat01 = New System.Windows.Forms.GroupBox()
        Me.AppOption_DisplayBtn_UncheckAll = New System.Windows.Forms.Button()
        Me.AppOption_DisplayCompleteVersionOnMainWindow = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_CheckAll = New System.Windows.Forms.Button()
        Me.AppOption_DisplayBtn_SpriteGFX = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_MultipleMidwayPoints = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_InteractionEdit = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_MarioStartEditor = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_Snes9x = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_Asar = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_PetiteMM = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_Btn35 = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_GradientTool = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_UberASM = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_SHTools = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_SMWCust = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_YYCHR = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_GraphEdit = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_GopherPopcornStew = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_Btn34 = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_EffectTools = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_SPCTool = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_StatusEffects = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_Flips = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_SPC700Player = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_Mode7Tilemap = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_Pixi = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_Blockreator = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_BRRPlayer = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_LvMusUtil = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_AddMusicK = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_MMLEdit = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_HDMARipper = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_HeAdder = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_MarioLPE = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_SnesGFX = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_RecoverLM = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_LunarExpand = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_LunarMagic = New System.Windows.Forms.CheckBox()
        Me.Text_008 = New System.Windows.Forms.Label()
        Me.AppOption_ColumnsNumberComboBox = New System.Windows.Forms.ComboBox()
        Me.Text_007 = New System.Windows.Forms.Label()
        Me.UI_Tab03_Cat02 = New System.Windows.Forms.GroupBox()
        Me.AppOption_EnableLegacyAboutBox = New System.Windows.Forms.CheckBox()
        Me.AppOption_HideVersionStringInAboutBox = New System.Windows.Forms.CheckBox()
        Me.UI_Tab03_Title01 = New System.Windows.Forms.Label()
        Me.UI_SettingsTab04 = New System.Windows.Forms.TabPage()
        Me.UI_Tab04_Cat05 = New System.Windows.Forms.GroupBox()
        Me.AppOption_Shortcut4_Path = New System.Windows.Forms.TextBox()
        Me.AppOption_EnableCustomShortcut_4 = New System.Windows.Forms.CheckBox()
        Me.AppOption_Shortcut4_SelectFile = New System.Windows.Forms.LinkLabel()
        Me.Text_018 = New System.Windows.Forms.Label()
        Me.AppOption_Shortcut4_Icon = New System.Windows.Forms.ComboBox()
        Me.Text_019 = New System.Windows.Forms.Label()
        Me.Text_020 = New System.Windows.Forms.Label()
        Me.AppOption_Shortcut4_LaunchWith = New System.Windows.Forms.ComboBox()
        Me.UI_Tab04_Cat07 = New System.Windows.Forms.GroupBox()
        Me.AppOption_Shortcut6_Path = New System.Windows.Forms.TextBox()
        Me.AppOption_EnableCustomShortcut_6 = New System.Windows.Forms.CheckBox()
        Me.Text_024 = New System.Windows.Forms.Label()
        Me.Text_025 = New System.Windows.Forms.Label()
        Me.AppOption_Shortcut6_SelectFile = New System.Windows.Forms.LinkLabel()
        Me.AppOption_Shortcut6_Icon = New System.Windows.Forms.ComboBox()
        Me.AppOption_Shortcut6_LaunchWith = New System.Windows.Forms.ComboBox()
        Me.Text_026 = New System.Windows.Forms.Label()
        Me.UI_Tab04_Cat04 = New System.Windows.Forms.GroupBox()
        Me.AppOption_Shortcut3_Path = New System.Windows.Forms.TextBox()
        Me.AppOption_Shortcut3_SelectFile = New System.Windows.Forms.LinkLabel()
        Me.AppOption_Shortcut3_Icon = New System.Windows.Forms.ComboBox()
        Me.Text_017 = New System.Windows.Forms.Label()
        Me.AppOption_Shortcut3_LaunchWith = New System.Windows.Forms.ComboBox()
        Me.Text_016 = New System.Windows.Forms.Label()
        Me.Text_015 = New System.Windows.Forms.Label()
        Me.AppOption_EnableCustomShortcut_3 = New System.Windows.Forms.CheckBox()
        Me.UI_Tab04_Cat06 = New System.Windows.Forms.GroupBox()
        Me.AppOption_Shortcut5_Path = New System.Windows.Forms.TextBox()
        Me.AppOption_EnableCustomShortcut_5 = New System.Windows.Forms.CheckBox()
        Me.Text_021 = New System.Windows.Forms.Label()
        Me.AppOption_Shortcut5_SelectFile = New System.Windows.Forms.LinkLabel()
        Me.AppOption_Shortcut5_LaunchWith = New System.Windows.Forms.ComboBox()
        Me.Text_023 = New System.Windows.Forms.Label()
        Me.AppOption_Shortcut5_Icon = New System.Windows.Forms.ComboBox()
        Me.Text_022 = New System.Windows.Forms.Label()
        Me.UI_Tab04_Cat03 = New System.Windows.Forms.GroupBox()
        Me.AppOption_Shortcut2_Path = New System.Windows.Forms.TextBox()
        Me.AppOption_Shortcut2_SelectFile = New System.Windows.Forms.LinkLabel()
        Me.AppOption_EnableCustomShortcut_2 = New System.Windows.Forms.CheckBox()
        Me.AppOption_Shortcut2_Icon = New System.Windows.Forms.ComboBox()
        Me.Text_012 = New System.Windows.Forms.Label()
        Me.Text_014 = New System.Windows.Forms.Label()
        Me.AppOption_Shortcut2_LaunchWith = New System.Windows.Forms.ComboBox()
        Me.Text_013 = New System.Windows.Forms.Label()
        Me.UI_Tab04_Cat02 = New System.Windows.Forms.GroupBox()
        Me.AppOption_Shortcut1_Path = New System.Windows.Forms.TextBox()
        Me.AppOption_Shortcut1_SelectFile = New System.Windows.Forms.LinkLabel()
        Me.AppOption_Shortcut1_Icon = New System.Windows.Forms.ComboBox()
        Me.Text_011 = New System.Windows.Forms.Label()
        Me.AppOption_Shortcut1_LaunchWith = New System.Windows.Forms.ComboBox()
        Me.Text_010 = New System.Windows.Forms.Label()
        Me.Text_009 = New System.Windows.Forms.Label()
        Me.AppOption_EnableCustomShortcut_1 = New System.Windows.Forms.CheckBox()
        Me.UI_Tab04_Cat01 = New System.Windows.Forms.GroupBox()
        Me.AppOption_EnableCustomShortcuts = New System.Windows.Forms.CheckBox()
        Me.UI_Tab04_Title01 = New System.Windows.Forms.Label()
        Me.UI_SettingsTab05 = New System.Windows.Forms.TabPage()
        Me.UI_Tab05_Cat03 = New System.Windows.Forms.GroupBox()
        Me.AppOption_UpdateAutomaticInstallSilentMode = New System.Windows.Forms.CheckBox()
        Me.UI_Tab04_Cat03_UnderOption01 = New System.Windows.Forms.PictureBox()
        Me.AppOption_UpdateAutomaticDownload = New System.Windows.Forms.CheckBox()
        Me.AppOption_UpdateAutomaticInstall = New System.Windows.Forms.CheckBox()
        Me.UI_Tab05_Cat02 = New System.Windows.Forms.GroupBox()
        Me.AppOption_DisplayUpdateSearchVersionOnAboutWindow = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayUpdateSearchModuleOnAboutWindow = New System.Windows.Forms.CheckBox()
        Me.UI_Tab05_Title01 = New System.Windows.Forms.Label()
        Me.UI_Tab05_Cat01 = New System.Windows.Forms.GroupBox()
        Me.AppOption_UseLegacyUpdatePopups = New System.Windows.Forms.CheckBox()
        Me.UI_Tab04_Cat01_UnderOption02 = New System.Windows.Forms.PictureBox()
        Me.AppOption_UpdateAtStartup_DiscreteMode = New System.Windows.Forms.CheckBox()
        Me.UI_Tab04_Cat01_UnderOption01 = New System.Windows.Forms.PictureBox()
        Me.AppOption_SearchUpdateAtAppStart = New System.Windows.Forms.CheckBox()
        Me.UI_SettingsTab06 = New System.Windows.Forms.TabPage()
        Me.UI_Tab06_ApplicationTabControl = New System.Windows.Forms.TabControl()
        Me.UI_Tab06_Tab01_LunarMagic = New System.Windows.Forms.TabPage()
        Me.UI_Tab06_Cat01_SubCat04 = New System.Windows.Forms.GroupBox()
        Me.AppOption_LM1CTL_DisplaySelectorOnCTRLClick = New System.Windows.Forms.CheckBox()
        Me.AppOption_EnableLM1CTL = New System.Windows.Forms.CheckBox()
        Me.AppOption_LM1CTL_VersionSelector = New System.Windows.Forms.ComboBox()
        Me.Text_036 = New System.Windows.Forms.Label()
        Me.UI_Tab06_Cat01_SubCat03 = New System.Windows.Forms.GroupBox()
        Me.AppOption_EnableHeaderMagicLMSlot3 = New System.Windows.Forms.CheckBox()
        Me.AppOption_EnableLMSlot3 = New System.Windows.Forms.CheckBox()
        Me.AppOption_LMslot3_SelectExecutable = New System.Windows.Forms.LinkLabel()
        Me.AppOption_LMslot3_Path = New System.Windows.Forms.TextBox()
        Me.Text_035 = New System.Windows.Forms.Label()
        Me.Text_033 = New System.Windows.Forms.Label()
        Me.AppOption_LMslot3_Name = New System.Windows.Forms.TextBox()
        Me.AppOption_LMslot3_Version = New System.Windows.Forms.ComboBox()
        Me.Text_034 = New System.Windows.Forms.Label()
        Me.UI_Tab06_Cat01_SubCat01 = New System.Windows.Forms.GroupBox()
        Me.AppOption_EnableLMSlot1 = New System.Windows.Forms.CheckBox()
        Me.AppOption_LMslot1_SelectExecutable = New System.Windows.Forms.LinkLabel()
        Me.AppOption_EnableHeaderMagicLMSlot1 = New System.Windows.Forms.CheckBox()
        Me.AppOption_LMslot1_Path = New System.Windows.Forms.TextBox()
        Me.Text_029 = New System.Windows.Forms.Label()
        Me.Text_027 = New System.Windows.Forms.Label()
        Me.AppOption_LMslot1_Name = New System.Windows.Forms.TextBox()
        Me.AppOption_LMslot1_Version = New System.Windows.Forms.ComboBox()
        Me.Text_028 = New System.Windows.Forms.Label()
        Me.UI_Tab06_Cat01_SubCat02 = New System.Windows.Forms.GroupBox()
        Me.AppOption_EnableHeaderMagicLMSlot2 = New System.Windows.Forms.CheckBox()
        Me.AppOption_EnableLMSlot2 = New System.Windows.Forms.CheckBox()
        Me.AppOption_LMslot2_SelectExecutable = New System.Windows.Forms.LinkLabel()
        Me.AppOption_LMslot2_Path = New System.Windows.Forms.TextBox()
        Me.Text_032 = New System.Windows.Forms.Label()
        Me.Text_030 = New System.Windows.Forms.Label()
        Me.AppOption_LMslot2_Name = New System.Windows.Forms.TextBox()
        Me.AppOption_LMslot2_Version = New System.Windows.Forms.ComboBox()
        Me.Text_031 = New System.Windows.Forms.Label()
        Me.UI_Tab06_Tab02_Snes9xBsnes = New System.Windows.Forms.TabPage()
        Me.UI_Tab06_Cat02_SubCat03 = New System.Windows.Forms.GroupBox()
        Me.AppOption_SelectBsnesExecutable = New System.Windows.Forms.LinkLabel()
        Me.Text_041 = New System.Windows.Forms.Label()
        Me.AppOption_BsnesExecutable = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat02_SubCat02 = New System.Windows.Forms.GroupBox()
        Me.Text_040 = New System.Windows.Forms.Label()
        Me.AppOption_Snes9x_SelectedArch = New System.Windows.Forms.ComboBox()
        Me.AppOption_Snes9x_Selectx64Executable = New System.Windows.Forms.LinkLabel()
        Me.AppOption_Snes9x_Selectx86Executable = New System.Windows.Forms.LinkLabel()
        Me.Text_039 = New System.Windows.Forms.Label()
        Me.AppOption_Snes9x_UseColoredIcon = New System.Windows.Forms.CheckBox()
        Me.AppOption_Snes9x_x64Executable = New System.Windows.Forms.TextBox()
        Me.Text_038 = New System.Windows.Forms.Label()
        Me.AppOption_Snes9x_x86Executable = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat02_SubCat01 = New System.Windows.Forms.GroupBox()
        Me.Text_037 = New System.Windows.Forms.Label()
        Me.AppOption_SnesEmuSelector = New System.Windows.Forms.ComboBox()
        Me.UI_Tab06_Tab03_SmallHackerTools = New System.Windows.Forms.TabPage()
        Me.UI_Tab06_Cat03_SubCat04 = New System.Windows.Forms.GroupBox()
        Me.UI_Tab06_Cat03_SubCat05 = New System.Windows.Forms.GroupBox()
        Me.AppOption_SMWENI_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_045 = New System.Windows.Forms.Label()
        Me.AppOption_SMWENI_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat03_SubCat06 = New System.Windows.Forms.GroupBox()
        Me.AppOption_SMWENE_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_046 = New System.Windows.Forms.Label()
        Me.AppOption_SMWENE_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat03_SubCat01 = New System.Windows.Forms.GroupBox()
        Me.Text_042 = New System.Windows.Forms.Label()
        Me.AppOption_DisplayBtn_SMWTYMI = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_SMWSBE = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_SMWPTE = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_SMWMTE = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_SMWENE = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_SMWENI = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_SMWBBPE = New System.Windows.Forms.CheckBox()
        Me.AppOption_DisplayBtn_ILBPE = New System.Windows.Forms.CheckBox()
        Me.UI_Tab06_Cat03_SubCat10 = New System.Windows.Forms.GroupBox()
        Me.AppOption_SMWTYMI_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_050 = New System.Windows.Forms.Label()
        Me.AppOption_SMWTYMI_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat03_SubCat09 = New System.Windows.Forms.GroupBox()
        Me.AppOption_SMWSBE_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_049 = New System.Windows.Forms.Label()
        Me.AppOption_SMWSBE_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat03_SubCat08 = New System.Windows.Forms.GroupBox()
        Me.AppOption_SMWPTE_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_048 = New System.Windows.Forms.Label()
        Me.AppOption_SMWPTE_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat03_SubCat03 = New System.Windows.Forms.GroupBox()
        Me.AppOption_SMWBBPE_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_044 = New System.Windows.Forms.Label()
        Me.AppOption_SMWBBPE_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat03_SubCat07 = New System.Windows.Forms.GroupBox()
        Me.AppOption_SMWMTE_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_047 = New System.Windows.Forms.Label()
        Me.AppOption_SMWMTE_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat03_SubCat02 = New System.Windows.Forms.GroupBox()
        Me.AppOption_ILBPE_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_043 = New System.Windows.Forms.Label()
        Me.AppOption_ILBPE_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Tab04_OtherApps1 = New System.Windows.Forms.TabPage()
        Me.UI_Tab06_Cat04_SubCat10 = New System.Windows.Forms.GroupBox()
        Me.AppOption_BRRPlayer_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_061 = New System.Windows.Forms.Label()
        Me.AppOption_BRRPlayer_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat04_SubCat09 = New System.Windows.Forms.GroupBox()
        Me.AppOption_LvMusUtil_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_060 = New System.Windows.Forms.Label()
        Me.AppOption_LvMusUtil_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat04_SubCat08 = New System.Windows.Forms.GroupBox()
        Me.AppOption_AMK_GUI_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_059 = New System.Windows.Forms.Label()
        Me.AppOption_AMK_GUI_Path = New System.Windows.Forms.TextBox()
        Me.AppOption_AMK_CMD_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_058 = New System.Windows.Forms.Label()
        Me.AppOption_AMK_CMD_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat04_SubCat07 = New System.Windows.Forms.GroupBox()
        Me.AppOption_MMLEdit_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_057 = New System.Windows.Forms.Label()
        Me.AppOption_MMLEdit_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat04_SubCat06 = New System.Windows.Forms.GroupBox()
        Me.AppOption_HdmaGR_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_056 = New System.Windows.Forms.Label()
        Me.AppOption_HdmaGR_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat04_SubCat05 = New System.Windows.Forms.GroupBox()
        Me.AppOption_HeAdder_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_055 = New System.Windows.Forms.Label()
        Me.AppOption_HeAdder_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat04_SubCat04 = New System.Windows.Forms.GroupBox()
        Me.AppOption_MarioLuigiLPE_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_054 = New System.Windows.Forms.Label()
        Me.AppOption_MarioLuigiLPE_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat04_SubCat03 = New System.Windows.Forms.GroupBox()
        Me.AppOption_SnesGFX_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_053 = New System.Windows.Forms.Label()
        Me.AppOption_SnesGFX_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat04_SubCat02 = New System.Windows.Forms.GroupBox()
        Me.AppOption_RecoverLM_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_052 = New System.Windows.Forms.Label()
        Me.AppOption_RecoverLM_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat04_SubCat01 = New System.Windows.Forms.GroupBox()
        Me.AppOption_LunarExpand_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_051 = New System.Windows.Forms.Label()
        Me.AppOption_LunarExpand_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Tab05_OtherApps2 = New System.Windows.Forms.TabPage()
        Me.UI_Tab06_Cat05_SubCat02 = New System.Windows.Forms.GroupBox()
        Me.AppOption_PixiConfigurator_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_064 = New System.Windows.Forms.Label()
        Me.AppOption_PixiConfigurator_Path = New System.Windows.Forms.TextBox()
        Me.AppOption_Pixi_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_063 = New System.Windows.Forms.Label()
        Me.AppOption_Pixi_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat05_SubCat10 = New System.Windows.Forms.GroupBox()
        Me.AppOption_PetiteMM_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_072 = New System.Windows.Forms.Label()
        Me.AppOption_PetiteMM_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat05_SubCat09 = New System.Windows.Forms.GroupBox()
        Me.AppOption_GPS_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_071 = New System.Windows.Forms.Label()
        Me.AppOption_GPS_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat05_SubCat08 = New System.Windows.Forms.GroupBox()
        Me.AppOption_EffectTool_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_070 = New System.Windows.Forms.Label()
        Me.AppOption_EffectTool_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat05_SubCat07 = New System.Windows.Forms.GroupBox()
        Me.AppOption_SnesColorTool_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_069 = New System.Windows.Forms.Label()
        Me.AppOption_SnesColorTool_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat05_SubCat06 = New System.Windows.Forms.GroupBox()
        Me.AppOption_StatusEffects_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_068 = New System.Windows.Forms.Label()
        Me.AppOption_StatusEffects_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat05_SubCat05 = New System.Windows.Forms.GroupBox()
        Me.AppOption_FloatingIPS_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_067 = New System.Windows.Forms.Label()
        Me.AppOption_FloatingIPS_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat05_SubCat04 = New System.Windows.Forms.GroupBox()
        Me.AppOption_SPC700Player_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_066 = New System.Windows.Forms.Label()
        Me.AppOption_SPC700Player_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat05_SubCat03 = New System.Windows.Forms.GroupBox()
        Me.AppOption_M7Map_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_065 = New System.Windows.Forms.Label()
        Me.AppOption_M7Map_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat05_SubCat01 = New System.Windows.Forms.GroupBox()
        Me.AppOption_Blockreator_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_062 = New System.Windows.Forms.Label()
        Me.AppOption_Blockreator_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Tab06_OtherApps3 = New System.Windows.Forms.TabPage()
        Me.UI_Tab06_Cat06_SubCat10 = New System.Windows.Forms.GroupBox()
        Me.AppOption_GradientTool_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_082 = New System.Windows.Forms.Label()
        Me.AppOption_GradientTool_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat06_SubCat09 = New System.Windows.Forms.GroupBox()
        Me.AppOption_UberASM_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_081 = New System.Windows.Forms.Label()
        Me.AppOption_UberASM_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat06_SubCat08 = New System.Windows.Forms.GroupBox()
        Me.AppOption_SMWCustomizer_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_080 = New System.Windows.Forms.Label()
        Me.AppOption_SMWCustomizer_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat06_SubCat07 = New System.Windows.Forms.GroupBox()
        Me.AppOption_YYCHR_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_079 = New System.Windows.Forms.Label()
        Me.AppOption_YYCHR_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat06_SubCat06 = New System.Windows.Forms.GroupBox()
        Me.AppOption_GraphicEditor_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_078 = New System.Windows.Forms.Label()
        Me.AppOption_GraphicEditor_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat06_SubCat05 = New System.Windows.Forms.GroupBox()
        Me.AppOption_SpriteGFX_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_077 = New System.Windows.Forms.Label()
        Me.AppOption_SpriteGFX_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat06_SubCat04 = New System.Windows.Forms.GroupBox()
        Me.AppOption_MultipleMidwayPoints_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_076 = New System.Windows.Forms.Label()
        Me.AppOption_MultipleMidwayPoints_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat06_SubCat03 = New System.Windows.Forms.GroupBox()
        Me.AppOption_InteractionEditor_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_075 = New System.Windows.Forms.Label()
        Me.AppOption_InteractionEditor_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat06_SubCat02 = New System.Windows.Forms.GroupBox()
        Me.AppOption_MarioSE_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_074 = New System.Windows.Forms.Label()
        Me.AppOption_MarioSE_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Cat06_SubCat01 = New System.Windows.Forms.GroupBox()
        Me.AppOption_Asar_SelectPath = New System.Windows.Forms.LinkLabel()
        Me.Text_073 = New System.Windows.Forms.Label()
        Me.AppOption_Asar_Path = New System.Windows.Forms.TextBox()
        Me.UI_Tab06_Title01 = New System.Windows.Forms.Label()
        Me.Z01_CommandBar_TabControl = New System.Windows.Forms.TabControl()
        Me.Z01_CommandBar_Tab = New System.Windows.Forms.TabPage()
        Me.UI_Btn_ExperimentalSettings = New System.Windows.Forms.Button()
        Me.UI_Btn_UpdatesModal = New System.Windows.Forms.Button()
        Me.UI_Btn_OK = New System.Windows.Forms.Button()
        Me.UI_Btn_Cancel = New System.Windows.Forms.Button()
        Me.UI_Btn_SubOptionsMenu = New System.Windows.Forms.Button()
        Me.DownArrowMenuPos = New System.Windows.Forms.PictureBox()
        Me.Z99_UIDeco02 = New System.Windows.Forms.PictureBox()
        Me.Z99_UIDeco01 = New System.Windows.Forms.PictureBox()
        Me.Z99_UIDeco03 = New System.Windows.Forms.PictureBox()
        Me.Z99_UIDeco04 = New System.Windows.Forms.PictureBox()
        Me.DownArrowMenu = New System.Windows.Forms.ContextMenu()
        Me.DownArrowMenu_ReloadSettings = New System.Windows.Forms.MenuItem()
        Me.DownArrowMenu_Sep01 = New System.Windows.Forms.MenuItem()
        Me.DownArrowMenu_ImportSettings = New System.Windows.Forms.MenuItem()
        Me.DownArrowMenu_ExportSettings = New System.Windows.Forms.MenuItem()
        Me.DownArrowMenu_Sep02 = New System.Windows.Forms.MenuItem()
        Me.DownArrowMenu_ResetSettings = New System.Windows.Forms.MenuItem()
        Me.DownArrowMenu_Sep03 = New System.Windows.Forms.MenuItem()
        Me.DownArrowMenu_HD_ExperimentalSettings = New System.Windows.Forms.MenuItem()
        Me.DownArrowMenu_Icons = New wyDay.Controls.VistaMenu(Me.components)
        Me.AppNames_HideBtnSettings = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExportSettings_SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ImportSettings_OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SelectFileForShortcut = New System.Windows.Forms.OpenFileDialog()
        Me.SelectApplicationExecutable_OpenFileBox = New System.Windows.Forms.OpenFileDialog()
        Me.SelectApplicationDirectory_OpenFolderBox = New System.Windows.Forms.FolderBrowserDialog()
        Me.UI_MainSettingsTab.SuspendLayout()
        Me.UI_SettingsTab01.SuspendLayout()
        Me.UI_Tab01_Cat04.SuspendLayout()
        Me.UI_Tab01_Cat03.SuspendLayout()
        CType(Me.AppOption_OpacityValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_Tab01_Cat02.SuspendLayout()
        CType(Me.UI_Tab01_Cat02_UnderOption01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_Tab01_Cat01.SuspendLayout()
        Me.UI_SettingsTab02.SuspendLayout()
        Me.UI_Tab02_Cat03.SuspendLayout()
        CType(Me.Shell32AboutIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UI_Tab02_Cat03_UnderOption02, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_Tab02_Cat04.SuspendLayout()
        CType(Me.BtmBarSeparatorsIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HideBottomBtnsIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AboutButtonIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskmgrButtonIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuiltInWinverButtonIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinverButtonIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportCrashButtonIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuggestUpdateButtonIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HelpButtonIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UI_Tab02_Cat03_UnderOption01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_Tab02_Cat02.SuspendLayout()
        CType(Me.TaskmgrIcon_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Taskmgr_CurrentOSIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_Tab02_Cat01.SuspendLayout()
        CType(Me.WinverIcon_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Winver_CurrentOSIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_SettingsTab03.SuspendLayout()
        Me.UI_Tab03_Cat03.SuspendLayout()
        Me.UI_Tab03_Cat04.SuspendLayout()
        Me.UI_Tab03_Cat01.SuspendLayout()
        Me.UI_Tab03_Cat02.SuspendLayout()
        Me.UI_SettingsTab04.SuspendLayout()
        Me.UI_Tab04_Cat05.SuspendLayout()
        Me.UI_Tab04_Cat07.SuspendLayout()
        Me.UI_Tab04_Cat04.SuspendLayout()
        Me.UI_Tab04_Cat06.SuspendLayout()
        Me.UI_Tab04_Cat03.SuspendLayout()
        Me.UI_Tab04_Cat02.SuspendLayout()
        Me.UI_Tab04_Cat01.SuspendLayout()
        Me.UI_SettingsTab05.SuspendLayout()
        Me.UI_Tab05_Cat03.SuspendLayout()
        CType(Me.UI_Tab04_Cat03_UnderOption01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_Tab05_Cat02.SuspendLayout()
        Me.UI_Tab05_Cat01.SuspendLayout()
        CType(Me.UI_Tab04_Cat01_UnderOption02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UI_Tab04_Cat01_UnderOption01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_SettingsTab06.SuspendLayout()
        Me.UI_Tab06_ApplicationTabControl.SuspendLayout()
        Me.UI_Tab06_Tab01_LunarMagic.SuspendLayout()
        Me.UI_Tab06_Cat01_SubCat04.SuspendLayout()
        Me.UI_Tab06_Cat01_SubCat03.SuspendLayout()
        Me.UI_Tab06_Cat01_SubCat01.SuspendLayout()
        Me.UI_Tab06_Cat01_SubCat02.SuspendLayout()
        Me.UI_Tab06_Tab02_Snes9xBsnes.SuspendLayout()
        Me.UI_Tab06_Cat02_SubCat03.SuspendLayout()
        Me.UI_Tab06_Cat02_SubCat02.SuspendLayout()
        Me.UI_Tab06_Cat02_SubCat01.SuspendLayout()
        Me.UI_Tab06_Tab03_SmallHackerTools.SuspendLayout()
        Me.UI_Tab06_Cat03_SubCat04.SuspendLayout()
        Me.UI_Tab06_Cat03_SubCat05.SuspendLayout()
        Me.UI_Tab06_Cat03_SubCat06.SuspendLayout()
        Me.UI_Tab06_Cat03_SubCat01.SuspendLayout()
        Me.UI_Tab06_Cat03_SubCat10.SuspendLayout()
        Me.UI_Tab06_Cat03_SubCat09.SuspendLayout()
        Me.UI_Tab06_Cat03_SubCat08.SuspendLayout()
        Me.UI_Tab06_Cat03_SubCat03.SuspendLayout()
        Me.UI_Tab06_Cat03_SubCat07.SuspendLayout()
        Me.UI_Tab06_Cat03_SubCat02.SuspendLayout()
        Me.UI_Tab06_Tab04_OtherApps1.SuspendLayout()
        Me.UI_Tab06_Cat04_SubCat10.SuspendLayout()
        Me.UI_Tab06_Cat04_SubCat09.SuspendLayout()
        Me.UI_Tab06_Cat04_SubCat08.SuspendLayout()
        Me.UI_Tab06_Cat04_SubCat07.SuspendLayout()
        Me.UI_Tab06_Cat04_SubCat06.SuspendLayout()
        Me.UI_Tab06_Cat04_SubCat05.SuspendLayout()
        Me.UI_Tab06_Cat04_SubCat04.SuspendLayout()
        Me.UI_Tab06_Cat04_SubCat03.SuspendLayout()
        Me.UI_Tab06_Cat04_SubCat02.SuspendLayout()
        Me.UI_Tab06_Cat04_SubCat01.SuspendLayout()
        Me.UI_Tab06_Tab05_OtherApps2.SuspendLayout()
        Me.UI_Tab06_Cat05_SubCat02.SuspendLayout()
        Me.UI_Tab06_Cat05_SubCat10.SuspendLayout()
        Me.UI_Tab06_Cat05_SubCat09.SuspendLayout()
        Me.UI_Tab06_Cat05_SubCat08.SuspendLayout()
        Me.UI_Tab06_Cat05_SubCat07.SuspendLayout()
        Me.UI_Tab06_Cat05_SubCat06.SuspendLayout()
        Me.UI_Tab06_Cat05_SubCat05.SuspendLayout()
        Me.UI_Tab06_Cat05_SubCat04.SuspendLayout()
        Me.UI_Tab06_Cat05_SubCat03.SuspendLayout()
        Me.UI_Tab06_Cat05_SubCat01.SuspendLayout()
        Me.UI_Tab06_Tab06_OtherApps3.SuspendLayout()
        Me.UI_Tab06_Cat06_SubCat10.SuspendLayout()
        Me.UI_Tab06_Cat06_SubCat09.SuspendLayout()
        Me.UI_Tab06_Cat06_SubCat08.SuspendLayout()
        Me.UI_Tab06_Cat06_SubCat07.SuspendLayout()
        Me.UI_Tab06_Cat06_SubCat06.SuspendLayout()
        Me.UI_Tab06_Cat06_SubCat05.SuspendLayout()
        Me.UI_Tab06_Cat06_SubCat04.SuspendLayout()
        Me.UI_Tab06_Cat06_SubCat03.SuspendLayout()
        Me.UI_Tab06_Cat06_SubCat02.SuspendLayout()
        Me.UI_Tab06_Cat06_SubCat01.SuspendLayout()
        Me.Z01_CommandBar_TabControl.SuspendLayout()
        Me.Z01_CommandBar_Tab.SuspendLayout()
        CType(Me.DownArrowMenuPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Z99_UIDeco02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Z99_UIDeco01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Z99_UIDeco03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Z99_UIDeco04, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DownArrowMenu_Icons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UI_MainSettingsTab
        '
        resources.ApplyResources(Me.UI_MainSettingsTab, "UI_MainSettingsTab")
        Me.UI_MainSettingsTab.Controls.Add(Me.UI_SettingsTab01)
        Me.UI_MainSettingsTab.Controls.Add(Me.UI_SettingsTab02)
        Me.UI_MainSettingsTab.Controls.Add(Me.UI_SettingsTab03)
        Me.UI_MainSettingsTab.Controls.Add(Me.UI_SettingsTab04)
        Me.UI_MainSettingsTab.Controls.Add(Me.UI_SettingsTab05)
        Me.UI_MainSettingsTab.Controls.Add(Me.UI_SettingsTab06)
        Me.UI_MainSettingsTab.Name = "UI_MainSettingsTab"
        Me.UI_MainSettingsTab.SelectedIndex = 0
        '
        'UI_SettingsTab01
        '
        Me.UI_SettingsTab01.Controls.Add(Me.UI_Tab01_Title02)
        Me.UI_SettingsTab01.Controls.Add(Me.UI_Tab01_Cat04)
        Me.UI_SettingsTab01.Controls.Add(Me.UI_Tab01_Cat03)
        Me.UI_SettingsTab01.Controls.Add(Me.UI_Tab01_Cat02)
        Me.UI_SettingsTab01.Controls.Add(Me.UI_Tab01_Title01)
        Me.UI_SettingsTab01.Controls.Add(Me.UI_Tab01_Cat01)
        resources.ApplyResources(Me.UI_SettingsTab01, "UI_SettingsTab01")
        Me.UI_SettingsTab01.Name = "UI_SettingsTab01"
        Me.UI_SettingsTab01.UseVisualStyleBackColor = True
        '
        'UI_Tab01_Title02
        '
        resources.ApplyResources(Me.UI_Tab01_Title02, "UI_Tab01_Title02")
        Me.UI_Tab01_Title02.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UI_Tab01_Title02.Name = "UI_Tab01_Title02"
        '
        'UI_Tab01_Cat04
        '
        resources.ApplyResources(Me.UI_Tab01_Cat04, "UI_Tab01_Cat04")
        Me.UI_Tab01_Cat04.Controls.Add(Me.Text_003)
        Me.UI_Tab01_Cat04.Controls.Add(Me.AppOption_Theme)
        Me.UI_Tab01_Cat04.Name = "UI_Tab01_Cat04"
        Me.UI_Tab01_Cat04.TabStop = False
        '
        'Text_003
        '
        resources.ApplyResources(Me.Text_003, "Text_003")
        Me.Text_003.Name = "Text_003"
        '
        'AppOption_Theme
        '
        resources.ApplyResources(Me.AppOption_Theme, "AppOption_Theme")
        Me.AppOption_Theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_Theme.FormattingEnabled = True
        Me.AppOption_Theme.Items.AddRange(New Object() {resources.GetString("AppOption_Theme.Items")})
        Me.AppOption_Theme.Name = "AppOption_Theme"
        '
        'UI_Tab01_Cat03
        '
        resources.ApplyResources(Me.UI_Tab01_Cat03, "UI_Tab01_Cat03")
        Me.UI_Tab01_Cat03.Controls.Add(Me.AppOption_OpacityValue)
        Me.UI_Tab01_Cat03.Controls.Add(Me.AppOption_OpacityPercentage)
        Me.UI_Tab01_Cat03.Controls.Add(Me.Text_002)
        Me.UI_Tab01_Cat03.Controls.Add(Me.AppOption_AppOpacityApplyMode)
        Me.UI_Tab01_Cat03.Controls.Add(Me.AppOption_AppOpacity)
        Me.UI_Tab01_Cat03.Controls.Add(Me.Text_001)
        Me.UI_Tab01_Cat03.Name = "UI_Tab01_Cat03"
        Me.UI_Tab01_Cat03.TabStop = False
        '
        'AppOption_OpacityValue
        '
        resources.ApplyResources(Me.AppOption_OpacityValue, "AppOption_OpacityValue")
        Me.AppOption_OpacityValue.BackColor = System.Drawing.SystemColors.Window
        Me.AppOption_OpacityValue.Maximum = 100
        Me.AppOption_OpacityValue.Minimum = 20
        Me.AppOption_OpacityValue.Name = "AppOption_OpacityValue"
        Me.AppOption_OpacityValue.TickFrequency = 5
        Me.AppOption_OpacityValue.TickStyle = System.Windows.Forms.TickStyle.None
        Me.AppOption_OpacityValue.Value = 100
        '
        'AppOption_OpacityPercentage
        '
        resources.ApplyResources(Me.AppOption_OpacityPercentage, "AppOption_OpacityPercentage")
        Me.AppOption_OpacityPercentage.Name = "AppOption_OpacityPercentage"
        '
        'Text_002
        '
        resources.ApplyResources(Me.Text_002, "Text_002")
        Me.Text_002.Name = "Text_002"
        '
        'AppOption_AppOpacityApplyMode
        '
        resources.ApplyResources(Me.AppOption_AppOpacityApplyMode, "AppOption_AppOpacityApplyMode")
        Me.AppOption_AppOpacityApplyMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_AppOpacityApplyMode.Items.AddRange(New Object() {resources.GetString("AppOption_AppOpacityApplyMode.Items"), resources.GetString("AppOption_AppOpacityApplyMode.Items1"), resources.GetString("AppOption_AppOpacityApplyMode.Items2")})
        Me.AppOption_AppOpacityApplyMode.Name = "AppOption_AppOpacityApplyMode"
        '
        'AppOption_AppOpacity
        '
        resources.ApplyResources(Me.AppOption_AppOpacity, "AppOption_AppOpacity")
        Me.AppOption_AppOpacity.Name = "AppOption_AppOpacity"
        Me.AppOption_AppOpacity.UseVisualStyleBackColor = True
        '
        'Text_001
        '
        resources.ApplyResources(Me.Text_001, "Text_001")
        Me.Text_001.Name = "Text_001"
        '
        'UI_Tab01_Cat02
        '
        resources.ApplyResources(Me.UI_Tab01_Cat02, "UI_Tab01_Cat02")
        Me.UI_Tab01_Cat02.Controls.Add(Me.AppOption_CustomTextFormattingCodes)
        Me.UI_Tab01_Cat02.Controls.Add(Me.AppOption_TitleCustomText)
        Me.UI_Tab01_Cat02.Controls.Add(Me.ChrCount01)
        Me.UI_Tab01_Cat02.Controls.Add(Me.AppOption_AdditionalTitleTextType)
        Me.UI_Tab01_Cat02.Controls.Add(Me.AppOption_CustomTitleText)
        Me.UI_Tab01_Cat02.Controls.Add(Me.UI_Tab01_Cat02_UnderOption01)
        Me.UI_Tab01_Cat02.Controls.Add(Me.AppOption_HideTitle)
        Me.UI_Tab01_Cat02.Controls.Add(Me.AppOption_ShowBlankIcon)
        Me.UI_Tab01_Cat02.Controls.Add(Me.AppOption_HideIcon)
        Me.UI_Tab01_Cat02.Controls.Add(Me.AppOption_LockAtTopMost)
        Me.UI_Tab01_Cat02.Name = "UI_Tab01_Cat02"
        Me.UI_Tab01_Cat02.TabStop = False
        '
        'AppOption_CustomTextFormattingCodes
        '
        resources.ApplyResources(Me.AppOption_CustomTextFormattingCodes, "AppOption_CustomTextFormattingCodes")
        Me.AppOption_CustomTextFormattingCodes.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_CustomTextFormattingCodes.Name = "AppOption_CustomTextFormattingCodes"
        Me.AppOption_CustomTextFormattingCodes.TabStop = True
        '
        'AppOption_TitleCustomText
        '
        resources.ApplyResources(Me.AppOption_TitleCustomText, "AppOption_TitleCustomText")
        Me.AppOption_TitleCustomText.Name = "AppOption_TitleCustomText"
        '
        'ChrCount01
        '
        resources.ApplyResources(Me.ChrCount01, "ChrCount01")
        Me.ChrCount01.Name = "ChrCount01"
        '
        'AppOption_AdditionalTitleTextType
        '
        resources.ApplyResources(Me.AppOption_AdditionalTitleTextType, "AppOption_AdditionalTitleTextType")
        Me.AppOption_AdditionalTitleTextType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_AdditionalTitleTextType.Items.AddRange(New Object() {resources.GetString("AppOption_AdditionalTitleTextType.Items"), resources.GetString("AppOption_AdditionalTitleTextType.Items1"), resources.GetString("AppOption_AdditionalTitleTextType.Items2")})
        Me.AppOption_AdditionalTitleTextType.Name = "AppOption_AdditionalTitleTextType"
        '
        'AppOption_CustomTitleText
        '
        resources.ApplyResources(Me.AppOption_CustomTitleText, "AppOption_CustomTitleText")
        Me.AppOption_CustomTitleText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AppOption_CustomTitleText.Name = "AppOption_CustomTitleText"
        Me.AppOption_CustomTitleText.UseVisualStyleBackColor = True
        '
        'UI_Tab01_Cat02_UnderOption01
        '
        Me.UI_Tab01_Cat02_UnderOption01.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.CbxUnderOptionUnavailable
        resources.ApplyResources(Me.UI_Tab01_Cat02_UnderOption01, "UI_Tab01_Cat02_UnderOption01")
        Me.UI_Tab01_Cat02_UnderOption01.Name = "UI_Tab01_Cat02_UnderOption01"
        Me.UI_Tab01_Cat02_UnderOption01.TabStop = False
        '
        'AppOption_HideTitle
        '
        resources.ApplyResources(Me.AppOption_HideTitle, "AppOption_HideTitle")
        Me.AppOption_HideTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AppOption_HideTitle.Name = "AppOption_HideTitle"
        Me.AppOption_HideTitle.UseVisualStyleBackColor = True
        '
        'AppOption_ShowBlankIcon
        '
        resources.ApplyResources(Me.AppOption_ShowBlankIcon, "AppOption_ShowBlankIcon")
        Me.AppOption_ShowBlankIcon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AppOption_ShowBlankIcon.Name = "AppOption_ShowBlankIcon"
        Me.AppOption_ShowBlankIcon.UseVisualStyleBackColor = True
        '
        'AppOption_HideIcon
        '
        resources.ApplyResources(Me.AppOption_HideIcon, "AppOption_HideIcon")
        Me.AppOption_HideIcon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AppOption_HideIcon.Name = "AppOption_HideIcon"
        Me.AppOption_HideIcon.UseVisualStyleBackColor = True
        '
        'AppOption_LockAtTopMost
        '
        resources.ApplyResources(Me.AppOption_LockAtTopMost, "AppOption_LockAtTopMost")
        Me.AppOption_LockAtTopMost.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AppOption_LockAtTopMost.Name = "AppOption_LockAtTopMost"
        Me.AppOption_LockAtTopMost.UseVisualStyleBackColor = True
        '
        'UI_Tab01_Title01
        '
        resources.ApplyResources(Me.UI_Tab01_Title01, "UI_Tab01_Title01")
        Me.UI_Tab01_Title01.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UI_Tab01_Title01.Name = "UI_Tab01_Title01"
        '
        'UI_Tab01_Cat01
        '
        resources.ApplyResources(Me.UI_Tab01_Cat01, "UI_Tab01_Cat01")
        Me.UI_Tab01_Cat01.Controls.Add(Me.AppOption_DarkThemeToggle)
        Me.UI_Tab01_Cat01.Controls.Add(Me.AppOption_WinClassicEnhancements)
        Me.UI_Tab01_Cat01.Controls.Add(Me.AppOption_DWMExtension)
        Me.UI_Tab01_Cat01.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UI_Tab01_Cat01.Name = "UI_Tab01_Cat01"
        Me.UI_Tab01_Cat01.TabStop = False
        '
        'AppOption_DarkThemeToggle
        '
        resources.ApplyResources(Me.AppOption_DarkThemeToggle, "AppOption_DarkThemeToggle")
        Me.AppOption_DarkThemeToggle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AppOption_DarkThemeToggle.Name = "AppOption_DarkThemeToggle"
        Me.AppOption_DarkThemeToggle.UseVisualStyleBackColor = True
        '
        'AppOption_WinClassicEnhancements
        '
        resources.ApplyResources(Me.AppOption_WinClassicEnhancements, "AppOption_WinClassicEnhancements")
        Me.AppOption_WinClassicEnhancements.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AppOption_WinClassicEnhancements.Name = "AppOption_WinClassicEnhancements"
        Me.AppOption_WinClassicEnhancements.UseVisualStyleBackColor = True
        '
        'AppOption_DWMExtension
        '
        resources.ApplyResources(Me.AppOption_DWMExtension, "AppOption_DWMExtension")
        Me.AppOption_DWMExtension.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AppOption_DWMExtension.Name = "AppOption_DWMExtension"
        Me.AppOption_DWMExtension.UseVisualStyleBackColor = True
        '
        'UI_SettingsTab02
        '
        Me.UI_SettingsTab02.Controls.Add(Me.UI_Tab02_Title01)
        Me.UI_SettingsTab02.Controls.Add(Me.UI_Tab02_Cat03)
        Me.UI_SettingsTab02.Controls.Add(Me.UI_Tab02_Cat02)
        Me.UI_SettingsTab02.Controls.Add(Me.UI_Tab02_Cat01)
        resources.ApplyResources(Me.UI_SettingsTab02, "UI_SettingsTab02")
        Me.UI_SettingsTab02.Name = "UI_SettingsTab02"
        Me.UI_SettingsTab02.UseVisualStyleBackColor = True
        '
        'UI_Tab02_Title01
        '
        resources.ApplyResources(Me.UI_Tab02_Title01, "UI_Tab02_Title01")
        Me.UI_Tab02_Title01.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UI_Tab02_Title01.Name = "UI_Tab02_Title01"
        '
        'UI_Tab02_Cat03
        '
        resources.ApplyResources(Me.UI_Tab02_Cat03, "UI_Tab02_Cat03")
        Me.UI_Tab02_Cat03.Controls.Add(Me.Shell32AboutIcon)
        Me.UI_Tab02_Cat03.Controls.Add(Me.AppOption_UseShell32About)
        Me.UI_Tab02_Cat03.Controls.Add(Me.UI_Tab02_Cat03_UnderOption02)
        Me.UI_Tab02_Cat03.Controls.Add(Me.UI_Tab02_Cat04)
        Me.UI_Tab02_Cat03.Controls.Add(Me.AboutButtonIcon)
        Me.UI_Tab02_Cat03.Controls.Add(Me.TaskmgrButtonIcon)
        Me.UI_Tab02_Cat03.Controls.Add(Me.BuiltInWinverButtonIcon)
        Me.UI_Tab02_Cat03.Controls.Add(Me.WinverButtonIcon)
        Me.UI_Tab02_Cat03.Controls.Add(Me.ReportCrashButtonIcon)
        Me.UI_Tab02_Cat03.Controls.Add(Me.SuggestUpdateButtonIcon)
        Me.UI_Tab02_Cat03.Controls.Add(Me.HelpButtonIcon)
        Me.UI_Tab02_Cat03.Controls.Add(Me.UI_Tab02_Cat03_UnderOption01)
        Me.UI_Tab02_Cat03.Controls.Add(Me.AppOption_BuiltInAboutWindows_Prewiew)
        Me.UI_Tab02_Cat03.Controls.Add(Me.AppOption_DisplayReportCrashButton)
        Me.UI_Tab02_Cat03.Controls.Add(Me.AppOption_DisplayAboutButton)
        Me.UI_Tab02_Cat03.Controls.Add(Me.AppOption_DisplayTaskmgrButton)
        Me.UI_Tab02_Cat03.Controls.Add(Me.AppOption_DisplayHelpButton)
        Me.UI_Tab02_Cat03.Controls.Add(Me.AppOption_DisplaySuggestUpdateButton)
        Me.UI_Tab02_Cat03.Controls.Add(Me.AppOption_BuiltInWinver)
        Me.UI_Tab02_Cat03.Controls.Add(Me.AppOption_DisplayWinverButton)
        Me.UI_Tab02_Cat03.Name = "UI_Tab02_Cat03"
        Me.UI_Tab02_Cat03.TabStop = False
        '
        'Shell32AboutIcon
        '
        Me.Shell32AboutIcon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.Via_GUI
        resources.ApplyResources(Me.Shell32AboutIcon, "Shell32AboutIcon")
        Me.Shell32AboutIcon.Name = "Shell32AboutIcon"
        Me.Shell32AboutIcon.TabStop = False
        '
        'AppOption_UseShell32About
        '
        resources.ApplyResources(Me.AppOption_UseShell32About, "AppOption_UseShell32About")
        Me.AppOption_UseShell32About.AutoEllipsis = True
        Me.AppOption_UseShell32About.Name = "AppOption_UseShell32About"
        Me.AppOption_UseShell32About.UseVisualStyleBackColor = True
        '
        'UI_Tab02_Cat03_UnderOption02
        '
        Me.UI_Tab02_Cat03_UnderOption02.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.CbxUnderOption
        resources.ApplyResources(Me.UI_Tab02_Cat03_UnderOption02, "UI_Tab02_Cat03_UnderOption02")
        Me.UI_Tab02_Cat03_UnderOption02.Name = "UI_Tab02_Cat03_UnderOption02"
        Me.UI_Tab02_Cat03_UnderOption02.TabStop = False
        '
        'UI_Tab02_Cat04
        '
        resources.ApplyResources(Me.UI_Tab02_Cat04, "UI_Tab02_Cat04")
        Me.UI_Tab02_Cat04.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab02_Cat04.Controls.Add(Me.BtmBarSeparatorsIcon)
        Me.UI_Tab02_Cat04.Controls.Add(Me.AppOption_BtmBarSeparators)
        Me.UI_Tab02_Cat04.Controls.Add(Me.HideBottomBtnsIcon)
        Me.UI_Tab02_Cat04.Controls.Add(Me.AppOption_HideBottomBtns)
        Me.UI_Tab02_Cat04.Name = "UI_Tab02_Cat04"
        Me.UI_Tab02_Cat04.TabStop = False
        '
        'BtmBarSeparatorsIcon
        '
        Me.BtmBarSeparatorsIcon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.BtmBar_Separators
        resources.ApplyResources(Me.BtmBarSeparatorsIcon, "BtmBarSeparatorsIcon")
        Me.BtmBarSeparatorsIcon.Name = "BtmBarSeparatorsIcon"
        Me.BtmBarSeparatorsIcon.TabStop = False
        '
        'AppOption_BtmBarSeparators
        '
        resources.ApplyResources(Me.AppOption_BtmBarSeparators, "AppOption_BtmBarSeparators")
        Me.AppOption_BtmBarSeparators.Name = "AppOption_BtmBarSeparators"
        Me.AppOption_BtmBarSeparators.UseVisualStyleBackColor = True
        '
        'HideBottomBtnsIcon
        '
        Me.HideBottomBtnsIcon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.list
        resources.ApplyResources(Me.HideBottomBtnsIcon, "HideBottomBtnsIcon")
        Me.HideBottomBtnsIcon.Name = "HideBottomBtnsIcon"
        Me.HideBottomBtnsIcon.TabStop = False
        '
        'AppOption_HideBottomBtns
        '
        resources.ApplyResources(Me.AppOption_HideBottomBtns, "AppOption_HideBottomBtns")
        Me.AppOption_HideBottomBtns.Name = "AppOption_HideBottomBtns"
        Me.AppOption_HideBottomBtns.UseVisualStyleBackColor = True
        '
        'AboutButtonIcon
        '
        resources.ApplyResources(Me.AboutButtonIcon, "AboutButtonIcon")
        Me.AboutButtonIcon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.Info
        Me.AboutButtonIcon.Name = "AboutButtonIcon"
        Me.AboutButtonIcon.TabStop = False
        '
        'TaskmgrButtonIcon
        '
        Me.TaskmgrButtonIcon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.Taskmgr_Icon_Win11
        resources.ApplyResources(Me.TaskmgrButtonIcon, "TaskmgrButtonIcon")
        Me.TaskmgrButtonIcon.Name = "TaskmgrButtonIcon"
        Me.TaskmgrButtonIcon.TabStop = False
        '
        'BuiltInWinverButtonIcon
        '
        Me.BuiltInWinverButtonIcon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.Built_in_Winver
        resources.ApplyResources(Me.BuiltInWinverButtonIcon, "BuiltInWinverButtonIcon")
        Me.BuiltInWinverButtonIcon.Name = "BuiltInWinverButtonIcon"
        Me.BuiltInWinverButtonIcon.TabStop = False
        '
        'WinverButtonIcon
        '
        Me.WinverButtonIcon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.Winver_Logo_Win7
        resources.ApplyResources(Me.WinverButtonIcon, "WinverButtonIcon")
        Me.WinverButtonIcon.Name = "WinverButtonIcon"
        Me.WinverButtonIcon.TabStop = False
        '
        'ReportCrashButtonIcon
        '
        Me.ReportCrashButtonIcon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.Bug
        resources.ApplyResources(Me.ReportCrashButtonIcon, "ReportCrashButtonIcon")
        Me.ReportCrashButtonIcon.Name = "ReportCrashButtonIcon"
        Me.ReportCrashButtonIcon.TabStop = False
        '
        'SuggestUpdateButtonIcon
        '
        Me.SuggestUpdateButtonIcon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.Update
        resources.ApplyResources(Me.SuggestUpdateButtonIcon, "SuggestUpdateButtonIcon")
        Me.SuggestUpdateButtonIcon.Name = "SuggestUpdateButtonIcon"
        Me.SuggestUpdateButtonIcon.TabStop = False
        '
        'HelpButtonIcon
        '
        Me.HelpButtonIcon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.Help
        resources.ApplyResources(Me.HelpButtonIcon, "HelpButtonIcon")
        Me.HelpButtonIcon.Name = "HelpButtonIcon"
        Me.HelpButtonIcon.TabStop = False
        '
        'UI_Tab02_Cat03_UnderOption01
        '
        Me.UI_Tab02_Cat03_UnderOption01.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.CbxUnderOptionUnavailable
        resources.ApplyResources(Me.UI_Tab02_Cat03_UnderOption01, "UI_Tab02_Cat03_UnderOption01")
        Me.UI_Tab02_Cat03_UnderOption01.Name = "UI_Tab02_Cat03_UnderOption01"
        Me.UI_Tab02_Cat03_UnderOption01.TabStop = False
        '
        'AppOption_BuiltInAboutWindows_Prewiew
        '
        resources.ApplyResources(Me.AppOption_BuiltInAboutWindows_Prewiew, "AppOption_BuiltInAboutWindows_Prewiew")
        Me.AppOption_BuiltInAboutWindows_Prewiew.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_BuiltInAboutWindows_Prewiew.Name = "AppOption_BuiltInAboutWindows_Prewiew"
        Me.AppOption_BuiltInAboutWindows_Prewiew.TabStop = True
        '
        'AppOption_DisplayReportCrashButton
        '
        resources.ApplyResources(Me.AppOption_DisplayReportCrashButton, "AppOption_DisplayReportCrashButton")
        Me.AppOption_DisplayReportCrashButton.AutoEllipsis = True
        Me.AppOption_DisplayReportCrashButton.Name = "AppOption_DisplayReportCrashButton"
        Me.AppOption_DisplayReportCrashButton.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayAboutButton
        '
        resources.ApplyResources(Me.AppOption_DisplayAboutButton, "AppOption_DisplayAboutButton")
        Me.AppOption_DisplayAboutButton.AutoEllipsis = True
        Me.AppOption_DisplayAboutButton.Checked = True
        Me.AppOption_DisplayAboutButton.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AppOption_DisplayAboutButton.Name = "AppOption_DisplayAboutButton"
        Me.AppOption_DisplayAboutButton.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayTaskmgrButton
        '
        resources.ApplyResources(Me.AppOption_DisplayTaskmgrButton, "AppOption_DisplayTaskmgrButton")
        Me.AppOption_DisplayTaskmgrButton.AutoEllipsis = True
        Me.AppOption_DisplayTaskmgrButton.Name = "AppOption_DisplayTaskmgrButton"
        Me.AppOption_DisplayTaskmgrButton.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayHelpButton
        '
        resources.ApplyResources(Me.AppOption_DisplayHelpButton, "AppOption_DisplayHelpButton")
        Me.AppOption_DisplayHelpButton.AutoEllipsis = True
        Me.AppOption_DisplayHelpButton.Name = "AppOption_DisplayHelpButton"
        Me.AppOption_DisplayHelpButton.UseVisualStyleBackColor = True
        '
        'AppOption_DisplaySuggestUpdateButton
        '
        resources.ApplyResources(Me.AppOption_DisplaySuggestUpdateButton, "AppOption_DisplaySuggestUpdateButton")
        Me.AppOption_DisplaySuggestUpdateButton.AutoEllipsis = True
        Me.AppOption_DisplaySuggestUpdateButton.Name = "AppOption_DisplaySuggestUpdateButton"
        Me.AppOption_DisplaySuggestUpdateButton.UseVisualStyleBackColor = True
        '
        'AppOption_BuiltInWinver
        '
        resources.ApplyResources(Me.AppOption_BuiltInWinver, "AppOption_BuiltInWinver")
        Me.AppOption_BuiltInWinver.AutoEllipsis = True
        Me.AppOption_BuiltInWinver.Name = "AppOption_BuiltInWinver"
        Me.AppOption_BuiltInWinver.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayWinverButton
        '
        resources.ApplyResources(Me.AppOption_DisplayWinverButton, "AppOption_DisplayWinverButton")
        Me.AppOption_DisplayWinverButton.AutoEllipsis = True
        Me.AppOption_DisplayWinverButton.Name = "AppOption_DisplayWinverButton"
        Me.AppOption_DisplayWinverButton.UseVisualStyleBackColor = True
        '
        'UI_Tab02_Cat02
        '
        resources.ApplyResources(Me.UI_Tab02_Cat02, "UI_Tab02_Cat02")
        Me.UI_Tab02_Cat02.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab02_Cat02.Controls.Add(Me.Text_006)
        Me.UI_Tab02_Cat02.Controls.Add(Me.Text_005)
        Me.UI_Tab02_Cat02.Controls.Add(Me.TaskmgrIcon_Preview)
        Me.UI_Tab02_Cat02.Controls.Add(Me.Taskmgr_CurrentOSIcon)
        Me.UI_Tab02_Cat02.Controls.Add(Me.AppOption_TaskmgrIconBasedOnCurrentOS)
        Me.UI_Tab02_Cat02.Controls.Add(Me.AppOption_TaskmgrIconLineColor)
        Me.UI_Tab02_Cat02.Controls.Add(Me.AppOption_TaskmgrIconBackColor)
        Me.UI_Tab02_Cat02.Name = "UI_Tab02_Cat02"
        Me.UI_Tab02_Cat02.TabStop = False
        '
        'Text_006
        '
        resources.ApplyResources(Me.Text_006, "Text_006")
        Me.Text_006.Name = "Text_006"
        '
        'Text_005
        '
        resources.ApplyResources(Me.Text_005, "Text_005")
        Me.Text_005.Name = "Text_005"
        '
        'TaskmgrIcon_Preview
        '
        Me.TaskmgrIcon_Preview.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.SysIconModify64
        resources.ApplyResources(Me.TaskmgrIcon_Preview, "TaskmgrIcon_Preview")
        Me.TaskmgrIcon_Preview.Name = "TaskmgrIcon_Preview"
        Me.TaskmgrIcon_Preview.TabStop = False
        '
        'Taskmgr_CurrentOSIcon
        '
        Me.Taskmgr_CurrentOSIcon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.SysIconModify
        resources.ApplyResources(Me.Taskmgr_CurrentOSIcon, "Taskmgr_CurrentOSIcon")
        Me.Taskmgr_CurrentOSIcon.Name = "Taskmgr_CurrentOSIcon"
        Me.Taskmgr_CurrentOSIcon.TabStop = False
        '
        'AppOption_TaskmgrIconBasedOnCurrentOS
        '
        resources.ApplyResources(Me.AppOption_TaskmgrIconBasedOnCurrentOS, "AppOption_TaskmgrIconBasedOnCurrentOS")
        Me.AppOption_TaskmgrIconBasedOnCurrentOS.AutoEllipsis = True
        Me.AppOption_TaskmgrIconBasedOnCurrentOS.Name = "AppOption_TaskmgrIconBasedOnCurrentOS"
        Me.AppOption_TaskmgrIconBasedOnCurrentOS.UseVisualStyleBackColor = True
        '
        'AppOption_TaskmgrIconLineColor
        '
        Me.AppOption_TaskmgrIconLineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_TaskmgrIconLineColor.FormattingEnabled = True
        Me.AppOption_TaskmgrIconLineColor.Items.AddRange(New Object() {resources.GetString("AppOption_TaskmgrIconLineColor.Items"), resources.GetString("AppOption_TaskmgrIconLineColor.Items1"), resources.GetString("AppOption_TaskmgrIconLineColor.Items2"), resources.GetString("AppOption_TaskmgrIconLineColor.Items3"), resources.GetString("AppOption_TaskmgrIconLineColor.Items4"), resources.GetString("AppOption_TaskmgrIconLineColor.Items5"), resources.GetString("AppOption_TaskmgrIconLineColor.Items6"), resources.GetString("AppOption_TaskmgrIconLineColor.Items7"), resources.GetString("AppOption_TaskmgrIconLineColor.Items8"), resources.GetString("AppOption_TaskmgrIconLineColor.Items9")})
        resources.ApplyResources(Me.AppOption_TaskmgrIconLineColor, "AppOption_TaskmgrIconLineColor")
        Me.AppOption_TaskmgrIconLineColor.Name = "AppOption_TaskmgrIconLineColor"
        '
        'AppOption_TaskmgrIconBackColor
        '
        Me.AppOption_TaskmgrIconBackColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_TaskmgrIconBackColor.FormattingEnabled = True
        Me.AppOption_TaskmgrIconBackColor.Items.AddRange(New Object() {resources.GetString("AppOption_TaskmgrIconBackColor.Items"), resources.GetString("AppOption_TaskmgrIconBackColor.Items1")})
        resources.ApplyResources(Me.AppOption_TaskmgrIconBackColor, "AppOption_TaskmgrIconBackColor")
        Me.AppOption_TaskmgrIconBackColor.Name = "AppOption_TaskmgrIconBackColor"
        '
        'UI_Tab02_Cat01
        '
        resources.ApplyResources(Me.UI_Tab02_Cat01, "UI_Tab02_Cat01")
        Me.UI_Tab02_Cat01.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab02_Cat01.Controls.Add(Me.WinverIcon_Preview)
        Me.UI_Tab02_Cat01.Controls.Add(Me.Winver_CurrentOSIcon)
        Me.UI_Tab02_Cat01.Controls.Add(Me.AppOption_WinverIconBasedOnCurrentOS)
        Me.UI_Tab02_Cat01.Controls.Add(Me.Text_004)
        Me.UI_Tab02_Cat01.Controls.Add(Me.AppOption_WinverIcon)
        Me.UI_Tab02_Cat01.Name = "UI_Tab02_Cat01"
        Me.UI_Tab02_Cat01.TabStop = False
        '
        'WinverIcon_Preview
        '
        Me.WinverIcon_Preview.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.SysIconModify64
        resources.ApplyResources(Me.WinverIcon_Preview, "WinverIcon_Preview")
        Me.WinverIcon_Preview.Name = "WinverIcon_Preview"
        Me.WinverIcon_Preview.TabStop = False
        '
        'Winver_CurrentOSIcon
        '
        Me.Winver_CurrentOSIcon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.SysIconModify
        resources.ApplyResources(Me.Winver_CurrentOSIcon, "Winver_CurrentOSIcon")
        Me.Winver_CurrentOSIcon.Name = "Winver_CurrentOSIcon"
        Me.Winver_CurrentOSIcon.TabStop = False
        '
        'AppOption_WinverIconBasedOnCurrentOS
        '
        resources.ApplyResources(Me.AppOption_WinverIconBasedOnCurrentOS, "AppOption_WinverIconBasedOnCurrentOS")
        Me.AppOption_WinverIconBasedOnCurrentOS.Name = "AppOption_WinverIconBasedOnCurrentOS"
        Me.AppOption_WinverIconBasedOnCurrentOS.UseVisualStyleBackColor = True
        '
        'Text_004
        '
        resources.ApplyResources(Me.Text_004, "Text_004")
        Me.Text_004.Name = "Text_004"
        '
        'AppOption_WinverIcon
        '
        Me.AppOption_WinverIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_WinverIcon.FormattingEnabled = True
        Me.AppOption_WinverIcon.Items.AddRange(New Object() {resources.GetString("AppOption_WinverIcon.Items"), resources.GetString("AppOption_WinverIcon.Items1"), resources.GetString("AppOption_WinverIcon.Items2"), resources.GetString("AppOption_WinverIcon.Items3"), resources.GetString("AppOption_WinverIcon.Items4"), resources.GetString("AppOption_WinverIcon.Items5"), resources.GetString("AppOption_WinverIcon.Items6"), resources.GetString("AppOption_WinverIcon.Items7"), resources.GetString("AppOption_WinverIcon.Items8"), resources.GetString("AppOption_WinverIcon.Items9"), resources.GetString("AppOption_WinverIcon.Items10"), resources.GetString("AppOption_WinverIcon.Items11"), resources.GetString("AppOption_WinverIcon.Items12"), resources.GetString("AppOption_WinverIcon.Items13"), resources.GetString("AppOption_WinverIcon.Items14"), resources.GetString("AppOption_WinverIcon.Items15"), resources.GetString("AppOption_WinverIcon.Items16"), resources.GetString("AppOption_WinverIcon.Items17"), resources.GetString("AppOption_WinverIcon.Items18"), resources.GetString("AppOption_WinverIcon.Items19"), resources.GetString("AppOption_WinverIcon.Items20"), resources.GetString("AppOption_WinverIcon.Items21")})
        resources.ApplyResources(Me.AppOption_WinverIcon, "AppOption_WinverIcon")
        Me.AppOption_WinverIcon.Name = "AppOption_WinverIcon"
        '
        'UI_SettingsTab03
        '
        Me.UI_SettingsTab03.Controls.Add(Me.UI_Tab03_Cat03)
        Me.UI_SettingsTab03.Controls.Add(Me.UI_Tab03_Cat04)
        Me.UI_SettingsTab03.Controls.Add(Me.UI_Tab03_Cat01)
        Me.UI_SettingsTab03.Controls.Add(Me.UI_Tab03_Cat02)
        Me.UI_SettingsTab03.Controls.Add(Me.UI_Tab03_Title01)
        resources.ApplyResources(Me.UI_SettingsTab03, "UI_SettingsTab03")
        Me.UI_SettingsTab03.Name = "UI_SettingsTab03"
        Me.UI_SettingsTab03.UseVisualStyleBackColor = True
        '
        'UI_Tab03_Cat03
        '
        resources.ApplyResources(Me.UI_Tab03_Cat03, "UI_Tab03_Cat03")
        Me.UI_Tab03_Cat03.Controls.Add(Me.AppOption_ShowSystrayIcon)
        Me.UI_Tab03_Cat03.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UI_Tab03_Cat03.Name = "UI_Tab03_Cat03"
        Me.UI_Tab03_Cat03.TabStop = False
        '
        'AppOption_ShowSystrayIcon
        '
        resources.ApplyResources(Me.AppOption_ShowSystrayIcon, "AppOption_ShowSystrayIcon")
        Me.AppOption_ShowSystrayIcon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AppOption_ShowSystrayIcon.Name = "AppOption_ShowSystrayIcon"
        Me.AppOption_ShowSystrayIcon.UseVisualStyleBackColor = True
        '
        'UI_Tab03_Cat04
        '
        resources.ApplyResources(Me.UI_Tab03_Cat04, "UI_Tab03_Cat04")
        Me.UI_Tab03_Cat04.Controls.Add(Me.AppOption_OpenAboutDialogKeyboardShortcut)
        Me.UI_Tab03_Cat04.Controls.Add(Me.AppOption_OpenSuggestUpdateKeyboardShortcut)
        Me.UI_Tab03_Cat04.Controls.Add(Me.AppOption_OpenHelpKeyboardShortcut)
        Me.UI_Tab03_Cat04.Controls.Add(Me.AppOption_CustomShortcutsKeyboardShortcut)
        Me.UI_Tab03_Cat04.Controls.Add(Me.AppOption_OpenSettingsKeyboardShortcut)
        Me.UI_Tab03_Cat04.Controls.Add(Me.AppOption_QuickRestartKeyboardShortcut)
        Me.UI_Tab03_Cat04.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UI_Tab03_Cat04.Name = "UI_Tab03_Cat04"
        Me.UI_Tab03_Cat04.TabStop = False
        '
        'AppOption_OpenAboutDialogKeyboardShortcut
        '
        resources.ApplyResources(Me.AppOption_OpenAboutDialogKeyboardShortcut, "AppOption_OpenAboutDialogKeyboardShortcut")
        Me.AppOption_OpenAboutDialogKeyboardShortcut.Name = "AppOption_OpenAboutDialogKeyboardShortcut"
        Me.AppOption_OpenAboutDialogKeyboardShortcut.UseVisualStyleBackColor = False
        '
        'AppOption_OpenSuggestUpdateKeyboardShortcut
        '
        resources.ApplyResources(Me.AppOption_OpenSuggestUpdateKeyboardShortcut, "AppOption_OpenSuggestUpdateKeyboardShortcut")
        Me.AppOption_OpenSuggestUpdateKeyboardShortcut.Name = "AppOption_OpenSuggestUpdateKeyboardShortcut"
        Me.AppOption_OpenSuggestUpdateKeyboardShortcut.UseVisualStyleBackColor = True
        '
        'AppOption_OpenHelpKeyboardShortcut
        '
        resources.ApplyResources(Me.AppOption_OpenHelpKeyboardShortcut, "AppOption_OpenHelpKeyboardShortcut")
        Me.AppOption_OpenHelpKeyboardShortcut.Name = "AppOption_OpenHelpKeyboardShortcut"
        Me.AppOption_OpenHelpKeyboardShortcut.UseVisualStyleBackColor = True
        '
        'AppOption_CustomShortcutsKeyboardShortcut
        '
        resources.ApplyResources(Me.AppOption_CustomShortcutsKeyboardShortcut, "AppOption_CustomShortcutsKeyboardShortcut")
        Me.AppOption_CustomShortcutsKeyboardShortcut.Name = "AppOption_CustomShortcutsKeyboardShortcut"
        Me.AppOption_CustomShortcutsKeyboardShortcut.UseVisualStyleBackColor = True
        '
        'AppOption_OpenSettingsKeyboardShortcut
        '
        resources.ApplyResources(Me.AppOption_OpenSettingsKeyboardShortcut, "AppOption_OpenSettingsKeyboardShortcut")
        Me.AppOption_OpenSettingsKeyboardShortcut.Name = "AppOption_OpenSettingsKeyboardShortcut"
        Me.AppOption_OpenSettingsKeyboardShortcut.UseVisualStyleBackColor = True
        '
        'AppOption_QuickRestartKeyboardShortcut
        '
        resources.ApplyResources(Me.AppOption_QuickRestartKeyboardShortcut, "AppOption_QuickRestartKeyboardShortcut")
        Me.AppOption_QuickRestartKeyboardShortcut.Name = "AppOption_QuickRestartKeyboardShortcut"
        Me.AppOption_QuickRestartKeyboardShortcut.UseVisualStyleBackColor = True
        '
        'UI_Tab03_Cat01
        '
        resources.ApplyResources(Me.UI_Tab03_Cat01, "UI_Tab03_Cat01")
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_UncheckAll)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayCompleteVersionOnMainWindow)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_CheckAll)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_SpriteGFX)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_MultipleMidwayPoints)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_InteractionEdit)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_MarioStartEditor)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_Snes9x)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_Asar)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_PetiteMM)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_Btn35)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_GradientTool)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_UberASM)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_SHTools)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_SMWCust)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_YYCHR)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_GraphEdit)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_GopherPopcornStew)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_Btn34)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_EffectTools)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_SPCTool)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_StatusEffects)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_Flips)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_SPC700Player)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_Mode7Tilemap)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_Pixi)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_Blockreator)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_BRRPlayer)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_LvMusUtil)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_AddMusicK)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_MMLEdit)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_HDMARipper)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_HeAdder)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_MarioLPE)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_SnesGFX)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_RecoverLM)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_LunarExpand)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_DisplayBtn_LunarMagic)
        Me.UI_Tab03_Cat01.Controls.Add(Me.Text_008)
        Me.UI_Tab03_Cat01.Controls.Add(Me.AppOption_ColumnsNumberComboBox)
        Me.UI_Tab03_Cat01.Controls.Add(Me.Text_007)
        Me.UI_Tab03_Cat01.Name = "UI_Tab03_Cat01"
        Me.UI_Tab03_Cat01.TabStop = False
        '
        'AppOption_DisplayBtn_UncheckAll
        '
        Me.AppOption_DisplayBtn_UncheckAll.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.Settings_CbxUncheckAll
        resources.ApplyResources(Me.AppOption_DisplayBtn_UncheckAll, "AppOption_DisplayBtn_UncheckAll")
        Me.AppOption_DisplayBtn_UncheckAll.Name = "AppOption_DisplayBtn_UncheckAll"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_UncheckAll, resources.GetString("AppOption_DisplayBtn_UncheckAll.ToolTip"))
        Me.AppOption_DisplayBtn_UncheckAll.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayCompleteVersionOnMainWindow
        '
        resources.ApplyResources(Me.AppOption_DisplayCompleteVersionOnMainWindow, "AppOption_DisplayCompleteVersionOnMainWindow")
        Me.AppOption_DisplayCompleteVersionOnMainWindow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AppOption_DisplayCompleteVersionOnMainWindow.Name = "AppOption_DisplayCompleteVersionOnMainWindow"
        Me.AppOption_DisplayCompleteVersionOnMainWindow.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_CheckAll
        '
        Me.AppOption_DisplayBtn_CheckAll.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.Settings_CbxCheckAll
        resources.ApplyResources(Me.AppOption_DisplayBtn_CheckAll, "AppOption_DisplayBtn_CheckAll")
        Me.AppOption_DisplayBtn_CheckAll.Name = "AppOption_DisplayBtn_CheckAll"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_CheckAll, resources.GetString("AppOption_DisplayBtn_CheckAll.ToolTip"))
        Me.AppOption_DisplayBtn_CheckAll.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_SpriteGFX
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_SpriteGFX, "AppOption_DisplayBtn_SpriteGFX")
        Me.AppOption_DisplayBtn_SpriteGFX.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_SpriteGFX
        Me.AppOption_DisplayBtn_SpriteGFX.Name = "AppOption_DisplayBtn_SpriteGFX"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_SpriteGFX, resources.GetString("AppOption_DisplayBtn_SpriteGFX.ToolTip"))
        Me.AppOption_DisplayBtn_SpriteGFX.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_MultipleMidwayPoints
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_MultipleMidwayPoints, "AppOption_DisplayBtn_MultipleMidwayPoints")
        Me.AppOption_DisplayBtn_MultipleMidwayPoints.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_MMP
        Me.AppOption_DisplayBtn_MultipleMidwayPoints.Name = "AppOption_DisplayBtn_MultipleMidwayPoints"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_MultipleMidwayPoints, resources.GetString("AppOption_DisplayBtn_MultipleMidwayPoints.ToolTip"))
        Me.AppOption_DisplayBtn_MultipleMidwayPoints.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_InteractionEdit
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_InteractionEdit, "AppOption_DisplayBtn_InteractionEdit")
        Me.AppOption_DisplayBtn_InteractionEdit.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_InteractionEdit
        Me.AppOption_DisplayBtn_InteractionEdit.Name = "AppOption_DisplayBtn_InteractionEdit"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_InteractionEdit, resources.GetString("AppOption_DisplayBtn_InteractionEdit.ToolTip"))
        Me.AppOption_DisplayBtn_InteractionEdit.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_MarioStartEditor
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_MarioStartEditor, "AppOption_DisplayBtn_MarioStartEditor")
        Me.AppOption_DisplayBtn_MarioStartEditor.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_MarioSEditor
        Me.AppOption_DisplayBtn_MarioStartEditor.Name = "AppOption_DisplayBtn_MarioStartEditor"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_MarioStartEditor, resources.GetString("AppOption_DisplayBtn_MarioStartEditor.ToolTip"))
        Me.AppOption_DisplayBtn_MarioStartEditor.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_Snes9x
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_Snes9x, "AppOption_DisplayBtn_Snes9x")
        Me.AppOption_DisplayBtn_Snes9x.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Snes9x
        Me.AppOption_DisplayBtn_Snes9x.Name = "AppOption_DisplayBtn_Snes9x"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_Snes9x, resources.GetString("AppOption_DisplayBtn_Snes9x.ToolTip"))
        Me.AppOption_DisplayBtn_Snes9x.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_Asar
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_Asar, "AppOption_DisplayBtn_Asar")
        Me.AppOption_DisplayBtn_Asar.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Asar
        Me.AppOption_DisplayBtn_Asar.Name = "AppOption_DisplayBtn_Asar"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_Asar, resources.GetString("AppOption_DisplayBtn_Asar.ToolTip"))
        Me.AppOption_DisplayBtn_Asar.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_PetiteMM
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_PetiteMM, "AppOption_DisplayBtn_PetiteMM")
        Me.AppOption_DisplayBtn_PetiteMM.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_PetiteMM
        Me.AppOption_DisplayBtn_PetiteMM.Name = "AppOption_DisplayBtn_PetiteMM"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_PetiteMM, resources.GetString("AppOption_DisplayBtn_PetiteMM.ToolTip"))
        Me.AppOption_DisplayBtn_PetiteMM.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_Btn35
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_Btn35, "AppOption_DisplayBtn_Btn35")
        Me.AppOption_DisplayBtn_Btn35.Name = "AppOption_DisplayBtn_Btn35"
        Me.AppOption_DisplayBtn_Btn35.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_GradientTool
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_GradientTool, "AppOption_DisplayBtn_GradientTool")
        Me.AppOption_DisplayBtn_GradientTool.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_GradientTool
        Me.AppOption_DisplayBtn_GradientTool.Name = "AppOption_DisplayBtn_GradientTool"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_GradientTool, resources.GetString("AppOption_DisplayBtn_GradientTool.ToolTip"))
        Me.AppOption_DisplayBtn_GradientTool.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_UberASM
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_UberASM, "AppOption_DisplayBtn_UberASM")
        Me.AppOption_DisplayBtn_UberASM.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_UberASM
        Me.AppOption_DisplayBtn_UberASM.Name = "AppOption_DisplayBtn_UberASM"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_UberASM, resources.GetString("AppOption_DisplayBtn_UberASM.ToolTip"))
        Me.AppOption_DisplayBtn_UberASM.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_SHTools
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_SHTools, "AppOption_DisplayBtn_SHTools")
        Me.AppOption_DisplayBtn_SHTools.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Smallhacker
        Me.AppOption_DisplayBtn_SHTools.Name = "AppOption_DisplayBtn_SHTools"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_SHTools, resources.GetString("AppOption_DisplayBtn_SHTools.ToolTip"))
        Me.AppOption_DisplayBtn_SHTools.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_SMWCust
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_SMWCust, "AppOption_DisplayBtn_SMWCust")
        Me.AppOption_DisplayBtn_SMWCust.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_SMWCust
        Me.AppOption_DisplayBtn_SMWCust.Name = "AppOption_DisplayBtn_SMWCust"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_SMWCust, resources.GetString("AppOption_DisplayBtn_SMWCust.ToolTip"))
        Me.AppOption_DisplayBtn_SMWCust.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_YYCHR
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_YYCHR, "AppOption_DisplayBtn_YYCHR")
        Me.AppOption_DisplayBtn_YYCHR.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_YYCHR
        Me.AppOption_DisplayBtn_YYCHR.Name = "AppOption_DisplayBtn_YYCHR"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_YYCHR, resources.GetString("AppOption_DisplayBtn_YYCHR.ToolTip"))
        Me.AppOption_DisplayBtn_YYCHR.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_GraphEdit
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_GraphEdit, "AppOption_DisplayBtn_GraphEdit")
        Me.AppOption_DisplayBtn_GraphEdit.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_GraphEdit
        Me.AppOption_DisplayBtn_GraphEdit.Name = "AppOption_DisplayBtn_GraphEdit"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_GraphEdit, resources.GetString("AppOption_DisplayBtn_GraphEdit.ToolTip"))
        Me.AppOption_DisplayBtn_GraphEdit.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_GopherPopcornStew
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_GopherPopcornStew, "AppOption_DisplayBtn_GopherPopcornStew")
        Me.AppOption_DisplayBtn_GopherPopcornStew.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_GPS
        Me.AppOption_DisplayBtn_GopherPopcornStew.Name = "AppOption_DisplayBtn_GopherPopcornStew"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_GopherPopcornStew, resources.GetString("AppOption_DisplayBtn_GopherPopcornStew.ToolTip"))
        Me.AppOption_DisplayBtn_GopherPopcornStew.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_Btn34
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_Btn34, "AppOption_DisplayBtn_Btn34")
        Me.AppOption_DisplayBtn_Btn34.Name = "AppOption_DisplayBtn_Btn34"
        Me.AppOption_DisplayBtn_Btn34.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_EffectTools
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_EffectTools, "AppOption_DisplayBtn_EffectTools")
        Me.AppOption_DisplayBtn_EffectTools.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Effecttool
        Me.AppOption_DisplayBtn_EffectTools.Name = "AppOption_DisplayBtn_EffectTools"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_EffectTools, resources.GetString("AppOption_DisplayBtn_EffectTools.ToolTip"))
        Me.AppOption_DisplayBtn_EffectTools.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_SPCTool
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_SPCTool, "AppOption_DisplayBtn_SPCTool")
        Me.AppOption_DisplayBtn_SPCTool.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_SnesColorTool
        Me.AppOption_DisplayBtn_SPCTool.Name = "AppOption_DisplayBtn_SPCTool"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_SPCTool, resources.GetString("AppOption_DisplayBtn_SPCTool.ToolTip"))
        Me.AppOption_DisplayBtn_SPCTool.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_StatusEffects
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_StatusEffects, "AppOption_DisplayBtn_StatusEffects")
        Me.AppOption_DisplayBtn_StatusEffects.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_StatusEffects
        Me.AppOption_DisplayBtn_StatusEffects.Name = "AppOption_DisplayBtn_StatusEffects"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_StatusEffects, resources.GetString("AppOption_DisplayBtn_StatusEffects.ToolTip"))
        Me.AppOption_DisplayBtn_StatusEffects.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_Flips
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_Flips, "AppOption_DisplayBtn_Flips")
        Me.AppOption_DisplayBtn_Flips.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Flips
        Me.AppOption_DisplayBtn_Flips.Name = "AppOption_DisplayBtn_Flips"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_Flips, resources.GetString("AppOption_DisplayBtn_Flips.ToolTip"))
        Me.AppOption_DisplayBtn_Flips.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_SPC700Player
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_SPC700Player, "AppOption_DisplayBtn_SPC700Player")
        Me.AppOption_DisplayBtn_SPC700Player.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_SPC700
        Me.AppOption_DisplayBtn_SPC700Player.Name = "AppOption_DisplayBtn_SPC700Player"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_SPC700Player, resources.GetString("AppOption_DisplayBtn_SPC700Player.ToolTip"))
        Me.AppOption_DisplayBtn_SPC700Player.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_Mode7Tilemap
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_Mode7Tilemap, "AppOption_DisplayBtn_Mode7Tilemap")
        Me.AppOption_DisplayBtn_Mode7Tilemap.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Mode7T
        Me.AppOption_DisplayBtn_Mode7Tilemap.Name = "AppOption_DisplayBtn_Mode7Tilemap"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_Mode7Tilemap, resources.GetString("AppOption_DisplayBtn_Mode7Tilemap.ToolTip"))
        Me.AppOption_DisplayBtn_Mode7Tilemap.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_Pixi
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_Pixi, "AppOption_DisplayBtn_Pixi")
        Me.AppOption_DisplayBtn_Pixi.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Pixi
        Me.AppOption_DisplayBtn_Pixi.Name = "AppOption_DisplayBtn_Pixi"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_Pixi, resources.GetString("AppOption_DisplayBtn_Pixi.ToolTip"))
        Me.AppOption_DisplayBtn_Pixi.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_Blockreator
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_Blockreator, "AppOption_DisplayBtn_Blockreator")
        Me.AppOption_DisplayBtn_Blockreator.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Blockreator
        Me.AppOption_DisplayBtn_Blockreator.Name = "AppOption_DisplayBtn_Blockreator"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_Blockreator, resources.GetString("AppOption_DisplayBtn_Blockreator.ToolTip"))
        Me.AppOption_DisplayBtn_Blockreator.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_BRRPlayer
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_BRRPlayer, "AppOption_DisplayBtn_BRRPlayer")
        Me.AppOption_DisplayBtn_BRRPlayer.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_BRRPlayer
        Me.AppOption_DisplayBtn_BRRPlayer.Name = "AppOption_DisplayBtn_BRRPlayer"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_BRRPlayer, resources.GetString("AppOption_DisplayBtn_BRRPlayer.ToolTip"))
        Me.AppOption_DisplayBtn_BRRPlayer.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_LvMusUtil
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_LvMusUtil, "AppOption_DisplayBtn_LvMusUtil")
        Me.AppOption_DisplayBtn_LvMusUtil.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_LvMusUtility
        Me.AppOption_DisplayBtn_LvMusUtil.Name = "AppOption_DisplayBtn_LvMusUtil"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_LvMusUtil, resources.GetString("AppOption_DisplayBtn_LvMusUtil.ToolTip"))
        Me.AppOption_DisplayBtn_LvMusUtil.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_AddMusicK
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_AddMusicK, "AppOption_DisplayBtn_AddMusicK")
        Me.AppOption_DisplayBtn_AddMusicK.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_AddMusicK
        Me.AppOption_DisplayBtn_AddMusicK.Name = "AppOption_DisplayBtn_AddMusicK"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_AddMusicK, resources.GetString("AppOption_DisplayBtn_AddMusicK.ToolTip"))
        Me.AppOption_DisplayBtn_AddMusicK.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_MMLEdit
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_MMLEdit, "AppOption_DisplayBtn_MMLEdit")
        Me.AppOption_DisplayBtn_MMLEdit.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_MML_Edit
        Me.AppOption_DisplayBtn_MMLEdit.Name = "AppOption_DisplayBtn_MMLEdit"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_MMLEdit, resources.GetString("AppOption_DisplayBtn_MMLEdit.ToolTip"))
        Me.AppOption_DisplayBtn_MMLEdit.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_HDMARipper
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_HDMARipper, "AppOption_DisplayBtn_HDMARipper")
        Me.AppOption_DisplayBtn_HDMARipper.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_HDMARipper
        Me.AppOption_DisplayBtn_HDMARipper.Name = "AppOption_DisplayBtn_HDMARipper"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_HDMARipper, resources.GetString("AppOption_DisplayBtn_HDMARipper.ToolTip"))
        Me.AppOption_DisplayBtn_HDMARipper.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_HeAdder
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_HeAdder, "AppOption_DisplayBtn_HeAdder")
        Me.AppOption_DisplayBtn_HeAdder.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_HeAdder
        Me.AppOption_DisplayBtn_HeAdder.Name = "AppOption_DisplayBtn_HeAdder"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_HeAdder, resources.GetString("AppOption_DisplayBtn_HeAdder.ToolTip"))
        Me.AppOption_DisplayBtn_HeAdder.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_MarioLPE
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_MarioLPE, "AppOption_DisplayBtn_MarioLPE")
        Me.AppOption_DisplayBtn_MarioLPE.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_MarioLPE
        Me.AppOption_DisplayBtn_MarioLPE.Name = "AppOption_DisplayBtn_MarioLPE"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_MarioLPE, resources.GetString("AppOption_DisplayBtn_MarioLPE.ToolTip"))
        Me.AppOption_DisplayBtn_MarioLPE.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_SnesGFX
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_SnesGFX, "AppOption_DisplayBtn_SnesGFX")
        Me.AppOption_DisplayBtn_SnesGFX.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_SnesGFX
        Me.AppOption_DisplayBtn_SnesGFX.Name = "AppOption_DisplayBtn_SnesGFX"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_SnesGFX, resources.GetString("AppOption_DisplayBtn_SnesGFX.ToolTip"))
        Me.AppOption_DisplayBtn_SnesGFX.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_RecoverLM
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_RecoverLM, "AppOption_DisplayBtn_RecoverLM")
        Me.AppOption_DisplayBtn_RecoverLM.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_RLM
        Me.AppOption_DisplayBtn_RecoverLM.Name = "AppOption_DisplayBtn_RecoverLM"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_RecoverLM, resources.GetString("AppOption_DisplayBtn_RecoverLM.ToolTip"))
        Me.AppOption_DisplayBtn_RecoverLM.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_LunarExpand
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_LunarExpand, "AppOption_DisplayBtn_LunarExpand")
        Me.AppOption_DisplayBtn_LunarExpand.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_LE
        Me.AppOption_DisplayBtn_LunarExpand.Name = "AppOption_DisplayBtn_LunarExpand"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_LunarExpand, resources.GetString("AppOption_DisplayBtn_LunarExpand.ToolTip"))
        Me.AppOption_DisplayBtn_LunarExpand.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_LunarMagic
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_LunarMagic, "AppOption_DisplayBtn_LunarMagic")
        Me.AppOption_DisplayBtn_LunarMagic.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.LM_NORMAL
        Me.AppOption_DisplayBtn_LunarMagic.Name = "AppOption_DisplayBtn_LunarMagic"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_LunarMagic, resources.GetString("AppOption_DisplayBtn_LunarMagic.ToolTip"))
        Me.AppOption_DisplayBtn_LunarMagic.UseVisualStyleBackColor = True
        '
        'Text_008
        '
        resources.ApplyResources(Me.Text_008, "Text_008")
        Me.Text_008.Name = "Text_008"
        '
        'AppOption_ColumnsNumberComboBox
        '
        resources.ApplyResources(Me.AppOption_ColumnsNumberComboBox, "AppOption_ColumnsNumberComboBox")
        Me.AppOption_ColumnsNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_ColumnsNumberComboBox.FormattingEnabled = True
        Me.AppOption_ColumnsNumberComboBox.Items.AddRange(New Object() {resources.GetString("AppOption_ColumnsNumberComboBox.Items"), resources.GetString("AppOption_ColumnsNumberComboBox.Items1"), resources.GetString("AppOption_ColumnsNumberComboBox.Items2"), resources.GetString("AppOption_ColumnsNumberComboBox.Items3"), resources.GetString("AppOption_ColumnsNumberComboBox.Items4")})
        Me.AppOption_ColumnsNumberComboBox.Name = "AppOption_ColumnsNumberComboBox"
        '
        'Text_007
        '
        resources.ApplyResources(Me.Text_007, "Text_007")
        Me.Text_007.Name = "Text_007"
        '
        'UI_Tab03_Cat02
        '
        resources.ApplyResources(Me.UI_Tab03_Cat02, "UI_Tab03_Cat02")
        Me.UI_Tab03_Cat02.Controls.Add(Me.AppOption_EnableLegacyAboutBox)
        Me.UI_Tab03_Cat02.Controls.Add(Me.AppOption_HideVersionStringInAboutBox)
        Me.UI_Tab03_Cat02.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UI_Tab03_Cat02.Name = "UI_Tab03_Cat02"
        Me.UI_Tab03_Cat02.TabStop = False
        '
        'AppOption_EnableLegacyAboutBox
        '
        resources.ApplyResources(Me.AppOption_EnableLegacyAboutBox, "AppOption_EnableLegacyAboutBox")
        Me.AppOption_EnableLegacyAboutBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AppOption_EnableLegacyAboutBox.Name = "AppOption_EnableLegacyAboutBox"
        Me.AppOption_EnableLegacyAboutBox.UseVisualStyleBackColor = True
        '
        'AppOption_HideVersionStringInAboutBox
        '
        resources.ApplyResources(Me.AppOption_HideVersionStringInAboutBox, "AppOption_HideVersionStringInAboutBox")
        Me.AppOption_HideVersionStringInAboutBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AppOption_HideVersionStringInAboutBox.Name = "AppOption_HideVersionStringInAboutBox"
        Me.AppOption_HideVersionStringInAboutBox.UseVisualStyleBackColor = True
        '
        'UI_Tab03_Title01
        '
        resources.ApplyResources(Me.UI_Tab03_Title01, "UI_Tab03_Title01")
        Me.UI_Tab03_Title01.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UI_Tab03_Title01.Name = "UI_Tab03_Title01"
        '
        'UI_SettingsTab04
        '
        Me.UI_SettingsTab04.Controls.Add(Me.UI_Tab04_Cat05)
        Me.UI_SettingsTab04.Controls.Add(Me.UI_Tab04_Cat07)
        Me.UI_SettingsTab04.Controls.Add(Me.UI_Tab04_Cat04)
        Me.UI_SettingsTab04.Controls.Add(Me.UI_Tab04_Cat06)
        Me.UI_SettingsTab04.Controls.Add(Me.UI_Tab04_Cat03)
        Me.UI_SettingsTab04.Controls.Add(Me.UI_Tab04_Cat02)
        Me.UI_SettingsTab04.Controls.Add(Me.UI_Tab04_Cat01)
        Me.UI_SettingsTab04.Controls.Add(Me.UI_Tab04_Title01)
        resources.ApplyResources(Me.UI_SettingsTab04, "UI_SettingsTab04")
        Me.UI_SettingsTab04.Name = "UI_SettingsTab04"
        Me.UI_SettingsTab04.UseVisualStyleBackColor = True
        '
        'UI_Tab04_Cat05
        '
        resources.ApplyResources(Me.UI_Tab04_Cat05, "UI_Tab04_Cat05")
        Me.UI_Tab04_Cat05.Controls.Add(Me.AppOption_Shortcut4_Path)
        Me.UI_Tab04_Cat05.Controls.Add(Me.AppOption_EnableCustomShortcut_4)
        Me.UI_Tab04_Cat05.Controls.Add(Me.AppOption_Shortcut4_SelectFile)
        Me.UI_Tab04_Cat05.Controls.Add(Me.Text_018)
        Me.UI_Tab04_Cat05.Controls.Add(Me.AppOption_Shortcut4_Icon)
        Me.UI_Tab04_Cat05.Controls.Add(Me.Text_019)
        Me.UI_Tab04_Cat05.Controls.Add(Me.Text_020)
        Me.UI_Tab04_Cat05.Controls.Add(Me.AppOption_Shortcut4_LaunchWith)
        Me.UI_Tab04_Cat05.Name = "UI_Tab04_Cat05"
        Me.UI_Tab04_Cat05.TabStop = False
        '
        'AppOption_Shortcut4_Path
        '
        resources.ApplyResources(Me.AppOption_Shortcut4_Path, "AppOption_Shortcut4_Path")
        Me.AppOption_Shortcut4_Path.Name = "AppOption_Shortcut4_Path"
        '
        'AppOption_EnableCustomShortcut_4
        '
        resources.ApplyResources(Me.AppOption_EnableCustomShortcut_4, "AppOption_EnableCustomShortcut_4")
        Me.AppOption_EnableCustomShortcut_4.Name = "AppOption_EnableCustomShortcut_4"
        Me.AppOption_EnableCustomShortcut_4.UseVisualStyleBackColor = False
        '
        'AppOption_Shortcut4_SelectFile
        '
        resources.ApplyResources(Me.AppOption_Shortcut4_SelectFile, "AppOption_Shortcut4_SelectFile")
        Me.AppOption_Shortcut4_SelectFile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_Shortcut4_SelectFile.Name = "AppOption_Shortcut4_SelectFile"
        Me.AppOption_Shortcut4_SelectFile.TabStop = True
        '
        'Text_018
        '
        resources.ApplyResources(Me.Text_018, "Text_018")
        Me.Text_018.Name = "Text_018"
        '
        'AppOption_Shortcut4_Icon
        '
        resources.ApplyResources(Me.AppOption_Shortcut4_Icon, "AppOption_Shortcut4_Icon")
        Me.AppOption_Shortcut4_Icon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_Shortcut4_Icon.DropDownWidth = 200
        Me.AppOption_Shortcut4_Icon.FormattingEnabled = True
        Me.AppOption_Shortcut4_Icon.Items.AddRange(New Object() {resources.GetString("AppOption_Shortcut4_Icon.Items"), resources.GetString("AppOption_Shortcut4_Icon.Items1"), resources.GetString("AppOption_Shortcut4_Icon.Items2"), resources.GetString("AppOption_Shortcut4_Icon.Items3"), resources.GetString("AppOption_Shortcut4_Icon.Items4"), resources.GetString("AppOption_Shortcut4_Icon.Items5"), resources.GetString("AppOption_Shortcut4_Icon.Items6"), resources.GetString("AppOption_Shortcut4_Icon.Items7"), resources.GetString("AppOption_Shortcut4_Icon.Items8"), resources.GetString("AppOption_Shortcut4_Icon.Items9"), resources.GetString("AppOption_Shortcut4_Icon.Items10"), resources.GetString("AppOption_Shortcut4_Icon.Items11"), resources.GetString("AppOption_Shortcut4_Icon.Items12"), resources.GetString("AppOption_Shortcut4_Icon.Items13"), resources.GetString("AppOption_Shortcut4_Icon.Items14"), resources.GetString("AppOption_Shortcut4_Icon.Items15"), resources.GetString("AppOption_Shortcut4_Icon.Items16"), resources.GetString("AppOption_Shortcut4_Icon.Items17"), resources.GetString("AppOption_Shortcut4_Icon.Items18"), resources.GetString("AppOption_Shortcut4_Icon.Items19"), resources.GetString("AppOption_Shortcut4_Icon.Items20"), resources.GetString("AppOption_Shortcut4_Icon.Items21"), resources.GetString("AppOption_Shortcut4_Icon.Items22"), resources.GetString("AppOption_Shortcut4_Icon.Items23"), resources.GetString("AppOption_Shortcut4_Icon.Items24"), resources.GetString("AppOption_Shortcut4_Icon.Items25"), resources.GetString("AppOption_Shortcut4_Icon.Items26"), resources.GetString("AppOption_Shortcut4_Icon.Items27"), resources.GetString("AppOption_Shortcut4_Icon.Items28"), resources.GetString("AppOption_Shortcut4_Icon.Items29"), resources.GetString("AppOption_Shortcut4_Icon.Items30"), resources.GetString("AppOption_Shortcut4_Icon.Items31"), resources.GetString("AppOption_Shortcut4_Icon.Items32"), resources.GetString("AppOption_Shortcut4_Icon.Items33"), resources.GetString("AppOption_Shortcut4_Icon.Items34")})
        Me.AppOption_Shortcut4_Icon.Name = "AppOption_Shortcut4_Icon"
        '
        'Text_019
        '
        resources.ApplyResources(Me.Text_019, "Text_019")
        Me.Text_019.Name = "Text_019"
        '
        'Text_020
        '
        resources.ApplyResources(Me.Text_020, "Text_020")
        Me.Text_020.Name = "Text_020"
        '
        'AppOption_Shortcut4_LaunchWith
        '
        Me.AppOption_Shortcut4_LaunchWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_Shortcut4_LaunchWith.DropDownWidth = 200
        resources.ApplyResources(Me.AppOption_Shortcut4_LaunchWith, "AppOption_Shortcut4_LaunchWith")
        Me.AppOption_Shortcut4_LaunchWith.FormattingEnabled = True
        Me.AppOption_Shortcut4_LaunchWith.Items.AddRange(New Object() {resources.GetString("AppOption_Shortcut4_LaunchWith.Items"), resources.GetString("AppOption_Shortcut4_LaunchWith.Items1"), resources.GetString("AppOption_Shortcut4_LaunchWith.Items2"), resources.GetString("AppOption_Shortcut4_LaunchWith.Items3"), resources.GetString("AppOption_Shortcut4_LaunchWith.Items4"), resources.GetString("AppOption_Shortcut4_LaunchWith.Items5"), resources.GetString("AppOption_Shortcut4_LaunchWith.Items6"), resources.GetString("AppOption_Shortcut4_LaunchWith.Items7"), resources.GetString("AppOption_Shortcut4_LaunchWith.Items8"), resources.GetString("AppOption_Shortcut4_LaunchWith.Items9"), resources.GetString("AppOption_Shortcut4_LaunchWith.Items10"), resources.GetString("AppOption_Shortcut4_LaunchWith.Items11")})
        Me.AppOption_Shortcut4_LaunchWith.Name = "AppOption_Shortcut4_LaunchWith"
        '
        'UI_Tab04_Cat07
        '
        resources.ApplyResources(Me.UI_Tab04_Cat07, "UI_Tab04_Cat07")
        Me.UI_Tab04_Cat07.Controls.Add(Me.AppOption_Shortcut6_Path)
        Me.UI_Tab04_Cat07.Controls.Add(Me.AppOption_EnableCustomShortcut_6)
        Me.UI_Tab04_Cat07.Controls.Add(Me.Text_024)
        Me.UI_Tab04_Cat07.Controls.Add(Me.Text_025)
        Me.UI_Tab04_Cat07.Controls.Add(Me.AppOption_Shortcut6_SelectFile)
        Me.UI_Tab04_Cat07.Controls.Add(Me.AppOption_Shortcut6_Icon)
        Me.UI_Tab04_Cat07.Controls.Add(Me.AppOption_Shortcut6_LaunchWith)
        Me.UI_Tab04_Cat07.Controls.Add(Me.Text_026)
        Me.UI_Tab04_Cat07.Name = "UI_Tab04_Cat07"
        Me.UI_Tab04_Cat07.TabStop = False
        '
        'AppOption_Shortcut6_Path
        '
        resources.ApplyResources(Me.AppOption_Shortcut6_Path, "AppOption_Shortcut6_Path")
        Me.AppOption_Shortcut6_Path.Name = "AppOption_Shortcut6_Path"
        '
        'AppOption_EnableCustomShortcut_6
        '
        resources.ApplyResources(Me.AppOption_EnableCustomShortcut_6, "AppOption_EnableCustomShortcut_6")
        Me.AppOption_EnableCustomShortcut_6.Name = "AppOption_EnableCustomShortcut_6"
        Me.AppOption_EnableCustomShortcut_6.UseVisualStyleBackColor = False
        '
        'Text_024
        '
        resources.ApplyResources(Me.Text_024, "Text_024")
        Me.Text_024.Name = "Text_024"
        '
        'Text_025
        '
        resources.ApplyResources(Me.Text_025, "Text_025")
        Me.Text_025.Name = "Text_025"
        '
        'AppOption_Shortcut6_SelectFile
        '
        resources.ApplyResources(Me.AppOption_Shortcut6_SelectFile, "AppOption_Shortcut6_SelectFile")
        Me.AppOption_Shortcut6_SelectFile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_Shortcut6_SelectFile.Name = "AppOption_Shortcut6_SelectFile"
        Me.AppOption_Shortcut6_SelectFile.TabStop = True
        '
        'AppOption_Shortcut6_Icon
        '
        resources.ApplyResources(Me.AppOption_Shortcut6_Icon, "AppOption_Shortcut6_Icon")
        Me.AppOption_Shortcut6_Icon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_Shortcut6_Icon.DropDownWidth = 200
        Me.AppOption_Shortcut6_Icon.FormattingEnabled = True
        Me.AppOption_Shortcut6_Icon.Items.AddRange(New Object() {resources.GetString("AppOption_Shortcut6_Icon.Items"), resources.GetString("AppOption_Shortcut6_Icon.Items1"), resources.GetString("AppOption_Shortcut6_Icon.Items2"), resources.GetString("AppOption_Shortcut6_Icon.Items3"), resources.GetString("AppOption_Shortcut6_Icon.Items4"), resources.GetString("AppOption_Shortcut6_Icon.Items5"), resources.GetString("AppOption_Shortcut6_Icon.Items6"), resources.GetString("AppOption_Shortcut6_Icon.Items7"), resources.GetString("AppOption_Shortcut6_Icon.Items8"), resources.GetString("AppOption_Shortcut6_Icon.Items9"), resources.GetString("AppOption_Shortcut6_Icon.Items10"), resources.GetString("AppOption_Shortcut6_Icon.Items11"), resources.GetString("AppOption_Shortcut6_Icon.Items12"), resources.GetString("AppOption_Shortcut6_Icon.Items13"), resources.GetString("AppOption_Shortcut6_Icon.Items14"), resources.GetString("AppOption_Shortcut6_Icon.Items15"), resources.GetString("AppOption_Shortcut6_Icon.Items16"), resources.GetString("AppOption_Shortcut6_Icon.Items17"), resources.GetString("AppOption_Shortcut6_Icon.Items18"), resources.GetString("AppOption_Shortcut6_Icon.Items19"), resources.GetString("AppOption_Shortcut6_Icon.Items20"), resources.GetString("AppOption_Shortcut6_Icon.Items21"), resources.GetString("AppOption_Shortcut6_Icon.Items22"), resources.GetString("AppOption_Shortcut6_Icon.Items23"), resources.GetString("AppOption_Shortcut6_Icon.Items24"), resources.GetString("AppOption_Shortcut6_Icon.Items25"), resources.GetString("AppOption_Shortcut6_Icon.Items26"), resources.GetString("AppOption_Shortcut6_Icon.Items27"), resources.GetString("AppOption_Shortcut6_Icon.Items28"), resources.GetString("AppOption_Shortcut6_Icon.Items29"), resources.GetString("AppOption_Shortcut6_Icon.Items30"), resources.GetString("AppOption_Shortcut6_Icon.Items31"), resources.GetString("AppOption_Shortcut6_Icon.Items32"), resources.GetString("AppOption_Shortcut6_Icon.Items33"), resources.GetString("AppOption_Shortcut6_Icon.Items34")})
        Me.AppOption_Shortcut6_Icon.Name = "AppOption_Shortcut6_Icon"
        '
        'AppOption_Shortcut6_LaunchWith
        '
        Me.AppOption_Shortcut6_LaunchWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_Shortcut6_LaunchWith.DropDownWidth = 200
        resources.ApplyResources(Me.AppOption_Shortcut6_LaunchWith, "AppOption_Shortcut6_LaunchWith")
        Me.AppOption_Shortcut6_LaunchWith.FormattingEnabled = True
        Me.AppOption_Shortcut6_LaunchWith.Items.AddRange(New Object() {resources.GetString("AppOption_Shortcut6_LaunchWith.Items"), resources.GetString("AppOption_Shortcut6_LaunchWith.Items1"), resources.GetString("AppOption_Shortcut6_LaunchWith.Items2"), resources.GetString("AppOption_Shortcut6_LaunchWith.Items3"), resources.GetString("AppOption_Shortcut6_LaunchWith.Items4"), resources.GetString("AppOption_Shortcut6_LaunchWith.Items5"), resources.GetString("AppOption_Shortcut6_LaunchWith.Items6"), resources.GetString("AppOption_Shortcut6_LaunchWith.Items7"), resources.GetString("AppOption_Shortcut6_LaunchWith.Items8"), resources.GetString("AppOption_Shortcut6_LaunchWith.Items9"), resources.GetString("AppOption_Shortcut6_LaunchWith.Items10"), resources.GetString("AppOption_Shortcut6_LaunchWith.Items11")})
        Me.AppOption_Shortcut6_LaunchWith.Name = "AppOption_Shortcut6_LaunchWith"
        '
        'Text_026
        '
        resources.ApplyResources(Me.Text_026, "Text_026")
        Me.Text_026.Name = "Text_026"
        '
        'UI_Tab04_Cat04
        '
        resources.ApplyResources(Me.UI_Tab04_Cat04, "UI_Tab04_Cat04")
        Me.UI_Tab04_Cat04.Controls.Add(Me.AppOption_Shortcut3_Path)
        Me.UI_Tab04_Cat04.Controls.Add(Me.AppOption_Shortcut3_SelectFile)
        Me.UI_Tab04_Cat04.Controls.Add(Me.AppOption_Shortcut3_Icon)
        Me.UI_Tab04_Cat04.Controls.Add(Me.Text_017)
        Me.UI_Tab04_Cat04.Controls.Add(Me.AppOption_Shortcut3_LaunchWith)
        Me.UI_Tab04_Cat04.Controls.Add(Me.Text_016)
        Me.UI_Tab04_Cat04.Controls.Add(Me.Text_015)
        Me.UI_Tab04_Cat04.Controls.Add(Me.AppOption_EnableCustomShortcut_3)
        Me.UI_Tab04_Cat04.Name = "UI_Tab04_Cat04"
        Me.UI_Tab04_Cat04.TabStop = False
        '
        'AppOption_Shortcut3_Path
        '
        resources.ApplyResources(Me.AppOption_Shortcut3_Path, "AppOption_Shortcut3_Path")
        Me.AppOption_Shortcut3_Path.Name = "AppOption_Shortcut3_Path"
        '
        'AppOption_Shortcut3_SelectFile
        '
        resources.ApplyResources(Me.AppOption_Shortcut3_SelectFile, "AppOption_Shortcut3_SelectFile")
        Me.AppOption_Shortcut3_SelectFile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_Shortcut3_SelectFile.Name = "AppOption_Shortcut3_SelectFile"
        Me.AppOption_Shortcut3_SelectFile.TabStop = True
        '
        'AppOption_Shortcut3_Icon
        '
        resources.ApplyResources(Me.AppOption_Shortcut3_Icon, "AppOption_Shortcut3_Icon")
        Me.AppOption_Shortcut3_Icon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_Shortcut3_Icon.DropDownWidth = 200
        Me.AppOption_Shortcut3_Icon.FormattingEnabled = True
        Me.AppOption_Shortcut3_Icon.Items.AddRange(New Object() {resources.GetString("AppOption_Shortcut3_Icon.Items"), resources.GetString("AppOption_Shortcut3_Icon.Items1"), resources.GetString("AppOption_Shortcut3_Icon.Items2"), resources.GetString("AppOption_Shortcut3_Icon.Items3"), resources.GetString("AppOption_Shortcut3_Icon.Items4"), resources.GetString("AppOption_Shortcut3_Icon.Items5"), resources.GetString("AppOption_Shortcut3_Icon.Items6"), resources.GetString("AppOption_Shortcut3_Icon.Items7"), resources.GetString("AppOption_Shortcut3_Icon.Items8"), resources.GetString("AppOption_Shortcut3_Icon.Items9"), resources.GetString("AppOption_Shortcut3_Icon.Items10"), resources.GetString("AppOption_Shortcut3_Icon.Items11"), resources.GetString("AppOption_Shortcut3_Icon.Items12"), resources.GetString("AppOption_Shortcut3_Icon.Items13"), resources.GetString("AppOption_Shortcut3_Icon.Items14"), resources.GetString("AppOption_Shortcut3_Icon.Items15"), resources.GetString("AppOption_Shortcut3_Icon.Items16"), resources.GetString("AppOption_Shortcut3_Icon.Items17"), resources.GetString("AppOption_Shortcut3_Icon.Items18"), resources.GetString("AppOption_Shortcut3_Icon.Items19"), resources.GetString("AppOption_Shortcut3_Icon.Items20"), resources.GetString("AppOption_Shortcut3_Icon.Items21"), resources.GetString("AppOption_Shortcut3_Icon.Items22"), resources.GetString("AppOption_Shortcut3_Icon.Items23"), resources.GetString("AppOption_Shortcut3_Icon.Items24"), resources.GetString("AppOption_Shortcut3_Icon.Items25"), resources.GetString("AppOption_Shortcut3_Icon.Items26"), resources.GetString("AppOption_Shortcut3_Icon.Items27"), resources.GetString("AppOption_Shortcut3_Icon.Items28"), resources.GetString("AppOption_Shortcut3_Icon.Items29"), resources.GetString("AppOption_Shortcut3_Icon.Items30"), resources.GetString("AppOption_Shortcut3_Icon.Items31"), resources.GetString("AppOption_Shortcut3_Icon.Items32"), resources.GetString("AppOption_Shortcut3_Icon.Items33"), resources.GetString("AppOption_Shortcut3_Icon.Items34")})
        Me.AppOption_Shortcut3_Icon.Name = "AppOption_Shortcut3_Icon"
        '
        'Text_017
        '
        resources.ApplyResources(Me.Text_017, "Text_017")
        Me.Text_017.Name = "Text_017"
        '
        'AppOption_Shortcut3_LaunchWith
        '
        Me.AppOption_Shortcut3_LaunchWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_Shortcut3_LaunchWith.DropDownWidth = 200
        resources.ApplyResources(Me.AppOption_Shortcut3_LaunchWith, "AppOption_Shortcut3_LaunchWith")
        Me.AppOption_Shortcut3_LaunchWith.FormattingEnabled = True
        Me.AppOption_Shortcut3_LaunchWith.Items.AddRange(New Object() {resources.GetString("AppOption_Shortcut3_LaunchWith.Items"), resources.GetString("AppOption_Shortcut3_LaunchWith.Items1"), resources.GetString("AppOption_Shortcut3_LaunchWith.Items2"), resources.GetString("AppOption_Shortcut3_LaunchWith.Items3"), resources.GetString("AppOption_Shortcut3_LaunchWith.Items4"), resources.GetString("AppOption_Shortcut3_LaunchWith.Items5"), resources.GetString("AppOption_Shortcut3_LaunchWith.Items6"), resources.GetString("AppOption_Shortcut3_LaunchWith.Items7"), resources.GetString("AppOption_Shortcut3_LaunchWith.Items8"), resources.GetString("AppOption_Shortcut3_LaunchWith.Items9"), resources.GetString("AppOption_Shortcut3_LaunchWith.Items10"), resources.GetString("AppOption_Shortcut3_LaunchWith.Items11")})
        Me.AppOption_Shortcut3_LaunchWith.Name = "AppOption_Shortcut3_LaunchWith"
        '
        'Text_016
        '
        resources.ApplyResources(Me.Text_016, "Text_016")
        Me.Text_016.Name = "Text_016"
        '
        'Text_015
        '
        resources.ApplyResources(Me.Text_015, "Text_015")
        Me.Text_015.Name = "Text_015"
        '
        'AppOption_EnableCustomShortcut_3
        '
        resources.ApplyResources(Me.AppOption_EnableCustomShortcut_3, "AppOption_EnableCustomShortcut_3")
        Me.AppOption_EnableCustomShortcut_3.Name = "AppOption_EnableCustomShortcut_3"
        Me.AppOption_EnableCustomShortcut_3.UseVisualStyleBackColor = False
        '
        'UI_Tab04_Cat06
        '
        resources.ApplyResources(Me.UI_Tab04_Cat06, "UI_Tab04_Cat06")
        Me.UI_Tab04_Cat06.Controls.Add(Me.AppOption_Shortcut5_Path)
        Me.UI_Tab04_Cat06.Controls.Add(Me.AppOption_EnableCustomShortcut_5)
        Me.UI_Tab04_Cat06.Controls.Add(Me.Text_021)
        Me.UI_Tab04_Cat06.Controls.Add(Me.AppOption_Shortcut5_SelectFile)
        Me.UI_Tab04_Cat06.Controls.Add(Me.AppOption_Shortcut5_LaunchWith)
        Me.UI_Tab04_Cat06.Controls.Add(Me.Text_023)
        Me.UI_Tab04_Cat06.Controls.Add(Me.AppOption_Shortcut5_Icon)
        Me.UI_Tab04_Cat06.Controls.Add(Me.Text_022)
        Me.UI_Tab04_Cat06.Name = "UI_Tab04_Cat06"
        Me.UI_Tab04_Cat06.TabStop = False
        '
        'AppOption_Shortcut5_Path
        '
        resources.ApplyResources(Me.AppOption_Shortcut5_Path, "AppOption_Shortcut5_Path")
        Me.AppOption_Shortcut5_Path.Name = "AppOption_Shortcut5_Path"
        '
        'AppOption_EnableCustomShortcut_5
        '
        resources.ApplyResources(Me.AppOption_EnableCustomShortcut_5, "AppOption_EnableCustomShortcut_5")
        Me.AppOption_EnableCustomShortcut_5.Name = "AppOption_EnableCustomShortcut_5"
        Me.AppOption_EnableCustomShortcut_5.UseVisualStyleBackColor = False
        '
        'Text_021
        '
        resources.ApplyResources(Me.Text_021, "Text_021")
        Me.Text_021.Name = "Text_021"
        '
        'AppOption_Shortcut5_SelectFile
        '
        resources.ApplyResources(Me.AppOption_Shortcut5_SelectFile, "AppOption_Shortcut5_SelectFile")
        Me.AppOption_Shortcut5_SelectFile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_Shortcut5_SelectFile.Name = "AppOption_Shortcut5_SelectFile"
        Me.AppOption_Shortcut5_SelectFile.TabStop = True
        '
        'AppOption_Shortcut5_LaunchWith
        '
        Me.AppOption_Shortcut5_LaunchWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_Shortcut5_LaunchWith.DropDownWidth = 200
        resources.ApplyResources(Me.AppOption_Shortcut5_LaunchWith, "AppOption_Shortcut5_LaunchWith")
        Me.AppOption_Shortcut5_LaunchWith.FormattingEnabled = True
        Me.AppOption_Shortcut5_LaunchWith.Items.AddRange(New Object() {resources.GetString("AppOption_Shortcut5_LaunchWith.Items"), resources.GetString("AppOption_Shortcut5_LaunchWith.Items1"), resources.GetString("AppOption_Shortcut5_LaunchWith.Items2"), resources.GetString("AppOption_Shortcut5_LaunchWith.Items3"), resources.GetString("AppOption_Shortcut5_LaunchWith.Items4"), resources.GetString("AppOption_Shortcut5_LaunchWith.Items5"), resources.GetString("AppOption_Shortcut5_LaunchWith.Items6"), resources.GetString("AppOption_Shortcut5_LaunchWith.Items7"), resources.GetString("AppOption_Shortcut5_LaunchWith.Items8"), resources.GetString("AppOption_Shortcut5_LaunchWith.Items9"), resources.GetString("AppOption_Shortcut5_LaunchWith.Items10"), resources.GetString("AppOption_Shortcut5_LaunchWith.Items11")})
        Me.AppOption_Shortcut5_LaunchWith.Name = "AppOption_Shortcut5_LaunchWith"
        '
        'Text_023
        '
        resources.ApplyResources(Me.Text_023, "Text_023")
        Me.Text_023.Name = "Text_023"
        '
        'AppOption_Shortcut5_Icon
        '
        resources.ApplyResources(Me.AppOption_Shortcut5_Icon, "AppOption_Shortcut5_Icon")
        Me.AppOption_Shortcut5_Icon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_Shortcut5_Icon.DropDownWidth = 200
        Me.AppOption_Shortcut5_Icon.FormattingEnabled = True
        Me.AppOption_Shortcut5_Icon.Items.AddRange(New Object() {resources.GetString("AppOption_Shortcut5_Icon.Items"), resources.GetString("AppOption_Shortcut5_Icon.Items1"), resources.GetString("AppOption_Shortcut5_Icon.Items2"), resources.GetString("AppOption_Shortcut5_Icon.Items3"), resources.GetString("AppOption_Shortcut5_Icon.Items4"), resources.GetString("AppOption_Shortcut5_Icon.Items5"), resources.GetString("AppOption_Shortcut5_Icon.Items6"), resources.GetString("AppOption_Shortcut5_Icon.Items7"), resources.GetString("AppOption_Shortcut5_Icon.Items8"), resources.GetString("AppOption_Shortcut5_Icon.Items9"), resources.GetString("AppOption_Shortcut5_Icon.Items10"), resources.GetString("AppOption_Shortcut5_Icon.Items11"), resources.GetString("AppOption_Shortcut5_Icon.Items12"), resources.GetString("AppOption_Shortcut5_Icon.Items13"), resources.GetString("AppOption_Shortcut5_Icon.Items14"), resources.GetString("AppOption_Shortcut5_Icon.Items15"), resources.GetString("AppOption_Shortcut5_Icon.Items16"), resources.GetString("AppOption_Shortcut5_Icon.Items17"), resources.GetString("AppOption_Shortcut5_Icon.Items18"), resources.GetString("AppOption_Shortcut5_Icon.Items19"), resources.GetString("AppOption_Shortcut5_Icon.Items20"), resources.GetString("AppOption_Shortcut5_Icon.Items21"), resources.GetString("AppOption_Shortcut5_Icon.Items22"), resources.GetString("AppOption_Shortcut5_Icon.Items23"), resources.GetString("AppOption_Shortcut5_Icon.Items24"), resources.GetString("AppOption_Shortcut5_Icon.Items25"), resources.GetString("AppOption_Shortcut5_Icon.Items26"), resources.GetString("AppOption_Shortcut5_Icon.Items27"), resources.GetString("AppOption_Shortcut5_Icon.Items28"), resources.GetString("AppOption_Shortcut5_Icon.Items29"), resources.GetString("AppOption_Shortcut5_Icon.Items30"), resources.GetString("AppOption_Shortcut5_Icon.Items31"), resources.GetString("AppOption_Shortcut5_Icon.Items32"), resources.GetString("AppOption_Shortcut5_Icon.Items33"), resources.GetString("AppOption_Shortcut5_Icon.Items34")})
        Me.AppOption_Shortcut5_Icon.Name = "AppOption_Shortcut5_Icon"
        '
        'Text_022
        '
        resources.ApplyResources(Me.Text_022, "Text_022")
        Me.Text_022.Name = "Text_022"
        '
        'UI_Tab04_Cat03
        '
        resources.ApplyResources(Me.UI_Tab04_Cat03, "UI_Tab04_Cat03")
        Me.UI_Tab04_Cat03.Controls.Add(Me.AppOption_Shortcut2_Path)
        Me.UI_Tab04_Cat03.Controls.Add(Me.AppOption_Shortcut2_SelectFile)
        Me.UI_Tab04_Cat03.Controls.Add(Me.AppOption_EnableCustomShortcut_2)
        Me.UI_Tab04_Cat03.Controls.Add(Me.AppOption_Shortcut2_Icon)
        Me.UI_Tab04_Cat03.Controls.Add(Me.Text_012)
        Me.UI_Tab04_Cat03.Controls.Add(Me.Text_014)
        Me.UI_Tab04_Cat03.Controls.Add(Me.AppOption_Shortcut2_LaunchWith)
        Me.UI_Tab04_Cat03.Controls.Add(Me.Text_013)
        Me.UI_Tab04_Cat03.Name = "UI_Tab04_Cat03"
        Me.UI_Tab04_Cat03.TabStop = False
        '
        'AppOption_Shortcut2_Path
        '
        resources.ApplyResources(Me.AppOption_Shortcut2_Path, "AppOption_Shortcut2_Path")
        Me.AppOption_Shortcut2_Path.Name = "AppOption_Shortcut2_Path"
        '
        'AppOption_Shortcut2_SelectFile
        '
        resources.ApplyResources(Me.AppOption_Shortcut2_SelectFile, "AppOption_Shortcut2_SelectFile")
        Me.AppOption_Shortcut2_SelectFile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_Shortcut2_SelectFile.Name = "AppOption_Shortcut2_SelectFile"
        Me.AppOption_Shortcut2_SelectFile.TabStop = True
        '
        'AppOption_EnableCustomShortcut_2
        '
        resources.ApplyResources(Me.AppOption_EnableCustomShortcut_2, "AppOption_EnableCustomShortcut_2")
        Me.AppOption_EnableCustomShortcut_2.Name = "AppOption_EnableCustomShortcut_2"
        Me.AppOption_EnableCustomShortcut_2.UseVisualStyleBackColor = False
        '
        'AppOption_Shortcut2_Icon
        '
        resources.ApplyResources(Me.AppOption_Shortcut2_Icon, "AppOption_Shortcut2_Icon")
        Me.AppOption_Shortcut2_Icon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_Shortcut2_Icon.DropDownWidth = 200
        Me.AppOption_Shortcut2_Icon.FormattingEnabled = True
        Me.AppOption_Shortcut2_Icon.Items.AddRange(New Object() {resources.GetString("AppOption_Shortcut2_Icon.Items"), resources.GetString("AppOption_Shortcut2_Icon.Items1"), resources.GetString("AppOption_Shortcut2_Icon.Items2"), resources.GetString("AppOption_Shortcut2_Icon.Items3"), resources.GetString("AppOption_Shortcut2_Icon.Items4"), resources.GetString("AppOption_Shortcut2_Icon.Items5"), resources.GetString("AppOption_Shortcut2_Icon.Items6"), resources.GetString("AppOption_Shortcut2_Icon.Items7"), resources.GetString("AppOption_Shortcut2_Icon.Items8"), resources.GetString("AppOption_Shortcut2_Icon.Items9"), resources.GetString("AppOption_Shortcut2_Icon.Items10"), resources.GetString("AppOption_Shortcut2_Icon.Items11"), resources.GetString("AppOption_Shortcut2_Icon.Items12"), resources.GetString("AppOption_Shortcut2_Icon.Items13"), resources.GetString("AppOption_Shortcut2_Icon.Items14"), resources.GetString("AppOption_Shortcut2_Icon.Items15"), resources.GetString("AppOption_Shortcut2_Icon.Items16"), resources.GetString("AppOption_Shortcut2_Icon.Items17"), resources.GetString("AppOption_Shortcut2_Icon.Items18"), resources.GetString("AppOption_Shortcut2_Icon.Items19"), resources.GetString("AppOption_Shortcut2_Icon.Items20"), resources.GetString("AppOption_Shortcut2_Icon.Items21"), resources.GetString("AppOption_Shortcut2_Icon.Items22"), resources.GetString("AppOption_Shortcut2_Icon.Items23"), resources.GetString("AppOption_Shortcut2_Icon.Items24"), resources.GetString("AppOption_Shortcut2_Icon.Items25"), resources.GetString("AppOption_Shortcut2_Icon.Items26"), resources.GetString("AppOption_Shortcut2_Icon.Items27"), resources.GetString("AppOption_Shortcut2_Icon.Items28"), resources.GetString("AppOption_Shortcut2_Icon.Items29"), resources.GetString("AppOption_Shortcut2_Icon.Items30"), resources.GetString("AppOption_Shortcut2_Icon.Items31"), resources.GetString("AppOption_Shortcut2_Icon.Items32"), resources.GetString("AppOption_Shortcut2_Icon.Items33"), resources.GetString("AppOption_Shortcut2_Icon.Items34")})
        Me.AppOption_Shortcut2_Icon.Name = "AppOption_Shortcut2_Icon"
        '
        'Text_012
        '
        resources.ApplyResources(Me.Text_012, "Text_012")
        Me.Text_012.Name = "Text_012"
        '
        'Text_014
        '
        resources.ApplyResources(Me.Text_014, "Text_014")
        Me.Text_014.Name = "Text_014"
        '
        'AppOption_Shortcut2_LaunchWith
        '
        Me.AppOption_Shortcut2_LaunchWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_Shortcut2_LaunchWith.DropDownWidth = 200
        resources.ApplyResources(Me.AppOption_Shortcut2_LaunchWith, "AppOption_Shortcut2_LaunchWith")
        Me.AppOption_Shortcut2_LaunchWith.FormattingEnabled = True
        Me.AppOption_Shortcut2_LaunchWith.Items.AddRange(New Object() {resources.GetString("AppOption_Shortcut2_LaunchWith.Items"), resources.GetString("AppOption_Shortcut2_LaunchWith.Items1"), resources.GetString("AppOption_Shortcut2_LaunchWith.Items2"), resources.GetString("AppOption_Shortcut2_LaunchWith.Items3"), resources.GetString("AppOption_Shortcut2_LaunchWith.Items4"), resources.GetString("AppOption_Shortcut2_LaunchWith.Items5"), resources.GetString("AppOption_Shortcut2_LaunchWith.Items6"), resources.GetString("AppOption_Shortcut2_LaunchWith.Items7"), resources.GetString("AppOption_Shortcut2_LaunchWith.Items8"), resources.GetString("AppOption_Shortcut2_LaunchWith.Items9"), resources.GetString("AppOption_Shortcut2_LaunchWith.Items10"), resources.GetString("AppOption_Shortcut2_LaunchWith.Items11")})
        Me.AppOption_Shortcut2_LaunchWith.Name = "AppOption_Shortcut2_LaunchWith"
        '
        'Text_013
        '
        resources.ApplyResources(Me.Text_013, "Text_013")
        Me.Text_013.Name = "Text_013"
        '
        'UI_Tab04_Cat02
        '
        resources.ApplyResources(Me.UI_Tab04_Cat02, "UI_Tab04_Cat02")
        Me.UI_Tab04_Cat02.Controls.Add(Me.AppOption_Shortcut1_Path)
        Me.UI_Tab04_Cat02.Controls.Add(Me.AppOption_Shortcut1_SelectFile)
        Me.UI_Tab04_Cat02.Controls.Add(Me.AppOption_Shortcut1_Icon)
        Me.UI_Tab04_Cat02.Controls.Add(Me.Text_011)
        Me.UI_Tab04_Cat02.Controls.Add(Me.AppOption_Shortcut1_LaunchWith)
        Me.UI_Tab04_Cat02.Controls.Add(Me.Text_010)
        Me.UI_Tab04_Cat02.Controls.Add(Me.Text_009)
        Me.UI_Tab04_Cat02.Controls.Add(Me.AppOption_EnableCustomShortcut_1)
        Me.UI_Tab04_Cat02.Name = "UI_Tab04_Cat02"
        Me.UI_Tab04_Cat02.TabStop = False
        '
        'AppOption_Shortcut1_Path
        '
        resources.ApplyResources(Me.AppOption_Shortcut1_Path, "AppOption_Shortcut1_Path")
        Me.AppOption_Shortcut1_Path.Name = "AppOption_Shortcut1_Path"
        '
        'AppOption_Shortcut1_SelectFile
        '
        resources.ApplyResources(Me.AppOption_Shortcut1_SelectFile, "AppOption_Shortcut1_SelectFile")
        Me.AppOption_Shortcut1_SelectFile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_Shortcut1_SelectFile.Name = "AppOption_Shortcut1_SelectFile"
        Me.AppOption_Shortcut1_SelectFile.TabStop = True
        '
        'AppOption_Shortcut1_Icon
        '
        resources.ApplyResources(Me.AppOption_Shortcut1_Icon, "AppOption_Shortcut1_Icon")
        Me.AppOption_Shortcut1_Icon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_Shortcut1_Icon.DropDownWidth = 200
        Me.AppOption_Shortcut1_Icon.FormattingEnabled = True
        Me.AppOption_Shortcut1_Icon.Items.AddRange(New Object() {resources.GetString("AppOption_Shortcut1_Icon.Items"), resources.GetString("AppOption_Shortcut1_Icon.Items1"), resources.GetString("AppOption_Shortcut1_Icon.Items2"), resources.GetString("AppOption_Shortcut1_Icon.Items3"), resources.GetString("AppOption_Shortcut1_Icon.Items4"), resources.GetString("AppOption_Shortcut1_Icon.Items5"), resources.GetString("AppOption_Shortcut1_Icon.Items6"), resources.GetString("AppOption_Shortcut1_Icon.Items7"), resources.GetString("AppOption_Shortcut1_Icon.Items8"), resources.GetString("AppOption_Shortcut1_Icon.Items9"), resources.GetString("AppOption_Shortcut1_Icon.Items10"), resources.GetString("AppOption_Shortcut1_Icon.Items11"), resources.GetString("AppOption_Shortcut1_Icon.Items12"), resources.GetString("AppOption_Shortcut1_Icon.Items13"), resources.GetString("AppOption_Shortcut1_Icon.Items14"), resources.GetString("AppOption_Shortcut1_Icon.Items15"), resources.GetString("AppOption_Shortcut1_Icon.Items16"), resources.GetString("AppOption_Shortcut1_Icon.Items17"), resources.GetString("AppOption_Shortcut1_Icon.Items18"), resources.GetString("AppOption_Shortcut1_Icon.Items19"), resources.GetString("AppOption_Shortcut1_Icon.Items20"), resources.GetString("AppOption_Shortcut1_Icon.Items21"), resources.GetString("AppOption_Shortcut1_Icon.Items22"), resources.GetString("AppOption_Shortcut1_Icon.Items23"), resources.GetString("AppOption_Shortcut1_Icon.Items24"), resources.GetString("AppOption_Shortcut1_Icon.Items25"), resources.GetString("AppOption_Shortcut1_Icon.Items26"), resources.GetString("AppOption_Shortcut1_Icon.Items27"), resources.GetString("AppOption_Shortcut1_Icon.Items28"), resources.GetString("AppOption_Shortcut1_Icon.Items29"), resources.GetString("AppOption_Shortcut1_Icon.Items30"), resources.GetString("AppOption_Shortcut1_Icon.Items31"), resources.GetString("AppOption_Shortcut1_Icon.Items32"), resources.GetString("AppOption_Shortcut1_Icon.Items33"), resources.GetString("AppOption_Shortcut1_Icon.Items34")})
        Me.AppOption_Shortcut1_Icon.Name = "AppOption_Shortcut1_Icon"
        '
        'Text_011
        '
        resources.ApplyResources(Me.Text_011, "Text_011")
        Me.Text_011.Name = "Text_011"
        '
        'AppOption_Shortcut1_LaunchWith
        '
        Me.AppOption_Shortcut1_LaunchWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_Shortcut1_LaunchWith.DropDownWidth = 200
        resources.ApplyResources(Me.AppOption_Shortcut1_LaunchWith, "AppOption_Shortcut1_LaunchWith")
        Me.AppOption_Shortcut1_LaunchWith.FormattingEnabled = True
        Me.AppOption_Shortcut1_LaunchWith.Items.AddRange(New Object() {resources.GetString("AppOption_Shortcut1_LaunchWith.Items"), resources.GetString("AppOption_Shortcut1_LaunchWith.Items1"), resources.GetString("AppOption_Shortcut1_LaunchWith.Items2"), resources.GetString("AppOption_Shortcut1_LaunchWith.Items3"), resources.GetString("AppOption_Shortcut1_LaunchWith.Items4"), resources.GetString("AppOption_Shortcut1_LaunchWith.Items5"), resources.GetString("AppOption_Shortcut1_LaunchWith.Items6"), resources.GetString("AppOption_Shortcut1_LaunchWith.Items7"), resources.GetString("AppOption_Shortcut1_LaunchWith.Items8"), resources.GetString("AppOption_Shortcut1_LaunchWith.Items9"), resources.GetString("AppOption_Shortcut1_LaunchWith.Items10"), resources.GetString("AppOption_Shortcut1_LaunchWith.Items11")})
        Me.AppOption_Shortcut1_LaunchWith.Name = "AppOption_Shortcut1_LaunchWith"
        '
        'Text_010
        '
        resources.ApplyResources(Me.Text_010, "Text_010")
        Me.Text_010.Name = "Text_010"
        '
        'Text_009
        '
        resources.ApplyResources(Me.Text_009, "Text_009")
        Me.Text_009.Name = "Text_009"
        '
        'AppOption_EnableCustomShortcut_1
        '
        resources.ApplyResources(Me.AppOption_EnableCustomShortcut_1, "AppOption_EnableCustomShortcut_1")
        Me.AppOption_EnableCustomShortcut_1.Name = "AppOption_EnableCustomShortcut_1"
        Me.AppOption_EnableCustomShortcut_1.UseVisualStyleBackColor = False
        '
        'UI_Tab04_Cat01
        '
        resources.ApplyResources(Me.UI_Tab04_Cat01, "UI_Tab04_Cat01")
        Me.UI_Tab04_Cat01.Controls.Add(Me.AppOption_EnableCustomShortcuts)
        Me.UI_Tab04_Cat01.Name = "UI_Tab04_Cat01"
        Me.UI_Tab04_Cat01.TabStop = False
        '
        'AppOption_EnableCustomShortcuts
        '
        resources.ApplyResources(Me.AppOption_EnableCustomShortcuts, "AppOption_EnableCustomShortcuts")
        Me.AppOption_EnableCustomShortcuts.Name = "AppOption_EnableCustomShortcuts"
        Me.AppOption_EnableCustomShortcuts.UseVisualStyleBackColor = False
        '
        'UI_Tab04_Title01
        '
        resources.ApplyResources(Me.UI_Tab04_Title01, "UI_Tab04_Title01")
        Me.UI_Tab04_Title01.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UI_Tab04_Title01.Name = "UI_Tab04_Title01"
        '
        'UI_SettingsTab05
        '
        Me.UI_SettingsTab05.Controls.Add(Me.UI_Tab05_Cat03)
        Me.UI_SettingsTab05.Controls.Add(Me.UI_Tab05_Cat02)
        Me.UI_SettingsTab05.Controls.Add(Me.UI_Tab05_Title01)
        Me.UI_SettingsTab05.Controls.Add(Me.UI_Tab05_Cat01)
        resources.ApplyResources(Me.UI_SettingsTab05, "UI_SettingsTab05")
        Me.UI_SettingsTab05.Name = "UI_SettingsTab05"
        Me.UI_SettingsTab05.UseVisualStyleBackColor = True
        '
        'UI_Tab05_Cat03
        '
        resources.ApplyResources(Me.UI_Tab05_Cat03, "UI_Tab05_Cat03")
        Me.UI_Tab05_Cat03.Controls.Add(Me.AppOption_UpdateAutomaticInstallSilentMode)
        Me.UI_Tab05_Cat03.Controls.Add(Me.UI_Tab04_Cat03_UnderOption01)
        Me.UI_Tab05_Cat03.Controls.Add(Me.AppOption_UpdateAutomaticDownload)
        Me.UI_Tab05_Cat03.Controls.Add(Me.AppOption_UpdateAutomaticInstall)
        Me.UI_Tab05_Cat03.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UI_Tab05_Cat03.Name = "UI_Tab05_Cat03"
        Me.UI_Tab05_Cat03.TabStop = False
        '
        'AppOption_UpdateAutomaticInstallSilentMode
        '
        resources.ApplyResources(Me.AppOption_UpdateAutomaticInstallSilentMode, "AppOption_UpdateAutomaticInstallSilentMode")
        Me.AppOption_UpdateAutomaticInstallSilentMode.AutoEllipsis = True
        Me.AppOption_UpdateAutomaticInstallSilentMode.Name = "AppOption_UpdateAutomaticInstallSilentMode"
        Me.AppOption_UpdateAutomaticInstallSilentMode.UseVisualStyleBackColor = True
        '
        'UI_Tab04_Cat03_UnderOption01
        '
        Me.UI_Tab04_Cat03_UnderOption01.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.CbxUnderOptionUnavailable
        resources.ApplyResources(Me.UI_Tab04_Cat03_UnderOption01, "UI_Tab04_Cat03_UnderOption01")
        Me.UI_Tab04_Cat03_UnderOption01.Name = "UI_Tab04_Cat03_UnderOption01"
        Me.UI_Tab04_Cat03_UnderOption01.TabStop = False
        '
        'AppOption_UpdateAutomaticDownload
        '
        resources.ApplyResources(Me.AppOption_UpdateAutomaticDownload, "AppOption_UpdateAutomaticDownload")
        Me.AppOption_UpdateAutomaticDownload.Name = "AppOption_UpdateAutomaticDownload"
        Me.AppOption_UpdateAutomaticDownload.UseVisualStyleBackColor = True
        '
        'AppOption_UpdateAutomaticInstall
        '
        resources.ApplyResources(Me.AppOption_UpdateAutomaticInstall, "AppOption_UpdateAutomaticInstall")
        Me.AppOption_UpdateAutomaticInstall.Name = "AppOption_UpdateAutomaticInstall"
        Me.AppOption_UpdateAutomaticInstall.UseVisualStyleBackColor = True
        '
        'UI_Tab05_Cat02
        '
        resources.ApplyResources(Me.UI_Tab05_Cat02, "UI_Tab05_Cat02")
        Me.UI_Tab05_Cat02.Controls.Add(Me.AppOption_DisplayUpdateSearchVersionOnAboutWindow)
        Me.UI_Tab05_Cat02.Controls.Add(Me.AppOption_DisplayUpdateSearchModuleOnAboutWindow)
        Me.UI_Tab05_Cat02.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UI_Tab05_Cat02.Name = "UI_Tab05_Cat02"
        Me.UI_Tab05_Cat02.TabStop = False
        '
        'AppOption_DisplayUpdateSearchVersionOnAboutWindow
        '
        resources.ApplyResources(Me.AppOption_DisplayUpdateSearchVersionOnAboutWindow, "AppOption_DisplayUpdateSearchVersionOnAboutWindow")
        Me.AppOption_DisplayUpdateSearchVersionOnAboutWindow.Name = "AppOption_DisplayUpdateSearchVersionOnAboutWindow"
        Me.AppOption_DisplayUpdateSearchVersionOnAboutWindow.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayUpdateSearchModuleOnAboutWindow
        '
        resources.ApplyResources(Me.AppOption_DisplayUpdateSearchModuleOnAboutWindow, "AppOption_DisplayUpdateSearchModuleOnAboutWindow")
        Me.AppOption_DisplayUpdateSearchModuleOnAboutWindow.Name = "AppOption_DisplayUpdateSearchModuleOnAboutWindow"
        Me.AppOption_DisplayUpdateSearchModuleOnAboutWindow.UseVisualStyleBackColor = True
        '
        'UI_Tab05_Title01
        '
        resources.ApplyResources(Me.UI_Tab05_Title01, "UI_Tab05_Title01")
        Me.UI_Tab05_Title01.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UI_Tab05_Title01.Name = "UI_Tab05_Title01"
        '
        'UI_Tab05_Cat01
        '
        resources.ApplyResources(Me.UI_Tab05_Cat01, "UI_Tab05_Cat01")
        Me.UI_Tab05_Cat01.Controls.Add(Me.AppOption_UseLegacyUpdatePopups)
        Me.UI_Tab05_Cat01.Controls.Add(Me.UI_Tab04_Cat01_UnderOption02)
        Me.UI_Tab05_Cat01.Controls.Add(Me.AppOption_UpdateAtStartup_DiscreteMode)
        Me.UI_Tab05_Cat01.Controls.Add(Me.UI_Tab04_Cat01_UnderOption01)
        Me.UI_Tab05_Cat01.Controls.Add(Me.AppOption_SearchUpdateAtAppStart)
        Me.UI_Tab05_Cat01.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UI_Tab05_Cat01.Name = "UI_Tab05_Cat01"
        Me.UI_Tab05_Cat01.TabStop = False
        '
        'AppOption_UseLegacyUpdatePopups
        '
        resources.ApplyResources(Me.AppOption_UseLegacyUpdatePopups, "AppOption_UseLegacyUpdatePopups")
        Me.AppOption_UseLegacyUpdatePopups.AutoEllipsis = True
        Me.AppOption_UseLegacyUpdatePopups.Name = "AppOption_UseLegacyUpdatePopups"
        Me.AppOption_UseLegacyUpdatePopups.UseVisualStyleBackColor = True
        '
        'UI_Tab04_Cat01_UnderOption02
        '
        Me.UI_Tab04_Cat01_UnderOption02.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.CbxUnderOptionUnavailableL
        resources.ApplyResources(Me.UI_Tab04_Cat01_UnderOption02, "UI_Tab04_Cat01_UnderOption02")
        Me.UI_Tab04_Cat01_UnderOption02.Name = "UI_Tab04_Cat01_UnderOption02"
        Me.UI_Tab04_Cat01_UnderOption02.TabStop = False
        '
        'AppOption_UpdateAtStartup_DiscreteMode
        '
        resources.ApplyResources(Me.AppOption_UpdateAtStartup_DiscreteMode, "AppOption_UpdateAtStartup_DiscreteMode")
        Me.AppOption_UpdateAtStartup_DiscreteMode.AutoEllipsis = True
        Me.AppOption_UpdateAtStartup_DiscreteMode.Name = "AppOption_UpdateAtStartup_DiscreteMode"
        Me.AppOption_UpdateAtStartup_DiscreteMode.UseVisualStyleBackColor = True
        '
        'UI_Tab04_Cat01_UnderOption01
        '
        Me.UI_Tab04_Cat01_UnderOption01.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.CbxUnderOptionUnavailable
        resources.ApplyResources(Me.UI_Tab04_Cat01_UnderOption01, "UI_Tab04_Cat01_UnderOption01")
        Me.UI_Tab04_Cat01_UnderOption01.Name = "UI_Tab04_Cat01_UnderOption01"
        Me.UI_Tab04_Cat01_UnderOption01.TabStop = False
        '
        'AppOption_SearchUpdateAtAppStart
        '
        resources.ApplyResources(Me.AppOption_SearchUpdateAtAppStart, "AppOption_SearchUpdateAtAppStart")
        Me.AppOption_SearchUpdateAtAppStart.Name = "AppOption_SearchUpdateAtAppStart"
        Me.AppOption_SearchUpdateAtAppStart.UseVisualStyleBackColor = False
        '
        'UI_SettingsTab06
        '
        Me.UI_SettingsTab06.Controls.Add(Me.UI_Tab06_ApplicationTabControl)
        Me.UI_SettingsTab06.Controls.Add(Me.UI_Tab06_Title01)
        resources.ApplyResources(Me.UI_SettingsTab06, "UI_SettingsTab06")
        Me.UI_SettingsTab06.Name = "UI_SettingsTab06"
        Me.UI_SettingsTab06.UseVisualStyleBackColor = True
        '
        'UI_Tab06_ApplicationTabControl
        '
        resources.ApplyResources(Me.UI_Tab06_ApplicationTabControl, "UI_Tab06_ApplicationTabControl")
        Me.UI_Tab06_ApplicationTabControl.Controls.Add(Me.UI_Tab06_Tab01_LunarMagic)
        Me.UI_Tab06_ApplicationTabControl.Controls.Add(Me.UI_Tab06_Tab02_Snes9xBsnes)
        Me.UI_Tab06_ApplicationTabControl.Controls.Add(Me.UI_Tab06_Tab03_SmallHackerTools)
        Me.UI_Tab06_ApplicationTabControl.Controls.Add(Me.UI_Tab06_Tab04_OtherApps1)
        Me.UI_Tab06_ApplicationTabControl.Controls.Add(Me.UI_Tab06_Tab05_OtherApps2)
        Me.UI_Tab06_ApplicationTabControl.Controls.Add(Me.UI_Tab06_Tab06_OtherApps3)
        Me.UI_Tab06_ApplicationTabControl.Name = "UI_Tab06_ApplicationTabControl"
        Me.UI_Tab06_ApplicationTabControl.SelectedIndex = 0
        Me.UI_Tab06_ApplicationTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        '
        'UI_Tab06_Tab01_LunarMagic
        '
        Me.UI_Tab06_Tab01_LunarMagic.Controls.Add(Me.UI_Tab06_Cat01_SubCat04)
        Me.UI_Tab06_Tab01_LunarMagic.Controls.Add(Me.UI_Tab06_Cat01_SubCat03)
        Me.UI_Tab06_Tab01_LunarMagic.Controls.Add(Me.UI_Tab06_Cat01_SubCat01)
        Me.UI_Tab06_Tab01_LunarMagic.Controls.Add(Me.UI_Tab06_Cat01_SubCat02)
        resources.ApplyResources(Me.UI_Tab06_Tab01_LunarMagic, "UI_Tab06_Tab01_LunarMagic")
        Me.UI_Tab06_Tab01_LunarMagic.Name = "UI_Tab06_Tab01_LunarMagic"
        Me.UI_Tab06_Tab01_LunarMagic.UseVisualStyleBackColor = True
        '
        'UI_Tab06_Cat01_SubCat04
        '
        resources.ApplyResources(Me.UI_Tab06_Cat01_SubCat04, "UI_Tab06_Cat01_SubCat04")
        Me.UI_Tab06_Cat01_SubCat04.Controls.Add(Me.AppOption_LM1CTL_DisplaySelectorOnCTRLClick)
        Me.UI_Tab06_Cat01_SubCat04.Controls.Add(Me.AppOption_EnableLM1CTL)
        Me.UI_Tab06_Cat01_SubCat04.Controls.Add(Me.AppOption_LM1CTL_VersionSelector)
        Me.UI_Tab06_Cat01_SubCat04.Controls.Add(Me.Text_036)
        Me.UI_Tab06_Cat01_SubCat04.Name = "UI_Tab06_Cat01_SubCat04"
        Me.UI_Tab06_Cat01_SubCat04.TabStop = False
        '
        'AppOption_LM1CTL_DisplaySelectorOnCTRLClick
        '
        resources.ApplyResources(Me.AppOption_LM1CTL_DisplaySelectorOnCTRLClick, "AppOption_LM1CTL_DisplaySelectorOnCTRLClick")
        Me.AppOption_LM1CTL_DisplaySelectorOnCTRLClick.Name = "AppOption_LM1CTL_DisplaySelectorOnCTRLClick"
        Me.AppOption_LM1CTL_DisplaySelectorOnCTRLClick.UseVisualStyleBackColor = True
        '
        'AppOption_EnableLM1CTL
        '
        resources.ApplyResources(Me.AppOption_EnableLM1CTL, "AppOption_EnableLM1CTL")
        Me.AppOption_EnableLM1CTL.Name = "AppOption_EnableLM1CTL"
        Me.AppOption_EnableLM1CTL.UseVisualStyleBackColor = True
        '
        'AppOption_LM1CTL_VersionSelector
        '
        resources.ApplyResources(Me.AppOption_LM1CTL_VersionSelector, "AppOption_LM1CTL_VersionSelector")
        Me.AppOption_LM1CTL_VersionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_LM1CTL_VersionSelector.FormattingEnabled = True
        Me.AppOption_LM1CTL_VersionSelector.Items.AddRange(New Object() {resources.GetString("AppOption_LM1CTL_VersionSelector.Items"), resources.GetString("AppOption_LM1CTL_VersionSelector.Items1"), resources.GetString("AppOption_LM1CTL_VersionSelector.Items2")})
        Me.AppOption_LM1CTL_VersionSelector.Name = "AppOption_LM1CTL_VersionSelector"
        '
        'Text_036
        '
        resources.ApplyResources(Me.Text_036, "Text_036")
        Me.Text_036.Name = "Text_036"
        '
        'UI_Tab06_Cat01_SubCat03
        '
        resources.ApplyResources(Me.UI_Tab06_Cat01_SubCat03, "UI_Tab06_Cat01_SubCat03")
        Me.UI_Tab06_Cat01_SubCat03.Controls.Add(Me.AppOption_EnableHeaderMagicLMSlot3)
        Me.UI_Tab06_Cat01_SubCat03.Controls.Add(Me.AppOption_EnableLMSlot3)
        Me.UI_Tab06_Cat01_SubCat03.Controls.Add(Me.AppOption_LMslot3_SelectExecutable)
        Me.UI_Tab06_Cat01_SubCat03.Controls.Add(Me.AppOption_LMslot3_Path)
        Me.UI_Tab06_Cat01_SubCat03.Controls.Add(Me.Text_035)
        Me.UI_Tab06_Cat01_SubCat03.Controls.Add(Me.Text_033)
        Me.UI_Tab06_Cat01_SubCat03.Controls.Add(Me.AppOption_LMslot3_Name)
        Me.UI_Tab06_Cat01_SubCat03.Controls.Add(Me.AppOption_LMslot3_Version)
        Me.UI_Tab06_Cat01_SubCat03.Controls.Add(Me.Text_034)
        Me.UI_Tab06_Cat01_SubCat03.Name = "UI_Tab06_Cat01_SubCat03"
        Me.UI_Tab06_Cat01_SubCat03.TabStop = False
        '
        'AppOption_EnableHeaderMagicLMSlot3
        '
        resources.ApplyResources(Me.AppOption_EnableHeaderMagicLMSlot3, "AppOption_EnableHeaderMagicLMSlot3")
        Me.AppOption_EnableHeaderMagicLMSlot3.Name = "AppOption_EnableHeaderMagicLMSlot3"
        Me.AppOption_EnableHeaderMagicLMSlot3.UseVisualStyleBackColor = True
        '
        'AppOption_EnableLMSlot3
        '
        resources.ApplyResources(Me.AppOption_EnableLMSlot3, "AppOption_EnableLMSlot3")
        Me.AppOption_EnableLMSlot3.Name = "AppOption_EnableLMSlot3"
        Me.AppOption_EnableLMSlot3.UseVisualStyleBackColor = True
        '
        'AppOption_LMslot3_SelectExecutable
        '
        resources.ApplyResources(Me.AppOption_LMslot3_SelectExecutable, "AppOption_LMslot3_SelectExecutable")
        Me.AppOption_LMslot3_SelectExecutable.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_LMslot3_SelectExecutable.Name = "AppOption_LMslot3_SelectExecutable"
        Me.AppOption_LMslot3_SelectExecutable.TabStop = True
        '
        'AppOption_LMslot3_Path
        '
        resources.ApplyResources(Me.AppOption_LMslot3_Path, "AppOption_LMslot3_Path")
        Me.AppOption_LMslot3_Path.Name = "AppOption_LMslot3_Path"
        '
        'Text_035
        '
        resources.ApplyResources(Me.Text_035, "Text_035")
        Me.Text_035.Name = "Text_035"
        '
        'Text_033
        '
        resources.ApplyResources(Me.Text_033, "Text_033")
        Me.Text_033.Name = "Text_033"
        '
        'AppOption_LMslot3_Name
        '
        resources.ApplyResources(Me.AppOption_LMslot3_Name, "AppOption_LMslot3_Name")
        Me.AppOption_LMslot3_Name.Name = "AppOption_LMslot3_Name"
        '
        'AppOption_LMslot3_Version
        '
        resources.ApplyResources(Me.AppOption_LMslot3_Version, "AppOption_LMslot3_Version")
        Me.AppOption_LMslot3_Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_LMslot3_Version.FormattingEnabled = True
        Me.AppOption_LMslot3_Version.Items.AddRange(New Object() {resources.GetString("AppOption_LMslot3_Version.Items"), resources.GetString("AppOption_LMslot3_Version.Items1"), resources.GetString("AppOption_LMslot3_Version.Items2"), resources.GetString("AppOption_LMslot3_Version.Items3"), resources.GetString("AppOption_LMslot3_Version.Items4"), resources.GetString("AppOption_LMslot3_Version.Items5"), resources.GetString("AppOption_LMslot3_Version.Items6"), resources.GetString("AppOption_LMslot3_Version.Items7"), resources.GetString("AppOption_LMslot3_Version.Items8"), resources.GetString("AppOption_LMslot3_Version.Items9"), resources.GetString("AppOption_LMslot3_Version.Items10"), resources.GetString("AppOption_LMslot3_Version.Items11"), resources.GetString("AppOption_LMslot3_Version.Items12"), resources.GetString("AppOption_LMslot3_Version.Items13"), resources.GetString("AppOption_LMslot3_Version.Items14"), resources.GetString("AppOption_LMslot3_Version.Items15"), resources.GetString("AppOption_LMslot3_Version.Items16"), resources.GetString("AppOption_LMslot3_Version.Items17"), resources.GetString("AppOption_LMslot3_Version.Items18"), resources.GetString("AppOption_LMslot3_Version.Items19"), resources.GetString("AppOption_LMslot3_Version.Items20"), resources.GetString("AppOption_LMslot3_Version.Items21"), resources.GetString("AppOption_LMslot3_Version.Items22"), resources.GetString("AppOption_LMslot3_Version.Items23"), resources.GetString("AppOption_LMslot3_Version.Items24"), resources.GetString("AppOption_LMslot3_Version.Items25"), resources.GetString("AppOption_LMslot3_Version.Items26"), resources.GetString("AppOption_LMslot3_Version.Items27"), resources.GetString("AppOption_LMslot3_Version.Items28"), resources.GetString("AppOption_LMslot3_Version.Items29"), resources.GetString("AppOption_LMslot3_Version.Items30"), resources.GetString("AppOption_LMslot3_Version.Items31"), resources.GetString("AppOption_LMslot3_Version.Items32"), resources.GetString("AppOption_LMslot3_Version.Items33"), resources.GetString("AppOption_LMslot3_Version.Items34"), resources.GetString("AppOption_LMslot3_Version.Items35"), resources.GetString("AppOption_LMslot3_Version.Items36"), resources.GetString("AppOption_LMslot3_Version.Items37"), resources.GetString("AppOption_LMslot3_Version.Items38"), resources.GetString("AppOption_LMslot3_Version.Items39"), resources.GetString("AppOption_LMslot3_Version.Items40"), resources.GetString("AppOption_LMslot3_Version.Items41"), resources.GetString("AppOption_LMslot3_Version.Items42"), resources.GetString("AppOption_LMslot3_Version.Items43"), resources.GetString("AppOption_LMslot3_Version.Items44"), resources.GetString("AppOption_LMslot3_Version.Items45"), resources.GetString("AppOption_LMslot3_Version.Items46"), resources.GetString("AppOption_LMslot3_Version.Items47"), resources.GetString("AppOption_LMslot3_Version.Items48"), resources.GetString("AppOption_LMslot3_Version.Items49"), resources.GetString("AppOption_LMslot3_Version.Items50"), resources.GetString("AppOption_LMslot3_Version.Items51"), resources.GetString("AppOption_LMslot3_Version.Items52"), resources.GetString("AppOption_LMslot3_Version.Items53"), resources.GetString("AppOption_LMslot3_Version.Items54"), resources.GetString("AppOption_LMslot3_Version.Items55"), resources.GetString("AppOption_LMslot3_Version.Items56"), resources.GetString("AppOption_LMslot3_Version.Items57"), resources.GetString("AppOption_LMslot3_Version.Items58"), resources.GetString("AppOption_LMslot3_Version.Items59"), resources.GetString("AppOption_LMslot3_Version.Items60"), resources.GetString("AppOption_LMslot3_Version.Items61")})
        Me.AppOption_LMslot3_Version.Name = "AppOption_LMslot3_Version"
        '
        'Text_034
        '
        resources.ApplyResources(Me.Text_034, "Text_034")
        Me.Text_034.Name = "Text_034"
        '
        'UI_Tab06_Cat01_SubCat01
        '
        resources.ApplyResources(Me.UI_Tab06_Cat01_SubCat01, "UI_Tab06_Cat01_SubCat01")
        Me.UI_Tab06_Cat01_SubCat01.Controls.Add(Me.AppOption_EnableLMSlot1)
        Me.UI_Tab06_Cat01_SubCat01.Controls.Add(Me.AppOption_LMslot1_SelectExecutable)
        Me.UI_Tab06_Cat01_SubCat01.Controls.Add(Me.AppOption_EnableHeaderMagicLMSlot1)
        Me.UI_Tab06_Cat01_SubCat01.Controls.Add(Me.AppOption_LMslot1_Path)
        Me.UI_Tab06_Cat01_SubCat01.Controls.Add(Me.Text_029)
        Me.UI_Tab06_Cat01_SubCat01.Controls.Add(Me.Text_027)
        Me.UI_Tab06_Cat01_SubCat01.Controls.Add(Me.AppOption_LMslot1_Name)
        Me.UI_Tab06_Cat01_SubCat01.Controls.Add(Me.AppOption_LMslot1_Version)
        Me.UI_Tab06_Cat01_SubCat01.Controls.Add(Me.Text_028)
        Me.UI_Tab06_Cat01_SubCat01.Name = "UI_Tab06_Cat01_SubCat01"
        Me.UI_Tab06_Cat01_SubCat01.TabStop = False
        '
        'AppOption_EnableLMSlot1
        '
        resources.ApplyResources(Me.AppOption_EnableLMSlot1, "AppOption_EnableLMSlot1")
        Me.AppOption_EnableLMSlot1.Name = "AppOption_EnableLMSlot1"
        Me.AppOption_EnableLMSlot1.UseVisualStyleBackColor = True
        '
        'AppOption_LMslot1_SelectExecutable
        '
        resources.ApplyResources(Me.AppOption_LMslot1_SelectExecutable, "AppOption_LMslot1_SelectExecutable")
        Me.AppOption_LMslot1_SelectExecutable.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_LMslot1_SelectExecutable.Name = "AppOption_LMslot1_SelectExecutable"
        Me.AppOption_LMslot1_SelectExecutable.TabStop = True
        '
        'AppOption_EnableHeaderMagicLMSlot1
        '
        resources.ApplyResources(Me.AppOption_EnableHeaderMagicLMSlot1, "AppOption_EnableHeaderMagicLMSlot1")
        Me.AppOption_EnableHeaderMagicLMSlot1.Name = "AppOption_EnableHeaderMagicLMSlot1"
        Me.AppOption_EnableHeaderMagicLMSlot1.UseVisualStyleBackColor = True
        '
        'AppOption_LMslot1_Path
        '
        resources.ApplyResources(Me.AppOption_LMslot1_Path, "AppOption_LMslot1_Path")
        Me.AppOption_LMslot1_Path.Name = "AppOption_LMslot1_Path"
        '
        'Text_029
        '
        resources.ApplyResources(Me.Text_029, "Text_029")
        Me.Text_029.Name = "Text_029"
        '
        'Text_027
        '
        resources.ApplyResources(Me.Text_027, "Text_027")
        Me.Text_027.Name = "Text_027"
        '
        'AppOption_LMslot1_Name
        '
        resources.ApplyResources(Me.AppOption_LMslot1_Name, "AppOption_LMslot1_Name")
        Me.AppOption_LMslot1_Name.Name = "AppOption_LMslot1_Name"
        '
        'AppOption_LMslot1_Version
        '
        resources.ApplyResources(Me.AppOption_LMslot1_Version, "AppOption_LMslot1_Version")
        Me.AppOption_LMslot1_Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_LMslot1_Version.FormattingEnabled = True
        Me.AppOption_LMslot1_Version.Items.AddRange(New Object() {resources.GetString("AppOption_LMslot1_Version.Items"), resources.GetString("AppOption_LMslot1_Version.Items1"), resources.GetString("AppOption_LMslot1_Version.Items2"), resources.GetString("AppOption_LMslot1_Version.Items3"), resources.GetString("AppOption_LMslot1_Version.Items4"), resources.GetString("AppOption_LMslot1_Version.Items5"), resources.GetString("AppOption_LMslot1_Version.Items6"), resources.GetString("AppOption_LMslot1_Version.Items7"), resources.GetString("AppOption_LMslot1_Version.Items8"), resources.GetString("AppOption_LMslot1_Version.Items9"), resources.GetString("AppOption_LMslot1_Version.Items10"), resources.GetString("AppOption_LMslot1_Version.Items11"), resources.GetString("AppOption_LMslot1_Version.Items12"), resources.GetString("AppOption_LMslot1_Version.Items13"), resources.GetString("AppOption_LMslot1_Version.Items14"), resources.GetString("AppOption_LMslot1_Version.Items15"), resources.GetString("AppOption_LMslot1_Version.Items16"), resources.GetString("AppOption_LMslot1_Version.Items17"), resources.GetString("AppOption_LMslot1_Version.Items18"), resources.GetString("AppOption_LMslot1_Version.Items19"), resources.GetString("AppOption_LMslot1_Version.Items20"), resources.GetString("AppOption_LMslot1_Version.Items21"), resources.GetString("AppOption_LMslot1_Version.Items22"), resources.GetString("AppOption_LMslot1_Version.Items23"), resources.GetString("AppOption_LMslot1_Version.Items24"), resources.GetString("AppOption_LMslot1_Version.Items25"), resources.GetString("AppOption_LMslot1_Version.Items26"), resources.GetString("AppOption_LMslot1_Version.Items27"), resources.GetString("AppOption_LMslot1_Version.Items28"), resources.GetString("AppOption_LMslot1_Version.Items29"), resources.GetString("AppOption_LMslot1_Version.Items30"), resources.GetString("AppOption_LMslot1_Version.Items31"), resources.GetString("AppOption_LMslot1_Version.Items32"), resources.GetString("AppOption_LMslot1_Version.Items33"), resources.GetString("AppOption_LMslot1_Version.Items34"), resources.GetString("AppOption_LMslot1_Version.Items35"), resources.GetString("AppOption_LMslot1_Version.Items36"), resources.GetString("AppOption_LMslot1_Version.Items37"), resources.GetString("AppOption_LMslot1_Version.Items38"), resources.GetString("AppOption_LMslot1_Version.Items39"), resources.GetString("AppOption_LMslot1_Version.Items40"), resources.GetString("AppOption_LMslot1_Version.Items41"), resources.GetString("AppOption_LMslot1_Version.Items42"), resources.GetString("AppOption_LMslot1_Version.Items43"), resources.GetString("AppOption_LMslot1_Version.Items44"), resources.GetString("AppOption_LMslot1_Version.Items45"), resources.GetString("AppOption_LMslot1_Version.Items46"), resources.GetString("AppOption_LMslot1_Version.Items47"), resources.GetString("AppOption_LMslot1_Version.Items48"), resources.GetString("AppOption_LMslot1_Version.Items49"), resources.GetString("AppOption_LMslot1_Version.Items50"), resources.GetString("AppOption_LMslot1_Version.Items51"), resources.GetString("AppOption_LMslot1_Version.Items52"), resources.GetString("AppOption_LMslot1_Version.Items53"), resources.GetString("AppOption_LMslot1_Version.Items54"), resources.GetString("AppOption_LMslot1_Version.Items55"), resources.GetString("AppOption_LMslot1_Version.Items56"), resources.GetString("AppOption_LMslot1_Version.Items57"), resources.GetString("AppOption_LMslot1_Version.Items58"), resources.GetString("AppOption_LMslot1_Version.Items59"), resources.GetString("AppOption_LMslot1_Version.Items60"), resources.GetString("AppOption_LMslot1_Version.Items61")})
        Me.AppOption_LMslot1_Version.Name = "AppOption_LMslot1_Version"
        '
        'Text_028
        '
        resources.ApplyResources(Me.Text_028, "Text_028")
        Me.Text_028.Name = "Text_028"
        '
        'UI_Tab06_Cat01_SubCat02
        '
        resources.ApplyResources(Me.UI_Tab06_Cat01_SubCat02, "UI_Tab06_Cat01_SubCat02")
        Me.UI_Tab06_Cat01_SubCat02.Controls.Add(Me.AppOption_EnableHeaderMagicLMSlot2)
        Me.UI_Tab06_Cat01_SubCat02.Controls.Add(Me.AppOption_EnableLMSlot2)
        Me.UI_Tab06_Cat01_SubCat02.Controls.Add(Me.AppOption_LMslot2_SelectExecutable)
        Me.UI_Tab06_Cat01_SubCat02.Controls.Add(Me.AppOption_LMslot2_Path)
        Me.UI_Tab06_Cat01_SubCat02.Controls.Add(Me.Text_032)
        Me.UI_Tab06_Cat01_SubCat02.Controls.Add(Me.Text_030)
        Me.UI_Tab06_Cat01_SubCat02.Controls.Add(Me.AppOption_LMslot2_Name)
        Me.UI_Tab06_Cat01_SubCat02.Controls.Add(Me.AppOption_LMslot2_Version)
        Me.UI_Tab06_Cat01_SubCat02.Controls.Add(Me.Text_031)
        Me.UI_Tab06_Cat01_SubCat02.Name = "UI_Tab06_Cat01_SubCat02"
        Me.UI_Tab06_Cat01_SubCat02.TabStop = False
        '
        'AppOption_EnableHeaderMagicLMSlot2
        '
        resources.ApplyResources(Me.AppOption_EnableHeaderMagicLMSlot2, "AppOption_EnableHeaderMagicLMSlot2")
        Me.AppOption_EnableHeaderMagicLMSlot2.Name = "AppOption_EnableHeaderMagicLMSlot2"
        Me.AppOption_EnableHeaderMagicLMSlot2.UseVisualStyleBackColor = True
        '
        'AppOption_EnableLMSlot2
        '
        resources.ApplyResources(Me.AppOption_EnableLMSlot2, "AppOption_EnableLMSlot2")
        Me.AppOption_EnableLMSlot2.Name = "AppOption_EnableLMSlot2"
        Me.AppOption_EnableLMSlot2.UseVisualStyleBackColor = True
        '
        'AppOption_LMslot2_SelectExecutable
        '
        resources.ApplyResources(Me.AppOption_LMslot2_SelectExecutable, "AppOption_LMslot2_SelectExecutable")
        Me.AppOption_LMslot2_SelectExecutable.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_LMslot2_SelectExecutable.Name = "AppOption_LMslot2_SelectExecutable"
        Me.AppOption_LMslot2_SelectExecutable.TabStop = True
        '
        'AppOption_LMslot2_Path
        '
        resources.ApplyResources(Me.AppOption_LMslot2_Path, "AppOption_LMslot2_Path")
        Me.AppOption_LMslot2_Path.Name = "AppOption_LMslot2_Path"
        '
        'Text_032
        '
        resources.ApplyResources(Me.Text_032, "Text_032")
        Me.Text_032.Name = "Text_032"
        '
        'Text_030
        '
        resources.ApplyResources(Me.Text_030, "Text_030")
        Me.Text_030.Name = "Text_030"
        '
        'AppOption_LMslot2_Name
        '
        resources.ApplyResources(Me.AppOption_LMslot2_Name, "AppOption_LMslot2_Name")
        Me.AppOption_LMslot2_Name.Name = "AppOption_LMslot2_Name"
        '
        'AppOption_LMslot2_Version
        '
        resources.ApplyResources(Me.AppOption_LMslot2_Version, "AppOption_LMslot2_Version")
        Me.AppOption_LMslot2_Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_LMslot2_Version.FormattingEnabled = True
        Me.AppOption_LMslot2_Version.Items.AddRange(New Object() {resources.GetString("AppOption_LMslot2_Version.Items"), resources.GetString("AppOption_LMslot2_Version.Items1"), resources.GetString("AppOption_LMslot2_Version.Items2"), resources.GetString("AppOption_LMslot2_Version.Items3"), resources.GetString("AppOption_LMslot2_Version.Items4"), resources.GetString("AppOption_LMslot2_Version.Items5"), resources.GetString("AppOption_LMslot2_Version.Items6"), resources.GetString("AppOption_LMslot2_Version.Items7"), resources.GetString("AppOption_LMslot2_Version.Items8"), resources.GetString("AppOption_LMslot2_Version.Items9"), resources.GetString("AppOption_LMslot2_Version.Items10"), resources.GetString("AppOption_LMslot2_Version.Items11"), resources.GetString("AppOption_LMslot2_Version.Items12"), resources.GetString("AppOption_LMslot2_Version.Items13"), resources.GetString("AppOption_LMslot2_Version.Items14"), resources.GetString("AppOption_LMslot2_Version.Items15"), resources.GetString("AppOption_LMslot2_Version.Items16"), resources.GetString("AppOption_LMslot2_Version.Items17"), resources.GetString("AppOption_LMslot2_Version.Items18"), resources.GetString("AppOption_LMslot2_Version.Items19"), resources.GetString("AppOption_LMslot2_Version.Items20"), resources.GetString("AppOption_LMslot2_Version.Items21"), resources.GetString("AppOption_LMslot2_Version.Items22"), resources.GetString("AppOption_LMslot2_Version.Items23"), resources.GetString("AppOption_LMslot2_Version.Items24"), resources.GetString("AppOption_LMslot2_Version.Items25"), resources.GetString("AppOption_LMslot2_Version.Items26"), resources.GetString("AppOption_LMslot2_Version.Items27"), resources.GetString("AppOption_LMslot2_Version.Items28"), resources.GetString("AppOption_LMslot2_Version.Items29"), resources.GetString("AppOption_LMslot2_Version.Items30"), resources.GetString("AppOption_LMslot2_Version.Items31"), resources.GetString("AppOption_LMslot2_Version.Items32"), resources.GetString("AppOption_LMslot2_Version.Items33"), resources.GetString("AppOption_LMslot2_Version.Items34"), resources.GetString("AppOption_LMslot2_Version.Items35"), resources.GetString("AppOption_LMslot2_Version.Items36"), resources.GetString("AppOption_LMslot2_Version.Items37"), resources.GetString("AppOption_LMslot2_Version.Items38"), resources.GetString("AppOption_LMslot2_Version.Items39"), resources.GetString("AppOption_LMslot2_Version.Items40"), resources.GetString("AppOption_LMslot2_Version.Items41"), resources.GetString("AppOption_LMslot2_Version.Items42"), resources.GetString("AppOption_LMslot2_Version.Items43"), resources.GetString("AppOption_LMslot2_Version.Items44"), resources.GetString("AppOption_LMslot2_Version.Items45"), resources.GetString("AppOption_LMslot2_Version.Items46"), resources.GetString("AppOption_LMslot2_Version.Items47"), resources.GetString("AppOption_LMslot2_Version.Items48"), resources.GetString("AppOption_LMslot2_Version.Items49"), resources.GetString("AppOption_LMslot2_Version.Items50"), resources.GetString("AppOption_LMslot2_Version.Items51"), resources.GetString("AppOption_LMslot2_Version.Items52"), resources.GetString("AppOption_LMslot2_Version.Items53"), resources.GetString("AppOption_LMslot2_Version.Items54"), resources.GetString("AppOption_LMslot2_Version.Items55"), resources.GetString("AppOption_LMslot2_Version.Items56"), resources.GetString("AppOption_LMslot2_Version.Items57"), resources.GetString("AppOption_LMslot2_Version.Items58"), resources.GetString("AppOption_LMslot2_Version.Items59"), resources.GetString("AppOption_LMslot2_Version.Items60"), resources.GetString("AppOption_LMslot2_Version.Items61")})
        Me.AppOption_LMslot2_Version.Name = "AppOption_LMslot2_Version"
        '
        'Text_031
        '
        resources.ApplyResources(Me.Text_031, "Text_031")
        Me.Text_031.Name = "Text_031"
        '
        'UI_Tab06_Tab02_Snes9xBsnes
        '
        Me.UI_Tab06_Tab02_Snes9xBsnes.Controls.Add(Me.UI_Tab06_Cat02_SubCat03)
        Me.UI_Tab06_Tab02_Snes9xBsnes.Controls.Add(Me.UI_Tab06_Cat02_SubCat02)
        Me.UI_Tab06_Tab02_Snes9xBsnes.Controls.Add(Me.UI_Tab06_Cat02_SubCat01)
        resources.ApplyResources(Me.UI_Tab06_Tab02_Snes9xBsnes, "UI_Tab06_Tab02_Snes9xBsnes")
        Me.UI_Tab06_Tab02_Snes9xBsnes.Name = "UI_Tab06_Tab02_Snes9xBsnes"
        Me.UI_Tab06_Tab02_Snes9xBsnes.UseVisualStyleBackColor = True
        '
        'UI_Tab06_Cat02_SubCat03
        '
        resources.ApplyResources(Me.UI_Tab06_Cat02_SubCat03, "UI_Tab06_Cat02_SubCat03")
        Me.UI_Tab06_Cat02_SubCat03.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat02_SubCat03.Controls.Add(Me.AppOption_SelectBsnesExecutable)
        Me.UI_Tab06_Cat02_SubCat03.Controls.Add(Me.Text_041)
        Me.UI_Tab06_Cat02_SubCat03.Controls.Add(Me.AppOption_BsnesExecutable)
        Me.UI_Tab06_Cat02_SubCat03.Name = "UI_Tab06_Cat02_SubCat03"
        Me.UI_Tab06_Cat02_SubCat03.TabStop = False
        '
        'AppOption_SelectBsnesExecutable
        '
        resources.ApplyResources(Me.AppOption_SelectBsnesExecutable, "AppOption_SelectBsnesExecutable")
        Me.AppOption_SelectBsnesExecutable.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_SelectBsnesExecutable.Name = "AppOption_SelectBsnesExecutable"
        Me.AppOption_SelectBsnesExecutable.TabStop = True
        '
        'Text_041
        '
        resources.ApplyResources(Me.Text_041, "Text_041")
        Me.Text_041.Name = "Text_041"
        '
        'AppOption_BsnesExecutable
        '
        resources.ApplyResources(Me.AppOption_BsnesExecutable, "AppOption_BsnesExecutable")
        Me.AppOption_BsnesExecutable.Name = "AppOption_BsnesExecutable"
        '
        'UI_Tab06_Cat02_SubCat02
        '
        resources.ApplyResources(Me.UI_Tab06_Cat02_SubCat02, "UI_Tab06_Cat02_SubCat02")
        Me.UI_Tab06_Cat02_SubCat02.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat02_SubCat02.Controls.Add(Me.Text_040)
        Me.UI_Tab06_Cat02_SubCat02.Controls.Add(Me.AppOption_Snes9x_SelectedArch)
        Me.UI_Tab06_Cat02_SubCat02.Controls.Add(Me.AppOption_Snes9x_Selectx64Executable)
        Me.UI_Tab06_Cat02_SubCat02.Controls.Add(Me.AppOption_Snes9x_Selectx86Executable)
        Me.UI_Tab06_Cat02_SubCat02.Controls.Add(Me.Text_039)
        Me.UI_Tab06_Cat02_SubCat02.Controls.Add(Me.AppOption_Snes9x_UseColoredIcon)
        Me.UI_Tab06_Cat02_SubCat02.Controls.Add(Me.AppOption_Snes9x_x64Executable)
        Me.UI_Tab06_Cat02_SubCat02.Controls.Add(Me.Text_038)
        Me.UI_Tab06_Cat02_SubCat02.Controls.Add(Me.AppOption_Snes9x_x86Executable)
        Me.UI_Tab06_Cat02_SubCat02.Name = "UI_Tab06_Cat02_SubCat02"
        Me.UI_Tab06_Cat02_SubCat02.TabStop = False
        '
        'Text_040
        '
        resources.ApplyResources(Me.Text_040, "Text_040")
        Me.Text_040.Name = "Text_040"
        '
        'AppOption_Snes9x_SelectedArch
        '
        Me.AppOption_Snes9x_SelectedArch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_Snes9x_SelectedArch.FormattingEnabled = True
        Me.AppOption_Snes9x_SelectedArch.Items.AddRange(New Object() {resources.GetString("AppOption_Snes9x_SelectedArch.Items"), resources.GetString("AppOption_Snes9x_SelectedArch.Items1")})
        resources.ApplyResources(Me.AppOption_Snes9x_SelectedArch, "AppOption_Snes9x_SelectedArch")
        Me.AppOption_Snes9x_SelectedArch.Name = "AppOption_Snes9x_SelectedArch"
        '
        'AppOption_Snes9x_Selectx64Executable
        '
        resources.ApplyResources(Me.AppOption_Snes9x_Selectx64Executable, "AppOption_Snes9x_Selectx64Executable")
        Me.AppOption_Snes9x_Selectx64Executable.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_Snes9x_Selectx64Executable.Name = "AppOption_Snes9x_Selectx64Executable"
        Me.AppOption_Snes9x_Selectx64Executable.TabStop = True
        '
        'AppOption_Snes9x_Selectx86Executable
        '
        resources.ApplyResources(Me.AppOption_Snes9x_Selectx86Executable, "AppOption_Snes9x_Selectx86Executable")
        Me.AppOption_Snes9x_Selectx86Executable.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_Snes9x_Selectx86Executable.Name = "AppOption_Snes9x_Selectx86Executable"
        Me.AppOption_Snes9x_Selectx86Executable.TabStop = True
        '
        'Text_039
        '
        resources.ApplyResources(Me.Text_039, "Text_039")
        Me.Text_039.Name = "Text_039"
        '
        'AppOption_Snes9x_UseColoredIcon
        '
        resources.ApplyResources(Me.AppOption_Snes9x_UseColoredIcon, "AppOption_Snes9x_UseColoredIcon")
        Me.AppOption_Snes9x_UseColoredIcon.Name = "AppOption_Snes9x_UseColoredIcon"
        Me.AppOption_Snes9x_UseColoredIcon.UseVisualStyleBackColor = True
        '
        'AppOption_Snes9x_x64Executable
        '
        resources.ApplyResources(Me.AppOption_Snes9x_x64Executable, "AppOption_Snes9x_x64Executable")
        Me.AppOption_Snes9x_x64Executable.Name = "AppOption_Snes9x_x64Executable"
        '
        'Text_038
        '
        resources.ApplyResources(Me.Text_038, "Text_038")
        Me.Text_038.Name = "Text_038"
        '
        'AppOption_Snes9x_x86Executable
        '
        resources.ApplyResources(Me.AppOption_Snes9x_x86Executable, "AppOption_Snes9x_x86Executable")
        Me.AppOption_Snes9x_x86Executable.Name = "AppOption_Snes9x_x86Executable"
        '
        'UI_Tab06_Cat02_SubCat01
        '
        resources.ApplyResources(Me.UI_Tab06_Cat02_SubCat01, "UI_Tab06_Cat02_SubCat01")
        Me.UI_Tab06_Cat02_SubCat01.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat02_SubCat01.Controls.Add(Me.Text_037)
        Me.UI_Tab06_Cat02_SubCat01.Controls.Add(Me.AppOption_SnesEmuSelector)
        Me.UI_Tab06_Cat02_SubCat01.Name = "UI_Tab06_Cat02_SubCat01"
        Me.UI_Tab06_Cat02_SubCat01.TabStop = False
        '
        'Text_037
        '
        resources.ApplyResources(Me.Text_037, "Text_037")
        Me.Text_037.Name = "Text_037"
        '
        'AppOption_SnesEmuSelector
        '
        Me.AppOption_SnesEmuSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AppOption_SnesEmuSelector.FormattingEnabled = True
        Me.AppOption_SnesEmuSelector.Items.AddRange(New Object() {resources.GetString("AppOption_SnesEmuSelector.Items"), resources.GetString("AppOption_SnesEmuSelector.Items1"), resources.GetString("AppOption_SnesEmuSelector.Items2")})
        resources.ApplyResources(Me.AppOption_SnesEmuSelector, "AppOption_SnesEmuSelector")
        Me.AppOption_SnesEmuSelector.Name = "AppOption_SnesEmuSelector"
        '
        'UI_Tab06_Tab03_SmallHackerTools
        '
        Me.UI_Tab06_Tab03_SmallHackerTools.Controls.Add(Me.UI_Tab06_Cat03_SubCat04)
        Me.UI_Tab06_Tab03_SmallHackerTools.Controls.Add(Me.UI_Tab06_Cat03_SubCat01)
        Me.UI_Tab06_Tab03_SmallHackerTools.Controls.Add(Me.UI_Tab06_Cat03_SubCat10)
        Me.UI_Tab06_Tab03_SmallHackerTools.Controls.Add(Me.UI_Tab06_Cat03_SubCat09)
        Me.UI_Tab06_Tab03_SmallHackerTools.Controls.Add(Me.UI_Tab06_Cat03_SubCat08)
        Me.UI_Tab06_Tab03_SmallHackerTools.Controls.Add(Me.UI_Tab06_Cat03_SubCat03)
        Me.UI_Tab06_Tab03_SmallHackerTools.Controls.Add(Me.UI_Tab06_Cat03_SubCat07)
        Me.UI_Tab06_Tab03_SmallHackerTools.Controls.Add(Me.UI_Tab06_Cat03_SubCat02)
        resources.ApplyResources(Me.UI_Tab06_Tab03_SmallHackerTools, "UI_Tab06_Tab03_SmallHackerTools")
        Me.UI_Tab06_Tab03_SmallHackerTools.Name = "UI_Tab06_Tab03_SmallHackerTools"
        Me.UI_Tab06_Tab03_SmallHackerTools.UseVisualStyleBackColor = True
        '
        'UI_Tab06_Cat03_SubCat04
        '
        resources.ApplyResources(Me.UI_Tab06_Cat03_SubCat04, "UI_Tab06_Cat03_SubCat04")
        Me.UI_Tab06_Cat03_SubCat04.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat03_SubCat04.Controls.Add(Me.UI_Tab06_Cat03_SubCat05)
        Me.UI_Tab06_Cat03_SubCat04.Controls.Add(Me.UI_Tab06_Cat03_SubCat06)
        Me.UI_Tab06_Cat03_SubCat04.Name = "UI_Tab06_Cat03_SubCat04"
        Me.UI_Tab06_Cat03_SubCat04.TabStop = False
        '
        'UI_Tab06_Cat03_SubCat05
        '
        resources.ApplyResources(Me.UI_Tab06_Cat03_SubCat05, "UI_Tab06_Cat03_SubCat05")
        Me.UI_Tab06_Cat03_SubCat05.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat03_SubCat05.Controls.Add(Me.AppOption_SMWENI_SelectPath)
        Me.UI_Tab06_Cat03_SubCat05.Controls.Add(Me.Text_045)
        Me.UI_Tab06_Cat03_SubCat05.Controls.Add(Me.AppOption_SMWENI_Path)
        Me.UI_Tab06_Cat03_SubCat05.Name = "UI_Tab06_Cat03_SubCat05"
        Me.UI_Tab06_Cat03_SubCat05.TabStop = False
        '
        'AppOption_SMWENI_SelectPath
        '
        resources.ApplyResources(Me.AppOption_SMWENI_SelectPath, "AppOption_SMWENI_SelectPath")
        Me.AppOption_SMWENI_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_SMWENI_SelectPath.Name = "AppOption_SMWENI_SelectPath"
        Me.AppOption_SMWENI_SelectPath.TabStop = True
        '
        'Text_045
        '
        resources.ApplyResources(Me.Text_045, "Text_045")
        Me.Text_045.Name = "Text_045"
        '
        'AppOption_SMWENI_Path
        '
        resources.ApplyResources(Me.AppOption_SMWENI_Path, "AppOption_SMWENI_Path")
        Me.AppOption_SMWENI_Path.Name = "AppOption_SMWENI_Path"
        '
        'UI_Tab06_Cat03_SubCat06
        '
        resources.ApplyResources(Me.UI_Tab06_Cat03_SubCat06, "UI_Tab06_Cat03_SubCat06")
        Me.UI_Tab06_Cat03_SubCat06.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat03_SubCat06.Controls.Add(Me.AppOption_SMWENE_SelectPath)
        Me.UI_Tab06_Cat03_SubCat06.Controls.Add(Me.Text_046)
        Me.UI_Tab06_Cat03_SubCat06.Controls.Add(Me.AppOption_SMWENE_Path)
        Me.UI_Tab06_Cat03_SubCat06.Name = "UI_Tab06_Cat03_SubCat06"
        Me.UI_Tab06_Cat03_SubCat06.TabStop = False
        '
        'AppOption_SMWENE_SelectPath
        '
        resources.ApplyResources(Me.AppOption_SMWENE_SelectPath, "AppOption_SMWENE_SelectPath")
        Me.AppOption_SMWENE_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_SMWENE_SelectPath.Name = "AppOption_SMWENE_SelectPath"
        Me.AppOption_SMWENE_SelectPath.TabStop = True
        '
        'Text_046
        '
        resources.ApplyResources(Me.Text_046, "Text_046")
        Me.Text_046.Name = "Text_046"
        '
        'AppOption_SMWENE_Path
        '
        resources.ApplyResources(Me.AppOption_SMWENE_Path, "AppOption_SMWENE_Path")
        Me.AppOption_SMWENE_Path.Name = "AppOption_SMWENE_Path"
        '
        'UI_Tab06_Cat03_SubCat01
        '
        resources.ApplyResources(Me.UI_Tab06_Cat03_SubCat01, "UI_Tab06_Cat03_SubCat01")
        Me.UI_Tab06_Cat03_SubCat01.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat03_SubCat01.Controls.Add(Me.Text_042)
        Me.UI_Tab06_Cat03_SubCat01.Controls.Add(Me.AppOption_DisplayBtn_SMWTYMI)
        Me.UI_Tab06_Cat03_SubCat01.Controls.Add(Me.AppOption_DisplayBtn_SMWSBE)
        Me.UI_Tab06_Cat03_SubCat01.Controls.Add(Me.AppOption_DisplayBtn_SMWPTE)
        Me.UI_Tab06_Cat03_SubCat01.Controls.Add(Me.AppOption_DisplayBtn_SMWMTE)
        Me.UI_Tab06_Cat03_SubCat01.Controls.Add(Me.AppOption_DisplayBtn_SMWENE)
        Me.UI_Tab06_Cat03_SubCat01.Controls.Add(Me.AppOption_DisplayBtn_SMWENI)
        Me.UI_Tab06_Cat03_SubCat01.Controls.Add(Me.AppOption_DisplayBtn_SMWBBPE)
        Me.UI_Tab06_Cat03_SubCat01.Controls.Add(Me.AppOption_DisplayBtn_ILBPE)
        Me.UI_Tab06_Cat03_SubCat01.Name = "UI_Tab06_Cat03_SubCat01"
        Me.UI_Tab06_Cat03_SubCat01.TabStop = False
        '
        'Text_042
        '
        resources.ApplyResources(Me.Text_042, "Text_042")
        Me.Text_042.Name = "Text_042"
        '
        'AppOption_DisplayBtn_SMWTYMI
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_SMWTYMI, "AppOption_DisplayBtn_SMWTYMI")
        Me.AppOption_DisplayBtn_SMWTYMI.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Smallhacker_SMWTYMI
        Me.AppOption_DisplayBtn_SMWTYMI.Name = "AppOption_DisplayBtn_SMWTYMI"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_SMWTYMI, resources.GetString("AppOption_DisplayBtn_SMWTYMI.ToolTip"))
        Me.AppOption_DisplayBtn_SMWTYMI.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_SMWSBE
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_SMWSBE, "AppOption_DisplayBtn_SMWSBE")
        Me.AppOption_DisplayBtn_SMWSBE.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Smallhacker_SMWSBE
        Me.AppOption_DisplayBtn_SMWSBE.Name = "AppOption_DisplayBtn_SMWSBE"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_SMWSBE, resources.GetString("AppOption_DisplayBtn_SMWSBE.ToolTip"))
        Me.AppOption_DisplayBtn_SMWSBE.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_SMWPTE
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_SMWPTE, "AppOption_DisplayBtn_SMWPTE")
        Me.AppOption_DisplayBtn_SMWPTE.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Smallhacker_SMWPTE
        Me.AppOption_DisplayBtn_SMWPTE.Name = "AppOption_DisplayBtn_SMWPTE"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_SMWPTE, resources.GetString("AppOption_DisplayBtn_SMWPTE.ToolTip"))
        Me.AppOption_DisplayBtn_SMWPTE.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_SMWMTE
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_SMWMTE, "AppOption_DisplayBtn_SMWMTE")
        Me.AppOption_DisplayBtn_SMWMTE.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Smallhacker_SMWMTE
        Me.AppOption_DisplayBtn_SMWMTE.Name = "AppOption_DisplayBtn_SMWMTE"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_SMWMTE, resources.GetString("AppOption_DisplayBtn_SMWMTE.ToolTip"))
        Me.AppOption_DisplayBtn_SMWMTE.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_SMWENE
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_SMWENE, "AppOption_DisplayBtn_SMWENE")
        Me.AppOption_DisplayBtn_SMWENE.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Smallhacker_SMWEN_E
        Me.AppOption_DisplayBtn_SMWENE.Name = "AppOption_DisplayBtn_SMWENE"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_SMWENE, resources.GetString("AppOption_DisplayBtn_SMWENE.ToolTip"))
        Me.AppOption_DisplayBtn_SMWENE.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_SMWENI
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_SMWENI, "AppOption_DisplayBtn_SMWENI")
        Me.AppOption_DisplayBtn_SMWENI.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Smallhacker_SMWEN_I
        Me.AppOption_DisplayBtn_SMWENI.Name = "AppOption_DisplayBtn_SMWENI"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_SMWENI, resources.GetString("AppOption_DisplayBtn_SMWENI.ToolTip"))
        Me.AppOption_DisplayBtn_SMWENI.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_SMWBBPE
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_SMWBBPE, "AppOption_DisplayBtn_SMWBBPE")
        Me.AppOption_DisplayBtn_SMWBBPE.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Smallhacker_SMWBBPE
        Me.AppOption_DisplayBtn_SMWBBPE.Name = "AppOption_DisplayBtn_SMWBBPE"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_SMWBBPE, resources.GetString("AppOption_DisplayBtn_SMWBBPE.ToolTip"))
        Me.AppOption_DisplayBtn_SMWBBPE.UseVisualStyleBackColor = True
        '
        'AppOption_DisplayBtn_ILBPE
        '
        resources.ApplyResources(Me.AppOption_DisplayBtn_ILBPE, "AppOption_DisplayBtn_ILBPE")
        Me.AppOption_DisplayBtn_ILBPE.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Smallhacker_LIBPE
        Me.AppOption_DisplayBtn_ILBPE.Name = "AppOption_DisplayBtn_ILBPE"
        Me.AppNames_HideBtnSettings.SetToolTip(Me.AppOption_DisplayBtn_ILBPE, resources.GetString("AppOption_DisplayBtn_ILBPE.ToolTip"))
        Me.AppOption_DisplayBtn_ILBPE.UseVisualStyleBackColor = True
        '
        'UI_Tab06_Cat03_SubCat10
        '
        resources.ApplyResources(Me.UI_Tab06_Cat03_SubCat10, "UI_Tab06_Cat03_SubCat10")
        Me.UI_Tab06_Cat03_SubCat10.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat03_SubCat10.Controls.Add(Me.AppOption_SMWTYMI_SelectPath)
        Me.UI_Tab06_Cat03_SubCat10.Controls.Add(Me.Text_050)
        Me.UI_Tab06_Cat03_SubCat10.Controls.Add(Me.AppOption_SMWTYMI_Path)
        Me.UI_Tab06_Cat03_SubCat10.Name = "UI_Tab06_Cat03_SubCat10"
        Me.UI_Tab06_Cat03_SubCat10.TabStop = False
        '
        'AppOption_SMWTYMI_SelectPath
        '
        resources.ApplyResources(Me.AppOption_SMWTYMI_SelectPath, "AppOption_SMWTYMI_SelectPath")
        Me.AppOption_SMWTYMI_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_SMWTYMI_SelectPath.Name = "AppOption_SMWTYMI_SelectPath"
        Me.AppOption_SMWTYMI_SelectPath.TabStop = True
        '
        'Text_050
        '
        resources.ApplyResources(Me.Text_050, "Text_050")
        Me.Text_050.Name = "Text_050"
        '
        'AppOption_SMWTYMI_Path
        '
        resources.ApplyResources(Me.AppOption_SMWTYMI_Path, "AppOption_SMWTYMI_Path")
        Me.AppOption_SMWTYMI_Path.Name = "AppOption_SMWTYMI_Path"
        '
        'UI_Tab06_Cat03_SubCat09
        '
        resources.ApplyResources(Me.UI_Tab06_Cat03_SubCat09, "UI_Tab06_Cat03_SubCat09")
        Me.UI_Tab06_Cat03_SubCat09.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat03_SubCat09.Controls.Add(Me.AppOption_SMWSBE_SelectPath)
        Me.UI_Tab06_Cat03_SubCat09.Controls.Add(Me.Text_049)
        Me.UI_Tab06_Cat03_SubCat09.Controls.Add(Me.AppOption_SMWSBE_Path)
        Me.UI_Tab06_Cat03_SubCat09.Name = "UI_Tab06_Cat03_SubCat09"
        Me.UI_Tab06_Cat03_SubCat09.TabStop = False
        '
        'AppOption_SMWSBE_SelectPath
        '
        resources.ApplyResources(Me.AppOption_SMWSBE_SelectPath, "AppOption_SMWSBE_SelectPath")
        Me.AppOption_SMWSBE_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_SMWSBE_SelectPath.Name = "AppOption_SMWSBE_SelectPath"
        Me.AppOption_SMWSBE_SelectPath.TabStop = True
        '
        'Text_049
        '
        resources.ApplyResources(Me.Text_049, "Text_049")
        Me.Text_049.Name = "Text_049"
        '
        'AppOption_SMWSBE_Path
        '
        resources.ApplyResources(Me.AppOption_SMWSBE_Path, "AppOption_SMWSBE_Path")
        Me.AppOption_SMWSBE_Path.Name = "AppOption_SMWSBE_Path"
        '
        'UI_Tab06_Cat03_SubCat08
        '
        resources.ApplyResources(Me.UI_Tab06_Cat03_SubCat08, "UI_Tab06_Cat03_SubCat08")
        Me.UI_Tab06_Cat03_SubCat08.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat03_SubCat08.Controls.Add(Me.AppOption_SMWPTE_SelectPath)
        Me.UI_Tab06_Cat03_SubCat08.Controls.Add(Me.Text_048)
        Me.UI_Tab06_Cat03_SubCat08.Controls.Add(Me.AppOption_SMWPTE_Path)
        Me.UI_Tab06_Cat03_SubCat08.Name = "UI_Tab06_Cat03_SubCat08"
        Me.UI_Tab06_Cat03_SubCat08.TabStop = False
        '
        'AppOption_SMWPTE_SelectPath
        '
        resources.ApplyResources(Me.AppOption_SMWPTE_SelectPath, "AppOption_SMWPTE_SelectPath")
        Me.AppOption_SMWPTE_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_SMWPTE_SelectPath.Name = "AppOption_SMWPTE_SelectPath"
        Me.AppOption_SMWPTE_SelectPath.TabStop = True
        '
        'Text_048
        '
        resources.ApplyResources(Me.Text_048, "Text_048")
        Me.Text_048.Name = "Text_048"
        '
        'AppOption_SMWPTE_Path
        '
        resources.ApplyResources(Me.AppOption_SMWPTE_Path, "AppOption_SMWPTE_Path")
        Me.AppOption_SMWPTE_Path.Name = "AppOption_SMWPTE_Path"
        '
        'UI_Tab06_Cat03_SubCat03
        '
        resources.ApplyResources(Me.UI_Tab06_Cat03_SubCat03, "UI_Tab06_Cat03_SubCat03")
        Me.UI_Tab06_Cat03_SubCat03.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat03_SubCat03.Controls.Add(Me.AppOption_SMWBBPE_SelectPath)
        Me.UI_Tab06_Cat03_SubCat03.Controls.Add(Me.Text_044)
        Me.UI_Tab06_Cat03_SubCat03.Controls.Add(Me.AppOption_SMWBBPE_Path)
        Me.UI_Tab06_Cat03_SubCat03.Name = "UI_Tab06_Cat03_SubCat03"
        Me.UI_Tab06_Cat03_SubCat03.TabStop = False
        '
        'AppOption_SMWBBPE_SelectPath
        '
        resources.ApplyResources(Me.AppOption_SMWBBPE_SelectPath, "AppOption_SMWBBPE_SelectPath")
        Me.AppOption_SMWBBPE_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_SMWBBPE_SelectPath.Name = "AppOption_SMWBBPE_SelectPath"
        Me.AppOption_SMWBBPE_SelectPath.TabStop = True
        '
        'Text_044
        '
        resources.ApplyResources(Me.Text_044, "Text_044")
        Me.Text_044.Name = "Text_044"
        '
        'AppOption_SMWBBPE_Path
        '
        resources.ApplyResources(Me.AppOption_SMWBBPE_Path, "AppOption_SMWBBPE_Path")
        Me.AppOption_SMWBBPE_Path.Name = "AppOption_SMWBBPE_Path"
        '
        'UI_Tab06_Cat03_SubCat07
        '
        resources.ApplyResources(Me.UI_Tab06_Cat03_SubCat07, "UI_Tab06_Cat03_SubCat07")
        Me.UI_Tab06_Cat03_SubCat07.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat03_SubCat07.Controls.Add(Me.AppOption_SMWMTE_SelectPath)
        Me.UI_Tab06_Cat03_SubCat07.Controls.Add(Me.Text_047)
        Me.UI_Tab06_Cat03_SubCat07.Controls.Add(Me.AppOption_SMWMTE_Path)
        Me.UI_Tab06_Cat03_SubCat07.Name = "UI_Tab06_Cat03_SubCat07"
        Me.UI_Tab06_Cat03_SubCat07.TabStop = False
        '
        'AppOption_SMWMTE_SelectPath
        '
        resources.ApplyResources(Me.AppOption_SMWMTE_SelectPath, "AppOption_SMWMTE_SelectPath")
        Me.AppOption_SMWMTE_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_SMWMTE_SelectPath.Name = "AppOption_SMWMTE_SelectPath"
        Me.AppOption_SMWMTE_SelectPath.TabStop = True
        '
        'Text_047
        '
        resources.ApplyResources(Me.Text_047, "Text_047")
        Me.Text_047.Name = "Text_047"
        '
        'AppOption_SMWMTE_Path
        '
        resources.ApplyResources(Me.AppOption_SMWMTE_Path, "AppOption_SMWMTE_Path")
        Me.AppOption_SMWMTE_Path.Name = "AppOption_SMWMTE_Path"
        '
        'UI_Tab06_Cat03_SubCat02
        '
        resources.ApplyResources(Me.UI_Tab06_Cat03_SubCat02, "UI_Tab06_Cat03_SubCat02")
        Me.UI_Tab06_Cat03_SubCat02.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat03_SubCat02.Controls.Add(Me.AppOption_ILBPE_SelectPath)
        Me.UI_Tab06_Cat03_SubCat02.Controls.Add(Me.Text_043)
        Me.UI_Tab06_Cat03_SubCat02.Controls.Add(Me.AppOption_ILBPE_Path)
        Me.UI_Tab06_Cat03_SubCat02.Name = "UI_Tab06_Cat03_SubCat02"
        Me.UI_Tab06_Cat03_SubCat02.TabStop = False
        '
        'AppOption_ILBPE_SelectPath
        '
        resources.ApplyResources(Me.AppOption_ILBPE_SelectPath, "AppOption_ILBPE_SelectPath")
        Me.AppOption_ILBPE_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_ILBPE_SelectPath.Name = "AppOption_ILBPE_SelectPath"
        Me.AppOption_ILBPE_SelectPath.TabStop = True
        '
        'Text_043
        '
        resources.ApplyResources(Me.Text_043, "Text_043")
        Me.Text_043.Name = "Text_043"
        '
        'AppOption_ILBPE_Path
        '
        resources.ApplyResources(Me.AppOption_ILBPE_Path, "AppOption_ILBPE_Path")
        Me.AppOption_ILBPE_Path.Name = "AppOption_ILBPE_Path"
        '
        'UI_Tab06_Tab04_OtherApps1
        '
        Me.UI_Tab06_Tab04_OtherApps1.Controls.Add(Me.UI_Tab06_Cat04_SubCat10)
        Me.UI_Tab06_Tab04_OtherApps1.Controls.Add(Me.UI_Tab06_Cat04_SubCat09)
        Me.UI_Tab06_Tab04_OtherApps1.Controls.Add(Me.UI_Tab06_Cat04_SubCat08)
        Me.UI_Tab06_Tab04_OtherApps1.Controls.Add(Me.UI_Tab06_Cat04_SubCat07)
        Me.UI_Tab06_Tab04_OtherApps1.Controls.Add(Me.UI_Tab06_Cat04_SubCat06)
        Me.UI_Tab06_Tab04_OtherApps1.Controls.Add(Me.UI_Tab06_Cat04_SubCat05)
        Me.UI_Tab06_Tab04_OtherApps1.Controls.Add(Me.UI_Tab06_Cat04_SubCat04)
        Me.UI_Tab06_Tab04_OtherApps1.Controls.Add(Me.UI_Tab06_Cat04_SubCat03)
        Me.UI_Tab06_Tab04_OtherApps1.Controls.Add(Me.UI_Tab06_Cat04_SubCat02)
        Me.UI_Tab06_Tab04_OtherApps1.Controls.Add(Me.UI_Tab06_Cat04_SubCat01)
        resources.ApplyResources(Me.UI_Tab06_Tab04_OtherApps1, "UI_Tab06_Tab04_OtherApps1")
        Me.UI_Tab06_Tab04_OtherApps1.Name = "UI_Tab06_Tab04_OtherApps1"
        Me.UI_Tab06_Tab04_OtherApps1.UseVisualStyleBackColor = True
        '
        'UI_Tab06_Cat04_SubCat10
        '
        resources.ApplyResources(Me.UI_Tab06_Cat04_SubCat10, "UI_Tab06_Cat04_SubCat10")
        Me.UI_Tab06_Cat04_SubCat10.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat04_SubCat10.Controls.Add(Me.AppOption_BRRPlayer_SelectPath)
        Me.UI_Tab06_Cat04_SubCat10.Controls.Add(Me.Text_061)
        Me.UI_Tab06_Cat04_SubCat10.Controls.Add(Me.AppOption_BRRPlayer_Path)
        Me.UI_Tab06_Cat04_SubCat10.Name = "UI_Tab06_Cat04_SubCat10"
        Me.UI_Tab06_Cat04_SubCat10.TabStop = False
        '
        'AppOption_BRRPlayer_SelectPath
        '
        resources.ApplyResources(Me.AppOption_BRRPlayer_SelectPath, "AppOption_BRRPlayer_SelectPath")
        Me.AppOption_BRRPlayer_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_BRRPlayer_SelectPath.Name = "AppOption_BRRPlayer_SelectPath"
        Me.AppOption_BRRPlayer_SelectPath.TabStop = True
        '
        'Text_061
        '
        resources.ApplyResources(Me.Text_061, "Text_061")
        Me.Text_061.Name = "Text_061"
        '
        'AppOption_BRRPlayer_Path
        '
        resources.ApplyResources(Me.AppOption_BRRPlayer_Path, "AppOption_BRRPlayer_Path")
        Me.AppOption_BRRPlayer_Path.Name = "AppOption_BRRPlayer_Path"
        '
        'UI_Tab06_Cat04_SubCat09
        '
        resources.ApplyResources(Me.UI_Tab06_Cat04_SubCat09, "UI_Tab06_Cat04_SubCat09")
        Me.UI_Tab06_Cat04_SubCat09.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat04_SubCat09.Controls.Add(Me.AppOption_LvMusUtil_SelectPath)
        Me.UI_Tab06_Cat04_SubCat09.Controls.Add(Me.Text_060)
        Me.UI_Tab06_Cat04_SubCat09.Controls.Add(Me.AppOption_LvMusUtil_Path)
        Me.UI_Tab06_Cat04_SubCat09.Name = "UI_Tab06_Cat04_SubCat09"
        Me.UI_Tab06_Cat04_SubCat09.TabStop = False
        '
        'AppOption_LvMusUtil_SelectPath
        '
        resources.ApplyResources(Me.AppOption_LvMusUtil_SelectPath, "AppOption_LvMusUtil_SelectPath")
        Me.AppOption_LvMusUtil_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_LvMusUtil_SelectPath.Name = "AppOption_LvMusUtil_SelectPath"
        Me.AppOption_LvMusUtil_SelectPath.TabStop = True
        '
        'Text_060
        '
        resources.ApplyResources(Me.Text_060, "Text_060")
        Me.Text_060.Name = "Text_060"
        '
        'AppOption_LvMusUtil_Path
        '
        resources.ApplyResources(Me.AppOption_LvMusUtil_Path, "AppOption_LvMusUtil_Path")
        Me.AppOption_LvMusUtil_Path.Name = "AppOption_LvMusUtil_Path"
        '
        'UI_Tab06_Cat04_SubCat08
        '
        resources.ApplyResources(Me.UI_Tab06_Cat04_SubCat08, "UI_Tab06_Cat04_SubCat08")
        Me.UI_Tab06_Cat04_SubCat08.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat04_SubCat08.Controls.Add(Me.AppOption_AMK_GUI_SelectPath)
        Me.UI_Tab06_Cat04_SubCat08.Controls.Add(Me.Text_059)
        Me.UI_Tab06_Cat04_SubCat08.Controls.Add(Me.AppOption_AMK_GUI_Path)
        Me.UI_Tab06_Cat04_SubCat08.Controls.Add(Me.AppOption_AMK_CMD_SelectPath)
        Me.UI_Tab06_Cat04_SubCat08.Controls.Add(Me.Text_058)
        Me.UI_Tab06_Cat04_SubCat08.Controls.Add(Me.AppOption_AMK_CMD_Path)
        Me.UI_Tab06_Cat04_SubCat08.Name = "UI_Tab06_Cat04_SubCat08"
        Me.UI_Tab06_Cat04_SubCat08.TabStop = False
        '
        'AppOption_AMK_GUI_SelectPath
        '
        resources.ApplyResources(Me.AppOption_AMK_GUI_SelectPath, "AppOption_AMK_GUI_SelectPath")
        Me.AppOption_AMK_GUI_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_AMK_GUI_SelectPath.Name = "AppOption_AMK_GUI_SelectPath"
        Me.AppOption_AMK_GUI_SelectPath.TabStop = True
        '
        'Text_059
        '
        resources.ApplyResources(Me.Text_059, "Text_059")
        Me.Text_059.Name = "Text_059"
        '
        'AppOption_AMK_GUI_Path
        '
        resources.ApplyResources(Me.AppOption_AMK_GUI_Path, "AppOption_AMK_GUI_Path")
        Me.AppOption_AMK_GUI_Path.Name = "AppOption_AMK_GUI_Path"
        '
        'AppOption_AMK_CMD_SelectPath
        '
        resources.ApplyResources(Me.AppOption_AMK_CMD_SelectPath, "AppOption_AMK_CMD_SelectPath")
        Me.AppOption_AMK_CMD_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_AMK_CMD_SelectPath.Name = "AppOption_AMK_CMD_SelectPath"
        Me.AppOption_AMK_CMD_SelectPath.TabStop = True
        '
        'Text_058
        '
        resources.ApplyResources(Me.Text_058, "Text_058")
        Me.Text_058.Name = "Text_058"
        '
        'AppOption_AMK_CMD_Path
        '
        resources.ApplyResources(Me.AppOption_AMK_CMD_Path, "AppOption_AMK_CMD_Path")
        Me.AppOption_AMK_CMD_Path.Name = "AppOption_AMK_CMD_Path"
        '
        'UI_Tab06_Cat04_SubCat07
        '
        resources.ApplyResources(Me.UI_Tab06_Cat04_SubCat07, "UI_Tab06_Cat04_SubCat07")
        Me.UI_Tab06_Cat04_SubCat07.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat04_SubCat07.Controls.Add(Me.AppOption_MMLEdit_SelectPath)
        Me.UI_Tab06_Cat04_SubCat07.Controls.Add(Me.Text_057)
        Me.UI_Tab06_Cat04_SubCat07.Controls.Add(Me.AppOption_MMLEdit_Path)
        Me.UI_Tab06_Cat04_SubCat07.Name = "UI_Tab06_Cat04_SubCat07"
        Me.UI_Tab06_Cat04_SubCat07.TabStop = False
        '
        'AppOption_MMLEdit_SelectPath
        '
        resources.ApplyResources(Me.AppOption_MMLEdit_SelectPath, "AppOption_MMLEdit_SelectPath")
        Me.AppOption_MMLEdit_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_MMLEdit_SelectPath.Name = "AppOption_MMLEdit_SelectPath"
        Me.AppOption_MMLEdit_SelectPath.TabStop = True
        '
        'Text_057
        '
        resources.ApplyResources(Me.Text_057, "Text_057")
        Me.Text_057.Name = "Text_057"
        '
        'AppOption_MMLEdit_Path
        '
        resources.ApplyResources(Me.AppOption_MMLEdit_Path, "AppOption_MMLEdit_Path")
        Me.AppOption_MMLEdit_Path.Name = "AppOption_MMLEdit_Path"
        '
        'UI_Tab06_Cat04_SubCat06
        '
        resources.ApplyResources(Me.UI_Tab06_Cat04_SubCat06, "UI_Tab06_Cat04_SubCat06")
        Me.UI_Tab06_Cat04_SubCat06.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat04_SubCat06.Controls.Add(Me.AppOption_HdmaGR_SelectPath)
        Me.UI_Tab06_Cat04_SubCat06.Controls.Add(Me.Text_056)
        Me.UI_Tab06_Cat04_SubCat06.Controls.Add(Me.AppOption_HdmaGR_Path)
        Me.UI_Tab06_Cat04_SubCat06.Name = "UI_Tab06_Cat04_SubCat06"
        Me.UI_Tab06_Cat04_SubCat06.TabStop = False
        '
        'AppOption_HdmaGR_SelectPath
        '
        resources.ApplyResources(Me.AppOption_HdmaGR_SelectPath, "AppOption_HdmaGR_SelectPath")
        Me.AppOption_HdmaGR_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_HdmaGR_SelectPath.Name = "AppOption_HdmaGR_SelectPath"
        Me.AppOption_HdmaGR_SelectPath.TabStop = True
        '
        'Text_056
        '
        resources.ApplyResources(Me.Text_056, "Text_056")
        Me.Text_056.Name = "Text_056"
        '
        'AppOption_HdmaGR_Path
        '
        resources.ApplyResources(Me.AppOption_HdmaGR_Path, "AppOption_HdmaGR_Path")
        Me.AppOption_HdmaGR_Path.Name = "AppOption_HdmaGR_Path"
        '
        'UI_Tab06_Cat04_SubCat05
        '
        resources.ApplyResources(Me.UI_Tab06_Cat04_SubCat05, "UI_Tab06_Cat04_SubCat05")
        Me.UI_Tab06_Cat04_SubCat05.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat04_SubCat05.Controls.Add(Me.AppOption_HeAdder_SelectPath)
        Me.UI_Tab06_Cat04_SubCat05.Controls.Add(Me.Text_055)
        Me.UI_Tab06_Cat04_SubCat05.Controls.Add(Me.AppOption_HeAdder_Path)
        Me.UI_Tab06_Cat04_SubCat05.Name = "UI_Tab06_Cat04_SubCat05"
        Me.UI_Tab06_Cat04_SubCat05.TabStop = False
        '
        'AppOption_HeAdder_SelectPath
        '
        resources.ApplyResources(Me.AppOption_HeAdder_SelectPath, "AppOption_HeAdder_SelectPath")
        Me.AppOption_HeAdder_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_HeAdder_SelectPath.Name = "AppOption_HeAdder_SelectPath"
        Me.AppOption_HeAdder_SelectPath.TabStop = True
        '
        'Text_055
        '
        resources.ApplyResources(Me.Text_055, "Text_055")
        Me.Text_055.Name = "Text_055"
        '
        'AppOption_HeAdder_Path
        '
        resources.ApplyResources(Me.AppOption_HeAdder_Path, "AppOption_HeAdder_Path")
        Me.AppOption_HeAdder_Path.Name = "AppOption_HeAdder_Path"
        '
        'UI_Tab06_Cat04_SubCat04
        '
        resources.ApplyResources(Me.UI_Tab06_Cat04_SubCat04, "UI_Tab06_Cat04_SubCat04")
        Me.UI_Tab06_Cat04_SubCat04.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat04_SubCat04.Controls.Add(Me.AppOption_MarioLuigiLPE_SelectPath)
        Me.UI_Tab06_Cat04_SubCat04.Controls.Add(Me.Text_054)
        Me.UI_Tab06_Cat04_SubCat04.Controls.Add(Me.AppOption_MarioLuigiLPE_Path)
        Me.UI_Tab06_Cat04_SubCat04.Name = "UI_Tab06_Cat04_SubCat04"
        Me.UI_Tab06_Cat04_SubCat04.TabStop = False
        '
        'AppOption_MarioLuigiLPE_SelectPath
        '
        resources.ApplyResources(Me.AppOption_MarioLuigiLPE_SelectPath, "AppOption_MarioLuigiLPE_SelectPath")
        Me.AppOption_MarioLuigiLPE_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_MarioLuigiLPE_SelectPath.Name = "AppOption_MarioLuigiLPE_SelectPath"
        Me.AppOption_MarioLuigiLPE_SelectPath.TabStop = True
        '
        'Text_054
        '
        resources.ApplyResources(Me.Text_054, "Text_054")
        Me.Text_054.Name = "Text_054"
        '
        'AppOption_MarioLuigiLPE_Path
        '
        resources.ApplyResources(Me.AppOption_MarioLuigiLPE_Path, "AppOption_MarioLuigiLPE_Path")
        Me.AppOption_MarioLuigiLPE_Path.Name = "AppOption_MarioLuigiLPE_Path"
        '
        'UI_Tab06_Cat04_SubCat03
        '
        resources.ApplyResources(Me.UI_Tab06_Cat04_SubCat03, "UI_Tab06_Cat04_SubCat03")
        Me.UI_Tab06_Cat04_SubCat03.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat04_SubCat03.Controls.Add(Me.AppOption_SnesGFX_SelectPath)
        Me.UI_Tab06_Cat04_SubCat03.Controls.Add(Me.Text_053)
        Me.UI_Tab06_Cat04_SubCat03.Controls.Add(Me.AppOption_SnesGFX_Path)
        Me.UI_Tab06_Cat04_SubCat03.Name = "UI_Tab06_Cat04_SubCat03"
        Me.UI_Tab06_Cat04_SubCat03.TabStop = False
        '
        'AppOption_SnesGFX_SelectPath
        '
        resources.ApplyResources(Me.AppOption_SnesGFX_SelectPath, "AppOption_SnesGFX_SelectPath")
        Me.AppOption_SnesGFX_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_SnesGFX_SelectPath.Name = "AppOption_SnesGFX_SelectPath"
        Me.AppOption_SnesGFX_SelectPath.TabStop = True
        '
        'Text_053
        '
        resources.ApplyResources(Me.Text_053, "Text_053")
        Me.Text_053.Name = "Text_053"
        '
        'AppOption_SnesGFX_Path
        '
        resources.ApplyResources(Me.AppOption_SnesGFX_Path, "AppOption_SnesGFX_Path")
        Me.AppOption_SnesGFX_Path.Name = "AppOption_SnesGFX_Path"
        '
        'UI_Tab06_Cat04_SubCat02
        '
        resources.ApplyResources(Me.UI_Tab06_Cat04_SubCat02, "UI_Tab06_Cat04_SubCat02")
        Me.UI_Tab06_Cat04_SubCat02.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat04_SubCat02.Controls.Add(Me.AppOption_RecoverLM_SelectPath)
        Me.UI_Tab06_Cat04_SubCat02.Controls.Add(Me.Text_052)
        Me.UI_Tab06_Cat04_SubCat02.Controls.Add(Me.AppOption_RecoverLM_Path)
        Me.UI_Tab06_Cat04_SubCat02.Name = "UI_Tab06_Cat04_SubCat02"
        Me.UI_Tab06_Cat04_SubCat02.TabStop = False
        '
        'AppOption_RecoverLM_SelectPath
        '
        resources.ApplyResources(Me.AppOption_RecoverLM_SelectPath, "AppOption_RecoverLM_SelectPath")
        Me.AppOption_RecoverLM_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_RecoverLM_SelectPath.Name = "AppOption_RecoverLM_SelectPath"
        Me.AppOption_RecoverLM_SelectPath.TabStop = True
        '
        'Text_052
        '
        resources.ApplyResources(Me.Text_052, "Text_052")
        Me.Text_052.Name = "Text_052"
        '
        'AppOption_RecoverLM_Path
        '
        resources.ApplyResources(Me.AppOption_RecoverLM_Path, "AppOption_RecoverLM_Path")
        Me.AppOption_RecoverLM_Path.Name = "AppOption_RecoverLM_Path"
        '
        'UI_Tab06_Cat04_SubCat01
        '
        resources.ApplyResources(Me.UI_Tab06_Cat04_SubCat01, "UI_Tab06_Cat04_SubCat01")
        Me.UI_Tab06_Cat04_SubCat01.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat04_SubCat01.Controls.Add(Me.AppOption_LunarExpand_SelectPath)
        Me.UI_Tab06_Cat04_SubCat01.Controls.Add(Me.Text_051)
        Me.UI_Tab06_Cat04_SubCat01.Controls.Add(Me.AppOption_LunarExpand_Path)
        Me.UI_Tab06_Cat04_SubCat01.Name = "UI_Tab06_Cat04_SubCat01"
        Me.UI_Tab06_Cat04_SubCat01.TabStop = False
        '
        'AppOption_LunarExpand_SelectPath
        '
        resources.ApplyResources(Me.AppOption_LunarExpand_SelectPath, "AppOption_LunarExpand_SelectPath")
        Me.AppOption_LunarExpand_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_LunarExpand_SelectPath.Name = "AppOption_LunarExpand_SelectPath"
        Me.AppOption_LunarExpand_SelectPath.TabStop = True
        '
        'Text_051
        '
        resources.ApplyResources(Me.Text_051, "Text_051")
        Me.Text_051.Name = "Text_051"
        '
        'AppOption_LunarExpand_Path
        '
        resources.ApplyResources(Me.AppOption_LunarExpand_Path, "AppOption_LunarExpand_Path")
        Me.AppOption_LunarExpand_Path.Name = "AppOption_LunarExpand_Path"
        '
        'UI_Tab06_Tab05_OtherApps2
        '
        Me.UI_Tab06_Tab05_OtherApps2.Controls.Add(Me.UI_Tab06_Cat05_SubCat02)
        Me.UI_Tab06_Tab05_OtherApps2.Controls.Add(Me.UI_Tab06_Cat05_SubCat10)
        Me.UI_Tab06_Tab05_OtherApps2.Controls.Add(Me.UI_Tab06_Cat05_SubCat09)
        Me.UI_Tab06_Tab05_OtherApps2.Controls.Add(Me.UI_Tab06_Cat05_SubCat08)
        Me.UI_Tab06_Tab05_OtherApps2.Controls.Add(Me.UI_Tab06_Cat05_SubCat07)
        Me.UI_Tab06_Tab05_OtherApps2.Controls.Add(Me.UI_Tab06_Cat05_SubCat06)
        Me.UI_Tab06_Tab05_OtherApps2.Controls.Add(Me.UI_Tab06_Cat05_SubCat05)
        Me.UI_Tab06_Tab05_OtherApps2.Controls.Add(Me.UI_Tab06_Cat05_SubCat04)
        Me.UI_Tab06_Tab05_OtherApps2.Controls.Add(Me.UI_Tab06_Cat05_SubCat03)
        Me.UI_Tab06_Tab05_OtherApps2.Controls.Add(Me.UI_Tab06_Cat05_SubCat01)
        resources.ApplyResources(Me.UI_Tab06_Tab05_OtherApps2, "UI_Tab06_Tab05_OtherApps2")
        Me.UI_Tab06_Tab05_OtherApps2.Name = "UI_Tab06_Tab05_OtherApps2"
        Me.UI_Tab06_Tab05_OtherApps2.UseVisualStyleBackColor = True
        '
        'UI_Tab06_Cat05_SubCat02
        '
        resources.ApplyResources(Me.UI_Tab06_Cat05_SubCat02, "UI_Tab06_Cat05_SubCat02")
        Me.UI_Tab06_Cat05_SubCat02.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat05_SubCat02.Controls.Add(Me.AppOption_PixiConfigurator_SelectPath)
        Me.UI_Tab06_Cat05_SubCat02.Controls.Add(Me.Text_064)
        Me.UI_Tab06_Cat05_SubCat02.Controls.Add(Me.AppOption_PixiConfigurator_Path)
        Me.UI_Tab06_Cat05_SubCat02.Controls.Add(Me.AppOption_Pixi_SelectPath)
        Me.UI_Tab06_Cat05_SubCat02.Controls.Add(Me.Text_063)
        Me.UI_Tab06_Cat05_SubCat02.Controls.Add(Me.AppOption_Pixi_Path)
        Me.UI_Tab06_Cat05_SubCat02.Name = "UI_Tab06_Cat05_SubCat02"
        Me.UI_Tab06_Cat05_SubCat02.TabStop = False
        '
        'AppOption_PixiConfigurator_SelectPath
        '
        resources.ApplyResources(Me.AppOption_PixiConfigurator_SelectPath, "AppOption_PixiConfigurator_SelectPath")
        Me.AppOption_PixiConfigurator_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_PixiConfigurator_SelectPath.Name = "AppOption_PixiConfigurator_SelectPath"
        Me.AppOption_PixiConfigurator_SelectPath.TabStop = True
        '
        'Text_064
        '
        resources.ApplyResources(Me.Text_064, "Text_064")
        Me.Text_064.Name = "Text_064"
        '
        'AppOption_PixiConfigurator_Path
        '
        resources.ApplyResources(Me.AppOption_PixiConfigurator_Path, "AppOption_PixiConfigurator_Path")
        Me.AppOption_PixiConfigurator_Path.Name = "AppOption_PixiConfigurator_Path"
        '
        'AppOption_Pixi_SelectPath
        '
        resources.ApplyResources(Me.AppOption_Pixi_SelectPath, "AppOption_Pixi_SelectPath")
        Me.AppOption_Pixi_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_Pixi_SelectPath.Name = "AppOption_Pixi_SelectPath"
        Me.AppOption_Pixi_SelectPath.TabStop = True
        '
        'Text_063
        '
        resources.ApplyResources(Me.Text_063, "Text_063")
        Me.Text_063.Name = "Text_063"
        '
        'AppOption_Pixi_Path
        '
        resources.ApplyResources(Me.AppOption_Pixi_Path, "AppOption_Pixi_Path")
        Me.AppOption_Pixi_Path.Name = "AppOption_Pixi_Path"
        '
        'UI_Tab06_Cat05_SubCat10
        '
        resources.ApplyResources(Me.UI_Tab06_Cat05_SubCat10, "UI_Tab06_Cat05_SubCat10")
        Me.UI_Tab06_Cat05_SubCat10.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat05_SubCat10.Controls.Add(Me.AppOption_PetiteMM_SelectPath)
        Me.UI_Tab06_Cat05_SubCat10.Controls.Add(Me.Text_072)
        Me.UI_Tab06_Cat05_SubCat10.Controls.Add(Me.AppOption_PetiteMM_Path)
        Me.UI_Tab06_Cat05_SubCat10.Name = "UI_Tab06_Cat05_SubCat10"
        Me.UI_Tab06_Cat05_SubCat10.TabStop = False
        '
        'AppOption_PetiteMM_SelectPath
        '
        resources.ApplyResources(Me.AppOption_PetiteMM_SelectPath, "AppOption_PetiteMM_SelectPath")
        Me.AppOption_PetiteMM_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_PetiteMM_SelectPath.Name = "AppOption_PetiteMM_SelectPath"
        Me.AppOption_PetiteMM_SelectPath.TabStop = True
        '
        'Text_072
        '
        resources.ApplyResources(Me.Text_072, "Text_072")
        Me.Text_072.Name = "Text_072"
        '
        'AppOption_PetiteMM_Path
        '
        resources.ApplyResources(Me.AppOption_PetiteMM_Path, "AppOption_PetiteMM_Path")
        Me.AppOption_PetiteMM_Path.Name = "AppOption_PetiteMM_Path"
        '
        'UI_Tab06_Cat05_SubCat09
        '
        resources.ApplyResources(Me.UI_Tab06_Cat05_SubCat09, "UI_Tab06_Cat05_SubCat09")
        Me.UI_Tab06_Cat05_SubCat09.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat05_SubCat09.Controls.Add(Me.AppOption_GPS_SelectPath)
        Me.UI_Tab06_Cat05_SubCat09.Controls.Add(Me.Text_071)
        Me.UI_Tab06_Cat05_SubCat09.Controls.Add(Me.AppOption_GPS_Path)
        Me.UI_Tab06_Cat05_SubCat09.Name = "UI_Tab06_Cat05_SubCat09"
        Me.UI_Tab06_Cat05_SubCat09.TabStop = False
        '
        'AppOption_GPS_SelectPath
        '
        resources.ApplyResources(Me.AppOption_GPS_SelectPath, "AppOption_GPS_SelectPath")
        Me.AppOption_GPS_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_GPS_SelectPath.Name = "AppOption_GPS_SelectPath"
        Me.AppOption_GPS_SelectPath.TabStop = True
        '
        'Text_071
        '
        resources.ApplyResources(Me.Text_071, "Text_071")
        Me.Text_071.Name = "Text_071"
        '
        'AppOption_GPS_Path
        '
        resources.ApplyResources(Me.AppOption_GPS_Path, "AppOption_GPS_Path")
        Me.AppOption_GPS_Path.Name = "AppOption_GPS_Path"
        '
        'UI_Tab06_Cat05_SubCat08
        '
        resources.ApplyResources(Me.UI_Tab06_Cat05_SubCat08, "UI_Tab06_Cat05_SubCat08")
        Me.UI_Tab06_Cat05_SubCat08.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat05_SubCat08.Controls.Add(Me.AppOption_EffectTool_SelectPath)
        Me.UI_Tab06_Cat05_SubCat08.Controls.Add(Me.Text_070)
        Me.UI_Tab06_Cat05_SubCat08.Controls.Add(Me.AppOption_EffectTool_Path)
        Me.UI_Tab06_Cat05_SubCat08.Name = "UI_Tab06_Cat05_SubCat08"
        Me.UI_Tab06_Cat05_SubCat08.TabStop = False
        '
        'AppOption_EffectTool_SelectPath
        '
        resources.ApplyResources(Me.AppOption_EffectTool_SelectPath, "AppOption_EffectTool_SelectPath")
        Me.AppOption_EffectTool_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_EffectTool_SelectPath.Name = "AppOption_EffectTool_SelectPath"
        Me.AppOption_EffectTool_SelectPath.TabStop = True
        '
        'Text_070
        '
        resources.ApplyResources(Me.Text_070, "Text_070")
        Me.Text_070.Name = "Text_070"
        '
        'AppOption_EffectTool_Path
        '
        resources.ApplyResources(Me.AppOption_EffectTool_Path, "AppOption_EffectTool_Path")
        Me.AppOption_EffectTool_Path.Name = "AppOption_EffectTool_Path"
        '
        'UI_Tab06_Cat05_SubCat07
        '
        resources.ApplyResources(Me.UI_Tab06_Cat05_SubCat07, "UI_Tab06_Cat05_SubCat07")
        Me.UI_Tab06_Cat05_SubCat07.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat05_SubCat07.Controls.Add(Me.AppOption_SnesColorTool_SelectPath)
        Me.UI_Tab06_Cat05_SubCat07.Controls.Add(Me.Text_069)
        Me.UI_Tab06_Cat05_SubCat07.Controls.Add(Me.AppOption_SnesColorTool_Path)
        Me.UI_Tab06_Cat05_SubCat07.Name = "UI_Tab06_Cat05_SubCat07"
        Me.UI_Tab06_Cat05_SubCat07.TabStop = False
        '
        'AppOption_SnesColorTool_SelectPath
        '
        resources.ApplyResources(Me.AppOption_SnesColorTool_SelectPath, "AppOption_SnesColorTool_SelectPath")
        Me.AppOption_SnesColorTool_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_SnesColorTool_SelectPath.Name = "AppOption_SnesColorTool_SelectPath"
        Me.AppOption_SnesColorTool_SelectPath.TabStop = True
        '
        'Text_069
        '
        resources.ApplyResources(Me.Text_069, "Text_069")
        Me.Text_069.Name = "Text_069"
        '
        'AppOption_SnesColorTool_Path
        '
        resources.ApplyResources(Me.AppOption_SnesColorTool_Path, "AppOption_SnesColorTool_Path")
        Me.AppOption_SnesColorTool_Path.Name = "AppOption_SnesColorTool_Path"
        '
        'UI_Tab06_Cat05_SubCat06
        '
        resources.ApplyResources(Me.UI_Tab06_Cat05_SubCat06, "UI_Tab06_Cat05_SubCat06")
        Me.UI_Tab06_Cat05_SubCat06.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat05_SubCat06.Controls.Add(Me.AppOption_StatusEffects_SelectPath)
        Me.UI_Tab06_Cat05_SubCat06.Controls.Add(Me.Text_068)
        Me.UI_Tab06_Cat05_SubCat06.Controls.Add(Me.AppOption_StatusEffects_Path)
        Me.UI_Tab06_Cat05_SubCat06.Name = "UI_Tab06_Cat05_SubCat06"
        Me.UI_Tab06_Cat05_SubCat06.TabStop = False
        '
        'AppOption_StatusEffects_SelectPath
        '
        resources.ApplyResources(Me.AppOption_StatusEffects_SelectPath, "AppOption_StatusEffects_SelectPath")
        Me.AppOption_StatusEffects_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_StatusEffects_SelectPath.Name = "AppOption_StatusEffects_SelectPath"
        Me.AppOption_StatusEffects_SelectPath.TabStop = True
        '
        'Text_068
        '
        resources.ApplyResources(Me.Text_068, "Text_068")
        Me.Text_068.Name = "Text_068"
        '
        'AppOption_StatusEffects_Path
        '
        resources.ApplyResources(Me.AppOption_StatusEffects_Path, "AppOption_StatusEffects_Path")
        Me.AppOption_StatusEffects_Path.Name = "AppOption_StatusEffects_Path"
        '
        'UI_Tab06_Cat05_SubCat05
        '
        resources.ApplyResources(Me.UI_Tab06_Cat05_SubCat05, "UI_Tab06_Cat05_SubCat05")
        Me.UI_Tab06_Cat05_SubCat05.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat05_SubCat05.Controls.Add(Me.AppOption_FloatingIPS_SelectPath)
        Me.UI_Tab06_Cat05_SubCat05.Controls.Add(Me.Text_067)
        Me.UI_Tab06_Cat05_SubCat05.Controls.Add(Me.AppOption_FloatingIPS_Path)
        Me.UI_Tab06_Cat05_SubCat05.Name = "UI_Tab06_Cat05_SubCat05"
        Me.UI_Tab06_Cat05_SubCat05.TabStop = False
        '
        'AppOption_FloatingIPS_SelectPath
        '
        resources.ApplyResources(Me.AppOption_FloatingIPS_SelectPath, "AppOption_FloatingIPS_SelectPath")
        Me.AppOption_FloatingIPS_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_FloatingIPS_SelectPath.Name = "AppOption_FloatingIPS_SelectPath"
        Me.AppOption_FloatingIPS_SelectPath.TabStop = True
        '
        'Text_067
        '
        resources.ApplyResources(Me.Text_067, "Text_067")
        Me.Text_067.Name = "Text_067"
        '
        'AppOption_FloatingIPS_Path
        '
        resources.ApplyResources(Me.AppOption_FloatingIPS_Path, "AppOption_FloatingIPS_Path")
        Me.AppOption_FloatingIPS_Path.Name = "AppOption_FloatingIPS_Path"
        '
        'UI_Tab06_Cat05_SubCat04
        '
        resources.ApplyResources(Me.UI_Tab06_Cat05_SubCat04, "UI_Tab06_Cat05_SubCat04")
        Me.UI_Tab06_Cat05_SubCat04.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat05_SubCat04.Controls.Add(Me.AppOption_SPC700Player_SelectPath)
        Me.UI_Tab06_Cat05_SubCat04.Controls.Add(Me.Text_066)
        Me.UI_Tab06_Cat05_SubCat04.Controls.Add(Me.AppOption_SPC700Player_Path)
        Me.UI_Tab06_Cat05_SubCat04.Name = "UI_Tab06_Cat05_SubCat04"
        Me.UI_Tab06_Cat05_SubCat04.TabStop = False
        '
        'AppOption_SPC700Player_SelectPath
        '
        resources.ApplyResources(Me.AppOption_SPC700Player_SelectPath, "AppOption_SPC700Player_SelectPath")
        Me.AppOption_SPC700Player_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_SPC700Player_SelectPath.Name = "AppOption_SPC700Player_SelectPath"
        Me.AppOption_SPC700Player_SelectPath.TabStop = True
        '
        'Text_066
        '
        resources.ApplyResources(Me.Text_066, "Text_066")
        Me.Text_066.Name = "Text_066"
        '
        'AppOption_SPC700Player_Path
        '
        resources.ApplyResources(Me.AppOption_SPC700Player_Path, "AppOption_SPC700Player_Path")
        Me.AppOption_SPC700Player_Path.Name = "AppOption_SPC700Player_Path"
        '
        'UI_Tab06_Cat05_SubCat03
        '
        resources.ApplyResources(Me.UI_Tab06_Cat05_SubCat03, "UI_Tab06_Cat05_SubCat03")
        Me.UI_Tab06_Cat05_SubCat03.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat05_SubCat03.Controls.Add(Me.AppOption_M7Map_SelectPath)
        Me.UI_Tab06_Cat05_SubCat03.Controls.Add(Me.Text_065)
        Me.UI_Tab06_Cat05_SubCat03.Controls.Add(Me.AppOption_M7Map_Path)
        Me.UI_Tab06_Cat05_SubCat03.Name = "UI_Tab06_Cat05_SubCat03"
        Me.UI_Tab06_Cat05_SubCat03.TabStop = False
        '
        'AppOption_M7Map_SelectPath
        '
        resources.ApplyResources(Me.AppOption_M7Map_SelectPath, "AppOption_M7Map_SelectPath")
        Me.AppOption_M7Map_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_M7Map_SelectPath.Name = "AppOption_M7Map_SelectPath"
        Me.AppOption_M7Map_SelectPath.TabStop = True
        '
        'Text_065
        '
        resources.ApplyResources(Me.Text_065, "Text_065")
        Me.Text_065.Name = "Text_065"
        '
        'AppOption_M7Map_Path
        '
        resources.ApplyResources(Me.AppOption_M7Map_Path, "AppOption_M7Map_Path")
        Me.AppOption_M7Map_Path.Name = "AppOption_M7Map_Path"
        '
        'UI_Tab06_Cat05_SubCat01
        '
        resources.ApplyResources(Me.UI_Tab06_Cat05_SubCat01, "UI_Tab06_Cat05_SubCat01")
        Me.UI_Tab06_Cat05_SubCat01.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat05_SubCat01.Controls.Add(Me.AppOption_Blockreator_SelectPath)
        Me.UI_Tab06_Cat05_SubCat01.Controls.Add(Me.Text_062)
        Me.UI_Tab06_Cat05_SubCat01.Controls.Add(Me.AppOption_Blockreator_Path)
        Me.UI_Tab06_Cat05_SubCat01.Name = "UI_Tab06_Cat05_SubCat01"
        Me.UI_Tab06_Cat05_SubCat01.TabStop = False
        '
        'AppOption_Blockreator_SelectPath
        '
        resources.ApplyResources(Me.AppOption_Blockreator_SelectPath, "AppOption_Blockreator_SelectPath")
        Me.AppOption_Blockreator_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_Blockreator_SelectPath.Name = "AppOption_Blockreator_SelectPath"
        Me.AppOption_Blockreator_SelectPath.TabStop = True
        '
        'Text_062
        '
        resources.ApplyResources(Me.Text_062, "Text_062")
        Me.Text_062.Name = "Text_062"
        '
        'AppOption_Blockreator_Path
        '
        resources.ApplyResources(Me.AppOption_Blockreator_Path, "AppOption_Blockreator_Path")
        Me.AppOption_Blockreator_Path.Name = "AppOption_Blockreator_Path"
        '
        'UI_Tab06_Tab06_OtherApps3
        '
        Me.UI_Tab06_Tab06_OtherApps3.Controls.Add(Me.UI_Tab06_Cat06_SubCat10)
        Me.UI_Tab06_Tab06_OtherApps3.Controls.Add(Me.UI_Tab06_Cat06_SubCat09)
        Me.UI_Tab06_Tab06_OtherApps3.Controls.Add(Me.UI_Tab06_Cat06_SubCat08)
        Me.UI_Tab06_Tab06_OtherApps3.Controls.Add(Me.UI_Tab06_Cat06_SubCat07)
        Me.UI_Tab06_Tab06_OtherApps3.Controls.Add(Me.UI_Tab06_Cat06_SubCat06)
        Me.UI_Tab06_Tab06_OtherApps3.Controls.Add(Me.UI_Tab06_Cat06_SubCat05)
        Me.UI_Tab06_Tab06_OtherApps3.Controls.Add(Me.UI_Tab06_Cat06_SubCat04)
        Me.UI_Tab06_Tab06_OtherApps3.Controls.Add(Me.UI_Tab06_Cat06_SubCat03)
        Me.UI_Tab06_Tab06_OtherApps3.Controls.Add(Me.UI_Tab06_Cat06_SubCat02)
        Me.UI_Tab06_Tab06_OtherApps3.Controls.Add(Me.UI_Tab06_Cat06_SubCat01)
        resources.ApplyResources(Me.UI_Tab06_Tab06_OtherApps3, "UI_Tab06_Tab06_OtherApps3")
        Me.UI_Tab06_Tab06_OtherApps3.Name = "UI_Tab06_Tab06_OtherApps3"
        Me.UI_Tab06_Tab06_OtherApps3.UseVisualStyleBackColor = True
        '
        'UI_Tab06_Cat06_SubCat10
        '
        resources.ApplyResources(Me.UI_Tab06_Cat06_SubCat10, "UI_Tab06_Cat06_SubCat10")
        Me.UI_Tab06_Cat06_SubCat10.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat06_SubCat10.Controls.Add(Me.AppOption_GradientTool_SelectPath)
        Me.UI_Tab06_Cat06_SubCat10.Controls.Add(Me.Text_082)
        Me.UI_Tab06_Cat06_SubCat10.Controls.Add(Me.AppOption_GradientTool_Path)
        Me.UI_Tab06_Cat06_SubCat10.Name = "UI_Tab06_Cat06_SubCat10"
        Me.UI_Tab06_Cat06_SubCat10.TabStop = False
        '
        'AppOption_GradientTool_SelectPath
        '
        resources.ApplyResources(Me.AppOption_GradientTool_SelectPath, "AppOption_GradientTool_SelectPath")
        Me.AppOption_GradientTool_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_GradientTool_SelectPath.Name = "AppOption_GradientTool_SelectPath"
        Me.AppOption_GradientTool_SelectPath.TabStop = True
        '
        'Text_082
        '
        resources.ApplyResources(Me.Text_082, "Text_082")
        Me.Text_082.Name = "Text_082"
        '
        'AppOption_GradientTool_Path
        '
        resources.ApplyResources(Me.AppOption_GradientTool_Path, "AppOption_GradientTool_Path")
        Me.AppOption_GradientTool_Path.Name = "AppOption_GradientTool_Path"
        '
        'UI_Tab06_Cat06_SubCat09
        '
        resources.ApplyResources(Me.UI_Tab06_Cat06_SubCat09, "UI_Tab06_Cat06_SubCat09")
        Me.UI_Tab06_Cat06_SubCat09.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat06_SubCat09.Controls.Add(Me.AppOption_UberASM_SelectPath)
        Me.UI_Tab06_Cat06_SubCat09.Controls.Add(Me.Text_081)
        Me.UI_Tab06_Cat06_SubCat09.Controls.Add(Me.AppOption_UberASM_Path)
        Me.UI_Tab06_Cat06_SubCat09.Name = "UI_Tab06_Cat06_SubCat09"
        Me.UI_Tab06_Cat06_SubCat09.TabStop = False
        '
        'AppOption_UberASM_SelectPath
        '
        resources.ApplyResources(Me.AppOption_UberASM_SelectPath, "AppOption_UberASM_SelectPath")
        Me.AppOption_UberASM_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_UberASM_SelectPath.Name = "AppOption_UberASM_SelectPath"
        Me.AppOption_UberASM_SelectPath.TabStop = True
        '
        'Text_081
        '
        resources.ApplyResources(Me.Text_081, "Text_081")
        Me.Text_081.Name = "Text_081"
        '
        'AppOption_UberASM_Path
        '
        resources.ApplyResources(Me.AppOption_UberASM_Path, "AppOption_UberASM_Path")
        Me.AppOption_UberASM_Path.Name = "AppOption_UberASM_Path"
        '
        'UI_Tab06_Cat06_SubCat08
        '
        resources.ApplyResources(Me.UI_Tab06_Cat06_SubCat08, "UI_Tab06_Cat06_SubCat08")
        Me.UI_Tab06_Cat06_SubCat08.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat06_SubCat08.Controls.Add(Me.AppOption_SMWCustomizer_SelectPath)
        Me.UI_Tab06_Cat06_SubCat08.Controls.Add(Me.Text_080)
        Me.UI_Tab06_Cat06_SubCat08.Controls.Add(Me.AppOption_SMWCustomizer_Path)
        Me.UI_Tab06_Cat06_SubCat08.Name = "UI_Tab06_Cat06_SubCat08"
        Me.UI_Tab06_Cat06_SubCat08.TabStop = False
        '
        'AppOption_SMWCustomizer_SelectPath
        '
        resources.ApplyResources(Me.AppOption_SMWCustomizer_SelectPath, "AppOption_SMWCustomizer_SelectPath")
        Me.AppOption_SMWCustomizer_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_SMWCustomizer_SelectPath.Name = "AppOption_SMWCustomizer_SelectPath"
        Me.AppOption_SMWCustomizer_SelectPath.TabStop = True
        '
        'Text_080
        '
        resources.ApplyResources(Me.Text_080, "Text_080")
        Me.Text_080.Name = "Text_080"
        '
        'AppOption_SMWCustomizer_Path
        '
        resources.ApplyResources(Me.AppOption_SMWCustomizer_Path, "AppOption_SMWCustomizer_Path")
        Me.AppOption_SMWCustomizer_Path.Name = "AppOption_SMWCustomizer_Path"
        '
        'UI_Tab06_Cat06_SubCat07
        '
        resources.ApplyResources(Me.UI_Tab06_Cat06_SubCat07, "UI_Tab06_Cat06_SubCat07")
        Me.UI_Tab06_Cat06_SubCat07.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat06_SubCat07.Controls.Add(Me.AppOption_YYCHR_SelectPath)
        Me.UI_Tab06_Cat06_SubCat07.Controls.Add(Me.Text_079)
        Me.UI_Tab06_Cat06_SubCat07.Controls.Add(Me.AppOption_YYCHR_Path)
        Me.UI_Tab06_Cat06_SubCat07.Name = "UI_Tab06_Cat06_SubCat07"
        Me.UI_Tab06_Cat06_SubCat07.TabStop = False
        '
        'AppOption_YYCHR_SelectPath
        '
        resources.ApplyResources(Me.AppOption_YYCHR_SelectPath, "AppOption_YYCHR_SelectPath")
        Me.AppOption_YYCHR_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_YYCHR_SelectPath.Name = "AppOption_YYCHR_SelectPath"
        Me.AppOption_YYCHR_SelectPath.TabStop = True
        '
        'Text_079
        '
        resources.ApplyResources(Me.Text_079, "Text_079")
        Me.Text_079.Name = "Text_079"
        '
        'AppOption_YYCHR_Path
        '
        resources.ApplyResources(Me.AppOption_YYCHR_Path, "AppOption_YYCHR_Path")
        Me.AppOption_YYCHR_Path.Name = "AppOption_YYCHR_Path"
        '
        'UI_Tab06_Cat06_SubCat06
        '
        resources.ApplyResources(Me.UI_Tab06_Cat06_SubCat06, "UI_Tab06_Cat06_SubCat06")
        Me.UI_Tab06_Cat06_SubCat06.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat06_SubCat06.Controls.Add(Me.AppOption_GraphicEditor_SelectPath)
        Me.UI_Tab06_Cat06_SubCat06.Controls.Add(Me.Text_078)
        Me.UI_Tab06_Cat06_SubCat06.Controls.Add(Me.AppOption_GraphicEditor_Path)
        Me.UI_Tab06_Cat06_SubCat06.Name = "UI_Tab06_Cat06_SubCat06"
        Me.UI_Tab06_Cat06_SubCat06.TabStop = False
        '
        'AppOption_GraphicEditor_SelectPath
        '
        resources.ApplyResources(Me.AppOption_GraphicEditor_SelectPath, "AppOption_GraphicEditor_SelectPath")
        Me.AppOption_GraphicEditor_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_GraphicEditor_SelectPath.Name = "AppOption_GraphicEditor_SelectPath"
        Me.AppOption_GraphicEditor_SelectPath.TabStop = True
        '
        'Text_078
        '
        resources.ApplyResources(Me.Text_078, "Text_078")
        Me.Text_078.Name = "Text_078"
        '
        'AppOption_GraphicEditor_Path
        '
        resources.ApplyResources(Me.AppOption_GraphicEditor_Path, "AppOption_GraphicEditor_Path")
        Me.AppOption_GraphicEditor_Path.Name = "AppOption_GraphicEditor_Path"
        '
        'UI_Tab06_Cat06_SubCat05
        '
        resources.ApplyResources(Me.UI_Tab06_Cat06_SubCat05, "UI_Tab06_Cat06_SubCat05")
        Me.UI_Tab06_Cat06_SubCat05.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat06_SubCat05.Controls.Add(Me.AppOption_SpriteGFX_SelectPath)
        Me.UI_Tab06_Cat06_SubCat05.Controls.Add(Me.Text_077)
        Me.UI_Tab06_Cat06_SubCat05.Controls.Add(Me.AppOption_SpriteGFX_Path)
        Me.UI_Tab06_Cat06_SubCat05.Name = "UI_Tab06_Cat06_SubCat05"
        Me.UI_Tab06_Cat06_SubCat05.TabStop = False
        '
        'AppOption_SpriteGFX_SelectPath
        '
        resources.ApplyResources(Me.AppOption_SpriteGFX_SelectPath, "AppOption_SpriteGFX_SelectPath")
        Me.AppOption_SpriteGFX_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_SpriteGFX_SelectPath.Name = "AppOption_SpriteGFX_SelectPath"
        Me.AppOption_SpriteGFX_SelectPath.TabStop = True
        '
        'Text_077
        '
        resources.ApplyResources(Me.Text_077, "Text_077")
        Me.Text_077.Name = "Text_077"
        '
        'AppOption_SpriteGFX_Path
        '
        resources.ApplyResources(Me.AppOption_SpriteGFX_Path, "AppOption_SpriteGFX_Path")
        Me.AppOption_SpriteGFX_Path.Name = "AppOption_SpriteGFX_Path"
        '
        'UI_Tab06_Cat06_SubCat04
        '
        resources.ApplyResources(Me.UI_Tab06_Cat06_SubCat04, "UI_Tab06_Cat06_SubCat04")
        Me.UI_Tab06_Cat06_SubCat04.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat06_SubCat04.Controls.Add(Me.AppOption_MultipleMidwayPoints_SelectPath)
        Me.UI_Tab06_Cat06_SubCat04.Controls.Add(Me.Text_076)
        Me.UI_Tab06_Cat06_SubCat04.Controls.Add(Me.AppOption_MultipleMidwayPoints_Path)
        Me.UI_Tab06_Cat06_SubCat04.Name = "UI_Tab06_Cat06_SubCat04"
        Me.UI_Tab06_Cat06_SubCat04.TabStop = False
        '
        'AppOption_MultipleMidwayPoints_SelectPath
        '
        resources.ApplyResources(Me.AppOption_MultipleMidwayPoints_SelectPath, "AppOption_MultipleMidwayPoints_SelectPath")
        Me.AppOption_MultipleMidwayPoints_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_MultipleMidwayPoints_SelectPath.Name = "AppOption_MultipleMidwayPoints_SelectPath"
        Me.AppOption_MultipleMidwayPoints_SelectPath.TabStop = True
        '
        'Text_076
        '
        resources.ApplyResources(Me.Text_076, "Text_076")
        Me.Text_076.Name = "Text_076"
        '
        'AppOption_MultipleMidwayPoints_Path
        '
        resources.ApplyResources(Me.AppOption_MultipleMidwayPoints_Path, "AppOption_MultipleMidwayPoints_Path")
        Me.AppOption_MultipleMidwayPoints_Path.Name = "AppOption_MultipleMidwayPoints_Path"
        '
        'UI_Tab06_Cat06_SubCat03
        '
        resources.ApplyResources(Me.UI_Tab06_Cat06_SubCat03, "UI_Tab06_Cat06_SubCat03")
        Me.UI_Tab06_Cat06_SubCat03.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat06_SubCat03.Controls.Add(Me.AppOption_InteractionEditor_SelectPath)
        Me.UI_Tab06_Cat06_SubCat03.Controls.Add(Me.Text_075)
        Me.UI_Tab06_Cat06_SubCat03.Controls.Add(Me.AppOption_InteractionEditor_Path)
        Me.UI_Tab06_Cat06_SubCat03.Name = "UI_Tab06_Cat06_SubCat03"
        Me.UI_Tab06_Cat06_SubCat03.TabStop = False
        '
        'AppOption_InteractionEditor_SelectPath
        '
        resources.ApplyResources(Me.AppOption_InteractionEditor_SelectPath, "AppOption_InteractionEditor_SelectPath")
        Me.AppOption_InteractionEditor_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_InteractionEditor_SelectPath.Name = "AppOption_InteractionEditor_SelectPath"
        Me.AppOption_InteractionEditor_SelectPath.TabStop = True
        '
        'Text_075
        '
        resources.ApplyResources(Me.Text_075, "Text_075")
        Me.Text_075.Name = "Text_075"
        '
        'AppOption_InteractionEditor_Path
        '
        resources.ApplyResources(Me.AppOption_InteractionEditor_Path, "AppOption_InteractionEditor_Path")
        Me.AppOption_InteractionEditor_Path.Name = "AppOption_InteractionEditor_Path"
        '
        'UI_Tab06_Cat06_SubCat02
        '
        resources.ApplyResources(Me.UI_Tab06_Cat06_SubCat02, "UI_Tab06_Cat06_SubCat02")
        Me.UI_Tab06_Cat06_SubCat02.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat06_SubCat02.Controls.Add(Me.AppOption_MarioSE_SelectPath)
        Me.UI_Tab06_Cat06_SubCat02.Controls.Add(Me.Text_074)
        Me.UI_Tab06_Cat06_SubCat02.Controls.Add(Me.AppOption_MarioSE_Path)
        Me.UI_Tab06_Cat06_SubCat02.Name = "UI_Tab06_Cat06_SubCat02"
        Me.UI_Tab06_Cat06_SubCat02.TabStop = False
        '
        'AppOption_MarioSE_SelectPath
        '
        resources.ApplyResources(Me.AppOption_MarioSE_SelectPath, "AppOption_MarioSE_SelectPath")
        Me.AppOption_MarioSE_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_MarioSE_SelectPath.Name = "AppOption_MarioSE_SelectPath"
        Me.AppOption_MarioSE_SelectPath.TabStop = True
        '
        'Text_074
        '
        resources.ApplyResources(Me.Text_074, "Text_074")
        Me.Text_074.Name = "Text_074"
        '
        'AppOption_MarioSE_Path
        '
        resources.ApplyResources(Me.AppOption_MarioSE_Path, "AppOption_MarioSE_Path")
        Me.AppOption_MarioSE_Path.Name = "AppOption_MarioSE_Path"
        '
        'UI_Tab06_Cat06_SubCat01
        '
        resources.ApplyResources(Me.UI_Tab06_Cat06_SubCat01, "UI_Tab06_Cat06_SubCat01")
        Me.UI_Tab06_Cat06_SubCat01.BackColor = System.Drawing.Color.Transparent
        Me.UI_Tab06_Cat06_SubCat01.Controls.Add(Me.AppOption_Asar_SelectPath)
        Me.UI_Tab06_Cat06_SubCat01.Controls.Add(Me.Text_073)
        Me.UI_Tab06_Cat06_SubCat01.Controls.Add(Me.AppOption_Asar_Path)
        Me.UI_Tab06_Cat06_SubCat01.Name = "UI_Tab06_Cat06_SubCat01"
        Me.UI_Tab06_Cat06_SubCat01.TabStop = False
        '
        'AppOption_Asar_SelectPath
        '
        resources.ApplyResources(Me.AppOption_Asar_SelectPath, "AppOption_Asar_SelectPath")
        Me.AppOption_Asar_SelectPath.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AppOption_Asar_SelectPath.Name = "AppOption_Asar_SelectPath"
        Me.AppOption_Asar_SelectPath.TabStop = True
        '
        'Text_073
        '
        resources.ApplyResources(Me.Text_073, "Text_073")
        Me.Text_073.Name = "Text_073"
        '
        'AppOption_Asar_Path
        '
        resources.ApplyResources(Me.AppOption_Asar_Path, "AppOption_Asar_Path")
        Me.AppOption_Asar_Path.Name = "AppOption_Asar_Path"
        '
        'UI_Tab06_Title01
        '
        resources.ApplyResources(Me.UI_Tab06_Title01, "UI_Tab06_Title01")
        Me.UI_Tab06_Title01.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UI_Tab06_Title01.Name = "UI_Tab06_Title01"
        '
        'Z01_CommandBar_TabControl
        '
        resources.ApplyResources(Me.Z01_CommandBar_TabControl, "Z01_CommandBar_TabControl")
        Me.Z01_CommandBar_TabControl.Controls.Add(Me.Z01_CommandBar_Tab)
        Me.Z01_CommandBar_TabControl.Name = "Z01_CommandBar_TabControl"
        Me.Z01_CommandBar_TabControl.SelectedIndex = 0
        Me.Z01_CommandBar_TabControl.TabStop = False
        '
        'Z01_CommandBar_Tab
        '
        Me.Z01_CommandBar_Tab.Controls.Add(Me.UI_Btn_ExperimentalSettings)
        Me.Z01_CommandBar_Tab.Controls.Add(Me.UI_Btn_UpdatesModal)
        Me.Z01_CommandBar_Tab.Controls.Add(Me.UI_Btn_OK)
        Me.Z01_CommandBar_Tab.Controls.Add(Me.UI_Btn_Cancel)
        Me.Z01_CommandBar_Tab.Controls.Add(Me.UI_Btn_SubOptionsMenu)
        Me.Z01_CommandBar_Tab.Controls.Add(Me.DownArrowMenuPos)
        resources.ApplyResources(Me.Z01_CommandBar_Tab, "Z01_CommandBar_Tab")
        Me.Z01_CommandBar_Tab.Name = "Z01_CommandBar_Tab"
        Me.Z01_CommandBar_Tab.UseVisualStyleBackColor = True
        '
        'UI_Btn_ExperimentalSettings
        '
        resources.ApplyResources(Me.UI_Btn_ExperimentalSettings, "UI_Btn_ExperimentalSettings")
        Me.UI_Btn_ExperimentalSettings.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.ExperimentalSettings
        Me.UI_Btn_ExperimentalSettings.Name = "UI_Btn_ExperimentalSettings"
        Me.UI_Btn_ExperimentalSettings.UseVisualStyleBackColor = True
        '
        'UI_Btn_UpdatesModal
        '
        resources.ApplyResources(Me.UI_Btn_UpdatesModal, "UI_Btn_UpdatesModal")
        Me.UI_Btn_UpdatesModal.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_UpdateAccessBtn
        Me.UI_Btn_UpdatesModal.Name = "UI_Btn_UpdatesModal"
        Me.UI_Btn_UpdatesModal.UseVisualStyleBackColor = True
        '
        'UI_Btn_OK
        '
        resources.ApplyResources(Me.UI_Btn_OK, "UI_Btn_OK")
        Me.UI_Btn_OK.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.SettingsOK
        Me.UI_Btn_OK.Name = "UI_Btn_OK"
        Me.UI_Btn_OK.UseVisualStyleBackColor = True
        '
        'UI_Btn_Cancel
        '
        resources.ApplyResources(Me.UI_Btn_Cancel, "UI_Btn_Cancel")
        Me.UI_Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.UI_Btn_Cancel.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.SettingsCancel
        Me.UI_Btn_Cancel.Name = "UI_Btn_Cancel"
        Me.UI_Btn_Cancel.UseVisualStyleBackColor = True
        '
        'UI_Btn_SubOptionsMenu
        '
        resources.ApplyResources(Me.UI_Btn_SubOptionsMenu, "UI_Btn_SubOptionsMenu")
        Me.UI_Btn_SubOptionsMenu.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_DownArrow
        Me.UI_Btn_SubOptionsMenu.Name = "UI_Btn_SubOptionsMenu"
        Me.UI_Btn_SubOptionsMenu.UseVisualStyleBackColor = True
        '
        'DownArrowMenuPos
        '
        resources.ApplyResources(Me.DownArrowMenuPos, "DownArrowMenuPos")
        Me.DownArrowMenuPos.Name = "DownArrowMenuPos"
        Me.DownArrowMenuPos.TabStop = False
        '
        'Z99_UIDeco02
        '
        resources.ApplyResources(Me.Z99_UIDeco02, "Z99_UIDeco02")
        Me.Z99_UIDeco02.BackColor = System.Drawing.Color.Transparent
        Me.Z99_UIDeco02.Name = "Z99_UIDeco02"
        Me.Z99_UIDeco02.TabStop = False
        '
        'Z99_UIDeco01
        '
        resources.ApplyResources(Me.Z99_UIDeco01, "Z99_UIDeco01")
        Me.Z99_UIDeco01.BackColor = System.Drawing.Color.Transparent
        Me.Z99_UIDeco01.Name = "Z99_UIDeco01"
        Me.Z99_UIDeco01.TabStop = False
        '
        'Z99_UIDeco03
        '
        resources.ApplyResources(Me.Z99_UIDeco03, "Z99_UIDeco03")
        Me.Z99_UIDeco03.Name = "Z99_UIDeco03"
        Me.Z99_UIDeco03.TabStop = False
        '
        'Z99_UIDeco04
        '
        resources.ApplyResources(Me.Z99_UIDeco04, "Z99_UIDeco04")
        Me.Z99_UIDeco04.Name = "Z99_UIDeco04"
        Me.Z99_UIDeco04.TabStop = False
        '
        'DownArrowMenu
        '
        Me.DownArrowMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.DownArrowMenu_ReloadSettings, Me.DownArrowMenu_Sep01, Me.DownArrowMenu_ImportSettings, Me.DownArrowMenu_ExportSettings, Me.DownArrowMenu_Sep02, Me.DownArrowMenu_ResetSettings, Me.DownArrowMenu_Sep03, Me.DownArrowMenu_HD_ExperimentalSettings})
        '
        'DownArrowMenu_ReloadSettings
        '
        Me.DownArrowMenu_Icons.SetImage(Me.DownArrowMenu_ReloadSettings, Global.SMW_MultiTool_Launcher.My.Resources.Resources.SettingsReload)
        Me.DownArrowMenu_ReloadSettings.Index = 0
        resources.ApplyResources(Me.DownArrowMenu_ReloadSettings, "DownArrowMenu_ReloadSettings")
        '
        'DownArrowMenu_Sep01
        '
        Me.DownArrowMenu_Sep01.Index = 1
        resources.ApplyResources(Me.DownArrowMenu_Sep01, "DownArrowMenu_Sep01")
        '
        'DownArrowMenu_ImportSettings
        '
        Me.DownArrowMenu_Icons.SetImage(Me.DownArrowMenu_ImportSettings, Global.SMW_MultiTool_Launcher.My.Resources.Resources.Settings_Import)
        Me.DownArrowMenu_ImportSettings.Index = 2
        resources.ApplyResources(Me.DownArrowMenu_ImportSettings, "DownArrowMenu_ImportSettings")
        '
        'DownArrowMenu_ExportSettings
        '
        Me.DownArrowMenu_Icons.SetImage(Me.DownArrowMenu_ExportSettings, Global.SMW_MultiTool_Launcher.My.Resources.Resources.Settings_Export)
        Me.DownArrowMenu_ExportSettings.Index = 3
        resources.ApplyResources(Me.DownArrowMenu_ExportSettings, "DownArrowMenu_ExportSettings")
        '
        'DownArrowMenu_Sep02
        '
        Me.DownArrowMenu_Sep02.Index = 4
        resources.ApplyResources(Me.DownArrowMenu_Sep02, "DownArrowMenu_Sep02")
        '
        'DownArrowMenu_ResetSettings
        '
        Me.DownArrowMenu_Icons.SetImage(Me.DownArrowMenu_ResetSettings, Global.SMW_MultiTool_Launcher.My.Resources.Resources.Settings_Reset)
        Me.DownArrowMenu_ResetSettings.Index = 5
        resources.ApplyResources(Me.DownArrowMenu_ResetSettings, "DownArrowMenu_ResetSettings")
        '
        'DownArrowMenu_Sep03
        '
        Me.DownArrowMenu_Sep03.Index = 6
        resources.ApplyResources(Me.DownArrowMenu_Sep03, "DownArrowMenu_Sep03")
        '
        'DownArrowMenu_HD_ExperimentalSettings
        '
        Me.DownArrowMenu_Icons.SetImage(Me.DownArrowMenu_HD_ExperimentalSettings, Global.SMW_MultiTool_Launcher.My.Resources.Resources.ExperimentalSettings)
        Me.DownArrowMenu_HD_ExperimentalSettings.Index = 7
        resources.ApplyResources(Me.DownArrowMenu_HD_ExperimentalSettings, "DownArrowMenu_HD_ExperimentalSettings")
        '
        'DownArrowMenu_Icons
        '
        Me.DownArrowMenu_Icons.ContainerControl = Me
        '
        'ExportSettings_SaveFileDialog
        '
        Me.ExportSettings_SaveFileDialog.CheckFileExists = True
        Me.ExportSettings_SaveFileDialog.DefaultExt = "config"
        Me.ExportSettings_SaveFileDialog.FileName = "SMWMTL configuration.config"
        resources.ApplyResources(Me.ExportSettings_SaveFileDialog, "ExportSettings_SaveFileDialog")
        Me.ExportSettings_SaveFileDialog.ValidateNames = False
        '
        'ImportSettings_OpenFileDialog
        '
        Me.ImportSettings_OpenFileDialog.DefaultExt = "config"
        Me.ImportSettings_OpenFileDialog.FileName = "SMWMTL configuration.config"
        resources.ApplyResources(Me.ImportSettings_OpenFileDialog, "ImportSettings_OpenFileDialog")
        Me.ImportSettings_OpenFileDialog.ValidateNames = False
        '
        'SelectFileForShortcut
        '
        resources.ApplyResources(Me.SelectFileForShortcut, "SelectFileForShortcut")
        Me.SelectFileForShortcut.SupportMultiDottedExtensions = True
        '
        'SelectApplicationExecutable_OpenFileBox
        '
        resources.ApplyResources(Me.SelectApplicationExecutable_OpenFileBox, "SelectApplicationExecutable_OpenFileBox")
        '
        'SelectApplicationDirectory_OpenFolderBox
        '
        resources.ApplyResources(Me.SelectApplicationDirectory_OpenFolderBox, "SelectApplicationDirectory_OpenFolderBox")
        '
        'Frm03_Settings
        '
        Me.AcceptButton = Me.UI_Btn_OK
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.UI_Btn_Cancel
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.Z99_UIDeco04)
        Me.Controls.Add(Me.Z99_UIDeco03)
        Me.Controls.Add(Me.Z99_UIDeco01)
        Me.Controls.Add(Me.Z99_UIDeco02)
        Me.Controls.Add(Me.UI_MainSettingsTab)
        Me.Controls.Add(Me.Z01_CommandBar_TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm03_Settings"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.UI_MainSettingsTab.ResumeLayout(False)
        Me.UI_SettingsTab01.ResumeLayout(False)
        Me.UI_SettingsTab01.PerformLayout()
        Me.UI_Tab01_Cat04.ResumeLayout(False)
        Me.UI_Tab01_Cat04.PerformLayout()
        Me.UI_Tab01_Cat03.ResumeLayout(False)
        Me.UI_Tab01_Cat03.PerformLayout()
        CType(Me.AppOption_OpacityValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_Tab01_Cat02.ResumeLayout(False)
        Me.UI_Tab01_Cat02.PerformLayout()
        CType(Me.UI_Tab01_Cat02_UnderOption01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_Tab01_Cat01.ResumeLayout(False)
        Me.UI_SettingsTab02.ResumeLayout(False)
        Me.UI_SettingsTab02.PerformLayout()
        Me.UI_Tab02_Cat03.ResumeLayout(False)
        Me.UI_Tab02_Cat03.PerformLayout()
        CType(Me.Shell32AboutIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UI_Tab02_Cat03_UnderOption02, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_Tab02_Cat04.ResumeLayout(False)
        Me.UI_Tab02_Cat04.PerformLayout()
        CType(Me.BtmBarSeparatorsIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HideBottomBtnsIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AboutButtonIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskmgrButtonIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuiltInWinverButtonIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinverButtonIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportCrashButtonIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuggestUpdateButtonIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HelpButtonIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UI_Tab02_Cat03_UnderOption01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_Tab02_Cat02.ResumeLayout(False)
        Me.UI_Tab02_Cat02.PerformLayout()
        CType(Me.TaskmgrIcon_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Taskmgr_CurrentOSIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_Tab02_Cat01.ResumeLayout(False)
        Me.UI_Tab02_Cat01.PerformLayout()
        CType(Me.WinverIcon_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Winver_CurrentOSIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_SettingsTab03.ResumeLayout(False)
        Me.UI_SettingsTab03.PerformLayout()
        Me.UI_Tab03_Cat03.ResumeLayout(False)
        Me.UI_Tab03_Cat04.ResumeLayout(False)
        Me.UI_Tab03_Cat01.ResumeLayout(False)
        Me.UI_Tab03_Cat01.PerformLayout()
        Me.UI_Tab03_Cat02.ResumeLayout(False)
        Me.UI_SettingsTab04.ResumeLayout(False)
        Me.UI_SettingsTab04.PerformLayout()
        Me.UI_Tab04_Cat05.ResumeLayout(False)
        Me.UI_Tab04_Cat05.PerformLayout()
        Me.UI_Tab04_Cat07.ResumeLayout(False)
        Me.UI_Tab04_Cat07.PerformLayout()
        Me.UI_Tab04_Cat04.ResumeLayout(False)
        Me.UI_Tab04_Cat04.PerformLayout()
        Me.UI_Tab04_Cat06.ResumeLayout(False)
        Me.UI_Tab04_Cat06.PerformLayout()
        Me.UI_Tab04_Cat03.ResumeLayout(False)
        Me.UI_Tab04_Cat03.PerformLayout()
        Me.UI_Tab04_Cat02.ResumeLayout(False)
        Me.UI_Tab04_Cat02.PerformLayout()
        Me.UI_Tab04_Cat01.ResumeLayout(False)
        Me.UI_SettingsTab05.ResumeLayout(False)
        Me.UI_SettingsTab05.PerformLayout()
        Me.UI_Tab05_Cat03.ResumeLayout(False)
        Me.UI_Tab05_Cat03.PerformLayout()
        CType(Me.UI_Tab04_Cat03_UnderOption01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_Tab05_Cat02.ResumeLayout(False)
        Me.UI_Tab05_Cat01.ResumeLayout(False)
        Me.UI_Tab05_Cat01.PerformLayout()
        CType(Me.UI_Tab04_Cat01_UnderOption02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UI_Tab04_Cat01_UnderOption01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_SettingsTab06.ResumeLayout(False)
        Me.UI_SettingsTab06.PerformLayout()
        Me.UI_Tab06_ApplicationTabControl.ResumeLayout(False)
        Me.UI_Tab06_Tab01_LunarMagic.ResumeLayout(False)
        Me.UI_Tab06_Cat01_SubCat04.ResumeLayout(False)
        Me.UI_Tab06_Cat01_SubCat04.PerformLayout()
        Me.UI_Tab06_Cat01_SubCat03.ResumeLayout(False)
        Me.UI_Tab06_Cat01_SubCat03.PerformLayout()
        Me.UI_Tab06_Cat01_SubCat01.ResumeLayout(False)
        Me.UI_Tab06_Cat01_SubCat01.PerformLayout()
        Me.UI_Tab06_Cat01_SubCat02.ResumeLayout(False)
        Me.UI_Tab06_Cat01_SubCat02.PerformLayout()
        Me.UI_Tab06_Tab02_Snes9xBsnes.ResumeLayout(False)
        Me.UI_Tab06_Cat02_SubCat03.ResumeLayout(False)
        Me.UI_Tab06_Cat02_SubCat03.PerformLayout()
        Me.UI_Tab06_Cat02_SubCat02.ResumeLayout(False)
        Me.UI_Tab06_Cat02_SubCat02.PerformLayout()
        Me.UI_Tab06_Cat02_SubCat01.ResumeLayout(False)
        Me.UI_Tab06_Cat02_SubCat01.PerformLayout()
        Me.UI_Tab06_Tab03_SmallHackerTools.ResumeLayout(False)
        Me.UI_Tab06_Cat03_SubCat04.ResumeLayout(False)
        Me.UI_Tab06_Cat03_SubCat05.ResumeLayout(False)
        Me.UI_Tab06_Cat03_SubCat05.PerformLayout()
        Me.UI_Tab06_Cat03_SubCat06.ResumeLayout(False)
        Me.UI_Tab06_Cat03_SubCat06.PerformLayout()
        Me.UI_Tab06_Cat03_SubCat01.ResumeLayout(False)
        Me.UI_Tab06_Cat03_SubCat01.PerformLayout()
        Me.UI_Tab06_Cat03_SubCat10.ResumeLayout(False)
        Me.UI_Tab06_Cat03_SubCat10.PerformLayout()
        Me.UI_Tab06_Cat03_SubCat09.ResumeLayout(False)
        Me.UI_Tab06_Cat03_SubCat09.PerformLayout()
        Me.UI_Tab06_Cat03_SubCat08.ResumeLayout(False)
        Me.UI_Tab06_Cat03_SubCat08.PerformLayout()
        Me.UI_Tab06_Cat03_SubCat03.ResumeLayout(False)
        Me.UI_Tab06_Cat03_SubCat03.PerformLayout()
        Me.UI_Tab06_Cat03_SubCat07.ResumeLayout(False)
        Me.UI_Tab06_Cat03_SubCat07.PerformLayout()
        Me.UI_Tab06_Cat03_SubCat02.ResumeLayout(False)
        Me.UI_Tab06_Cat03_SubCat02.PerformLayout()
        Me.UI_Tab06_Tab04_OtherApps1.ResumeLayout(False)
        Me.UI_Tab06_Cat04_SubCat10.ResumeLayout(False)
        Me.UI_Tab06_Cat04_SubCat10.PerformLayout()
        Me.UI_Tab06_Cat04_SubCat09.ResumeLayout(False)
        Me.UI_Tab06_Cat04_SubCat09.PerformLayout()
        Me.UI_Tab06_Cat04_SubCat08.ResumeLayout(False)
        Me.UI_Tab06_Cat04_SubCat08.PerformLayout()
        Me.UI_Tab06_Cat04_SubCat07.ResumeLayout(False)
        Me.UI_Tab06_Cat04_SubCat07.PerformLayout()
        Me.UI_Tab06_Cat04_SubCat06.ResumeLayout(False)
        Me.UI_Tab06_Cat04_SubCat06.PerformLayout()
        Me.UI_Tab06_Cat04_SubCat05.ResumeLayout(False)
        Me.UI_Tab06_Cat04_SubCat05.PerformLayout()
        Me.UI_Tab06_Cat04_SubCat04.ResumeLayout(False)
        Me.UI_Tab06_Cat04_SubCat04.PerformLayout()
        Me.UI_Tab06_Cat04_SubCat03.ResumeLayout(False)
        Me.UI_Tab06_Cat04_SubCat03.PerformLayout()
        Me.UI_Tab06_Cat04_SubCat02.ResumeLayout(False)
        Me.UI_Tab06_Cat04_SubCat02.PerformLayout()
        Me.UI_Tab06_Cat04_SubCat01.ResumeLayout(False)
        Me.UI_Tab06_Cat04_SubCat01.PerformLayout()
        Me.UI_Tab06_Tab05_OtherApps2.ResumeLayout(False)
        Me.UI_Tab06_Cat05_SubCat02.ResumeLayout(False)
        Me.UI_Tab06_Cat05_SubCat02.PerformLayout()
        Me.UI_Tab06_Cat05_SubCat10.ResumeLayout(False)
        Me.UI_Tab06_Cat05_SubCat10.PerformLayout()
        Me.UI_Tab06_Cat05_SubCat09.ResumeLayout(False)
        Me.UI_Tab06_Cat05_SubCat09.PerformLayout()
        Me.UI_Tab06_Cat05_SubCat08.ResumeLayout(False)
        Me.UI_Tab06_Cat05_SubCat08.PerformLayout()
        Me.UI_Tab06_Cat05_SubCat07.ResumeLayout(False)
        Me.UI_Tab06_Cat05_SubCat07.PerformLayout()
        Me.UI_Tab06_Cat05_SubCat06.ResumeLayout(False)
        Me.UI_Tab06_Cat05_SubCat06.PerformLayout()
        Me.UI_Tab06_Cat05_SubCat05.ResumeLayout(False)
        Me.UI_Tab06_Cat05_SubCat05.PerformLayout()
        Me.UI_Tab06_Cat05_SubCat04.ResumeLayout(False)
        Me.UI_Tab06_Cat05_SubCat04.PerformLayout()
        Me.UI_Tab06_Cat05_SubCat03.ResumeLayout(False)
        Me.UI_Tab06_Cat05_SubCat03.PerformLayout()
        Me.UI_Tab06_Cat05_SubCat01.ResumeLayout(False)
        Me.UI_Tab06_Cat05_SubCat01.PerformLayout()
        Me.UI_Tab06_Tab06_OtherApps3.ResumeLayout(False)
        Me.UI_Tab06_Cat06_SubCat10.ResumeLayout(False)
        Me.UI_Tab06_Cat06_SubCat10.PerformLayout()
        Me.UI_Tab06_Cat06_SubCat09.ResumeLayout(False)
        Me.UI_Tab06_Cat06_SubCat09.PerformLayout()
        Me.UI_Tab06_Cat06_SubCat08.ResumeLayout(False)
        Me.UI_Tab06_Cat06_SubCat08.PerformLayout()
        Me.UI_Tab06_Cat06_SubCat07.ResumeLayout(False)
        Me.UI_Tab06_Cat06_SubCat07.PerformLayout()
        Me.UI_Tab06_Cat06_SubCat06.ResumeLayout(False)
        Me.UI_Tab06_Cat06_SubCat06.PerformLayout()
        Me.UI_Tab06_Cat06_SubCat05.ResumeLayout(False)
        Me.UI_Tab06_Cat06_SubCat05.PerformLayout()
        Me.UI_Tab06_Cat06_SubCat04.ResumeLayout(False)
        Me.UI_Tab06_Cat06_SubCat04.PerformLayout()
        Me.UI_Tab06_Cat06_SubCat03.ResumeLayout(False)
        Me.UI_Tab06_Cat06_SubCat03.PerformLayout()
        Me.UI_Tab06_Cat06_SubCat02.ResumeLayout(False)
        Me.UI_Tab06_Cat06_SubCat02.PerformLayout()
        Me.UI_Tab06_Cat06_SubCat01.ResumeLayout(False)
        Me.UI_Tab06_Cat06_SubCat01.PerformLayout()
        Me.Z01_CommandBar_TabControl.ResumeLayout(False)
        Me.Z01_CommandBar_Tab.ResumeLayout(False)
        CType(Me.DownArrowMenuPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Z99_UIDeco02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Z99_UIDeco01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Z99_UIDeco03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Z99_UIDeco04, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DownArrowMenu_Icons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UI_MainSettingsTab As TabControl
    Friend WithEvents UI_SettingsTab01 As TabPage
    Friend WithEvents UI_SettingsTab02 As TabPage
    Friend WithEvents Z01_CommandBar_TabControl As TabControl
    Friend WithEvents Z01_CommandBar_Tab As TabPage
    Friend WithEvents Z99_UIDeco02 As PictureBox
    Friend WithEvents Z99_UIDeco01 As PictureBox
    Friend WithEvents Z99_UIDeco03 As PictureBox
    Friend WithEvents Z99_UIDeco04 As PictureBox
    Friend WithEvents UI_Tab01_Cat01 As GroupBox
    Friend WithEvents UI_Btn_SubOptionsMenu As Button
    Friend WithEvents UI_Btn_OK As Button
    Friend WithEvents UI_Btn_Cancel As Button
    Friend WithEvents AppOption_HideTitle As CheckBox
    Friend WithEvents AppOption_WinClassicEnhancements As CheckBox
    Friend WithEvents AppOption_DWMExtension As CheckBox
    Friend WithEvents AppOption_ShowBlankIcon As CheckBox
    Friend WithEvents UI_Tab01_Title01 As Label
    Friend WithEvents AppOption_HideIcon As CheckBox
    Friend WithEvents UI_Tab01_Cat02 As GroupBox
    Friend WithEvents AppOption_LockAtTopMost As CheckBox
    Friend WithEvents AppOption_AppOpacity As CheckBox
    Friend WithEvents UI_Tab01_Cat03 As GroupBox
    Friend WithEvents AppOption_AppOpacityApplyMode As ComboBox
    Friend WithEvents Text_001 As Label
    Friend WithEvents UI_Tab01_Cat02_UnderOption01 As PictureBox
    Friend WithEvents UI_SettingsTab03 As TabPage
    Friend WithEvents UI_SettingsTab05 As TabPage
    Friend WithEvents UI_SettingsTab06 As TabPage
    Friend WithEvents UI_Tab02_Cat02 As GroupBox
    Friend WithEvents Text_006 As Label
    Friend WithEvents AppOption_TaskmgrIconBackColor As ComboBox
    Friend WithEvents Text_005 As Label
    Friend WithEvents AppOption_TaskmgrIconLineColor As ComboBox
    Friend WithEvents Taskmgr_CurrentOSIcon As PictureBox
    Friend WithEvents AppOption_TaskmgrIconBasedOnCurrentOS As CheckBox
    Friend WithEvents UI_Tab02_Cat01 As GroupBox
    Friend WithEvents Text_004 As Label
    Friend WithEvents AppOption_WinverIcon As ComboBox
    Friend WithEvents Winver_CurrentOSIcon As PictureBox
    Friend WithEvents AppOption_WinverIconBasedOnCurrentOS As CheckBox
    Friend WithEvents UI_Tab02_Cat03 As GroupBox
    Friend WithEvents AppOption_TitleCustomText As TextBox
    Friend WithEvents ChrCount01 As Label
    Friend WithEvents UI_Tab02_Cat03_UnderOption01 As PictureBox
    Friend WithEvents AppOption_BuiltInAboutWindows_Prewiew As LinkLabel
    Friend WithEvents AppOption_DisplayTaskmgrButton As CheckBox
    Friend WithEvents AppOption_DisplayWinverButton As CheckBox
    Friend WithEvents AppOption_BuiltInWinver As CheckBox
    Friend WithEvents AppOption_DisplayReportCrashButton As CheckBox
    Friend WithEvents AppOption_DisplaySuggestUpdateButton As CheckBox
    Friend WithEvents AppOption_DisplayHelpButton As CheckBox
    Friend WithEvents AppOption_OpacityValue As TrackBar
    Friend WithEvents AppOption_OpacityPercentage As Label
    Friend WithEvents Text_002 As Label
    Friend WithEvents AppOption_AdditionalTitleTextType As ComboBox
    Friend WithEvents AppOption_CustomTitleText As CheckBox
    Friend WithEvents AppOption_CustomTextFormattingCodes As LinkLabel
    Friend WithEvents AppOption_DarkThemeToggle As CheckBox
    Friend WithEvents UI_Btn_UpdatesModal As Button
    Friend WithEvents TaskmgrIcon_Preview As PictureBox
    Friend WithEvents WinverIcon_Preview As PictureBox
    Friend WithEvents UI_Tab02_Title01 As Label
    Friend WithEvents HelpButtonIcon As PictureBox
    Friend WithEvents TaskmgrButtonIcon As PictureBox
    Friend WithEvents BuiltInWinverButtonIcon As PictureBox
    Friend WithEvents WinverButtonIcon As PictureBox
    Friend WithEvents ReportCrashButtonIcon As PictureBox
    Friend WithEvents SuggestUpdateButtonIcon As PictureBox
    Friend WithEvents UI_Tab01_Cat04 As GroupBox
    Friend WithEvents Text_003 As Label
    Friend WithEvents AppOption_Theme As ComboBox
    Friend WithEvents UI_Tab02_Cat04 As GroupBox
    Friend WithEvents BtmBarSeparatorsIcon As PictureBox
    Friend WithEvents AppOption_BtmBarSeparators As CheckBox
    Friend WithEvents HideBottomBtnsIcon As PictureBox
    Friend WithEvents AppOption_HideBottomBtns As CheckBox
    Friend WithEvents UI_Tab01_Title02 As Label
    Friend WithEvents DownArrowMenu As ContextMenu
    Friend WithEvents DownArrowMenu_ReloadSettings As MenuItem
    Friend WithEvents DownArrowMenuPos As PictureBox
    Friend WithEvents DownArrowMenu_Sep01 As MenuItem
    Friend WithEvents DownArrowMenu_ImportSettings As MenuItem
    Friend WithEvents DownArrowMenu_ExportSettings As MenuItem
    Friend WithEvents DownArrowMenu_ResetSettings As MenuItem
    Friend WithEvents DownArrowMenu_Icons As wyDay.Controls.VistaMenu
    Friend WithEvents AboutButtonIcon As PictureBox
    Friend WithEvents AppOption_DisplayAboutButton As CheckBox
    Friend WithEvents Shell32AboutIcon As PictureBox
    Friend WithEvents AppOption_UseShell32About As CheckBox
    Friend WithEvents UI_Tab02_Cat03_UnderOption02 As PictureBox
    Friend WithEvents DownArrowMenu_Sep02 As MenuItem
    Friend WithEvents UI_Tab03_Cat02 As GroupBox
    Friend WithEvents AppOption_HideVersionStringInAboutBox As CheckBox
    Friend WithEvents AppOption_EnableLegacyAboutBox As CheckBox
    Friend WithEvents AppOption_DisplayCompleteVersionOnMainWindow As CheckBox
    Friend WithEvents UI_Tab03_Title01 As Label
    Friend WithEvents UI_Tab03_Cat01 As GroupBox
    Friend WithEvents AppOption_ColumnsNumberComboBox As ComboBox
    Friend WithEvents Text_007 As Label
    Friend WithEvents AppOption_DisplayBtn_Btn35 As CheckBox
    Friend WithEvents AppOption_DisplayBtn_GradientTool As CheckBox
    Friend WithEvents AppOption_DisplayBtn_UberASM As CheckBox
    Friend WithEvents AppOption_DisplayBtn_SHTools As CheckBox
    Friend WithEvents AppOption_DisplayBtn_SMWCust As CheckBox
    Friend WithEvents AppOption_DisplayBtn_YYCHR As CheckBox
    Friend WithEvents AppOption_DisplayBtn_GraphEdit As CheckBox
    Friend WithEvents AppOption_DisplayBtn_GopherPopcornStew As CheckBox
    Friend WithEvents AppOption_DisplayBtn_Btn34 As CheckBox
    Friend WithEvents AppOption_DisplayBtn_EffectTools As CheckBox
    Friend WithEvents AppOption_DisplayBtn_SPCTool As CheckBox
    Friend WithEvents AppOption_DisplayBtn_StatusEffects As CheckBox
    Friend WithEvents AppOption_DisplayBtn_Flips As CheckBox
    Friend WithEvents AppOption_DisplayBtn_SPC700Player As CheckBox
    Friend WithEvents AppOption_DisplayBtn_Mode7Tilemap As CheckBox
    Friend WithEvents AppOption_DisplayBtn_Pixi As CheckBox
    Friend WithEvents AppOption_DisplayBtn_Blockreator As CheckBox
    Friend WithEvents AppOption_DisplayBtn_BRRPlayer As CheckBox
    Friend WithEvents AppOption_DisplayBtn_LvMusUtil As CheckBox
    Friend WithEvents AppOption_DisplayBtn_AddMusicK As CheckBox
    Friend WithEvents AppOption_DisplayBtn_MMLEdit As CheckBox
    Friend WithEvents AppOption_DisplayBtn_HDMARipper As CheckBox
    Friend WithEvents AppOption_DisplayBtn_HeAdder As CheckBox
    Friend WithEvents AppOption_DisplayBtn_MarioLPE As CheckBox
    Friend WithEvents AppOption_DisplayBtn_SnesGFX As CheckBox
    Friend WithEvents AppOption_DisplayBtn_RecoverLM As CheckBox
    Friend WithEvents AppOption_DisplayBtn_LunarExpand As CheckBox
    Friend WithEvents AppOption_DisplayBtn_LunarMagic As CheckBox
    Friend WithEvents Text_008 As Label
    Friend WithEvents AppOption_DisplayBtn_SpriteGFX As CheckBox
    Friend WithEvents AppOption_DisplayBtn_MultipleMidwayPoints As CheckBox
    Friend WithEvents AppOption_DisplayBtn_InteractionEdit As CheckBox
    Friend WithEvents AppOption_DisplayBtn_MarioStartEditor As CheckBox
    Friend WithEvents AppOption_DisplayBtn_Snes9x As CheckBox
    Friend WithEvents AppOption_DisplayBtn_Asar As CheckBox
    Friend WithEvents AppOption_DisplayBtn_PetiteMM As CheckBox
    Friend WithEvents AppOption_DisplayBtn_UncheckAll As Button
    Friend WithEvents AppOption_DisplayBtn_CheckAll As Button
    Friend WithEvents AppNames_HideBtnSettings As ToolTip
    Friend WithEvents UI_Tab03_Cat03 As GroupBox
    Friend WithEvents AppOption_ShowSystrayIcon As CheckBox
    Friend WithEvents UI_Tab03_Cat04 As GroupBox
    Friend WithEvents AppOption_OpenAboutDialogKeyboardShortcut As CheckBox
    Friend WithEvents AppOption_OpenSuggestUpdateKeyboardShortcut As CheckBox
    Friend WithEvents AppOption_OpenHelpKeyboardShortcut As CheckBox
    Friend WithEvents AppOption_CustomShortcutsKeyboardShortcut As CheckBox
    Friend WithEvents AppOption_OpenSettingsKeyboardShortcut As CheckBox
    Friend WithEvents AppOption_QuickRestartKeyboardShortcut As CheckBox
    Friend WithEvents UI_Tab05_Title01 As Label
    Friend WithEvents UI_Tab05_Cat01 As GroupBox
    Friend WithEvents AppOption_SearchUpdateAtAppStart As CheckBox
    Friend WithEvents AppOption_UpdateAutomaticInstall As CheckBox
    Friend WithEvents AppOption_UpdateAutomaticDownload As CheckBox
    Friend WithEvents AppOption_DisplayUpdateSearchModuleOnAboutWindow As CheckBox
    Friend WithEvents AppOption_UpdateAtStartup_DiscreteMode As CheckBox
    Friend WithEvents UI_Tab04_Cat01_UnderOption01 As PictureBox
    Friend WithEvents AppOption_UseLegacyUpdatePopups As CheckBox
    Friend WithEvents UI_Tab04_Cat01_UnderOption02 As PictureBox
    Friend WithEvents UI_Tab05_Cat02 As GroupBox
    Friend WithEvents UI_Tab05_Cat03 As GroupBox
    Friend WithEvents UI_SettingsTab04 As TabPage
    Friend WithEvents ExportSettings_SaveFileDialog As SaveFileDialog
    Friend WithEvents ImportSettings_OpenFileDialog As OpenFileDialog
    Friend WithEvents UI_Tab04_Title01 As Label
    Friend WithEvents UI_Tab04_Cat01 As GroupBox
    Friend WithEvents AppOption_EnableCustomShortcuts As CheckBox
    Friend WithEvents UI_Tab04_Cat05 As GroupBox
    Friend WithEvents UI_Tab04_Cat07 As GroupBox
    Friend WithEvents UI_Tab04_Cat04 As GroupBox
    Friend WithEvents UI_Tab04_Cat06 As GroupBox
    Friend WithEvents UI_Tab04_Cat03 As GroupBox
    Friend WithEvents UI_Tab04_Cat02 As GroupBox
    Friend WithEvents AppOption_EnableCustomShortcut_4 As CheckBox
    Friend WithEvents AppOption_EnableCustomShortcut_6 As CheckBox
    Friend WithEvents AppOption_EnableCustomShortcut_3 As CheckBox
    Friend WithEvents AppOption_EnableCustomShortcut_5 As CheckBox
    Friend WithEvents AppOption_EnableCustomShortcut_2 As CheckBox
    Friend WithEvents AppOption_EnableCustomShortcut_1 As CheckBox
    Friend WithEvents Text_009 As Label
    Friend WithEvents AppOption_Shortcut1_LaunchWith As ComboBox
    Friend WithEvents Text_010 As Label
    Friend WithEvents AppOption_Shortcut1_SelectFile As LinkLabel
    Friend WithEvents AppOption_Shortcut1_Icon As ComboBox
    Friend WithEvents Text_011 As Label
    Friend WithEvents AppOption_Shortcut2_SelectFile As LinkLabel
    Friend WithEvents AppOption_Shortcut2_Icon As ComboBox
    Friend WithEvents Text_012 As Label
    Friend WithEvents Text_014 As Label
    Friend WithEvents AppOption_Shortcut2_LaunchWith As ComboBox
    Friend WithEvents Text_013 As Label
    Friend WithEvents AppOption_Shortcut1_Path As TextBox
    Friend WithEvents AppOption_Shortcut2_Path As TextBox
    Friend WithEvents AppOption_Shortcut4_Path As TextBox
    Friend WithEvents AppOption_Shortcut4_SelectFile As LinkLabel
    Friend WithEvents Text_018 As Label
    Friend WithEvents AppOption_Shortcut4_Icon As ComboBox
    Friend WithEvents Text_019 As Label
    Friend WithEvents Text_020 As Label
    Friend WithEvents AppOption_Shortcut4_LaunchWith As ComboBox
    Friend WithEvents AppOption_Shortcut6_Path As TextBox
    Friend WithEvents Text_024 As Label
    Friend WithEvents Text_025 As Label
    Friend WithEvents AppOption_Shortcut6_SelectFile As LinkLabel
    Friend WithEvents AppOption_Shortcut6_Icon As ComboBox
    Friend WithEvents AppOption_Shortcut6_LaunchWith As ComboBox
    Friend WithEvents Text_026 As Label
    Friend WithEvents AppOption_Shortcut3_Path As TextBox
    Friend WithEvents AppOption_Shortcut3_SelectFile As LinkLabel
    Friend WithEvents AppOption_Shortcut3_Icon As ComboBox
    Friend WithEvents Text_017 As Label
    Friend WithEvents AppOption_Shortcut3_LaunchWith As ComboBox
    Friend WithEvents Text_016 As Label
    Friend WithEvents Text_015 As Label
    Friend WithEvents AppOption_Shortcut5_Path As TextBox
    Friend WithEvents Text_021 As Label
    Friend WithEvents AppOption_Shortcut5_SelectFile As LinkLabel
    Friend WithEvents AppOption_Shortcut5_LaunchWith As ComboBox
    Friend WithEvents Text_023 As Label
    Friend WithEvents AppOption_Shortcut5_Icon As ComboBox
    Friend WithEvents Text_022 As Label
    Friend WithEvents SelectFileForShortcut As OpenFileDialog
    Friend WithEvents SelectApplicationExecutable_OpenFileBox As OpenFileDialog
    Friend WithEvents AppOption_DisplayUpdateSearchVersionOnAboutWindow As CheckBox
    Friend WithEvents UI_Tab06_Title01 As Label
    Friend WithEvents UI_Tab06_Cat01_SubCat01 As GroupBox
    Friend WithEvents Text_027 As Label
    Friend WithEvents AppOption_LMslot1_Name As TextBox
    Friend WithEvents AppOption_LMslot1_Version As ComboBox
    Friend WithEvents Text_028 As Label
    Friend WithEvents AppOption_LMslot1_Path As TextBox
    Friend WithEvents Text_029 As Label
    Friend WithEvents AppOption_LMslot1_SelectExecutable As LinkLabel
    Friend WithEvents UI_Tab06_Cat01_SubCat03 As GroupBox
    Friend WithEvents AppOption_LMslot3_SelectExecutable As LinkLabel
    Friend WithEvents AppOption_LMslot3_Path As TextBox
    Friend WithEvents Text_035 As Label
    Friend WithEvents Text_033 As Label
    Friend WithEvents AppOption_LMslot3_Name As TextBox
    Friend WithEvents AppOption_LMslot3_Version As ComboBox
    Friend WithEvents Text_034 As Label
    Friend WithEvents UI_Tab06_Cat01_SubCat02 As GroupBox
    Friend WithEvents AppOption_LMslot2_SelectExecutable As LinkLabel
    Friend WithEvents AppOption_LMslot2_Path As TextBox
    Friend WithEvents Text_032 As Label
    Friend WithEvents Text_030 As Label
    Friend WithEvents AppOption_LMslot2_Name As TextBox
    Friend WithEvents AppOption_LMslot2_Version As ComboBox
    Friend WithEvents Text_031 As Label
    Friend WithEvents UI_Tab06_ApplicationTabControl As TabControl
    Friend WithEvents UI_Tab06_Tab01_LunarMagic As TabPage
    Friend WithEvents UI_Tab06_Tab02_Snes9xBsnes As TabPage
    Friend WithEvents AppOption_EnableLMSlot3 As CheckBox
    Friend WithEvents AppOption_EnableLMSlot1 As CheckBox
    Friend WithEvents AppOption_EnableLMSlot2 As CheckBox
    Friend WithEvents UI_Tab06_Cat01_SubCat04 As GroupBox
    Friend WithEvents AppOption_LM1CTL_DisplaySelectorOnCTRLClick As CheckBox
    Friend WithEvents AppOption_EnableLM1CTL As CheckBox
    Friend WithEvents AppOption_LM1CTL_VersionSelector As ComboBox
    Friend WithEvents Text_036 As Label
    Friend WithEvents AppOption_EnableHeaderMagicLMSlot3 As CheckBox
    Friend WithEvents AppOption_EnableHeaderMagicLMSlot1 As CheckBox
    Friend WithEvents AppOption_EnableHeaderMagicLMSlot2 As CheckBox
    Friend WithEvents UI_Tab06_Cat02_SubCat03 As GroupBox
    Friend WithEvents AppOption_SelectBsnesExecutable As LinkLabel
    Friend WithEvents Text_041 As Label
    Friend WithEvents AppOption_BsnesExecutable As TextBox
    Friend WithEvents UI_Tab06_Cat02_SubCat02 As GroupBox
    Friend WithEvents AppOption_Snes9x_Selectx64Executable As LinkLabel
    Friend WithEvents AppOption_Snes9x_Selectx86Executable As LinkLabel
    Friend WithEvents Text_039 As Label
    Friend WithEvents AppOption_Snes9x_UseColoredIcon As CheckBox
    Friend WithEvents AppOption_Snes9x_x64Executable As TextBox
    Friend WithEvents Text_038 As Label
    Friend WithEvents AppOption_Snes9x_x86Executable As TextBox
    Friend WithEvents Text_040 As Label
    Friend WithEvents AppOption_Snes9x_SelectedArch As ComboBox
    Friend WithEvents UI_Tab06_Cat02_SubCat01 As GroupBox
    Friend WithEvents Text_037 As Label
    Friend WithEvents AppOption_SnesEmuSelector As ComboBox
    Friend WithEvents UI_Tab06_Tab03_SmallHackerTools As TabPage
    Friend WithEvents UI_Tab06_Tab04_OtherApps1 As TabPage
    Friend WithEvents UI_Tab06_Cat03_SubCat10 As GroupBox
    Friend WithEvents AppOption_SMWTYMI_SelectPath As LinkLabel
    Friend WithEvents Text_050 As Label
    Friend WithEvents AppOption_SMWTYMI_Path As TextBox
    Friend WithEvents UI_Tab06_Cat03_SubCat06 As GroupBox
    Friend WithEvents AppOption_SMWENE_SelectPath As LinkLabel
    Friend WithEvents Text_046 As Label
    Friend WithEvents AppOption_SMWENE_Path As TextBox
    Friend WithEvents UI_Tab06_Cat03_SubCat09 As GroupBox
    Friend WithEvents AppOption_SMWSBE_SelectPath As LinkLabel
    Friend WithEvents Text_049 As Label
    Friend WithEvents AppOption_SMWSBE_Path As TextBox
    Friend WithEvents UI_Tab06_Cat03_SubCat05 As GroupBox
    Friend WithEvents AppOption_SMWENI_SelectPath As LinkLabel
    Friend WithEvents Text_045 As Label
    Friend WithEvents AppOption_SMWENI_Path As TextBox
    Friend WithEvents UI_Tab06_Cat03_SubCat08 As GroupBox
    Friend WithEvents AppOption_SMWPTE_SelectPath As LinkLabel
    Friend WithEvents Text_048 As Label
    Friend WithEvents AppOption_SMWPTE_Path As TextBox
    Friend WithEvents UI_Tab06_Cat03_SubCat03 As GroupBox
    Friend WithEvents AppOption_SMWBBPE_SelectPath As LinkLabel
    Friend WithEvents Text_044 As Label
    Friend WithEvents AppOption_SMWBBPE_Path As TextBox
    Friend WithEvents UI_Tab06_Cat03_SubCat07 As GroupBox
    Friend WithEvents AppOption_SMWMTE_SelectPath As LinkLabel
    Friend WithEvents Text_047 As Label
    Friend WithEvents AppOption_SMWMTE_Path As TextBox
    Friend WithEvents UI_Tab06_Cat03_SubCat02 As GroupBox
    Friend WithEvents AppOption_ILBPE_SelectPath As LinkLabel
    Friend WithEvents Text_043 As Label
    Friend WithEvents AppOption_ILBPE_Path As TextBox
    Friend WithEvents UI_Tab06_Cat03_SubCat01 As GroupBox
    Friend WithEvents Text_042 As Label
    Friend WithEvents AppOption_DisplayBtn_SMWTYMI As CheckBox
    Friend WithEvents AppOption_DisplayBtn_SMWSBE As CheckBox
    Friend WithEvents AppOption_DisplayBtn_SMWPTE As CheckBox
    Friend WithEvents AppOption_DisplayBtn_SMWMTE As CheckBox
    Friend WithEvents AppOption_DisplayBtn_SMWENE As CheckBox
    Friend WithEvents AppOption_DisplayBtn_SMWENI As CheckBox
    Friend WithEvents AppOption_DisplayBtn_SMWBBPE As CheckBox
    Friend WithEvents AppOption_DisplayBtn_ILBPE As CheckBox
    Friend WithEvents UI_Tab06_Cat03_SubCat04 As GroupBox
    Friend WithEvents UI_Tab06_Tab05_OtherApps2 As TabPage
    Friend WithEvents UI_Tab06_Tab06_OtherApps3 As TabPage
    Friend WithEvents UI_Tab06_Cat04_SubCat10 As GroupBox
    Friend WithEvents AppOption_BRRPlayer_SelectPath As LinkLabel
    Friend WithEvents Text_061 As Label
    Friend WithEvents AppOption_BRRPlayer_Path As TextBox
    Friend WithEvents UI_Tab06_Cat04_SubCat09 As GroupBox
    Friend WithEvents AppOption_LvMusUtil_SelectPath As LinkLabel
    Friend WithEvents Text_060 As Label
    Friend WithEvents AppOption_LvMusUtil_Path As TextBox
    Friend WithEvents UI_Tab06_Cat04_SubCat08 As GroupBox
    Friend WithEvents AppOption_AMK_GUI_SelectPath As LinkLabel
    Friend WithEvents Text_059 As Label
    Friend WithEvents AppOption_AMK_GUI_Path As TextBox
    Friend WithEvents AppOption_AMK_CMD_SelectPath As LinkLabel
    Friend WithEvents Text_058 As Label
    Friend WithEvents AppOption_AMK_CMD_Path As TextBox
    Friend WithEvents UI_Tab06_Cat04_SubCat07 As GroupBox
    Friend WithEvents AppOption_MMLEdit_SelectPath As LinkLabel
    Friend WithEvents Text_057 As Label
    Friend WithEvents AppOption_MMLEdit_Path As TextBox
    Friend WithEvents UI_Tab06_Cat04_SubCat06 As GroupBox
    Friend WithEvents AppOption_HdmaGR_SelectPath As LinkLabel
    Friend WithEvents Text_056 As Label
    Friend WithEvents AppOption_HdmaGR_Path As TextBox
    Friend WithEvents UI_Tab06_Cat04_SubCat05 As GroupBox
    Friend WithEvents AppOption_HeAdder_SelectPath As LinkLabel
    Friend WithEvents Text_055 As Label
    Friend WithEvents AppOption_HeAdder_Path As TextBox
    Friend WithEvents UI_Tab06_Cat04_SubCat04 As GroupBox
    Friend WithEvents AppOption_MarioLuigiLPE_SelectPath As LinkLabel
    Friend WithEvents Text_054 As Label
    Friend WithEvents AppOption_MarioLuigiLPE_Path As TextBox
    Friend WithEvents UI_Tab06_Cat04_SubCat03 As GroupBox
    Friend WithEvents AppOption_SnesGFX_SelectPath As LinkLabel
    Friend WithEvents Text_053 As Label
    Friend WithEvents AppOption_SnesGFX_Path As TextBox
    Friend WithEvents UI_Tab06_Cat04_SubCat02 As GroupBox
    Friend WithEvents AppOption_RecoverLM_SelectPath As LinkLabel
    Friend WithEvents Text_052 As Label
    Friend WithEvents AppOption_RecoverLM_Path As TextBox
    Friend WithEvents UI_Tab06_Cat04_SubCat01 As GroupBox
    Friend WithEvents AppOption_LunarExpand_SelectPath As LinkLabel
    Friend WithEvents Text_051 As Label
    Friend WithEvents AppOption_LunarExpand_Path As TextBox
    Friend WithEvents UI_Tab06_Cat05_SubCat10 As GroupBox
    Friend WithEvents AppOption_PetiteMM_SelectPath As LinkLabel
    Friend WithEvents Text_072 As Label
    Friend WithEvents AppOption_PetiteMM_Path As TextBox
    Friend WithEvents UI_Tab06_Cat05_SubCat09 As GroupBox
    Friend WithEvents AppOption_GPS_SelectPath As LinkLabel
    Friend WithEvents Text_071 As Label
    Friend WithEvents AppOption_GPS_Path As TextBox
    Friend WithEvents UI_Tab06_Cat05_SubCat08 As GroupBox
    Friend WithEvents AppOption_EffectTool_SelectPath As LinkLabel
    Friend WithEvents Text_070 As Label
    Friend WithEvents AppOption_EffectTool_Path As TextBox
    Friend WithEvents UI_Tab06_Cat05_SubCat07 As GroupBox
    Friend WithEvents AppOption_SnesColorTool_SelectPath As LinkLabel
    Friend WithEvents Text_069 As Label
    Friend WithEvents AppOption_SnesColorTool_Path As TextBox
    Friend WithEvents UI_Tab06_Cat05_SubCat06 As GroupBox
    Friend WithEvents AppOption_StatusEffects_SelectPath As LinkLabel
    Friend WithEvents Text_068 As Label
    Friend WithEvents AppOption_StatusEffects_Path As TextBox
    Friend WithEvents UI_Tab06_Cat05_SubCat05 As GroupBox
    Friend WithEvents AppOption_FloatingIPS_SelectPath As LinkLabel
    Friend WithEvents Text_067 As Label
    Friend WithEvents AppOption_FloatingIPS_Path As TextBox
    Friend WithEvents UI_Tab06_Cat05_SubCat04 As GroupBox
    Friend WithEvents AppOption_SPC700Player_SelectPath As LinkLabel
    Friend WithEvents Text_066 As Label
    Friend WithEvents AppOption_SPC700Player_Path As TextBox
    Friend WithEvents UI_Tab06_Cat05_SubCat03 As GroupBox
    Friend WithEvents AppOption_M7Map_SelectPath As LinkLabel
    Friend WithEvents Text_065 As Label
    Friend WithEvents AppOption_M7Map_Path As TextBox
    Friend WithEvents UI_Tab06_Cat05_SubCat01 As GroupBox
    Friend WithEvents AppOption_Blockreator_SelectPath As LinkLabel
    Friend WithEvents Text_062 As Label
    Friend WithEvents AppOption_Blockreator_Path As TextBox
    Friend WithEvents UI_Tab06_Cat05_SubCat02 As GroupBox
    Friend WithEvents AppOption_PixiConfigurator_SelectPath As LinkLabel
    Friend WithEvents Text_064 As Label
    Friend WithEvents AppOption_PixiConfigurator_Path As TextBox
    Friend WithEvents AppOption_Pixi_SelectPath As LinkLabel
    Friend WithEvents Text_063 As Label
    Friend WithEvents AppOption_Pixi_Path As TextBox
    Friend WithEvents SelectApplicationDirectory_OpenFolderBox As FolderBrowserDialog
    Friend WithEvents UI_Tab06_Cat06_SubCat10 As GroupBox
    Friend WithEvents AppOption_GradientTool_SelectPath As LinkLabel
    Friend WithEvents Text_082 As Label
    Friend WithEvents AppOption_GradientTool_Path As TextBox
    Friend WithEvents UI_Tab06_Cat06_SubCat09 As GroupBox
    Friend WithEvents AppOption_UberASM_SelectPath As LinkLabel
    Friend WithEvents Text_081 As Label
    Friend WithEvents AppOption_UberASM_Path As TextBox
    Friend WithEvents UI_Tab06_Cat06_SubCat08 As GroupBox
    Friend WithEvents AppOption_SMWCustomizer_SelectPath As LinkLabel
    Friend WithEvents Text_080 As Label
    Friend WithEvents AppOption_SMWCustomizer_Path As TextBox
    Friend WithEvents UI_Tab06_Cat06_SubCat07 As GroupBox
    Friend WithEvents AppOption_YYCHR_SelectPath As LinkLabel
    Friend WithEvents Text_079 As Label
    Friend WithEvents AppOption_YYCHR_Path As TextBox
    Friend WithEvents UI_Tab06_Cat06_SubCat06 As GroupBox
    Friend WithEvents AppOption_GraphicEditor_SelectPath As LinkLabel
    Friend WithEvents Text_078 As Label
    Friend WithEvents AppOption_GraphicEditor_Path As TextBox
    Friend WithEvents UI_Tab06_Cat06_SubCat05 As GroupBox
    Friend WithEvents AppOption_SpriteGFX_SelectPath As LinkLabel
    Friend WithEvents Text_077 As Label
    Friend WithEvents AppOption_SpriteGFX_Path As TextBox
    Friend WithEvents UI_Tab06_Cat06_SubCat04 As GroupBox
    Friend WithEvents AppOption_MultipleMidwayPoints_SelectPath As LinkLabel
    Friend WithEvents Text_076 As Label
    Friend WithEvents AppOption_MultipleMidwayPoints_Path As TextBox
    Friend WithEvents UI_Tab06_Cat06_SubCat03 As GroupBox
    Friend WithEvents AppOption_InteractionEditor_SelectPath As LinkLabel
    Friend WithEvents Text_075 As Label
    Friend WithEvents AppOption_InteractionEditor_Path As TextBox
    Friend WithEvents UI_Tab06_Cat06_SubCat02 As GroupBox
    Friend WithEvents AppOption_MarioSE_SelectPath As LinkLabel
    Friend WithEvents Text_074 As Label
    Friend WithEvents AppOption_MarioSE_Path As TextBox
    Friend WithEvents UI_Tab06_Cat06_SubCat01 As GroupBox
    Friend WithEvents AppOption_Asar_SelectPath As LinkLabel
    Friend WithEvents Text_073 As Label
    Friend WithEvents AppOption_Asar_Path As TextBox
    Friend WithEvents AppOption_UpdateAutomaticInstallSilentMode As CheckBox
    Friend WithEvents UI_Tab04_Cat03_UnderOption01 As PictureBox
    Friend WithEvents DownArrowMenu_Sep03 As MenuItem
    Friend WithEvents DownArrowMenu_HD_ExperimentalSettings As MenuItem
    Friend WithEvents UI_Btn_ExperimentalSettings As Button
End Class
