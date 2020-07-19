Public Class formPayOrders

    Private currentUnpaidOrders() As OrderRecord 'Array of all items that are currently being displayed in the list box. Note that it mirrors the exact items being displayed.

    Private Sub CLickedButtonBack() Handles btnBack.Click
        formMain.Show() 'Show main form
        Me.Close() 'Close current form
    End Sub

    Private Sub LoadedFormPayForOrders() Handles MyBase.Load
        currentUnpaidOrders = GetCurrentUnpaidOrders() 'Load currentUnpaid orders into the control array
        DisplayArrayInListBox(currentUnpaidOrders) 'Display current unpaid orders in the list box
    End Sub

    Private Function GetCurrentUnpaidOrders()
        Dim allOrders() As OrderRecord = LoadOrders() 'Array of all orders ever made.
        Dim ordersToReturn() As OrderRecord = Nothing 'Array of orders to return
        'Find orders that have been made today and have not been paid for yet
        For i = 0 To UBound(allOrders)
            If allOrders(i).orderDate = Today.Date And allOrders(i).orderPaid = False Then
                AddElementToArray(ordersToReturn, allOrders(i)) 'Add this order to ordersToReturn
            End If
        Next
        Return ordersToReturn 'Return ordersToReturn
    End Function

    Private Sub DisplayArrayInListBox(ByVal arrToDisplay() As OrderRecord)
        lstOrders.Items.Clear() 'Clear all items in list box.
        Try
            For Each item In arrToDisplay
                'Add each order to the list box.
                lstOrders.Items.Add(item.tableNumber & vbTab & item.employee & vbTab & Format(item.orderSubtotal, "Currency"))
            Next
            lstOrders.Enabled = True
            btnSortByTable.Enabled = True
            btnSortByTotal.Enabled = True
            btnConfirmPayment.Enabled = True
        Catch ex As Exception
            'Nothing to display
            lstOrders.Items.Add("")
            lstOrders.Items.Add("No orders from today")
            lstOrders.Items.Add("are still unpaid")
            lstOrders.Enabled = False
            btnSortByTable.Enabled = False
            btnSortByTotal.Enabled = False
            btnConfirmPayment.Enabled = False
        End Try
    End Sub

    Private Sub ClickedButtonSortByTable() Handles btnSortByTable.Click
        currentUnpaidOrders = InsertionSortByTableNumber(currentUnpaidOrders) 'Sorted array of all  unpaid current orders.
        DisplayArrayInListBox(currentUnpaidOrders) 'Display this array in list box.
    End Sub

    Private Sub ClickedButtonSortByOrderTotal() Handles btnSortByTotal.Click
        currentUnpaidOrders = InsertionSortByOrderTotal(currentUnpaidOrders) 'Sorted array of all  unpaid current orders.
        Array.Reverse(currentUnpaidOrders)
        DisplayArrayInListBox(currentUnpaidOrders) 'Display this array in list box.
    End Sub

    Private Sub ClickedButtonConfirmPayment() Handles btnConfirmPayment.Click
        If ItemIsSelected() Then
            'Add any customer comments to the order and mark it as paid.
            Dim orderIDToEdit As Integer = currentUnpaidOrders(lstOrders.SelectedIndex).orderID 'Declare orderIDToEdit and set to the orderID of the currently selected record.
            Dim allOrders() As OrderRecord = LoadOrders() 'Array of all orders ever made.
            allOrders(orderIDToEdit).orderPaid = True 'Change orderPaid flag of the appropriate record to true.

            If Not iptCustomerComments.Text = "" Then
                allOrders(orderIDToEdit).customerComments = iptCustomerComments.Text 'Add any customer comments to the appropriate record.
            End If

            EditOrderRecord(allOrders(orderIDToEdit)) 'Make edits to the order at orderIDToEdit
            currentUnpaidOrders = GetCurrentUnpaidOrders()
            DisplayArrayInListBox(currentUnpaidOrders) 'Display all current unpaid orders in the list box. (Note this removes the order we just edited, as it is now paid for)
            iptCustomerComments.Text = "" 'Reset customer comments
            MsgBox("Order Marked as Paid.")
        Else
            MsgBox("Please select an order to confirm.")
        End If
    End Sub

    Private Function ItemIsSelected() 'Check if an item is selected in the list box.
        If lstOrders.SelectedIndex = -1 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ClickedButtonHelp() Handles btnHelp.Click
        'Display help message.
        MsgBox("All of the orders displayed are unpaid orders from today. Sort by table number or by order total to find the correct order, add any customer comments and mark the order as paid once payment is confirmed.")
    End Sub
End Class