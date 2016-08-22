Public Class frmEvent
    Public myEventsList As New ArrayList()

    Private Sub frmEvent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtEventTitle.Enabled = True
        myLogic.clearForm(Me)
        btnNew.Visible = False
        btnUpdateEvent.Text = "Save"
        btnUpdateEvent.Enabled = True
    End Sub

    Private Sub btnUpdateEvent_Click(sender As Object, e As EventArgs) Handles btnUpdateEvent.Click
        If myLogic.errorsExistEvents(Me, "Update") Then
            Return
        End If

        txtEventTitle.Enabled = False

        myLogic.updateEvents(Me, False, "")
        myLogic.setSelectedEvent(Me)
        btnUpdateEvent.Text = "Update"
        btnNew.Visible = True
    End Sub

    Private Sub frmEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myLogic.loadEvents(Me)
    End Sub

    Private Sub lbEvents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbEvents.SelectedIndexChanged
        myLogic.selectEvents(Me)
        btnDelete.Enabled = True
        btnUpdateTitle.Text = "Update Title"
        btnUpdateTitle.Enabled = True
        btnUpdateEvent.Enabled = True
        txtEventTitle.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If myLogic.errorsExistEvents(Me, "Delete") Then
            Return
        End If

        myLogic.deleteEvent(myEventsList, lbEvents.Text)
        myLogic.loadEvents(Me)
        myLogic.clearForm(Me)
    End Sub

    Private Sub btnUpdateTitle_Click(sender As Object, e As EventArgs) Handles btnUpdateTitle.Click

        txtEventTitle.Enabled = True

        If myLogic.errorsExistEvents(Me, "Update Title") Then
            Return
        End If

        If btnUpdateTitle.Text = "Save" Then
            myLogic.updateEvents(Me, True, lbEvents.Text)
            myLogic.setSelectedEvent(Me)
            btnUpdateTitle.Text = "Update Title"
            txtEventTitle.Enabled = False
            Return

        End If

        btnUpdateTitle.Text = "Save"

    End Sub



End Class