<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAthlete
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
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.rdFemale = New System.Windows.Forms.RadioButton()
        Me.rdMale = New System.Windows.Forms.RadioButton()
        Me.txtMembFeeOut = New System.Windows.Forms.TextBox()
        Me.dtPickerDateJoined = New System.Windows.Forms.DateTimePicker()
        Me.dtPickerBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.txtNameSurname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbAthletes = New System.Windows.Forms.ListBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtMemNo = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.rdFemale)
        Me.GroupBox1.Controls.Add(Me.rdMale)
        Me.GroupBox1.Controls.Add(Me.txtMembFeeOut)
        Me.GroupBox1.Controls.Add(Me.dtPickerDateJoined)
        Me.GroupBox1.Controls.Add(Me.dtPickerBirthDate)
        Me.GroupBox1.Controls.Add(Me.txtNameSurname)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(245, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 298)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Athlete Details"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(225, 242)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 30
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(132, 242)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(71, 23)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'rdFemale
        '
        Me.rdFemale.AutoSize = True
        Me.rdFemale.Enabled = False
        Me.rdFemale.Location = New System.Drawing.Point(214, 117)
        Me.rdFemale.Name = "rdFemale"
        Me.rdFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdFemale.TabIndex = 28
        Me.rdFemale.TabStop = True
        Me.rdFemale.Text = "Female"
        Me.rdFemale.UseVisualStyleBackColor = True
        '
        'rdMale
        '
        Me.rdMale.AutoSize = True
        Me.rdMale.Enabled = False
        Me.rdMale.Location = New System.Drawing.Point(132, 117)
        Me.rdMale.Name = "rdMale"
        Me.rdMale.Size = New System.Drawing.Size(48, 17)
        Me.rdMale.TabIndex = 27
        Me.rdMale.TabStop = True
        Me.rdMale.Text = "Male"
        Me.rdMale.UseVisualStyleBackColor = True
        '
        'txtMembFeeOut
        '
        Me.txtMembFeeOut.Enabled = False
        Me.txtMembFeeOut.Location = New System.Drawing.Point(132, 202)
        Me.txtMembFeeOut.Name = "txtMembFeeOut"
        Me.txtMembFeeOut.Size = New System.Drawing.Size(157, 20)
        Me.txtMembFeeOut.TabIndex = 26
        '
        'dtPickerDateJoined
        '
        Me.dtPickerDateJoined.Enabled = False
        Me.dtPickerDateJoined.Location = New System.Drawing.Point(132, 155)
        Me.dtPickerDateJoined.Name = "dtPickerDateJoined"
        Me.dtPickerDateJoined.Size = New System.Drawing.Size(157, 20)
        Me.dtPickerDateJoined.TabIndex = 25
        '
        'dtPickerBirthDate
        '
        Me.dtPickerBirthDate.Enabled = False
        Me.dtPickerBirthDate.Location = New System.Drawing.Point(132, 63)
        Me.dtPickerBirthDate.Name = "dtPickerBirthDate"
        Me.dtPickerBirthDate.Size = New System.Drawing.Size(157, 20)
        Me.dtPickerBirthDate.TabIndex = 24
        '
        'txtNameSurname
        '
        Me.txtNameSurname.Enabled = False
        Me.txtNameSurname.Location = New System.Drawing.Point(132, 25)
        Me.txtNameSurname.Name = "txtNameSurname"
        Me.txtNameSurname.Size = New System.Drawing.Size(157, 20)
        Me.txtNameSurname.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, -30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "List Of Athlets"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Date Joined"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Fee Oustanding"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Birth Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Name  Surname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, -94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Membership No"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.lbAthletes)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.txtMemNo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 298)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'lbAthletes
        '
        Me.lbAthletes.FormattingEnabled = True
        Me.lbAthletes.Location = New System.Drawing.Point(15, 45)
        Me.lbAthletes.Name = "lbAthletes"
        Me.lbAthletes.Size = New System.Drawing.Size(174, 212)
        Me.lbAthletes.TabIndex = 21
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(133, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(56, 23)
        Me.btnSearch.TabIndex = 20
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtMemNo
        '
        Me.txtMemNo.Location = New System.Drawing.Point(15, 19)
        Me.txtMemNo.Name = "txtMemNo"
        Me.txtMemNo.Size = New System.Drawing.Size(112, 20)
        Me.txtMemNo.TabIndex = 19
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(15, 264)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(174, 23)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmAthlete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 327)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAthlete"
        Me.Text = "Athlete"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents rdFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtMembFeeOut As System.Windows.Forms.TextBox
    Friend WithEvents dtPickerDateJoined As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtPickerBirthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNameSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbAthletes As System.Windows.Forms.ListBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtMemNo As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
