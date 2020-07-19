Public Class formEditMenuItem

    Private itemToEditIndex As Integer = -1 'The index of the item that we want to edit. Set to -1 initially, as no item is selected.

    Public Sub GetItemToEditIndex(ByVal index As Integer)
        itemToEditIndex = index 'Set itemToEdit index to the item index passed in from formEditMenu
        DisplayDataToEdit() 'Display the data that we want to edit.
    End Sub

    Private Sub ClickedButtonConfirmEdit() Handles btnEditItem.Click
        Dim newRecord As MenuItemRecord 'The new record that we will replace the existing one with.
        Dim menuItems() As MenuItemRecord = LoadMenuItems() 'Array of all menu items
        'Check if the item price field is convertible to Single data type.
        If StringIsConvertibleToSingle(iptItemPrice.Text) Then
            'Populate fields of newRecord
            newRecord.itemID = itemToEditIndex
            newRecord.itemName = lblItem.Text
            newRecord.itemPrice = iptItemPrice.Text
            newRecord.isFood = menuItems(itemToEditIndex).isFood
            EditMenuItem(newRecord) 'Override the existing menu item
            formEditMenu.Show() 'Show formEditMenu
            Me.Close() 'Close current form
        Else
            MsgBox("Price field is invalid. Make sure that it only contains numbers.")
        End If
    End Sub


    Private Sub DisplayDataToEdit()
        Dim menuItems() As MenuItemRecord = LoadMenuItems() 'Array of all menu items
        'Display the data that we want to edit
        lblItem.Text = menuItems(itemToEditIndex).itemName
        iptItemPrice.Text = FormatNumber(menuItems(itemToEditIndex).itemPrice, 2)
    End Sub

    Private Sub ClickedButtonBack() Handles btnBack.Click
        formEditMenu.Show() 'Show formEditMenu
        Me.Close() 'Close current form
    End Sub

    Private Sub ClickedButtonHelp() Handles btnHelp.Click
        'Display help message
        MsgBox("Change the price of an existing item. Press 'Confirm Edit Item' when you have finished editing the menu item.")
    End Sub

End Class