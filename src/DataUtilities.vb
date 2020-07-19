Imports System.IO

Module DataUtilities

    Public Structure UserRecord
        Dim userID As Integer 'ID for reference
        Dim username As String 'Username
        Dim password As String 'Password
        Dim manager As Boolean 'Is the user a manager?
    End Structure

    Public Structure MenuItemRecord
        Dim itemID As Integer 'ID for reference
        Dim itemName As String 'Name of the item
        Dim itemPrice As Single 'Price of the item
        Dim isFood As Boolean 'Is the item a food item?
    End Structure

    Public Structure OrderRecord
        Dim orderID As Integer 'ID for reference
        Dim orderDate As Date 'Date that the order was made
        Dim tableNumber As Integer 'Table number for a specific order
        Dim orderSubtotal As Single 'Order subtotal
        Dim orderPaid As Boolean 'Has the order been paid for?
        Dim employee As String 'The employee that entered the order
        Dim customerComments As String 'Additional customer comments.
    End Structure

    Public filePath As String = Application.StartupPath 'The file path of the project

#Region "Users"

    Public Function LoadUsers()
        Dim arrToLoadInto(0) As UserRecord 'The array that we want to load the data into
        Dim nullElementRemoved As Boolean = False 'Has the intial null element been removed yet?
        Dim oRead As System.IO.StreamReader 'For sequentially accessing the contents of text files.
        Dim lineIn As String 'The line read by oRead that is then processed.
        Dim tmp 'Temporary variable for storing data while it is processed and placed into arrToLoadInto.

        oRead = File.OpenText(filePath & "\users.txt") 'Locate text file
        Debug.Print(filePath)

        While oRead.Peek <> -1 'while there are still lines left to read 
            lineIn = oRead.ReadLine() 'Set lineIn to current line
            If Mid(lineIn, 1, 1) <> "" Then 'if there are characters on the line
                tmp = Split(lineIn, "|") 'Split the line, separating the elements by the “|” character
                Dim currentRecord As UserRecord 'The current userRecord that we are analysing
                'Populate fields in currentUser variable
                currentRecord.userID = tmp(0)
                currentRecord.username = tmp(1)
                currentRecord.password = tmp(2)
                currentRecord.manager = tmp(3)
                'Check if the null element has been removed.
                If nullElementRemoved = False Then
                    'i.e. The array still contains its initial null element and this element needs to be overrided
                    arrToLoadInto(0) = currentRecord 'override
                    nullElementRemoved = True
                Else
                    'i.e. The array contains only useful data, add the next useful record on the end
                    AddElementToArray(arrToLoadInto, currentRecord)
                End If
            End If
        End While
        oRead.Close() 'Close text file
        'Check if the null element has been removed
        If nullElementRemoved = True Then
            Return arrToLoadInto
        Else
            'We dont want to return anything
            Debug.Print("Tried to load users from an empty file")
            Return Nothing
        End If
    End Function

    Public Sub AddUserRecord(ByVal username As String, password As String, ByVal manager As Boolean)
        Dim recordToAdd As UserRecord 'The record to add to arrRecords

        'Load data into recordToAdd from parameters. Note that the ID isn't decided on yet, we determine that in the next IF statements.
        recordToAdd.username = username
        recordToAdd.password = password
        recordToAdd.manager = manager

        'Checkif the text file is empty
        If TextFileIsEmpty("users.txt") = True Then
            Dim nextID As Integer = 0 'The next ID of the record we want to add
            recordToAdd.userID = nextID 'Set the ID of the record we want to add to nextID
            Dim arrRecords() As UserRecord = {recordToAdd} 'Array containing the record we want to add
            SaveUserArrayToFile(arrRecords) 'Save new array to file
        Else
            Dim arrRecords() As UserRecord = LoadUsers() 'Create an array of all users, and load data from file into it
            Dim nextID As Integer = UBound(arrRecords) + 1 'The next ID of the record we want to add
            recordToAdd.userID = nextID 'Set the ID of the record we want to add to nextID
            AddElementToArray(arrRecords, recordToAdd) 'Add recordToAdd to the end of array arrRecords
            SaveUserArrayToFile(arrRecords) 'Save new array to file
        End If
    End Sub

    Private Sub SaveUserArrayToFile(ByVal arrToSave() As UserRecord)
        Dim sep As Char = "|" 'The separator character between elements in the text file.
        Dim writeLine As String = "" 'The string to be written to file
        'Loop through the array that we want to save
        For i = 0 To UBound(arrToSave)
            writeLine &= arrToSave(i).userID & sep & arrToSave(i).username & sep & arrToSave(i).password & sep & arrToSave(i).manager & vbCrLf 'Add the current record to writeLine
        Next
        File.WriteAllText(filePath & "\users.txt", writeLine) 'Override text file
    End Sub
