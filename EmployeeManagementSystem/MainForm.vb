Public Class MainForm
    Private Sub PictureBoxEmployee_Click(sender As Object, e As EventArgs) Handles PictureBoxEmployee.Click
        Me.Hide()
        Dim Employee = New Employee
        Employee.Show()
    End Sub

    Private Sub LabelEmployee_Click(sender As Object, e As EventArgs) Handles LabelEmployee.Click
        Me.Hide()
        Dim Employee = New Employee
        Employee.Show()
    End Sub

    Private Sub PictureBoxDetails_Click(sender As Object, e As EventArgs) Handles PictureBoxDetails.Click
        Me.Hide()
        Dim Details = New Details
        Details.Show()

    End Sub

    Private Sub LabelDetails_Click(sender As Object, e As EventArgs) Handles LabelDetails.Click
        Me.Hide()
        Dim Details = New Details
        Details.Show()
    End Sub

    Private Sub PictureBoxSalary_Click(sender As Object, e As EventArgs) Handles PictureBoxSalary.Click
        Me.Hide()
        Dim Salary = New Salary
        Salary.Show()
    End Sub

    Private Sub LabelSalary_Click(sender As Object, e As EventArgs) Handles LabelSalary.Click
        Me.Hide()
        Dim Salary = New Salary
        Salary.Show()
    End Sub

    Private Sub PictureBoxLogout_Click(sender As Object, e As EventArgs) Handles PictureBoxLogout.Click
        Dim log = New Login
        Me.Hide()
        log.Show()
    End Sub
End Class