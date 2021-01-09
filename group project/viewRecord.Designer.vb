<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewRecord))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBCustomerDataSet = New group_project.DBCustomerDataSet()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerEmailTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerICTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BookDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.ChildAmountTextBox = New System.Windows.Forms.TextBox()
        Me.AdultAmountTextBox = New System.Windows.Forms.TextBox()
        Me.BookingIDTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PackageIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerTableAdapter = New group_project.DBCustomerDataSetTableAdapters.customerTableAdapter()
        Me.TableAdapterManager = New group_project.DBCustomerDataSetTableAdapters.TableAdapterManager()
        Me.BookingTableAdapter = New group_project.DBCustomerDataSetTableAdapters.bookingTableAdapter()
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBCustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(35, 31)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(67, 15)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "username:"
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Location = New System.Drawing.Point(7, 56)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(100, 15)
        CustomerNameLabel.TabIndex = 2
        CustomerNameLabel.Text = "customer Name:"
        '
        'CustomerICLabel
        '
        CustomerICLabel.AutoSize = True
        CustomerICLabel.Location = New System.Drawing.Point(25, 82)
        CustomerICLabel.Name = "CustomerICLabel"
        CustomerICLabel.Size = New System.Drawing.Size(80, 15)
        CustomerICLabel.TabIndex = 4
        CustomerICLabel.Text = "customer IC:"
        '
        'CustomerPhoneLabel
        '
        CustomerPhoneLabel.AutoSize = True
        CustomerPhoneLabel.Location = New System.Drawing.Point(4, 109)
        CustomerPhoneLabel.Name = "CustomerPhoneLabel"
        CustomerPhoneLabel.Size = New System.Drawing.Size(103, 15)
        CustomerPhoneLabel.TabIndex = 6
        CustomerPhoneLabel.Text = "customer Phone:"
        '
        'CustomerEmailLabel
        '
        CustomerEmailLabel.AutoSize = True
        CustomerEmailLabel.Location = New System.Drawing.Point(10, 136)
        CustomerEmailLabel.Name = "CustomerEmailLabel"
        CustomerEmailLabel.Size = New System.Drawing.Size(101, 15)
        CustomerEmailLabel.TabIndex = 8
        CustomerEmailLabel.Text = "customer Email:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(35, 164)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(66, 15)
        PasswordLabel.TabIndex = 10
        PasswordLabel.Text = "password:"
        '
        'BookingIDLabel
        '
        BookingIDLabel.AutoSize = True
        BookingIDLabel.Location = New System.Drawing.Point(20, 31)
        BookingIDLabel.Name = "BookingIDLabel"
        BookingIDLabel.Size = New System.Drawing.Size(74, 15)
        BookingIDLabel.TabIndex = 0
        BookingIDLabel.Text = "booking ID:"
        '
        'AdultAmountLabel
        '
        AdultAmountLabel.AutoSize = True
        AdultAmountLabel.Location = New System.Drawing.Point(10, 56)
        AdultAmountLabel.Name = "AdultAmountLabel"
        AdultAmountLabel.Size = New System.Drawing.Size(87, 15)
        AdultAmountLabel.TabIndex = 2
        AdultAmountLabel.Text = "adult Amount:"
        '
        'ChildAmountLabel
        '
        ChildAmountLabel.AutoSize = True
        ChildAmountLabel.Location = New System.Drawing.Point(11, 82)
        ChildAmountLabel.Name = "ChildAmountLabel"
        ChildAmountLabel.Size = New System.Drawing.Size(86, 15)
        ChildAmountLabel.TabIndex = 4
        ChildAmountLabel.Text = "child Amount:"
        '
        'TotalPaymentLabel
        '
        TotalPaymentLabel.AutoSize = True
        TotalPaymentLabel.Location = New System.Drawing.Point(10, 109)
        TotalPaymentLabel.Name = "TotalPaymentLabel"
        TotalPaymentLabel.Size = New System.Drawing.Size(90, 15)
        TotalPaymentLabel.TabIndex = 6
        TotalPaymentLabel.Text = "total Payment:"
        '
        'BookDateLabel
        '
        BookDateLabel.AutoSize = True
        BookDateLabel.Location = New System.Drawing.Point(24, 136)
        BookDateLabel.Name = "BookDateLabel"
        BookDateLabel.Size = New System.Drawing.Size(69, 15)
        BookDateLabel.TabIndex = 5
        BookDateLabel.Text = "book Date:"
        '
        'PackageIDLabel
        '
        PackageIDLabel.AutoSize = True
        PackageIDLabel.Location = New System.Drawing.Point(18, 31)
        PackageIDLabel.Name = "PackageIDLabel"
        PackageIDLabel.Size = New System.Drawing.Size(75, 15)
        PackageIDLabel.TabIndex = 5
        PackageIDLabel.Text = "package ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Controls.Add(UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox1.Controls.Add(CustomerEmailLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerEmailTextBox)
        Me.GroupBox1.Controls.Add(CustomerNameLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerNameTextBox)
        Me.GroupBox1.Controls.Add(CustomerPhoneLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerPhoneTextBox)
        Me.GroupBox1.Controls.Add(CustomerICLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerICTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 207)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(107, 161)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(113, 22)
        Me.PasswordTextBox.TabIndex = 11
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.DBCustomerDataSet
        '
        'DBCustomerDataSet
        '
        Me.DBCustomerDataSet.DataSetName = "DBCustomerDataSet"
        Me.DBCustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(108, 28)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(112, 22)
        Me.UsernameTextBox.TabIndex = 1
        '
        'CustomerEmailTextBox
        '
        Me.CustomerEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerEmail", True))
        Me.CustomerEmailTextBox.Location = New System.Drawing.Point(108, 133)
        Me.CustomerEmailTextBox.Name = "CustomerEmailTextBox"
        Me.CustomerEmailTextBox.Size = New System.Drawing.Size(112, 22)
        Me.CustomerEmailTextBox.TabIndex = 9
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerName", True))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(108, 53)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(112, 22)
        Me.CustomerNameTextBox.TabIndex = 3
        '
        'CustomerPhoneTextBox
        '
        Me.CustomerPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerPhone", True))
        Me.CustomerPhoneTextBox.Location = New System.Drawing.Point(108, 106)
        Me.CustomerPhoneTextBox.Name = "CustomerPhoneTextBox"
        Me.CustomerPhoneTextBox.Size = New System.Drawing.Size(112, 22)
        Me.CustomerPhoneTextBox.TabIndex = 7
        '
        'CustomerICTextBox
        '
        Me.CustomerICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerIC", True))
        Me.CustomerICTextBox.Location = New System.Drawing.Point(108, 79)
        Me.CustomerICTextBox.Name = "CustomerICTextBox"
        Me.CustomerICTextBox.Size = New System.Drawing.Size(112, 22)
        Me.CustomerICTextBox.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox2.Controls.Add(BookDateLabel)
        Me.GroupBox2.Controls.Add(Me.BookDateDateTimePicker)
        Me.GroupBox2.Controls.Add(TotalPaymentLabel)
        Me.GroupBox2.Controls.Add(Me.TotalPaymentTextBox)
        Me.GroupBox2.Controls.Add(ChildAmountLabel)
        Me.GroupBox2.Controls.Add(Me.ChildAmountTextBox)
        Me.GroupBox2.Controls.Add(AdultAmountLabel)
        Me.GroupBox2.Controls.Add(Me.AdultAmountTextBox)
        Me.GroupBox2.Controls.Add(BookingIDLabel)
        Me.GroupBox2.Controls.Add(Me.BookingIDTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(258, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 179)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Booking Details"
        '
        'BookDateDateTimePicker
        '
        Me.BookDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookingBindingSource, "bookDate", True))
        Me.BookDateDateTimePicker.Location = New System.Drawing.Point(102, 132)
        Me.BookDateDateTimePicker.Name = "BookDateDateTimePicker"
        Me.BookDateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.BookDateDateTimePicker.TabIndex = 6
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "customerbooking"
        Me.BookingBindingSource.DataSource = Me.CustomerBindingSource
        '
        'TotalPaymentTextBox
        '
        Me.TotalPaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "totalPayment", True))
        Me.TotalPaymentTextBox.Location = New System.Drawing.Point(102, 106)
        Me.TotalPaymentTextBox.Name = "TotalPaymentTextBox"
        Me.TotalPaymentTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TotalPaymentTextBox.TabIndex = 7
        '
        'ChildAmountTextBox
        '
        Me.ChildAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "childAmount", True))
        Me.ChildAmountTextBox.Location = New System.Drawing.Point(100, 79)
        Me.ChildAmountTextBox.Name = "ChildAmountTextBox"
        Me.ChildAmountTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ChildAmountTextBox.TabIndex = 5
        '
        'AdultAmountTextBox
        '
        Me.AdultAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "adultAmount", True))
        Me.AdultAmountTextBox.Location = New System.Drawing.Point(100, 53)
        Me.AdultAmountTextBox.Name = "AdultAmountTextBox"
        Me.AdultAmountTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AdultAmountTextBox.TabIndex = 3
        '
        'BookingIDTextBox
        '
        Me.BookingIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "bookingID", True))
        Me.BookingIDTextBox.Location = New System.Drawing.Point(100, 28)
        Me.BookingIDTextBox.Name = "BookingIDTextBox"
        Me.BookingIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BookingIDTextBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox3.Controls.Add(PackageIDLabel)
        Me.GroupBox3.Controls.Add(Me.PackageIDTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(609, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 69)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Package Details"
        '
        'PackageIDTextBox
        '
        Me.PackageIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "packageID", True))
        Me.PackageIDTextBox.Location = New System.Drawing.Point(90, 28)
        Me.PackageIDTextBox.Name = "PackageIDTextBox"
        Me.PackageIDTextBox.Size = New System.Drawing.Size(42, 22)
        Me.PackageIDTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(257, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Record"
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
        Me.TableAdapterManager.packageTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = group_project.DBCustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.BackColor = System.Drawing.Color.Silver
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
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.CustomerBindingNavigator.TabIndex = 2
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
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Font = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(580, 186)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Package Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(92, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Wholesome Year"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Half of Adventure"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "A Happy Day"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Package Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Package ID"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(630, 313)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 37)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'viewRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "viewRecord"
        Me.Text = "viewRecord"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBCustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
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
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents CustomerEmailTextBox As TextBox
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents CustomerPhoneTextBox As TextBox
    Friend WithEvents CustomerICTextBox As TextBox
    Friend WithEvents BookingTableAdapter As DBCustomerDataSetTableAdapters.bookingTableAdapter
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookDateDateTimePicker As DateTimePicker
    Friend WithEvents TotalPaymentTextBox As TextBox
    Friend WithEvents ChildAmountTextBox As TextBox
    Friend WithEvents AdultAmountTextBox As TextBox
    Friend WithEvents BookingIDTextBox As TextBox
    Friend WithEvents PackageIDTextBox As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnExit As Button
End Class