#End Region

#Region "Menu"

    Public Function LoadMenuItems()
        Dim arrToLoadInto(0) As MenuItemRecord 'The array we want to load the data into
        Dim nullElementRemoved As Boolean = False 'Has the intial null element been removed yet?
        Dim oRead As System.IO.StreamReader 'For sequentially accessing the contents of text files.
        Dim lineIn As String 'The line read by oRead that is then processed.
        Dim tmp 'Temporary variable for storing data while it is processed and placed into arrToLoadInto.

        oRead = File.OpenText(filePath & "\menu.txt") 'Locate text file

        While oRead.Peek <> -1 'While there are still lines left to read 
            lineIn = oRead.ReadLine() 'Set lineIn to current line
            If Mid(lineIn, 1, 1) <> "" Then 'if there are characters on the line
                tmp = Split(lineIn, "|") 'Split the line, separating the elements by the “|” character
                Dim currentRecord As MenuItemRecord 'The current menu item we are examining
                'Populate fields in currentMenuItem
                currentRecord.itemID = tmp(0)
                currentRecord.itemName = tmp(1)
                currentRecord.itemPrice = tmp(2)
                currentRecord.isFood = tmp(3)
                'Check if the null element has been removed yet
                If nullElementRemoved = False Then
                    'i.e. The array still contains its initial null element and this element needs to be overrided
                    arrToLoadInto(0) = currentRecord 'Override the first item in the array
                    nullElementRemoved = True 'Set nullElementRemoved to True
                Else
                    'i.e. The array contains only useful data, add the next useful record on the end
                    AddElementToArray(arrToLoadInto, currentRecord) 'Add the next useful record to the end of the array.
                End If
            End If
        End While
        oRead.Close() 'Close text file
        'Check if the null element has been romoved.
        If nullElementRemoved = True Then
            Return arrToLoadInto 'Return array of all menu records.
        Else
            'We dont want to return anything
            Debug.Print("Tried to load menu items from an empty file")
            Return Nothing 'Return nothing.
        End If
    End Function

    Public Sub AddMenuItemRecord(ByVal menuItemName As String, ByVal menuItemPrice As Single, ByVal isFood As Boolean)
        Dim recordToAdd As MenuItemRecord 'The record to add to arrRecords

        'Load data into recordToAdd from parameters. Note that the ID isn't decided on yet, we determine that in the next IF statements.
        recordToAdd.itemName = menuItemName
        recordToAdd.itemPrice = menuItemPrice
        recordToAdd.isFood = isFood

        'Check if the text file is empty.
        If TextFileIsEmpty("menu.txt") = True Then
            Dim nextID As Integer = 0 'The ID of the next record we want to create.
            recordToAdd.itemID = nextID 'Set ID of record we want to add to nextID
            Dim arrRecords() As MenuItemRecord = {recordToAdd} 'Declare array of menu item records and set to the value of the record we want to add.
            SaveMenuToFile(arrRecords) 'Save new array to file
        Else
            Dim arrRecords() As MenuItemRecord = LoadMenuItems() 'Create an array of all users, and load data from file into it
            Dim nextID As Integer = UBound(arrRecords) + 1 'The ID of the new record (1 more than the previous ID)
            recordToAdd.itemID = nextID 'Set ID of record we want to add to nextID
            AddElementToArray(arrRecords, recordToAdd) 'Add recordToAdd to the end of array arrRecords
            SaveMenuToFile(arrRecords) 'Save new array to file
        End If
    End Sub

    Private Sub SaveMenuToFile(ByVal arrToSave() As MenuItemRecord)
        Dim sep As Char = "|" 'The separator character between elements in the text file.
        Dim writeLine As String = "" 'The string to be written to file
        'Loop through the array that we want to save
        For i = 0 To UBound(arrToSave)
            writeLine &= arrToSave(i).itemID & sep & arrToSave(i).itemName & sep & arrToSave(i).itemPrice & sep & arrToSave(i).isFood & vbCrLf 'Add the current record to writeLine
        Next
        File.WriteAllText(filePath & "\menu.txt", writeLine) 'Override the text file
    End Sub

    Public Sub DeleteMenuItem(ByVal menuItemToDelete As MenuItemRecord)
        Dim menuItems() As MenuItemRecord = LoadMenuItems() 'Array of all menu items
        RemoveElementFromArray(menuItems, menuItemToDelete.itemID) 'Remove menu item at a specific index.
        For i = 0 To UBound(menuItems) 'Loop through arrMenuItems
            menuItems(i).itemID = i 'Change the itemID field of the current menu item to its current index in the array.
        Next
        SaveMenuToFile(menuItems) 'Save array to file.
    End Sub

    Public Sub EditMenuItem(recordToEdit As MenuItemRecord)
        Dim menuItems() As MenuItemRecord = LoadMenuItems() 'Array of all menuItem records.
        menuItems(recordToEdit.itemID) = recordToEdit 'Override existing record with new record.
        SaveMenuToFile(menuItems) 'Save new array to file.
    End Sub

    Public Sub ClearMenuFile()
        File.WriteAllText(filePath & "\menu.txt", "") 'Delete all text from the text file.
    End Sub

