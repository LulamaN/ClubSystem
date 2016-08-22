Public Class myPerfResults

        Private myEventID As String
        Private myMembershipNo As Double
        Private myFinishTime As Integer

        Property eventID As String
            Get
                Return myEventID
            End Get

            Set(value As String)
                myEventID = value
            End Set
        End Property

        Property MembershipNo As Double
            Get
                Return myMembershipNo
            End Get

            Set(value As Double)
                myMembershipNo = value
            End Set
        End Property

        Property FinishTime As Integer
            Get
                Return myFinishTime
            End Get

            Set(value As Integer)
                myFinishTime = value
            End Set
        End Property



End Class
