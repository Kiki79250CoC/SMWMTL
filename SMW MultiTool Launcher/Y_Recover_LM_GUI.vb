Imports System.IO

Public Class Y_Recover_LM_GUI

    Private Sub RecoverLM_AppLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        FileToUnlock_TextBox.Select()
        UnlockStatus_Text.Text = Frm99_TranslateForm.RlmGUI_Done.Text

    End Sub

    ' Browse locked ROM
    Private Sub ROM_To_Unlock_BrowseBtn_Click(sender As Object, e As EventArgs) Handles ROM_To_Unlock_BrowseBtn.Click
        Dim result As DialogResult = OpenLockedROM.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            FileToUnlock_TextBox.Text = Path.GetFullPath(OpenLockedROM.FileName)
        End If
    End Sub

    ' Save unlocked ROM
    Private Sub Unlocked_ROM_BrowseBtn_Click(sender As Object, e As EventArgs) Handles Unlocked_ROM_BrowseBtn.Click
        Dim result As DialogResult = SaveUnlockedROM.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            UnlockedFile_TextBox.Text = Path.GetFullPath(SaveUnlockedROM.FileName)
        End If
    End Sub

    ' "Recover" button
    Private Sub RecoverBtn_Click(sender As Object, e As EventArgs) Handles RecoverBtn.Click

        TopMost = True

        Dim RLM As New Process
        With RLM.StartInfo
            .FileName = "cmd.exe"
            .UseShellExecute = False
            .RedirectStandardOutput = True
            .WindowStyle = ProcessWindowStyle.Hidden
        End With

        If FileToUnlock_TextBox.Text = Nothing OrElse UnlockedFile_TextBox.Text = Nothing Then
            RLM.StartInfo.Arguments = $"/c {Chr(34) & My.Settings.RECOVERLM_PATH & Chr(34)}"
        Else
            RLM.StartInfo.Arguments = $"/c {Chr(34) & My.Settings.RECOVERLM_PATH & Chr(34)} {Chr(34) & FileToUnlock_TextBox.Text & Chr(34)} {Chr(34) & UnlockedFile_TextBox.Text & Chr(34)}"
        End If

        RLM.Start()

        Dim output() As String = RLM.StandardOutput.ReadToEnd.Split(vbLf)
        For Each ln As String In output
            ConsoleOutput_RichTextBox.AppendText(vbNewLine & ln & vbNewLine)
            ConsoleOutput_RichTextBox.ScrollToCaret()

            UnlockStatus_Text.Text = ln
        Next

        ConsoleOutput_RichTextBox.AppendText("---------------------------------------------------------------------------" & vbNewLine & vbNewLine)
        ConsoleOutput_RichTextBox.ScrollToCaret()

        UnlockStatus_Text.Text = Frm99_TranslateForm.RlmGUI_Done.Text

        TopMost = False

    End Sub
    Private Sub ConsoleOutput_RichTextBox_ContentsResized(sender As Object, e As ContentsResizedEventArgs) Handles ConsoleOutput_RichTextBox.ContentsResized
        ConsoleOutputZoom_Text.Text = $"{Frm99_TranslateForm.RlmGUI_OutputZoom.Text} {ConsoleOutput_RichTextBox.ZoomFactor}x"
    End Sub

    ' ----------| Menu bar |----------

    ' "Menu" menu
    Private Sub ResetWindow_MenuItem_Click(sender As Object, e As EventArgs) Handles ResetWindow_MenuItem.Click

        FileToUnlock_TextBox.Clear()
        UnlockedFile_TextBox.Clear()

        ConsoleOutput_RichTextBox.Clear()
        ConsoleOutput_RichTextBox.ZoomFactor = 1

    End Sub
    Private Sub Close_MenuItem_Click(sender As Object, e As EventArgs) Handles Close_MenuItem.Click
        Close()
    End Sub
    Private Sub ShowStatusBar_MenuItem_Click(sender As Object, e As EventArgs) Handles ShowStatusBar_MenuItem.Click
        Select Case ShowStatusBar_MenuItem.Checked
            Case True
                StatusBar.Visible = False
                ShowStatusBar_MenuItem.Checked = False

            Case False
                StatusBar.Visible = True
                ShowStatusBar_MenuItem.Checked = True

        End Select
    End Sub

    ' "Console Output" menu
    Private Sub ShowConsoleOutput_MenuItem_Click(sender As Object, e As EventArgs) Handles ShowConsoleOutput_MenuItem.Click

        If ShowConsoleOutput_MenuItem.Checked = True Then

            Size = New Size(Width, 173)

            ClearConsoleOutput_MenuItem.Enabled = False
            ConsoleOutput_Submenu.Enabled = False
            ResetZoom_MenuItem.Enabled = False
            ExportConsoleOutput_MenuItem.Enabled = False

            ConsoleOutputZoom_Text.Visible = False

            ShowConsoleOutput_MenuItem.Checked = False

        Else

            Size = New Size(Width, 465)

            ClearConsoleOutput_MenuItem.Enabled = True
            ConsoleOutput_Submenu.Enabled = True
            ResetZoom_MenuItem.Enabled = True
            ExportConsoleOutput_MenuItem.Enabled = True

            ConsoleOutputZoom_Text.Visible = True

            ShowConsoleOutput_MenuItem.Checked = True

            ConsoleOutput_Groupbox.Height = 285

        End If

    End Sub
    Private Sub ClearConsoleOutput_MenuItem_Click(sender As Object, e As EventArgs) Handles ClearConsoleOutput_MenuItem.Click
        ConsoleOutput_RichTextBox.Clear()
    End Sub

    ' Console output zoom
    Private Sub ResetZoom_MenuItem_Click(sender As Object, e As EventArgs) Handles ResetZoom_MenuItem.Click, Zoom1x_MenuItem.Click

        ConsoleOutput_RichTextBox.ZoomFactor = 1
        ConsoleOutputZoom_Text.Text = $"{Frm99_TranslateForm.RlmGUI_OutputZoom.Text} {ConsoleOutput_RichTextBox.ZoomFactor}x"

    End Sub
    Private Sub Zoom2x_MenuItem_Click(sender As Object, e As EventArgs) Handles Zoom2x_MenuItem.Click
        ConsoleOutput_RichTextBox.ZoomFactor = 2
    End Sub
    Private Sub Zoom3x_MenuItem_Click(sender As Object, e As EventArgs) Handles Zoom3x_MenuItem.Click
        ConsoleOutput_RichTextBox.ZoomFactor = 3
    End Sub
    Private Sub Zoom4x_MenuItem_Click(sender As Object, e As EventArgs) Handles Zoom4x_MenuItem.Click
        ConsoleOutput_RichTextBox.ZoomFactor = 4
    End Sub
    Private Sub Zoom5x_MenuItem_Click(sender As Object, e As EventArgs) Handles Zoom5x_MenuItem.Click
        ConsoleOutput_RichTextBox.ZoomFactor = 5
    End Sub
    Private Sub Zoom6x_MenuItem_Click(sender As Object, e As EventArgs) Handles Zoom6x_MenuItem.Click
        ConsoleOutput_RichTextBox.ZoomFactor = 6
    End Sub
    Private Sub Zoom7x_MenuItem_Click(sender As Object, e As EventArgs) Handles Zoom7x_MenuItem.Click
        ConsoleOutput_RichTextBox.ZoomFactor = 7
    End Sub
    Private Sub Zoom8x_MenuItem_Click(sender As Object, e As EventArgs) Handles Zoom8x_MenuItem.Click
        ConsoleOutput_RichTextBox.ZoomFactor = 8
    End Sub
    Private Sub Zoom9x_MenuItem_Click(sender As Object, e As EventArgs) Handles Zoom9x_MenuItem.Click
        ConsoleOutput_RichTextBox.ZoomFactor = 9
    End Sub
    Private Sub Zoom10x_MenuItem_Click(sender As Object, e As EventArgs) Handles Zoom10x_MenuItem.Click
        ConsoleOutput_RichTextBox.ZoomFactor = 10
    End Sub

    ' Export console output
    Private Sub ExportConsoleOutput_MenuItem_Click(sender As Object, e As EventArgs) Handles ExportConsoleOutput_MenuItem.Click
        If ExportConsoleOutput.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim a() As String = ExportConsoleOutput.FileName.Split("\")
            Dim sw As New StreamWriter(ExportConsoleOutput.FileName)
            sw.Write(ConsoleOutput_RichTextBox.Text)
            sw.Close()
        End If
    End Sub

    ' Menu "?"
    Private Sub HowToUse_MenuItem_Click(sender As Object, e As EventArgs) Handles HowToUse_MenuItem.Click

    End Sub
    Private Sub About_MenuItem_Click(sender As Object, e As EventArgs) Handles About_MenuItem.Click
        MsgBox($"{Frm99_TranslateForm.RlmGUI_TradLine01.Text & vbNewLine}Version 1.2.0{vbNewLine & vbNewLine}© 2014-{If(Year(Now) > My.Resources.BUILD_DATE_YEAR, Year(Now), My.Resources.BUILD_DATE_YEAR)} {My.Resources.APP_AUTHOR & vbNewLine & Frm02_About.UI_AllRightsLabel.Text}", MsgBoxStyle.Information, Frm99_TranslateForm.RlmGUI_AboutTitle.Text)
    End Sub

End Class