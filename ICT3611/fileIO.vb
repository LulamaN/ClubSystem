Imports System.IO
Imports System.Data.OleDb

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

    ''Database methods

    ''Select data from Access Table
    Public Shared Function selectDBData(ByVal query As String) As DataTable
        Dim t1 As DataTable = Nothing

        Try

            Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\Documents\clubsystem.mdb")

            con.Open()

            Dim cmd As New OleDbCommand(query, con)
            Dim da As New OleDbDataAdapter(cmd)

            Dim ds As New DataSet

            da.Fill(ds)
            con.Close()

            t1 = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try

        Return t1

    End Function

    ''Modify data in Access Table
    Public Shared Sub modifyDBData(ByVal query As String)

        Try
            Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\Documents\clubsystem.mdb")
            Dim cmd As New OleDbCommand(query, con)
            con.Open()

            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try


    End Sub


End Class
