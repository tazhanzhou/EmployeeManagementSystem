Imports System.Data.SqlClient
Public Class Employee
    Dim Conn As New SqlConnection("Data Source=(localdb)\ProjectsV13;Initial Catalog=EmployeeVbDb;Integrated Security=True")
    Private Sub Populate()
        Dim cmd As New SqlCommand("Select * From Employees", Conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        Me.Hide()
        Dim mainForm = New MainForm
        mainForm.Show()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Conn.Open()
        Dim Query As String
        Query = "insert into Employees (EmployeeName,Address,Phone,Gender,Position,Education,Dob) values 
('" & TextBoxName.Text & "','" & TextBoxAddress.Text & "','" & TextBoxPhone.Text & "',
'" & ComboBoxGender.SelectedItem.ToString() & "','" & ComboBoxPosition.SelectedItem.ToString() & "',
'" & ComboBoxEducation.SelectedItem.ToString() & "','" & DateTimePicker1.Value & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Employee Added")
        Conn.Close()
        Populate()
        Clear()
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
    Dim key = 0
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If key = 0 Then
            MessageBox.Show("Select the Employee to Delete")
        Else
            Try
                Conn.Open()
                Dim cmd As New SqlCommand("Delete from Employees where EmployeeID = " & key & "", Conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Employee Deleted")
                Conn.Close()
                Populate()
                Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        TextBoxName.Text = row.Cells(1).Value.ToString()
        TextBoxAddress.Text = row.Cells(2).Value.ToString()
        TextBoxPhone.Text = row.Cells(3).Value.ToString()
        ComboBoxGender.SelectedItem = row.Cells(4).Value.ToString()
        ComboBoxPosition.SelectedItem = row.Cells(5).Value.ToString()
        ComboBoxEducation.SelectedItem = row.Cells(6).Value.ToString()
        DateTimePicker1.Value = row.Cells(7).Value.ToString()

    End Sub
    Private Sub Clear()
        key = 0
        TextBoxName.Clear()
        TextBoxAddress.Clear()
        TextBoxPhone.Clear()
        ComboBoxGender.ResetText()
        ComboBoxPosition.ResetText()
        ComboBoxEducation.ResetText()

    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If TextBoxName.Text = "" Or TextBoxAddress.Text = "" Or TextBoxPhone.Text = "" Then
            MessageBox.Show("Missing Information")
        Else
            Conn.Open()
            Dim cmd As New SqlCommand("Update Employees set EmployeeName='" & TextBoxName.Text & "',
Address='" & TextBoxAddress.Text & "', Phone='" & TextBoxPhone.Text & "', Gender='" & ComboBoxGender.SelectedItem.ToString() & "',
Position='" & ComboBoxPosition.SelectedItem.ToString() & "', Education='" & ComboBoxEducation.SelectedItem.ToString() & "',
DOB='" & DateTimePicker1.Value & "' where EmployeeID = " & key & "", Conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee Updated")
            Conn.Close()
            Populate()
            Clear()
        End If

    End Sub

    Private Sub PictureBoxClose_Click(sender As Object, e As EventArgs) Handles PictureBoxClose.Click
        Application.Exit()
    End Sub
End Class