Public Class formViewSales

    Dim currentlyDisplayedItems() As OrderRecord = LoadOrders() 'Array of all items that are currently being displayed. Note that it mirrors the exact items being displayed.

    Private Sub LoadedFormViewSales() Handles MyBase.Load
        DisplayArrayInSalesListBox(LoadOrders()) 'Display ALL sales in list box.
    End Sub

    Private Sub ChangedFilterCriteria() Handles iptSearch.TextChanged, dateFrom.ValueChanged, dateTo.ValueChanged
        'Check if the from-date is earlier than the to-date
        If dateFrom.Value.Date <= dateTo.Value.Date Then
            currentlyDisplayedItems = FindSalesWithinDateRange(dateFrom.Value.Date, dateTo.Value.Date) 'Filter currentlyDisplayedItems, returning only the sales that are within the specified date range.
            currentlyDisplayedItems = FindRecordsWithSearchCriteria(currentlyDisplayedItems, iptSearch.Text) 'Filter currentlyDisplayedItems, returning the sales that match the previous filter AND contain the search criteria.
            DisplayArrayInSalesListBox(currentlyDisplayedItems) 'Display all filtered sales in a list box.
        Else
            MsgBox("Please ensure that the start date is before the end date.")
            dateFrom.Value = dateTo.Value.Date 'Set from-date to the to-date.
        End If
    End Sub

    Private Sub DisplayArrayInSalesListBox(ByVal arrToDisplay() As OrderRecord)
        lstSales.Items.Clear() 'Clear all items from list box.
        Try
            'Loop through all the elements of the array we want to display.
            For i = 0 To UBound(arrToDisplay)
                'Add item to list box, starting from first item
                lstSales.Items.Add(arrToDisplay(i).orderDate & vbTab & Format(arrToDisplay(i).orderSubtotal, "Currency") & vbTab & arrToDisplay(i).employee)
            Next
            lstSales.Enabled = True
            btnInspectRecord.Enabled = True
            btnSortDate.Enabled = True
            btnSortEmployee.Enabled = True
            btnSortTotal.Enabled = True
        Catch ex As Exception
            'Nothing to display
            lstSales.Items.Add("")
            lstSales.Items.Add("No sales found that match the given criteria") 'Display message in list box for feedback.
            lstSales.Enabled = False
            btnInspectRecord.Enabled = False
            btnSortDate.Enabled = False
            btnSortEmployee.Enabled = False
            btnSortTotal.Enabled = False
        End Try

    End Sub

    Private Sub ClickedButtonBack() Handles btnBack.Click
        formMain.Show() 'Show main form
        Me.Close() 'Close current form
    End Sub

    Private Function FindSalesWithinDateRange(ByVal startDate As Date, ByVal endDate As Date)
        Dim allSales() As OrderRecord = LoadOrders() 'Array of all sales that have ever been made.
        Dim salesToReturn() As OrderRecord = Nothing 'Array of all sales we want to return
        Try
            'Loop through array of all sales.
            For Each sale In allSales
                'Check if the sale date is within the specified date range.
                If sale.orderDate >= startDate And sale.orderDate <= endDate Then
                    AddElementToArray(salesToReturn, sale) 'Add the sale to the salesToReturn array
                End If
            Next
        Catch ex As Exception
            'No sales to loop through
        End Try
        Return salesToReturn 'Return all sales within date range.
    End Function

    Private Sub ClickedButtonInspectRecord() Handles btnInspectRecord.Click
        'Check if an item is selected in the list box.
        If ItemIsSelected() Then
            Dim allOrders() As OrderRecord = LoadOrders() 'Array of all orders
            Dim orderIDToDisplay As Integer = currentlyDisplayedItems(lstSales.SelectedIndex).orderID 'Declare orderIDToDisplay and set to the orderID of the item at the current index of the list box.
            DisplayItemInfo(allOrders(orderIDToDisplay)) 'Display item info in a popup window.
        Else
            MsgBox("Please select an item to inspect")
        End If
    End Sub

    Private Sub DisplayItemInfo(ByVal itemToDisplay As OrderRecord)
        'Print sale data in a popup window.
        MsgBox("Sale info:" & vbCrLf & vbCrLf & "Order ID: " & vbTab & itemToDisplay.orderID & vbCrLf & "Date: " & vbTab & itemToDisplay.orderDate & vbCrLf & "Waiter: " & vbTab & itemToDisplay.employee & vbCrLf & "Subtotal: " & vbTab & Format(itemToDisplay.orderSubtotal, "Currency") & vbCrLf & "Tips:" & vbTab & itemToDisplay.customerComments)
    End Sub

    Private Function ItemIsSelected() 'Check if an item is selected in a listbox.
        If lstSales.SelectedIndex = -1 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ClickedButtonSortByOrderTotal() Handles btnSortTotal.Click
        currentlyDisplayedItems = InsertionSortByOrderTotal(currentlyDisplayedItems) 'Sort current items by order total
        Array.Reverse(currentlyDisplayedItems)
        DisplayArrayInSalesListBox(currentlyDisplayedItems) 'Update list box display
    End Sub

    Private Sub ClickedButtonSortByEmployee() Handles btnSortEmployee.Click
        currentlyDisplayedItems = InsertionSortByEmployee(currentlyDisplayedItems) 'Sort current items by employee
        DisplayArrayInSalesListBox(currentlyDisplayedItems) 'Update list box display
    End Sub

    Private Sub ClickedButtonSortByOrderDate() Handles btnSortDate.Click
        currentlyDisplayedItems = InsertionSortByDate(currentlyDisplayedItems) 'Sort current items by date.
        DisplayArrayInSalesListBox(currentlyDisplayedItems) 'Update list box display
    End Sub

    Private Sub ClickedButtonHelp() Handles btnHelp.Click
        'Display help message
        MsgBox("Enter search criteria in the input box at the top of the screen." & vbCrLf & "Choose a range of dates that you want to inspect, followed by any sorting you want to apply to the data." & vbCrLf & "Click 'Inspect Record' after selecting an item from the list to view more information about it.")
    End Sub
End Class