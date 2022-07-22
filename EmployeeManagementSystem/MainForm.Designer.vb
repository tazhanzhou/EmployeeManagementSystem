<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PictureBoxEmployee = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDetails = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSalary = New System.Windows.Forms.PictureBox()
        Me.LabelEmployee = New System.Windows.Forms.Label()
        Me.LabelDetails = New System.Windows.Forms.Label()
        Me.LabelSalary = New System.Windows.Forms.Label()
        Me.PictureBoxLogout = New System.Windows.Forms.PictureBox()
        Me.LabelLogout = New System.Windows.Forms.Label()
        CType(Me.PictureBoxEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxEmployee
        '
        Me.PictureBoxEmployee.Image = CType(resources.GetObject("PictureBoxEmployee.Image"), System.Drawing.Image)
        Me.PictureBoxEmployee.Location = New System.Drawing.Point(153, 124)
        Me.PictureBoxEmployee.Name = "PictureBoxEmployee"
        Me.PictureBoxEmployee.Size = New System.Drawing.Size(105, 99)
        Me.PictureBoxEmployee.TabIndex = 0
        Me.PictureBoxEmployee.TabStop = False
        '
        'PictureBoxDetails
        '
        Me.PictureBoxDetails.ErrorImage = CType(resources.GetObject("PictureBoxDetails.ErrorImage"), System.Drawing.Image)
        Me.PictureBoxDetails.Image = CType(resources.GetObject("PictureBoxDetails.Image"), System.Drawing.Image)
        Me.PictureBoxDetails.Location = New System.Drawing.Point(316, 124)
        Me.PictureBoxDetails.Name = "PictureBoxDetails"
        Me.PictureBoxDetails.Size = New System.Drawing.Size(105, 99)
        Me.PictureBoxDetails.TabIndex = 1
        Me.PictureBoxDetails.TabStop = False
        '
        'PictureBoxSalary
        '
        Me.PictureBoxSalary.Image = CType(resources.GetObject("PictureBoxSalary.Image"), System.Drawing.Image)
        Me.PictureBoxSalary.Location = New System.Drawing.Point(475, 124)
        Me.PictureBoxSalary.Name = "PictureBoxSalary"
        Me.PictureBoxSalary.Size = New System.Drawing.Size(105, 99)
        Me.PictureBoxSalary.TabIndex = 2
        Me.PictureBoxSalary.TabStop = False
        '
        'LabelEmployee
        '
        Me.LabelEmployee.AutoSize = True
        Me.LabelEmployee.Location = New System.Drawing.Point(172, 247)
        Me.LabelEmployee.Name = "LabelEmployee"
        Me.LabelEmployee.Size = New System.Drawing.Size(59, 15)
        Me.LabelEmployee.TabIndex = 3
        Me.LabelEmployee.Text = "Employee"
        '
        'LabelDetails
        '
        Me.LabelDetails.AutoSize = True
        Me.LabelDetails.Location = New System.Drawing.Point(341, 247)
        Me.LabelDetails.Name = "LabelDetails"
        Me.LabelDetails.Size = New System.Drawing.Size(42, 15)
        Me.LabelDetails.TabIndex = 4
        Me.LabelDetails.Text = "Details"
        '
        'LabelSalary
        '
        Me.LabelSalary.AutoSize = True
        Me.LabelSalary.Location = New System.Drawing.Point(495, 247)
        Me.LabelSalary.Name = "LabelSalary"
        Me.LabelSalary.Size = New System.Drawing.Size(38, 15)
        Me.LabelSalary.TabIndex = 5
        Me.LabelSalary.Text = "Salary"
        '
        'PictureBoxLogout
        '
        Me.PictureBoxLogout.Image = CType(resources.GetObject("PictureBoxLogout.Image"), System.Drawing.Image)
        Me.PictureBoxLogout.Location = New System.Drawing.Point(643, 11)
        Me.PictureBoxLogout.Name = "PictureBoxLogout"
        Me.PictureBoxLogout.Size = New System.Drawing.Size(65, 63)
        Me.PictureBoxLogout.TabIndex = 6
        Me.PictureBoxLogout.TabStop = False
        '
        'LabelLogout
        '
        Me.LabelLogout.AutoSize = True
        Me.LabelLogout.Location = New System.Drawing.Point(653, 77)
        Me.LabelLogout.Name = "LabelLogout"
        Me.LabelLogout.Size = New System.Drawing.Size(45, 15)
        Me.LabelLogout.TabIndex = 7
        Me.LabelLogout.Text = "Logout"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 401)
        Me.Controls.Add(Me.LabelLogout)
        Me.Controls.Add(Me.PictureBoxLogout)
        Me.Controls.Add(Me.LabelSalary)
        Me.Controls.Add(Me.LabelDetails)
        Me.Controls.Add(Me.LabelEmployee)
        Me.Controls.Add(Me.PictureBoxSalary)
        Me.Controls.Add(Me.PictureBoxDetails)
        Me.Controls.Add(Me.PictureBoxEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        CType(Me.PictureBoxEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxEmployee As PictureBox
    Friend WithEvents PictureBoxDetails As PictureBox
    Friend WithEvents PictureBoxSalary As PictureBox
    Friend WithEvents LabelEmployee As Label
    Friend WithEvents LabelDetails As Label
    Friend WithEvents LabelSalary As Label
    Friend WithEvents PictureBoxLogout As PictureBox
    Friend WithEvents LabelLogout As Label
End Class
