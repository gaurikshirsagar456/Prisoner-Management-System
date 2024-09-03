Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" And TextBox2.Text = "admin123" Then
            MessageBox.Show("LOGIN SUCCESSFULLY...!!!")
            Prison.Show()
            Me.Hide()
        Else
            MessageBox.Show("INVALID USERNAME OR PASSWORD...")
        End If
    End Sub
End Class
