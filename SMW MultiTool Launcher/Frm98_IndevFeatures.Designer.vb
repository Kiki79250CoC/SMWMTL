<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm98_IndevFeatures
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm98_IndevFeatures))
        Me.ExperimentalSettingsGroup = New System.Windows.Forms.GroupBox()
        Me.ExSet_DarkModeHomeUpdateBar = New System.Windows.Forms.CheckBox()
        Me.ValidateBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.ExperimentalSettingsGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExperimentalSettingsGroup
        '
        resources.ApplyResources(Me.ExperimentalSettingsGroup, "ExperimentalSettingsGroup")
        Me.ExperimentalSettingsGroup.Controls.Add(Me.ExSet_DarkModeHomeUpdateBar)
        Me.ExperimentalSettingsGroup.Name = "ExperimentalSettingsGroup"
        Me.ExperimentalSettingsGroup.TabStop = False
        '
        'ExSet_DarkModeHomeUpdateBar
        '
        resources.ApplyResources(Me.ExSet_DarkModeHomeUpdateBar, "ExSet_DarkModeHomeUpdateBar")
        Me.ExSet_DarkModeHomeUpdateBar.Name = "ExSet_DarkModeHomeUpdateBar"
        Me.ExSet_DarkModeHomeUpdateBar.UseVisualStyleBackColor = True
        '
        'ValidateBtn
        '
        resources.ApplyResources(Me.ValidateBtn, "ValidateBtn")
        Me.ValidateBtn.Name = "ValidateBtn"
        Me.ValidateBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        resources.ApplyResources(Me.CancelBtn, "CancelBtn")
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'Frm98_IndevFeatures
        '
        Me.AcceptButton = Me.ValidateBtn
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBtn
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ValidateBtn)
        Me.Controls.Add(Me.ExperimentalSettingsGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm98_IndevFeatures"
        Me.ShowInTaskbar = False
        Me.ExperimentalSettingsGroup.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ExperimentalSettingsGroup As GroupBox
    Friend WithEvents ExSet_DarkModeHomeUpdateBar As CheckBox
    Friend WithEvents ValidateBtn As Button
    Friend WithEvents CancelBtn As Button
End Class
