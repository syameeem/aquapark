Public Class home
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        stafflogin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        customerstatus.Show()
        Me.Hide()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
