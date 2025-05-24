' 
'   LukeOS BuildSystem
'   Program to create a usable LukeOS Root Filesystem
'
Imports System.IO

Module ProgramMain
    Dim RelDebug As String = "1"
    Dim ProjectDirectory As String
    Sub Main()

        Call SetProjectDirectory()
        Console.WriteLine("This build is a Release or Debug ?")
        Console.WriteLine("Default is Debug")
        Console.WriteLine("")
        Console.WriteLine("1 - Debug")
        Console.WriteLine("2 - Release")
        Console.Write(": ")
        RelDebug = Console.ReadLine()
        If RelDebug = "1" Then
            Call BuildDebug()
        ElseIf RelDebug = "2" Then
            Call BuildRelease()
        Else
            Call BuildDebug()
        End If
    End Sub

    Public Sub BuildDebug()
        Console.WriteLine("Building Debug")
        Try
            If Directory.Exists(ProjectDirectory + "\Build") Then
                Directory.Delete(ProjectDirectory + "\Build", True)
            Else
                Console.WriteLine("No Other Build Detected!")
            End If
            Directory.CreateDirectory(ProjectDirectory + "\Build")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Debug")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Debug\System")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Debug\System\Boot")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Debug\System\Boot\Drivers")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Debug\Apps")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Debug\User")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Debug\Temp")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Debug\Apps\File Manager")
            File.Copy(ProjectDirectory + "\BootManager\bin\Debug\BootManager.exe", ProjectDirectory + "\Build\Debug\System\Boot\BootManager.exe")
            File.Copy(ProjectDirectory + "\SystemDesktop\bin\Debug\SystemDesktop.exe", ProjectDirectory + "\Build\Debug\System\SystemDesktop.exe")
            File.Copy(ProjectDirectory + "\File Manager\bin\Debug\File Manager.exe", ProjectDirectory + "\Build\Debug\Apps\File Manager\File Manager.exe")

            Console.WriteLine("Build Success!")
            Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine("Error on Build LukeOS: " + ex.Message)
            Console.WriteLine("Try Build Solution in Visual Studio")
            Console.ReadLine()
        End Try

    End Sub

    Public Sub BuildRelease()
        Console.WriteLine("Building Release")
        Try
            If Directory.Exists(ProjectDirectory + "\Build") Then
                Directory.Delete(ProjectDirectory + "\Build", True)
            Else
                Console.WriteLine("No Other Build Detected!")
            End If
            Directory.CreateDirectory(ProjectDirectory + "\Build")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Release")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Release\System")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Release\System\Boot")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Release\System\Boot\Drivers")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Release\Apps")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Release\User")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Release\Temp")
            Directory.CreateDirectory(ProjectDirectory + "\Build\Release\Apps\File Manager")
            File.Copy(ProjectDirectory + "\BootManager\bin\Release\BootManager.exe", ProjectDirectory + "\Build\Release\System\Boot\BootManager.exe")
            File.Copy(ProjectDirectory + "\SystemDesktop\bin\Release\SystemDesktop.exe", ProjectDirectory + "\Build\Release\System\SystemDesktop.exe")
            File.Copy(ProjectDirectory + "\File Manager\bin\Release\File Manager.exe", ProjectDirectory + "\Build\Release\Apps\File Manager\File Manager.exe")
            Console.WriteLine("Build Success!")
            Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine("Error on build LukeOS: " + ex.Message)
            Console.WriteLine("Try Build Solution in Visual Studio")
            Console.ReadLine()
        End Try
    End Sub

    Public Sub SetProjectDirectory()
        Dim X As Integer = 1
        While X = 1
            Console.WriteLine("Where are the project files?")
            Console.Write(": ")
            ProjectDirectory = Console.ReadLine()
            If ProjectDirectory = "" Then
                Console.WriteLine("Please Select a Path")
            Else
                Console.WriteLine("Continuing with " + ProjectDirectory)
                X = 0
            End If
        End While
    End Sub
End Module
