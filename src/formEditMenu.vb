Public Class formEditMenu

    Private Sub LoadedFormEditMenu() Handles MyBase.Load
        Dim menuItems() As MenuItemRecord = LoadMenuItems() 'Array of all menu items
        'Add all menu items to the list box.
        For Each item As MenuItemRecord In menuItems
            lstMenuItems.Items.Add(item.itemName & vbTab & Format(item.itemPrice, "Currency"))
        Next
    End Sub

    Private Sub ClickedButtonAddMenuItem() Handles btnAddMenuItem.Click
        formAddMenuItem.Show() 'Show formAddMenuItem
        Me.Close() 'Close current form
    End Sub

    Private Sub ClickedButtonEditMenuItem() Handles btnEditMenuItem.Click
        'Check if an item is currently selected
        If ItemIsSelected() Then
            formEditMenuItem.Show() 'Show formEditMenuItem
            formEditMenuItem.GetItemToEditIndex(lstMenuItems.SelectedIndex) 'Pass in the selected index to formEditMenuItem
            Me.Close() 'Close current form
        Else
            MsgBox("Please select an item from the list to edit")
        End If
    End Sub

    Private Sub ClickedButtonDeleteMenuItem() Handles btnDeleteMenuItem.Click
        Dim menuItems() As MenuItemRecord = LoadMenuItems() 'Array of all menu items
        'Check if there are items in the list
        If Not lstMenuItems.Items.Count = 0 Then
            'Check if an item is currently selected
            If ItemIsSelected() Then
                DeleteMenuItem(menuItems(lstMenuItems.SelectedIndex)) 'Delete selected menu item
                lstMenuItems.Items.RemoveAt(lstMenuItems.SelectedIndex) 'Remove item from list box.
            Else
                MsgBox("Please select an item from the list to delete")
            End If
        Else
            MsgBox("Please create a menu item before trying to delete one.")
        End If
    End Sub

    Private Sub ClickedButtonResetMenu() Handles btnResetMenu.Click
        ClearMenuFile() 'Clear menu file
        lstMenuItems.Items.Clear() 'Clear menu items list box.
    End Sub

    Private Function ItemIsSelected() 'Checks if an item is selected in a list box or not.
        If lstMenuItems.SelectedIndex = -1 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ClickedButtonBack() Handles btnBack.Click
        formMain.Show() 'Show main form
        Me.Close() 'Close current form
    End Sub

    Private Sub ClickedButtonHelp() Handles btnHelp.Click
        'Display help message
        MsgBox("Click:" & vbCrLf & "'Add Menu Item' to add an item to the menu." & vbCrLf & "'Edit Menu Item' to edit the price of an existing item" & vbCrLf & "'Delete Menu Item' after selecting an item from the list to remove it from the menu" & vbCrLf & "'Reset Menu' to reset the entire menu")
    End Sub

End Class