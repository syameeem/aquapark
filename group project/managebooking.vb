Public Class managebooking
    Private Sub BookingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BookingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BookingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBCustomerDataSet)

    End Sub

    Private Sub managebooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBCustomerDataSet.package' table. You can move, or remove it, as needed.
        Me.PackageTableAdapter.Fill(Me.DBCustomerDataSet.package)
        'TODO: This line of code loads data into the 'DBCustomerDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.DBCustomerDataSet.customer)
        'TODO: This line of code loads data into the 'DBCustomerDataSet.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me.DBCustomerDataSet.booking)

    End Sub


End Class