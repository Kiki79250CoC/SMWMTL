<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm09_MoreInformations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm09_MoreInformations))
        Me.InformationsTabControl = New System.Windows.Forms.TabControl()
        Me.UI_Tab01_LegalNotice = New System.Windows.Forms.TabPage()
        Me.LegalNotice_Text04 = New System.Windows.Forms.Label()
        Me.LegalNotice_Text03 = New System.Windows.Forms.Label()
        Me.LegalNotice_Text02 = New System.Windows.Forms.Label()
        Me.LegalNotice_Text01 = New System.Windows.Forms.Label()
        Me.UI_Tab02_License = New System.Windows.Forms.TabPage()
        Me.UI_LicensePanel = New System.Windows.Forms.Panel()
        Me.Licence_TextBox = New System.Windows.Forms.RichTextBox()
        Me.UI_Tab03_Changelog = New System.Windows.Forms.TabPage()
        Me.UI_ChangelogPanel = New System.Windows.Forms.Panel()
        Me.Changelog_TextBox = New System.Windows.Forms.RichTextBox()
        Me.UI_Tab04_OtherCredits = New System.Windows.Forms.TabPage()
        Me.Developement_Tool_GroupBox_Text = New System.Windows.Forms.Label()
        Me.Developement_Tool_GroupBox_Pic = New System.Windows.Forms.PictureBox()
        Me.OtherCredits_Text01 = New System.Windows.Forms.Label()
        Me.UI_StatPanel = New System.Windows.Forms.Panel()
        Me.UI_HeaderBorder = New System.Windows.Forms.Panel()
        Me.UI_StatPanel_Icon = New System.Windows.Forms.PictureBox()
        Me.UI_StatPanel_Description = New System.Windows.Forms.Label()
        Me.UI_StatPanel_Title = New System.Windows.Forms.Label()
        Me.UI_BtmBar_Panel = New System.Windows.Forms.Panel()
        Me.UI_ButtonsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.UI_ButtonsPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.UI_LegalNoticeBtn = New System.Windows.Forms.Button()
        Me.UI_AppLicenseBtn = New System.Windows.Forms.Button()
        Me.UI_AppChangelogBtn = New System.Windows.Forms.Button()
        Me.UI_OtherCreditsBtn = New System.Windows.Forms.Button()
        Me.InformationsTabControl.SuspendLayout()
        Me.UI_Tab01_LegalNotice.SuspendLayout()
        Me.UI_Tab02_License.SuspendLayout()
        Me.UI_LicensePanel.SuspendLayout()
        Me.UI_Tab03_Changelog.SuspendLayout()
        Me.UI_ChangelogPanel.SuspendLayout()
        Me.UI_Tab04_OtherCredits.SuspendLayout()
        CType(Me.Developement_Tool_GroupBox_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_StatPanel.SuspendLayout()
        CType(Me.UI_StatPanel_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_BtmBar_Panel.SuspendLayout()
        Me.UI_ButtonsPanel.SuspendLayout()
        Me.UI_ButtonsPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'InformationsTabControl
        '
        resources.ApplyResources(Me.InformationsTabControl, "InformationsTabControl")
        Me.InformationsTabControl.Controls.Add(Me.UI_Tab01_LegalNotice)
        Me.InformationsTabControl.Controls.Add(Me.UI_Tab02_License)
        Me.InformationsTabControl.Controls.Add(Me.UI_Tab03_Changelog)
        Me.InformationsTabControl.Controls.Add(Me.UI_Tab04_OtherCredits)
        Me.InformationsTabControl.Name = "InformationsTabControl"
        Me.InformationsTabControl.SelectedIndex = 0
        Me.InformationsTabControl.TabStop = False
        '
        'UI_Tab01_LegalNotice
        '
        resources.ApplyResources(Me.UI_Tab01_LegalNotice, "UI_Tab01_LegalNotice")
        Me.UI_Tab01_LegalNotice.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.UI_Tab01_LegalNotice.Controls.Add(Me.LegalNotice_Text04)
        Me.UI_Tab01_LegalNotice.Controls.Add(Me.LegalNotice_Text03)
        Me.UI_Tab01_LegalNotice.Controls.Add(Me.LegalNotice_Text02)
        Me.UI_Tab01_LegalNotice.Controls.Add(Me.LegalNotice_Text01)
        Me.UI_Tab01_LegalNotice.Name = "UI_Tab01_LegalNotice"
        '
        'LegalNotice_Text04
        '
        resources.ApplyResources(Me.LegalNotice_Text04, "LegalNotice_Text04")
        Me.LegalNotice_Text04.Name = "LegalNotice_Text04"
        '
        'LegalNotice_Text03
        '
        resources.ApplyResources(Me.LegalNotice_Text03, "LegalNotice_Text03")
        Me.LegalNotice_Text03.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LegalNotice_Text03.Name = "LegalNotice_Text03"
        '
        'LegalNotice_Text02
        '
        resources.ApplyResources(Me.LegalNotice_Text02, "LegalNotice_Text02")
        Me.LegalNotice_Text02.Name = "LegalNotice_Text02"
        '
        'LegalNotice_Text01
        '
        resources.ApplyResources(Me.LegalNotice_Text01, "LegalNotice_Text01")
        Me.LegalNotice_Text01.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LegalNotice_Text01.Name = "LegalNotice_Text01"
        '
        'UI_Tab02_License
        '
        resources.ApplyResources(Me.UI_Tab02_License, "UI_Tab02_License")
        Me.UI_Tab02_License.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.UI_Tab02_License.Controls.Add(Me.UI_LicensePanel)
        Me.UI_Tab02_License.Name = "UI_Tab02_License"
        '
        'UI_LicensePanel
        '
        resources.ApplyResources(Me.UI_LicensePanel, "UI_LicensePanel")
        Me.UI_LicensePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_LicensePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UI_LicensePanel.Controls.Add(Me.Licence_TextBox)
        Me.UI_LicensePanel.Name = "UI_LicensePanel"
        '
        'Licence_TextBox
        '
        resources.ApplyResources(Me.Licence_TextBox, "Licence_TextBox")
        Me.Licence_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Licence_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Licence_TextBox.Name = "Licence_TextBox"
        Me.Licence_TextBox.ReadOnly = True
        '
        'UI_Tab03_Changelog
        '
        resources.ApplyResources(Me.UI_Tab03_Changelog, "UI_Tab03_Changelog")
        Me.UI_Tab03_Changelog.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.UI_Tab03_Changelog.Controls.Add(Me.UI_ChangelogPanel)
        Me.UI_Tab03_Changelog.Name = "UI_Tab03_Changelog"
        '
        'UI_ChangelogPanel
        '
        resources.ApplyResources(Me.UI_ChangelogPanel, "UI_ChangelogPanel")
        Me.UI_ChangelogPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_ChangelogPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UI_ChangelogPanel.Controls.Add(Me.Changelog_TextBox)
        Me.UI_ChangelogPanel.Name = "UI_ChangelogPanel"
        '
        'Changelog_TextBox
        '
        resources.ApplyResources(Me.Changelog_TextBox, "Changelog_TextBox")
        Me.Changelog_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Changelog_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Changelog_TextBox.DetectUrls = False
        Me.Changelog_TextBox.Name = "Changelog_TextBox"
        Me.Changelog_TextBox.ReadOnly = True
        '
        'UI_Tab04_OtherCredits
        '
        resources.ApplyResources(Me.UI_Tab04_OtherCredits, "UI_Tab04_OtherCredits")
        Me.UI_Tab04_OtherCredits.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.UI_Tab04_OtherCredits.Controls.Add(Me.Developement_Tool_GroupBox_Text)
        Me.UI_Tab04_OtherCredits.Controls.Add(Me.Developement_Tool_GroupBox_Pic)
        Me.UI_Tab04_OtherCredits.Controls.Add(Me.OtherCredits_Text01)
        Me.UI_Tab04_OtherCredits.Name = "UI_Tab04_OtherCredits"
        '
        'Developement_Tool_GroupBox_Text
        '
        resources.ApplyResources(Me.Developement_Tool_GroupBox_Text, "Developement_Tool_GroupBox_Text")
        Me.Developement_Tool_GroupBox_Text.Name = "Developement_Tool_GroupBox_Text"
        '
        'Developement_Tool_GroupBox_Pic
        '
        resources.ApplyResources(Me.Developement_Tool_GroupBox_Pic, "Developement_Tool_GroupBox_Pic")
        Me.Developement_Tool_GroupBox_Pic.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.VSLogo
        Me.Developement_Tool_GroupBox_Pic.Name = "Developement_Tool_GroupBox_Pic"
        Me.Developement_Tool_GroupBox_Pic.TabStop = False
        '
        'OtherCredits_Text01
        '
        resources.ApplyResources(Me.OtherCredits_Text01, "OtherCredits_Text01")
        Me.OtherCredits_Text01.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.OtherCredits_Text01.Name = "OtherCredits_Text01"
        '
        'UI_StatPanel
        '
        resources.ApplyResources(Me.UI_StatPanel, "UI_StatPanel")
        Me.UI_StatPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_StatPanel.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.TitleBlue
        Me.UI_StatPanel.Controls.Add(Me.UI_HeaderBorder)
        Me.UI_StatPanel.Controls.Add(Me.UI_StatPanel_Icon)
        Me.UI_StatPanel.Controls.Add(Me.UI_StatPanel_Description)
        Me.UI_StatPanel.Controls.Add(Me.UI_StatPanel_Title)
        Me.UI_StatPanel.Name = "UI_StatPanel"
        '
        'UI_HeaderBorder
        '
        resources.ApplyResources(Me.UI_HeaderBorder, "UI_HeaderBorder")
        Me.UI_HeaderBorder.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_BorderLineBottomLight
        Me.UI_HeaderBorder.Name = "UI_HeaderBorder"
        '
        'UI_StatPanel_Icon
        '
        resources.ApplyResources(Me.UI_StatPanel_Icon, "UI_StatPanel_Icon")
        Me.UI_StatPanel_Icon.BackColor = System.Drawing.Color.Transparent
        Me.UI_StatPanel_Icon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.MoreInformations_Icon
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
        'UI_BtmBar_Panel
        '
        resources.ApplyResources(Me.UI_BtmBar_Panel, "UI_BtmBar_Panel")
        Me.UI_BtmBar_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_BtmBar_Panel.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_BottomBarLight
        Me.UI_BtmBar_Panel.Controls.Add(Me.UI_ButtonsPanel)
        Me.UI_BtmBar_Panel.Controls.Add(Me.UI_ButtonsPanel2)
        Me.UI_BtmBar_Panel.Name = "UI_BtmBar_Panel"
        '
        'UI_ButtonsPanel
        '
        resources.ApplyResources(Me.UI_ButtonsPanel, "UI_ButtonsPanel")
        Me.UI_ButtonsPanel.BackColor = System.Drawing.Color.Transparent
        Me.UI_ButtonsPanel.Controls.Add(Me.CloseBtn)
        Me.UI_ButtonsPanel.Name = "UI_ButtonsPanel"
        '
        'CloseBtn
        '
        resources.ApplyResources(Me.CloseBtn, "CloseBtn")
        Me.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'UI_ButtonsPanel2
        '
        resources.ApplyResources(Me.UI_ButtonsPanel2, "UI_ButtonsPanel2")
        Me.UI_ButtonsPanel2.BackColor = System.Drawing.Color.Transparent
        Me.UI_ButtonsPanel2.Controls.Add(Me.UI_LegalNoticeBtn)
        Me.UI_ButtonsPanel2.Controls.Add(Me.UI_AppLicenseBtn)
        Me.UI_ButtonsPanel2.Controls.Add(Me.UI_AppChangelogBtn)
        Me.UI_ButtonsPanel2.Controls.Add(Me.UI_OtherCreditsBtn)
        Me.UI_ButtonsPanel2.Name = "UI_ButtonsPanel2"
        '
        'UI_LegalNoticeBtn
        '
        resources.ApplyResources(Me.UI_LegalNoticeBtn, "UI_LegalNoticeBtn")
        Me.UI_LegalNoticeBtn.Name = "UI_LegalNoticeBtn"
        Me.UI_LegalNoticeBtn.UseVisualStyleBackColor = True
        '
        'UI_AppLicenseBtn
        '
        resources.ApplyResources(Me.UI_AppLicenseBtn, "UI_AppLicenseBtn")
        Me.UI_AppLicenseBtn.Name = "UI_AppLicenseBtn"
        Me.UI_AppLicenseBtn.UseVisualStyleBackColor = True
        '
        'UI_AppChangelogBtn
        '
        resources.ApplyResources(Me.UI_AppChangelogBtn, "UI_AppChangelogBtn")
        Me.UI_AppChangelogBtn.Name = "UI_AppChangelogBtn"
        Me.UI_AppChangelogBtn.UseVisualStyleBackColor = True
        '
        'UI_OtherCreditsBtn
        '
        resources.ApplyResources(Me.UI_OtherCreditsBtn, "UI_OtherCreditsBtn")
        Me.UI_OtherCreditsBtn.Name = "UI_OtherCreditsBtn"
        Me.UI_OtherCreditsBtn.UseVisualStyleBackColor = True
        '
        'Frm09_MoreInformations
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UI_BtmBar_Panel)
        Me.Controls.Add(Me.UI_StatPanel)
        Me.Controls.Add(Me.InformationsTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm09_MoreInformations"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.InformationsTabControl.ResumeLayout(False)
        Me.UI_Tab01_LegalNotice.ResumeLayout(False)
        Me.UI_Tab01_LegalNotice.PerformLayout()
        Me.UI_Tab02_License.ResumeLayout(False)
        Me.UI_LicensePanel.ResumeLayout(False)
        Me.UI_Tab03_Changelog.ResumeLayout(False)
        Me.UI_ChangelogPanel.ResumeLayout(False)
        Me.UI_Tab04_OtherCredits.ResumeLayout(False)
        Me.UI_Tab04_OtherCredits.PerformLayout()
        CType(Me.Developement_Tool_GroupBox_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_StatPanel.ResumeLayout(False)
        CType(Me.UI_StatPanel_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_BtmBar_Panel.ResumeLayout(False)
        Me.UI_ButtonsPanel.ResumeLayout(False)
        Me.UI_ButtonsPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InformationsTabControl As System.Windows.Forms.TabControl
    Friend WithEvents UI_Tab01_LegalNotice As System.Windows.Forms.TabPage
    Friend WithEvents UI_Tab02_License As System.Windows.Forms.TabPage
    Friend WithEvents Licence_TextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents UI_Tab03_Changelog As TabPage
    Friend WithEvents Changelog_TextBox As RichTextBox
    Friend WithEvents LegalNotice_Text01 As Label
    Friend WithEvents LegalNotice_Text02 As Label
    Friend WithEvents UI_Tab04_OtherCredits As TabPage
    Friend WithEvents Developement_Tool_GroupBox_Text As Label
    Friend WithEvents Developement_Tool_GroupBox_Pic As PictureBox
    Friend WithEvents UI_StatPanel As Panel
    Friend WithEvents UI_HeaderBorder As Panel
    Friend WithEvents UI_StatPanel_Icon As PictureBox
    Friend WithEvents UI_StatPanel_Description As Label
    Friend WithEvents UI_StatPanel_Title As Label
    Friend WithEvents UI_BtmBar_Panel As Panel
    Friend WithEvents UI_ButtonsPanel As FlowLayoutPanel
    Friend WithEvents CloseBtn As Button
    Friend WithEvents UI_ButtonsPanel2 As FlowLayoutPanel
    Friend WithEvents UI_LegalNoticeBtn As Button
    Friend WithEvents UI_AppLicenseBtn As Button
    Friend WithEvents UI_AppChangelogBtn As Button
    Friend WithEvents UI_LicensePanel As Panel
    Friend WithEvents UI_OtherCreditsBtn As Button
    Friend WithEvents UI_ChangelogPanel As Panel
    Friend WithEvents OtherCredits_Text01 As Label
    Friend WithEvents LegalNotice_Text04 As Label
    Friend WithEvents LegalNotice_Text03 As Label
End Class
