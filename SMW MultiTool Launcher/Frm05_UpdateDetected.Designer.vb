<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm05_UpdateDetected
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm05_UpdateDetected))
        Me.UI_InstallUpdateBtn = New System.Windows.Forms.Button()
        Me.UI_UpdateText_NewVersion = New System.Windows.Forms.Label()
        Me.UI_StatPanel = New System.Windows.Forms.Panel()
        Me.UI_HeaderBorder = New System.Windows.Forms.Panel()
        Me.UI_AppLogo = New System.Windows.Forms.PictureBox()
        Me.UI_StatPanel_Icon = New System.Windows.Forms.PictureBox()
        Me.UI_StatPanel_Description = New System.Windows.Forms.Label()
        Me.UI_BtmBar_Panel = New System.Windows.Forms.Panel()
        Me.UI_BtmBar_PanelBorder = New System.Windows.Forms.Panel()
        Me.UI_ButtonsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.UI_IgnoreVersionUpdateBtn = New System.Windows.Forms.Button()
        Me.UI_DeclineUpdateBtn = New System.Windows.Forms.Button()
        Me.UI_UpdateText01 = New System.Windows.Forms.Label()
        Me.UI_UpdateGraphicLine01 = New System.Windows.Forms.PictureBox()
        Me.UI_ChangelogPanel = New System.Windows.Forms.Panel()
        Me.UI_Changelog_TextBox = New System.Windows.Forms.RichTextBox()
        Me.UI_StatPanel.SuspendLayout()
        CType(Me.UI_AppLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UI_StatPanel_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_BtmBar_Panel.SuspendLayout()
        Me.UI_ButtonsPanel.SuspendLayout()
        CType(Me.UI_UpdateGraphicLine01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_ChangelogPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'UI_InstallUpdateBtn
        '
        resources.ApplyResources(Me.UI_InstallUpdateBtn, "UI_InstallUpdateBtn")
        Me.UI_InstallUpdateBtn.BackColor = System.Drawing.SystemColors.Control
        Me.UI_InstallUpdateBtn.Name = "UI_InstallUpdateBtn"
        Me.UI_InstallUpdateBtn.UseVisualStyleBackColor = True
        '
        'UI_UpdateText_NewVersion
        '
        resources.ApplyResources(Me.UI_UpdateText_NewVersion, "UI_UpdateText_NewVersion")
        Me.UI_UpdateText_NewVersion.BackColor = System.Drawing.Color.Transparent
        Me.UI_UpdateText_NewVersion.Name = "UI_UpdateText_NewVersion"
        '
        'UI_StatPanel
        '
        resources.ApplyResources(Me.UI_StatPanel, "UI_StatPanel")
        Me.UI_StatPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_StatPanel.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.TitleGreen
        Me.UI_StatPanel.Controls.Add(Me.UI_HeaderBorder)
        Me.UI_StatPanel.Controls.Add(Me.UI_AppLogo)
        Me.UI_StatPanel.Controls.Add(Me.UI_StatPanel_Icon)
        Me.UI_StatPanel.Controls.Add(Me.UI_StatPanel_Description)
        Me.UI_StatPanel.Controls.Add(Me.UI_UpdateText_NewVersion)
        Me.UI_StatPanel.Name = "UI_StatPanel"
        '
        'UI_HeaderBorder
        '
        resources.ApplyResources(Me.UI_HeaderBorder, "UI_HeaderBorder")
        Me.UI_HeaderBorder.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_BorderLineBottomLight
        Me.UI_HeaderBorder.Name = "UI_HeaderBorder"
        '
        'UI_AppLogo
        '
        Me.UI_AppLogo.BackColor = System.Drawing.Color.Transparent
        Me.UI_AppLogo.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UpdateLogo_Light
        resources.ApplyResources(Me.UI_AppLogo, "UI_AppLogo")
        Me.UI_AppLogo.Name = "UI_AppLogo"
        Me.UI_AppLogo.TabStop = False
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
        'UI_BtmBar_Panel
        '
        resources.ApplyResources(Me.UI_BtmBar_Panel, "UI_BtmBar_Panel")
        Me.UI_BtmBar_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_BtmBar_Panel.Controls.Add(Me.UI_BtmBar_PanelBorder)
        Me.UI_BtmBar_Panel.Controls.Add(Me.UI_ButtonsPanel)
        Me.UI_BtmBar_Panel.Name = "UI_BtmBar_Panel"
        '
        'UI_BtmBar_PanelBorder
        '
        resources.ApplyResources(Me.UI_BtmBar_PanelBorder, "UI_BtmBar_PanelBorder")
        Me.UI_BtmBar_PanelBorder.BackColor = System.Drawing.Color.Transparent
        Me.UI_BtmBar_PanelBorder.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_BottomBarLight
        Me.UI_BtmBar_PanelBorder.Name = "UI_BtmBar_PanelBorder"
        '
        'UI_ButtonsPanel
        '
        resources.ApplyResources(Me.UI_ButtonsPanel, "UI_ButtonsPanel")
        Me.UI_ButtonsPanel.BackColor = System.Drawing.Color.Transparent
        Me.UI_ButtonsPanel.Controls.Add(Me.UI_IgnoreVersionUpdateBtn)
        Me.UI_ButtonsPanel.Controls.Add(Me.UI_DeclineUpdateBtn)
        Me.UI_ButtonsPanel.Controls.Add(Me.UI_InstallUpdateBtn)
        Me.UI_ButtonsPanel.Name = "UI_ButtonsPanel"
        '
        'UI_IgnoreVersionUpdateBtn
        '
        resources.ApplyResources(Me.UI_IgnoreVersionUpdateBtn, "UI_IgnoreVersionUpdateBtn")
        Me.UI_IgnoreVersionUpdateBtn.BackColor = System.Drawing.SystemColors.Control
        Me.UI_IgnoreVersionUpdateBtn.Name = "UI_IgnoreVersionUpdateBtn"
        Me.UI_IgnoreVersionUpdateBtn.UseVisualStyleBackColor = True
        '
        'UI_DeclineUpdateBtn
        '
        resources.ApplyResources(Me.UI_DeclineUpdateBtn, "UI_DeclineUpdateBtn")
        Me.UI_DeclineUpdateBtn.BackColor = System.Drawing.SystemColors.Control
        Me.UI_DeclineUpdateBtn.Name = "UI_DeclineUpdateBtn"
        Me.UI_DeclineUpdateBtn.UseVisualStyleBackColor = True
        '
        'UI_UpdateText01
        '
        resources.ApplyResources(Me.UI_UpdateText01, "UI_UpdateText01")
        Me.UI_UpdateText01.Name = "UI_UpdateText01"
        '
        'UI_UpdateGraphicLine01
        '
        resources.ApplyResources(Me.UI_UpdateGraphicLine01, "UI_UpdateGraphicLine01")
        Me.UI_UpdateGraphicLine01.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_UpdatePopupGradient_Light
        Me.UI_UpdateGraphicLine01.Name = "UI_UpdateGraphicLine01"
        Me.UI_UpdateGraphicLine01.TabStop = False
        '
        'UI_ChangelogPanel
        '
        resources.ApplyResources(Me.UI_ChangelogPanel, "UI_ChangelogPanel")
        Me.UI_ChangelogPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_ChangelogPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UI_ChangelogPanel.Controls.Add(Me.UI_Changelog_TextBox)
        Me.UI_ChangelogPanel.Name = "UI_ChangelogPanel"
        '
        'UI_Changelog_TextBox
        '
        Me.UI_Changelog_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_Changelog_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.UI_Changelog_TextBox, "UI_Changelog_TextBox")
        Me.UI_Changelog_TextBox.Name = "UI_Changelog_TextBox"
        Me.UI_Changelog_TextBox.ReadOnly = True
        '
        'Frm05_UpdateDetected
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.UI_ChangelogPanel)
        Me.Controls.Add(Me.UI_BtmBar_Panel)
        Me.Controls.Add(Me.UI_StatPanel)
        Me.Controls.Add(Me.UI_UpdateGraphicLine01)
        Me.Controls.Add(Me.UI_UpdateText01)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm05_UpdateDetected"
        Me.ShowInTaskbar = False
        Me.UI_StatPanel.ResumeLayout(False)
        Me.UI_StatPanel.PerformLayout()
        CType(Me.UI_AppLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UI_StatPanel_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_BtmBar_Panel.ResumeLayout(False)
        Me.UI_ButtonsPanel.ResumeLayout(False)
        CType(Me.UI_UpdateGraphicLine01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_ChangelogPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UI_InstallUpdateBtn As Button
    Public WithEvents UI_UpdateText_NewVersion As Label
    Friend WithEvents UI_StatPanel As Panel
    Friend WithEvents UI_HeaderBorder As Panel
    Friend WithEvents UI_StatPanel_Icon As PictureBox
    Friend WithEvents UI_BtmBar_Panel As Panel
    Friend WithEvents UI_ButtonsPanel As FlowLayoutPanel
    Friend WithEvents UI_BtmBar_PanelBorder As Panel
    Friend WithEvents UI_DeclineUpdateBtn As Button
    Friend WithEvents UI_AppLogo As PictureBox
    Friend WithEvents UI_StatPanel_Description As Label
    Friend WithEvents UI_UpdateText01 As Label
    Friend WithEvents UI_UpdateGraphicLine01 As PictureBox
    Friend WithEvents UI_IgnoreVersionUpdateBtn As Button
    Friend WithEvents UI_ChangelogPanel As Panel
    Friend WithEvents UI_Changelog_TextBox As RichTextBox
End Class
