Public Class myAthletes

    Private myMemNum As Double
    Private myNameSurname As String
    Private myBirthDate As Date
    Private myGender As String
    Private myDateJoined As Date
    Private myMembFeeOut As Double

    Private myPerfResults = New myPerfResults
    Private myPerfResultList = New ArrayList()

    Property MemNum As Double
        Get
            Return myMemNum

        End Get

        Set(value As Double)
            myMemNum = value
        End Set

    End Property



    Property NameSurname As String
        Get
            Return myNameSurname

        End Get

        Set(value As String)
            myNameSurname = value
        End Set

    End Property

    Property BirthDate As Date
        Get
            Return myBirthDate

        End Get

        Set(value As Date)
            myBirthDate = value
        End Set

    End Property

    Property Gender As String
        Get
            Return myGender

        End Get

        Set(value As String)
            myGender = value
        End Set

    End Property


    Property DateJoined As Date
        Get
            Return myDateJoined

        End Get

        Set(value As Date)
            myDateJoined = value
        End Set

    End Property



    Property MembFeeOut As Double
        Get
            Return myMembFeeOut

        End Get

        Set(value As Double)
            myMembFeeOut = value
        End Set
    End Property



    Public Sub addRaceResult(ByVal eventID As String, ByVal membNo As Double, ByVal finishTime As Integer)

        Dim myPerfResult As New myPerfResults

        myPerfResults.eventID = eventID
        myPerfResults.MembershipNo = membNo
        myPerfResults.FinishTime = finishTime

        myPerfResults.Add(myPerfResult)


    End Sub




End Class
