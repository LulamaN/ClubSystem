Public Class frmPerfomance

    Private myAthletesList As New ArrayList()
    Private myResultsList As New ArrayList()
    Private myEventsList As New ArrayList()

    Private Sub frmPerfomance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub frmPerfomance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myLogic.loadAthlete(myAthletesList, cmbAthlete)
        myLogic.loadEvents(myEventsList, cmbEvent)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If myLogic.errorsExistEvents(Me, "Search") Then
            Return
        End If
        myLogic.searchAthleteOnPerf(Me, txtMemNo.Text)
    End Sub

    Private Sub cmbAthlete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAthlete.SelectedIndexChanged
        myLogic.loadResults(cmbAthlete.Text, myResultsList, lbResults)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If myLogic.errorsExistEvents(Me, "Add") Then
            Return
        End If

        myLogic.saveRaceResultsData(myResultsList, cmbAthlete.Text, cmbEvent.Text, txtResult.Text)
        myLogic.saveRaceResultsToFile(myResultsList)
        myLogic.loadResults(cmbAthlete.Text, myResultsList, lbResults)
    End Sub
End Class