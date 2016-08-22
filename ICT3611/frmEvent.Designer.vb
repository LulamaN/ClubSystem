<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvent
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
        Me.txtEventTitle = New System.Windows.Forms.TextBox()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.txtRegFee = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.dtPicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdateEvent = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnUpdateTitle = New System.Windows.Forms.Button()
        Me.lbEvents = New System.Windows.Forms.ListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.l = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEventTitle
        '
        Me.txtEventTitle.Enabled = False
        Me.txtEventTitle.Location = New System.Drawing.Point(170, 94)
        Me.txtEventTitle.Name = "txtEventTitle"
        Me.txtEventTitle.Size = New System.Drawing.Size(201, 20)
        Me.txtEventTitle.TabIndex = 0
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(170, 338)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(201, 20)
        Me.txtDistance.TabIndex = 1
        '
        'txtRegFee
        '
        Me.txtRegFee.Location = New System.Drawing.Point(170, 236)
        Me.txtRegFee.Name = "txtRegFee"
        Me.txtRegFee.Size = New System.Drawing.Size(201, 20)
        Me.txtRegFee.TabIndex = 2
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(170, 288)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(201, 20)
        Me.txtLocation.TabIndex = 3
        '
        'dtPicker
        '
        Me.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPicker.Location = New System.Drawing.Point(171, 180)
        Me.dtPicker.Name = "dtPicker"
        Me.dtPicker.Size = New System.Drawing.Size(200, 20)
        Me.dtPicker.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Event Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Event Date "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Registration Fee"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Event Location"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Distance"
        '
        'btnUpdateEvent
        '
        Me.btnUpdateEvent.Enabled = False
        Me.btnUpdateEvent.Location = New System.Drawing.Point(169, 393)
        Me.btnUpdateEvent.Name = "btnUpdateEvent"
        Me.btnUpdateEvent.Size = New System.Drawing.Size(75, 30)
        Me.btnUpdateEvent.TabIndex = 10
        Me.btnUpdateEvent.Text = "Update"
        Me.btnUpdateEvent.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(308, 393)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 30)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnUpdateTitle
        '
        Me.btnUpdateTitle.Enabled = False
        Me.btnUpdateTitle.Location = New System.Drawing.Point(296, 123)
        Me.btnUpdateTitle.Name = "btnUpdateTitle"
        Me.btnUpdateTitle.Size = New System.Drawing.Size(75, 30)
        Me.btnUpdateTitle.TabIndex = 12
        Me.btnUpdateTitle.Text = "Update Title"
        Me.btnUpdateTitle.UseVisualStyleBackColor = True
        '
        'lbEvents
        '
        Me.lbEvents.FormattingEnabled = True
        Me.lbEvents.Location = New System.Drawing.Point(502, 94)
        Me.lbEvents.Name = "lbEvents"
        Me.lbEvents.Size = New System.Drawing.Size(218, 264)
        Me.lbEvents.TabIndex = 13
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(502, 393)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(218, 30)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'l
        '
        Me.l.AutoSize = True
        Me.l.Location = New System.Drawing.Point(572, 75)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(66, 13)
        Me.l.TabIndex = 15
        Me.l.Text = "Event Name"
        '
        'frmEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 543)
        Me.Controls.Add(Me.l)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lbEvents)
        Me.Controls.Add(Me.btnUpdateTitle)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnUpdateEvent)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtPicker)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtRegFee)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.txtEventTitle)
        Me.Name = "frmEvent"
        Me.Text = "Event"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEventTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtDistance As System.Windows.Forms.TextBox
    Friend WithEvents txtRegFee As System.Windows.Forms.TextBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents dtPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateEvent As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnUpdateTitle As System.Windows.Forms.Button
    Friend WithEvents lbEvents As System.Windows.Forms.ListBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents l As System.Windows.Forms.Label
End Class
