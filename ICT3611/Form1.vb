Public Class Form1

    Public fAth1 = New frmAthlete()
    Public fEvent1 = New frmEvent()
    Public fPerfomance1 = New frmPerfomance()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        fAth1.MdiParent = Me
        fEvent1.MdiParent = Me
        fPerfomance1.mdiParent = Me


        '''''''''''''''''''''''''''''
        'Create instance of the class




        Dim mySportsPerson1 As New myAthletes

        mySportsPerson1.MemNum = 567890
        mySportsPerson1.NameSurname = "Athi Ntsingila"
        mySportsPerson1.BirthDate = "1995 /09/10"
        mySportsPerson1.Gender = "Male"
        mySportsPerson1.DateJoined = "2006 /09/10"
        mySportsPerson1.MembFeeOut = 567890

        Dim mySportsPerson2 As New myAthletes

        mySportsPerson1.MemNum = 567890
        mySportsPerson1.NameSurname = "Aviwe Ntsingila"
        mySportsPerson1.BirthDate = "2006/09/10"
        mySportsPerson1.Gender = "Female"
        mySportsPerson1.DateJoined = "1996/09/10"
        mySportsPerson1.MembFeeOut = 567890



        'Get values from the class
        'MessageBox.Show(myRace2.Title & " " & myRace2.EventDate)


        ''Dim myFileIO As New fileIO
        ''myFileIO.writeLine("Events.txt", myRace2.Title & "," & myRace2.Location)



        '''''''''''''''''''''''''''

    End Sub






    Private Sub AthleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AthleteToolStripMenuItem.Click
        fAth1.show()

    End Sub

    Private Sub EventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventToolStripMenuItem.Click
        fEvent1.show()
    End Sub

    Private Sub PerformanceResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerformanceResultsToolStripMenuItem.Click
        fPerfomance1.show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub
End Class
