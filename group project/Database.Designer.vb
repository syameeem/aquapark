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
        Dim PackageIDLabel As System.Windows.Forms.Label
        Dim PackageNameLabel As System.Windows.Forms.Label
        Dim AdultAmountLabel As System.Windows.Forms.Label
        Dim BookingIDLabel As System.Windows.Forms.Label
        Dim ChildAmountLabel As System.Windows.Forms.Label
        Dim TotalPaymentLabel As System.Windows.Forms.Label
        Dim BookDateLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Dim CustomerICLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim CustomerPhoneLabel As System.Windows.Forms.Label
        Dim CustomerEmailLabel As System.Windows.Forms.Label
        Me.DBCustomerDataSet = New group_project.DBCustomerDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New group_project.DBCustomerDataSetTableAdapters.customerTableAdapter()
        Me.TableAdapterManager = New group_project.DBCustomerDataSetTableAdapters.TableAdapterManager()
        Me.BookingTableAdapter = New group_project.DBCustomerDataSetTableAdapters.bookingTableAdapter()
        Me.PackageTableAdapter = New group_project.DBCustomerDataSetTableAdapters.packageTableAdapter()
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PackageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PackageIDTextBox = New System.Windows.Forms.TextBox()
        Me.PackageNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BookingIDTextBox = New System.Windows.Forms.TextBox()
        Me.AdultAmountTextBox = New System.Windows.Forms.TextBox()
        Me.ChildAmountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.BookDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CustomerPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerICTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerEmailTextBox = New System.Windows.Forms.TextBox()
        PackageIDLabel = New System.Windows.Forms.Label()
        PackageNameLabel = New System.Windows.Forms.Label()
        AdultAmountLabel = New System.Windows.Forms.Label()
        BookingIDLabel = New System.Windows.Forms.Label()
        ChildAmountLabel = New System.Windows.Forms.Label()
        TotalPaymentLabel = New System.Windows.Forms.Label()
        BookDateLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        CustomerNameLabel = New System.Windows.Forms.Label()
        CustomerICLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CustomerPhoneLabel = New System.Windows.Forms.Label()
        CustomerEmailLabel = New System.Windows.Forms.Label()
        CType(Me.DBCustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'PackageTableAdapter
        '
        Me.PackageTableAdapter.ClearBeforeFill = True
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "customerbooking"
        Me.BookingBindingSource.DataSource = Me.CustomerBindingSource
        '
        'PackageBindingSource
        '
        Me.PackageBindingSource.DataMember = "package"
        Me.PackageBindingSource.DataSource = Me.DBCustomerDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 41)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Booking Details"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(645, 228)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 37)
        Me.btnExit.TabIndex = 36
        Me.btnExit.Text = "Confirm?"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gray
        Me.GroupBox3.Controls.Add(PackageIDLabel)
        Me.GroupBox3.Controls.Add(Me.PackageIDTextBox)
        Me.GroupBox3.Controls.Add(Me.PackageNameTextBox)
        Me.GroupBox3.Controls.Add(PackageNameLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(608, 103)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 92)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Package Details"
        '
        'PackageIDLabel
        '
        PackageIDLabel.AutoSize = True
        PackageIDLabel.Location = New System.Drawing.Point(22, 32)
        PackageIDLabel.Name = "PackageIDLabel"
        PackageIDLabel.Size = New System.Drawing.Size(66, 13)
        PackageIDLabel.TabIndex = 23
        PackageIDLabel.Text = "package ID:"
        '
        'PackageIDTextBox
        '
        Me.PackageIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageBindingSource, "packageID", True))
        Me.PackageIDTextBox.Location = New System.Drawing.Point(94, 29)
        Me.PackageIDTextBox.Name = "PackageIDTextBox"
        Me.PackageIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PackageIDTextBox.TabIndex = 24
        '
        'PackageNameTextBox
        '
        Me.PackageNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PackageBindingSource, "packageName", True))
        Me.PackageNameTextBox.Location = New System.Drawing.Point(94, 61)
        Me.PackageNameTextBox.Name = "PackageNameTextBox"
        Me.PackageNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PackageNameTextBox.TabIndex = 26
        '
        'PackageNameLabel
        '
        PackageNameLabel.AutoSize = True
        PackageNameLabel.Location = New System.Drawing.Point(5, 64)
        PackageNameLabel.Name = "PackageNameLabel"
        PackageNameLabel.Size = New System.Drawing.Size(83, 13)
        PackageNameLabel.TabIndex = 25
        PackageNameLabel.Text = "package Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gray
        Me.GroupBox2.Controls.Add(AdultAmountLabel)
        Me.GroupBox2.Controls.Add(Me.BookingIDTextBox)
        Me.GroupBox2.Controls.Add(BookingIDLabel)
        Me.GroupBox2.Controls.Add(Me.AdultAmountTextBox)
        Me.GroupBox2.Controls.Add(Me.ChildAmountTextBox)
        Me.GroupBox2.Controls.Add(ChildAmountLabel)
        Me.GroupBox2.Controls.Add(Me.TotalPaymentTextBox)
        Me.GroupBox2.Controls.Add(TotalPaymentLabel)
        Me.GroupBox2.Controls.Add(Me.BookDateDateTimePicker)
        Me.GroupBox2.Controls.Add(BookDateLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(289, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 226)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Booking Details"
        '
        'AdultAmountLabel
        '
        AdultAmountLabel.AutoSize = True
        AdultAmountLabel.Location = New System.Drawing.Point(8, 62)
        AdultAmountLabel.Name = "AdultAmountLabel"
        AdultAmountLabel.Size = New System.Drawing.Size(72, 13)
        AdultAmountLabel.TabIndex = 3
        AdultAmountLabel.Text = "adult Amount:"
        '
        'BookingIDTextBox
        '
        Me.BookingIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "bookingID", True))
        Me.BookingIDTextBox.Location = New System.Drawing.Point(86, 24)
        Me.BookingIDTextBox.Name = "BookingIDTextBox"
        Me.BookingIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BookingIDTextBox.TabIndex = 2
        '
        'BookingIDLabel
        '
        BookingIDLabel.AutoSize = True
        BookingIDLabel.Location = New System.Drawing.Point(18, 27)
        BookingIDLabel.Name = "BookingIDLabel"
        BookingIDLabel.Size = New System.Drawing.Size(62, 13)
        BookingIDLabel.TabIndex = 1
        BookingIDLabel.Text = "booking ID:"
        '
        'AdultAmountTextBox
        '
        Me.AdultAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "adultAmount", True))
        Me.AdultAmountTextBox.Location = New System.Drawing.Point(86, 59)
        Me.AdultAmountTextBox.Name = "AdultAmountTextBox"
        Me.AdultAmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdultAmountTextBox.TabIndex = 4
        '
        'ChildAmountTextBox
        '
        Me.ChildAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "childAmount", True))
        Me.ChildAmountTextBox.Location = New System.Drawing.Point(86, 91)
        Me.ChildAmountTextBox.Name = "ChildAmountTextBox"
        Me.ChildAmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ChildAmountTextBox.TabIndex = 6
        '
        'ChildAmountLabel
        '
        ChildAmountLabel.AutoSize = True
        ChildAmountLabel.Location = New System.Drawing.Point(9, 94)
        ChildAmountLabel.Name = "ChildAmountLabel"
        ChildAmountLabel.Size = New System.Drawing.Size(71, 13)
        ChildAmountLabel.TabIndex = 5
        ChildAmountLabel.Text = "child Amount:"
        '
        'TotalPaymentTextBox
        '
        Me.TotalPaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "totalPayment", True))
        Me.TotalPaymentTextBox.Location = New System.Drawing.Point(86, 122)
        Me.TotalPaymentTextBox.Name = "TotalPaymentTextBox"
        Me.TotalPaymentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalPaymentTextBox.TabIndex = 8
        '
        'TotalPaymentLabel
        '
        TotalPaymentLabel.AutoSize = True
        TotalPaymentLabel.Location = New System.Drawing.Point(6, 125)
        TotalPaymentLabel.Name = "TotalPaymentLabel"
        TotalPaymentLabel.Size = New System.Drawing.Size(74, 13)
        TotalPaymentLabel.TabIndex = 7
        TotalPaymentLabel.Text = "total Payment:"
        '
        'BookDateDateTimePicker
        '
        Me.BookDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookingBindingSource, "bookDate", True))
        Me.BookDateDateTimePicker.Location = New System.Drawing.Point(72, 160)
        Me.BookDateDateTimePicker.Name = "BookDateDateTimePicker"
        Me.BookDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.BookDateDateTimePicker.TabIndex = 10
        '
        'BookDateLabel
        '
        BookDateLabel.AutoSize = True
        BookDateLabel.Location = New System.Drawing.Point(6, 164)
        BookDateLabel.Name = "BookDateLabel"
        BookDateLabel.Size = New System.Drawing.Size(60, 13)
        BookDateLabel.TabIndex = 9
        BookDateLabel.Text = "book Date:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.CustomerPhoneTextBox)
        Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox1.Controls.Add(UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerNameTextBox)
        Me.GroupBox1.Controls.Add(CustomerNameLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerICTextBox)
        Me.GroupBox1.Controls.Add(CustomerICLabel)
        Me.GroupBox1.Controls.Add(PasswordLabel)
        Me.GroupBox1.Controls.Add(CustomerPhoneLabel)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Controls.Add(Me.CustomerEmailTextBox)
        Me.GroupBox1.Controls.Add(CustomerEmailLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 248)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'CustomerPhoneTextBox
        '
        Me.CustomerPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerPhone", True))
        Me.CustomerPhoneTextBox.Location = New System.Drawing.Point(99, 125)
        Me.CustomerPhoneTextBox.Name = "CustomerPhoneTextBox"
        Me.CustomerPhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerPhoneTextBox.TabIndex = 18
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(99, 27)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 12
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(37, 30)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 11
        UsernameLabel.Text = "username:"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerName", True))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(99, 59)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerNameTextBox.TabIndex = 14
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Location = New System.Drawing.Point(9, 62)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(84, 13)
        CustomerNameLabel.TabIndex = 13
        CustomerNameLabel.Text = "customer Name:"
        '
        'CustomerICTextBox
        '
        Me.CustomerICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerIC", True))
        Me.CustomerICTextBox.Location = New System.Drawing.Point(99, 94)
        Me.CustomerICTextBox.Name = "CustomerICTextBox"
        Me.CustomerICTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerICTextBox.TabIndex = 16
        '
        'CustomerICLabel
        '
        CustomerICLabel.AutoSize = True
        CustomerICLabel.Location = New System.Drawing.Point(27, 97)
        CustomerICLabel.Name = "CustomerICLabel"
        CustomerICLabel.Size = New System.Drawing.Size(66, 13)
        CustomerICLabel.TabIndex = 15
        CustomerICLabel.Text = "customer IC:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(38, 204)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 21
        PasswordLabel.Text = "password:"
        '
        'CustomerPhoneLabel
        '
        CustomerPhoneLabel.AutoSize = True
        CustomerPhoneLabel.Location = New System.Drawing.Point(6, 128)
        CustomerPhoneLabel.Name = "CustomerPhoneLabel"
        CustomerPhoneLabel.Size = New System.Drawing.Size(87, 13)
        CustomerPhoneLabel.TabIndex = 17
        CustomerPhoneLabel.Text = "customer Phone:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(99, 201)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 22
        '
        'CustomerEmailTextBox
        '
        Me.CustomerEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerEmail", True))
        Me.CustomerEmailTextBox.Location = New System.Drawing.Point(99, 164)
        Me.CustomerEmailTextBox.Name = "CustomerEmailTextBox"
        Me.CustomerEmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerEmailTextBox.TabIndex = 20
        '
        'CustomerEmailLabel
        '
        CustomerEmailLabel.AutoSize = True
        CustomerEmailLabel.Location = New System.Drawing.Point(12, 167)
        CustomerEmailLabel.Name = "CustomerEmailLabel"
        CustomerEmailLabel.Size = New System.Drawing.Size(81, 13)
        CustomerEmailLabel.TabIndex = 19
        CustomerEmailLabel.Text = "customer Email:"
        '
        'Database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
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
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents BookingTableAdapter As DBCustomerDataSetTableAdapters.bookingTableAdapter
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents PackageTableAdapter As DBCustomerDataSetTableAdapters.packageTableAdapter
    Friend WithEvents PackageBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PackageIDTextBox As TextBox
    Friend WithEvents PackageNameTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BookingIDTextBox As TextBox
    Friend WithEvents AdultAmountTextBox As TextBox
    Friend WithEvents ChildAmountTextBox As TextBox
    Friend WithEvents TotalPaymentTextBox As TextBox
    Friend WithEvents BookDateDateTimePicker As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CustomerPhoneTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents CustomerICTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents CustomerEmailTextBox As TextBox
End Class
