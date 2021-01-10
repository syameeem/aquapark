<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bookingRecord
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DBCustomerDataSet = New group_project.DBCustomerDataSet()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingTableAdapter = New group_project.DBCustomerDataSetTableAdapters.bookingTableAdapter()
        Me.TableAdapterManager = New group_project.DBCustomerDataSetTableAdapters.TableAdapterManager()
        Me.BookingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdultAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChildAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBCustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(257, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Booking Record"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(368, 401)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 37)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingIDDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PackageIDDataGridViewTextBoxColumn, Me.AdultAmountDataGridViewTextBoxColumn, Me.ChildAmountDataGridViewTextBoxColumn, Me.TotalPaymentDataGridViewTextBoxColumn, Me.BookDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookingBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(38, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(714, 318)
        Me.DataGridView1.TabIndex = 6
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(632, 401)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(120, 16)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Customer Record?"
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
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.packageTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = group_project.DBCustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BookingIDDataGridViewTextBoxColumn
        '
        Me.BookingIDDataGridViewTextBoxColumn.DataPropertyName = "bookingID"
        Me.BookingIDDataGridViewTextBoxColumn.HeaderText = "bookingID"
        Me.BookingIDDataGridViewTextBoxColumn.Name = "BookingIDDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PackageIDDataGridViewTextBoxColumn
        '
        Me.PackageIDDataGridViewTextBoxColumn.DataPropertyName = "packageID"
        Me.PackageIDDataGridViewTextBoxColumn.HeaderText = "packageID"
        Me.PackageIDDataGridViewTextBoxColumn.Name = "PackageIDDataGridViewTextBoxColumn"
        '
        'AdultAmountDataGridViewTextBoxColumn
        '
        Me.AdultAmountDataGridViewTextBoxColumn.DataPropertyName = "adultAmount"
        Me.AdultAmountDataGridViewTextBoxColumn.HeaderText = "adultAmount"
        Me.AdultAmountDataGridViewTextBoxColumn.Name = "AdultAmountDataGridViewTextBoxColumn"
        '
        'ChildAmountDataGridViewTextBoxColumn
        '
        Me.ChildAmountDataGridViewTextBoxColumn.DataPropertyName = "childAmount"
        Me.ChildAmountDataGridViewTextBoxColumn.HeaderText = "childAmount"
        Me.ChildAmountDataGridViewTextBoxColumn.Name = "ChildAmountDataGridViewTextBoxColumn"
        '
        'TotalPaymentDataGridViewTextBoxColumn
        '
        Me.TotalPaymentDataGridViewTextBoxColumn.DataPropertyName = "totalPayment"
        Me.TotalPaymentDataGridViewTextBoxColumn.HeaderText = "totalPayment"
        Me.TotalPaymentDataGridViewTextBoxColumn.Name = "TotalPaymentDataGridViewTextBoxColumn"
        '
        'BookDateDataGridViewTextBoxColumn
        '
        Me.BookDateDataGridViewTextBoxColumn.DataPropertyName = "bookDate"
        Me.BookDateDataGridViewTextBoxColumn.HeaderText = "bookDate"
        Me.BookDateDataGridViewTextBoxColumn.Name = "BookDateDataGridViewTextBoxColumn"
        '
        'bookingRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "bookingRecord"
        Me.Text = "bookingRecord"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBCustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DBCustomerDataSet As DBCustomerDataSet
    Friend WithEvents BookingBindingSource As BindingSource
    Friend WithEvents BookingTableAdapter As DBCustomerDataSetTableAdapters.bookingTableAdapter
    Friend WithEvents TableAdapterManager As DBCustomerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BookingIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PackageIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdultAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChildAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
