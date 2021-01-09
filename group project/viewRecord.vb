Public Class viewRecord
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBCustomerDataSet)

    End Sub

    Private Sub viewRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBCustomerDataSet.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.DBCustomerDataSet.booking)
        'TODO: This line of code loads data into the 'DBCustomerDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.DBCustomerDataSet.customer)
        'TODO: This line of code loads data into the 'DBCustomerDataSet.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.DBCustomerDataSet.booking)
        'TODO: This line of code loads data into the 'DBCustomerDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.DBCustomerDataSet.customer)

    End Sub

    Private Sub CustomerBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBCustomerDataSet)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class