Public Class Database
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBCustomerDataSet)

    End Sub

    Private Sub Database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBCustomerDataSet.package' table. You can move, or remove it, as needed.
        Me.PackageTableAdapter.Fill(Me.DBCustomerDataSet.package)
        'TODO: This line of code loads data into the 'DBCustomerDataSet.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.DBCustomerDataSet.booking)
        'TODO: This line of code loads data into the 'DBCustomerDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.DBCustomerDataSet.customer)

    End Sub
End Class