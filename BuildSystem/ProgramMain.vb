Imports System.IO

Module ProgramMain
    Dim RelDebug As String = "1"
    Dim MSBuildPath As String = "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin"
    Dim MSBuildYN As String = "N"
    Dim ProjectDirectory As String
    Sub Main()
        Console.WriteLine("Do you want to change the MSBuild path? (y/n)(Default is N)")
        MSBuildYN = Console.ReadLine()
        If MSBuildYN = "N" Then
            Console.WriteLine("Continuing with Default Path")
        ElseIf MSBuildYN = "n" Then
            Console.WriteLine("Continuing with Default Path")
        ElseIf MSBuildYN = "Y" Then
            Call ChangeMSBuildPath()
        ElseIf MSBuildYN = "y" Then
        Else
            Console.WriteLine("Continuing with Default Path")
        End If
        Call SetProjectDirectory()
        Console.WriteLine("This build is a Release or Debug ?")
        Console.WriteLine("Default is Debug")
        Console.WriteLine("")
        Console.WriteLine("1 - Debug")
        Console.WriteLine("2 - Release")
        RelDebug = Console.ReadLine()
        If RelDebug = "1" Then
            Call BuildDebug(MSBuildPath)
        ElseIf RelDebug = "2" Then
            Call BuildRelease(MSBuildPath)
        Else
            Call BuildDebug(MSBuildPath)
        End If
    End Sub

    Public Sub BuildDebug(ByVal PathMSBuild As String)
        Console.WriteLine("Building Debug")
        Try
            If Directory.Exists(ProjectDirectory + "\Build") Then
                Directory.Delete(ProjectDirectory + "\Build", True)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub BuildRelease(ByVal PathMSBuild As String)
        Console.WriteLine("Building Release")
    End Sub

    Public Sub ChangeMSBuildPath()
        Console.WriteLine("Enter the Path to MSBuild")
        MSBuildPath = Console.ReadLine()
        Console.WriteLine("Continuing with Path: " + MSBuildPath)
    End Sub

    Public Sub SetProjectDirectory()
        Dim X As Integer = 0
        While X = 1
            Console.WriteLine("Where are the project files?")
            ProjectDirectory = Console.ReadLine()
            If ProjectDirectory = "" Then
                Console.WriteLine("Please Select a Path")
            Else
                Console.WriteLine("Continuing with " + ProjectDirectory)
                X = 1
            End If
        End While



    End Sub
End Module
