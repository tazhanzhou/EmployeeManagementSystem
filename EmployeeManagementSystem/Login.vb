Imports System.Data.SqlClient
Imports System.Windows.Forms.Design

Public Class Login
    Dim Conn As New SqlConnection("Data Source=(localdb)\ProjectsV13;Initial Catalog=EmployeeVbDb;Integrated Security=True")
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxUserId.Clear()
        TextBoxPassword.Clear()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim userId As String = TextBoxUserId.Text
        Dim userPw As String = TextBoxPassword.Text
        Dim sqlquerry As String = "Select * From UserPW where id= @userId AND password= @userPw"
        Dim cmd As New SqlCommand(sqlquerry, Conn)
        cmd.Parameters.Add("@userId", SqlDbType.VarChar, 50).Value = userId
        cmd.Parameters.Add("@userPw", SqlDbType.VarChar, 50).Value = userPw

        If TextBoxUserId.Text = "" Then
            MessageBox.Show("Enter the User ID")
            Return
        End If
        If TextBoxPassword.Text = "" Then
            MessageBox.Show("Enter the password")
            Return
        End If
        Try
            Conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read Then
                MessageBox.Show("Login Successful")
                Me.Hide()
                Dim mainForm = New MainForm
                mainForm.Show()
            Else
                MessageBox.Show("Unknown User or Password")
                TextBoxUserId.Clear()
                TextBoxPassword.Clear()
            End If
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Conn.Close()
        Finally
            If Conn IsNot Nothing Then
                Conn.Dispose()
            End If
        End Try

    End Sub
End Class