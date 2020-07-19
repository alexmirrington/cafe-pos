Module UserUtilities
    Public Function IsManager(ByVal userToCheck As String)
        Dim users() As UserRecord = LoadUsers()
        Try
            'Loop through users until we find the correct one.
            For i = 0 To UBound(users)
                If users(i).username = userToCheck Then
                    'Found the user
                    Return users(i).manager
                End If
            Next
        Catch ex As Exception
            'i.e. There is nothing in the users array
        End Try
        Return False
    End Function
End Module
