﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managebooking
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
        Dim BookingIDLabel As System.Windows.Forms.Label
        Dim AdultAmountLabel As System.Windows.Forms.Label
        Dim ChildAmountLabel As System.Windows.Forms.Label
        Dim TotalPaymentLabel As System.Windows.Forms.Label
        Dim BookDateLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Dim CustomerICLabel As System.Windows.Forms.Label
        Dim CustomerPhoneLabel As System.Windows.Forms.Label
        Dim CustomerEmailLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim PackageIDLabel As System.Windows.Forms.Label
        Dim PackageNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(managebooking))
        Me.DBCustomerDataSet = New group_project.DBCustomerDataSet()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableAdapter = New group_project.DBCustomerDataSetTableAdapters.bookingTableAdapter()
        Me.TableAdapterManager = New group_project.DBCustomerDataSetTableAdapters.TableAdapterManager()
        Me.CustomerTableAdapter = New group_project.DBCustomerDataSetTableAdapters.customerTableAdapter()
        Me.PackageTableAdapter = New group_project.DBCustomerDataSetTableAdapters.packageTableAdapter()
        Me.BookingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BookingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BookingIDTextBox = New System.Windows.Forms.TextBox()
        Me.AdultAmountTextBox = New System.Windows.Forms.TextBox()
        Me.ChildAmountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.BookDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerICTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerEmailTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PackageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PackageIDTextBox = New System.Windows.Forms.TextBox()
        Me.PackageNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        BookingIDLabel = New System.Windows.Forms.Label()
        AdultAmountLabel = New System.Windows.Forms.Label()
        ChildAmountLabel = New System.Windows.Forms.Label()
        TotalPaymentLabel = New System.Windows.Forms.Label()
        BookDateLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        CustomerNameLabel = New System.Windows.Forms.Label()
        CustomerICLabel = New System.Windows.Forms.Label()
        CustomerPhoneLabel = New System.Windows.Forms.Label()
        CustomerEmailLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        PackageIDLabel = New System.Windows.Forms.Label()
        PackageNameLabel = New System.Windows.Forms.Label()
        CType(Me.DBCustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BookingBindingNavigator.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        'AdultAmountLabel
        '
        AdultAmountLabel.AutoSize = True
        AdultAmountLabel.Location = New System.Drawing.Point(8, 62)
        AdultAmountLabel.Name = "AdultAmountLabel"
        AdultAmountLabel.Size = New System.Drawing.Size(72, 13)
        AdultAmountLabel.TabIndex = 3
        AdultAmountLabel.Text = "adult Amount:"
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
        'TotalPaymentLabel
        '
        TotalPaymentLabel.AutoSize = True
        TotalPaymentLabel.Location = New System.Drawing.Point(6, 125)
        TotalPaymentLabel.Name = "TotalPaymentLabel"
        TotalPaymentLabel.Size = New System.Drawing.Size(74, 13)
        TotalPaymentLabel.TabIndex = 7
        TotalPaymentLabel.Text = "total Payment:"
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
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(37, 30)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 11
        UsernameLabel.Text = "username:"
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
        'CustomerICLabel
        '
        CustomerICLabel.AutoSize = True
        CustomerICLabel.Location = New System.Drawing.Point(27, 97)
        CustomerICLabel.Name = "CustomerICLabel"
        CustomerICLabel.Size = New System.Drawing.Size(66, 13)
        CustomerICLabel.TabIndex = 15
        CustomerICLabel.Text = "customer IC:"
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
        'CustomerEmailLabel
        '
        CustomerEmailLabel.AutoSize = True
        CustomerEmailLabel.Location = New System.Drawing.Point(12, 167)
        CustomerEmailLabel.Name = "CustomerEmailLabel"
        CustomerEmailLabel.Size = New System.Drawing.Size(81, 13)
        CustomerEmailLabel.TabIndex = 19
        CustomerEmailLabel.Text = "customer Email:"
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
        'PackageIDLabel
        '
        PackageIDLabel.AutoSize = True
        PackageIDLabel.Location = New System.Drawing.Point(22, 32)
        PackageIDLabel.Name = "PackageIDLabel"
        PackageIDLabel.Size = New System.Drawing.Size(66, 13)
        PackageIDLabel.TabIndex = 23
        PackageIDLabel.Text = "package ID:"
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
        'DBCustomerDataSet
        '
        Me.DBCustomerDataSet.DataSetName = "DBCustomerDataSet"
        Me.DBCustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "booking"
        Me.BookingBindingSource.DataSource = Me.DBCustomerDataSet
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bookingTableAdapter = Me.BookingTableAdapter
        Me.TableAdapterManager.customerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.packageTableAdapter = Me.PackageTableAdapter
        Me.TableAdapterManager.UpdateOrder = group_project.DBCustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'PackageTableAdapter
        '
        Me.PackageTableAdapter.ClearBeforeFill = True
        '
        'BookingBindingNavigator
        '
        Me.BookingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BookingBindingNavigator.BindingSource = Me.BookingBindingSource
        Me.BookingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BookingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BookingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BookingBindingNavigatorSaveItem})
        Me.BookingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BookingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BookingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BookingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BookingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BookingBindingNavigator.Name = "BookingBindingNavigator"
        Me.BookingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BookingBindingNavigator.Size = New System.Drawing.Size(908, 25)
        Me.BookingBindingNavigator.TabIndex = 0
        Me.BookingBindingNavigator.Text = "BindingNavigator1"
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
        'BookingBindingNavigatorSaveItem
        '
        Me.BookingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BookingBindingNavigatorSaveItem.Image = CType(resources.GetObject("BookingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BookingBindingNavigatorSaveItem.Name = "BookingBindingNavigatorSaveItem"
        Me.BookingBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BookingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BookingIDTextBox
        '
        Me.BookingIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "bookingID", True))
        Me.BookingIDTextBox.Location = New System.Drawing.Point(86, 24)
        Me.BookingIDTextBox.Name = "BookingIDTextBox"
        Me.BookingIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BookingIDTextBox.TabIndex = 2
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
        'TotalPaymentTextBox
        '
        Me.TotalPaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "totalPayment", True))
        Me.TotalPaymentTextBox.Location = New System.Drawing.Point(86, 122)
        Me.TotalPaymentTextBox.Name = "TotalPaymentTextBox"
        Me.TotalPaymentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalPaymentTextBox.TabIndex = 8
        '
        'BookDateDateTimePicker
        '
        Me.BookDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookingBindingSource, "bookDate", True))
        Me.BookDateDateTimePicker.Location = New System.Drawing.Point(72, 160)
        Me.BookDateDateTimePicker.Name = "BookDateDateTimePicker"
        Me.BookDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.BookDateDateTimePicker.TabIndex = 10
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.DBCustomerDataSet
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(99, 27)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 12
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerName", True))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(99, 59)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerNameTextBox.TabIndex = 14
        '
        'CustomerICTextBox
        '
        Me.CustomerICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerIC", True))
        Me.CustomerICTextBox.Location = New System.Drawing.Point(99, 94)
        Me.CustomerICTextBox.Name = "CustomerICTextBox"
        Me.CustomerICTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerICTextBox.TabIndex = 16
        '
        'CustomerPhoneTextBox
        '
        Me.CustomerPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerPhone", True))
        Me.CustomerPhoneTextBox.Location = New System.Drawing.Point(99, 125)
        Me.CustomerPhoneTextBox.Name = "CustomerPhoneTextBox"
        Me.CustomerPhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerPhoneTextBox.TabIndex = 18
        '
        'CustomerEmailTextBox
        '
        Me.CustomerEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customerEmail", True))
        Me.CustomerEmailTextBox.Location = New System.Drawing.Point(99, 164)
        Me.CustomerEmailTextBox.Name = "CustomerEmailTextBox"
        Me.CustomerEmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerEmailTextBox.TabIndex = 20
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(99, 201)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 22
        '
        'PackageBindingSource
        '
        Me.PackageBindingSource.DataMember = "package"
        Me.PackageBindingSource.DataSource = Me.DBCustomerDataSet
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 41)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Booking Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(346, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 28
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
        Me.GroupBox1.Location = New System.Drawing.Point(54, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 248)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
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
        Me.GroupBox2.Location = New System.Drawing.Point(312, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 226)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Booking Details"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gray
        Me.GroupBox3.Controls.Add(PackageIDLabel)
        Me.GroupBox3.Controls.Add(Me.PackageIDTextBox)
        Me.GroupBox3.Controls.Add(Me.PackageNameTextBox)
        Me.GroupBox3.Controls.Add(PackageNameLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(631, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 92)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Package Details"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(688, 248)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 37)
        Me.btnExit.TabIndex = 32
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'managebooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(908, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BookingBindingNavigator)
        Me.Name = "managebooking"
        Me.Text = "managebooking"
        CType(Me.DBCustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BookingBindingNavigator.ResumeLayout(False)
        Me.BookingBindingNavigator.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBCustomerDataSet As DBCustomerDataSet
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As DBCustomerDataSetTableAdapters.bookingTableAdapter
    Friend WithEvents TableAdapterManager As DBCustomerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BookingBindingNavigator As BindingNavigator
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
    Friend WithEvents BookingBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BookingIDTextBox As TextBox
    Friend WithEvents CustomerTableAdapter As DBCustomerDataSetTableAdapters.customerTableAdapter
    Friend WithEvents AdultAmountTextBox As TextBox
    Friend WithEvents ChildAmountTextBox As TextBox
    Friend WithEvents TotalPaymentTextBox As TextBox
    Friend WithEvents BookDateDateTimePicker As DateTimePicker
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents PackageTableAdapter As DBCustomerDataSetTableAdapters.packageTableAdapter
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents CustomerICTextBox As TextBox
    Friend WithEvents CustomerPhoneTextBox As TextBox
    Friend WithEvents CustomerEmailTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PackageBindingSource As BindingSource
    Friend WithEvents PackageIDTextBox As TextBox
    Friend WithEvents PackageNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnExit As Button
End Class
