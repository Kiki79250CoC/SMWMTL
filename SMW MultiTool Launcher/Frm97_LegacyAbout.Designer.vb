<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm97_LegacyAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm97_LegacyAbout))
        Me.OK_Btn = New System.Windows.Forms.Button()
        Me.LegacyAbout_TabControl = New System.Windows.Forms.TabControl()
        Me.About_TabPage = New System.Windows.Forms.TabPage()
        Me.About_GroupBox = New System.Windows.Forms.GroupBox()
        Me.AboutText = New System.Windows.Forms.Label()
        Me.App_Logo = New System.Windows.Forms.PictureBox()
        Me.PDP_Pic = New System.Windows.Forms.PictureBox()
        Me.Deco2 = New System.Windows.Forms.PictureBox()
        Me.Deco1 = New System.Windows.Forms.PictureBox()
        Me.Z_BottomTabControl = New System.Windows.Forms.TabControl()
        Me.None01 = New System.Windows.Forms.TabPage()
        Me.Deco4 = New System.Windows.Forms.PictureBox()
        Me.Deco3 = New System.Windows.Forms.PictureBox()
        Me.LegacyAbout_TabControl.SuspendLayout()
        Me.About_TabPage.SuspendLayout()
        Me.About_GroupBox.SuspendLayout()
        CType(Me.App_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDP_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deco2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deco1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Z_BottomTabControl.SuspendLayout()
        Me.None01.SuspendLayout()
        CType(Me.Deco4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deco3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Btn
        '
        resources.ApplyResources(Me.OK_Btn, "OK_Btn")
        Me.OK_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OK_Btn.Name = "OK_Btn"
        Me.OK_Btn.UseVisualStyleBackColor = True
        '
        'LegacyAbout_TabControl
        '
        resources.ApplyResources(Me.LegacyAbout_TabControl, "LegacyAbout_TabControl")
        Me.LegacyAbout_TabControl.Controls.Add(Me.About_TabPage)
        Me.LegacyAbout_TabControl.Name = "LegacyAbout_TabControl"
        Me.LegacyAbout_TabControl.SelectedIndex = 0
        '
        'About_TabPage
        '
        Me.About_TabPage.Controls.Add(Me.About_GroupBox)
        Me.About_TabPage.Controls.Add(Me.App_Logo)
        Me.About_TabPage.Controls.Add(Me.PDP_Pic)
        resources.ApplyResources(Me.About_TabPage, "About_TabPage")
        Me.About_TabPage.Name = "About_TabPage"
        Me.About_TabPage.UseVisualStyleBackColor = True
        '
        'About_GroupBox
        '
        resources.ApplyResources(Me.About_GroupBox, "About_GroupBox")
        Me.About_GroupBox.Controls.Add(Me.AboutText)
        Me.About_GroupBox.Name = "About_GroupBox"
        Me.About_GroupBox.TabStop = False
        '
        'AboutText
        '
        resources.ApplyResources(Me.AboutText, "AboutText")
        Me.AboutText.AutoEllipsis = True
        Me.AboutText.Name = "AboutText"
        '
        'App_Logo
        '
        Me.App_Logo.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.Logo210
        resources.ApplyResources(Me.App_Logo, "App_Logo")
        Me.App_Logo.Name = "App_Logo"
        Me.App_Logo.TabStop = False
        '
        'PDP_Pic
        '
        resources.ApplyResources(Me.PDP_Pic, "PDP_Pic")
        Me.PDP_Pic.Image = Global.SMW_MultiTool_Launcher.My.Resources.Resources.Kiki79250CoC
        Me.PDP_Pic.Name = "PDP_Pic"
        Me.PDP_Pic.TabStop = False
        '
        'Deco2
        '
        resources.ApplyResources(Me.Deco2, "Deco2")
        Me.Deco2.BackColor = System.Drawing.Color.Transparent
        Me.Deco2.Name = "Deco2"
        Me.Deco2.TabStop = False
        '
        'Deco1
        '
        resources.ApplyResources(Me.Deco1, "Deco1")
        Me.Deco1.BackColor = System.Drawing.Color.Transparent
        Me.Deco1.Name = "Deco1"
        Me.Deco1.TabStop = False
        '
        'Z_BottomTabControl
        '
        resources.ApplyResources(Me.Z_BottomTabControl, "Z_BottomTabControl")
        Me.Z_BottomTabControl.Controls.Add(Me.None01)
        Me.Z_BottomTabControl.Name = "Z_BottomTabControl"
        Me.Z_BottomTabControl.SelectedIndex = 0
        '
        'None01
        '
        Me.None01.Controls.Add(Me.OK_Btn)
        resources.ApplyResources(Me.None01, "None01")
        Me.None01.Name = "None01"
        Me.None01.UseVisualStyleBackColor = True
        '
        'Deco4
        '
        resources.ApplyResources(Me.Deco4, "Deco4")
        Me.Deco4.BackColor = System.Drawing.Color.Transparent
        Me.Deco4.Name = "Deco4"
        Me.Deco4.TabStop = False
        '
        'Deco3
        '
        resources.ApplyResources(Me.Deco3, "Deco3")
        Me.Deco3.BackColor = System.Drawing.Color.Transparent
        Me.Deco3.Name = "Deco3"
        Me.Deco3.TabStop = False
        '
        'Frm97_LegacyAbout
        '
        Me.AcceptButton = Me.OK_Btn
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.CancelButton = Me.OK_Btn
        Me.Controls.Add(Me.Deco3)
        Me.Controls.Add(Me.Deco4)
        Me.Controls.Add(Me.Deco2)
        Me.Controls.Add(Me.Deco1)
        Me.Controls.Add(Me.LegacyAbout_TabControl)
        Me.Controls.Add(Me.Z_BottomTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm97_LegacyAbout"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.LegacyAbout_TabControl.ResumeLayout(False)
        Me.About_TabPage.ResumeLayout(False)
        Me.About_GroupBox.ResumeLayout(False)
        CType(Me.App_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDP_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deco2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deco1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Z_BottomTabControl.ResumeLayout(False)
        Me.None01.ResumeLayout(False)
        CType(Me.Deco4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deco3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Btn As System.Windows.Forms.Button
    Friend WithEvents About_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents App_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents AboutText As System.Windows.Forms.Label
    Friend WithEvents Deco2 As System.Windows.Forms.PictureBox
    Friend WithEvents Deco1 As System.Windows.Forms.PictureBox
    Friend WithEvents PDP_Pic As System.Windows.Forms.PictureBox
    Public WithEvents LegacyAbout_TabControl As System.Windows.Forms.TabControl
    Public WithEvents About_TabPage As System.Windows.Forms.TabPage
    Friend WithEvents Z_BottomTabControl As TabControl
    Friend WithEvents None01 As TabPage
    Friend WithEvents Deco4 As PictureBox
    Friend WithEvents Deco3 As PictureBox
End Class
