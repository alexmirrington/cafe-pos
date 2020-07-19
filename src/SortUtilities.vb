Module SortUtilities

#Region "BasicSorts"

    'Public Function BubbleSortAscending(ByRef arrToSort() As Integer)
    '    Debug.Print("Bubble Sort")
    '    Dim firstIndex As Integer = 0 'the starting index of the array
    '    Dim lastIndex As Integer = UBound(arrToSort) 'the last index of the array
    '    Dim currentIndex As Integer = firstIndex 'Placeholder index

    '    While lastIndex > firstIndex
    '        currentIndex = firstIndex
    '        While currentIndex < lastIndex
    '            If arrToSort(currentIndex) > arrToSort(currentIndex + 1) Then
    '                'Perform Swap
    '                Dim temp As Integer = arrToSort(currentIndex)
    '                arrToSort(currentIndex) = arrToSort(currentIndex + 1)
    '                arrToSort(currentIndex + 1) = temp
    '            End If
    '            currentIndex = currentIndex + 1 'Increment current index to swap next pair
    '        End While
    '        lastIndex = lastIndex - 1 'Make sure that we perform 1 less swap each pass for optimisation
    '        PrintItemsInArray(arrToSort)
    '    End While

    '    Return arrToSort
    'End Function

    'Public Function InsertionSortAscending(ByRef arrToSort() As Integer)
    '    Debug.Print("Insertion Sort")
    '    Dim firstIndex As Integer = 0 'the starting index of the array
    '    Dim lastIndex As Integer = UBound(arrToSort) 'the last index of the array
    '    Dim indexToSort As Integer = firstIndex + 1 'The index of the array that we are trying to insert into the correct position. Note we start from 1 more than the start index as we are going to assume that the first element is already sorted
    '    Dim currentIndexOfLoop As Integer = firstIndex

    '    While indexToSort <= lastIndex
    '        'i.e. while the array isnt sorted yet
    '        While currentIndexOfLoop < indexToSort
    '            If arrToSort(indexToSort) >= arrToSort(currentIndexOfLoop) Then
    '                'increase currentIndexOfLoop
    '                currentIndexOfLoop = currentIndexOfLoop + 1
    '            Else
    '                'we want to insert arrToSort(indexToSort) into the array at the index currentIndexOfLoop
    '                Dim temp As Integer = arrToSort(indexToSort) 'Bring the element to be sorted into a temporary spot while we shift all previous items up into the spot
    '                For i = indexToSort To currentIndexOfLoop + 1 Step -1
    '                    arrToSort(i) = arrToSort(i - 1) 'Shift elements up through array
    '                Next
    '                arrToSort(currentIndexOfLoop) = temp
    '            End If
    '        End While
    '        currentIndexOfLoop = firstIndex
    '        indexToSort = indexToSort + 1
    '        PrintItemsInArray(arrToSort)
    '    End While

    '    Return arrToSort
    'End Function

    'Public Function SelectionSortAscending(ByRef arrToSort() As Integer)
    '    Debug.Print("Selection Sort")
    '    Dim firstIndex As Integer = 0
    '    Dim lastIndex As Integer = UBound(arrToSort)
    '    Dim endUnsortedIndex As Integer = firstIndex
    '    Dim currentIndex As Integer = firstIndex
    '    Dim minItemIndex As Integer = firstIndex

    '    While endUnsortedIndex < lastIndex
    '        'i.e. while the whole array isnt sorted yet
    '        currentIndex = endUnsortedIndex
    '        minItemIndex = currentIndex

    '        While currentIndex < lastIndex
    '            'i.e. loop through the array starting from minItemIndex, and find the next minimum value
    '            currentIndex = currentIndex + 1 'Increment before looping, we already have minItemIndex = currentIndex, so we dont need to check the first one
    '            If arrToSort(currentIndex) < arrToSort(minItemIndex) Then
    '                minItemIndex = currentIndex
    '            End If
    '        End While

    '        'Perform Swap
    '        Dim temp As Integer = arrToSort(minItemIndex)
    '        arrToSort(minItemIndex) = arrToSort(endUnsortedIndex)
    '        arrToSort(endUnsortedIndex) = temp
    '        endUnsortedIndex = endUnsortedIndex + 1

    '        'Display array at end of each pass
    '        PrintItemsInArray(arrToSort)

    '    End While

    '    Return arrToSort

    'End Function

