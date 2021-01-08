<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Database
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Database))
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Dim CustomerICLabel As System.Windows.Forms.Label
        Dim CustomerPhoneLabel As System.Windows.Forms.Label
        Dim CustomerEmailLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim BookingIDLabel As System.Windows.Forms.Label
        Dim AdultAmountLabel As System.Windows.Forms.Label
        Dim ChildAmountLabel As System.Windows.Forms.Label
        Dim TotalPaymentLabel As System.Windows.Forms.Label
        Dim BookDateLabel As System.Windows.Forms.Label
        Dim PackageIDLabel As System.Windows.Forms.Label
        Dim PackageNameLabel As System.Windows.Forms.Label
        Me.DBCustomerDataSet = New group_project.DBCustomerDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New group_project.DBCustomerDataSetTableAdapters.customerTableAdapter()
        Me.TableAdapterManager = New group_project.DBCustomerDataSetTableAdapters.TableAdapterManager()
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerICTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerEmailTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableAdapter = New group_project.DBCustomerDataSetTableAdapters.bookingTableAdapter()
        Me.BookingIDTextBox = New System.Windows.Forms.TextBox()
        Me.AdultAmountTextBox = New System.Windows.Forms.TextBox()
        Me.ChildAmountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.BookDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PackageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PackageTableAdapter = New group_project.DBCustomerDataSetTableAdapters.packageTableAdapter()
        Me.PackageIDTextBox = New System.Windows.Forms.TextBox()
        Me.PackageNameTextBox = New System.Windows.Forms.TextBox()
        UsernameLabel = New System.Windows.Forms.Label()
        CustomerNameLabel = New System.Windows.Forms.Label()
        CustomerICLabel = New System.Windows.Forms.Label()
        CustomerPhoneLabel = New System.Windows.Forms.Label()
        CustomerEmailLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        BookingIDLabel = New System.Windows.Forms.Label()
        AdultAmountLabel = New System.Windows.Forms.Label()
        ChildAmountLabel = New System.Windows.Forms.Label()
        TotalPaymentLabel = New System.Windows.Forms.Label()
        BookDateLabel = New System.Windows.Forms.Label()
        PackageIDLabel = New System.Windows.Forms.Label()
        PackageNameLabel = New System.Windows.Forms.Label()
        CType(Me.DBCustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBCustomerDataSet
        '
        Me.DBCustomerDataSet.DataSetName = "DBCustomerDataSet"
        Me.DBCustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.DBCustomerDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bookingTableAdapter = Me.BookingTableAdapter
        Me.TableAdapterManager.customerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.packageTableAdapter = Me.PackageTableAdapter
        Me.TableAdapterManager.UpdateOrder = group_project.DBCustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerBindingNavigatorSaveItem})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(852, 25)
        Me.CustomerBindingNavigator.TabIndex = 0
        Me.CustomerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(48, 54)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 1
        UsernameLabel.Text = "username:"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(110, 51)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 2
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Location = New System.Drawing.Point(20, 89)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(84, 13)
        CustomerNameLabel.TabIndex = 3
        CustomerNameLabel.Text = "customer Name:"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerName", True))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(110, 86)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerNameTextBox.TabIndex = 4
        '
        'CustomerICLabel
        '
        CustomerICLabel.AutoSize = True
        CustomerICLabel.Location = New System.Drawing.Point(38, 122)
        CustomerICLabel.Name = "CustomerICLabel"
        CustomerICLabel.Size = New System.Drawing.Size(66, 13)
        CustomerICLabel.TabIndex = 5
        CustomerICLabel.Text = "customer IC:"
        '
        'CustomerICTextBox
        '
        Me.CustomerICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerIC", True))
        Me.CustomerICTextBox.Location = New System.Drawing.Point(110, 119)
        Me.CustomerICTextBox.Name = "CustomerICTextBox"
        Me.CustomerICTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerICTextBox.TabIndex = 6
        '
        'CustomerPhoneLabel
        '
        CustomerPhoneLabel.AutoSize = True
        CustomerPhoneLabel.Location = New System.Drawing.Point(20, 159)
        CustomerPhoneLabel.Name = "CustomerPhoneLabel"
        CustomerPhoneLabel.Size = New System.Drawing.Size(87, 13)
        CustomerPhoneLabel.TabIndex = 7
        CustomerPhoneLabel.Text = "customer Phone:"
        '
        'CustomerPhoneTextBox
        '
        Me.CustomerPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerPhone", True))
        Me.CustomerPhoneTextBox.Location = New System.Drawing.Point(113, 156)
        Me.CustomerPhoneTextBox.Name = "CustomerPhoneTextBox"
        Me.CustomerPhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerPhoneTextBox.TabIndex = 8
        '
        'CustomerEmailLabel
        '
        CustomerEmailLabel.AutoSize = True
        CustomerEmailLabel.Location = New System.Drawing.Point(26, 194)
        CustomerEmailLabel.Name = "CustomerEmailLabel"
        CustomerEmailLabel.Size = New System.Drawing.Size(81, 13)
        CustomerEmailLabel.TabIndex = 9
        CustomerEmailLabel.Text = "customer Email:"
        '
        'CustomerEmailTextBox
        '
        Me.CustomerEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerEmail", True))
        Me.CustomerEmailTextBox.Location = New System.Drawing.Point(113, 191)
        Me.CustomerEmailTextBox.Name = "CustomerEmailTextBox"
        Me.CustomerEmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerEmailTextBox.TabIndex = 10
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(52, 233)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 11
        PasswordLabel.Text = "password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(113, 230)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 12
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "customerbooking"
        Me.BookingBindingSource.DataSource = Me.CustomerBindingSource
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'BookingIDLabel
        '
        BookingIDLabel.AutoSize = True
        BookingIDLabel.Location = New System.Drawing.Point(257, 54)
        BookingIDLabel.Name = "BookingIDLabel"
        BookingIDLabel.Size = New System.Drawing.Size(62, 13)
        BookingIDLabel.TabIndex = 13
        BookingIDLabel.Text = "booking ID:"
        '
        'BookingIDTextBox
        '
        Me.BookingIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "bookingID", True))
        Me.BookingIDTextBox.Location = New System.Drawing.Point(325, 51)
        Me.BookingIDTextBox.Name = "BookingIDTextBox"
        Me.BookingIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BookingIDTextBox.TabIndex = 14
        '
        'AdultAmountLabel
        '
        AdultAmountLabel.AutoSize = True
        AdultAmountLabel.Location = New System.Drawing.Point(247, 86)
        AdultAmountLabel.Name = "AdultAmountLabel"
        AdultAmountLabel.Size = New System.Drawing.Size(72, 13)
        AdultAmountLabel.TabIndex = 15
        AdultAmountLabel.Text = "adult Amount:"
        '
        'AdultAmountTextBox
        '
        Me.AdultAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "adultAmount", True))
        Me.AdultAmountTextBox.Location = New System.Drawing.Point(325, 83)
        Me.AdultAmountTextBox.Name = "AdultAmountTextBox"
        Me.AdultAmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdultAmountTextBox.TabIndex = 16
        '
        'ChildAmountLabel
        '
        ChildAmountLabel.AutoSize = True
        ChildAmountLabel.Location = New System.Drawing.Point(248, 119)
        ChildAmountLabel.Name = "ChildAmountLabel"
        ChildAmountLabel.Size = New System.Drawing.Size(71, 13)
        ChildAmountLabel.TabIndex = 17
        ChildAmountLabel.Text = "child Amount:"
        '
        'ChildAmountTextBox
        '
        Me.ChildAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "childAmount", True))
        Me.ChildAmountTextBox.Location = New System.Drawing.Point(325, 116)
        Me.ChildAmountTextBox.Name = "ChildAmountTextBox"
        Me.ChildAmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ChildAmountTextBox.TabIndex = 18
        '
        'TotalPaymentLabel
        '
        TotalPaymentLabel.AutoSize = True
        TotalPaymentLabel.Location = New System.Drawing.Point(245, 156)
        TotalPaymentLabel.Name = "TotalPaymentLabel"
        TotalPaymentLabel.Size = New System.Drawing.Size(74, 13)
        TotalPaymentLabel.TabIndex = 19
        TotalPaymentLabel.Text = "total Payment:"
        '
        'TotalPaymentTextBox
        '
        Me.TotalPaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "totalPayment", True))
        Me.TotalPaymentTextBox.Location = New System.Drawing.Point(325, 153)
        Me.TotalPaymentTextBox.Name = "TotalPaymentTextBox"
        Me.TotalPaymentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalPaymentTextBox.TabIndex = 20
        '
        'BookDateLabel
        '
        BookDateLabel.AutoSize = True
        BookDateLabel.Location = New System.Drawing.Point(247, 191)
        BookDateLabel.Name = "BookDateLabel"
        BookDateLabel.Size = New System.Drawing.Size(60, 13)
        BookDateLabel.TabIndex = 21
        BookDateLabel.Text = "book Date:"
        '
        'BookDateDateTimePicker
        '
        Me.BookDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookingBindingSource, "bookDate", True))
        Me.BookDateDateTimePicker.Location = New System.Drawing.Point(313, 187)
        Me.BookDateDateTimePicker.Name = "BookDateDateTimePicker"
        Me.BookDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.BookDateDateTimePicker.TabIndex = 22
        '
        'PackageBindingSource
        '
        Me.PackageBindingSource.DataMember = "package"
        Me.PackageBindingSource.DataSource = Me.DBCustomerDataSet
        '
        'PackageTableAdapter
        '
        Me.PackageTableAdapter.ClearBeforeFill = True
        '
        'PackageIDLabel
        '
        PackageIDLabel.AutoSize = True
        PackageIDLabel.Location = New System.Drawing.Point(587, 58)
        PackageIDLabel.Name = "PackageIDLabel"
        PackageIDLabel.Size = New System.Drawing.Size(66, 13)
        PackageIDLabel.TabIndex = 23
        PackageIDLabel.Text = "package ID:"
        '
        'PackageIDTextBox
        '
        Me.PackageIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageBindingSource, "packageID", True))
        Me.PackageIDTextBox.Location = New System.Drawing.Point(659, 55)
        Me.PackageIDTextBox.Name = "PackageIDTextBox"
        Me.PackageIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PackageIDTextBox.TabIndex = 24
        '
        'PackageNameLabel
        '
        PackageNameLabel.AutoSize = True
        PackageNameLabel.Location = New System.Drawing.Point(570, 89)
        PackageNameLabel.Name = "PackageNameLabel"
        PackageNameLabel.Size = New System.Drawing.Size(83, 13)
        PackageNameLabel.TabIndex = 25
        PackageNameLabel.Text = "package Name:"
        '
        'PackageNameTextBox
        '
        Me.PackageNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageBindingSource, "packageName", True))
        Me.PackageNameTextBox.Location = New System.Drawing.Point(659, 86)
        Me.PackageNameTextBox.Name = "PackageNameTextBox"
        Me.PackageNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PackageNameTextBox.TabIndex = 26
        '
        'Database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 450)
        Me.Controls.Add(PackageNameLabel)
        Me.Controls.Add(Me.PackageNameTextBox)
        Me.Controls.Add(PackageIDLabel)
        Me.Controls.Add(Me.PackageIDTextBox)
        Me.Controls.Add(BookDateLabel)
        Me.Controls.Add(Me.BookDateDateTimePicker)
        Me.Controls.Add(TotalPaymentLabel)
        Me.Controls.Add(Me.TotalPaymentTextBox)
        Me.Controls.Add(ChildAmountLabel)
        Me.Controls.Add(Me.ChildAmountTextBox)
        Me.Controls.Add(AdultAmountLabel)
        Me.Controls.Add(Me.AdultAmountTextBox)
        Me.Controls.Add(BookingIDLabel)
        Me.Controls.Add(Me.BookingIDTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(CustomerEmailLabel)
        Me.Controls.Add(Me.CustomerEmailTextBox)
        Me.Controls.Add(CustomerPhoneLabel)
        Me.Controls.Add(Me.CustomerPhoneTextBox)
        Me.Controls.Add(CustomerICLabel)
        Me.Controls.Add(Me.CustomerICTextBox)
        Me.Controls.Add(CustomerNameLabel)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Name = "Database"
        Me.Text = "Database"
        CType(Me.DBCustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBCustomerDataSet As DBCustomerDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As DBCustomerDataSetTableAdapters.customerTableAdapter
    Friend WithEvents TableAdapterManager As DBCustomerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents CustomerICTextBox As TextBox
    Friend WithEvents CustomerPhoneTextBox As TextBox
    Friend WithEvents CustomerEmailTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents BookingTableAdapter As DBCustomerDataSetTableAdapters.bookingTableAdapter
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents PackageTableAdapter As DBCustomerDataSetTableAdapters.packageTableAdapter
    Friend WithEvents BookingIDTextBox As TextBox
    Friend WithEvents AdultAmountTextBox As TextBox
    Friend WithEvents ChildAmountTextBox As TextBox
    Friend WithEvents TotalPaymentTextBox As TextBox
    Friend WithEvents BookDateDateTimePicker As DateTimePicker
    Friend WithEvents PackageBindingSource As BindingSource
    Friend WithEvents PackageIDTextBox As TextBox
    Friend WithEvents PackageNameTextBox As TextBox
End Class
