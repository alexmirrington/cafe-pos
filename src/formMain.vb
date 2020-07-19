Public Class formMain

    Private Sub LoadedMainForm() Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & formLogin.currentUser 'Update welcome text
        'Check if the user is a manager or not
        If Not IsManager(formLogin.currentUser) Then
            'Move buttons around and make some buttons invisible to remove functionality if the user isn't a manager
            btnSwitchUser.Location = New Point(btnChangeMenu.Location.X, btnChangeMenu.Location.Y)
            btnQuit.Location = New Point(btnViewSales.Location.X, btnViewSales.Location.Y)
            btnViewSales.Visible = False
            btnChangeMenu.Visible = False
        End If
    End Sub

#Region "MainMenuButtons"

    Private Sub ClickedButtonTakeOrders() Handles btnTakeOrders.Click
        formTakeOrders.Show() 'Show formTakeOrders
        Me.Close() 'Close current form
    End Sub

    Private Sub ClickedButtonPayForOrders() Handles btnPayForOrders.Click
        formPayOrders.Show() 'Show formPayOrders
        Me.Close() 'Close current form
    End Sub

    Private Sub ClickedButtonChangeMenu() Handles btnChangeMenu.Click
        formEditMenu.Show() 'Show formEditMenu
        Me.Close() 'Close current form
    End Sub

    Private Sub ClickeButtonViewSales() Handles btnViewSales.Click
        formViewSales.Show() 'Show formViewSales
        Me.Close() 'Close current form
    End Sub

    Private Sub ClickedButtonSwitchUser() Handles btnSwitchUser.Click
        formLogin.Show() 'Show login form
        Me.Close() 'Close current form
    End Sub

    Private Sub ClickedButtonQuit() Handles btnQuit.Click
        End 'End Program
    End Sub

    Private Sub ClickedButtonHelp() Handles btnHelp.Click
        'Display help message
        MsgBox("Click:" & vbCrLf & "'Take Orders' to wait on customers." & vbCrLf & "'Pay for Orders' to confirm payment as the customer leaves" & vbCrLf & "'Switch User' to log in as someone else" & vbCrLf & "'Quit' to stop using the application" & vbCrLf & vbCrLf & "If you are a manager, you are also able to click:" & vbCrLf & "'Change Menu' to add, edit and delete menu items" & vbCrLf & "'View Sales' to view and search all previous sales")
    End Sub

#End Region
 
End Class