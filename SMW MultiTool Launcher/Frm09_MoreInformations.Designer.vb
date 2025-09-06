<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm09_MoreInformations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm09_MoreInformations))
        Me.UI_StatPanel_Icon = New System.Windows.Forms.PictureBox()
        Me.UI_StatPanel_Description = New System.Windows.Forms.Label()
        Me.UI_StatPanel = New SMWMTLextensions.AstraUI.AstraUI_BorderedDockPanel()
        Me.UI_StatPanel_Title = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.UI_BtmBar_Panel = New SMWMTLextensions.AstraUI.AstraUI_BorderedDockPanel()
        Me.UI_OtherCreditsEx = New SMWMTLextensions.AstraUI.AstraUI_BorderedBox()
        Me.Developement_Tool_GroupBox_Pic = New System.Windows.Forms.PictureBox()
        Me.OtherCredits_Text01 = New System.Windows.Forms.Label()
        Me.Developement_Tool_GroupBox_Text = New System.Windows.Forms.Label()
        Me.UI_OtherCredits_DevTools = New SMWMTLextensions.AstraUI.AstraUI_BorderedBox()
        Me.UI_OtherCreditsArranger = New System.Windows.Forms.FlowLayoutPanel()
        Me.AstraUI_BorderedBox1 = New SMWMTLextensions.AstraUI.AstraUI_BorderedBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AstraUI_BorderedBox2 = New SMWMTLextensions.AstraUI.AstraUI_BorderedBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UI_Tab_OtherCredits = New System.Windows.Forms.TabPage()
        Me.Changelog_TextBox = New System.Windows.Forms.RichTextBox()
        Me.UI_ChangelogPanel = New SMWMTLextensions.AstraUI.AstraUI_BorderedBox()
        Me.UI_Tab_Changelog = New System.Windows.Forms.TabPage()
        Me.Licence_TextBox = New System.Windows.Forms.RichTextBox()
        Me.UI_LicensePanel = New SMWMTLextensions.AstraUI.AstraUI_BorderedBox()
        Me.UI_Tab_LicenseApp = New System.Windows.Forms.TabPage()
        Me.LegalNoticeText_Title = New System.Windows.Forms.Label()
        Me.LegalNoticeText_Description = New System.Windows.Forms.Label()
        Me.LegalNotice_CustomBuildWarn_Icon = New System.Windows.Forms.PictureBox()
        Me.LegalNotice_CustomBuildWarn_Title = New System.Windows.Forms.Label()
        Me.LegalNotice_CustomBuildWarn_Description = New System.Windows.Forms.Label()
        Me.UI_Legal_CustomBuildWrn = New SMWMTLextensions.AstraUI.AstraUI_BorderedBox()
        Me.UI_Tab_LegalNotice = New System.Windows.Forms.TabPage()
        Me.UI_LegalNoticeArranger = New System.Windows.Forms.FlowLayoutPanel()
        Me.UI_LegalNoticeBlock = New System.Windows.Forms.FlowLayoutPanel()
        Me.UI_LegalNoticeTabControl = New SMWMTLextensions.AstraUI.AstraUI_VerticalTabControl()
        CType(Me.UI_StatPanel_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_StatPanel.SuspendLayout()
        Me.UI_BtmBar_Panel.SuspendLayout()
        CType(Me.Developement_Tool_GroupBox_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_OtherCredits_DevTools.SuspendLayout()
        Me.UI_OtherCreditsArranger.SuspendLayout()
        Me.AstraUI_BorderedBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AstraUI_BorderedBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_Tab_OtherCredits.SuspendLayout()
        Me.UI_ChangelogPanel.SuspendLayout()
        Me.UI_Tab_Changelog.SuspendLayout()
        Me.UI_LicensePanel.SuspendLayout()
        Me.UI_Tab_LicenseApp.SuspendLayout()
        CType(Me.LegalNotice_CustomBuildWarn_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_Legal_CustomBuildWrn.SuspendLayout()
        Me.UI_Tab_LegalNotice.SuspendLayout()
        Me.UI_LegalNoticeArranger.SuspendLayout()
        Me.UI_LegalNoticeBlock.SuspendLayout()
        Me.UI_LegalNoticeTabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'UI_StatPanel_Icon
        '
        Me.UI_StatPanel_Icon.BackColor = System.Drawing.Color.Transparent
        Me.UI_StatPanel_Icon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.MoreInformations_Icon
        resources.ApplyResources(Me.UI_StatPanel_Icon, "UI_StatPanel_Icon")
        Me.UI_StatPanel_Icon.Name = "UI_StatPanel_Icon"
        Me.UI_StatPanel_Icon.TabStop = False
        '
        'UI_StatPanel_Description
        '
        resources.ApplyResources(Me.UI_StatPanel_Description, "UI_StatPanel_Description")
        Me.UI_StatPanel_Description.AutoEllipsis = True
        Me.UI_StatPanel_Description.BackColor = System.Drawing.Color.Transparent
        Me.UI_StatPanel_Description.Name = "UI_StatPanel_Description"
        '
        'UI_StatPanel
        '
        Me.UI_StatPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_StatPanel.BorderAtBottom = True
        Me.UI_StatPanel.Controls.Add(Me.UI_StatPanel_Icon)
        Me.UI_StatPanel.Controls.Add(Me.UI_StatPanel_Title)
        Me.UI_StatPanel.Controls.Add(Me.UI_StatPanel_Description)
        resources.ApplyResources(Me.UI_StatPanel, "UI_StatPanel")
        Me.UI_StatPanel.Name = "UI_StatPanel"
        '
        'UI_StatPanel_Title
        '
        resources.ApplyResources(Me.UI_StatPanel_Title, "UI_StatPanel_Title")
        Me.UI_StatPanel_Title.AutoEllipsis = True
        Me.UI_StatPanel_Title.BackColor = System.Drawing.Color.Transparent
        Me.UI_StatPanel_Title.Name = "UI_StatPanel_Title"
        '
        'CloseBtn
        '
        resources.ApplyResources(Me.CloseBtn, "CloseBtn")
        Me.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'UI_BtmBar_Panel
        '
        Me.UI_BtmBar_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_BtmBar_Panel.Controls.Add(Me.CloseBtn)
        resources.ApplyResources(Me.UI_BtmBar_Panel, "UI_BtmBar_Panel")
        Me.UI_BtmBar_Panel.Name = "UI_BtmBar_Panel"
        '
        'UI_OtherCreditsEx
        '
        resources.ApplyResources(Me.UI_OtherCreditsEx, "UI_OtherCreditsEx")
        Me.UI_OtherCreditsEx.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UI_OtherCreditsEx.Name = "UI_OtherCreditsEx"
        '
        'Developement_Tool_GroupBox_Pic
        '
        Me.Developement_Tool_GroupBox_Pic.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.VSLogo
        resources.ApplyResources(Me.Developement_Tool_GroupBox_Pic, "Developement_Tool_GroupBox_Pic")
        Me.Developement_Tool_GroupBox_Pic.Name = "Developement_Tool_GroupBox_Pic"
        Me.Developement_Tool_GroupBox_Pic.TabStop = False
        '
        'OtherCredits_Text01
        '
        resources.ApplyResources(Me.OtherCredits_Text01, "OtherCredits_Text01")
        Me.OtherCredits_Text01.Name = "OtherCredits_Text01"
        '
        'Developement_Tool_GroupBox_Text
        '
        resources.ApplyResources(Me.Developement_Tool_GroupBox_Text, "Developement_Tool_GroupBox_Text")
        Me.Developement_Tool_GroupBox_Text.Name = "Developement_Tool_GroupBox_Text"
        '
        'UI_OtherCredits_DevTools
        '
        resources.ApplyResources(Me.UI_OtherCredits_DevTools, "UI_OtherCredits_DevTools")
        Me.UI_OtherCredits_DevTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_OtherCredits_DevTools.Controls.Add(Me.Developement_Tool_GroupBox_Pic)
        Me.UI_OtherCredits_DevTools.Controls.Add(Me.OtherCredits_Text01)
        Me.UI_OtherCredits_DevTools.Controls.Add(Me.Developement_Tool_GroupBox_Text)
        Me.UI_OtherCredits_DevTools.Name = "UI_OtherCredits_DevTools"
        '
        'UI_OtherCreditsArranger
        '
        resources.ApplyResources(Me.UI_OtherCreditsArranger, "UI_OtherCreditsArranger")
        Me.UI_OtherCreditsArranger.Controls.Add(Me.UI_OtherCredits_DevTools)
        Me.UI_OtherCreditsArranger.Controls.Add(Me.AstraUI_BorderedBox1)
        Me.UI_OtherCreditsArranger.Controls.Add(Me.AstraUI_BorderedBox2)
        Me.UI_OtherCreditsArranger.Controls.Add(Me.UI_OtherCreditsEx)
        Me.UI_OtherCreditsArranger.Name = "UI_OtherCreditsArranger"
        '
        'AstraUI_BorderedBox1
        '
        resources.ApplyResources(Me.AstraUI_BorderedBox1, "AstraUI_BorderedBox1")
        Me.AstraUI_BorderedBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.AstraUI_BorderedBox1.Controls.Add(Me.PictureBox1)
        Me.AstraUI_BorderedBox1.Controls.Add(Me.Label1)
        Me.AstraUI_BorderedBox1.Controls.Add(Me.Label2)
        Me.AstraUI_BorderedBox1.Name = "AstraUI_BorderedBox1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.VSLogo
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'AstraUI_BorderedBox2
        '
        resources.ApplyResources(Me.AstraUI_BorderedBox2, "AstraUI_BorderedBox2")
        Me.AstraUI_BorderedBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.AstraUI_BorderedBox2.Controls.Add(Me.PictureBox2)
        Me.AstraUI_BorderedBox2.Controls.Add(Me.Label3)
        Me.AstraUI_BorderedBox2.Controls.Add(Me.Label4)
        Me.AstraUI_BorderedBox2.Name = "AstraUI_BorderedBox2"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.VSLogo
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'UI_Tab_OtherCredits
        '
        Me.UI_Tab_OtherCredits.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UI_Tab_OtherCredits.Controls.Add(Me.UI_OtherCreditsArranger)
        resources.ApplyResources(Me.UI_Tab_OtherCredits, "UI_Tab_OtherCredits")
        Me.UI_Tab_OtherCredits.Name = "UI_Tab_OtherCredits"
        '
        'Changelog_TextBox
        '
        Me.Changelog_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Changelog_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Changelog_TextBox.DetectUrls = False
        resources.ApplyResources(Me.Changelog_TextBox, "Changelog_TextBox")
        Me.Changelog_TextBox.Name = "Changelog_TextBox"
        Me.Changelog_TextBox.ReadOnly = True
        '
        'UI_ChangelogPanel
        '
        resources.ApplyResources(Me.UI_ChangelogPanel, "UI_ChangelogPanel")
        Me.UI_ChangelogPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_ChangelogPanel.Controls.Add(Me.Changelog_TextBox)
        Me.UI_ChangelogPanel.Name = "UI_ChangelogPanel"
        '
        'UI_Tab_Changelog
        '
        Me.UI_Tab_Changelog.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UI_Tab_Changelog.Controls.Add(Me.UI_ChangelogPanel)
        resources.ApplyResources(Me.UI_Tab_Changelog, "UI_Tab_Changelog")
        Me.UI_Tab_Changelog.Name = "UI_Tab_Changelog"
        '
        'Licence_TextBox
        '
        Me.Licence_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Licence_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.Licence_TextBox, "Licence_TextBox")
        Me.Licence_TextBox.Name = "Licence_TextBox"
        Me.Licence_TextBox.ReadOnly = True
        '
        'UI_LicensePanel
        '
        resources.ApplyResources(Me.UI_LicensePanel, "UI_LicensePanel")
        Me.UI_LicensePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_LicensePanel.Controls.Add(Me.Licence_TextBox)
        Me.UI_LicensePanel.Name = "UI_LicensePanel"
        '
        'UI_Tab_LicenseApp
        '
        Me.UI_Tab_LicenseApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UI_Tab_LicenseApp.Controls.Add(Me.UI_LicensePanel)
        resources.ApplyResources(Me.UI_Tab_LicenseApp, "UI_Tab_LicenseApp")
        Me.UI_Tab_LicenseApp.Name = "UI_Tab_LicenseApp"
        '
        'LegalNoticeText_Title
        '
        Me.LegalNoticeText_Title.AutoEllipsis = True
        resources.ApplyResources(Me.LegalNoticeText_Title, "LegalNoticeText_Title")
        Me.LegalNoticeText_Title.Name = "LegalNoticeText_Title"
        '
        'LegalNoticeText_Description
        '
        resources.ApplyResources(Me.LegalNoticeText_Description, "LegalNoticeText_Description")
        Me.LegalNoticeText_Description.Name = "LegalNoticeText_Description"
        '
        'LegalNotice_CustomBuildWarn_Icon
        '
        Me.LegalNotice_CustomBuildWarn_Icon.BackColor = System.Drawing.Color.Transparent
        Me.LegalNotice_CustomBuildWarn_Icon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_Badge_Warning
        resources.ApplyResources(Me.LegalNotice_CustomBuildWarn_Icon, "LegalNotice_CustomBuildWarn_Icon")
        Me.LegalNotice_CustomBuildWarn_Icon.Name = "LegalNotice_CustomBuildWarn_Icon"
        Me.LegalNotice_CustomBuildWarn_Icon.TabStop = False
        '
        'LegalNotice_CustomBuildWarn_Title
        '
        Me.LegalNotice_CustomBuildWarn_Title.AutoEllipsis = True
        Me.LegalNotice_CustomBuildWarn_Title.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.LegalNotice_CustomBuildWarn_Title, "LegalNotice_CustomBuildWarn_Title")
        Me.LegalNotice_CustomBuildWarn_Title.Name = "LegalNotice_CustomBuildWarn_Title"
        '
        'LegalNotice_CustomBuildWarn_Description
        '
        resources.ApplyResources(Me.LegalNotice_CustomBuildWarn_Description, "LegalNotice_CustomBuildWarn_Description")
        Me.LegalNotice_CustomBuildWarn_Description.BackColor = System.Drawing.Color.Transparent
        Me.LegalNotice_CustomBuildWarn_Description.Name = "LegalNotice_CustomBuildWarn_Description"
        '
        'UI_Legal_CustomBuildWrn
        '
        resources.ApplyResources(Me.UI_Legal_CustomBuildWrn, "UI_Legal_CustomBuildWrn")
        Me.UI_Legal_CustomBuildWrn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UI_Legal_CustomBuildWrn.Controls.Add(Me.LegalNotice_CustomBuildWarn_Icon)
        Me.UI_Legal_CustomBuildWrn.Controls.Add(Me.LegalNotice_CustomBuildWarn_Title)
        Me.UI_Legal_CustomBuildWrn.Controls.Add(Me.LegalNotice_CustomBuildWarn_Description)
        Me.UI_Legal_CustomBuildWrn.Name = "UI_Legal_CustomBuildWrn"
        '
        'UI_Tab_LegalNotice
        '
        Me.UI_Tab_LegalNotice.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UI_Tab_LegalNotice.Controls.Add(Me.UI_LegalNoticeArranger)
        resources.ApplyResources(Me.UI_Tab_LegalNotice, "UI_Tab_LegalNotice")
        Me.UI_Tab_LegalNotice.Name = "UI_Tab_LegalNotice"
        '
        'UI_LegalNoticeArranger
        '
        resources.ApplyResources(Me.UI_LegalNoticeArranger, "UI_LegalNoticeArranger")
        Me.UI_LegalNoticeArranger.Controls.Add(Me.UI_Legal_CustomBuildWrn)
        Me.UI_LegalNoticeArranger.Controls.Add(Me.UI_LegalNoticeBlock)
        Me.UI_LegalNoticeArranger.Name = "UI_LegalNoticeArranger"
        '
        'UI_LegalNoticeBlock
        '
        resources.ApplyResources(Me.UI_LegalNoticeBlock, "UI_LegalNoticeBlock")
        Me.UI_LegalNoticeBlock.Controls.Add(Me.LegalNoticeText_Title)
        Me.UI_LegalNoticeBlock.Controls.Add(Me.LegalNoticeText_Description)
        Me.UI_LegalNoticeBlock.Name = "UI_LegalNoticeBlock"
        '
        'UI_LegalNoticeTabControl
        '
        resources.ApplyResources(Me.UI_LegalNoticeTabControl, "UI_LegalNoticeTabControl")
        Me.UI_LegalNoticeTabControl.Controls.Add(Me.UI_Tab_LegalNotice)
        Me.UI_LegalNoticeTabControl.Controls.Add(Me.UI_Tab_LicenseApp)
        Me.UI_LegalNoticeTabControl.Controls.Add(Me.UI_Tab_Changelog)
        Me.UI_LegalNoticeTabControl.Controls.Add(Me.UI_Tab_OtherCredits)
        Me.UI_LegalNoticeTabControl.Multiline = True
        Me.UI_LegalNoticeTabControl.Name = "UI_LegalNoticeTabControl"
        Me.UI_LegalNoticeTabControl.SelectedIndex = 0
        Me.UI_LegalNoticeTabControl.ShowTabTagVBorder = True
        Me.UI_LegalNoticeTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        '
        'Frm09_MoreInformations
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.CancelButton = Me.CloseBtn
        Me.Controls.Add(Me.UI_StatPanel)
        Me.Controls.Add(Me.UI_BtmBar_Panel)
        Me.Controls.Add(Me.UI_LegalNoticeTabControl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm09_MoreInformations"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.UI_StatPanel_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_StatPanel.ResumeLayout(False)
        Me.UI_BtmBar_Panel.ResumeLayout(False)
        CType(Me.Developement_Tool_GroupBox_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_OtherCredits_DevTools.ResumeLayout(False)
        Me.UI_OtherCredits_DevTools.PerformLayout()
        Me.UI_OtherCreditsArranger.ResumeLayout(False)
        Me.AstraUI_BorderedBox1.ResumeLayout(False)
        Me.AstraUI_BorderedBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AstraUI_BorderedBox2.ResumeLayout(False)
        Me.AstraUI_BorderedBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_Tab_OtherCredits.ResumeLayout(False)
        Me.UI_ChangelogPanel.ResumeLayout(False)
        Me.UI_Tab_Changelog.ResumeLayout(False)
        Me.UI_LicensePanel.ResumeLayout(False)
        Me.UI_Tab_LicenseApp.ResumeLayout(False)
        CType(Me.LegalNotice_CustomBuildWarn_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_Legal_CustomBuildWrn.ResumeLayout(False)
        Me.UI_Legal_CustomBuildWrn.PerformLayout()
        Me.UI_Tab_LegalNotice.ResumeLayout(False)
        Me.UI_LegalNoticeArranger.ResumeLayout(False)
        Me.UI_LegalNoticeArranger.PerformLayout()
        Me.UI_LegalNoticeBlock.ResumeLayout(False)
        Me.UI_LegalNoticeBlock.PerformLayout()
        Me.UI_LegalNoticeTabControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UI_StatPanel_Icon As PictureBox
    Friend WithEvents UI_StatPanel_Description As Label
    Friend WithEvents UI_StatPanel As SMWMTLextensions.AstraUI.AstraUI_BorderedDockPanel
    Friend WithEvents UI_StatPanel_Title As Label
    Friend WithEvents CloseBtn As Button
    Friend WithEvents UI_BtmBar_Panel As SMWMTLextensions.AstraUI.AstraUI_BorderedDockPanel
    Friend WithEvents UI_OtherCreditsEx As SMWMTLextensions.AstraUI.AstraUI_BorderedBox
    Friend WithEvents Developement_Tool_GroupBox_Pic As PictureBox
    Friend WithEvents OtherCredits_Text01 As Label
    Friend WithEvents Developement_Tool_GroupBox_Text As Label
    Friend WithEvents UI_OtherCredits_DevTools As SMWMTLextensions.AstraUI.AstraUI_BorderedBox
    Friend WithEvents UI_OtherCreditsArranger As FlowLayoutPanel
    Friend WithEvents UI_Tab_OtherCredits As TabPage
    Friend WithEvents Changelog_TextBox As RichTextBox
    Friend WithEvents UI_ChangelogPanel As SMWMTLextensions.AstraUI.AstraUI_BorderedBox
    Friend WithEvents UI_Tab_Changelog As TabPage
    Friend WithEvents Licence_TextBox As RichTextBox
    Friend WithEvents UI_LicensePanel As SMWMTLextensions.AstraUI.AstraUI_BorderedBox
    Friend WithEvents UI_Tab_LicenseApp As TabPage
    Friend WithEvents LegalNoticeText_Title As Label
    Friend WithEvents LegalNoticeText_Description As Label
    Friend WithEvents LegalNotice_CustomBuildWarn_Icon As PictureBox
    Friend WithEvents LegalNotice_CustomBuildWarn_Title As Label
    Friend WithEvents LegalNotice_CustomBuildWarn_Description As Label
    Friend WithEvents UI_Legal_CustomBuildWrn As SMWMTLextensions.AstraUI.AstraUI_BorderedBox
    Friend WithEvents UI_Tab_LegalNotice As TabPage
    Friend WithEvents UI_LegalNoticeTabControl As SMWMTLextensions.AstraUI.AstraUI_VerticalTabControl
    Friend WithEvents UI_LegalNoticeArranger As FlowLayoutPanel
    Friend WithEvents UI_LegalNoticeBlock As FlowLayoutPanel
    Friend WithEvents AstraUI_BorderedBox1 As SMWMTLextensions.AstraUI.AstraUI_BorderedBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AstraUI_BorderedBox2 As SMWMTLextensions.AstraUI.AstraUI_BorderedBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
