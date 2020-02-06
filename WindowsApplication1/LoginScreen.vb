Public Class LoginScreen

    Dim LoginList As New List(Of String)
    Dim PasswordList As New List(Of String)
    Dim usernames As New Microsoft.VisualBasic.Collection()
    Dim usernameValidation As Boolean


    Private Sub btnDesktop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesktop.Click
        Me.Hide()
        LogAdmin.Show()

    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim LineOfTextUsernames As String
        Dim i As Integer
        Dim aryTextFileUsernames() As String



        If txtUsername.Text = "Admin Login" And txtPassword.Text = "Admin" Then
            Me.Hide()
            LogAdmin.Show()
        End If




        If (IsNumeric(txtUsername.Text)) = False Then
            LineOfTextUsernames = My.Computer.FileSystem.ReadAllText("C:\Logins.txt")
            aryTextFileUsernames = LineOfTextUsernames.Split(",")
            For i = 0 To UBound(aryTextFileUsernames)
                LoginList.Add(aryTextFileUsernames(i))

            Next i

            Dim LineOfTextPassword As String
            Dim x As Integer
            Dim aryTextFilePassword() As String



            LineOfTextPassword = My.Computer.FileSystem.ReadAllText("C:\Passwords.txt")
            aryTextFilePassword = LineOfTextPassword.Split(",")
            For x = 0 To UBound(aryTextFilePassword)
                PasswordList.Add(aryTextFilePassword(x))

            Next x


            For i = 0 To UBound(aryTextFileUsernames)

                If aryTextFileUsernames(i) <> txtUsername.Text Then
                    MsgBox("Username not found")
                    Return
                End If

                If aryTextFileUsernames(i) = txtUsername.Text Then

                    If aryTextFilePassword(i) = txtPassword.Text Then
                        Me.Hide()
                        PurchasingScreen.Show()
                        Return

                    End If

                    If aryTextFilePassword(i) <> txtPassword.Text Then
                        MsgBox("Incorrect Password")
                        Return
                    End If







                End If
            Next i


        Else
            MsgBox("Invalid username, no numbers as username or password allowed")




        End If










    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub txtUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Click
        txtUsername.Clear()

    End Sub

    Private Sub txtPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Click
        txtPassword.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        txtUsername.Text = ComboBox1.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnOtherTenders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtherTenders.Click
        Me.Hide()
        Generate_Barcode.Show()
    End Sub
End Class
