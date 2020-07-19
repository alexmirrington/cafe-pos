Public Class formNewLogin
    Const maxUserLength As Integer = 8

    Private Sub ClickedButtonCreateUser() Handles btnCreateUser.Click
        'Check if username and password have been given yet
        If Not iptUsername.Text = "" And Not iptPassword.Text = "" Then
            'Make sure username length is less than maxUserLength
            If iptUsername.Text.Length < maxUserLength Then
                'Check the given passwords match
                If iptPassword.Text = iptConfirmPassword.Text Then
                    If Not UserAlreadyExists(iptUsername.Text) Then
                        'New user creation successful
                        AddUserRecord(iptUsername.Text, iptPassword.Text, togManager.Checked) 'Add a new user
                        MsgBox("New user created successfully")
                        formLogin.currentUser = iptUsername.Text 'Update value of currentUser
                        formMain.Show() 'Show main form
                        Me.Close() 'Close current form
                    Else
                        MsgBox("User already exists in database. Please choose a new username.")
                    End If
                Else
                    MsgBox("Passwords don't match.")
                End If
            Else
                MsgBox("Please choose a username that is less than " & maxUserLength & " characters long")
            End If
        Else
            MsgBox("Please insert a username and password")
        End If

    End Sub

    Private Function UserAlreadyExists(ByVal userToSearch As String)
        Dim users() As UserRecord = LoadUsers() 'Array of all user records
        Try
            'Extract usernames from the userRecord array
            Dim usernames(UBound(users)) As String
            For i = 0 To UBound(users)
                usernames(i) = users(i).username
            Next

            'Check if the username already exists
            If ItemExistsInArray(usernames, userToSearch) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            'i.e. There is nothing in the users array
            Return False
        End Try
    End Function

    Private Sub ClickedButtonBack() Handles btnBack.Click
        formLogin.Show() 'Show login form
        Me.Close() 'Close current form
    End Sub

    Private Sub ClickedButtonHelp() Handles btnHelp.Click
        'Display help message
        MsgBox("Select a username and a password for your account. Repeat your password to make sure it is correct, and then select either an employee or a manager account. You will be taken to the main screen after your account is successfully created.")
    End Sub
End Class
