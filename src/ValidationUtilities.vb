Module ValidationUtilities
    Public Function StringIsConvertibleToInteger(ByVal str As String)
        Try
            Integer.Parse(str)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function StringIsConvertibleToSingle(ByVal str As String)
        Try
            Single.Parse(str)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module
