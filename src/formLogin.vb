Public Class formLogin

    Public currentUser As String 'Public variable for keeping track of the user that is currently logged in.

    Private Sub ClickedButtonSubmit() Handles btnSubmit.Click
        'Check if the username and password fields satisfy all criteria then
        If CheckLogin(iptUsername.Text, iptPassword.Text) = True Then
            currentUser = iptUsername.Text 'Update value of current user
            ClearInputs() 'Clear all inputs
            Me.Hide() 'Hide current form
            formMain.Show() 'Show main form
        Else
            MsgBox("Username or Password incorrect.") 'Display error message
            ClearInputs() 'Clear all inputs
        End If
    End Sub

    Private Function CheckLogin(ByVal inputUsername As String, ByVal inputPassword As String)
        Dim users() As UserRecord = LoadUsers() 'Array of all users
        Try
            'Loop through users and see if username and password match
            For i = 0 To UBound(users)
                If users(i).username = inputUsername And users(i).password = inputPassword Then
                    'Login successful
                    Return True
                End If
            Next
        Catch ex As Exception
            'i.e. There is nothing in the users array
        End Try
        Return False
    End Function

    Private Sub ClearInputs()
        'Reset text boxes
        iptPassword.Text = ""
        iptUsername.Text = ""
    End Sub

    Private Sub ClickedButtonCreateNewLogin() Handles btnCreateLogin.Click
        formNewLogin.Show() 'Show main form
        Me.Hide()   'Hide current form
    End Sub

    Private Sub ClickedButtonQuit() Handles btnQuit.Click
        End 'End program
    End Sub

    Private Sub ClickedButtonHelp() Handles btnHelp.Click
        MsgBox("Login as an existing user or create a new user.") 'Display help message
    End Sub
End Class