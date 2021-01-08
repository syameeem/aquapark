﻿Public Class choosePackage

    Dim sqlconn As New OleDb.OleDbConnection
    Dim sqlquery As New OleDb.OleDbCommand
    Dim connString As String

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Dim objReader As IO.StreamReader
        Dim strLine As String
        Dim adultPrice As Double
        Dim childPrice As Double
        Dim strArray() As String
        Dim totalPrice As Double
        Dim strAdult As String
        Dim adultAmt As Integer
        Dim strChild As String
        Dim childAmt As Integer
        Dim package As Integer
        Dim bookdate As Date

        strAdult = txtAdultAmt.Text
        adultAmt = Convert.ToInt32(strAdult)
        strChild = txtChildAmt.Text
        childAmt = Convert.ToInt32(strChild)
        bookdate = dateTime.Text
        'Convert.ToDateTime((dateTime.Text), "dd/MM/yyyy")
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Documents\GitHub\aquapark\DBCustomer.accdb"
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

        totalPrice = (adultPrice * adultAmt) + (childPrice * childAmt)
        lblTotalPrice.Text = totalPrice.ToString("C")

        sqlquery.CommandText = "INSERT INTO [booking] ([packageID, adultAmount, childAmount, totalPayment, bookDate, username])
                                VALUES(@package.packageID, @adultAmt, @childAmt, @totalPrice, @bookdate, @customer.username)"

        sqlquery.Parameters.AddWithValue("@packageID", package)
        sqlquery.Parameters.AddWithValue("@adultAmount", adultAmt)
        sqlquery.Parameters.AddWithValue("@childAmount", childAmt)
        sqlquery.Parameters.AddWithValue("@totalPayment", totalPrice)
        sqlquery.Parameters.AddWithValue("@bookDate", bookdate)

        sqlquery.ExecuteNonQuery()
        sqlconn.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dateTime.Value = ""
        lblTotalPrice.Text = ""
        txtAdultAmt.Text = ""
        txtChildAmt.Text = ""
        comboBoxPackage.Text = ""
    End Sub

    Private Sub comboBoxPackage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxPackage.SelectedIndexChanged

    End Sub

    Private Sub txtAdultAmt_TextChanged(sender As Object, e As EventArgs) Handles txtAdultAmt.TextChanged

    End Sub

    Private Sub txtChildAmt_TextChanged(sender As Object, e As EventArgs) Handles txtChildAmt.TextChanged

    End Sub

    Private Sub dateTime_ValueChanged(sender As Object, e As EventArgs) Handles dateTime.ValueChanged

    End Sub

    Private Sub choosePackage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class