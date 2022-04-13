<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm04_UpdatesModal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm04_UpdatesModal))
        Me.UI_SearchUpdateBtn = New System.Windows.Forms.Button()
        Me.UI_BtmBar_Panel = New System.Windows.Forms.Panel()
        Me.AppUpdateEngineVersion_Label = New System.Windows.Forms.Label()
        Me.AppVersion_Label = New System.Windows.Forms.Label()
        Me.UI_DownloadUpdateBtn = New System.Windows.Forms.Button()
        Me.UI_InstallUpdateBtn = New System.Windows.Forms.Button()
        Me.UI_StatPanel = New System.Windows.Forms.Panel()
        Me.UI_StatPanel_Icon = New System.Windows.Forms.PictureBox()
        Me.UI_StatPanel_Description = New System.Windows.Forms.Label()
        Me.UI_StatPanel_Title = New System.Windows.Forms.Label()
        Me.UI_CurrentProcessProgress = New System.Windows.Forms.ProgressBar()
        Me.UI_CurrentProcessText = New System.Windows.Forms.Label()
        Me.UI_HeaderPanel = New System.Windows.Forms.Panel()
        Me.UI_HeaderBorder = New System.Windows.Forms.Panel()
        Me.UI_InfoDescriptionText = New System.Windows.Forms.Label()
        Me.UI_InfoTitleText = New System.Windows.Forms.Label()
        Me.UI_UpdateActionsButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.UI_Text_Changelog = New System.Windows.Forms.Label()
        Me.UI_Changelog_TextBox = New System.Windows.Forms.RichTextBox()
        Me.UI_ChangelogPanel = New System.Windows.Forms.Panel()
        Me.UI_LastCheckedUpdate = New System.Windows.Forms.Label()
        Me.UI_DownloadState = New System.Windows.Forms.Label()
        Me.UI_BtmBar_Panel.SuspendLayout()
        Me.UI_StatPanel.SuspendLayout()
        CType(Me.UI_StatPanel_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_HeaderPanel.SuspendLayout()
        Me.UI_UpdateActionsButtons.SuspendLayout()
        Me.UI_ChangelogPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'UI_SearchUpdateBtn
        '
        resources.ApplyResources(Me.UI_SearchUpdateBtn, "UI_SearchUpdateBtn")
        Me.UI_SearchUpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.UI_SearchUpdateBtn.FlatAppearance.BorderSize = 0
        Me.UI_SearchUpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.UI_SearchUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_SearchUpdateBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UI_SearchUpdateBtn.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_Icon_SearchUpdate
        Me.UI_SearchUpdateBtn.Name = "UI_SearchUpdateBtn"
        Me.UI_SearchUpdateBtn.UseVisualStyleBackColor = True
        '
        'UI_BtmBar_Panel
        '
        resources.ApplyResources(Me.UI_BtmBar_Panel, "UI_BtmBar_Panel")
        Me.UI_BtmBar_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_BtmBar_Panel.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_BottomBarLight
        Me.UI_BtmBar_Panel.Controls.Add(Me.AppUpdateEngineVersion_Label)
        Me.UI_BtmBar_Panel.Controls.Add(Me.AppVersion_Label)
        Me.UI_BtmBar_Panel.Name = "UI_BtmBar_Panel"
        '
        'AppUpdateEngineVersion_Label
        '
        resources.ApplyResources(Me.AppUpdateEngineVersion_Label, "AppUpdateEngineVersion_Label")
        Me.AppUpdateEngineVersion_Label.Name = "AppUpdateEngineVersion_Label"
        '
        'AppVersion_Label
        '
        resources.ApplyResources(Me.AppVersion_Label, "AppVersion_Label")
        Me.AppVersion_Label.Name = "AppVersion_Label"
        '
        'UI_DownloadUpdateBtn
        '
        resources.ApplyResources(Me.UI_DownloadUpdateBtn, "UI_DownloadUpdateBtn")
        Me.UI_DownloadUpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.UI_DownloadUpdateBtn.FlatAppearance.BorderSize = 0
        Me.UI_DownloadUpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.UI_DownloadUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_DownloadUpdateBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UI_DownloadUpdateBtn.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_Icon_DownloadUpdate
        Me.UI_DownloadUpdateBtn.Name = "UI_DownloadUpdateBtn"
        Me.UI_DownloadUpdateBtn.UseVisualStyleBackColor = True
        '
        'UI_InstallUpdateBtn
        '
        resources.ApplyResources(Me.UI_InstallUpdateBtn, "UI_InstallUpdateBtn")
        Me.UI_InstallUpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.UI_InstallUpdateBtn.FlatAppearance.BorderSize = 0
        Me.UI_InstallUpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.UI_InstallUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_InstallUpdateBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UI_InstallUpdateBtn.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_Icon_InstallUpdate
        Me.UI_InstallUpdateBtn.Name = "UI_InstallUpdateBtn"
        Me.UI_InstallUpdateBtn.UseVisualStyleBackColor = True
        '
        'UI_StatPanel
        '
        resources.ApplyResources(Me.UI_StatPanel, "UI_StatPanel")
        Me.UI_StatPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_StatPanel.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UpdateBackVert
        Me.UI_StatPanel.Controls.Add(Me.UI_StatPanel_Icon)
        Me.UI_StatPanel.Controls.Add(Me.UI_StatPanel_Description)
        Me.UI_StatPanel.Controls.Add(Me.UI_StatPanel_Title)
        Me.UI_StatPanel.Name = "UI_StatPanel"
        '
        'UI_StatPanel_Icon
        '
        Me.UI_StatPanel_Icon.BackColor = System.Drawing.Color.Transparent
        Me.UI_StatPanel_Icon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_Badge_EngineLogo
        resources.ApplyResources(Me.UI_StatPanel_Icon, "UI_StatPanel_Icon")
        Me.UI_StatPanel_Icon.Name = "UI_StatPanel_Icon"
        Me.UI_StatPanel_Icon.TabStop = False
        '
        'UI_StatPanel_Description
        '
        resources.ApplyResources(Me.UI_StatPanel_Description, "UI_StatPanel_Description")
        Me.UI_StatPanel_Description.BackColor = System.Drawing.Color.Transparent
        Me.UI_StatPanel_Description.Name = "UI_StatPanel_Description"
        '
        'UI_StatPanel_Title
        '
        resources.ApplyResources(Me.UI_StatPanel_Title, "UI_StatPanel_Title")
        Me.UI_StatPanel_Title.BackColor = System.Drawing.Color.Transparent
        Me.UI_StatPanel_Title.Name = "UI_StatPanel_Title"
        '
        'UI_CurrentProcessProgress
        '
        resources.ApplyResources(Me.UI_CurrentProcessProgress, "UI_CurrentProcessProgress")
        Me.UI_CurrentProcessProgress.Name = "UI_CurrentProcessProgress"
        '
        'UI_CurrentProcessText
        '
        resources.ApplyResources(Me.UI_CurrentProcessText, "UI_CurrentProcessText")
        Me.UI_CurrentProcessText.Name = "UI_CurrentProcessText"
        '
        'UI_HeaderPanel
        '
        resources.ApplyResources(Me.UI_HeaderPanel, "UI_HeaderPanel")
        Me.UI_HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.UI_HeaderPanel.Controls.Add(Me.UI_HeaderBorder)
        Me.UI_HeaderPanel.Controls.Add(Me.UI_StatPanel)
        Me.UI_HeaderPanel.Name = "UI_HeaderPanel"
        '
        'UI_HeaderBorder
        '
        resources.ApplyResources(Me.UI_HeaderBorder, "UI_HeaderBorder")
        Me.UI_HeaderBorder.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_BorderLineBottomLight
        Me.UI_HeaderBorder.Name = "UI_HeaderBorder"
        '
        'UI_InfoDescriptionText
        '
        resources.ApplyResources(Me.UI_InfoDescriptionText, "UI_InfoDescriptionText")
        Me.UI_InfoDescriptionText.Name = "UI_InfoDescriptionText"
        '
        'UI_InfoTitleText
        '
        resources.ApplyResources(Me.UI_InfoTitleText, "UI_InfoTitleText")
        Me.UI_InfoTitleText.Name = "UI_InfoTitleText"
        '
        'UI_UpdateActionsButtons
        '
        resources.ApplyResources(Me.UI_UpdateActionsButtons, "UI_UpdateActionsButtons")
        Me.UI_UpdateActionsButtons.Controls.Add(Me.UI_SearchUpdateBtn)
        Me.UI_UpdateActionsButtons.Controls.Add(Me.UI_DownloadUpdateBtn)
        Me.UI_UpdateActionsButtons.Controls.Add(Me.UI_InstallUpdateBtn)
        Me.UI_UpdateActionsButtons.Name = "UI_UpdateActionsButtons"
        '
        'UI_Text_Changelog
        '
        resources.ApplyResources(Me.UI_Text_Changelog, "UI_Text_Changelog")
        Me.UI_Text_Changelog.Name = "UI_Text_Changelog"
        '
        'UI_Changelog_TextBox
        '
        Me.UI_Changelog_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_Changelog_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.UI_Changelog_TextBox, "UI_Changelog_TextBox")
        Me.UI_Changelog_TextBox.Name = "UI_Changelog_TextBox"
        Me.UI_Changelog_TextBox.ReadOnly = True
        '
        'UI_ChangelogPanel
        '
        resources.ApplyResources(Me.UI_ChangelogPanel, "UI_ChangelogPanel")
        Me.UI_ChangelogPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_ChangelogPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UI_ChangelogPanel.Controls.Add(Me.UI_Changelog_TextBox)
        Me.UI_ChangelogPanel.Name = "UI_ChangelogPanel"
        '
        'UI_LastCheckedUpdate
        '
        resources.ApplyResources(Me.UI_LastCheckedUpdate, "UI_LastCheckedUpdate")
        Me.UI_LastCheckedUpdate.Name = "UI_LastCheckedUpdate"
        '
        'UI_DownloadState
        '
        resources.ApplyResources(Me.UI_DownloadState, "UI_DownloadState")
        Me.UI_DownloadState.Name = "UI_DownloadState"
        '
        'Frm04_UpdatesModal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Controls.Add(Me.UI_UpdateActionsButtons)
        Me.Controls.Add(Me.UI_CurrentProcessProgress)
        Me.Controls.Add(Me.UI_InfoDescriptionText)
        Me.Controls.Add(Me.UI_HeaderPanel)
        Me.Controls.Add(Me.UI_InfoTitleText)
        Me.Controls.Add(Me.UI_BtmBar_Panel)
        Me.Controls.Add(Me.UI_LastCheckedUpdate)
        Me.Controls.Add(Me.UI_Text_Changelog)
        Me.Controls.Add(Me.UI_ChangelogPanel)
        Me.Controls.Add(Me.UI_DownloadState)
        Me.Controls.Add(Me.UI_CurrentProcessText)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm04_UpdatesModal"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.UI_BtmBar_Panel.ResumeLayout(False)
        Me.UI_StatPanel.ResumeLayout(False)
        CType(Me.UI_StatPanel_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_HeaderPanel.ResumeLayout(False)
        Me.UI_UpdateActionsButtons.ResumeLayout(False)
        Me.UI_UpdateActionsButtons.PerformLayout()
        Me.UI_ChangelogPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UI_SearchUpdateBtn As Button
    Friend WithEvents UI_BtmBar_Panel As Panel
    Friend WithEvents AppVersion_Label As Label
    Friend WithEvents AppUpdateEngineVersion_Label As Label
    Friend WithEvents UI_DownloadUpdateBtn As Button
    Friend WithEvents UI_StatPanel As Panel
    Friend WithEvents UI_StatPanel_Icon As PictureBox
    Friend WithEvents UI_StatPanel_Description As Label
    Friend WithEvents UI_StatPanel_Title As Label
    Friend WithEvents UI_CurrentProcessProgress As ProgressBar
    Friend WithEvents UI_CurrentProcessText As Label
    Friend WithEvents UI_InstallUpdateBtn As Button
    Friend WithEvents UI_HeaderPanel As Panel
    Friend WithEvents UI_InfoTitleText As Label
    Friend WithEvents UI_InfoDescriptionText As Label
    Friend WithEvents UI_HeaderBorder As Panel
    Friend WithEvents UI_UpdateActionsButtons As FlowLayoutPanel
    Friend WithEvents UI_Text_Changelog As Label
    Friend WithEvents UI_Changelog_TextBox As RichTextBox
    Friend WithEvents UI_ChangelogPanel As Panel
    Friend WithEvents UI_LastCheckedUpdate As Label
    Friend WithEvents UI_DownloadState As Label
End Class
