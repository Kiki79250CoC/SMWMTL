<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm07_BugsFound
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm07_BugsFound))
        Me.OK_Btn = New System.Windows.Forms.Button()
        Me.DashSeparatorLabel = New System.Windows.Forms.Label()
        Me.SMWC_Profile_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SMWC_ComposeMsg_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Mailto_LinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Text_1 = New System.Windows.Forms.Label()
        Me.GitHubBtn = New System.Windows.Forms.Button()
        Me.YouTubeBtn = New System.Windows.Forms.Button()
        Me.TwitterBtn = New System.Windows.Forms.Button()
        Me.UI_BtmBar_Panel = New System.Windows.Forms.Panel()
        Me.UI_ButtonsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.UI_ButtonsPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.UI_StatPanel = New System.Windows.Forms.Panel()
        Me.UI_HeaderBorder = New System.Windows.Forms.Panel()
        Me.UI_StatPanel_Icon = New System.Windows.Forms.PictureBox()
        Me.UI_StatPanel_Description = New System.Windows.Forms.Label()
        Me.UI_StatPanel_Title = New System.Windows.Forms.Label()
        Me.UI_BtmBar_Panel.SuspendLayout()
        Me.UI_ButtonsPanel.SuspendLayout()
        Me.UI_ButtonsPanel2.SuspendLayout()
        Me.UI_StatPanel.SuspendLayout()
        CType(Me.UI_StatPanel_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Btn
        '
        resources.ApplyResources(Me.OK_Btn, "OK_Btn")
        Me.OK_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OK_Btn.Name = "OK_Btn"
        Me.OK_Btn.UseVisualStyleBackColor = True
        '
        'DashSeparatorLabel
        '
        resources.ApplyResources(Me.DashSeparatorLabel, "DashSeparatorLabel")
        Me.DashSeparatorLabel.Name = "DashSeparatorLabel"
        '
        'SMWC_Profile_LinkLabel
        '
        resources.ApplyResources(Me.SMWC_Profile_LinkLabel, "SMWC_Profile_LinkLabel")
        Me.SMWC_Profile_LinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.SMWC_Profile_LinkLabel.LinkColor = System.Drawing.Color.RoyalBlue
        Me.SMWC_Profile_LinkLabel.Name = "SMWC_Profile_LinkLabel"
        Me.SMWC_Profile_LinkLabel.TabStop = True
        '
        'SMWC_ComposeMsg_LinkLabel
        '
        resources.ApplyResources(Me.SMWC_ComposeMsg_LinkLabel, "SMWC_ComposeMsg_LinkLabel")
        Me.SMWC_ComposeMsg_LinkLabel.DisabledLinkColor = System.Drawing.Color.Black
        Me.SMWC_ComposeMsg_LinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.SMWC_ComposeMsg_LinkLabel.LinkColor = System.Drawing.Color.RoyalBlue
        Me.SMWC_ComposeMsg_LinkLabel.Name = "SMWC_ComposeMsg_LinkLabel"
        Me.SMWC_ComposeMsg_LinkLabel.TabStop = True
        '
        'Mailto_LinkLabel
        '
        resources.ApplyResources(Me.Mailto_LinkLabel, "Mailto_LinkLabel")
        Me.Mailto_LinkLabel.DisabledLinkColor = System.Drawing.Color.Black
        Me.Mailto_LinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.Mailto_LinkLabel.LinkColor = System.Drawing.Color.RoyalBlue
        Me.Mailto_LinkLabel.Name = "Mailto_LinkLabel"
        Me.Mailto_LinkLabel.TabStop = True
        '
        'Text_1
        '
        resources.ApplyResources(Me.Text_1, "Text_1")
        Me.Text_1.Name = "Text_1"
        '
        'GitHubBtn
        '
        resources.ApplyResources(Me.GitHubBtn, "GitHubBtn")
        Me.GitHubBtn.BackColor = System.Drawing.SystemColors.Control
        Me.GitHubBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GitHubBtn.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.GitHub_16
        Me.GitHubBtn.Name = "GitHubBtn"
        Me.GitHubBtn.UseVisualStyleBackColor = True
        '
        'YouTubeBtn
        '
        resources.ApplyResources(Me.YouTubeBtn, "YouTubeBtn")
        Me.YouTubeBtn.BackColor = System.Drawing.SystemColors.Control
        Me.YouTubeBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.YouTubeBtn.Name = "YouTubeBtn"
        Me.YouTubeBtn.UseVisualStyleBackColor = True
        '
        'TwitterBtn
        '
        resources.ApplyResources(Me.TwitterBtn, "TwitterBtn")
        Me.TwitterBtn.BackColor = System.Drawing.SystemColors.Control
        Me.TwitterBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TwitterBtn.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.Twitter_16
        Me.TwitterBtn.Name = "TwitterBtn"
        Me.TwitterBtn.UseVisualStyleBackColor = True
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
        Me.UI_ButtonsPanel.Controls.Add(Me.OK_Btn)
        Me.UI_ButtonsPanel.Name = "UI_ButtonsPanel"
        '
        'UI_ButtonsPanel2
        '
        resources.ApplyResources(Me.UI_ButtonsPanel2, "UI_ButtonsPanel2")
        Me.UI_ButtonsPanel2.BackColor = System.Drawing.Color.Transparent
        Me.UI_ButtonsPanel2.Controls.Add(Me.TwitterBtn)
        Me.UI_ButtonsPanel2.Controls.Add(Me.YouTubeBtn)
        Me.UI_ButtonsPanel2.Controls.Add(Me.GitHubBtn)
        Me.UI_ButtonsPanel2.Name = "UI_ButtonsPanel2"
        '
        'UI_StatPanel
        '
        resources.ApplyResources(Me.UI_StatPanel, "UI_StatPanel")
        Me.UI_StatPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_StatPanel.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.TitleRed
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
        Me.UI_StatPanel_Icon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_Badge_Error
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
        'Frm07_BugsFound
        '
        Me.AcceptButton = Me.OK_Btn
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.CancelButton = Me.OK_Btn
        Me.Controls.Add(Me.DashSeparatorLabel)
        Me.Controls.Add(Me.UI_BtmBar_Panel)
        Me.Controls.Add(Me.SMWC_ComposeMsg_LinkLabel)
        Me.Controls.Add(Me.SMWC_Profile_LinkLabel)
        Me.Controls.Add(Me.Mailto_LinkLabel)
        Me.Controls.Add(Me.UI_StatPanel)
        Me.Controls.Add(Me.Text_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm07_BugsFound"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.UI_BtmBar_Panel.ResumeLayout(False)
        Me.UI_ButtonsPanel.ResumeLayout(False)
        Me.UI_ButtonsPanel2.ResumeLayout(False)
        Me.UI_StatPanel.ResumeLayout(False)
        CType(Me.UI_StatPanel_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Btn As System.Windows.Forms.Button
    Friend WithEvents DashSeparatorLabel As System.Windows.Forms.Label
    Friend WithEvents SMWC_Profile_LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents SMWC_ComposeMsg_LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Mailto_LinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents Text_1 As System.Windows.Forms.Label
    Friend WithEvents TwitterBtn As Button
    Friend WithEvents YouTubeBtn As Button
    Friend WithEvents GitHubBtn As Button
    Friend WithEvents UI_BtmBar_Panel As Panel
    Friend WithEvents UI_ButtonsPanel As FlowLayoutPanel
    Friend WithEvents UI_ButtonsPanel2 As FlowLayoutPanel
    Friend WithEvents UI_StatPanel As Panel
    Friend WithEvents UI_StatPanel_Title As Label
    Friend WithEvents UI_HeaderBorder As Panel
    Friend WithEvents UI_StatPanel_Description As Label
    Friend WithEvents UI_StatPanel_Icon As PictureBox
End Class
