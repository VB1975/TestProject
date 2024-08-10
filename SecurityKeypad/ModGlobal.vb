Module ModGlobal

    Public Filename As String = AppDomain.CurrentDomain.BaseDirectory & "AccessCode.txt"
    Public AccessCode As String

    Public Sub GetAccessCode()

        Dim objFile As New IO.StreamReader(Filename)
        AccessCode = objFile.ReadLine
        objFile.Close()
        objFile.Dispose()

    End Sub
End Module
