
Imports System.IO

Public Class OSInteract

    Public Shared Function PELinkerTimestamp(Path As String) As Date
        Dim FileB(2047) As Byte
        Dim FileS As Stream = Nothing
        Try
            FileS = New FileStream(Path, FileMode.Open, FileAccess.Read)
            FileS.Read(FileB, 0, 2048)
        Finally
            If FileS IsNot Nothing Then FileS.Close()
        End Try
        Return New DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(BitConverter.ToInt32(FileB, BitConverter.ToInt32(FileB, 60) + 8)).AddHours(TimeZone.CurrentTimeZone.GetUtcOffset(New DateTime(1970, 1, 1, 0, 0, 0)).Hours)
    End Function

End Class
