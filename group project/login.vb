Imports System.Data.OleDb

Public Class login

    ReadOnly con As New OleDbConnection(My.Settings.DBCustomerConn)


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        registration.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If usernametxt.Text = Nothing Or passwordtxt.Text = Nothing Then
            MessageBox.Show("Please enter crededentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using Command As New OleDbCommand("SELECT COUNT(*) FROM customer WHERE username = @username AND password = @password", con)
            Command.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = usernametxt.Text.Trim
            Command.Parameters.AddWithValue("@password", OleDbType.VarChar).Value = passwordtxt.Text.Trim

            Dim count = Convert.ToInt32(Command.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Login found")
                Me.Hide()
                CustomerDB.ShowDialog()
            Else
                MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usernametxt.Clear()
        passwordtxt.Clear()
    End Sub
End Class