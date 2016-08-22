Public Class myEvent

    Private myTitle As String
    Private myDate As Date
    Private myRegFee As Double
    Private myLocation As String
    Private myDistance As Double

    Property Title As String
        Get
            Return myTitle

        End Get

        Set(value As String)
            myTitle = value
        End Set

    End Property

    Property EventDate As String
        Get
            Return myDate

        End Get

        Set(value As String)
            myDate = value
        End Set

    End Property


  
    Property RegFee As Double
        Get
            Return myRegFee

        End Get

        Set(value As Double)
            myRegFee = value
        End Set

    End Property


    Property Location As String
        Get
            Return myLocation

        End Get

        Set(value As String)
            myLocation = value
        End Set

    End Property


    Property Distance As Double
        Get
            Return myDistance

        End Get

        Set(value As Double)
            myDistance = value
        End Set

    End Property

    Public Function isOver100() As String
        If myRegFee > 100 Then
            Return "Yes it is"
        Else
            Return "No it is not"
        End If
    End Function


   

    
End Class
