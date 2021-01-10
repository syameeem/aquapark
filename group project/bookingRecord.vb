Public Class bookingRecord
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        customerRecord.Show()
        Me.Hide()
    End Sub

    Private Sub bookingRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBCustomerDataSet.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.DBCustomerDataSet.booking)
        'TODO: This line of code loads data into the 'DBCustomerDataSet.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.DBCustomerDataSet.booking)
        'TODO: This line of code loads data into the 'DBCustomerDataSet.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.DBCustomerDataSet.booking)

    End Sub
End Class