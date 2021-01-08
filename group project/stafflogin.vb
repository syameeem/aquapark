Imports System.Data.OleDb
Public Class stafflogin

    ReadOnly con As New OleDbConnection(My.Settings.DBCustomerConn)

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If staffIDtxt.Text = Nothing Or passwordtxt.Text = Nothing Then
            MessageBox.Show("Please enter crededentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using Command As New OleDbCommand("SELECT COUNT(*) FROM staff WHERE staffID = @staffID AND password = @password", con)
            Command.Parameters.AddWithValue("@staffID", OleDbType.VarChar).Value = staffIDtxt.Text.Trim
            Command.Parameters.AddWithValue("@password", OleDbType.VarChar).Value = passwordtxt.Text.Trim

            Dim count = Convert.ToInt32(Command.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Login found")
                Me.Hide()
                managebooking.Show()
            Else
                MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub


End Class