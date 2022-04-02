<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDlg01_ResetConfirmation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDlg01_ResetConfirmation))
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Text_01 = New System.Windows.Forms.Label()
        Me.Text_02 = New System.Windows.Forms.Label()
        Me.ExportSettings_Button = New System.Windows.Forms.Button()
        Me.ExportSettings_SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.UI_StatPanel = New System.Windows.Forms.Panel()
        Me.UI_HeaderBorder = New System.Windows.Forms.Panel()
        Me.UI_StatPanel_Icon = New System.Windows.Forms.PictureBox()
        Me.UI_StatPanel_Description = New System.Windows.Forms.Label()
        Me.UI_StatPanel_Title = New System.Windows.Forms.Label()
        Me.UI_BtmBar_Panel = New System.Windows.Forms.Panel()
        Me.UI_ButtonsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.UI_ButtonsPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.UI_StatPanel.SuspendLayout()
        CType(Me.UI_StatPanel_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UI_BtmBar_Panel.SuspendLayout()
        Me.UI_ButtonsPanel.SuspendLayout()
        Me.UI_ButtonsPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        resources.ApplyResources(Me.OK_Button, "OK_Button")
        Me.OK_Button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OK_Button.Name = "OK_Button"
        '
        'Cancel_Button
        '
        resources.ApplyResources(Me.Cancel_Button, "Cancel_Button")
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cancel_Button.Name = "Cancel_Button"
        '
        'Text_01
        '
        resources.ApplyResources(Me.Text_01, "Text_01")
        Me.Text_01.BackColor = System.Drawing.Color.Transparent
        Me.Text_01.Name = "Text_01"
        '
        'Text_02
        '
        resources.ApplyResources(Me.Text_02, "Text_02")
        Me.Text_02.BackColor = System.Drawing.Color.Transparent
        Me.Text_02.ForeColor = System.Drawing.Color.DarkGreen
        Me.Text_02.Name = "Text_02"
        '
        'ExportSettings_Button
        '
        resources.ApplyResources(Me.ExportSettings_Button, "ExportSettings_Button")
        Me.ExportSettings_Button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ExportSettings_Button.Name = "ExportSettings_Button"
        '
        'ExportSettings_SaveFileDialog
        '
        Me.ExportSettings_SaveFileDialog.CheckFileExists = True
        Me.ExportSettings_SaveFileDialog.DefaultExt = "config"
        Me.ExportSettings_SaveFileDialog.FileName = "SMWMTL configuration.config"
        resources.ApplyResources(Me.ExportSettings_SaveFileDialog, "ExportSettings_SaveFileDialog")
        Me.ExportSettings_SaveFileDialog.ValidateNames = False
        '
        'UI_StatPanel
        '
        resources.ApplyResources(Me.UI_StatPanel, "UI_StatPanel")
        Me.UI_StatPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.UI_StatPanel.BackgroundImage = Global.SMW_MultiTool_Launcher.My.Resources.Resources.TitleYellow
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
        Me.UI_StatPanel_Icon.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.UI_Badge_Warning
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
        Me.UI_ButtonsPanel.Controls.Add(Me.Cancel_Button)
        Me.UI_ButtonsPanel.Controls.Add(Me.OK_Button)
        Me.UI_ButtonsPanel.Name = "UI_ButtonsPanel"
        '
        'UI_ButtonsPanel2
        '
        resources.ApplyResources(Me.UI_ButtonsPanel2, "UI_ButtonsPanel2")
        Me.UI_ButtonsPanel2.BackColor = System.Drawing.Color.Transparent
        Me.UI_ButtonsPanel2.Controls.Add(Me.ExportSettings_Button)
        Me.UI_ButtonsPanel2.Name = "UI_ButtonsPanel2"
        '
        'FrmDlg01_ResetConfirmation
        '
        Me.AcceptButton = Me.OK_Button
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.CancelButton = Me.Cancel_Button
        Me.Controls.Add(Me.UI_BtmBar_Panel)
        Me.Controls.Add(Me.UI_StatPanel)
        Me.Controls.Add(Me.Text_02)
        Me.Controls.Add(Me.Text_01)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDlg01_ResetConfirmation"
        Me.ShowInTaskbar = False
        Me.UI_StatPanel.ResumeLayout(False)
        CType(Me.UI_StatPanel_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UI_BtmBar_Panel.ResumeLayout(False)
        Me.UI_ButtonsPanel.ResumeLayout(False)
        Me.UI_ButtonsPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Text_01 As System.Windows.Forms.Label
    Friend WithEvents Text_02 As System.Windows.Forms.Label
    Friend WithEvents ExportSettings_Button As Button
    Friend WithEvents ExportSettings_SaveFileDialog As SaveFileDialog
    Friend WithEvents UI_StatPanel As Panel
    Friend WithEvents UI_HeaderBorder As Panel
    Friend WithEvents UI_StatPanel_Icon As PictureBox
    Friend WithEvents UI_StatPanel_Description As Label
    Friend WithEvents UI_StatPanel_Title As Label
    Friend WithEvents UI_BtmBar_Panel As Panel
    Friend WithEvents UI_ButtonsPanel As FlowLayoutPanel
    Friend WithEvents UI_ButtonsPanel2 As FlowLayoutPanel
End Class
