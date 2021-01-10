Public Class registration
    Dim sqlconn As New OleDb.OleDbConnection
    Dim sqlquery As New OleDb.OleDbCommand
    Dim connString As String

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        login.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim strusername As String
        Dim strcustname As String
        Dim strcustic As String
        Dim strcustphone As String
        Dim strcustemail As String
        Dim strpassword As String

        strusername = usernametxt.Text
        strcustname = customerNametxt.Text
        strcustic = customerICtxt.Text
        strcustphone = customerPhonetxt.Text
        strcustemail = customerEmailtxt.Text
        strpassword = passwordtxt.Text


        If strusername = Nothing Or strpassword = Nothing Or strcustname = Nothing Or strcustic = Nothing Or strcustphone = Nothing Or strcustemail = Nothing Or strpassword = Nothing Then
            MessageBox.Show("Please enter empty details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If strcustphone.Length < 10 Then
            MessageBox.Show("Invalid Phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\GitHub\aquapark\DBCustomer.accdb"
        sqlconn.ConnectionString = connString
        sqlquery.Connection = sqlconn
        sqlconn.Open()

        sqlquery.CommandText = "INSERT INTO [customer] ([username], [customerName], [customerIC], [customerPhone], [customerEmail], [password])
                                VALUES(@strusername, @strcustname, @strcustic, @strcustphone, @strcustemail, @strpassword)"

        sqlquery.Parameters.AddWithValue("@strusername", strusername)
        sqlquery.Parameters.AddWithValue("@strcustname", strcustname)
        sqlquery.Parameters.AddWithValue("@strcustic", strcustic)
        sqlquery.Parameters.AddWithValue("@strcustphone", strcustphone)
        sqlquery.Parameters.AddWithValue("@strcustemail", strcustemail)
        sqlquery.Parameters.AddWithValue("@strpassword", strpassword)
        sqlquery.ExecuteNonQuery()
        sqlconn.Close()
        login.Show()
        Me.Hide()
    End Sub

    Private Sub registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usernametxt.Clear()
        customerNametxt.Clear()
        customerICtxt.Clear()
        customerPhonetxt.Clear()
        customerEmailtxt.Clear()
        passwordtxt.Clear()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        usernametxt.Clear()
        customerNametxt.Clear()
        customerICtxt.Clear()
        customerPhonetxt.Clear()
        customerEmailtxt.Clear()
        passwordtxt.Clear()
    End Sub

    Private Sub customerEmailtxt_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customerEmailtxt.Validated
        If customerEmailtxt.Text.Trim() <> "" Then
            Dim emailvl As Boolean = EmailValid(customerEmailtxt.Text.ToString.Trim())
            If emailvl = False Then
                MsgBox("Please, Enter Valid Email")
                customerEmailtxt.Focus()
            End If
        End If
    End Sub

    Public Function EmailValid(ByVal email As String) As Boolean
        ' The regular expression rule
        Dim Expression As New System.Text.RegularExpressions.Regex("\S+@\S+\.\S+")
        ' If the email matches the regular expression
        If Expression.IsMatch(email) Then
            ' MessageBox.Show("The email address is valid.")
            Return True
        Else
            ' MessageBox.Show("The email address is NOT valid.")
            Return False
        End If
    End Function
End Class