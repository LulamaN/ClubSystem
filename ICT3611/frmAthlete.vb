Public Class frmAthlete
    Public myAthletesList As New ArrayList()
    Public isUpdate As Boolean = True

    Private Sub frmAthlete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myLogic.loadAthletes(Me)
    End Sub

    Private Sub frmAthlete_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
        MessageBox.Show("Enter membership number or select from the list")
        Return
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbAthletes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAthletes.SelectedIndexChanged
        myLogic.selectAthlete(Me)
        btnUpdate.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        Dim myNewMembNo As String

        If myLogic.errorsExistAthlete(Me) Then
            Return
        End If

        If isUpdate = False Then
            myNewMembNo = myLogic.genNewMemNo(dtPickerBirthDate.Value)
            txtMemNo.Text = myNewMembNo
        End If

        myLogic.saveAthleteData(isUpdate, myAthletesList, CType(txtMemNo.Text, Double), txtNameSurname.Text, dtPickerBirthDate.Value, myLogic.getGender(Me), dtPickerDateJoined.Value, CType(txtMembFeeOut.Text, Double))
        myLogic.saveAthleteToFile(myAthletesList)

        myLogic.loadAthletes(Me)
        myLogic.setSelectedAthlete(Me)

        txtMemNo.Visible = True
        btnUpdate.Text = "Update"
        isUpdate = True
        btnNew.Visible = True

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        myLogic.searchAthleteOnAthlete(Me, txtMemNo.Text)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        isUpdate = False

        txtMemNo.Visible = False

        txtMemNo.Text = ""
        txtNameSurname.Text = ""
        txtMembFeeOut.Text = ""
        btnNew.Visible = False
        btnUpdate.Enabled = True
        btnUpdate.Text = "Save"


    End Sub
End Class