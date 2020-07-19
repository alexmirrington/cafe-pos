Public Class formAddMenuItem

    Private Sub ClickedButtonConfirmAdd() Handles btnAddItem.Click
        'Check if there is an item name in the input box.
        If Not iptItemName.Text = "" Then
            'Check if the price value is convertible to a single data type.
            If StringIsConvertibleToSingle(iptItemPrice.Text) Then
                Dim itemPrice As Single = FormatNumber(iptItemPrice.Text, 2) 'Price of the item, to 2 d.p.
                AddMenuItemRecord(iptItemName.Text, itemPrice, togFood.Checked) 'Add menu item to database.
                MsgBox("New menu item added.")
                'Reset input boxes
                iptItemName.Text = ""
                iptItemPrice.Text = ""
            Else
                MsgBox("Price field is invalid. Make sure that it only contains numbers.")
            End If
        Else
            MsgBox("Please insert an item name.")
        End If
    End Sub

    Private Sub ClickedButtonBack() Handles btnBack.Click
        formEditMenu.Show() 'Show formEditMenu
        Me.Close() 'Close current form
    End Sub

    Private Sub ClickedButtonHelp() Handles btnHelp.Click
        'Display help message
        MsgBox("Choose an item name (A short but recognisable name is best) and a price, and select whether it is a food or a beverage. Press 'Add Item' when finished.")
    End Sub
End Class