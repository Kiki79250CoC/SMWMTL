<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm02_About
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm02_About))
        Me.UI_Btn_OK = New System.Windows.Forms.Button()
        Me.Info_UpdateStatusIcon = New System.Windows.Forms.PictureBox()
        Me.Info_UpdateStatus = New System.Windows.Forms.Label()
        Me.AppLogo_Image = New System.Windows.Forms.PictureBox()
        Me.AppVersion_Label = New System.Windows.Forms.Label()
        Me.AppCompil_Label = New System.Windows.Forms.Label()
        Me.AppCopyrightLabel = New System.Windows.Forms.Label()
        Me.AppVersionStringLabel = New System.Windows.Forms.Label()
        Me.UI_Btn_LegacyAbout = New System.Windows.Forms.Button()
        Me.UI_AllRightsLabel = New System.Windows.Forms.Label()
        Me.UI_ButtonsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.UI_Separator1 = New System.Windows.Forms.PictureBox()
        Me.UI_Btn_Mentions = New System.Windows.Forms.Button()
        Me.UI_BtmBar_Panel = New System.Windows.Forms.Panel()
        Me.UI_BtmBar_PanelBorder = New System.Windows.Forms.Panel()
        Me.UI_UpdateStatusPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.UI_Btn_GoToUpdateModal = New System.Windows.Forms.LinkLabel()
        Me.UI_StatPanel = New System.Windows.Forms.Panel()
        Me.UI_HeaderBorder = New System.Windows.Forms.Panel()
        Me.UI_AppNamePanel = New System.Windows.Forms.Panel()
        Me.UI_AppNameBorder = New System.Windows.Forms.Panel()
        Me.UpdateSysVersion_Label = New System.Windows.Forms.Label()
        Me.CopyBuildStringToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SMWC_ExcRel = New System.Windows.Forms.Label()
        CType(Me.Info_UpdateStatusIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppLogo_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_ButtonsPanel.SuspendLayout()
        CType(Me.UI_Separator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_BtmBar_Panel.SuspendLayout()
        Me.UI_UpdateStatusPanel.SuspendLayout()
        Me.UI_StatPanel.SuspendLayout()
        Me.UI_AppNamePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'UI_Btn_OK
        '
        resources.ApplyResources(Me.UI_Btn_OK, "UI_Btn_OK")
        Me.UI_Btn_OK.BackColor = System.Drawing.SystemColors.Control
        Me.UI_Btn_OK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.UI_Btn_OK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UI_Btn_OK.Name = "UI_Btn_OK"
        Me.UI_Btn_OK.UseVisualStyleBackColor = True
        '
        'Info_UpdateStatusIcon
        '
        resources.ApplyResources(Me.Info_UpdateStatusIcon, "Info_UpdateStatusIcon")
        Me.Info_UpdateStatusIcon.BackColor = System.Drawing.Color.Transparent
        Me.Info_UpdateStatusIcon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.SysIconModify
        Me.Info_UpdateStatusIcon.Name = "Info_UpdateStatusIcon"
        Me.Info_UpdateStatusIcon.TabStop = False
        '
        'Info_UpdateStatus
        '
        resources.ApplyResources(Me.Info_UpdateStatus, "Info_UpdateStatus")
        Me.Info_UpdateStatus.Name = "Info_UpdateStatus"
        '
        'AppLogo_Image
        '
        resources.ApplyResources(Me.AppLogo_Image, "AppLogo_Image")
        Me.AppLogo_Image.BackColor = System.Drawing.Color.Transparent
        Me.AppLogo_Image.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.About_Logo
        Me.AppLogo_Image.Name = "AppLogo_Image"
        Me.AppLogo_Image.TabStop = False
        '
        'AppVersion_Label
        '
        resources.ApplyResources(Me.AppVersion_Label, "AppVersion_Label")
        Me.AppVersion_Label.BackColor = System.Drawing.Color.Transparent
        Me.AppVersion_Label.Name = "AppVersion_Label"
        '
        'AppCompil_Label
        '
        resources.ApplyResources(Me.AppCompil_Label, "AppCompil_Label")
        Me.AppCompil_Label.BackColor = System.Drawing.Color.Transparent
        Me.AppCompil_Label.Name = "AppCompil_Label"
        '
        'AppCopyrightLabel
        '
        resources.ApplyResources(Me.AppCopyrightLabel, "AppCopyrightLabel")
        Me.AppCopyrightLabel.BackColor = System.Drawing.Color.Transparent
        Me.AppCopyrightLabel.Name = "AppCopyrightLabel"
        '
        'AppVersionStringLabel
        '
        resources.ApplyResources(Me.AppVersionStringLabel, "AppVersionStringLabel")
        Me.AppVersionStringLabel.BackColor = System.Drawing.Color.Transparent
        Me.AppVersionStringLabel.Name = "AppVersionStringLabel"
        Me.CopyBuildStringToolTip.SetToolTip(Me.AppVersionStringLabel, resources.GetString("AppVersionStringLabel.ToolTip"))
        '
        'UI_Btn_LegacyAbout
        '
        resources.ApplyResources(Me.UI_Btn_LegacyAbout, "UI_Btn_LegacyAbout")
        Me.UI_Btn_LegacyAbout.BackColor = System.Drawing.SystemColors.Control
        Me.UI_Btn_LegacyAbout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UI_Btn_LegacyAbout.Name = "UI_Btn_LegacyAbout"
        Me.UI_Btn_LegacyAbout.UseVisualStyleBackColor = True
        '
        'UI_AllRightsLabel
        '
        resources.ApplyResources(Me.UI_AllRightsLabel, "UI_AllRightsLabel")
        Me.UI_AllRightsLabel.BackColor = System.Drawing.Color.Transparent
        Me.UI_AllRightsLabel.Name = "UI_AllRightsLabel"
        '
        'UI_ButtonsPanel
        '
        resources.ApplyResources(Me.UI_ButtonsPanel, "UI_ButtonsPanel")
        Me.UI_ButtonsPanel.BackColor = System.Drawing.Color.Transparent
        Me.UI_ButtonsPanel.Controls.Add(Me.UI_Btn_OK)
        Me.UI_ButtonsPanel.Controls.Add(Me.UI_Separator1)
        Me.UI_ButtonsPanel.Controls.Add(Me.UI_Btn_Mentions)
        Me.UI_ButtonsPanel.Controls.Add(Me.UI_Btn_LegacyAbout)
        Me.UI_ButtonsPanel.Name = "UI_ButtonsPanel"
        '
        'UI_Separator1
        '
        resources.ApplyResources(Me.UI_Separator1, "UI_Separator1")
        Me.UI_Separator1.BackColor = System.Drawing.Color.Transparent
        Me.UI_Separator1.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_ButtonSeparatorLight
        Me.UI_Separator1.Name = "UI_Separator1"
        Me.UI_Separator1.TabStop = False
        '
        'UI_Btn_Mentions
        '
        resources.ApplyResources(Me.UI_Btn_Mentions, "UI_Btn_Mentions")
        Me.UI_Btn_Mentions.BackColor = System.Drawing.SystemColors.Control
        Me.UI_Btn_Mentions.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UI_Btn_Mentions.Name = "UI_Btn_Mentions"
        Me.UI_Btn_Mentions.UseVisualStyleBackColor = True
        '
        'UI_BtmBar_Panel
        '
        resources.ApplyResources(Me.UI_BtmBar_Panel, "UI_BtmBar_Panel")
        Me.UI_BtmBar_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_BtmBar_Panel.Controls.Add(Me.UI_BtmBar_PanelBorder)
        Me.UI_BtmBar_Panel.Controls.Add(Me.Info_UpdateStatusIcon)
        Me.UI_BtmBar_Panel.Controls.Add(Me.UI_ButtonsPanel)
        Me.UI_BtmBar_Panel.Controls.Add(Me.UI_UpdateStatusPanel)
        Me.UI_BtmBar_Panel.Name = "UI_BtmBar_Panel"
        '
        'UI_BtmBar_PanelBorder
        '
        resources.ApplyResources(Me.UI_BtmBar_PanelBorder, "UI_BtmBar_PanelBorder")
        Me.UI_BtmBar_PanelBorder.BackColor = System.Drawing.Color.Transparent
        Me.UI_BtmBar_PanelBorder.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_BottomBarLight
        Me.UI_BtmBar_PanelBorder.Name = "UI_BtmBar_PanelBorder"
        '
        'UI_UpdateStatusPanel
        '
        resources.ApplyResources(Me.UI_UpdateStatusPanel, "UI_UpdateStatusPanel")
        Me.UI_UpdateStatusPanel.BackColor = System.Drawing.Color.Transparent
        Me.UI_UpdateStatusPanel.Controls.Add(Me.Info_UpdateStatus)
        Me.UI_UpdateStatusPanel.Controls.Add(Me.UI_Btn_GoToUpdateModal)
        Me.UI_UpdateStatusPanel.Name = "UI_UpdateStatusPanel"
        '
        'UI_Btn_GoToUpdateModal
        '
        Me.UI_Btn_GoToUpdateModal.ActiveLinkColor = System.Drawing.Color.MidnightBlue
        resources.ApplyResources(Me.UI_Btn_GoToUpdateModal, "UI_Btn_GoToUpdateModal")
        Me.UI_Btn_GoToUpdateModal.LinkColor = System.Drawing.Color.RoyalBlue
        Me.UI_Btn_GoToUpdateModal.Name = "UI_Btn_GoToUpdateModal"
        Me.UI_Btn_GoToUpdateModal.TabStop = True
        Me.UI_Btn_GoToUpdateModal.VisitedLinkColor = System.Drawing.Color.RoyalBlue
        '
        'UI_StatPanel
        '
        resources.ApplyResources(Me.UI_StatPanel, "UI_StatPanel")
        Me.UI_StatPanel.BackColor = System.Drawing.Color.Transparent
        Me.UI_StatPanel.Controls.Add(Me.UI_HeaderBorder)
        Me.UI_StatPanel.Controls.Add(Me.AppVersionStringLabel)
        Me.UI_StatPanel.Name = "UI_StatPanel"
        '
        'UI_HeaderBorder
        '
        resources.ApplyResources(Me.UI_HeaderBorder, "UI_HeaderBorder")
        Me.UI_HeaderBorder.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_BorderLineBottomLight
        Me.UI_HeaderBorder.Name = "UI_HeaderBorder"
        '
        'UI_AppNamePanel
        '
        resources.ApplyResources(Me.UI_AppNamePanel, "UI_AppNamePanel")
        Me.UI_AppNamePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_AppNamePanel.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.About_WindowBack
        Me.UI_AppNamePanel.Controls.Add(Me.UI_AppNameBorder)
        Me.UI_AppNamePanel.Controls.Add(Me.AppLogo_Image)
        Me.UI_AppNamePanel.Name = "UI_AppNamePanel"
        '
        'UI_AppNameBorder
        '
        resources.ApplyResources(Me.UI_AppNameBorder, "UI_AppNameBorder")
        Me.UI_AppNameBorder.BackColor = System.Drawing.Color.Transparent
        Me.UI_AppNameBorder.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_BorderLineBottom
        Me.UI_AppNameBorder.Name = "UI_AppNameBorder"
        '
        'UpdateSysVersion_Label
        '
        resources.ApplyResources(Me.UpdateSysVersion_Label, "UpdateSysVersion_Label")
        Me.UpdateSysVersion_Label.BackColor = System.Drawing.Color.Transparent
        Me.UpdateSysVersion_Label.Name = "UpdateSysVersion_Label"
        '
        'SMWC_ExcRel
        '
        resources.ApplyResources(Me.SMWC_ExcRel, "SMWC_ExcRel")
        Me.SMWC_ExcRel.BackColor = System.Drawing.Color.Transparent
        Me.SMWC_ExcRel.Name = "SMWC_ExcRel"
        '
        'Frm02_About
        '
        Me.AcceptButton = Me.UI_Btn_OK
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.CancelButton = Me.UI_Btn_OK
        Me.Controls.Add(Me.AppCopyrightLabel)
        Me.Controls.Add(Me.AppVersion_Label)
        Me.Controls.Add(Me.AppCompil_Label)
        Me.Controls.Add(Me.UI_BtmBar_Panel)
        Me.Controls.Add(Me.UI_AllRightsLabel)
        Me.Controls.Add(Me.UI_AppNamePanel)
        Me.Controls.Add(Me.UI_StatPanel)
        Me.Controls.Add(Me.SMWC_ExcRel)
        Me.Controls.Add(Me.UpdateSysVersion_Label)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm02_About"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.Info_UpdateStatusIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppLogo_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_ButtonsPanel.ResumeLayout(False)
        CType(Me.UI_Separator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_BtmBar_Panel.ResumeLayout(False)
        Me.UI_UpdateStatusPanel.ResumeLayout(False)
        Me.UI_UpdateStatusPanel.PerformLayout()
        Me.UI_StatPanel.ResumeLayout(False)
        Me.UI_AppNamePanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UI_Btn_OK As System.Windows.Forms.Button
    Friend WithEvents Info_UpdateStatusIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Info_UpdateStatus As System.Windows.Forms.Label
    Friend WithEvents AppLogo_Image As System.Windows.Forms.PictureBox
    Friend WithEvents AppVersion_Label As System.Windows.Forms.Label
    Friend WithEvents AppCompil_Label As System.Windows.Forms.Label
    Friend WithEvents AppCopyrightLabel As System.Windows.Forms.Label
    Friend WithEvents AppVersionStringLabel As System.Windows.Forms.Label
    Friend WithEvents UI_Btn_LegacyAbout As System.Windows.Forms.Button
    Friend WithEvents UI_AllRightsLabel As Label
    Friend WithEvents UI_ButtonsPanel As FlowLayoutPanel
    Friend WithEvents UI_Btn_Mentions As Button
    Friend WithEvents UI_Separator1 As PictureBox
    Friend WithEvents UI_BtmBar_Panel As Panel
    Friend WithEvents UI_UpdateStatusPanel As FlowLayoutPanel
    Friend WithEvents UI_StatPanel As Panel
    Friend WithEvents UI_HeaderBorder As Panel
    Friend WithEvents UI_AppNamePanel As Panel
    Friend WithEvents UI_AppNameBorder As Panel
    Friend WithEvents UI_Btn_GoToUpdateModal As LinkLabel
    Friend WithEvents UI_BtmBar_PanelBorder As Panel
    Friend WithEvents UpdateSysVersion_Label As Label
    Friend WithEvents CopyBuildStringToolTip As ToolTip
    Friend WithEvents SMWC_ExcRel As Label
End Class
