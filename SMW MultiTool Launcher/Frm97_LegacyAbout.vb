
Imports System.Globalization

Public Class Frm97_LegacyAbout
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

    Declare Ansi Function ShellAbout Lib "shell32.dll" Alias "ShellAboutA" (hWnd As IntPtr, szApp As String, szOtherStuff As String, hIcon As IntPtr) As Integer

#End Region
#Region "        Values "

    ReadOnly Win_NT_Version As String = $"{Environment.OSVersion.Version.Major}.{Environment.OSVersion.Version.Minor}"
    ReadOnly Win_BuildNbr As String = Environment.OSVersion.Version.Build

    ReadOnly Year_in_Digits = Year(Now)
    ReadOnly DisplayYear As String = My.Resources.BUILD_DATE_YEAR

    ' Software Compilation date
    ReadOnly CompileDate As New DateTime(My.Resources.BUILD_DATE_YEAR, My.Resources.BUILD_DATE_MONTH, My.Resources.BUILD_DATE_DAY)

#End Region

    Private Sub Frm97_LegacyAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Icon = My.Resources.AppIcon

        ' Application Name
        Text += $" {Frm01_Main.WindowTitle}"
        About_GroupBox.Text = Frm01_Main.WindowTitle

        ' Enhancements for Windows Classic
        For Each ImgBx As PictureBox In {Deco1, Deco2, Deco3, Deco4}
            Select Case My.Settings.WIN_CLASSIC_ENHANCEMENTS
                Case True
                    ImgBx.Visible = False

                Case False
                    ImgBx.Visible = True

                    Select Case Win_NT_Version
                        Case "6.0", "6.1"
#Region "                        Code that applies to Windows Vista & 7 "

                            Deco3.Image = My.Resources.UI_RightMask_7
                            Deco4.Image = My.Resources.UI_LeftMask_7

#End Region

                        Case "6.2", "6.3"
#Region "                        Code that applies to Windows 8 and 8.1 "

                            Deco3.Image = My.Resources.UI_RightMask_8
                            Deco4.Image = My.Resources.UI_LeftMask_8

#End Region

                        Case "10.0"
#Region "                        Code that applies to Windows 10 and 11 "

                            If Win_BuildNbr >= "21800" Then
                                Deco3.Image = My.Resources.UI_RightMask_11
                                Deco4.Image = My.Resources.UI_LeftMask_11
                            Else
                                Deco3.Image = My.Resources.UI_RightMask_10
                                Deco4.Image = My.Resources.UI_LeftMask_10
                            End If

#End Region

                    End Select

            End Select
        Next

        ' DWMAPI extension (Option enabled) and Theme (Option Disabled)
        Select Case My.Settings.DWM_EXTENSION
            Case True
                Select Case AeroEnabled()
                    Case True
                        Dim side As New Side With {.Left = 13, .Right = 13, .Top = 33, .Bottom = If(Win_NT_Version = "6.0", 15, 13)}
                        Dim result As Integer = DwmExtendFrameIntoClientArea(Handle, side)

                        BackColor = Color.Black

                End Select

            Case False



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

        ' Replacing values
        AboutText.Text = AboutText.Text.Replace("BUILDN", My.Resources.APP_VERSION_BUILD).Replace("COMPLETEVER", $"{My.Resources.APP_VERSION}.{My.Resources.APP_VERSION_BUILD}").Replace("SVER", My.Resources.APP_VERSION).Replace("STATE", My.Resources.RELEASE_STATE).Replace("ACD", $"{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CompileDate.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture(If(My.Computer.Info.InstalledUICulture.ToString().Contains("fr"), "fr-FR", "en-US"))))}").Replace("ACYEAR", If(Year_in_Digits >= DisplayYear, Year_in_Digits, DisplayYear)).Replace("ATHR", My.Resources.APP_AUTHOR).Trim()

    End Sub

    ' Boutons

    ' "OK" button
    Private Sub OK_Btn_Click(sender As Object, e As EventArgs) Handles OK_Btn.Click
        Close()
    End Sub

    ' Page end

End Class