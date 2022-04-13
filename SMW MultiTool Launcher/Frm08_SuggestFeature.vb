
Imports System.IO

Public Class Frm08_SuggestFeature
#Region "        DWMAPI "

    ' Detect DWM activation
    <Runtime.InteropServices.DllImport("dwmapi.dll")> Private Shared Function DwmIsCompositionEnabled(ByRef enabled As Boolean) As Integer
    End Function
    Public Function AeroEnabled() As Boolean
        If Environment.OSVersion.Version.Major < 6 Then Return False
        Dim Enabled As Boolean
        DwmIsCompositionEnabled(Enabled)
        Return Enabled
    End Function

    ' Border extension
    <Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential)> Public Structure Side
        Public Left As Integer
        Public Right As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure
    <Runtime.InteropServices.DllImport("dwmapi.dll")> Public Shared Function DwmExtendFrameIntoClientArea(hWnd As IntPtr, ByRef pMarinset As Side) As Integer
    End Function

    Declare Ansi Function ShellAbout Lib "shell32.dll" Alias "ShellAboutA" (ByVal hWnd As IntPtr, ByVal szApp As String, ByVal szOtherStuff As String, ByVal hIcon As IntPtr) As Integer

#End Region
#Region "        Values "

    ReadOnly Win_NT_Version As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion", "CurrentVersion", Nothing)

#End Region

    Private Sub Frm08_SuggestFeature_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Icon = My.Resources.AppIcon

        ' DarkMode Toggle
        Select Case My.Settings.UI_DARK_MODE
            Case True
                ForeColor = Color.White
                BackColor = Color.FromArgb(36, 36, 36)
                UI_StatPanel.BackColor = Color.FromArgb(25, 25, 25)
                UI_BtmBar_Panel.BackColor = Color.FromArgb(25, 25, 25)
                UI_HeaderBorder.BackgroundImage = My.Resources.UI_BorderLineBottom
                UI_BtmBar_Panel.BackgroundImage = My.Resources.UI_BottomBar

                For Each TxtBx As TextBox In {ToolName_TextBox, AppVersion_TextBox, SuggestedBy_TextBox, Link_TextBox, OptionalMsg_TextBox, SuggestionResult_TextBox}
                    TxtBx.BackColor = Color.FromArgb(25, 25, 25)
                    TxtBx.ForeColor = Color.White
                Next

                For Each Panels As Panel In {ToolName_TextBoxBorder, AppVersion_TextBoxBorder, SuggestedBy_TextBoxBorder, Link_TextBoxBorder, OptionalMsg_TextBoxBorder, SuggestionResult_TextBoxBorder}
                    Panels.BackColor = Color.FromArgb(25, 25, 25)
                Next

                Gradient1.Image = My.Resources.GradientLine_White
                UI_Separator1.Image = My.Resources.UI_ButtonSeparator

        End Select

        ' Hiding the title and the window icon
        Select Case My.Settings.HIDE_TITLE
            Case True
                Text = Nothing

        End Select
        Select Case My.Settings.HIDE_ICON
            Case True
                Select Case My.Settings.BLANK_ICON
                    Case True
                        Icon = My.Resources.Blank16x16

                    Case False
                        ShowIcon = False

                End Select

        End Select

        ' Window opacity
        Select Case My.Settings.APP_OPACITY_TOGGLE
            Case True
                Select Case My.Settings.APP_OPACITY_APPLY_MODE
                    Case Is >= 1
                        Opacity = My.Settings.APP_OPACITY / 100

                End Select

        End Select

        OptionalMsg_CharCount.Text = $"{OptionalMsg_TextBox.Text.Length} / {OptionalMsg_TextBox.MaxLength}"

    End Sub

    ' Buttons
    ' ---------------------------------------------------------------------------------------------------------------------

    ' "To suggest file" button
    Private Sub ToSuggestFile_Click(sender As Object, e As EventArgs) Handles ToSuggestFileBtn.Click

        SuggestionResult_TextBox.Text = $"A new suggestion by {SuggestedBy_TextBox.Text} for a new app / update app version. {vbNewLine & vbNewLine}App name: {ToolName_TextBox.Text & vbNewLine}App version: {AppVersion_TextBox.Text & vbNewLine}Newer version: {If(NewVersion_Checkbox.Checked = True, "Yes", "No") & vbNewLine & vbNewLine}Link: {Link_TextBox.Text & vbNewLine & vbNewLine}Optional message: {vbNewLine & vbNewLine & OptionalMsg_TextBox.Text & vbNewLine & vbNewLine}-------------------------------------------------------------------------------------------------------{vbNewLine & vbNewLine}{My.Application.Info.AssemblyName}_{My.Resources.APP_CODENAME}_{My.Resources.APP_VERSION_COMPLETE}_x{If(Environment.Is64BitProcess = True, "64", "86")}_{My.Resources.BUILD_DATE_COMBINED}"

        SuggestionResult_TextBox.DeselectAll()
    End Sub

    ' "Copy" button
    Private Sub CopyBtn_Click(sender As Object, e As EventArgs) Handles CopyBtn.Click
        SuggestionResult_TextBox.SelectAll()
        SuggestionResult_TextBox.Copy()
        SuggestionResult_TextBox.DeselectAll()
    End Sub

    ' "Save to file" button
    Private Sub SaveToTXTFileBtn_Click(sender As Object, e As EventArgs) Handles SaveToTXTFileBtn.Click
        If SaveToTXTFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim a() As String = SaveToTXTFileDialog.FileName.Split("\")
            Dim sw As New StreamWriter(SaveToTXTFileDialog.FileName)
            sw.Write(SuggestionResult_TextBox.Text)
            My.Settings.Save()
            sw.Close()

        End If
    End Sub

    ' "Close" button
    Private Sub Close_Event(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Close()
    End Sub

    ' Other functions
    ' ---------------------------------------------------------------------------------------------------------------------

    ' Optional message characters counter
    Private Sub OptionalMsg_TextBox_TextChanged(sender As Object, e As EventArgs) Handles OptionalMsg_TextBox.TextChanged

        OptionalMsg_CharCount.Text = OptionalMsg_TextBox.Text.Length & " / " & OptionalMsg_TextBox.MaxLength

        If OptionalMsg_TextBox.Text.Length >= 0 Then
            OptionalMsg_CharCount.ForeColor = Color.Black
        End If
        If OptionalMsg_TextBox.Text.Length >= 1800 Then
            OptionalMsg_CharCount.ForeColor = Color.Purple
        End If
        If OptionalMsg_TextBox.Text.Length >= 1900 Then
            OptionalMsg_CharCount.ForeColor = Color.Red
        End If

    End Sub

    ' Page end

End Class