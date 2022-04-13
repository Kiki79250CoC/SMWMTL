<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm08_SuggestFeature
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm08_SuggestFeature))
        Me.ToolName_Title = New System.Windows.Forms.Label()
        Me.Link_Title = New System.Windows.Forms.Label()
        Me.ToolName_TextBox = New System.Windows.Forms.TextBox()
        Me.Link_TextBox = New System.Windows.Forms.TextBox()
        Me.ToSuggestFileBtn = New System.Windows.Forms.Button()
        Me.AppVersion_Title = New System.Windows.Forms.Label()
        Me.AppVersion_TextBox = New System.Windows.Forms.TextBox()
        Me.SuggestedBy_Title = New System.Windows.Forms.Label()
        Me.SuggestedBy_TextBox = New System.Windows.Forms.TextBox()
        Me.SuggestionResult_TextBox = New System.Windows.Forms.TextBox()
        Me.SaveToTXTFileBtn = New System.Windows.Forms.Button()
        Me.CopyBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.OptionalMsg_TextBox = New System.Windows.Forms.TextBox()
        Me.Gradient1 = New System.Windows.Forms.PictureBox()
        Me.OptionalMsg_CharCount = New System.Windows.Forms.Label()
        Me.OptionalMsg_Title = New System.Windows.Forms.Label()
        Me.SaveToTXTFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.UI_StatPanel = New System.Windows.Forms.Panel()
        Me.UI_HeaderBorder = New System.Windows.Forms.Panel()
        Me.UI_StatPanel_Icon = New System.Windows.Forms.PictureBox()
        Me.UI_StatPanel_Description = New System.Windows.Forms.Label()
        Me.UI_StatPanel_Title = New System.Windows.Forms.Label()
        Me.UI_BtmBar_Panel = New System.Windows.Forms.Panel()
        Me.UI_ButtonsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.UI_ButtonsPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.UI_Separator1 = New System.Windows.Forms.PictureBox()
        Me.ToolName_TextBoxBorder = New System.Windows.Forms.Panel()
        Me.AppVersion_TextBoxBorder = New System.Windows.Forms.Panel()
        Me.SuggestedBy_TextBoxBorder = New System.Windows.Forms.Panel()
        Me.Link_TextBoxBorder = New System.Windows.Forms.Panel()
        Me.SuggestionResult_TextBoxBorder = New System.Windows.Forms.Panel()
        Me.NewVersion_Checkbox = New System.Windows.Forms.CheckBox()
        Me.OptionalMsg_TextBoxBorder = New System.Windows.Forms.Panel()
        Me.SuggestionResult_TextBoxTitle = New System.Windows.Forms.Label()
        CType(Me.Gradient1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_StatPanel.SuspendLayout()
        CType(Me.UI_StatPanel_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_BtmBar_Panel.SuspendLayout()
        Me.UI_ButtonsPanel.SuspendLayout()
        Me.UI_ButtonsPanel2.SuspendLayout()
        CType(Me.UI_Separator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolName_TextBoxBorder.SuspendLayout()
        Me.AppVersion_TextBoxBorder.SuspendLayout()
        Me.SuggestedBy_TextBoxBorder.SuspendLayout()
        Me.Link_TextBoxBorder.SuspendLayout()
        Me.SuggestionResult_TextBoxBorder.SuspendLayout()
        Me.OptionalMsg_TextBoxBorder.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolName_Title
        '
        resources.ApplyResources(Me.ToolName_Title, "ToolName_Title")
        Me.ToolName_Title.Name = "ToolName_Title"
        '
        'Link_Title
        '
        resources.ApplyResources(Me.Link_Title, "Link_Title")
        Me.Link_Title.Name = "Link_Title"
        '
        'ToolName_TextBox
        '
        resources.ApplyResources(Me.ToolName_TextBox, "ToolName_TextBox")
        Me.ToolName_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ToolName_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolName_TextBox.Name = "ToolName_TextBox"
        '
        'Link_TextBox
        '
        resources.ApplyResources(Me.Link_TextBox, "Link_TextBox")
        Me.Link_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Link_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Link_TextBox.Name = "Link_TextBox"
        '
        'ToSuggestFileBtn
        '
        resources.ApplyResources(Me.ToSuggestFileBtn, "ToSuggestFileBtn")
        Me.ToSuggestFileBtn.Name = "ToSuggestFileBtn"
        Me.ToSuggestFileBtn.UseVisualStyleBackColor = True
        '
        'AppVersion_Title
        '
        resources.ApplyResources(Me.AppVersion_Title, "AppVersion_Title")
        Me.AppVersion_Title.Name = "AppVersion_Title"
        '
        'AppVersion_TextBox
        '
        resources.ApplyResources(Me.AppVersion_TextBox, "AppVersion_TextBox")
        Me.AppVersion_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.AppVersion_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AppVersion_TextBox.Name = "AppVersion_TextBox"
        '
        'SuggestedBy_Title
        '
        resources.ApplyResources(Me.SuggestedBy_Title, "SuggestedBy_Title")
        Me.SuggestedBy_Title.Name = "SuggestedBy_Title"
        '
        'SuggestedBy_TextBox
        '
        resources.ApplyResources(Me.SuggestedBy_TextBox, "SuggestedBy_TextBox")
        Me.SuggestedBy_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.SuggestedBy_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SuggestedBy_TextBox.Name = "SuggestedBy_TextBox"
        '
        'SuggestionResult_TextBox
        '
        resources.ApplyResources(Me.SuggestionResult_TextBox, "SuggestionResult_TextBox")
        Me.SuggestionResult_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.SuggestionResult_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SuggestionResult_TextBox.Name = "SuggestionResult_TextBox"
        Me.SuggestionResult_TextBox.ReadOnly = True
        '
        'SaveToTXTFileBtn
        '
        resources.ApplyResources(Me.SaveToTXTFileBtn, "SaveToTXTFileBtn")
        Me.SaveToTXTFileBtn.Name = "SaveToTXTFileBtn"
        Me.SaveToTXTFileBtn.UseVisualStyleBackColor = True
        '
        'CopyBtn
        '
        resources.ApplyResources(Me.CopyBtn, "CopyBtn")
        Me.CopyBtn.Name = "CopyBtn"
        Me.CopyBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(Me.CloseBtn, "CloseBtn")
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'OptionalMsg_TextBox
        '
        Me.OptionalMsg_TextBox.AllowDrop = True
        resources.ApplyResources(Me.OptionalMsg_TextBox, "OptionalMsg_TextBox")
        Me.OptionalMsg_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.OptionalMsg_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OptionalMsg_TextBox.Name = "OptionalMsg_TextBox"
        '
        'Gradient1
        '
        resources.ApplyResources(Me.Gradient1, "Gradient1")
        Me.Gradient1.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.GradientLine_Black
        Me.Gradient1.Name = "Gradient1"
        Me.Gradient1.TabStop = False
        '
        'OptionalMsg_CharCount
        '
        resources.ApplyResources(Me.OptionalMsg_CharCount, "OptionalMsg_CharCount")
        Me.OptionalMsg_CharCount.Name = "OptionalMsg_CharCount"
        '
        'OptionalMsg_Title
        '
        resources.ApplyResources(Me.OptionalMsg_Title, "OptionalMsg_Title")
        Me.OptionalMsg_Title.Name = "OptionalMsg_Title"
        '
        'SaveToTXTFileDialog
        '
        Me.SaveToTXTFileDialog.CheckFileExists = True
        Me.SaveToTXTFileDialog.DefaultExt = "txt"
        Me.SaveToTXTFileDialog.FileName = "Suggestion.txt"
        resources.ApplyResources(Me.SaveToTXTFileDialog, "SaveToTXTFileDialog")
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
        Me.UI_StatPanel_Icon.BackColor = System.Drawing.Color.Transparent
        Me.UI_StatPanel_Icon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.SuggestFeature_Icon
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
        'UI_ButtonsPanel2
        '
        resources.ApplyResources(Me.UI_ButtonsPanel2, "UI_ButtonsPanel2")
        Me.UI_ButtonsPanel2.BackColor = System.Drawing.Color.Transparent
        Me.UI_ButtonsPanel2.Controls.Add(Me.ToSuggestFileBtn)
        Me.UI_ButtonsPanel2.Controls.Add(Me.UI_Separator1)
        Me.UI_ButtonsPanel2.Controls.Add(Me.CopyBtn)
        Me.UI_ButtonsPanel2.Controls.Add(Me.SaveToTXTFileBtn)
        Me.UI_ButtonsPanel2.Name = "UI_ButtonsPanel2"
        '
        'UI_Separator1
        '
        resources.ApplyResources(Me.UI_Separator1, "UI_Separator1")
        Me.UI_Separator1.BackColor = System.Drawing.Color.Transparent
        Me.UI_Separator1.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_ButtonSeparatorLight
        Me.UI_Separator1.Name = "UI_Separator1"
        Me.UI_Separator1.TabStop = False
        '
        'ToolName_TextBoxBorder
        '
        resources.ApplyResources(Me.ToolName_TextBoxBorder, "ToolName_TextBoxBorder")
        Me.ToolName_TextBoxBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ToolName_TextBoxBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolName_TextBoxBorder.Controls.Add(Me.ToolName_TextBox)
        Me.ToolName_TextBoxBorder.Name = "ToolName_TextBoxBorder"
        '
        'AppVersion_TextBoxBorder
        '
        resources.ApplyResources(Me.AppVersion_TextBoxBorder, "AppVersion_TextBoxBorder")
        Me.AppVersion_TextBoxBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.AppVersion_TextBoxBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AppVersion_TextBoxBorder.Controls.Add(Me.AppVersion_TextBox)
        Me.AppVersion_TextBoxBorder.Name = "AppVersion_TextBoxBorder"
        '
        'SuggestedBy_TextBoxBorder
        '
        resources.ApplyResources(Me.SuggestedBy_TextBoxBorder, "SuggestedBy_TextBoxBorder")
        Me.SuggestedBy_TextBoxBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.SuggestedBy_TextBoxBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SuggestedBy_TextBoxBorder.Controls.Add(Me.SuggestedBy_TextBox)
        Me.SuggestedBy_TextBoxBorder.Name = "SuggestedBy_TextBoxBorder"
        '
        'Link_TextBoxBorder
        '
        resources.ApplyResources(Me.Link_TextBoxBorder, "Link_TextBoxBorder")
        Me.Link_TextBoxBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Link_TextBoxBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Link_TextBoxBorder.Controls.Add(Me.Link_TextBox)
        Me.Link_TextBoxBorder.Name = "Link_TextBoxBorder"
        '
        'SuggestionResult_TextBoxBorder
        '
        resources.ApplyResources(Me.SuggestionResult_TextBoxBorder, "SuggestionResult_TextBoxBorder")
        Me.SuggestionResult_TextBoxBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.SuggestionResult_TextBoxBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SuggestionResult_TextBoxBorder.Controls.Add(Me.SuggestionResult_TextBox)
        Me.SuggestionResult_TextBoxBorder.Name = "SuggestionResult_TextBoxBorder"
        '
        'NewVersion_Checkbox
        '
        resources.ApplyResources(Me.NewVersion_Checkbox, "NewVersion_Checkbox")
        Me.NewVersion_Checkbox.Name = "NewVersion_Checkbox"
        Me.NewVersion_Checkbox.UseVisualStyleBackColor = True
        '
        'OptionalMsg_TextBoxBorder
        '
        resources.ApplyResources(Me.OptionalMsg_TextBoxBorder, "OptionalMsg_TextBoxBorder")
        Me.OptionalMsg_TextBoxBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.OptionalMsg_TextBoxBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OptionalMsg_TextBoxBorder.Controls.Add(Me.OptionalMsg_TextBox)
        Me.OptionalMsg_TextBoxBorder.Name = "OptionalMsg_TextBoxBorder"
        '
        'SuggestionResult_TextBoxTitle
        '
        resources.ApplyResources(Me.SuggestionResult_TextBoxTitle, "SuggestionResult_TextBoxTitle")
        Me.SuggestionResult_TextBoxTitle.Name = "SuggestionResult_TextBoxTitle"
        '
        'Frm08_SuggestFeature
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.CancelButton = Me.CloseBtn
        Me.Controls.Add(Me.OptionalMsg_TextBoxBorder)
        Me.Controls.Add(Me.NewVersion_Checkbox)
        Me.Controls.Add(Me.SuggestionResult_TextBoxBorder)
        Me.Controls.Add(Me.Link_TextBoxBorder)
        Me.Controls.Add(Me.SuggestedBy_TextBoxBorder)
        Me.Controls.Add(Me.AppVersion_TextBoxBorder)
        Me.Controls.Add(Me.ToolName_TextBoxBorder)
        Me.Controls.Add(Me.Gradient1)
        Me.Controls.Add(Me.UI_BtmBar_Panel)
        Me.Controls.Add(Me.OptionalMsg_CharCount)
        Me.Controls.Add(Me.UI_StatPanel)
        Me.Controls.Add(Me.ToolName_Title)
        Me.Controls.Add(Me.SuggestionResult_TextBoxTitle)
        Me.Controls.Add(Me.OptionalMsg_Title)
        Me.Controls.Add(Me.AppVersion_Title)
        Me.Controls.Add(Me.SuggestedBy_Title)
        Me.Controls.Add(Me.Link_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm08_SuggestFeature"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.Gradient1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_StatPanel.ResumeLayout(False)
        CType(Me.UI_StatPanel_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_BtmBar_Panel.ResumeLayout(False)
        Me.UI_ButtonsPanel.ResumeLayout(False)
        Me.UI_ButtonsPanel2.ResumeLayout(False)
        CType(Me.UI_Separator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolName_TextBoxBorder.ResumeLayout(False)
        Me.ToolName_TextBoxBorder.PerformLayout()
        Me.AppVersion_TextBoxBorder.ResumeLayout(False)
        Me.AppVersion_TextBoxBorder.PerformLayout()
        Me.SuggestedBy_TextBoxBorder.ResumeLayout(False)
        Me.SuggestedBy_TextBoxBorder.PerformLayout()
        Me.Link_TextBoxBorder.ResumeLayout(False)
        Me.Link_TextBoxBorder.PerformLayout()
        Me.SuggestionResult_TextBoxBorder.ResumeLayout(False)
        Me.SuggestionResult_TextBoxBorder.PerformLayout()
        Me.OptionalMsg_TextBoxBorder.ResumeLayout(False)
        Me.OptionalMsg_TextBoxBorder.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolName_Title As System.Windows.Forms.Label
    Friend WithEvents Link_Title As System.Windows.Forms.Label
    Friend WithEvents ToolName_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Link_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToSuggestFileBtn As System.Windows.Forms.Button
    Friend WithEvents AppVersion_Title As System.Windows.Forms.Label
    Friend WithEvents AppVersion_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SuggestedBy_Title As System.Windows.Forms.Label
    Friend WithEvents SuggestedBy_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SuggestionResult_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveToTXTFileBtn As System.Windows.Forms.Button
    Friend WithEvents CopyBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents OptionalMsg_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents OptionalMsg_Title As System.Windows.Forms.Label
    Friend WithEvents OptionalMsg_CharCount As System.Windows.Forms.Label
    Friend WithEvents SaveToTXTFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Gradient1 As PictureBox
    Friend WithEvents UI_StatPanel As Panel
    Friend WithEvents UI_HeaderBorder As Panel
    Friend WithEvents UI_StatPanel_Icon As PictureBox
    Friend WithEvents UI_StatPanel_Description As Label
    Friend WithEvents UI_StatPanel_Title As Label
    Friend WithEvents UI_BtmBar_Panel As Panel
    Friend WithEvents UI_ButtonsPanel As FlowLayoutPanel
    Friend WithEvents UI_ButtonsPanel2 As FlowLayoutPanel
    Friend WithEvents ToolName_TextBoxBorder As Panel
    Friend WithEvents AppVersion_TextBoxBorder As Panel
    Friend WithEvents SuggestedBy_TextBoxBorder As Panel
    Friend WithEvents Link_TextBoxBorder As Panel
    Friend WithEvents SuggestionResult_TextBoxBorder As Panel
    Friend WithEvents NewVersion_Checkbox As CheckBox
    Friend WithEvents OptionalMsg_TextBoxBorder As Panel
    Friend WithEvents SuggestionResult_TextBoxTitle As Label
    Friend WithEvents UI_Separator1 As PictureBox
End Class