#End Region
    
#Region "OrderRecordSorts"
    Public Function InsertionSortByOrderTotal(ByRef arrToSort() As OrderRecord)
        Dim firstIndex As Integer = 0 'The starting index of the array
        Dim lastIndex As Integer = UBound(arrToSort) 'The last index of the array
        Dim indexToSort As Integer = firstIndex + 1 'The index of the array that we are trying to insert into the correct position. Note we start from 1 more than the start index as we are going to assume that the first element is already sorted
        Dim currentIndexOfLoop As Integer = firstIndex 'The current index of the inner loop, for keeping track of which item we are currently comparing to the item we are sorting.

        'While the array isnt sorted yet
        While indexToSort <= lastIndex
            'Loop through array, starting from the beginning of the array until the index that we want to sort.
            While currentIndexOfLoop < indexToSort
                'Check if the orderSubtotal at the index that we want to sort is greater than or equal to the orderSubtotal at currentIndexOfLoop
                If arrToSort(indexToSort).orderSubtotal >= arrToSort(currentIndexOfLoop).orderSubtotal Then
                    currentIndexOfLoop = currentIndexOfLoop + 1 'Increase currentIndexOfLoop
                Else
                    'we want to insert arrToSort(indexToSort) into the array at the index currentIndexOfLoop
                    Dim temp As OrderRecord = arrToSort(indexToSort) 'Bring the element to be sorted into a temporary spot while we shift all previous items up into the spot
                    'Loop through items in reverse order, starting from the index that we want to sort.
                    For i = indexToSort To currentIndexOfLoop + 1 Step -1
                        arrToSort(i) = arrToSort(i - 1) 'Shift elements up through array
                    Next
                    arrToSort(currentIndexOfLoop) = temp 'Insert arrToSort(indexToSort) into the array at the index currentIndexOfLoop
                End If
            End While
            currentIndexOfLoop = firstIndex 'Reset currentINdexOfLoop to the first index of the array.
            indexToSort = indexToSort + 1 'Increment indexToSort by 1
        End While

        Return arrToSort 'Return sorted array
    End Function

    Public Function InsertionSortByTableNumber(ByRef arrToSort() As OrderRecord)
        Dim firstIndex As Integer = 0 'The starting index of the array
        Dim lastIndex As Integer = UBound(arrToSort) 'The last index of the array
        Dim indexToSort As Integer = firstIndex + 1 'The index of the array that we are trying to insert into the correct position. Note we start from 1 more than the start index as we are going to assume that the first element is already sorted
        Dim currentIndexOfLoop As Integer = firstIndex 'The current index of the inner loop, for keeping track of which item we are currently comparing to the item we are sorting.

        'While the array isnt sorted yet
        While indexToSort <= lastIndex
            'Loop through array, starting from the beginning of the array until the index that we want to sort.
            While currentIndexOfLoop < indexToSort
                'Check if the tableNumber at the index that we want to sort is greater than or equal to the tableNumber at currentIndexOfLoop
                If arrToSort(indexToSort).tableNumber >= arrToSort(currentIndexOfLoop).tableNumber Then
                    currentIndexOfLoop = currentIndexOfLoop + 1 'Increase currentIndexOfLoop
                Else
                    'we want to insert arrToSort(indexToSort) into the array at the index currentIndexOfLoop
                    Dim temp As OrderRecord = arrToSort(indexToSort) 'Bring the element to be sorted into a temporary spot while we shift all previous items up into the spot
                    'Loop through items in reverse order, starting from the index that we want to sort.
                    For i = indexToSort To currentIndexOfLoop + 1 Step -1
                        arrToSort(i) = arrToSort(i - 1) 'Shift elements up through array
                    Next
                    arrToSort(currentIndexOfLoop) = temp 'Insert arrToSort(indexToSort) into the array at the index currentIndexOfLoop
                End If
            End While
            currentIndexOfLoop = firstIndex 'Reset currentINdexOfLoop to the first index of the array.
            indexToSort = indexToSort + 1 'Increment indexToSort by 1
        End While

        Return arrToSort
    End Function

    Public Function InsertionSortByEmployee(ByRef arrToSort() As OrderRecord)
        Dim firstIndex As Integer = 0 'The starting index of the array
        Dim lastIndex As Integer = UBound(arrToSort) 'The last index of the array
        Dim indexToSort As Integer = firstIndex + 1 'The index of the array that we are trying to insert into the correct position. Note we start from 1 more than the start index as we are going to assume that the first element is already sorted
        Dim currentIndexOfLoop As Integer = firstIndex 'The current index of the inner loop, for keeping track of which item we are currently comparing to the item we are sorting.

        'While the array isnt sorted yet
        While indexToSort <= lastIndex
            'Loop through array, starting from the beginning of the array until the index that we want to sort.
            While currentIndexOfLoop < indexToSort
                'Check if the employee at the index that we want to sort is further in the alphabet than the employee at currentIndexOfLoop
                If arrToSort(indexToSort).employee >= arrToSort(currentIndexOfLoop).employee Then
                    currentIndexOfLoop = currentIndexOfLoop + 1 'Increase currentIndexOfLoop
                Else
                    'we want to insert arrToSort(indexToSort) into the array at the index currentIndexOfLoop
                    Dim temp As OrderRecord = arrToSort(indexToSort) 'Bring the element to be sorted into a temporary spot while we shift all previous items up into the spot
                    'Loop through items in reverse order, starting from the index that we want to sort.
                    For i = indexToSort To currentIndexOfLoop + 1 Step -1
                        arrToSort(i) = arrToSort(i - 1) 'Shift elements up through array
                    Next
                    arrToSort(currentIndexOfLoop) = temp 'Insert arrToSort(indexToSort) into the array at the index currentIndexOfLoop
                End If
            End While
            currentIndexOfLoop = firstIndex 'Reset currentINdexOfLoop to the first index of the array.
            indexToSort = indexToSort + 1 'Increment indexToSort by 1
        End While

        Return arrToSort
    End Function

    Public Function InsertionSortByDate(ByRef arrToSort() As OrderRecord)
        Dim firstIndex As Integer = 0 'The starting index of the array
        Dim lastIndex As Integer = UBound(arrToSort) 'The last index of the array
        Dim indexToSort As Integer = firstIndex + 1 'The index of the array that we are trying to insert into the correct position. Note we start from 1 more than the start index as we are going to assume that the first element is already sorted
        Dim currentIndexOfLoop As Integer = firstIndex 'The current index of the inner loop, for keeping track of which item we are currently comparing to the item we are sorting.

        'While the array isnt sorted yet
        While indexToSort <= lastIndex
            'Loop through array, starting from the beginning of the array until the index that we want to sort.
            While currentIndexOfLoop < indexToSort
                'Check if the orderDate at the index that we want to sort is greater than or equal to the orderDate at currentIndexOfLoop
                If arrToSort(indexToSort).orderDate >= arrToSort(currentIndexOfLoop).orderDate Then
                    currentIndexOfLoop = currentIndexOfLoop + 1 'Increase currentIndexOfLoop
                Else
                    'we want to insert arrToSort(indexToSort) into the array at the index currentIndexOfLoop
                    Dim temp As OrderRecord = arrToSort(indexToSort) 'Bring the element to be sorted into a temporary spot while we shift all previous items up into the spot
                    'Loop through items in reverse order, starting from the index that we want to sort.
                    For i = indexToSort To currentIndexOfLoop + 1 Step -1
                        arrToSort(i) = arrToSort(i - 1) 'Shift elements up through array
                    Next
                    arrToSort(currentIndexOfLoop) = temp 'Insert arrToSort(indexToSort) into the array at the index currentIndexOfLoop
                End If
            End While
            currentIndexOfLoop = firstIndex 'Reset currentINdexOfLoop to the first index of the array.
            indexToSort = indexToSort + 1 'Increment indexToSort by 1
        End While

        Return arrToSort
    End Function
#End Region

End Module
