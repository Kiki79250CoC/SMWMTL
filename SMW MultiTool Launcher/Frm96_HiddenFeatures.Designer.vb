<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm96_HiddenFeatures
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
        Me.Z_IndevSettings_TabControl = New System.Windows.Forms.TabControl()
        Me.Z_IndevSettings_Tab1 = New System.Windows.Forms.TabPage()
        Me.PersonalizedTheme_GroupBox = New System.Windows.Forms.GroupBox()
        Me.PersoTheme_Text = New System.Windows.Forms.Label()
        Me.PersoTheme_BrowseBtn = New System.Windows.Forms.Button()
        Me.PersoTheme_PathTextBox = New System.Windows.Forms.TextBox()
        Me.CompactMode_GroupBox = New System.Windows.Forms.GroupBox()
        Me.CompactMode_Prewiew = New System.Windows.Forms.Button()
        Me.CompactMode_EnableCheckBox = New System.Windows.Forms.CheckBox()
        Me.CompactMode_PreviewText = New System.Windows.Forms.Label()
        Me.CompactMode_Program6Text = New System.Windows.Forms.Label()
        Me.CompactMode_Program5Text = New System.Windows.Forms.Label()
        Me.CompactMode_Program4Text = New System.Windows.Forms.Label()
        Me.CompactMode_Program3Text = New System.Windows.Forms.Label()
        Me.CompactMode_Program2Text = New System.Windows.Forms.Label()
        Me.CompactMode_Program1Text = New System.Windows.Forms.Label()
        Me.CompactMode_Program6_ComboBox = New System.Windows.Forms.ComboBox()
        Me.CompactMode_Program5_ComboBox = New System.Windows.Forms.ComboBox()
        Me.CompactMode_Program4_ComboBox = New System.Windows.Forms.ComboBox()
        Me.CompactMode_Program3_ComboBox = New System.Windows.Forms.ComboBox()
        Me.CompactMode_Program2_ComboBox = New System.Windows.Forms.ComboBox()
        Me.CompactMode_Program1_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Z_IndevSettings_TabControl.SuspendLayout()
        Me.Z_IndevSettings_Tab1.SuspendLayout()
        Me.PersonalizedTheme_GroupBox.SuspendLayout()
        Me.CompactMode_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Z_IndevSettings_TabControl
        '
        Me.Z_IndevSettings_TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Z_IndevSettings_TabControl.Controls.Add(Me.Z_IndevSettings_Tab1)
        Me.Z_IndevSettings_TabControl.Location = New System.Drawing.Point(12, 12)
        Me.Z_IndevSettings_TabControl.Name = "Z_IndevSettings_TabControl"
        Me.Z_IndevSettings_TabControl.SelectedIndex = 0
        Me.Z_IndevSettings_TabControl.Size = New System.Drawing.Size(256, 388)
        Me.Z_IndevSettings_TabControl.TabIndex = 35
        '
        'Z_IndevSettings_Tab1
        '
        Me.Z_IndevSettings_Tab1.Controls.Add(Me.PersonalizedTheme_GroupBox)
        Me.Z_IndevSettings_Tab1.Controls.Add(Me.CompactMode_GroupBox)
        Me.Z_IndevSettings_Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Z_IndevSettings_Tab1.Name = "Z_IndevSettings_Tab1"
        Me.Z_IndevSettings_Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Z_IndevSettings_Tab1.Size = New System.Drawing.Size(248, 362)
        Me.Z_IndevSettings_Tab1.TabIndex = 0
        Me.Z_IndevSettings_Tab1.Text = "PAGE_1"
        Me.Z_IndevSettings_Tab1.UseVisualStyleBackColor = True
        '
        'PersonalizedTheme_GroupBox
        '
        Me.PersonalizedTheme_GroupBox.Controls.Add(Me.PersoTheme_Text)
        Me.PersonalizedTheme_GroupBox.Controls.Add(Me.PersoTheme_BrowseBtn)
        Me.PersonalizedTheme_GroupBox.Controls.Add(Me.PersoTheme_PathTextBox)
        Me.PersonalizedTheme_GroupBox.Location = New System.Drawing.Point(3, 303)
        Me.PersonalizedTheme_GroupBox.Name = "PersonalizedTheme_GroupBox"
        Me.PersonalizedTheme_GroupBox.Size = New System.Drawing.Size(239, 49)
        Me.PersonalizedTheme_GroupBox.TabIndex = 22
        Me.PersonalizedTheme_GroupBox.TabStop = False
        Me.PersonalizedTheme_GroupBox.Text = "240-PERSO_THEME"
        '
        'PersoTheme_Text
        '
        Me.PersoTheme_Text.AutoSize = True
        Me.PersoTheme_Text.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PersoTheme_Text.Location = New System.Drawing.Point(6, 25)
        Me.PersoTheme_Text.Name = "PersoTheme_Text"
        Me.PersoTheme_Text.Size = New System.Drawing.Size(94, 13)
        Me.PersoTheme_Text.TabIndex = 20
        Me.PersoTheme_Text.Text = "PERS_PIC_PATH"
        '
        'PersoTheme_BrowseBtn
        '
        Me.PersoTheme_BrowseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersoTheme_BrowseBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PersoTheme_BrowseBtn.Location = New System.Drawing.Point(189, 20)
        Me.PersoTheme_BrowseBtn.Name = "PersoTheme_BrowseBtn"
        Me.PersoTheme_BrowseBtn.Size = New System.Drawing.Size(44, 23)
        Me.PersoTheme_BrowseBtn.TabIndex = 21
        Me.PersoTheme_BrowseBtn.Text = "FIND"
        Me.PersoTheme_BrowseBtn.UseVisualStyleBackColor = True
        '
        'PersoTheme_PathTextBox
        '
        Me.PersoTheme_PathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersoTheme_PathTextBox.Location = New System.Drawing.Point(106, 22)
        Me.PersoTheme_PathTextBox.Name = "PersoTheme_PathTextBox"
        Me.PersoTheme_PathTextBox.Size = New System.Drawing.Size(77, 20)
        Me.PersoTheme_PathTextBox.TabIndex = 19
        '
        'CompactMode_GroupBox
        '
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_Prewiew)
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_EnableCheckBox)
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_PreviewText)
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_Program6Text)
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_Program5Text)
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_Program4Text)
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_Program3Text)
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_Program2Text)
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_Program1Text)
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_Program6_ComboBox)
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_Program5_ComboBox)
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_Program4_ComboBox)
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_Program3_ComboBox)
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_Program2_ComboBox)
        Me.CompactMode_GroupBox.Controls.Add(Me.CompactMode_Program1_ComboBox)
        Me.CompactMode_GroupBox.Location = New System.Drawing.Point(3, 6)
        Me.CompactMode_GroupBox.Name = "CompactMode_GroupBox"
        Me.CompactMode_GroupBox.Size = New System.Drawing.Size(239, 291)
        Me.CompactMode_GroupBox.TabIndex = 31
        Me.CompactMode_GroupBox.TabStop = False
        Me.CompactMode_GroupBox.Text = "230-COMPACT_MODE"
        '
        'CompactMode_Prewiew
        '
        Me.CompactMode_Prewiew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CompactMode_Prewiew.Location = New System.Drawing.Point(152, 15)
        Me.CompactMode_Prewiew.Name = "CompactMode_Prewiew"
        Me.CompactMode_Prewiew.Size = New System.Drawing.Size(75, 23)
        Me.CompactMode_Prewiew.TabIndex = 14
        Me.CompactMode_Prewiew.Text = "PREVIEW"
        Me.CompactMode_Prewiew.UseVisualStyleBackColor = True
        '
        'CompactMode_EnableCheckBox
        '
        Me.CompactMode_EnableCheckBox.AutoSize = True
        Me.CompactMode_EnableCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CompactMode_EnableCheckBox.Location = New System.Drawing.Point(6, 19)
        Me.CompactMode_EnableCheckBox.Name = "CompactMode_EnableCheckBox"
        Me.CompactMode_EnableCheckBox.Size = New System.Drawing.Size(68, 17)
        Me.CompactMode_EnableCheckBox.TabIndex = 13
        Me.CompactMode_EnableCheckBox.Text = "ENABLE"
        Me.CompactMode_EnableCheckBox.UseVisualStyleBackColor = True
        '
        'CompactMode_PreviewText
        '
        Me.CompactMode_PreviewText.AutoSize = True
        Me.CompactMode_PreviewText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CompactMode_PreviewText.Location = New System.Drawing.Point(73, 20)
        Me.CompactMode_PreviewText.Name = "CompactMode_PreviewText"
        Me.CompactMode_PreviewText.Size = New System.Drawing.Size(57, 13)
        Me.CompactMode_PreviewText.TabIndex = 12
        Me.CompactMode_PreviewText.Text = "PREVIEW"
        '
        'CompactMode_Program6Text
        '
        Me.CompactMode_Program6Text.AutoSize = True
        Me.CompactMode_Program6Text.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CompactMode_Program6Text.Location = New System.Drawing.Point(3, 245)
        Me.CompactMode_Program6Text.Name = "CompactMode_Program6Text"
        Me.CompactMode_Program6Text.Size = New System.Drawing.Size(74, 13)
        Me.CompactMode_Program6Text.TabIndex = 11
        Me.CompactMode_Program6Text.Text = "PROGRAM_6"
        '
        'CompactMode_Program5Text
        '
        Me.CompactMode_Program5Text.AutoSize = True
        Me.CompactMode_Program5Text.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CompactMode_Program5Text.Location = New System.Drawing.Point(3, 205)
        Me.CompactMode_Program5Text.Name = "CompactMode_Program5Text"
        Me.CompactMode_Program5Text.Size = New System.Drawing.Size(74, 13)
        Me.CompactMode_Program5Text.TabIndex = 10
        Me.CompactMode_Program5Text.Text = "PROGRAM_5"
        '
        'CompactMode_Program4Text
        '
        Me.CompactMode_Program4Text.AutoSize = True
        Me.CompactMode_Program4Text.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CompactMode_Program4Text.Location = New System.Drawing.Point(3, 165)
        Me.CompactMode_Program4Text.Name = "CompactMode_Program4Text"
        Me.CompactMode_Program4Text.Size = New System.Drawing.Size(74, 13)
        Me.CompactMode_Program4Text.TabIndex = 9
        Me.CompactMode_Program4Text.Text = "PROGRAM_4"
        '
        'CompactMode_Program3Text
        '
        Me.CompactMode_Program3Text.AutoSize = True
        Me.CompactMode_Program3Text.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CompactMode_Program3Text.Location = New System.Drawing.Point(3, 125)
        Me.CompactMode_Program3Text.Name = "CompactMode_Program3Text"
        Me.CompactMode_Program3Text.Size = New System.Drawing.Size(74, 13)
        Me.CompactMode_Program3Text.TabIndex = 8
        Me.CompactMode_Program3Text.Text = "PROGRAM_3"
        '
        'CompactMode_Program2Text
        '
        Me.CompactMode_Program2Text.AutoSize = True
        Me.CompactMode_Program2Text.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CompactMode_Program2Text.Location = New System.Drawing.Point(3, 85)
        Me.CompactMode_Program2Text.Name = "CompactMode_Program2Text"
        Me.CompactMode_Program2Text.Size = New System.Drawing.Size(74, 13)
        Me.CompactMode_Program2Text.TabIndex = 7
        Me.CompactMode_Program2Text.Text = "PROGRAM_2"
        '
        'CompactMode_Program1Text
        '
        Me.CompactMode_Program1Text.AutoSize = True
        Me.CompactMode_Program1Text.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CompactMode_Program1Text.Location = New System.Drawing.Point(3, 45)
        Me.CompactMode_Program1Text.Name = "CompactMode_Program1Text"
        Me.CompactMode_Program1Text.Size = New System.Drawing.Size(74, 13)
        Me.CompactMode_Program1Text.TabIndex = 6
        Me.CompactMode_Program1Text.Text = "PROGRAM_1"
        '
        'CompactMode_Program6_ComboBox
        '
        Me.CompactMode_Program6_ComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompactMode_Program6_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompactMode_Program6_ComboBox.FormattingEnabled = True
        Me.CompactMode_Program6_ComboBox.Location = New System.Drawing.Point(6, 261)
        Me.CompactMode_Program6_ComboBox.Name = "CompactMode_Program6_ComboBox"
        Me.CompactMode_Program6_ComboBox.Size = New System.Drawing.Size(227, 21)
        Me.CompactMode_Program6_ComboBox.TabIndex = 5
        '
        'CompactMode_Program5_ComboBox
        '
        Me.CompactMode_Program5_ComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompactMode_Program5_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompactMode_Program5_ComboBox.FormattingEnabled = True
        Me.CompactMode_Program5_ComboBox.Location = New System.Drawing.Point(6, 221)
        Me.CompactMode_Program5_ComboBox.Name = "CompactMode_Program5_ComboBox"
        Me.CompactMode_Program5_ComboBox.Size = New System.Drawing.Size(227, 21)
        Me.CompactMode_Program5_ComboBox.TabIndex = 4
        '
        'CompactMode_Program4_ComboBox
        '
        Me.CompactMode_Program4_ComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompactMode_Program4_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompactMode_Program4_ComboBox.FormattingEnabled = True
        Me.CompactMode_Program4_ComboBox.Location = New System.Drawing.Point(6, 181)
        Me.CompactMode_Program4_ComboBox.Name = "CompactMode_Program4_ComboBox"
        Me.CompactMode_Program4_ComboBox.Size = New System.Drawing.Size(227, 21)
        Me.CompactMode_Program4_ComboBox.TabIndex = 3
        '
        'CompactMode_Program3_ComboBox
        '
        Me.CompactMode_Program3_ComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompactMode_Program3_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompactMode_Program3_ComboBox.FormattingEnabled = True
        Me.CompactMode_Program3_ComboBox.Location = New System.Drawing.Point(6, 141)
        Me.CompactMode_Program3_ComboBox.Name = "CompactMode_Program3_ComboBox"
        Me.CompactMode_Program3_ComboBox.Size = New System.Drawing.Size(227, 21)
        Me.CompactMode_Program3_ComboBox.TabIndex = 2
        '
        'CompactMode_Program2_ComboBox
        '
        Me.CompactMode_Program2_ComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompactMode_Program2_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompactMode_Program2_ComboBox.FormattingEnabled = True
        Me.CompactMode_Program2_ComboBox.Location = New System.Drawing.Point(6, 101)
        Me.CompactMode_Program2_ComboBox.Name = "CompactMode_Program2_ComboBox"
        Me.CompactMode_Program2_ComboBox.Size = New System.Drawing.Size(227, 21)
        Me.CompactMode_Program2_ComboBox.TabIndex = 1
        '
        'CompactMode_Program1_ComboBox
        '
        Me.CompactMode_Program1_ComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompactMode_Program1_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompactMode_Program1_ComboBox.FormattingEnabled = True
        Me.CompactMode_Program1_ComboBox.Location = New System.Drawing.Point(6, 61)
        Me.CompactMode_Program1_ComboBox.Name = "CompactMode_Program1_ComboBox"
        Me.CompactMode_Program1_ComboBox.Size = New System.Drawing.Size(227, 21)
        Me.CompactMode_Program1_ComboBox.TabIndex = 0
        '
        'Frm96_HiddenFeatures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(280, 412)
        Me.Controls.Add(Me.Z_IndevSettings_TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm96_HiddenFeatures"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frm96_HiddenFeatures"
        Me.Z_IndevSettings_TabControl.ResumeLayout(False)
        Me.Z_IndevSettings_Tab1.ResumeLayout(False)
        Me.PersonalizedTheme_GroupBox.ResumeLayout(False)
        Me.PersonalizedTheme_GroupBox.PerformLayout()
        Me.CompactMode_GroupBox.ResumeLayout(False)
        Me.CompactMode_GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Z_IndevSettings_TabControl As TabControl
    Friend WithEvents Z_IndevSettings_Tab1 As TabPage
    Friend WithEvents PersonalizedTheme_GroupBox As GroupBox
    Friend WithEvents PersoTheme_Text As Label
    Friend WithEvents PersoTheme_BrowseBtn As Button
    Friend WithEvents PersoTheme_PathTextBox As TextBox
    Friend WithEvents CompactMode_GroupBox As GroupBox
    Friend WithEvents CompactMode_Prewiew As Button
    Friend WithEvents CompactMode_EnableCheckBox As CheckBox
    Friend WithEvents CompactMode_PreviewText As Label
    Friend WithEvents CompactMode_Program6Text As Label
    Friend WithEvents CompactMode_Program5Text As Label
    Friend WithEvents CompactMode_Program4Text As Label
    Friend WithEvents CompactMode_Program3Text As Label
    Friend WithEvents CompactMode_Program2Text As Label
    Friend WithEvents CompactMode_Program1Text As Label
    Friend WithEvents CompactMode_Program6_ComboBox As ComboBox
    Friend WithEvents CompactMode_Program5_ComboBox As ComboBox
    Friend WithEvents CompactMode_Program4_ComboBox As ComboBox
    Friend WithEvents CompactMode_Program3_ComboBox As ComboBox
    Friend WithEvents CompactMode_Program2_ComboBox As ComboBox
    Friend WithEvents CompactMode_Program1_ComboBox As ComboBox
End Class
