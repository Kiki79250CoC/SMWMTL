
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    Partial Friend Class MyApplication

        Private Function GetFileVersionInfo(filename As String) As Version
            Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion)
        End Function

        ' ---------------------------------------------------------------------------------------------------------------------

        Private Sub App_JumpStart(sender As Object, e As StartupEventArgs) Handles Me.Startup

            ' Block Windows XP execution, even with HEX-Operating system number hack
            If Environment.OSVersion.Version.Major < 6 Then

                MsgBox($"{Frm99_TranslateForm.UI00_UnsupportedOS.Text} {Application.Info.AssemblyName}.", MsgBoxStyle.Critical, Application.Info.AssemblyName)
                End

            End If

            ' Block execution if "Application.exe.config" file is missing
            Select Case IO.File.Exists($"{IO.Path.GetFileName(Windows.Forms.Application.ExecutablePath)}.config")
                Case False
                    MsgBox($"{Frm99_TranslateForm.UI00_ConfigFileMissing.Text.Replace("$SFL", $"{IO.Path.GetFileName(Windows.Forms.Application.ExecutablePath)}.config")}", MsgBoxStyle.Critical, Application.Info.AssemblyName)
                    End

            End Select

            ' -----------------------------------------------------------------------------------------------------------------

            ' Update - "UpdatePkg.exe" file handling
            Select Case IO.File.Exists($"{Application.Info.DirectoryPath}\UpdatePkg.exe")
                Case True
                    Select Case GetFileVersionInfo($"{Application.Info.DirectoryPath}\UpdatePkg.exe").ToString
                        Case Is <= $"{Resources.APP_VERSION}.{Resources.APP_VERSION_BUILD}"
                            IO.File.Delete($"{Application.Info.DirectoryPath}\UpdatePkg.exe")

                        Case Is > $"{Resources.APP_VERSION}.{Resources.APP_VERSION_BUILD}"
                            Select Case Settings.UPDATE_SILENT_INSTALL
                                Case True
                                    Try

                                        Dim ProcStart As New ProcessStartInfo With {.FileName = $"{Application.Info.DirectoryPath}\UpdatePkg.exe", .WorkingDirectory = Application.Info.DirectoryPath, .Arguments = "/VERYSILENT /CURRENTUSER /CLOSEAPPLICATIONS /NOCANCEL"}
                                        Process.Start(ProcStart)

                                    Catch ex As Exception

                                        MsgBox(ex.Message, MsgBoxStyle.Critical, Application.Info.AssemblyName)

                                    End Try

                            End Select

                    End Select

            End Select

            ' Set current version number
            Settings.EXECUTABLE_CURRENT_VERSION = $"{Resources.APP_VERSION}.{Resources.APP_VERSION_BUILD}"

            ' Settings refresh
            Settings.Save()
            Settings.Reload()

            ' Updates module v3
            ' -----------------------------------------------------------------------------------------------------------------

            ' Untrigger silent update when current version is the same or above the last version found in update
            If Settings.UPDATE_SILENT_INSTALL = True And Settings.UPDATE_FOUND_CVERSION <= Resources.APP_VERSION_WITHZERO Then

                Settings.UPDATE_SILENT_INSTALL = False

            End If

            ' Disable "Update pending" if last check is +6 hours or if last checked version number is < / = than current
            If Settings.UPDATE_PENDING = True And Now > Settings.LAST_UPDATE_CHECK_DATE.AddHours(6) OrElse Settings.UPDATE_PENDING = True And Settings.UPDATE_FOUND_CVERSION <= Resources.APP_VERSION_WITHZERO Then

                Settings.UPDATE_PENDING = False
                Settings.UPDATE_PENDING_DOWNLOAD = False
                Settings.UPDATE_PENDING_INSTALLATION = False

            End If

            ' -----------------------------------------------------------------------------------------------------------------

            ' Enable the Pre-Release mode is this build is a beta one
            Select Case Resources.RELEASE_STATE
                Case "Stable", "Stable LTS"
                    Settings.IS_PRERELEASE = False

                Case Else
                    Settings.IS_PRERELEASE = True

            End Select

        End Sub
        Private Sub App_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException

            e.ExitApplication = False
            MsgBox(e.Exception.Message.ToString(), MsgBoxStyle.Critical, Application.Info.AssemblyName)

        End Sub

    End Class

End Namespace
