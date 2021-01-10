Public Class bookingRecord
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
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

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        customerRecord.Show()
        Me.Hide()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        dlgFont.ShowDialog()
        Label1.Font = dlgFont.Font
        btnExit.Font = dlgFont.Font
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        dlgColor.ShowDialog()
        Label1.ForeColor = dlgColor.Color
        btnExit.ForeColor = dlgColor.Color
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("View and check all the customer's booking information.", MsgBoxStyle.Information, "Booking Record")
    End Sub

End Class