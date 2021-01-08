<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class choosePackage
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboBoxPackage = New System.Windows.Forms.ComboBox()
        Me.txtAdultAmt = New System.Windows.Forms.TextBox()
        Me.txtChildAmt = New System.Windows.Forms.TextBox()
        Me.dateTime = New System.Windows.Forms.DateTimePicker()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(52, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "A Happy - Day Package"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(314, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Half But Happy Package"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(580, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Happy For  Year Package"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Choose Package"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Amount of Adults"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Amount Of Kids"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date"
        '
        'comboBoxPackage
        '
        Me.comboBoxPackage.FormattingEnabled = True
        Me.comboBoxPackage.Items.AddRange(New Object() {"A Happy - Day", "Half Of Adventure", "Wholesome Year"})
        Me.comboBoxPackage.Location = New System.Drawing.Point(267, 213)
        Me.comboBoxPackage.Name = "comboBoxPackage"
        Me.comboBoxPackage.Size = New System.Drawing.Size(206, 21)
        Me.comboBoxPackage.TabIndex = 7
        '
        'txtAdultAmt
        '
        Me.txtAdultAmt.Location = New System.Drawing.Point(267, 246)
        Me.txtAdultAmt.Name = "txtAdultAmt"
        Me.txtAdultAmt.Size = New System.Drawing.Size(206, 20)
        Me.txtAdultAmt.TabIndex = 8
        '
        'txtChildAmt
        '
        Me.txtChildAmt.Location = New System.Drawing.Point(267, 279)
        Me.txtChildAmt.Name = "txtChildAmt"
        Me.txtChildAmt.Size = New System.Drawing.Size(206, 20)
        Me.txtChildAmt.TabIndex = 9
        '
        'dateTime
        '
        Me.dateTime.Location = New System.Drawing.Point(267, 310)
        Me.dateTime.Name = "dateTime"
        Me.dateTime.Size = New System.Drawing.Size(206, 20)
        Me.dateTime.TabIndex = 10
        '
        'btnBook
        '
        Me.btnBook.Location = New System.Drawing.Point(188, 366)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(95, 42)
        Me.btnBook.TabIndex = 11
        Me.btnBook.Text = "Book Ticket"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(351, 366)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 42)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(560, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = " Total Payment :"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(590, 279)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(155, 74)
        Me.lblTotalPrice.TabIndex = 14
        '
        'choosePackage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 450)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.dateTime)
        Me.Controls.Add(Me.txtChildAmt)
        Me.Controls.Add(Me.txtAdultAmt)
        Me.Controls.Add(Me.comboBoxPackage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "choosePackage"
        Me.Text = "Choose Package"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents comboBoxPackage As ComboBox
    Friend WithEvents txtAdultAmt As TextBox
    Friend WithEvents txtChildAmt As TextBox
    Friend WithEvents dateTime As DateTimePicker
    Friend WithEvents btnBook As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalPrice As Label
End Class
