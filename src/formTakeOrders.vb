Public Class formTakeOrders

    Private selectedTableNumber As Integer = 1 'Variable for keeping track of the currently selected table number
    Private orderItemIndexes() As Integer 'Array for keeping track of the MenuItemIDs of all items that have been ordered.

    Private Sub LoadedFormTakeOrders() Handles MyBase.Load
        LoadMenu() 'Load the menu items from the database
    End Sub

    Private Sub ChangedTableNumber(sender As System.Object, e As System.EventArgs) Handles togTable1.CheckedChanged, togTable2.CheckedChanged, togTable3.CheckedChanged, togTable4.CheckedChanged, togTable5.CheckedChanged, togTable6.CheckedChanged, togTable7.CheckedChanged, togTable8.CheckedChanged, togTable9.CheckedChanged, togTable10.CheckedChanged, togTable11.CheckedChanged, togTable12.CheckedChanged, togTable13.CheckedChanged, togTable14.CheckedChanged, togTable15.CheckedChanged, togTable16.CheckedChanged
        'Check if the toggle that was updated is now checked
        If sender.checked = True Then
            selectedTableNumber = sender.tag + 1 'Set selectedTableNumber to the tag of the radio button + 1 (Tags start from 0)
        End If
    End Sub

    Private Sub LoadMenu()
        'Load data from the menu database into the combo boxes.
        Dim menuItems() As MenuItemRecord = LoadMenuItems() 'Array of all the menu items in the database
        For Each item As MenuItemRecord In menuItems
            If item.isFood Then
                comboFood.Items.Add(item.itemName) 'Add the item to the food combo box.
            Else
                comboBeverages.Items.Add(item.itemName) 'Add the item to the beverages combo box.
            End If
        Next
    End Sub

    Private Sub ClickedButtonAddFood() Handles btnAddFood.Click
        If Not comboFood.SelectedIndex = -1 Then 'Check that an item has been selected.
            If StringIsConvertibleToInteger(txtFoodAmount.Text) Then 'Check if the amount given in the text box is an integer. (Avoids errors trying to parse a string that isn't convertible to an integer)
                For i = 0 To Integer.Parse(txtFoodAmount.Text) - 1
                    AddElementToArray(orderItemIndexes, GetMenuItemIndex(comboFood.SelectedItem)) 'Add the selected item to the orderItemIndexes array.
                Next
                UpdateOrderList(orderItemIndexes) 'Update the order list box.
                lblOrderTotalAmount.Text = Format(CalculateOrderSubtotal(orderItemIndexes), "Currency") 'Calculate new order total and update orderTotal label.
            Else
                MsgBox("Please select an amount of the food you want to add.")
            End If
        Else
            MsgBox("Please select the food item that you want to add.")
        End If
    End Sub

    Private Sub ClickedButtonAddBeverage() Handles btnAddBeverage.Click
        If Not comboBeverages.SelectedIndex = -1 Then 'Check that an item has been selected.
            If StringIsConvertibleToInteger(txtBeverageAmount.Text) Then 'Check if the amount given in the text box is an integer. (Avoids errors trying to parse a string that isn't convertible to an integer)
                For i = 0 To Integer.Parse(txtBeverageAmount.Text) - 1
                    AddElementToArray(orderItemIndexes, GetMenuItemIndex(comboBeverages.SelectedItem)) 'Add the selected item to the orderItemIndexes array.
                Next
                UpdateOrderList(orderItemIndexes) 'Update the order list box.
                lblOrderTotalAmount.Text = Format(CalculateOrderSubtotal(orderItemIndexes), "Currency") 'Calculate new order total and update orderTotal label.
            Else
                MsgBox("Please select an amount of the beverage you want to add.")
            End If
        Else
            MsgBox("Please select the beverage that you want to add.")
        End If
    End Sub

    Private Function GetMenuItemIndex(ByVal menuItemName As String) 'Function for traversing all menu items. Takes in the menu item name and returns its unique itemID for reference.
        Dim menuItems() As MenuItemRecord = LoadMenuItems() 'Array of all menu items, loaded from the menu database.
        For Each item As MenuItemRecord In menuItems
            If item.itemName = menuItemName Then 'If input itemName matches the itemName of this specific data item 
                Return item.itemID 'Return the itemID
            End If
        Next
        Debug.Print("Couldn't find menu item " & menuItemName & " in database.") 'Menu item doesn't exist.
        Return Nothing
    End Function

    Private Sub UpdateOrderList(ByVal orderItemIndexes() As Integer)
        Dim menuItems() As MenuItemRecord = LoadMenuItems() 'Array of all menu items, loaded from the menu item database
        'Clear all items in both list boxes.
        lstItems.Items.Clear()
        lstItemsConfirm.Items.Clear()
        Try
            For i = 0 To UBound(orderItemIndexes)
                'Add current item to each list box
                lstItems.Items.Add(menuItems(orderItemIndexes(i)).itemName)
                lstItemsConfirm.Items.Add(menuItems(orderItemIndexes(i)).itemName)
            Next
        Catch ex As Exception
            'No indexes in orderItemIndexes
        End Try
    End Sub

    Private Function CalculateOrderSubtotal(ByVal orderItemIndexes() As Integer)
        Dim menuItems() As MenuItemRecord = LoadMenuItems() 'Array of all menu items, loaded from the menu database.
        Dim subtotal As Single = 0 'Running total of the order.
        Try
            For i = 0 To UBound(orderItemIndexes)
                subtotal = subtotal + menuItems(orderItemIndexes(i)).itemPrice 'Add the current item's price to the subtotal.
            Next
        Catch ex As Exception
            'nothing in the array
        End Try
        Return subtotal 'Return the subtotal
    End Function

    Private Sub ClickedButtonResetList() Handles btnResetList.Click
        lstItems.Items.Clear() 'Clear all items from the list box.
        PurgeArray(orderItemIndexes) 'Remove all elements from the array orderItemIndexes.
        UpdateOrderList(orderItemIndexes) 'Update list boxes.
        lblOrderTotalAmount.Text = Format(CalculateOrderSubtotal(orderItemIndexes), "Currency") 'Update order subtotal
    End Sub

    Private Sub ClickedButtonBack() Handles btnBack.Click
        formMain.Show() 'Show main form
        Me.Close() 'Close current form
    End Sub

    Private Sub ClickedButtonConfirmOrder() Handles btnConfirmOrder.Click
        'If the order subtotal is not $0.00
        If Not CalculateOrderSubtotal(orderItemIndexes) = 0 Then
            AddOrderRecord(Today().Date, selectedTableNumber, CalculateOrderSubtotal(orderItemIndexes), False, formLogin.currentUser, "None") 'Add the order record to the database.
            PrintReceipt() 'Print the receipt with all order details.
            formMain.Show() 'Show main form
            Me.Close() 'Close current form
        Else
            MsgBox("Can't confirm an order that doesn't contain any items")
        End If

    End Sub

    Private Sub PrintReceipt()
        Dim printString As String 'Variable that keeps track of the string to print.
        'Add order data to the printString
        printString = "Order Confirmed." & vbCrLf & vbCrLf & "Table Number: " & selectedTableNumber & vbCrLf & vbCrLf & "Order details:" & vbCrLf
        For Each item In lstItems.Items
            printString += item & vbCrLf
        Next
        printString += vbCrLf & "Order Subtotal:" & vbCrLf & Format(CalculateOrderSubtotal(orderItemIndexes), "Currency")
        MsgBox(printString) 'Display the printString in a messagebox to simulate a receipt.
    End Sub

    Private Sub ClickedButtonHelp() Handles btnHelp.Click
        'Display help message
        MsgBox("Select a table number in the 'Select Table' tab." & vbCrLf & "Add food and beverages to the order in the 'Food/Beverages' tab." & vbCrLf & "Review and confirm the order in the 'Confirm Order' tab.")
    End Sub
End Class