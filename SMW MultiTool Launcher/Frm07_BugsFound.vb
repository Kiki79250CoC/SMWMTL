
Public Class Frm07_BugsFound

    Private Sub Frm07_BugsFound_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

                For Each LinkLbls As LinkLabel In {Mailto_LinkLabel, SMWC_Profile_LinkLabel, SMWC_ComposeMsg_LinkLabel}
                    With LinkLbls
                        .LinkColor = Color.LightGray
                        .VisitedLinkColor = Color.LightGray
                        .ActiveLinkColor = Color.DimGray
                    End With
                Next

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

                    Case Else
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

    End Sub

    ' Buttons and Links
    ' ------------------------------------

    ' "Mail" link
    Private Sub Mailto_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Mailto_LinkLabel.LinkClicked
        Process.Start("mailto:Kiki79250.coc@gmail.com")
    End Sub

    ' "View Profile" link
    Private Sub SMWC_Profile_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SMWC_Profile_LinkLabel.LinkClicked
        Process.Start("https://www.smwcentral.net/?p=profile&id=30080")
    End Sub

    ' "Compose Message" link
    Private Sub SMWC_ComposeMsg_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SMWC_ComposeMsg_LinkLabel.LinkClicked
        Process.Start("https://www.smwcentral.net/?p=pm&do=compose&user=30080")
    End Sub


    ' "Twitter" button
    Private Sub Twitter_Click(sender As Object, e As EventArgs) Handles TwitterBtn.Click
        Process.Start(If(Year(Now) >= 2023, "https://twitter.com/AstragonQC", "https://twitter.com/Kiki79250CoC"))
    End Sub

    ' "YouTube" button
    Private Sub YouTubeBtn_Click(sender As Object, e As EventArgs) Handles YouTubeBtn.Click
        Process.Start("https://www.youtube.com/channel/UCpgPO5kdA-zPhu71jli89tg")
    End Sub

    ' "GitHub Repo" button
    Private Sub GitHubBtn_Click(sender As Object, e As EventArgs) Handles GitHubBtn.Click
        Process.Start(If(Year(Now) >= 2023, "https://github.com/AstragonQC/SMWMTL", "https://github.com/Kiki79250CoC/SMWMTL"))
    End Sub

    ' "OK" button
    Private Sub OK_Btn_Click(sender As Object, e As EventArgs) Handles OK_Btn.Click
        Close()
    End Sub

    ' Page end

End Class