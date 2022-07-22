Imports System.Data.SqlClient

Public Class Salary
    Dim Conn As New SqlConnection("Data Source=(localdb)\ProjectsV13;Initial Catalog=EmployeeVbDb;Integrated Security=True")
    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        Me.Hide()
        Dim mainForm = New MainForm
        mainForm.Show()
    End Sub
    Private Sub FetchEmployeeData()
        If TextBoxEmployeeID.Text = "" Then
            MessageBox.Show("Enter the Employee ID")
        Else
            Conn.Open()
            Dim cmd As New SqlCommand("Select * From Employees where EmployeeID=" & TextBoxEmployeeID.Text & "", Conn)
            Dim dt As DataTable = New DataTable
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                LabelName.Text = dr(1).ToString()
                LabelPosition.Text = dr(5).ToString()
                LabelName.Visible = True
                LabelPosition.Visible = True
            Next
            Conn.Close()
        End If
    End Sub
    Private Sub ButtonFetchData_Click(sender As Object, e As EventArgs) Handles ButtonFetchData.Click
        FetchEmployeeData()
    End Sub
    Dim DailyPay
    Private Sub ButtonView_Click(sender As Object, e As EventArgs) Handles ButtonView.Click
        If LabelPosition.Text = "" Then
            MessageBox.Show("Select an Employee")
        ElseIf TextBoxWorkedDays.Text = "" Or Convert.ToInt32(TextBoxWorkedDays.Text) > 28 Then
            MessageBox.Show("Enter a valid Number of Days")
        Else
            Select Case LabelPosition.Text
                Case "Manager"
                    DailyPay = 1200
                Case "IT"
                    DailyPay = 1100
                Case "Cleaner"
                    DailyPay = 800
                Case Else
                    DailyPay = 700
            End Select
            Dim total = DailyPay * Convert.ToInt32(TextBoxWorkedDays.Text)
            RichTextBox1.Text = "Employee ID: " + TextBoxEmployeeID.Text & vbCrLf & "Name: " +
            LabelName.Text & vbCrLf & "Position: " + LabelPosition.Text & vbCrLf &
            "Days Worked: " + TextBoxWorkedDays.Text & vbCrLf & "Daily Salary Rs: " +
            DailyPay.ToString() & vbCrLf & "Total Amount Rs: " + total.ToString()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Century Gothic", 25), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("***Pay Slip***", New Font("Arial", 20), Brushes.Crimson, 300, 100)
        e.Graphics.DrawString(RichTextBox1.Text, New Font("Century Gothic", 20), Brushes.Black, 150, 190)
        e.Graphics.DrawString("==========Thanks for Your Services============", New Font("Century Gothic", 15), Brushes.DarkGreen, 150, 500)
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        If PrintPreviewDialog1 Is Nothing Then
            PrintPreviewDialog1 = New PrintPreviewDialog
        End If

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PictureBoxClose_Click(sender As Object, e As EventArgs) Handles PictureBoxClose.Click
        Application.Exit()
    End Sub
End Class