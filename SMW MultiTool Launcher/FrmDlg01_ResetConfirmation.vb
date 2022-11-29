
Imports System.Configuration

Public Class FrmDlg01_ResetConfirmation
#Region "        Values "

    ReadOnly ConfigFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath

#End Region

    Private Sub FrmDlg01_ResetConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Icon = My.Resources.ResetConfirmation

        ' DarkMode Toggle
        Select Case My.Settings.UI_DARK_MODE
            Case True
                ForeColor = Color.White
                BackColor = Color.FromArgb(36, 36, 36)
                UI_StatPanel.BackColor = Color.FromArgb(25, 25, 25)
                UI_BtmBar_Panel.BackColor = Color.FromArgb(25, 25, 25)
                UI_HeaderBorder.BackgroundImage = My.Resources.UI_BorderLineBottom
                UI_BtmBar_Panel.BackgroundImage = My.Resources.UI_BottomBar

                Text_02.ForeColor = Color.PaleGreen

        End Select

        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)

    End Sub

    ' Buttons

    ' "OK" button
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    ' "Cancel" button
    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    ' "Export settings" button
    Private Sub SettingsExportBtn_Click(sender As Object, e As EventArgs) Handles ExportSettings_Button.Click

        ExportSettings_SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Try

            Dim result As DialogResult = ExportSettings_SaveFileDialog.ShowDialog()

            If result = Windows.Forms.DialogResult.OK Then

                IO.File.Delete(IO.Path.GetFullPath(ExportSettings_SaveFileDialog.FileName))
                IO.File.Copy(ConfigFile, IO.Path.GetFullPath(ExportSettings_SaveFileDialog.FileName))

                MessageBox.Show($"{Frm99_TranslateForm.UI03_SettingsExportSuccessDesc.Text}{vbNewLine}{Chr(34)}{IO.Path.GetFullPath(ExportSettings_SaveFileDialog.FileName)}{Chr(34)}.", Frm99_TranslateForm.UI03_SettingsExportSuccessTitle.Text, CType(MsgBoxStyle.OkOnly, MessageBoxButtons), MessageBoxIcon.Information)

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {ExportSettings_SaveFileDialog.Title}")

        End Try
    End Sub

    ' Page end

End Class
