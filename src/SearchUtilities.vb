Module SearchUtilities

#Region "Basic Searches"
    Public Function ItemExistsInArray(Of T)(ByVal arrToSearch() As T, ByVal elementToSearchFor As T)
        'Algorithm based on linear search

        'Note the try/catch statement is here in case a null array is passed in as a parameter.
        Try
            'Loop through the array that we want to search
            For i = 0 To UBound(arrToSearch)
                If arrToSearch(i).Equals(elementToSearchFor) Then 'Check if the element at the current loop index matches the element we are searching for
                    Return True 'Return true
                End If
            Next
        Catch ex As Exception
            Debug.Print("Null array passed into function ItemExistsInArray()")
        End Try
        Return False 'Return false
    End Function

    'OTHER STANDARD ALGORITHMS

    'Public Function ItemExistsInSortedArray(ByVal sortedArrToSearch() As Integer, ByVal elementToSearchFor As Integer)
    '    'Perform Binary Search, quicker than the Linear Search version but requires a sorted array.
    '    Dim lowerIndex As Integer = 0
    '    Dim upperIndex As Integer = UBound(sortedArrToSearch)
    '    Dim itemFound As Boolean = False

    '    While itemFound = False And upperIndex >= lowerIndex
    '        Dim midIndex As Integer = CInt((lowerIndex + upperIndex) / 2)
    '        If elementToSearchFor < sortedArrToSearch(midIndex) Then
    '            upperIndex = midIndex - 1
    '        ElseIf elementToSearchFor > sortedArrToSearch(midIndex) Then
    '            lowerIndex = midIndex + 1
    '        Else
    '            'Item found
    '            itemFound = True
    '        End If
    '    End While

    '    If itemFound = True Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

    'Public Function GetMaxValueInArray(ByVal arrToSearch() As Integer)
    '    'Based on Linear Search
    '    Dim maxValue As Integer = arrToSearch(0)
    '    For i = 0 To UBound(arrToSearch)
    '        If arrToSearch(i) > maxValue Then
    '            maxValue = arrToSearch(i)
    '        End If
    '    Next
    '    Return maxValue
    'End Function

    'Public Function GetMinValueInArray(ByVal arrToSearch() As Integer)
    '    'Based on Linear Search
    '    Dim minValue As Integer = arrToSearch(0)
    '    For i = 0 To UBound(arrToSearch)
    '        If arrToSearch(i) < minValue Then
    '            minValue = arrToSearch(i)
    '        End If
    '    Next
    '    Return minValue
    'End Function
#End Region

#Region "Order Searches"
    Public Function FindRecordsWithSearchCriteria(ByVal arrToSearch() As OrderRecord, ByVal searchCriteria As String)
        'Based on linear search

        Dim arrToReturn() As OrderRecord = Nothing 'Array for storing records that we want to return

        'Note the try/catch statement is here in case a null array is passed in as a parameter.
        Try
            'Loop through array of items we are searching
            For i = 0 To UBound(arrToSearch)
                'Check if the current record contains the search criteria in either its subtotal, employee, or customerComments fields
                If arrToSearch(i).orderSubtotal.ToString.ToUpper.Contains(searchCriteria.ToUpper) Or arrToSearch(i).employee.ToString.ToUpper.Contains(searchCriteria.ToUpper) Or arrToSearch(i).customerComments.ToString.ToUpper.Contains(searchCriteria.ToUpper) Then
                    AddElementToArray(arrToReturn, arrToSearch(i)) 'Add the current record to the array of records that we want to return.
                End If
            Next
        Catch ex As Exception
            Debug.Print("Null array passed into function FindRecordsWithSearchCriteria()")
        End Try
        Return arrToReturn 'Return recordsToReturn.
    End Function
#End Region
End Module
