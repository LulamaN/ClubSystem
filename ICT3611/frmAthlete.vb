Public Class frmAthlete
    Public myAthletesList As New ArrayList()
    Public isUpdate As Boolean = True

    Private Sub frmAthlete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myLogic.loadAthletes(Me)
    End Sub

    Private Sub frmAthlete_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()

        Return
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbAthletes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAthletes.SelectedIndexChanged
        setFormControls(True)

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
        'myLogic.saveAthleteToFile(myAthletesList)

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

        setFormControls(True)

        isUpdate = False

        txtMemNo.Visible = False

        txtMemNo.Text = ""
        txtNameSurname.Text = ""
        txtMembFeeOut.Text = ""
        btnNew.Visible = False
        btnUpdate.Enabled = True
        btnUpdate.Text = "Save"
    End Sub

    Public Sub setFormControls(ByVal enabled As Boolean)

        If enabled Then
            txtNameSurname.Enabled = True
            dtPickerBirthDate.Enabled = True
            rdFemale.Enabled = True
            rdMale.Enabled = True
            dtPickerDateJoined.Enabled = True
            txtMembFeeOut.Enabled = True

        Else
            txtNameSurname.Enabled = False
            dtPickerBirthDate.Enabled = False
            rdFemale.Enabled = False
            rdMale.Enabled = False
            dtPickerDateJoined.Enabled = False
            txtMembFeeOut.Enabled = False
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If myLogic.getAthleteRecordsCount(txtMemNo.Text) = 0 Then
            'delete the athlete
            myLogic.deleteAthlete(txtMemNo.Text)
            myLogic.loadAthletes(Me)

            txtNameSurname.Text = ""
            txtMembFeeOut.Text = ""
            setFormControls(False)
            btnUpdate.Enabled = False

        Else
            'you can't delete

            Try

                Throw New System.Exception("Athlete has results captured, you cannot delete this record!")
            

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

      

        End If
    End Sub
End Class