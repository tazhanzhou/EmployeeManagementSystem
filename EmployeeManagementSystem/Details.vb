Imports System.Data.SqlClient

Public Class Details
    Dim Conn As New SqlConnection("Data Source=(localdb)\ProjectsV13;Initial Catalog=EmployeeVbDb;Integrated Security=True")
    'Fetch the Employee Data from Database
    Private Sub FetchEmployeeData()
        If TextBoxEmployeeID.Text = "" Then
            MessageBox.Show("Enter the Employee ID")
        Else
            Conn.Open()
            Dim cmd As New SqlCommand("Select * From Employees where EmployeeID=" & TextBoxEmployeeID.Text & "", Conn)

            'initialize a DataTable instance
            Dim dt As DataTable = New DataTable

            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            sda.Fill(dt)
            For Each dr As DataRow In dt.Rows
                LabelName.Text = dr(1).ToString()
                LabelAddress.Text = dr(2).ToString()
                LabelPhone.Text = dr(3).ToString()
                LabelGender.Text = dr(4).ToString()
                LabelPosition.Text = dr(5).ToString()
                LabelEducation.Text = dr(6).ToString()
                LabelDBO.Text = dr(7).ToString()
                LabelName.Visible = True
                LabelAddress.Visible = True
                LabelGender.Visible = True
                LabelPosition.Visible = True
                LabelPhone.Visible = True
                LabelEducation.Visible = True
                LabelDBO.Visible = True
            Next
            Conn.Close()
        End If
    End Sub
    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        Me.Hide()
        Dim mainForm = New MainForm
        mainForm.Show()
    End Sub
    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        FetchEmployeeData()
    End Sub
End Class