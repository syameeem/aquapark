Public Class customerRecord
    Private Sub bookingrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBCustomerDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.DBCustomerDataSet.customer)
        'TODO: This line of code loads data into the 'DBCustomerDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.DBCustomerDataSet.customer)
        'TODO: This line of code loads data into the 'DBCustomerDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.DBCustomerDataSet.customer)


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        bookingRecord.Show()
        Me.Hide()
    End Sub
End Class