Imports System.Globalization

Module ModGlobal

    Function CalculateAge(ByVal dob As DateTime) As Integer

        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - dob.Year

        ' Adjust the age if the birth date has not yet occurred this year
        If (today.Month < dob.Month) OrElse (today.Month = dob.Month AndAlso today.Day < dob.Day) Then
            age -= 1
        End If

        Return age

    End Function

    Function ToProperCase(ByVal str As String) As String

        Dim cultureInfo As CultureInfo = CultureInfo.CurrentCulture
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Return textInfo.ToTitleCase(str.ToLower())

    End Function
End Module
