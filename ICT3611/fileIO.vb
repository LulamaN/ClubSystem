Imports System.IO

Friend NotInheritable Class fileIO

    Public Shared Sub writeLine(ByVal myFileName As String, ByVal myLine As String, ByVal append As Boolean)
        Dim myFile As System.IO.StreamWriter
        myFile = My.Computer.FileSystem.OpenTextFileWriter(myFileName, append)
        myFile.WriteLine(myLine)
        myFile.Close()


    End Sub




    Public Shared Function readFile(ByVal fileName As String) As ArrayList
        Dim myLine As String
        Dim myFile = New StreamReader(fileName)

        Dim myFileContents As New ArrayList()

        Do
            myLine = myFile.ReadLine()

            If myLine Is Nothing Then
                Exit Do
            Else
                Dim mySplitLine() As String = myLine.Split(",")
                myFileContents.Add(mySplitLine)
            End If

        Loop
        myFile.Close()
        Return myFileContents

    End Function


End Class
