
Public Class Frm06_OS_Version
#Region "        Values "

    ' Windows Name
    ReadOnly Win_FullName As String = My.Computer.Info.OSFullName.ToString
    ReadOnly Win_OriginalName As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion", "ProductName", Nothing)

    ' Windows' Version Numbers
    ReadOnly Win_NT_Version As String = $"{Environment.OSVersion.Version.Major}.{Environment.OSVersion.Version.Minor}"
    ReadOnly Win_Build_Number As Integer = Environment.OSVersion.Version.Build

    ReadOnly Win_completeBuildNbr As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion", "BuildLabEx", Nothing)
    ReadOnly Win_UpdateRevisionNbr As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion", "UBR", Nothing)

    ' Windows 10/11 Major version
    Private Win_MajorVerValue As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion", "ReleaseId", "1507")

    ' Copyright Year
    Private Win_Copyright_Year As String = Nothing

    ' RAM
    Private AvailableRAM As Decimal
    Private TotalRAM As Decimal

    ' Retrieving Username
    ReadOnly WSHNetwork = CreateObject("WScript.Network")

#End Region

    Private Sub Frm06_OS_Version_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Dark Mode
        Select Case My.Settings.UI_DARK_MODE
            Case True
                ForeColor = Color.White
                BackColor = Color.FromArgb(36, 36, 36)
                UI_StatPanel.BackColor = Color.FromArgb(25, 25, 25)
                UI_BtmBar_Panel.BackColor = Color.FromArgb(25, 25, 25)
                UI_HeaderBorder.BackgroundImage = My.Resources.UI_BorderLineBottom
                UI_BtmBar_Panel.BackgroundImage = My.Resources.UI_BottomBar

                Title1.ForeColor = Color.White
                Title2.ForeColor = Color.White

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

        ' Windows Opacity
        Select Case My.Settings.APP_OPACITY_TOGGLE
            Case True
                Select Case My.Settings.APP_OPACITY_APPLY_MODE
                    Case Is >= 1
                        Opacity = My.Settings.APP_OPACITY / 100

                End Select

        End Select

        ' +-------------------------------------------------------------+
        ' |                  LOADING DATA ABOUT THE OS                  |
        ' +-------------------------------------------------------------+

        ' Preliminary Step - Retrieving the Major version if Windows 10+
        If Win_MajorVerValue = "2009" Then
            Win_MajorVerValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion", "DisplayVersion", Nothing)
        End If

        ' OS Name
        WindowsVersion_Value.Text = Win_OriginalName
        WindowsVersion_Value.Text = WindowsVersion_Value.Text.Replace("(TM) ", "").Trim().Replace("Microsoft ", "").Replace("Ultimate", "").Replace("Professional", "").Replace("Pro", "").Replace("for Workstations", "").Replace("Core", "").Replace("Family", "").Replace("Enterprise", "").Replace("China", "").Replace("Only", "").Replace("Home", "").Replace("Single Language", "").Replace("SE", "").Replace("Basic", "").Replace("Premium", "").Replace("Starter", "").Replace("Edition", "").Replace("KN", "").Replace("SE", "").Replace("K", "").Replace("N", "").Replace("E", "").Replace("G", "").Replace("IoT", "").Replace("Education", "").Replace("Insider Preview", "").Replace("Datacenter", "").Replace("Standard", "").Replace("Foundation", "").Replace("Storage Server", "").Trim()

        ' OS Edition
        WindowsEdition_Value.Text = Win_FullName
        WindowsEdition_Value.Text = WindowsEdition_Value.Text.Replace("Microsoft", "").Replace("Windows", "").Replace("®", "").Replace("™", "").Replace("XP", "").Replace("Vista", "").Replace("7", "").Replace("8", "").Replace(".1", "").Replace("10", "").Replace("11", "").Replace("Server", "").Replace("for", "").Replace("2008", "").Replace("2012", "").Replace("2016", "").Replace("2019", "").Replace("2022", "").Replace("R2", "").Replace("Longhorn", "").Replace("Insider", "").Replace("Developer", "").Replace("Technical", "").Replace("Preview", "").Trim()

        ' Service Pack
        Select Case Win_NT_Version
            Case "6.0", "6.1"
                WindowsServicePack_Value.Text = If(WindowsServicePack_Value.Text = Nothing, "RTM", Environment.OSVersion.ServicePack)

            Case "6.2"
                WindowsServicePack_Value.Text = "RTM"

            Case "6.3"
                WindowsServicePack_Value.Text = If(Win_UpdateRevisionNbr >= 17031, "Update 1", "RTM")

            Case "6.4", "10.0"
                Text3.Text = Frm99_TranslateForm.UI0A_FeatureUpdate.Text
                WindowsServicePack_Value.Text = Win_MajorVerValue
                Win_Copyright_Year = If(Win_MajorVerValue = "Dev", Nothing, Win_MajorVerValue.Take(2).ToArray)

        End Select

        ' OS Version (NT Kernel & BuildLabEx)
        WindowsNTVersion_Value.Text = $"Version NT {Win_NT_Version} Build {Win_Build_Number} • (NT {Win_NT_Version}.{Win_Build_Number})"
        WindowsCompleteVersion_Value.Text = $"{Win_NT_Version}.{Win_completeBuildNbr}"

        ' OS Platform
        WindowsPlatform_Value.Text = $"{Environment.OSVersion.Platform}"

        ' OS Culture
        WindowsLanguage_Value.Text = $"{My.Computer.Info.InstalledUICulture.DisplayName} ({My.Computer.Info.InstalledUICulture})"

        ' Retrieving information about RAM
        AvailableRAM = (My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024).ToString
        TotalRAM = (My.Computer.Info.TotalPhysicalMemory / 1024 / 1024).ToString

        AvailableRAM_Value.Text = $"{Math.Round(AvailableRAM, 2, MidpointRounding.AwayFromZero)} {MegabyteUnit.Text}"
        TotalRAM_Value.Text = $"{Math.Round(TotalRAM, 2, MidpointRounding.AwayFromZero)} {MegabyteUnit.Text}"

        MemoriesTimer.Start()

        ' Current Username
        WindowsUsername_Value.Text = WSHNetwork.Username

        ' Computer Name
        WindowsComputerName_Value.Text = Net.Dns.GetHostName

        ' Copyright and Microsoft Logo

        Select Case Win_NT_Version
            Case "6.0"
                If Win_OriginalName.Contains("Server") Then
                    OS_Winver_Image.Image = If(My.Settings.UI_DARK_MODE = True, My.Resources.Winver_banner_WinSvr2008W, My.Resources.Winver_banner_WinSvr2008B)
                    Win_Copyright_Year = "08"

                Else
                    OS_Winver_Image.Image = If(My.Settings.UI_DARK_MODE = True, My.Resources.Winver_banner_WinVistaW, My.Resources.Winver_banner_WinVistaB)
                    Win_Copyright_Year = "07"

                End If

            Case "6.1"
                If Win_OriginalName.Contains("Server") Then
                    OS_Winver_Image.Image = If(My.Settings.UI_DARK_MODE = True, My.Resources.Winver_banner_WinSvr2008R2W, My.Resources.Winver_banner_WinSvr2008R2B)

                Else
                    OS_Winver_Image.Image = If(My.Settings.UI_DARK_MODE = True, My.Resources.Winver_banner_Win7W, My.Resources.Winver_banner_Win7B)

                End If

                Win_Copyright_Year = "09"

            Case "6.2"
                If Win_OriginalName.Contains("Server") Then
                    OS_Winver_Image.Image = If(My.Settings.UI_DARK_MODE = True, My.Resources.Winver_banner_WinSvr2012W, My.Resources.Winver_banner_WinSvr2012B)

                Else
                    OS_Winver_Image.Image = If(My.Settings.UI_DARK_MODE = True, My.Resources.Winver_banner_Win8W, My.Resources.Winver_banner_Win8B)

                End If

                Win_Copyright_Year = "12"

            Case "6.3"
                If Win_OriginalName.Contains("Server") Then
                    OS_Winver_Image.Image = If(My.Settings.UI_DARK_MODE = True, My.Resources.Winver_banner_WinSvr2012R2W, My.Resources.Winver_banner_WinSvr2012R2B)

                Else
                    OS_Winver_Image.Image = If(My.Settings.UI_DARK_MODE = True, My.Resources.Winver_banner_Win81W, My.Resources.Winver_banner_Win81B)

                End If

                Win_Copyright_Year = "13"

            Case "6.4", "10.0"
                If Win_OriginalName.Contains("Server") Then

                    If WindowsVersion_Value.Text.Contains("2016") Then
                        OS_Winver_Image.Image = If(My.Settings.UI_DARK_MODE = True, My.Resources.Winver_banner_WinSvr2016W, My.Resources.Winver_banner_WinSvr2016B)

                    ElseIf WindowsVersion_Value.Text.Contains("2019") Then
                        OS_Winver_Image.Image = If(My.Settings.UI_DARK_MODE = True, My.Resources.Winver_banner_WinSvr2019W, My.Resources.Winver_banner_WinSvr2019B)

                    ElseIf WindowsVersion_Value.Text.Contains("2022") Then
                        OS_Winver_Image.Image = If(My.Settings.UI_DARK_MODE = True, My.Resources.Winver_banner_WinSvr2022W, My.Resources.Winver_banner_WinSvr2022B)

                    End If

                Else
                    If Win_Build_Number >= 21800 Then
                        OS_Winver_Image.Image = If(My.Settings.UI_DARK_MODE = True, My.Resources.Winver_banner_Win11W, My.Resources.Winver_banner_Win11B)
                        WindowsVersion_Value.Text = "Windows 11"

                    Else
                        OS_Winver_Image.Image = If(My.Settings.UI_DARK_MODE = True, My.Resources.Winver_banner_Win10W, My.Resources.Winver_banner_Win10B)

                    End If

                End If

            Case Else
                OS_Winver_Image.Image = If(My.Settings.UI_DARK_MODE = True, My.Resources.Winver_banner_WinUnknownW, My.Resources.Winver_banner_WinUnknownB)
                Win_Copyright_Year = Nothing

        End Select

        MicrosoftCopyright_Value.Text = $"© {If(Win_Copyright_Year = Nothing, Nothing, $"20{Win_Copyright_Year} ")}Microsoft Corporation"

        ' Adding Windows version in the title (if the Title is enabled)
        Select Case My.Settings.HIDE_TITLE
            Case False
                Text += $"{WindowsVersion_Value.Text} {WindowsEdition_Value.Text} ({WindowsArch_Value.Text})"

        End Select

    End Sub

    ' Buttons at the bottom of the Window.
    ' ------------------------------------

    ' "OK" Button
    Private Sub OK_Btn_Click(sender As Object, e As EventArgs) Handles OK_Btn.Click
        Close()
    End Sub

    ' "Advanced System Informations" button
    Private Sub MSINFO32_Btn_Click(sender As Object, e As EventArgs) Handles MSINFO32_Btn.Click
        Try

            Process.Start("msinfo32.exe")

        Catch ex As Exception

            MsgBox($"{Frm99_TranslateForm.UI0A_TradLine_02.Text}{vbNewLine}{vbNewLine}{ex.Message}", MsgBoxStyle.Critical, $"{My.Application.Info.AssemblyName} • {Frm99_TranslateForm.UI0A_TradLine_01.Text}")

        End Try
    End Sub

    ' Automated functions
    ' ------------------------------------
    ' RAM usage Timer

    Private Sub MemoriesTimer_Tick(sender As Object, e As EventArgs) Handles MemoriesTimer.Tick
        AvailableRAM = (My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024).ToString
        AvailableRAM_Value.Text = Math.Round(AvailableRAM, 2, MidpointRounding.AwayFromZero) & " " & MegabyteUnit.Text
    End Sub

    ' Page end

End Class