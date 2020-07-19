Module ArrayUtilities
    Public Sub AddElementToArray(Of T)(ByRef arrToAddTo() As T, ByVal elementToAdd As T)
        Try
            Dim nextID As Integer = UBound(arrToAddTo) + 1 'The next ID of the array that we want to create.
            ReDim Preserve arrToAddTo(nextID) 'Open up new spot in array
            arrToAddTo(nextID) = elementToAdd 'Set value of new spot to the element we want to add
        Catch ex As Exception 'Empty array parameter.
            Dim arrToReturn(0) As T 'Create new array with 1 element
            arrToReturn(0) = elementToAdd 'Set this element to the element we want to add.
            arrToAddTo = arrToReturn 'Set arrToReturn to this new array.
        End Try
    End Sub

    Public Sub RemoveElementFromArray(Of T)(ByRef arrToRemoveFrom() As T, ByVal indexOfElementToRemove As Integer)
        Try
            Dim arrToReturn(UBound(arrToRemoveFrom) - 1) As T 'Create new array with 1 less element than the parameter array.
            'Loop through the array that we want to remove from
            For i = 0 To UBound(arrToRemoveFrom)
                If i < indexOfElementToRemove Then 'If the current index is less than the index of the element we want to remove then
                    arrToReturn(i) = arrToRemoveFrom(i) 'Copy the data from the parameter array to the array that we want to return, keeping the same indices.
                ElseIf i > indexOfElementToRemove Then 'If the current index is greater than the index of the element we want to remove then
                    arrToReturn(i - 1) = arrToRemoveFrom(i) 'Copy the data from the parameter array to the array that we want to return, decreasing the index by 1
                End If
            Next
            arrToRemoveFrom = arrToReturn 'Return the final array
        Catch ex As Exception
            Debug.Print("Index doesn't exist in arrToRemoveFrom")
        End Try
    End Sub

    Public Sub PurgeArray(Of T)(ByRef arrToPurge() As T)
        arrToPurge = Nothing 'Set array to nothing
    End Sub

    'Public Sub PrintItemsInArray(ByVal arrToPrint() As Integer)
    '    Try
    '        Dim printString As String = "" 'The string that we want to print
    '        'Loop through items of the array, and add them to printString
    '        For i = 0 To UBound(arrToPrint)
    '            If i = 0 Then
    '                printString += arrToPrint(i).ToString()
    '            Else
    '                printString += ", " & arrToPrint(i).ToString()
    '            End If
    '        Next
    '        Debug.Print(printString) 'Print printString
    '    Catch ex As Exception
    '        Debug.Print("Empty Array")
    '    End Try

    'End Sub

End Module
