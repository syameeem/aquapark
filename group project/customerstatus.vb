Public Class customerstatus
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        registration.Show()
        Me.Hide()
    End Sub

    Private Sub customerstatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class