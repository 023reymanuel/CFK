Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Function IsValidUser(username As String, password As String) As Boolean
        ' Implement your actual authentication logic here
        ' For simplicity, using hardcoded values
        Return username = "admin" AndAlso password = "password"
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If IsValidUser(username, password) Then
            ' Login successful, open the main form and hide the login form
            Dim mainForm As New Form2()
            mainForm.Show()
            Me.Hide()
        Else
            ' Invalid credentials, display an error message
            MessageBox.Show("Invalid username or password. Please try again.")
        End If

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