#End Region

#Region "Orders"
    Public Function LoadOrders()
        Dim arrToLoadInto(0) As OrderRecord 'The array we want to load the data into
        Dim nullElementRemoved As Boolean = False 'Has the first null element been removed yet?
        Dim oRead As System.IO.StreamReader 'For sequentially accessing the contents of text files.
        Dim lineIn As String 'The line read by oRead that is then processed.
        Dim tmp 'Temporary variable for storing data while it is processed and placed into arrToLoadInto.

        oRead = File.OpenText(filePath & "\sales.txt") 'Locate text file

        While oRead.Peek <> -1 'while there are still lines left to read 
            lineIn = oRead.ReadLine() 'Set lineIn to current line
            If Mid(lineIn, 1, 1) <> "" Then 'if there are characters on the line
                tmp = Split(lineIn, "|") 'Split the line, separating the elements by the “|” character
                Dim currentRecord As OrderRecord 'The current orderRecord that we are examining
                'Populate fields in currentOrder
                currentRecord.orderID = tmp(0)
                currentRecord.orderDate = tmp(1)
                currentRecord.tableNumber = tmp(2)
                currentRecord.orderSubtotal = tmp(3)
                currentRecord.orderPaid = tmp(4)
                currentRecord.employee = tmp(5)
                currentRecord.customerComments = tmp(6)
                'Check if the null element has been removed or not.
                If nullElementRemoved = False Then
                    'i.e. The array still contains its initial null element and this element needs to be overrided
                    arrToLoadInto(0) = currentRecord 'Override the null element with the currentOrder we just loaded
                    nullElementRemoved = True 'Set nullElementRemoved to true
                Else
                    'i.e. The array contains only useful data, add the next useful record on the end
                    AddElementToArray(arrToLoadInto, currentRecord) 'Add currentOrder to the end of arrToLoadInto
                End If
            End If
        End While
        oRead.Close() 'Close text file
        'Check if null element has been removed
        If nullElementRemoved = True Then
            Return arrToLoadInto 'Return array of all orders
        Else
            Debug.Print("Tried to load order records from an empty file") 'File was empty
            Return Nothing 'Return Nothing
        End If
    End Function

    Public Sub AddOrderRecord(ByVal orderDate As Date, ByVal tableNumber As Integer, ByVal orderSubtotal As Single, ByVal orderPaid As Boolean, ByVal employee As String, ByVal customerComments As String)
        Dim recordToAdd As OrderRecord 'The record to add to arrRecords

        'Load data into recordToAdd from parameters. Note that the ID isn't decided on yet, we determine that in the following IF statements.
        recordToAdd.orderDate = orderDate
        recordToAdd.tableNumber = tableNumber
        recordToAdd.orderSubtotal = orderSubtotal
        recordToAdd.orderPaid = orderPaid
        recordToAdd.employee = employee
        recordToAdd.customerComments = customerComments

        'Check if text file is empty
        If TextFileIsEmpty("sales.txt") = True Then
            Dim nextID As Integer = 0 'The ID of the next record we are going to add.
            recordToAdd.orderID = nextID 'Set the orderID of recordToAdd to nextID.
            Dim arrRecords() As OrderRecord = {recordToAdd} 'Declare array of orderRecords and set to the value of the record we want to add.
            SaveOrderToFile(arrRecords) 'Save new array to file
        Else
            Dim arrRecords() As OrderRecord = LoadOrders() 'Create an array of all orders, and load data from file into it
            Dim nextID As Integer = UBound(arrRecords) + 1 'The ID of the new record (1 more than the previous ID)
            recordToAdd.orderID = nextID 'Set the orderID of recordToAdd to nextID.
            AddElementToArray(arrRecords, recordToAdd) 'Add recordToAdd to the end of array arrRecords
            SaveOrderToFile(arrRecords) 'Save new array to file
        End If
    End Sub

    Private Sub SaveOrderToFile(ByVal arrToSave() As OrderRecord)
        Dim sep As Char = "|" 'The separator character between elements in the text file.
        Dim writeLine As String = "" 'The string to be written to file
        'Loop through the array that we want to save.
        For i = 0 To UBound(arrToSave)
            writeLine &= arrToSave(i).orderID & sep & arrToSave(i).orderDate & sep & arrToSave(i).tableNumber & sep & arrToSave(i).orderSubtotal & sep & arrToSave(i).orderPaid & sep & arrToSave(i).employee & sep & arrToSave(i).customerComments & vbCrLf 'Add the current record to writeLine
        Next
        File.WriteAllText(filePath & "\sales.txt", writeLine) 'Override the text file
    End Sub

    Public Sub EditOrderRecord(recordToEdit As OrderRecord)
        Dim allOrders() As OrderRecord = LoadOrders() 'Array of all order records.
        allOrders(recordToEdit.orderID) = recordToEdit 'Override existing record with new record.
        SaveOrderToFile(allOrders) 'Save new array to file
    End Sub
#End Region

#Region "General"
    Private Function TextFileIsEmpty(ByVal fileName As String)
        Try
            'Check if there is no text in the text file
            If File.ReadAllText(filePath & "\" & fileName) = "" Then
                Debug.Print(fileName & " is empty")
                Return True 'Return true
            Else
                Debug.Print(fileName & " contains stuff")
                Return False 'Return False
            End If
        Catch ex As Exception
            Debug.Fail("Tried to read data from a file " & fileName & ", which doesn't exist.")
            Return Nothing 'Return Nothing, as the text file doesn't exist.
        End Try
    End Function
#End Region
    
End Module
