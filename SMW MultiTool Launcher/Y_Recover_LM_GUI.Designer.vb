<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Y_Recover_LM_GUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Y_Recover_LM_GUI))
        Me.FileToUnlock_Text = New System.Windows.Forms.Label()
        Me.UnlockedFile_Text = New System.Windows.Forms.Label()
        Me.FileToUnlock_TextBox = New System.Windows.Forms.TextBox()
        Me.UnlockedFile_TextBox = New System.Windows.Forms.TextBox()
        Me.ROM_To_Unlock_BrowseBtn = New System.Windows.Forms.Button()
        Me.Unlocked_ROM_BrowseBtn = New System.Windows.Forms.Button()
        Me.RecoverBtn = New System.Windows.Forms.Button()
        Me.ConsoleOutput_RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ConsoleOutput_Groupbox = New System.Windows.Forms.GroupBox()
        Me.Informations_Groupbox = New System.Windows.Forms.GroupBox()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.ConsoleOutputZoom_Text = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UnlockStatus_Text = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OpenLockedROM = New System.Windows.Forms.OpenFileDialog()
        Me.SaveUnlockedROM = New System.Windows.Forms.SaveFileDialog()
        Me.ExportConsoleOutput = New System.Windows.Forms.SaveFileDialog()
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.Menu_MenuItem = New System.Windows.Forms.MenuItem()
        Me.ResetWindow_MenuItem = New System.Windows.Forms.MenuItem()
        Me.ShowStatusBar_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Separator1 = New System.Windows.Forms.MenuItem()
        Me.Close_MenuItem = New System.Windows.Forms.MenuItem()
        Me.ConsoleOutput_MenuItem = New System.Windows.Forms.MenuItem()
        Me.ShowConsoleOutput_MenuItem = New System.Windows.Forms.MenuItem()
        Me.ClearConsoleOutput_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Separator2 = New System.Windows.Forms.MenuItem()
        Me.ConsoleOutput_Submenu = New System.Windows.Forms.MenuItem()
        Me.Zoom1x_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Zoom2x_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Zoom3x_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Zoom4x_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Zoom5x_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Zoom6x_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Zoom7x_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Zoom8x_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Zoom9x_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Zoom10x_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Separator5 = New System.Windows.Forms.MenuItem()
        Me.CustomZoom_MenuItem = New System.Windows.Forms.MenuItem()
        Me.ResetZoom_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Separator3 = New System.Windows.Forms.MenuItem()
        Me.ExportConsoleOutput_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Help_MenuItem = New System.Windows.Forms.MenuItem()
        Me.HowToUse_MenuItem = New System.Windows.Forms.MenuItem()
        Me.Separator4 = New System.Windows.Forms.MenuItem()
        Me.About_MenuItem = New System.Windows.Forms.MenuItem()
        Me.MenuItems_Icons = New SMWMTLextensions.ControlExtensions.NativeMenuIcon(Me.components)
        Me.ConsoleOutput_Groupbox.SuspendLayout()
        Me.Informations_Groupbox.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        CType(Me.MenuItems_Icons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileToUnlock_Text
        '
        resources.ApplyResources(Me.FileToUnlock_Text, "FileToUnlock_Text")
        Me.FileToUnlock_Text.Name = "FileToUnlock_Text"
        '
        'UnlockedFile_Text
        '
        resources.ApplyResources(Me.UnlockedFile_Text, "UnlockedFile_Text")
        Me.UnlockedFile_Text.Name = "UnlockedFile_Text"
        '
        'FileToUnlock_TextBox
        '
        resources.ApplyResources(Me.FileToUnlock_TextBox, "FileToUnlock_TextBox")
        Me.FileToUnlock_TextBox.BackColor = System.Drawing.Color.White
        Me.FileToUnlock_TextBox.Name = "FileToUnlock_TextBox"
        '
        'UnlockedFile_TextBox
        '
        resources.ApplyResources(Me.UnlockedFile_TextBox, "UnlockedFile_TextBox")
        Me.UnlockedFile_TextBox.BackColor = System.Drawing.Color.White
        Me.UnlockedFile_TextBox.Name = "UnlockedFile_TextBox"
        '
        'ROM_To_Unlock_BrowseBtn
        '
        resources.ApplyResources(Me.ROM_To_Unlock_BrowseBtn, "ROM_To_Unlock_BrowseBtn")
        Me.ROM_To_Unlock_BrowseBtn.Name = "ROM_To_Unlock_BrowseBtn"
        Me.ROM_To_Unlock_BrowseBtn.UseVisualStyleBackColor = True
        '
        'Unlocked_ROM_BrowseBtn
        '
        resources.ApplyResources(Me.Unlocked_ROM_BrowseBtn, "Unlocked_ROM_BrowseBtn")
        Me.Unlocked_ROM_BrowseBtn.Name = "Unlocked_ROM_BrowseBtn"
        Me.Unlocked_ROM_BrowseBtn.UseVisualStyleBackColor = True
        '
        'RecoverBtn
        '
        resources.ApplyResources(Me.RecoverBtn, "RecoverBtn")
        Me.RecoverBtn.Name = "RecoverBtn"
        Me.RecoverBtn.UseVisualStyleBackColor = True
        '
        'ConsoleOutput_RichTextBox
        '
        resources.ApplyResources(Me.ConsoleOutput_RichTextBox, "ConsoleOutput_RichTextBox")
        Me.ConsoleOutput_RichTextBox.BackColor = System.Drawing.SystemColors.ControlText
        Me.ConsoleOutput_RichTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ConsoleOutput_RichTextBox.ForeColor = System.Drawing.SystemColors.Window
        Me.ConsoleOutput_RichTextBox.Name = "ConsoleOutput_RichTextBox"
        Me.ConsoleOutput_RichTextBox.ReadOnly = True
        Me.ConsoleOutput_RichTextBox.TabStop = False
        '
        'ConsoleOutput_Groupbox
        '
        resources.ApplyResources(Me.ConsoleOutput_Groupbox, "ConsoleOutput_Groupbox")
        Me.ConsoleOutput_Groupbox.Controls.Add(Me.ConsoleOutput_RichTextBox)
        Me.ConsoleOutput_Groupbox.Name = "ConsoleOutput_Groupbox"
        Me.ConsoleOutput_Groupbox.TabStop = False
        '
        'Informations_Groupbox
        '
        resources.ApplyResources(Me.Informations_Groupbox, "Informations_Groupbox")
        Me.Informations_Groupbox.Controls.Add(Me.FileToUnlock_TextBox)
        Me.Informations_Groupbox.Controls.Add(Me.RecoverBtn)
        Me.Informations_Groupbox.Controls.Add(Me.UnlockedFile_TextBox)
        Me.Informations_Groupbox.Controls.Add(Me.ROM_To_Unlock_BrowseBtn)
        Me.Informations_Groupbox.Controls.Add(Me.Unlocked_ROM_BrowseBtn)
        Me.Informations_Groupbox.Controls.Add(Me.FileToUnlock_Text)
        Me.Informations_Groupbox.Controls.Add(Me.UnlockedFile_Text)
        Me.Informations_Groupbox.Name = "Informations_Groupbox"
        Me.Informations_Groupbox.TabStop = False
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsoleOutputZoom_Text, Me.UnlockStatus_Text})
        resources.ApplyResources(Me.StatusBar, "StatusBar")
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.SizingGrip = False
        '
        'ConsoleOutputZoom_Text
        '
        Me.ConsoleOutputZoom_Text.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ConsoleOutputZoom_Text.Name = "ConsoleOutputZoom_Text"
        resources.ApplyResources(Me.ConsoleOutputZoom_Text, "ConsoleOutputZoom_Text")
        '
        'UnlockStatus_Text
        '
        resources.ApplyResources(Me.UnlockStatus_Text, "UnlockStatus_Text")
        Me.UnlockStatus_Text.Name = "UnlockStatus_Text"
        Me.UnlockStatus_Text.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.UnlockStatus_Text.Spring = True
        '
        'OpenLockedROM
        '
        resources.ApplyResources(Me.OpenLockedROM, "OpenLockedROM")
        Me.OpenLockedROM.ValidateNames = False
        '
        'SaveUnlockedROM
        '
        Me.SaveUnlockedROM.CheckFileExists = True
        resources.ApplyResources(Me.SaveUnlockedROM, "SaveUnlockedROM")
        Me.SaveUnlockedROM.ValidateNames = False
        '
        'ExportConsoleOutput
        '
        Me.ExportConsoleOutput.CheckFileExists = True
        resources.ApplyResources(Me.ExportConsoleOutput, "ExportConsoleOutput")
        Me.ExportConsoleOutput.ValidateNames = False
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Menu_MenuItem, Me.ConsoleOutput_MenuItem, Me.Help_MenuItem})
        '
        'Menu_MenuItem
        '
        Me.Menu_MenuItem.Index = 0
        Me.Menu_MenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ResetWindow_MenuItem, Me.ShowStatusBar_MenuItem, Me.Separator1, Me.Close_MenuItem})
        resources.ApplyResources(Me.Menu_MenuItem, "Menu_MenuItem")
        '
        'ResetWindow_MenuItem
        '
        Me.MenuItems_Icons.SetImage(Me.ResetWindow_MenuItem, Global.SMW_MultiTool_Launcher.My.Resources.Resources.SettingsReload)
        Me.ResetWindow_MenuItem.Index = 0
        resources.ApplyResources(Me.ResetWindow_MenuItem, "ResetWindow_MenuItem")
        '
        'ShowStatusBar_MenuItem
        '
        Me.ShowStatusBar_MenuItem.Checked = True
        Me.ShowStatusBar_MenuItem.Index = 1
        resources.ApplyResources(Me.ShowStatusBar_MenuItem, "ShowStatusBar_MenuItem")
        '
        'Separator1
        '
        Me.Separator1.Index = 2
        resources.ApplyResources(Me.Separator1, "Separator1")
        '
        'Close_MenuItem
        '
        Me.MenuItems_Icons.SetImage(Me.Close_MenuItem, Global.SMW_MultiTool_Launcher.My.Resources.Resources.SettingsCancel)
        Me.Close_MenuItem.Index = 3
        resources.ApplyResources(Me.Close_MenuItem, "Close_MenuItem")
        '
        'ConsoleOutput_MenuItem
        '
        Me.ConsoleOutput_MenuItem.Index = 1
        Me.ConsoleOutput_MenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ShowConsoleOutput_MenuItem, Me.ClearConsoleOutput_MenuItem, Me.Separator2, Me.ConsoleOutput_Submenu, Me.ResetZoom_MenuItem, Me.Separator3, Me.ExportConsoleOutput_MenuItem})
        resources.ApplyResources(Me.ConsoleOutput_MenuItem, "ConsoleOutput_MenuItem")
        '
        'ShowConsoleOutput_MenuItem
        '
        Me.ShowConsoleOutput_MenuItem.Index = 0
        resources.ApplyResources(Me.ShowConsoleOutput_MenuItem, "ShowConsoleOutput_MenuItem")
        '
        'ClearConsoleOutput_MenuItem
        '
        resources.ApplyResources(Me.ClearConsoleOutput_MenuItem, "ClearConsoleOutput_MenuItem")
        Me.ClearConsoleOutput_MenuItem.Index = 1
        '
        'Separator2
        '
        Me.Separator2.Index = 2
        resources.ApplyResources(Me.Separator2, "Separator2")
        '
        'ConsoleOutput_Submenu
        '
        resources.ApplyResources(Me.ConsoleOutput_Submenu, "ConsoleOutput_Submenu")
        Me.ConsoleOutput_Submenu.Index = 3
        Me.ConsoleOutput_Submenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Zoom1x_MenuItem, Me.Zoom2x_MenuItem, Me.Zoom3x_MenuItem, Me.Zoom4x_MenuItem, Me.Zoom5x_MenuItem, Me.Zoom6x_MenuItem, Me.Zoom7x_MenuItem, Me.Zoom8x_MenuItem, Me.Zoom9x_MenuItem, Me.Zoom10x_MenuItem, Me.Separator5, Me.CustomZoom_MenuItem})
        '
        'Zoom1x_MenuItem
        '
        Me.Zoom1x_MenuItem.Index = 0
        resources.ApplyResources(Me.Zoom1x_MenuItem, "Zoom1x_MenuItem")
        '
        'Zoom2x_MenuItem
        '
        Me.Zoom2x_MenuItem.Index = 1
        resources.ApplyResources(Me.Zoom2x_MenuItem, "Zoom2x_MenuItem")
        '
        'Zoom3x_MenuItem
        '
        Me.Zoom3x_MenuItem.Index = 2
        resources.ApplyResources(Me.Zoom3x_MenuItem, "Zoom3x_MenuItem")
        '
        'Zoom4x_MenuItem
        '
        Me.Zoom4x_MenuItem.Index = 3
        resources.ApplyResources(Me.Zoom4x_MenuItem, "Zoom4x_MenuItem")
        '
        'Zoom5x_MenuItem
        '
        Me.Zoom5x_MenuItem.Index = 4
        resources.ApplyResources(Me.Zoom5x_MenuItem, "Zoom5x_MenuItem")
        '
        'Zoom6x_MenuItem
        '
        Me.Zoom6x_MenuItem.Index = 5
        resources.ApplyResources(Me.Zoom6x_MenuItem, "Zoom6x_MenuItem")
        '
        'Zoom7x_MenuItem
        '
        Me.Zoom7x_MenuItem.Index = 6
        resources.ApplyResources(Me.Zoom7x_MenuItem, "Zoom7x_MenuItem")
        '
        'Zoom8x_MenuItem
        '
        Me.Zoom8x_MenuItem.Index = 7
        resources.ApplyResources(Me.Zoom8x_MenuItem, "Zoom8x_MenuItem")
        '
        'Zoom9x_MenuItem
        '
        Me.Zoom9x_MenuItem.Index = 8
        resources.ApplyResources(Me.Zoom9x_MenuItem, "Zoom9x_MenuItem")
        '
        'Zoom10x_MenuItem
        '
        Me.Zoom10x_MenuItem.Index = 9
        resources.ApplyResources(Me.Zoom10x_MenuItem, "Zoom10x_MenuItem")
        '
        'Separator5
        '
        Me.Separator5.Index = 10
        resources.ApplyResources(Me.Separator5, "Separator5")
        '
        'CustomZoom_MenuItem
        '
        Me.CustomZoom_MenuItem.Index = 11
        resources.ApplyResources(Me.CustomZoom_MenuItem, "CustomZoom_MenuItem")
        '
        'ResetZoom_MenuItem
        '
        resources.ApplyResources(Me.ResetZoom_MenuItem, "ResetZoom_MenuItem")
        Me.ResetZoom_MenuItem.Index = 4
        '
        'Separator3
        '
        Me.Separator3.Index = 5
        resources.ApplyResources(Me.Separator3, "Separator3")
        '
        'ExportConsoleOutput_MenuItem
        '
        resources.ApplyResources(Me.ExportConsoleOutput_MenuItem, "ExportConsoleOutput_MenuItem")
        Me.MenuItems_Icons.SetImage(Me.ExportConsoleOutput_MenuItem, Global.SMW_MultiTool_Launcher.My.Resources.Resources.AppIcon_Smallhacker_SMWEN_E)
        Me.ExportConsoleOutput_MenuItem.Index = 6
        '
        'Help_MenuItem
        '
        Me.Help_MenuItem.Index = 2
        Me.Help_MenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.HowToUse_MenuItem, Me.Separator4, Me.About_MenuItem})
        resources.ApplyResources(Me.Help_MenuItem, "Help_MenuItem")
        '
        'HowToUse_MenuItem
        '
        resources.ApplyResources(Me.HowToUse_MenuItem, "HowToUse_MenuItem")
        Me.MenuItems_Icons.SetImage(Me.HowToUse_MenuItem, Global.SMW_MultiTool_Launcher.My.Resources.Resources.Help)
        Me.HowToUse_MenuItem.Index = 0
        '
        'Separator4
        '
        Me.Separator4.Index = 1
        resources.ApplyResources(Me.Separator4, "Separator4")
        '
        'About_MenuItem
        '
        Me.MenuItems_Icons.SetImage(Me.About_MenuItem, Global.SMW_MultiTool_Launcher.My.Resources.Resources.Info)
        Me.About_MenuItem.Index = 2
        resources.ApplyResources(Me.About_MenuItem, "About_MenuItem")
        '
        'MenuItems_Icons
        '
        Me.MenuItems_Icons.ContainerControl = Me
        '
        'Y_Recover_LM_GUI
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.Informations_Groupbox)
        Me.Controls.Add(Me.ConsoleOutput_Groupbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu
        Me.MinimizeBox = False
        Me.Name = "Y_Recover_LM_GUI"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.ConsoleOutput_Groupbox.ResumeLayout(False)
        Me.Informations_Groupbox.ResumeLayout(False)
        Me.Informations_Groupbox.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        CType(Me.MenuItems_Icons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileToUnlock_Text As System.Windows.Forms.Label
    Friend WithEvents UnlockedFile_Text As System.Windows.Forms.Label
    Friend WithEvents FileToUnlock_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnlockedFile_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ROM_To_Unlock_BrowseBtn As System.Windows.Forms.Button
    Friend WithEvents Unlocked_ROM_BrowseBtn As System.Windows.Forms.Button
    Friend WithEvents OpenLockedROM As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveUnlockedROM As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RecoverBtn As System.Windows.Forms.Button
    Friend WithEvents ConsoleOutput_RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents ExportConsoleOutput As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ConsoleOutput_Groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents Informations_Groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents MainMenu As MainMenu
    Friend WithEvents Menu_MenuItem As MenuItem
    Friend WithEvents ResetWindow_MenuItem As MenuItem
    Friend WithEvents Separator1 As MenuItem
    Friend WithEvents Close_MenuItem As MenuItem
    Friend WithEvents ConsoleOutput_MenuItem As MenuItem
    Friend WithEvents ResetZoom_MenuItem As MenuItem
    Friend WithEvents Separator2 As MenuItem
    Friend WithEvents ClearConsoleOutput_MenuItem As MenuItem
    Friend WithEvents ConsoleOutput_Submenu As MenuItem
    Friend WithEvents Zoom1x_MenuItem As MenuItem
    Friend WithEvents Zoom5x_MenuItem As MenuItem
    Friend WithEvents Zoom6x_MenuItem As MenuItem
    Friend WithEvents Zoom10x_MenuItem As MenuItem
    Friend WithEvents Help_MenuItem As MenuItem
    Friend WithEvents About_MenuItem As MenuItem
    Friend WithEvents Zoom4x_MenuItem As MenuItem
    Friend WithEvents Zoom9x_MenuItem As MenuItem
    Friend WithEvents Separator5 As MenuItem
    Friend WithEvents CustomZoom_MenuItem As MenuItem
    Friend WithEvents Separator3 As MenuItem
    Friend WithEvents ExportConsoleOutput_MenuItem As MenuItem
    Friend WithEvents HowToUse_MenuItem As MenuItem
    Friend WithEvents Separator4 As MenuItem
    Friend WithEvents ConsoleZoom_Status As StatusBarPanel
    Friend WithEvents StatusBar As StatusStrip
    Friend WithEvents ConsoleOutputZoom_Text As ToolStripStatusLabel
    Friend WithEvents UnlockStatus_Text As ToolStripStatusLabel
    Friend WithEvents ShowStatusBar_MenuItem As MenuItem
    Friend WithEvents ShowConsoleOutput_MenuItem As MenuItem
    Friend WithEvents Zoom2x_MenuItem As MenuItem
    Friend WithEvents Zoom3x_MenuItem As MenuItem
    Friend WithEvents Zoom7x_MenuItem As MenuItem
    Friend WithEvents Zoom8x_MenuItem As MenuItem
    Friend WithEvents MenuItems_Icons As SMWMTLextensions.ControlExtensions.NativeMenuIcon
End Class
