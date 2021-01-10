Public Class choosePackage

    Dim sqlconn As New OleDb.OleDbConnection
    Dim sqlquery As New OleDb.OleDbCommand
    Dim connString As String
    Public Shared totalPrice As Double


    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Dim objReader As IO.StreamReader
        Dim strLine As String
        Dim adultPrice As Double
        Dim childPrice As Double
        Dim strArray() As String
        Dim strAdult As String
        Dim adultAmt As Integer
        Dim strChild As String
        Dim childAmt As Integer
        Dim package As Integer
        Dim bookdate As Date
        Dim strStaffID As String = "1010"


        strAdult = txtAdultAmt.Text
        adultAmt = Convert.ToInt32(strAdult)
        strChild = txtChildAmt.Text
        childAmt = Convert.ToInt32(strChild)
        bookdate = dateTime.Text
        'Convert.ToDateTime((dateTime.Text), "dd/MM/yyyy")

        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\GitHub\aquapark\DBCustomer.accdb"
        sqlconn.Close()
        sqlconn.ConnectionString = connString
        sqlquery.Connection = sqlconn
        sqlconn.Open()

        If Me.comboBoxPackage.SelectedIndex = 0 Then
            If IO.File.Exists("C:\Users\User\Documents\GitHub\aquapark\day.txt") Then
                objReader = IO.File.OpenText("C:\Users\User\Documents\GitHub\aquapark\day.txt")

            Else
                MsgBox("Files does not exists!")
                Close()
            End If

            Do While objReader.Peek <> -1
                strLine = objReader.ReadLine()
                strArray = strLine.Split(",")
                adultPrice = Convert.ToDouble(strArray(0))
                childPrice = Convert.ToDouble(strArray(1))
            Loop
            package = 1

        ElseIf Me.comboBoxPackage.SelectedIndex = 1 Then
            If IO.File.Exists("C:\Users\User\Documents\GitHub\aquapark\month.txt") Then
                objReader = IO.File.OpenText("C:\Users\User\Documents\GitHub\aquapark\month.txt")

            Else
                MsgBox("Files does not exists!")
                Close()
            End If

            Do While objReader.Peek <> -1
                strLine = objReader.ReadLine()
                strArray = strLine.Split(",")
                adultPrice = Convert.ToDouble(strArray(0))
                childPrice = Convert.ToDouble(strArray(1))
            Loop
            package = 2

        Else
            If IO.File.Exists("C:\Users\User\Documents\GitHub\aquapark\year.txt") Then
                objReader = IO.File.OpenText("C:\Users\User\Documents\GitHub\aquapark\year.txt")

            Else
                MsgBox("Files does not exists!")
                Close()
            End If

            Do While objReader.Peek <> -1
                strLine = objReader.ReadLine()
                strArray = strLine.Split(",")
                adultPrice = Convert.ToDouble(strArray(0))
                childPrice = Convert.ToDouble(strArray(1))
            Loop
            package = 3
        End If


        totalPrice = calculateCost(adultAmt, childAmt, adultPrice, childPrice)
        display(totalPrice)

        objReader.Close()

        Dim result As DialogResult = MessageBox.Show("Your total is " & totalPrice.ToString("C") & ". Confirm Booking?", "Please Confirm Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            sqlquery.CommandText = "INSERT INTO [booking] ([packageID], [adultAmount], [childAmount], [totalPayment], [bookDate], [username], [staffID])
                                VALUES(@package, @adultAmt, @childAmt, @totalPrice, @bookdate, @username, @strStaffID)"

            sqlquery.Parameters.AddWithValue("@packageID", package)
            sqlquery.Parameters.AddWithValue("@adultAmount", adultAmt)
            sqlquery.Parameters.AddWithValue("@childAmount", childAmt)
            sqlquery.Parameters.AddWithValue("@totalPayment", totalPrice)
            sqlquery.Parameters.AddWithValue("@bookDate", bookdate)
            sqlquery.Parameters.AddWithValue("@username", login.username)
            sqlquery.Parameters.AddWithValue("@staffID", strStaffID)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            continueBook.Show()
            Me.Hide()
        End If

    End Sub

    Private Function calculateCost(adultAmt As Integer, childAmt As Integer, adultPrice As Double, childPrice As Double)
        Dim totalPrice As Double
        totalPrice = (adultAmt * adultPrice) + (childAmt * childPrice)
        Return totalPrice
    End Function

    Private Sub display(totalPrice As Double)
        lblDisplayPrice.Text = totalPrice.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDisplayPrice.Text = ""
        txtAdultAmt.Text = ""
        txtChildAmt.Text = ""
        comboBoxPackage.Text = ""
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim objReader As IO.StreamReader
        Dim strLine As String
        Dim adultPrice As Double
        Dim childPrice As Double
        Dim strArray() As String
        Dim strAdult As String
        Dim adultAmt As Integer
        Dim strChild As String
        Dim childAmt As Integer
        Dim package As Integer
        Dim bookdate As Date
        Dim strStaffID As String = "1010"


        strAdult = txtAdultAmt.Text
        adultAmt = Convert.ToInt32(strAdult)
        strChild = txtChildAmt.Text
        childAmt = Convert.ToInt32(strChild)
        bookdate = dateTime.Text
        'Convert.ToDateTime((dateTime.Text), "dd/MM/yyyy")


        If Me.comboBoxPackage.SelectedIndex = 0 Then
            If IO.File.Exists("C:\Users\User\Documents\GitHub\aquapark\day.txt") Then
                objReader = IO.File.OpenText("C:\Users\User\Documents\GitHub\aquapark\day.txt")

            Else
                MsgBox("Files does not exists!")
                Close()
            End If

            Do While objReader.Peek <> -1
                strLine = objReader.ReadLine()
                strArray = strLine.Split(",")
                adultPrice = Convert.ToDouble(strArray(0))
                childPrice = Convert.ToDouble(strArray(1))
            Loop
            package = 1

        ElseIf Me.comboBoxPackage.SelectedIndex = 1 Then
            If IO.File.Exists("C:\Users\User\Documents\GitHub\aquapark\month.txt") Then
                objReader = IO.File.OpenText("C:\Users\User\Documents\GitHub\aquapark\month.txt")

            Else
                MsgBox("Files does not exists!")
                Close()
            End If

            Do While objReader.Peek <> -1
                strLine = objReader.ReadLine()
                strArray = strLine.Split(",")
                adultPrice = Convert.ToDouble(strArray(0))
                childPrice = Convert.ToDouble(strArray(1))
            Loop
            package = 2

        Else
            If IO.File.Exists("C:\Users\User\Documents\GitHub\aquapark\year.txt") Then
                objReader = IO.File.OpenText("C:\Users\User\Documents\GitHub\aquapark\year.txt")

            Else
                MsgBox("Files does not exists!")
                Close()
            End If

            Do While objReader.Peek <> -1
                strLine = objReader.ReadLine()
                strArray = strLine.Split(",")
                adultPrice = Convert.ToDouble(strArray(0))
                childPrice = Convert.ToDouble(strArray(1))
            Loop
            package = 3
        End If


        totalPrice = calculateCost(adultAmt, childAmt, adultPrice, childPrice)
        display(totalPrice)

        objReader.Close()

    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click
        btnCalc_Click(sender, e)
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        lblDisplayPrice.Text = ""
        txtAdultAmt.Text = ""
        txtChildAmt.Text = ""
        comboBoxPackage.Text = ""
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        dlgFont.ShowDialog()
        lblchoosepackage.Font = dlgFont.Font
        lblamtadult.Font = dlgFont.Font
        lblamtkid.Font = dlgFont.Font
        lbldate.Font = dlgFont.Font
        lbltotal.Font = dlgFont.Font
        lblDisplayPrice.Font = dlgFont.Font

    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        dlgColor.ShowDialog()
        GroupBox1.BackColor = dlgColor.Color
        GroupBox2.BackColor = dlgColor.Color
        GroupBox3.BackColor = dlgColor.Color
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Please choose your desired package and fill all of the details below in order to complete the booking process.", MsgBoxStyle.Information, "Aquapark Booking Process")
    End Sub
End Class