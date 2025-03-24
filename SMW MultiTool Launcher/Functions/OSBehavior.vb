
Public Class ClientOSInfo
    Public Shared ReadOnly KVer As Version = Version.Parse(FileVersionInfo.GetVersionInfo($"{Environment.SystemDirectory}\NTOSKrnl.exe").ProductVersion)
    Public Shared ReadOnly HALVer As Version = Version.Parse(FileVersionInfo.GetVersionInfo($"{Environment.SystemDirectory}\HAL.dll").ProductVersion)
    Public Shared ReadOnly W32kVer As Version = Version.Parse(FileVersionInfo.GetVersionInfo($"{Environment.SystemDirectory}\Win32K.sys").ProductVersion)
    Public Shared ReadOnly WLVer As Version = Version.Parse(FileVersionInfo.GetVersionInfo($"{Environment.SystemDirectory}\WinLogon.exe").ProductVersion)

End Class

Public Class OSBehavior

    Public Shared Function IsOSSupported()

        ' If one of these checks fails, it means that the OS is not supported.
        ' While CltOSVer is easy to bypass, KVer and HALVer are linked to the
        ' physical OS system files, and I'm not sure anyone wants to Reshack
        ' system files' version number.
        '
        ' The check of the bootloader could have been a possibility, but it would
        ' cause a problem of false positive if a NTLDR-based OS is installed 
        ' aside of a modern version of Windows.

        Dim RequiredOSVersion As New Version(6, 0, 6002)

        Dim CltOSVerChk As Boolean = RequiredOSVersion.CompareTo(SystemInterop.CltOSV)
        Dim KVerChk As Boolean = RequiredOSVersion.CompareTo(ClientOSInfo.KVer)
        Dim HALVerChk As Boolean = RequiredOSVersion.CompareTo(ClientOSInfo.HALVer)
        Dim W32kVerChk As Boolean = RequiredOSVersion.CompareTo(ClientOSInfo.W32kVer)
        Dim WinLogonVerChk As Boolean = RequiredOSVersion.CompareTo(ClientOSInfo.WLVer)

        Return CltOSVerChk AndAlso KVerChk AndAlso HALVerChk AndAlso W32kVerChk AndAlso WinLogonVerChk

    End Function

End Class
