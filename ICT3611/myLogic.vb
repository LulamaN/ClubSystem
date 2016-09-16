Friend NotInheritable Class myLogic

    Public Shared Sub loadEvents(ByRef myEventsList As ArrayList, ByRef lb As ListBox)
        ''Dim myFileContents As New ArrayList()
        myEventsList.Clear()

        Dim myDT As New DataTable



        myDT = fileIO.selectDBData("SELECT * FROM Events")

        'Fill the listbox
        lb.Items.Clear()

        Dim row As DataRow

        For Each row In myDT.Rows
            lb.Items.Add(row.Item(0).ToString())
            Dim myRace As New myEvent

            ''result = myFileContents.Item(i)

            myRace.Distance = row.Item(4)
            myRace.EventDate = row.Item(1)
            myRace.Location = row.Item(3)
            myRace.RegFee = row.Item(2)
            myRace.Title = row.Item(0)
            myEventsList.Add(myRace)

        Next



        'myFileContents = fileIO.readFile("Events.txt")

        'For i As Integer = 0 To myFileContents.Count - 1

        '    Dim result As String()
        '    Dim myRace As New myEvent

        '    result = myFileContents.Item(i)

        '    myRace.Distance = result(0)
        '    myRace.EventDate = result(1)
        '    myRace.Location = result(2)
        '    myRace.RegFee = result(3)
        '    myRace.Title = result(4)
        '    myEventsList.Add(myRace)

        'Next

        ' ''Add events to listbox
        'For Each record As myEvent In myEventsList
        '    lb.Items.Add(record.Title)
        'Next

    End Sub

    Public Shared Sub loadEvents(ByRef myEventsList As ArrayList, ByRef cmb As ComboBox)
        ''Dim myFileContents As New ArrayList()
        myEventsList.Clear()

        Dim myDT As New DataTable

        myDT = fileIO.selectDBData("SELECT * FROM Events")

        'Fill the listbox
        cmb.Items.Clear()

        Dim row As DataRow

        For Each row In myDT.Rows
            cmb.Items.Add(row.Item(0).ToString())
            Dim myRace As New myEvent

            ''result = myFileContents.Item(i)

            myRace.Distance = row.Item(4)
            myRace.EventDate = row.Item(1)
            myRace.Location = row.Item(3)
            myRace.RegFee = row.Item(2)
            myRace.Title = row.Item(0)
            myEventsList.Add(myRace)

        Next
    End Sub

    Public Shared Sub saveEventData(ByRef myEventsList As ArrayList, ByVal isUpdateName As Boolean, ByVal oldEventName As String, ByVal eventName As String, eventDate As Date, regFee As Double, ByVal location As String, ByVal distance As Double)
        Dim isUpdate As Boolean = False
        Dim mySql As String

        If isUpdateName Then
            For Each EventItem As myEvent In myEventsList

                If EventItem.Title = Trim(oldEventName) Then
                    EventItem.Title = eventName
                    EventItem.EventDate = eventDate
                    EventItem.RegFee = regFee
                    EventItem.Location = location
                    EventItem.Distance = distance
                    isUpdate = True
                End If
            Next

            mySql = "UPDATE Events " & _
                   "SET event_title = '" & eventName & "'" & _
                      ",event_date = '" & eventDate.ToShortDateString() & "'" & _
                      ",registration_fee = '" & regFee & "'" & _
                      ",event_location = '" & location & "'" & _
                      ",distance = '" & distance & "'" & _
                 " WHERE event_title = '" & oldEventName & "'"

            fileIO.modifyDBData(mySql)

        End If


        If Not isUpdateName Then
            For Each EventItem As myEvent In myEventsList
                If EventItem.Title = eventName Then
                    EventItem.EventDate = eventDate
                    EventItem.RegFee = regFee
                    EventItem.Location = location
                    EventItem.Distance = distance
                    isUpdate = True
                End If
            Next

            mySql = "UPDATE Events " & _
          "SET " & _
               "event_date = '" & eventDate.ToShortDateString() & "'" & _
               ",registration_fee = '" & regFee & "'" & _
               ",event_location = '" & location & "'" & _
               ",distance = '" & distance & "'" & _
          " WHERE event_title = '" & eventName & "'"

            fileIO.modifyDBData(mySql)

            'MessageBox.Show(mySql)

            'fileIO.writeLine("testsql.txt", mySql, False)

        End If


        If isUpdate = False Then
            Dim newEvent As New myEvent
            newEvent.Title = eventName
            newEvent.EventDate = eventDate
            newEvent.RegFee = regFee
            newEvent.Location = location
            newEvent.Distance = distance

            myEventsList.Add(newEvent)

            mySql = "INSERT INTO Events (event_title, event_date,registration_fee,event_location,distance) " & _
                    "VALUES ('" & eventName & "','" & eventDate.ToShortDateString() & "','" & regFee & "','" & location & "','" & distance & "')"

            fileIO.modifyDBData(mySql)

        End If






    End Sub


    Public Shared Sub saveEventsToFile(ByVal eventsList As ArrayList)

        Dim myDelimString As String

        For i As Integer = 0 To eventsList.Count - 1
            Dim myEvent As New myEvent

            myEvent = eventsList.Item(i)

            myDelimString = myEvent.Distance & "," & myEvent.EventDate & "," & myEvent.Location & "," & myEvent.RegFee & "," & myEvent.Title


            If i = 0 Then
                fileIO.writeLine("Events.txt", myDelimString, False)
            Else
                fileIO.writeLine("Events.txt", myDelimString, True)
            End If

        Next

    End Sub


    Public Shared Sub deleteEvent(ByRef eventsList As ArrayList, ByVal eventName As String)


        For i As Integer = 0 To eventsList.Count - 1
            Dim myEvent As New myEvent
            myEvent = eventsList.Item(i)

            If myEvent.Title = eventName Then
                eventsList.RemoveAt(i)
                Exit For
            End If
        Next

        'Write modified bubble to the file
        'saveEventsToFile(eventsList)

        fileIO.modifyDBData("DELETE FROM Events WHERE event_title = '" & eventName & "'")

    End Sub


    'Ath

    Public Shared Sub loadAthlete(ByRef myAthleteList As ArrayList, ByRef lb As ListBox)
        ' Dim myFileContents As New ArrayList()
        myAthleteList.Clear()

        'myFileContents = fileIO.readFile("Athlete.txt")

        Dim myDT As New DataTable

        myDT = fileIO.selectDBData("SELECT * FROM Athlete")


        Dim row As DataRow

        For Each row In myDT.Rows

            ''Dim result As String()
            Dim myAthlete As New myAthletes

            ''result = myFileContents.Item(i)

            myAthlete.MemNum = row.Item(0)
            myAthlete.NameSurname = row.Item(1)
            myAthlete.BirthDate = row.Item(2)
            myAthlete.Gender = row.Item(3)
            myAthlete.DateJoined = row.Item(4)
            myAthlete.MembFeeOut = row.Item(5)

            myAthleteList.Add(myAthlete)

        Next

        ''Add Athlete to listbox
        For Each record As myAthletes In myAthleteList
            lb.Items.Add(record.MemNum)
        Next
    End Sub

    Public Shared Sub loadAthlete(ByRef myAthleteList As ArrayList, ByRef cmb As ComboBox)
        'Dim myFileContents As New ArrayList()
        myAthleteList.Clear()

        'myFileContents = fileIO.readFile("Athlete.txt")

        Dim myDT As New DataTable

        myDT = fileIO.selectDBData("SELECT * FROM Athlete")


        Dim row As DataRow

        For Each row In myDT.Rows

            ''Dim result As String()
            Dim myAthlete As New myAthletes

            ''result = myFileContents.Item(i)

            myAthlete.MemNum = row.Item(0)
            myAthlete.NameSurname = row.Item(1)
            myAthlete.BirthDate = row.Item(2)
            myAthlete.Gender = row.Item(3)
            myAthlete.DateJoined = row.Item(4)
            myAthlete.MembFeeOut = row.Item(5)

            myAthleteList.Add(myAthlete)

        Next

        ''Add Athlete to listbox
        For Each record As myAthletes In myAthleteList
            cmb.Items.Add(record.MemNum)
        Next

    End Sub

    Public Shared Function getGender(ByRef myFrmAth As frmAthlete) As String
        If myFrmAth.rdFemale.Checked Then
            Return "Female"
        Else
            Return "Male"
        End If
    End Function





    Public Shared Sub loadAthletes(ByRef myFrmAth As frmAthlete)
        myFrmAth.lbAthletes.Items.Clear()
        myLogic.loadAthlete(myFrmAth.myAthletesList, myFrmAth.lbAthletes)


    End Sub

    Public Shared Sub setSelectedAthlete(ByRef myFrmAth As frmAthlete)
        Dim index As Integer = 0

        For Each li As String In myFrmAth.lbAthletes.Items
            If li = myFrmAth.txtMemNo.Text Then
                Exit For
            Else
                index = index + 1
            End If

        Next
        myFrmAth.lbAthletes.SelectedIndex = index
    End Sub

    Public Shared Sub searchAthleteOnPerf(ByRef myFrmAth As frmPerfomance, ByVal membNo As String)
        Dim myIndex As Integer = 0

        For Each myMembNo As String In myFrmAth.cmbAthlete.Items
            If myMembNo = membNo Then
                myFrmAth.cmbAthlete.SelectedIndex = myIndex
                Exit For
            Else
                myIndex = myIndex + 1
            End If
        Next
    End Sub

    Public Shared Sub searchAthleteOnAthlete(ByRef myFrmAth As frmAthlete, ByVal membNo As String)
        Dim myIndex As Integer = 0

        For Each myMembNo As String In myFrmAth.lbAthletes.Items
            If myMembNo = membNo Then
                myFrmAth.lbAthletes.SelectedIndex = myIndex
                Exit For
            Else
                myIndex = myIndex + 1
            End If
        Next
    End Sub

    Public Shared Sub saveAthleteData(ByVal isUpdate As Boolean, ByRef myAthleteList As ArrayList, ByVal MembNo As Double, ByRef NameSur As String, ByRef BirthDate As Date, ByRef Gender As String, ByRef DateJoined As Date, ByRef MemFeeOut As Double)
        '' Dim isUpdate As Boolean = False
        Dim mySql

        If isUpdate Then
            For Each AthItem As myAthletes In myAthleteList
                If MembNo = AthItem.MemNum Then
                    AthItem.NameSurname = NameSur
                    AthItem.BirthDate = BirthDate
                    AthItem.Gender = Gender
                    AthItem.DateJoined = DateJoined
                    AthItem.MembFeeOut = MemFeeOut
                End If

     
            Next

            mySql = "UPDATE Athlete " & _
                 " SET name_surname = '" & NameSur & "'" & _
                 ",birth_date = '" & BirthDate.ToShortDateString() & "'" & _
                 ",gender = '" & Gender & "'" & _
                 ",date_joined = '" & DateJoined.ToShortDateString() & "'" & _
                 ",fee_outstanding = '" & MemFeeOut & "'" & _
                 " WHERE membership_number = '" & MembNo & "'"
            fileIO.modifyDBData(mySql)

        Else
            Dim AthItem As New myAthletes
            AthItem.MemNum = MembNo
            AthItem.NameSurname = NameSur
            AthItem.BirthDate = BirthDate
            AthItem.Gender = Gender
            AthItem.DateJoined = DateJoined
            AthItem.MembFeeOut = MemFeeOut

            myAthleteList.Add(AthItem)

            mySql = "INSERT INTO Athlete (membership_number,name_surname,birth_date,gender,date_joined,fee_outstanding)" & _
             " VALUES ('" & MembNo & "','" & NameSur & "','" & BirthDate.ToShortDateString() & "','" & Gender & "','" & DateJoined.ToShortDateString() & "','" & MemFeeOut & "')"
            fileIO.modifyDBData(mySql)
        End If





    End Sub

    Public Shared Sub saveAthleteToFile(ByVal AthleteList As ArrayList)

        Dim myDelimString As String

        For i As Integer = 0 To AthleteList.Count - 1
            Dim myAthlete As New myAthletes

            myAthlete = AthleteList.Item(i)

            myDelimString = myAthlete.MemNum & "," & myAthlete.NameSurname & "," & myAthlete.BirthDate & "," & myAthlete.Gender & "," & myAthlete.DateJoined & "," & myAthlete.MembFeeOut



            If i = 0 Then
                fileIO.writeLine("Athlete.txt", myDelimString, False)
            Else
                fileIO.writeLine("Athlete.txt", myDelimString, True)
            End If

        Next

    End Sub

    Public Shared Sub deleteAthlete(ByRef AthletesList As ArrayList, ByVal MemNum As String)


        For i As Integer = 0 To AthletesList.Count - 1
            Dim myAthlete As New myAthletes
            myAthlete = AthletesList.Item(i)

            If myAthlete.MemNum = MemNum Then
                AthletesList.RemoveAt(i)
                Exit For
            End If
        Next

        saveAthleteToFile(AthletesList)

    End Sub

    Public Shared Sub selectAthlete(ByRef myFrmAth As frmAthlete)
        Dim selectedMembNo As String
        selectedMembNo = myFrmAth.lbAthletes.Text

        For Each AthItem As myAthletes In myFrmAth.myAthletesList
            If selectedMembNo = AthItem.MemNum Then
                myFrmAth.txtMemNo.Text = AthItem.MemNum
                myFrmAth.txtNameSurname.Text = AthItem.NameSurname
                myFrmAth.dtPickerBirthDate.Value = AthItem.BirthDate

                If myLogic.getGender(myFrmAth) = "Female" Then
                    myFrmAth.rdFemale.Checked = True
                Else
                    myFrmAth.rdMale.Checked = True
                End If

                myFrmAth.dtPickerDateJoined.Value = AthItem.DateJoined
                myFrmAth.txtMembFeeOut.Text = AthItem.MembFeeOut

            End If
        Next
    End Sub

    Public Shared Sub loadResults(ByVal membNo As Double, ByRef myResultsList As ArrayList, ByRef lb As ListBox)
        Try

    
        myResultsList.Clear()
        lb.Items.Clear()

        Dim myRes As myPerfResults = Nothing
        Dim myDT As New DataTable
        Dim mySql

        mySql = "SELECT membership_number,event,result FROM raceresults;"

        myDT = fileIO.selectDBData(mySql)


        Dim row As DataRow

        For Each row In myDT.Rows

            myRes = New myPerfResults

            myRes.MembershipNo = row.Item(0)
            myRes.eventID = row.Item(1)
            myRes.FinishTime = row.Item(2)

            myResultsList.Add(myRes)

            If membNo = row.Item(0) Then
                lb.Items.Add(myRes.MembershipNo & "," & myRes.eventID & "," & myRes.FinishTime)
            End If

        Next

        Catch ex As Exception
            MessageBox.Show("No data found! (" & ex.Message.ToString() & ")")
        End Try



    End Sub


    Public Shared Sub saveRaceResultsData(ByRef myRaceResultsList As ArrayList, membNo As Double, ByVal eventID As String, ByVal result As String)

        Dim mySql
        Dim newRaceResult As New myPerfResults
        newRaceResult.MembershipNo = membNo
        newRaceResult.eventID = eventID
        newRaceResult.FinishTime = result
        

        myRaceResultsList.Add(newRaceResult)


        mySql = "INSERT INTO RaceResults (membership_number,event,result) " & _
                "VALUES ('" & membNo & "','" & eventID & "','" & result & "')"

        fileIO.modifyDBData(mySql)

    End Sub


    Public Shared Sub saveRaceResultsToFile(ByVal resultsList As ArrayList)

        Dim myDelimString As String

        For i As Integer = 0 To resultsList.Count - 1
            Dim myResult As New myPerfResults

            myResult = resultsList.Item(i)

            myDelimString = myResult.MembershipNo & "," & myResult.eventID & "," & myResult.FinishTime


            If i = 0 Then
                fileIO.writeLine("RaceResults.txt", myDelimString, False)
            Else
                fileIO.writeLine("RaceResults.txt", myDelimString, True)
            End If

        Next

    End Sub



    Public Shared Function myRandom(ByVal lower As Integer, ByVal upper As Integer) As String


        Dim resultInt As Integer
        Dim resultStr As String

        Randomize()

        'Random number between 1 and 999.

        resultInt = CInt(Int((upper * Rnd()) + lower))

        resultStr = Microsoft.VisualBasic.Right("000" & CStr(resultInt), 3)

        Return resultStr


    End Function


    Public Shared Function genCheckDigit(ByVal number As String) As String

        Dim myCheckDigit As String

        Dim sum As Integer = 0

        Dim myModVal As Integer



        For i As Integer = 1 To number.Length()

            sum = sum + Microsoft.VisualBasic.Val(GetChar(number, i))

        Next


        myModVal = sum Mod 10


        If myModVal = 0 Then

            myCheckDigit = 0

        Else

            myCheckDigit = 10 - myModVal

        End If

        Return myCheckDigit

    End Function


    Public Shared Function genNewMemNo(ByVal birthDate As Date) As String

        Dim myMemNo As String

        Dim currYear As String

        Dim memBirthDate As String

        Dim myRandomNo As String



        currYear = Microsoft.VisualBasic.Right(Year(Now()), 2)

        memBirthDate = Year(birthDate) & Microsoft.VisualBasic.Right("0" & Month(birthDate), 2) & Microsoft.VisualBasic.Right("0" & Microsoft.VisualBasic.DateAndTime.Day(birthDate), 2)

        myRandomNo = myRandom(0, 999)

        myMemNo = currYear & memBirthDate & myRandomNo & genCheckDigit(currYear & memBirthDate & myRandomNo)

        Return myMemNo

    End Function

    Public Shared Function isValidMembNo(ByVal number As String)

        Dim isValid As Boolean = False
        Dim checkDigit As Integer
        Dim myCheckDigit As String
        Dim sum As Integer = 0
        Dim myModVal As Integer

        If number.Length <> 14 Then

            isValid = False

            Return isValid

        Else
            checkDigit = Microsoft.VisualBasic.Right(number, 1)

            For i As Integer = 1 To number.Length() - 1

                sum = sum + Microsoft.VisualBasic.Val(GetChar(number, i))

            Next

            myModVal = sum Mod 10

            If myModVal = 0 Then


                If myModVal = checkDigit Then

                    isValid = True

                End If

            Else

                myCheckDigit = 10 - myModVal

                If myCheckDigit = checkDigit Then

                    isValid = True

                End If

            End If

        End If

        Return isValid

    End Function


    ''Error Checking PerfResults
    Public Shared Function errorsExistEvents(ByRef myEvFrm As frmEvent, ByVal type As String) As Boolean
        If type = "Update" Then

            If myEvFrm.txtEventTitle.Text.Trim() = "" Then
                MessageBox.Show("Please fill in an Event Name")
                Return True
            End If
            '
            '

            If myEvFrm.txtRegFee.Text.Trim() = "" Then
                MessageBox.Show("Please fill in the Registration Fee")
                Return True
            End If

            Dim myDouble As Double

            If Double.TryParse(myEvFrm.txtRegFee.Text, myDouble) Then
            Else
                MessageBox.Show("Registration Fee is not a valid number")
                Return True
            End If


            If myEvFrm.txtLocation.Text.Trim() = "" Then
                MessageBox.Show("Please fill in Location")
                Return True
            End If
            If myEvFrm.txtDistance.Text.Trim() = "" Then
                MessageBox.Show("Please fill in a valid distance")
                Return True
            End If

        End If

        If type = "Update Title" Then
            'check the title

            If myEvFrm.txtEventTitle.Text.Trim() = "" Then
                MessageBox.Show("Please fill in a valid event title")
                Return True
            End If
        End If

        If type = "Delete" Then
            'check if there is a selected event
            If myEvFrm.lbEvents.SelectedIndex = -1 Then
                MessageBox.Show("Please select an event to delete")
                Return True
            End If
        End If
        Return False
    End Function

    ''Error Checking PerfResults
    Public Shared Function errorsExistEvents(ByRef myRRF As frmPerfomance, ByVal type As String) As Boolean

        If type = "Add" Then
            If myRRF.cmbAthlete.Text.Trim() = "" Then
                MessageBox.Show("Please select an athlete")
                Return True
            End If

            If myRRF.cmbEvent.Text.Trim() = "" Then

                MessageBox.Show("Please choose an event")
                Return True
            End If

            If myRRF.txtResult.Text.Trim() = "" Then
                MessageBox.Show("Please fill in results ")
                Return True

            End If

            Dim myDouble As Double

            If Double.TryParse(myRRF.txtResult.Text, myDouble) Then

            Else

                MessageBox.Show("Please fill in a results")
                Return True
            End If

         

        End If


        If type = "Search" Then

            If myRRF.txtMemNo.Text.Trim() = "" Then
                MessageBox.Show("Please fill in a membership number")
                Return True
            End If

            If myLogic.isValidMembNo(myRRF.txtMemNo.Text) Then

            Else
                MessageBox.Show("Please fill in a valid membership number")
                Return True
            End If

        End If

        Return False
    End Function

    ''Error Checking Athletes
    Public Shared Function errorsExistAthlete(ByRef myRRF As frmAthlete) As Boolean
        If myRRF.txtNameSurname.Text.Trim() = "" Then
            MessageBox.Show("Please fill in a valid name and surname")
            Return True
        End If

        Dim myTestName As Double
        If Double.TryParse(myRRF.txtNameSurname.Text, myTestName) Then
            MessageBox.Show("Please enter a valid name/surname")
            Return True
        End If

        If myRRF.rdFemale.Checked Or myRRF.rdMale.Checked Then
            'Then ok
        Else
            MessageBox.Show("Please select a gender")
            Return True
        End If


        If myRRF.txtMembFeeOut.Text.Trim() = "" Then
            MessageBox.Show("Please fill in the membership fee outstanding")
            Return True
        End If

        Dim myDouble As Double

        If Double.TryParse(myRRF.txtMembFeeOut.Text, myDouble) Then
        Else
            MessageBox.Show("Membership fee outstanding is not a valid number")
            Return True
        End If


        If DateDiff(DateInterval.Year, myRRF.dtPickerBirthDate.Value, myRRF.dtPickerDateJoined.Value) < 16 Then
            MessageBox.Show("Athlete must be 16 or older")
            Return True
        End If
        Return False
    End Function


    ''Event form methods

    Public Shared Sub updateEvents(ByRef myFrmEvents As frmEvent, ByVal isUpdateName As Boolean, ByVal oldEventName As String)
        myLogic.saveEventData(myFrmEvents.myEventsList, isUpdateName, oldEventName, myFrmEvents.txtEventTitle.Text, myFrmEvents.dtPicker.Value, myFrmEvents.txtRegFee.Text, myFrmEvents.txtLocation.Text, myFrmEvents.txtDistance.Text)
        'myLogic.saveEventsToFile(myFrmEvents.myEventsList)
        myLogic.loadEvents(myFrmEvents)
    End Sub

    Public Shared Sub saveEvents(ByRef myFrmEvents As frmEvent)
        myFrmEvents.btnUpdateEvent.Show()
    End Sub

    Public Shared Sub selectEvents(ByRef myFrmEvents As frmEvent)
        Dim selectedEvent As String
        selectedEvent = myFrmEvents.lbEvents.Text

        For Each EventItem As myEvent In myFrmEvents.myEventsList
            If selectedEvent = EventItem.Title Then
                myFrmEvents.txtEventTitle.Text = myFrmEvents.lbEvents.Text
                myFrmEvents.dtPicker.Text = EventItem.EventDate
                myFrmEvents.txtRegFee.Text = EventItem.RegFee
                myFrmEvents.txtLocation.Text = EventItem.Location
                myFrmEvents.txtDistance.Text = EventItem.Distance
            End If
        Next
    End Sub

    Public Shared Sub loadEvents(ByRef myFrmEvents As frmEvent)
        myFrmEvents.lbEvents.Items.Clear()
        myLogic.loadEvents(myFrmEvents.myEventsList, myFrmEvents.lbEvents)


    End Sub

    Public Shared Sub setSelectedEvent(ByRef myFrmEvents As frmEvent)
        Dim index As Integer = 0

        For Each li As String In myFrmEvents.lbEvents.Items
            If li = myFrmEvents.txtEventTitle.Text Then
                Exit For
            Else
                index = index + 1
            End If

        Next
        myFrmEvents.lbEvents.SelectedIndex = index
    End Sub

    Public Shared Sub clearForm(ByRef myFrmEvents As frmEvent)
        myFrmEvents.txtEventTitle.Text = ""
        myFrmEvents.txtRegFee.Text = ""
        myFrmEvents.txtLocation.Text = ""
        myFrmEvents.txtDistance.Text = ""
    End Sub


    Public Shared Function getAthleteRecordsCount(ByVal membNo As String) As Integer
        Dim mySQL As String
        Dim myCount As Integer
        Dim myDT As New DataTable

        mySQL = "SELECT count(membership_number) as recCount from raceresults WHERE membership_number = '" & membNo & "'"

        myDT = fileIO.selectDBData(mySQL)

        myCount = CInt(myDT.Rows(0).Item(0))


        Return myCount


    End Function

    Public Shared Sub deleteAthlete(ByVal membNo As String)
        Dim mySQL As String

        mySQL = "DELETE FROM Athlete WHERE membership_number = '" & membNo & "'"

        fileIO.modifyDBData(mySQL)


    End Sub


End Class
